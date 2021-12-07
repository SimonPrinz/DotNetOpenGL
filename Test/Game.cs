using System;
using static GLFW;
using static Test.GLTest;

namespace Test
{
	public class Game : IDisposable
	{
		private const int OPENGL_CORE_PROFILE = 0x32001;
		private static readonly IntPtr NULL = IntPtr.Zero;
		
		private readonly Window _Window;
		private readonly FpsTimer _FpsTimer;

		private bool _Vsync;
		private bool Vsync
		{
			get => _Vsync;
			set
			{
				_Vsync = value;
				SwapInterval(_Vsync ? 1 : 0);
			}
		}

		public Game()
		{
			if (!Init())
				throw new InvalidOperationException("could not initialize glfw");

			SetWindowHint(CONTEXT_VERSION_MAJOR, 3);
			SetWindowHint(CONTEXT_VERSION_MINOR, 3);
			SetWindowHint(OPENGL_PROFILE, OPENGL_CORE_PROFILE);

			_Window = CreateWindow(1280, 720, "DotNetOpenGL", (Monitor)NULL, (Window)NULL);
			if (_Window == NULL)
				throw new InvalidOperationException("could not create glfw window");

			MakeContextCurrent(_Window);

			SetKeyCallback(_Window, (_, pKey, _, pAction, _) =>
			{
				if (pAction != RELEASE)
					return;

				if (pKey == KEY_ESCAPE)
					SetWindowShouldClose(_Window, true);
				if (pKey == KEY_V)
					Vsync = !Vsync;
			});
			SetFramebufferSizeCallback(_Window, (_, pWidth, pHeight) =>
			{
				SetViewport(0, 0, pWidth, pHeight);
				Render();
			});

			Vsync = true;

			_FpsTimer = new FpsTimer();
		}

		public void Run()
		{
			SetViewport(0, 0, 1280, 720);
			SetClearColor(.2f, .3f, .3f, 1f);

			while (!ShouldWindowClose(_Window))
				Render();
		}

		private void Render()
		{
			long lTime = NanoTime();

			using (IDisposable lFpsTracker = _FpsTimer.Track())
			{
				float lBlue = (MathF.Sin(lTime) / 1_000_000 + 1) / 2;
				SetClearColor(.2f, .3f, lBlue, 1f);
				Clear(COLOR_BUFFER_BIT);

				SwapBuffers(_Window);
				PollEvents();
			}

			SetWindowTitle(_Window, $"DotNetOpenGL - {_FpsTimer.GetFps():F2} FPS{(Vsync ? " Vsync" : "")} ({_FpsTimer.GetMs():F3} ms)");
		}

		public void Dispose()
		{
			if (_Window != IntPtr.Zero)
				Terminate();
		}
	}
}
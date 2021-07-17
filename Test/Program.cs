using System;
using System.Runtime.InteropServices;
using static GLFW;

namespace Test
{
	internal static class Program
	{
		private const int OPENGL_CORE_PROFILE = 0x32001;
		private static readonly IntPtr NULL = IntPtr.Zero;
		
		private static void Main(string[] pArgs)
		{
			if (!Init())
				throw new InvalidOperationException("could not initialize glfw");

			try
			{
				SetWindowHint(CONTEXT_VERSION_MAJOR, 3);
				SetWindowHint(CONTEXT_VERSION_MINOR, 3);
				SetWindowHint(OPENGL_PROFILE, OPENGL_CORE_PROFILE);

				Window lWindow = CreateWindow(1280, 720, "DotNetOpenGL", (Monitor) NULL, (Window) NULL);
				if (lWindow == NULL)
					throw new InvalidOperationException("could not create glfw window");
				
				MakeContextCurrent(lWindow);

				SetKeyCallback(lWindow, (_, pKey, _, _, _) =>
				{
					if (pKey == KEY_ESCAPE)
						SetWindowShouldClose(lWindow, true);
				});
				
				SetViewport(0, 0, 1280, 720);
				SetClearColor(.2f, .3f, .3f, 1f);

				while (!ShouldWindowClose(lWindow))
				{
					Clear(COLOR_BUFFER_BIT);
					
					SwapBuffers(lWindow);
					PollEvents();
				}
			}
			finally
			{
				Terminate();
			}
		}
		
		#region Test

		public const int COLOR_BUFFER_BIT = 0x4000;

		#region glViewport

		[DllImport(GL.LIB)]
		private static extern void glViewport(int pPosX, int pPosY, int pWidth, int pHeight);

		public static void SetViewport(int pPosX, int pPosY, int pWidth, int pHeight) =>
			glViewport(pPosX, pPosY, pWidth, pHeight);

		#endregion

		#region glClearColor

		[DllImport(GL.LIB)]
		private static extern void glClearColor(float pRed, float pGreen, float pBlue, float pAlpha);

		public static void SetClearColor(float pRed, float pGreen, float pBlue, float pAlpha) =>
			glClearColor(pRed, pGreen, pBlue, pAlpha);

		#endregion

		#region glClear

		[DllImport(GL.LIB)]
		private static extern void glClear(int pMask);

		public static void Clear(int pMask) =>
			glClear(pMask);

		#endregion

		#endregion
	}
}
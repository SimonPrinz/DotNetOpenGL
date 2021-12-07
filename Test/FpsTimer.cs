using System;
using System.Diagnostics;

namespace Test
{
	public class FpsTimer
	{
		private readonly Stopwatch _Stopwatch;

		public FpsTimer()
		{
			_Stopwatch = new Stopwatch();
		}

		public IDisposable Track()
		{
			_Stopwatch.Restart();
			return new FpsTracker(this);
		}

		private long GetTicks()
		{
			return _Stopwatch.ElapsedTicks > 0 ? _Stopwatch.ElapsedTicks : 1;
		}

		public float GetFps()
		{
			return 10000000f / GetTicks();
		}

		public float GetMs()
		{
			return GetTicks() / 10000f;
		}

		private class FpsTracker : IDisposable
		{
			private readonly FpsTimer _Timer;

			public FpsTracker(FpsTimer pTimer)
			{
				_Timer = pTimer;
			}

			public void Dispose()
			{
				_Timer._Stopwatch.Stop();
			}
		}
	}
}
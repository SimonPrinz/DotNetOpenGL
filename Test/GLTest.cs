using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Test
{
	public class GLTest
	{
		public static long NanoTime()
		{
			long lNano = 10000L * Stopwatch.GetTimestamp();
			lNano /= TimeSpan.TicksPerMillisecond;
			lNano *= 100L;
			return lNano;
		}
		
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
	}
}
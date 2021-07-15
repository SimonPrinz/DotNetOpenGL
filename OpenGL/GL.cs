using System.Runtime.InteropServices;

public static partial class GL
{
	public const string LIB = "opengl32";

	#region Test

	public const int COLOR_BUFFER_BIT = 0x4000;

	#region glViewport

	[DllImport(LIB)]
	private static extern void glViewport(int pPosX, int pPosY, int pWidth, int pHeight);

	public static void SetViewport(int pPosX, int pPosY, int pWidth, int pHeight) =>
		glViewport(pPosX, pPosY, pWidth, pHeight);

	#endregion

	#region glClearColor

	[DllImport(LIB)]
	private static extern void glClearColor(float pRed, float pGreen, float pBlue, float pAlpha);

	public static void SetClearColor(float pRed, float pGreen, float pBlue, float pAlpha) =>
		glClearColor(pRed, pGreen, pBlue, pAlpha);

	#endregion

	#region glClear

	[DllImport(LIB)]
	private static extern void glClear(int pMask);

	public static void Clear(int pMask) =>
		glClear(pMask);

	#endregion

	#endregion
}
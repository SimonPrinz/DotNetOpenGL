using System;
using System.Runtime.InteropServices;

public partial class GLFW
{
	#region Macros

	/// <summary>
	/// One.
	/// </summary>
	public const int TRUE = 1;

	/// <summary>
	/// Zero.
	/// </summary>
	public const int FALSE = 0;

	/// <summary>
	/// Joystick hat buttons init hint.
	/// </summary>
	public const int JOYSTICK_HAT_BUTTONS = 0x00050001;

	/// <summary>
	/// macOS specific init hint.
	/// </summary>
	public const int COCOA_CHDIR_RESOURCES = 0x00051001;

	/// <summary>
	/// macOS specific init hint.
	/// </summary>
	public const int COCOA_MENUBAR = 0x00051002;

	#endregion

	#region Typedefs

	private delegate void GLFWerrorfun(int pErrorCode, IntPtr pDescription);

	public delegate void ErrorCallback(int pErrorCode, string? pDescription);

	#endregion

	#region Functions

	#region glfwInit

	[DllImport(LIB)]
	private static extern int glfwInit();

	/// <summary>
	/// Initializes the GLFW library.
	/// </summary>
	public static bool Init() =>
		glfwInit() == TRUE;

	#endregion

	#region glfwTerminate

	[DllImport(LIB)]
	private static extern void glfwTerminate();

	/// <summary>
	/// Terminates the GLFW library.
	/// </summary>
	public static void Terminate() =>
		glfwTerminate();

	#endregion

	#region glfwInitHint

	[DllImport(LIB)]
	private static extern void glfwInitHint(int pHint, int pValue);

	/// <summary>
	/// Sets the specified init hint to the desired value.
	/// </summary>
	public static void SetInitHint(int pHint, int pValue) =>
		glfwInitHint(pHint, pValue);

	#endregion

	#region glfwGetVersion

	[DllImport(LIB)]
	private static extern void glfwGetVersion(out long pMajor, out long pMinor, out long pRevision);

	/// <summary>
	/// Retrieves the version of the GLFW library.
	/// </summary>
	public static (long Major, long Minor, long Revision) GetVersion()
	{
		glfwGetVersion(out long lMajor, out long lMinor, out long lRevision);
		return (lMajor, lMinor, lRevision);
	}

	#endregion

	#region glfwGetVersionString

	[DllImport(LIB)]
	private static extern IntPtr glfwGetVersionString();

	/// <summary>
	/// Returns a string describing the compile-time configuration.
	/// </summary>
	public static string? GetVersionString() =>
		glfwGetVersionString() is var lVersionPtr && lVersionPtr != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lVersionPtr) : null;

	#endregion

	#region glfwGetError

	[DllImport(LIB)]
	private static extern int glfwGetError(out IntPtr pDescription);

	/// <summary>
	/// Returns and clears the last error for the calling thread.
	/// </summary>
	public static (int ErrorCode, string? Description)? GetError() =>
		glfwGetError(out IntPtr lDescription) is var lErrorCode &&
		lErrorCode != NO_ERROR
			? (lErrorCode, Marshal.PtrToStringAnsi(lDescription)) : null;

	#endregion

	#region glfwSetErrorCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetErrorCallback(IntPtr pCallback);

	/// <summary>
	/// Sets the error callback.
	/// </summary>
	public static ErrorCallback? SetErrorCallback(ErrorCallback? pCallback)
	{
		IntPtr lCallbackPointer;
		if (pCallback == null)
			return (lCallbackPointer = glfwSetErrorCallback(IntPtr.Zero)) != IntPtr.Zero
				? Marshal.GetDelegateForFunctionPointer<ErrorCallback>(lCallbackPointer) : null;

		void GlfwCallback(int pCode, IntPtr pDescription) =>
			pCallback(pCode, Marshal.PtrToStringAnsi(pDescription));

		return (lCallbackPointer = glfwSetErrorCallback(
			Marshal.GetFunctionPointerForDelegate((GLFWerrorfun) GlfwCallback))) != IntPtr.Zero
			? Marshal.GetDelegateForFunctionPointer<ErrorCallback>(lCallbackPointer) : null;
	}

	#endregion

	#endregion
}
using System;
using System.Runtime.InteropServices;

public partial class GLFW
{
	#region Typesdefs

	/// <summary>
	/// Client API function pointer type.
	/// </summary>
	public readonly struct ProcAddress
	{
		private readonly IntPtr _Value;

		private ProcAddress(IntPtr pValue) => _Value = pValue;

		public static implicit operator IntPtr(ProcAddress pProcAddress) => pProcAddress._Value;
		public static explicit operator ProcAddress(IntPtr pPtr) => new(pPtr);
	}

	#endregion
	
	#region Functions

	#region glfwMakeContextCurrent

	[DllImport(LIB)]
	private static extern void glfwMakeContextCurrent(IntPtr pWindow);

	/// <summary>
	/// Makes the context of the specified window current for the calling thread.
	/// </summary>
	public static void MakeContextCurrent(Window? pWindow) =>
		glfwMakeContextCurrent(pWindow != null ? (IntPtr) pWindow : IntPtr.Zero);

	#endregion

	#region glfwGetCurrentContext

	[DllImport(LIB)]
	private static extern IntPtr glfwGetCurrentContext();

	/// <summary>
	/// Returns the window whose context is current on the calling thread.
	/// </summary>
	public static Window? GetCurrentContext() =>
		glfwGetCurrentContext() is var lWindow && lWindow != IntPtr.Zero
			? (Window) lWindow : null;

	#endregion

	#region glfwSwapInterval

	[DllImport(LIB)]
	private static extern void glfwSwapInterval(int pInterval);

	/// <summary>
	/// Sets the swap interval for the current context.
	/// </summary>
	public static void SwapInterval(int pInterval) =>
		glfwSwapInterval(pInterval);

	#endregion
	
	#region glfwExtensionSupported

	[DllImport(LIB)]
	private static extern int glfwExtensionSupported(IntPtr pExtension);

	/// <summary>
	/// Returns whether the specified extension is available.
	/// </summary>
	public static bool IsExtensionSupported(string pExtension) =>
		glfwExtensionSupported(Marshal.StringToHGlobalAnsi(pExtension)) == TRUE;

	#endregion

	#region glfwGetProcAddress

	[DllImport(LIB)]
	private static extern IntPtr glfwGetProcAddress(IntPtr pProcName);

	/// <summary>
	/// Returns the address of the specified function for the current context.
	/// </summary>
	public static ProcAddress? GetProcAddress(string pProcName) =>
		glfwGetProcAddress(Marshal.StringToHGlobalAnsi(pProcName)) is var lProcPointer &&
		lProcPointer != IntPtr.Zero
			? (ProcAddress) lProcPointer : null;

	#endregion

	#endregion
}
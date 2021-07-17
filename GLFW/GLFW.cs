using System;
using System.Runtime.InteropServices;

public static partial class GLFW
{
#if Windows
	public const string LIB = "lib_glfw.dll";
#elif OSX
	// ToDo: check on mac
	public const string LIB = "lib_glfw.dylib";
#elif Linux
	public const string LIB = "lib_glfw.so";
#endif

	#region Delegates

	private static TDelegate? SetCallback<TDelegate>(TDelegate? pDelegate, Func<IntPtr, IntPtr> pGlfwCallbackFunction)
		where TDelegate : MulticastDelegate
	{
		IntPtr lCallbackPointer;
		return pDelegate == null
			? (lCallbackPointer = pGlfwCallbackFunction(IntPtr.Zero)) != IntPtr.Zero
				? UnregisterDelegate<TDelegate>(lCallbackPointer)
				: null
			: (lCallbackPointer = pGlfwCallbackFunction(RegisterDelegate(pDelegate))) != IntPtr.Zero
				? UnregisterDelegate<TDelegate>(lCallbackPointer)
				: null;
	}

	private static IntPtr RegisterDelegate<TDelegate>(TDelegate pDelegate)
		where TDelegate : MulticastDelegate
	{
		return Marshal.GetFunctionPointerForDelegate(pDelegate);
	}

	private static TDelegate UnregisterDelegate<TDelegate>(IntPtr pPtr)
		where TDelegate : MulticastDelegate
	{
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(pPtr);
	}

	#endregion
}
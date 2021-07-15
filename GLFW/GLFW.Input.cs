using System;
using System.Linq;
using System.Runtime.InteropServices;

public partial class GLFW
{
	#region Macros

	/// <summary>
	/// The key or mouse button was released.
	/// </summary>
	public const int RELEASE = 0;

	/// <summary>
	/// The key or mouse button was pressed.
	/// </summary>
	public const int PRESS = 1;

	/// <summary>
	/// The key was held down until it repeated.
	/// </summary>
	public const int REPEAT = 2;

	#endregion

	#region Typedefs

	#region GLFWcursor

	/// <summary>
	/// Opaque cursor object.
	/// </summary>
	public readonly struct Cursor
	{
		private readonly IntPtr _Value;

		private Cursor(IntPtr pValue) => _Value = pValue;

		public static implicit operator IntPtr(Cursor pCursor) => pCursor._Value;
		public static explicit operator Cursor(IntPtr pPtr) => new(pPtr);
	}

	#endregion

	#region GLFWmousebuttonfun

	private delegate void GLFWmousebuttonfun(IntPtr pWindow, int pButton, int pAction, int pMods);

	public delegate void MouseButtonCallback(Window pWindow, int pButton, int pAction, int pMods);

	#endregion

	#region GLFWcursorposfun

	private delegate void GLFWcursorposfun(IntPtr pWindow, double pXPos, double pYPos);

	public delegate void CursorPosCallback(Window pWindow, double pXPos, double pYPos);

	#endregion

	#region GLFWcursorenterfun

	private delegate void GLFWcursorenterfun(IntPtr pWindow, int pEntered);

	public delegate void CursorEnterCallback(Window pWindow, bool pEntered);

	#endregion

	#region GLFWscrollfun

	private delegate void GLFWscrollfun(IntPtr pWindow, double pXOffset, double pYOffset);

	public delegate void ScrollCallback(Window pWindow, double pXOffset, double pYOffset);

	#endregion

	#region GLFWkeyfun

	private delegate void GLFWkeyfun(IntPtr pWindow, int pKey, int pScancode, int pAction, int pMods);

	public delegate void KeyCallback(Window pWindow, int pKey, int pScancode, int pAction, int pMods);

	#endregion

	#region GLFWcharfun

	private delegate void GLFWcharfun(IntPtr pWindow, uint pCodepoint);

	public delegate void CharCallback(Window pWindow, uint pCodepoint);

	#endregion

	#region GLFWcharmodsfun

	private delegate void GLFWcharmodsfun(IntPtr pWindow, uint pCodepoint, int pMods);

	public delegate void CharModsCallback(Window pWindow, uint pCodepoint, int pMods);

	#endregion

	#region GLFWdropfun

	private delegate void GLFWdropfun(IntPtr pWindow, int pPathCount, IntPtr[] pPaths);

	public delegate void DropCallback(Window pWindow, int pPathCount, string[] pPaths);

	#endregion

	#region GLFWjoystickfun

	private delegate void GLFWjoystickfun(int pJid, int pEvent);

	public delegate void JoystickCallback(int pJid, int pEvent);

	#endregion

	#region GLFWgamepadstate

	/// <summary>
	/// Gamepad input state.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GamepadState
	{
		byte[] buttons;
		float[] axes;
	}

	#endregion

	#endregion

	#region Functions

	#region glfwGetInputMode

	[DllImport(LIB)]
	private static extern int glfwGetInputMode(IntPtr pWindow, int pMode);

	/// <summary>
	/// Returns the value of an input option for the specified window.
	/// </summary>
	public static int GetInputMode(Window pWindow, int pMode) =>
		glfwGetInputMode(pWindow, pMode);

	#endregion

	#region glfwSetInputMode

	[DllImport(LIB)]
	private static extern void glfwSetInputMode(IntPtr pWindow, int pMode, int pValue);

	/// <summary>
	/// Sets an input option for the specified window.
	/// </summary>
	public static void SetInputMode(Window pWindow, int pMode, int pValue) =>
		glfwSetInputMode(pWindow, pMode, pValue);

	#endregion

	#region glfwRawMouseMotionSupported

	[DllImport(LIB)]
	private static extern int glfwRawMouseMotionSupported();

	/// <summary>
	/// Returns whether raw mouse motion is supported.
	/// </summary>
	public static bool IsRawMouseMotionSupported() =>
		glfwRawMouseMotionSupported() == TRUE;

	#endregion

	#region glfwGetKeyName

	[DllImport(LIB)]
	private static extern IntPtr glfwGetKeyName(int pKey, int pScancode);

	/// <summary>
	/// Returns the layout-specific name of the specified printable key.
	/// </summary>
	public static string? GetKeyName(int pKey, int pScancode) =>
		glfwGetKeyName(pKey, pScancode) is var lKeyNamePtr && lKeyNamePtr != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lKeyNamePtr) : null;

	#endregion

	#region glfwGetKeyScancode

	[DllImport(LIB)]
	private static extern int glfwGetKeyScancode(int pKey);

	/// <summary>
	/// Returns the platform-specific scancode of the specified key.
	/// </summary>
	public static int GetKeyScancode(int pKey) =>
		glfwGetKeyScancode(pKey);

	#endregion

	#region glfwGetKey

	[DllImport(LIB)]
	private static extern int glfwGetKey(IntPtr pWindow, int pKey);

	/// <summary>
	/// Returns the last reported state of a keyboard key for the specified window.
	/// </summary>
	public static int GetKey(Window pWindow, int pKey) =>
		glfwGetKey(pWindow, pKey);

	#endregion

	#region glfwGetMouseButton

	[DllImport(LIB)]
	private static extern int glfwGetMouseButton(IntPtr pWindow, int pButton);

	/// <summary>
	/// Returns the last reported state of a mouse button for the specified window. 
	/// </summary>
	public static int GetMouseButton(Window pWindow, int pButton) =>
		glfwGetMouseButton(pWindow, pButton);

	#endregion

	#region glfwGetCursorPos

	[DllImport(LIB)]
	private static extern void glfwGetCursorPos(IntPtr pWindow, out double pXPos, out double pYPos);

	/// <summary>
	/// Retrieves the position of the cursor relative to the content area of the window.
	/// </summary>
	public static (double XPos, double YPos) GetCursorPos(Window pWindow)
	{
		glfwGetCursorPos(pWindow, out double lXPos, out double lYPos);
		return (lXPos, lYPos);
	}

	#endregion

	#region glfwSetCursorPos

	[DllImport(LIB)]
	private static extern void glfwSetCursorPos(IntPtr pWindow, double pXPos, double pYPos);

	/// <summary>
	/// Sets the position of the cursor, relative to the content area of the window.
	/// </summary>
	public static void SetCursorPos(Window pWindow, double pXPos, double pYPos) =>
		glfwSetCursorPos(pWindow, pXPos, pYPos);

	#endregion

	#region glfwCreateCursor

	[DllImport(LIB)]
	private static extern IntPtr glfwCreateCursor(IntPtr pImage, int pXPos, int pYPos);

	// ToDo: glfwCreateCursor - https://www.glfw.org/docs/3.3/group__input.html#gafca356935e10135016aa49ffa464c355

	#endregion

	#region glfwCreateStandardCursor

	[DllImport(LIB)]
	private static extern IntPtr glfwCreateStandardCursor(int pShape);

	/// <summary>
	/// Creates a cursor with a standard shape.
	/// </summary>
	public static Cursor? CreateStandardCursor(int pShape) =>
		glfwCreateStandardCursor(pShape) is var lCursor && lCursor != IntPtr.Zero
			? (Cursor) lCursor : null;

	#endregion

	#region glfwDestroyCursor

	[DllImport(LIB)]
	private static extern void glfwDestroyCursor(IntPtr pCursor);

	/// <summary>
	/// Destroys a cursor.
	/// </summary>
	public static void DestroyCursor(Cursor pCursor) =>
		glfwDestroyCursor(pCursor);

	#endregion

	#region glfwSetCursor

	[DllImport(LIB)]
	private static extern void glfwSetCursor(IntPtr pWindow, IntPtr pCursor);

	/// <summary>
	/// Sets the cursor for the window.
	/// </summary>
	public static void SetCursor(Window pWindow, Cursor pCursor) =>
		glfwSetCursor(pWindow, pCursor);

	#endregion

	#region glfwSetKeyCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetKeyCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the key callback.
	/// </summary>
	public static KeyCallback? SetKeyCallback(Window pWindow, KeyCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetKeyCallback(pWindow, pPtr));

	#endregion

	#region glfwSetCharCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetCharCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the Unicode character callback.
	/// </summary>
	public static CharCallback? SetCharCallback(Window pWindow, CharCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetCharCallback(pWindow, pPtr));

	#endregion

	#region glfwSetCharModsCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetCharModsCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the Unicode character with modifiers callback.
	/// </summary>
	public static CharModsCallback? SetCharModsCallback(Window pWindow, CharModsCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetCharModsCallback(pWindow, pPtr));

	#endregion

	#region glfwSetMouseButtonCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetMouseButtonCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the mouse button callback.
	/// </summary>
	public static MouseButtonCallback? SetMouseButtonCallback(Window pWindow, MouseButtonCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetMouseButtonCallback(pWindow, pPtr));

	#endregion

	#region glfwSetCursorPosCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetCursorPosCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the cursor position callback.
	/// </summary>
	public static CursorPosCallback? SetCursorPosCallback(Window pWindow, CursorPosCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetCursorPosCallback(pWindow, pPtr));

	#endregion

	#region glfwSetCursorEnterCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetCursorEnterCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the cursor enter/leave callback.
	/// </summary>
	public static CursorEnterCallback? SetCursorEnterCallback(Window pWindow, CursorEnterCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetCursorEnterCallback(pWindow, pPtr));

	#endregion

	#region glfwSetScrollCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetScrollCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the scroll callback.
	/// </summary>
	public static ScrollCallback? SetScrollCallback(Window pWindow, ScrollCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetScrollCallback(pWindow, pPtr));

	#endregion

	#region glfwSetDropCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetDropCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the path drop callback.
	/// </summary>
	public static DropCallback? SetDropCallback(Window pWindow, DropCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetDropCallback(pWindow, pPtr));

	#endregion

	#region glfwJoystickPresent

	[DllImport(LIB)]
	private static extern int glfwJoystickPresent(int pJoystickId);

	/// <summary>
	/// Returns whether the specified joystick is present.
	/// </summary>
	public static bool IsJoystickPresent(int pJoystickId) =>
		glfwJoystickPresent(pJoystickId) == TRUE;

	#endregion

	#region glfwGetJoystickAxes

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickAxes(int pJoystickId, out int pCount);

	/// <summary>
	/// Returns the values of all axes of the specified joystick.
	/// </summary>
	public static float[] GetJoystickAxes(int pJoystickId)
	{
		IntPtr lAxesPtr = glfwGetJoystickAxes(pJoystickId, out int lCount);
		float[] lAxes = new float[lCount];
		Marshal.Copy(lAxesPtr, lAxes, 0, lCount);
		return lAxes;
	}

	#endregion

	#region glfwGetJoystickButtons

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickButtons(int pJoystickId, out int pCount);

	/// <summary>
	/// Returns the state of all buttons of the specified joystick.
	/// </summary>
	public static bool[] GetJoystickButtons(int pJoystickId)
	{
		IntPtr lButtonsPtr = glfwGetJoystickButtons(pJoystickId, out int lCount);
		byte[] lButtons = new byte[lCount];
		Marshal.Copy(lButtonsPtr, lButtons, 0, lCount);
		return lButtons.Select(pButton => pButton == PRESS).ToArray();
	}

	#endregion

	#region glfwGetJoystickHats

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickHats(int pJoystickId, out int pCount);

	public static byte[] GetJoystickHats(int pJoystickId)
	{
		IntPtr lHatsPtr = glfwGetJoystickHats(pJoystickId, out int lCount);
		byte[] lHats = new byte[lCount];
		Marshal.Copy(lHatsPtr, lHats, 0, lCount);
		return lHats;
	}

	#endregion

	#region glfwGetJoystickName

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickName(int pJoystickId);

	/// <summary>
	/// Returns the name of the specified joystick.
	/// </summary>
	public static string? GetJoystickName(int pJoystickId) =>
		glfwGetJoystickName(pJoystickId) is var lPtr && lPtr != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lPtr) : null;

	#endregion

	#region glfwGetJoystickGUID

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickGUID(int pJoystickId);

	/// <summary>
	/// Returns the SDL compatible GUID of the specified joystick.
	/// </summary>
	public static Guid? GetJoystickGuid(int pJoystickId)
	{
		IntPtr lGuidPtr = glfwGetJoystickGUID(pJoystickId);
		if (lGuidPtr == IntPtr.Zero)
			return null;
		byte[] lGuid = new byte[16];
		Marshal.Copy(lGuidPtr, lGuid, 0, 16);
		return new Guid(lGuid);
	}

	#endregion

	#region glfwSetJoystickUserPointer

	[DllImport(LIB)]
	private static extern void glfwSetJoystickUserPointer(int pJoystickId, IntPtr pPtr);

	// ToDo: glfwSetJoystickUserPointer - https://www.glfw.org/docs/3.3/group__input.html#ga6b2f72d64d636b48a727b437cbb7489e

	#endregion

	#region glfwGetJoystickUserPointer

	[DllImport(LIB)]
	private static extern IntPtr glfwGetJoystickUserPointer(int pJoystickId);

	// ToDo: glfwGetJoystickUserPointer - https://www.glfw.org/docs/3.3/group__input.html#ga06290acb7ed23895bf26b8e981827ebd

	#endregion

	#region glfwJoystickIsGamepad

	[DllImport(LIB)]
	private static extern int glfwJoystickIsGamepad(int pJoystickId);

	/// <summary>
	/// Returns whether the specified joystick has a gamepad mapping.
	/// </summary>
	public static bool IsJoystickGamepad(int pJoystickId) =>
		glfwJoystickIsGamepad(pJoystickId) == TRUE;

	#endregion

	#region glfwSetJoystickCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetJoystickCallback(IntPtr pCallback);

	/// <summary>
	/// Sets the joystick configuration callback.
	/// </summary>
	public static JoystickCallback? SetJoystickCallback(JoystickCallback? pCallback) =>
		SetCallback(pCallback, glfwSetJoystickCallback);

	#endregion

	#region glfwUpdateGamepadMappings

	[DllImport(LIB)]
	private static extern int glfwUpdateGamepadMappings(IntPtr pPtr);

	/// <summary>
	/// Adds the specified SDL_GameControllerDB gamepad mappings.
	/// </summary>
	public static bool UpdateGamepadMappings(string pMappings) =>
		glfwUpdateGamepadMappings(Marshal.StringToHGlobalAnsi(pMappings)) == TRUE;

	#endregion

	#region glfwGetGamepadName

	[DllImport(LIB)]
	private static extern IntPtr glfwGetGamepadName(int pJoystickId);

	/// <summary>
	/// Returns the human-readable gamepad name for the specified joystick.
	/// </summary>
	public static string? GetGamepadName(int pJoystickId) =>
		glfwGetGamepadName(pJoystickId) is var lPtr && lPtr != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lPtr) : null;

	#endregion

	#region glfwGetGamepadState

	[DllImport(LIB)]
	private static extern int glfwGetGamepadState(int pJoystickId, IntPtr pState);

	// ToDo: glfwGetGamepadState - https://www.glfw.org/docs/3.3/group__input.html#gadccddea8bce6113fa459de379ddaf051

	#endregion

	#region glfwSetClipboardString

	[DllImport(LIB)]
	private static extern void glfwSetClipboardString(IntPtr pWindow, IntPtr pString);

	/// <summary>
	/// Sets the clipboard to the specified string.
	/// </summary>
	public static void SetClipboardString(Window pWindow, string pString) =>
		glfwSetClipboardString(pWindow, Marshal.StringToHGlobalAnsi(pString));

	#endregion

	#region glfwGetClipboardString

	[DllImport(LIB)]
	private static extern IntPtr glfwGetClipboardString(IntPtr pWindow);

	/// <summary>
	/// Returns the contents of the clipboard as a string.
	/// </summary>
	public static string? GetClipboardString(Window? pWindow) =>
		glfwGetClipboardString(pWindow != null ? (IntPtr) pWindow : IntPtr.Zero) is var lString &&
		lString != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lString) : null;

	#endregion

	#region glfwGetTime

	[DllImport(LIB)]
	private static extern double glfwGetTime();

	/// <summary>
	/// Returns the GLFW time.
	/// </summary>
	public static double GetTime() =>
		glfwGetTime();

	#endregion

	#region glfwSetTime

	[DllImport(LIB)]
	private static extern void glfwSetTime(double pTime);

	/// <summary>
	/// Sets the GLFW time.
	/// </summary>
	public static void SetTime(double pTime) =>
		glfwSetTime(pTime);

	#endregion

	#region glfwGetTimerValue

	[DllImport(LIB)]
	private static extern ulong glfwGetTimerValue();

	/// <summary>
	/// Returns the current value of the raw timer.
	/// </summary>
	public static ulong GetTimerValue() =>
		glfwGetTimerValue();

	#endregion

	#region glfwGetTimerFrequency

	[DllImport(LIB)]
	private static extern ulong glfwGetTimerFrequency();

	/// <summary>
	/// Returns the frequency, in Hz, of the raw timer.
	/// </summary>
	public static ulong GetTimerFrequency() =>
		glfwGetTimerFrequency();

	#endregion

	#endregion
}
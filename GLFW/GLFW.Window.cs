using System;
using System.Runtime.InteropServices;

public partial class GLFW
{
	#region Macros

	/// <summary>
	/// Input focus window hint and attribute.
	/// </summary>
	public const int FOCUSED = 0x00020001;

	/// <summary>
	/// Window iconification window attribute.
	/// </summary>
	public const int ICONIFIED = 0x00020002;

	/// <summary>
	/// Window resize-ability window hint and attribute.
	/// </summary>
	public const int RESIZABLE = 0x00020003;

	/// <summary>
	/// Window visibility window hint and attribute.
	/// </summary>
	public const int VISIBLE = 0x00020004;

	/// <summary>
	/// Window decoration window hint and attribute.
	/// </summary>
	public const int DECORATED = 0x00020005;

	/// <summary>
	/// Window auto-iconification window hint and attribute.
	/// </summary>
	public const int AUTO_ICONIFY = 0x00020006;

	/// <summary>
	/// Window decoration window hint and attribute.
	/// </summary>
	public const int FLOATING = 0x00020007;

	/// <summary>
	/// Window maximization window hint and attribute.
	/// </summary>
	public const int MAXIMIZED = 0x00020008;

	/// <summary>
	/// Cursor centering window hint.
	/// </summary>
	public const int CENTER_CURSOR = 0x00020009;

	/// <summary>
	/// Window framebuffer transparency hint and attribute.
	/// </summary>
	public const int TRANSPARENT_FRAMEBUFFER = 0x0002000A;

	/// <summary>
	/// Mouse cursor hover window attribute.
	/// </summary>
	public const int HOVERED = 0x0002000B;

	/// <summary>
	/// Input focus on calling show window hint and attribute.
	/// </summary>
	public const int FOCUS_ON_SHOW = 0x0002000C;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int RED_BITS = 0x00021001;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int GREEN_BITS = 0x00021002;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int BLUE_BITS = 0x00021003;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int ALPHA_BITS = 0x00021004;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int DEPTH_BITS = 0x00021005;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int STENCIL_BITS = 0x00021006;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int ACCUM_RED_BITS = 0x00021007;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int ACCUM_GREEN_BITS = 0x00021008;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int ACCUM_BLUE_BITS = 0x00021009;

	/// <summary>
	/// Framebuffer bit depth hint.
	/// </summary>
	public const int ACCUM_ALPHA_BITS = 0x0002100A;

	/// <summary>
	/// Framebuffer auxiliary buffer hint.
	/// </summary>
	public const int AUX_BUFFERS = 0x0002100B;

	/// <summary>
	/// OpenGL stereoscopic rendering hint.
	/// </summary>
	public const int STEREO = 0x0002100C;

	/// <summary>
	/// Framebuffer MSAA samples hint.
	/// </summary>
	public const int SAMPLES = 0x0002100D;

	/// <summary>
	/// Framebuffer sRGB hint.
	/// </summary>
	public const int SRGB_CAPABLE = 0x0002100E;

	/// <summary>
	/// Monitor refresh rate hint.
	/// </summary>
	public const int REFRESH_RATE = 0x0002100F;

	/// <summary>
	/// Framebuffer double buffering hint.
	/// </summary>
	public const int DOUBLEBUFFER = 0x00021010;

	/// <summary>
	/// Context client API hint and attribute.
	/// </summary>
	public const int CLIENT_API = 0x00022001;

	/// <summary>
	/// Context client API major version hint and attribute.
	/// </summary>
	public const int CONTEXT_VERSION_MAJOR = 0x00022002;

	/// <summary>
	/// Context client API minor version hint and attribute.
	/// </summary>
	public const int CONTEXT_VERSION_MINOR = 0x00022003;

	/// <summary>
	/// Context client API revision number hint and attribute.
	/// </summary>
	public const int CONTEXT_REVISION = 0x00022004;

	/// <summary>
	/// Context robustness hint and attribute.
	/// </summary>
	public const int CONTEXT_ROBUSTNESS = 0x00022005;

	/// <summary>
	/// OpenGL forward-compatibility hint and attribute.
	/// </summary>
	public const int OPENGL_FORWARD_COMPAT = 0x00022006;

	/// <summary>
	/// Debug mode context hint and attribute.
	/// </summary>
	public const int OPENGL_DEBUG_CONTEXT = 0x00022007;

	/// <summary>
	/// OpenGL profile hint and attribute.
	/// </summary>1
	public const int OPENGL_PROFILE = 0x00022008;

	/// <summary>
	/// Context flush-on-release hint and attribute.
	/// </summary>
	public const int CONTEXT_RELEASE_BEHAVIOR = 0x00022009;

	/// <summary>
	/// Context error suppression hint and attribute.
	/// </summary>
	public const int CONTEXT_NO_ERROR = 0x0002200A;

	/// <summary>
	/// Context creation API hint and attribute.
	/// </summary>
	public const int CONTEXT_CREATION_API = 0x0002200B;

	/// <summary>
	/// Window content area scaling window window hint.
	/// </summary>
	public const int SCALE_TO_MONITOR = 0x0002200C;

	/// <summary>
	/// macOS specific window hint.
	/// </summary>
	public const int COCOA_RETINA_FRAMEBUFFER = 0x00023001;

	/// <summary>
	/// macOS specific window hint.
	/// </summary>
	public const int COCOA_FRAME_NAME = 0x00023002;

	/// <summary>
	/// macOS specific window hint.
	/// </summary>
	public const int COCOA_GRAPHICS_SWITCHING = 0x00023003;

	/// <summary>
	/// X11 specific window hint.
	/// </summary>
	public const int X11_CLASS_NAME = 0x00024001;

	/// <summary>
	/// X11 specific window hint.
	/// </summary>
	public const int X11_INSTANCE_NAME = 0x00024002;

	#endregion

	#region Typedefs

	#region GLFWWindow
	
	/// <summary>
	/// Opaque window object.
	/// </summary>
	public readonly struct Window
	{
		private readonly IntPtr _Value;

		private Window(IntPtr pValue) => _Value = pValue;

		public static implicit operator IntPtr(Window pWindow) => pWindow._Value;
		public static explicit operator Window(IntPtr pPtr) => new(pPtr);
	}
	
	#endregion

	#region GLFWwindowposfun

	private delegate void GLFWwindowposfun(IntPtr pWindow, int pXPos, int pYPos);

	public delegate void WindowPosCallback(Window pWindow, int pXPos, int pYPos);

	#endregion

	#region GLFWwindowsizefun

	private delegate void GLFWwindowsizefun(IntPtr pWindow, int pWidth, int pHeight);

	public delegate void WindowSizeCallback(Window pWindow, int pWidth, int pHeight);

	#endregion

	#region GLFWwindowclosefun

	private delegate void GLFWwindowclosefun(IntPtr pWindow);

	public delegate void WindowCloseCallback(Window pWindow);

	#endregion

	#region GLFWwindowrefreshfun

	private delegate void GLFWwindowrefreshfun(IntPtr pWindow);

	public delegate void WindowRefreshCallback(Window pWindow);

	#endregion

	#region GLFWwindowfocusfun

	private delegate void GLFWwindowfocusfun(IntPtr pWindow, int pFocused);

	public delegate void WindowFocusCallback(Window pWindow, bool pFocused);

	#endregion

	#region GLFWwindowiconifyfun

	private delegate void GLFWwindowiconifyfun(IntPtr pWindow, int pIconified);

	public delegate void WindowIconifyCallback(Window pWindow, bool pIconified);

	#endregion

	#region GLFWwindowmaximizefun

	private delegate void GLFWwindowmaximizefun(IntPtr pWindow, int pMaximized);

	public delegate void WindowMaximizeCallback(Window pWindow, bool pMaximized);

	#endregion

	#region GLFWframebuffersizefun

	private delegate void GLFWframebuffersizefun(IntPtr pWindow, int pWidth, int pHeight);

	public delegate void FramebufferSizeCallback(Window pWindow, int pWidth, int pHeight);

	#endregion

	#region GLFWwindowcontentscalefun

	private delegate void GLFWwindowcontentscalefun(IntPtr pWindow, float pScaleX, float pScaleY);

	public delegate void WindowContentScaleCallback(Window pWindow, float pScaleX, float pScaleY);

	#endregion

	#region GLFWimage
	
	/// <summary>
	/// Image data.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Image
	{
		int width;
		int height;
		// ToDo: don't know if that works ¯\_(ツ)_/¯
		byte[] pixels;

		public override string ToString() =>
			$"{width}x{height}";
	}
	
	#endregion

	#endregion

	#region Functions

	#region glfwDefaultWindowHints

	[DllImport(LIB)]
	private static extern void glfwDefaultWindowHints();

	/// <summary>
	/// Resets all window hints to their default values.
	/// </summary>
	public static void SetDefaultWindowHints() =>
		glfwDefaultWindowHints();

	#endregion

	#region glfwWindowHint

	[DllImport(LIB)]
	private static extern void glfwWindowHint(int pHint, int pValue);

	/// <summary>
	/// Sets the specified window hint to the desired value.
	/// </summary>
	public static void SetWindowHint(int pHint, int pValue) =>
		glfwWindowHint(pHint, pValue);

	#endregion

	#region glfwWindowHintString

	[DllImport(LIB)]
	private static extern void glfwWindowHintString(int pHint, IntPtr pValue);

	/// <summary>
	/// Sets the specified window hint to the desired value.
	/// </summary>
	public static void SetWindowHintString(int pHint, string pValue) =>
		glfwWindowHintString(pHint, Marshal.StringToHGlobalAnsi(pValue));

	#endregion

	#region glfwCreateWindow

	[DllImport(LIB)]
	private static extern IntPtr glfwCreateWindow(int pWidth, int pHeight, IntPtr pTitle, IntPtr pMonitor, IntPtr pShare);

	/// <summary>
	/// Creates a window and its associated context.
	/// </summary>
	public static Window CreateWindow(int pWidth, int pHeight, string pTitle, Monitor pMonitor, Window pShare) =>
		(Window) glfwCreateWindow(pWidth, pHeight, Marshal.StringToHGlobalAnsi(pTitle), pMonitor, pShare);

	#endregion

	#region glfwDestroyWindow

	[DllImport(LIB)]
	private static extern void glfwDestroyWindow(IntPtr pWindow);

	/// <summary>
	/// Destroys the specified window and its context.
	/// </summary>
	public static void DestroyWindow(Window pWindow) =>
		glfwDestroyWindow(pWindow);

	#endregion

	#region glfwWindowShouldClose

	[DllImport(LIB)]
	private static extern int glfwWindowShouldClose(IntPtr pWindow);

	/// <summary>
	/// Checks the close flag of the specified window.
	/// </summary>
	public static bool ShouldWindowClose(Window pWindow) =>
		glfwWindowShouldClose(pWindow) == TRUE;

	#endregion

	#region glfwSetWindowShouldClose

	[DllImport(LIB)]
	private static extern void glfwSetWindowShouldClose(IntPtr pWindow, int pValue);

	/// <summary>
	/// Sets the close flag of the specified window.
	/// </summary>
	public static void SetWindowShouldClose(Window pWindow, bool pValue) =>
		glfwSetWindowShouldClose(pWindow, pValue ? 1 : 0);

	#endregion

	#region glfwSetWindowTitle

	[DllImport(LIB)]
	private static extern void glfwSetWindowTitle(IntPtr pWindow, IntPtr pTitle);

	/// <summary>
	/// Sets the title of the specified window.
	/// </summary>
	public static void SetWindowTitle(Window pWindow, string pTitle) =>
		glfwSetWindowTitle(pWindow, Marshal.StringToHGlobalAnsi(pTitle));

	#endregion

	#region glfwSetWindowIcon

	[DllImport(LIB)]
	private static extern void glfwSetWindowIcon(IntPtr pWindow, int pCount, IntPtr pImages);
	
	// ToDo: glfwSetWindowIcon - https://www.glfw.org/docs/3.3/group__window.html#gadd7ccd39fe7a7d1f0904666ae5932dc5

	#endregion

	#region glfwGetWindowPos

	[DllImport(LIB)]
	private static extern void glfwGetWindowPos(IntPtr pWindow, out int pPosX, out int pPosY);

	/// <summary>
	/// Retrieves the position of the content area of the specified window.
	/// </summary>
	public static (int PosX, int PosY) GetWindowPos(Window pWindow)
	{
		glfwGetWindowPos(pWindow, out int lPosX, out int lPosY);
		return (lPosX, lPosY);
	}

	#endregion

	#region glfwSetWindowPos

	[DllImport(LIB)]
	private static extern void glfwSetWindowPos(IntPtr pWindow, int pPosX, int pPosY);

	/// <summary>
	/// Sets the position of the content area of the specified window.
	/// </summary>
	public static void SetWindowPos(Window pWindow, int pPosX, int pPosY) =>
		glfwSetWindowPos(pWindow, pPosX, pPosY);

	#endregion

	#region glfwGetWindowSize

	[DllImport(LIB)]
	private static extern void glfwGetWindowSize(IntPtr pWindow, out int pWidth, out int pHeight);

	/// <summary>
	/// Retrieves the size of the content area of the specified window.
	/// </summary>
	public static (int Width, int Height) GetWindowSize(Window pWindow)
	{
		glfwGetWindowSize(pWindow, out int lWidth, out int lHeight);
		return (lWidth, lHeight);
	}

	#endregion

	#region glfwSetWindowSizeLimits

	[DllImport(LIB)]
	private static extern void glfwSetWindowSizeLimits(IntPtr pWindow, int pMinWidth, int pMinHeight, int pMaxWidth, int pMaxHeight);

	/// <summary>
	/// Sets the size limits of the specified window.
	/// </summary>
	public static void SetWindowSizeLimits(Window pWindow, int pMinWidth, int pMinHeight, int pMaxWidth, int pMaxHeight) =>
		glfwSetWindowSizeLimits(pWindow, pMinWidth, pMinHeight, pMaxWidth, pMaxHeight);

	#endregion

	#region glfwSetWindowAspectRatio

	[DllImport(LIB)]
	private static extern void glfwSetWindowAspectRatio(IntPtr pWindow, int pNumer, int pDenom);

	/// <summary>
	/// Sets the aspect ratio of the specified window.
	/// </summary>
	public static void SetWindowAspectRatio(Window pWindow, int pNumer, int pDenom) =>
		glfwSetWindowAspectRatio(pWindow, pNumer, pDenom);

	#endregion

	#region glfwSetWindowSize

	[DllImport(LIB)]
	private static extern void glfwSetWindowSize(IntPtr pWindow, int pWidth, int pHeight);

	/// <summary>
	/// Sets the size of the content area of the specified window.
	/// </summary>
	public static void SetWindowSize(Window pWindow, int pWidth, int pHeight) =>
		glfwSetWindowSize(pWindow, pWidth, pHeight);

	#endregion

	#region glfwGetFramebufferSize

	[DllImport(LIB)]
	private static extern void glfwGetFramebufferSize(IntPtr pWindow, out int pWidth, out int pHeight);

	/// <summary>
	/// Retrieves the size of the framebuffer of the specified window.
	/// </summary>
	public static (int Width, int Height) GetFramebufferSize(Window pWindow)
	{
		glfwGetFramebufferSize(pWindow, out int lWidth, out int lHeight);
		return (lWidth, lHeight);
	}

	#endregion

	#region glfwGetWindowFrameSize

	[DllImport(LIB)]
	private static extern void glfwGetWindowFrameSize(IntPtr pWindow, out int pLeft, out int pTop, out int pRight, out int pBottom);

	/// <summary>
	/// Retrieves the size of the frame of the window.
	/// </summary>
	public static (int Top, int Right, int Bottom, int Left) GetWindowFrameSize(Window pWindow)
	{
		glfwGetWindowFrameSize(pWindow, out int lLeft, out int lTop, out int lRight, out int lBottom);
		return (lTop, lRight, lBottom, lLeft);
	}

	#endregion

	#region glfwGetWindowContentScale

	[DllImport(LIB)]
	private static extern void glfwGetWindowContentScale(IntPtr pWindow, out float pScaleX, out float pScaleY);

	/// <summary>
	/// Retrieves the content scale for the specified window.
	/// </summary>
	public static (float ScaleX, float ScaleY) GetWindowContentScale(Window pWindow)
	{
		glfwGetWindowContentScale(pWindow, out float lScaleX, out float lScaleY);
		return (lScaleX, lScaleY);
	}

	#endregion

	#region glfwGetWindowOpacity

	[DllImport(LIB)]
	private static extern float glfwGetWindowOpacity(IntPtr pWindow);

	/// <summary>
	/// Returns the opacity of the whole window.
	/// </summary>
	public static float GetWindowOpacity(Window pWindow) =>
		glfwGetWindowOpacity(pWindow);

	#endregion

	#region glfwSetWindowOpacity

	[DllImport(LIB)]
	private static extern void glfwSetWindowOpacity(IntPtr pWindow, float pOpacity);

	/// <summary>
	/// Sets the opacity of the whole window.
	/// </summary>
	public static void SetWindowOpacity(Window pWindow, float pOpacity) =>
		glfwSetWindowOpacity(pWindow, pOpacity);

	#endregion
	
	#region glfwIconifyWindow

	[DllImport(LIB)]
	private static extern void glfwIconifyWindow(IntPtr pWindow);

	/// <summary>
	/// Iconifies the specified window.
	/// </summary>
	public static void IconifyWindow(Window pWindow) =>
		glfwIconifyWindow(pWindow);

	#endregion

	#region glfwRestoreWindow

	[DllImport(LIB)]
	private static extern void glfwRestoreWindow(IntPtr pWindow);

	/// <summary>
	/// Restores the specified window.
	/// </summary>
	public static void RestoreWindow(Window pWindow) =>
		glfwRestoreWindow(pWindow);

	#endregion

	#region glfwMaximizeWindow

	[DllImport(LIB)]
	private static extern void glfwMaximizeWindow(IntPtr pWindow);

	/// <summary>
	/// Maximizes the specified window.
	/// </summary>
	public static void MaximizeWindow(Window pWindow) =>
		glfwMaximizeWindow(pWindow);

	#endregion

	#region glfwShowWindow

	[DllImport(LIB)]
	private static extern void glfwShowWindow(IntPtr pWindow);

	/// <summary>
	/// Makes the specified window visible.
	/// </summary>
	public static void ShowWindow(Window pWindow) =>
		glfwShowWindow(pWindow);

	#endregion

	#region glfwHideWindow

	[DllImport(LIB)]
	private static extern void glfwHideWindow(IntPtr pWindow);

	/// <summary>
	/// Hides the specified window.
	/// </summary>
	public static void HideWindow(Window pWindow) =>
		glfwHideWindow(pWindow);

	#endregion

	#region glfwFocusWindow

	[DllImport(LIB)]
	private static extern void glfwFocusWindow(IntPtr pWindow);

	/// <summary>
	/// Brings the specified window to front and sets input focus.
	/// </summary>
	public static void FocusWindow(Window pWindow) =>
		glfwFocusWindow(pWindow);

	#endregion

	#region glfwRequestWindowAttention

	[DllImport(LIB)]
	private static extern void glfwRequestWindowAttention(IntPtr pWindow);

	/// <summary>
	/// Requests user attention to the specified window.
	/// </summary>
	public static void RequestWindowAttention(Window pWindow) =>
		glfwRequestWindowAttention(pWindow);

	#endregion

	#region glfwGetWindowMonitor

	[DllImport(LIB)]
	private static extern IntPtr glfwGetWindowMonitor(IntPtr pWindow);

	/// <summary>
	/// Returns the monitor that the window uses for full screen mode.
	/// </summary>
	public static Monitor GetWindowMonitor(Window pWindow) =>
		(Monitor) glfwGetWindowMonitor(pWindow);

	#endregion

	#region glfwSetWindowMonitor

	[DllImport(LIB)]
	private static extern void glfwSetWindowMonitor(IntPtr pWindow, IntPtr pMonitor, int pPosX, int pPosY, int pWidth, int pHeight, int pRefreshRate);

	/// <summary>
	/// Sets the mode, monitor, video mode and placement of a window.
	/// </summary>
	public static void SetWindowMonitor(Window pWindow, Monitor pMonitor, int pPosX, int pPosY, int pWidth, int pHeight, int pRefreshRate) =>
		glfwSetWindowMonitor(pWindow, pMonitor, pPosX, pPosY, pWidth, pHeight, pRefreshRate);

	#endregion

	#region glfwGetWindowAttrib

	[DllImport(LIB)]
	private static extern int glfwGetWindowAttrib(IntPtr pWindow, int pAttribute);

	/// <summary>
	/// Returns an attribute of the specified window.
	/// </summary>
	public static int GetWindowAttrib(Window pWindow, int pAttribute) =>
		glfwGetWindowAttrib(pWindow, pAttribute);

	#endregion

	#region glfwSetWindowAttrib

	[DllImport(LIB)]
	private static extern void glfwSetWindowAttrib(IntPtr pWindow, int pAttribute, int pValue);

	/// <summary>
	/// Sets an attribute of the specified window.
	/// </summary>
	public static void SetWindowAttrib(Window pWindow, int pAttribute, int pValue) =>
		glfwSetWindowAttrib(pWindow, pAttribute, pValue);

	#endregion

	#region glfwSetWindowUserPointer

	[DllImport(LIB)]
	private static extern void glfwSetWindowUserPointer(IntPtr pWindow, IntPtr pPtr);
	
	// ToDo: glfwSetWindowUserPointer - https://www.glfw.org/docs/3.3/group__window.html#ga3d2fc6026e690ab31a13f78bc9fd3651

	#endregion

	#region glfwGetWindowUserPointer

	[DllImport(LIB)]
	private static extern IntPtr glfwGetWindowUserPointer(IntPtr pWindow);
	
	// ToDo: glfwGetWindowUserPointer - https://www.glfw.org/docs/3.3/group__window.html#ga17807ce0f45ac3f8bb50d6dcc59a4e06

	#endregion

	#region glfwSetWindowPosCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowPosCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the position callback for the specified window.
	/// </summary>
	public static WindowPosCallback? SetWindowPosCallback(Window pWindow, WindowPosCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowPosCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowSizeCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowSizeCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the size callback for the specified window.
	/// </summary>
	public static WindowSizeCallback? SetWindowSizeCallback(Window pWindow, WindowSizeCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowSizeCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowCloseCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowCloseCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the close callback for the specified window.
	/// </summary>
	public static WindowCloseCallback? SetWindowCloseCallback(Window pWindow, WindowCloseCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowCloseCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowRefreshCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowRefreshCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the refresh callback for the specified window.
	/// </summary>
	public static WindowRefreshCallback? SetWindowRefreshCallback(Window pWindow, WindowRefreshCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowRefreshCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowFocusCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowFocusCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the focus callback for the specified window.
	/// </summary>
	public static WindowFocusCallback? SetWindowFocusCallback(Window pWindow, WindowFocusCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowFocusCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowIconifyCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowIconifyCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the iconify callback for the specified window.
	/// </summary>
	public static WindowIconifyCallback? SetWindowIconifyCallback(Window pWindow, WindowIconifyCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowIconifyCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowMaximizeCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowMaximizeCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the maximize callback for the specified window.
	/// </summary>
	public static WindowMaximizeCallback? SetWindowMaximizeCallback(Window pWindow, WindowMaximizeCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowMaximizeCallback(pWindow, pPtr));

	#endregion

	#region glfwSetFramebufferSizeCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetFramebufferSizeCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the framebuffer resize callback for the specified window.
	/// </summary>
	public static FramebufferSizeCallback? SetFramebufferSizeCallback(Window pWindow, FramebufferSizeCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetFramebufferSizeCallback(pWindow, pPtr));

	#endregion

	#region glfwSetWindowContentScaleCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetWindowContentScaleCallback(IntPtr pWindow, IntPtr pCallback);

	/// <summary>
	/// Sets the window content scale callback for the specified window.
	/// </summary>
	public static WindowContentScaleCallback? SetWindowContentScaleCallback(Window pWindow, WindowContentScaleCallback? pCallback) =>
		SetCallback(pCallback, pPtr => glfwSetWindowContentScaleCallback(pWindow, pPtr));

	#endregion
	
	#region glfwPollEvents

	[DllImport(LIB)]
	private static extern void glfwPollEvents();

	/// <summary>
	/// Processes all pending events.
	/// </summary>
	public static void PollEvents() =>
		glfwPollEvents();

	#endregion

	#region glfwWaitEvents

	[DllImport(LIB)]
	private static extern void glfwWaitEvents();

	/// <summary>
	/// Waits until events are queued and processes them.
	/// </summary>
	public static void WaitEvents() =>
		glfwWaitEvents();

	#endregion

	#region glfwWaitEventsTimeout

	[DllImport(LIB)]
	private static extern void glfwWaitEventsTimeout(double pTimeout);

	/// <summary>
	/// Waits with timeout until events are queued and processes them.
	/// </summary>
	public static void WaitEventsTimeout(double pTimeout) =>
		glfwWaitEventsTimeout(pTimeout);

	#endregion

	#region glfwPostEmptyEvent

	[DllImport(LIB)]
	private static extern void glfwPostEmptyEvent();

	/// <summary>
	/// Posts an empty event to the event queue.
	/// </summary>
	public static void PostEmptyEvent() =>
		glfwPostEmptyEvent();

	#endregion

	#region glfwSwapBuffers

	[DllImport(LIB)]
	private static extern void glfwSwapBuffers(IntPtr pWindow);

	/// <summary>
	/// Swaps the front and back buffers of the specified window.
	/// </summary>
	public static void SwapBuffers(Window pWindow) =>
		glfwSwapBuffers(pWindow);

	#endregion

	#endregion
}
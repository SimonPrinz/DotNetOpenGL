using System;
using System.Linq;
using System.Runtime.InteropServices;

public partial class GLFW
{
	#region Typedefs

	#region GLFWmonitor

	/// <summary>
	/// Opaque monitor object.
	/// </summary>
	public readonly struct Monitor
	{
		private readonly IntPtr _Value;

		private Monitor(IntPtr pValue) => _Value = pValue;

		public static implicit operator IntPtr(Monitor pMonitor) => pMonitor._Value;
		public static explicit operator Monitor(IntPtr pPtr) => new(pPtr);
	}

	#endregion

	#region GLFWmonitorfun

	private delegate void GLFWmonitorfun(IntPtr pMonitor, int pEvent);

	public delegate void MonitorCallback(Monitor pMonitor, int pEvent);

	#endregion

	#region GLFWvidmode

	/// <summary>
	/// Video mode type.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VideoMode
	{
		public int width;
		public int height;
		public int redBits;
		public int greenBits;
		public int blueBits;
		public int refreshRate;
	}

	#endregion

	#region GLFWgammaramp

	/// <summary>
	/// Gamma ramp.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GammaRamp
	{
		public IntPtr red;
		public IntPtr green;
		public IntPtr blue;
		public uint size;
	}

	#endregion

	#endregion

	#region Functions

	#region glfwGetMonitors

	[DllImport(LIB)]
	private static extern IntPtr glfwGetMonitors(out int pCount);

	/// <summary>
	/// Returns the currently connected monitors.
	/// </summary>
	public static Monitor[] GetMonitors()
	{
		IntPtr lMonitorsPtr = glfwGetMonitors(out int lCount);
		IntPtr[] lMonitors = new IntPtr[lCount];
		Marshal.Copy(lMonitorsPtr, lMonitors, 0, lCount);
		return lMonitors.Select(pPtr => (Monitor) pPtr).ToArray();
	}

	#endregion

	#region glfwGetPrimaryMonitor

	[DllImport(LIB)]
	private static extern IntPtr glfwGetPrimaryMonitor();

	/// <summary>
	/// Returns the primary monitor.
	/// </summary>
	public static Monitor GetPrimaryMonitor() =>
		(Monitor) glfwGetPrimaryMonitor();

	#endregion

	#region glfwGetMonitorPos

	[DllImport(LIB)]
	private static extern void glfwGetMonitorPos(IntPtr pMonitor, out int pXPos, out int pYPos);

	/// <summary>
	/// Returns the position of the monitor's viewport on the virtual screen.
	/// </summary>
	public static (int XPos, int YPos) GetMonitorPos(Monitor pMonitor)
	{
		glfwGetMonitorPos(pMonitor, out int lXPos, out int lYPos);
		return (lXPos, lYPos);
	}

	#endregion

	#region glfwGetMonitorWorkarea

	[DllImport(LIB)]
	private static extern void glfwGetMonitorWorkarea(IntPtr pMonitor, out int pXPos, out int pYPos, out int pWidth,
		out int pHeight);

	/// <summary>
	/// Retrieves the work area of the monitor.
	/// </summary>
	public static (int XPos, int YPos, int Width, int Height) GetMonitorWorkarea(Monitor pMonitor)
	{
		glfwGetMonitorWorkarea(pMonitor, out int lXPos, out int lYPos, out int lWidth, out int lHeight);
		return (lXPos, lYPos, lWidth, lHeight);
	}

	#endregion

	#region glfwGetMonitorPhysicalSize

	[DllImport(LIB)]
	private static extern void glfwGetMonitorPhysicalSize(IntPtr pMonitor, out int pWidthMm, out int pHeightMm);

	/// <summary>
	/// Returns the physical size of the monitor.
	/// </summary>
	public static (int WidthMm, int HeightMm) GetMonitorPhysicalSize(Monitor pMonitor)
	{
		glfwGetMonitorPhysicalSize(pMonitor, out int lWidthMm, out int lHeightMm);
		return (lWidthMm, lHeightMm);
	}

	#endregion

	#region glfwGetMonitorContentScale

	[DllImport(LIB)]
	private static extern void glfwGetMonitorContentScale(IntPtr pMonitor, out float pScaleX, out float pScaleY);

	/// <summary>
	/// Retrieves the content scale for the specified monitor.
	/// </summary>
	public static (float ScaleX, float ScaleY) GetMonitorContentScale(Monitor pMonitor)
	{
		glfwGetMonitorContentScale(pMonitor, out float lScaleX, out float lScaleY);
		return (lScaleX, lScaleY);
	}

	#endregion

	#region glfwGetMonitorName

	[DllImport(LIB)]
	private static extern IntPtr glfwGetMonitorName(IntPtr pMonitor);

	/// <summary>
	/// Returns the name of the specified monitor.
	/// </summary>
	public static string? GetMonitorName(Monitor pMonitor) =>
		glfwGetMonitorName(pMonitor) is var lNamePtr && lNamePtr != IntPtr.Zero
			? Marshal.PtrToStringAnsi(lNamePtr) : null;

	#endregion

	#region glfwSetMonitorUserPointer

	[DllImport(LIB)]
	private static extern void glfwSetMonitorUserPointer(IntPtr pMonitor, IntPtr pPtr);
	
	// ToDo: glfwSetMonitorUserPointer - https://www.glfw.org/docs/3.3/group__monitor.html#ga702750e24313a686d3637297b6e85fda

	#endregion

	#region glfwGetMonitorUserPointer

	[DllImport(LIB)]
	private static extern IntPtr glfwGetMonitorUserPointer(IntPtr pMonitor);
	
	// ToDo: glfwGetMonitorUserPointer - https://www.glfw.org/docs/3.3/group__monitor.html#gac2d4209016b049222877f620010ed0d8

	#endregion

	#region glfwSetMonitorCallback

	[DllImport(LIB)]
	private static extern IntPtr glfwSetMonitorCallback(IntPtr pCallback);

	/// <summary>
	/// Sets the monitor configuration callback.
	/// </summary>
	public static MonitorCallback? SetMonitorCallback(MonitorCallback? pCallback) =>
		SetCallback(pCallback, glfwSetMonitorCallback);

	#endregion

	#region glfwGetVideoModes

	[DllImport(LIB)]
	private static extern IntPtr glfwGetVideoModes(IntPtr pMonitor, out int pCount);

	/// <summary>
	/// Returns the available video modes for the specified monitor.
	/// </summary>
	public static VideoMode[] GetVideoModes(Monitor pMonitor)
	{
		IntPtr lVidModePtr = glfwGetVideoModes(pMonitor, out int lCount);
		IntPtr[] lVideoModes = new IntPtr[lCount];
		Marshal.Copy(lVidModePtr, lVideoModes, 0, lCount);
		return lVideoModes.Select(Marshal.PtrToStructure<VideoMode>).ToArray();
	}

	#endregion

	#region glfwGetVideoMode

	[DllImport(LIB)]
	private static extern IntPtr glfwGetVideoMode(IntPtr pMonitor);

	/// <summary>
	/// Returns the current mode of the specified monitor.
	/// </summary>
	public static VideoMode? GetVideoMode(Monitor pMonitor) =>
		glfwGetVideoMode(pMonitor) is var lVideoModePtr && lVideoModePtr != IntPtr.Zero
			? Marshal.PtrToStructure<VideoMode>(lVideoModePtr) : null;

	#endregion

	#region glfwSetGamma

	[DllImport(LIB)]
	private static extern void glfwSetGamma(IntPtr pMonitor, float pGamma);

	/// <summary>
	/// Generates a gamma ramp and sets it for the specified monitor.
	/// </summary>
	public static void SetGamma(Monitor pMonitor, float pGamma) =>
		glfwSetGamma(pMonitor, pGamma);

	#endregion

	#region glfwGetGammaRamp

	[DllImport(LIB)]
	private static extern IntPtr glfwGetGammaRamp(IntPtr pMonitor);

	// ToDo: GetGammaRamp - https://www.glfw.org/docs/3.3/group__monitor.html#gab7c41deb2219bde3e1eb756ddaa9ec80

	#endregion

	#region glfwSetGammaRamp

	[DllImport(LIB)]
	private static extern void glfwSetGammaRamp(IntPtr pMonitor, IntPtr pRamp);
	
	// ToDo: glfwSetGammaRamp - https://www.glfw.org/docs/3.3/group__monitor.html#ga583f0ffd0d29613d8cd172b996bbf0dd

	#endregion

	#endregion
}
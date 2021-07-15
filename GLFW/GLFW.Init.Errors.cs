public partial class GLFW
{
	#region Macros

	/// <summary>
	/// No error has occurred.
	/// </summary>
	public const int NO_ERROR = 0;

	/// <summary>
	/// GLFW has not been initialized.
	/// </summary>
	public const int NOT_INITIALIZED = 0x00010001;

	/// <summary>
	/// No context is current for this thread.
	/// </summary>
	public const int NO_CURRENT_CONTEXT = 0x00010002;

	/// <summary>
	/// One of the arguments to the function was an invalid enum value.
	/// </summary>
	public const int INVALID_ENUM = 0x00010003;

	/// <summary>
	/// One of the arguments to the function was an invalid value.
	/// </summary>
	public const int INVALID_VALUE = 0x00010004;

	/// <summary>
	/// A memory allocation failed.
	/// </summary>
	public const int OUT_OF_MEMORY = 0x00010005;

	/// <summary>
	/// GLFW could not find support for the requested API on the system.
	/// </summary>
	public const int API_UNAVAILABLE = 0x00010006;

	/// <summary>
	/// The requested OpenGL or OpenGL ES version is not available.
	/// </summary>
	public const int VERSION_UNAVAILABLE = 0x00010007;

	/// <summary>
	/// A platform-specific error occurred that does not match any of the more specific categories.
	/// </summary>
	public const int PLATFORM_ERROR = 0x00010008;

	/// <summary>
	/// The requested format is not supported or available.
	/// </summary>
	public const int FORMAT_UNAVAILABLE = 0x00010009;

	/// <summary>
	/// The specified window does not have an OpenGL or OpenGL ES context.
	/// </summary>
	public const int NO_WINDOW_CONTEXT = 0x0001000A;

	#endregion
}

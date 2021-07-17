public class GL
{
#if Windows
	public const string LIB = "opengl32";
#elif OSX
	// ToDo: works, but there may be a better way
	public const string LIB = "/System/Library/Frameworks/OpenGL.framework/Versions/A/OpenGL";
#elif Linux
	public const string LIB = "libGL.so.1";
#endif
}
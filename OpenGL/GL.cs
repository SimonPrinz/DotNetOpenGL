public static class GL
{
#if Windows
	public const string LIB = "opengl32";
#elif OSX
	// ToDo: check on mac
	public const string LIB = "com.apple.opengl";
#elif Linux
	// ToDo: check on linux
	public const string LIB = "libGL.so";
#endif
}
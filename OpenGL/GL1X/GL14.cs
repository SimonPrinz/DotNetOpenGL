/// <summary>
/// The OpenGL functionality up to version 1.4. Includes the deprecated symbols of the Compatibility Profile.<br/>
/// Extensions promoted to core in this release:
/// <ul>
///     <li>SGIS_generate_mipmap</li>
///     <li>NV_blend_square</li>
///     <li>ARB_depth_texture and ARB_shadow</li>
///     <li>EXT_fog_coord</li>
///     <li>EXT_multi_draw_arrays</li>
///     <li>ARB_point_parameters</li>
///     <li>EXT_secondary_color</li>
///     <li>EXT_blend_func_separate</li>
///     <li>EXT_stencil_wrap</li>
///     <li>ARB_texture_env_crossbar</li>
///     <li>EXT_texture_lod_bias</li>
///     <li>ARB_texture_mirrored_repeat</li>
///     <li>ARB_window_pos</li>
/// </ul>
/// </summary>
public class GL14 : GL13
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of TexParameteri, TexParameterf, TexParameteriv, TexParameterfv,
	/// GetTexParameteriv, and GetTexParameterfv.
	/// </summary>
	public const int GENERATE_MIPMAP = 0x8191;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of Hint, and by the <c>pname</c> parameter of GetBooleanv, GetIntegerv,
	/// GetFloatv, and GetDoublev.
	/// </summary>
	public const int GENERATE_MIPMAP_HINT = 0x8192;

	/// <summary>
	/// Accepted by the <c>sfactor</c> and <c>dfactor</c> parameters of BlendFunc.
	/// </summary>
	public const int
		CONSTANT_COLOR           = 0x8001,
		ONE_MINUS_CONSTANT_COLOR = 0x8002,
		CONSTANT_ALPHA           = 0x8003,
		ONE_MINUS_CONSTANT_ALPHA = 0x8004;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of BlendEquation.
	/// </summary>
	public const int
		FUNC_ADD = 0x8006,
		MIN      = 0x8007,
		MAX      = 0x8008;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of BlendEquation.
	/// </summary>
	public const int
		FUNC_SUBTRACT         = 0x800A,
		FUNC_REVERSE_SUBTRACT = 0x800B;

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, CopyTexImage1D and CopyTexImage2D.
	/// </summary>
	public const int
		DEPTH_COMPONENT16 = 0x81A5,
		DEPTH_COMPONENT24 = 0x81A6,
		DEPTH_COMPONENT32 = 0x81A7;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetTexLevelParameterfv and GetTexLevelParameteriv.
	/// </summary>
	public const int TEXTURE_DEPTH_SIZE = 0x884A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of TexParameterf, TexParameteri, TexParameterfv, TexParameteriv,
	/// GetTexParameterfv, and GetTexParameteriv.
	/// </summary>
	public const int DEPTH_TEXTURE_MODE = 0x884B;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of TexParameterf, TexParameteri, TexParameterfv, TexParameteriv,
	/// GetTexParameterfv, and GetTexParameteriv.
	/// </summary>
	public const int
		TEXTURE_COMPARE_MODE = 0x884C,
		TEXTURE_COMPARE_FUNC = 0x884D;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of TexParameterf, TexParameteri, TexParameterfv, and TexParameteriv when
	/// the <c>pname</c> parameter is TEXTURE_COMPARE_MODE.
	/// </summary>
	public const int COMPARE_R_TO_TEXTURE = 0x884E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of Fogi and Fogf.
	/// </summary>
	public const int FOG_COORDINATE_SOURCE = 0x8450;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of Fogi and Fogf.
	/// </summary>
	public const int
		FOG_COORDINATE = 0x8451,
		FRAGMENT_DEPTH = 0x8452;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		CURRENT_FOG_COORDINATE      = 0x8453,
		FOG_COORDINATE_ARRAY_TYPE   = 0x8454,
		FOG_COORDINATE_ARRAY_STRIDE = 0x8455;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetPointerv.
	/// </summary>
	public const int FOG_COORDINATE_ARRAY_POINTER = 0x8456;

	/// <summary>
	/// Accepted by the <c>array</c> parameter of EnableClientState and DisableClientState.
	/// </summary>
	public const int FOG_COORDINATE_ARRAY = 0x8457;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of PointParameterfARB, and the <c>pname</c> of Get.
	/// </summary>
	public const int
		POINT_SIZE_MIN             = 0x8126,
		POINT_SIZE_MAX             = 0x8127,
		POINT_FADE_THRESHOLD_SIZE  = 0x8128,
		POINT_DISTANCE_ATTENUATION = 0x8129;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int COLOR_SUM = 0x8458;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		CURRENT_SECONDARY_COLOR      = 0x8459,
		SECONDARY_COLOR_ARRAY_SIZE   = 0x845A,
		SECONDARY_COLOR_ARRAY_TYPE   = 0x845B,
		SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetPointerv.
	/// </summary>
	public const int SECONDARY_COLOR_ARRAY_POINTER = 0x845D;

	/// <summary>
	/// Accepted by the <c>array</c> parameter of EnableClientState and DisableClientState.
	/// </summary>
	public const int SECONDARY_COLOR_ARRAY = 0x845E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		BLEND_DST_RGB   = 0x80C8,
		BLEND_SRC_RGB   = 0x80C9,
		BLEND_DST_ALPHA = 0x80CA,
		BLEND_SRC_ALPHA = 0x80CB;

	/// <summary>
	/// Accepted by the <c>sfail</c>, <c>dpfail</c>, and <c>dppass</c> parameter of StencilOp.
	/// </summary>
	public const int
		INCR_WRAP = 0x8507,
		DECR_WRAP = 0x8508;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of GetTexEnvfv, GetTexEnviv, TexEnvi, TexEnvf, Texenviv, and TexEnvfv.
	/// </summary>
	public const int TEXTURE_FILTER_CONTROL = 0x8500;

	/// <summary>
	/// When the <c>target</c> parameter of GetTexEnvfv, GetTexEnviv, TexEnvi, TexEnvf, TexEnviv, and TexEnvfv is
	/// TEXTURE_FILTER_CONTROL, then the value of <c>pname</c> may be.
	/// </summary>
	public const int TEXTURE_LOD_BIAS = 0x8501;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of TexParameteri and TexParameterf, and by the <c>params</c> parameter of
	/// TexParameteriv and TexParameterfv, when their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or TEXTURE_WRAP_R.
	/// </summary>
	public const int MIRRORED_REPEAT = 0x8370;

	#endregion
}
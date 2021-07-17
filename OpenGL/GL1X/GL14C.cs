/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 1.4.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>NV_blend_square</li>
/// 	<li>ARB_depth_texture and ARB_shadow</li>
/// 	<li>EXT_fog_coord</li>
/// 	<li>EXT_multi_draw_arrays</li>
/// 	<li>ARB_point_parameters</li>
/// 	<li>EXT_blend_func_separate</li>
/// 	<li>EXT_stencil_wrap</li>
/// 	<li>ARB_texture_env_crossbar</li>
/// 	<li>EXT_texture_lod_bias</li>
/// 	<li>ARB_texture_mirrored_repeat</li>
/// </ul>
/// </summary>
public class GL14C : GL13C
{
	#region Constants
	
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
    public const int
        TEXTURE_COMPARE_MODE = 0x884C,
        TEXTURE_COMPARE_FUNC = 0x884D;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of PointParameterfARB, and the <c>pname</c> of Get.
    /// </summary>
    public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;

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
    /// TexParameteriv and TexParameterfv, when their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or
    /// TEXTURE_WRAP_R.
    /// </summary>
    public const int MIRRORED_REPEAT = 0x8370;

	#endregion
}
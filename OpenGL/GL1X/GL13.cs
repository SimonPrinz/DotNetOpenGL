/// <summary>
/// The OpenGL functionality up to version 1.3. Includes the deprecated symbols of the Compatibility Profile.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_texture_compression</li>
/// 	<li>ARB_texture_cube_map</li>
/// 	<li>ARB_multisample</li>
/// 	<li>ARB_multitexture</li>
/// 	<li>ARB_texture_env_add</li>
/// 	<li>ARB_texture_env_combine</li>
/// 	<li>ARB_texture_env_dot3</li>
/// 	<li>ARB_texture_border_clamp</li>
/// 	<li>ARB_transpose_matrix</li>
/// </ul>
/// </summary>
public class GL13 : GL12
{
    #region Constants

    /// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D, and
    /// CopyTexImage2D.
    /// </summary>
    public const int
        COMPRESSED_ALPHA           = 0x84E9,
        COMPRESSED_LUMINANCE       = 0x84EA,
        COMPRESSED_LUMINANCE_ALPHA = 0x84EB,
        COMPRESSED_INTENSITY       = 0x84EC,
        COMPRESSED_RGB             = 0x84ED,
        COMPRESSED_RGBA            = 0x84EE;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of Hint and the <c>value</c> parameter of GetIntegerv, GetBooleanv,
    /// GetFloatv, and GetDoublev.
    /// </summary>
    public const int TEXTURE_COMPRESSION_HINT = 0x84EF;

    /// <summary>
    /// Accepted by the <c>value</c> parameter of GetTexLevelParameter.
    /// </summary>
    public const int
        TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0,
        TEXTURE_COMPRESSED            = 0x86A1;

    /// <summary>
    /// Accepted by the <c>value</c> parameter of GetIntegerv, GetBooleanv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2,
        COMPRESSED_TEXTURE_FORMATS     = 0x86A3;

    /// <summary>
    /// Accepted by the <c>param</c> parameters of TexGend, TexGenf, and TexGeni when <c>pname</c> parameter is
    /// TEXTURE_GEN_MODE.
    /// </summary>
    public const int
        NORMAL_MAP     = 0x8511,
        REFLECTION_MAP = 0x8512;

    /// <summary>
    /// When the <c>pname</c> parameter of TexGendv, TexGenfv, and TexGeniv is TEXTURE_GEN_MODE, then the array
    /// <c>params</c> may also contain NORMAL_MAP or REFLECTION_MAP. Accepted by the <c>cap</c> parameter of Enable,
    /// Disable, IsEnabled, and by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev,
    /// and by the <c>target</c> parameter of BindTexture, GetTexParameterfv, GetTexParameteriv, TexParameterf,
    /// TexParameteri, TexParameterfv, and TexParameteriv.
    /// </summary>
    public const int TEXTURE_CUBE_MAP = 0x8513;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of GetTexImage, GetTexLevelParameteriv, GetTexLevelParameterfv,
    /// TexImage2D, CopyTexImage2D, TexSubImage2D, and CopySubTexImage2D.
    /// </summary>
    public const int
        TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515,
        TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516,
        TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517,
        TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518,
        TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519,
        TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of GetTexLevelParameteriv, GetTexLevelParameterfv, GetTexParameteriv, and TexImage2D.
    /// </summary>
    public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
    /// </summary>
    public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

    /// <summary>
    /// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
    /// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        MULTISAMPLE              = 0x809D,
        SAMPLE_ALPHA_TO_COVERAGE = 0x809E,
        SAMPLE_ALPHA_TO_ONE      = 0x809F,
        SAMPLE_COVERAGE          = 0x80A0;

    /// <summary>
    /// Accepted by the <c>mask</c> parameter of PushAttrib.
    /// </summary>
    public const int MULTISAMPLE_BIT = 0x20000000;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
    /// </summary>
    public const int
        SAMPLE_BUFFERS         = 0x80A8,
        SAMPLES                = 0x80A9,
        SAMPLE_COVERAGE_VALUE  = 0x80AA,
        SAMPLE_COVERAGE_INVERT = 0x80AB;

    /// <summary>
    /// Accepted by the <c>texture</c> parameter of ActiveTexture and MultiTexCoord.
    /// </summary>
    public const int
        TEXTURE0  = 0x84C0,
        TEXTURE1  = 0x84C1,
        TEXTURE2  = 0x84C2,
        TEXTURE3  = 0x84C3,
        TEXTURE4  = 0x84C4,
        TEXTURE5  = 0x84C5,
        TEXTURE6  = 0x84C6,
        TEXTURE7  = 0x84C7,
        TEXTURE8  = 0x84C8,
        TEXTURE9  = 0x84C9,
        TEXTURE10 = 0x84CA,
        TEXTURE11 = 0x84CB,
        TEXTURE12 = 0x84CC,
        TEXTURE13 = 0x84CD,
        TEXTURE14 = 0x84CE,
        TEXTURE15 = 0x84CF,
        TEXTURE16 = 0x84D0,
        TEXTURE17 = 0x84D1,
        TEXTURE18 = 0x84D2,
        TEXTURE19 = 0x84D3,
        TEXTURE20 = 0x84D4,
        TEXTURE21 = 0x84D5,
        TEXTURE22 = 0x84D6,
        TEXTURE23 = 0x84D7,
        TEXTURE24 = 0x84D8,
        TEXTURE25 = 0x84D9,
        TEXTURE26 = 0x84DA,
        TEXTURE27 = 0x84DB,
        TEXTURE28 = 0x84DC,
        TEXTURE29 = 0x84DD,
        TEXTURE30 = 0x84DE,
        TEXTURE31 = 0x84DF;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
    /// </summary>
    public const int
        ACTIVE_TEXTURE        = 0x84E0,
        CLIENT_ACTIVE_TEXTURE = 0x84E1,
        MAX_TEXTURE_UNITS     = 0x84E2;

    /// <summary>
    /// Accepted by the <c>params</c> parameter of TexEnvf, TexEnvi, TexEnvfv, and TexEnviv when the <c>pname</c>
    /// parameter value is TEXTURE_ENV_MODE.
    /// </summary>
    public const int COMBINE = 0x8570;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of TexEnvf, TexEnvi, TexEnvfv, and TexEnviv when the <c>target</c>
    /// parameter value is TEXTURE_ENV.
    /// </summary>
    public const int
        COMBINE_RGB    = 0x8571,
        COMBINE_ALPHA  = 0x8572,
        SOURCE0_RGB    = 0x8580,
        SOURCE1_RGB    = 0x8581,
        SOURCE2_RGB    = 0x8582,
        SOURCE0_ALPHA  = 0x8588,
        SOURCE1_ALPHA  = 0x8589,
        SOURCE2_ALPHA  = 0x858A,
        OPERAND0_RGB   = 0x8590,
        OPERAND1_RGB   = 0x8591,
        OPERAND2_RGB   = 0x8592,
        OPERAND0_ALPHA = 0x8598,
        OPERAND1_ALPHA = 0x8599,
        OPERAND2_ALPHA = 0x859A,
        RGB_SCALE      = 0x8573;

    /// <summary>
    /// Accepted by the <c>params</c> parameter of TexEnvf, TexEnvi, TexEnvfv, and TexEnviv when the <c>pname</c>
    /// parameter value is COMBINE_RGB or COMBINE_ALPHA.
    /// </summary>
    public const int
        ADD_SIGNED  = 0x8574,
        INTERPOLATE = 0x8575,
        SUBTRACT    = 0x84E7;

    /// <summary>
    /// Accepted by the <c>params</c> parameter of TexEnvf, TexEnvi, TexEnvfv, and TexEnviv when the <c>pname</c>
    /// parameter value is SOURCE0_RGB, SOURCE1_RGB, SOURCE2_RGB, SOURCE0_ALPHA, SOURCE1_ALPHA, or SOURCE2_ALPHA.
    /// </summary>
    public const int
        CONSTANT      = 0x8576,
        PRIMARY_COLOR = 0x8577,
        PREVIOUS      = 0x8578;

    /// <summary>
    /// Accepted by the <c>params</c> parameter of TexEnvf, TexEnvi, TexEnvfv, and TexEnviv when the <c>pname</c>
    /// parameter value is COMBINE_RGB_ARB.
    /// </summary>
    public const int
        DOT3_RGB  = 0x86AE,
        DOT3_RGBA = 0x86AF;

    /// <summary>
    /// Accepted by the <c>param</c> parameter of TexParameteri and TexParameterf, and by the <c>params</c> parameter of
    /// TexParameteriv and TexParameterfv, when their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or
    /// TEXTURE_WRAP_R.
    /// </summary>
    public const int CLAMP_TO_BORDER = 0x812D;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        TRANSPOSE_MODELVIEW_MATRIX  = 0x84E3,
        TRANSPOSE_PROJECTION_MATRIX = 0x84E4,
        TRANSPOSE_TEXTURE_MATRIX    = 0x84E5,
        TRANSPOSE_COLOR_MATRIX      = 0x84E6;

    #endregion
}
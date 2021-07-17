/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 1.3.<br/>
/// Extensions promoted to core in this release:
/// <ul>
///     <li>ARB_texture_compression</li>
///     <li>ARB_texture_cube_map</li>
///     <li>ARB_multisample</li>
///     <li>ARB_multitexture</li>
///     <li>ARB_texture_border_clamp</li>
/// </ul>
/// </summary>
public class GL13C : GL12C
{
    #region Constants

    /// <summary>
    /// Accepted by the internalformat parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D, and
    /// CopyTexImage2D.
    /// </summary>
    public const int
        COMPRESSED_RGB  = 0x84ED,
        COMPRESSED_RGBA = 0x84EE;

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
    /// Accepted by the <c>target</c> parameter of GetTexLevelParameteriv, GetTexLevelParameterfv, GetTexParameteriv,
    /// and TexImage2D.
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
    public const int ACTIVE_TEXTURE = 0x84E0;

    /// <summary>
    /// Accepted by the <c>param</c> parameter of TexParameteri and TexParameterf, and by the <c>params</c> parameter of
    /// TexParameteriv and TexParameterfv, when their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or
    /// TEXTURE_WRAP_R.
    /// </summary>
    public const int CLAMP_TO_BORDER = 0x812D;

    #endregion
}
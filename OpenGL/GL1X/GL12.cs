/// <summary>
/// The OpenGL functionality up to version 1.2. Includes the deprecated symbols of the Compatibility Profile.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>EXT_texture3D</li>
/// 	<li>EXT_bgra</li>
/// 	<li>EXT_packed_pixels</li>
/// 	<li>EXT_rescale_normal</li>
/// 	<li>EXT_separate_specular_color</li>
/// 	<li>SGIS_texture_edge_clamp</li>
/// 	<li>SGIS_texture_lod</li>
/// 	<li>EXT_draw_range_elements</li>
/// </ul>
/// Extensions part of the imaging subset:
/// <ul>
/// 	<li>EXT_color_table and EXT_color_subtable</li>
/// 	<li>EXT_convolution and HP_convolution_border_modes</li>
/// 	<li>SGI_color_matrix</li>
/// 	<li>EXT_histogram</li>
/// 	<li>EXT_blend_color</li>
/// 	<li>EXT_blend_minmax and EXT_blend_subtract</li>
/// </ul>
/// </summary>
public class GL12 : GL11
{
    #region Constants

    /// <summary>
    /// Aliases for smooth points and lines.
    /// </summary>
    public const int
        ALIASED_POINT_SIZE_RANGE      = 0x846D,
        ALIASED_LINE_WIDTH_RANGE      = 0x846E,
        SMOOTH_POINT_SIZE_RANGE       = 0xB12,
        SMOOTH_POINT_SIZE_GRANULARITY = 0xB13,
        SMOOTH_LINE_WIDTH_RANGE       = 0xB22,
        SMOOTH_LINE_WIDTH_GRANULARITY = 0xB23;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int TEXTURE_BINDING_3D = 0x806A;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev,
    /// and by the <c>pname</c> parameter of PixelStore.
    /// </summary>
    public const int
        PACK_SKIP_IMAGES    = 0x806B,
        PACK_IMAGE_HEIGHT   = 0x806C,
        UNPACK_SKIP_IMAGES  = 0x806D,
        UNPACK_IMAGE_HEIGHT = 0x806E;

    /// <summary>
    /// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, by the <c>pname</c> parameter of
    /// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev, and by the <c>target</c> parameter of TexImage3D,
    /// GetTexImage, GetTexLevelParameteriv, GetTexLevelParameterfv, GetTexParameteriv, and GetTexParameterfv.
    /// </summary>
    public const int TEXTURE_3D = 0x806F;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of TexImage3D, GetTexLevelParameteriv, and GetTexLevelParameterfv.
    /// </summary>
    public const int PROXY_TEXTURE_3D = 0x8070;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetTexLevelParameteriv and GetTexLevelParameterfv.
    /// </summary>
    public const int TEXTURE_DEPTH = 0x8071;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of TexParameteriv, TexParameterfv, GetTexParameteriv, and GetTexParameterfv.
    /// </summary>
    public const int TEXTURE_WRAP_R = 0x8072;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int MAX_3D_TEXTURE_SIZE = 0x8073;

    /// <summary>
    /// Accepted by the <c>format</c> parameter of DrawPixels, GetTexImage, ReadPixels, TexImage1D, and TexImage2D.
    /// </summary>
    public const int
        BGR  = 0x80E0,
        BGRA = 0x80E1;

    /// <summary>
    /// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, GetTexImage, TexImage3D,
    /// TexSubImage1D, TexSubImage2D, TexSubImage3D, GetHistogram, GetMinmax, ConvolutionFilter1D, ConvolutionFilter2D,
    /// ConvolutionFilter3D, GetConvolutionFilter, SeparableFilter2D, SeparableFilter3D, GetSeparableFilter, ColorTable,
    /// GetColorTable, TexImage4D, and TexSubImage4D.
    /// </summary>
    public const int
        UNSIGNED_BYTE_3_3_2         = 0x8032,
        UNSIGNED_BYTE_2_3_3_REV     = 0x8362,
        UNSIGNED_SHORT_5_6_5        = 0x8363,
        UNSIGNED_SHORT_5_6_5_REV    = 0x8364,
        UNSIGNED_SHORT_4_4_4_4      = 0x8033,
        UNSIGNED_SHORT_4_4_4_4_REV  = 0x8365,
        UNSIGNED_SHORT_5_5_5_1      = 0x8034,
        UNSIGNED_SHORT_1_5_5_5_REV  = 0x8366,
        UNSIGNED_INT_8_8_8_8        = 0x8035,
        UNSIGNED_INT_8_8_8_8_REV    = 0x8367,
        UNSIGNED_INT_10_10_10_2     = 0x8036,
        UNSIGNED_INT_2_10_10_10_REV = 0x8368;

    /// <summary>
    /// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the {@code pname} parameter of
    /// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int RESCALE_NORMAL = 0x803A;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of LightModel*, and also by the <c>pname</c> parameter of GetBooleanv,
    /// GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

    /// <summary>
    /// Accepted by the <c>param</c> parameter of LightModel* when <c>pname</c> is  LIGHT_MODEL_COLOR_CONTROL.
    /// </summary>
    public const int
        SINGLE_COLOR            = 0x81F9,
        SEPARATE_SPECULAR_COLOR = 0x81FA;

    /// <summary>
    /// Accepted by the <c>param</c> parameter of TexParameteri and TexParameterf, and by the <c>params</c> parameter of
    /// TexParameteriv and TexParameterfv, when their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or
    /// TEXTURE_WRAP_R.
    /// </summary>
    public const int CLAMP_TO_EDGE = 0x812F;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of TexParameteri, TexParameterf, TexParameteriv, TexParameterfv,
    /// GetTexParameteriv, and GetTexParameterfv.
    /// </summary>
    public const int
        TEXTURE_MIN_LOD    = 0x813A,
        TEXTURE_MAX_LOD    = 0x813B,
        TEXTURE_BASE_LEVEL = 0x813C,
        TEXTURE_MAX_LEVEL  = 0x813D;

    /// <summary>
    /// Recommended maximum amounts of vertex and index data.
    /// </summary>
    public const int
        MAX_ELEMENTS_VERTICES = 0x80E8,
        MAX_ELEMENTS_INDICES  = 0x80E9;

    #endregion
}
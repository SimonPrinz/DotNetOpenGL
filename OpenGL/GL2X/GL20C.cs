/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 2.0.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_shader_objects</li>
/// 	<li>ARB_vertex_shader and ARB_fragment_shader</li>
/// 	<li>ARB_shading_language_100</li>
/// 	<li>ARB_draw_buffers</li>
/// 	<li>ARB_texture_non_power_of_two</li>
/// 	<li>ARB_point_sprite</li>
/// 	<li>ATI_separate_stencil and EXT_stencil_two_side</li>
/// </ul>
/// </summary>
public class GL20C : GL15C
{
	#region Constants
    
    /// <summary>
    /// Accepted by the <c>name</c> parameter of GetString.
    /// </summary>
    public const int SHADING_LANGUAGE_VERSION = 0x8B8C;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetInteger.
    /// </summary>
    public const int CURRENT_PROGRAM = 0x8B8D;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetShaderiv.
    /// </summary>
    public const int
        SHADER_TYPE                 = 0x8B4F,
        DELETE_STATUS               = 0x8B80,
        COMPILE_STATUS              = 0x8B81,
        LINK_STATUS                 = 0x8B82,
        VALIDATE_STATUS             = 0x8B83,
        INFO_LOG_LENGTH             = 0x8B84,
        ATTACHED_SHADERS            = 0x8B85,
        ACTIVE_UNIFORMS             = 0x8B86,
        ACTIVE_UNIFORM_MAX_LENGTH   = 0x8B87,
        ACTIVE_ATTRIBUTES           = 0x8B89,
        ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A,
        SHADER_SOURCE_LENGTH        = 0x8B88;

    /// <summary>
    /// Returned by the <c>type</c> parameter of GetActiveUniform.
    /// </summary>
    public const int
        FLOAT_VEC2        = 0x8B50,
        FLOAT_VEC3        = 0x8B51,
        FLOAT_VEC4        = 0x8B52,
        INT_VEC2          = 0x8B53,
        INT_VEC3          = 0x8B54,
        INT_VEC4          = 0x8B55,
        BOOL              = 0x8B56,
        BOOL_VEC2         = 0x8B57,
        BOOL_VEC3         = 0x8B58,
        BOOL_VEC4         = 0x8B59,
        FLOAT_MAT2        = 0x8B5A,
        FLOAT_MAT3        = 0x8B5B,
        FLOAT_MAT4        = 0x8B5C,
        SAMPLER_1D        = 0x8B5D,
        SAMPLER_2D        = 0x8B5E,
        SAMPLER_3D        = 0x8B5F,
        SAMPLER_CUBE      = 0x8B60,
        SAMPLER_1D_SHADOW = 0x8B61,
        SAMPLER_2D_SHADOW = 0x8B62;

    /// <summary>
    /// Accepted by the <c>type</c> argument of CreateShader and returned by the <c>params</c> parameter of GetShaderiv.
    /// </summary>
    public const int VERTEX_SHADER = 0x8B31;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        MAX_VERTEX_UNIFORM_COMPONENTS    = 0x8B4A,
        MAX_VARYING_FLOATS               = 0x8B4B,
        MAX_VERTEX_ATTRIBS               = 0x8869,
        MAX_TEXTURE_IMAGE_UNITS          = 0x8872,
        MAX_VERTEX_TEXTURE_IMAGE_UNITS   = 0x8B4C,
        MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

    /// <summary>
    /// Accepted by the <c>cap</c> parameter of Disable, Enable, and IsEnabled, and by the <c>pname</c> parameter of
    /// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetVertexAttrib{dfi}v.
    /// </summary>
    public const int
        VERTEX_ATTRIB_ARRAY_ENABLED    = 0x8622,
        VERTEX_ATTRIB_ARRAY_SIZE       = 0x8623,
        VERTEX_ATTRIB_ARRAY_STRIDE     = 0x8624,
        VERTEX_ATTRIB_ARRAY_TYPE       = 0x8625,
        VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
        CURRENT_VERTEX_ATTRIB          = 0x8626;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetVertexAttribPointerv.
    /// </summary>
    public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

    /// <summary>
    /// Accepted by the <c>type</c> argument of CreateShader and returned by the <c>params</c> parameter of GetShaderiv.
    /// </summary>
    public const int FRAGMENT_SHADER = 0x8B30;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of Hint and the <c>pname</c> parameter of GetBooleanv, GetIntegerv,
    /// GetFloatv, and GetDoublev.
    /// </summary>
    public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

    /// <summary>
    /// Accepted by the <c>pname</c> parameters of GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        MAX_DRAW_BUFFERS = 0x8824,
        DRAW_BUFFER0     = 0x8825,
        DRAW_BUFFER1     = 0x8826,
        DRAW_BUFFER2     = 0x8827,
        DRAW_BUFFER3     = 0x8828,
        DRAW_BUFFER4     = 0x8829,
        DRAW_BUFFER5     = 0x882A,
        DRAW_BUFFER6     = 0x882B,
        DRAW_BUFFER7     = 0x882C,
        DRAW_BUFFER8     = 0x882D,
        DRAW_BUFFER9     = 0x882E,
        DRAW_BUFFER10    = 0x882F,
        DRAW_BUFFER11    = 0x8830,
        DRAW_BUFFER12    = 0x8831,
        DRAW_BUFFER13    = 0x8832,
        DRAW_BUFFER14    = 0x8833,
        DRAW_BUFFER15    = 0x8834;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of PointParameter{if}v.
    /// </summary>
    public const int POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

    /// <summary>
    /// Accepted by the <c>param</c> parameter of PointParameter{if}v.
    /// </summary>
    public const int
        LOWER_LEFT = 0x8CA1,
        UPPER_LEFT = 0x8CA2;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        BLEND_EQUATION_RGB   = 0x8009,
        BLEND_EQUATION_ALPHA = 0x883D;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetIntegerv.
    /// </summary>
    public const int
        STENCIL_BACK_FUNC            = 0x8800,
        STENCIL_BACK_FAIL            = 0x8801,
        STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802,
        STENCIL_BACK_PASS_DEPTH_PASS = 0x8803,
        STENCIL_BACK_REF             = 0x8CA3,
        STENCIL_BACK_VALUE_MASK      = 0x8CA4,
        STENCIL_BACK_WRITEMASK       = 0x8CA5;

	#endregion
}
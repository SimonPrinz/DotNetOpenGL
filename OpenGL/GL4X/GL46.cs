/// <summary>
/// The OpenGL functionality up to version 4.6. Includes the deprecated symbols of the Compatibility Profile.
/// OpenGL 4.6 implementations support revision 4.60 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_indirect_parameters</li>
/// 	<li>ARB_pipeline_statistics_query</li>
/// 	<li>ARB_polygon_offset_clamp</li>
/// 	<li>KHR_no_error</li>
/// 	<li>ARB_shader_atomic_counter_ops</li>
/// 	<li>ARB_shader_draw_parameters</li>
/// 	<li>ARB_shader_group_vote</li>
/// 	<li>ARB_spirv</li>
/// 	<li>ARB_spirv_extensions</li>
/// 	<li>ARB_texture_filter_anisotropic</li>
/// 	<li>ARB_transform_feedback_overflow_query</li>
/// </ul>
/// </summary>
public class GL46 : GL45
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, GetBufferPointerv, MapBufferRange, FlushMappedBufferRange, GetBufferParameteriv, and
	/// CopyBufferSubData.
	/// </summary>
	public const int PARAMETER_BUFFER = 0x80EE;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetIntegerv, GetBooleanv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int PARAMETER_BUFFER_BINDING = 0x80EF;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, GetQueryiv, BeginQueryIndexed, EndQueryIndexed
	/// and GetQueryIndexediv.
	/// </summary>
	public const int
		VERTICES_SUBMITTED = 0x82EE,
		PRIMITIVES_SUBMITTED = 0x82EF,
		VERTEX_SHADER_INVOCATIONS = 0x82F0,
		TESS_CONTROL_SHADER_PATCHES = 0x82F1,
		TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2,
		GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3,
		FRAGMENT_SHADER_INVOCATIONS = 0x82F4,
		COMPUTE_SHADER_INVOCATIONS = 0x82F5,
		CLIPPING_INPUT_PRIMITIVES = 0x82F6,
		CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int POLYGON_OFFSET_CLAMP = 0x8E1B;

	/// <summary>
	/// If set in CONTEXT_FLAGS, then no error behavior is enabled for this context.
	/// </summary>
	public const int CONTEXT_FLAG_NO_ERROR_BIT = 0x8;

	/// <summary>
	/// Accepted by the <c>binaryformat</c> parameter of ShaderBinary.
	/// </summary>
	public const int SHADER_BINARY_FORMAT_SPIR_V = 0x9551;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetShaderiv.
	/// </summary>
	public const int SPIR_V_BINARY = 0x9552;

	/// <summary>
	/// Accepted by the <c>name</c> parameter of GetStringi.
	/// </summary>
	public const int SPIR_V_EXTENSIONS = 0x9553;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv.
	/// </summary>
	public const int NUM_SPIR_V_EXTENSIONS = 0x9554;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetTexParameterfv, GetTexParameteriv, TexParameterf, TexParameterfv,
	/// TexParameteri, and TexParameteriv.
	/// </summary>
	public const int TEXTURE_MAX_ANISOTROPY = 0x84FE;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetBooleanv, GetDoublev, GetFloatv, and GetIntegerv.
	/// </summary>
	public const int MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, GetQueryiv, BeginQueryIndexed, EndQueryIndexed
	/// and GetQueryIndexediv.
	/// </summary>
	public const int
		TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC,
		TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;

	#endregion
}
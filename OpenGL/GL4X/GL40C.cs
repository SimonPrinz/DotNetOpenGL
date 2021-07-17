/// <summary>
/// The OpenGL functionality up to version 4.0. Includes only Core Profile symbols.
/// OpenGL 4.0 implementations support revision 4.00 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_texture_query_lod</li>
/// 	<li>ARB_draw_buffers_blend</li>
/// 	<li>ARB_draw_indirect</li>
/// 	<li>ARB_gpu_shader5</li>
/// 	<li>ARB_gpu_shader_fp64</li>
/// 	<li>ARB_sample_shading</li>
/// 	<li>ARB_shader_subroutine</li>
/// 	<li>ARB_tessellation_shader</li>
/// 	<li>ARB_texture_buffer_object_rgb32</li>
/// 	<li>ARB_texture_cube_map_array</li>
/// 	<li>ARB_texture_gather</li>
/// 	<li>ARB_transform_feedback2</li>
/// 	<li>ARB_transform_feedback3</li>
/// </ul>
/// </summary>
public class GL40C : GL33C
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, GetBufferPointerv, MapBufferRange, FlushMappedBufferRange, GetBufferParameteriv, and
	/// CopyBufferSubData.
	/// </summary>
	public const int DRAW_INDIRECT_BUFFER = 0x8F3F;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetIntegerv, GetBooleanv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int GEOMETRY_SHADER_INVOCATIONS = 0x887F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, GetDoublev, and GetInteger64v.
	/// </summary>
	public const int
		MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A,
		MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B,
		MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C,
		FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;

	/// <summary>
	/// Returned in the <c>type</c> parameter of GetActiveUniform, and GetTransformFeedbackVarying.
	/// </summary>
	public const int
		DOUBLE_VEC2 = 0x8FFC,
		DOUBLE_VEC3 = 0x8FFD,
		DOUBLE_VEC4 = 0x8FFE,
		DOUBLE_MAT2 = 0x8F46,
		DOUBLE_MAT3 = 0x8F47,
		DOUBLE_MAT4 = 0x8F48,
		DOUBLE_MAT2x3 = 0x8F49,
		DOUBLE_MAT2x4 = 0x8F4A,
		DOUBLE_MAT3x2 = 0x8F4B,
		DOUBLE_MAT3x4 = 0x8F4C,
		DOUBLE_MAT4x2 = 0x8F4D,
		DOUBLE_MAT4x3 = 0x8F4E;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int SAMPLE_SHADING = 0x8C36;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int MIN_SAMPLE_SHADING_VALUE = 0x8C37;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramStageiv.
	/// </summary>
	public const int
		ACTIVE_SUBROUTINES = 0x8DE5,
		ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6,
		ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47,
		ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48,
		ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, GetDoublev, and GetInteger64v.
	/// </summary>
	public const int
		MAX_SUBROUTINES = 0x8DE7,
		MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveSubroutineUniformiv.
	/// </summary>
	public const int
		NUM_COMPATIBLE_SUBROUTINES = 0x8E4A,
		COMPATIBLE_SUBROUTINES = 0x8E4B;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of Begin and all vertex array functions that implicitly call Begin.
	/// </summary>
	public const int PATCHES = 0xE;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of PatchParameteri, GetBooleanv, GetDoublev, GetFloatv, GetIntegerv, and
	/// GetInteger64v.
	/// </summary>
	public const int PATCH_VERTICES = 0x8E72;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of PatchParameterfv, GetBooleanv, GetDoublev, GetFloatv, and GetIntegerv,
	/// and GetInteger64v.
	/// </summary>
	public const int
		PATCH_DEFAULT_INNER_LEVEL = 0x8E73,
		PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int
		TESS_CONTROL_OUTPUT_VERTICES = 0x8E75,
		TESS_GEN_MODE = 0x8E76,
		TESS_GEN_SPACING = 0x8E77,
		TESS_GEN_VERTEX_ORDER = 0x8E78,
		TESS_GEN_POINT_MODE = 0x8E79;

	/// <summary>
	/// Returned by GetProgramiv when <c>pname</c> is TESS_GEN_MODE.
	/// </summary>
	public const int ISOLINES = 0x8E7A;

	/// <summary>
	/// Returned by GetProgramiv when <c>pname</c> is TESS_GEN_SPACING.
	/// </summary>
	public const int
		FRACTIONAL_ODD = 0x8E7B,
		FRACTIONAL_EVEN = 0x8E7C;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetFloatv, GetIntegerv, and GetInteger64v.
	/// </summary>
	public const int
		MAX_PATCH_VERTICES = 0x8E7D,
		MAX_TESS_GEN_LEVEL = 0x8E7E,
		MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F,
		MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80,
		MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81,
		MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82,
		MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83,
		MAX_TESS_PATCH_COMPONENTS = 0x8E84,
		MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85,
		MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86,
		MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89,
		MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A,
		MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C,
		MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D,
		MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E,
		MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveUniformBlockiv.
	/// </summary>
	public const int
		UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0,
		UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of CreateShader and returned by the <c>params</c> parameter of GetShaderiv.
	/// </summary>
	public const int
		TESS_EVALUATION_SHADER = 0x8E87,
		TESS_CONTROL_SHADER = 0x8E88;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexParameteri, TexParameteriv, TexParameterf, TexParameterfv,
	/// BindTexture, and GenerateMipmap.
	/// </summary>
	public const int TEXTURE_CUBE_MAP_ARRAY = 0x9009;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv and GetFloatv.
	/// </summary>
	public const int TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexImage3D, TexSubImage3D, CompressedTeximage3D,
	/// CompressedTexSubImage3D and CopyTexSubImage3D.
	/// </summary>
	public const int PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		SAMPLER_CUBE_MAP_ARRAY = 0x900C,
		SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,
		INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,
		UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E,
		MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindTransformFeedback.
	/// </summary>
	public const int TRANSFORM_FEEDBACK = 0x8E22;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int
		TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23,
		TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24,
		TRANSFORM_FEEDBACK_BINDING = 0x8E25;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int
		MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70,
		MAX_VERTEX_STREAMS = 0x8E71;

	#endregion
}
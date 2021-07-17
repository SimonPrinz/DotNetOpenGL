/// <summary>
/// The OpenGL functionality up to version 4.1. Includes the deprecated symbols of the Compatibility Profile.
/// OpenGL 4.1 implementations support revision 4.10 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_ES2_compatibility</li>
/// 	<li>ARB_get_program_binary</li>
/// 	<li>ARB_separate_shader_objects</li>
/// 	<li>ARB_shader_precision</li>
/// 	<li>ARB_vertex_attrib_64bit</li>
/// 	<li>ARB_viewport_array</li>
/// </ul>
/// </summary>
public class GL41 : GL40
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		SHADER_COMPILER = 0x8DFA,
		SHADER_BINARY_FORMATS = 0x8DF8,
		NUM_SHADER_BINARY_FORMATS = 0x8DF9,
		MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB,
		MAX_VARYING_VECTORS = 0x8DFC,
		MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD,
		IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,
		IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of VertexAttribPointer.
	/// </summary>
	public const int FIXED = 0x140C;

	/// <summary>
	/// Accepted by the <c>precisiontype</c> parameter of GetShaderPrecisionFormat.
	/// </summary>
	public const int
		LOW_FLOAT = 0x8DF0,
		MEDIUM_FLOAT = 0x8DF1,
		HIGH_FLOAT = 0x8DF2,
		LOW_INT = 0x8DF3,
		MEDIUM_INT = 0x8DF4,
		HIGH_INT = 0x8DF5;

	/// <summary>
	/// Accepted by the <c>format</c> parameter of most commands taking sized internal formats.
	/// </summary>
	public const int RGB565 = 0x8D62;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of ProgramParameteri and GetProgramiv.
	/// </summary>
	public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int PROGRAM_BINARY_LENGTH = 0x8741;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv and GetDoublev.
	/// </summary>
	public const int
		NUM_PROGRAM_BINARY_FORMATS = 0x87FE,
		PROGRAM_BINARY_FORMATS = 0x87FF;

	/// <summary>
	/// Accepted by <c>stages</c> parameter to UseProgramStages.
	/// </summary>
	public const int
		VERTEX_SHADER_BIT = 0x1,
		FRAGMENT_SHADER_BIT = 0x2,
		GEOMETRY_SHADER_BIT = 0x4,
		TESS_CONTROL_SHADER_BIT = 0x8,
		TESS_EVALUATION_SHADER_BIT = 0x10;
	
	/// <summary>
	/// Accepted by <c>stages</c> parameter to UseProgramStages.
	/// </summary>
	public const uint ALL_SHADER_BITS = 0xFFFFFFFF;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of ProgramParameteri and GetProgramiv.
	/// </summary>
	public const int PROGRAM_SEPARABLE = 0x8258;

	/// <summary>
	/// Accepted by <c>type</c> parameter to GetProgramPipelineiv.
	/// </summary>
	public const int ACTIVE_PROGRAM = 0x8259;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int PROGRAM_PIPELINE_BINDING = 0x825A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, GetDoublev and GetInteger64v.
	/// </summary>
	public const int
		MAX_VIEWPORTS = 0x825B,
		VIEWPORT_SUBPIXEL_BITS = 0x825C,
		VIEWPORT_BOUNDS_RANGE = 0x825D,
		LAYER_PROVOKING_VERTEX = 0x825E,
		VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

	/// <summary>
	/// Returned in the <c>data</c> parameter from a Get query with a <c>pname</c> of LAYER_PROVOKING_VERTEX or
	/// VIEWPORT_INDEX_PROVOKING_VERTEX.
	/// </summary>
	public const int UNDEFINED_VERTEX = 0x8260;

	#endregion
}
/// <summary>
/// The OpenGL functionality up to version 4.2. Includes only Core Profile symbols.
/// OpenGL 4.2 implementations support revision 4.20 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_texture_compression_bptc</li>
/// 	<li>ARB_compressed_texture_pixel_storage</li>
/// 	<li>ARB_shader_atomic_counters</li>
/// 	<li>ARB_texture_storage</li>
/// 	<li>ARB_transform_feedback_instanced</li>
/// 	<li>ARB_base_instance</li>
/// 	<li>ARB_shader_image_load_store</li>
/// 	<li>ARB_conservative_depth and ARB_shading_language_420pack</li>
/// 	<li>ARB_internalformat_query</li>
/// 	<li>ARB_map_buffer_alignment</li>
/// </ul>
/// </summary>
public class GL42C : GL41C
{
	#region Constants

	/// <summary>
	/// Renamed tokens.
	/// </summary>
	public const int
		COPY_READ_BUFFER_BINDING = GL31.COPY_READ_BUFFER,
		COPY_WRITE_BUFFER_BINDING = GL31.COPY_WRITE_BUFFER,
		TRANSFORM_FEEDBACK_ACTIVE = GL40.TRANSFORM_FEEDBACK_BUFFER_ACTIVE,
		TRANSFORM_FEEDBACK_PAUSED = GL40.TRANSFORM_FEEDBACK_BUFFER_PAUSED;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage2D, TexImage3D, CopyTexImage2D, CopyTexImage3D,
	/// CompressedTexImage2D, and CompressedTexImage3D and the <c>format</c> parameter of CompressedTexSubImage2D and
	/// CompressedTexSubImage3D.
	/// </summary>
	public const int
		COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C,
		COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D,
		COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E,
		COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of PixelStore[fi], GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv,
	/// and GetDoublev.
	/// </summary>
	public const int
		UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127,
		UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128,
		UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129,
		UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A,
		PACK_COMPRESSED_BLOCK_WIDTH = 0x912B,
		PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C,
		PACK_COMPRESSED_BLOCK_DEPTH = 0x912D,
		PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindBufferBase and BindBufferRange.
	/// </summary>
	public const int ATOMIC_COUNTER_BUFFER = 0x92C0;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleani_v, GetIntegeri_v, GetFloati_v, GetDoublei_v,
	/// GetInteger64i_v, GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, GetDoublev, and
	/// GetActiveAtomicCounterBufferiv.
	/// </summary>
	public const int ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegeri_64v.
	/// </summary>
	public const int
		ATOMIC_COUNTER_BUFFER_START = 0x92C2,
		ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveAtomicCounterBufferiv.
	/// </summary>
	public const int
		ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4,
		ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5,
		ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6,
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7,
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8,
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9,
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA,
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC,
		MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD,
		MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE,
		MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF,
		MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0,
		MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1,
		MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2,
		MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3,
		MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4,
		MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5,
		MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6,
		MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7,
		MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8,
		MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveUniformsiv.
	/// </summary>
	public const int UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

	/// <summary>
	/// Returned in <c>params</c> by GetActiveUniform and GetActiveUniformsiv.
	/// </summary>
	public const int UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetTexParameter{if}v.
	/// </summary>
	public const int TEXTURE_IMMUTABLE_FORMAT = 0x912F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, GetDoublev, and GetInteger64v.
	/// </summary>
	public const int
		MAX_IMAGE_UNITS = 0x8F38,
		MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39,
		MAX_IMAGE_SAMPLES = 0x906D,
		MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA,
		MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB,
		MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC,
		MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD,
		MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE,
		MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of GetIntegeri_v and GetBooleani_v.
	/// </summary>
	public const int
		IMAGE_BINDING_NAME = 0x8F3A,
		IMAGE_BINDING_LEVEL = 0x8F3B,
		IMAGE_BINDING_LAYERED = 0x8F3C,
		IMAGE_BINDING_LAYER = 0x8F3D,
		IMAGE_BINDING_ACCESS = 0x8F3E,
		IMAGE_BINDING_FORMAT = 0x906E;

	/// <summary>
	/// Accepted by the <c>barriers</c> parameter of MemoryBarrier.
	/// </summary>
	public const int
		VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x1,
		ELEMENT_ARRAY_BARRIER_BIT = 0x2,
		UNIFORM_BARRIER_BIT = 0x4,
		TEXTURE_FETCH_BARRIER_BIT = 0x8,
		SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x20,
		COMMAND_BARRIER_BIT = 0x40,
		PIXEL_BUFFER_BARRIER_BIT = 0x80,
		TEXTURE_UPDATE_BARRIER_BIT = 0x100,
		BUFFER_UPDATE_BARRIER_BIT = 0x200,
		FRAMEBUFFER_BARRIER_BIT = 0x400,
		TRANSFORM_FEEDBACK_BARRIER_BIT = 0x800,
		ATOMIC_COUNTER_BARRIER_BIT = 0x1000;
	
	/// <summary>
	/// Accepted by the <c>barriers</c> parameter of MemoryBarrier.
	/// </summary>
	public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		IMAGE_1D = 0x904C,
		IMAGE_2D = 0x904D,
		IMAGE_3D = 0x904E,
		IMAGE_2D_RECT = 0x904F,
		IMAGE_CUBE = 0x9050,
		IMAGE_BUFFER = 0x9051,
		IMAGE_1D_ARRAY = 0x9052,
		IMAGE_2D_ARRAY = 0x9053,
		IMAGE_CUBE_MAP_ARRAY = 0x9054,
		IMAGE_2D_MULTISAMPLE = 0x9055,
		IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056,
		INT_IMAGE_1D = 0x9057,
		INT_IMAGE_2D = 0x9058,
		INT_IMAGE_3D = 0x9059,
		INT_IMAGE_2D_RECT = 0x905A,
		INT_IMAGE_CUBE = 0x905B,
		INT_IMAGE_BUFFER = 0x905C,
		INT_IMAGE_1D_ARRAY = 0x905D,
		INT_IMAGE_2D_ARRAY = 0x905E,
		INT_IMAGE_CUBE_MAP_ARRAY = 0x905F,
		INT_IMAGE_2D_MULTISAMPLE = 0x9060,
		INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061,
		UNSIGNED_INT_IMAGE_1D = 0x9062,
		UNSIGNED_INT_IMAGE_2D = 0x9063,
		UNSIGNED_INT_IMAGE_3D = 0x9064,
		UNSIGNED_INT_IMAGE_2D_RECT = 0x9065,
		UNSIGNED_INT_IMAGE_CUBE = 0x9066,
		UNSIGNED_INT_IMAGE_BUFFER = 0x9067,
		UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068,
		UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069,
		UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A,
		UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B,
		UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetTexParameteriv, GetTexParameterfv, GetTexParameterIiv, and
	/// GetTexParameterIuiv.
	/// </summary>
	public const int IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

	/// <summary>
	/// Returned in the <c>data</c> parameter of GetTexParameteriv, GetTexParameterfv, GetTexParameterIiv, and
	/// GetTexParameterIuiv when <c>value</c> is IMAGE_FORMAT_COMPATIBILITY_TYPE.
	/// </summary>
	public const int
		IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8,
		IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetInternalformativ.
	/// </summary>
	public const int NUM_SAMPLE_COUNTS = 0x9380;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

	#endregion
}
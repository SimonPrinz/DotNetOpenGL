/// <summary>
/// The OpenGL functionality up to version 4.3. Includes only Core Profile symbols.
/// OpenGL 4.3 implementations support revision 4.30 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_arrays_of_arrays</li>
/// 	<li>ARB_ES3_compatibility</li>
/// 	<li>ARB_clear_buffer_object</li>
/// 	<li>ARB_compute_shader</li>
/// 	<li>ARB_copy_image</li>
/// 	<li>ARB_debug_group</li>
/// 	<li>EXT_debug_label</li>
/// 	<li>ARB_debug_output2</li>
/// 	<li>ARB_debug_output</li>
/// 	<li>ARB_explicit_uniform_location</li>
/// 	<li>ARB_fragment_layer_viewport</li>
/// 	<li>ARB_framebuffer_no_attachments</li>
/// 	<li>ARB_internalformat_query2</li>
/// 	<li>ARB_invalidate_subdata</li>
/// 	<li>ARB_multi_draw_indirect</li>
/// 	<li>ARB_program_interface_query</li>
/// 	<li>ARB_robust_buffer_access_behavior</li>
/// 	<li>ARB_shader_image_size</li>
/// 	<li>ARB_shader_storage_buffer_object</li>
/// 	<li>ARB_stencil_texturing</li>
/// 	<li>ARB_texture_buffer_range</li>
/// 	<li>ARB_texture_query_levels</li>
/// 	<li>ARB_texture_storage_multisample</li>
/// 	<li>ARB_texture_view</li>
/// 	<li>ARB_vertex_attrib_binding</li>
/// </ul>
/// </summary>
public class GL43C : GL42C
{
	#region Constants

	/// <summary>
	/// No. of supported Shading Language Versions. Accepted by the <c>pname</c> parameter of GetIntegerv.
	/// </summary>
	public const int NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;

	/// <summary>
	/// Vertex attrib array has unconverted doubles. Accepted by the <c>pname</c> parameter of GetVertexAttribiv.
	/// </summary>
	public const int VERTEX_ATTRIB_ARRAY_LONG = 0x874E;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of CompressedTexImage2D.
	/// </summary>
	public const int
		COMPRESSED_RGB8_ETC2 = 0x9274,
		COMPRESSED_SRGB8_ETC2 = 0x9275,
		COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276,
		COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277,
		COMPRESSED_RGBA8_ETC2_EAC = 0x9278,
		COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279,
		COMPRESSED_R11_EAC = 0x9270,
		COMPRESSED_SIGNED_R11_EAC = 0x9271,
		COMPRESSED_RG11_EAC = 0x9272,
		COMPRESSED_SIGNED_RG11_EAC = 0x9273;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of Enable and Disable.
	/// </summary>
	public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, GetQueryIndexediv and GetQueryiv.
	/// </summary>
	public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of the GetInteger* functions.
	/// </summary>
	public const int MAX_ELEMENT_INDEX = 0x8D6B;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetTexParameterfv and  GetTexParameteriv.
	/// </summary>
	public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of CreateShader and returned in the <c>params</c> parameter by GetShaderiv.
	/// </summary>
	public const int COMPUTE_SHADER = 0x91B9;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, GetBooleanv, GetFloatv, GetDoublev and GetInteger64v.
	/// </summary>
	public const int
		MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB,
		MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC,
		MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD,
		MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262,
		MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263,
		MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264,
		MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265,
		MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266,
		MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegeri_v, GetBooleani_v, GetFloati_v, GetDoublei_v and
	/// GetInteger64i_v.
	/// </summary>
	public const int
		MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE,
		MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int COMPUTE_WORK_GROUP_SIZE = 0x8267;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveUniformBlockiv.
	/// </summary>
	public const int UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveAtomicCounterBufferiv.
	/// </summary>
	public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, and GetBufferPointerv.
	/// </summary>
	public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetIntegerv, GetBooleanv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

	/// <summary>
	/// Accepted by the <c>stages</c> parameter of UseProgramStages.
	/// </summary>
	public const int COMPUTE_SHADER_BIT = 0x20;

	/// <summary>
	/// Tokens accepted by the <c>target</c> parameters of Enable, Disable, and  IsEnabled.
	/// </summary>
	public const int
		DEBUG_OUTPUT = 0x92E0,
		DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;

	/// <summary>
	/// Returned by GetIntegerv when <c>pname</c> is CONTEXT_FLAGS.
	/// </summary>
	public const int CONTEXT_FLAG_DEBUG_BIT = 0x2;

	/// <summary>
	/// Tokens accepted by the <c>value</c> parameters of GetBooleanv, GetIntegerv,  GetFloatv, GetDoublev and
	/// GetInteger64v.
	/// </summary>
	public const int
		MAX_DEBUG_MESSAGE_LENGTH = 0x9143,
		MAX_DEBUG_LOGGED_MESSAGES = 0x9144,
		DEBUG_LOGGED_MESSAGES = 0x9145,
		DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243,
		MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C,
		DEBUG_GROUP_STACK_DEPTH = 0x826D,
		MAX_LABEL_LENGTH = 0x82E8;

	/// <summary>
	/// Tokens accepted by the <c>pname</c> parameter of GetPointerv.
	/// </summary>
	public const int
		DEBUG_CALLBACK_FUNCTION = 0x8244,
		DEBUG_CALLBACK_USER_PARAM = 0x8245;

	/// <summary>
	/// Tokens accepted or provided by the <c>source</c> parameters of DebugMessageControl, DebugMessageInsert and
	/// DEBUGPROC, and the <c>sources</c> parameter of GetDebugMessageLog.
	/// </summary>
	public const int
		DEBUG_SOURCE_API = 0x8246,
		DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247,
		DEBUG_SOURCE_SHADER_COMPILER = 0x8248,
		DEBUG_SOURCE_THIRD_PARTY = 0x8249,
		DEBUG_SOURCE_APPLICATION = 0x824A,
		DEBUG_SOURCE_OTHER = 0x824B;

	/// <summary>
	/// Tokens accepted or provided by the <c>type</c> parameters of DebugMessageControl, DebugMessageInsert and
	/// DEBUGPROC, and the <c>types</c> parameter of GetDebugMessageLog.
	/// </summary>
	public const int
		DEBUG_TYPE_ERROR = 0x824C,
		DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D,
		DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E,
		DEBUG_TYPE_PORTABILITY = 0x824F,
		DEBUG_TYPE_PERFORMANCE = 0x8250,
		DEBUG_TYPE_OTHER = 0x8251,
		DEBUG_TYPE_MARKER = 0x8268;

	/// <summary>
	/// Tokens accepted or provided by the <c>type</c> parameters of DebugMessageControl and DEBUGPROC, and the
	/// <c>types</c> parameter of GetDebugMessageLog.
	/// </summary>
	public const int
		DEBUG_TYPE_PUSH_GROUP = 0x8269,
		DEBUG_TYPE_POP_GROUP = 0x826A;

	/// <summary>
	/// Tokens accepted or provided by the <c>severity</c> parameters of DebugMessageControl, DebugMessageInsert and
	/// DEBUGPROC callback functions, and the <c>severities</c> parameter of GetDebugMessageLog.
	/// </summary>
	public const int
		DEBUG_SEVERITY_HIGH = 0x9146,
		DEBUG_SEVERITY_MEDIUM = 0x9147,
		DEBUG_SEVERITY_LOW = 0x9148,
		DEBUG_SEVERITY_NOTIFICATION = 0x826B;

	/// <summary>
	/// Tokens accepted or provided by the <c>identifier</c> parameters of ObjectLabel and GetObjectLabel.
	/// </summary>
	public const int
		BUFFER = 0x82E0,
		SHADER = 0x82E1,
		PROGRAM = 0x82E2,
		QUERY = 0x82E3,
		PROGRAM_PIPELINE = 0x82E4,
		SAMPLER = 0x82E6;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, GetDoublev, and GetInteger64v.
	/// </summary>
	public const int MAX_UNIFORM_LOCATIONS = 0x826E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of FramebufferParameteri, GetFramebufferParameteriv,
	/// NamedFramebufferParameteriEXT, and GetNamedFramebufferParameterivEXT.
	/// </summary>
	public const int
		FRAMEBUFFER_DEFAULT_WIDTH = 0x9310,
		FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311,
		FRAMEBUFFER_DEFAULT_LAYERS = 0x9312,
		FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313,
		FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, GetBooleanv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_FRAMEBUFFER_WIDTH = 0x9315,
		MAX_FRAMEBUFFER_HEIGHT = 0x9316,
		MAX_FRAMEBUFFER_LAYERS = 0x9317,
		MAX_FRAMEBUFFER_SAMPLES = 0x9318;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetInternalformativ and GetInternalformati64v.
	/// </summary>
	public const int
		INTERNALFORMAT_SUPPORTED = 0x826F,
		INTERNALFORMAT_PREFERRED = 0x8270,
		INTERNALFORMAT_RED_SIZE = 0x8271,
		INTERNALFORMAT_GREEN_SIZE = 0x8272,
		INTERNALFORMAT_BLUE_SIZE = 0x8273,
		INTERNALFORMAT_ALPHA_SIZE = 0x8274,
		INTERNALFORMAT_DEPTH_SIZE = 0x8275,
		INTERNALFORMAT_STENCIL_SIZE = 0x8276,
		INTERNALFORMAT_SHARED_SIZE = 0x8277,
		INTERNALFORMAT_RED_TYPE = 0x8278,
		INTERNALFORMAT_GREEN_TYPE = 0x8279,
		INTERNALFORMAT_BLUE_TYPE = 0x827A,
		INTERNALFORMAT_ALPHA_TYPE = 0x827B,
		INTERNALFORMAT_DEPTH_TYPE = 0x827C,
		INTERNALFORMAT_STENCIL_TYPE = 0x827D,
		MAX_WIDTH = 0x827E,
		MAX_HEIGHT = 0x827F,
		MAX_DEPTH = 0x8280,
		MAX_LAYERS = 0x8281,
		MAX_COMBINED_DIMENSIONS = 0x8282,
		COLOR_COMPONENTS = 0x8283,
		DEPTH_COMPONENTS = 0x8284,
		STENCIL_COMPONENTS = 0x8285,
		COLOR_RENDERABLE = 0x8286,
		DEPTH_RENDERABLE = 0x8287,
		STENCIL_RENDERABLE = 0x8288,
		FRAMEBUFFER_RENDERABLE = 0x8289,
		FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A,
		FRAMEBUFFER_BLEND = 0x828B,
		READ_PIXELS = 0x828C,
		READ_PIXELS_FORMAT = 0x828D,
		READ_PIXELS_TYPE = 0x828E,
		TEXTURE_IMAGE_FORMAT = 0x828F,
		TEXTURE_IMAGE_TYPE = 0x8290,
		GET_TEXTURE_IMAGE_FORMAT = 0x8291,
		GET_TEXTURE_IMAGE_TYPE = 0x8292,
		MIPMAP = 0x8293,
		MANUAL_GENERATE_MIPMAP = 0x8294,
		AUTO_GENERATE_MIPMAP = 0x8295,
		COLOR_ENCODING = 0x8296,
		SRGB_READ = 0x8297,
		SRGB_WRITE = 0x8298,
		FILTER = 0x829A,
		VERTEX_TEXTURE = 0x829B,
		TESS_CONTROL_TEXTURE = 0x829C,
		TESS_EVALUATION_TEXTURE = 0x829D,
		GEOMETRY_TEXTURE = 0x829E,
		FRAGMENT_TEXTURE = 0x829F,
		COMPUTE_TEXTURE = 0x82A0,
		TEXTURE_SHADOW = 0x82A1,
		TEXTURE_GATHER = 0x82A2,
		TEXTURE_GATHER_SHADOW = 0x82A3,
		SHADER_IMAGE_LOAD = 0x82A4,
		SHADER_IMAGE_STORE = 0x82A5,
		SHADER_IMAGE_ATOMIC = 0x82A6,
		IMAGE_TEXEL_SIZE = 0x82A7,
		IMAGE_COMPATIBILITY_CLASS = 0x82A8,
		IMAGE_PIXEL_FORMAT = 0x82A9,
		IMAGE_PIXEL_TYPE = 0x82AA,
		SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC,
		SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD,
		SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE,
		SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF,
		TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1,
		TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2,
		TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3,
		CLEAR_BUFFER = 0x82B4,
		TEXTURE_VIEW = 0x82B5,
		VIEW_COMPATIBILITY_CLASS = 0x82B6;

	/// <summary>
	/// Returned as possible responses for various <c>pname</c> queries to GetInternalformativ and GetInternalformati64v.
	/// </summary>
	public const int
		FULL_SUPPORT = 0x82B7,
		CAVEAT_SUPPORT = 0x82B8,
		IMAGE_CLASS_4_X_32 = 0x82B9,
		IMAGE_CLASS_2_X_32 = 0x82BA,
		IMAGE_CLASS_1_X_32 = 0x82BB,
		IMAGE_CLASS_4_X_16 = 0x82BC,
		IMAGE_CLASS_2_X_16 = 0x82BD,
		IMAGE_CLASS_1_X_16 = 0x82BE,
		IMAGE_CLASS_4_X_8 = 0x82BF,
		IMAGE_CLASS_2_X_8 = 0x82C0,
		IMAGE_CLASS_1_X_8 = 0x82C1,
		IMAGE_CLASS_11_11_10 = 0x82C2,
		IMAGE_CLASS_10_10_10_2 = 0x82C3,
		VIEW_CLASS_128_BITS = 0x82C4,
		VIEW_CLASS_96_BITS = 0x82C5,
		VIEW_CLASS_64_BITS = 0x82C6,
		VIEW_CLASS_48_BITS = 0x82C7,
		VIEW_CLASS_32_BITS = 0x82C8,
		VIEW_CLASS_24_BITS = 0x82C9,
		VIEW_CLASS_16_BITS = 0x82CA,
		VIEW_CLASS_8_BITS = 0x82CB,
		VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC,
		VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD,
		VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE,
		VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF,
		VIEW_CLASS_RGTC1_RED = 0x82D0,
		VIEW_CLASS_RGTC2_RG = 0x82D1,
		VIEW_CLASS_BPTC_UNORM = 0x82D2,
		VIEW_CLASS_BPTC_FLOAT = 0x82D3;

	/// <summary>
	/// Accepted by the <c>programInterface</c> parameter of GetProgramInterfaceiv, GetProgramResourceIndex,
	/// GetProgramResourceName, GetProgramResourceiv, GetProgramResourceLocation, and GetProgramResourceLocationIndex.
	/// </summary>
	public const int
		UNIFORM = 0x92E1,
		UNIFORM_BLOCK = 0x92E2,
		PROGRAM_INPUT = 0x92E3,
		PROGRAM_OUTPUT = 0x92E4,
		BUFFER_VARIABLE = 0x92E5,
		SHADER_STORAGE_BLOCK = 0x92E6,
		VERTEX_SUBROUTINE = 0x92E8,
		TESS_CONTROL_SUBROUTINE = 0x92E9,
		TESS_EVALUATION_SUBROUTINE = 0x92EA,
		GEOMETRY_SUBROUTINE = 0x92EB,
		FRAGMENT_SUBROUTINE = 0x92EC,
		COMPUTE_SUBROUTINE = 0x92ED,
		VERTEX_SUBROUTINE_UNIFORM = 0x92EE,
		TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF,
		TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0,
		GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1,
		FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2,
		COMPUTE_SUBROUTINE_UNIFORM = 0x92F3,
		TRANSFORM_FEEDBACK_VARYING = 0x92F4;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramInterfaceiv.
	/// </summary>
	public const int
		ACTIVE_RESOURCES = 0x92F5,
		MAX_NAME_LENGTH = 0x92F6,
		MAX_NUM_ACTIVE_VARIABLES = 0x92F7,
		MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;

	/// <summary>
	/// Accepted in the <c>props</c> array of GetProgramResourceiv.
	/// </summary>
	public const int
		NAME_LENGTH = 0x92F9,
		TYPE = 0x92FA,
		ARRAY_SIZE = 0x92FB,
		OFFSET = 0x92FC,
		BLOCK_INDEX = 0x92FD,
		ARRAY_STRIDE = 0x92FE,
		MATRIX_STRIDE = 0x92FF,
		IS_ROW_MAJOR = 0x9300,
		ATOMIC_COUNTER_BUFFER_INDEX = 0x9301,
		BUFFER_BINDING = 0x9302,
		BUFFER_DATA_SIZE = 0x9303,
		NUM_ACTIVE_VARIABLES = 0x9304,
		ACTIVE_VARIABLES = 0x9305,
		REFERENCED_BY_VERTEX_SHADER = 0x9306,
		REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307,
		REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308,
		REFERENCED_BY_GEOMETRY_SHADER = 0x9309,
		REFERENCED_BY_FRAGMENT_SHADER = 0x930A,
		REFERENCED_BY_COMPUTE_SHADER = 0x930B,
		TOP_LEVEL_ARRAY_SIZE = 0x930C,
		TOP_LEVEL_ARRAY_STRIDE = 0x930D,
		LOCATION = 0x930E,
		LOCATION_INDEX = 0x930F,
		IS_PER_PATCH = 0x92E7;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, and GetBufferPointerv.
	/// </summary>
	public const int SHADER_STORAGE_BUFFER = 0x90D2;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, GetIntegeri_v, GetBooleanv, GetInteger64v, GetFloatv,
	/// GetDoublev, GetBooleani_v, GetIntegeri_v, GetFloati_v, GetDoublei_v, and GetInteger64i_v.
	/// </summary>
	public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegeri_v, GetBooleani_v, GetIntegeri_v, GetFloati_v, GetDoublei_v,
	/// and GetInteger64i_v.
	/// </summary>
	public const int
		SHADER_STORAGE_BUFFER_START = 0x90D4,
		SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, GetBooleanv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6,
		MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7,
		MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8,
		MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9,
		MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA,
		MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB,
		MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC,
		MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD,
		MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE,
		SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

	/// <summary>
	/// Accepted in the <c>barriers</c> bitfield in glMemoryBarrier.
	/// </summary>
	public const int SHADER_STORAGE_BARRIER_BIT = 0x2000;

	/// <summary>
	/// Alias for the existing token MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS.
	/// </summary>
	public const int MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of TexParameter* and GetTexParameter*.
	/// </summary>
	public const int DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetTexLevelParameter.
	/// </summary>
	public const int
		TEXTURE_BUFFER_OFFSET = 0x919D,
		TEXTURE_BUFFER_SIZE = 0x919E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetTexParameterfv and  GetTexParameteriv.
	/// </summary>
	public const int
		TEXTURE_VIEW_MIN_LEVEL = 0x82DB,
		TEXTURE_VIEW_NUM_LEVELS = 0x82DC,
		TEXTURE_VIEW_MIN_LAYER = 0x82DD,
		TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetVertexAttrib*v.
	/// </summary>
	public const int
		VERTEX_ATTRIB_BINDING = 0x82D4,
		VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of GetBooleani_v, GetIntegeri_v, GetFloati_v, GetDoublei_v, and
	/// GetInteger64i_v.
	/// </summary>
	public const int
		VERTEX_BINDING_DIVISOR = 0x82D6,
		VERTEX_BINDING_OFFSET = 0x82D7,
		VERTEX_BINDING_STRIDE = 0x82D8,
		VERTEX_BINDING_BUFFER = 0x8F4F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, ....
	/// </summary>
	public const int
		MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9,
		MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

	#endregion
}
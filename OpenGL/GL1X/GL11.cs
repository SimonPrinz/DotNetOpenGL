/// <summary>
/// The OpenGL functionality up to version 1.1. Includes the deprecated symbols of the Compatibility Profile.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>EXT_vertex_array</li>
/// 	<li>EXT_polygon_offset</li>
/// 	<li>EXT_blend_logic_op</li>
/// 	<li>EXT_texture</li>
/// 	<li>EXT_copy_texture</li>
/// 	<li>EXT_subtexture</li>
/// 	<li>EXT_texture_object</li>
/// </ul>
/// </summary>
public class GL11 : GL
{
	#region Constants

	/// <summary>
	/// AccumOp
	/// </summary>
	public const int
		ACCUM = 0x100,
		LOAD = 0x101,
		RETURN = 0x102,
		MULT = 0x103,
		ADD = 0x104;

	/// <summary>
	/// AlphaFunction
	/// </summary>
	public const int
		NEVER = 0x200,
		LESS = 0x201,
		EQUAL = 0x202,
		LEQUAL = 0x203,
		GREATER = 0x204,
		NOTEQUAL = 0x205,
		GEQUAL = 0x206,
		ALWAYS = 0x207;

	/// <summary>
	/// AttribMask
	/// </summary>
	public const int
		CURRENT_BIT = 0x1,
		POINT_BIT = 0x2,
		LINE_BIT = 0x4,
		POLYGON_BIT = 0x8,
		POLYGON_STIPPLE_BIT = 0x10,
		PIXEL_MODE_BIT = 0x20,
		LIGHTING_BIT = 0x40,
		FOG_BIT = 0x80,
		DEPTH_BUFFER_BIT = 0x100,
		ACCUM_BUFFER_BIT = 0x200,
		STENCIL_BUFFER_BIT = 0x400,
		VIEWPORT_BIT = 0x800,
		TRANSFORM_BIT = 0x1000,
		ENABLE_BIT = 0x2000,
		COLOR_BUFFER_BIT = 0x4000,
		HINT_BIT = 0x8000,
		EVAL_BIT = 0x10000,
		LIST_BIT = 0x20000,
		TEXTURE_BIT = 0x40000,
		SCISSOR_BIT = 0x80000,
		ALL_ATTRIB_BITS = 0xFFFFF;

	/// <summary>
	/// BeginMode
	/// </summary>
	public const int
		POINTS = 0x0,
		LINES = 0x1,
		LINE_LOOP = 0x2,
		LINE_STRIP = 0x3,
		TRIANGLES = 0x4,
		TRIANGLE_STRIP = 0x5,
		TRIANGLE_FAN = 0x6,
		QUADS = 0x7,
		QUAD_STRIP = 0x8,
		POLYGON = 0x9;

	/// <summary>
	/// BlendingFactorDest
	/// </summary>
	public const int
		ZERO = 0,
		ONE = 1,
		SRC_COLOR = 0x300,
		ONE_MINUS_SRC_COLOR = 0x301,
		SRC_ALPHA = 0x302,
		ONE_MINUS_SRC_ALPHA = 0x303,
		DST_ALPHA = 0x304,
		ONE_MINUS_DST_ALPHA = 0x305;

	/// <summary>
	/// BlendingFactorSrc
	/// </summary>
	public const int
		DST_COLOR = 0x306,
		ONE_MINUS_DST_COLOR = 0x307,
		SRC_ALPHA_SATURATE = 0x308;

	/// <summary>
	/// Boolean
	/// </summary>
	public const int
		TRUE = 1,
		FALSE = 0;

	/// <summary>
	/// ClipPlaneName
	/// </summary>
	public const int
		CLIP_PLANE0 = 0x3000,
		CLIP_PLANE1 = 0x3001,
		CLIP_PLANE2 = 0x3002,
		CLIP_PLANE3 = 0x3003,
		CLIP_PLANE4 = 0x3004,
		CLIP_PLANE5 = 0x3005;

	/// <summary>
	/// DataType
	/// </summary>
	public const int
		BYTE = 0x1400,
		UNSIGNED_BYTE = 0x1401,
		SHORT = 0x1402,
		UNSIGNED_SHORT = 0x1403,
		INT = 0x1404,
		UNSIGNED_INT = 0x1405,
		FLOAT = 0x1406,
		_2_BYTES = 0x1407,
		_3_BYTES = 0x1408,
		_4_BYTES = 0x1409,
		DOUBLE = 0x140A;

	/// <summary>
	/// DrawBufferMode
	/// </summary>
	public const int
		NONE = 0,
		FRONT_LEFT = 0x400,
		FRONT_RIGHT = 0x401,
		BACK_LEFT = 0x402,
		BACK_RIGHT = 0x403,
		FRONT = 0x404,
		BACK = 0x405,
		LEFT = 0x406,
		RIGHT = 0x407,
		FRONT_AND_BACK = 0x408,
		AUX0 = 0x409,
		AUX1 = 0x40A,
		AUX2 = 0x40B,
		AUX3 = 0x40C;

	/// <summary>
	/// ErrorCode
	/// </summary>
	public const int
		NO_ERROR = 0,
		INVALID_ENUM = 0x500,
		INVALID_VALUE = 0x501,
		INVALID_OPERATION = 0x502,
		STACK_OVERFLOW = 0x503,
		STACK_UNDERFLOW = 0x504,
		OUT_OF_MEMORY = 0x505;

	/// <summary>
	/// FeedBackMode
	/// </summary>
	public const int
		_2D = 0x600,
		_3D = 0x601,
		_3D_COLOR = 0x602,
		_3D_COLOR_TEXTURE = 0x603,
		_4D_COLOR_TEXTURE = 0x604;

	/// <summary>
	/// FeedBackToken
	/// </summary>
	public const int
		PASS_THROUGH_TOKEN = 0x700,
		POINT_TOKEN = 0x701,
		LINE_TOKEN = 0x702,
		POLYGON_TOKEN = 0x703,
		BITMAP_TOKEN = 0x704,
		DRAW_PIXEL_TOKEN = 0x705,
		COPY_PIXEL_TOKEN = 0x706,
		LINE_RESET_TOKEN = 0x707;

	/// <summary>
	/// FogMode
	/// </summary>
	public const int
		EXP = 0x800,
		EXP2 = 0x801;

	/// <summary>
	/// FrontFaceDirection
	/// </summary>
	public const int
		CW = 0x900,
		CCW = 0x901;

	/// <summary>
	/// GetMapTarget
	/// </summary>
	public const int
		COEFF = 0xA00,
		ORDER = 0xA01,
		DOMAIN = 0xA02;

	/// <summary>
	/// GetTarget
	/// </summary>
	public const int
		CURRENT_COLOR = 0xB00,
		CURRENT_INDEX = 0xB01,
		CURRENT_NORMAL = 0xB02,
		CURRENT_TEXTURE_COORDS = 0xB03,
		CURRENT_RASTER_COLOR = 0xB04,
		CURRENT_RASTER_INDEX = 0xB05,
		CURRENT_RASTER_TEXTURE_COORDS = 0xB06,
		CURRENT_RASTER_POSITION = 0xB07,
		CURRENT_RASTER_POSITION_VALID = 0xB08,
		CURRENT_RASTER_DISTANCE = 0xB09,
		POINT_SMOOTH = 0xB10,
		POINT_SIZE = 0xB11,
		POINT_SIZE_RANGE = 0xB12,
		POINT_SIZE_GRANULARITY = 0xB13,
		LINE_SMOOTH = 0xB20,
		LINE_WIDTH = 0xB21,
		LINE_WIDTH_RANGE = 0xB22,
		LINE_WIDTH_GRANULARITY = 0xB23,
		LINE_STIPPLE = 0xB24,
		LINE_STIPPLE_PATTERN = 0xB25,
		LINE_STIPPLE_REPEAT = 0xB26,
		LIST_MODE = 0xB30,
		MAX_LIST_NESTING = 0xB31,
		LIST_BASE = 0xB32,
		LIST_INDEX = 0xB33,
		POLYGON_MODE = 0xB40,
		POLYGON_SMOOTH = 0xB41,
		POLYGON_STIPPLE = 0xB42,
		EDGE_FLAG = 0xB43,
		CULL_FACE = 0xB44,
		CULL_FACE_MODE = 0xB45,
		FRONT_FACE = 0xB46,
		LIGHTING = 0xB50,
		LIGHT_MODEL_LOCAL_VIEWER = 0xB51,
		LIGHT_MODEL_TWO_SIDE = 0xB52,
		LIGHT_MODEL_AMBIENT = 0xB53,
		SHADE_MODEL = 0xB54,
		COLOR_MATERIAL_FACE = 0xB55,
		COLOR_MATERIAL_PARAMETER = 0xB56,
		COLOR_MATERIAL = 0xB57,
		FOG = 0xB60,
		FOG_INDEX = 0xB61,
		FOG_DENSITY = 0xB62,
		FOG_START = 0xB63,
		FOG_END = 0xB64,
		FOG_MODE = 0xB65,
		FOG_COLOR = 0xB66,
		DEPTH_RANGE = 0xB70,
		DEPTH_TEST = 0xB71,
		DEPTH_WRITEMASK = 0xB72,
		DEPTH_CLEAR_VALUE = 0xB73,
		DEPTH_FUNC = 0xB74,
		ACCUM_CLEAR_VALUE = 0xB80,
		STENCIL_TEST = 0xB90,
		STENCIL_CLEAR_VALUE = 0xB91,
		STENCIL_FUNC = 0xB92,
		STENCIL_VALUE_MASK = 0xB93,
		STENCIL_FAIL = 0xB94,
		STENCIL_PASS_DEPTH_FAIL = 0xB95,
		STENCIL_PASS_DEPTH_PASS = 0xB96,
		STENCIL_REF = 0xB97,
		STENCIL_WRITEMASK = 0xB98,
		MATRIX_MODE = 0xBA0,
		NORMALIZE = 0xBA1,
		VIEWPORT = 0xBA2,
		MODELVIEW_STACK_DEPTH = 0xBA3,
		PROJECTION_STACK_DEPTH = 0xBA4,
		TEXTURE_STACK_DEPTH = 0xBA5,
		MODELVIEW_MATRIX = 0xBA6,
		PROJECTION_MATRIX = 0xBA7,
		TEXTURE_MATRIX = 0xBA8,
		ATTRIB_STACK_DEPTH = 0xBB0,
		CLIENT_ATTRIB_STACK_DEPTH = 0xBB1,
		ALPHA_TEST = 0xBC0,
		ALPHA_TEST_FUNC = 0xBC1,
		ALPHA_TEST_REF = 0xBC2,
		DITHER = 0xBD0,
		BLEND_DST = 0xBE0,
		BLEND_SRC = 0xBE1,
		BLEND = 0xBE2,
		LOGIC_OP_MODE = 0xBF0,
		INDEX_LOGIC_OP = 0xBF1,
		LOGIC_OP = 0xBF1,
		COLOR_LOGIC_OP = 0xBF2,
		AUX_BUFFERS = 0xC00,
		DRAW_BUFFER = 0xC01,
		READ_BUFFER = 0xC02,
		SCISSOR_BOX = 0xC10,
		SCISSOR_TEST = 0xC11,
		INDEX_CLEAR_VALUE = 0xC20,
		INDEX_WRITEMASK = 0xC21,
		COLOR_CLEAR_VALUE = 0xC22,
		COLOR_WRITEMASK = 0xC23,
		INDEX_MODE = 0xC30,
		RGBA_MODE = 0xC31,
		DOUBLEBUFFER = 0xC32,
		STEREO = 0xC33,
		RENDER_MODE = 0xC40,
		PERSPECTIVE_CORRECTION_HINT = 0xC50,
		POINT_SMOOTH_HINT = 0xC51,
		LINE_SMOOTH_HINT = 0xC52,
		POLYGON_SMOOTH_HINT = 0xC53,
		FOG_HINT = 0xC54,
		TEXTURE_GEN_S = 0xC60,
		TEXTURE_GEN_T = 0xC61,
		TEXTURE_GEN_R = 0xC62,
		TEXTURE_GEN_Q = 0xC63,
		PIXEL_MAP_I_TO_I = 0xC70,
		PIXEL_MAP_S_TO_S = 0xC71,
		PIXEL_MAP_I_TO_R = 0xC72,
		PIXEL_MAP_I_TO_G = 0xC73,
		PIXEL_MAP_I_TO_B = 0xC74,
		PIXEL_MAP_I_TO_A = 0xC75,
		PIXEL_MAP_R_TO_R = 0xC76,
		PIXEL_MAP_G_TO_G = 0xC77,
		PIXEL_MAP_B_TO_B = 0xC78,
		PIXEL_MAP_A_TO_A = 0xC79,
		PIXEL_MAP_I_TO_I_SIZE = 0xCB0,
		PIXEL_MAP_S_TO_S_SIZE = 0xCB1,
		PIXEL_MAP_I_TO_R_SIZE = 0xCB2,
		PIXEL_MAP_I_TO_G_SIZE = 0xCB3,
		PIXEL_MAP_I_TO_B_SIZE = 0xCB4,
		PIXEL_MAP_I_TO_A_SIZE = 0xCB5,
		PIXEL_MAP_R_TO_R_SIZE = 0xCB6,
		PIXEL_MAP_G_TO_G_SIZE = 0xCB7,
		PIXEL_MAP_B_TO_B_SIZE = 0xCB8,
		PIXEL_MAP_A_TO_A_SIZE = 0xCB9,
		UNPACK_SWAP_BYTES = 0xCF0,
		UNPACK_LSB_FIRST = 0xCF1,
		UNPACK_ROW_LENGTH = 0xCF2,
		UNPACK_SKIP_ROWS = 0xCF3,
		UNPACK_SKIP_PIXELS = 0xCF4,
		UNPACK_ALIGNMENT = 0xCF5,
		PACK_SWAP_BYTES = 0xD00,
		PACK_LSB_FIRST = 0xD01,
		PACK_ROW_LENGTH = 0xD02,
		PACK_SKIP_ROWS = 0xD03,
		PACK_SKIP_PIXELS = 0xD04,
		PACK_ALIGNMENT = 0xD05,
		MAP_COLOR = 0xD10,
		MAP_STENCIL = 0xD11,
		INDEX_SHIFT = 0xD12,
		INDEX_OFFSET = 0xD13,
		RED_SCALE = 0xD14,
		RED_BIAS = 0xD15,
		ZOOM_X = 0xD16,
		ZOOM_Y = 0xD17,
		GREEN_SCALE = 0xD18,
		GREEN_BIAS = 0xD19,
		BLUE_SCALE = 0xD1A,
		BLUE_BIAS = 0xD1B,
		ALPHA_SCALE = 0xD1C,
		ALPHA_BIAS = 0xD1D,
		DEPTH_SCALE = 0xD1E,
		DEPTH_BIAS = 0xD1F,
		MAX_EVAL_ORDER = 0xD30,
		MAX_LIGHTS = 0xD31,
		MAX_CLIP_PLANES = 0xD32,
		MAX_TEXTURE_SIZE = 0xD33,
		MAX_PIXEL_MAP_TABLE = 0xD34,
		MAX_ATTRIB_STACK_DEPTH = 0xD35,
		MAX_MODELVIEW_STACK_DEPTH = 0xD36,
		MAX_NAME_STACK_DEPTH = 0xD37,
		MAX_PROJECTION_STACK_DEPTH = 0xD38,
		MAX_TEXTURE_STACK_DEPTH = 0xD39,
		MAX_VIEWPORT_DIMS = 0xD3A,
		MAX_CLIENT_ATTRIB_STACK_DEPTH = 0xD3B,
		SUBPIXEL_BITS = 0xD50,
		INDEX_BITS = 0xD51,
		RED_BITS = 0xD52,
		GREEN_BITS = 0xD53,
		BLUE_BITS = 0xD54,
		ALPHA_BITS = 0xD55,
		DEPTH_BITS = 0xD56,
		STENCIL_BITS = 0xD57,
		ACCUM_RED_BITS = 0xD58,
		ACCUM_GREEN_BITS = 0xD59,
		ACCUM_BLUE_BITS = 0xD5A,
		ACCUM_ALPHA_BITS = 0xD5B,
		NAME_STACK_DEPTH = 0xD70,
		AUTO_NORMAL = 0xD80,
		MAP1_COLOR_4 = 0xD90,
		MAP1_INDEX = 0xD91,
		MAP1_NORMAL = 0xD92,
		MAP1_TEXTURE_COORD_1 = 0xD93,
		MAP1_TEXTURE_COORD_2 = 0xD94,
		MAP1_TEXTURE_COORD_3 = 0xD95,
		MAP1_TEXTURE_COORD_4 = 0xD96,
		MAP1_VERTEX_3 = 0xD97,
		MAP1_VERTEX_4 = 0xD98,
		MAP2_COLOR_4 = 0xDB0,
		MAP2_INDEX = 0xDB1,
		MAP2_NORMAL = 0xDB2,
		MAP2_TEXTURE_COORD_1 = 0xDB3,
		MAP2_TEXTURE_COORD_2 = 0xDB4,
		MAP2_TEXTURE_COORD_3 = 0xDB5,
		MAP2_TEXTURE_COORD_4 = 0xDB6,
		MAP2_VERTEX_3 = 0xDB7,
		MAP2_VERTEX_4 = 0xDB8,
		MAP1_GRID_DOMAIN = 0xDD0,
		MAP1_GRID_SEGMENTS = 0xDD1,
		MAP2_GRID_DOMAIN = 0xDD2,
		MAP2_GRID_SEGMENTS = 0xDD3,
		TEXTURE_1D = 0xDE0,
		TEXTURE_2D = 0xDE1,
		FEEDBACK_BUFFER_POINTER = 0xDF0,
		FEEDBACK_BUFFER_SIZE = 0xDF1,
		FEEDBACK_BUFFER_TYPE = 0xDF2,
		SELECTION_BUFFER_POINTER = 0xDF3,
		SELECTION_BUFFER_SIZE = 0xDF4;

	/// <summary>
	/// GetTextureParameter
	/// </summary>
	public const int
		TEXTURE_WIDTH = 0x1000,
		TEXTURE_HEIGHT = 0x1001,
		TEXTURE_INTERNAL_FORMAT = 0x1003,
		TEXTURE_COMPONENTS = 0x1003,
		TEXTURE_BORDER_COLOR = 0x1004,
		TEXTURE_BORDER = 0x1005;

	/// <summary>
	/// HintMode
	/// </summary>
	public const int
		DONT_CARE = 0x1100,
		FASTEST = 0x1101,
		NICEST = 0x1102;

	/// <summary>
	/// LightName
	/// </summary>
	public const int
		LIGHT0 = 0x4000,
		LIGHT1 = 0x4001,
		LIGHT2 = 0x4002,
		LIGHT3 = 0x4003,
		LIGHT4 = 0x4004,
		LIGHT5 = 0x4005,
		LIGHT6 = 0x4006,
		LIGHT7 = 0x4007;

	/// <summary>
	/// LightParameter
	/// </summary>
	public const int
		AMBIENT = 0x1200,
		DIFFUSE = 0x1201,
		SPECULAR = 0x1202,
		POSITION = 0x1203,
		SPOT_DIRECTION = 0x1204,
		SPOT_EXPONENT = 0x1205,
		SPOT_CUTOFF = 0x1206,
		CONSTANT_ATTENUATION = 0x1207,
		LINEAR_ATTENUATION = 0x1208,
		QUADRATIC_ATTENUATION = 0x1209;

	/// <summary>
	/// ListMode
	/// </summary>
	public const int
		COMPILE = 0x1300,
		COMPILE_AND_EXECUTE = 0x1301;

	/// <summary>
	/// LogicOp
	/// </summary>
	public const int
		CLEAR = 0x1500,
		AND = 0x1501,
		AND_REVERSE = 0x1502,
		COPY = 0x1503,
		AND_INVERTED = 0x1504,
		NOOP = 0x1505,
		XOR = 0x1506,
		OR = 0x1507,
		NOR = 0x1508,
		EQUIV = 0x1509,
		INVERT = 0x150A,
		OR_REVERSE = 0x150B,
		COPY_INVERTED = 0x150C,
		OR_INVERTED = 0x150D,
		NAND = 0x150E,
		SET = 0x150F;

	/// <summary>
	/// MaterialParameter
	/// </summary>
	public const int
		EMISSION = 0x1600,
		SHININESS = 0x1601,
		AMBIENT_AND_DIFFUSE = 0x1602,
		COLOR_INDEXES = 0x1603;

	/// <summary>
	/// MatrixMode
	/// </summary>
	public const int
		MODELVIEW = 0x1700,
		PROJECTION = 0x1701,
		TEXTURE = 0x1702;

	/// <summary>
	/// PixelCopyType
	/// </summary>
	public const int
		COLOR = 0x1800,
		DEPTH = 0x1801,
		STENCIL = 0x1802;

	/// <summary>
	/// PixelFormat
	/// </summary>
	public const int
		COLOR_INDEX = 0x1900,
		STENCIL_INDEX = 0x1901,
		DEPTH_COMPONENT = 0x1902,
		RED = 0x1903,
		GREEN = 0x1904,
		BLUE = 0x1905,
		ALPHA = 0x1906,
		RGB = 0x1907,
		RGBA = 0x1908,
		LUMINANCE = 0x1909,
		LUMINANCE_ALPHA = 0x190A;

	/// <summary>
	/// PixelType
	/// </summary>
	public const int BITMAP = 0x1A00;

	/// <summary>
	/// PolygonMode
	/// </summary>
	public const int
		POINT = 0x1B00,
		LINE = 0x1B01,
		FILL = 0x1B02;

	/// <summary>
	/// RenderingMode
	/// </summary>
	public const int
		RENDER = 0x1C00,
		FEEDBACK = 0x1C01,
		SELECT = 0x1C02;

	/// <summary>
	/// ShadingModel
	/// </summary>
	public const int
		FLAT = 0x1D00,
		SMOOTH = 0x1D01;

	/// <summary>
	/// StencilOp
	/// </summary>
	public const int
		KEEP = 0x1E00,
		REPLACE = 0x1E01,
		INCR = 0x1E02,
		DECR = 0x1E03;

	/// <summary>
	/// StringName
	/// </summary>
	public const int
		VENDOR = 0x1F00,
		RENDERER = 0x1F01,
		VERSION = 0x1F02,
		EXTENSIONS = 0x1F03;

	/// <summary>
	/// TextureCoordName
	/// </summary>
	public const int
		S = 0x2000,
		T = 0x2001,
		R = 0x2002,
		Q = 0x2003;

	/// <summary>
	/// TextureEnvMode
	/// </summary>
	public const int
		MODULATE = 0x2100,
		DECAL = 0x2101;

	/// <summary>
	/// TextureEnvParameter
	/// </summary>
	public const int
		TEXTURE_ENV_MODE = 0x2200,
		TEXTURE_ENV_COLOR = 0x2201;

	/// <summary>
	/// TextureEnvTarget
	/// </summary>
	public const int TEXTURE_ENV = 0x2300;

	/// <summary>
	/// TextureGenMode
	/// </summary>
	public const int
		EYE_LINEAR = 0x2400,
		OBJECT_LINEAR = 0x2401,
		SPHERE_MAP = 0x2402;

	/// <summary>
	/// TextureGenParameter
	/// </summary>
	public const int
		TEXTURE_GEN_MODE = 0x2500,
		OBJECT_PLANE = 0x2501,
		EYE_PLANE = 0x2502;

	/// <summary>
	/// TextureMagFilter
	/// </summary>
	public const int
		NEAREST = 0x2600,
		LINEAR = 0x2601;

	/// <summary>
	/// TextureMinFilter
	/// </summary>
	public const int
		NEAREST_MIPMAP_NEAREST = 0x2700,
		LINEAR_MIPMAP_NEAREST = 0x2701,
		NEAREST_MIPMAP_LINEAR = 0x2702,
		LINEAR_MIPMAP_LINEAR = 0x2703;

	/// <summary>
	/// TextureParameterName
	/// </summary>
	public const int
		TEXTURE_MAG_FILTER = 0x2800,
		TEXTURE_MIN_FILTER = 0x2801,
		TEXTURE_WRAP_S = 0x2802,
		TEXTURE_WRAP_T = 0x2803;

	/// <summary>
	/// TextureWrapMode
	/// </summary>
	public const int
		CLAMP = 0x2900,
		REPEAT = 0x2901;

	/// <summary>
	/// ClientAttribMask
	/// </summary>
	public const uint
		CLIENT_PIXEL_STORE_BIT = 0x1,
		CLIENT_VERTEX_ARRAY_BIT = 0x2,
		CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;

	/// <summary>
	/// polygon_offset
	/// </summary>
	public const int
		POLYGON_OFFSET_FACTOR = 0x8038,
		POLYGON_OFFSET_UNITS = 0x2A00,
		POLYGON_OFFSET_POINT = 0x2A01,
		POLYGON_OFFSET_LINE = 0x2A02,
		POLYGON_OFFSET_FILL = 0x8037;

	/// <summary>
	/// texture
	/// </summary>
	public const int
		ALPHA4 = 0x803B,
		ALPHA8 = 0x803C,
		ALPHA12 = 0x803D,
		ALPHA16 = 0x803E,
		LUMINANCE4 = 0x803F,
		LUMINANCE8 = 0x8040,
		LUMINANCE12 = 0x8041,
		LUMINANCE16 = 0x8042,
		LUMINANCE4_ALPHA4 = 0x8043,
		LUMINANCE6_ALPHA2 = 0x8044,
		LUMINANCE8_ALPHA8 = 0x8045,
		LUMINANCE12_ALPHA4 = 0x8046,
		LUMINANCE12_ALPHA12 = 0x8047,
		LUMINANCE16_ALPHA16 = 0x8048,
		INTENSITY = 0x8049,
		INTENSITY4 = 0x804A,
		INTENSITY8 = 0x804B,
		INTENSITY12 = 0x804C,
		INTENSITY16 = 0x804D,
		R3_G3_B2 = 0x2A10,
		RGB4 = 0x804F,
		RGB5 = 0x8050,
		RGB8 = 0x8051,
		RGB10 = 0x8052,
		RGB12 = 0x8053,
		RGB16 = 0x8054,
		RGBA2 = 0x8055,
		RGBA4 = 0x8056,
		RGB5_A1 = 0x8057,
		RGBA8 = 0x8058,
		RGB10_A2 = 0x8059,
		RGBA12 = 0x805A,
		RGBA16 = 0x805B,
		TEXTURE_RED_SIZE = 0x805C,
		TEXTURE_GREEN_SIZE = 0x805D,
		TEXTURE_BLUE_SIZE = 0x805E,
		TEXTURE_ALPHA_SIZE = 0x805F,
		TEXTURE_LUMINANCE_SIZE = 0x8060,
		TEXTURE_INTENSITY_SIZE = 0x8061,
		PROXY_TEXTURE_1D = 0x8063,
		PROXY_TEXTURE_2D = 0x8064;

	/// <summary>
	/// texture_object
	/// </summary>
	public const int
		TEXTURE_PRIORITY = 0x8066,
		TEXTURE_RESIDENT = 0x8067,
		TEXTURE_BINDING_1D = 0x8068,
		TEXTURE_BINDING_2D = 0x8069;

	/// <summary>
	/// vertex_array
	/// </summary>
	public const int
		VERTEX_ARRAY = 0x8074,
		NORMAL_ARRAY = 0x8075,
		COLOR_ARRAY = 0x8076,
		INDEX_ARRAY = 0x8077,
		TEXTURE_COORD_ARRAY = 0x8078,
		EDGE_FLAG_ARRAY = 0x8079,
		VERTEX_ARRAY_SIZE = 0x807A,
		VERTEX_ARRAY_TYPE = 0x807B,
		VERTEX_ARRAY_STRIDE = 0x807C,
		NORMAL_ARRAY_TYPE = 0x807E,
		NORMAL_ARRAY_STRIDE = 0x807F,
		COLOR_ARRAY_SIZE = 0x8081,
		COLOR_ARRAY_TYPE = 0x8082,
		COLOR_ARRAY_STRIDE = 0x8083,
		INDEX_ARRAY_TYPE = 0x8085,
		INDEX_ARRAY_STRIDE = 0x8086,
		TEXTURE_COORD_ARRAY_SIZE = 0x8088,
		TEXTURE_COORD_ARRAY_TYPE = 0x8089,
		TEXTURE_COORD_ARRAY_STRIDE = 0x808A,
		EDGE_FLAG_ARRAY_STRIDE = 0x808C,
		VERTEX_ARRAY_POINTER = 0x808E,
		NORMAL_ARRAY_POINTER = 0x808F,
		COLOR_ARRAY_POINTER = 0x8090,
		INDEX_ARRAY_POINTER = 0x8091,
		TEXTURE_COORD_ARRAY_POINTER = 0x8092,
		EDGE_FLAG_ARRAY_POINTER = 0x8093,
		V2F = 0x2A20,
		V3F = 0x2A21,
		C4UB_V2F = 0x2A22,
		C4UB_V3F = 0x2A23,
		C3F_V3F = 0x2A24,
		N3F_V3F = 0x2A25,
		C4F_N3F_V3F = 0x2A26,
		T2F_V3F = 0x2A27,
		T4F_V4F = 0x2A28,
		T2F_C4UB_V3F = 0x2A29,
		T2F_C3F_V3F = 0x2A2A,
		T2F_N3F_V3F = 0x2A2B,
		T2F_C4F_N3F_V3F = 0x2A2C,
		T4F_C4F_N3F_V4F = 0x2A2D;

	#endregion
}
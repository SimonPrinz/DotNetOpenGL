/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 1.1.<br/>
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
public class GL11C : GL
{
	#region Constants

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
		DEPTH_BUFFER_BIT = 0x100,
		STENCIL_BUFFER_BIT = 0x400,
		COLOR_BUFFER_BIT = 0x4000;

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
		QUADS = 0x7;

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
		FRONT_AND_BACK = 0x408;

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
	/// FrontFaceDirection
	/// </summary>
	public const int
		CW = 0x900,
		CCW = 0x901;

	/// <summary>
	/// GetTarget
	/// </summary>
	public const int
		POINT_SIZE = 0xB11,
		POINT_SIZE_RANGE = 0xB12,
		POINT_SIZE_GRANULARITY = 0xB13,
		LINE_SMOOTH = 0xB20,
		LINE_WIDTH = 0xB21,
		LINE_WIDTH_RANGE = 0xB22,
		LINE_WIDTH_GRANULARITY = 0xB23,
		POLYGON_MODE = 0xB40,
		POLYGON_SMOOTH = 0xB41,
		CULL_FACE = 0xB44,
		CULL_FACE_MODE = 0xB45,
		FRONT_FACE = 0xB46,
		DEPTH_RANGE = 0xB70,
		DEPTH_TEST = 0xB71,
		DEPTH_WRITEMASK = 0xB72,
		DEPTH_CLEAR_VALUE = 0xB73,
		DEPTH_FUNC = 0xB74,
		STENCIL_TEST = 0xB90,
		STENCIL_CLEAR_VALUE = 0xB91,
		STENCIL_FUNC = 0xB92,
		STENCIL_VALUE_MASK = 0xB93,
		STENCIL_FAIL = 0xB94,
		STENCIL_PASS_DEPTH_FAIL = 0xB95,
		STENCIL_PASS_DEPTH_PASS = 0xB96,
		STENCIL_REF = 0xB97,
		STENCIL_WRITEMASK = 0xB98,
		VIEWPORT = 0xBA2,
		DITHER = 0xBD0,
		BLEND_DST = 0xBE0,
		BLEND_SRC = 0xBE1,
		BLEND = 0xBE2,
		LOGIC_OP_MODE = 0xBF0,
		COLOR_LOGIC_OP = 0xBF2,
		DRAW_BUFFER = 0xC01,
		READ_BUFFER = 0xC02,
		SCISSOR_BOX = 0xC10,
		SCISSOR_TEST = 0xC11,
		COLOR_CLEAR_VALUE = 0xC22,
		COLOR_WRITEMASK = 0xC23,
		DOUBLEBUFFER = 0xC32,
		STEREO = 0xC33,
		LINE_SMOOTH_HINT = 0xC52,
		POLYGON_SMOOTH_HINT = 0xC53,
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
		MAX_TEXTURE_SIZE = 0xD33,
		MAX_VIEWPORT_DIMS = 0xD3A,
		SUBPIXEL_BITS = 0xD50,
		TEXTURE_1D = 0xDE0,
		TEXTURE_2D = 0xDE1;

	/// <summary>
	/// GetTextureParameter
	/// </summary>
	public const int
		TEXTURE_WIDTH = 0x1000,
		TEXTURE_HEIGHT = 0x1001,
		TEXTURE_INTERNAL_FORMAT = 0x1003,
		TEXTURE_BORDER_COLOR = 0x1004;

	/// <summary>
	/// HintMode
	/// </summary>
	public const int
		DONT_CARE = 0x1100,
		FASTEST = 0x1101,
		NICEST = 0x1102;

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
		STENCIL_INDEX = 0x1901,
		DEPTH_COMPONENT = 0x1902,
		RED = 0x1903,
		GREEN = 0x1904,
		BLUE = 0x1905,
		ALPHA = 0x1906,
		RGB = 0x1907,
		RGBA = 0x1908;

	/// <summary>
	/// PolygonMode
	/// </summary>
	public const int
		POINT = 0x1B00,
		LINE = 0x1B01,
		FILL = 0x1B02;

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
	public const int REPEAT = 0x2901;

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
		PROXY_TEXTURE_1D = 0x8063,
		PROXY_TEXTURE_2D = 0x8064;

	/// <summary>
	/// texture_object
	/// </summary>
	public const int
		TEXTURE_BINDING_1D = 0x8068,
		TEXTURE_BINDING_2D = 0x8069;

	/// <summary>
	/// vertex_array
	/// </summary>
	public const int VERTEX_ARRAY = 0x8074;

	#endregion
}
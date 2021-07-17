/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 3.0.
/// OpenGL 3.0 implementations are guaranteed to support at least versions 1.10, 1.20 and 1.30 of the shading language,
/// although versions 1.10 and 1.20 are deprecated in a forward-compatible context.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>EXT_gpu_shader4</li>
/// 	<li>NV_conditional_render</li>
/// 	<li>APPLE_flush_buffer_range</li>
/// 	<li>ARB_color_buffer_float, NV_depth_buffer_float, ARB_texture_float, EXT_packed_float and EXT_texture_shared_exponent</li>
/// 	<li>EXT_framebuffer_object</li>
/// 	<li>NV_half_float and ARB_half_FLOAT_pixel</li>
/// 	<li>EXT_framebuffer_multisample and EXT_framebuffer_blit</li>
/// 	<li>EXT_texture_integer</li>
/// 	<li>EXT_texture_array</li>
/// 	<li>EXT_packed_depth_stencil</li>
/// 	<li>EXT_draw_buffers2</li>
/// 	<li>EXT_texture_compression_rgtc</li>
/// 	<li>EXT_transform_feedback</li>
/// 	<li>APPLE_vertex_array_object</li>
/// 	<li>EXT_framebuffer_sRGB</li>
/// </ul>
/// </summary>
public class GL30C : GL21C
{
	#region Constants

	/// <summary>
	/// GetTarget
	/// </summary>
	public const int
		MAJOR_VERSION = 0x821B,
		MINOR_VERSION = 0x821C,
		NUM_EXTENSIONS = 0x821D,
		CONTEXT_FLAGS = 0x821E,
		CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x1;

	/// <summary>
	/// Renamed tokens.
	/// </summary>
	public const int
		COMPARE_REF_TO_TEXTURE = 0x884E,
		CLIP_DISTANCE0 = 0x3000,
		CLIP_DISTANCE1 = 0x3001,
		CLIP_DISTANCE2 = 0x3002,
		CLIP_DISTANCE3 = 0x3003,
		CLIP_DISTANCE4 = 0x3004,
		CLIP_DISTANCE5 = 0x3005,
		CLIP_DISTANCE6 = 0x3006,
		CLIP_DISTANCE7 = 0x3007,
		MAX_CLIP_DISTANCES = 0xD32,
		MAX_VARYING_COMPONENTS = 0x8B4B;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetVertexAttribdv, GetVertexAttribfv, GetVertexAttribiv,
	/// GetVertexAttribIuiv and GetVertexAttribIiv.
	/// </summary>
	public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		SAMPLER_1D_ARRAY = 0x8DC0,
		SAMPLER_2D_ARRAY = 0x8DC1,
		SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,
		SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,
		SAMPLER_CUBE_SHADOW = 0x8DC5,
		UNSIGNED_INT_VEC2 = 0x8DC6,
		UNSIGNED_INT_VEC3 = 0x8DC7,
		UNSIGNED_INT_VEC4 = 0x8DC8,
		INT_SAMPLER_1D = 0x8DC9,
		INT_SAMPLER_2D = 0x8DCA,
		INT_SAMPLER_3D = 0x8DCB,
		INT_SAMPLER_CUBE = 0x8DCC,
		INT_SAMPLER_1D_ARRAY = 0x8DCE,
		INT_SAMPLER_2D_ARRAY = 0x8DCF,
		UNSIGNED_INT_SAMPLER_1D = 0x8DD1,
		UNSIGNED_INT_SAMPLER_2D = 0x8DD2,
		UNSIGNED_INT_SAMPLER_3D = 0x8DD3,
		UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,
		UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,
		UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MIN_PROGRAM_TEXEL_OFFSET = 0x8904,
		MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of BeginConditionalRender.
	/// </summary>
	public const int
		QUERY_WAIT = 0x8E13,
		QUERY_NO_WAIT = 0x8E14,
		QUERY_BY_REGION_WAIT = 0x8E15,
		QUERY_BY_REGION_NO_WAIT = 0x8E16;

	/// <summary>
	/// Accepted by the <c>access</c> parameter of MapBufferRange.
	/// </summary>
	public const int
		MAP_READ_BIT = 0x1,
		MAP_WRITE_BIT = 0x2,
		MAP_INVALIDATE_RANGE_BIT = 0x4,
		MAP_INVALIDATE_BUFFER_BIT = 0x8,
		MAP_FLUSH_EXPLICIT_BIT = 0x10,
		MAP_UNSYNCHRONIZED_BIT = 0x20;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBufferParameteriv.
	/// </summary>
	public const int
		BUFFER_ACCESS_FLAGS = 0x911F,
		BUFFER_MAP_LENGTH = 0x9120,
		BUFFER_MAP_OFFSET = 0x9121;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of ClampColor and the <c>pname</c> parameter of GetBooleanv, GetIntegerv,
	/// GetFloatv, and GetDoublev.
	/// </summary>
	public const int CLAMP_READ_COLOR = 0x891C;

	/// <summary>
	/// Accepted by the <c>clamp</c> parameter of ClampColor.
	/// </summary>
	public const int FIXED_ONLY = 0x891D;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D, and RenderbufferStorage, and returned in the <c>data</c> parameter of GetTexLevelParameter and
	/// GetRenderbufferParameteriv.
	/// </summary>
	public const int
		DEPTH_COMPONENT32F = 0x8CAC,
		DEPTH32F_STENCIL8 = 0x8CAD;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, TexImage3D,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, and GetTexImage.
	/// </summary>
	public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetTexLevelParameter.
	/// </summary>
	public const int
		TEXTURE_RED_TYPE = 0x8C10,
		TEXTURE_GREEN_TYPE = 0x8C11,
		TEXTURE_BLUE_TYPE = 0x8C12,
		TEXTURE_ALPHA_TYPE = 0x8C13,
		TEXTURE_DEPTH_TYPE = 0x8C16;

	/// <summary>
	/// Returned by the <c>params</c> parameter of GetTexLevelParameter.
	/// </summary>
	public const int UNSIGNED_NORMALIZED = 0x8C17;

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, and TexImage3D.
	/// </summary>
	public const int
		RGBA32F = 0x8814,
		RGB32F = 0x8815,
		RGBA16F = 0x881A,
		RGB16F = 0x881B;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D, and RenderbufferStorage.
	/// </summary>
	public const int R11F_G11F_B10F = 0x8C3A;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, GetTexImage, TexImage3D,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, GetHistogram, GetMinmax, ConvolutionFilter1D, ConvolutionFilter2D,
	/// ConvolutionFilter3D, GetConvolutionFilter, SeparableFilter2D, GetSeparableFilter, ColorTable, ColorSubTable, and
	/// GetColorTable.
	/// </summary>
	public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D, and RenderbufferStorage.
	/// </summary>
	public const int RGB9_E5 = 0x8C3D;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, GetTexImage, TexImage3D,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, GetHistogram, GetMinmax, ConvolutionFilter1D, ConvolutionFilter2D,
	/// ConvolutionFilter3D, GetConvolutionFilter, SeparableFilter2D, GetSeparableFilter, ColorTable, ColorSubTable, and
	/// GetColorTable.
	/// </summary>
	public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetTexLevelParameterfv and GetTexLevelParameteriv.
	/// </summary>
	public const int TEXTURE_SHARED_SIZE = 0x8C3F;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindFramebuffer, CheckFramebufferStatus, FramebufferTexture{1D|2D|3D},
	/// FramebufferRenderbuffer, and GetFramebufferAttachmentParameteriv.
	/// </summary>
	public const int
		FRAMEBUFFER = 0x8D40,
		READ_FRAMEBUFFER = 0x8CA8,
		DRAW_FRAMEBUFFER = 0x8CA9;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindRenderbuffer, RenderbufferStorage, and GetRenderbufferParameteriv,
	/// and returned by GetFramebufferAttachmentParameteriv.
	/// </summary>
	public const int RENDERBUFFER = 0x8D41;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of RenderbufferStorage.
	/// </summary>
	public const int
		STENCIL_INDEX1 = 0x8D46,
		STENCIL_INDEX4 = 0x8D47,
		STENCIL_INDEX8 = 0x8D48,
		STENCIL_INDEX16 = 0x8D49;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetRenderbufferParameteriv.
	/// </summary>
	public const int
		RENDERBUFFER_WIDTH = 0x8D42,
		RENDERBUFFER_HEIGHT = 0x8D43,
		RENDERBUFFER_INTERNAL_FORMAT = 0x8D44,
		RENDERBUFFER_RED_SIZE = 0x8D50,
		RENDERBUFFER_GREEN_SIZE = 0x8D51,
		RENDERBUFFER_BLUE_SIZE = 0x8D52,
		RENDERBUFFER_ALPHA_SIZE = 0x8D53,
		RENDERBUFFER_DEPTH_SIZE = 0x8D54,
		RENDERBUFFER_STENCIL_SIZE = 0x8D55,
		RENDERBUFFER_SAMPLES = 0x8CAB;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetFramebufferAttachmentParameteriv.
	/// </summary>
	public const int
		FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0,
		FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1,
		FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2,
		FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3,
		FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4,
		FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210,
		FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211,
		FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212,
		FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213,
		FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214,
		FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215,
		FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216,
		FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

	/// <summary>
	/// Returned in <c>params</c> by GetFramebufferAttachmentParameteriv.
	/// </summary>
	public const int FRAMEBUFFER_DEFAULT = 0x8218;

	/// <summary>
	/// Accepted by the <c>attachment</c> parameter of FramebufferTexture{1D|2D|3D}, FramebufferRenderbuffer, and
	/// GetFramebufferAttachmentParameteriv.
	/// </summary>
	public const int
		COLOR_ATTACHMENT0 = 0x8CE0,
		COLOR_ATTACHMENT1 = 0x8CE1,
		COLOR_ATTACHMENT2 = 0x8CE2,
		COLOR_ATTACHMENT3 = 0x8CE3,
		COLOR_ATTACHMENT4 = 0x8CE4,
		COLOR_ATTACHMENT5 = 0x8CE5,
		COLOR_ATTACHMENT6 = 0x8CE6,
		COLOR_ATTACHMENT7 = 0x8CE7,
		COLOR_ATTACHMENT8 = 0x8CE8,
		COLOR_ATTACHMENT9 = 0x8CE9,
		COLOR_ATTACHMENT10 = 0x8CEA,
		COLOR_ATTACHMENT11 = 0x8CEB,
		COLOR_ATTACHMENT12 = 0x8CEC,
		COLOR_ATTACHMENT13 = 0x8CED,
		COLOR_ATTACHMENT14 = 0x8CEE,
		COLOR_ATTACHMENT15 = 0x8CEF,
		COLOR_ATTACHMENT16 = 0x8CF0,
		COLOR_ATTACHMENT17 = 0x8CF1,
		COLOR_ATTACHMENT18 = 0x8CF2,
		COLOR_ATTACHMENT19 = 0x8CF3,
		COLOR_ATTACHMENT20 = 0x8CF4,
		COLOR_ATTACHMENT21 = 0x8CF5,
		COLOR_ATTACHMENT22 = 0x8CF6,
		COLOR_ATTACHMENT23 = 0x8CF7,
		COLOR_ATTACHMENT24 = 0x8CF8,
		COLOR_ATTACHMENT25 = 0x8CF9,
		COLOR_ATTACHMENT26 = 0x8CFA,
		COLOR_ATTACHMENT27 = 0x8CFB,
		COLOR_ATTACHMENT28 = 0x8CFC,
		COLOR_ATTACHMENT29 = 0x8CFD,
		COLOR_ATTACHMENT30 = 0x8CFE,
		COLOR_ATTACHMENT31 = 0x8CFF,
		DEPTH_ATTACHMENT = 0x8D00,
		STENCIL_ATTACHMENT = 0x8D20,
		DEPTH_STENCIL_ATTACHMENT = 0x821A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int MAX_SAMPLES = 0x8D57;

	/// <summary>
	/// Returned by CheckFramebufferStatus().
	/// </summary>
	public const int
		FRAMEBUFFER_COMPLETE = 0x8CD5,
		FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6,
		FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7,
		FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB,
		FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC,
		FRAMEBUFFER_UNSUPPORTED = 0x8CDD,
		FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56,
		FRAMEBUFFER_UNDEFINED = 0x8219;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetIntegerv, GetFloatv,  and GetDoublev.
	/// </summary>
	public const int
		FRAMEBUFFER_BINDING = 0x8CA6,
		DRAW_FRAMEBUFFER_BINDING = 0x8CA6,
		READ_FRAMEBUFFER_BINDING = 0x8CAA,
		RENDERBUFFER_BINDING = 0x8CA7,
		MAX_COLOR_ATTACHMENTS = 0x8CDF,
		MAX_RENDERBUFFER_SIZE = 0x84E8;

	/// <summary>
	/// Returned by GetError().
	/// </summary>
	public const int INVALID_FRAMEBUFFER_OPERATION = 0x506;

	/// <summary>
	/// Accepted by the <c>format</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, TexImage3D,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, and GetTexImage, by the <c>type</c> parameter of CopyPixels, by the
	/// <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D, CopyTexImage2D, and
	/// RenderbufferStorage, and returned in the <c>data</c> parameter of GetTexLevelParameter and
	/// GetRenderbufferParameteriv.
	/// </summary>
	public const int DEPTH_STENCIL = 0x84F9;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, TexImage3D,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, and GetTexImage.
	/// </summary>
	public const int UNSIGNED_INT_24_8 = 0x84FA;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D, and RenderbufferStorage, and returned in the <c>data</c> parameter of GetTexLevelParameter and
	/// GetRenderbufferParameteriv.
	/// </summary>
	public const int DEPTH24_STENCIL8 = 0x88F0;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetTexLevelParameter.
	/// </summary>
	public const int TEXTURE_STENCIL_SIZE = 0x88F1;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of DrawPixels, ReadPixels, TexImage1D, TexImage2D, TexImage3D, GetTexImage,
	/// TexSubImage1D, TexSubImage2D, TexSubImage3D, GetHistogram, GetMinmax, ConvolutionFilter1D, ConvolutionFilter2D,
	/// GetConvolutionFilter, SeparableFilter2D, GetSeparableFilter, ColorTable, ColorSubTable, and GetColorTable.<br/>
	/// Accepted by the <c>type</c> argument of VertexPointer, NormalPointer, ColorPointer, SecondaryColorPointer,
	/// FogCoordPointer, TexCoordPointer, and VertexAttribPointer.
	/// </summary>
	public const int HALF_FLOAT = 0x140B;

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, and TexImage3D.
	/// </summary>
	public const int
		RGBA32UI = 0x8D70,
		RGB32UI = 0x8D71,
		RGBA16UI = 0x8D76,
		RGB16UI = 0x8D77,
		RGBA8UI = 0x8D7C,
		RGB8UI = 0x8D7D,
		RGBA32I = 0x8D82,
		RGB32I = 0x8D83,
		RGBA16I = 0x8D88,
		RGB16I = 0x8D89,
		RGBA8I = 0x8D8E,
		RGB8I = 0x8D8F;

	/// <summary>
	/// Accepted by the <c>format</c> parameter of TexImage1D, TexImage2D, TexImage3D, TexSubImage1D, TexSubImage2D,
	/// TexSubImage3D, DrawPixels and ReadPixels.
	/// </summary>
	public const int
		RED_INTEGER = 0x8D94,
		GREEN_INTEGER = 0x8D95,
		BLUE_INTEGER = 0x8D96,
		RGB_INTEGER = 0x8D98,
		RGBA_INTEGER = 0x8D99,
		BGR_INTEGER = 0x8D9A,
		BGRA_INTEGER = 0x8D9B;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexParameteri, TexParameteriv, TexParameterf, TexParameterfv,
	/// GenerateMipmap, and BindTexture.
	/// </summary>
	public const int
		TEXTURE_1D_ARRAY = 0x8C18,
		TEXTURE_2D_ARRAY = 0x8C1A;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexImage3D, TexSubImage3D, CopyTexSubImage3D, CompressedTexImage3D,
	/// and CompressedTexSubImage3D.
	/// </summary>
	public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexImage2D, TexSubImage2D, CopyTexImage2D, CopyTexSubImage2D,
	/// CompressedTexImage2D, and CompressedTexSubImage2D.
	/// </summary>
	public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv and GetFloatv.
	/// </summary>
	public const int
		TEXTURE_BINDING_1D_ARRAY = 0x8C1C,
		TEXTURE_BINDING_2D_ARRAY = 0x8C1D,
		MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage2D, CopyTexImage2D, and CompressedTexImage2D and the
	/// <c>format</c> parameter of CompressedTexSubImage2D.
	/// </summary>
	public const int
		COMPRESSED_RED_RGTC1 = 0x8DBB,
		COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC,
		COMPRESSED_RG_RGTC2 = 0x8DBD,
		COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D, and
	/// CopyTexImage2D.
	/// </summary>
	public const int
		R8 = 0x8229,
		R16 = 0x822A,
		RG8 = 0x822B,
		RG16 = 0x822C,
		R16F = 0x822D,
		R32F = 0x822E,
		RG16F = 0x822F,
		RG32F = 0x8230,
		R8I = 0x8231,
		R8UI = 0x8232,
		R16I = 0x8233,
		R16UI = 0x8234,
		R32I = 0x8235,
		R32UI = 0x8236,
		RG8I = 0x8237,
		RG8UI = 0x8238,
		RG16I = 0x8239,
		RG16UI = 0x823A,
		RG32I = 0x823B,
		RG32UI = 0x823C,
		RG = 0x8227,
		COMPRESSED_RED = 0x8225,
		COMPRESSED_RG = 0x8226;

	/// <summary>
	/// Accepted by the <c>format</c> parameter of TexImage3D, TexImage2D, TexImage3D, TexSubImage1D, TexSubImage2D,
	/// TexSubImage3D, and ReadPixels.
	/// </summary>
	public const int RG_INTEGER = 0x8228;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, GetBufferPointerv, BindBufferRange, BindBufferOffset and BindBufferBase.
	/// </summary>
	public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of GetIntegeri_v and GetBooleani_v.
	/// </summary>
	public const int
		TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84,
		TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of GetIntegeri_v and GetBooleani_v, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

	/// <summary>
	/// Accepted by the <c>bufferMode</c> parameter of TransformFeedbackVaryings.
	/// </summary>
	public const int
		INTERLEAVED_ATTRIBS = 0x8C8C,
		SEPARATE_ATTRIBS = 0x8C8D;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, and GetQueryiv.
	/// </summary>
	public const int
		PRIMITIVES_GENERATED = 0x8C87,
		TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

	/**
     * Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	 * GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
     */
	public const int RASTERIZER_DISCARD = 0x8C89;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int
		MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A,
		MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B,
		MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int
		TRANSFORM_FEEDBACK_VARYINGS = 0x8C83,
		TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F,
		TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int VERTEX_ARRAY_BINDING = 0x85B5;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int FRAMEBUFFER_SRGB = 0x8DB9;

	#endregion
}
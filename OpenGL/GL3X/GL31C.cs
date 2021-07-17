/// <summary>
/// The OpenGL functionality of a forward compatible context, up to version 3.1.
/// OpenGL 3.1 implementations support revision 1.40 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_draw_instanced</li>
/// 	<li>ARB_copy_buffer</li>
/// 	<li>NV_primitive_restart</li>
/// 	<li>ARB_texture_buffer_object</li>
/// 	<li>ARB_texture_rectangle</li>
/// 	<li>ARB_uniform_buffer_object</li>
/// </ul>
/// </summary>
public class GL31C : GL30C
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, and TexImage3D.
	/// </summary>
	public const int
		R8_SNORM = 0x8F94,
		RG8_SNORM = 0x8F95,
		RGB8_SNORM = 0x8F96,
		RGBA8_SNORM = 0x8F97,
		R16_SNORM = 0x8F98,
		RG16_SNORM = 0x8F99,
		RGB16_SNORM = 0x8F9A,
		RGBA16_SNORM = 0x8F9B;

	/// <summary>
	/// Returned by GetTexLevelParameter and GetFramebufferAttachmentParameter.
	/// </summary>
	public const int SIGNED_NORMALIZED = 0x8F9C;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		SAMPLER_BUFFER = 0x8DC2,
		INT_SAMPLER_2D_RECT = 0x8DCD,
		INT_SAMPLER_BUFFER = 0x8DD0,
		UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5,
		UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;

	/// <summary>
	/// Accepted by the target parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, GetBufferPointerv, MapBufferRange, FlushMappedBufferRange, GetBufferParameteriv,
	/// BindBufferRange, BindBufferBase, and CopyBufferSubData.
	/// </summary>
	public const int
		COPY_READ_BUFFER = 0x8F36,
		COPY_WRITE_BUFFER = 0x8F37;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable and IsEnabled.
	/// </summary>
	public const int PRIMITIVE_RESTART = 0x8F9D;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int PRIMITIVE_RESTART_INDEX = 0x8F9E;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindBuffer, BufferData, BufferSubData, MapBuffer, MapBufferRange,
	/// BindTexture, UnmapBuffer, GetBufferSubData, GetBufferParameteriv, GetBufferPointerv, and TexBuffer, and the
	/// <c>pname</c> parameter of GetBooleanv, GetDoublev, GetFloatv, and GetIntegerv.
	/// </summary>
	public const int TEXTURE_BUFFER = 0x8C2A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetBooleanv, GetDoublev, GetFloatv, and GetIntegerv.
	/// </summary>
	public const int
		MAX_TEXTURE_BUFFER_SIZE = 0x8C2B,
		TEXTURE_BINDING_BUFFER = 0x8C2C,
		TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable and IsEnabled; by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv and GetDoublev; and by the <c>target</c> parameter of BindTexture,
	/// GetTexParameterfv, GetTexParameteriv, TexParameterf, TexParameteri, TexParameterfv and TexParameteriv.
	/// </summary>
	public const int TEXTURE_RECTANGLE = 0x84F5;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv and GetDoublev.
	/// </summary>
	public const int TEXTURE_BINDING_RECTANGLE = 0x84F6;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of GetTexLevelParameteriv, GetTexLevelParameterfv, GetTexParameteriv and
	/// TexImage2D.
	/// </summary>
	public const int PROXY_TEXTURE_RECTANGLE = 0x84F7;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv and GetFloatv.
	/// </summary>
	public const int MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;

	/// <summary>
	/// Returned by <c>type</c> parameter of GetActiveUniform when the location <c>index</c> for program object
	/// <c>program</c> is of type sampler2DRect.
	/// </summary>
	public const int SAMPLER_2D_RECT = 0x8B63;

	/// <summary>
	/// Returned by <c>type</c> parameter of GetActiveUniform when the location <c>index</c> for program object
	/// <c>program</c> is of type sampler2DRectShadow.
	/// </summary>
	public const int SAMPLER_2D_RECT_SHADOW = 0x8B64;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, and GetBufferPointerv.
	/// </summary>
	public const int UNIFORM_BUFFER = 0x8A11;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegeri_v, GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int UNIFORM_BUFFER_BINDING = 0x8A28;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegeri_v.
	/// </summary>
	public const int
		UNIFORM_BUFFER_START = 0x8A29,
		UNIFORM_BUFFER_SIZE = 0x8A2A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B,
		MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C,
		MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D,
		MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E,
		MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F,
		MAX_UNIFORM_BLOCK_SIZE = 0x8A30,
		MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31,
		MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32,
		MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33,
		UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetProgramiv.
	/// </summary>
	public const int
		ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35,
		ACTIVE_UNIFORM_BLOCKS = 0x8A36;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveUniformsiv.
	/// </summary>
	public const int
		UNIFORM_TYPE = 0x8A37,
		UNIFORM_SIZE = 0x8A38,
		UNIFORM_NAME_LENGTH = 0x8A39,
		UNIFORM_BLOCK_INDEX = 0x8A3A,
		UNIFORM_OFFSET = 0x8A3B,
		UNIFORM_ARRAY_STRIDE = 0x8A3C,
		UNIFORM_MATRIX_STRIDE = 0x8A3D,
		UNIFORM_IS_ROW_MAJOR = 0x8A3E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetActiveUniformBlockiv.
	/// </summary>
	public const int
		UNIFORM_BLOCK_BINDING = 0x8A3F,
		UNIFORM_BLOCK_DATA_SIZE = 0x8A40,
		UNIFORM_BLOCK_NAME_LENGTH = 0x8A41,
		UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42,
		UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43,
		UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44,
		UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45,
		UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;

	/// <summary>
	/// Returned by GetActiveUniformsiv and GetUniformBlockIndex.
	/// </summary>
	public const uint INVALID_INDEX = 0xFFFFFFFF;

	#endregion
}
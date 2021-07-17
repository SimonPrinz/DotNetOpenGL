/// <summary>
/// The OpenGL functionality up to version 4.4. Includes the deprecated symbols of the Compatibility Profile.
/// OpenGL 4.4 implementations support revision 4.40 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_buffer_storage</li>
/// 	<li>ARB_clear_texture</li>
/// 	<li>ARB_enhanced_layouts</li>
/// 	<li>ARB_multi_bind</li>
/// 	<li>ARB_query_buffer_object</li>
/// 	<li>ARB_texture_mirror_clamp_to_edge</li>
/// 	<li>ARB_texture_stencil8</li>
/// 	<li>ARB_vertex_type_10f_11f_11f_rev</li>
/// </ul>
/// </summary>
public class GL44 : GL43
{
	#region Constants

	/// <summary>
	/// Implementation-dependent state which constrains the maximum value of stride parameters to vertex array
	/// pointer-setting commands.
	/// </summary>
	public const int MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

	/// <summary>
	/// Implementations are not required to support primitive restart for separate patch primitives
	/// (primitive type PATCHES). Support can be queried by calling GetBooleanv with the symbolic constant
	/// PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED. A value of FALSE indicates that primitive restart is treated as
	/// disabled when drawing patches, no matter the value of the enables. A value of TRUE indicates that primitive
	/// restart behaves normally for patches.
	/// </summary>
	public const int PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

	/// <summary>
	/// Equivalent to TEXTURE_BUFFER_ARB query, but named more consistently.
	/// </summary>
	public const int TEXTURE_BUFFER_BINDING = 0x8C2A;

	/// <summary>
	/// Accepted in the <c>flags</c> parameter of BufferStorage and NamedBufferStorageEXT.
	/// </summary>
	public const int
		MAP_PERSISTENT_BIT = 0x40,
		MAP_COHERENT_BIT = 0x80,
		DYNAMIC_STORAGE_BIT = 0x100,
		CLIENT_STORAGE_BIT = 0x200;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBufferParameter.
	/// </summary>
	public const int
		BUFFER_IMMUTABLE_STORAGE = 0x821F,
		BUFFER_STORAGE_FLAGS = 0x8220;

	/// <summary>
	/// Accepted by the <c>barriers</c> parameter of MemoryBarrier.
	/// </summary>
	public const int CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x4000;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter for GetInternalformativ and GetInternalformati64v.
	/// </summary>
	public const int CLEAR_TEXTURE = 0x9365;

	/// <summary>
	/// Accepted in the <c>props</c> array of GetProgramResourceiv.
	/// </summary>
	public const int
		LOCATION_COMPONENT = 0x934A,
		TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B,
		TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetQueryObjectiv, GetQueryObjectuiv, GetQueryObjecti64v and
	/// GetQueryObjectui64v.
	/// </summary>
	public const int QUERY_RESULT_NO_WAIT = 0x9194;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// MapBufferRange, GetBufferSubData, GetBufferParameteriv, GetBufferParameteri64v, GetBufferPointerv,
	/// ClearBufferSubData, and the <c>readtarget</c> and <c>writetarget</c> parameters of CopyBufferSubData.
	/// </summary>
	public const int QUERY_BUFFER = 0x9192;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int QUERY_BUFFER_BINDING = 0x9193;

	/// <summary>
	/// Accepted in the <c>barriers</c> bitfield in MemoryBarrier.
	/// </summary>
	public const int QUERY_BUFFER_BARRIER_BIT = 0x8000;

	/// <summary>
	/// Accepted by the <c>param</c> parameter of TexParameter{if}, SamplerParameter{if} and SamplerParameter{if}v, and
	/// by the <c>params</c> parameter of TexParameter{if}v, TexParameterI{i ui}v and SamplerParameterI{i ui}v when
	/// their <c>pname</c> parameter is TEXTURE_WRAP_S, TEXTURE_WRAP_T, or TEXTURE_WRAP_R,
	/// </summary>
	public const int MIRROR_CLAMP_TO_EDGE = 0x8743;

	#endregion
}
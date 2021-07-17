/// <summary>
/// The OpenGL functionality up to version 3.2. Includes the deprecated symbols of the Compatibility Profile.
/// OpenGL 3.2 implementations support revision 1.50 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_vertex_array_bgra</li>
/// 	<li>ARB_draw_elements_base_vertex</li>
/// 	<li>ARB_fragment_coord_conventions</li>
/// 	<li>ARB_provoking_vertex</li>
/// 	<li>ARB_seamless_cube_map</li>
/// 	<li>ARB_texture_multisample</li>
/// 	<li>ARB_depth_clamp</li>
/// 	<li>ARB_geometry_shader4</li>
/// 	<li>ARB_sync</li>
/// </ul>
/// </summary>
public class GL32 : GL31
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv.
	/// </summary>
	public const int CONTEXT_PROFILE_MASK = 0x9126;

	/// <summary>
	/// Context profile bits.
	/// </summary>
	public const int
		CONTEXT_CORE_PROFILE_BIT = 0x1,
		CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x2;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122,
		MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123,
		MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124,
		MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of ProvokingVertex.
	/// </summary>
	public const int
		FIRST_VERTEX_CONVENTION = 0x8E4D,
		LAST_VERTEX_CONVENTION = 0x8E4E;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		PROVOKING_VERTEX = 0x8E4F,
		QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv and GetDoublev.
	/// </summary>
	public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetMultisamplefv.
	/// </summary>
	public const int SAMPLE_POSITION = 0x8E50;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int SAMPLE_MASK = 0x8E51;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of GetBooleani_v and GetIntegeri_v.
	/// </summary>
	public const int SAMPLE_MASK_VALUE = 0x8E52;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindTexture and TexImage2DMultisample.
	/// </summary>
	public const int TEXTURE_2D_MULTISAMPLE = 0x9100;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexImage2DMultisample.
	/// </summary>
	public const int PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BindTexture and TexImage3DMultisample.
	/// </summary>
	public const int TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of TexImage3DMultisample.
	/// </summary>
	public const int PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int
		MAX_SAMPLE_MASK_WORDS = 0x8E59,
		MAX_COLOR_TEXTURE_SAMPLES = 0x910E,
		MAX_DEPTH_TEXTURE_SAMPLES = 0x910F,
		MAX_INTEGER_SAMPLES = 0x9110,
		TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104,
		TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetTexLevelParameter.
	/// </summary>
	public const int
		TEXTURE_SAMPLES = 0x9106,
		TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		SAMPLER_2D_MULTISAMPLE = 0x9108,
		INT_SAMPLER_2D_MULTISAMPLE = 0x9109,
		UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,
		SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,
		INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,
		UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int DEPTH_CLAMP = 0x864F;

	/// <summary>
	/// Accepted by the <c>type</c> parameter of CreateShader and returned by the <c>params</c> parameter of GetShaderiv.
	/// </summary>
	public const int GEOMETRY_SHADER = 0x8DD9;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of ProgramParameteri and GetProgramiv.
	/// </summary>
	public const int
		GEOMETRY_VERTICES_OUT = 0x8DDA,
		GEOMETRY_INPUT_TYPE = 0x8DDB,
		GEOMETRY_OUTPUT_TYPE = 0x8DDC;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29,
		MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF,
		MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0,
		MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of Begin, DrawArrays, MultiDrawArrays, DrawElements, MultiDrawElements,
	/// and DrawRangeElements.
	/// </summary>
	public const int
		LINES_ADJACENCY = 0xA,
		LINE_STRIP_ADJACENCY = 0xB,
		TRIANGLES_ADJACENCY = 0xC,
		TRIANGLE_STRIP_ADJACENCY = 0xD;

	/// <summary>
	/// Returned by CheckFramebufferStatus.
	/// </summary>
	public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetFramebufferAttachment- Parameteriv.
	/// </summary>
	public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

	/// <summary>
	/// Accepted by the <c>cap</c> parameter of Enable, Disable, and IsEnabled, and by the <c>pname</c> parameter of
	/// GetIntegerv, GetFloatv, GetDoublev, and GetBooleanv.
	/// </summary>
	public const int PROGRAM_POINT_SIZE = 0x8642;

	/// <summary>
	/// Accepted as the <c>pname</c> parameter of GetInteger64v.
	/// </summary>
	public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;

	/// <summary>
	/// Accepted as the <c>pname</c> parameter of GetSynciv.
	/// </summary>
	public const int
		OBJECT_TYPE = 0x9112,
		SYNC_CONDITION = 0x9113,
		SYNC_STATUS = 0x9114,
		SYNC_FLAGS = 0x9115;

	/// <summary>
	/// Returned in <c>values</c> for GetSynciv <c>pname</c> OBJECT_TYPE.
	/// </summary>
	public const int SYNC_FENCE = 0x9116;

	/// <summary>
	/// Returned in <c>values</c> for GetSynciv <c>pname</c> SYNC_CONDITION.
	/// </summary>
	public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

	/// <summary>
	/// Returned in <c>values</c> for GetSynciv <c>pname</c> SYNC_STATUS.
	/// </summary>
	public const int
		UNSIGNALED = 0x9118,
		SIGNALED = 0x9119;

	/// <summary>
	/// Accepted in the <c>flags</c> parameter of ClientWaitSync.
	/// </summary>
	public const int SYNC_FLUSH_COMMANDS_BIT = 0x1;

	/// <summary>
	/// Accepted in the <c>timeout</c> parameter of WaitSync.
	/// </summary>
	public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;

	/// <summary>
	/// Returned by ClientWaitSync.
	/// </summary>
	public const int
		ALREADY_SIGNALED = 0x911A,
		TIMEOUT_EXPIRED = 0x911B,
		CONDITION_SATISFIED = 0x911C,
		WAIT_FAILED = 0x911D;

	#endregion
}
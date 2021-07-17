/// <summary>
/// The OpenGL functionality up to version 4.5. Includes only Core Profile symbols.
/// OpenGL 4.5 implementations support revision 4.50 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_clip_control</li>
/// 	<li>ARB_cull_distance</li>
/// 	<li>ARB_ES3_1_compatibility</li>
/// 	<li>ARB_conditional_render_inverted</li>
/// 	<li>KHR_context_flush_control</li>
/// 	<li>ARB_derivative_control</li>
/// 	<li>ARB_direct_state_access</li>
/// 	<li>ARB_get_texture_sub_image</li>
/// 	<li>KHR_robustness</li>
/// 	<li>ARB_shader_texture_image_samples</li>
/// 	<li>ARB_texture_barrier</li>
/// </ul>
/// </summary>
public class GL45C : GL44C
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>depth</c> parameter of ClipControl.
	/// </summary>
	public const int
		NEGATIVE_ONE_TO_ONE = 0x935E,
		ZERO_TO_ONE = 0x935F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		CLIP_ORIGIN = 0x935C,
		CLIP_DEPTH_MODE = 0x935D;

	/// <summary>
	/// Accepted by the <c>mode</c> parameter of BeginConditionalRender.
	/// </summary>
	public const int
		QUERY_WAIT_INVERTED = 0x8E17,
		QUERY_NO_WAIT_INVERTED = 0x8E18,
		QUERY_BY_REGION_WAIT_INVERTED = 0x8E19,
		QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetDoublev, GetFloatv, GetIntegerv, and GetInteger64v.
	/// </summary>
	public const int
		MAX_CULL_DISTANCES = 0x82F9,
		MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetTextureParameter{if}v and GetTextureParameterI{i ui}v.
	/// </summary>
	public const int TEXTURE_TARGET = 0x1006;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetQueryObjectiv.
	/// </summary>
	public const int QUERY_TARGET = 0x82EA;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetIntegerv, GetFloatv, GetBooleanv GetDoublev and GetInteger64v.
	/// </summary>
	public const int CONTEXT_RELEASE_BEHAVIOR = 0x82FB;

	/// <summary>
	/// Returned in <c>data</c> by GetIntegerv, GetFloatv, GetBooleanv GetDoublev and GetInteger64v when <c>pname</c> is
	/// CONTEXT_RELEASE_BEHAVIOR.
	/// </summary>
	public const int CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

	/// <summary>
	/// Returned by GetGraphicsResetStatus.
	/// </summary>
	public const int
		GUILTY_CONTEXT_RESET = 0x8253,
		INNOCENT_CONTEXT_RESET = 0x8254,
		UNKNOWN_CONTEXT_RESET = 0x8255;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of GetBooleanv, GetIntegerv, and GetFloatv.
	/// </summary>
	public const int RESET_NOTIFICATION_STRATEGY = 0x8256;

	/// <summary>
	/// Returned by GetIntegerv and related simple queries when <c>value</c> is RESET_NOTIFICATION_STRATEGY.
	/// </summary>
	public const int
		LOSE_CONTEXT_ON_RESET = 0x8252,
		NO_RESET_NOTIFICATION = 0x8261;

	/// <summary>
	/// Returned by GetIntegerv when <c>pname</c> is CONTEXT_FLAGS.
	/// </summary>
	public const int CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x4;

	/// <summary>
	/// Returned by GetError.
	/// </summary>
	public const int CONTEXT_LOST = 0x507;

	#endregion
}
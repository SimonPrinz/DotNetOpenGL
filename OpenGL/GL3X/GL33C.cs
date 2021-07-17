/// <summary>
/// The OpenGL functionality up to version 3.3. Includes only Core Profile symbols.
/// OpenGL 3.3 implementations support revision 3.30 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_shader_bit_encoding</li>
/// 	<li>ARB_blend_func_extended</li>
/// 	<li>ARB_explicit_attrib_location</li>
/// 	<li>ARB_occlusion_query2</li>
/// 	<li>ARB_sampler_objects</li>
/// 	<li>ARB_texture_rgb10_a2ui</li>
/// 	<li>ARB_texture_swizzle</li>
/// 	<li>ARB_timer_query</li>
/// 	<li>ARB_instanced_arrays</li>
/// 	<li>ARB_vertex_type_2_10_10_10_rev</li>
/// </ul>
/// </summary>
public class GL33C : GL32C
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>src</c> and <c>dst</c> parameters of BlendFunc and BlendFunci, and by the <c>srcRGB</c>,
	/// <c>dstRGB</c>, <c>srcAlpha</c> and <c>dstAlpha</c> parameters of BlendFuncSeparate and BlendFuncSeparatei.
	/// </summary>
	public const int
		SRC1_COLOR = 0x88F9,
		ONE_MINUS_SRC1_COLOR = 0x88FA,
		ONE_MINUS_SRC1_ALPHA = 0x88FB;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv and GetDoublev.
	/// </summary>
	public const int MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, and GetQueryiv.
	/// </summary>
	public const int ANY_SAMPLES_PASSED = 0x8C2F;

	/// <summary>
	/// Accepted by the <c>value</c> parameter of the GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv and GetDoublev
	/// functions.
	/// </summary>
	public const int SAMPLER_BINDING = 0x8919;

	/// <summary>
	/// Accepted by the <c>internalFormat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D, RenderbufferStorage and RenderbufferStorageMultisample.
	/// </summary>
	public const int RGB10_A2UI = 0x906F;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of TexParameteri, TexParameterf, TexParameteriv, TexParameterfv,
	/// GetTexParameterfv, and GetTexParameteriv.
	/// </summary>
	public const int
		TEXTURE_SWIZZLE_R = 0x8E42,
		TEXTURE_SWIZZLE_G = 0x8E43,
		TEXTURE_SWIZZLE_B = 0x8E44,
		TEXTURE_SWIZZLE_A = 0x8E45;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of TexParameteriv,  TexParameterfv, GetTexParameterfv, and
	/// GetTexParameteriv.
	/// </summary>
	public const int TEXTURE_SWIZZLE_RGBA = 0x8E46;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, and GetQueryiv.
	/// </summary>
	public const int TIME_ELAPSED = 0x88BF;

	/// <summary>
	/// Accepted by the <c>target</c> parameter of GetQueryiv and QueryCounter. Accepted by the <c>value</c> parameter
	/// of GetBooleanv, GetIntegerv, GetInteger64v, GetFloatv, and GetDoublev.
	/// </summary>
	public const int TIMESTAMP = 0x8E28;

	/// <summary>
	/// Accepted by the <c>pname</c> parameters of GetVertexAttribdv, GetVertexAttribfv, and GetVertexAttribiv.
	/// </summary>
	public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

	/** Accepted by the <c>type</c> parameter of VertexAttribPointer, VertexPointer, NormalPointer, ColorPointer,
	 * SecondaryColorPointer, TexCoordPointer, VertexAttribP{1234}ui, VertexP*, TexCoordP*, MultiTexCoordP*, NormalP3ui,
	 * ColorP*, SecondaryColorP* and VertexAttribP*.
	 */
	public const int INT_2_10_10_10_REV = 0x8D9F;

	#endregion
}
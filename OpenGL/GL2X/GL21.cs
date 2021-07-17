/// <summary>
/// The OpenGL functionality up to version 2.1. Includes the deprecated symbols of the Compatibility Profile.
/// OpenGL 2.1 implementations must support at least revision 1.20 of the OpenGL Shading Language.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_pixel_buffer_object</li>
/// 	<li>EXT_texture_sRGB</li>
/// </ul>
/// </summary>
public class GL21 : GL20
{
	#region Constants

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int CURRENT_RASTER_SECONDARY_COLOR = 0x845F;

	/// <summary>
	/// Returned by the <c>type</c> parameter of GetActiveUniform.
	/// </summary>
	public const int
		FLOAT_MAT2x3 = 0x8B65,
		FLOAT_MAT2x4 = 0x8B66,
		FLOAT_MAT3x2 = 0x8B67,
		FLOAT_MAT3x4 = 0x8B68,
		FLOAT_MAT4x2 = 0x8B69,
		FLOAT_MAT4x3 = 0x8B6A;

	/// <summary>
	/// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
	/// GetBufferSubData, GetBufferParameteriv, and GetBufferPointerv.
	/// </summary>
	public const int
		PIXEL_PACK_BUFFER   = 0x88EB,
		PIXEL_UNPACK_BUFFER = 0x88EC;

	/// <summary>
	/// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
	/// </summary>
	public const int
		PIXEL_PACK_BUFFER_BINDING   = 0x88ED,
		PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;

	/// <summary>
	/// Accepted by the <c>internalformat</c> parameter of TexImage1D, TexImage2D, TexImage3D, CopyTexImage1D,
	/// CopyTexImage2D.
	/// </summary>
	public const int
		SRGB                        = 0x8C40,
		SRGB8                       = 0x8C41,
		SRGB_ALPHA                  = 0x8C42,
		SRGB8_ALPHA8                = 0x8C43,
		SLUMINANCE_ALPHA            = 0x8C44,
		SLUMINANCE8_ALPHA8          = 0x8C45,
		SLUMINANCE                  = 0x8C46,
		SLUMINANCE8                 = 0x8C47,
		COMPRESSED_SRGB             = 0x8C48,
		COMPRESSED_SRGB_ALPHA       = 0x8C49,
		COMPRESSED_SLUMINANCE       = 0x8C4A,
		COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;

	#endregion
}
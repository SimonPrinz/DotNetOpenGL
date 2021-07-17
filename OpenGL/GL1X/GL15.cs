/// <summary>
/// The OpenGL functionality up to version 1.5. Includes the deprecated symbols of the Compatibility Profile.<br/>
/// Extensions promoted to core in this release:
/// <ul>
/// 	<li>ARB_vertex_buffer_object</li>
/// 	<li>ARB_occlusion_query</li>
/// 	<li>EXT_shadow_funcs</li>
/// </ul>
/// </summary>
public class GL15 : GL14
{
	#region Constants
    
    /// <summary>
    /// New token names.
    /// </summary>
    public const int
        FOG_COORD_SRC                  = 0x8450,
        FOG_COORD                      = 0x8451,
        CURRENT_FOG_COORD              = 0x8453,
        FOG_COORD_ARRAY_TYPE           = 0x8454,
        FOG_COORD_ARRAY_STRIDE         = 0x8455,
        FOG_COORD_ARRAY_POINTER        = 0x8456,
        FOG_COORD_ARRAY                = 0x8457,
        FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D,
        SRC0_RGB                       = 0x8580,
        SRC1_RGB                       = 0x8581,
        SRC2_RGB                       = 0x8582,
        SRC0_ALPHA                     = 0x8588,
        SRC1_ALPHA                     = 0x8589,
        SRC2_ALPHA                     = 0x858A;
    
    /// <summary>
    /// Accepted by the <c>target</c> parameters of BindBuffer, BufferData, BufferSubData, MapBuffer, UnmapBuffer,
    /// GetBufferSubData, GetBufferParameteriv, and GetBufferPointerv.
    /// </summary>
    public const int
        ARRAY_BUFFER         = 0x8892,
        ELEMENT_ARRAY_BUFFER = 0x8893;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBooleanv, GetIntegerv, GetFloatv, and GetDoublev.
    /// </summary>
    public const int
        ARRAY_BUFFER_BINDING                 = 0x8894,
        ELEMENT_ARRAY_BUFFER_BINDING         = 0x8895,
        VERTEX_ARRAY_BUFFER_BINDING          = 0x8896,
        NORMAL_ARRAY_BUFFER_BINDING          = 0x8897,
        COLOR_ARRAY_BUFFER_BINDING           = 0x8898,
        INDEX_ARRAY_BUFFER_BINDING           = 0x8899,
        TEXTURE_COORD_ARRAY_BUFFER_BINDING   = 0x889A,
        EDGE_FLAG_ARRAY_BUFFER_BINDING       = 0x889B,
        SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C,
        FOG_COORDINATE_ARRAY_BUFFER_BINDING  = 0x889D,
        WEIGHT_ARRAY_BUFFER_BINDING          = 0x889E;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetVertexAttribiv.
    /// </summary>
    public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

    /// <summary>
    /// Accepted by the <c>usage</c> parameter of BufferData.
    /// </summary>
    public const int
        STREAM_DRAW  = 0x88E0,
        STREAM_READ  = 0x88E1,
        STREAM_COPY  = 0x88E2,
        STATIC_DRAW  = 0x88E4,
        STATIC_READ  = 0x88E5,
        STATIC_COPY  = 0x88E6,
        DYNAMIC_DRAW = 0x88E8,
        DYNAMIC_READ = 0x88E9,
        DYNAMIC_COPY = 0x88EA;

    /// <summary>
    /// Accepted by the <c>access</c> parameter of MapBuffer.
    /// </summary>
    public const int
        READ_ONLY  = 0x88B8,
        WRITE_ONLY = 0x88B9,
        READ_WRITE = 0x88BA;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBufferParameteriv.
    /// </summary>
    public const int
        BUFFER_SIZE   = 0x8764,
        BUFFER_USAGE  = 0x8765,
        BUFFER_ACCESS = 0x88BB,
        BUFFER_MAPPED = 0x88BC;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetBufferPointerv.
    /// </summary>
    public const int BUFFER_MAP_POINTER = 0x88BD;

    /// <summary>
    /// Accepted by the <c>target</c> parameter of BeginQuery, EndQuery, and GetQueryiv.
    /// </summary>
    public const int SAMPLES_PASSED = 0x8914;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetQueryiv.
    /// </summary>
    public const int
        QUERY_COUNTER_BITS = 0x8864,
        CURRENT_QUERY      = 0x8865;

    /// <summary>
    /// Accepted by the <c>pname</c> parameter of GetQueryObjectiv and GetQueryObjectuiv.
    /// </summary>
    public const int
        QUERY_RESULT           = 0x8866,
        QUERY_RESULT_AVAILABLE = 0x8867;

	#endregion
}
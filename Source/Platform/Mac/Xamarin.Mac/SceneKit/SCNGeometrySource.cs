using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNGeometrySource", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNGeometrySource : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerComponent = "bytesPerComponent";

	private static readonly IntPtr selBytesPerComponentHandle = Selector.GetHandle("bytesPerComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsPerVector = "componentsPerVector";

	private static readonly IntPtr selComponentsPerVectorHandle = Selector.GetHandle("componentsPerVector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataOffset = "dataOffset";

	private static readonly IntPtr selDataOffsetHandle = Selector.GetHandle("dataOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataStride = "dataStride";

	private static readonly IntPtr selDataStrideHandle = Selector.GetHandle("dataStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatComponents = "floatComponents";

	private static readonly IntPtr selFloatComponentsHandle = Selector.GetHandle("floatComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometrySourceWithBuffer_VertexFormat_Semantic_VertexCount_DataOffset_DataStride_ = "geometrySourceWithBuffer:vertexFormat:semantic:vertexCount:dataOffset:dataStride:";

	private static readonly IntPtr selGeometrySourceWithBuffer_VertexFormat_Semantic_VertexCount_DataOffset_DataStride_Handle = Selector.GetHandle("geometrySourceWithBuffer:vertexFormat:semantic:vertexCount:dataOffset:dataStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometrySourceWithData_Semantic_VectorCount_FloatComponents_ComponentsPerVector_BytesPerComponent_DataOffset_DataStride_ = "geometrySourceWithData:semantic:vectorCount:floatComponents:componentsPerVector:bytesPerComponent:dataOffset:dataStride:";

	private static readonly IntPtr selGeometrySourceWithData_Semantic_VectorCount_FloatComponents_ComponentsPerVector_BytesPerComponent_DataOffset_DataStride_Handle = Selector.GetHandle("geometrySourceWithData:semantic:vectorCount:floatComponents:componentsPerVector:bytesPerComponent:dataOffset:dataStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometrySourceWithNormals_Count_ = "geometrySourceWithNormals:count:";

	private static readonly IntPtr selGeometrySourceWithNormals_Count_Handle = Selector.GetHandle("geometrySourceWithNormals:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometrySourceWithTextureCoordinates_Count_ = "geometrySourceWithTextureCoordinates:count:";

	private static readonly IntPtr selGeometrySourceWithTextureCoordinates_Count_Handle = Selector.GetHandle("geometrySourceWithTextureCoordinates:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometrySourceWithVertices_Count_ = "geometrySourceWithVertices:count:";

	private static readonly IntPtr selGeometrySourceWithVertices_Count_Handle = Selector.GetHandle("geometrySourceWithVertices:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemantic = "semantic";

	private static readonly IntPtr selSemanticHandle = Selector.GetHandle("semantic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorCount = "vectorCount";

	private static readonly IntPtr selVectorCountHandle = Selector.GetHandle("vectorCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNGeometrySource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BytesPerComponent
	{
		[Export("bytesPerComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBytesPerComponentHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBytesPerComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ComponentsPerVector
	{
		[Export("componentsPerVector")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selComponentsPerVectorHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selComponentsPerVectorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DataOffset
	{
		[Export("dataOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDataOffsetHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDataOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DataStride
	{
		[Export("dataStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDataStrideHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDataStrideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FloatComponents
	{
		[Export("floatComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFloatComponentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFloatComponentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString Semantic
	{
		[Export("semantic")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSemanticHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSemanticHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VectorCount
	{
		[Export("vectorCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selVectorCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selVectorCountHandle);
		}
	}

	public unsafe static SCNGeometrySource FromVertices(SCNVector3[] vertices)
	{
		if (vertices == null)
		{
			throw new ArgumentNullException("vertices");
		}
		fixed (SCNVector3* ptr = &vertices[0])
		{
			return FromVertices((IntPtr)ptr, vertices.Length);
		}
	}

	public unsafe static SCNGeometrySource FromNormals(SCNVector3[] normals)
	{
		if (normals == null)
		{
			throw new ArgumentNullException("normals");
		}
		fixed (SCNVector3* ptr = &normals[0])
		{
			return FromNormals((IntPtr)ptr, normals.Length);
		}
	}

	public unsafe static SCNGeometrySource FromTextureCoordinates(CGPoint[] texcoords)
	{
		if (texcoords == null)
		{
			throw new ArgumentNullException("texcoords");
		}
		fixed (CGPoint* ptr = &texcoords[0])
		{
			return FromTextureCoordinates((IntPtr)ptr, texcoords.Length);
		}
	}

	private static NSString SemanticToToken(SCNGeometrySourceSemantics geometrySourceSemantic)
	{
		return geometrySourceSemantic switch
		{
			SCNGeometrySourceSemantics.Vertex => SCNGeometrySourceSemantic.Vertex, 
			SCNGeometrySourceSemantics.Normal => SCNGeometrySourceSemantic.Normal, 
			SCNGeometrySourceSemantics.Color => SCNGeometrySourceSemantic.Color, 
			SCNGeometrySourceSemantics.Texcoord => SCNGeometrySourceSemantic.Texcoord, 
			SCNGeometrySourceSemantics.VertexCrease => SCNGeometrySourceSemantic.VertexCrease, 
			SCNGeometrySourceSemantics.EdgeCrease => SCNGeometrySourceSemantic.EdgeCrease, 
			SCNGeometrySourceSemantics.BoneWeights => SCNGeometrySourceSemantic.BoneWeights, 
			SCNGeometrySourceSemantics.BoneIndices => SCNGeometrySourceSemantic.BoneIndices, 
			_ => throw new ArgumentException("geometrySourceSemantic"), 
		};
	}

	public static SCNGeometrySource FromData(NSData data, SCNGeometrySourceSemantics semantic, nint vectorCount, bool floatComponents, nint componentsPerVector, nint bytesPerComponent, nint offset, nint stride)
	{
		return FromData(data, SemanticToToken(semantic), vectorCount, floatComponents, componentsPerVector, bytesPerComponent, offset, stride);
	}

	public static SCNGeometrySource FromMetalBuffer(IMTLBuffer mtlBuffer, MTLVertexFormat vertexFormat, SCNGeometrySourceSemantics semantic, nint vertexCount, nint offset, nint stride)
	{
		return FromMetalBuffer(mtlBuffer, vertexFormat, SemanticToToken(semantic), vertexCount, offset, stride);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNGeometrySource()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNGeometrySource(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNGeometrySource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNGeometrySource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("geometrySourceWithData:semantic:vectorCount:floatComponents:componentsPerVector:bytesPerComponent:dataOffset:dataStride:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNGeometrySource FromData(NSData data, NSString geometrySourceSemantic, nint vectorCount, bool floatComponents, nint componentsPerVector, nint bytesPerComponent, nint offset, nint stride)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (geometrySourceSemantic == null)
		{
			throw new ArgumentNullException("geometrySourceSemantic");
		}
		return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_bool_nint_nint_nint_nint(class_ptr, selGeometrySourceWithData_Semantic_VectorCount_FloatComponents_ComponentsPerVector_BytesPerComponent_DataOffset_DataStride_Handle, data.Handle, geometrySourceSemantic.Handle, vectorCount, floatComponents, componentsPerVector, bytesPerComponent, offset, stride));
	}

	[Export("geometrySourceWithBuffer:vertexFormat:semantic:vertexCount:dataOffset:dataStride:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNGeometrySource FromMetalBuffer(IMTLBuffer mtlBuffer, MTLVertexFormat vertexFormat, NSString geometrySourceSemantic, nint vertexCount, nint offset, nint stride)
	{
		if (mtlBuffer == null)
		{
			throw new ArgumentNullException("mtlBuffer");
		}
		if (geometrySourceSemantic == null)
		{
			throw new ArgumentNullException("geometrySourceSemantic");
		}
		return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_nint_nint_nint(class_ptr, selGeometrySourceWithBuffer_VertexFormat_Semantic_VertexCount_DataOffset_DataStride_Handle, mtlBuffer.Handle, (ulong)vertexFormat, geometrySourceSemantic.Handle, vertexCount, offset, stride));
	}

	[Export("geometrySourceWithNormals:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SCNGeometrySource FromNormals(IntPtr normals, nint count)
	{
		return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selGeometrySourceWithNormals_Count_Handle, normals, count));
	}

	[Export("geometrySourceWithTextureCoordinates:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SCNGeometrySource FromTextureCoordinates(IntPtr texcoords, nint count)
	{
		return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selGeometrySourceWithTextureCoordinates_Count_Handle, texcoords, count));
	}

	[Export("geometrySourceWithVertices:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SCNGeometrySource FromVertices(IntPtr vertices, nint count)
	{
		return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selGeometrySourceWithVertices_Count_Handle, vertices, count));
	}
}

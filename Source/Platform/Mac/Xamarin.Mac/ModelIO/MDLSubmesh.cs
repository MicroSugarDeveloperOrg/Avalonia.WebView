using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using SceneKit;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLSubmesh", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLSubmesh : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometryType = "geometryType";

	private static readonly IntPtr selGeometryTypeHandle = Selector.GetHandle("geometryType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexBuffer = "indexBuffer";

	private static readonly IntPtr selIndexBufferHandle = Selector.GetHandle("indexBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexBufferAsIndexType_ = "indexBufferAsIndexType:";

	private static readonly IntPtr selIndexBufferAsIndexType_Handle = Selector.GetHandle("indexBufferAsIndexType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexCount = "indexCount";

	private static readonly IntPtr selIndexCountHandle = Selector.GetHandle("indexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexType = "indexType";

	private static readonly IntPtr selIndexTypeHandle = Selector.GetHandle("indexType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_ = "initWithIndexBuffer:indexCount:indexType:geometryType:material:";

	private static readonly IntPtr selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle = Selector.GetHandle("initWithIndexBuffer:indexCount:indexType:geometryType:material:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMDLSubmesh_IndexType_GeometryType_ = "initWithMDLSubmesh:indexType:geometryType:";

	private static readonly IntPtr selInitWithMDLSubmesh_IndexType_GeometryType_Handle = Selector.GetHandle("initWithMDLSubmesh:indexType:geometryType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_ = "initWithName:indexBuffer:indexCount:indexType:geometryType:material:";

	private static readonly IntPtr selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle = Selector.GetHandle("initWithName:indexBuffer:indexCount:indexType:geometryType:material:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_ = "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:";

	private static readonly IntPtr selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_Handle = Selector.GetHandle("initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterial = "material";

	private static readonly IntPtr selMaterialHandle = Selector.GetHandle("material");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaterial_ = "setMaterial:";

	private static readonly IntPtr selSetMaterial_Handle = Selector.GetHandle("setMaterial:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTopology_ = "setTopology:";

	private static readonly IntPtr selSetTopology_Handle = Selector.GetHandle("setTopology:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubmeshWithSCNGeometryElement_ = "submeshWithSCNGeometryElement:";

	private static readonly IntPtr selSubmeshWithSCNGeometryElement_Handle = Selector.GetHandle("submeshWithSCNGeometryElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubmeshWithSCNGeometryElement_BufferAllocator_ = "submeshWithSCNGeometryElement:bufferAllocator:";

	private static readonly IntPtr selSubmeshWithSCNGeometryElement_BufferAllocator_Handle = Selector.GetHandle("submeshWithSCNGeometryElement:bufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopology = "topology";

	private static readonly IntPtr selTopologyHandle = Selector.GetHandle("topology");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLSubmesh");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLGeometryType GeometryType
	{
		[Export("geometryType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLGeometryType)Messaging.Int64_objc_msgSend(base.Handle, selGeometryTypeHandle);
			}
			return (MDLGeometryType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selGeometryTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer IndexBuffer
	{
		[Export("indexBuffer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexBufferHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexCount
	{
		[Export("indexCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selIndexCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selIndexCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLIndexBitDepth IndexType
	{
		[Export("indexType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLIndexBitDepth)Messaging.UInt64_objc_msgSend(base.Handle, selIndexTypeHandle);
			}
			return (MDLIndexBitDepth)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selIndexTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterial? Material
	{
		[Export("material", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterial>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaterialHandle));
			}
			return Runtime.GetNSObject<MDLMaterial>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaterialHandle));
		}
		[Export("setMaterial:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaterial_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaterial_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLSubmeshTopology? Topology
	{
		[Export("topology", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLSubmeshTopology>(Messaging.IntPtr_objc_msgSend(base.Handle, selTopologyHandle));
			}
			return Runtime.GetNSObject<MDLSubmeshTopology>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTopologyHandle));
		}
		[Export("setTopology:", ArgumentSemantic.Retain)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTopology_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTopology_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLSubmesh()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLSubmesh(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLSubmesh(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:indexBuffer:indexCount:indexType:geometryType:material:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSubmesh(string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr(base.Handle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle, arg, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr(base.SuperHandle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle, arg, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithIndexBuffer:indexCount:indexType:geometryType:material:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSubmesh(IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material)
		: base(NSObjectFlag.Empty)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64_Int64_IntPtr(base.Handle, selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero), "initWithIndexBuffer:indexCount:indexType:geometryType:material:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt64_Int64_IntPtr(base.SuperHandle, selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_Handle, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero), "initWithIndexBuffer:indexCount:indexType:geometryType:material:");
		}
	}

	[Export("initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSubmesh(string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material, MDLSubmeshTopology? topology)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr_IntPtr(base.Handle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_Handle, arg, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero, topology?.Handle ?? IntPtr.Zero), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr_IntPtr(base.SuperHandle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_Handle, arg, indexBuffer.Handle, indexCount, (ulong)indexType, (long)geometryType, material?.Handle ?? IntPtr.Zero, topology?.Handle ?? IntPtr.Zero), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithMDLSubmesh:indexType:geometryType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSubmesh(MDLSubmesh indexBuffer, MDLIndexBitDepth indexType, MDLGeometryType geometryType)
		: base(NSObjectFlag.Empty)
	{
		if (indexBuffer == null)
		{
			throw new ArgumentNullException("indexBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_Int64(base.Handle, selInitWithMDLSubmesh_IndexType_GeometryType_Handle, indexBuffer.Handle, (ulong)indexType, (long)geometryType), "initWithMDLSubmesh:indexType:geometryType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_Int64(base.SuperHandle, selInitWithMDLSubmesh_IndexType_GeometryType_Handle, indexBuffer.Handle, (ulong)indexType, (long)geometryType), "initWithMDLSubmesh:indexType:geometryType:");
		}
	}

	[Export("submeshWithSCNGeometryElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLSubmesh FromGeometryElement(SCNGeometryElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		return Runtime.GetNSObject<MDLSubmesh>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSubmeshWithSCNGeometryElement_Handle, element.Handle));
	}

	[Export("submeshWithSCNGeometryElement:bufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLSubmesh FromGeometryElement(SCNGeometryElement element, IMDLMeshBufferAllocator? bufferAllocator)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		return Runtime.GetNSObject<MDLSubmesh>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSubmeshWithSCNGeometryElement_BufferAllocator_Handle, element.Handle, bufferAllocator?.Handle ?? IntPtr.Zero));
	}

	[Export("indexBufferAsIndexType:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer GetIndexBuffer(MDLIndexBitDepth indexType)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selIndexBufferAsIndexType_Handle, (ulong)indexType), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selIndexBufferAsIndexType_Handle, (ulong)indexType), owns: false);
	}
}

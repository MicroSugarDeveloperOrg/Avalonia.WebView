using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ModelIO;
using ObjCRuntime;

namespace MetalKit;

[Register("MTKMesh", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTKMesh : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMesh_Device_Error_ = "initWithMesh:device:error:";

	private static readonly IntPtr selInitWithMesh_Device_Error_Handle = Selector.GetHandle("initWithMesh:device:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewMeshesFromAsset_Device_SourceMeshes_Error_ = "newMeshesFromAsset:device:sourceMeshes:error:";

	private static readonly IntPtr selNewMeshesFromAsset_Device_SourceMeshes_Error_Handle = Selector.GetHandle("newMeshesFromAsset:device:sourceMeshes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubmeshes = "submeshes";

	private static readonly IntPtr selSubmeshesHandle = Selector.GetHandle("submeshes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexBuffers = "vertexBuffers";

	private static readonly IntPtr selVertexBuffersHandle = Selector.GetHandle("vertexBuffers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCount = "vertexCount";

	private static readonly IntPtr selVertexCountHandle = Selector.GetHandle("vertexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexDescriptor = "vertexDescriptor";

	private static readonly IntPtr selVertexDescriptorHandle = Selector.GetHandle("vertexDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTKMesh");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	public virtual MTKSubmesh[] Submeshes
	{
		[Export("submeshes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MTKSubmesh>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubmeshesHandle));
			}
			return NSArray.ArrayFromHandle<MTKSubmesh>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubmeshesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTKMeshBuffer[] VertexBuffers
	{
		[Export("vertexBuffers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MTKMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexBuffersHandle));
			}
			return NSArray.ArrayFromHandle<MTKMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexBuffersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VertexCount
	{
		[Export("vertexCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVertexCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVertexCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexDescriptor VertexDescriptor
	{
		[Export("vertexDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexDescriptorHandle));
			}
			return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexDescriptorHandle));
		}
	}

	public static MTKMesh[] FromAsset(MDLAsset asset, IMTLDevice device, out MDLMesh[] sourceMeshes, out NSError error)
	{
		NSArray sourceMeshes2;
		MTKMesh[] result = FromAsset(asset, device, out sourceMeshes2, out error);
		sourceMeshes = NSArray.FromArray<MDLMesh>(sourceMeshes2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTKMesh(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTKMesh(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMesh:device:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTKMesh(MDLMesh mesh, IMTLDevice device, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithMesh_Device_Error_Handle, mesh.Handle, device.Handle, ref arg), "initWithMesh:device:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithMesh_Device_Error_Handle, mesh.Handle, device.Handle, ref arg), "initWithMesh:device:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("newMeshesFromAsset:device:sourceMeshes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MTKMesh[]? FromAsset(MDLAsset asset, IMTLDevice device, out NSArray sourceMeshes, out NSError error)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		MTKMesh[] result = NSArray.ArrayFromHandle<MTKMesh>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(class_ptr, selNewMeshesFromAsset_Device_SourceMeshes_Error_Handle, asset.Handle, device.Handle, ref arg, ref arg2));
		sourceMeshes = Runtime.GetNSObject<NSArray>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}
}

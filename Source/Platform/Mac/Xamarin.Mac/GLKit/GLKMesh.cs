using System;
using System.ComponentModel;
using Foundation;
using ModelIO;
using ObjCRuntime;

namespace GLKit;

[Register("GLKMesh", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GLKMesh : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMesh_Error_ = "initWithMesh:error:";

	private static readonly IntPtr selInitWithMesh_Error_Handle = Selector.GetHandle("initWithMesh:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewMeshesFromAsset_SourceMeshes_Error_ = "newMeshesFromAsset:sourceMeshes:error:";

	private static readonly IntPtr selNewMeshesFromAsset_SourceMeshes_Error_Handle = Selector.GetHandle("newMeshesFromAsset:sourceMeshes:error:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKMesh");

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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKSubmesh[] Submeshes
	{
		[Export("submeshes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GLKSubmesh>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubmeshesHandle));
			}
			return NSArray.ArrayFromHandle<GLKSubmesh>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubmeshesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKMeshBuffer[] VertexBuffers
	{
		[Export("vertexBuffers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GLKMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexBuffersHandle));
			}
			return NSArray.ArrayFromHandle<GLKMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexBuffersHandle));
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

	public static GLKMesh[] FromAsset(MDLAsset asset, out MDLMesh[] sourceMeshes, out NSError error)
	{
		NSArray sourceMeshes2;
		GLKMesh[] result = FromAsset(asset, out sourceMeshes2, out error);
		sourceMeshes = NSArray.FromArray<MDLMesh>(sourceMeshes2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GLKMesh(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKMesh(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMesh:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GLKMesh(MDLMesh mesh, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithMesh_Error_Handle, mesh.Handle, ref arg), "initWithMesh:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithMesh_Error_Handle, mesh.Handle, ref arg), "initWithMesh:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("newMeshesFromAsset:sourceMeshes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static GLKMesh[]? FromAsset(MDLAsset asset, out NSArray sourceMeshes, out NSError error)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		GLKMesh[] result = NSArray.ArrayFromHandle<GLKMesh>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr(class_ptr, selNewMeshesFromAsset_SourceMeshes_Error_Handle, asset.Handle, ref arg, ref arg2));
		sourceMeshes = Runtime.GetNSObject<NSArray>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}
}

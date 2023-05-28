using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalKit;

[Register("MTKSubmesh", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTKSubmesh : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexBuffer = "indexBuffer";

	private static readonly IntPtr selIndexBufferHandle = Selector.GetHandle("indexBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexCount = "indexCount";

	private static readonly IntPtr selIndexCountHandle = Selector.GetHandle("indexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexType = "indexType";

	private static readonly IntPtr selIndexTypeHandle = Selector.GetHandle("indexType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMesh = "mesh";

	private static readonly IntPtr selMeshHandle = Selector.GetHandle("mesh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimitiveType = "primitiveType";

	private static readonly IntPtr selPrimitiveTypeHandle = Selector.GetHandle("primitiveType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTKSubmesh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Mesh_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTKMeshBuffer IndexBuffer
	{
		[Export("indexBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTKMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexBufferHandle));
			}
			return Runtime.GetNSObject<MTKMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexBufferHandle));
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
	public virtual MTLIndexType IndexType
	{
		[Export("indexType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLIndexType)Messaging.UInt64_objc_msgSend(base.Handle, selIndexTypeHandle);
			}
			return (MTLIndexType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selIndexTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTKMesh? Mesh
	{
		[Export("mesh", ArgumentSemantic.Weak)]
		get
		{
			MTKMesh mTKMesh = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MTKMesh>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMeshHandle)) : Runtime.GetNSObject<MTKMesh>(Messaging.IntPtr_objc_msgSend(base.Handle, selMeshHandle)));
			MarkDirty();
			__mt_Mesh_var = mTKMesh;
			return mTKMesh;
		}
	}

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
	public virtual MTLPrimitiveType PrimitiveType
	{
		[Export("primitiveType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPrimitiveType)Messaging.UInt64_objc_msgSend(base.Handle, selPrimitiveTypeHandle);
			}
			return (MTLPrimitiveType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPrimitiveTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTKSubmesh(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTKSubmesh(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Mesh_var = null;
		}
	}
}

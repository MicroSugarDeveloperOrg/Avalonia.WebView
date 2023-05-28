using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ModelIO;
using ObjCRuntime;

namespace Metal;

[Register("MTLVertexDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLVertexDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayouts = "layouts";

	private static readonly IntPtr selLayoutsHandle = Selector.GetHandle("layouts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexDescriptor = "vertexDescriptor";

	private static readonly IntPtr selVertexDescriptorHandle = Selector.GetHandle("vertexDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLVertexDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLVertexAttributeDescriptorArray Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLVertexAttributeDescriptorArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<MTLVertexAttributeDescriptorArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLVertexBufferLayoutDescriptorArray Layouts
	{
		[Export("layouts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLVertexBufferLayoutDescriptorArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutsHandle));
			}
			return Runtime.GetNSObject<MTLVertexBufferLayoutDescriptorArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutsHandle));
		}
	}

	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	[iOS(9, 0)]
	private static extern IntPtr MTKMetalVertexDescriptorFromModelIO(IntPtr modelIODescriptor);

	[iOS(9, 0)]
	public static MTLVertexDescriptor FromModelIO(MDLVertexDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentException("descriptor");
		}
		return Runtime.GetNSObject<MTLVertexDescriptor>(MTKMetalVertexDescriptorFromModelIO(descriptor.Handle));
	}

	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	private static extern IntPtr MTKMetalVertexDescriptorFromModelIOWithError(IntPtr modelIODescriptor, out IntPtr error);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	public static MTLVertexDescriptor FromModelIO(MDLVertexDescriptor descriptor, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentException("descriptor");
		}
		IntPtr error2;
		MTLVertexDescriptor nSObject = Runtime.GetNSObject<MTLVertexDescriptor>(MTKMetalVertexDescriptorFromModelIOWithError(descriptor.Handle, out error2));
		error = Runtime.GetNSObject<NSError>(error2);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLVertexDescriptor()
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
	protected MTLVertexDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLVertexDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("vertexDescriptor")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLVertexDescriptor Create()
	{
		return Runtime.GetNSObject<MTLVertexDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selVertexDescriptorHandle));
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}
}

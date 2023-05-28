using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRenderPassColorAttachmentDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPassColorAttachmentDescriptor : MTLRenderPassAttachmentDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearColor = "clearColor";

	private static readonly IntPtr selClearColorHandle = Selector.GetHandle("clearColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearColor_ = "setClearColor:";

	private static readonly IntPtr selSetClearColor_Handle = Selector.GetHandle("setClearColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPassColorAttachmentDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLClearColor ClearColor
	{
		[Export("clearColor")]
		get
		{
			MTLClearColor retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLClearColor_objc_msgSend_stret(out retval, base.Handle, selClearColorHandle);
			}
			else
			{
				Messaging.MTLClearColor_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClearColorHandle);
			}
			return retval;
		}
		[Export("setClearColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLClearColor(base.Handle, selSetClearColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLClearColor(base.SuperHandle, selSetClearColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPassColorAttachmentDescriptor()
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
	protected MTLRenderPassColorAttachmentDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPassColorAttachmentDescriptor(IntPtr handle)
		: base(handle)
	{
	}
}

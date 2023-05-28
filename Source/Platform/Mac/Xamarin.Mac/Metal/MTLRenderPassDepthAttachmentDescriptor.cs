using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRenderPassDepthAttachmentDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPassDepthAttachmentDescriptor : MTLRenderPassAttachmentDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearDepth = "clearDepth";

	private static readonly IntPtr selClearDepthHandle = Selector.GetHandle("clearDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthResolveFilter = "depthResolveFilter";

	private static readonly IntPtr selDepthResolveFilterHandle = Selector.GetHandle("depthResolveFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearDepth_ = "setClearDepth:";

	private static readonly IntPtr selSetClearDepth_Handle = Selector.GetHandle("setClearDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthResolveFilter_ = "setDepthResolveFilter:";

	private static readonly IntPtr selSetDepthResolveFilter_Handle = Selector.GetHandle("setDepthResolveFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPassDepthAttachmentDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ClearDepth
	{
		[Export("clearDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selClearDepthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selClearDepthHandle);
		}
		[Export("setClearDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetClearDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetClearDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual MTLMultisampleDepthResolveFilter DepthResolveFilter
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("depthResolveFilter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLMultisampleDepthResolveFilter)Messaging.UInt64_objc_msgSend(base.Handle, selDepthResolveFilterHandle);
			}
			return (MTLMultisampleDepthResolveFilter)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthResolveFilterHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setDepthResolveFilter:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDepthResolveFilter_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDepthResolveFilter_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPassDepthAttachmentDescriptor()
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
	protected MTLRenderPassDepthAttachmentDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPassDepthAttachmentDescriptor(IntPtr handle)
		: base(handle)
	{
	}
}

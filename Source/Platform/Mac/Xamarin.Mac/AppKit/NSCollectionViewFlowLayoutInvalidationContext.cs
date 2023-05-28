using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewFlowLayoutInvalidationContext", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewFlowLayoutInvalidationContext : NSCollectionViewLayoutInvalidationContext
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateFlowLayoutAttributes = "invalidateFlowLayoutAttributes";

	private static readonly IntPtr selInvalidateFlowLayoutAttributesHandle = Selector.GetHandle("invalidateFlowLayoutAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateFlowLayoutDelegateMetrics = "invalidateFlowLayoutDelegateMetrics";

	private static readonly IntPtr selInvalidateFlowLayoutDelegateMetricsHandle = Selector.GetHandle("invalidateFlowLayoutDelegateMetrics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInvalidateFlowLayoutAttributes_ = "setInvalidateFlowLayoutAttributes:";

	private static readonly IntPtr selSetInvalidateFlowLayoutAttributes_Handle = Selector.GetHandle("setInvalidateFlowLayoutAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInvalidateFlowLayoutDelegateMetrics_ = "setInvalidateFlowLayoutDelegateMetrics:";

	private static readonly IntPtr selSetInvalidateFlowLayoutDelegateMetrics_Handle = Selector.GetHandle("setInvalidateFlowLayoutDelegateMetrics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewFlowLayoutInvalidationContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InvalidateFlowLayoutAttributes
	{
		[Export("invalidateFlowLayoutAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInvalidateFlowLayoutAttributesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInvalidateFlowLayoutAttributesHandle);
		}
		[Export("setInvalidateFlowLayoutAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInvalidateFlowLayoutAttributes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInvalidateFlowLayoutAttributes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InvalidateFlowLayoutDelegateMetrics
	{
		[Export("invalidateFlowLayoutDelegateMetrics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInvalidateFlowLayoutDelegateMetricsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInvalidateFlowLayoutDelegateMetricsHandle);
		}
		[Export("setInvalidateFlowLayoutDelegateMetrics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInvalidateFlowLayoutDelegateMetrics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInvalidateFlowLayoutDelegateMetrics_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewFlowLayoutInvalidationContext()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSCollectionViewFlowLayoutInvalidationContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewFlowLayoutInvalidationContext(IntPtr handle)
		: base(handle)
	{
	}
}

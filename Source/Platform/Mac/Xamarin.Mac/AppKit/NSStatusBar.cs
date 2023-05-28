using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStatusBar", true)]
public class NSStatusBar : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVertical = "isVertical";

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveStatusItem_ = "removeStatusItem:";

	private static readonly IntPtr selRemoveStatusItem_Handle = Selector.GetHandle("removeStatusItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusItemWithLength_ = "statusItemWithLength:";

	private static readonly IntPtr selStatusItemWithLength_Handle = Selector.GetHandle("statusItemWithLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemStatusBar = "systemStatusBar";

	private static readonly IntPtr selSystemStatusBarHandle = Selector.GetHandle("systemStatusBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThickness = "thickness";

	private static readonly IntPtr selThicknessHandle = Selector.GetHandle("thickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStatusBar");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSStatusBar SystemStatusBar
	{
		[Export("systemStatusBar")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSStatusBar>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemStatusBarHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Thickness
	{
		[Export("thickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selThicknessHandle);
		}
	}

	public NSStatusItem CreateStatusItem(NSStatusItemLength length)
	{
		return CreateStatusItem((float)length);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStatusBar()
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
	protected NSStatusBar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStatusBar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("statusItemWithLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSStatusItem CreateStatusItem(nfloat length)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSStatusItem>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selStatusItemWithLength_Handle, length));
		}
		return Runtime.GetNSObject<NSStatusItem>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selStatusItemWithLength_Handle, length));
	}

	[Export("removeStatusItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveStatusItem(NSStatusItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveStatusItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveStatusItem_Handle, item.Handle);
		}
	}
}

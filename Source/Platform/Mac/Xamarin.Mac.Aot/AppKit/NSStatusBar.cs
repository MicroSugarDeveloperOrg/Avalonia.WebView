using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStatusBar", true)]
public class NSStatusBar : NSObject
{
	private static readonly IntPtr selSystemStatusBarHandle = Selector.GetHandle("systemStatusBar");

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	private static readonly IntPtr selThicknessHandle = Selector.GetHandle("thickness");

	private static readonly IntPtr selStatusItemWithLength_Handle = Selector.GetHandle("statusItemWithLength:");

	private static readonly IntPtr selRemoveStatusItem_Handle = Selector.GetHandle("removeStatusItem:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSStatusBar");

	private static object __mt_SystemStatusBar_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSStatusBar SystemStatusBar
	{
		[Export("systemStatusBar")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSStatusBar)(__mt_SystemStatusBar_var_static = (NSStatusBar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemStatusBarHandle)));
		}
	}

	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
	}

	public virtual double Thickness
	{
		[Export("thickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selThicknessHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStatusBar()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSStatusBar(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSStatusBar(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSStatusBar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("statusItemWithLength:")]
	public virtual NSStatusItem CreateStatusItem(double length)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSStatusItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selStatusItemWithLength_Handle, length));
		}
		return (NSStatusItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selStatusItemWithLength_Handle, length));
	}

	[Export("removeStatusItem:")]
	public virtual void RemoveStatusItem(NSStatusItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveStatusItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveStatusItem_Handle, item.Handle);
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPanel", true)]
public class NSPanel : NSWindow
{
	private static readonly IntPtr selIsFloatingPanelHandle = Selector.GetHandle("isFloatingPanel");

	private static readonly IntPtr selSetFloatingPanel_Handle = Selector.GetHandle("setFloatingPanel:");

	private static readonly IntPtr selBecomesKeyOnlyIfNeededHandle = Selector.GetHandle("becomesKeyOnlyIfNeeded");

	private static readonly IntPtr selSetBecomesKeyOnlyIfNeeded_Handle = Selector.GetHandle("setBecomesKeyOnlyIfNeeded:");

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	private static readonly IntPtr selSetWorksWhenModal_Handle = Selector.GetHandle("setWorksWhenModal:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPanel");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool FloatingPanel
	{
		[Export("isFloatingPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFloatingPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFloatingPanelHandle);
		}
		[Export("setFloatingPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloatingPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloatingPanel_Handle, value);
			}
		}
	}

	public virtual bool BecomesKeyOnlyIfNeeded
	{
		[Export("becomesKeyOnlyIfNeeded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBecomesKeyOnlyIfNeededHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBecomesKeyOnlyIfNeededHandle);
		}
		[Export("setBecomesKeyOnlyIfNeeded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBecomesKeyOnlyIfNeeded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBecomesKeyOnlyIfNeeded_Handle, value);
			}
		}
	}

	public new virtual bool WorksWhenModal
	{
		[Export("worksWhenModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWorksWhenModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWorksWhenModalHandle);
		}
		[Export("setWorksWhenModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWorksWhenModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWorksWhenModal_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPanel()
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
	public NSPanel(NSCoder coder)
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
	public NSPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPanel(IntPtr handle)
		: base(handle)
	{
	}
}

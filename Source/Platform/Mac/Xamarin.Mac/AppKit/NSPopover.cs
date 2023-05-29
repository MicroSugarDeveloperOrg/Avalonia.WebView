using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPopover", true)]
public class NSPopover : NSResponder
{
	public static class Notifications
	{
		public static NSObject ObserveWillShow(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillShowNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidShow(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidShowNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillClose(EventHandler<NSPopoverCloseEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseNotification, delegate(NSNotification notification)
			{
				handler(null, new NSPopoverCloseEventArgs(notification));
			});
		}

		public static NSObject ObserveDidClose(EventHandler<NSPopoverCloseEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidCloseNotification, delegate(NSNotification notification)
			{
				handler(null, new NSPopoverCloseEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	private static readonly IntPtr selSetAppearance_Handle = Selector.GetHandle("setAppearance:");

	private static readonly IntPtr selBehaviorHandle = Selector.GetHandle("behavior");

	private static readonly IntPtr selSetBehavior_Handle = Selector.GetHandle("setBehavior:");

	private static readonly IntPtr selAnimatesHandle = Selector.GetHandle("animates");

	private static readonly IntPtr selSetAnimates_Handle = Selector.GetHandle("setAnimates:");

	private static readonly IntPtr selContentViewControllerHandle = Selector.GetHandle("contentViewController");

	private static readonly IntPtr selSetContentViewController_Handle = Selector.GetHandle("setContentViewController:");

	private static readonly IntPtr selContentSizeHandle = Selector.GetHandle("contentSize");

	private static readonly IntPtr selSetContentSize_Handle = Selector.GetHandle("setContentSize:");

	private static readonly IntPtr selIsShownHandle = Selector.GetHandle("isShown");

	private static readonly IntPtr selPositioningRectHandle = Selector.GetHandle("positioningRect");

	private static readonly IntPtr selSetPositioningRect_Handle = Selector.GetHandle("setPositioningRect:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selShowRelativeToRectOfViewPreferredEdge_Handle = Selector.GetHandle("showRelativeToRect:ofView:preferredEdge:");

	private static readonly IntPtr selPerformClose_Handle = Selector.GetHandle("performClose:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPopover");

	private object __mt_ContentViewController_var;

	private object __mt_WeakDelegate_var;

	private static NSString _CloseReasonKey;

	private static NSString _CloseReasonStandard;

	private static NSString _CloseReasonDetachToWindow;

	private static NSString _WillShowNotification;

	private static NSString _DidShowNotification;

	private static NSString _WillCloseNotification;

	private static NSString _DidCloseNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPopoverAppearance Appearance
	{
		[Export("appearance")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPopoverAppearance)Messaging.Int64_objc_msgSend(base.Handle, selAppearanceHandle);
			}
			return (NSPopoverAppearance)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle);
		}
		[Export("setAppearance:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAppearance_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAppearance_Handle, (long)value);
			}
		}
	}

	public virtual NSPopoverBehavior Behavior
	{
		[Export("behavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPopoverBehavior)Messaging.Int64_objc_msgSend(base.Handle, selBehaviorHandle);
			}
			return (NSPopoverBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBehaviorHandle);
		}
		[Export("setBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBehavior_Handle, (long)value);
			}
		}
	}

	public virtual bool Animates
	{
		[Export("animates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesHandle);
		}
		[Export("setAnimates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimates_Handle, value);
			}
		}
	}

	public virtual NSViewController ContentViewController
	{
		[Export("contentViewController")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSViewController)(__mt_ContentViewController_var = ((!IsDirectBinding) ? ((NSViewController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewControllerHandle))) : ((NSViewController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewControllerHandle)))));
		}
		[Export("setContentViewController:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentViewController_Handle, value.Handle);
			}
			__mt_ContentViewController_var = value;
		}
	}

	public virtual CGSize ContentSize
	{
		[Export("contentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentSizeHandle);
		}
		[Export("setContentSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentSize_Handle, value);
			}
		}
	}

	public virtual bool Shown
	{
		[Export("isShown")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsShownHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsShownHandle);
		}
	}

	public virtual CGRect PositioningRect
	{
		[Export("positioningRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selPositioningRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPositioningRectHandle);
			}
			return retval;
		}
		[Export("setPositioningRect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetPositioningRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetPositioningRect_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSPopoverDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSPopoverDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	[Field("NSPopoverCloseReasonKey", "AppKit")]
	public static NSString CloseReasonKey
	{
		get
		{
			if (_CloseReasonKey == null)
			{
				_CloseReasonKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverCloseReasonKey");
			}
			return _CloseReasonKey;
		}
	}

	[Field("NSPopoverCloseReasonStandard", "AppKit")]
	public static NSString CloseReasonStandard
	{
		get
		{
			if (_CloseReasonStandard == null)
			{
				_CloseReasonStandard = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverCloseReasonStandard");
			}
			return _CloseReasonStandard;
		}
	}

	[Field("NSPopoverCloseReasonDetachToWindow", "AppKit")]
	public static NSString CloseReasonDetachToWindow
	{
		get
		{
			if (_CloseReasonDetachToWindow == null)
			{
				_CloseReasonDetachToWindow = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverCloseReasonDetachToWindow");
			}
			return _CloseReasonDetachToWindow;
		}
	}

	[Field("NSPopoverWillShowNotification", "AppKit")]
	public static NSString WillShowNotification
	{
		get
		{
			if (_WillShowNotification == null)
			{
				_WillShowNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverWillShowNotification");
			}
			return _WillShowNotification;
		}
	}

	[Field("NSPopoverDidShowNotification", "AppKit")]
	public static NSString DidShowNotification
	{
		get
		{
			if (_DidShowNotification == null)
			{
				_DidShowNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverDidShowNotification");
			}
			return _DidShowNotification;
		}
	}

	[Field("NSPopoverWillCloseNotification", "AppKit")]
	public static NSString WillCloseNotification
	{
		get
		{
			if (_WillCloseNotification == null)
			{
				_WillCloseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverWillCloseNotification");
			}
			return _WillCloseNotification;
		}
	}

	[Field("NSPopoverDidCloseNotification", "AppKit")]
	public static NSString DidCloseNotification
	{
		get
		{
			if (_DidCloseNotification == null)
			{
				_DidCloseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopoverDidCloseNotification");
			}
			return _DidCloseNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopover()
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
	public NSPopover(NSCoder coder)
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
	public NSPopover(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPopover(IntPtr handle)
		: base(handle)
	{
	}

	[Export("showRelativeToRect:ofView:preferredEdge:")]
	public virtual void Show(CGRect relativePositioningRect, NSView positioningView, NSRectEdge preferredEdge)
	{
		NSApplication.EnsureUIThread();
		if (positioningView == null)
		{
			throw new ArgumentNullException("positioningView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_int(base.Handle, selShowRelativeToRectOfViewPreferredEdge_Handle, relativePositioningRect, positioningView.Handle, (int)preferredEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_int(base.SuperHandle, selShowRelativeToRectOfViewPreferredEdge_Handle, relativePositioningRect, positioningView.Handle, (int)preferredEdge);
		}
	}

	[Export("performClose:")]
	public virtual void PerformClose(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClose_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClose_Handle, sender.Handle);
		}
	}

	[Export("close")]
	public virtual void Close()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ContentViewController_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

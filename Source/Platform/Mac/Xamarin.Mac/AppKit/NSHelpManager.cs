using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSHelpManager", true)]
public class NSHelpManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveContextHelpModeDidActivate(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContextHelpModeDidActivateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveContextHelpModeDidActivate(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContextHelpModeDidActivateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveContextHelpModeDidDeactivate(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContextHelpModeDidDeactivateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveContextHelpModeDidDeactivate(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContextHelpModeDidDeactivateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextHelpForObject_ = "contextHelpForObject:";

	private static readonly IntPtr selContextHelpForObject_Handle = Selector.GetHandle("contextHelpForObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindString_InBook_ = "findString:inBook:";

	private static readonly IntPtr selFindString_InBook_Handle = Selector.GetHandle("findString:inBook:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContextHelpModeActive = "isContextHelpModeActive";

	private static readonly IntPtr selIsContextHelpModeActiveHandle = Selector.GetHandle("isContextHelpModeActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenHelpAnchor_InBook_ = "openHelpAnchor:inBook:";

	private static readonly IntPtr selOpenHelpAnchor_InBook_Handle = Selector.GetHandle("openHelpAnchor:inBook:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterBooksInBundle_ = "registerBooksInBundle:";

	private static readonly IntPtr selRegisterBooksInBundle_Handle = Selector.GetHandle("registerBooksInBundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveContextHelpForObject_ = "removeContextHelpForObject:";

	private static readonly IntPtr selRemoveContextHelpForObject_Handle = Selector.GetHandle("removeContextHelpForObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContextHelp_ForObject_ = "setContextHelp:forObject:";

	private static readonly IntPtr selSetContextHelp_ForObject_Handle = Selector.GetHandle("setContextHelp:forObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContextHelpModeActive_ = "setContextHelpModeActive:";

	private static readonly IntPtr selSetContextHelpModeActive_Handle = Selector.GetHandle("setContextHelpModeActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedHelpManager = "sharedHelpManager";

	private static readonly IntPtr selSharedHelpManagerHandle = Selector.GetHandle("sharedHelpManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowContextHelpForObject_LocationHint_ = "showContextHelpForObject:locationHint:";

	private static readonly IntPtr selShowContextHelpForObject_LocationHint_Handle = Selector.GetHandle("showContextHelpForObject:locationHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSHelpManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContextHelpModeDidActivateNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContextHelpModeDidDeactivateNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ContextHelpModeActive
	{
		[Export("isContextHelpModeActive")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsContextHelpModeActiveHandle);
		}
		[Export("setContextHelpModeActive:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetContextHelpModeActive_Handle, value);
		}
	}

	[Field("NSContextHelpModeDidActivateNotification", "AppKit")]
	[Advice("Use NSHelpManager.Notifications.ObserveContextHelpModeDidActivate helper method instead.")]
	public static NSString ContextHelpModeDidActivateNotification
	{
		get
		{
			if (_ContextHelpModeDidActivateNotification == null)
			{
				_ContextHelpModeDidActivateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSContextHelpModeDidActivateNotification");
			}
			return _ContextHelpModeDidActivateNotification;
		}
	}

	[Field("NSContextHelpModeDidDeactivateNotification", "AppKit")]
	[Advice("Use NSHelpManager.Notifications.ObserveContextHelpModeDidDeactivate helper method instead.")]
	public static NSString ContextHelpModeDidDeactivateNotification
	{
		get
		{
			if (_ContextHelpModeDidDeactivateNotification == null)
			{
				_ContextHelpModeDidDeactivateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSContextHelpModeDidDeactivateNotification");
			}
			return _ContextHelpModeDidDeactivateNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSHelpManager()
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
	protected NSHelpManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSHelpManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("contextHelpForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString Context(NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContextHelpForObject_Handle, theObject.Handle));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContextHelpForObject_Handle, theObject.Handle));
	}

	[Export("findString:inBook:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindString(string query, string book)
	{
		NSApplication.EnsureUIThread();
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (book == null)
		{
			throw new ArgumentNullException("book");
		}
		IntPtr arg = NSString.CreateNative(query);
		IntPtr arg2 = NSString.CreateNative(book);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindString_InBook_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindString_InBook_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("openHelpAnchor:inBook:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenHelpAnchor(string anchor, string book)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (book == null)
		{
			throw new ArgumentNullException("book");
		}
		IntPtr arg = NSString.CreateNative(anchor);
		IntPtr arg2 = NSString.CreateNative(book);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selOpenHelpAnchor_InBook_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selOpenHelpAnchor_InBook_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("registerBooksInBundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RegisterBooks(NSBundle bundle)
	{
		NSApplication.EnsureUIThread();
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRegisterBooksInBundle_Handle, bundle.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterBooksInBundle_Handle, bundle.Handle);
	}

	[Export("removeContextHelpForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveContext(NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveContextHelpForObject_Handle, theObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveContextHelpForObject_Handle, theObject.Handle);
		}
	}

	[Export("setContextHelp:forObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContext(NSAttributedString attrString, NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetContextHelp_ForObject_Handle, attrString.Handle, theObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetContextHelp_ForObject_Handle, attrString.Handle, theObject.Handle);
		}
	}

	[Export("sharedHelpManager")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSHelpManager SharedHelpManager()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSHelpManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedHelpManagerHandle));
	}

	[Export("showContextHelpForObject:locationHint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowContext(NSObject theObject, CGPoint pt)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint(base.Handle, selShowContextHelpForObject_LocationHint_Handle, theObject.Handle, pt);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selShowContextHelpForObject_LocationHint_Handle, theObject.Handle, pt);
	}
}

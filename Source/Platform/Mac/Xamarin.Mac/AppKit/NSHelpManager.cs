using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSHelpManager", true)]
public class NSHelpManager : NSObject
{
	private static readonly IntPtr selIsContextHelpModeActiveHandle = Selector.GetHandle("isContextHelpModeActive");

	private static readonly IntPtr selSetContextHelpModeActive_Handle = Selector.GetHandle("setContextHelpModeActive:");

	private static readonly IntPtr selSharedHelpManagerHandle = Selector.GetHandle("sharedHelpManager");

	private static readonly IntPtr selSetContextHelpForObject_Handle = Selector.GetHandle("setContextHelp:forObject:");

	private static readonly IntPtr selRemoveContextHelpForObject_Handle = Selector.GetHandle("removeContextHelpForObject:");

	private static readonly IntPtr selContextHelpForObject_Handle = Selector.GetHandle("contextHelpForObject:");

	private static readonly IntPtr selShowContextHelpForObjectLocationHint_Handle = Selector.GetHandle("showContextHelpForObject:locationHint:");

	private static readonly IntPtr selOpenHelpAnchorInBook_Handle = Selector.GetHandle("openHelpAnchor:inBook:");

	private static readonly IntPtr selFindStringInBook_Handle = Selector.GetHandle("findString:inBook:");

	private static readonly IntPtr selRegisterBooksInBundle_Handle = Selector.GetHandle("registerBooksInBundle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSHelpManager");

	public override IntPtr ClassHandle => class_ptr;

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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSHelpManager()
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
	public NSHelpManager(NSCoder coder)
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
	public NSHelpManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHelpManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sharedHelpManager")]
	public static NSHelpManager SharedHelpManager()
	{
		NSApplication.EnsureUIThread();
		return (NSHelpManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedHelpManagerHandle));
	}

	[Export("setContextHelp:forObject:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetContextHelpForObject_Handle, attrString.Handle, theObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetContextHelpForObject_Handle, attrString.Handle, theObject.Handle);
		}
	}

	[Export("removeContextHelpForObject:")]
	public virtual void RemoveContext(NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveContextHelpForObject_Handle, theObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveContextHelpForObject_Handle, theObject.Handle);
		}
	}

	[Export("contextHelpForObject:")]
	public virtual NSAttributedString Context(NSObject theObject)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (IsDirectBinding)
		{
			return (NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContextHelpForObject_Handle, theObject.Handle));
		}
		return (NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContextHelpForObject_Handle, theObject.Handle));
	}

	[Export("showContextHelpForObject:locationHint:")]
	public virtual bool ShowContext(NSObject theObject, CGPoint pt)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint(base.Handle, selShowContextHelpForObjectLocationHint_Handle, theObject.Handle, pt);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selShowContextHelpForObjectLocationHint_Handle, theObject.Handle, pt);
	}

	[Export("openHelpAnchor:inBook:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selOpenHelpAnchorInBook_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selOpenHelpAnchorInBook_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("findString:inBook:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindStringInBook_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindStringInBook_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("registerBooksInBundle:")]
	public virtual bool RegisterBooks(NSBundle bundle)
	{
		NSApplication.EnsureUIThread();
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRegisterBooksInBundle_Handle, bundle.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterBooksInBundle_Handle, bundle.Handle);
	}
}

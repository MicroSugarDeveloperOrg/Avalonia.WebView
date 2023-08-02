using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSViewController", true)]
public class NSViewController : NSResponder
{
	private static readonly IntPtr selNibNameHandle = Selector.GetHandle("nibName");

	private static readonly IntPtr selNibBundleHandle = Selector.GetHandle("nibBundle");

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	private static readonly IntPtr selInitWithNibNameBundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	private static readonly IntPtr selLoadViewHandle = Selector.GetHandle("loadView");

	private static readonly IntPtr selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	private static readonly IntPtr selDiscardEditingHandle = Selector.GetHandle("discardEditing");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSViewController");

	private object __mt_NibBundle_var;

	private object __mt_RepresentedObject_var;

	private object __mt_View_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string NibName
	{
		[Export("nibName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNibNameHandle));
		}
	}

	public virtual NSBundle NibBundle
	{
		[Export("nibBundle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSBundle)(__mt_NibBundle_var = ((!IsDirectBinding) ? ((NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNibBundleHandle))) : ((NSBundle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNibBundleHandle)))));
		}
	}

	public virtual NSObject RepresentedObject
	{
		[Export("representedObject")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_RepresentedObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle))));
		}
		[Export("setRepresentedObject:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedObject_Handle, value.Handle);
			}
			__mt_RepresentedObject_var = value;
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_View_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)))));
		}
		[Export("setView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value.Handle);
			}
			__mt_View_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSViewController()
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
	public NSViewController(NSCoder coder)
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
	public NSViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	public NSViewController(string nibNameOrNull, NSBundle nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibNameBundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibNameBundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("loadView")]
	public virtual void LoadView()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadViewHandle);
		}
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	public new virtual void CommitEditing(NSObject delegateObject, Selector didCommitSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didCommitSelector == null)
		{
			throw new ArgumentNullException("didCommitSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, delegateObject.Handle, didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, delegateObject.Handle, didCommitSelector.Handle, contextInfo);
		}
	}

	[Export("commitEditing")]
	public new virtual bool CommitEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCommitEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCommitEditingHandle);
	}

	[Export("discardEditing")]
	public virtual void DiscardEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardEditingHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_NibBundle_var = null;
			__mt_RepresentedObject_var = null;
			__mt_View_var = null;
		}
	}
}

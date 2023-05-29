using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindowController", true)]
public class NSWindowController : NSResponder
{
	private static readonly IntPtr selWindowNibNameHandle = Selector.GetHandle("windowNibName");

	private static readonly IntPtr selWindowNibPathHandle = Selector.GetHandle("windowNibPath");

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	private static readonly IntPtr selWindowFrameAutosaveNameHandle = Selector.GetHandle("windowFrameAutosaveName");

	private static readonly IntPtr selSetWindowFrameAutosaveName_Handle = Selector.GetHandle("setWindowFrameAutosaveName:");

	private static readonly IntPtr selShouldCascadeWindowsHandle = Selector.GetHandle("shouldCascadeWindows");

	private static readonly IntPtr selSetShouldCascadeWindows_Handle = Selector.GetHandle("setShouldCascadeWindows:");

	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	private static readonly IntPtr selSetDocument_Handle = Selector.GetHandle("setDocument:");

	private static readonly IntPtr selShouldCloseDocumentHandle = Selector.GetHandle("shouldCloseDocument");

	private static readonly IntPtr selSetShouldCloseDocument_Handle = Selector.GetHandle("setShouldCloseDocument:");

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	private static readonly IntPtr selSetWindow_Handle = Selector.GetHandle("setWindow:");

	private static readonly IntPtr selIsWindowLoadedHandle = Selector.GetHandle("isWindowLoaded");

	private static readonly IntPtr selInitWithWindow_Handle = Selector.GetHandle("initWithWindow:");

	private static readonly IntPtr selInitWithWindowNibName_Handle = Selector.GetHandle("initWithWindowNibName:");

	private static readonly IntPtr selInitWithWindowNibNameOwner_Handle = Selector.GetHandle("initWithWindowNibName:owner:");

	private static readonly IntPtr selSetDocumentEdited_Handle = Selector.GetHandle("setDocumentEdited:");

	private static readonly IntPtr selSynchronizeWindowTitleWithDocumentNameHandle = Selector.GetHandle("synchronizeWindowTitleWithDocumentName");

	private static readonly IntPtr selWindowTitleForDocumentDisplayName_Handle = Selector.GetHandle("windowTitleForDocumentDisplayName:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selShowWindow_Handle = Selector.GetHandle("showWindow:");

	private static readonly IntPtr selWindowWillLoadHandle = Selector.GetHandle("windowWillLoad");

	private static readonly IntPtr selWindowDidLoadHandle = Selector.GetHandle("windowDidLoad");

	private static readonly IntPtr selLoadWindowHandle = Selector.GetHandle("loadWindow");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSWindowController");

	private object __mt_Owner_var;

	private object __mt_Document_var;

	private object __mt_Window_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string WindowNibName
	{
		[Export("windowNibName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibNameHandle));
		}
	}

	public virtual string WindowNibPath
	{
		[Export("windowNibPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibPathHandle));
		}
	}

	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Owner_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle))));
		}
	}

	public virtual string WindowFrameAutosaveName
	{
		[Export("windowFrameAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowFrameAutosaveNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowFrameAutosaveNameHandle));
		}
		[Export("setWindowFrameAutosaveName:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindowFrameAutosaveName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindowFrameAutosaveName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool ShouldCascadeWindows
	{
		[Export("shouldCascadeWindows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCascadeWindowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCascadeWindowsHandle);
		}
		[Export("setShouldCascadeWindows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCascadeWindows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCascadeWindows_Handle, value);
			}
		}
	}

	public virtual NSDocument Document
	{
		[Export("document")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDocument)(__mt_Document_var = ((!IsDirectBinding) ? ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle))) : ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle)))));
		}
		[Export("setDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocument_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocument_Handle, value.Handle);
			}
			__mt_Document_var = value;
		}
	}

	public virtual bool ShouldCloseDocument
	{
		[Export("shouldCloseDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCloseDocumentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCloseDocumentHandle);
		}
		[Export("setShouldCloseDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCloseDocument_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCloseDocument_Handle, value);
			}
		}
	}

	public virtual NSWindow Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_Window_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle)))));
		}
		[Export("setWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindow_Handle, value.Handle);
			}
			__mt_Window_var = value;
		}
	}

	public virtual bool IsWindowLoaded
	{
		[Export("isWindowLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsWindowLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsWindowLoadedHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWindowController()
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
	public NSWindowController(NSCoder coder)
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
	public NSWindowController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSWindowController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithWindow:")]
	public NSWindowController(NSWindow window)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithWindow_Handle, window.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithWindow_Handle, window.Handle);
		}
	}

	[Export("initWithWindowNibName:")]
	public NSWindowController(string windowNibName)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (windowNibName == null)
		{
			throw new ArgumentNullException("windowNibName");
		}
		IntPtr arg = NSString.CreateNative(windowNibName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithWindowNibName_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithWindowNibName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithWindowNibName:owner:")]
	public NSWindowController(string windowNibName, NSObject owner)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (windowNibName == null)
		{
			throw new ArgumentNullException("windowNibName");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		IntPtr arg = NSString.CreateNative(windowNibName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithWindowNibNameOwner_Handle, arg, owner.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithWindowNibNameOwner_Handle, arg, owner.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setDocumentEdited:")]
	public virtual void SetDocumentEdited(bool dirtyFlag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetDocumentEdited_Handle, dirtyFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDocumentEdited_Handle, dirtyFlag);
		}
	}

	[Export("synchronizeWindowTitleWithDocumentName")]
	public virtual void SynchronizeWindowTitleWithDocumentName()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeWindowTitleWithDocumentNameHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeWindowTitleWithDocumentNameHandle);
		}
	}

	[Export("windowTitleForDocumentDisplayName:")]
	public virtual string WindowTitleForDocumentDisplayName(string displayName)
	{
		NSApplication.EnsureUIThread();
		if (displayName == null)
		{
			throw new ArgumentNullException("displayName");
		}
		IntPtr arg = NSString.CreateNative(displayName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowTitleForDocumentDisplayName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWindowTitleForDocumentDisplayName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("showWindow:")]
	public virtual void ShowWindow(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowWindow_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowWindow_Handle, sender.Handle);
		}
	}

	[Export("windowWillLoad")]
	public virtual void WindowWillLoad()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWindowWillLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWindowWillLoadHandle);
		}
	}

	[Export("windowDidLoad")]
	public virtual void WindowDidLoad()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWindowDidLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWindowDidLoadHandle);
		}
	}

	[Export("loadWindow")]
	public virtual void LoadWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadWindowHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Owner_var = null;
			__mt_Document_var = null;
			__mt_Window_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindowController", true)]
public class NSWindowController : NSResponder, INSCoding, INativeObject, IDisposable, INSSeguePerforming
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentViewController = "contentViewController";

	private static readonly IntPtr selContentViewControllerHandle = Selector.GetHandle("contentViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissController_ = "dismissController:";

	private static readonly IntPtr selDismissController_Handle = Selector.GetHandle("dismissController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocument = "document";

	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWindow_ = "initWithWindow:";

	private static readonly IntPtr selInitWithWindow_Handle = Selector.GetHandle("initWithWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWindowNibName_ = "initWithWindowNibName:";

	private static readonly IntPtr selInitWithWindowNibName_Handle = Selector.GetHandle("initWithWindowNibName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWindowNibName_Owner_ = "initWithWindowNibName:owner:";

	private static readonly IntPtr selInitWithWindowNibName_Owner_Handle = Selector.GetHandle("initWithWindowNibName:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsWindowLoaded = "isWindowLoaded";

	private static readonly IntPtr selIsWindowLoadedHandle = Selector.GetHandle("isWindowLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadWindow = "loadWindow";

	private static readonly IntPtr selLoadWindowHandle = Selector.GetHandle("loadWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwner = "owner";

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSegueWithIdentifier_Sender_ = "performSegueWithIdentifier:sender:";

	private static readonly IntPtr selPerformSegueWithIdentifier_Sender_Handle = Selector.GetHandle("performSegueWithIdentifier:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForSegue_Sender_ = "prepareForSegue:sender:";

	private static readonly IntPtr selPrepareForSegue_Sender_Handle = Selector.GetHandle("prepareForSegue:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentViewController_ = "setContentViewController:";

	private static readonly IntPtr selSetContentViewController_Handle = Selector.GetHandle("setContentViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocument_ = "setDocument:";

	private static readonly IntPtr selSetDocument_Handle = Selector.GetHandle("setDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentEdited_ = "setDocumentEdited:";

	private static readonly IntPtr selSetDocumentEdited_Handle = Selector.GetHandle("setDocumentEdited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCascadeWindows_ = "setShouldCascadeWindows:";

	private static readonly IntPtr selSetShouldCascadeWindows_Handle = Selector.GetHandle("setShouldCascadeWindows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCloseDocument_ = "setShouldCloseDocument:";

	private static readonly IntPtr selSetShouldCloseDocument_Handle = Selector.GetHandle("setShouldCloseDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindow_ = "setWindow:";

	private static readonly IntPtr selSetWindow_Handle = Selector.GetHandle("setWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindowFrameAutosaveName_ = "setWindowFrameAutosaveName:";

	private static readonly IntPtr selSetWindowFrameAutosaveName_Handle = Selector.GetHandle("setWindowFrameAutosaveName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCascadeWindows = "shouldCascadeWindows";

	private static readonly IntPtr selShouldCascadeWindowsHandle = Selector.GetHandle("shouldCascadeWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCloseDocument = "shouldCloseDocument";

	private static readonly IntPtr selShouldCloseDocumentHandle = Selector.GetHandle("shouldCloseDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldPerformSegueWithIdentifier_Sender_ = "shouldPerformSegueWithIdentifier:sender:";

	private static readonly IntPtr selShouldPerformSegueWithIdentifier_Sender_Handle = Selector.GetHandle("shouldPerformSegueWithIdentifier:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowWindow_ = "showWindow:";

	private static readonly IntPtr selShowWindow_Handle = Selector.GetHandle("showWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoryboard = "storyboard";

	private static readonly IntPtr selStoryboardHandle = Selector.GetHandle("storyboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeWindowTitleWithDocumentName = "synchronizeWindowTitleWithDocumentName";

	private static readonly IntPtr selSynchronizeWindowTitleWithDocumentNameHandle = Selector.GetHandle("synchronizeWindowTitleWithDocumentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindow = "window";

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowDidLoad = "windowDidLoad";

	private static readonly IntPtr selWindowDidLoadHandle = Selector.GetHandle("windowDidLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowFrameAutosaveName = "windowFrameAutosaveName";

	private static readonly IntPtr selWindowFrameAutosaveNameHandle = Selector.GetHandle("windowFrameAutosaveName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNibName = "windowNibName";

	private static readonly IntPtr selWindowNibNameHandle = Selector.GetHandle("windowNibName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNibPath = "windowNibPath";

	private static readonly IntPtr selWindowNibPathHandle = Selector.GetHandle("windowNibPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowTitleForDocumentDisplayName_ = "windowTitleForDocumentDisplayName:";

	private static readonly IntPtr selWindowTitleForDocumentDisplayName_Handle = Selector.GetHandle("windowTitleForDocumentDisplayName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowWillLoad = "windowWillLoad";

	private static readonly IntPtr selWindowWillLoadHandle = Selector.GetHandle("windowWillLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSWindowController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController ContentViewController
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("contentViewController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewControllerHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setContentViewController:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentViewController_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument? Document
	{
		[Export("document")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle));
			}
			return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle));
		}
		[Export("setDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsWindowLoaded
	{
		[Export("isWindowLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsWindowLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsWindowLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCascadeWindows
	{
		[Export("shouldCascadeWindows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCascadeWindowsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCascadeWindowsHandle);
		}
		[Export("setShouldCascadeWindows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCascadeWindows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCascadeWindows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCloseDocument
	{
		[Export("shouldCloseDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCloseDocumentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCloseDocumentHandle);
		}
		[Export("setShouldCloseDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCloseDocument_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCloseDocument_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSStoryboard Storyboard
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("storyboard", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selStoryboardHandle));
			}
			return Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStoryboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow Window
	{
		[Export("window", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle));
		}
		[Export("setWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindow_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WindowFrameAutosaveName
	{
		[Export("windowFrameAutosaveName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WindowNibName
	{
		[Export("windowNibName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WindowNibPath
	{
		[Export("windowNibPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWindowController()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSWindowController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSWindowController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWindowController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithWindow:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindowController(NSWindow window)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithWindow_Handle, window.Handle), "initWithWindow:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithWindow_Handle, window.Handle), "initWithWindow:");
		}
	}

	[Export("initWithWindowNibName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindowController(string windowNibName)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (windowNibName == null)
		{
			throw new ArgumentNullException("windowNibName");
		}
		IntPtr arg = NSString.CreateNative(windowNibName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithWindowNibName_Handle, arg), "initWithWindowNibName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithWindowNibName_Handle, arg), "initWithWindowNibName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithWindowNibName:owner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithWindowNibName_Owner_Handle, arg, owner.Handle), "initWithWindowNibName:owner:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithWindowNibName_Owner_Handle, arg, owner.Handle), "initWithWindowNibName:owner:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("dismissController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissController(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismissController_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismissController_Handle, sender.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("loadWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadWindowHandle);
		}
	}

	[Export("performSegueWithIdentifier:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSegue(string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("prepareForSegue:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (segue == null)
		{
			throw new ArgumentNullException("segue");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrepareForSegue_Sender_Handle, segue.Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrepareForSegue_Sender_Handle, segue.Handle, sender.Handle);
		}
	}

	[Export("setDocumentEdited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDocumentEdited(bool dirtyFlag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetDocumentEdited_Handle, dirtyFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDocumentEdited_Handle, dirtyFlag);
		}
	}

	[Export("shouldPerformSegueWithIdentifier:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPerformSegue(string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("showWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowWindow(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowWindow_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowWindow_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("synchronizeWindowTitleWithDocumentName")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SynchronizeWindowTitleWithDocumentName()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeWindowTitleWithDocumentNameHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeWindowTitleWithDocumentNameHandle);
		}
	}

	[Export("windowDidLoad")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WindowDidLoad()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWindowDidLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWindowDidLoadHandle);
		}
	}

	[Export("windowTitleForDocumentDisplayName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WindowTitleForDocumentDisplayName(string displayName)
	{
		NSApplication.EnsureUIThread();
		if (displayName == null)
		{
			throw new ArgumentNullException("displayName");
		}
		IntPtr arg = NSString.CreateNative(displayName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowTitleForDocumentDisplayName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWindowTitleForDocumentDisplayName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("windowWillLoad")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WindowWillLoad()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWindowWillLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWindowWillLoadHandle);
		}
	}
}

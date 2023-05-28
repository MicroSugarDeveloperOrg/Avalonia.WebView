using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPrintPanel", true)]
public class NSPrintPanel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryControllers = "accessoryControllers";

	private static readonly IntPtr selAccessoryControllersHandle = Selector.GetHandle("accessoryControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAccessoryController_ = "addAccessoryController:";

	private static readonly IntPtr selAddAccessoryController_Handle = Selector.GetHandle("addAccessoryController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_ = "beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultButtonTitle = "defaultButtonTitle";

	private static readonly IntPtr selDefaultButtonTitleHandle = Selector.GetHandle("defaultButtonTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHelpAnchor = "helpAnchor";

	private static readonly IntPtr selHelpAnchorHandle = Selector.GetHandle("helpAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJobStyleHint = "jobStyleHint";

	private static readonly IntPtr selJobStyleHintHandle = Selector.GetHandle("jobStyleHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintInfo = "printInfo";

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintPanel = "printPanel";

	private static readonly IntPtr selPrintPanelHandle = Selector.GetHandle("printPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAccessoryController_ = "removeAccessoryController:";

	private static readonly IntPtr selRemoveAccessoryController_Handle = Selector.GetHandle("removeAccessoryController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModal = "runModal";

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalWithPrintInfo_ = "runModalWithPrintInfo:";

	private static readonly IntPtr selRunModalWithPrintInfo_Handle = Selector.GetHandle("runModalWithPrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultButtonTitle_ = "setDefaultButtonTitle:";

	private static readonly IntPtr selSetDefaultButtonTitle_Handle = Selector.GetHandle("setDefaultButtonTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHelpAnchor_ = "setHelpAnchor:";

	private static readonly IntPtr selSetHelpAnchor_Handle = Selector.GetHandle("setHelpAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJobStyleHint_ = "setJobStyleHint:";

	private static readonly IntPtr selSetJobStyleHint_Handle = Selector.GetHandle("setJobStyleHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOptions_ = "setOptions:";

	private static readonly IntPtr selSetOptions_Handle = Selector.GetHandle("setOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPrintPanel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DefaultButtonTitle
	{
		[Export("defaultButtonTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultButtonTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultButtonTitleHandle));
		}
		[Export("setDefaultButtonTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultButtonTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultButtonTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string HelpAnchor
	{
		[Export("helpAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHelpAnchorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHelpAnchorHandle));
		}
		[Export("setHelpAnchor:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHelpAnchor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHelpAnchor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string JobStyleHint
	{
		[Export("jobStyleHint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJobStyleHintHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJobStyleHintHandle));
		}
		[Export("setJobStyleHint:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJobStyleHint_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJobStyleHint_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintPanelOptions Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPrintPanelOptions)Messaging.Int64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSPrintPanelOptions)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
		[Export("setOptions:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetOptions_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetOptions_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle));
			}
			return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrintPanel PrintPanel
	{
		[Export("printPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPrintPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selPrintPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintPanel()
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
	protected NSPrintPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPrintPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("accessoryControllers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController[] AccessoryControllers()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryControllersHandle));
		}
		return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryControllersHandle));
	}

	[Export("addAccessoryController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAccessoryController(NSViewController accessoryController)
	{
		NSApplication.EnsureUIThread();
		if (accessoryController == null)
		{
			throw new ArgumentNullException("accessoryController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAccessoryController_Handle, accessoryController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAccessoryController_Handle, accessoryController.Handle);
		}
	}

	[Export("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow, NSObject? del, Selector? didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (docWindow == null)
		{
			throw new ArgumentNullException("docWindow");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_Handle, printInfo.Handle, docWindow.Handle, del?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetWithPrintInfo_ModalForWindow_Delegate_DidEndSelector_ContextInfo_Handle, printInfo.Handle, docWindow.Handle, del?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
	}

	[Export("removeAccessoryController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAccessoryController(NSViewController accessoryController)
	{
		NSApplication.EnsureUIThread();
		if (accessoryController == null)
		{
			throw new ArgumentNullException("accessoryController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAccessoryController_Handle, accessoryController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAccessoryController_Handle, accessoryController.Handle);
		}
	}

	[Export("runModal")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}

	[Export("runModalWithPrintInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModalWithPrintInfo(NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selRunModalWithPrintInfo_Handle, printInfo.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalWithPrintInfo_Handle, printInfo.Handle);
	}
}

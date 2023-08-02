using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPrintPanel", true)]
public class NSPrintPanel : NSObject
{
	private object __mt_accessory_var;

	private static readonly IntPtr selPrintPanelHandle = Selector.GetHandle("printPanel");

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selSetOptions_Handle = Selector.GetHandle("setOptions:");

	private static readonly IntPtr selDefaultButtonTitleHandle = Selector.GetHandle("defaultButtonTitle");

	private static readonly IntPtr selSetDefaultButtonTitle_Handle = Selector.GetHandle("setDefaultButtonTitle:");

	private static readonly IntPtr selHelpAnchorHandle = Selector.GetHandle("helpAnchor");

	private static readonly IntPtr selSetHelpAnchor_Handle = Selector.GetHandle("setHelpAnchor:");

	private static readonly IntPtr selJobStyleHintHandle = Selector.GetHandle("jobStyleHint");

	private static readonly IntPtr selSetJobStyleHint_Handle = Selector.GetHandle("setJobStyleHint:");

	private static readonly IntPtr selAddAccessoryController_Handle = Selector.GetHandle("addAccessoryController:");

	private static readonly IntPtr selRemoveAccessoryController_Handle = Selector.GetHandle("removeAccessoryController:");

	private static readonly IntPtr selAccessoryControllersHandle = Selector.GetHandle("accessoryControllers");

	private static readonly IntPtr selBeginSheetWithPrintInfoModalForWindowDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selRunModalWithPrintInfo_Handle = Selector.GetHandle("runModalWithPrintInfo:");

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPrintPanel");

	private static object __mt_PrintPanel_var_static;

	private object __mt_PrintInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSPrintPanel PrintPanel
	{
		[Export("printPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintPanel)(__mt_PrintPanel_var_static = (NSPrintPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPrintPanelHandle)));
		}
	}

	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintInfo)(__mt_PrintInfo_var = ((!IsDirectBinding) ? ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle))) : ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle)))));
		}
	}

	public virtual NSPrintPanelOptions Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPrintPanelOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSPrintPanelOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
		[Export("setOptions:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOptions_Handle, (ulong)value);
			}
		}
	}

	public virtual string DefaultButtonTitle
	{
		[Export("defaultButtonTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string HelpAnchor
	{
		[Export("helpAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string JobStyleHint
	{
		[Export("jobStyleHint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrintPanel()
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
	public NSPrintPanel(NSCoder coder)
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
	public NSPrintPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPrintPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addAccessoryController:")]
	public virtual void AddAccessoryController(NSViewController accessoryController)
	{
		NSApplication.EnsureUIThread();
		if (accessoryController == null)
		{
			throw new ArgumentNullException("accessoryController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAccessoryController_Handle, accessoryController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAccessoryController_Handle, accessoryController.Handle);
		}
		__mt_accessory_var = AccessoryControllers();
	}

	[Export("removeAccessoryController:")]
	public virtual void RemoveAccessoryController(NSViewController accessoryController)
	{
		NSApplication.EnsureUIThread();
		if (accessoryController == null)
		{
			throw new ArgumentNullException("accessoryController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAccessoryController_Handle, accessoryController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAccessoryController_Handle, accessoryController.Handle);
		}
		__mt_accessory_var = AccessoryControllers();
	}

	[Export("accessoryControllers")]
	public virtual NSViewController[] AccessoryControllers()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryControllersHandle));
		}
		return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryControllersHandle));
	}

	[Export("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:")]
	public virtual void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow, NSObject del, Selector didEndSelector, IntPtr contextInfo)
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetWithPrintInfoModalForWindowDelegateDidEndSelectorContextInfo_Handle, printInfo.Handle, docWindow.Handle, del?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetWithPrintInfoModalForWindowDelegateDidEndSelectorContextInfo_Handle, printInfo.Handle, docWindow.Handle, del?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
	}

	[Export("runModalWithPrintInfo:")]
	public virtual long RunModalWithPrintInfo(NSPrintInfo printInfo)
	{
		NSApplication.EnsureUIThread();
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selRunModalWithPrintInfo_Handle, printInfo.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalWithPrintInfo_Handle, printInfo.Handle);
	}

	[Export("runModal")]
	public virtual long RunModal()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}

	protected override void Dispose(bool disposing)
	{
		__mt_accessory_var = null;
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PrintInfo_var = null;
		}
	}
}

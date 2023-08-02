using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPageLayout", true)]
public class NSPageLayout : NSObject
{
	private object __mt_accessory_var;

	private static readonly IntPtr selPageLayoutHandle = Selector.GetHandle("pageLayout");

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	private static readonly IntPtr selAddAccessoryController_Handle = Selector.GetHandle("addAccessoryController:");

	private static readonly IntPtr selRemoveAccessoryController_Handle = Selector.GetHandle("removeAccessoryController:");

	private static readonly IntPtr selAccessoryControllersHandle = Selector.GetHandle("accessoryControllers");

	private static readonly IntPtr selBeginSheetWithPrintInfoModalForWindowDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selRunModalWithPrintInfo_Handle = Selector.GetHandle("runModalWithPrintInfo:");

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPageLayout");

	private static object __mt_PageLayout_var_static;

	private object __mt_PrintInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSPageLayout PageLayout
	{
		[Export("pageLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPageLayout)(__mt_PageLayout_var_static = (NSPageLayout)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPageLayoutHandle)));
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

	public void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow)
	{
		BeginSheet(printInfo, docWindow, null, null, IntPtr.Zero);
	}

	public void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow, NSAction onEnded)
	{
		NSObject del = OneShotTracker.Create(onEnded);
		BeginSheet(printInfo, docWindow, del, NSActionDispatcher.Selector, IntPtr.Zero);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPageLayout()
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
	public NSPageLayout(NSCoder coder)
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
	public NSPageLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPageLayout(IntPtr handle)
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

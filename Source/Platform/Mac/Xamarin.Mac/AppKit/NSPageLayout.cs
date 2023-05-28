using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSPageLayout", true)]
public class NSPageLayout : NSObject
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
	private const string selPageLayout = "pageLayout";

	private static readonly IntPtr selPageLayoutHandle = Selector.GetHandle("pageLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintInfo = "printInfo";

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPageLayout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPageLayout PageLayout
	{
		[Export("pageLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPageLayout>(Messaging.IntPtr_objc_msgSend(class_ptr, selPageLayoutHandle));
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

	public void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow)
	{
		BeginSheet(printInfo, docWindow, null, null, IntPtr.Zero);
	}

	public void BeginSheet(NSPrintInfo printInfo, NSWindow docWindow, Action onEnded)
	{
		NSAsyncActionDispatcher del = new NSAsyncActionDispatcher(onEnded);
		BeginSheet(printInfo, docWindow, del, NSDispatcher.Selector, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPageLayout()
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
	protected NSPageLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPageLayout(IntPtr handle)
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

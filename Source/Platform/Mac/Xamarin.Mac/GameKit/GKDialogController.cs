using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKDialogController", true)]
public class GKDialogController : NSResponder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismiss_ = "dismiss:";

	private static readonly IntPtr selDismiss_Handle = Selector.GetHandle("dismiss:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentWindow = "parentWindow";

	private static readonly IntPtr selParentWindowHandle = Selector.GetHandle("parentWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewController_ = "presentViewController:";

	private static readonly IntPtr selPresentViewController_Handle = Selector.GetHandle("presentViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParentWindow_ = "setParentWindow:";

	private static readonly IntPtr selSetParentWindow_Handle = Selector.GetHandle("setParentWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedDialogController = "sharedDialogController";

	private static readonly IntPtr selSharedDialogControllerHandle = Selector.GetHandle("sharedDialogController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKDialogController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ParentWindow_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow ParentWindow
	{
		[Export("parentWindow", ArgumentSemantic.Weak)]
		get
		{
			NSWindow nSWindow = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentWindowHandle)) : Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentWindowHandle)));
			MarkDirty();
			__mt_ParentWindow_var = nSWindow;
			return nSWindow;
		}
		[Export("setParentWindow:", ArgumentSemantic.Weak)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentWindow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentWindow_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ParentWindow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKDialogController SharedDialogController
	{
		[Export("sharedDialogController")]
		get
		{
			return Runtime.GetNSObject<GKDialogController>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedDialogControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKDialogController()
		: base(NSObjectFlag.Empty)
	{
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
	public GKDialogController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected GKDialogController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKDialogController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dismiss:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Dismiss(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismiss_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismiss_Handle, sender.Handle);
		}
	}

	[Export("presentViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PresentViewController(NSViewController viewController)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPresentViewController_Handle, viewController.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentViewController_Handle, viewController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentWindow_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPanel", true)]
public class NSPanel : NSWindow
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomesKeyOnlyIfNeeded = "becomesKeyOnlyIfNeeded";

	private static readonly IntPtr selBecomesKeyOnlyIfNeededHandle = Selector.GetHandle("becomesKeyOnlyIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentRect_StyleMask_Backing_Defer_ = "initWithContentRect:styleMask:backing:defer:";

	private static readonly IntPtr selInitWithContentRect_StyleMask_Backing_Defer_Handle = Selector.GetHandle("initWithContentRect:styleMask:backing:defer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFloatingPanel = "isFloatingPanel";

	private static readonly IntPtr selIsFloatingPanelHandle = Selector.GetHandle("isFloatingPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBecomesKeyOnlyIfNeeded_ = "setBecomesKeyOnlyIfNeeded:";

	private static readonly IntPtr selSetBecomesKeyOnlyIfNeeded_Handle = Selector.GetHandle("setBecomesKeyOnlyIfNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatingPanel_ = "setFloatingPanel:";

	private static readonly IntPtr selSetFloatingPanel_Handle = Selector.GetHandle("setFloatingPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWorksWhenModal_ = "setWorksWhenModal:";

	private static readonly IntPtr selSetWorksWhenModal_Handle = Selector.GetHandle("setWorksWhenModal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorksWhenModal = "worksWhenModal";

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPanel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BecomesKeyOnlyIfNeeded
	{
		[Export("becomesKeyOnlyIfNeeded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBecomesKeyOnlyIfNeededHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBecomesKeyOnlyIfNeededHandle);
		}
		[Export("setBecomesKeyOnlyIfNeeded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBecomesKeyOnlyIfNeeded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBecomesKeyOnlyIfNeeded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FloatingPanel
	{
		[Export("isFloatingPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFloatingPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFloatingPanelHandle);
		}
		[Export("setFloatingPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloatingPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloatingPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool WorksWhenModal
	{
		[Export("worksWhenModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWorksWhenModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWorksWhenModalHandle);
		}
		[Export("setWorksWhenModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWorksWhenModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWorksWhenModal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPanel()
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
	public NSPanel(NSCoder coder)
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
	protected NSPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentRect:styleMask:backing:defer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPanel(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool(base.Handle, selInitWithContentRect_StyleMask_Backing_Defer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation), "initWithContentRect:styleMask:backing:defer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool(base.SuperHandle, selInitWithContentRect_StyleMask_Backing_Defer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation), "initWithContentRect:styleMask:backing:defer:");
		}
	}
}

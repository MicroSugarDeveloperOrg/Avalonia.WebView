using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSplitViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSSplitViewController : NSViewController, INSSplitViewDelegate, INativeObject, IDisposable, INSUserInterfaceValidations
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSplitViewItem_ = "addSplitViewItem:";

	private static readonly IntPtr selAddSplitViewItem_Handle = Selector.GetHandle("addSplitViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSplitViewItem_AtIndex_ = "insertSplitViewItem:atIndex:";

	private static readonly IntPtr selInsertSplitViewItem_AtIndex_Handle = Selector.GetHandle("insertSplitViewItem:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumThicknessForInlineSidebars = "minimumThicknessForInlineSidebars";

	private static readonly IntPtr selMinimumThicknessForInlineSidebarsHandle = Selector.GetHandle("minimumThicknessForInlineSidebars");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSplitViewItem_ = "removeSplitViewItem:";

	private static readonly IntPtr selRemoveSplitViewItem_Handle = Selector.GetHandle("removeSplitViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumThicknessForInlineSidebars_ = "setMinimumThicknessForInlineSidebars:";

	private static readonly IntPtr selSetMinimumThicknessForInlineSidebars_Handle = Selector.GetHandle("setMinimumThicknessForInlineSidebars:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSplitView_ = "setSplitView:";

	private static readonly IntPtr selSetSplitView_Handle = Selector.GetHandle("setSplitView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSplitViewItems_ = "setSplitViewItems:";

	private static readonly IntPtr selSetSplitViewItems_Handle = Selector.GetHandle("setSplitViewItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView = "splitView";

	private static readonly IntPtr selSplitViewHandle = Selector.GetHandle("splitView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_AdditionalEffectiveRectOfDividerAtIndex_ = "splitView:additionalEffectiveRectOfDividerAtIndex:";

	private static readonly IntPtr selSplitView_AdditionalEffectiveRectOfDividerAtIndex_Handle = Selector.GetHandle("splitView:additionalEffectiveRectOfDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_CanCollapseSubview_ = "splitView:canCollapseSubview:";

	private static readonly IntPtr selSplitView_CanCollapseSubview_Handle = Selector.GetHandle("splitView:canCollapseSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ConstrainMaxCoordinate_OfSubviewAt_ = "splitView:constrainMaxCoordinate:ofSubviewAt:";

	private static readonly IntPtr selSplitView_ConstrainMaxCoordinate_OfSubviewAt_Handle = Selector.GetHandle("splitView:constrainMaxCoordinate:ofSubviewAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ConstrainMinCoordinate_OfSubviewAt_ = "splitView:constrainMinCoordinate:ofSubviewAt:";

	private static readonly IntPtr selSplitView_ConstrainMinCoordinate_OfSubviewAt_Handle = Selector.GetHandle("splitView:constrainMinCoordinate:ofSubviewAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ConstrainSplitPosition_OfSubviewAt_ = "splitView:constrainSplitPosition:ofSubviewAt:";

	private static readonly IntPtr selSplitView_ConstrainSplitPosition_OfSubviewAt_Handle = Selector.GetHandle("splitView:constrainSplitPosition:ofSubviewAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_ = "splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:";

	private static readonly IntPtr selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_Handle = Selector.GetHandle("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ResizeSubviewsWithOldSize_ = "splitView:resizeSubviewsWithOldSize:";

	private static readonly IntPtr selSplitView_ResizeSubviewsWithOldSize_Handle = Selector.GetHandle("splitView:resizeSubviewsWithOldSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ShouldAdjustSizeOfSubview_ = "splitView:shouldAdjustSizeOfSubview:";

	private static readonly IntPtr selSplitView_ShouldAdjustSizeOfSubview_Handle = Selector.GetHandle("splitView:shouldAdjustSizeOfSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_ = "splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:";

	private static readonly IntPtr selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_Handle = Selector.GetHandle("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitView_ShouldHideDividerAtIndex_ = "splitView:shouldHideDividerAtIndex:";

	private static readonly IntPtr selSplitView_ShouldHideDividerAtIndex_Handle = Selector.GetHandle("splitView:shouldHideDividerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitViewDidResizeSubviews_ = "splitViewDidResizeSubviews:";

	private static readonly IntPtr selSplitViewDidResizeSubviews_Handle = Selector.GetHandle("splitViewDidResizeSubviews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitViewItemForViewController_ = "splitViewItemForViewController:";

	private static readonly IntPtr selSplitViewItemForViewController_Handle = Selector.GetHandle("splitViewItemForViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitViewItems = "splitViewItems";

	private static readonly IntPtr selSplitViewItemsHandle = Selector.GetHandle("splitViewItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitViewWillResizeSubviews_ = "splitViewWillResizeSubviews:";

	private static readonly IntPtr selSplitViewWillResizeSubviews_Handle = Selector.GetHandle("splitViewWillResizeSubviews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleSidebar_ = "toggleSidebar:";

	private static readonly IntPtr selToggleSidebar_Handle = Selector.GetHandle("toggleSidebar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSplitViewController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat MinimumThicknessForInlineSidebars
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("minimumThicknessForInlineSidebars", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumThicknessForInlineSidebarsHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumThicknessForInlineSidebarsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMinimumThicknessForInlineSidebars:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumThicknessForInlineSidebars_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumThicknessForInlineSidebars_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSplitView SplitView
	{
		[Export("splitView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSplitView>(Messaging.IntPtr_objc_msgSend(base.Handle, selSplitViewHandle));
			}
			return Runtime.GetNSObject<NSSplitView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSplitViewHandle));
		}
		[Export("setSplitView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSplitView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSplitView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSplitViewItem[] SplitViewItems
	{
		[Export("splitViewItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSplitViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSplitViewItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSSplitViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSplitViewItemsHandle));
		}
		[Export("setSplitViewItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSplitViewItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSplitViewItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[Field("NSSplitViewControllerAutomaticDimension", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static nfloat AutomaticDimension
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSSplitViewControllerAutomaticDimension");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitViewController()
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
	public NSSplitViewController(NSCoder coder)
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
	protected NSSplitViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSplitViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSplitViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addSplitViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSplitViewItem(NSSplitViewItem splitViewItem)
	{
		NSApplication.EnsureUIThread();
		if (splitViewItem == null)
		{
			throw new ArgumentNullException("splitViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSplitViewItem_Handle, splitViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSplitViewItem_Handle, splitViewItem.Handle);
		}
	}

	[Export("splitView:canCollapseSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual bool CanCollapse(NSSplitView splitView, NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSplitView_CanCollapseSubview_Handle, splitView.Handle, subview.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSplitView_CanCollapseSubview_Handle, splitView.Handle, subview.Handle);
	}

	[Export("splitView:constrainSplitPosition:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ConstrainSplitPosition(NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(base.Handle, selSplitView_ConstrainSplitPosition_OfSubviewAt_Handle, splitView.Handle, proposedPosition, subviewDividerIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_nfloat_nint(base.SuperHandle, selSplitView_ConstrainSplitPosition_OfSubviewAt_Handle, splitView.Handle, proposedPosition, subviewDividerIndex);
	}

	[Export("splitViewDidResizeSubviews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResizeSubviews(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSplitViewDidResizeSubviews_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSplitViewDidResizeSubviews_Handle, notification.Handle);
		}
	}

	[Export("splitView:additionalEffectiveRectOfDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual CGRect GetAdditionalEffectiveRect(NSSplitView splitView, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_nint(out retval, base.Handle, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_Handle, splitView.Handle, dividerIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_nint(out retval, base.SuperHandle, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_Handle, splitView.Handle, dividerIndex);
		}
		return retval;
	}

	[Export("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual CGRect GetEffectiveRect(NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_nint(out retval, base.Handle, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_Handle, splitView.Handle, proposedEffectiveRect, drawnRect, dividerIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGRect_nint(out retval, base.SuperHandle, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_Handle, splitView.Handle, proposedEffectiveRect, drawnRect, dividerIndex);
		}
		return retval;
	}

	[Export("splitViewItemForViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSplitViewItem GetSplitViewItem(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSplitViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSplitViewItemForViewController_Handle, viewController.Handle));
		}
		return Runtime.GetNSObject<NSSplitViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSplitViewItemForViewController_Handle, viewController.Handle));
	}

	[Export("insertSplitViewItem:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSplitViewItem(NSSplitViewItem splitViewItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (splitViewItem == null)
		{
			throw new ArgumentNullException("splitViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertSplitViewItem_AtIndex_Handle, splitViewItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertSplitViewItem_AtIndex_Handle, splitViewItem.Handle, index);
		}
	}

	[Export("removeSplitViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveSplitViewItem(NSSplitViewItem splitViewItem)
	{
		NSApplication.EnsureUIThread();
		if (splitViewItem == null)
		{
			throw new ArgumentNullException("splitViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveSplitViewItem_Handle, splitViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSplitViewItem_Handle, splitViewItem.Handle);
		}
	}

	[Export("splitView:resizeSubviewsWithOldSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resize(NSSplitView splitView, CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGSize(base.Handle, selSplitView_ResizeSubviewsWithOldSize_Handle, splitView.Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGSize(base.SuperHandle, selSplitView_ResizeSubviewsWithOldSize_Handle, splitView.Handle, oldSize);
		}
	}

	[Export("splitView:constrainMaxCoordinate:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SetMaxCoordinateOfSubview(NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(base.Handle, selSplitView_ConstrainMaxCoordinate_OfSubviewAt_Handle, splitView.Handle, proposedMaximumPosition, subviewDividerIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_nfloat_nint(base.SuperHandle, selSplitView_ConstrainMaxCoordinate_OfSubviewAt_Handle, splitView.Handle, proposedMaximumPosition, subviewDividerIndex);
	}

	[Export("splitView:constrainMinCoordinate:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SetMinCoordinateOfSubview(NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(base.Handle, selSplitView_ConstrainMinCoordinate_OfSubviewAt_Handle, splitView.Handle, proposedMinimumPosition, subviewDividerIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr_nfloat_nint(base.SuperHandle, selSplitView_ConstrainMinCoordinate_OfSubviewAt_Handle, splitView.Handle, proposedMinimumPosition, subviewDividerIndex);
	}

	[Export("splitView:shouldAdjustSizeOfSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAdjustSize(NSSplitView splitView, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSplitView_ShouldAdjustSizeOfSubview_Handle, splitView.Handle, view.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSplitView_ShouldAdjustSizeOfSubview_Handle, splitView.Handle, view.Handle);
	}

	[Export("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "This delegate method is never called, and NSSplitViewController's implementation always returns false.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual bool ShouldCollapseForDoubleClick(NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(base.Handle, selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_Handle, splitView.Handle, subview.Handle, doubleClickAtDividerIndex);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_nint(base.SuperHandle, selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_Handle, splitView.Handle, subview.Handle, doubleClickAtDividerIndex);
	}

	[Export("splitView:shouldHideDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual bool ShouldHideDivider(NSSplitView splitView, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nint(base.Handle, selSplitView_ShouldHideDividerAtIndex_Handle, splitView.Handle, dividerIndex);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSplitView_ShouldHideDividerAtIndex_Handle, splitView.Handle, dividerIndex);
	}

	[Export("splitViewWillResizeSubviews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SplitViewWillResizeSubviews(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSplitViewWillResizeSubviews_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSplitViewWillResizeSubviews_Handle, notification.Handle);
		}
	}

	[Export("toggleSidebar:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleSidebar(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSidebar_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSidebar_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableHeaderCell", true)]
public class NSTableHeaderCell : NSTextFieldCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSortIndicatorWithFrame_InView_Ascending_Priority_ = "drawSortIndicatorWithFrame:inView:ascending:priority:";

	private static readonly IntPtr selDrawSortIndicatorWithFrame_InView_Ascending_Priority_Handle = Selector.GetHandle("drawSortIndicatorWithFrame:inView:ascending:priority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortIndicatorRectForBounds_ = "sortIndicatorRectForBounds:";

	private static readonly IntPtr selSortIndicatorRectForBounds_Handle = Selector.GetHandle("sortIndicatorRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTableHeaderCell");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableHeaderCell()
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
	public NSTableHeaderCell(NSCoder coder)
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
	protected NSTableHeaderCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableHeaderCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTableHeaderCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("drawSortIndicatorWithFrame:inView:ascending:priority:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSortIndicator(CGRect cellFrame, NSView controlView, bool ascending, nint priority)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_bool_nint(base.Handle, selDrawSortIndicatorWithFrame_InView_Ascending_Priority_Handle, cellFrame, controlView.Handle, ascending, priority);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_bool_nint(base.SuperHandle, selDrawSortIndicatorWithFrame_InView_Ascending_Priority_Handle, cellFrame, controlView.Handle, ascending, priority);
		}
	}

	[Export("sortIndicatorRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetSortIndicatorRect(CGRect theRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSortIndicatorRectForBounds_Handle, theRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSortIndicatorRectForBounds_Handle, theRect);
		}
		return retval;
	}
}

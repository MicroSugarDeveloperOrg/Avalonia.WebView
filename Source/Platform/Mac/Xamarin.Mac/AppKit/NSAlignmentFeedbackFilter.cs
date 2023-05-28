using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAlignmentFeedbackFilter", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSAlignmentFeedbackFilter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_ = "alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:";

	private static readonly IntPtr selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_Handle = Selector.GetHandle("alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_ = "alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:";

	private static readonly IntPtr selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_Handle = Selector.GetHandle("alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_ = "alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:";

	private static readonly IntPtr selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_Handle = Selector.GetHandle("alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputEventMask = "inputEventMask";

	private static readonly IntPtr selInputEventMaskHandle = Selector.GetHandle("inputEventMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformFeedback_PerformanceTime_ = "performFeedback:performanceTime:";

	private static readonly IntPtr selPerformFeedback_PerformanceTime_Handle = Selector.GetHandle("performFeedback:performanceTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithEvent_ = "updateWithEvent:";

	private static readonly IntPtr selUpdateWithEvent_Handle = Selector.GetHandle("updateWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithPanRecognizer_ = "updateWithPanRecognizer:";

	private static readonly IntPtr selUpdateWithPanRecognizer_Handle = Selector.GetHandle("updateWithPanRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAlignmentFeedbackFilter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEventMask InputEventMask
	{
		[Export("inputEventMask")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSEventMask)Messaging.UInt64_objc_msgSend(class_ptr, selInputEventMaskHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAlignmentFeedbackFilter()
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
	protected NSAlignmentFeedbackFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAlignmentFeedbackFilter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSAlignmentFeedbackToken? GetTokenForHorizontalMovement(NSView? view, nfloat previousX, nfloat alignedX, nfloat defaultX)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat_nfloat(base.Handle, selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_Handle, view?.Handle ?? IntPtr.Zero, previousX, alignedX, defaultX), owns: false);
		}
		return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat_nfloat(base.SuperHandle, selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_Handle, view?.Handle ?? IntPtr.Zero, previousX, alignedX, defaultX), owns: false);
	}

	[Export("alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSAlignmentFeedbackToken? GetTokenForMovement(NSView? view, CGPoint previousPoint, CGPoint alignedPoint, CGPoint defaultPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint_CGPoint_CGPoint(base.Handle, selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_Handle, view?.Handle ?? IntPtr.Zero, previousPoint, alignedPoint, defaultPoint), owns: false);
		}
		return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint_CGPoint_CGPoint(base.SuperHandle, selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_Handle, view?.Handle ?? IntPtr.Zero, previousPoint, alignedPoint, defaultPoint), owns: false);
	}

	[Export("alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSAlignmentFeedbackToken? GetTokenForVerticalMovement(NSView? view, nfloat previousY, nfloat alignedY, nfloat defaultY)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat_nfloat(base.Handle, selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_Handle, view?.Handle ?? IntPtr.Zero, previousY, alignedY, defaultY), owns: false);
		}
		return Runtime.GetINativeObject<INSAlignmentFeedbackToken>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat_nfloat(base.SuperHandle, selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_Handle, view?.Handle ?? IntPtr.Zero, previousY, alignedY, defaultY), owns: false);
	}

	[Export("performFeedback:performanceTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformFeedback(INSAlignmentFeedbackToken[] tokens, NSHapticFeedbackPerformanceTime performanceTime)
	{
		NSApplication.EnsureUIThread();
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens");
		}
		NSArray nSArray = NSArray.FromNSObjects(tokens);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selPerformFeedback_PerformanceTime_Handle, nSArray.Handle, (ulong)performanceTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selPerformFeedback_PerformanceTime_Handle, nSArray.Handle, (ulong)performanceTime);
		}
		nSArray.Dispose();
	}

	[Export("updateWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("updateWithPanRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(NSPanGestureRecognizer panRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (panRecognizer == null)
		{
			throw new ArgumentNullException("panRecognizer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateWithPanRecognizer_Handle, panRecognizer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateWithPanRecognizer_Handle, panRecognizer.Handle);
		}
	}
}

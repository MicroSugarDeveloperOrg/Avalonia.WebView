using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMovieView", true)]
public class QTMovieView : NSView
{
	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	private static readonly IntPtr selSetMovie_Handle = Selector.GetHandle("setMovie:");

	private static readonly IntPtr selIsControllerVisibleHandle = Selector.GetHandle("isControllerVisible");

	private static readonly IntPtr selSetControllerVisible_Handle = Selector.GetHandle("setControllerVisible:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selControllerBarHeightHandle = Selector.GetHandle("controllerBarHeight");

	private static readonly IntPtr selPreservesAspectRatioHandle = Selector.GetHandle("preservesAspectRatio");

	private static readonly IntPtr selSetPreservesAspectRatio_Handle = Selector.GetHandle("setPreservesAspectRatio:");

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	private static readonly IntPtr selMovieBoundsHandle = Selector.GetHandle("movieBounds");

	private static readonly IntPtr selMovieControllerBoundsHandle = Selector.GetHandle("movieControllerBounds");

	private static readonly IntPtr selIsBackButtonVisibleHandle = Selector.GetHandle("isBackButtonVisible");

	private static readonly IntPtr selSetBackButtonVisible_Handle = Selector.GetHandle("setBackButtonVisible:");

	private static readonly IntPtr selIsCustomButtonVisibleHandle = Selector.GetHandle("isCustomButtonVisible");

	private static readonly IntPtr selSetCustomButtonVisible_Handle = Selector.GetHandle("setCustomButtonVisible:");

	private static readonly IntPtr selIsHotSpotButtonVisibleHandle = Selector.GetHandle("isHotSpotButtonVisible");

	private static readonly IntPtr selSetHotSpotButtonVisible_Handle = Selector.GetHandle("setHotSpotButtonVisible:");

	private static readonly IntPtr selAreStepButtonsVisibleHandle = Selector.GetHandle("areStepButtonsVisible");

	private static readonly IntPtr selSetStepButtonsVisible_Handle = Selector.GetHandle("setStepButtonsVisible:");

	private static readonly IntPtr selIsTranslateButtonVisibleHandle = Selector.GetHandle("isTranslateButtonVisible");

	private static readonly IntPtr selSetTranslateButtonVisible_Handle = Selector.GetHandle("setTranslateButtonVisible:");

	private static readonly IntPtr selIsVolumeButtonVisibleHandle = Selector.GetHandle("isVolumeButtonVisible");

	private static readonly IntPtr selSetVolumeButtonVisible_Handle = Selector.GetHandle("setVolumeButtonVisible:");

	private static readonly IntPtr selAreZoomButtonsVisibleHandle = Selector.GetHandle("areZoomButtonsVisible");

	private static readonly IntPtr selSetZoomButtonsVisible_Handle = Selector.GetHandle("setZoomButtonsVisible:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selSetShowsResizeIndicator_Handle = Selector.GetHandle("setShowsResizeIndicator:");

	private static readonly IntPtr selPlay_Handle = Selector.GetHandle("play:");

	private static readonly IntPtr selPause_Handle = Selector.GetHandle("pause:");

	private static readonly IntPtr selGotoBeginning_Handle = Selector.GetHandle("gotoBeginning:");

	private static readonly IntPtr selGotoEnd_Handle = Selector.GetHandle("gotoEnd:");

	private static readonly IntPtr selGotoNextSelectionPoint_Handle = Selector.GetHandle("gotoNextSelectionPoint:");

	private static readonly IntPtr selGotoPreviousSelectionPoint_Handle = Selector.GetHandle("gotoPreviousSelectionPoint:");

	private static readonly IntPtr selGotoPosterFrame_Handle = Selector.GetHandle("gotoPosterFrame:");

	private static readonly IntPtr selStepForward_Handle = Selector.GetHandle("stepForward:");

	private static readonly IntPtr selStepBackward_Handle = Selector.GetHandle("stepBackward:");

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selSelectNone_Handle = Selector.GetHandle("selectNone:");

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	private static readonly IntPtr selAddScaled_Handle = Selector.GetHandle("addScaled:");

	private static readonly IntPtr selReplace_Handle = Selector.GetHandle("replace:");

	private static readonly IntPtr selTrim_Handle = Selector.GetHandle("trim:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTMovieView");

	private object __mt_Movie_var;

	private object __mt_FillColor_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			return (QTMovie)(__mt_Movie_var = ((!IsDirectBinding) ? ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle))) : ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle)))));
		}
		[Export("setMovie:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovie_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovie_Handle, value.Handle);
			}
			__mt_Movie_var = value;
		}
	}

	public virtual bool IsControllerVisible
	{
		[Export("isControllerVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsControllerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsControllerVisibleHandle);
		}
		[Export("setControllerVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetControllerVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetControllerVisible_Handle, value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual float ControllerBarHeight
	{
		[Export("controllerBarHeight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selControllerBarHeightHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selControllerBarHeightHandle);
		}
	}

	public virtual bool PreservesAspectRatio
	{
		[Export("preservesAspectRatio")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesAspectRatioHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesAspectRatioHandle);
		}
		[Export("setPreservesAspectRatio:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesAspectRatio_Handle, value);
			}
		}
	}

	public virtual NSColor FillColor
	{
		[Export("fillColor")]
		get
		{
			return (NSColor)(__mt_FillColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle)))));
		}
		[Export("setFillColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
			__mt_FillColor_var = value;
		}
	}

	public virtual CGRect MovieBounds
	{
		[Export("movieBounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selMovieBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMovieBoundsHandle);
			}
			return retval;
		}
	}

	public virtual CGRect MovieControllerBounds
	{
		[Export("movieControllerBounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selMovieControllerBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMovieControllerBoundsHandle);
			}
			return retval;
		}
	}

	public virtual bool BackButtonVisible
	{
		[Export("isBackButtonVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBackButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBackButtonVisibleHandle);
		}
		[Export("setBackButtonVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBackButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBackButtonVisible_Handle, value);
			}
		}
	}

	public virtual bool CustomButtonVisible
	{
		[Export("isCustomButtonVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCustomButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCustomButtonVisibleHandle);
		}
		[Export("setCustomButtonVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCustomButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCustomButtonVisible_Handle, value);
			}
		}
	}

	public virtual bool HotSpotButtonVisible
	{
		[Export("isHotSpotButtonVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHotSpotButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHotSpotButtonVisibleHandle);
		}
		[Export("setHotSpotButtonVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHotSpotButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHotSpotButtonVisible_Handle, value);
			}
		}
	}

	public virtual bool SetStepButtonsVisible
	{
		[Export("areStepButtonsVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreStepButtonsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreStepButtonsVisibleHandle);
		}
		[Export("setStepButtonsVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStepButtonsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStepButtonsVisible_Handle, value);
			}
		}
	}

	public virtual bool TranslateButtonVisible
	{
		[Export("isTranslateButtonVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTranslateButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTranslateButtonVisibleHandle);
		}
		[Export("setTranslateButtonVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTranslateButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTranslateButtonVisible_Handle, value);
			}
		}
	}

	public virtual bool VolumeButtonVisible
	{
		[Export("isVolumeButtonVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVolumeButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVolumeButtonVisibleHandle);
		}
		[Export("setVolumeButtonVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVolumeButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVolumeButtonVisible_Handle, value);
			}
		}
	}

	public virtual bool ZoomButtonsVisible
	{
		[Export("areZoomButtonsVisible")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreZoomButtonsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreZoomButtonsVisibleHandle);
		}
		[Export("setZoomButtonsVisible:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZoomButtonsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZoomButtonsVisible_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public QTMovieViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as QTMovieViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovieView()
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
	public QTMovieView(NSCoder coder)
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
	public QTMovieView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTMovieView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setShowsResizeIndicator:")]
	public virtual void SetShowsResizeIndicator(bool show)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsResizeIndicator_Handle, show);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsResizeIndicator_Handle, show);
		}
	}

	[Export("play:")]
	public virtual void Play(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPlay_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPlay_Handle, sender.Handle);
		}
	}

	[Export("pause:")]
	public virtual void Pause(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPause_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPause_Handle, sender.Handle);
		}
	}

	[Export("gotoBeginning:")]
	public virtual void GotoBeginning(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoBeginning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoBeginning_Handle, sender.Handle);
		}
	}

	[Export("gotoEnd:")]
	public virtual void GotoEnd(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoEnd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoEnd_Handle, sender.Handle);
		}
	}

	[Export("gotoNextSelectionPoint:")]
	public virtual void GotoNextSelectionPoint(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoNextSelectionPoint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoNextSelectionPoint_Handle, sender.Handle);
		}
	}

	[Export("gotoPreviousSelectionPoint:")]
	public virtual void GotoPreviousSelectionPoint(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoPreviousSelectionPoint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoPreviousSelectionPoint_Handle, sender.Handle);
		}
	}

	[Export("gotoPosterFrame:")]
	public virtual void GotoPosterFrame(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoPosterFrame_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoPosterFrame_Handle, sender.Handle);
		}
	}

	[Export("stepForward:")]
	public virtual void StepForward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStepForward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStepForward_Handle, sender.Handle);
		}
	}

	[Export("stepBackward:")]
	public virtual void StepBackward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStepBackward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStepBackward_Handle, sender.Handle);
		}
	}

	[Export("cut:")]
	public virtual void Cut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("copy:")]
	public virtual void Copy(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender.Handle);
		}
	}

	[Export("paste:")]
	public virtual void Paste(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("selectAll:")]
	public virtual void SelectAll(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("selectNone:")]
	public virtual void SelectNone(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNone_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNone_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	public virtual void Delete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("add:")]
	public virtual void Add(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("addScaled:")]
	public virtual void AddScaled(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddScaled_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddScaled_Handle, sender.Handle);
		}
	}

	[Export("replace:")]
	public virtual void Replace(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplace_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplace_Handle, sender.Handle);
		}
	}

	[Export("trim:")]
	public virtual void Trim(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrim_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrim_Handle, sender.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Movie_var = null;
			__mt_FillColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

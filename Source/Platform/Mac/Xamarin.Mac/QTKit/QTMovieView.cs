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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdd_ = "add:";

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddScaled_ = "addScaled:";

	private static readonly IntPtr selAddScaled_Handle = Selector.GetHandle("addScaled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreStepButtonsVisible = "areStepButtonsVisible";

	private static readonly IntPtr selAreStepButtonsVisibleHandle = Selector.GetHandle("areStepButtonsVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAreZoomButtonsVisible = "areZoomButtonsVisible";

	private static readonly IntPtr selAreZoomButtonsVisibleHandle = Selector.GetHandle("areZoomButtonsVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControllerBarHeight = "controllerBarHeight";

	private static readonly IntPtr selControllerBarHeightHandle = Selector.GetHandle("controllerBarHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopy_ = "copy:";

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCut_ = "cut:";

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelete_ = "delete:";

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillColor = "fillColor";

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoBeginning_ = "gotoBeginning:";

	private static readonly IntPtr selGotoBeginning_Handle = Selector.GetHandle("gotoBeginning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoEnd_ = "gotoEnd:";

	private static readonly IntPtr selGotoEnd_Handle = Selector.GetHandle("gotoEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoNextSelectionPoint_ = "gotoNextSelectionPoint:";

	private static readonly IntPtr selGotoNextSelectionPoint_Handle = Selector.GetHandle("gotoNextSelectionPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoPosterFrame_ = "gotoPosterFrame:";

	private static readonly IntPtr selGotoPosterFrame_Handle = Selector.GetHandle("gotoPosterFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGotoPreviousSelectionPoint_ = "gotoPreviousSelectionPoint:";

	private static readonly IntPtr selGotoPreviousSelectionPoint_Handle = Selector.GetHandle("gotoPreviousSelectionPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBackButtonVisible = "isBackButtonVisible";

	private static readonly IntPtr selIsBackButtonVisibleHandle = Selector.GetHandle("isBackButtonVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsControllerVisible = "isControllerVisible";

	private static readonly IntPtr selIsControllerVisibleHandle = Selector.GetHandle("isControllerVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCustomButtonVisible = "isCustomButtonVisible";

	private static readonly IntPtr selIsCustomButtonVisibleHandle = Selector.GetHandle("isCustomButtonVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHotSpotButtonVisible = "isHotSpotButtonVisible";

	private static readonly IntPtr selIsHotSpotButtonVisibleHandle = Selector.GetHandle("isHotSpotButtonVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTranslateButtonVisible = "isTranslateButtonVisible";

	private static readonly IntPtr selIsTranslateButtonVisibleHandle = Selector.GetHandle("isTranslateButtonVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVolumeButtonVisible = "isVolumeButtonVisible";

	private static readonly IntPtr selIsVolumeButtonVisibleHandle = Selector.GetHandle("isVolumeButtonVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovie = "movie";

	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieBounds = "movieBounds";

	private static readonly IntPtr selMovieBoundsHandle = Selector.GetHandle("movieBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieControllerBounds = "movieControllerBounds";

	private static readonly IntPtr selMovieControllerBoundsHandle = Selector.GetHandle("movieControllerBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaste_ = "paste:";

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause_ = "pause:";

	private static readonly IntPtr selPause_Handle = Selector.GetHandle("pause:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay_ = "play:";

	private static readonly IntPtr selPlay_Handle = Selector.GetHandle("play:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesAspectRatio = "preservesAspectRatio";

	private static readonly IntPtr selPreservesAspectRatioHandle = Selector.GetHandle("preservesAspectRatio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplace_ = "replace:";

	private static readonly IntPtr selReplace_Handle = Selector.GetHandle("replace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNone_ = "selectNone:";

	private static readonly IntPtr selSelectNone_Handle = Selector.GetHandle("selectNone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackButtonVisible_ = "setBackButtonVisible:";

	private static readonly IntPtr selSetBackButtonVisible_Handle = Selector.GetHandle("setBackButtonVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControllerVisible_ = "setControllerVisible:";

	private static readonly IntPtr selSetControllerVisible_Handle = Selector.GetHandle("setControllerVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomButtonVisible_ = "setCustomButtonVisible:";

	private static readonly IntPtr selSetCustomButtonVisible_Handle = Selector.GetHandle("setCustomButtonVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillColor_ = "setFillColor:";

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHotSpotButtonVisible_ = "setHotSpotButtonVisible:";

	private static readonly IntPtr selSetHotSpotButtonVisible_Handle = Selector.GetHandle("setHotSpotButtonVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovie_ = "setMovie:";

	private static readonly IntPtr selSetMovie_Handle = Selector.GetHandle("setMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesAspectRatio_ = "setPreservesAspectRatio:";

	private static readonly IntPtr selSetPreservesAspectRatio_Handle = Selector.GetHandle("setPreservesAspectRatio:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsResizeIndicator_ = "setShowsResizeIndicator:";

	private static readonly IntPtr selSetShowsResizeIndicator_Handle = Selector.GetHandle("setShowsResizeIndicator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStepButtonsVisible_ = "setStepButtonsVisible:";

	private static readonly IntPtr selSetStepButtonsVisible_Handle = Selector.GetHandle("setStepButtonsVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTranslateButtonVisible_ = "setTranslateButtonVisible:";

	private static readonly IntPtr selSetTranslateButtonVisible_Handle = Selector.GetHandle("setTranslateButtonVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolumeButtonVisible_ = "setVolumeButtonVisible:";

	private static readonly IntPtr selSetVolumeButtonVisible_Handle = Selector.GetHandle("setVolumeButtonVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoomButtonsVisible_ = "setZoomButtonsVisible:";

	private static readonly IntPtr selSetZoomButtonsVisible_Handle = Selector.GetHandle("setZoomButtonsVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepBackward_ = "stepBackward:";

	private static readonly IntPtr selStepBackward_Handle = Selector.GetHandle("stepBackward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepForward_ = "stepForward:";

	private static readonly IntPtr selStepForward_Handle = Selector.GetHandle("stepForward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrim_ = "trim:";

	private static readonly IntPtr selTrim_Handle = Selector.GetHandle("trim:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTMovieView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BackButtonVisible
	{
		[Export("isBackButtonVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBackButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBackButtonVisibleHandle);
		}
		[Export("setBackButtonVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBackButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBackButtonVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ControllerBarHeight
	{
		[Export("controllerBarHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selControllerBarHeightHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selControllerBarHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CustomButtonVisible
	{
		[Export("isCustomButtonVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCustomButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCustomButtonVisibleHandle);
		}
		[Export("setCustomButtonVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCustomButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCustomButtonVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQTMovieViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IQTMovieViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor FillColor
	{
		[Export("fillColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle));
		}
		[Export("setFillColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HotSpotButtonVisible
	{
		[Export("isHotSpotButtonVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHotSpotButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHotSpotButtonVisibleHandle);
		}
		[Export("setHotSpotButtonVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHotSpotButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHotSpotButtonVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsControllerVisible
	{
		[Export("isControllerVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsControllerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsControllerVisibleHandle);
		}
		[Export("setControllerVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetControllerVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetControllerVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle));
			}
			return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle));
		}
		[Export("setMovie:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovie_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovie_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect MovieBounds
	{
		[Export("movieBounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect MovieControllerBounds
	{
		[Export("movieControllerBounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesAspectRatio
	{
		[Export("preservesAspectRatio")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesAspectRatioHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesAspectRatioHandle);
		}
		[Export("setPreservesAspectRatio:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesAspectRatio_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetStepButtonsVisible
	{
		[Export("areStepButtonsVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreStepButtonsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreStepButtonsVisibleHandle);
		}
		[Export("setStepButtonsVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStepButtonsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStepButtonsVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TranslateButtonVisible
	{
		[Export("isTranslateButtonVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTranslateButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTranslateButtonVisibleHandle);
		}
		[Export("setTranslateButtonVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTranslateButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTranslateButtonVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VolumeButtonVisible
	{
		[Export("isVolumeButtonVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVolumeButtonVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVolumeButtonVisibleHandle);
		}
		[Export("setVolumeButtonVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVolumeButtonVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVolumeButtonVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ZoomButtonsVisible
	{
		[Export("areZoomButtonsVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreZoomButtonsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreZoomButtonsVisibleHandle);
		}
		[Export("setZoomButtonsVisible:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZoomButtonsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZoomButtonsVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovieView()
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
	public QTMovieView(NSCoder coder)
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
	protected QTMovieView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTMovieView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovieView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("add:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("addScaled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddScaled(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddScaled_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddScaled_Handle, sender.Handle);
		}
	}

	[Export("copy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Copy(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender.Handle);
		}
	}

	[Export("cut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Delete(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("gotoBeginning:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoBeginning(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoBeginning_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoBeginning_Handle, sender.Handle);
		}
	}

	[Export("gotoEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoEnd(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoEnd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoEnd_Handle, sender.Handle);
		}
	}

	[Export("gotoNextSelectionPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoNextSelectionPoint(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoNextSelectionPoint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoNextSelectionPoint_Handle, sender.Handle);
		}
	}

	[Export("gotoPosterFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoPosterFrame(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoPosterFrame_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoPosterFrame_Handle, sender.Handle);
		}
	}

	[Export("gotoPreviousSelectionPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GotoPreviousSelectionPoint(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGotoPreviousSelectionPoint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGotoPreviousSelectionPoint_Handle, sender.Handle);
		}
	}

	[Export("paste:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Paste(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("pause:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pause(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPause_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPause_Handle, sender.Handle);
		}
	}

	[Export("play:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Play(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPlay_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPlay_Handle, sender.Handle);
		}
	}

	[Export("replace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Replace(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplace_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplace_Handle, sender.Handle);
		}
	}

	[Export("selectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("selectNone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNone(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNone_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNone_Handle, sender.Handle);
		}
	}

	[Export("setShowsResizeIndicator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetShowsResizeIndicator(bool show)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsResizeIndicator_Handle, show);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsResizeIndicator_Handle, show);
		}
	}

	[Export("stepBackward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StepBackward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStepBackward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStepBackward_Handle, sender.Handle);
		}
	}

	[Export("stepForward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StepForward(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStepForward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStepForward_Handle, sender.Handle);
		}
	}

	[Export("trim:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Trim(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrim_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrim_Handle, sender.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

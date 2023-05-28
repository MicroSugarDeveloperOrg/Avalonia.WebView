using System;
using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageView", true)]
public class IKImageView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutohidesScrollers = "autohidesScrollers";

	private static readonly IntPtr selAutohidesScrollersHandle = Selector.GetHandle("autohidesScrollers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoresizes = "autoresizes";

	private static readonly IntPtr selAutoresizesHandle = Selector.GetHandle("autoresizes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertImagePointToViewPoint_ = "convertImagePointToViewPoint:";

	private static readonly IntPtr selConvertImagePointToViewPoint_Handle = Selector.GetHandle("convertImagePointToViewPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertImageRectToViewRect_ = "convertImageRectToViewRect:";

	private static readonly IntPtr selConvertImageRectToViewRect_Handle = Selector.GetHandle("convertImageRectToViewRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertViewPointToImagePoint_ = "convertViewPointToImagePoint:";

	private static readonly IntPtr selConvertViewPointToImagePoint_Handle = Selector.GetHandle("convertViewPointToImagePoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertViewRectToImageRect_ = "convertViewRectToImageRect:";

	private static readonly IntPtr selConvertViewRectToImageRect_Handle = Selector.GetHandle("convertViewRectToImageRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCrop_ = "crop:";

	private static readonly IntPtr selCrop_Handle = Selector.GetHandle("crop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentToolMode = "currentToolMode";

	private static readonly IntPtr selCurrentToolModeHandle = Selector.GetHandle("currentToolMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleClickOpensImageEditPanel = "doubleClickOpensImageEditPanel";

	private static readonly IntPtr selDoubleClickOpensImageEditPanelHandle = Selector.GetHandle("doubleClickOpensImageEditPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditable = "editable";

	private static readonly IntPtr selEditableHandle = Selector.GetHandle("editable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipImageHorizontal_ = "flipImageHorizontal:";

	private static readonly IntPtr selFlipImageHorizontal_Handle = Selector.GetHandle("flipImageHorizontal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipImageVertical_ = "flipImageVertical:";

	private static readonly IntPtr selFlipImageVertical_Handle = Selector.GetHandle("flipImageVertical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasHorizontalScroller = "hasHorizontalScroller";

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasVerticalScroller = "hasVerticalScroller";

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageCorrection = "imageCorrection";

	private static readonly IntPtr selImageCorrectionHandle = Selector.GetHandle("imageCorrection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageProperties = "imageProperties";

	private static readonly IntPtr selImagePropertiesHandle = Selector.GetHandle("imageProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSize = "imageSize";

	private static readonly IntPtr selImageSizeHandle = Selector.GetHandle("imageSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlayForType_ = "overlayForType:";

	private static readonly IntPtr selOverlayForType_Handle = Selector.GetHandle("overlayForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateImageLeft_ = "rotateImageLeft:";

	private static readonly IntPtr selRotateImageLeft_Handle = Selector.GetHandle("rotateImageLeft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateImageRight_ = "rotateImageRight:";

	private static readonly IntPtr selRotateImageRight_Handle = Selector.GetHandle("rotateImageRight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationAngle = "rotationAngle";

	private static readonly IntPtr selRotationAngleHandle = Selector.GetHandle("rotationAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollToPoint_ = "scrollToPoint:";

	private static readonly IntPtr selScrollToPoint_Handle = Selector.GetHandle("scrollToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollToRect_ = "scrollToRect:";

	private static readonly IntPtr selScrollToRect_Handle = Selector.GetHandle("scrollToRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutohidesScrollers_ = "setAutohidesScrollers:";

	private static readonly IntPtr selSetAutohidesScrollers_Handle = Selector.GetHandle("setAutohidesScrollers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoresizes_ = "setAutoresizes:";

	private static readonly IntPtr selSetAutoresizes_Handle = Selector.GetHandle("setAutoresizes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentToolMode_ = "setCurrentToolMode:";

	private static readonly IntPtr selSetCurrentToolMode_Handle = Selector.GetHandle("setCurrentToolMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleClickOpensImageEditPanel_ = "setDoubleClickOpensImageEditPanel:";

	private static readonly IntPtr selSetDoubleClickOpensImageEditPanel_Handle = Selector.GetHandle("setDoubleClickOpensImageEditPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasHorizontalScroller_ = "setHasHorizontalScroller:";

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasVerticalScroller_ = "setHasVerticalScroller:";

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ImageProperties_ = "setImage:imageProperties:";

	private static readonly IntPtr selSetImage_ImageProperties_Handle = Selector.GetHandle("setImage:imageProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageCorrection_ = "setImageCorrection:";

	private static readonly IntPtr selSetImageCorrection_Handle = Selector.GetHandle("setImageCorrection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageWithURL_ = "setImageWithURL:";

	private static readonly IntPtr selSetImageWithURL_Handle = Selector.GetHandle("setImageWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageZoomFactor_CenterPoint_ = "setImageZoomFactor:centerPoint:";

	private static readonly IntPtr selSetImageZoomFactor_CenterPoint_Handle = Selector.GetHandle("setImageZoomFactor:centerPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverlay_ForType_ = "setOverlay:forType:";

	private static readonly IntPtr selSetOverlay_ForType_Handle = Selector.GetHandle("setOverlay:forType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationAngle_ = "setRotationAngle:";

	private static readonly IntPtr selSetRotationAngle_Handle = Selector.GetHandle("setRotationAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationAngle_CenterPoint_ = "setRotationAngle:centerPoint:";

	private static readonly IntPtr selSetRotationAngle_CenterPoint_Handle = Selector.GetHandle("setRotationAngle:centerPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportsDragAndDrop_ = "setSupportsDragAndDrop:";

	private static readonly IntPtr selSetSupportsDragAndDrop_Handle = Selector.GetHandle("setSupportsDragAndDrop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoomFactor_ = "setZoomFactor:";

	private static readonly IntPtr selSetZoomFactor_Handle = Selector.GetHandle("setZoomFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsDragAndDrop = "supportsDragAndDrop";

	private static readonly IntPtr selSupportsDragAndDropHandle = Selector.GetHandle("supportsDragAndDrop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomFactor = "zoomFactor";

	private static readonly IntPtr selZoomFactorHandle = Selector.GetHandle("zoomFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomImageToActualSize_ = "zoomImageToActualSize:";

	private static readonly IntPtr selZoomImageToActualSize_Handle = Selector.GetHandle("zoomImageToActualSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomImageToFit_ = "zoomImageToFit:";

	private static readonly IntPtr selZoomImageToFit_Handle = Selector.GetHandle("zoomImageToFit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomImageToRect_ = "zoomImageToRect:";

	private static readonly IntPtr selZoomImageToRect_Handle = Selector.GetHandle("zoomImageToRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomIn_ = "zoomIn:";

	private static readonly IntPtr selZoomIn_Handle = Selector.GetHandle("zoomIn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomOut_ = "zoomOut:";

	private static readonly IntPtr selZoomOut_Handle = Selector.GetHandle("zoomOut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKImageView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_BackgroundColor_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ImageCorrection_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutohidesScrollers
	{
		[Export("autohidesScrollers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollersHandle);
		}
		[Export("setAutohidesScrollers:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScrollers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScrollers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autoresizes
	{
		[Export("autoresizes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesHandle);
		}
		[Export("setAutoresizes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Assign)]
		get
		{
			NSColor nSColor = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle)) : Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)));
			MarkDirty();
			__mt_BackgroundColor_var = nSColor;
			return nSColor;
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			MarkDirty();
			__mt_BackgroundColor_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrentToolMode
	{
		[Export("currentToolMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentToolModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentToolModeHandle));
		}
		[Export("setCurrentToolMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentToolMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentToolMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_Delegate_var = nSObject;
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
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoubleClickOpensImageEditPanel
	{
		[Export("doubleClickOpensImageEditPanel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDoubleClickOpensImageEditPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDoubleClickOpensImageEditPanelHandle);
		}
		[Export("setDoubleClickOpensImageEditPanel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoubleClickOpensImageEditPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoubleClickOpensImageEditPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Editable
	{
		[Export("editable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEditableHandle);
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
	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage Image
	{
		[Export("image")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter ImageCorrection
	{
		[Export("imageCorrection", ArgumentSemantic.Assign)]
		get
		{
			CIFilter cIFilter = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageCorrectionHandle)) : Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageCorrectionHandle)));
			MarkDirty();
			__mt_ImageCorrection_var = cIFilter;
			return cIFilter;
		}
		[Export("setImageCorrection:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageCorrection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageCorrection_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ImageCorrection_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selImagePropertiesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagePropertiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ImageSize
	{
		[Export("imageSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selImageSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selImageSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RotationAngle
	{
		[Export("rotationAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRotationAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRotationAngleHandle);
		}
		[Export("setRotationAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRotationAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRotationAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsDragAndDrop
	{
		[Export("supportsDragAndDrop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsDragAndDropHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsDragAndDropHandle);
		}
		[Export("setSupportsDragAndDrop:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupportsDragAndDrop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupportsDragAndDrop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ZoomFactor
	{
		[Export("zoomFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZoomFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZoomFactorHandle);
		}
		[Export("setZoomFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetZoomFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetZoomFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageView()
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
	public IKImageView(NSCoder coder)
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
	protected IKImageView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKImageView(CGRect frameRect)
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

	[Export("convertImagePointToViewPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertImagePointToViewPoint(CGPoint imagePoint)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertImagePointToViewPoint_Handle, imagePoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertImagePointToViewPoint_Handle, imagePoint);
	}

	[Export("convertImageRectToViewRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertImageRectToViewRect(CGRect imageRect)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertImageRectToViewRect_Handle, imageRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertImageRectToViewRect_Handle, imageRect);
		}
		return retval;
	}

	[Export("convertViewPointToImagePoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertViewPointToImagePoint(CGPoint viewPoint)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertViewPointToImagePoint_Handle, viewPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertViewPointToImagePoint_Handle, viewPoint);
	}

	[Export("convertViewRectToImageRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertViewRectToImageRect(CGRect viewRect)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertViewRectToImageRect_Handle, viewRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertViewRectToImageRect_Handle, viewRect);
		}
		return retval;
	}

	[Export("crop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Crop(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCrop_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCrop_Handle, sender.Handle);
		}
	}

	[Export("flipImageHorizontal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlipImageHorizontal(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlipImageHorizontal_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlipImageHorizontal_Handle, sender.Handle);
		}
	}

	[Export("flipImageVertical:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlipImageVertical(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlipImageVertical_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlipImageVertical_Handle, sender.Handle);
		}
	}

	[Export("overlayForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer GetOverlay(string layerType)
	{
		if (layerType == null)
		{
			throw new ArgumentNullException("layerType");
		}
		IntPtr arg = NSString.CreateNative(layerType);
		CALayer result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOverlayForType_Handle, arg)) : Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOverlayForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("rotateImageLeft:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateImageLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateImageLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateImageLeft_Handle, sender.Handle);
		}
	}

	[Export("rotateImageRight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateImageRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateImageRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateImageRight_Handle, sender.Handle);
		}
	}

	[Export("scrollToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollTo(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollToPoint_Handle, point);
		}
	}

	[Export("scrollToRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollTo(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollToRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollToRect_Handle, rect);
		}
	}

	[Export("setImageWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageWithURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageWithURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageWithURL_Handle, url.Handle);
		}
	}

	[Export("setImageZoomFactor:centerPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageZoomFactor(nfloat zoomFactor, CGPoint centerPoint)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_CGPoint(base.Handle, selSetImageZoomFactor_CenterPoint_Handle, zoomFactor, centerPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_CGPoint(base.SuperHandle, selSetImageZoomFactor_CenterPoint_Handle, zoomFactor, centerPoint);
		}
	}

	[Export("setImage:imageProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageimageProperties(CGImage image, NSDictionary metaData)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (metaData == null)
		{
			throw new ArgumentNullException("metaData");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetImage_ImageProperties_Handle, image.Handle, metaData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetImage_ImageProperties_Handle, image.Handle, metaData.Handle);
		}
	}

	[Export("setOverlay:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOverlay(CALayer layer, string layerType)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (layerType == null)
		{
			throw new ArgumentNullException("layerType");
		}
		IntPtr arg = NSString.CreateNative(layerType);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetOverlay_ForType_Handle, layer.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetOverlay_ForType_Handle, layer.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setRotationAngle:centerPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRotation(nfloat rotationAngle, CGPoint centerPoint)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_CGPoint(base.Handle, selSetRotationAngle_CenterPoint_Handle, rotationAngle, centerPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_CGPoint(base.SuperHandle, selSetRotationAngle_CenterPoint_Handle, rotationAngle, centerPoint);
		}
	}

	[Export("zoomImageToActualSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomImageToActualSize(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomImageToActualSize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomImageToActualSize_Handle, sender.Handle);
		}
	}

	[Export("zoomImageToFit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomImageToFit(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomImageToFit_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomImageToFit_Handle, sender.Handle);
		}
	}

	[Export("zoomImageToRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomImageToRect(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selZoomImageToRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selZoomImageToRect_Handle, rect);
		}
	}

	[Export("zoomIn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomIn(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomIn_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomIn_Handle, sender.Handle);
		}
	}

	[Export("zoomOut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ZoomOut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomOut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomOut_Handle, sender.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
			__mt_Delegate_var = null;
			__mt_ImageCorrection_var = null;
		}
	}
}

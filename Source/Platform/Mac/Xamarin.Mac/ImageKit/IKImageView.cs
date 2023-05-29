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
	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selZoomFactorHandle = Selector.GetHandle("zoomFactor");

	private static readonly IntPtr selSetZoomFactor_Handle = Selector.GetHandle("setZoomFactor:");

	private static readonly IntPtr selRotationAngleHandle = Selector.GetHandle("rotationAngle");

	private static readonly IntPtr selSetRotationAngle_Handle = Selector.GetHandle("setRotationAngle:");

	private static readonly IntPtr selCurrentToolModeHandle = Selector.GetHandle("currentToolMode");

	private static readonly IntPtr selSetCurrentToolMode_Handle = Selector.GetHandle("setCurrentToolMode:");

	private static readonly IntPtr selAutoresizesHandle = Selector.GetHandle("autoresizes");

	private static readonly IntPtr selSetAutoresizes_Handle = Selector.GetHandle("setAutoresizes:");

	private static readonly IntPtr selHasHorizontalScrollerHandle = Selector.GetHandle("hasHorizontalScroller");

	private static readonly IntPtr selSetHasHorizontalScroller_Handle = Selector.GetHandle("setHasHorizontalScroller:");

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	private static readonly IntPtr selAutohidesScrollersHandle = Selector.GetHandle("autohidesScrollers");

	private static readonly IntPtr selSetAutohidesScrollers_Handle = Selector.GetHandle("setAutohidesScrollers:");

	private static readonly IntPtr selSupportsDragAndDropHandle = Selector.GetHandle("supportsDragAndDrop");

	private static readonly IntPtr selSetSupportsDragAndDrop_Handle = Selector.GetHandle("setSupportsDragAndDrop:");

	private static readonly IntPtr selEditableHandle = Selector.GetHandle("editable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selDoubleClickOpensImageEditPanelHandle = Selector.GetHandle("doubleClickOpensImageEditPanel");

	private static readonly IntPtr selSetDoubleClickOpensImageEditPanel_Handle = Selector.GetHandle("setDoubleClickOpensImageEditPanel:");

	private static readonly IntPtr selImageCorrectionHandle = Selector.GetHandle("imageCorrection");

	private static readonly IntPtr selSetImageCorrection_Handle = Selector.GetHandle("setImageCorrection:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selImageSizeHandle = Selector.GetHandle("imageSize");

	private static readonly IntPtr selImagePropertiesHandle = Selector.GetHandle("imageProperties");

	private static readonly IntPtr selSetImageImageProperties_Handle = Selector.GetHandle("setImage:imageProperties:");

	private static readonly IntPtr selSetImageWithURL_Handle = Selector.GetHandle("setImageWithURL:");

	private static readonly IntPtr selSetRotationAngleCenterPoint_Handle = Selector.GetHandle("setRotationAngle:centerPoint:");

	private static readonly IntPtr selRotateImageLeft_Handle = Selector.GetHandle("rotateImageLeft:");

	private static readonly IntPtr selRotateImageRight_Handle = Selector.GetHandle("rotateImageRight:");

	private static readonly IntPtr selSetImageZoomFactorCenterPoint_Handle = Selector.GetHandle("setImageZoomFactor:centerPoint:");

	private static readonly IntPtr selZoomImageToRect_Handle = Selector.GetHandle("zoomImageToRect:");

	private static readonly IntPtr selZoomImageToFit_Handle = Selector.GetHandle("zoomImageToFit:");

	private static readonly IntPtr selZoomImageToActualSize_Handle = Selector.GetHandle("zoomImageToActualSize:");

	private static readonly IntPtr selZoomIn_Handle = Selector.GetHandle("zoomIn:");

	private static readonly IntPtr selZoomOut_Handle = Selector.GetHandle("zoomOut:");

	private static readonly IntPtr selFlipImageHorizontal_Handle = Selector.GetHandle("flipImageHorizontal:");

	private static readonly IntPtr selFlipImageVertical_Handle = Selector.GetHandle("flipImageVertical:");

	private static readonly IntPtr selCrop_Handle = Selector.GetHandle("crop:");

	private static readonly IntPtr selSetOverlayForType_Handle = Selector.GetHandle("setOverlay:forType:");

	private static readonly IntPtr selOverlayForType_Handle = Selector.GetHandle("overlayForType:");

	private static readonly IntPtr selScrollToPoint_Handle = Selector.GetHandle("scrollToPoint:");

	private static readonly IntPtr selScrollToRect_Handle = Selector.GetHandle("scrollToRect:");

	private static readonly IntPtr selConvertViewPointToImagePoint_Handle = Selector.GetHandle("convertViewPointToImagePoint:");

	private static readonly IntPtr selConvertViewRectToImageRect_Handle = Selector.GetHandle("convertViewRectToImageRect:");

	private static readonly IntPtr selConvertImagePointToViewPoint_Handle = Selector.GetHandle("convertImagePointToViewPoint:");

	private static readonly IntPtr selConvertImageRectToViewRect_Handle = Selector.GetHandle("convertImageRectToViewRect:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKImageView");

	private object __mt_Delegate_var;

	private object __mt_ImageCorrection_var;

	private object __mt_BackgroundColor_var;

	private object __mt_ImageProperties_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_Delegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
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
			__mt_Delegate_var = value;
		}
	}

	public virtual double ZoomFactor
	{
		[Export("zoomFactor")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selZoomFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selZoomFactorHandle);
		}
		[Export("setZoomFactor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetZoomFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetZoomFactor_Handle, value);
			}
		}
	}

	public virtual double RotationAngle
	{
		[Export("rotationAngle")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRotationAngleHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRotationAngleHandle);
		}
		[Export("setRotationAngle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRotationAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRotationAngle_Handle, value);
			}
		}
	}

	public virtual string CurrentToolMode
	{
		[Export("currentToolMode")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool Autoresizes
	{
		[Export("autoresizes")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesHandle);
		}
		[Export("setAutoresizes:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizes_Handle, value);
			}
		}
	}

	public virtual bool HasHorizontalScroller
	{
		[Export("hasHorizontalScroller")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasHorizontalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasHorizontalScrollerHandle);
		}
		[Export("setHasHorizontalScroller:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasHorizontalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasHorizontalScroller_Handle, value);
			}
		}
	}

	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	public virtual bool AutohidesScrollers
	{
		[Export("autohidesScrollers")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutohidesScrollersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutohidesScrollersHandle);
		}
		[Export("setAutohidesScrollers:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutohidesScrollers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutohidesScrollers_Handle, value);
			}
		}
	}

	public virtual bool SupportsDragAndDrop
	{
		[Export("supportsDragAndDrop")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsDragAndDropHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsDragAndDropHandle);
		}
		[Export("setSupportsDragAndDrop:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupportsDragAndDrop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupportsDragAndDrop_Handle, value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("editable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEditableHandle);
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

	public virtual bool DoubleClickOpensImageEditPanel
	{
		[Export("doubleClickOpensImageEditPanel")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDoubleClickOpensImageEditPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDoubleClickOpensImageEditPanelHandle);
		}
		[Export("setDoubleClickOpensImageEditPanel:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoubleClickOpensImageEditPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoubleClickOpensImageEditPanel_Handle, value);
			}
		}
	}

	public virtual CIFilter ImageCorrection
	{
		[Export("imageCorrection", ArgumentSemantic.Assign)]
		get
		{
			return (CIFilter)(__mt_ImageCorrection_var = ((!IsDirectBinding) ? ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageCorrectionHandle))) : ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageCorrectionHandle)))));
		}
		[Export("setImageCorrection:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageCorrection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageCorrection_Handle, value.Handle);
			}
			__mt_ImageCorrection_var = value;
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Assign)]
		get
		{
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual CGImage Image
	{
		[Export("image")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGImage(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return new CGImage(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	public virtual CGSize ImageSize
	{
		[Export("imageSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selImageSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selImageSizeHandle);
		}
	}

	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			return (NSDictionary)(__mt_ImageProperties_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagePropertiesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImagePropertiesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageView()
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
	public IKImageView(NSCoder coder)
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
	public IKImageView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setImage:imageProperties:")]
	public virtual void SetImageimageProperties(CGImage image, NSDictionary metaData)
	{
		if (metaData == null)
		{
			throw new ArgumentNullException("metaData");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetImageImageProperties_Handle, image.Handle, metaData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetImageImageProperties_Handle, image.Handle, metaData.Handle);
		}
	}

	[Export("setImageWithURL:")]
	public virtual void SetImageWithURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageWithURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageWithURL_Handle, url.Handle);
		}
	}

	[Export("setRotationAngle:centerPoint:")]
	public virtual void SetRotation(double rotationAngle, CGPoint centerPoint)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_CGPoint(base.Handle, selSetRotationAngleCenterPoint_Handle, rotationAngle, centerPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_CGPoint(base.SuperHandle, selSetRotationAngleCenterPoint_Handle, rotationAngle, centerPoint);
		}
	}

	[Export("rotateImageLeft:")]
	public virtual void RotateImageLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateImageLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateImageLeft_Handle, sender.Handle);
		}
	}

	[Export("rotateImageRight:")]
	public virtual void RotateImageRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateImageRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateImageRight_Handle, sender.Handle);
		}
	}

	[Export("setImageZoomFactor:centerPoint:")]
	public virtual void SetImageZoomFactor(double zoomFactor, CGPoint centerPoint)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_CGPoint(base.Handle, selSetImageZoomFactorCenterPoint_Handle, zoomFactor, centerPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_CGPoint(base.SuperHandle, selSetImageZoomFactorCenterPoint_Handle, zoomFactor, centerPoint);
		}
	}

	[Export("zoomImageToRect:")]
	public virtual void ZoomImageToRect(CGRect rect)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selZoomImageToRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selZoomImageToRect_Handle, rect);
		}
	}

	[Export("zoomImageToFit:")]
	public virtual void ZoomImageToFit(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomImageToFit_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomImageToFit_Handle, sender.Handle);
		}
	}

	[Export("zoomImageToActualSize:")]
	public virtual void ZoomImageToActualSize(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomImageToActualSize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomImageToActualSize_Handle, sender.Handle);
		}
	}

	[Export("zoomIn:")]
	public virtual void ZoomIn(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomIn_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomIn_Handle, sender.Handle);
		}
	}

	[Export("zoomOut:")]
	public virtual void ZoomOut(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoomOut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoomOut_Handle, sender.Handle);
		}
	}

	[Export("flipImageHorizontal:")]
	public virtual void FlipImageHorizontal(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlipImageHorizontal_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlipImageHorizontal_Handle, sender.Handle);
		}
	}

	[Export("flipImageVertical:")]
	public virtual void FlipImageVertical(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlipImageVertical_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlipImageVertical_Handle, sender.Handle);
		}
	}

	[Export("crop:")]
	public virtual void Crop(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCrop_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCrop_Handle, sender.Handle);
		}
	}

	[Export("setOverlay:forType:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetOverlayForType_Handle, layer.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetOverlayForType_Handle, layer.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("overlayForType:")]
	public virtual CALayer GetOverlay(string layerType)
	{
		if (layerType == null)
		{
			throw new ArgumentNullException("layerType");
		}
		IntPtr arg = NSString.CreateNative(layerType);
		CALayer result = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOverlayForType_Handle, arg))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOverlayForType_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("scrollToPoint:")]
	public virtual void ScrollTo(CGPoint point)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollToPoint_Handle, point);
		}
	}

	[Export("scrollToRect:")]
	public virtual void ScrollTo(CGRect rect)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollToRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollToRect_Handle, rect);
		}
	}

	[Export("convertViewPointToImagePoint:")]
	public virtual CGPoint ConvertViewPointToImagePoint(CGPoint viewPoint)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertViewPointToImagePoint_Handle, viewPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertViewPointToImagePoint_Handle, viewPoint);
	}

	[Export("convertViewRectToImageRect:")]
	public virtual CGRect ConvertViewRectToImageRect(CGRect viewRect)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertViewRectToImageRect_Handle, viewRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertViewRectToImageRect_Handle, viewRect);
		}
		return retval;
	}

	[Export("convertImagePointToViewPoint:")]
	public virtual CGPoint ConvertImagePointToViewPoint(CGPoint imagePoint)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertImagePointToViewPoint_Handle, imagePoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertImagePointToViewPoint_Handle, imagePoint);
	}

	[Export("convertImageRectToViewRect:")]
	public virtual CGRect ConvertImageRectToViewRect(CGRect imageRect)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertImageRectToViewRect_Handle, imageRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertImageRectToViewRect_Handle, imageRect);
		}
		return retval;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
			__mt_ImageCorrection_var = null;
			__mt_BackgroundColor_var = null;
			__mt_ImageProperties_var = null;
		}
	}
}

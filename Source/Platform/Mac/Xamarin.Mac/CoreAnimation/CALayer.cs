using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CALayer", true)]
public class CALayer : NSObject
{
	private const string selInitWithLayer = "initWithLayer:";

	private static readonly IntPtr selPresentationLayerHandle = Selector.GetHandle("presentationLayer");

	private static readonly IntPtr selModelLayerHandle = Selector.GetHandle("modelLayer");

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	private static readonly IntPtr selZPositionHandle = Selector.GetHandle("zPosition");

	private static readonly IntPtr selSetZPosition_Handle = Selector.GetHandle("setZPosition:");

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	private static readonly IntPtr selAnchorPointZHandle = Selector.GetHandle("anchorPointZ");

	private static readonly IntPtr selSetAnchorPointZ_Handle = Selector.GetHandle("setAnchorPointZ:");

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	private static readonly IntPtr selAffineTransformHandle = Selector.GetHandle("affineTransform");

	private static readonly IntPtr selSetAffineTransform_Handle = Selector.GetHandle("setAffineTransform:");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	private static readonly IntPtr selIsDoubleSidedHandle = Selector.GetHandle("isDoubleSided");

	private static readonly IntPtr selSetDoubleSided_Handle = Selector.GetHandle("setDoubleSided:");

	private static readonly IntPtr selIsGeometryFlippedHandle = Selector.GetHandle("isGeometryFlipped");

	private static readonly IntPtr selSetGeometryFlipped_Handle = Selector.GetHandle("setGeometryFlipped:");

	private static readonly IntPtr selContentsAreFlippedHandle = Selector.GetHandle("contentsAreFlipped");

	private static readonly IntPtr selSuperlayerHandle = Selector.GetHandle("superlayer");

	private static readonly IntPtr selSublayersHandle = Selector.GetHandle("sublayers");

	private static readonly IntPtr selSetSublayers_Handle = Selector.GetHandle("setSublayers:");

	private static readonly IntPtr selSublayerTransformHandle = Selector.GetHandle("sublayerTransform");

	private static readonly IntPtr selSetSublayerTransform_Handle = Selector.GetHandle("setSublayerTransform:");

	private static readonly IntPtr selMaskHandle = Selector.GetHandle("mask");

	private static readonly IntPtr selSetMask_Handle = Selector.GetHandle("setMask:");

	private static readonly IntPtr selMasksToBoundsHandle = Selector.GetHandle("masksToBounds");

	private static readonly IntPtr selSetMasksToBounds_Handle = Selector.GetHandle("setMasksToBounds:");

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	private static readonly IntPtr selSetLayoutManager_Handle = Selector.GetHandle("setLayoutManager:");

	private static readonly IntPtr selContentsScaleHandle = Selector.GetHandle("contentsScale");

	private static readonly IntPtr selSetContentsScale_Handle = Selector.GetHandle("setContentsScale:");

	private static readonly IntPtr selContentsRectHandle = Selector.GetHandle("contentsRect");

	private static readonly IntPtr selSetContentsRect_Handle = Selector.GetHandle("setContentsRect:");

	private static readonly IntPtr selContentsGravityHandle = Selector.GetHandle("contentsGravity");

	private static readonly IntPtr selSetContentsGravity_Handle = Selector.GetHandle("setContentsGravity:");

	private static readonly IntPtr selContentsCenterHandle = Selector.GetHandle("contentsCenter");

	private static readonly IntPtr selSetContentsCenter_Handle = Selector.GetHandle("setContentsCenter:");

	private static readonly IntPtr selMinificationFilterHandle = Selector.GetHandle("minificationFilter");

	private static readonly IntPtr selSetMinificationFilter_Handle = Selector.GetHandle("setMinificationFilter:");

	private static readonly IntPtr selMagnificationFilterHandle = Selector.GetHandle("magnificationFilter");

	private static readonly IntPtr selSetMagnificationFilter_Handle = Selector.GetHandle("setMagnificationFilter:");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	private static readonly IntPtr selNeedsDisplayOnBoundsChangeHandle = Selector.GetHandle("needsDisplayOnBoundsChange");

	private static readonly IntPtr selSetNeedsDisplayOnBoundsChange_Handle = Selector.GetHandle("setNeedsDisplayOnBoundsChange:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selCornerRadiusHandle = Selector.GetHandle("cornerRadius");

	private static readonly IntPtr selSetCornerRadius_Handle = Selector.GetHandle("setCornerRadius:");

	private static readonly IntPtr selBorderWidthHandle = Selector.GetHandle("borderWidth");

	private static readonly IntPtr selSetBorderWidth_Handle = Selector.GetHandle("setBorderWidth:");

	private static readonly IntPtr selBorderColorHandle = Selector.GetHandle("borderColor");

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	private static readonly IntPtr selOpacityHandle = Selector.GetHandle("opacity");

	private static readonly IntPtr selSetOpacity_Handle = Selector.GetHandle("setOpacity:");

	private static readonly IntPtr selEdgeAntialiasingMaskHandle = Selector.GetHandle("edgeAntialiasingMask");

	private static readonly IntPtr selSetEdgeAntialiasingMask_Handle = Selector.GetHandle("setEdgeAntialiasingMask:");

	private static readonly IntPtr selActionsHandle = Selector.GetHandle("actions");

	private static readonly IntPtr selSetActions_Handle = Selector.GetHandle("setActions:");

	private static readonly IntPtr selAnimationKeysHandle = Selector.GetHandle("animationKeys");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selBeginTimeHandle = Selector.GetHandle("beginTime");

	private static readonly IntPtr selSetBeginTime_Handle = Selector.GetHandle("setBeginTime:");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	private static readonly IntPtr selTimeOffsetHandle = Selector.GetHandle("timeOffset");

	private static readonly IntPtr selSetTimeOffset_Handle = Selector.GetHandle("setTimeOffset:");

	private static readonly IntPtr selRepeatCountHandle = Selector.GetHandle("repeatCount");

	private static readonly IntPtr selSetRepeatCount_Handle = Selector.GetHandle("setRepeatCount:");

	private static readonly IntPtr selRepeatDurationHandle = Selector.GetHandle("repeatDuration");

	private static readonly IntPtr selSetRepeatDuration_Handle = Selector.GetHandle("setRepeatDuration:");

	private static readonly IntPtr selAutoreversesHandle = Selector.GetHandle("autoreverses");

	private static readonly IntPtr selSetAutoreverses_Handle = Selector.GetHandle("setAutoreverses:");

	private static readonly IntPtr selFillModeHandle = Selector.GetHandle("fillMode");

	private static readonly IntPtr selSetFillMode_Handle = Selector.GetHandle("setFillMode:");

	private static readonly IntPtr selShadowColorHandle = Selector.GetHandle("shadowColor");

	private static readonly IntPtr selSetShadowColor_Handle = Selector.GetHandle("setShadowColor:");

	private static readonly IntPtr selShadowOffsetHandle = Selector.GetHandle("shadowOffset");

	private static readonly IntPtr selSetShadowOffset_Handle = Selector.GetHandle("setShadowOffset:");

	private static readonly IntPtr selShadowOpacityHandle = Selector.GetHandle("shadowOpacity");

	private static readonly IntPtr selSetShadowOpacity_Handle = Selector.GetHandle("setShadowOpacity:");

	private static readonly IntPtr selShadowRadiusHandle = Selector.GetHandle("shadowRadius");

	private static readonly IntPtr selSetShadowRadius_Handle = Selector.GetHandle("setShadowRadius:");

	private static readonly IntPtr selVisibleRectHandle = Selector.GetHandle("visibleRect");

	private static readonly IntPtr selAutoresizingMaskHandle = Selector.GetHandle("autoresizingMask");

	private static readonly IntPtr selSetAutoresizingMask_Handle = Selector.GetHandle("setAutoresizingMask:");

	private static readonly IntPtr selConstraintsHandle = Selector.GetHandle("constraints");

	private static readonly IntPtr selSetConstraints_Handle = Selector.GetHandle("setConstraints:");

	private static readonly IntPtr selFiltersHandle = Selector.GetHandle("filters");

	private static readonly IntPtr selSetFilters_Handle = Selector.GetHandle("setFilters:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr selDefaultValueForKey_Handle = Selector.GetHandle("defaultValueForKey:");

	private static readonly IntPtr selNeedsDisplayForKey_Handle = Selector.GetHandle("needsDisplayForKey:");

	private static readonly IntPtr selRemoveFromSuperlayerHandle = Selector.GetHandle("removeFromSuperlayer");

	private static readonly IntPtr selAddSublayer_Handle = Selector.GetHandle("addSublayer:");

	private static readonly IntPtr selInsertSublayerAtIndex_Handle = Selector.GetHandle("insertSublayer:atIndex:");

	private static readonly IntPtr selInsertSublayerBelow_Handle = Selector.GetHandle("insertSublayer:below:");

	private static readonly IntPtr selInsertSublayerAbove_Handle = Selector.GetHandle("insertSublayer:above:");

	private static readonly IntPtr selReplaceSublayerWith_Handle = Selector.GetHandle("replaceSublayer:with:");

	private static readonly IntPtr selConvertPointFromLayer_Handle = Selector.GetHandle("convertPoint:fromLayer:");

	private static readonly IntPtr selConvertPointToLayer_Handle = Selector.GetHandle("convertPoint:toLayer:");

	private static readonly IntPtr selConvertRectFromLayer_Handle = Selector.GetHandle("convertRect:fromLayer:");

	private static readonly IntPtr selConvertRectToLayer_Handle = Selector.GetHandle("convertRect:toLayer:");

	private static readonly IntPtr selConvertTimeFromLayer_Handle = Selector.GetHandle("convertTime:fromLayer:");

	private static readonly IntPtr selConvertTimeToLayer_Handle = Selector.GetHandle("convertTime:toLayer:");

	private static readonly IntPtr selHitTest_Handle = Selector.GetHandle("hitTest:");

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	private static readonly IntPtr selSetNeedsDisplayHandle = Selector.GetHandle("setNeedsDisplay");

	private static readonly IntPtr selSetNeedsDisplayInRect_Handle = Selector.GetHandle("setNeedsDisplayInRect:");

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	private static readonly IntPtr selDrawInContext_Handle = Selector.GetHandle("drawInContext:");

	private static readonly IntPtr selRenderInContext_Handle = Selector.GetHandle("renderInContext:");

	private static readonly IntPtr selPreferredFrameSizeHandle = Selector.GetHandle("preferredFrameSize");

	private static readonly IntPtr selSetNeedsLayoutHandle = Selector.GetHandle("setNeedsLayout");

	private static readonly IntPtr selNeedsLayoutHandle = Selector.GetHandle("needsLayout");

	private static readonly IntPtr selLayoutIfNeededHandle = Selector.GetHandle("layoutIfNeeded");

	private static readonly IntPtr selLayoutSublayersHandle = Selector.GetHandle("layoutSublayers");

	private static readonly IntPtr selDefaultActionForKey_Handle = Selector.GetHandle("defaultActionForKey:");

	private static readonly IntPtr selActionForKey_Handle = Selector.GetHandle("actionForKey:");

	private static readonly IntPtr selAddAnimationForKey_Handle = Selector.GetHandle("addAnimation:forKey:");

	private static readonly IntPtr selRemoveAllAnimationsHandle = Selector.GetHandle("removeAllAnimations");

	private static readonly IntPtr selRemoveAnimationForKey_Handle = Selector.GetHandle("removeAnimationForKey:");

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	private static readonly IntPtr selScrollPoint_Handle = Selector.GetHandle("scrollPoint:");

	private static readonly IntPtr selScrollRectToVisible_Handle = Selector.GetHandle("scrollRectToVisible:");

	private static readonly IntPtr selResizeSublayersWithOldSize_Handle = Selector.GetHandle("resizeSublayersWithOldSize:");

	private static readonly IntPtr selResizeWithOldSuperlayerSize_Handle = Selector.GetHandle("resizeWithOldSuperlayerSize:");

	private static readonly IntPtr selAddConstraint_Handle = Selector.GetHandle("addConstraint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CALayer");

	private object __mt_PresentationLayer_var;

	private object __mt_ModelLayer_var;

	private object __mt_SuperLayer_var;

	private object __mt_Sublayers_var;

	private object __mt_Mask_var;

	private object __mt_LayoutManager_var;

	private object __mt_Actions_var;

	private object __mt_WeakDelegate_var;

	private object __mt_Constraints_var;

	private object __mt_Filters_var;

	private static NSString _Transition;

	private static NSString _GravityCenter;

	private static NSString _GravityTop;

	private static NSString _GravityBottom;

	private static NSString _GravityLeft;

	private static NSString _GravityRight;

	private static NSString _GravityTopLeft;

	private static NSString _GravityTopRight;

	private static NSString _GravityBottomLeft;

	private static NSString _GravityBottomRight;

	private static NSString _GravityResize;

	private static NSString _GravityResizeAspect;

	private static NSString _GravityResizeAspectFill;

	private static NSString _FilterNearest;

	private static NSString _FilterLinear;

	private static NSString _FilterTrilinear;

	private static NSString _OnOrderIn;

	private static NSString _OnOrderOut;

	[Obsolete("Use BeginTime instead")]
	public double CFTimeInterval
	{
		get
		{
			return BeginTime;
		}
		set
		{
			BeginTime = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual CALayer PresentationLayer
	{
		[Export("presentationLayer")]
		get
		{
			return (CALayer)(__mt_PresentationLayer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentationLayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentationLayerHandle)))));
		}
	}

	public virtual CALayer ModelLayer
	{
		[Export("modelLayer")]
		get
		{
			return (CALayer)(__mt_ModelLayer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelLayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selModelLayerHandle)))));
		}
	}

	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
		[Export("setBounds:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetBounds_Handle, value);
			}
		}
	}

	public virtual double ZPosition
	{
		[Export("zPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selZPositionHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selZPositionHandle);
		}
		[Export("setZPosition:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetZPosition_Handle, value);
			}
		}
	}

	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
			}
		}
	}

	public virtual double AnchorPointZ
	{
		[Export("anchorPointZ")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAnchorPointZHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAnchorPointZHandle);
		}
		[Export("setAnchorPointZ:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAnchorPointZ_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAnchorPointZ_Handle, value);
			}
		}
	}

	public virtual CGPoint Position
	{
		[Export("position")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	public virtual CATransform3D Transform
	{
		[Export("transform")]
		get
		{
			CATransform3D retval;
			if (IsDirectBinding)
			{
				Messaging.CATransform3D_objc_msgSend_stret(out retval, base.Handle, selTransformHandle);
			}
			else
			{
				Messaging.CATransform3D_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTransformHandle);
			}
			return retval;
		}
		[Export("setTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetTransform_Handle, value);
			}
		}
	}

	public virtual CGAffineTransform AffineTransform
	{
		[Export("affineTransform")]
		get
		{
			CGAffineTransform retval;
			if (IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selAffineTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAffineTransformHandle);
			}
			return retval;
		}
		[Export("setAffineTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetAffineTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetAffineTransform_Handle, value);
			}
		}
	}

	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
		[Export("setFrame:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrame_Handle, value);
			}
		}
	}

	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	public virtual bool DoubleSided
	{
		[Export("isDoubleSided")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDoubleSidedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDoubleSidedHandle);
		}
		[Export("setDoubleSided:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoubleSided_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoubleSided_Handle, value);
			}
		}
	}

	public virtual bool GeometryFlipped
	{
		[Export("isGeometryFlipped")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGeometryFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGeometryFlippedHandle);
		}
		[Export("setGeometryFlipped:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeometryFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeometryFlipped_Handle, value);
			}
		}
	}

	public virtual bool ContentsAreFlipped
	{
		[Export("contentsAreFlipped")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selContentsAreFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContentsAreFlippedHandle);
		}
	}

	public virtual CALayer SuperLayer
	{
		[Export("superlayer")]
		get
		{
			return (CALayer)(__mt_SuperLayer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperlayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperlayerHandle)))));
		}
	}

	public virtual CALayer[] Sublayers
	{
		[Export("sublayers", ArgumentSemantic.Copy)]
		get
		{
			return (CALayer[])(__mt_Sublayers_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSublayersHandle)) : NSArray.ArrayFromHandle<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selSublayersHandle))));
		}
		[Export("setSublayers:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSublayers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSublayers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Sublayers_var = value;
		}
	}

	public virtual CATransform3D SublayerTransform
	{
		[Export("sublayerTransform")]
		get
		{
			CATransform3D retval;
			if (IsDirectBinding)
			{
				Messaging.CATransform3D_objc_msgSend_stret(out retval, base.Handle, selSublayerTransformHandle);
			}
			else
			{
				Messaging.CATransform3D_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSublayerTransformHandle);
			}
			return retval;
		}
		[Export("setSublayerTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetSublayerTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetSublayerTransform_Handle, value);
			}
		}
	}

	public virtual CALayer Mask
	{
		[Export("mask", ArgumentSemantic.Retain)]
		get
		{
			return (CALayer)(__mt_Mask_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaskHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMaskHandle)))));
		}
		[Export("setMask:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMask_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMask_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Mask_var = value;
		}
	}

	public virtual bool MasksToBounds
	{
		[Export("masksToBounds")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMasksToBoundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMasksToBoundsHandle);
		}
		[Export("setMasksToBounds:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMasksToBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMasksToBounds_Handle, value);
			}
		}
	}

	public virtual CGImage Contents
	{
		[Export("contents", ArgumentSemantic.Retain)]
		get
		{
			if (IsDirectBinding)
			{
				return new CGImage(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle));
			}
			return new CGImage(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle));
		}
		[Export("setContents:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	public virtual NSObject LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			return (NSObject)(__mt_LayoutManager_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle))));
		}
		[Export("setLayoutManager:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayoutManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayoutManager_Handle, value.Handle);
			}
			__mt_LayoutManager_var = value;
		}
	}

	public virtual double ContentsScale
	{
		[Export("contentsScale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selContentsScaleHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selContentsScaleHandle);
		}
		[Export("setContentsScale:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetContentsScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetContentsScale_Handle, value);
			}
		}
	}

	public virtual CGRect ContentsRect
	{
		[Export("contentsRect")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContentsRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentsRectHandle);
			}
			return retval;
		}
		[Export("setContentsRect:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetContentsRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetContentsRect_Handle, value);
			}
		}
	}

	public virtual string ContentsGravity
	{
		[Export("contentsGravity", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsGravityHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsGravityHandle));
		}
		[Export("setContentsGravity:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentsGravity_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentsGravity_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual CGRect ContentsCenter
	{
		[Export("contentsCenter")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContentsCenterHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentsCenterHandle);
			}
			return retval;
		}
		[Export("setContentsCenter:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetContentsCenter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetContentsCenter_Handle, value);
			}
		}
	}

	public virtual string MinificationFilter
	{
		[Export("minificationFilter", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMinificationFilterHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinificationFilterHandle));
		}
		[Export("setMinificationFilter:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinificationFilter_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinificationFilter_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string MagnificationFilter
	{
		[Export("magnificationFilter", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMagnificationFilterHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMagnificationFilterHandle));
		}
		[Export("setMagnificationFilter:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMagnificationFilter_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMagnificationFilter_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Opaque
	{
		[Export("isOpaque")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Export("setOpaque:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
	}

	public virtual bool NeedsDisplayOnBoundsChange
	{
		[Export("needsDisplayOnBoundsChange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayOnBoundsChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayOnBoundsChangeHandle);
		}
		[Export("setNeedsDisplayOnBoundsChange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplayOnBoundsChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplayOnBoundsChange_Handle, value);
			}
		}
	}

	public virtual CGColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	public virtual double CornerRadius
	{
		[Export("cornerRadius")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCornerRadiusHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCornerRadiusHandle);
		}
		[Export("setCornerRadius:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCornerRadius_Handle, value);
			}
		}
	}

	public virtual double BorderWidth
	{
		[Export("borderWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBorderWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBorderWidthHandle);
		}
		[Export("setBorderWidth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBorderWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBorderWidth_Handle, value);
			}
		}
	}

	public virtual CGColor BorderColor
	{
		[Export("borderColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selBorderColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBorderColorHandle));
		}
		[Export("setBorderColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorderColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorderColor_Handle, value.Handle);
			}
		}
	}

	public virtual float Opacity
	{
		[Export("opacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOpacityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOpacityHandle);
		}
		[Export("setOpacity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOpacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOpacity_Handle, value);
			}
		}
	}

	public virtual CAEdgeAntialiasingMask EdgeAntialiasingMask
	{
		[Export("edgeAntialiasingMask")]
		get
		{
			if (IsDirectBinding)
			{
				return (CAEdgeAntialiasingMask)Messaging.int_objc_msgSend(base.Handle, selEdgeAntialiasingMaskHandle);
			}
			return (CAEdgeAntialiasingMask)Messaging.int_objc_msgSendSuper(base.SuperHandle, selEdgeAntialiasingMaskHandle);
		}
		[Export("setEdgeAntialiasingMask:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetEdgeAntialiasingMask_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetEdgeAntialiasingMask_Handle, (int)value);
			}
		}
	}

	public virtual NSDictionary Actions
	{
		[Export("actions", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_Actions_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selActionsHandle)))));
		}
		[Export("setActions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActions_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActions_Handle, value.Handle);
			}
			__mt_Actions_var = value;
		}
	}

	public virtual string[] AnimationKeys
	{
		[Export("animationKeys")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationKeysHandle));
		}
	}

	public virtual string Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
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
			__mt_WeakDelegate_var = value;
		}
	}

	public CALayerDelegate Delegate
	{
		get
		{
			return WeakDelegate as CALayerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual double BeginTime
	{
		[Export("beginTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeginTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeginTimeHandle);
		}
		[Export("setBeginTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBeginTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBeginTime_Handle, value);
			}
		}
	}

	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	public virtual float Speed
	{
		[Export("speed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	public virtual double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeOffsetHandle);
		}
		[Export("setTimeOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeOffset_Handle, value);
			}
		}
	}

	public virtual float RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRepeatCountHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRepeatCountHandle);
		}
		[Export("setRepeatCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRepeatCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRepeatCount_Handle, value);
			}
		}
	}

	public virtual double RepeatDuration
	{
		[Export("repeatDuration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRepeatDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRepeatDurationHandle);
		}
		[Export("setRepeatDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRepeatDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRepeatDuration_Handle, value);
			}
		}
	}

	public virtual bool AutoReverses
	{
		[Export("autoreverses")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoreversesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoreversesHandle);
		}
		[Export("setAutoreverses:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoreverses_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoreverses_Handle, value);
			}
		}
	}

	public virtual string FillMode
	{
		[Export("fillMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFillModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillModeHandle));
		}
		[Export("setFillMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Since(3, 2)]
	public virtual CGColor ShadowColor
	{
		[Export("shadowColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selShadowColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowColorHandle));
		}
		[Export("setShadowColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadowColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadowColor_Handle, value.Handle);
			}
		}
	}

	[Since(3, 2)]
	public virtual CGSize ShadowOffset
	{
		[Export("shadowOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selShadowOffsetHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selShadowOffsetHandle);
		}
		[Export("setShadowOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetShadowOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetShadowOffset_Handle, value);
			}
		}
	}

	[Since(3, 2)]
	public virtual float ShadowOpacity
	{
		[Export("shadowOpacity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selShadowOpacityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selShadowOpacityHandle);
		}
		[Export("setShadowOpacity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetShadowOpacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetShadowOpacity_Handle, value);
			}
		}
	}

	[Since(3, 2)]
	public virtual double ShadowRadius
	{
		[Export("shadowRadius")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selShadowRadiusHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selShadowRadiusHandle);
		}
		[Export("setShadowRadius:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetShadowRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetShadowRadius_Handle, value);
			}
		}
	}

	public virtual CGRect VisibleRect
	{
		[Export("visibleRect")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selVisibleRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVisibleRectHandle);
			}
			return retval;
		}
	}

	public virtual CAAutoresizingMask AutoresizinMask
	{
		[Export("autoresizingMask")]
		get
		{
			if (IsDirectBinding)
			{
				return (CAAutoresizingMask)Messaging.int_objc_msgSend(base.Handle, selAutoresizingMaskHandle);
			}
			return (CAAutoresizingMask)Messaging.int_objc_msgSendSuper(base.SuperHandle, selAutoresizingMaskHandle);
		}
		[Export("setAutoresizingMask:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetAutoresizingMask_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetAutoresizingMask_Handle, (int)value);
			}
		}
	}

	public virtual CAConstraint[] Constraints
	{
		[Export("constraints")]
		get
		{
			return (CAConstraint[])(__mt_Constraints_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CAConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsHandle)) : NSArray.ArrayFromHandle<CAConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsHandle))));
		}
		[Export("setConstraints:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConstraints_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConstraints_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Constraints_var = value;
		}
	}

	public virtual CIFilter[] Filters
	{
		[Export("filters")]
		get
		{
			return (CIFilter[])(__mt_Filters_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFiltersHandle)) : NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFiltersHandle))));
		}
		[Export("setFilters:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilters_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilters_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Filters_var = value;
		}
	}

	[Field("kCATransition", "CoreAnimation")]
	public static NSString Transition
	{
		get
		{
			if (_Transition == null)
			{
				_Transition = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransition");
			}
			return _Transition;
		}
	}

	[Field("kCAGravityCenter", "CoreAnimation")]
	public static NSString GravityCenter
	{
		get
		{
			if (_GravityCenter == null)
			{
				_GravityCenter = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityCenter");
			}
			return _GravityCenter;
		}
	}

	[Field("kCAGravityTop", "CoreAnimation")]
	public static NSString GravityTop
	{
		get
		{
			if (_GravityTop == null)
			{
				_GravityTop = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityTop");
			}
			return _GravityTop;
		}
	}

	[Field("kCAGravityBottom", "CoreAnimation")]
	public static NSString GravityBottom
	{
		get
		{
			if (_GravityBottom == null)
			{
				_GravityBottom = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityBottom");
			}
			return _GravityBottom;
		}
	}

	[Field("kCAGravityLeft", "CoreAnimation")]
	public static NSString GravityLeft
	{
		get
		{
			if (_GravityLeft == null)
			{
				_GravityLeft = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityLeft");
			}
			return _GravityLeft;
		}
	}

	[Field("kCAGravityRight", "CoreAnimation")]
	public static NSString GravityRight
	{
		get
		{
			if (_GravityRight == null)
			{
				_GravityRight = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityRight");
			}
			return _GravityRight;
		}
	}

	[Field("kCAGravityTopLeft", "CoreAnimation")]
	public static NSString GravityTopLeft
	{
		get
		{
			if (_GravityTopLeft == null)
			{
				_GravityTopLeft = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityTopLeft");
			}
			return _GravityTopLeft;
		}
	}

	[Field("kCAGravityTopRight", "CoreAnimation")]
	public static NSString GravityTopRight
	{
		get
		{
			if (_GravityTopRight == null)
			{
				_GravityTopRight = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityTopRight");
			}
			return _GravityTopRight;
		}
	}

	[Field("kCAGravityBottomLeft", "CoreAnimation")]
	public static NSString GravityBottomLeft
	{
		get
		{
			if (_GravityBottomLeft == null)
			{
				_GravityBottomLeft = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityBottomLeft");
			}
			return _GravityBottomLeft;
		}
	}

	[Field("kCAGravityBottomRight", "CoreAnimation")]
	public static NSString GravityBottomRight
	{
		get
		{
			if (_GravityBottomRight == null)
			{
				_GravityBottomRight = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityBottomRight");
			}
			return _GravityBottomRight;
		}
	}

	[Field("kCAGravityResize", "CoreAnimation")]
	public static NSString GravityResize
	{
		get
		{
			if (_GravityResize == null)
			{
				_GravityResize = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityResize");
			}
			return _GravityResize;
		}
	}

	[Field("kCAGravityResizeAspect", "CoreAnimation")]
	public static NSString GravityResizeAspect
	{
		get
		{
			if (_GravityResizeAspect == null)
			{
				_GravityResizeAspect = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityResizeAspect");
			}
			return _GravityResizeAspect;
		}
	}

	[Field("kCAGravityResizeAspectFill", "CoreAnimation")]
	public static NSString GravityResizeAspectFill
	{
		get
		{
			if (_GravityResizeAspectFill == null)
			{
				_GravityResizeAspectFill = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGravityResizeAspectFill");
			}
			return _GravityResizeAspectFill;
		}
	}

	[Field("kCAFilterNearest", "CoreAnimation")]
	public static NSString FilterNearest
	{
		get
		{
			if (_FilterNearest == null)
			{
				_FilterNearest = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFilterNearest");
			}
			return _FilterNearest;
		}
	}

	[Field("kCAFilterLinear", "CoreAnimation")]
	public static NSString FilterLinear
	{
		get
		{
			if (_FilterLinear == null)
			{
				_FilterLinear = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFilterLinear");
			}
			return _FilterLinear;
		}
	}

	[Field("kCAFilterTrilinear", "CoreAnimation")]
	public static NSString FilterTrilinear
	{
		get
		{
			if (_FilterTrilinear == null)
			{
				_FilterTrilinear = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFilterTrilinear");
			}
			return _FilterTrilinear;
		}
	}

	[Field("kCAOnOrderIn", "CoreAnimation")]
	public static NSString OnOrderIn
	{
		get
		{
			if (_OnOrderIn == null)
			{
				_OnOrderIn = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAOnOrderIn");
			}
			return _OnOrderIn;
		}
	}

	[Field("kCAOnOrderOut", "CoreAnimation")]
	public static NSString OnOrderOut
	{
		get
		{
			if (_OnOrderOut == null)
			{
				_OnOrderOut = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAOnOrderOut");
			}
			return _OnOrderOut;
		}
	}

	[Export("initWithLayer:")]
	public CALayer(CALayer other)
	{
		if (GetType() == typeof(CALayer))
		{
			Messaging.intptr_objc_msgSend_intptr(base.Handle, Selector.GetHandle("initWithLayer:"), other.Handle);
			return;
		}
		Messaging.intptr_objc_msgSendSuper_intptr(base.SuperHandle, Selector.GetHandle("initWithLayer:"), other.Handle);
		Clone(other);
	}

	public virtual void Clone(CALayer other)
	{
	}

	[Obsolete("Use ConvertRectFromLayer instead")]
	public CGRect ConvertRectfromLayer(CGRect rect, CALayer layer)
	{
		return ConvertRectFromLayer(rect, layer);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CALayer()
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
	public CALayer(NSCoder coder)
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
	public CALayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CALayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("defaultValueForKey:")]
	public static NSObject DefaultValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("needsDisplayForKey:")]
	public static bool NeedsDisplayForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selNeedsDisplayForKey_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeFromSuperlayer")]
	public virtual void RemoveFromSuperLayer()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperlayerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperlayerHandle);
		}
	}

	[Export("addSublayer:")]
	public virtual void AddSublayer(CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSublayer_Handle, layer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSublayer_Handle, layer.Handle);
		}
		_ = Sublayers;
	}

	[Export("insertSublayer:atIndex:")]
	public virtual void InsertSublayer(CALayer layer, int index)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertSublayerAtIndex_Handle, layer.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertSublayerAtIndex_Handle, layer.Handle, index);
		}
		_ = Sublayers;
	}

	[Export("insertSublayer:below:")]
	public virtual void InsertSublayerBelow(CALayer layer, CALayer sibling)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (sibling == null)
		{
			throw new ArgumentNullException("sibling");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSublayerBelow_Handle, layer.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSublayerBelow_Handle, layer.Handle, sibling.Handle);
		}
		_ = Sublayers;
	}

	[Export("insertSublayer:above:")]
	public virtual void InsertSublayerAbove(CALayer layer, CALayer sibling)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (sibling == null)
		{
			throw new ArgumentNullException("sibling");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSublayerAbove_Handle, layer.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSublayerAbove_Handle, layer.Handle, sibling.Handle);
		}
		_ = Sublayers;
	}

	[Export("replaceSublayer:with:")]
	public virtual void ReplaceSublayer(CALayer layer, CALayer with)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (with == null)
		{
			throw new ArgumentNullException("with");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceSublayerWith_Handle, layer.Handle, with.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceSublayerWith_Handle, layer.Handle, with.Handle);
		}
		_ = Sublayers;
	}

	[Export("convertPoint:fromLayer:")]
	public virtual CGPoint ConvertPointFromLayer(CGPoint point, CALayer layer)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointFromLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointFromLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertPoint:toLayer:")]
	public virtual CGPoint ConvertPointToLayer(CGPoint point, CALayer layer)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointToLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointToLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertRect:fromLayer:")]
	public virtual CGRect ConvertRectFromLayer(CGRect rect, CALayer layer)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectFromLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectFromLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertRect:toLayer:")]
	public virtual CGRect ConvertRectToLayer(CGRect rect, CALayer layer)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectToLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectToLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertTime:fromLayer:")]
	public virtual double ConvertTimeFromLayer(double timeInterval, CALayer layer)
	{
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double_IntPtr(base.Handle, selConvertTimeFromLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.Double_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selConvertTimeFromLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertTime:toLayer:")]
	public virtual double ConvertTimeToLayer(double timeInterval, CALayer layer)
	{
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double_IntPtr(base.Handle, selConvertTimeToLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.Double_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selConvertTimeToLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("hitTest:")]
	public virtual CALayer HitTest(CGPoint p)
	{
		if (IsDirectBinding)
		{
			return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selHitTest_Handle, p));
		}
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selHitTest_Handle, p));
	}

	[Export("containsPoint:")]
	public virtual bool Contains(CGPoint p)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, p);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, p);
	}

	[Export("display")]
	public virtual void Display()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	[Export("setNeedsDisplay")]
	public virtual void SetNeedsDisplay()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsDisplayHandle);
		}
	}

	[Export("setNeedsDisplayInRect:")]
	public virtual void SetNeedsDisplayInRect(CGRect r)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetNeedsDisplayInRect_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetNeedsDisplayInRect_Handle, r);
		}
	}

	[Export("displayIfNeeded")]
	public virtual void DisplayIfNeeded()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededHandle);
		}
	}

	[Export("drawInContext:")]
	public virtual void DrawInContext(CGContext ctx)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawInContext_Handle, ctx.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawInContext_Handle, ctx.Handle);
		}
	}

	[Export("renderInContext:")]
	public virtual void RenderInContext(CGContext ctx)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRenderInContext_Handle, ctx.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRenderInContext_Handle, ctx.Handle);
		}
	}

	[Export("preferredFrameSize")]
	public virtual CGSize PreferredFrameSize()
	{
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredFrameSizeHandle);
		}
		return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredFrameSizeHandle);
	}

	[Export("setNeedsLayout")]
	public virtual void SetNeedsLayout()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsLayoutHandle);
		}
	}

	[Export("needsLayout")]
	public virtual bool NeedsLayout()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selNeedsLayoutHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsLayoutHandle);
	}

	[Export("layoutIfNeeded")]
	public virtual void LayoutIfNeeded()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutIfNeededHandle);
		}
	}

	[Export("layoutSublayers")]
	public virtual void LayoutSublayers()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutSublayersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutSublayersHandle);
		}
	}

	[Export("defaultActionForKey:")]
	public static NSObject DefaultActionForKey(string eventKey)
	{
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		IntPtr arg = NSString.CreateNative(eventKey);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultActionForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("actionForKey:")]
	public virtual NSObject ActionForKey(string eventKey)
	{
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		IntPtr arg = NSString.CreateNative(eventKey);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selActionForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selActionForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addAnimation:forKey:")]
	public virtual void AddAnimation(CAAnimation animation, string key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimationForKey_Handle, animation.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimationForKey_Handle, animation.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeAllAnimations")]
	public virtual void RemoveAllAnimations()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAnimationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAnimationsHandle);
		}
	}

	[Export("removeAnimationForKey:")]
	public virtual void RemoveAnimation(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnimationForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnimationForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("animationForKey:")]
	public virtual CAAnimation AnimationForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		CAAnimation result = ((!IsDirectBinding) ? ((CAAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, arg))) : ((CAAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("scrollPoint:")]
	public virtual void ScrollPoint(CGPoint p)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollPoint_Handle, p);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollPoint_Handle, p);
		}
	}

	[Export("scrollRectToVisible:")]
	public virtual void ScrollRectToVisible(CGRect r)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollRectToVisible_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollRectToVisible_Handle, r);
		}
	}

	[Export("resizeSublayersWithOldSize:")]
	public virtual void ResizeSublayers(CGSize oldSize)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeSublayersWithOldSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeSublayersWithOldSize_Handle, oldSize);
		}
	}

	[Export("resizeWithOldSuperlayerSize:")]
	public virtual void Resize(CGSize oldSuperlayerSize)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeWithOldSuperlayerSize_Handle, oldSuperlayerSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeWithOldSuperlayerSize_Handle, oldSuperlayerSize);
		}
	}

	[Export("addConstraint:")]
	public virtual void AddConstraint(CAConstraint c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraint_Handle, c.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraint_Handle, c.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PresentationLayer_var = null;
			__mt_ModelLayer_var = null;
			__mt_SuperLayer_var = null;
			__mt_Sublayers_var = null;
			__mt_Mask_var = null;
			__mt_LayoutManager_var = null;
			__mt_Actions_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Constraints_var = null;
			__mt_Filters_var = null;
		}
	}
}

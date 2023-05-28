using System;
using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CALayer", true)]
public class CALayer : NSObject, ICAMediaTiming, INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	private const string selInitWithLayer = "initWithLayer:";

	private WeakReference calayerdelegate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionForKey_ = "actionForKey:";

	private static readonly IntPtr selActionForKey_Handle = Selector.GetHandle("actionForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActions = "actions";

	private static readonly IntPtr selActionsHandle = Selector.GetHandle("actions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimation_ForKey_ = "addAnimation:forKey:";

	private static readonly IntPtr selAddAnimation_ForKey_Handle = Selector.GetHandle("addAnimation:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddConstraint_ = "addConstraint:";

	private static readonly IntPtr selAddConstraint_Handle = Selector.GetHandle("addConstraint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSublayer_ = "addSublayer:";

	private static readonly IntPtr selAddSublayer_Handle = Selector.GetHandle("addSublayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAffineTransform = "affineTransform";

	private static readonly IntPtr selAffineTransformHandle = Selector.GetHandle("affineTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEdgeAntialiasing = "allowsEdgeAntialiasing";

	private static readonly IntPtr selAllowsEdgeAntialiasingHandle = Selector.GetHandle("allowsEdgeAntialiasing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsGroupOpacity = "allowsGroupOpacity";

	private static readonly IntPtr selAllowsGroupOpacityHandle = Selector.GetHandle("allowsGroupOpacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPoint = "anchorPoint";

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPointZ = "anchorPointZ";

	private static readonly IntPtr selAnchorPointZHandle = Selector.GetHandle("anchorPointZ");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationKeys = "animationKeys";

	private static readonly IntPtr selAnimationKeysHandle = Selector.GetHandle("animationKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoresizingMask = "autoresizingMask";

	private static readonly IntPtr selAutoresizingMaskHandle = Selector.GetHandle("autoresizingMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoreverses = "autoreverses";

	private static readonly IntPtr selAutoreversesHandle = Selector.GetHandle("autoreverses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundFilters = "backgroundFilters";

	private static readonly IntPtr selBackgroundFiltersHandle = Selector.GetHandle("backgroundFilters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginTime = "beginTime";

	private static readonly IntPtr selBeginTimeHandle = Selector.GetHandle("beginTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBorderColor = "borderColor";

	private static readonly IntPtr selBorderColorHandle = Selector.GetHandle("borderColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBorderWidth = "borderWidth";

	private static readonly IntPtr selBorderWidthHandle = Selector.GetHandle("borderWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositingFilter = "compositingFilter";

	private static readonly IntPtr selCompositingFilterHandle = Selector.GetHandle("compositingFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraints = "constraints";

	private static readonly IntPtr selConstraintsHandle = Selector.GetHandle("constraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsPoint_ = "containsPoint:";

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContents = "contents";

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsAreFlipped = "contentsAreFlipped";

	private static readonly IntPtr selContentsAreFlippedHandle = Selector.GetHandle("contentsAreFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsCenter = "contentsCenter";

	private static readonly IntPtr selContentsCenterHandle = Selector.GetHandle("contentsCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsFormat = "contentsFormat";

	private static readonly IntPtr selContentsFormatHandle = Selector.GetHandle("contentsFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsGravity = "contentsGravity";

	private static readonly IntPtr selContentsGravityHandle = Selector.GetHandle("contentsGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsRect = "contentsRect";

	private static readonly IntPtr selContentsRectHandle = Selector.GetHandle("contentsRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsScale = "contentsScale";

	private static readonly IntPtr selContentsScaleHandle = Selector.GetHandle("contentsScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_FromLayer_ = "convertPoint:fromLayer:";

	private static readonly IntPtr selConvertPoint_FromLayer_Handle = Selector.GetHandle("convertPoint:fromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToLayer_ = "convertPoint:toLayer:";

	private static readonly IntPtr selConvertPoint_ToLayer_Handle = Selector.GetHandle("convertPoint:toLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_FromLayer_ = "convertRect:fromLayer:";

	private static readonly IntPtr selConvertRect_FromLayer_Handle = Selector.GetHandle("convertRect:fromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_ToLayer_ = "convertRect:toLayer:";

	private static readonly IntPtr selConvertRect_ToLayer_Handle = Selector.GetHandle("convertRect:toLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertTime_FromLayer_ = "convertTime:fromLayer:";

	private static readonly IntPtr selConvertTime_FromLayer_Handle = Selector.GetHandle("convertTime:fromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertTime_ToLayer_ = "convertTime:toLayer:";

	private static readonly IntPtr selConvertTime_ToLayer_Handle = Selector.GetHandle("convertTime:toLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCornerCurve = "cornerCurve";

	private static readonly IntPtr selCornerCurveHandle = Selector.GetHandle("cornerCurve");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCornerCurveExpansionFactor_ = "cornerCurveExpansionFactor:";

	private static readonly IntPtr selCornerCurveExpansionFactor_Handle = Selector.GetHandle("cornerCurveExpansionFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCornerRadius = "cornerRadius";

	private static readonly IntPtr selCornerRadiusHandle = Selector.GetHandle("cornerRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultActionForKey_ = "defaultActionForKey:";

	private static readonly IntPtr selDefaultActionForKey_Handle = Selector.GetHandle("defaultActionForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultValueForKey_ = "defaultValueForKey:";

	private static readonly IntPtr selDefaultValueForKey_Handle = Selector.GetHandle("defaultValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplay = "display";

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeeded = "displayIfNeeded";

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInContext_ = "drawInContext:";

	private static readonly IntPtr selDrawInContext_Handle = Selector.GetHandle("drawInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsAsynchronously = "drawsAsynchronously";

	private static readonly IntPtr selDrawsAsynchronouslyHandle = Selector.GetHandle("drawsAsynchronously");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeAntialiasingMask = "edgeAntialiasingMask";

	private static readonly IntPtr selEdgeAntialiasingMaskHandle = Selector.GetHandle("edgeAntialiasingMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillMode = "fillMode";

	private static readonly IntPtr selFillModeHandle = Selector.GetHandle("fillMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilters = "filters";

	private static readonly IntPtr selFiltersHandle = Selector.GetHandle("filters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitTest_ = "hitTest:";

	private static readonly IntPtr selHitTest_Handle = Selector.GetHandle("hitTest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSublayer_Above_ = "insertSublayer:above:";

	private static readonly IntPtr selInsertSublayer_Above_Handle = Selector.GetHandle("insertSublayer:above:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSublayer_AtIndex_ = "insertSublayer:atIndex:";

	private static readonly IntPtr selInsertSublayer_AtIndex_Handle = Selector.GetHandle("insertSublayer:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSublayer_Below_ = "insertSublayer:below:";

	private static readonly IntPtr selInsertSublayer_Below_Handle = Selector.GetHandle("insertSublayer:below:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDoubleSided = "isDoubleSided";

	private static readonly IntPtr selIsDoubleSidedHandle = Selector.GetHandle("isDoubleSided");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGeometryFlipped = "isGeometryFlipped";

	private static readonly IntPtr selIsGeometryFlippedHandle = Selector.GetHandle("isGeometryFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutIfNeeded = "layoutIfNeeded";

	private static readonly IntPtr selLayoutIfNeededHandle = Selector.GetHandle("layoutIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManager = "layoutManager";

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutSublayers = "layoutSublayers";

	private static readonly IntPtr selLayoutSublayersHandle = Selector.GetHandle("layoutSublayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnificationFilter = "magnificationFilter";

	private static readonly IntPtr selMagnificationFilterHandle = Selector.GetHandle("magnificationFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMask = "mask";

	private static readonly IntPtr selMaskHandle = Selector.GetHandle("mask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskedCorners = "maskedCorners";

	private static readonly IntPtr selMaskedCornersHandle = Selector.GetHandle("maskedCorners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMasksToBounds = "masksToBounds";

	private static readonly IntPtr selMasksToBoundsHandle = Selector.GetHandle("masksToBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinificationFilter = "minificationFilter";

	private static readonly IntPtr selMinificationFilterHandle = Selector.GetHandle("minificationFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinificationFilterBias = "minificationFilterBias";

	private static readonly IntPtr selMinificationFilterBiasHandle = Selector.GetHandle("minificationFilterBias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelLayer = "modelLayer";

	private static readonly IntPtr selModelLayerHandle = Selector.GetHandle("modelLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsDisplay = "needsDisplay";

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsDisplayForKey_ = "needsDisplayForKey:";

	private static readonly IntPtr selNeedsDisplayForKey_Handle = Selector.GetHandle("needsDisplayForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsDisplayOnBoundsChange = "needsDisplayOnBoundsChange";

	private static readonly IntPtr selNeedsDisplayOnBoundsChangeHandle = Selector.GetHandle("needsDisplayOnBoundsChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsLayout = "needsLayout";

	private static readonly IntPtr selNeedsLayoutHandle = Selector.GetHandle("needsLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpacity = "opacity";

	private static readonly IntPtr selOpacityHandle = Selector.GetHandle("opacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredFrameSize = "preferredFrameSize";

	private static readonly IntPtr selPreferredFrameSizeHandle = Selector.GetHandle("preferredFrameSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationLayer = "presentationLayer";

	private static readonly IntPtr selPresentationLayerHandle = Selector.GetHandle("presentationLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRasterizationScale = "rasterizationScale";

	private static readonly IntPtr selRasterizationScaleHandle = Selector.GetHandle("rasterizationScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllAnimations = "removeAllAnimations";

	private static readonly IntPtr selRemoveAllAnimationsHandle = Selector.GetHandle("removeAllAnimations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_ = "removeAnimationForKey:";

	private static readonly IntPtr selRemoveAnimationForKey_Handle = Selector.GetHandle("removeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromSuperlayer = "removeFromSuperlayer";

	private static readonly IntPtr selRemoveFromSuperlayerHandle = Selector.GetHandle("removeFromSuperlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderInContext_ = "renderInContext:";

	private static readonly IntPtr selRenderInContext_Handle = Selector.GetHandle("renderInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatCount = "repeatCount";

	private static readonly IntPtr selRepeatCountHandle = Selector.GetHandle("repeatCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatDuration = "repeatDuration";

	private static readonly IntPtr selRepeatDurationHandle = Selector.GetHandle("repeatDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceSublayer_With_ = "replaceSublayer:with:";

	private static readonly IntPtr selReplaceSublayer_With_Handle = Selector.GetHandle("replaceSublayer:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeSublayersWithOldSize_ = "resizeSublayersWithOldSize:";

	private static readonly IntPtr selResizeSublayersWithOldSize_Handle = Selector.GetHandle("resizeSublayersWithOldSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeWithOldSuperlayerSize_ = "resizeWithOldSuperlayerSize:";

	private static readonly IntPtr selResizeWithOldSuperlayerSize_Handle = Selector.GetHandle("resizeWithOldSuperlayerSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollPoint_ = "scrollPoint:";

	private static readonly IntPtr selScrollPoint_Handle = Selector.GetHandle("scrollPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRectToVisible_ = "scrollRectToVisible:";

	private static readonly IntPtr selScrollRectToVisible_Handle = Selector.GetHandle("scrollRectToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActions_ = "setActions:";

	private static readonly IntPtr selSetActions_Handle = Selector.GetHandle("setActions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffineTransform_ = "setAffineTransform:";

	private static readonly IntPtr selSetAffineTransform_Handle = Selector.GetHandle("setAffineTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEdgeAntialiasing_ = "setAllowsEdgeAntialiasing:";

	private static readonly IntPtr selSetAllowsEdgeAntialiasing_Handle = Selector.GetHandle("setAllowsEdgeAntialiasing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsGroupOpacity_ = "setAllowsGroupOpacity:";

	private static readonly IntPtr selSetAllowsGroupOpacity_Handle = Selector.GetHandle("setAllowsGroupOpacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPoint_ = "setAnchorPoint:";

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPointZ_ = "setAnchorPointZ:";

	private static readonly IntPtr selSetAnchorPointZ_Handle = Selector.GetHandle("setAnchorPointZ:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoresizingMask_ = "setAutoresizingMask:";

	private static readonly IntPtr selSetAutoresizingMask_Handle = Selector.GetHandle("setAutoresizingMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoreverses_ = "setAutoreverses:";

	private static readonly IntPtr selSetAutoreverses_Handle = Selector.GetHandle("setAutoreverses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundFilters_ = "setBackgroundFilters:";

	private static readonly IntPtr selSetBackgroundFilters_Handle = Selector.GetHandle("setBackgroundFilters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBeginTime_ = "setBeginTime:";

	private static readonly IntPtr selSetBeginTime_Handle = Selector.GetHandle("setBeginTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderColor_ = "setBorderColor:";

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderWidth_ = "setBorderWidth:";

	private static readonly IntPtr selSetBorderWidth_Handle = Selector.GetHandle("setBorderWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBounds_ = "setBounds:";

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompositingFilter_ = "setCompositingFilter:";

	private static readonly IntPtr selSetCompositingFilter_Handle = Selector.GetHandle("setCompositingFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstraints_ = "setConstraints:";

	private static readonly IntPtr selSetConstraints_Handle = Selector.GetHandle("setConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContents_ = "setContents:";

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentsCenter_ = "setContentsCenter:";

	private static readonly IntPtr selSetContentsCenter_Handle = Selector.GetHandle("setContentsCenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentsFormat_ = "setContentsFormat:";

	private static readonly IntPtr selSetContentsFormat_Handle = Selector.GetHandle("setContentsFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentsGravity_ = "setContentsGravity:";

	private static readonly IntPtr selSetContentsGravity_Handle = Selector.GetHandle("setContentsGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentsRect_ = "setContentsRect:";

	private static readonly IntPtr selSetContentsRect_Handle = Selector.GetHandle("setContentsRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentsScale_ = "setContentsScale:";

	private static readonly IntPtr selSetContentsScale_Handle = Selector.GetHandle("setContentsScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCornerCurve_ = "setCornerCurve:";

	private static readonly IntPtr selSetCornerCurve_Handle = Selector.GetHandle("setCornerCurve:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCornerRadius_ = "setCornerRadius:";

	private static readonly IntPtr selSetCornerRadius_Handle = Selector.GetHandle("setCornerRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleSided_ = "setDoubleSided:";

	private static readonly IntPtr selSetDoubleSided_Handle = Selector.GetHandle("setDoubleSided:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsAsynchronously_ = "setDrawsAsynchronously:";

	private static readonly IntPtr selSetDrawsAsynchronously_Handle = Selector.GetHandle("setDrawsAsynchronously:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeAntialiasingMask_ = "setEdgeAntialiasingMask:";

	private static readonly IntPtr selSetEdgeAntialiasingMask_Handle = Selector.GetHandle("setEdgeAntialiasingMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillMode_ = "setFillMode:";

	private static readonly IntPtr selSetFillMode_Handle = Selector.GetHandle("setFillMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilters_ = "setFilters:";

	private static readonly IntPtr selSetFilters_Handle = Selector.GetHandle("setFilters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrame_ = "setFrame:";

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGeometryFlipped_ = "setGeometryFlipped:";

	private static readonly IntPtr selSetGeometryFlipped_Handle = Selector.GetHandle("setGeometryFlipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutManager_ = "setLayoutManager:";

	private static readonly IntPtr selSetLayoutManager_Handle = Selector.GetHandle("setLayoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnificationFilter_ = "setMagnificationFilter:";

	private static readonly IntPtr selSetMagnificationFilter_Handle = Selector.GetHandle("setMagnificationFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMask_ = "setMask:";

	private static readonly IntPtr selSetMask_Handle = Selector.GetHandle("setMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaskedCorners_ = "setMaskedCorners:";

	private static readonly IntPtr selSetMaskedCorners_Handle = Selector.GetHandle("setMaskedCorners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMasksToBounds_ = "setMasksToBounds:";

	private static readonly IntPtr selSetMasksToBounds_Handle = Selector.GetHandle("setMasksToBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinificationFilter_ = "setMinificationFilter:";

	private static readonly IntPtr selSetMinificationFilter_Handle = Selector.GetHandle("setMinificationFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinificationFilterBias_ = "setMinificationFilterBias:";

	private static readonly IntPtr selSetMinificationFilterBias_Handle = Selector.GetHandle("setMinificationFilterBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplay = "setNeedsDisplay";

	private static readonly IntPtr selSetNeedsDisplayHandle = Selector.GetHandle("setNeedsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayInRect_ = "setNeedsDisplayInRect:";

	private static readonly IntPtr selSetNeedsDisplayInRect_Handle = Selector.GetHandle("setNeedsDisplayInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayOnBoundsChange_ = "setNeedsDisplayOnBoundsChange:";

	private static readonly IntPtr selSetNeedsDisplayOnBoundsChange_Handle = Selector.GetHandle("setNeedsDisplayOnBoundsChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsLayout = "setNeedsLayout";

	private static readonly IntPtr selSetNeedsLayoutHandle = Selector.GetHandle("setNeedsLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpacity_ = "setOpacity:";

	private static readonly IntPtr selSetOpacity_Handle = Selector.GetHandle("setOpacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpaque_ = "setOpaque:";

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRasterizationScale_ = "setRasterizationScale:";

	private static readonly IntPtr selSetRasterizationScale_Handle = Selector.GetHandle("setRasterizationScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatCount_ = "setRepeatCount:";

	private static readonly IntPtr selSetRepeatCount_Handle = Selector.GetHandle("setRepeatCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatDuration_ = "setRepeatDuration:";

	private static readonly IntPtr selSetRepeatDuration_Handle = Selector.GetHandle("setRepeatDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowColor_ = "setShadowColor:";

	private static readonly IntPtr selSetShadowColor_Handle = Selector.GetHandle("setShadowColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowOffset_ = "setShadowOffset:";

	private static readonly IntPtr selSetShadowOffset_Handle = Selector.GetHandle("setShadowOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowOpacity_ = "setShadowOpacity:";

	private static readonly IntPtr selSetShadowOpacity_Handle = Selector.GetHandle("setShadowOpacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowPath_ = "setShadowPath:";

	private static readonly IntPtr selSetShadowPath_Handle = Selector.GetHandle("setShadowPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowRadius_ = "setShadowRadius:";

	private static readonly IntPtr selSetShadowRadius_Handle = Selector.GetHandle("setShadowRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldRasterize_ = "setShouldRasterize:";

	private static readonly IntPtr selSetShouldRasterize_Handle = Selector.GetHandle("setShouldRasterize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyle_ = "setStyle:";

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSublayerTransform_ = "setSublayerTransform:";

	private static readonly IntPtr selSetSublayerTransform_Handle = Selector.GetHandle("setSublayerTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSublayers_ = "setSublayers:";

	private static readonly IntPtr selSetSublayers_Handle = Selector.GetHandle("setSublayers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeOffset_ = "setTimeOffset:";

	private static readonly IntPtr selSetTimeOffset_Handle = Selector.GetHandle("setTimeOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransform_ = "setTransform:";

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZPosition_ = "setZPosition:";

	private static readonly IntPtr selSetZPosition_Handle = Selector.GetHandle("setZPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowColor = "shadowColor";

	private static readonly IntPtr selShadowColorHandle = Selector.GetHandle("shadowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowOffset = "shadowOffset";

	private static readonly IntPtr selShadowOffsetHandle = Selector.GetHandle("shadowOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowOpacity = "shadowOpacity";

	private static readonly IntPtr selShadowOpacityHandle = Selector.GetHandle("shadowOpacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowPath = "shadowPath";

	private static readonly IntPtr selShadowPathHandle = Selector.GetHandle("shadowPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowRadius = "shadowRadius";

	private static readonly IntPtr selShadowRadiusHandle = Selector.GetHandle("shadowRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRasterize = "shouldRasterize";

	private static readonly IntPtr selShouldRasterizeHandle = Selector.GetHandle("shouldRasterize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSublayerTransform = "sublayerTransform";

	private static readonly IntPtr selSublayerTransformHandle = Selector.GetHandle("sublayerTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSublayers = "sublayers";

	private static readonly IntPtr selSublayersHandle = Selector.GetHandle("sublayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperlayer = "superlayer";

	private static readonly IntPtr selSuperlayerHandle = Selector.GetHandle("superlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeOffset = "timeOffset";

	private static readonly IntPtr selTimeOffsetHandle = Selector.GetHandle("timeOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleRect = "visibleRect";

	private static readonly IntPtr selVisibleRectHandle = Selector.GetHandle("visibleRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZPosition = "zPosition";

	private static readonly IntPtr selZPositionHandle = Selector.GetHandle("zPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CALayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterNearest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterTrilinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityBottom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityBottomLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityBottomRight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityCenter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResizeAspect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResizeAspectFill;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityRight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityTop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityTopLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityTopRight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnOrderIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnOrderOut;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Transition;

	[Obsolete("Use 'AutoresizingMask' instead.")]
	public virtual CAAutoresizingMask AutoresizinMask
	{
		get
		{
			return AutoresizingMask;
		}
		set
		{
			AutoresizingMask = value;
		}
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public CAContentsFormat ContentsFormat
	{
		get
		{
			return CAContentsFormatExtensions.GetValue(_ContentsFormat);
		}
		set
		{
			_ContentsFormat = value.GetConstant();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? Actions
	{
		[Export("actions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selActionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionsHandle));
		}
		[Export("setActions:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActions_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActions_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform AffineTransform
	{
		[Export("affineTransform")]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetAffineTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetAffineTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool AllowsEdgeAntialiasing
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("allowsEdgeAntialiasing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEdgeAntialiasingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEdgeAntialiasingHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAllowsEdgeAntialiasing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEdgeAntialiasing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEdgeAntialiasing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool AllowsGroupOpacity
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("allowsGroupOpacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsGroupOpacityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsGroupOpacityHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAllowsGroupOpacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsGroupOpacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsGroupOpacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AnchorPointZ
	{
		[Export("anchorPointZ")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAnchorPointZHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAnchorPointZHandle);
		}
		[Export("setAnchorPointZ:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAnchorPointZ_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAnchorPointZ_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? AnimationKeys
	{
		[Export("animationKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationKeysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoReverses
	{
		[Export("autoreverses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoreversesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoreversesHandle);
		}
		[Export("setAutoreverses:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoreverses_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoreverses_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAAutoresizingMask AutoresizingMask
	{
		[Export("autoresizingMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CAAutoresizingMask)Messaging.UInt32_objc_msgSend(base.Handle, selAutoresizingMaskHandle);
			}
			return (CAAutoresizingMask)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selAutoresizingMaskHandle);
		}
		[Export("setAutoresizingMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetAutoresizingMask_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetAutoresizingMask_Handle, (uint)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setBackgroundColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter[]? BackgroundFilters
	{
		[Export("backgroundFilters", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundFiltersHandle));
			}
			return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundFiltersHandle));
		}
		[Export("setBackgroundFilters:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double BeginTime
	{
		[Export("beginTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeginTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeginTimeHandle);
		}
		[Export("setBeginTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBeginTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBeginTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor BorderColor
	{
		[Export("borderColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBorderColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selBorderColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setBorderColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorderColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorderColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BorderWidth
	{
		[Export("borderWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBorderWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBorderWidthHandle);
		}
		[Export("setBorderWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBorderWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBorderWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? CompositingFilter
	{
		[Export("compositingFilter", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCompositingFilterHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompositingFilterHandle));
		}
		[Export("setCompositingFilter:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAConstraint[] Constraints
	{
		[Export("constraints")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CAConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsHandle));
			}
			return NSArray.ArrayFromHandle<CAConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsHandle));
		}
		[Export("setConstraints:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConstraints_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConstraints_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual CGImage? Contents
	{
		[Export("contents", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
		[Export("setContents:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContentsAreFlipped
	{
		[Export("contentsAreFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selContentsAreFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContentsAreFlippedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ContentsCenter
	{
		[Export("contentsCenter")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetContentsCenter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetContentsCenter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ContentsGravity
	{
		[Export("contentsGravity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ContentsRect
	{
		[Export("contentsRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetContentsRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetContentsRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ContentsScale
	{
		[Export("contentsScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selContentsScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selContentsScaleHandle);
		}
		[Export("setContentsScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetContentsScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetContentsScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(CACornerCurve), OriginalType = typeof(NSString))]
	public virtual CACornerCurve CornerCurve
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("cornerCurve")]
		get
		{
			if (base.IsDirectBinding)
			{
				return CACornerCurveExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selCornerCurveHandle)));
			}
			return CACornerCurveExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCornerCurveHandle)));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setCornerCurve:")]
		set
		{
			NSString constant = value.GetConstant();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCornerCurve_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCornerCurve_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CornerRadius
	{
		[Export("cornerRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selCornerRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selCornerRadiusHandle);
		}
		[Export("setCornerRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetCornerRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ICALayerDelegate Delegate
	{
		get
		{
			return WeakDelegate as ICALayerDelegate;
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
	public virtual bool DoubleSided
	{
		[Export("isDoubleSided")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDoubleSidedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDoubleSidedHandle);
		}
		[Export("setDoubleSided:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoubleSided_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoubleSided_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsAsynchronously
	{
		[Export("drawsAsynchronously")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsAsynchronouslyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsAsynchronouslyHandle);
		}
		[Export("setDrawsAsynchronously:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsAsynchronously_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsAsynchronously_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAEdgeAntialiasingMask EdgeAntialiasingMask
	{
		[Export("edgeAntialiasingMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CAEdgeAntialiasingMask)Messaging.UInt32_objc_msgSend(base.Handle, selEdgeAntialiasingMaskHandle);
			}
			return (CAEdgeAntialiasingMask)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEdgeAntialiasingMaskHandle);
		}
		[Export("setEdgeAntialiasingMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetEdgeAntialiasingMask_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetEdgeAntialiasingMask_Handle, (uint)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FillMode
	{
		[Export("fillMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFillModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillModeHandle));
		}
		[Export("setFillMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter[]? Filters
	{
		[Export("filters", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFiltersHandle));
			}
			return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFiltersHandle));
		}
		[Export("setFilters:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GeometryFlipped
	{
		[Export("isGeometryFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGeometryFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGeometryFlippedHandle);
		}
		[Export("setGeometryFlipped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeometryFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeometryFlipped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject LayoutManager
	{
		[Export("layoutManager", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle));
		}
		[Export("setLayoutManager:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayoutManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayoutManager_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MagnificationFilter
	{
		[Export("magnificationFilter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer? Mask
	{
		[Export("mask", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaskHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaskHandle));
		}
		[Export("setMask:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMask_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMask_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CACornerMask MaskedCorners
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("maskedCorners", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CACornerMask)Messaging.UInt64_objc_msgSend(base.Handle, selMaskedCornersHandle);
			}
			return (CACornerMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaskedCornersHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setMaskedCorners:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaskedCorners_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaskedCorners_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MasksToBounds
	{
		[Export("masksToBounds")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMasksToBoundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMasksToBoundsHandle);
		}
		[Export("setMasksToBounds:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMasksToBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMasksToBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MinificationFilter
	{
		[Export("minificationFilter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinificationFilterBias
	{
		[Export("minificationFilterBias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinificationFilterBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinificationFilterBiasHandle);
		}
		[Export("setMinificationFilterBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinificationFilterBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinificationFilterBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer ModelLayer
	{
		[Export("modelLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selModelLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelLayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsDisplayOnBoundsChange
	{
		[Export("needsDisplayOnBoundsChange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayOnBoundsChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayOnBoundsChangeHandle);
		}
		[Export("setNeedsDisplayOnBoundsChange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplayOnBoundsChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplayOnBoundsChange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Opacity
	{
		[Export("opacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOpacityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOpacityHandle);
		}
		[Export("setOpacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOpacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOpacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Opaque
	{
		[Export("isOpaque")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Export("setOpaque:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint Position
	{
		[Export("position")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer PresentationLayer
	{
		[Export("presentationLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentationLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentationLayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RasterizationScale
	{
		[Export("rasterizationScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRasterizationScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRasterizationScaleHandle);
		}
		[Export("setRasterizationScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRasterizationScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRasterizationScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRepeatCountHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRepeatCountHandle);
		}
		[Export("setRepeatCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRepeatCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRepeatCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double RepeatDuration
	{
		[Export("repeatDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRepeatDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRepeatDurationHandle);
		}
		[Export("setRepeatDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRepeatDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRepeatDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor ShadowColor
	{
		[Export("shadowColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selShadowColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setShadowColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadowColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadowColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ShadowOffset
	{
		[Export("shadowOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selShadowOffsetHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selShadowOffsetHandle);
		}
		[Export("setShadowOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetShadowOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetShadowOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ShadowOpacity
	{
		[Export("shadowOpacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selShadowOpacityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selShadowOpacityHandle);
		}
		[Export("setShadowOpacity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetShadowOpacity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetShadowOpacity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPath? ShadowPath
	{
		[Export("shadowPath")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowPathHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selShadowPathHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPath(intPtr);
		}
		[Export("setShadowPath:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadowPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadowPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ShadowRadius
	{
		[Export("shadowRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selShadowRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selShadowRadiusHandle);
		}
		[Export("setShadowRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetShadowRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetShadowRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRasterize
	{
		[Export("shouldRasterize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRasterizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRasterizeHandle);
		}
		[Export("setShouldRasterize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldRasterize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldRasterize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Speed
	{
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? Style
	{
		[Export("style", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleHandle));
		}
		[Export("setStyle:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CATransform3D SublayerTransform
	{
		[Export("sublayerTransform")]
		get
		{
			CATransform3D retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetSublayerTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetSublayerTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer[]? Sublayers
	{
		[Export("sublayers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selSublayersHandle));
			}
			return NSArray.ArrayFromHandle<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSublayersHandle));
		}
		[Export("setSublayers:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSublayers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSublayers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer SuperLayer
	{
		[Export("superlayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperlayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperlayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeOffsetHandle);
		}
		[Export("setTimeOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CATransform3D Transform
	{
		[Export("transform")]
		get
		{
			CATransform3D retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect VisibleRect
	{
		[Export("visibleRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
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
			SetCALayerDelegate(value as CALayerDelegate);
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ZPosition
	{
		[Export("zPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZPositionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZPositionHandle);
		}
		[Export("setZPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetZPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _Contents
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle);
		}
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	internal virtual NSString _ContentsFormat
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("contentsFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsFormatHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsFormatHandle));
		}
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setContentsFormat:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentsFormat_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentsFormat_Handle, value.Handle);
			}
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

	[Export("initWithLayer:")]
	public CALayer(CALayer other)
	{
		if (GetType() == typeof(CALayer))
		{
			Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithLayer:"), other.Handle);
		}
		else
		{
			Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithLayer:"), other.Handle);
			Clone(other);
		}
		MarkDirtyIfDerived();
	}

	private void MarkDirtyIfDerived()
	{
		if (!(GetType() == typeof(CALayer)))
		{
			MarkDirty(allowCustomTypes: true);
		}
	}

	public virtual void Clone(CALayer other)
	{
	}

	private void SetCALayerDelegate(CALayerDelegate value)
	{
		if (calayerdelegate != null)
		{
			CALayerDelegate cALayerDelegate = (CALayerDelegate)calayerdelegate.Target;
			if (cALayerDelegate == value)
			{
				return;
			}
			cALayerDelegate.SetCALayer(null);
		}
		if (value == null)
		{
			calayerdelegate = null;
			return;
		}
		calayerdelegate = new WeakReference(value);
		value.SetCALayer(this);
	}

	private void OnDispose()
	{
		if (calayerdelegate != null)
		{
			CALayerDelegate cALayerDelegate = (CALayerDelegate)calayerdelegate.Target;
			if (cALayerDelegate != null)
			{
				WeakDelegate = null;
			}
		}
	}

	public T GetContentsAs<T>() where T : NSObject
	{
		return Runtime.GetNSObject<T>(_Contents);
	}

	public void SetContents(NSObject value)
	{
		_Contents = value?.Handle ?? IntPtr.Zero;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CALayer()
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
		MarkDirtyIfDerived();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CALayer(NSCoder coder)
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
		MarkDirtyIfDerived();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CALayer(NSObjectFlag t)
		: base(t)
	{
		MarkDirtyIfDerived();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CALayer(IntPtr handle)
		: base(handle)
	{
		MarkDirtyIfDerived();
	}

	[Export("actionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ActionForKey(string eventKey)
	{
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		IntPtr arg = NSString.CreateNative(eventKey);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selActionForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selActionForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addAnimation:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(CAAnimation animation, string? key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimation_ForKey_Handle, animation.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimation_ForKey_Handle, animation.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addConstraint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddConstraint(CAConstraint c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraint_Handle, c.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraint_Handle, c.Handle);
		}
	}

	[Export("addSublayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSublayer(CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSublayer_Handle, layer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSublayer_Handle, layer.Handle);
		}
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAAnimation AnimationForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		CAAnimation result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, arg)) : Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("containsPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(CGPoint p)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, p);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, p);
	}

	[Export("convertPoint:fromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromLayer(CGPoint point, CALayer? layer)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_FromLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_FromLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertPoint:toLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToLayer(CGPoint point, CALayer? layer)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToLayer_Handle, point, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertRect:fromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromLayer(CGRect rect, CALayer? layer)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_FromLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_FromLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertRect:toLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToLayer(CGRect rect, CALayer? layer)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_ToLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_ToLayer_Handle, rect, layer?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertTime:fromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ConvertTimeFromLayer(double timeInterval, CALayer? layer)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double_IntPtr(base.Handle, selConvertTime_FromLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.Double_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selConvertTime_FromLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("convertTime:toLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ConvertTimeToLayer(double timeInterval, CALayer? layer)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double_IntPtr(base.Handle, selConvertTime_ToLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
		}
		return Messaging.Double_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selConvertTime_ToLayer_Handle, timeInterval, layer?.Handle ?? IntPtr.Zero);
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("defaultActionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("defaultValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultValue(string? key)
	{
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("display")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Display()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	[Export("displayIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeeded()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededHandle);
		}
	}

	[Export("drawInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInContext(CGContext ctx)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawInContext_Handle, ctx.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawInContext_Handle, ctx.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("cornerCurveExpansionFactor:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetCornerCurveExpansionFactor([BindAs(typeof(CACornerCurve), OriginalType = typeof(NSString))] CACornerCurve curve)
	{
		NSString constant = curve.GetConstant();
		return Messaging.nfloat_objc_msgSend_IntPtr(class_ptr, selCornerCurveExpansionFactor_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
	}

	[Export("hitTest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer HitTest(CGPoint p)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selHitTest_Handle, p));
		}
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selHitTest_Handle, p));
	}

	[Export("insertSublayer:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSublayer(CALayer layer, int index)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertSublayer_AtIndex_Handle, layer.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertSublayer_AtIndex_Handle, layer.Handle, index);
		}
	}

	[Export("insertSublayer:above:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSublayer_Above_Handle, layer.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSublayer_Above_Handle, layer.Handle, sibling.Handle);
		}
	}

	[Export("insertSublayer:below:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSublayer_Below_Handle, layer.Handle, sibling.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSublayer_Below_Handle, layer.Handle, sibling.Handle);
		}
	}

	[Export("layoutIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutIfNeeded()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutIfNeededHandle);
		}
	}

	[Export("layoutSublayers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutSublayers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutSublayersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutSublayersHandle);
		}
	}

	[Export("needsDisplayForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("needsLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsLayout()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selNeedsLayoutHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsLayoutHandle);
	}

	[Export("preferredFrameSize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize PreferredFrameSize()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredFrameSizeHandle);
		}
		return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredFrameSizeHandle);
	}

	[Export("removeAllAnimations")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllAnimations()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAnimationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAnimationsHandle);
		}
	}

	[Export("removeAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnimationForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnimationForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeFromSuperlayer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFromSuperLayer()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperlayerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperlayerHandle);
		}
	}

	[Export("renderInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenderInContext(CGContext ctx)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRenderInContext_Handle, ctx.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRenderInContext_Handle, ctx.Handle);
		}
	}

	[Export("replaceSublayer:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceSublayer_With_Handle, layer.Handle, with.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceSublayer_With_Handle, layer.Handle, with.Handle);
		}
	}

	[Export("resizeWithOldSuperlayerSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resize(CGSize oldSuperlayerSize)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeWithOldSuperlayerSize_Handle, oldSuperlayerSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeWithOldSuperlayerSize_Handle, oldSuperlayerSize);
		}
	}

	[Export("resizeSublayersWithOldSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResizeSublayers(CGSize oldSize)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeSublayersWithOldSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeSublayersWithOldSize_Handle, oldSize);
		}
	}

	[Export("scrollPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollPoint(CGPoint p)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollPoint_Handle, p);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollPoint_Handle, p);
		}
	}

	[Export("scrollRectToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollRectToVisible(CGRect r)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollRectToVisible_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollRectToVisible_Handle, r);
		}
	}

	[Export("setNeedsDisplay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsDisplayHandle);
		}
	}

	[Export("setNeedsDisplayInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplayInRect(CGRect r)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetNeedsDisplayInRect_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetNeedsDisplayInRect_Handle, r);
		}
	}

	[Export("setNeedsLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsLayout()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		OnDispose();
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

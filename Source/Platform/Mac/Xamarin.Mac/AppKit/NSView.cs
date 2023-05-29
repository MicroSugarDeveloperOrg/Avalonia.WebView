using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSView", true)]
public class NSView : NSResponder
{
	public static class Notifications
	{
		public static NSObject ObserveFrameChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(FrameChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFocusChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveBoundsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(BoundsChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveGlobalFrameChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(GlobalFrameChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUpdatedTrackingAreas(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(UpdatedTrackingAreasNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private object __mt_tracking_var;

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	private static readonly IntPtr selSuperviewHandle = Selector.GetHandle("superview");

	private static readonly IntPtr selOpaqueAncestorHandle = Selector.GetHandle("opaqueAncestor");

	private static readonly IntPtr selIsHiddenOrHasHiddenAncestorHandle = Selector.GetHandle("isHiddenOrHasHiddenAncestor");

	private static readonly IntPtr selWantsDefaultClippingHandle = Selector.GetHandle("wantsDefaultClipping");

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	private static readonly IntPtr selIsRotatedFromBaseHandle = Selector.GetHandle("isRotatedFromBase");

	private static readonly IntPtr selIsRotatedOrScaledFromBaseHandle = Selector.GetHandle("isRotatedOrScaledFromBase");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selNeedsPanelToBecomeKeyHandle = Selector.GetHandle("needsPanelToBecomeKey");

	private static readonly IntPtr selMouseDownCanMoveWindowHandle = Selector.GetHandle("mouseDownCanMoveWindow");

	private static readonly IntPtr selShouldDrawColorHandle = Selector.GetHandle("shouldDrawColor");

	private static readonly IntPtr selEnclosingScrollViewHandle = Selector.GetHandle("enclosingScrollView");

	private static readonly IntPtr selInLiveResizeHandle = Selector.GetHandle("inLiveResize");

	private static readonly IntPtr selPreservesContentDuringLiveResizeHandle = Selector.GetHandle("preservesContentDuringLiveResize");

	private static readonly IntPtr selRectPreservedDuringLiveResizeHandle = Selector.GetHandle("rectPreservedDuringLiveResize");

	private static readonly IntPtr selInputContextHandle = Selector.GetHandle("inputContext");

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	private static readonly IntPtr selSubviewsHandle = Selector.GetHandle("subviews");

	private static readonly IntPtr selSetSubviews_Handle = Selector.GetHandle("setSubviews:");

	private static readonly IntPtr selPostsFrameChangedNotificationsHandle = Selector.GetHandle("postsFrameChangedNotifications");

	private static readonly IntPtr selSetPostsFrameChangedNotifications_Handle = Selector.GetHandle("setPostsFrameChangedNotifications:");

	private static readonly IntPtr selAutoresizesSubviewsHandle = Selector.GetHandle("autoresizesSubviews");

	private static readonly IntPtr selSetAutoresizesSubviews_Handle = Selector.GetHandle("setAutoresizesSubviews:");

	private static readonly IntPtr selAutoresizingMaskHandle = Selector.GetHandle("autoresizingMask");

	private static readonly IntPtr selSetAutoresizingMask_Handle = Selector.GetHandle("setAutoresizingMask:");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	private static readonly IntPtr selFrameRotationHandle = Selector.GetHandle("frameRotation");

	private static readonly IntPtr selSetFrameRotation_Handle = Selector.GetHandle("setFrameRotation:");

	private static readonly IntPtr selFrameCenterRotationHandle = Selector.GetHandle("frameCenterRotation");

	private static readonly IntPtr selSetFrameCenterRotation_Handle = Selector.GetHandle("setFrameCenterRotation:");

	private static readonly IntPtr selBoundsRotationHandle = Selector.GetHandle("boundsRotation");

	private static readonly IntPtr selSetBoundsRotation_Handle = Selector.GetHandle("setBoundsRotation:");

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	private static readonly IntPtr selCanDrawConcurrentlyHandle = Selector.GetHandle("canDrawConcurrently");

	private static readonly IntPtr selSetCanDrawConcurrently_Handle = Selector.GetHandle("setCanDrawConcurrently:");

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	private static readonly IntPtr selSetNeedsDisplay_Handle = Selector.GetHandle("setNeedsDisplay:");

	private static readonly IntPtr selAcceptsTouchEventsHandle = Selector.GetHandle("acceptsTouchEvents");

	private static readonly IntPtr selSetAcceptsTouchEvents_Handle = Selector.GetHandle("setAcceptsTouchEvents:");

	private static readonly IntPtr selWantsRestingTouchesHandle = Selector.GetHandle("wantsRestingTouches");

	private static readonly IntPtr selSetWantsRestingTouches_Handle = Selector.GetHandle("setWantsRestingTouches:");

	private static readonly IntPtr selLayerContentsRedrawPolicyHandle = Selector.GetHandle("layerContentsRedrawPolicy");

	private static readonly IntPtr selSetLayerContentsRedrawPolicy_Handle = Selector.GetHandle("setLayerContentsRedrawPolicy:");

	private static readonly IntPtr selLayerContentsPlacementHandle = Selector.GetHandle("layerContentsPlacement");

	private static readonly IntPtr selSetLayerContentsPlacement_Handle = Selector.GetHandle("setLayerContentsPlacement:");

	private static readonly IntPtr selWantsLayerHandle = Selector.GetHandle("wantsLayer");

	private static readonly IntPtr selSetWantsLayer_Handle = Selector.GetHandle("setWantsLayer:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr selSetLayer_Handle = Selector.GetHandle("setLayer:");

	private static readonly IntPtr selAlphaValueHandle = Selector.GetHandle("alphaValue");

	private static readonly IntPtr selSetAlphaValue_Handle = Selector.GetHandle("setAlphaValue:");

	private static readonly IntPtr selBackgroundFiltersHandle = Selector.GetHandle("backgroundFilters");

	private static readonly IntPtr selSetBackgroundFilters_Handle = Selector.GetHandle("setBackgroundFilters:");

	private static readonly IntPtr selCompositingFilterHandle = Selector.GetHandle("compositingFilter");

	private static readonly IntPtr selSetCompositingFilter_Handle = Selector.GetHandle("setCompositingFilter:");

	private static readonly IntPtr selContentFiltersHandle = Selector.GetHandle("contentFilters");

	private static readonly IntPtr selSetContentFilters_Handle = Selector.GetHandle("setContentFilters:");

	private static readonly IntPtr selShadowHandle = Selector.GetHandle("shadow");

	private static readonly IntPtr selSetShadow_Handle = Selector.GetHandle("setShadow:");

	private static readonly IntPtr selPostsBoundsChangedNotificationsHandle = Selector.GetHandle("postsBoundsChangedNotifications");

	private static readonly IntPtr selSetPostsBoundsChangedNotifications_Handle = Selector.GetHandle("setPostsBoundsChangedNotifications:");

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	private static readonly IntPtr selSetToolTip_Handle = Selector.GetHandle("setToolTip:");

	private static readonly IntPtr selIsInFullScreenModeHandle = Selector.GetHandle("isInFullScreenMode");

	private static readonly IntPtr selConstraintsHandle = Selector.GetHandle("constraints");

	private static readonly IntPtr selNeedsUpdateConstraintsHandle = Selector.GetHandle("needsUpdateConstraints");

	private static readonly IntPtr selSetNeedsUpdateConstraints_Handle = Selector.GetHandle("setNeedsUpdateConstraints:");

	private static readonly IntPtr selNeedsLayoutHandle = Selector.GetHandle("needsLayout");

	private static readonly IntPtr selSetNeedsLayout_Handle = Selector.GetHandle("setNeedsLayout:");

	private static readonly IntPtr selTranslatesAutoresizingMaskIntoConstraintsHandle = Selector.GetHandle("translatesAutoresizingMaskIntoConstraints");

	private static readonly IntPtr selSetTranslatesAutoresizingMaskIntoConstraints_Handle = Selector.GetHandle("setTranslatesAutoresizingMaskIntoConstraints:");

	private static readonly IntPtr selAlignmentRectInsetsHandle = Selector.GetHandle("alignmentRectInsets");

	private static readonly IntPtr selBaselineOffsetFromBottomHandle = Selector.GetHandle("baselineOffsetFromBottom");

	private static readonly IntPtr selIntrinsicContentSizeHandle = Selector.GetHandle("intrinsicContentSize");

	private static readonly IntPtr selFittingSizeHandle = Selector.GetHandle("fittingSize");

	private static readonly IntPtr selHasAmbiguousLayoutHandle = Selector.GetHandle("hasAmbiguousLayout");

	private static readonly IntPtr selNextKeyViewHandle = Selector.GetHandle("nextKeyView");

	private static readonly IntPtr selSetNextKeyView_Handle = Selector.GetHandle("setNextKeyView:");

	private static readonly IntPtr selPreviousKeyViewHandle = Selector.GetHandle("previousKeyView");

	private static readonly IntPtr selNextValidKeyViewHandle = Selector.GetHandle("nextValidKeyView");

	private static readonly IntPtr selPreviousValidKeyViewHandle = Selector.GetHandle("previousValidKeyView");

	private static readonly IntPtr selCanBecomeKeyViewHandle = Selector.GetHandle("canBecomeKeyView");

	private static readonly IntPtr selFocusRingTypeHandle = Selector.GetHandle("focusRingType");

	private static readonly IntPtr selSetFocusRingType_Handle = Selector.GetHandle("setFocusRingType:");

	private static readonly IntPtr selDefaultFocusRingTypeHandle = Selector.GetHandle("defaultFocusRingType");

	private static readonly IntPtr selFocusRingMaskBoundsHandle = Selector.GetHandle("focusRingMaskBounds");

	private static readonly IntPtr selIsDrawingFindIndicatorHandle = Selector.GetHandle("isDrawingFindIndicator");

	private static readonly IntPtr selPrintJobTitleHandle = Selector.GetHandle("printJobTitle");

	private static readonly IntPtr selPageHeaderHandle = Selector.GetHandle("pageHeader");

	private static readonly IntPtr selPageFooterHandle = Selector.GetHandle("pageFooter");

	private static readonly IntPtr selHeightAdjustLimitHandle = Selector.GetHandle("heightAdjustLimit");

	private static readonly IntPtr selWidthAdjustLimitHandle = Selector.GetHandle("widthAdjustLimit");

	private static readonly IntPtr selWantsBestResolutionOpenGLSurfaceHandle = Selector.GetHandle("wantsBestResolutionOpenGLSurface");

	private static readonly IntPtr selSetWantsBestResolutionOpenGLSurface_Handle = Selector.GetHandle("setWantsBestResolutionOpenGLSurface:");

	private static readonly IntPtr selWantsPeriodicDraggingUpdatesHandle = Selector.GetHandle("wantsPeriodicDraggingUpdates");

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selIsDescendantOf_Handle = Selector.GetHandle("isDescendantOf:");

	private static readonly IntPtr selAncestorSharedWithView_Handle = Selector.GetHandle("ancestorSharedWithView:");

	private static readonly IntPtr selNeedsToDrawRect_Handle = Selector.GetHandle("needsToDrawRect:");

	private static readonly IntPtr selViewDidHideHandle = Selector.GetHandle("viewDidHide");

	private static readonly IntPtr selViewDidUnhideHandle = Selector.GetHandle("viewDidUnhide");

	private static readonly IntPtr selAddSubview_Handle = Selector.GetHandle("addSubview:");

	private static readonly IntPtr selAddSubviewPositionedRelativeTo_Handle = Selector.GetHandle("addSubview:positioned:relativeTo:");

	private static readonly IntPtr selViewWillMoveToWindow_Handle = Selector.GetHandle("viewWillMoveToWindow:");

	private static readonly IntPtr selViewDidMoveToWindowHandle = Selector.GetHandle("viewDidMoveToWindow");

	private static readonly IntPtr selViewWillMoveToSuperview_Handle = Selector.GetHandle("viewWillMoveToSuperview:");

	private static readonly IntPtr selViewDidMoveToSuperviewHandle = Selector.GetHandle("viewDidMoveToSuperview");

	private static readonly IntPtr selDidAddSubview_Handle = Selector.GetHandle("didAddSubview:");

	private static readonly IntPtr selWillRemoveSubview_Handle = Selector.GetHandle("willRemoveSubview:");

	private static readonly IntPtr selRemoveFromSuperviewHandle = Selector.GetHandle("removeFromSuperview");

	private static readonly IntPtr selReplaceSubviewWith_Handle = Selector.GetHandle("replaceSubview:with:");

	private static readonly IntPtr selRemoveFromSuperviewWithoutNeedingDisplayHandle = Selector.GetHandle("removeFromSuperviewWithoutNeedingDisplay");

	private static readonly IntPtr selResizeSubviewsWithOldSize_Handle = Selector.GetHandle("resizeSubviewsWithOldSize:");

	private static readonly IntPtr selResizeWithOldSuperviewSize_Handle = Selector.GetHandle("resizeWithOldSuperviewSize:");

	private static readonly IntPtr selSetFrameOrigin_Handle = Selector.GetHandle("setFrameOrigin:");

	private static readonly IntPtr selSetFrameSize_Handle = Selector.GetHandle("setFrameSize:");

	private static readonly IntPtr selSetBoundsOrigin_Handle = Selector.GetHandle("setBoundsOrigin:");

	private static readonly IntPtr selSetBoundsSize_Handle = Selector.GetHandle("setBoundsSize:");

	private static readonly IntPtr selTranslateOriginToPoint_Handle = Selector.GetHandle("translateOriginToPoint:");

	private static readonly IntPtr selScaleUnitSquareToSize_Handle = Selector.GetHandle("scaleUnitSquareToSize:");

	private static readonly IntPtr selRotateByAngle_Handle = Selector.GetHandle("rotateByAngle:");

	private static readonly IntPtr selConvertPointFromView_Handle = Selector.GetHandle("convertPoint:fromView:");

	private static readonly IntPtr selConvertPointToView_Handle = Selector.GetHandle("convertPoint:toView:");

	private static readonly IntPtr selConvertSizeFromView_Handle = Selector.GetHandle("convertSize:fromView:");

	private static readonly IntPtr selConvertSizeToView_Handle = Selector.GetHandle("convertSize:toView:");

	private static readonly IntPtr selConvertRectFromView_Handle = Selector.GetHandle("convertRect:fromView:");

	private static readonly IntPtr selConvertRectToView_Handle = Selector.GetHandle("convertRect:toView:");

	private static readonly IntPtr selCenterScanRect_Handle = Selector.GetHandle("centerScanRect:");

	private static readonly IntPtr selConvertPointToBase_Handle = Selector.GetHandle("convertPointToBase:");

	private static readonly IntPtr selConvertPointFromBase_Handle = Selector.GetHandle("convertPointFromBase:");

	private static readonly IntPtr selConvertSizeToBase_Handle = Selector.GetHandle("convertSizeToBase:");

	private static readonly IntPtr selConvertSizeFromBase_Handle = Selector.GetHandle("convertSizeFromBase:");

	private static readonly IntPtr selConvertRectToBase_Handle = Selector.GetHandle("convertRectToBase:");

	private static readonly IntPtr selConvertRectFromBase_Handle = Selector.GetHandle("convertRectFromBase:");

	private static readonly IntPtr selCanDrawHandle = Selector.GetHandle("canDraw");

	private static readonly IntPtr selSetNeedsDisplayInRect_Handle = Selector.GetHandle("setNeedsDisplayInRect:");

	private static readonly IntPtr selLockFocusHandle = Selector.GetHandle("lockFocus");

	private static readonly IntPtr selUnlockFocusHandle = Selector.GetHandle("unlockFocus");

	private static readonly IntPtr selLockFocusIfCanDrawHandle = Selector.GetHandle("lockFocusIfCanDraw");

	private static readonly IntPtr selLockFocusIfCanDrawInContext_Handle = Selector.GetHandle("lockFocusIfCanDrawInContext:");

	private static readonly IntPtr selFocusViewHandle = Selector.GetHandle("focusView");

	private static readonly IntPtr selVisibleRectHandle = Selector.GetHandle("visibleRect");

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	private static readonly IntPtr selDisplayIfNeededIgnoringOpacityHandle = Selector.GetHandle("displayIfNeededIgnoringOpacity");

	private static readonly IntPtr selDisplayRect_Handle = Selector.GetHandle("displayRect:");

	private static readonly IntPtr selDisplayIfNeededInRect_Handle = Selector.GetHandle("displayIfNeededInRect:");

	private static readonly IntPtr selDisplayRectIgnoringOpacity_Handle = Selector.GetHandle("displayRectIgnoringOpacity:");

	private static readonly IntPtr selDisplayIfNeededInRectIgnoringOpacity_Handle = Selector.GetHandle("displayIfNeededInRectIgnoringOpacity:");

	private static readonly IntPtr selDrawRect_Handle = Selector.GetHandle("drawRect:");

	private static readonly IntPtr selDisplayRectIgnoringOpacityInContext_Handle = Selector.GetHandle("displayRectIgnoringOpacity:inContext:");

	private static readonly IntPtr selBitmapImageRepForCachingDisplayInRect_Handle = Selector.GetHandle("bitmapImageRepForCachingDisplayInRect:");

	private static readonly IntPtr selCacheDisplayInRectToBitmapImageRep_Handle = Selector.GetHandle("cacheDisplayInRect:toBitmapImageRep:");

	private static readonly IntPtr selViewWillDrawHandle = Selector.GetHandle("viewWillDraw");

	private static readonly IntPtr selGStateHandle = Selector.GetHandle("gState");

	private static readonly IntPtr selAllocateGStateHandle = Selector.GetHandle("allocateGState");

	private static readonly IntPtr selReleaseGStateHandle = Selector.GetHandle("releaseGState");

	private static readonly IntPtr selSetUpGStateHandle = Selector.GetHandle("setUpGState");

	private static readonly IntPtr selRenewGStateHandle = Selector.GetHandle("renewGState");

	private static readonly IntPtr selScrollPoint_Handle = Selector.GetHandle("scrollPoint:");

	private static readonly IntPtr selScrollRectToVisible_Handle = Selector.GetHandle("scrollRectToVisible:");

	private static readonly IntPtr selAutoscroll_Handle = Selector.GetHandle("autoscroll:");

	private static readonly IntPtr selAdjustScroll_Handle = Selector.GetHandle("adjustScroll:");

	private static readonly IntPtr selScrollRectBy_Handle = Selector.GetHandle("scrollRect:by:");

	private static readonly IntPtr selTranslateRectsNeedingDisplayInRectBy_Handle = Selector.GetHandle("translateRectsNeedingDisplayInRect:by:");

	private static readonly IntPtr selHitTest_Handle = Selector.GetHandle("hitTest:");

	private static readonly IntPtr selMouseInRect_Handle = Selector.GetHandle("mouse:inRect:");

	private static readonly IntPtr selViewWithTag_Handle = Selector.GetHandle("viewWithTag:");

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	private static readonly IntPtr selAcceptsFirstMouse_Handle = Selector.GetHandle("acceptsFirstMouse:");

	private static readonly IntPtr selShouldDelayWindowOrderingForEvent_Handle = Selector.GetHandle("shouldDelayWindowOrderingForEvent:");

	private static readonly IntPtr selAddCursorRectCursor_Handle = Selector.GetHandle("addCursorRect:cursor:");

	private static readonly IntPtr selRemoveCursorRectCursor_Handle = Selector.GetHandle("removeCursorRect:cursor:");

	private static readonly IntPtr selDiscardCursorRectsHandle = Selector.GetHandle("discardCursorRects");

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	private static readonly IntPtr selAddTrackingRectOwnerUserDataAssumeInside_Handle = Selector.GetHandle("addTrackingRect:owner:userData:assumeInside:");

	private static readonly IntPtr selRemoveTrackingRect_Handle = Selector.GetHandle("removeTrackingRect:");

	private static readonly IntPtr selMakeBackingLayerHandle = Selector.GetHandle("makeBackingLayer");

	private static readonly IntPtr selAddTrackingArea_Handle = Selector.GetHandle("addTrackingArea:");

	private static readonly IntPtr selRemoveTrackingArea_Handle = Selector.GetHandle("removeTrackingArea:");

	private static readonly IntPtr selTrackingAreasHandle = Selector.GetHandle("trackingAreas");

	private static readonly IntPtr selUpdateTrackingAreasHandle = Selector.GetHandle("updateTrackingAreas");

	private static readonly IntPtr selMenuForEvent_Handle = Selector.GetHandle("menuForEvent:");

	private static readonly IntPtr selDefaultMenuHandle = Selector.GetHandle("defaultMenu");

	private static readonly IntPtr selAddToolTipRectOwnerUserData_Handle = Selector.GetHandle("addToolTipRect:owner:userData:");

	private static readonly IntPtr selRemoveToolTip_Handle = Selector.GetHandle("removeToolTip:");

	private static readonly IntPtr selRemoveAllToolTipsHandle = Selector.GetHandle("removeAllToolTips");

	private static readonly IntPtr selViewWillStartLiveResizeHandle = Selector.GetHandle("viewWillStartLiveResize");

	private static readonly IntPtr selViewDidEndLiveResizeHandle = Selector.GetHandle("viewDidEndLiveResize");

	private static readonly IntPtr selRegisterForDraggedTypes_Handle = Selector.GetHandle("registerForDraggedTypes:");

	private static readonly IntPtr selUnregisterDraggedTypesHandle = Selector.GetHandle("unregisterDraggedTypes");

	private static readonly IntPtr selRegisteredDraggedTypesHandle = Selector.GetHandle("registeredDraggedTypes");

	private static readonly IntPtr selBeginDraggingSessionWithItemsEventSource_Handle = Selector.GetHandle("beginDraggingSessionWithItems:event:source:");

	private static readonly IntPtr selDragImageAtOffsetEventPasteboardSourceSlideBack_Handle = Selector.GetHandle("dragImage:at:offset:event:pasteboard:source:slideBack:");

	private static readonly IntPtr selDragFileFromRectSlideBackEvent_Handle = Selector.GetHandle("dragFile:fromRect:slideBack:event:");

	private static readonly IntPtr selDragPromisedFilesOfTypesFromRectSourceSlideBackEvent_Handle = Selector.GetHandle("dragPromisedFilesOfTypes:fromRect:source:slideBack:event:");

	private static readonly IntPtr selExitFullScreenModeWithOptions_Handle = Selector.GetHandle("exitFullScreenModeWithOptions:");

	private static readonly IntPtr selEnterFullScreenModeWithOptions_Handle = Selector.GetHandle("enterFullScreenMode:withOptions:");

	private static readonly IntPtr selAddConstraint_Handle = Selector.GetHandle("addConstraint:");

	private static readonly IntPtr selAddConstraints_Handle = Selector.GetHandle("addConstraints:");

	private static readonly IntPtr selRemoveConstraint_Handle = Selector.GetHandle("removeConstraint:");

	private static readonly IntPtr selRemoveConstraints_Handle = Selector.GetHandle("removeConstraints:");

	private static readonly IntPtr selLayoutSubtreeIfNeededHandle = Selector.GetHandle("layoutSubtreeIfNeeded");

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	private static readonly IntPtr selUpdateConstraintsHandle = Selector.GetHandle("updateConstraints");

	private static readonly IntPtr selUpdateConstraintsForSubtreeIfNeededHandle = Selector.GetHandle("updateConstraintsForSubtreeIfNeeded");

	private static readonly IntPtr selRequiresConstraintBasedLayoutHandle = Selector.GetHandle("requiresConstraintBasedLayout");

	private static readonly IntPtr selAlignmentRectForFrame_Handle = Selector.GetHandle("alignmentRectForFrame:");

	private static readonly IntPtr selFrameForAlignmentRect_Handle = Selector.GetHandle("frameForAlignmentRect:");

	private static readonly IntPtr selInvalidateIntrinsicContentSizeHandle = Selector.GetHandle("invalidateIntrinsicContentSize");

	private static readonly IntPtr selContentHuggingPriorityForOrientation_Handle = Selector.GetHandle("contentHuggingPriorityForOrientation:");

	private static readonly IntPtr selSetContentHuggingPriorityForOrientation_Handle = Selector.GetHandle("setContentHuggingPriority:forOrientation:");

	private static readonly IntPtr selContentCompressionResistancePriorityForOrientation_Handle = Selector.GetHandle("contentCompressionResistancePriorityForOrientation:");

	private static readonly IntPtr selSetContentCompressionResistancePriorityForOrientation_Handle = Selector.GetHandle("setContentCompressionResistancePriority:forOrientation:");

	private static readonly IntPtr selConstraintsAffectingLayoutForOrientation_Handle = Selector.GetHandle("constraintsAffectingLayoutForOrientation:");

	private static readonly IntPtr selExerciseAmbiguityInLayoutHandle = Selector.GetHandle("exerciseAmbiguityInLayout");

	private static readonly IntPtr selPerformMnemonic_Handle = Selector.GetHandle("performMnemonic:");

	private static readonly IntPtr selSetKeyboardFocusRingNeedsDisplayInRect_Handle = Selector.GetHandle("setKeyboardFocusRingNeedsDisplayInRect:");

	private static readonly IntPtr selDrawFocusRingMaskHandle = Selector.GetHandle("drawFocusRingMask");

	private static readonly IntPtr selNoteFocusRingMaskChangedHandle = Selector.GetHandle("noteFocusRingMaskChanged");

	private static readonly IntPtr selDataWithEPSInsideRect_Handle = Selector.GetHandle("dataWithEPSInsideRect:");

	private static readonly IntPtr selDataWithPDFInsideRect_Handle = Selector.GetHandle("dataWithPDFInsideRect:");

	private static readonly IntPtr selPrint_Handle = Selector.GetHandle("print:");

	private static readonly IntPtr selWriteEPSInsideRectToPasteboard_Handle = Selector.GetHandle("writeEPSInsideRect:toPasteboard:");

	private static readonly IntPtr selWritePDFInsideRectToPasteboard_Handle = Selector.GetHandle("writePDFInsideRect:toPasteboard:");

	private static readonly IntPtr selDrawPageBorderWithSize_Handle = Selector.GetHandle("drawPageBorderWithSize:");

	private static readonly IntPtr selDrawSheetBorderWithSize_Handle = Selector.GetHandle("drawSheetBorderWithSize:");

	private static readonly IntPtr selAdjustPageWidthNewLeftRightLimit_Handle = Selector.GetHandle("adjustPageWidthNew:left:right:limit:");

	private static readonly IntPtr selAdjustPageHeightNewTopBottomLimit_Handle = Selector.GetHandle("adjustPageHeightNew:top:bottom:limit:");

	private static readonly IntPtr selKnowsPageRange_Handle = Selector.GetHandle("knowsPageRange:");

	private static readonly IntPtr selRectForPage_Handle = Selector.GetHandle("rectForPage:");

	private static readonly IntPtr selLocationOfPrintRect_Handle = Selector.GetHandle("locationOfPrintRect:");

	private static readonly IntPtr selBackingAlignedRectOptions_Handle = Selector.GetHandle("backingAlignedRect:options:");

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	private static readonly IntPtr selConvertRectFromLayer_Handle = Selector.GetHandle("convertRectFromLayer:");

	private static readonly IntPtr selConvertRectToLayer_Handle = Selector.GetHandle("convertRectToLayer:");

	private static readonly IntPtr selConvertPointFromBacking_Handle = Selector.GetHandle("convertPointFromBacking:");

	private static readonly IntPtr selConvertPointToBacking_Handle = Selector.GetHandle("convertPointToBacking:");

	private static readonly IntPtr selConvertPointFromLayer_Handle = Selector.GetHandle("convertPointFromLayer:");

	private static readonly IntPtr selConvertPointToLayer_Handle = Selector.GetHandle("convertPointToLayer:");

	private static readonly IntPtr selConvertSizeFromBacking_Handle = Selector.GetHandle("convertSizeFromBacking:");

	private static readonly IntPtr selConvertSizeToBacking_Handle = Selector.GetHandle("convertSizeToBacking:");

	private static readonly IntPtr selConvertSizeFromLayer_Handle = Selector.GetHandle("convertSizeFromLayer:");

	private static readonly IntPtr selConvertSizeToLayer_Handle = Selector.GetHandle("convertSizeToLayer:");

	private static readonly IntPtr selDraggingEntered_Handle = Selector.GetHandle("draggingEntered:");

	private static readonly IntPtr selDraggingUpdated_Handle = Selector.GetHandle("draggingUpdated:");

	private static readonly IntPtr selDraggingExited_Handle = Selector.GetHandle("draggingExited:");

	private static readonly IntPtr selPrepareForDragOperation_Handle = Selector.GetHandle("prepareForDragOperation:");

	private static readonly IntPtr selPerformDragOperation_Handle = Selector.GetHandle("performDragOperation:");

	private static readonly IntPtr selConcludeDragOperation_Handle = Selector.GetHandle("concludeDragOperation:");

	private static readonly IntPtr selDraggingEnded_Handle = Selector.GetHandle("draggingEnded:");

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSView");

	private object __mt_Window_var;

	private object __mt_Superview_var;

	private object __mt_OpaqueAncestor_var;

	private object __mt_EnclosingScrollView_var;

	private object __mt_InputContext_var;

	private object __mt_Subviews_var;

	private object __mt_Layer_var;

	private object __mt_BackgroundFilters_var;

	private object __mt_CompositingFilter_var;

	private object __mt_ContentFilters_var;

	private object __mt_Shadow_var;

	private object __mt_Constraints_var;

	private object __mt_NextKeyView_var;

	private object __mt_PreviousKeyView_var;

	private object __mt_NextValidKeyView_var;

	private object __mt_PreviousValidKeyView_var;

	private object __mt_PageHeader_var;

	private object __mt_PageFooter_var;

	private object __mt_Animator_var;

	private object __mt_Animations_var;

	private static NSString _NSFullScreenModeApplicationPresentationOptions;

	private static NSString _NSFullScreenModeAllScreens;

	private static NSString _NSFullScreenModeSetting;

	private static NSString _NSFullScreenModeWindowLevel;

	private static NSString _FrameChangedNotification;

	private static NSString _FocusChangedNotification;

	private static NSString _BoundsChangedNotification;

	private static NSString _GlobalFrameChangedNotification;

	private static NSString _UpdatedTrackingAreasNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSWindow Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_Window_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle)))));
		}
	}

	public virtual NSView Superview
	{
		[Export("superview")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_Superview_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperviewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperviewHandle)))));
		}
	}

	public virtual NSView OpaqueAncestor
	{
		[Export("opaqueAncestor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_OpaqueAncestor_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpaqueAncestorHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOpaqueAncestorHandle)))));
		}
	}

	public virtual bool IsHiddenOrHasHiddenAncestor
	{
		[Export("isHiddenOrHasHiddenAncestor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenOrHasHiddenAncestorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenOrHasHiddenAncestorHandle);
		}
	}

	public virtual bool WantsDefaultClipping
	{
		[Export("wantsDefaultClipping")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsDefaultClippingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsDefaultClippingHandle);
		}
	}

	public virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	public virtual bool IsRotatedFromBase
	{
		[Export("isRotatedFromBase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRotatedFromBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRotatedFromBaseHandle);
		}
	}

	public virtual bool IsRotatedOrScaledFromBase
	{
		[Export("isRotatedOrScaledFromBase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRotatedOrScaledFromBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRotatedOrScaledFromBaseHandle);
		}
	}

	public virtual bool IsOpaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
	}

	public virtual long Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
	}

	public virtual bool NeedsPanelToBecomeKey
	{
		[Export("needsPanelToBecomeKey")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsPanelToBecomeKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsPanelToBecomeKeyHandle);
		}
	}

	public virtual bool MouseDownCanMoveWindow
	{
		[Export("mouseDownCanMoveWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMouseDownCanMoveWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMouseDownCanMoveWindowHandle);
		}
	}

	public virtual bool ShouldDrawColor
	{
		[Export("shouldDrawColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDrawColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDrawColorHandle);
		}
	}

	public virtual NSScrollView EnclosingScrollView
	{
		[Export("enclosingScrollView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScrollView)(__mt_EnclosingScrollView_var = ((!IsDirectBinding) ? ((NSScrollView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnclosingScrollViewHandle))) : ((NSScrollView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEnclosingScrollViewHandle)))));
		}
	}

	public virtual bool InLiveResize
	{
		[Export("inLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInLiveResizeHandle);
		}
	}

	public virtual bool PreservesContentDuringLiveResize
	{
		[Export("preservesContentDuringLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesContentDuringLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesContentDuringLiveResizeHandle);
		}
	}

	public virtual CGRect RectPreservedDuringLiveResize
	{
		[Export("rectPreservedDuringLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectPreservedDuringLiveResizeHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectPreservedDuringLiveResizeHandle);
			}
			return retval;
		}
	}

	public virtual NSTextInputContext InputContext
	{
		[Export("inputContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextInputContext)(__mt_InputContext_var = ((!IsDirectBinding) ? ((NSTextInputContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputContextHandle))) : ((NSTextInputContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInputContextHandle)))));
		}
	}

	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual NSView[] Subviews
	{
		[Export("subviews")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView[])(__mt_Subviews_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubviewsHandle)) : NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubviewsHandle))));
		}
		[Export("setSubviews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubviews_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubviews_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Subviews_var = value;
		}
	}

	public virtual bool PostsFrameChangedNotifications
	{
		[Export("postsFrameChangedNotifications")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPostsFrameChangedNotificationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPostsFrameChangedNotificationsHandle);
		}
		[Export("setPostsFrameChangedNotifications:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPostsFrameChangedNotifications_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPostsFrameChangedNotifications_Handle, value);
			}
		}
	}

	public virtual bool AutoresizesSubviews
	{
		[Export("autoresizesSubviews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesSubviewsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesSubviewsHandle);
		}
		[Export("setAutoresizesSubviews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizesSubviews_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizesSubviews_Handle, value);
			}
		}
	}

	public virtual NSViewResizingMask AutoresizingMask
	{
		[Export("autoresizingMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSViewResizingMask)Messaging.UInt64_objc_msgSend(base.Handle, selAutoresizingMaskHandle);
			}
			return (NSViewResizingMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAutoresizingMaskHandle);
		}
		[Export("setAutoresizingMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAutoresizingMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAutoresizingMask_Handle, (ulong)value);
			}
		}
	}

	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
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
			NSApplication.EnsureUIThread();
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

	public virtual double FrameRotation
	{
		[Export("frameRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrameRotationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrameRotationHandle);
		}
		[Export("setFrameRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrameRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrameRotation_Handle, value);
			}
		}
	}

	public virtual double FrameCenterRotation
	{
		[Export("frameCenterRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrameCenterRotationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrameCenterRotationHandle);
		}
		[Export("setFrameCenterRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrameCenterRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrameCenterRotation_Handle, value);
			}
		}
	}

	public virtual double BoundsRotation
	{
		[Export("boundsRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBoundsRotationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBoundsRotationHandle);
		}
		[Export("setBoundsRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBoundsRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBoundsRotation_Handle, value);
			}
		}
	}

	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			NSApplication.EnsureUIThread();
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
			NSApplication.EnsureUIThread();
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

	public virtual bool CanDrawConcurrently
	{
		[Export("canDrawConcurrently")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDrawConcurrentlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDrawConcurrentlyHandle);
		}
		[Export("setCanDrawConcurrently:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanDrawConcurrently_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanDrawConcurrently_Handle, value);
			}
		}
	}

	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
		[Export("setNeedsDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplay_Handle, value);
			}
		}
	}

	public virtual bool AcceptsTouchEvents
	{
		[Export("acceptsTouchEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsTouchEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsTouchEventsHandle);
		}
		[Export("setAcceptsTouchEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsTouchEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsTouchEvents_Handle, value);
			}
		}
	}

	public virtual bool WantsRestingTouches
	{
		[Export("wantsRestingTouches")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsRestingTouchesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsRestingTouchesHandle);
		}
		[Export("setWantsRestingTouches:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsRestingTouches_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsRestingTouches_Handle, value);
			}
		}
	}

	public virtual NSViewLayerContentsRedrawPolicy LayerContentsRedrawPolicy
	{
		[Export("layerContentsRedrawPolicy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSViewLayerContentsRedrawPolicy)Messaging.Int64_objc_msgSend(base.Handle, selLayerContentsRedrawPolicyHandle);
			}
			return (NSViewLayerContentsRedrawPolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayerContentsRedrawPolicyHandle);
		}
		[Export("setLayerContentsRedrawPolicy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayerContentsRedrawPolicy_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayerContentsRedrawPolicy_Handle, (long)value);
			}
		}
	}

	public virtual NSViewLayerContentsPlacement LayerContentsPlacement
	{
		[Export("layerContentsPlacement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSViewLayerContentsPlacement)Messaging.Int64_objc_msgSend(base.Handle, selLayerContentsPlacementHandle);
			}
			return (NSViewLayerContentsPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayerContentsPlacementHandle);
		}
		[Export("setLayerContentsPlacement:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayerContentsPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayerContentsPlacement_Handle, (long)value);
			}
		}
	}

	public virtual bool WantsLayer
	{
		[Export("wantsLayer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsLayerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsLayerHandle);
		}
		[Export("setWantsLayer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsLayer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsLayer_Handle, value);
			}
		}
	}

	public virtual CALayer Layer
	{
		[Export("layer")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CALayer)(__mt_Layer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLayerHandle)))));
		}
		[Export("setLayer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Layer_var = value;
		}
	}

	public virtual double AlphaValue
	{
		[Export("alphaValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaValueHandle);
		}
		[Export("setAlphaValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAlphaValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAlphaValue_Handle, value);
			}
		}
	}

	public virtual CIFilter[] BackgroundFilters
	{
		[Export("backgroundFilters")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CIFilter[])(__mt_BackgroundFilters_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundFiltersHandle)) : NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundFiltersHandle))));
		}
		[Export("setBackgroundFilters:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_BackgroundFilters_var = value;
		}
	}

	public virtual CIFilter CompositingFilter
	{
		[Export("compositingFilter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CIFilter)(__mt_CompositingFilter_var = ((!IsDirectBinding) ? ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompositingFilterHandle))) : ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCompositingFilterHandle)))));
		}
		[Export("setCompositingFilter:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_CompositingFilter_var = value;
		}
	}

	public virtual CIFilter[] ContentFilters
	{
		[Export("contentFilters")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CIFilter[])(__mt_ContentFilters_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentFiltersHandle)) : NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentFiltersHandle))));
		}
		[Export("setContentFilters:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_ContentFilters_var = value;
		}
	}

	public virtual NSShadow Shadow
	{
		[Export("shadow")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSShadow)(__mt_Shadow_var = ((!IsDirectBinding) ? ((NSShadow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowHandle))) : ((NSShadow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selShadowHandle)))));
		}
		[Export("setShadow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadow_Handle, value.Handle);
			}
			__mt_Shadow_var = value;
		}
	}

	public virtual bool PostsBoundsChangedNotifications
	{
		[Export("postsBoundsChangedNotifications")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPostsBoundsChangedNotificationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPostsBoundsChangedNotificationsHandle);
		}
		[Export("setPostsBoundsChangedNotifications:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPostsBoundsChangedNotifications_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPostsBoundsChangedNotifications_Handle, value);
			}
		}
	}

	public virtual string ToolTip
	{
		[Export("toolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolTipHandle));
		}
		[Export("setToolTip:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToolTip_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToolTip_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool IsInFullscreenMode
	{
		[Export("isInFullScreenMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInFullScreenModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInFullScreenModeHandle);
		}
	}

	public virtual NSLayoutConstraint[] Constraints
	{
		[Export("constraints")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLayoutConstraint[])(__mt_Constraints_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsHandle)) : NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsHandle))));
		}
	}

	public virtual bool NeedsUpdateConstraints
	{
		[Export("needsUpdateConstraints")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsUpdateConstraintsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsUpdateConstraintsHandle);
		}
		[Export("setNeedsUpdateConstraints:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsUpdateConstraints_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsUpdateConstraints_Handle, value);
			}
		}
	}

	public virtual bool NeedsLayout
	{
		[Export("needsLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsLayoutHandle);
		}
		[Export("setNeedsLayout:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsLayout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsLayout_Handle, value);
			}
		}
	}

	public virtual bool TranslatesAutoresizingMaskIntoConstraints
	{
		[Export("translatesAutoresizingMaskIntoConstraints")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTranslatesAutoresizingMaskIntoConstraintsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTranslatesAutoresizingMaskIntoConstraintsHandle);
		}
		[Export("setTranslatesAutoresizingMaskIntoConstraints:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTranslatesAutoresizingMaskIntoConstraints_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTranslatesAutoresizingMaskIntoConstraints_Handle, value);
			}
		}
	}

	public virtual NSEdgeInsets AlignmentRectInsets
	{
		[Export("alignmentRectInsets")]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selAlignmentRectInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAlignmentRectInsetsHandle);
			}
			return retval;
		}
	}

	public virtual double BaselineOffsetFromBottom
	{
		[Export("baselineOffsetFromBottom")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBaselineOffsetFromBottomHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBaselineOffsetFromBottomHandle);
		}
	}

	public virtual CGSize IntrinsicContentSize
	{
		[Export("intrinsicContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntrinsicContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntrinsicContentSizeHandle);
		}
	}

	public virtual CGSize FittingSize
	{
		[Export("fittingSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selFittingSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selFittingSizeHandle);
		}
	}

	public virtual bool HasAmbiguousLayout
	{
		[Export("hasAmbiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAmbiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAmbiguousLayoutHandle);
		}
	}

	public virtual NSView NextKeyView
	{
		[Export("nextKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_NextKeyView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextKeyViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextKeyViewHandle)))));
		}
		[Export("setNextKeyView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNextKeyView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNextKeyView_Handle, value.Handle);
			}
			__mt_NextKeyView_var = value;
		}
	}

	public virtual NSView PreviousKeyView
	{
		[Export("previousKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_PreviousKeyView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousKeyViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousKeyViewHandle)))));
		}
	}

	public virtual NSView NextValidKeyView
	{
		[Export("nextValidKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_NextValidKeyView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextValidKeyViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextValidKeyViewHandle)))));
		}
	}

	public virtual NSView PreviousValidKeyView
	{
		[Export("previousValidKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_PreviousValidKeyView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousValidKeyViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousValidKeyViewHandle)))));
		}
	}

	public virtual bool CanBecomeKeyView
	{
		[Export("canBecomeKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeKeyViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeKeyViewHandle);
		}
	}

	public virtual NSFocusRingType FocusRingType
	{
		[Export("focusRingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSFocusRingType)Messaging.UInt64_objc_msgSend(base.Handle, selFocusRingTypeHandle);
			}
			return (NSFocusRingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFocusRingTypeHandle);
		}
		[Export("setFocusRingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFocusRingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFocusRingType_Handle, (ulong)value);
			}
		}
	}

	public static NSFocusRingType DefaultFocusRingType
	{
		[Export("defaultFocusRingType")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFocusRingType)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultFocusRingTypeHandle);
		}
	}

	public virtual CGRect FocusRingMaskBounds
	{
		[Export("focusRingMaskBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFocusRingMaskBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFocusRingMaskBoundsHandle);
			}
			return retval;
		}
	}

	public virtual bool IsDrawingFindIndicator
	{
		[Export("isDrawingFindIndicator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDrawingFindIndicatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDrawingFindIndicatorHandle);
		}
	}

	public virtual string PrintJobTitle
	{
		[Export("printJobTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintJobTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintJobTitleHandle));
		}
	}

	public virtual NSAttributedString PageHeader
	{
		[Export("pageHeader")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_PageHeader_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageHeaderHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPageHeaderHandle)))));
		}
	}

	public virtual NSAttributedString PageFooter
	{
		[Export("pageFooter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_PageFooter_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageFooterHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPageFooterHandle)))));
		}
	}

	public virtual double HeightAdjustLimit
	{
		[Export("heightAdjustLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHeightAdjustLimitHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHeightAdjustLimitHandle);
		}
	}

	public virtual double WidthAdjustLimit
	{
		[Export("widthAdjustLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selWidthAdjustLimitHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selWidthAdjustLimitHandle);
		}
	}

	public virtual bool WantsBestResolutionOpenGLSurface
	{
		[Export("wantsBestResolutionOpenGLSurface")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsBestResolutionOpenGLSurfaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsBestResolutionOpenGLSurfaceHandle);
		}
		[Export("setWantsBestResolutionOpenGLSurface:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsBestResolutionOpenGLSurface_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsBestResolutionOpenGLSurface_Handle, value);
			}
		}
	}

	public virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsPeriodicDraggingUpdatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsPeriodicDraggingUpdatesHandle);
		}
	}

	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = (NSObject)(__mt_Animator_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle))));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_Animations_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle)))));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
			__mt_Animations_var = value;
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("NSFullScreenModeApplicationPresentationOptions", "AppKit")]
	public static NSString NSFullScreenModeApplicationPresentationOptions
	{
		get
		{
			if (_NSFullScreenModeApplicationPresentationOptions == null)
			{
				_NSFullScreenModeApplicationPresentationOptions = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeApplicationPresentationOptions");
			}
			return _NSFullScreenModeApplicationPresentationOptions;
		}
	}

	[Field("NSFullScreenModeAllScreens", "AppKit")]
	public static NSString NSFullScreenModeAllScreens
	{
		get
		{
			if (_NSFullScreenModeAllScreens == null)
			{
				_NSFullScreenModeAllScreens = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeAllScreens");
			}
			return _NSFullScreenModeAllScreens;
		}
	}

	[Field("NSFullScreenModeSetting", "AppKit")]
	public static NSString NSFullScreenModeSetting
	{
		get
		{
			if (_NSFullScreenModeSetting == null)
			{
				_NSFullScreenModeSetting = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeSetting");
			}
			return _NSFullScreenModeSetting;
		}
	}

	[Field("NSFullScreenModeWindowLevel", "AppKit")]
	public static NSString NSFullScreenModeWindowLevel
	{
		get
		{
			if (_NSFullScreenModeWindowLevel == null)
			{
				_NSFullScreenModeWindowLevel = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeWindowLevel");
			}
			return _NSFullScreenModeWindowLevel;
		}
	}

	[Field("NSViewFrameDidChangeNotification", "AppKit")]
	public static NSString FrameChangedNotification
	{
		get
		{
			if (_FrameChangedNotification == null)
			{
				_FrameChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewFrameDidChangeNotification");
			}
			return _FrameChangedNotification;
		}
	}

	[Field("NSViewFocusDidChangeNotification", "AppKit")]
	public static NSString FocusChangedNotification
	{
		get
		{
			if (_FocusChangedNotification == null)
			{
				_FocusChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewFocusDidChangeNotification");
			}
			return _FocusChangedNotification;
		}
	}

	[Field("NSViewBoundsDidChangeNotification", "AppKit")]
	public static NSString BoundsChangedNotification
	{
		get
		{
			if (_BoundsChangedNotification == null)
			{
				_BoundsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewBoundsDidChangeNotification");
			}
			return _BoundsChangedNotification;
		}
	}

	[Field("NSViewGlobalFrameDidChangeNotification", "AppKit")]
	public static NSString GlobalFrameChangedNotification
	{
		get
		{
			if (_GlobalFrameChangedNotification == null)
			{
				_GlobalFrameChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewGlobalFrameDidChangeNotification");
			}
			return _GlobalFrameChangedNotification;
		}
	}

	[Field("NSViewDidUpdateTrackingAreasNotification", "AppKit")]
	public static NSString UpdatedTrackingAreasNotification
	{
		get
		{
			if (_UpdatedTrackingAreasNotification == null)
			{
				_UpdatedTrackingAreasNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewDidUpdateTrackingAreasNotification");
			}
			return _UpdatedTrackingAreasNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSView()
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
	public NSView(NSCoder coder)
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
	public NSView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("isDescendantOf:")]
	public virtual bool IsDescendantOf(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDescendantOf_Handle, aView.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDescendantOf_Handle, aView.Handle);
	}

	[Export("ancestorSharedWithView:")]
	public virtual NSView AncestorSharedWithView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAncestorSharedWithView_Handle, aView.Handle));
		}
		return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAncestorSharedWithView_Handle, aView.Handle));
	}

	[Export("needsToDrawRect:")]
	public virtual bool NeedsToDraw(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selNeedsToDrawRect_Handle, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selNeedsToDrawRect_Handle, aRect);
	}

	[Export("viewDidHide")]
	public virtual void ViewDidHide()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidHideHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidHideHandle);
		}
	}

	[Export("viewDidUnhide")]
	public virtual void ViewDidUnhide()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidUnhideHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidUnhideHandle);
		}
	}

	[Export("addSubview:")]
	public virtual void AddSubview(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSubview_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSubview_Handle, aView.Handle);
		}
		_ = Subviews;
	}

	[Export("addSubview:positioned:relativeTo:")]
	public virtual void AddSubview(NSView aView, NSWindowOrderingMode place, NSView otherView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selAddSubviewPositionedRelativeTo_Handle, aView.Handle, (long)place, otherView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selAddSubviewPositionedRelativeTo_Handle, aView.Handle, (long)place, otherView?.Handle ?? IntPtr.Zero);
		}
		_ = Subviews;
	}

	[Export("viewWillMoveToWindow:")]
	public virtual void ViewWillMoveToWindow(NSWindow newWindow)
	{
		NSApplication.EnsureUIThread();
		if (newWindow == null)
		{
			throw new ArgumentNullException("newWindow");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewWillMoveToWindow_Handle, newWindow.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewWillMoveToWindow_Handle, newWindow.Handle);
		}
	}

	[Export("viewDidMoveToWindow")]
	public virtual void ViewDidMoveToWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidMoveToWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidMoveToWindowHandle);
		}
	}

	[Export("viewWillMoveToSuperview:")]
	public virtual void ViewWillMoveToSuperview(NSView newSuperview)
	{
		NSApplication.EnsureUIThread();
		if (newSuperview == null)
		{
			throw new ArgumentNullException("newSuperview");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewWillMoveToSuperview_Handle, newSuperview.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewWillMoveToSuperview_Handle, newSuperview.Handle);
		}
	}

	[Export("viewDidMoveToSuperview")]
	public virtual void ViewDidMoveToSuperview()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidMoveToSuperviewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidMoveToSuperviewHandle);
		}
	}

	[Export("didAddSubview:")]
	public virtual void DidAddSubview(NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAddSubview_Handle, subview.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAddSubview_Handle, subview.Handle);
		}
	}

	[Export("willRemoveSubview:")]
	public virtual void WillRemoveSubview(NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveSubview_Handle, subview.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveSubview_Handle, subview.Handle);
		}
	}

	[Export("removeFromSuperview")]
	public virtual void RemoveFromSuperview()
	{
		NSApplication.EnsureUIThread();
		NSView superview = Superview;
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperviewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperviewHandle);
		}
		__mt_Superview_var = null;
		_ = superview?.Subviews;
	}

	[Export("replaceSubview:with:")]
	public virtual void ReplaceSubviewWith(NSView oldView, NSView newView)
	{
		NSApplication.EnsureUIThread();
		if (oldView == null)
		{
			throw new ArgumentNullException("oldView");
		}
		if (newView == null)
		{
			throw new ArgumentNullException("newView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceSubviewWith_Handle, oldView.Handle, newView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceSubviewWith_Handle, oldView.Handle, newView.Handle);
		}
		_ = Subviews;
	}

	[Export("removeFromSuperviewWithoutNeedingDisplay")]
	public virtual void RemoveFromSuperviewWithoutNeedingDisplay()
	{
		NSApplication.EnsureUIThread();
		NSView superview = Superview;
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperviewWithoutNeedingDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperviewWithoutNeedingDisplayHandle);
		}
		__mt_Superview_var = null;
		_ = superview?.Subviews;
	}

	[Export("resizeSubviewsWithOldSize:")]
	public virtual void ResizeSubviewsWithOldSize(CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeSubviewsWithOldSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeSubviewsWithOldSize_Handle, oldSize);
		}
	}

	[Export("resizeWithOldSuperviewSize:")]
	public virtual void ResizeWithOldSuperviewSize(CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeWithOldSuperviewSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeWithOldSuperviewSize_Handle, oldSize);
		}
	}

	[Export("setFrameOrigin:")]
	public virtual void SetFrameOrigin(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameOrigin_Handle, newOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameOrigin_Handle, newOrigin);
		}
	}

	[Export("setFrameSize:")]
	public virtual void SetFrameSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetFrameSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetFrameSize_Handle, newSize);
		}
	}

	[Export("setBoundsOrigin:")]
	public virtual void SetBoundsOrigin(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetBoundsOrigin_Handle, newOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetBoundsOrigin_Handle, newOrigin);
		}
	}

	[Export("setBoundsSize:")]
	public virtual void SetBoundsSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetBoundsSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetBoundsSize_Handle, newSize);
		}
	}

	[Export("translateOriginToPoint:")]
	public virtual void TranslateOriginToPoint(CGPoint translation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selTranslateOriginToPoint_Handle, translation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selTranslateOriginToPoint_Handle, translation);
		}
	}

	[Export("scaleUnitSquareToSize:")]
	public virtual void ScaleUnitSquareToSize(CGSize newUnitSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selScaleUnitSquareToSize_Handle, newUnitSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selScaleUnitSquareToSize_Handle, newUnitSize);
		}
	}

	[Export("rotateByAngle:")]
	public virtual void RotateByAngle(double angle)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRotateByAngle_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRotateByAngle_Handle, angle);
		}
	}

	[Export("convertPoint:fromView:")]
	public virtual CGPoint ConvertPointFromView(CGPoint aPoint, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointFromView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointFromView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertPoint:toView:")]
	public virtual CGPoint ConvertPointToView(CGPoint aPoint, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPointToView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPointToView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertSize:fromView:")]
	public virtual CGSize ConvertSizeFromView(CGSize aSize, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize_IntPtr(base.Handle, selConvertSizeFromView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selConvertSizeFromView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertSize:toView:")]
	public virtual CGSize ConvertSizeToView(CGSize aSize, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize_IntPtr(base.Handle, selConvertSizeToView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selConvertSizeToView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertRect:fromView:")]
	public virtual CGRect ConvertRectFromView(CGRect aRect, NSView aView)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectFromView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectFromView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertRect:toView:")]
	public virtual CGRect ConvertRectToView(CGRect aRect, NSView aView)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRectToView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRectToView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("centerScanRect:")]
	public virtual CGRect CenterScanRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selCenterScanRect_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selCenterScanRect_Handle, aRect);
		}
		return retval;
	}

	[Export("convertPointToBase:")]
	public virtual CGPoint ConvertPointToBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToBase_Handle, aPoint);
	}

	[Export("convertPointFromBase:")]
	public virtual CGPoint ConvertPointFromBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromBase_Handle, aPoint);
	}

	[Export("convertSizeToBase:")]
	public virtual CGSize ConvertSizeToBase(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToBase_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToBase_Handle, aSize);
	}

	[Export("convertSizeFromBase:")]
	public virtual CGSize ConvertSizeFromBase(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromBase_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromBase_Handle, aSize);
	}

	[Export("convertRectToBase:")]
	public virtual CGRect ConvertRectToBase(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBase_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBase_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromBase:")]
	public virtual CGRect ConvertRectFromBase(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBase_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBase_Handle, aRect);
		}
		return retval;
	}

	[Export("canDraw")]
	public virtual bool CanDraw()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDrawHandle);
	}

	[Export("setNeedsDisplayInRect:")]
	public virtual void SetNeedsDisplayInRect(CGRect invalidRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetNeedsDisplayInRect_Handle, invalidRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetNeedsDisplayInRect_Handle, invalidRect);
		}
	}

	[Export("lockFocus")]
	public virtual void LockFocus()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockFocusHandle);
		}
	}

	[Export("unlockFocus")]
	public virtual void UnlockFocus()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockFocusHandle);
		}
	}

	[Export("lockFocusIfCanDraw")]
	public virtual bool LockFocusIfCanDraw()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selLockFocusIfCanDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLockFocusIfCanDrawHandle);
	}

	[Export("lockFocusIfCanDrawInContext:")]
	public virtual bool LockFocusIfCanDrawInContext(NSGraphicsContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLockFocusIfCanDrawInContext_Handle, context.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockFocusIfCanDrawInContext_Handle, context.Handle);
	}

	[Export("focusView")]
	public static NSView FocusView()
	{
		NSApplication.EnsureUIThread();
		return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFocusViewHandle));
	}

	[Export("visibleRect")]
	public virtual CGRect VisibleRect()
	{
		NSApplication.EnsureUIThread();
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

	[Export("display")]
	public virtual void Display()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	[Export("displayIfNeeded")]
	public virtual void DisplayIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededHandle);
		}
	}

	[Export("displayIfNeededIgnoringOpacity")]
	public virtual void DisplayIfNeededIgnoringOpacity()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededIgnoringOpacityHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededIgnoringOpacityHandle);
		}
	}

	[Export("displayRect:")]
	public virtual void DisplayRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayRect_Handle, rect);
		}
	}

	[Export("displayIfNeededInRect:")]
	public virtual void DisplayIfNeededInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayIfNeededInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayIfNeededInRect_Handle, rect);
		}
	}

	[Export("displayRectIgnoringOpacity:")]
	public virtual void DisplayRectIgnoringOpacity(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayRectIgnoringOpacity_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayRectIgnoringOpacity_Handle, rect);
		}
	}

	[Export("displayIfNeededInRectIgnoringOpacity:")]
	public virtual void DisplayIfNeededInRectIgnoringOpacity(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayIfNeededInRectIgnoringOpacity_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayIfNeededInRectIgnoringOpacity_Handle, rect);
		}
	}

	[Export("drawRect:")]
	public virtual void DrawRect(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawRect_Handle, dirtyRect);
		}
	}

	[Export("displayRectIgnoringOpacity:inContext:")]
	public virtual void DisplayRectIgnoringOpacity(CGRect aRect, NSGraphicsContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDisplayRectIgnoringOpacityInContext_Handle, aRect, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDisplayRectIgnoringOpacityInContext_Handle, aRect, context.Handle);
		}
	}

	[Export("bitmapImageRepForCachingDisplayInRect:")]
	public virtual NSBitmapImageRep BitmapImageRepForCachingDisplayInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selBitmapImageRepForCachingDisplayInRect_Handle, rect));
		}
		return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selBitmapImageRepForCachingDisplayInRect_Handle, rect));
	}

	[Export("cacheDisplayInRect:toBitmapImageRep:")]
	public virtual void CacheDisplay(CGRect rect, NSBitmapImageRep bitmapImageRep)
	{
		NSApplication.EnsureUIThread();
		if (bitmapImageRep == null)
		{
			throw new ArgumentNullException("bitmapImageRep");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selCacheDisplayInRectToBitmapImageRep_Handle, rect, bitmapImageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selCacheDisplayInRectToBitmapImageRep_Handle, rect, bitmapImageRep.Handle);
		}
	}

	[Export("viewWillDraw")]
	public virtual void ViewWillDraw()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillDrawHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillDrawHandle);
		}
	}

	[Export("gState")]
	public virtual long GState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selGStateHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selGStateHandle);
	}

	[Export("allocateGState")]
	public virtual void AllocateGState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAllocateGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAllocateGStateHandle);
		}
	}

	[Export("releaseGState")]
	public virtual void ReleaseGState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseGStateHandle);
		}
	}

	[Export("setUpGState")]
	public virtual void SetUpGState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetUpGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetUpGStateHandle);
		}
	}

	[Export("renewGState")]
	public virtual void RenewGState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRenewGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRenewGStateHandle);
		}
	}

	[Export("scrollPoint:")]
	public virtual void ScrollPoint(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollPoint_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollPoint_Handle, aPoint);
		}
	}

	[Export("scrollRectToVisible:")]
	public virtual bool ScrollRectToVisible(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selScrollRectToVisible_Handle, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollRectToVisible_Handle, aRect);
	}

	[Export("autoscroll:")]
	public virtual bool Autoscroll(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAutoscroll_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAutoscroll_Handle, theEvent.Handle);
	}

	[Export("adjustScroll:")]
	public virtual CGRect AdjustScroll(CGRect newVisible)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selAdjustScroll_Handle, newVisible);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selAdjustScroll_Handle, newVisible);
		}
		return retval;
	}

	[Export("scrollRect:by:")]
	public virtual void ScrollRect(CGRect aRect, CGSize delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGSize(base.Handle, selScrollRectBy_Handle, aRect, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGSize(base.SuperHandle, selScrollRectBy_Handle, aRect, delta);
		}
	}

	[Export("translateRectsNeedingDisplayInRect:by:")]
	public virtual void TranslateRectsNeedingDisplay(CGRect clipRect, CGSize delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGSize(base.Handle, selTranslateRectsNeedingDisplayInRectBy_Handle, clipRect, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGSize(base.SuperHandle, selTranslateRectsNeedingDisplayInRectBy_Handle, clipRect, delta);
		}
	}

	[Export("hitTest:")]
	public virtual NSView HitTest(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selHitTest_Handle, aPoint));
		}
		return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selHitTest_Handle, aPoint));
	}

	[Export("mouse:inRect:")]
	public virtual bool IsMouseInRect(CGPoint aPoint, CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint_CGRect(base.Handle, selMouseInRect_Handle, aPoint, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint_CGRect(base.SuperHandle, selMouseInRect_Handle, aPoint, aRect);
	}

	[Export("viewWithTag:")]
	public virtual NSObject ViewWithTag(long aTag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selViewWithTag_Handle, aTag));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selViewWithTag_Handle, aTag));
	}

	[Export("performKeyEquivalent:")]
	public new virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("acceptsFirstMouse:")]
	public virtual bool AcceptsFirstMouse(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAcceptsFirstMouse_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptsFirstMouse_Handle, theEvent.Handle);
	}

	[Export("shouldDelayWindowOrderingForEvent:")]
	public virtual bool ShouldDelayWindowOrderingForEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldDelayWindowOrderingForEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldDelayWindowOrderingForEvent_Handle, theEvent.Handle);
	}

	[Export("addCursorRect:cursor:")]
	public virtual void AddCursorRect(CGRect aRect, NSCursor cursor)
	{
		NSApplication.EnsureUIThread();
		if (cursor == null)
		{
			throw new ArgumentNullException("cursor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selAddCursorRectCursor_Handle, aRect, cursor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selAddCursorRectCursor_Handle, aRect, cursor.Handle);
		}
	}

	[Export("removeCursorRect:cursor:")]
	public virtual void RemoveCursorRect(CGRect aRect, NSCursor cursor)
	{
		NSApplication.EnsureUIThread();
		if (cursor == null)
		{
			throw new ArgumentNullException("cursor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selRemoveCursorRectCursor_Handle, aRect, cursor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selRemoveCursorRectCursor_Handle, aRect, cursor.Handle);
		}
	}

	[Export("discardCursorRects")]
	public virtual void DiscardCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardCursorRectsHandle);
		}
	}

	[Export("resetCursorRects")]
	public virtual void ResetCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCursorRectsHandle);
		}
	}

	[Export("addTrackingRect:owner:userData:assumeInside:")]
	public virtual long AddTrackingRect(CGRect aRect, NSObject anObject, IntPtr data, bool assumeInside)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGRect_IntPtr_IntPtr_bool(base.Handle, selAddTrackingRectOwnerUserDataAssumeInside_Handle, aRect, anObject.Handle, data, assumeInside);
		}
		return Messaging.Int64_objc_msgSendSuper_CGRect_IntPtr_IntPtr_bool(base.SuperHandle, selAddTrackingRectOwnerUserDataAssumeInside_Handle, aRect, anObject.Handle, data, assumeInside);
	}

	[Export("removeTrackingRect:")]
	public virtual void RemoveTrackingRect(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveTrackingRect_Handle, tag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveTrackingRect_Handle, tag);
		}
	}

	[Export("makeBackingLayer")]
	public virtual CALayer MakeBackingLayer()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMakeBackingLayerHandle));
		}
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMakeBackingLayerHandle));
	}

	[Export("addTrackingArea:")]
	public virtual void AddTrackingArea(NSTrackingArea trackingArea)
	{
		NSApplication.EnsureUIThread();
		if (trackingArea == null)
		{
			throw new ArgumentNullException("trackingArea");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTrackingArea_Handle, trackingArea.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTrackingArea_Handle, trackingArea.Handle);
		}
		__mt_tracking_var = TrackingAreas();
	}

	[Export("removeTrackingArea:")]
	public virtual void RemoveTrackingArea(NSTrackingArea trackingArea)
	{
		NSApplication.EnsureUIThread();
		if (trackingArea == null)
		{
			throw new ArgumentNullException("trackingArea");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrackingArea_Handle, trackingArea.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrackingArea_Handle, trackingArea.Handle);
		}
		__mt_tracking_var = TrackingAreas();
	}

	[Export("trackingAreas")]
	public virtual NSTrackingArea[] TrackingAreas()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSTrackingArea>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackingAreasHandle));
		}
		return NSArray.ArrayFromHandle<NSTrackingArea>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackingAreasHandle));
	}

	[Export("updateTrackingAreas")]
	public virtual void UpdateTrackingAreas()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateTrackingAreasHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateTrackingAreasHandle);
		}
	}

	[Export("menuForEvent:")]
	public virtual NSMenu MenuForEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMenuForEvent_Handle, theEvent.Handle));
		}
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMenuForEvent_Handle, theEvent.Handle));
	}

	[Export("defaultMenu")]
	public static NSMenu DefaultMenu()
	{
		NSApplication.EnsureUIThread();
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultMenuHandle));
	}

	[Export("addToolTipRect:owner:userData:")]
	public virtual long AddToolTip(CGRect aRect, NSObject anObject, IntPtr data)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selAddToolTipRectOwnerUserData_Handle, aRect, anObject.Handle, data);
		}
		return Messaging.Int64_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selAddToolTipRectOwnerUserData_Handle, aRect, anObject.Handle, data);
	}

	[Export("removeToolTip:")]
	public virtual void RemoveToolTip(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveToolTip_Handle, tag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveToolTip_Handle, tag);
		}
	}

	[Export("removeAllToolTips")]
	public virtual void RemoveAllToolTips()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllToolTipsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllToolTipsHandle);
		}
	}

	[Export("viewWillStartLiveResize")]
	public virtual void ViewWillStartLiveResize()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillStartLiveResizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillStartLiveResizeHandle);
		}
	}

	[Export("viewDidEndLiveResize")]
	public virtual void ViewDidEndLiveResize()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidEndLiveResizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidEndLiveResizeHandle);
		}
	}

	[Export("registerForDraggedTypes:")]
	public virtual void RegisterForDraggedTypes(string[] newTypes)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("unregisterDraggedTypes")]
	public virtual void UnregisterDraggedTypes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnregisterDraggedTypesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnregisterDraggedTypesHandle);
		}
	}

	[Export("registeredDraggedTypes")]
	public virtual string[] RegisteredDragTypes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredDraggedTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredDraggedTypesHandle));
	}

	[Export("beginDraggingSessionWithItems:event:source:")]
	public virtual NSDraggingSession BeginDraggingSession(NSDraggingItem[] itmes, NSEvent evnt, NSDraggingSource source)
	{
		NSApplication.EnsureUIThread();
		if (itmes == null)
		{
			throw new ArgumentNullException("itmes");
		}
		if (evnt == null)
		{
			throw new ArgumentNullException("evnt");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSArray nSArray = NSArray.FromNSObjects(itmes);
		NSDraggingSession result = ((!IsDirectBinding) ? ((NSDraggingSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginDraggingSessionWithItemsEventSource_Handle, nSArray.Handle, evnt.Handle, source.Handle))) : ((NSDraggingSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginDraggingSessionWithItemsEventSource_Handle, nSArray.Handle, evnt.Handle, source.Handle))));
		nSArray.Dispose();
		return result;
	}

	[Export("dragImage:at:offset:event:pasteboard:source:slideBack:")]
	public virtual void DragImage(NSImage anImage, CGPoint viewLocation, CGSize initialOffset, NSEvent theEvent, NSPasteboard pboard, NSObject sourceObj, bool slideFlag)
	{
		NSApplication.EnsureUIThread();
		if (anImage == null)
		{
			throw new ArgumentNullException("anImage");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (sourceObj == null)
		{
			throw new ArgumentNullException("sourceObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(base.Handle, selDragImageAtOffsetEventPasteboardSourceSlideBack_Handle, anImage.Handle, viewLocation, initialOffset, theEvent.Handle, pboard.Handle, sourceObj.Handle, slideFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selDragImageAtOffsetEventPasteboardSourceSlideBack_Handle, anImage.Handle, viewLocation, initialOffset, theEvent.Handle, pboard.Handle, sourceObj.Handle, slideFlag);
		}
	}

	[Export("dragFile:fromRect:slideBack:event:")]
	public virtual bool DragFile(string filename, CGRect aRect, bool slideBack, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		IntPtr arg = NSString.CreateNative(filename);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_bool_IntPtr(base.SuperHandle, selDragFileFromRectSlideBackEvent_Handle, arg, aRect, slideBack, theEvent.Handle) : Messaging.bool_objc_msgSend_IntPtr_CGRect_bool_IntPtr(base.Handle, selDragFileFromRectSlideBackEvent_Handle, arg, aRect, slideBack, theEvent.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dragPromisedFilesOfTypes:fromRect:source:slideBack:event:")]
	public virtual bool DragPromisedFilesOfTypes(string[] typeArray, CGRect aRect, NSObject sourceObject, bool slideBack, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (typeArray == null)
		{
			throw new ArgumentNullException("typeArray");
		}
		if (sourceObject == null)
		{
			throw new ArgumentNullException("sourceObject");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		NSArray nSArray = NSArray.FromStrings(typeArray);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool_IntPtr(base.SuperHandle, selDragPromisedFilesOfTypesFromRectSourceSlideBackEvent_Handle, nSArray.Handle, aRect, sourceObject.Handle, slideBack, theEvent.Handle) : Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool_IntPtr(base.Handle, selDragPromisedFilesOfTypesFromRectSourceSlideBackEvent_Handle, nSArray.Handle, aRect, sourceObject.Handle, slideBack, theEvent.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("exitFullScreenModeWithOptions:")]
	public virtual void ExitFullscreenModeWithOptions(NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExitFullScreenModeWithOptions_Handle, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExitFullScreenModeWithOptions_Handle, options.Handle);
		}
	}

	[Export("enterFullScreenMode:withOptions:")]
	public virtual bool EnterFullscreenModeWithOptions(NSScreen screen, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnterFullScreenModeWithOptions_Handle, screen.Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnterFullScreenModeWithOptions_Handle, screen.Handle, options.Handle);
	}

	[Export("addConstraint:")]
	public virtual void AddConstraint(NSLayoutConstraint constraint)
	{
		NSApplication.EnsureUIThread();
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraint_Handle, constraint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraint_Handle, constraint.Handle);
		}
		_ = Constraints;
	}

	[Export("addConstraints:")]
	public virtual void AddConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraints_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraints_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
		_ = Constraints;
	}

	[Export("removeConstraint:")]
	public virtual void RemoveConstraint(NSLayoutConstraint constraint)
	{
		NSApplication.EnsureUIThread();
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveConstraint_Handle, constraint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveConstraint_Handle, constraint.Handle);
		}
		_ = Constraints;
	}

	[Export("removeConstraints:")]
	public virtual void RemoveConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveConstraints_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveConstraints_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
		_ = Constraints;
	}

	[Export("layoutSubtreeIfNeeded")]
	public virtual void LayoutSubtreeIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutSubtreeIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutSubtreeIfNeededHandle);
		}
	}

	[Export("layout")]
	public virtual void Layout()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
		}
	}

	[Export("updateConstraints")]
	public virtual void UpdateConstraints()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsHandle);
		}
	}

	[Export("updateConstraintsForSubtreeIfNeeded")]
	public virtual void UpdateConstraintsForSubtreeIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsForSubtreeIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsForSubtreeIfNeededHandle);
		}
	}

	[Export("requiresConstraintBasedLayout")]
	public static bool RequiresConstraintBasedLayout()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selRequiresConstraintBasedLayoutHandle);
	}

	[Export("alignmentRectForFrame:")]
	public virtual CGRect GetAlignmentRectForFrame(CGRect frame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selAlignmentRectForFrame_Handle, frame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selAlignmentRectForFrame_Handle, frame);
		}
		return retval;
	}

	[Export("frameForAlignmentRect:")]
	public virtual CGRect GetFrameForAlignmentRect(CGRect alignmentRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selFrameForAlignmentRect_Handle, alignmentRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selFrameForAlignmentRect_Handle, alignmentRect);
		}
		return retval;
	}

	[Export("invalidateIntrinsicContentSize")]
	public virtual void InvalidateIntrinsicContentSize()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateIntrinsicContentSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateIntrinsicContentSizeHandle);
		}
	}

	[Export("contentHuggingPriorityForOrientation:")]
	public virtual float GetContentHuggingPriorityForOrientation(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selContentHuggingPriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selContentHuggingPriorityForOrientation_Handle, (long)orientation);
	}

	[Export("setContentHuggingPriority:forOrientation:")]
	public virtual void SetContentHuggingPriorityForOrientation(float priority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetContentHuggingPriorityForOrientation_Handle, priority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetContentHuggingPriorityForOrientation_Handle, priority, (long)orientation);
		}
	}

	[Export("contentCompressionResistancePriorityForOrientation:")]
	public virtual float GetContentCompressionResistancePriority(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selContentCompressionResistancePriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selContentCompressionResistancePriorityForOrientation_Handle, (long)orientation);
	}

	[Export("setContentCompressionResistancePriority:forOrientation:")]
	public virtual void SetContentCompressionResistancePriority(float priority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetContentCompressionResistancePriorityForOrientation_Handle, priority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetContentCompressionResistancePriorityForOrientation_Handle, priority, (long)orientation);
		}
	}

	[Export("constraintsAffectingLayoutForOrientation:")]
	public virtual NSLayoutConstraint[] GetConstraintsAffectingLayout(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
		}
		return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
	}

	[Export("exerciseAmbiguityInLayout")]
	public virtual void ExerciseAmbiguityInLayout()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selExerciseAmbiguityInLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selExerciseAmbiguityInLayoutHandle);
		}
	}

	[Export("performMnemonic:")]
	[Obsolete("Deprecated in 10.8", false)]
	public virtual bool PerformMnemonic(string mnemonic)
	{
		NSApplication.EnsureUIThread();
		if (mnemonic == null)
		{
			throw new ArgumentNullException("mnemonic");
		}
		IntPtr arg = NSString.CreateNative(mnemonic);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformMnemonic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformMnemonic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setKeyboardFocusRingNeedsDisplayInRect:")]
	public virtual void SetKeyboardFocusRingNeedsDisplay(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetKeyboardFocusRingNeedsDisplayInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetKeyboardFocusRingNeedsDisplayInRect_Handle, rect);
		}
	}

	[Export("drawFocusRingMask")]
	public virtual void DrawFocusRingMask()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawFocusRingMaskHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawFocusRingMaskHandle);
		}
	}

	[Export("noteFocusRingMaskChanged")]
	public virtual void NoteFocusRingMaskChanged()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteFocusRingMaskChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteFocusRingMaskChangedHandle);
		}
	}

	[Export("dataWithEPSInsideRect:")]
	public virtual NSData DataWithEpsInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithEPSInsideRect_Handle, rect));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithEPSInsideRect_Handle, rect));
	}

	[Export("dataWithPDFInsideRect:")]
	public virtual NSData DataWithPdfInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithPDFInsideRect_Handle, rect));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithPDFInsideRect_Handle, rect));
	}

	[Export("print:")]
	public virtual void Print(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrint_Handle, sender.Handle);
		}
	}

	[Export("writeEPSInsideRect:toPasteboard:")]
	public virtual void WriteEpsInsideRect(CGRect rect, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selWriteEPSInsideRectToPasteboard_Handle, rect, pboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selWriteEPSInsideRectToPasteboard_Handle, rect, pboard.Handle);
		}
	}

	[Export("writePDFInsideRect:toPasteboard:")]
	public virtual void WritePdfInsideRect(CGRect rect, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selWritePDFInsideRectToPasteboard_Handle, rect, pboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selWritePDFInsideRectToPasteboard_Handle, rect, pboard.Handle);
		}
	}

	[Export("drawPageBorderWithSize:")]
	public virtual void DrawPageBorder(CGSize borderSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selDrawPageBorderWithSize_Handle, borderSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selDrawPageBorderWithSize_Handle, borderSize);
		}
	}

	[Export("drawSheetBorderWithSize:")]
	public virtual void DrawSheetBorder(CGSize borderSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selDrawSheetBorderWithSize_Handle, borderSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selDrawSheetBorderWithSize_Handle, borderSize);
		}
	}

	[Export("adjustPageWidthNew:left:right:limit:")]
	public virtual void AdjustPageWidthNew(ref double newRight, double left, double proposedRight, double rightLimit)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_Double_Double_Double(base.Handle, selAdjustPageWidthNewLeftRightLimit_Handle, out newRight, left, proposedRight, rightLimit);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_Double_Double_Double(base.SuperHandle, selAdjustPageWidthNewLeftRightLimit_Handle, out newRight, left, proposedRight, rightLimit);
		}
	}

	[Export("adjustPageHeightNew:top:bottom:limit:")]
	public virtual void AdjustPageHeightNew(ref double newBottom, double top, double proposedBottom, double bottomLimit)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_Double_Double_Double(base.Handle, selAdjustPageHeightNewTopBottomLimit_Handle, out newBottom, top, proposedBottom, bottomLimit);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_Double_Double_Double(base.SuperHandle, selAdjustPageHeightNewTopBottomLimit_Handle, out newBottom, top, proposedBottom, bottomLimit);
		}
	}

	[Export("knowsPageRange:")]
	public virtual bool KnowsPageRange(ref NSRange aRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_out_NSRange(base.Handle, selKnowsPageRange_Handle, out aRange);
		}
		return Messaging.bool_objc_msgSendSuper_out_NSRange(base.SuperHandle, selKnowsPageRange_Handle, out aRange);
	}

	[Export("rectForPage:")]
	public virtual CGRect RectForPage(long pageNumber)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectForPage_Handle, pageNumber);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectForPage_Handle, pageNumber);
		}
		return retval;
	}

	[Export("locationOfPrintRect:")]
	public virtual CGPoint LocationOfPrintRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGRect(base.Handle, selLocationOfPrintRect_Handle, aRect);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGRect(base.SuperHandle, selLocationOfPrintRect_Handle, aRect);
	}

	[Export("backingAlignedRect:options:")]
	public virtual CGRect BackingAlignedRect(CGRect aRect, NSAlignmentOptions options)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out retval, base.Handle, selBackingAlignedRectOptions_Handle, aRect, (ulong)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_UInt64(out retval, base.SuperHandle, selBackingAlignedRectOptions_Handle, aRect, (ulong)options);
		}
		return retval;
	}

	[Export("convertRectFromBacking:")]
	public virtual CGRect ConvertRectFromBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToBacking:")]
	public virtual CGRect ConvertRectToBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromLayer:")]
	public virtual CGRect ConvertRectFromLayer(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromLayer_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromLayer_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToLayer:")]
	public virtual CGRect ConvertRectToLayer(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToLayer_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToLayer_Handle, aRect);
		}
		return retval;
	}

	[Export("convertPointFromBacking:")]
	public virtual CGPoint ConvertPointFromBacking(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromBacking_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromBacking_Handle, aPoint);
	}

	[Export("convertPointToBacking:")]
	public virtual CGPoint ConvertPointToBacking(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToBacking_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToBacking_Handle, aPoint);
	}

	[Export("convertPointFromLayer:")]
	public virtual CGPoint ConvertPointFromLayer(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromLayer_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromLayer_Handle, aPoint);
	}

	[Export("convertPointToLayer:")]
	public virtual CGPoint ConvertPointToLayer(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToLayer_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToLayer_Handle, aPoint);
	}

	[Export("convertSizeFromBacking:")]
	public virtual CGSize ConvertSizeFromBacking(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromBacking_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromBacking_Handle, aSize);
	}

	[Export("convertSizeToBacking:")]
	public virtual CGSize ConvertSizeToBacking(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToBacking_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToBacking_Handle, aSize);
	}

	[Export("convertSizeFromLayer:")]
	public virtual CGSize ConvertSizeFromLayer(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromLayer_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromLayer_Handle, aSize);
	}

	[Export("convertSizeToLayer:")]
	public virtual CGSize ConvertSizeToLayer(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToLayer_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToLayer_Handle, aSize);
	}

	[Export("draggingEntered:")]
	public virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingEntered_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEntered_Handle, sender.Handle);
	}

	[Export("draggingUpdated:")]
	public virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingUpdated_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingUpdated_Handle, sender.Handle);
	}

	[Export("draggingExited:")]
	public virtual void DraggingExited(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingExited_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingExited_Handle, sender.Handle);
		}
	}

	[Export("prepareForDragOperation:")]
	public virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareForDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForDragOperation_Handle, sender.Handle);
	}

	[Export("performDragOperation:")]
	public virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDragOperation_Handle, sender.Handle);
	}

	[Export("concludeDragOperation:")]
	public virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConcludeDragOperation_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConcludeDragOperation_Handle, sender.Handle);
		}
	}

	[Export("draggingEnded:")]
	public virtual void DraggingEnded(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingEnded_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEnded_Handle, sender.Handle);
		}
	}

	[Export("animationForKey:")]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("defaultAnimationForKey:")]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		__mt_tracking_var = null;
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Window_var = null;
			__mt_Superview_var = null;
			__mt_OpaqueAncestor_var = null;
			__mt_EnclosingScrollView_var = null;
			__mt_InputContext_var = null;
			__mt_Subviews_var = null;
			__mt_Layer_var = null;
			__mt_BackgroundFilters_var = null;
			__mt_CompositingFilter_var = null;
			__mt_ContentFilters_var = null;
			__mt_Shadow_var = null;
			__mt_Constraints_var = null;
			__mt_NextKeyView_var = null;
			__mt_PreviousKeyView_var = null;
			__mt_NextValidKeyView_var = null;
			__mt_PreviousValidKeyView_var = null;
			__mt_PageHeader_var = null;
			__mt_PageFooter_var = null;
			__mt_Animator_var = null;
			__mt_Animations_var = null;
		}
	}
}

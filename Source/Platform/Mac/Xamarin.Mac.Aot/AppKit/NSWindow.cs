using System;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWindow", true)]
public class NSWindow : NSResponder
{
	[Register]
	private sealed class _NSWindowDelegate : NSWindowDelegate
	{
		internal NSObjectPredicate windowShouldClose;

		internal NSWindowClient willReturnFieldEditor;

		internal NSWindowResize willResize;

		internal NSWindowFrame willUseStandardFrame;

		internal NSWindowFramePredicate shouldZoom;

		internal NSWindowUndoManager willReturnUndoManager;

		internal NSWindowSheetRect willPositionSheet;

		internal NSWindowMenu shouldPopUpDocumentPathMenu;

		internal NSWindowDocumentDrag shouldDragDocumentWithEvent;

		internal EventHandler didResize;

		internal EventHandler didExpose;

		internal EventHandler willMove;

		internal EventHandler didMoved;

		internal EventHandler didBecomeKey;

		internal EventHandler didResignKey;

		internal EventHandler didBecomeMain;

		internal EventHandler didResignMain;

		internal EventHandler willClose;

		internal EventHandler willMiniaturize;

		internal EventHandler didMiniaturize;

		internal EventHandler didDeminiaturize;

		internal EventHandler didUpdate;

		internal EventHandler didChangeScreen;

		internal EventHandler didChangeScreenProfile;

		internal EventHandler willBeginSheet;

		internal EventHandler didEndSheet;

		internal EventHandler willStartLiveResize;

		internal EventHandler didEndLiveResize;

		internal EventHandler willEnterFullScreen;

		internal EventHandler didEnterFullScreen;

		internal EventHandler willExitFullScreen;

		internal EventHandler didExitFullScreen;

		internal EventHandler didFailToEnterFullScreen;

		internal EventHandler didFailToExitFullScreen;

		internal NSWindowSize willUseFullScreenContentSize;

		internal NSWindowApplicationPresentationOptions willUseFullScreenPresentationOptions;

		internal NSWindowWindows customWindowsToEnterFullScreen;

		internal NSWindowWindows customWindowsToExitFullScreen;

		internal EventHandler<NSWindowDurationEventArgs> startCustomAnimationToEnterFullScreen;

		internal EventHandler<NSWindowDurationEventArgs> startCustomAnimationToExitFullScreen;

		internal EventHandler<NSWindowCoderEventArgs> willEncodeRestorableState;

		internal EventHandler<NSWindowCoderEventArgs> didDecodeRestorableState;

		internal NSWindowSizeSize willResizeForVersionBrowser;

		internal EventHandler willEnterVersionBrowser;

		internal EventHandler didEnterVersionBrowser;

		internal EventHandler willExitVersionBrowser;

		internal EventHandler didExitVersionBrowser;

		[Preserve(Conditional = true)]
		public override bool WindowShouldClose(NSObject sender)
		{
			return windowShouldClose?.Invoke(sender) ?? true;
		}

		[Preserve(Conditional = true)]
		public override NSObject WillReturnFieldEditor(NSWindow sender, NSObject client)
		{
			return willReturnFieldEditor?.Invoke(sender, client);
		}

		[Preserve(Conditional = true)]
		public override CGSize WillResize(NSWindow sender, CGSize toFrameSize)
		{
			return willResize?.Invoke(sender, toFrameSize) ?? toFrameSize;
		}

		[Preserve(Conditional = true)]
		public override CGRect WillUseStandardFrame(NSWindow window, CGRect newFrame)
		{
			return willUseStandardFrame?.Invoke(window, newFrame) ?? newFrame;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldZoom(NSWindow window, CGRect newFrame)
		{
			return shouldZoom?.Invoke(window, newFrame) ?? true;
		}

		[Preserve(Conditional = true)]
		public override NSUndoManager WillReturnUndoManager(NSWindow window)
		{
			return willReturnUndoManager?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		public override CGRect WillPositionSheet(NSWindow window, NSWindow sheet, CGRect usingRect)
		{
			return willPositionSheet?.Invoke(window, sheet, usingRect) ?? usingRect;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldPopUpDocumentPathMenu(NSWindow window, NSMenu menu)
		{
			return shouldPopUpDocumentPathMenu?.Invoke(window, menu) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldDragDocumentWithEvent(NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard)
		{
			return shouldDragDocumentWithEvent?.Invoke(window, theEvent, dragImageLocation, withPasteboard) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void DidResize(NSNotification notification)
		{
			didResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidExpose(NSNotification notification)
		{
			didExpose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillMove(NSNotification notification)
		{
			willMove?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidMoved(NSNotification notification)
		{
			didMoved?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidBecomeKey(NSNotification notification)
		{
			didBecomeKey?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidResignKey(NSNotification notification)
		{
			didResignKey?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidBecomeMain(NSNotification notification)
		{
			didBecomeMain?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidResignMain(NSNotification notification)
		{
			didResignMain?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillClose(NSNotification notification)
		{
			willClose?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillMiniaturize(NSNotification notification)
		{
			willMiniaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidMiniaturize(NSNotification notification)
		{
			didMiniaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidDeminiaturize(NSNotification notification)
		{
			didDeminiaturize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidUpdate(NSNotification notification)
		{
			didUpdate?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidChangeScreen(NSNotification notification)
		{
			didChangeScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidChangeScreenProfile(NSNotification notification)
		{
			didChangeScreenProfile?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillBeginSheet(NSNotification notification)
		{
			willBeginSheet?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidEndSheet(NSNotification notification)
		{
			didEndSheet?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillStartLiveResize(NSNotification notification)
		{
			willStartLiveResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidEndLiveResize(NSNotification notification)
		{
			didEndLiveResize?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillEnterFullScreen(NSNotification notification)
		{
			willEnterFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidEnterFullScreen(NSNotification notification)
		{
			didEnterFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillExitFullScreen(NSNotification notification)
		{
			willExitFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidExitFullScreen(NSNotification notification)
		{
			didExitFullScreen?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidFailToEnterFullScreen(NSWindow window)
		{
			didFailToEnterFullScreen?.Invoke(window, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidFailToExitFullScreen(NSWindow window)
		{
			didFailToExitFullScreen?.Invoke(window, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override CGSize WillUseFullScreenContentSize(NSWindow window, CGSize proposedSize)
		{
			return willUseFullScreenContentSize?.Invoke(window, proposedSize) ?? proposedSize;
		}

		[Preserve(Conditional = true)]
		public override NSApplicationPresentationOptions WillUseFullScreenPresentationOptions(NSWindow window, NSApplicationPresentationOptions proposedOptions)
		{
			return willUseFullScreenPresentationOptions?.Invoke(window, proposedOptions) ?? proposedOptions;
		}

		[Preserve(Conditional = true)]
		public override NSWindow[] CustomWindowsToEnterFullScreen(NSWindow window)
		{
			return customWindowsToEnterFullScreen?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		public override NSWindow[] CustomWindowsToExitFullScreen(NSWindow window)
		{
			return customWindowsToExitFullScreen?.Invoke(window);
		}

		[Preserve(Conditional = true)]
		public override void StartCustomAnimationToEnterFullScreen(NSWindow window, double duration)
		{
			EventHandler<NSWindowDurationEventArgs> eventHandler = startCustomAnimationToEnterFullScreen;
			if (eventHandler != null)
			{
				NSWindowDurationEventArgs e = new NSWindowDurationEventArgs(duration);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void StartCustomAnimationToExitFullScreen(NSWindow window, double duration)
		{
			EventHandler<NSWindowDurationEventArgs> eventHandler = startCustomAnimationToExitFullScreen;
			if (eventHandler != null)
			{
				NSWindowDurationEventArgs e = new NSWindowDurationEventArgs(duration);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillEncodeRestorableState(NSWindow window, NSCoder coder)
		{
			EventHandler<NSWindowCoderEventArgs> eventHandler = willEncodeRestorableState;
			if (eventHandler != null)
			{
				NSWindowCoderEventArgs e = new NSWindowCoderEventArgs(coder);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidDecodeRestorableState(NSWindow window, NSCoder coder)
		{
			EventHandler<NSWindowCoderEventArgs> eventHandler = didDecodeRestorableState;
			if (eventHandler != null)
			{
				NSWindowCoderEventArgs e = new NSWindowCoderEventArgs(coder);
				eventHandler(window, e);
			}
		}

		[Preserve(Conditional = true)]
		public override CGSize WillResizeForVersionBrowser(NSWindow window, CGSize maxPreferredSize, CGSize maxAllowedSize)
		{
			return willResizeForVersionBrowser?.Invoke(window, maxPreferredSize, maxAllowedSize) ?? maxPreferredSize;
		}

		[Preserve(Conditional = true)]
		public override void WillEnterVersionBrowser(NSNotification notification)
		{
			willEnterVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidEnterVersionBrowser(NSNotification notification)
		{
			didEnterVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void WillExitVersionBrowser(NSNotification notification)
		{
			willExitVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidExitVersionBrowser(NSNotification notification)
		{
			didExitVersionBrowser?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static IntPtr selInitWithWindowRef = Selector.GetHandle("initWithWindowRef:");

	private static readonly IntPtr selDefaultDepthLimitHandle = Selector.GetHandle("defaultDepthLimit");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selRepresentedURLHandle = Selector.GetHandle("representedURL");

	private static readonly IntPtr selSetRepresentedURL_Handle = Selector.GetHandle("setRepresentedURL:");

	private static readonly IntPtr selRepresentedFilenameHandle = Selector.GetHandle("representedFilename");

	private static readonly IntPtr selSetRepresentedFilename_Handle = Selector.GetHandle("setRepresentedFilename:");

	private static readonly IntPtr selIsExcludedFromWindowsMenuHandle = Selector.GetHandle("isExcludedFromWindowsMenu");

	private static readonly IntPtr selContentViewHandle = Selector.GetHandle("contentView");

	private static readonly IntPtr selSetContentView_Handle = Selector.GetHandle("setContentView:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selWindowNumberHandle = Selector.GetHandle("windowNumber");

	private static readonly IntPtr selStyleMaskHandle = Selector.GetHandle("styleMask");

	private static readonly IntPtr selSetStyleMask_Handle = Selector.GetHandle("setStyleMask:");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selInLiveResizeHandle = Selector.GetHandle("inLiveResize");

	private static readonly IntPtr selShowsResizeIndicatorHandle = Selector.GetHandle("showsResizeIndicator");

	private static readonly IntPtr selSetShowsResizeIndicator_Handle = Selector.GetHandle("setShowsResizeIndicator:");

	private static readonly IntPtr selResizeIncrementsHandle = Selector.GetHandle("resizeIncrements");

	private static readonly IntPtr selSetResizeIncrements_Handle = Selector.GetHandle("setResizeIncrements:");

	private static readonly IntPtr selAspectRatioHandle = Selector.GetHandle("aspectRatio");

	private static readonly IntPtr selSetAspectRatio_Handle = Selector.GetHandle("setAspectRatio:");

	private static readonly IntPtr selContentResizeIncrementsHandle = Selector.GetHandle("contentResizeIncrements");

	private static readonly IntPtr selSetContentResizeIncrements_Handle = Selector.GetHandle("setContentResizeIncrements:");

	private static readonly IntPtr selContentAspectRatioHandle = Selector.GetHandle("contentAspectRatio");

	private static readonly IntPtr selSetContentAspectRatio_Handle = Selector.GetHandle("setContentAspectRatio:");

	private static readonly IntPtr selIsFlushWindowDisabledHandle = Selector.GetHandle("isFlushWindowDisabled");

	private static readonly IntPtr selViewsNeedDisplayHandle = Selector.GetHandle("viewsNeedDisplay");

	private static readonly IntPtr selSetViewsNeedDisplay_Handle = Selector.GetHandle("setViewsNeedDisplay:");

	private static readonly IntPtr selIsAutodisplayHandle = Selector.GetHandle("isAutodisplay");

	private static readonly IntPtr selSetAutodisplay_Handle = Selector.GetHandle("setAutodisplay:");

	private static readonly IntPtr selPreservesContentDuringLiveResizeHandle = Selector.GetHandle("preservesContentDuringLiveResize");

	private static readonly IntPtr selSetPreservesContentDuringLiveResize_Handle = Selector.GetHandle("setPreservesContentDuringLiveResize:");

	private static readonly IntPtr selFirstResponderHandle = Selector.GetHandle("firstResponder");

	private static readonly IntPtr selResizeFlagsHandle = Selector.GetHandle("resizeFlags");

	private static readonly IntPtr selIsReleasedWhenClosedHandle = Selector.GetHandle("isReleasedWhenClosed");

	private static readonly IntPtr selSetReleasedWhenClosed_Handle = Selector.GetHandle("setReleasedWhenClosed:");

	private static readonly IntPtr selIsZoomedHandle = Selector.GetHandle("isZoomed");

	private static readonly IntPtr selSetIsZoomed_Handle = Selector.GetHandle("setIsZoomed:");

	private static readonly IntPtr selIsMiniaturizedHandle = Selector.GetHandle("isMiniaturized");

	private static readonly IntPtr selSetIsMiniaturized_Handle = Selector.GetHandle("setIsMiniaturized:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selIsMovableHandle = Selector.GetHandle("isMovable");

	private static readonly IntPtr selSetMovable_Handle = Selector.GetHandle("setMovable:");

	private static readonly IntPtr selIsMovableByWindowBackgroundHandle = Selector.GetHandle("isMovableByWindowBackground");

	private static readonly IntPtr selSetMovableByWindowBackground_Handle = Selector.GetHandle("setMovableByWindowBackground:");

	private static readonly IntPtr selHidesOnDeactivateHandle = Selector.GetHandle("hidesOnDeactivate");

	private static readonly IntPtr selSetHidesOnDeactivate_Handle = Selector.GetHandle("setHidesOnDeactivate:");

	private static readonly IntPtr selCanHideHandle = Selector.GetHandle("canHide");

	private static readonly IntPtr selSetCanHide_Handle = Selector.GetHandle("setCanHide:");

	private static readonly IntPtr selMiniwindowImageHandle = Selector.GetHandle("miniwindowImage");

	private static readonly IntPtr selSetMiniwindowImage_Handle = Selector.GetHandle("setMiniwindowImage:");

	private static readonly IntPtr selMiniwindowTitleHandle = Selector.GetHandle("miniwindowTitle");

	private static readonly IntPtr selSetMiniwindowTitle_Handle = Selector.GetHandle("setMiniwindowTitle:");

	private static readonly IntPtr selDockTileHandle = Selector.GetHandle("dockTile");

	private static readonly IntPtr selIsDocumentEditedHandle = Selector.GetHandle("isDocumentEdited");

	private static readonly IntPtr selSetDocumentEdited_Handle = Selector.GetHandle("setDocumentEdited:");

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	private static readonly IntPtr selSetIsVisible_Handle = Selector.GetHandle("setIsVisible:");

	private static readonly IntPtr selIsKeyWindowHandle = Selector.GetHandle("isKeyWindow");

	private static readonly IntPtr selIsMainWindowHandle = Selector.GetHandle("isMainWindow");

	private static readonly IntPtr selCanBecomeKeyWindowHandle = Selector.GetHandle("canBecomeKeyWindow");

	private static readonly IntPtr selCanBecomeMainWindowHandle = Selector.GetHandle("canBecomeMainWindow");

	private static readonly IntPtr selPreventsApplicationTerminationWhenModalHandle = Selector.GetHandle("preventsApplicationTerminationWhenModal");

	private static readonly IntPtr selSetPreventsApplicationTerminationWhenModal_Handle = Selector.GetHandle("setPreventsApplicationTerminationWhenModal:");

	private static readonly IntPtr selIsOneShotHandle = Selector.GetHandle("isOneShot");

	private static readonly IntPtr selAreCursorRectsEnabledHandle = Selector.GetHandle("areCursorRectsEnabled");

	private static readonly IntPtr selAllowsToolTipsWhenApplicationIsInactiveHandle = Selector.GetHandle("allowsToolTipsWhenApplicationIsInactive");

	private static readonly IntPtr selSetAllowsToolTipsWhenApplicationIsInactive_Handle = Selector.GetHandle("setAllowsToolTipsWhenApplicationIsInactive:");

	private static readonly IntPtr selBackingTypeHandle = Selector.GetHandle("backingType");

	private static readonly IntPtr selSetBackingType_Handle = Selector.GetHandle("setBackingType:");

	private static readonly IntPtr selLevelHandle = Selector.GetHandle("level");

	private static readonly IntPtr selSetLevel_Handle = Selector.GetHandle("setLevel:");

	private static readonly IntPtr selDepthLimitHandle = Selector.GetHandle("depthLimit");

	private static readonly IntPtr selSetDepthLimit_Handle = Selector.GetHandle("setDepthLimit:");

	private static readonly IntPtr selHasDynamicDepthLimitHandle = Selector.GetHandle("hasDynamicDepthLimit");

	private static readonly IntPtr selSetDynamicDepthLimit_Handle = Selector.GetHandle("setDynamicDepthLimit:");

	private static readonly IntPtr selScreenHandle = Selector.GetHandle("screen");

	private static readonly IntPtr selDeepestScreenHandle = Selector.GetHandle("deepestScreen");

	private static readonly IntPtr selCanStoreColorHandle = Selector.GetHandle("canStoreColor");

	private static readonly IntPtr selHasShadowHandle = Selector.GetHandle("hasShadow");

	private static readonly IntPtr selSetHasShadow_Handle = Selector.GetHandle("setHasShadow:");

	private static readonly IntPtr selAlphaValueHandle = Selector.GetHandle("alphaValue");

	private static readonly IntPtr selSetAlphaValue_Handle = Selector.GetHandle("setAlphaValue:");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	private static readonly IntPtr selSharingTypeHandle = Selector.GetHandle("sharingType");

	private static readonly IntPtr selSetSharingType_Handle = Selector.GetHandle("setSharingType:");

	private static readonly IntPtr selPreferredBackingLocationHandle = Selector.GetHandle("preferredBackingLocation");

	private static readonly IntPtr selSetPreferredBackingLocation_Handle = Selector.GetHandle("setPreferredBackingLocation:");

	private static readonly IntPtr selBackingLocationHandle = Selector.GetHandle("backingLocation");

	private static readonly IntPtr selAllowsConcurrentViewDrawingHandle = Selector.GetHandle("allowsConcurrentViewDrawing");

	private static readonly IntPtr selSetAllowsConcurrentViewDrawing_Handle = Selector.GetHandle("setAllowsConcurrentViewDrawing:");

	private static readonly IntPtr selDisplaysWhenScreenProfileChangesHandle = Selector.GetHandle("displaysWhenScreenProfileChanges");

	private static readonly IntPtr selSetDisplaysWhenScreenProfileChanges_Handle = Selector.GetHandle("setDisplaysWhenScreenProfileChanges:");

	private static readonly IntPtr selCanBecomeVisibleWithoutLoginHandle = Selector.GetHandle("canBecomeVisibleWithoutLogin");

	private static readonly IntPtr selSetCanBecomeVisibleWithoutLogin_Handle = Selector.GetHandle("setCanBecomeVisibleWithoutLogin:");

	private static readonly IntPtr selCollectionBehaviorHandle = Selector.GetHandle("collectionBehavior");

	private static readonly IntPtr selSetCollectionBehavior_Handle = Selector.GetHandle("setCollectionBehavior:");

	private static readonly IntPtr selIsOnActiveSpaceHandle = Selector.GetHandle("isOnActiveSpace");

	private static readonly IntPtr selMinSizeHandle = Selector.GetHandle("minSize");

	private static readonly IntPtr selSetMinSize_Handle = Selector.GetHandle("setMinSize:");

	private static readonly IntPtr selMaxSizeHandle = Selector.GetHandle("maxSize");

	private static readonly IntPtr selSetMaxSize_Handle = Selector.GetHandle("setMaxSize:");

	private static readonly IntPtr selContentMinSizeHandle = Selector.GetHandle("contentMinSize");

	private static readonly IntPtr selSetContentMinSize_Handle = Selector.GetHandle("setContentMinSize:");

	private static readonly IntPtr selContentMaxSizeHandle = Selector.GetHandle("contentMaxSize");

	private static readonly IntPtr selSetContentMaxSize_Handle = Selector.GetHandle("setContentMaxSize:");

	private static readonly IntPtr selAcceptsMouseMovedEventsHandle = Selector.GetHandle("acceptsMouseMovedEvents");

	private static readonly IntPtr selSetAcceptsMouseMovedEvents_Handle = Selector.GetHandle("setAcceptsMouseMovedEvents:");

	private static readonly IntPtr selIgnoresMouseEventsHandle = Selector.GetHandle("ignoresMouseEvents");

	private static readonly IntPtr selSetIgnoresMouseEvents_Handle = Selector.GetHandle("setIgnoresMouseEvents:");

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	private static readonly IntPtr selMouseLocationOutsideOfEventStreamHandle = Selector.GetHandle("mouseLocationOutsideOfEventStream");

	private static readonly IntPtr selWindowControllerHandle = Selector.GetHandle("windowController");

	private static readonly IntPtr selSetWindowController_Handle = Selector.GetHandle("setWindowController:");

	private static readonly IntPtr selIsSheetHandle = Selector.GetHandle("isSheet");

	private static readonly IntPtr selAttachedSheetHandle = Selector.GetHandle("attachedSheet");

	private static readonly IntPtr selChildWindowsHandle = Selector.GetHandle("childWindows");

	private static readonly IntPtr selParentWindowHandle = Selector.GetHandle("parentWindow");

	private static readonly IntPtr selSetParentWindow_Handle = Selector.GetHandle("setParentWindow:");

	private static readonly IntPtr selGraphicsContextHandle = Selector.GetHandle("graphicsContext");

	private static readonly IntPtr selUserSpaceScaleFactorHandle = Selector.GetHandle("userSpaceScaleFactor");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selSetColorSpace_Handle = Selector.GetHandle("setColorSpace:");

	private static readonly IntPtr selInitialFirstResponderHandle = Selector.GetHandle("initialFirstResponder");

	private static readonly IntPtr selSetInitialFirstResponder_Handle = Selector.GetHandle("setInitialFirstResponder:");

	private static readonly IntPtr selDefaultButtonCellHandle = Selector.GetHandle("defaultButtonCell");

	private static readonly IntPtr selSetDefaultButtonCell_Handle = Selector.GetHandle("setDefaultButtonCell:");

	private static readonly IntPtr selAutorecalculatesKeyViewLoopHandle = Selector.GetHandle("autorecalculatesKeyViewLoop");

	private static readonly IntPtr selSetAutorecalculatesKeyViewLoop_Handle = Selector.GetHandle("setAutorecalculatesKeyViewLoop:");

	private static readonly IntPtr selToolbarHandle = Selector.GetHandle("toolbar");

	private static readonly IntPtr selSetToolbar_Handle = Selector.GetHandle("setToolbar:");

	private static readonly IntPtr selShowsToolbarButtonHandle = Selector.GetHandle("showsToolbarButton");

	private static readonly IntPtr selSetShowsToolbarButton_Handle = Selector.GetHandle("setShowsToolbarButton:");

	private static readonly IntPtr selWindowRefHandle = Selector.GetHandle("windowRef");

	private static readonly IntPtr selIsRestorableHandle = Selector.GetHandle("isRestorable");

	private static readonly IntPtr selSetRestorable_Handle = Selector.GetHandle("setRestorable:");

	private static readonly IntPtr selRestorationClassHandle = Selector.GetHandle("restorationClass");

	private static readonly IntPtr selSetRestorationClass_Handle = Selector.GetHandle("setRestorationClass:");

	private static readonly IntPtr selBackingScaleFactorHandle = Selector.GetHandle("backingScaleFactor");

	private static readonly IntPtr selAnimationBehaviorHandle = Selector.GetHandle("animationBehavior");

	private static readonly IntPtr selSetAnimationBehavior_Handle = Selector.GetHandle("setAnimationBehavior:");

	private static readonly IntPtr selEffectiveAppearanceHandle = Selector.GetHandle("effectiveAppearance");

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	private static readonly IntPtr selSetAppearance_Handle = Selector.GetHandle("setAppearance:");

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selFrameRectForContentRectStyleMask_Handle = Selector.GetHandle("frameRectForContentRect:styleMask:");

	private static readonly IntPtr selContentRectForFrameRectStyleMask_Handle = Selector.GetHandle("contentRectForFrameRect:styleMask:");

	private static readonly IntPtr selMinFrameWidthWithTitleStyleMask_Handle = Selector.GetHandle("minFrameWidthWithTitle:styleMask:");

	private static readonly IntPtr selFrameRectForContentRect_Handle = Selector.GetHandle("frameRectForContentRect:");

	private static readonly IntPtr selContentRectForFrameRect_Handle = Selector.GetHandle("contentRectForFrameRect:");

	private static readonly IntPtr selInitWithContentRectStyleMaskBackingDefer_Handle = Selector.GetHandle("initWithContentRect:styleMask:backing:defer:");

	private static readonly IntPtr selInitWithContentRectStyleMaskBackingDeferScreen_Handle = Selector.GetHandle("initWithContentRect:styleMask:backing:defer:screen:");

	private static readonly IntPtr selSetTitleWithRepresentedFilename_Handle = Selector.GetHandle("setTitleWithRepresentedFilename:");

	private static readonly IntPtr selSetExcludedFromWindowsMenu_Handle = Selector.GetHandle("setExcludedFromWindowsMenu:");

	private static readonly IntPtr selFieldEditorForObject_Handle = Selector.GetHandle("fieldEditor:forObject:");

	private static readonly IntPtr selEndEditingFor_Handle = Selector.GetHandle("endEditingFor:");

	private static readonly IntPtr selConstrainFrameRectToScreen_Handle = Selector.GetHandle("constrainFrameRect:toScreen:");

	private static readonly IntPtr selSetFrameDisplay_Handle = Selector.GetHandle("setFrame:display:");

	private static readonly IntPtr selSetContentSize_Handle = Selector.GetHandle("setContentSize:");

	private static readonly IntPtr selSetFrameOrigin_Handle = Selector.GetHandle("setFrameOrigin:");

	private static readonly IntPtr selSetFrameTopLeftPoint_Handle = Selector.GetHandle("setFrameTopLeftPoint:");

	private static readonly IntPtr selCascadeTopLeftFromPoint_Handle = Selector.GetHandle("cascadeTopLeftFromPoint:");

	private static readonly IntPtr selAnimationResizeTime_Handle = Selector.GetHandle("animationResizeTime:");

	private static readonly IntPtr selSetFrameDisplayAnimate_Handle = Selector.GetHandle("setFrame:display:animate:");

	private static readonly IntPtr selUseOptimizedDrawing_Handle = Selector.GetHandle("useOptimizedDrawing:");

	private static readonly IntPtr selDisableFlushWindowHandle = Selector.GetHandle("disableFlushWindow");

	private static readonly IntPtr selEnableFlushWindowHandle = Selector.GetHandle("enableFlushWindow");

	private static readonly IntPtr selFlushWindowHandle = Selector.GetHandle("flushWindow");

	private static readonly IntPtr selFlushWindowIfNeededHandle = Selector.GetHandle("flushWindowIfNeeded");

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	private static readonly IntPtr selMakeFirstResponder_Handle = Selector.GetHandle("makeFirstResponder:");

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selMiniaturize_Handle = Selector.GetHandle("miniaturize:");

	private static readonly IntPtr selDeminiaturize_Handle = Selector.GetHandle("deminiaturize:");

	private static readonly IntPtr selZoom_Handle = Selector.GetHandle("zoom:");

	private static readonly IntPtr selTryToPerformWith_Handle = Selector.GetHandle("tryToPerform:with:");

	private static readonly IntPtr selValidRequestorForSendTypeReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	private static readonly IntPtr selSetContentBorderThicknessForEdge_Handle = Selector.GetHandle("setContentBorderThickness:forEdge:");

	private static readonly IntPtr selContentBorderThicknessForEdge_Handle = Selector.GetHandle("contentBorderThicknessForEdge:");

	private static readonly IntPtr selSetAutorecalculatesContentBorderThicknessForEdge_Handle = Selector.GetHandle("setAutorecalculatesContentBorderThickness:forEdge:");

	private static readonly IntPtr selAutorecalculatesContentBorderThicknessForEdge_Handle = Selector.GetHandle("autorecalculatesContentBorderThicknessForEdge:");

	private static readonly IntPtr selCenterHandle = Selector.GetHandle("center");

	private static readonly IntPtr selMakeKeyAndOrderFront_Handle = Selector.GetHandle("makeKeyAndOrderFront:");

	private static readonly IntPtr selOrderFront_Handle = Selector.GetHandle("orderFront:");

	private static readonly IntPtr selOrderBack_Handle = Selector.GetHandle("orderBack:");

	private static readonly IntPtr selOrderOut_Handle = Selector.GetHandle("orderOut:");

	private static readonly IntPtr selOrderWindowRelativeTo_Handle = Selector.GetHandle("orderWindow:relativeTo:");

	private static readonly IntPtr selOrderFrontRegardlessHandle = Selector.GetHandle("orderFrontRegardless");

	private static readonly IntPtr selMakeKeyWindowHandle = Selector.GetHandle("makeKeyWindow");

	private static readonly IntPtr selMakeMainWindowHandle = Selector.GetHandle("makeMainWindow");

	private static readonly IntPtr selBecomeKeyWindowHandle = Selector.GetHandle("becomeKeyWindow");

	private static readonly IntPtr selResignKeyWindowHandle = Selector.GetHandle("resignKeyWindow");

	private static readonly IntPtr selBecomeMainWindowHandle = Selector.GetHandle("becomeMainWindow");

	private static readonly IntPtr selResignMainWindowHandle = Selector.GetHandle("resignMainWindow");

	private static readonly IntPtr selWorksWhenModalHandle = Selector.GetHandle("worksWhenModal");

	private static readonly IntPtr selConvertBaseToScreen_Handle = Selector.GetHandle("convertBaseToScreen:");

	private static readonly IntPtr selConvertScreenToBase_Handle = Selector.GetHandle("convertScreenToBase:");

	private static readonly IntPtr selPerformClose_Handle = Selector.GetHandle("performClose:");

	private static readonly IntPtr selPerformMiniaturize_Handle = Selector.GetHandle("performMiniaturize:");

	private static readonly IntPtr selPerformZoom_Handle = Selector.GetHandle("performZoom:");

	private static readonly IntPtr selGStateHandle = Selector.GetHandle("gState");

	private static readonly IntPtr selSetOneShot_Handle = Selector.GetHandle("setOneShot:");

	private static readonly IntPtr selDataWithEPSInsideRect_Handle = Selector.GetHandle("dataWithEPSInsideRect:");

	private static readonly IntPtr selDataWithPDFInsideRect_Handle = Selector.GetHandle("dataWithPDFInsideRect:");

	private static readonly IntPtr selPrint_Handle = Selector.GetHandle("print:");

	private static readonly IntPtr selDisableCursorRectsHandle = Selector.GetHandle("disableCursorRects");

	private static readonly IntPtr selEnableCursorRectsHandle = Selector.GetHandle("enableCursorRects");

	private static readonly IntPtr selDiscardCursorRectsHandle = Selector.GetHandle("discardCursorRects");

	private static readonly IntPtr selInvalidateCursorRectsForView_Handle = Selector.GetHandle("invalidateCursorRectsForView:");

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	private static readonly IntPtr selInvalidateShadowHandle = Selector.GetHandle("invalidateShadow");

	private static readonly IntPtr selDisableScreenUpdatesUntilFlushHandle = Selector.GetHandle("disableScreenUpdatesUntilFlush");

	private static readonly IntPtr selStringWithSavedFrameHandle = Selector.GetHandle("stringWithSavedFrame");

	private static readonly IntPtr selSetFrameFromString_Handle = Selector.GetHandle("setFrameFromString:");

	private static readonly IntPtr selSaveFrameUsingName_Handle = Selector.GetHandle("saveFrameUsingName:");

	private static readonly IntPtr selSetFrameUsingNameForce_Handle = Selector.GetHandle("setFrameUsingName:force:");

	private static readonly IntPtr selSetFrameUsingName_Handle = Selector.GetHandle("setFrameUsingName:");

	private static readonly IntPtr selFrameAutosaveNameHandle = Selector.GetHandle("frameAutosaveName");

	private static readonly IntPtr selSetFrameAutosaveName_Handle = Selector.GetHandle("setFrameAutosaveName:");

	private static readonly IntPtr selRemoveFrameUsingName_Handle = Selector.GetHandle("removeFrameUsingName:");

	private static readonly IntPtr selCacheImageInRect_Handle = Selector.GetHandle("cacheImageInRect:");

	private static readonly IntPtr selRestoreCachedImageHandle = Selector.GetHandle("restoreCachedImage");

	private static readonly IntPtr selDiscardCachedImageHandle = Selector.GetHandle("discardCachedImage");

	private static readonly IntPtr selNextEventMatchingMask_Handle = Selector.GetHandle("nextEventMatchingMask:");

	private static readonly IntPtr selNextEventMatchingMaskUntilDateInModeDequeue_Handle = Selector.GetHandle("nextEventMatchingMask:untilDate:inMode:dequeue:");

	private static readonly IntPtr selDiscardEventsMatchingMaskBeforeEvent_Handle = Selector.GetHandle("discardEventsMatchingMask:beforeEvent:");

	private static readonly IntPtr selPostEventAtStart_Handle = Selector.GetHandle("postEvent:atStart:");

	private static readonly IntPtr selCurrentEventHandle = Selector.GetHandle("currentEvent");

	private static readonly IntPtr selSendEvent_Handle = Selector.GetHandle("sendEvent:");

	private static readonly IntPtr selMenuChanged_Handle = Selector.GetHandle("menuChanged:");

	private static readonly IntPtr selStandardWindowButtonForStyleMask_Handle = Selector.GetHandle("standardWindowButton:forStyleMask:");

	private static readonly IntPtr selStandardWindowButton_Handle = Selector.GetHandle("standardWindowButton:");

	private static readonly IntPtr selAddChildWindowOrdered_Handle = Selector.GetHandle("addChildWindow:ordered:");

	private static readonly IntPtr selRemoveChildWindow_Handle = Selector.GetHandle("removeChildWindow:");

	private static readonly IntPtr selWindowNumbersWithOptions_Handle = Selector.GetHandle("windowNumbersWithOptions:");

	private static readonly IntPtr selWindowNumberAtPointBelowWindowWithWindowNumber_Handle = Selector.GetHandle("windowNumberAtPoint:belowWindowWithWindowNumber:");

	private static readonly IntPtr selSelectNextKeyView_Handle = Selector.GetHandle("selectNextKeyView:");

	private static readonly IntPtr selSelectPreviousKeyView_Handle = Selector.GetHandle("selectPreviousKeyView:");

	private static readonly IntPtr selSelectKeyViewFollowingView_Handle = Selector.GetHandle("selectKeyViewFollowingView:");

	private static readonly IntPtr selSelectKeyViewPrecedingView_Handle = Selector.GetHandle("selectKeyViewPrecedingView:");

	private static readonly IntPtr selKeyViewSelectionDirectionHandle = Selector.GetHandle("keyViewSelectionDirection");

	private static readonly IntPtr selDisableKeyEquivalentForDefaultButtonCellHandle = Selector.GetHandle("disableKeyEquivalentForDefaultButtonCell");

	private static readonly IntPtr selEnableKeyEquivalentForDefaultButtonCellHandle = Selector.GetHandle("enableKeyEquivalentForDefaultButtonCell");

	private static readonly IntPtr selRecalculateKeyViewLoopHandle = Selector.GetHandle("recalculateKeyViewLoop");

	private static readonly IntPtr selToggleToolbarShown_Handle = Selector.GetHandle("toggleToolbarShown:");

	private static readonly IntPtr selRunToolbarCustomizationPalette_Handle = Selector.GetHandle("runToolbarCustomizationPalette:");

	private static readonly IntPtr selRegisterForDraggedTypes_Handle = Selector.GetHandle("registerForDraggedTypes:");

	private static readonly IntPtr selUnregisterDraggedTypesHandle = Selector.GetHandle("unregisterDraggedTypes");

	private static readonly IntPtr selDisableSnapshotRestorationHandle = Selector.GetHandle("disableSnapshotRestoration");

	private static readonly IntPtr selEnableSnapshotRestorationHandle = Selector.GetHandle("enableSnapshotRestoration");

	private static readonly IntPtr selUpdateConstraintsIfNeededHandle = Selector.GetHandle("updateConstraintsIfNeeded");

	private static readonly IntPtr selLayoutIfNeededHandle = Selector.GetHandle("layoutIfNeeded");

	private static readonly IntPtr selSetAnchorAttributeForOrientation_Handle = Selector.GetHandle("setAnchorAttribute:forOrientation:");

	private static readonly IntPtr selVisualizeConstraints_Handle = Selector.GetHandle("visualizeConstraints:");

	private static readonly IntPtr selConvertRectToScreen_Handle = Selector.GetHandle("convertRectToScreen:");

	private static readonly IntPtr selConvertRectFromScreen_Handle = Selector.GetHandle("convertRectFromScreen:");

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	private static readonly IntPtr selBackingAlignedRectOptions_Handle = Selector.GetHandle("backingAlignedRect:options:");

	private static readonly IntPtr selToggleFullScreen_Handle = Selector.GetHandle("toggleFullScreen:");

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSWindow");

	private object __mt_RepresentedUrl_var;

	private object __mt_ContentView_var;

	private object __mt_WeakDelegate_var;

	private object __mt_FirstResponder_var;

	private object __mt_BackgroundColor_var;

	private object __mt_MiniWindowImage_var;

	private object __mt_DockTile_var;

	private object __mt_Screen_var;

	private object __mt_DeepestScreen_var;

	private object __mt_DeviceDescription_var;

	private object __mt_WindowController_var;

	private object __mt_AttachedSheet_var;

	private object __mt_ChildWindows_var;

	private object __mt_ParentWindow_var;

	private object __mt_GraphicsContext_var;

	private object __mt_ColorSpace_var;

	private object __mt_InitialFirstResponder_var;

	private object __mt_DefaultButtonCell_var;

	private object __mt_Toolbar_var;

	private object __mt_EffectiveAppearance_var;

	private object __mt_Appearance_var;

	private object __mt_Animator_var;

	private object __mt_Animations_var;

	private static NSString _DidBecomeKeyNotification;

	private static NSString _DidBecomeMainNotification;

	private static NSString _DidChangeScreenNotification;

	private static NSString _DidDeminiaturizeNotification;

	private static NSString _DidExposeNotification;

	private static NSString _DidMiniaturizeNotification;

	private static NSString _DidMoveNotification;

	private static NSString _DidResignKeyNotification;

	private static NSString _DidResignMainNotification;

	private static NSString _DidResizeNotification;

	private static NSString _DidUpdateNotification;

	private static NSString _WillCloseNotification;

	private static NSString _WillMiniaturizeNotification;

	private static NSString _WillMoveNotification;

	private static NSString _WillBeginSheetNotification;

	private static NSString _DidEndSheetNotification;

	private static NSString _DidChangeScreenProfileNotification;

	private static NSString _WillStartLiveResizeNotification;

	private static NSString _DidEndLiveResizeNotification;

	private static NSString _WillEnterFullScreenNotification;

	private static NSString _DidEnterFullScreenNotification;

	private static NSString _WillExitFullScreenNotification;

	private static NSString _DidExitFullScreenNotification;

	private static NSString _WillEnterVersionBrowserNotification;

	private static NSString _DidEnterVersionBrowserNotification;

	private static NSString _WillExitVersionBrowserNotification;

	private static NSString _DidExitVersionBrowserNotification;

	public string FrameAutosaveName
	{
		get
		{
			return GetFrameAutosaveName();
		}
		set
		{
			SetFrameAutosaveName(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSWindowDepth DefaultDepthLimit
	{
		[Export("defaultDepthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindowDepth)Messaging.Int64_objc_msgSend(class_ptr, selDefaultDepthLimitHandle);
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSUrl RepresentedUrl
	{
		[Export("representedURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_RepresentedUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedURLHandle)))));
		}
		[Export("setRepresentedURL:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedURL_Handle, value.Handle);
			}
			__mt_RepresentedUrl_var = value;
		}
	}

	public virtual string RepresentedFilename
	{
		[Export("representedFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedFilenameHandle));
		}
		[Export("setRepresentedFilename:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool ExcludedFromWindowsMenu
	{
		[Export("isExcludedFromWindowsMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExcludedFromWindowsMenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExcludedFromWindowsMenuHandle);
		}
	}

	public virtual NSView ContentView
	{
		[Export("contentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_ContentView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentViewHandle)))));
		}
		[Export("setContentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentView_Handle, value.Handle);
			}
			__mt_ContentView_var = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
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

	public NSWindowDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSWindowDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual long WindowNumber
	{
		[Export("windowNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWindowNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWindowNumberHandle);
		}
	}

	public virtual NSWindowStyle StyleMask
	{
		[Export("styleMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowStyle)Messaging.UInt64_objc_msgSend(base.Handle, selStyleMaskHandle);
			}
			return (NSWindowStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStyleMaskHandle);
		}
		[Export("setStyleMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStyleMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStyleMask_Handle, (ulong)value);
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

	public virtual bool ShowsResizeIndicator
	{
		[Export("showsResizeIndicator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsResizeIndicatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsResizeIndicatorHandle);
		}
		[Export("setShowsResizeIndicator:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsResizeIndicator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsResizeIndicator_Handle, value);
			}
		}
	}

	public virtual CGSize ResizeIncrements
	{
		[Export("resizeIncrements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selResizeIncrementsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selResizeIncrementsHandle);
		}
		[Export("setResizeIncrements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetResizeIncrements_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetResizeIncrements_Handle, value);
			}
		}
	}

	public virtual CGSize AspectRatio
	{
		[Export("aspectRatio")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selAspectRatioHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selAspectRatioHandle);
		}
		[Export("setAspectRatio:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetAspectRatio_Handle, value);
			}
		}
	}

	public virtual CGSize ContentResizeIncrements
	{
		[Export("contentResizeIncrements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentResizeIncrementsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentResizeIncrementsHandle);
		}
		[Export("setContentResizeIncrements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentResizeIncrements_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentResizeIncrements_Handle, value);
			}
		}
	}

	public virtual CGSize ContentAspectRatio
	{
		[Export("contentAspectRatio")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentAspectRatioHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentAspectRatioHandle);
		}
		[Export("setContentAspectRatio:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentAspectRatio_Handle, value);
			}
		}
	}

	public virtual bool FlushWindowDisabled
	{
		[Export("isFlushWindowDisabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlushWindowDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlushWindowDisabledHandle);
		}
	}

	public virtual bool ViewsNeedDisplay
	{
		[Export("viewsNeedDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selViewsNeedDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selViewsNeedDisplayHandle);
		}
		[Export("setViewsNeedDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetViewsNeedDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetViewsNeedDisplay_Handle, value);
			}
		}
	}

	public virtual bool Autodisplay
	{
		[Export("isAutodisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutodisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutodisplayHandle);
		}
		[Export("setAutodisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutodisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutodisplay_Handle, value);
			}
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
		[Export("setPreservesContentDuringLiveResize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesContentDuringLiveResize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesContentDuringLiveResize_Handle, value);
			}
		}
	}

	public virtual NSResponder FirstResponder
	{
		[Export("firstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSResponder)(__mt_FirstResponder_var = ((!IsDirectBinding) ? ((NSResponder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstResponderHandle))) : ((NSResponder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstResponderHandle)))));
		}
	}

	public virtual long ResizeFlags
	{
		[Export("resizeFlags")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selResizeFlagsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selResizeFlagsHandle);
		}
	}

	public virtual bool ReleasedWhenClosed
	{
		[Export("isReleasedWhenClosed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReleasedWhenClosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReleasedWhenClosedHandle);
		}
		[Export("setReleasedWhenClosed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReleasedWhenClosed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReleasedWhenClosed_Handle, value);
			}
		}
	}

	public virtual bool IsZoomed
	{
		[Export("isZoomed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsZoomedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsZoomedHandle);
		}
		[Export("setIsZoomed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsZoomed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsZoomed_Handle, value);
			}
		}
	}

	public virtual bool IsMiniaturized
	{
		[Export("isMiniaturized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMiniaturizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMiniaturizedHandle);
		}
		[Export("setIsMiniaturized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsMiniaturized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsMiniaturized_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool IsMovable
	{
		[Export("isMovable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableHandle);
		}
		[Export("setMovable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovable_Handle, value);
			}
		}
	}

	public virtual bool MovableByWindowBackground
	{
		[Export("isMovableByWindowBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMovableByWindowBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMovableByWindowBackgroundHandle);
		}
		[Export("setMovableByWindowBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMovableByWindowBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMovableByWindowBackground_Handle, value);
			}
		}
	}

	public virtual bool HidesOnDeactivate
	{
		[Export("hidesOnDeactivate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesOnDeactivateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesOnDeactivateHandle);
		}
		[Export("setHidesOnDeactivate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidesOnDeactivate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidesOnDeactivate_Handle, value);
			}
		}
	}

	public virtual bool CanHide
	{
		[Export("canHide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanHideHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanHideHandle);
		}
		[Export("setCanHide:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanHide_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanHide_Handle, value);
			}
		}
	}

	public virtual NSImage MiniWindowImage
	{
		[Export("miniwindowImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_MiniWindowImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiniwindowImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMiniwindowImageHandle)))));
		}
		[Export("setMiniwindowImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiniwindowImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiniwindowImage_Handle, value.Handle);
			}
			__mt_MiniWindowImage_var = value;
		}
	}

	public virtual string MiniWindowTitle
	{
		[Export("miniwindowTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMiniwindowTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiniwindowTitleHandle));
		}
		[Export("setMiniwindowTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiniwindowTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiniwindowTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDockTile DockTile
	{
		[Export("dockTile")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDockTile)(__mt_DockTile_var = ((!IsDirectBinding) ? ((NSDockTile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDockTileHandle))) : ((NSDockTile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDockTileHandle)))));
		}
	}

	public virtual bool DocumentEdited
	{
		[Export("isDocumentEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDocumentEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDocumentEditedHandle);
		}
		[Export("setDocumentEdited:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDocumentEdited_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDocumentEdited_Handle, value);
			}
		}
	}

	public virtual bool IsVisible
	{
		[Export("isVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
		[Export("setIsVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsVisible_Handle, value);
			}
		}
	}

	public virtual bool IsKeyWindow
	{
		[Export("isKeyWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsKeyWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsKeyWindowHandle);
		}
	}

	public virtual bool IsMainWindow
	{
		[Export("isMainWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMainWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMainWindowHandle);
		}
	}

	public virtual bool CanBecomeKeyWindow
	{
		[Export("canBecomeKeyWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeKeyWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeKeyWindowHandle);
		}
	}

	public virtual bool CanBecomeMainWindow
	{
		[Export("canBecomeMainWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeMainWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeMainWindowHandle);
		}
	}

	public virtual bool PreventsApplicationTerminationWhenModal
	{
		[Export("preventsApplicationTerminationWhenModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreventsApplicationTerminationWhenModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreventsApplicationTerminationWhenModalHandle);
		}
		[Export("setPreventsApplicationTerminationWhenModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreventsApplicationTerminationWhenModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreventsApplicationTerminationWhenModal_Handle, value);
			}
		}
	}

	public virtual bool IsOneShot
	{
		[Export("isOneShot")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOneShotHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOneShotHandle);
		}
	}

	public virtual bool AreCursorRectsEnabled
	{
		[Export("areCursorRectsEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAreCursorRectsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAreCursorRectsEnabledHandle);
		}
	}

	public virtual bool AllowsToolTipsWhenApplicationIsInactive
	{
		[Export("allowsToolTipsWhenApplicationIsInactive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsToolTipsWhenApplicationIsInactiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsToolTipsWhenApplicationIsInactiveHandle);
		}
		[Export("setAllowsToolTipsWhenApplicationIsInactive:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsToolTipsWhenApplicationIsInactive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsToolTipsWhenApplicationIsInactive_Handle, value);
			}
		}
	}

	public virtual NSBackingStore BackingType
	{
		[Export("backingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBackingStore)Messaging.UInt64_objc_msgSend(base.Handle, selBackingTypeHandle);
			}
			return (NSBackingStore)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBackingTypeHandle);
		}
		[Export("setBackingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBackingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBackingType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSWindowLevel Level
	{
		[Export("level")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowLevel)Messaging.Int64_objc_msgSend(base.Handle, selLevelHandle);
			}
			return (NSWindowLevel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLevelHandle);
		}
		[Export("setLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLevel_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLevel_Handle, (long)value);
			}
		}
	}

	public virtual NSWindowDepth DepthLimit
	{
		[Export("depthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowDepth)Messaging.Int64_objc_msgSend(base.Handle, selDepthLimitHandle);
			}
			return (NSWindowDepth)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDepthLimitHandle);
		}
		[Export("setDepthLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDepthLimit_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDepthLimit_Handle, (long)value);
			}
		}
	}

	public virtual bool HasDynamicDepthLimit
	{
		[Export("hasDynamicDepthLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDynamicDepthLimitHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDynamicDepthLimitHandle);
		}
		[Export("setDynamicDepthLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDynamicDepthLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDynamicDepthLimit_Handle, value);
			}
		}
	}

	public virtual NSScreen Screen
	{
		[Export("screen")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScreen)(__mt_Screen_var = ((!IsDirectBinding) ? ((NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScreenHandle))) : ((NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selScreenHandle)))));
		}
	}

	public virtual NSScreen DeepestScreen
	{
		[Export("deepestScreen")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScreen)(__mt_DeepestScreen_var = ((!IsDirectBinding) ? ((NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeepestScreenHandle))) : ((NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeepestScreenHandle)))));
		}
	}

	public virtual bool CanStoreColor
	{
		[Export("canStoreColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStoreColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStoreColorHandle);
		}
	}

	public virtual bool HasShadow
	{
		[Export("hasShadow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasShadowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasShadowHandle);
		}
		[Export("setHasShadow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasShadow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasShadow_Handle, value);
			}
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
		[Export("setOpaque:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual NSWindowSharingType SharingType
	{
		[Export("sharingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowSharingType)Messaging.UInt64_objc_msgSend(base.Handle, selSharingTypeHandle);
			}
			return (NSWindowSharingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSharingTypeHandle);
		}
		[Export("setSharingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSharingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSharingType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSWindowBackingLocation PreferredBackingLocation
	{
		[Export("preferredBackingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSend(base.Handle, selPreferredBackingLocationHandle);
			}
			return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPreferredBackingLocationHandle);
		}
		[Export("setPreferredBackingLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPreferredBackingLocation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPreferredBackingLocation_Handle, (ulong)value);
			}
		}
	}

	public virtual NSWindowBackingLocation BackingLocation
	{
		[Export("backingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSend(base.Handle, selBackingLocationHandle);
			}
			return (NSWindowBackingLocation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBackingLocationHandle);
		}
	}

	public virtual bool AllowsConcurrentViewDrawing
	{
		[Export("allowsConcurrentViewDrawing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsConcurrentViewDrawingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsConcurrentViewDrawingHandle);
		}
		[Export("setAllowsConcurrentViewDrawing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsConcurrentViewDrawing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsConcurrentViewDrawing_Handle, value);
			}
		}
	}

	public virtual bool DisplaysWhenScreenProfileChanges
	{
		[Export("displaysWhenScreenProfileChanges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysWhenScreenProfileChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysWhenScreenProfileChangesHandle);
		}
		[Export("setDisplaysWhenScreenProfileChanges:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysWhenScreenProfileChanges_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysWhenScreenProfileChanges_Handle, value);
			}
		}
	}

	public virtual bool CanBecomeVisibleWithoutLogin
	{
		[Export("canBecomeVisibleWithoutLogin")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeVisibleWithoutLoginHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeVisibleWithoutLoginHandle);
		}
		[Export("setCanBecomeVisibleWithoutLogin:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanBecomeVisibleWithoutLogin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanBecomeVisibleWithoutLogin_Handle, value);
			}
		}
	}

	public virtual NSWindowCollectionBehavior CollectionBehavior
	{
		[Export("collectionBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowCollectionBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selCollectionBehaviorHandle);
			}
			return (NSWindowCollectionBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCollectionBehaviorHandle);
		}
		[Export("setCollectionBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCollectionBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCollectionBehavior_Handle, (ulong)value);
			}
		}
	}

	public virtual bool IsOnActiveSpace
	{
		[Export("isOnActiveSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOnActiveSpaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOnActiveSpaceHandle);
		}
	}

	public virtual CGSize MinSize
	{
		[Export("minSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinSizeHandle);
		}
		[Export("setMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinSize_Handle, value);
			}
		}
	}

	public virtual CGSize MaxSize
	{
		[Export("maxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxSizeHandle);
		}
		[Export("setMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxSize_Handle, value);
			}
		}
	}

	public virtual CGSize ContentMinSize
	{
		[Export("contentMinSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentMinSizeHandle);
		}
		[Export("setContentMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentMinSize_Handle, value);
			}
		}
	}

	public virtual CGSize ContentMaxSize
	{
		[Export("contentMaxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentMaxSizeHandle);
		}
		[Export("setContentMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentMaxSize_Handle, value);
			}
		}
	}

	public virtual bool AcceptsMouseMovedEvents
	{
		[Export("acceptsMouseMovedEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsMouseMovedEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsMouseMovedEventsHandle);
		}
		[Export("setAcceptsMouseMovedEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsMouseMovedEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsMouseMovedEvents_Handle, value);
			}
		}
	}

	public virtual bool IgnoresMouseEvents
	{
		[Export("ignoresMouseEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoresMouseEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoresMouseEventsHandle);
		}
		[Export("setIgnoresMouseEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIgnoresMouseEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIgnoresMouseEvents_Handle, value);
			}
		}
	}

	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_DeviceDescription_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle)))));
		}
	}

	public virtual CGPoint MouseLocationOutsideOfEventStream
	{
		[Export("mouseLocationOutsideOfEventStream")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selMouseLocationOutsideOfEventStreamHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selMouseLocationOutsideOfEventStreamHandle);
		}
	}

	public virtual NSObject WindowController
	{
		[Export("windowController")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WindowController_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowControllerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowControllerHandle))));
		}
		[Export("setWindowController:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindowController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindowController_Handle, value.Handle);
			}
			__mt_WindowController_var = value;
		}
	}

	public virtual bool IsSheet
	{
		[Export("isSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSheetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSheetHandle);
		}
	}

	public virtual NSWindow AttachedSheet
	{
		[Export("attachedSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_AttachedSheet_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedSheetHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedSheetHandle)))));
		}
	}

	public virtual NSWindow[] ChildWindows
	{
		[Export("childWindows")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow[])(__mt_ChildWindows_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildWindowsHandle)) : NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildWindowsHandle))));
		}
	}

	public virtual NSWindow ParentWindow
	{
		[Export("parentWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_ParentWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentWindowHandle)))));
		}
		[Export("setParentWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_ParentWindow_var = value;
		}
	}

	public virtual NSGraphicsContext GraphicsContext
	{
		[Export("graphicsContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSGraphicsContext)(__mt_GraphicsContext_var = ((!IsDirectBinding) ? ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGraphicsContextHandle))) : ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGraphicsContextHandle)))));
		}
	}

	public virtual double UserSpaceScaleFactor
	{
		[Export("userSpaceScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selUserSpaceScaleFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selUserSpaceScaleFactorHandle);
		}
	}

	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_ColorSpace_var = ((!IsDirectBinding) ? ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle))) : ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle)))));
		}
		[Export("setColorSpace:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorSpace_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorSpace_Handle, value.Handle);
			}
			__mt_ColorSpace_var = value;
		}
	}

	public virtual NSView InitialFirstResponder
	{
		[Export("initialFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_InitialFirstResponder_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialFirstResponderHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialFirstResponderHandle)))));
		}
		[Export("setInitialFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInitialFirstResponder_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInitialFirstResponder_Handle, value.Handle);
			}
			__mt_InitialFirstResponder_var = value;
		}
	}

	public virtual NSButtonCell DefaultButtonCell
	{
		[Export("defaultButtonCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSButtonCell)(__mt_DefaultButtonCell_var = ((!IsDirectBinding) ? ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultButtonCellHandle))) : ((NSButtonCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultButtonCellHandle)))));
		}
		[Export("setDefaultButtonCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultButtonCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultButtonCell_Handle, value.Handle);
			}
			__mt_DefaultButtonCell_var = value;
		}
	}

	public virtual bool AutorecalculatesKeyViewLoop
	{
		[Export("autorecalculatesKeyViewLoop")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutorecalculatesKeyViewLoopHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutorecalculatesKeyViewLoopHandle);
		}
		[Export("setAutorecalculatesKeyViewLoop:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutorecalculatesKeyViewLoop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutorecalculatesKeyViewLoop_Handle, value);
			}
		}
	}

	public virtual NSToolbar Toolbar
	{
		[Export("toolbar")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSToolbar)(__mt_Toolbar_var = ((!IsDirectBinding) ? ((NSToolbar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarHandle))) : ((NSToolbar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarHandle)))));
		}
		[Export("setToolbar:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToolbar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToolbar_Handle, value.Handle);
			}
			__mt_Toolbar_var = value;
		}
	}

	public virtual bool ShowsToolbarButton
	{
		[Export("showsToolbarButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsToolbarButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsToolbarButtonHandle);
		}
		[Export("setShowsToolbarButton:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsToolbarButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsToolbarButton_Handle, value);
			}
		}
	}

	public virtual IntPtr WindowRef
	{
		[Export("windowRef")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selWindowRefHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowRefHandle);
		}
	}

	public virtual bool Restorable
	{
		[Export("isRestorable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRestorableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRestorableHandle);
		}
		[Export("setRestorable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRestorable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRestorable_Handle, value);
			}
		}
	}

	public virtual Class RestorationClass
	{
		[Export("restorationClass")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selRestorationClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRestorationClassHandle));
		}
		[Export("setRestorationClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRestorationClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRestorationClass_Handle, value.Handle);
			}
		}
	}

	public virtual double BackingScaleFactor
	{
		[Export("backingScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBackingScaleFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBackingScaleFactorHandle);
		}
	}

	public virtual NSWindowAnimationBehavior AnimationBehavior
	{
		[Export("animationBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowAnimationBehavior)Messaging.Int64_objc_msgSend(base.Handle, selAnimationBehaviorHandle);
			}
			return (NSWindowAnimationBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAnimationBehaviorHandle);
		}
		[Export("setAnimationBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAnimationBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAnimationBehavior_Handle, (long)value);
			}
		}
	}

	public virtual NSAppearance EffectiveAppearance
	{
		[Export("effectiveAppearance")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAppearance)(__mt_EffectiveAppearance_var = ((!IsDirectBinding) ? ((NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEffectiveAppearanceHandle))) : ((NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEffectiveAppearanceHandle)))));
		}
	}

	public virtual NSAppearance Appearance
	{
		[Export("appearance")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAppearance)(__mt_Appearance_var = ((!IsDirectBinding) ? ((NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle))) : ((NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceHandle)))));
		}
		[Export("setAppearance:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppearance_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppearance_Handle, value.Handle);
			}
			__mt_Appearance_var = value;
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

	[Field("NSWindowDidBecomeKeyNotification", "AppKit")]
	public static NSString DidBecomeKeyNotification
	{
		get
		{
			if (_DidBecomeKeyNotification == null)
			{
				_DidBecomeKeyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidBecomeKeyNotification");
			}
			return _DidBecomeKeyNotification;
		}
	}

	[Field("NSWindowDidBecomeMainNotification", "AppKit")]
	public static NSString DidBecomeMainNotification
	{
		get
		{
			if (_DidBecomeMainNotification == null)
			{
				_DidBecomeMainNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidBecomeMainNotification");
			}
			return _DidBecomeMainNotification;
		}
	}

	[Field("NSWindowDidChangeScreenNotification", "AppKit")]
	public static NSString DidChangeScreenNotification
	{
		get
		{
			if (_DidChangeScreenNotification == null)
			{
				_DidChangeScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidChangeScreenNotification");
			}
			return _DidChangeScreenNotification;
		}
	}

	[Field("NSWindowDidDeminiaturizeNotification", "AppKit")]
	public static NSString DidDeminiaturizeNotification
	{
		get
		{
			if (_DidDeminiaturizeNotification == null)
			{
				_DidDeminiaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidDeminiaturizeNotification");
			}
			return _DidDeminiaturizeNotification;
		}
	}

	[Field("NSWindowDidExposeNotification", "AppKit")]
	public static NSString DidExposeNotification
	{
		get
		{
			if (_DidExposeNotification == null)
			{
				_DidExposeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExposeNotification");
			}
			return _DidExposeNotification;
		}
	}

	[Field("NSWindowDidMiniaturizeNotification", "AppKit")]
	public static NSString DidMiniaturizeNotification
	{
		get
		{
			if (_DidMiniaturizeNotification == null)
			{
				_DidMiniaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidMiniaturizeNotification");
			}
			return _DidMiniaturizeNotification;
		}
	}

	[Field("NSWindowDidMoveNotification", "AppKit")]
	public static NSString DidMoveNotification
	{
		get
		{
			if (_DidMoveNotification == null)
			{
				_DidMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidMoveNotification");
			}
			return _DidMoveNotification;
		}
	}

	[Field("NSWindowDidResignKeyNotification", "AppKit")]
	public static NSString DidResignKeyNotification
	{
		get
		{
			if (_DidResignKeyNotification == null)
			{
				_DidResignKeyNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResignKeyNotification");
			}
			return _DidResignKeyNotification;
		}
	}

	[Field("NSWindowDidResignMainNotification", "AppKit")]
	public static NSString DidResignMainNotification
	{
		get
		{
			if (_DidResignMainNotification == null)
			{
				_DidResignMainNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResignMainNotification");
			}
			return _DidResignMainNotification;
		}
	}

	[Field("NSWindowDidResizeNotification", "AppKit")]
	public static NSString DidResizeNotification
	{
		get
		{
			if (_DidResizeNotification == null)
			{
				_DidResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidResizeNotification");
			}
			return _DidResizeNotification;
		}
	}

	[Field("NSWindowDidUpdateNotification", "AppKit")]
	public static NSString DidUpdateNotification
	{
		get
		{
			if (_DidUpdateNotification == null)
			{
				_DidUpdateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidUpdateNotification");
			}
			return _DidUpdateNotification;
		}
	}

	[Field("NSWindowWillCloseNotification", "AppKit")]
	public static NSString WillCloseNotification
	{
		get
		{
			if (_WillCloseNotification == null)
			{
				_WillCloseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillCloseNotification");
			}
			return _WillCloseNotification;
		}
	}

	[Field("NSWindowWillMiniaturizeNotification", "AppKit")]
	public static NSString WillMiniaturizeNotification
	{
		get
		{
			if (_WillMiniaturizeNotification == null)
			{
				_WillMiniaturizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillMiniaturizeNotification");
			}
			return _WillMiniaturizeNotification;
		}
	}

	[Field("NSWindowWillMoveNotification", "AppKit")]
	public static NSString WillMoveNotification
	{
		get
		{
			if (_WillMoveNotification == null)
			{
				_WillMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillMoveNotification");
			}
			return _WillMoveNotification;
		}
	}

	[Field("NSWindowWillBeginSheetNotification", "AppKit")]
	public static NSString WillBeginSheetNotification
	{
		get
		{
			if (_WillBeginSheetNotification == null)
			{
				_WillBeginSheetNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillBeginSheetNotification");
			}
			return _WillBeginSheetNotification;
		}
	}

	[Field("NSWindowDidEndSheetNotification", "AppKit")]
	public static NSString DidEndSheetNotification
	{
		get
		{
			if (_DidEndSheetNotification == null)
			{
				_DidEndSheetNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEndSheetNotification");
			}
			return _DidEndSheetNotification;
		}
	}

	[Field("NSWindowDidChangeScreenProfileNotification", "AppKit")]
	public static NSString DidChangeScreenProfileNotification
	{
		get
		{
			if (_DidChangeScreenProfileNotification == null)
			{
				_DidChangeScreenProfileNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidChangeScreenProfileNotification");
			}
			return _DidChangeScreenProfileNotification;
		}
	}

	[Field("NSWindowWillStartLiveResizeNotification", "AppKit")]
	public static NSString WillStartLiveResizeNotification
	{
		get
		{
			if (_WillStartLiveResizeNotification == null)
			{
				_WillStartLiveResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillStartLiveResizeNotification");
			}
			return _WillStartLiveResizeNotification;
		}
	}

	[Field("NSWindowDidEndLiveResizeNotification", "AppKit")]
	public static NSString DidEndLiveResizeNotification
	{
		get
		{
			if (_DidEndLiveResizeNotification == null)
			{
				_DidEndLiveResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEndLiveResizeNotification");
			}
			return _DidEndLiveResizeNotification;
		}
	}

	[Field("NSWindowWillEnterFullScreenNotification", "AppKit")]
	public static NSString WillEnterFullScreenNotification
	{
		get
		{
			if (_WillEnterFullScreenNotification == null)
			{
				_WillEnterFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillEnterFullScreenNotification");
			}
			return _WillEnterFullScreenNotification;
		}
	}

	[Field("NSWindowDidEnterFullScreenNotification", "AppKit")]
	public static NSString DidEnterFullScreenNotification
	{
		get
		{
			if (_DidEnterFullScreenNotification == null)
			{
				_DidEnterFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEnterFullScreenNotification");
			}
			return _DidEnterFullScreenNotification;
		}
	}

	[Field("NSWindowWillExitFullScreenNotification", "AppKit")]
	public static NSString WillExitFullScreenNotification
	{
		get
		{
			if (_WillExitFullScreenNotification == null)
			{
				_WillExitFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillExitFullScreenNotification");
			}
			return _WillExitFullScreenNotification;
		}
	}

	[Field("NSWindowDidExitFullScreenNotification", "AppKit")]
	public static NSString DidExitFullScreenNotification
	{
		get
		{
			if (_DidExitFullScreenNotification == null)
			{
				_DidExitFullScreenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExitFullScreenNotification");
			}
			return _DidExitFullScreenNotification;
		}
	}

	[Field("NSWindowWillEnterVersionBrowserNotification", "AppKit")]
	public static NSString WillEnterVersionBrowserNotification
	{
		get
		{
			if (_WillEnterVersionBrowserNotification == null)
			{
				_WillEnterVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillEnterVersionBrowserNotification");
			}
			return _WillEnterVersionBrowserNotification;
		}
	}

	[Field("NSWindowDidEnterVersionBrowserNotification", "AppKit")]
	public static NSString DidEnterVersionBrowserNotification
	{
		get
		{
			if (_DidEnterVersionBrowserNotification == null)
			{
				_DidEnterVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidEnterVersionBrowserNotification");
			}
			return _DidEnterVersionBrowserNotification;
		}
	}

	[Field("NSWindowWillExitVersionBrowserNotification", "AppKit")]
	public static NSString WillExitVersionBrowserNotification
	{
		get
		{
			if (_WillExitVersionBrowserNotification == null)
			{
				_WillExitVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowWillExitVersionBrowserNotification");
			}
			return _WillExitVersionBrowserNotification;
		}
	}

	[Field("NSWindowDidExitVersionBrowserNotification", "AppKit")]
	public static NSString DidExitVersionBrowserNotification
	{
		get
		{
			if (_DidExitVersionBrowserNotification == null)
			{
				_DidExitVersionBrowserNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWindowDidExitVersionBrowserNotification");
			}
			return _DidExitVersionBrowserNotification;
		}
	}

	public NSObjectPredicate WindowShouldClose
	{
		get
		{
			return EnsureNSWindowDelegate().windowShouldClose;
		}
		set
		{
			EnsureNSWindowDelegate().windowShouldClose = value;
		}
	}

	public NSWindowClient WillReturnFieldEditor
	{
		get
		{
			return EnsureNSWindowDelegate().willReturnFieldEditor;
		}
		set
		{
			EnsureNSWindowDelegate().willReturnFieldEditor = value;
		}
	}

	public NSWindowResize WillResize
	{
		get
		{
			return EnsureNSWindowDelegate().willResize;
		}
		set
		{
			EnsureNSWindowDelegate().willResize = value;
		}
	}

	public NSWindowFrame WillUseStandardFrame
	{
		get
		{
			return EnsureNSWindowDelegate().willUseStandardFrame;
		}
		set
		{
			EnsureNSWindowDelegate().willUseStandardFrame = value;
		}
	}

	public NSWindowFramePredicate ShouldZoom
	{
		get
		{
			return EnsureNSWindowDelegate().shouldZoom;
		}
		set
		{
			EnsureNSWindowDelegate().shouldZoom = value;
		}
	}

	public NSWindowUndoManager WillReturnUndoManager
	{
		get
		{
			return EnsureNSWindowDelegate().willReturnUndoManager;
		}
		set
		{
			EnsureNSWindowDelegate().willReturnUndoManager = value;
		}
	}

	public NSWindowSheetRect WillPositionSheet
	{
		get
		{
			return EnsureNSWindowDelegate().willPositionSheet;
		}
		set
		{
			EnsureNSWindowDelegate().willPositionSheet = value;
		}
	}

	public NSWindowMenu ShouldPopUpDocumentPathMenu
	{
		get
		{
			return EnsureNSWindowDelegate().shouldPopUpDocumentPathMenu;
		}
		set
		{
			EnsureNSWindowDelegate().shouldPopUpDocumentPathMenu = value;
		}
	}

	public NSWindowDocumentDrag ShouldDragDocumentWithEvent
	{
		get
		{
			return EnsureNSWindowDelegate().shouldDragDocumentWithEvent;
		}
		set
		{
			EnsureNSWindowDelegate().shouldDragDocumentWithEvent = value;
		}
	}

	public NSWindowSize WillUseFullScreenContentSize
	{
		get
		{
			return EnsureNSWindowDelegate().willUseFullScreenContentSize;
		}
		set
		{
			EnsureNSWindowDelegate().willUseFullScreenContentSize = value;
		}
	}

	public NSWindowApplicationPresentationOptions WillUseFullScreenPresentationOptions
	{
		get
		{
			return EnsureNSWindowDelegate().willUseFullScreenPresentationOptions;
		}
		set
		{
			EnsureNSWindowDelegate().willUseFullScreenPresentationOptions = value;
		}
	}

	public NSWindowWindows CustomWindowsToEnterFullScreen
	{
		get
		{
			return EnsureNSWindowDelegate().customWindowsToEnterFullScreen;
		}
		set
		{
			EnsureNSWindowDelegate().customWindowsToEnterFullScreen = value;
		}
	}

	public NSWindowWindows CustomWindowsToExitFullScreen
	{
		get
		{
			return EnsureNSWindowDelegate().customWindowsToExitFullScreen;
		}
		set
		{
			EnsureNSWindowDelegate().customWindowsToExitFullScreen = value;
		}
	}

	public NSWindowSizeSize WillResizeForVersionBrowser
	{
		get
		{
			return EnsureNSWindowDelegate().willResizeForVersionBrowser;
		}
		set
		{
			EnsureNSWindowDelegate().willResizeForVersionBrowser = value;
		}
	}

	public event EventHandler DidResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResize, value);
		}
	}

	public event EventHandler DidExpose
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExpose = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExpose, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExpose = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExpose, value);
		}
	}

	public event EventHandler WillMove
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMove = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willMove, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMove = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willMove, value);
		}
	}

	public event EventHandler DidMoved
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMoved = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didMoved, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMoved = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didMoved, value);
		}
	}

	public event EventHandler DidBecomeKey
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeKey = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didBecomeKey, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeKey = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didBecomeKey, value);
		}
	}

	public event EventHandler DidResignKey
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignKey = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResignKey, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignKey = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResignKey, value);
		}
	}

	public event EventHandler DidBecomeMain
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeMain = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didBecomeMain, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didBecomeMain = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didBecomeMain, value);
		}
	}

	public event EventHandler DidResignMain
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignMain = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didResignMain, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didResignMain = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didResignMain, value);
		}
	}

	public event EventHandler WillClose
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willClose = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willClose, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willClose = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willClose, value);
		}
	}

	public event EventHandler WillMiniaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMiniaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willMiniaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willMiniaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willMiniaturize, value);
		}
	}

	public event EventHandler DidMiniaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMiniaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didMiniaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didMiniaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didMiniaturize, value);
		}
	}

	public event EventHandler DidDeminiaturize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDeminiaturize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didDeminiaturize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDeminiaturize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didDeminiaturize, value);
		}
	}

	public event EventHandler DidUpdate
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didUpdate = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didUpdate, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didUpdate = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didUpdate, value);
		}
	}

	public event EventHandler DidChangeScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didChangeScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didChangeScreen, value);
		}
	}

	public event EventHandler DidChangeScreenProfile
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreenProfile = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didChangeScreenProfile, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didChangeScreenProfile = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didChangeScreenProfile, value);
		}
	}

	public event EventHandler WillBeginSheet
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willBeginSheet = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willBeginSheet, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willBeginSheet = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willBeginSheet, value);
		}
	}

	public event EventHandler DidEndSheet
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndSheet = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEndSheet, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndSheet = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEndSheet, value);
		}
	}

	public event EventHandler WillStartLiveResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willStartLiveResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willStartLiveResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willStartLiveResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willStartLiveResize, value);
		}
	}

	public event EventHandler DidEndLiveResize
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndLiveResize = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEndLiveResize, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEndLiveResize = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEndLiveResize, value);
		}
	}

	public event EventHandler WillEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willEnterFullScreen, value);
		}
	}

	public event EventHandler DidEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEnterFullScreen, value);
		}
	}

	public event EventHandler WillExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willExitFullScreen, value);
		}
	}

	public event EventHandler DidExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExitFullScreen, value);
		}
	}

	public event EventHandler DidFailToEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToEnterFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didFailToEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToEnterFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didFailToEnterFullScreen, value);
		}
	}

	public event EventHandler DidFailToExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToExitFullScreen = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didFailToExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didFailToExitFullScreen = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didFailToExitFullScreen, value);
		}
	}

	public event EventHandler<NSWindowDurationEventArgs> StartCustomAnimationToEnterFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToEnterFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Combine(nSWindowDelegate.startCustomAnimationToEnterFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToEnterFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Remove(nSWindowDelegate.startCustomAnimationToEnterFullScreen, value);
		}
	}

	public event EventHandler<NSWindowDurationEventArgs> StartCustomAnimationToExitFullScreen
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToExitFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Combine(nSWindowDelegate.startCustomAnimationToExitFullScreen, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.startCustomAnimationToExitFullScreen = (EventHandler<NSWindowDurationEventArgs>)System.Delegate.Remove(nSWindowDelegate.startCustomAnimationToExitFullScreen, value);
		}
	}

	public event EventHandler<NSWindowCoderEventArgs> WillEncodeRestorableState
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEncodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Combine(nSWindowDelegate.willEncodeRestorableState, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEncodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Remove(nSWindowDelegate.willEncodeRestorableState, value);
		}
	}

	public event EventHandler<NSWindowCoderEventArgs> DidDecodeRestorableState
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDecodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Combine(nSWindowDelegate.didDecodeRestorableState, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didDecodeRestorableState = (EventHandler<NSWindowCoderEventArgs>)System.Delegate.Remove(nSWindowDelegate.didDecodeRestorableState, value);
		}
	}

	public event EventHandler WillEnterVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willEnterVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willEnterVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willEnterVersionBrowser, value);
		}
	}

	public event EventHandler DidEnterVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didEnterVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didEnterVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didEnterVersionBrowser, value);
		}
	}

	public event EventHandler WillExitVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.willExitVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.willExitVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.willExitVersionBrowser, value);
		}
	}

	public event EventHandler DidExitVersionBrowser
	{
		add
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitVersionBrowser = (EventHandler)System.Delegate.Combine(nSWindowDelegate.didExitVersionBrowser, value);
		}
		remove
		{
			_NSWindowDelegate nSWindowDelegate = EnsureNSWindowDelegate();
			nSWindowDelegate.didExitVersionBrowser = (EventHandler)System.Delegate.Remove(nSWindowDelegate.didExitVersionBrowser, value);
		}
	}

	private NSWindow(IntPtr windowRef, NSObjectFlag x)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, selInitWithWindowRef);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitWithWindowRef);
		}
	}

	public static NSWindow FromWindowRef(IntPtr windowRef)
	{
		return new NSWindow(windowRef, NSObjectFlag.Empty);
	}

	public void Close()
	{
		if (WindowController == null)
		{
			bool releasedWhenClosed = ReleasedWhenClosed;
			if (releasedWhenClosed)
			{
				CFObject.CFRetain(base.Handle);
			}
			_Close();
			if (releasedWhenClosed)
			{
				Dispose();
			}
		}
		else
		{
			_Close();
		}
	}

	public NSEvent NextEventMatchingMask(NSEventMask mask)
	{
		return NextEventMatchingMask((uint)mask);
	}

	public NSEvent NextEventMatchingMask(NSEventMask mask, NSDate expiration, string mode, bool deqFlag)
	{
		return NextEventMatchingMask((uint)mask, expiration, mode, deqFlag);
	}

	public void DiscardEventsMatchingMask(NSEventMask mask, NSEvent beforeLastEvent)
	{
		DiscardEventsMatchingMask((uint)mask, beforeLastEvent);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWindow()
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
	public NSWindow(NSCoder coder)
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
	public NSWindow(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSWindow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("frameRectForContentRect:styleMask:")]
	public static CGRect FrameRectFor(CGRect contectRect, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out var retval, class_ptr, selFrameRectForContentRectStyleMask_Handle, contectRect, (ulong)styleMask);
		return retval;
	}

	[Export("contentRectForFrameRect:styleMask:")]
	public static CGRect ContentRectFor(CGRect forFrameRect, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out var retval, class_ptr, selContentRectForFrameRectStyleMask_Handle, forFrameRect, (ulong)styleMask);
		return retval;
	}

	[Export("minFrameWidthWithTitle:styleMask:")]
	public static double MinFrameWidthWithTitle(string aTitle, NSWindowStyle aStyle)
	{
		NSApplication.EnsureUIThread();
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		double result = Messaging.Double_objc_msgSend_IntPtr_UInt64(class_ptr, selMinFrameWidthWithTitleStyleMask_Handle, arg, (ulong)aStyle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("frameRectForContentRect:")]
	public virtual CGRect FrameRectFor(CGRect contentRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selFrameRectForContentRect_Handle, contentRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selFrameRectForContentRect_Handle, contentRect);
		}
		return retval;
	}

	[Export("contentRectForFrameRect:")]
	public virtual CGRect ContentRectFor(CGRect frameRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selContentRectForFrameRect_Handle, frameRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selContentRectForFrameRect_Handle, frameRect);
		}
		return retval;
	}

	[Export("initWithContentRect:styleMask:backing:defer:")]
	public NSWindow(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool(base.Handle, selInitWithContentRectStyleMaskBackingDefer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool(base.SuperHandle, selInitWithContentRectStyleMaskBackingDefer_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation);
		}
	}

	[Export("initWithContentRect:styleMask:backing:defer:screen:")]
	public NSWindow(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation, NSScreen screen)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool_IntPtr(base.Handle, selInitWithContentRectStyleMaskBackingDeferScreen_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation, screen.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool_IntPtr(base.SuperHandle, selInitWithContentRectStyleMaskBackingDeferScreen_Handle, contentRect, (ulong)aStyle, (ulong)bufferingType, deferCreation, screen.Handle);
		}
	}

	[Export("setTitleWithRepresentedFilename:")]
	public virtual void SetTitleWithRepresentedFilename(string filename)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithRepresentedFilename_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithRepresentedFilename_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setExcludedFromWindowsMenu:")]
	public virtual void SetExcludedFromWindowsMenu(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetExcludedFromWindowsMenu_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExcludedFromWindowsMenu_Handle, flag);
		}
	}

	[Export("fieldEditor:forObject:")]
	public virtual NSText FieldEditor(bool createFlag, NSObject forObject)
	{
		NSApplication.EnsureUIThread();
		if (forObject == null)
		{
			throw new ArgumentNullException("forObject");
		}
		if (IsDirectBinding)
		{
			return (NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool_IntPtr(base.Handle, selFieldEditorForObject_Handle, createFlag, forObject.Handle));
		}
		return (NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selFieldEditorForObject_Handle, createFlag, forObject.Handle));
	}

	[Export("endEditingFor:")]
	public virtual void EndEditingFor(NSObject anObject)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndEditingFor_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndEditingFor_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("constrainFrameRect:toScreen:")]
	public virtual CGRect ConstrainFrameRect(CGRect frameRect, NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConstrainFrameRectToScreen_Handle, frameRect, screen?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConstrainFrameRectToScreen_Handle, frameRect, screen?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("setFrame:display:")]
	public virtual void SetFrame(CGRect frameRect, bool display)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selSetFrameDisplay_Handle, frameRect, display);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selSetFrameDisplay_Handle, frameRect, display);
		}
	}

	[Export("setContentSize:")]
	public virtual void SetContentSize(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentSize_Handle, aSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentSize_Handle, aSize);
		}
	}

	[Export("setFrameOrigin:")]
	public virtual void SetFrameOrigin(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameOrigin_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameOrigin_Handle, aPoint);
		}
	}

	[Export("setFrameTopLeftPoint:")]
	public virtual void SetFrameTopLeftPoint(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameTopLeftPoint_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameTopLeftPoint_Handle, aPoint);
		}
	}

	[Export("cascadeTopLeftFromPoint:")]
	public virtual CGPoint CascadeTopLeftFromPoint(CGPoint topLeftPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selCascadeTopLeftFromPoint_Handle, topLeftPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCascadeTopLeftFromPoint_Handle, topLeftPoint);
	}

	[Export("animationResizeTime:")]
	public virtual double AnimationResizeTime(CGRect newFrame)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_CGRect(base.Handle, selAnimationResizeTime_Handle, newFrame);
		}
		return Messaging.Double_objc_msgSendSuper_CGRect(base.SuperHandle, selAnimationResizeTime_Handle, newFrame);
	}

	[Export("setFrame:display:animate:")]
	public virtual void SetFrame(CGRect frameRect, bool display, bool animate)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool_bool(base.Handle, selSetFrameDisplayAnimate_Handle, frameRect, display, animate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool_bool(base.SuperHandle, selSetFrameDisplayAnimate_Handle, frameRect, display, animate);
		}
	}

	[Export("useOptimizedDrawing:")]
	public virtual void UseOptimizedDrawing(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selUseOptimizedDrawing_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selUseOptimizedDrawing_Handle, flag);
		}
	}

	[Export("disableFlushWindow")]
	public virtual void DisableFlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableFlushWindowHandle);
		}
	}

	[Export("enableFlushWindow")]
	public virtual void EnableFlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableFlushWindowHandle);
		}
	}

	[Export("flushWindow")]
	public virtual void FlushWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushWindowHandle);
		}
	}

	[Export("flushWindowIfNeeded")]
	public virtual void FlushWindowIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushWindowIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushWindowIfNeededHandle);
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

	[Export("update")]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}

	[Export("makeFirstResponder:")]
	public virtual bool MakeFirstResponder(NSResponder aResponder)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selMakeFirstResponder_Handle, aResponder?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeFirstResponder_Handle, aResponder?.Handle ?? IntPtr.Zero);
	}

	[Export("keyDown:")]
	public new virtual void KeyDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, theEvent.Handle);
		}
	}

	[Export("close")]
	internal virtual void _Close()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("miniaturize:")]
	public virtual void Miniaturize(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMiniaturize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMiniaturize_Handle, sender.Handle);
		}
	}

	[Export("deminiaturize:")]
	public virtual void Deminiaturize(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeminiaturize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeminiaturize_Handle, sender.Handle);
		}
	}

	[Export("zoom:")]
	public virtual void Zoom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selZoom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selZoom_Handle, sender.Handle);
		}
	}

	[Export("tryToPerform:with:")]
	public virtual bool TryToPerform(Selector anAction, NSObject anObject)
	{
		NSApplication.EnsureUIThread();
		if (anAction == null)
		{
			throw new ArgumentNullException("anAction");
		}
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTryToPerformWith_Handle, anAction.Handle, anObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTryToPerformWith_Handle, anAction.Handle, anObject.Handle);
	}

	[Export("validRequestorForSendType:returnType:")]
	public virtual NSObject ValidRequestorForSendType(string sendType, string returnType)
	{
		NSApplication.EnsureUIThread();
		if (sendType == null)
		{
			throw new ArgumentNullException("sendType");
		}
		if (returnType == null)
		{
			throw new ArgumentNullException("returnType");
		}
		IntPtr arg = NSString.CreateNative(sendType);
		IntPtr arg2 = NSString.CreateNative(returnType);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setContentBorderThickness:forEdge:")]
	public virtual void SetContentBorderThickness(double thickness, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_int(base.Handle, selSetContentBorderThicknessForEdge_Handle, thickness, (int)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_int(base.SuperHandle, selSetContentBorderThicknessForEdge_Handle, thickness, (int)edge);
		}
	}

	[Export("contentBorderThicknessForEdge:")]
	public virtual double ContentBorderThicknessForEdge(NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_int(base.Handle, selContentBorderThicknessForEdge_Handle, (int)edge);
		}
		return Messaging.Double_objc_msgSendSuper_int(base.SuperHandle, selContentBorderThicknessForEdge_Handle, (int)edge);
	}

	[Export("setAutorecalculatesContentBorderThickness:forEdge:")]
	public virtual void SetAutorecalculatesContentBorderThickness(bool flag, NSRectEdge forEdge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_int(base.Handle, selSetAutorecalculatesContentBorderThicknessForEdge_Handle, flag, (int)forEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_int(base.SuperHandle, selSetAutorecalculatesContentBorderThicknessForEdge_Handle, flag, (int)forEdge);
		}
	}

	[Export("autorecalculatesContentBorderThicknessForEdge:")]
	public virtual bool AutorecalculatesContentBorderThickness(NSRectEdge forEdgeedge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selAutorecalculatesContentBorderThicknessForEdge_Handle, (int)forEdgeedge);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selAutorecalculatesContentBorderThicknessForEdge_Handle, (int)forEdgeedge);
	}

	[Export("center")]
	public virtual void Center()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCenterHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCenterHandle);
		}
	}

	[Export("makeKeyAndOrderFront:")]
	public virtual void MakeKeyAndOrderFront(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMakeKeyAndOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMakeKeyAndOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderFront:")]
	public virtual void OrderFront(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFront_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderBack:")]
	public virtual void OrderBack(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderBack_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderBack_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderOut:")]
	public virtual void OrderOut(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderOut_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderOut_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("orderWindow:relativeTo:")]
	public virtual void OrderWindow(NSWindowOrderingMode place, long relativeTo)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selOrderWindowRelativeTo_Handle, (long)place, relativeTo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selOrderWindowRelativeTo_Handle, (long)place, relativeTo);
		}
	}

	[Export("orderFrontRegardless")]
	public virtual void OrderFrontRegardless()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selOrderFrontRegardlessHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selOrderFrontRegardlessHandle);
		}
	}

	[Export("makeKeyWindow")]
	public virtual void MakeKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeKeyWindowHandle);
		}
	}

	[Export("makeMainWindow")]
	public virtual void MakeMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeMainWindowHandle);
		}
	}

	[Export("becomeKeyWindow")]
	public virtual void BecomeKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBecomeKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBecomeKeyWindowHandle);
		}
	}

	[Export("resignKeyWindow")]
	public virtual void ResignKeyWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResignKeyWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResignKeyWindowHandle);
		}
	}

	[Export("becomeMainWindow")]
	public virtual void BecomeMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBecomeMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBecomeMainWindowHandle);
		}
	}

	[Export("resignMainWindow")]
	public virtual void ResignMainWindow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResignMainWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResignMainWindowHandle);
		}
	}

	[Export("worksWhenModal")]
	public virtual bool WorksWhenModal()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selWorksWhenModalHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWorksWhenModalHandle);
	}

	[Export("convertBaseToScreen:")]
	public virtual CGPoint ConvertBaseToScreen(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertBaseToScreen_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertBaseToScreen_Handle, aPoint);
	}

	[Export("convertScreenToBase:")]
	public virtual CGPoint ConvertScreenToBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertScreenToBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertScreenToBase_Handle, aPoint);
	}

	[Export("performClose:")]
	public virtual void PerformClose(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClose_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClose_Handle, sender.Handle);
		}
	}

	[Export("performMiniaturize:")]
	public virtual void PerformMiniaturize(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformMiniaturize_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformMiniaturize_Handle, sender.Handle);
		}
	}

	[Export("performZoom:")]
	public virtual void PerformZoom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformZoom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformZoom_Handle, sender.Handle);
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

	[Export("setOneShot:")]
	public virtual void SetOneShot(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetOneShot_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOneShot_Handle, flag);
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

	[Export("disableCursorRects")]
	public virtual void DisableCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableCursorRectsHandle);
		}
	}

	[Export("enableCursorRects")]
	public virtual void EnableCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableCursorRectsHandle);
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

	[Export("invalidateCursorRectsForView:")]
	public virtual void InvalidateCursorRectsForView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateCursorRectsForView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateCursorRectsForView_Handle, aView.Handle);
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

	[Export("invalidateShadow")]
	public virtual void InvalidateShadow()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateShadowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateShadowHandle);
		}
	}

	[Export("disableScreenUpdatesUntilFlush")]
	public virtual void DisableScreenUpdatesUntilFlush()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableScreenUpdatesUntilFlushHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableScreenUpdatesUntilFlushHandle);
		}
	}

	[Export("stringWithSavedFrame")]
	public virtual string StringWithSavedFrame()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringWithSavedFrameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringWithSavedFrameHandle));
	}

	[Export("setFrameFromString:")]
	public virtual void SetFrameFrom(string str)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameFromString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameFromString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("saveFrameUsingName:")]
	public virtual void SaveFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveFrameUsingName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveFrameUsingName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setFrameUsingName:force:")]
	public virtual bool SetFrameUsingName(string name, bool force)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetFrameUsingNameForce_Handle, arg, force) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selSetFrameUsingNameForce_Handle, arg, force));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setFrameUsingName:")]
	public virtual bool SetFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameUsingName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetFrameUsingName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("frameAutosaveName")]
	protected virtual string GetFrameAutosaveName()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameAutosaveNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameAutosaveNameHandle));
	}

	[Export("setFrameAutosaveName:")]
	protected virtual bool SetFrameAutosaveName(string frameName)
	{
		NSApplication.EnsureUIThread();
		if (frameName == null)
		{
			throw new ArgumentNullException("frameName");
		}
		IntPtr arg = NSString.CreateNative(frameName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameAutosaveName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetFrameAutosaveName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeFrameUsingName:")]
	public static void RemoveFrameUsingName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveFrameUsingName_Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("cacheImageInRect:")]
	public virtual void CacheImageInRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selCacheImageInRect_Handle, aRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selCacheImageInRect_Handle, aRect);
		}
	}

	[Export("restoreCachedImage")]
	public virtual void RestoreCachedImage()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRestoreCachedImageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRestoreCachedImageHandle);
		}
	}

	[Export("discardCachedImage")]
	public virtual void DiscardCachedImage()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardCachedImageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardCachedImageHandle);
		}
	}

	[Export("nextEventMatchingMask:")]
	protected virtual NSEvent NextEventMatchingMask(ulong mask)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selNextEventMatchingMask_Handle, mask));
		}
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selNextEventMatchingMask_Handle, mask));
	}

	[Export("nextEventMatchingMask:untilDate:inMode:dequeue:")]
	protected virtual NSEvent NextEventMatchingMask(ulong mask, NSDate expiration, string mode, bool deqFlag)
	{
		NSApplication.EnsureUIThread();
		if (expiration == null)
		{
			throw new ArgumentNullException("expiration");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
		NSEvent result = ((!IsDirectBinding) ? ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_bool(base.SuperHandle, selNextEventMatchingMaskUntilDateInModeDequeue_Handle, mask, expiration.Handle, arg, deqFlag))) : ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_bool(base.Handle, selNextEventMatchingMaskUntilDateInModeDequeue_Handle, mask, expiration.Handle, arg, deqFlag))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("discardEventsMatchingMask:beforeEvent:")]
	protected virtual void DiscardEventsMatchingMask(ulong mask, NSEvent beforeLastEvent)
	{
		NSApplication.EnsureUIThread();
		if (beforeLastEvent == null)
		{
			throw new ArgumentNullException("beforeLastEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selDiscardEventsMatchingMaskBeforeEvent_Handle, mask, beforeLastEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selDiscardEventsMatchingMaskBeforeEvent_Handle, mask, beforeLastEvent.Handle);
		}
	}

	[Export("postEvent:atStart:")]
	public virtual void PostEvent(NSEvent theEvent, bool atStart)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selPostEventAtStart_Handle, theEvent.Handle, atStart);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selPostEventAtStart_Handle, theEvent.Handle, atStart);
		}
	}

	[Export("currentEvent")]
	public virtual NSEvent CurrentEvent()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEventHandle));
		}
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEventHandle));
	}

	[Export("sendEvent:")]
	public virtual void SendEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSendEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendEvent_Handle, theEvent.Handle);
		}
	}

	[Export("menuChanged:")]
	public static void MenuChanged(NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selMenuChanged_Handle, menu.Handle);
	}

	[Export("standardWindowButton:forStyleMask:")]
	public static NSButton StandardWindowButton(NSWindowButton b, NSWindowStyle styleMask)
	{
		NSApplication.EnsureUIThread();
		return (NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_UInt64(class_ptr, selStandardWindowButtonForStyleMask_Handle, (ulong)b, (ulong)styleMask));
	}

	[Export("standardWindowButton:")]
	public virtual NSButton StandardWindowButton(NSWindowButton b)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selStandardWindowButton_Handle, (ulong)b));
		}
		return (NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selStandardWindowButton_Handle, (ulong)b));
	}

	[Export("addChildWindow:ordered:")]
	public virtual void AddChildWindow(NSWindow childWin, NSWindowOrderingMode place)
	{
		NSApplication.EnsureUIThread();
		if (childWin == null)
		{
			throw new ArgumentNullException("childWin");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddChildWindowOrdered_Handle, childWin.Handle, (long)place);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddChildWindowOrdered_Handle, childWin.Handle, (long)place);
		}
		_ = ChildWindows;
	}

	[Export("removeChildWindow:")]
	public virtual void RemoveChildWindow(NSWindow childWin)
	{
		NSApplication.EnsureUIThread();
		if (childWin == null)
		{
			throw new ArgumentNullException("childWin");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveChildWindow_Handle, childWin.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChildWindow_Handle, childWin.Handle);
		}
		_ = ChildWindows;
	}

	[Export("windowNumbersWithOptions:")]
	public static NSArray WindowNumbersWithOptions(NSWindowNumberListOptions options)
	{
		NSApplication.EnsureUIThread();
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selWindowNumbersWithOptions_Handle, (ulong)options));
	}

	[Export("windowNumberAtPoint:belowWindowWithWindowNumber:")]
	public static long WindowNumberAtPoint(CGPoint point, long windowNumber)
	{
		NSApplication.EnsureUIThread();
		return Messaging.Int64_objc_msgSend_CGPoint_Int64(class_ptr, selWindowNumberAtPointBelowWindowWithWindowNumber_Handle, point, windowNumber);
	}

	[Export("selectNextKeyView:")]
	public virtual void SelectNextKeyView(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNextKeyView_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNextKeyView_Handle, sender.Handle);
		}
	}

	[Export("selectPreviousKeyView:")]
	public virtual void SelectPreviousKeyView(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPreviousKeyView_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPreviousKeyView_Handle, sender.Handle);
		}
	}

	[Export("selectKeyViewFollowingView:")]
	public virtual void SelectKeyViewFollowingView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectKeyViewFollowingView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectKeyViewFollowingView_Handle, aView.Handle);
		}
	}

	[Export("selectKeyViewPrecedingView:")]
	public virtual void SelectKeyViewPrecedingView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectKeyViewPrecedingView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectKeyViewPrecedingView_Handle, aView.Handle);
		}
	}

	[Export("keyViewSelectionDirection")]
	public virtual NSSelectionDirection KeyViewSelectionDirection()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSSelectionDirection)Messaging.UInt64_objc_msgSend(base.Handle, selKeyViewSelectionDirectionHandle);
		}
		return (NSSelectionDirection)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyViewSelectionDirectionHandle);
	}

	[Export("disableKeyEquivalentForDefaultButtonCell")]
	public virtual void DisableKeyEquivalentForDefaultButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableKeyEquivalentForDefaultButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableKeyEquivalentForDefaultButtonCellHandle);
		}
	}

	[Export("enableKeyEquivalentForDefaultButtonCell")]
	public virtual void EnableKeyEquivalentForDefaultButtonCell()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableKeyEquivalentForDefaultButtonCellHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableKeyEquivalentForDefaultButtonCellHandle);
		}
	}

	[Export("recalculateKeyViewLoop")]
	public virtual void RecalculateKeyViewLoop()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRecalculateKeyViewLoopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRecalculateKeyViewLoopHandle);
		}
	}

	[Export("toggleToolbarShown:")]
	public virtual void ToggleToolbarShown(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleToolbarShown_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleToolbarShown_Handle, sender.Handle);
		}
	}

	[Export("runToolbarCustomizationPalette:")]
	public virtual void RunToolbarCustomizationPalette(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunToolbarCustomizationPalette_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunToolbarCustomizationPalette_Handle, sender.Handle);
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

	[Export("disableSnapshotRestoration")]
	public virtual void DisableSnapshotRestoration()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableSnapshotRestorationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableSnapshotRestorationHandle);
		}
	}

	[Export("enableSnapshotRestoration")]
	public virtual void EnableSnapshotRestoration()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableSnapshotRestorationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableSnapshotRestorationHandle);
		}
	}

	[Export("updateConstraintsIfNeeded")]
	public virtual void UpdateConstraintsIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsIfNeededHandle);
		}
	}

	[Export("layoutIfNeeded")]
	public virtual void LayoutIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutIfNeededHandle);
		}
	}

	[Export("setAnchorAttribute:forOrientation:")]
	public virtual void SetAnchorAttribute(NSLayoutAttribute layoutAttribute, NSLayoutConstraintOrientation forOrientation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSetAnchorAttributeForOrientation_Handle, (long)layoutAttribute, (long)forOrientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSetAnchorAttributeForOrientation_Handle, (long)layoutAttribute, (long)forOrientation);
		}
	}

	[Export("visualizeConstraints:")]
	public virtual void VisualizeConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selVisualizeConstraints_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selVisualizeConstraints_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("convertRectToScreen:")]
	public virtual CGRect ConvertRectToScreen(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToScreen_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToScreen_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromScreen:")]
	public virtual CGRect ConvertRectFromScreen(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromScreen_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromScreen_Handle, aRect);
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

	[Export("toggleFullScreen:")]
	public virtual void ToggleFullScreen(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleFullScreen_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleFullScreen_Handle, sender?.Handle ?? IntPtr.Zero);
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

	private _NSWindowDelegate EnsureNSWindowDelegate()
	{
		NSWindowDelegate nSWindowDelegate = Delegate;
		if (nSWindowDelegate == null || !(nSWindowDelegate is _NSWindowDelegate))
		{
			nSWindowDelegate = (Delegate = new _NSWindowDelegate());
		}
		return (_NSWindowDelegate)nSWindowDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RepresentedUrl_var = null;
			__mt_ContentView_var = null;
			__mt_WeakDelegate_var = null;
			__mt_FirstResponder_var = null;
			__mt_BackgroundColor_var = null;
			__mt_MiniWindowImage_var = null;
			__mt_DockTile_var = null;
			__mt_Screen_var = null;
			__mt_DeepestScreen_var = null;
			__mt_DeviceDescription_var = null;
			__mt_WindowController_var = null;
			__mt_AttachedSheet_var = null;
			__mt_ChildWindows_var = null;
			__mt_ParentWindow_var = null;
			__mt_GraphicsContext_var = null;
			__mt_ColorSpace_var = null;
			__mt_InitialFirstResponder_var = null;
			__mt_DefaultButtonCell_var = null;
			__mt_Toolbar_var = null;
			__mt_EffectiveAppearance_var = null;
			__mt_Appearance_var = null;
			__mt_Animator_var = null;
			__mt_Animations_var = null;
		}
	}
}

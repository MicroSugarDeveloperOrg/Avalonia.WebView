using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSViewController", true)]
public class NSViewController : NSResponder, INSCoding, INativeObject, IDisposable, INSEditor, INSExtensionRequestHandling, INSSeguePerforming, INSTouchBarProvider, INSUserInterfaceItemIdentification
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstResponder = "acceptsFirstResponder";

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChildViewController_ = "addChildViewController:";

	private static readonly IntPtr selAddChildViewController_Handle = Selector.GetHandle("addChildViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomeFirstResponder = "becomeFirstResponder";

	private static readonly IntPtr selBecomeFirstResponderHandle = Selector.GetHandle("becomeFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginGestureWithEvent_ = "beginGestureWithEvent:";

	private static readonly IntPtr selBeginGestureWithEvent_Handle = Selector.GetHandle("beginGestureWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginRequestWithExtensionContext_ = "beginRequestWithExtensionContext:";

	private static readonly IntPtr selBeginRequestWithExtensionContext_Handle = Selector.GetHandle("beginRequestWithExtensionContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeModeWithEvent_ = "changeModeWithEvent:";

	private static readonly IntPtr selChangeModeWithEvent_Handle = Selector.GetHandle("changeModeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildViewControllers = "childViewControllers";

	private static readonly IntPtr selChildViewControllersHandle = Selector.GetHandle("childViewControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditing = "commitEditing";

	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingAndReturnError_ = "commitEditingAndReturnError:";

	private static readonly IntPtr selCommitEditingAndReturnError_Handle = Selector.GetHandle("commitEditingAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_ = "commitEditingWithDelegate:didCommitSelector:contextInfo:";

	private static readonly IntPtr selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCursorUpdate_ = "cursorUpdate:";

	private static readonly IntPtr selCursorUpdate_Handle = Selector.GetHandle("cursorUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardEditing = "discardEditing";

	private static readonly IntPtr selDiscardEditingHandle = Selector.GetHandle("discardEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissController_ = "dismissController:";

	private static readonly IntPtr selDismissController_Handle = Selector.GetHandle("dismissController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissViewController_ = "dismissViewController:";

	private static readonly IntPtr selDismissViewController_Handle = Selector.GetHandle("dismissViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_ = "encodeRestorableStateWithCoder:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_BackgroundQueue_ = "encodeRestorableStateWithCoder:backgroundQueue:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_BackgroundQueue_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:backgroundQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndGestureWithEvent_ = "endGestureWithEvent:";

	private static readonly IntPtr selEndGestureWithEvent_Handle = Selector.GetHandle("endGestureWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtensionContext = "extensionContext";

	private static readonly IntPtr selExtensionContextHandle = Selector.GetHandle("extensionContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlagsChanged_ = "flagsChanged:";

	private static readonly IntPtr selFlagsChanged_Handle = Selector.GetHandle("flagsChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushBufferedKeyEvents = "flushBufferedKeyEvents";

	private static readonly IntPtr selFlushBufferedKeyEventsHandle = Selector.GetHandle("flushBufferedKeyEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHelpRequested_ = "helpRequested:";

	private static readonly IntPtr selHelpRequested_Handle = Selector.GetHandle("helpRequested:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertChildViewController_AtIndex_ = "insertChildViewController:atIndex:";

	private static readonly IntPtr selInsertChildViewController_AtIndex_Handle = Selector.GetHandle("insertChildViewController:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpretKeyEvents_ = "interpretKeyEvents:";

	private static readonly IntPtr selInterpretKeyEvents_Handle = Selector.GetHandle("interpretKeyEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateRestorableState = "invalidateRestorableState";

	private static readonly IntPtr selInvalidateRestorableStateHandle = Selector.GetHandle("invalidateRestorableState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsViewLoaded = "isViewLoaded";

	private static readonly IntPtr selIsViewLoadedHandle = Selector.GetHandle("isViewLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyDown_ = "keyDown:";

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyUp_ = "keyUp:";

	private static readonly IntPtr selKeyUp_Handle = Selector.GetHandle("keyUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadView = "loadView";

	private static readonly IntPtr selLoadViewHandle = Selector.GetHandle("loadView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnifyWithEvent_ = "magnifyWithEvent:";

	private static readonly IntPtr selMagnifyWithEvent_Handle = Selector.GetHandle("magnifyWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDown_ = "mouseDown:";

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDragged_ = "mouseDragged:";

	private static readonly IntPtr selMouseDragged_Handle = Selector.GetHandle("mouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseEntered_ = "mouseEntered:";

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseExited_ = "mouseExited:";

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseMoved_ = "mouseMoved:";

	private static readonly IntPtr selMouseMoved_Handle = Selector.GetHandle("mouseMoved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseUp_ = "mouseUp:";

	private static readonly IntPtr selMouseUp_Handle = Selector.GetHandle("mouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewWindowForTab_ = "newWindowForTab:";

	private static readonly IntPtr selNewWindowForTab_Handle = Selector.GetHandle("newWindowForTab:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextResponder = "nextResponder";

	private static readonly IntPtr selNextResponderHandle = Selector.GetHandle("nextResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNibBundle = "nibBundle";

	private static readonly IntPtr selNibBundleHandle = Selector.GetHandle("nibBundle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNibName = "nibName";

	private static readonly IntPtr selNibNameHandle = Selector.GetHandle("nibName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoResponderFor_ = "noResponderFor:";

	private static readonly IntPtr selNoResponderFor_Handle = Selector.GetHandle("noResponderFor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseDown_ = "otherMouseDown:";

	private static readonly IntPtr selOtherMouseDown_Handle = Selector.GetHandle("otherMouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseDragged_ = "otherMouseDragged:";

	private static readonly IntPtr selOtherMouseDragged_Handle = Selector.GetHandle("otherMouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseUp_ = "otherMouseUp:";

	private static readonly IntPtr selOtherMouseUp_Handle = Selector.GetHandle("otherMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentViewController = "parentViewController";

	private static readonly IntPtr selParentViewControllerHandle = Selector.GetHandle("parentViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSegueWithIdentifier_Sender_ = "performSegueWithIdentifier:sender:";

	private static readonly IntPtr selPerformSegueWithIdentifier_Sender_Handle = Selector.GetHandle("performSegueWithIdentifier:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredContentSize = "preferredContentSize";

	private static readonly IntPtr selPreferredContentSizeHandle = Selector.GetHandle("preferredContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredContentSizeDidChangeForViewController_ = "preferredContentSizeDidChangeForViewController:";

	private static readonly IntPtr selPreferredContentSizeDidChangeForViewController_Handle = Selector.GetHandle("preferredContentSizeDidChangeForViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMaximumSize = "preferredMaximumSize";

	private static readonly IntPtr selPreferredMaximumSizeHandle = Selector.GetHandle("preferredMaximumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMinimumSize = "preferredMinimumSize";

	private static readonly IntPtr selPreferredMinimumSizeHandle = Selector.GetHandle("preferredMinimumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredScreenOrigin = "preferredScreenOrigin";

	private static readonly IntPtr selPreferredScreenOriginHandle = Selector.GetHandle("preferredScreenOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForSegue_Sender_ = "prepareForSegue:sender:";

	private static readonly IntPtr selPrepareForSegue_Sender_Handle = Selector.GetHandle("prepareForSegue:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ = "presentError:";

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_ = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";

	private static readonly IntPtr selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewController_Animator_ = "presentViewController:animator:";

	private static readonly IntPtr selPresentViewController_Animator_Handle = Selector.GetHandle("presentViewController:animator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewController_AsPopoverRelativeToRect_OfView_PreferredEdge_Behavior_ = "presentViewController:asPopoverRelativeToRect:ofView:preferredEdge:behavior:";

	private static readonly IntPtr selPresentViewController_AsPopoverRelativeToRect_OfView_PreferredEdge_Behavior_Handle = Selector.GetHandle("presentViewController:asPopoverRelativeToRect:ofView:preferredEdge:behavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewControllerAsModalWindow_ = "presentViewControllerAsModalWindow:";

	private static readonly IntPtr selPresentViewControllerAsModalWindow_Handle = Selector.GetHandle("presentViewControllerAsModalWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewControllerAsSheet_ = "presentViewControllerAsSheet:";

	private static readonly IntPtr selPresentViewControllerAsSheet_Handle = Selector.GetHandle("presentViewControllerAsSheet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentViewControllerInWidget_ = "presentViewControllerInWidget:";

	private static readonly IntPtr selPresentViewControllerInWidget_Handle = Selector.GetHandle("presentViewControllerInWidget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedViewControllers = "presentedViewControllers";

	private static readonly IntPtr selPresentedViewControllersHandle = Selector.GetHandle("presentedViewControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentingViewController = "presentingViewController";

	private static readonly IntPtr selPresentingViewControllerHandle = Selector.GetHandle("presentingViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressureChangeWithEvent_ = "pressureChangeWithEvent:";

	private static readonly IntPtr selPressureChangeWithEvent_Handle = Selector.GetHandle("pressureChangeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickLookWithEvent_ = "quickLookWithEvent:";

	private static readonly IntPtr selQuickLookWithEvent_Handle = Selector.GetHandle("quickLookWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChildViewControllerAtIndex_ = "removeChildViewControllerAtIndex:";

	private static readonly IntPtr selRemoveChildViewControllerAtIndex_Handle = Selector.GetHandle("removeChildViewControllerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromParentViewController = "removeFromParentViewController";

	private static readonly IntPtr selRemoveFromParentViewControllerHandle = Selector.GetHandle("removeFromParentViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedObject = "representedObject";

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResignFirstResponder = "resignFirstResponder";

	private static readonly IntPtr selResignFirstResponderHandle = Selector.GetHandle("resignFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestorableStateKeyPaths = "restorableStateKeyPaths";

	private static readonly IntPtr selRestorableStateKeyPathsHandle = Selector.GetHandle("restorableStateKeyPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreStateWithCoder_ = "restoreStateWithCoder:";

	private static readonly IntPtr selRestoreStateWithCoder_Handle = Selector.GetHandle("restoreStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreUserActivityState_ = "restoreUserActivityState:";

	private static readonly IntPtr selRestoreUserActivityState_Handle = Selector.GetHandle("restoreUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseDown_ = "rightMouseDown:";

	private static readonly IntPtr selRightMouseDown_Handle = Selector.GetHandle("rightMouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseDragged_ = "rightMouseDragged:";

	private static readonly IntPtr selRightMouseDragged_Handle = Selector.GetHandle("rightMouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseUp_ = "rightMouseUp:";

	private static readonly IntPtr selRightMouseUp_Handle = Selector.GetHandle("rightMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateWithEvent_ = "rotateWithEvent:";

	private static readonly IntPtr selRotateWithEvent_Handle = Selector.GetHandle("rotateWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollWheel_ = "scrollWheel:";

	private static readonly IntPtr selScrollWheel_Handle = Selector.GetHandle("scrollWheel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChildViewControllers_ = "setChildViewControllers:";

	private static readonly IntPtr selSetChildViewControllers_Handle = Selector.GetHandle("setChildViewControllers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNextResponder_ = "setNextResponder:";

	private static readonly IntPtr selSetNextResponder_Handle = Selector.GetHandle("setNextResponder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredContentSize_ = "setPreferredContentSize:";

	private static readonly IntPtr selSetPreferredContentSize_Handle = Selector.GetHandle("setPreferredContentSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredScreenOrigin_ = "setPreferredScreenOrigin:";

	private static readonly IntPtr selSetPreferredScreenOrigin_Handle = Selector.GetHandle("setPreferredScreenOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepresentedObject_ = "setRepresentedObject:";

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceItemView_ = "setSourceItemView:";

	private static readonly IntPtr selSetSourceItemView_Handle = Selector.GetHandle("setSourceItemView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserActivity_ = "setUserActivity:";

	private static readonly IntPtr selSetUserActivity_Handle = Selector.GetHandle("setUserActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetView_ = "setView:";

	private static readonly IntPtr selSetView_Handle = Selector.GetHandle("setView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBeTreatedAsInkEvent_ = "shouldBeTreatedAsInkEvent:";

	private static readonly IntPtr selShouldBeTreatedAsInkEvent_Handle = Selector.GetHandle("shouldBeTreatedAsInkEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldPerformSegueWithIdentifier_Sender_ = "shouldPerformSegueWithIdentifier:sender:";

	private static readonly IntPtr selShouldPerformSegueWithIdentifier_Sender_Handle = Selector.GetHandle("shouldPerformSegueWithIdentifier:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowContextHelp_ = "showContextHelp:";

	private static readonly IntPtr selShowContextHelp_Handle = Selector.GetHandle("showContextHelp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartMagnifyWithEvent_ = "smartMagnifyWithEvent:";

	private static readonly IntPtr selSmartMagnifyWithEvent_Handle = Selector.GetHandle("smartMagnifyWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceItemView = "sourceItemView";

	private static readonly IntPtr selSourceItemViewHandle = Selector.GetHandle("sourceItemView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoryboard = "storyboard";

	private static readonly IntPtr selStoryboardHandle = Selector.GetHandle("storyboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementalTargetForAction_Sender_ = "supplementalTargetForAction:sender:";

	private static readonly IntPtr selSupplementalTargetForAction_Sender_Handle = Selector.GetHandle("supplementalTargetForAction:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSwipeWithEvent_ = "swipeWithEvent:";

	private static readonly IntPtr selSwipeWithEvent_Handle = Selector.GetHandle("swipeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabletPoint_ = "tabletPoint:";

	private static readonly IntPtr selTabletPoint_Handle = Selector.GetHandle("tabletPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabletProximity_ = "tabletProximity:";

	private static readonly IntPtr selTabletProximity_Handle = Selector.GetHandle("tabletProximity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchBar = "touchBar";

	private static readonly IntPtr selTouchBarHandle = Selector.GetHandle("touchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesBeganWithEvent_ = "touchesBeganWithEvent:";

	private static readonly IntPtr selTouchesBeganWithEvent_Handle = Selector.GetHandle("touchesBeganWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesCancelledWithEvent_ = "touchesCancelledWithEvent:";

	private static readonly IntPtr selTouchesCancelledWithEvent_Handle = Selector.GetHandle("touchesCancelledWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesEndedWithEvent_ = "touchesEndedWithEvent:";

	private static readonly IntPtr selTouchesEndedWithEvent_Handle = Selector.GetHandle("touchesEndedWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesMovedWithEvent_ = "touchesMovedWithEvent:";

	private static readonly IntPtr selTouchesMovedWithEvent_Handle = Selector.GetHandle("touchesMovedWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitionFromViewController_ToViewController_Options_CompletionHandler_ = "transitionFromViewController:toViewController:options:completionHandler:";

	private static readonly IntPtr selTransitionFromViewController_ToViewController_Options_CompletionHandler_Handle = Selector.GetHandle("transitionFromViewController:toViewController:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryToPerform_With_ = "tryToPerform:with:";

	private static readonly IntPtr selTryToPerform_With_Handle = Selector.GetHandle("tryToPerform:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateUserActivityState_ = "updateUserActivityState:";

	private static readonly IntPtr selUpdateUserActivityState_Handle = Selector.GetHandle("updateUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateViewConstraints = "updateViewConstraints";

	private static readonly IntPtr selUpdateViewConstraintsHandle = Selector.GetHandle("updateViewConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserActivity = "userActivity";

	private static readonly IntPtr selUserActivityHandle = Selector.GetHandle("userActivity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidRequestorForSendType_ReturnType_ = "validRequestorForSendType:returnType:";

	private static readonly IntPtr selValidRequestorForSendType_ReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateProposedFirstResponder_ForEvent_ = "validateProposedFirstResponder:forEvent:";

	private static readonly IntPtr selValidateProposedFirstResponder_ForEvent_Handle = Selector.GetHandle("validateProposedFirstResponder:forEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidAppear = "viewDidAppear";

	private static readonly IntPtr selViewDidAppearHandle = Selector.GetHandle("viewDidAppear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidDisappear = "viewDidDisappear";

	private static readonly IntPtr selViewDidDisappearHandle = Selector.GetHandle("viewDidDisappear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidLayout = "viewDidLayout";

	private static readonly IntPtr selViewDidLayoutHandle = Selector.GetHandle("viewDidLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidLoad = "viewDidLoad";

	private static readonly IntPtr selViewDidLoadHandle = Selector.GetHandle("viewDidLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillAppear = "viewWillAppear";

	private static readonly IntPtr selViewWillAppearHandle = Selector.GetHandle("viewWillAppear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillDisappear = "viewWillDisappear";

	private static readonly IntPtr selViewWillDisappearHandle = Selector.GetHandle("viewWillDisappear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillLayout = "viewWillLayout";

	private static readonly IntPtr selViewWillLayoutHandle = Selector.GetHandle("viewWillLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillTransitionToSize_ = "viewWillTransitionToSize:";

	private static readonly IntPtr selViewWillTransitionToSize_Handle = Selector.GetHandle("viewWillTransitionToSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsForwardedScrollEventsForAxis_ = "wantsForwardedScrollEventsForAxis:";

	private static readonly IntPtr selWantsForwardedScrollEventsForAxis_Handle = Selector.GetHandle("wantsForwardedScrollEventsForAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsScrollEventsForSwipeTrackingOnAxis_ = "wantsScrollEventsForSwipeTrackingOnAxis:";

	private static readonly IntPtr selWantsScrollEventsForSwipeTrackingOnAxis_Handle = Selector.GetHandle("wantsScrollEventsForSwipeTrackingOnAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillPresentError_ = "willPresentError:";

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PresentedViewControllers_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PresentingViewController_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController[] ChildViewControllers
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("childViewControllers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildViewControllersHandle));
			}
			return NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildViewControllersHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setChildViewControllers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChildViewControllers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChildViewControllers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSExtensionContext? ExtensionContext
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("extensionContext", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExtensionContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtensionContextHandle));
			}
			return Runtime.GetNSObject<NSExtensionContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtensionContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public new virtual NSMenu? Menu
	{
		[Export("menu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSResponder? NextResponder
	{
		[Export("nextResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextResponderHandle));
			}
			return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextResponderHandle));
		}
		[Export("setNextResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBundle NibBundle
	{
		[Export("nibBundle", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSend(base.Handle, selNibBundleHandle));
			}
			return Runtime.GetNSObject<NSBundle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNibBundleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NibName
	{
		[Export("nibName", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNibNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController ParentViewController
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("parentViewController")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentViewControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredContentSize
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredContentSizeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPreferredContentSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetPreferredContentSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetPreferredContentSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredMaximumSize
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredMaximumSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredMaximumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredMaximumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredMinimumSize
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredMinimumSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredMinimumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredMinimumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGPoint PreferredScreenOrigin
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredScreenOrigin", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPreferredScreenOriginHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPreferredScreenOriginHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPreferredScreenOrigin:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPreferredScreenOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPreferredScreenOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController[] PresentedViewControllers
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("presentedViewControllers", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSViewController[] array = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentedViewControllersHandle)) : NSArray.ArrayFromHandle<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentedViewControllersHandle)));
			MarkDirty();
			__mt_PresentedViewControllers_var = array;
			return array;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSViewController PresentingViewController
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("presentingViewController", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSViewController nSViewController = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentingViewControllerHandle)) : Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentingViewControllerHandle)));
			MarkDirty();
			__mt_PresentingViewController_var = nSViewController;
			return nSViewController;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RepresentedObject
	{
		[Export("representedObject", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle));
		}
		[Export("setRepresentedObject:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedObject_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSView? SourceItemView
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sourceItemView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceItemViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceItemViewHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSourceItemView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceItemView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceItemView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSStoryboard Storyboard
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("storyboard", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selStoryboardHandle));
			}
			return Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStoryboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public new virtual NSTouchBar? TouchBar
	{
		[Export("touchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selTouchBarHandle));
			}
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTouchBarHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSUserActivity UserActivity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("userActivity", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserActivityHandle));
			}
			return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserActivityHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUserActivity:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserActivity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserActivity_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView View
	{
		[Export("view", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
		[Export("setView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ViewLoaded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isViewLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsViewLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsViewLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSViewController()
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
	public NSViewController(NSCoder coder)
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
	protected NSViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("acceptsFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AcceptsFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAcceptsFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsFirstResponderHandle);
	}

	[Export("addChildViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChildViewController(NSViewController childViewController)
	{
		NSApplication.EnsureUIThread();
		if (childViewController == null)
		{
			throw new ArgumentNullException("childViewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChildViewController_Handle, childViewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChildViewController_Handle, childViewController.Handle);
		}
	}

	[Export("becomeFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool BecomeFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selBecomeFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBecomeFirstResponderHandle);
	}

	[Export("beginGestureWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void BeginGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("beginRequestWithExtensionContext:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
	}

	[Export("changeModeWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ChangeMode(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeModeWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeModeWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("commitEditing")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool CommitEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCommitEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCommitEditingHandle);
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void CommitEditing(NSObject? delegateObject, Selector? didCommitSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
	}

	[Export("commitEditingAndReturnError:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CommitEditing(out NSError? error)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCommitEditingAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCommitEditingAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("cursorUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void CursorUpdate(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCursorUpdate_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCursorUpdate_Handle, theEvent.Handle);
		}
	}

	[Export("discardEditing")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardEditingHandle);
		}
	}

	[Export("dismissController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissController(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismissController_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismissController_Handle, sender.Handle);
		}
	}

	[Export("dismissViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissViewController(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismissViewController_Handle, viewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismissViewController_Handle, viewController.Handle);
		}
	}

	[Export("encodeRestorableStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeRestorableState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("encodeRestorableStateWithCoder:backgroundQueue:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeRestorableState(NSCoder coder, NSOperationQueue queue)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("endGestureWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EndGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("flagsChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void FlagsChanged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlagsChanged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlagsChanged_Handle, theEvent.Handle);
		}
	}

	[Export("flushBufferedKeyEvents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void FlushBufferedKeyEvents()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushBufferedKeyEventsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushBufferedKeyEventsHandle);
		}
	}

	[Export("newWindowForTab:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void GetNewWindowForTab(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNewWindowForTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewWindowForTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("helpRequested:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void HelpRequested(NSEvent theEventPtr)
	{
		NSApplication.EnsureUIThread();
		if (theEventPtr == null)
		{
			throw new ArgumentNullException("theEventPtr");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHelpRequested_Handle, theEventPtr.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHelpRequested_Handle, theEventPtr.Handle);
		}
	}

	[Export("insertChildViewController:atIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertChildViewController(NSViewController childViewController, nint index)
	{
		NSApplication.EnsureUIThread();
		if (childViewController == null)
		{
			throw new ArgumentNullException("childViewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertChildViewController_AtIndex_Handle, childViewController.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertChildViewController_AtIndex_Handle, childViewController.Handle, index);
		}
	}

	[Export("interpretKeyEvents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void InterpretKeyEvents(NSEvent[] eventArray)
	{
		NSApplication.EnsureUIThread();
		if (eventArray == null)
		{
			throw new ArgumentNullException("eventArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(eventArray);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("invalidateRestorableState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void InvalidateRestorableState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateRestorableStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateRestorableStateHandle);
		}
	}

	[Export("keyDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void KeyDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, theEvent.Handle);
		}
	}

	[Export("keyUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void KeyUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyUp_Handle, theEvent.Handle);
		}
	}

	[Export("loadView")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadView()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadViewHandle);
		}
	}

	[Export("magnifyWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MagnifyWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("mouseEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	[Export("mouseMoved:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseMoved(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseMoved_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseMoved_Handle, theEvent.Handle);
		}
	}

	[Export("mouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("noResponderFor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void NoResponderFor(Selector eventSelector)
	{
		NSApplication.EnsureUIThread();
		if (eventSelector == null)
		{
			throw new ArgumentNullException("eventSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoResponderFor_Handle, eventSelector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoResponderFor_Handle, eventSelector.Handle);
		}
	}

	[Export("otherMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void OtherMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void OtherMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void OtherMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("performSegueWithIdentifier:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSegue(string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("preferredContentSizeDidChangeForViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PreferredContentSizeDidChange(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPreferredContentSizeDidChangeForViewController_Handle, viewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreferredContentSizeDidChangeForViewController_Handle, viewController.Handle);
		}
	}

	[Export("prepareForSegue:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (segue == null)
		{
			throw new ArgumentNullException("segue");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrepareForSegue_Sender_Handle, segue.Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrepareForSegue_Sender_Handle, segue.Handle, sender.Handle);
		}
	}

	[Export("presentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPresentError_Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentError_Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new void PresentError(NSError error, NSWindow window, NSObject? @delegate, Selector? didPresentSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle, error.Handle, window.Handle, @delegate?.Handle ?? IntPtr.Zero, (didPresentSelector == null) ? IntPtr.Zero : didPresentSelector.Handle, contextInfo);
	}

	[Export("presentViewController:animator:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentViewController(NSViewController viewController, INSViewControllerPresentationAnimator animator)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (animator != null)
		{
			if (!(animator is NSObject))
			{
				throw new ArgumentException("The object passed of type " + animator.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentViewController_Animator_Handle, viewController.Handle, animator.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentViewController_Animator_Handle, viewController.Handle, animator.Handle);
			}
			return;
		}
		throw new ArgumentNullException("animator");
	}

	[Export("presentViewController:asPopoverRelativeToRect:ofView:preferredEdge:behavior:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentViewController(NSViewController viewController, CGRect positioningRect, NSView positioningView, nuint preferredEdge, NSPopoverBehavior behavior)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (positioningView == null)
		{
			throw new ArgumentNullException("positioningView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr_nuint_Int64(base.Handle, selPresentViewController_AsPopoverRelativeToRect_OfView_PreferredEdge_Behavior_Handle, viewController.Handle, positioningRect, positioningView.Handle, preferredEdge, (long)behavior);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr_nuint_Int64(base.SuperHandle, selPresentViewController_AsPopoverRelativeToRect_OfView_PreferredEdge_Behavior_Handle, viewController.Handle, positioningRect, positioningView.Handle, preferredEdge, (long)behavior);
		}
	}

	[Export("presentViewControllerAsModalWindow:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentViewControllerAsModalWindow(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentViewControllerAsModalWindow_Handle, viewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentViewControllerAsModalWindow_Handle, viewController.Handle);
		}
	}

	[Export("presentViewControllerAsSheet:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentViewControllerAsSheet(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentViewControllerAsSheet_Handle, viewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentViewControllerAsSheet_Handle, viewController.Handle);
		}
	}

	[Export("presentViewControllerInWidget:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentViewControllerInWidget(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentViewControllerInWidget_Handle, viewController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentViewControllerInWidget_Handle, viewController.Handle);
		}
	}

	[Export("pressureChangeWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void PressureChange(NSEvent pressureChangeEvent)
	{
		NSApplication.EnsureUIThread();
		if (pressureChangeEvent == null)
		{
			throw new ArgumentNullException("pressureChangeEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPressureChangeWithEvent_Handle, pressureChangeEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPressureChangeWithEvent_Handle, pressureChangeEvent.Handle);
		}
	}

	[Export("quickLookWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void QuickLook(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selQuickLookWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuickLookWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("removeChildViewControllerAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveChildViewController(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveChildViewControllerAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveChildViewControllerAtIndex_Handle, index);
		}
	}

	[Export("removeFromParentViewController")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFromParentViewController()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromParentViewControllerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromParentViewControllerHandle);
		}
	}

	[Export("resignFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool ResignFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResignFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResignFirstResponderHandle);
	}

	[Export("restorableStateKeyPaths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static string[] RestorableStateKeyPaths()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selRestorableStateKeyPathsHandle));
	}

	[Export("restoreStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RestoreState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("restoreUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RestoreUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
	}

	[Export("rightMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RightMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RightMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RightMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("rotateWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RotateWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("scrollWheel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ScrollWheel(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollWheel_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollWheel_Handle, theEvent.Handle);
		}
	}

	[Export("shouldBeTreatedAsInkEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool ShouldBeTreatedAsInkEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
	}

	[Export("shouldPerformSegueWithIdentifier:sender:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPerformSegue(string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldPerformSegueWithIdentifier_Sender_Handle, arg, sender.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("showContextHelp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ShowContextHelp(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowContextHelp_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowContextHelp_Handle, sender.Handle);
		}
	}

	[Export("smartMagnifyWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SmartMagnify(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSmartMagnifyWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSmartMagnifyWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("supplementalTargetForAction:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject SupplementalTargetForAction(Selector action, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSupplementalTargetForAction_Sender_Handle, action.Handle, sender?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSupplementalTargetForAction_Sender_Handle, action.Handle, sender?.Handle ?? IntPtr.Zero));
	}

	[Export("swipeWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SwipeWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("tabletPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TabletPoint(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletPoint_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletPoint_Handle, theEvent.Handle);
		}
	}

	[Export("tabletProximity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TabletProximity(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletProximity_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletProximity_Handle, theEvent.Handle);
		}
	}

	[Export("touchesBeganWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TouchesBeganWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesCancelledWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TouchesCancelledWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesEndedWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TouchesEndedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesMovedWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void TouchesMovedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("transitionFromViewController:toViewController:options:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void TransitionFromViewController(NSViewController fromViewController, NSViewController toViewController, NSViewControllerTransitionOptions options, [BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		NSApplication.EnsureUIThread();
		if (fromViewController == null)
		{
			throw new ArgumentNullException("fromViewController");
		}
		if (toViewController == null)
		{
			throw new ArgumentNullException("toViewController");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selTransitionFromViewController_ToViewController_Options_CompletionHandler_Handle, fromViewController.Handle, toViewController.Handle, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selTransitionFromViewController_ToViewController_Options_CompletionHandler_Handle, fromViewController.Handle, toViewController.Handle, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("tryToPerform:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool TryToPerformwith(Selector anAction, NSObject? anObject)
	{
		NSApplication.EnsureUIThread();
		if (anAction == null)
		{
			throw new ArgumentNullException("anAction");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTryToPerform_With_Handle, anAction.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTryToPerform_With_Handle, anAction.Handle, anObject?.Handle ?? IntPtr.Zero);
	}

	[Export("updateUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void UpdateUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
	}

	[Export("updateViewConstraints")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateViewConstraints()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateViewConstraintsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateViewConstraintsHandle);
		}
	}

	[Export("validRequestorForSendType:returnType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject ValidRequestorForSendType(string? sendType, string? returnType)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(sendType);
		IntPtr arg2 = NSString.CreateNative(returnType);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("validateProposedFirstResponder:forEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool ValidateProposedFirstResponder(NSResponder responder, NSEvent? forEvent)
	{
		NSApplication.EnsureUIThread();
		if (responder == null)
		{
			throw new ArgumentNullException("responder");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidateProposedFirstResponder_ForEvent_Handle, responder.Handle, forEvent?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidateProposedFirstResponder_ForEvent_Handle, responder.Handle, forEvent?.Handle ?? IntPtr.Zero);
	}

	[Export("viewDidAppear")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidAppear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidAppearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidAppearHandle);
		}
	}

	[Export("viewDidDisappear")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidDisappear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidDisappearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidDisappearHandle);
		}
	}

	[Export("viewDidLayout")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidLayoutHandle);
		}
	}

	[Export("viewDidLoad")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidLoad()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidLoadHandle);
		}
	}

	[Export("viewWillAppear")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillAppear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillAppearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillAppearHandle);
		}
	}

	[Export("viewWillDisappear")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillDisappear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillDisappearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillDisappearHandle);
		}
	}

	[Export("viewWillLayout")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillLayoutHandle);
		}
	}

	[Export("viewWillTransitionToSize:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillTransition(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selViewWillTransitionToSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selViewWillTransitionToSize_Handle, newSize);
		}
	}

	[Export("wantsForwardedScrollEventsForAxis:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool WantsForwardedScrollEventsForAxis(NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
	}

	[Export("wantsScrollEventsForSwipeTrackingOnAxis:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool WantsScrollEventsForSwipeTrackingOnAxis(NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selWantsScrollEventsForSwipeTrackingOnAxis_Handle, (long)axis);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selWantsScrollEventsForSwipeTrackingOnAxis_Handle, (long)axis);
	}

	[Export("willPresentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSError WillPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWillPresentError_Handle, error.Handle));
		}
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillPresentError_Handle, error.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PresentedViewControllers_var = null;
			__mt_PresentingViewController_var = null;
		}
	}
}

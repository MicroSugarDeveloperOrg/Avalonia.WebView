using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCell", true)]
public class NSCell : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveControlTintChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ControlTintChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selPrefersTrackingUntilMouseUpHandle = Selector.GetHandle("prefersTrackingUntilMouseUp");

	private static readonly IntPtr selControlViewHandle = Selector.GetHandle("controlView");

	private static readonly IntPtr selSetControlView_Handle = Selector.GetHandle("setControlView:");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selSetTag_Handle = Selector.GetHandle("setTag:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	private static readonly IntPtr selIsBorderedHandle = Selector.GetHandle("isBordered");

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	private static readonly IntPtr selIsBezeledHandle = Selector.GetHandle("isBezeled");

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	private static readonly IntPtr selIsScrollableHandle = Selector.GetHandle("isScrollable");

	private static readonly IntPtr selSetScrollable_Handle = Selector.GetHandle("setScrollable:");

	private static readonly IntPtr selIsHighlightedHandle = Selector.GetHandle("isHighlighted");

	private static readonly IntPtr selSetHighlighted_Handle = Selector.GetHandle("setHighlighted:");

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	private static readonly IntPtr selWrapsHandle = Selector.GetHandle("wraps");

	private static readonly IntPtr selSetWraps_Handle = Selector.GetHandle("setWraps:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selKeyEquivalentHandle = Selector.GetHandle("keyEquivalent");

	private static readonly IntPtr selFormatterHandle = Selector.GetHandle("formatter");

	private static readonly IntPtr selSetFormatter_Handle = Selector.GetHandle("setFormatter:");

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	private static readonly IntPtr selHasValidObjectValueHandle = Selector.GetHandle("hasValidObjectValue");

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	private static readonly IntPtr selSetStringValue_Handle = Selector.GetHandle("setStringValue:");

	private static readonly IntPtr selIntValueHandle = Selector.GetHandle("intValue");

	private static readonly IntPtr selSetIntValue_Handle = Selector.GetHandle("setIntValue:");

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	private static readonly IntPtr selSetDoubleValue_Handle = Selector.GetHandle("setDoubleValue:");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	private static readonly IntPtr selSetRepresentedObject_Handle = Selector.GetHandle("setRepresentedObject:");

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	private static readonly IntPtr selMouseDownFlagsHandle = Selector.GetHandle("mouseDownFlags");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selDefaultMenuHandle = Selector.GetHandle("defaultMenu");

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	private static readonly IntPtr selLineBreakModeHandle = Selector.GetHandle("lineBreakMode");

	private static readonly IntPtr selSetLineBreakMode_Handle = Selector.GetHandle("setLineBreakMode:");

	private static readonly IntPtr selAllowsUndoHandle = Selector.GetHandle("allowsUndo");

	private static readonly IntPtr selSetAllowsUndo_Handle = Selector.GetHandle("setAllowsUndo:");

	private static readonly IntPtr selIntegerValueHandle = Selector.GetHandle("integerValue");

	private static readonly IntPtr selSetIntegerValue_Handle = Selector.GetHandle("setIntegerValue:");

	private static readonly IntPtr selTruncatesLastVisibleLineHandle = Selector.GetHandle("truncatesLastVisibleLine");

	private static readonly IntPtr selSetTruncatesLastVisibleLine_Handle = Selector.GetHandle("setTruncatesLastVisibleLine:");

	private static readonly IntPtr selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");

	private static readonly IntPtr selSetUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setUserInterfaceLayoutDirection:");

	private static readonly IntPtr selUsesSingleLineModeHandle = Selector.GetHandle("usesSingleLineMode");

	private static readonly IntPtr selSetUsesSingleLineMode_Handle = Selector.GetHandle("setUsesSingleLineMode:");

	private static readonly IntPtr selShowsFirstResponderHandle = Selector.GetHandle("showsFirstResponder");

	private static readonly IntPtr selSetShowsFirstResponder_Handle = Selector.GetHandle("setShowsFirstResponder:");

	private static readonly IntPtr selMnemonicLocationHandle = Selector.GetHandle("mnemonicLocation");

	private static readonly IntPtr selSetMnemonicLocation_Handle = Selector.GetHandle("setMnemonicLocation:");

	private static readonly IntPtr selMnemonicHandle = Selector.GetHandle("mnemonic");

	private static readonly IntPtr selFocusRingTypeHandle = Selector.GetHandle("focusRingType");

	private static readonly IntPtr selSetFocusRingType_Handle = Selector.GetHandle("setFocusRingType:");

	private static readonly IntPtr selDefaultFocusRingTypeHandle = Selector.GetHandle("defaultFocusRingType");

	private static readonly IntPtr selWantsNotificationForMarkedTextHandle = Selector.GetHandle("wantsNotificationForMarkedText");

	private static readonly IntPtr selSetWantsNotificationForMarkedText_Handle = Selector.GetHandle("setWantsNotificationForMarkedText:");

	private static readonly IntPtr selAttributedStringValueHandle = Selector.GetHandle("attributedStringValue");

	private static readonly IntPtr selSetAttributedStringValue_Handle = Selector.GetHandle("setAttributedStringValue:");

	private static readonly IntPtr selAllowsEditingTextAttributesHandle = Selector.GetHandle("allowsEditingTextAttributes");

	private static readonly IntPtr selSetAllowsEditingTextAttributes_Handle = Selector.GetHandle("setAllowsEditingTextAttributes:");

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	private static readonly IntPtr selAllowsMixedStateHandle = Selector.GetHandle("allowsMixedState");

	private static readonly IntPtr selSetAllowsMixedState_Handle = Selector.GetHandle("setAllowsMixedState:");

	private static readonly IntPtr selNextStateHandle = Selector.GetHandle("nextState");

	private static readonly IntPtr selBackgroundStyleHandle = Selector.GetHandle("backgroundStyle");

	private static readonly IntPtr selSetBackgroundStyle_Handle = Selector.GetHandle("setBackgroundStyle:");

	private static readonly IntPtr selInteriorBackgroundStyleHandle = Selector.GetHandle("interiorBackgroundStyle");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selSendActionOn_Handle = Selector.GetHandle("sendActionOn:");

	private static readonly IntPtr selIsEntryAcceptable_Handle = Selector.GetHandle("isEntryAcceptable:");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr selTakeIntValueFrom_Handle = Selector.GetHandle("takeIntValueFrom:");

	private static readonly IntPtr selTakeFloatValueFrom_Handle = Selector.GetHandle("takeFloatValueFrom:");

	private static readonly IntPtr selTakeDoubleValueFrom_Handle = Selector.GetHandle("takeDoubleValueFrom:");

	private static readonly IntPtr selTakeStringValueFrom_Handle = Selector.GetHandle("takeStringValueFrom:");

	private static readonly IntPtr selTakeObjectValueFrom_Handle = Selector.GetHandle("takeObjectValueFrom:");

	private static readonly IntPtr selCellAttribute_Handle = Selector.GetHandle("cellAttribute:");

	private static readonly IntPtr selSetCellAttributeTo_Handle = Selector.GetHandle("setCellAttribute:to:");

	private static readonly IntPtr selImageRectForBounds_Handle = Selector.GetHandle("imageRectForBounds:");

	private static readonly IntPtr selTitleRectForBounds_Handle = Selector.GetHandle("titleRectForBounds:");

	private static readonly IntPtr selDrawingRectForBounds_Handle = Selector.GetHandle("drawingRectForBounds:");

	private static readonly IntPtr selCellSizeForBounds_Handle = Selector.GetHandle("cellSizeForBounds:");

	private static readonly IntPtr selHighlightColorWithFrameInView_Handle = Selector.GetHandle("highlightColorWithFrame:inView:");

	private static readonly IntPtr selCalcDrawInfo_Handle = Selector.GetHandle("calcDrawInfo:");

	private static readonly IntPtr selSetUpFieldEditorAttributes_Handle = Selector.GetHandle("setUpFieldEditorAttributes:");

	private static readonly IntPtr selDrawInteriorWithFrameInView_Handle = Selector.GetHandle("drawInteriorWithFrame:inView:");

	private static readonly IntPtr selDrawWithFrameInView_Handle = Selector.GetHandle("drawWithFrame:inView:");

	private static readonly IntPtr selHighlightWithFrameInView_Handle = Selector.GetHandle("highlight:withFrame:inView:");

	private static readonly IntPtr selGetPeriodicDelayInterval_Handle = Selector.GetHandle("getPeriodicDelay:interval:");

	private static readonly IntPtr selStartTrackingAtInView_Handle = Selector.GetHandle("startTrackingAt:inView:");

	private static readonly IntPtr selContinueTrackingAtInView_Handle = Selector.GetHandle("continueTracking:at:inView:");

	private static readonly IntPtr selStopTrackingAtInViewMouseIsUp_Handle = Selector.GetHandle("stopTracking:at:inView:mouseIsUp:");

	private static readonly IntPtr selTrackMouseInRectOfViewUntilMouseUp_Handle = Selector.GetHandle("trackMouse:inRect:ofView:untilMouseUp:");

	private static readonly IntPtr selEditWithFrameInViewEditorDelegateEvent_Handle = Selector.GetHandle("editWithFrame:inView:editor:delegate:event:");

	private static readonly IntPtr selSelectWithFrameInViewEditorDelegateStartLength_Handle = Selector.GetHandle("selectWithFrame:inView:editor:delegate:start:length:");

	private static readonly IntPtr selEndEditing_Handle = Selector.GetHandle("endEditing:");

	private static readonly IntPtr selResetCursorRectInView_Handle = Selector.GetHandle("resetCursorRect:inView:");

	private static readonly IntPtr selMenuForEventInRectOfView_Handle = Selector.GetHandle("menuForEvent:inRect:ofView:");

	private static readonly IntPtr selSetSendsActionOnEndEditing_Handle = Selector.GetHandle("setSendsActionOnEndEditing:");

	private static readonly IntPtr selSendsActionOnEndEditingHandle = Selector.GetHandle("sendsActionOnEndEditing");

	private static readonly IntPtr selTakeIntegerValueFrom_Handle = Selector.GetHandle("takeIntegerValueFrom:");

	private static readonly IntPtr selFieldEditorForView_Handle = Selector.GetHandle("fieldEditorForView:");

	private static readonly IntPtr selRefusesFirstResponderHandle = Selector.GetHandle("refusesFirstResponder");

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	private static readonly IntPtr selSetTitleWithMnemonic_Handle = Selector.GetHandle("setTitleWithMnemonic:");

	private static readonly IntPtr selPerformClick_Handle = Selector.GetHandle("performClick:");

	private static readonly IntPtr selSetNextStateHandle = Selector.GetHandle("setNextState");

	private static readonly IntPtr selHitTestForEventInRectOfView_Handle = Selector.GetHandle("hitTestForEvent:inRect:ofView:");

	private static readonly IntPtr selExpansionFrameWithFrameInView_Handle = Selector.GetHandle("expansionFrameWithFrame:inView:");

	private static readonly IntPtr selDrawWithExpansionFrameInView_Handle = Selector.GetHandle("drawWithExpansionFrame:inView:");

	private static readonly IntPtr selDraggingImageComponentsWithFrameInView_Handle = Selector.GetHandle("draggingImageComponentsWithFrame:inView:");

	private static readonly IntPtr selDrawFocusRingMaskWithFrameInView_Handle = Selector.GetHandle("drawFocusRingMaskWithFrame:inView:");

	private static readonly IntPtr selFocusRingMaskBoundsForFrameInView_Handle = Selector.GetHandle("focusRingMaskBoundsForFrame:inView:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCell");

	private object __mt_ControlView_var;

	private object __mt_Target_var;

	private object __mt_Font_var;

	private object __mt_Formatter_var;

	private object __mt_ObjectValue_var;

	private object __mt_Image_var;

	private object __mt_RepresentedObject_var;

	private object __mt_Menu_var;

	private static object __mt_DefaultMenu_var_static;

	private object __mt_AttributedStringValue_var;

	private static NSString _ControlTintChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public static bool PrefersTrackingUntilMouseUp
	{
		[Export("prefersTrackingUntilMouseUp")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selPrefersTrackingUntilMouseUpHandle);
		}
	}

	public virtual NSView ControlView
	{
		[Export("controlView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_ControlView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selControlViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selControlViewHandle)))));
		}
		[Export("setControlView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetControlView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetControlView_Handle, value.Handle);
			}
			__mt_ControlView_var = value;
		}
	}

	public virtual NSCellType CellType
	{
		[Export("type")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSCellType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (NSCellType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
		[Export("setType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSCellStateValue State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSCellStateValue)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSCellStateValue)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
		[Export("setState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetState_Handle, (long)value);
			}
		}
	}

	public virtual NSObject Target
	{
		[Export("target")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Target_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle))));
		}
		[Export("setTarget:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Target_var = value;
		}
	}

	public virtual Selector Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
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
		[Export("setTag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTag_Handle, value);
			}
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

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	public virtual bool IsContinuous
	{
		[Export("isContinuous")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousHandle);
		}
		[Export("setContinuous:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuous_Handle, value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	public virtual bool Bordered
	{
		[Export("isBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBorderedHandle);
		}
		[Export("setBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, value);
			}
		}
	}

	public virtual bool Bezeled
	{
		[Export("isBezeled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBezeledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBezeledHandle);
		}
		[Export("setBezeled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, value);
			}
		}
	}

	public virtual bool Scrollable
	{
		[Export("isScrollable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsScrollableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsScrollableHandle);
		}
		[Export("setScrollable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetScrollable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScrollable_Handle, value);
			}
		}
	}

	public virtual bool Highlighted
	{
		[Export("isHighlighted")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHighlightedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHighlightedHandle);
		}
		[Export("setHighlighted:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHighlighted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHighlighted_Handle, value);
			}
		}
	}

	public virtual NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
		[Export("setAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlignment_Handle, (ulong)value);
			}
		}
	}

	public virtual bool Wraps
	{
		[Export("wraps")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWrapsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWrapsHandle);
		}
		[Export("setWraps:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWraps_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWraps_Handle, value);
			}
		}
	}

	public virtual NSFont Font
	{
		[Export("font")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_Font_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle)))));
		}
		[Export("setFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
			__mt_Font_var = value;
		}
	}

	public virtual string KeyEquivalent
	{
		[Export("keyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentHandle));
		}
	}

	public virtual NSFormatter Formatter
	{
		[Export("formatter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFormatter)(__mt_Formatter_var = ((!IsDirectBinding) ? ((NSFormatter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatterHandle))) : ((NSFormatter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatterHandle)))));
		}
		[Export("setFormatter:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormatter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormatter_Handle, value.Handle);
			}
			__mt_Formatter_var = value;
		}
	}

	public virtual NSObject ObjectValue
	{
		[Export("objectValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ObjectValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle))));
		}
		[Export("setObjectValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_ObjectValue_var = value;
		}
	}

	public virtual bool HasValidObjectValue
	{
		[Export("hasValidObjectValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasValidObjectValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasValidObjectValueHandle);
		}
	}

	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
		[Export("setStringValue:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStringValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStringValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual int IntValue
	{
		[Export("intValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIntValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIntValueHandle);
		}
		[Export("setIntValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetIntValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetIntValue_Handle, value);
			}
		}
	}

	public virtual float FloatValue
	{
		[Export("floatValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFloatValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFloatValueHandle);
		}
		[Export("setFloatValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFloatValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFloatValue_Handle, value);
			}
		}
	}

	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
		[Export("setDoubleValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDoubleValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDoubleValue_Handle, value);
			}
		}
	}

	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Image_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
		[Export("setImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
			__mt_Image_var = value;
		}
	}

	public virtual NSControlTint ControlTint
	{
		[Export("controlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlTint)Messaging.UInt64_objc_msgSend(base.Handle, selControlTintHandle);
			}
			return (NSControlTint)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlTintHandle);
		}
		[Export("setControlTint:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlTint_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlTint_Handle, (ulong)value);
			}
		}
	}

	public virtual NSControlSize ControlSize
	{
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	public virtual NSObject RepresentedObject
	{
		[Export("representedObject")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_RepresentedObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle))));
		}
		[Export("setRepresentedObject:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRepresentedObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRepresentedObject_Handle, value.Handle);
			}
			__mt_RepresentedObject_var = value;
		}
	}

	public virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
	}

	public virtual long MouseDownFlags
	{
		[Export("mouseDownFlags")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMouseDownFlagsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMouseDownFlagsHandle);
		}
	}

	public virtual NSMenu Menu
	{
		[Export("menu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Menu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle)))));
		}
		[Export("setMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value.Handle);
			}
			__mt_Menu_var = value;
		}
	}

	public static NSMenu DefaultMenu
	{
		[Export("defaultMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_DefaultMenu_var_static = (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultMenuHandle)));
		}
	}

	public virtual NSWritingDirection BaseWritingDirection
	{
		[Export("baseWritingDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWritingDirection)Messaging.Int64_objc_msgSend(base.Handle, selBaseWritingDirectionHandle);
			}
			return (NSWritingDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBaseWritingDirectionHandle);
		}
		[Export("setBaseWritingDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBaseWritingDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBaseWritingDirection_Handle, (long)value);
			}
		}
	}

	public virtual NSLineBreakMode LineBreakMode
	{
		[Export("lineBreakMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLineBreakMode)Messaging.UInt64_objc_msgSend(base.Handle, selLineBreakModeHandle);
			}
			return (NSLineBreakMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineBreakModeHandle);
		}
		[Export("setLineBreakMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineBreakMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineBreakMode_Handle, (ulong)value);
			}
		}
	}

	public virtual bool AllowsUndo
	{
		[Export("allowsUndo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsUndoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsUndoHandle);
		}
		[Export("setAllowsUndo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsUndo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsUndo_Handle, value);
			}
		}
	}

	public virtual long IntegerValue
	{
		[Export("integerValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selIntegerValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIntegerValueHandle);
		}
		[Export("setIntegerValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetIntegerValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetIntegerValue_Handle, value);
			}
		}
	}

	public virtual bool TruncatesLastVisibleLine
	{
		[Export("truncatesLastVisibleLine")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTruncatesLastVisibleLineHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTruncatesLastVisibleLineHandle);
		}
		[Export("setTruncatesLastVisibleLine:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTruncatesLastVisibleLine_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTruncatesLastVisibleLine_Handle, value);
			}
		}
	}

	public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection
	{
		[Export("userInterfaceLayoutDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUserInterfaceLayoutDirectionHandle);
		}
		[Export("setUserInterfaceLayoutDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
		}
	}

	public virtual bool UsesSingleLineMode
	{
		[Export("usesSingleLineMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSingleLineModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSingleLineModeHandle);
		}
		[Export("setUsesSingleLineMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSingleLineMode_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSingleLineMode_Handle, value);
			}
		}
	}

	public virtual bool ShowsFirstResponder
	{
		[Export("showsFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsFirstResponderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsFirstResponderHandle);
		}
		[Export("setShowsFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsFirstResponder_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsFirstResponder_Handle, value);
			}
		}
	}

	public virtual long MnemonicLocation
	{
		[Export("mnemonicLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMnemonicLocationHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMnemonicLocationHandle);
		}
		[Export("setMnemonicLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMnemonicLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMnemonicLocation_Handle, value);
			}
		}
	}

	public virtual string Mnemonic
	{
		[Export("mnemonic")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMnemonicHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMnemonicHandle));
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

	public virtual bool WantsNotificationForMarkedText
	{
		[Export("wantsNotificationForMarkedText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsNotificationForMarkedTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsNotificationForMarkedTextHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSAttributedString AttributedStringValue
	{
		[Export("attributedStringValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_AttributedStringValue_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringValueHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringValueHandle)))));
		}
		[Export("setAttributedStringValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedStringValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedStringValue_Handle, value.Handle);
			}
			__mt_AttributedStringValue_var = value;
		}
	}

	public virtual bool AllowsEditingTextAttributes
	{
		[Export("allowsEditingTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEditingTextAttributesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEditingTextAttributesHandle);
		}
		[Export("setAllowsEditingTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEditingTextAttributes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEditingTextAttributes_Handle, value);
			}
		}
	}

	public virtual bool ImportsGraphics
	{
		[Export("importsGraphics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImportsGraphicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImportsGraphicsHandle);
		}
		[Export("setImportsGraphics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImportsGraphics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImportsGraphics_Handle, value);
			}
		}
	}

	public virtual bool AllowsMixedState
	{
		[Export("allowsMixedState")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMixedStateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMixedStateHandle);
		}
		[Export("setAllowsMixedState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMixedState_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMixedState_Handle, value);
			}
		}
	}

	public virtual long NextState
	{
		[Export("nextState")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNextStateHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNextStateHandle);
		}
	}

	public virtual NSBackgroundStyle BackgroundStyle
	{
		[Export("backgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBackgroundStyleHandle);
		}
		[Export("setBackgroundStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBackgroundStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBackgroundStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSBackgroundStyle InteriorBackgroundStyle
	{
		[Export("interiorBackgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selInteriorBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInteriorBackgroundStyleHandle);
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

	[Field("NSControlTintDidChangeNotification", "AppKit")]
	public static NSString ControlTintChangedNotification
	{
		get
		{
			if (_ControlTintChangedNotification == null)
			{
				_ControlTintChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSControlTintDidChangeNotification");
			}
			return _ControlTintChangedNotification;
		}
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSDrawThreePartImage(CGRect rect, IntPtr startCap, IntPtr centerFill, IntPtr endCap, bool vertial, ulong op, double alphaFraction, bool flipped);

	public void DrawThreePartImage(CGRect frame, NSImage startCap, NSImage centerFill, NSImage endCap, bool vertical, NSCompositingOperation op, double alphaFraction, bool flipped)
	{
		NSDrawThreePartImage(frame, startCap?.Handle ?? IntPtr.Zero, centerFill?.Handle ?? IntPtr.Zero, endCap?.Handle ?? IntPtr.Zero, vertical, (ulong)op, alphaFraction, flipped);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSDrawNinePartImage(CGRect frame, IntPtr topLeftCorner, IntPtr topEdgeFill, IntPtr topRightCorner, IntPtr leftEdgeFill, IntPtr centerFill, IntPtr rightEdgeFill, IntPtr bottomLeftCorner, IntPtr bottomEdgeFill, IntPtr bottomRightCorner, ulong op, double alphaFraction, bool flipped);

	public void DrawNinePartImage(CGRect frame, NSImage topLeftCorner, NSImage topEdgeFill, NSImage topRightCorner, NSImage leftEdgeFill, NSImage centerFill, NSImage rightEdgeFill, NSImage bottomLeftCorner, NSImage bottomEdgeFill, NSImage bottomRightCorner, NSCompositingOperation op, double alphaFraction, bool flipped)
	{
		NSDrawNinePartImage(frame, topLeftCorner?.Handle ?? IntPtr.Zero, topEdgeFill?.Handle ?? IntPtr.Zero, topRightCorner?.Handle ?? IntPtr.Zero, leftEdgeFill?.Handle ?? IntPtr.Zero, centerFill?.Handle ?? IntPtr.Zero, rightEdgeFill?.Handle ?? IntPtr.Zero, bottomLeftCorner?.Handle ?? IntPtr.Zero, bottomEdgeFill?.Handle ?? IntPtr.Zero, bottomRightCorner?.Handle ?? IntPtr.Zero, (ulong)op, alphaFraction, flipped);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCell()
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
	public NSCell(NSCoder coder)
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
	public NSCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("sendActionOn:")]
	public virtual long SendActionOn(NSEventType mask)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_UInt64(base.Handle, selSendActionOn_Handle, (ulong)mask);
		}
		return Messaging.Int64_objc_msgSendSuper_UInt64(base.SuperHandle, selSendActionOn_Handle, (ulong)mask);
	}

	[Export("isEntryAcceptable:")]
	public virtual bool IsEntryAcceptable(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEntryAcceptable_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEntryAcceptable_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compare:")]
	public virtual NSComparisonResult Compare(NSObject otherCell)
	{
		NSApplication.EnsureUIThread();
		if (otherCell == null)
		{
			throw new ArgumentNullException("otherCell");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, otherCell.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, otherCell.Handle);
	}

	[Export("takeIntValueFrom:")]
	public virtual void TakeIntValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeIntValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeIntValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeFloatValueFrom:")]
	public virtual void TakeFloatValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeFloatValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeFloatValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeDoubleValueFrom:")]
	public virtual void TakeDoubleValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeDoubleValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeDoubleValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeStringValueFrom:")]
	public virtual void TakeStringValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeStringValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeStringValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeObjectValueFrom:")]
	public virtual void TakeObjectValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeObjectValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeObjectValueFrom_Handle, sender.Handle);
		}
	}

	[Export("cellAttribute:")]
	public virtual long CellAttribute(NSCellAttribute aParameter)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_UInt64(base.Handle, selCellAttribute_Handle, (ulong)aParameter);
		}
		return Messaging.Int64_objc_msgSendSuper_UInt64(base.SuperHandle, selCellAttribute_Handle, (ulong)aParameter);
	}

	[Export("setCellAttribute:to:")]
	public virtual void SetCellAttribute(NSCellAttribute aParameter, long value)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Int64(base.Handle, selSetCellAttributeTo_Handle, (ulong)aParameter, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Int64(base.SuperHandle, selSetCellAttributeTo_Handle, (ulong)aParameter, value);
		}
	}

	[Export("imageRectForBounds:")]
	public virtual CGRect ImageRectForBounds(CGRect theRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selImageRectForBounds_Handle, theRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selImageRectForBounds_Handle, theRect);
		}
		return retval;
	}

	[Export("titleRectForBounds:")]
	public virtual CGRect TitleRectForBounds(CGRect theRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selTitleRectForBounds_Handle, theRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selTitleRectForBounds_Handle, theRect);
		}
		return retval;
	}

	[Export("drawingRectForBounds:")]
	public virtual CGRect DrawingRectForBounds(CGRect theRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selDrawingRectForBounds_Handle, theRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selDrawingRectForBounds_Handle, theRect);
		}
		return retval;
	}

	[Export("cellSizeForBounds:")]
	public virtual CGSize CellSizeForBounds(CGRect bounds)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGRect(base.Handle, selCellSizeForBounds_Handle, bounds);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGRect(base.SuperHandle, selCellSizeForBounds_Handle, bounds);
	}

	[Export("highlightColorWithFrame:inView:")]
	public virtual NSColor HighlightColor(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selHighlightColorWithFrameInView_Handle, cellFrame, controlView.Handle));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selHighlightColorWithFrameInView_Handle, cellFrame, controlView.Handle));
	}

	[Export("calcDrawInfo:")]
	public virtual void CalcDrawInfo(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selCalcDrawInfo_Handle, aRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selCalcDrawInfo_Handle, aRect);
		}
	}

	[Export("setUpFieldEditorAttributes:")]
	public virtual NSText SetUpFieldEditorAttributes(NSText textObj)
	{
		NSApplication.EnsureUIThread();
		if (textObj == null)
		{
			throw new ArgumentNullException("textObj");
		}
		if (IsDirectBinding)
		{
			return (NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetUpFieldEditorAttributes_Handle, textObj.Handle));
		}
		return (NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUpFieldEditorAttributes_Handle, textObj.Handle));
	}

	[Export("drawInteriorWithFrame:inView:")]
	public virtual void DrawInteriorWithFrame(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawInteriorWithFrameInView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawInteriorWithFrameInView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("drawWithFrame:inView:")]
	public virtual void DrawWithFrame(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawWithFrameInView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawWithFrameInView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("highlight:withFrame:inView:")]
	public virtual void Highlight(bool highlight, CGRect withFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_CGRect_IntPtr(base.Handle, selHighlightWithFrameInView_Handle, highlight, withFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_CGRect_IntPtr(base.SuperHandle, selHighlightWithFrameInView_Handle, highlight, withFrame, inView.Handle);
		}
	}

	[Export("getPeriodicDelay:interval:")]
	public virtual void GetPeriodicDelay(ref double delay, ref double interval)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_out_Double(base.Handle, selGetPeriodicDelayInterval_Handle, out delay, out interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_out_Double(base.SuperHandle, selGetPeriodicDelayInterval_Handle, out delay, out interval);
		}
	}

	[Export("startTrackingAt:inView:")]
	public virtual bool StartTracking(CGPoint startPoint, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint_IntPtr(base.Handle, selStartTrackingAtInView_Handle, startPoint, inView.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selStartTrackingAtInView_Handle, startPoint, inView.Handle);
	}

	[Export("continueTracking:at:inView:")]
	public virtual bool ContinueTracking(CGPoint lastPoint, CGPoint currentPoint, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint_CGPoint_IntPtr(base.Handle, selContinueTrackingAtInView_Handle, lastPoint, currentPoint, inView.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint_CGPoint_IntPtr(base.SuperHandle, selContinueTrackingAtInView_Handle, lastPoint, currentPoint, inView.Handle);
	}

	[Export("stopTracking:at:inView:mouseIsUp:")]
	public virtual void StopTracking(CGPoint lastPoint, CGPoint stopPoint, NSView inView, bool mouseIsUp)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_IntPtr_bool(base.Handle, selStopTrackingAtInViewMouseIsUp_Handle, lastPoint, stopPoint, inView.Handle, mouseIsUp);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_IntPtr_bool(base.SuperHandle, selStopTrackingAtInViewMouseIsUp_Handle, lastPoint, stopPoint, inView.Handle, mouseIsUp);
		}
	}

	[Export("trackMouse:inRect:ofView:untilMouseUp:")]
	public virtual bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool(base.Handle, selTrackMouseInRectOfViewUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool(base.SuperHandle, selTrackMouseInRectOfViewUntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
	}

	[Export("editWithFrame:inView:editor:delegate:event:")]
	public virtual void EditWithFrame(CGRect aRect, NSView inView, NSText editor, NSObject delegateObject, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEditWithFrameInViewEditorDelegateEvent_Handle, aRect, inView.Handle, editor.Handle, delegateObject.Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEditWithFrameInViewEditorDelegateEvent_Handle, aRect, inView.Handle, editor.Handle, delegateObject.Handle, theEvent.Handle);
		}
	}

	[Export("selectWithFrame:inView:editor:delegate:start:length:")]
	public virtual void SelectWithFrame(CGRect aRect, NSView inView, NSText editor, NSObject delegateObject, long selStart, long selLength)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr_Int64_Int64(base.Handle, selSelectWithFrameInViewEditorDelegateStartLength_Handle, aRect, inView.Handle, editor.Handle, delegateObject.Handle, selStart, selLength);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr_Int64_Int64(base.SuperHandle, selSelectWithFrameInViewEditorDelegateStartLength_Handle, aRect, inView.Handle, editor.Handle, delegateObject.Handle, selStart, selLength);
		}
	}

	[Export("endEditing:")]
	public virtual void EndEditing(NSText textObj)
	{
		NSApplication.EnsureUIThread();
		if (textObj == null)
		{
			throw new ArgumentNullException("textObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndEditing_Handle, textObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndEditing_Handle, textObj.Handle);
		}
	}

	[Export("resetCursorRect:inView:")]
	public virtual void ResetCursorRect(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selResetCursorRectInView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selResetCursorRectInView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("menuForEvent:inRect:ofView:")]
	public virtual NSMenu MenuForEvent(NSEvent theEvent, CGRect cellFrame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selMenuForEventInRectOfView_Handle, theEvent.Handle, cellFrame, view.Handle));
		}
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selMenuForEventInRectOfView_Handle, theEvent.Handle, cellFrame, view.Handle));
	}

	[Export("setSendsActionOnEndEditing:")]
	public virtual void SetSendsActionOnEndEditing(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetSendsActionOnEndEditing_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSendsActionOnEndEditing_Handle, flag);
		}
	}

	[Export("sendsActionOnEndEditing")]
	public virtual bool SendsActionOnEndEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSendsActionOnEndEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendsActionOnEndEditingHandle);
	}

	[Export("takeIntegerValueFrom:")]
	public virtual void TakeIntegerValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeIntegerValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeIntegerValueFrom_Handle, sender.Handle);
		}
	}

	[Export("fieldEditorForView:")]
	public virtual NSTextView FieldEditorForView(NSView aControlView)
	{
		NSApplication.EnsureUIThread();
		if (aControlView == null)
		{
			throw new ArgumentNullException("aControlView");
		}
		if (IsDirectBinding)
		{
			return (NSTextView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFieldEditorForView_Handle, aControlView.Handle));
		}
		return (NSTextView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFieldEditorForView_Handle, aControlView.Handle));
	}

	[Export("refusesFirstResponder")]
	public virtual bool RefusesFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRefusesFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRefusesFirstResponderHandle);
	}

	[Export("acceptsFirstResponder")]
	public virtual bool AcceptsFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAcceptsFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsFirstResponderHandle);
	}

	[Export("setTitleWithMnemonic:")]
	public virtual void SetTitleWithMnemonic(string stringWithAmpersand)
	{
		NSApplication.EnsureUIThread();
		if (stringWithAmpersand == null)
		{
			throw new ArgumentNullException("stringWithAmpersand");
		}
		IntPtr arg = NSString.CreateNative(stringWithAmpersand);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithMnemonic_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithMnemonic_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("performClick:")]
	public virtual void PerformClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClick_Handle, sender.Handle);
		}
	}

	[Export("setNextState")]
	public virtual void SetNextState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNextStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNextStateHandle);
		}
	}

	[Export("hitTestForEvent:inRect:ofView:")]
	public virtual NSCellHit HitTest(NSEvent forEvent, CGRect inRect, NSView ofView)
	{
		NSApplication.EnsureUIThread();
		if (forEvent == null)
		{
			throw new ArgumentNullException("forEvent");
		}
		if (ofView == null)
		{
			throw new ArgumentNullException("ofView");
		}
		if (IsDirectBinding)
		{
			return (NSCellHit)Messaging.UInt64_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selHitTestForEventInRectOfView_Handle, forEvent.Handle, inRect, ofView.Handle);
		}
		return (NSCellHit)Messaging.UInt64_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selHitTestForEventInRectOfView_Handle, forEvent.Handle, inRect, ofView.Handle);
	}

	[Export("expansionFrameWithFrame:inView:")]
	public virtual CGRect ExpansionFrame(CGRect withFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selExpansionFrameWithFrameInView_Handle, withFrame, inView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selExpansionFrameWithFrameInView_Handle, withFrame, inView.Handle);
		}
		return retval;
	}

	[Export("drawWithExpansionFrame:inView:")]
	public virtual void DrawWithExpansionFrame(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawWithExpansionFrameInView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawWithExpansionFrameInView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("draggingImageComponentsWithFrame:inView:")]
	public virtual NSDraggingImageComponent[] GenerateDraggingImageComponents(CGRect frame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selDraggingImageComponentsWithFrameInView_Handle, frame, view.Handle));
		}
		return NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDraggingImageComponentsWithFrameInView_Handle, frame, view.Handle));
	}

	[Export("drawFocusRingMaskWithFrame:inView:")]
	public virtual void DrawFocusRing(CGRect cellFrameMask, NSView inControlView)
	{
		NSApplication.EnsureUIThread();
		if (inControlView == null)
		{
			throw new ArgumentNullException("inControlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawFocusRingMaskWithFrameInView_Handle, cellFrameMask, inControlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawFocusRingMaskWithFrameInView_Handle, cellFrameMask, inControlView.Handle);
		}
	}

	[Export("focusRingMaskBoundsForFrame:inView:")]
	public virtual CGRect GetFocusRingMaskBounds(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selFocusRingMaskBoundsForFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selFocusRingMaskBoundsForFrameInView_Handle, cellFrame, controlView.Handle);
		}
		return retval;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ControlView_var = null;
			__mt_Target_var = null;
			__mt_Font_var = null;
			__mt_Formatter_var = null;
			__mt_ObjectValue_var = null;
			__mt_Image_var = null;
			__mt_RepresentedObject_var = null;
			__mt_Menu_var = null;
			__mt_AttributedStringValue_var = null;
		}
	}
}

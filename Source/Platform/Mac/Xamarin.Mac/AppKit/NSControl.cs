using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSControl", true)]
public class NSControl : NSView
{
	public new static class Notifications
	{
		public static NSObject ObserveTextDidBeginEditing(EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidBeginEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			});
		}

		public static NSObject ObserveTextDidBeginEditing(NSObject objectToObserve, EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidBeginEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTextDidChange(EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			});
		}

		public static NSObject ObserveTextDidChange(NSObject objectToObserve, EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTextDidEndEditing(EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidEndEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			});
		}

		public static NSObject ObserveTextDidEndEditing(NSObject objectToObserve, EventHandler<NSControlTextEditingEventArgs> handler)
		{
			EventHandler<NSControlTextEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TextDidEndEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSControlTextEditingEventArgs(notification));
			}, objectToObserve);
		}
	}

	private NSObject target;

	private Selector action;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbortEditing = "abortEditing";

	private static readonly IntPtr selAbortEditingHandle = Selector.GetHandle("abortEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsExpansionToolTips = "allowsExpansionToolTips";

	private static readonly IntPtr selAllowsExpansionToolTipsHandle = Selector.GetHandle("allowsExpansionToolTips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringValue = "attributedStringValue";

	private static readonly IntPtr selAttributedStringValueHandle = Selector.GetHandle("attributedStringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseWritingDirection = "baseWritingDirection";

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalcSize = "calcSize";

	private static readonly IntPtr selCalcSizeHandle = Selector.GetHandle("calcSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCell = "cell";

	private static readonly IntPtr selCellHandle = Selector.GetHandle("cell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellClass = "cellClass";

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlSize = "controlSize";

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentEditor = "currentEditor";

	private static readonly IntPtr selCurrentEditorHandle = Selector.GetHandle("currentEditor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawCell_ = "drawCell:";

	private static readonly IntPtr selDrawCell_Handle = Selector.GetHandle("drawCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawCellInside_ = "drawCellInside:";

	private static readonly IntPtr selDrawCellInside_Handle = Selector.GetHandle("drawCellInside:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithExpansionFrame_InView_ = "drawWithExpansionFrame:inView:";

	private static readonly IntPtr selDrawWithExpansionFrame_InView_Handle = Selector.GetHandle("drawWithExpansionFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditWithFrame_Editor_Delegate_Event_ = "editWithFrame:editor:delegate:event:";

	private static readonly IntPtr selEditWithFrame_Editor_Delegate_Event_Handle = Selector.GetHandle("editWithFrame:editor:delegate:event:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndEditing_ = "endEditing:";

	private static readonly IntPtr selEndEditing_Handle = Selector.GetHandle("endEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatValue = "floatValue";

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatter = "formatter";

	private static readonly IntPtr selFormatterHandle = Selector.GetHandle("formatter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoresMultiClick = "ignoresMultiClick";

	private static readonly IntPtr selIgnoresMultiClickHandle = Selector.GetHandle("ignoresMultiClick");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntValue = "intValue";

	private static readonly IntPtr selIntValueHandle = Selector.GetHandle("intValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntegerValue = "integerValue";

	private static readonly IntPtr selIntegerValueHandle = Selector.GetHandle("integerValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateIntrinsicContentSizeForCell_ = "invalidateIntrinsicContentSizeForCell:";

	private static readonly IntPtr selInvalidateIntrinsicContentSizeForCell_Handle = Selector.GetHandle("invalidateIntrinsicContentSizeForCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContinuous = "isContinuous";

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHighlighted = "isHighlighted";

	private static readonly IntPtr selIsHighlightedHandle = Selector.GetHandle("isHighlighted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineBreakMode = "lineBreakMode";

	private static readonly IntPtr selLineBreakModeHandle = Selector.GetHandle("lineBreakMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDown_ = "mouseDown:";

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectValue = "objectValue";

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformClick_ = "performClick:";

	private static readonly IntPtr selPerformClick_Handle = Selector.GetHandle("performClick:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefusesFirstResponder = "refusesFirstResponder";

	private static readonly IntPtr selRefusesFirstResponderHandle = Selector.GetHandle("refusesFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectCell_ = "selectCell:";

	private static readonly IntPtr selSelectCell_Handle = Selector.GetHandle("selectCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectWithFrame_Editor_Delegate_Start_Length_ = "selectWithFrame:editor:delegate:start:length:";

	private static readonly IntPtr selSelectWithFrame_Editor_Delegate_Start_Length_Handle = Selector.GetHandle("selectWithFrame:editor:delegate:start:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedCell = "selectedCell";

	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTag = "selectedTag";

	private static readonly IntPtr selSelectedTagHandle = Selector.GetHandle("selectedTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAction_To_ = "sendAction:to:";

	private static readonly IntPtr selSendAction_To_Handle = Selector.GetHandle("sendAction:to:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendActionOn_ = "sendActionOn:";

	private static readonly IntPtr selSendActionOn_Handle = Selector.GetHandle("sendActionOn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_ = "setAlignment:";

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsExpansionToolTips_ = "setAllowsExpansionToolTips:";

	private static readonly IntPtr selSetAllowsExpansionToolTips_Handle = Selector.GetHandle("setAllowsExpansionToolTips:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedStringValue_ = "setAttributedStringValue:";

	private static readonly IntPtr selSetAttributedStringValue_Handle = Selector.GetHandle("setAttributedStringValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseWritingDirection_ = "setBaseWritingDirection:";

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCell_ = "setCell:";

	private static readonly IntPtr selSetCell_Handle = Selector.GetHandle("setCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellClass_ = "setCellClass:";

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuous_ = "setContinuous:";

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlSize_ = "setControlSize:";

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleValue_ = "setDoubleValue:";

	private static readonly IntPtr selSetDoubleValue_Handle = Selector.GetHandle("setDoubleValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatValue_ = "setFloatValue:";

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormatter_ = "setFormatter:";

	private static readonly IntPtr selSetFormatter_Handle = Selector.GetHandle("setFormatter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlighted_ = "setHighlighted:";

	private static readonly IntPtr selSetHighlighted_Handle = Selector.GetHandle("setHighlighted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoresMultiClick_ = "setIgnoresMultiClick:";

	private static readonly IntPtr selSetIgnoresMultiClick_Handle = Selector.GetHandle("setIgnoresMultiClick:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntValue_ = "setIntValue:";

	private static readonly IntPtr selSetIntValue_Handle = Selector.GetHandle("setIntValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntegerValue_ = "setIntegerValue:";

	private static readonly IntPtr selSetIntegerValue_Handle = Selector.GetHandle("setIntegerValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineBreakMode_ = "setLineBreakMode:";

	private static readonly IntPtr selSetLineBreakMode_Handle = Selector.GetHandle("setLineBreakMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplay = "setNeedsDisplay";

	private static readonly IntPtr selSetNeedsDisplayHandle = Selector.GetHandle("setNeedsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObjectValue_ = "setObjectValue:";

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRefusesFirstResponder_ = "setRefusesFirstResponder:";

	private static readonly IntPtr selSetRefusesFirstResponder_Handle = Selector.GetHandle("setRefusesFirstResponder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStringValue_ = "setStringValue:";

	private static readonly IntPtr selSetStringValue_Handle = Selector.GetHandle("setStringValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTag_ = "setTag:";

	private static readonly IntPtr selSetTag_Handle = Selector.GetHandle("setTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesSingleLineMode_ = "setUsesSingleLineMode:";

	private static readonly IntPtr selSetUsesSingleLineMode_Handle = Selector.GetHandle("setUsesSingleLineMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeThatFits_ = "sizeThatFits:";

	private static readonly IntPtr selSizeThatFits_Handle = Selector.GetHandle("sizeThatFits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToFit = "sizeToFit";

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTag = "tag";

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeDoubleValueFrom_ = "takeDoubleValueFrom:";

	private static readonly IntPtr selTakeDoubleValueFrom_Handle = Selector.GetHandle("takeDoubleValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeFloatValueFrom_ = "takeFloatValueFrom:";

	private static readonly IntPtr selTakeFloatValueFrom_Handle = Selector.GetHandle("takeFloatValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeIntValueFrom_ = "takeIntValueFrom:";

	private static readonly IntPtr selTakeIntValueFrom_Handle = Selector.GetHandle("takeIntValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeIntegerValueFrom_ = "takeIntegerValueFrom:";

	private static readonly IntPtr selTakeIntegerValueFrom_Handle = Selector.GetHandle("takeIntegerValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeObjectValueFrom_ = "takeObjectValueFrom:";

	private static readonly IntPtr selTakeObjectValueFrom_Handle = Selector.GetHandle("takeObjectValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeStringValueFrom_ = "takeStringValueFrom:";

	private static readonly IntPtr selTakeStringValueFrom_Handle = Selector.GetHandle("takeStringValueFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCell_ = "updateCell:";

	private static readonly IntPtr selUpdateCell_Handle = Selector.GetHandle("updateCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCellInside_ = "updateCellInside:";

	private static readonly IntPtr selUpdateCellInside_Handle = Selector.GetHandle("updateCellInside:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesSingleLineMode = "usesSingleLineMode";

	private static readonly IntPtr selUsesSingleLineModeHandle = Selector.GetHandle("usesSingleLineMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateEditing = "validateEditing";

	private static readonly IntPtr selValidateEditingHandle = Selector.GetHandle("validateEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextDidBeginEditingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextDidEndEditingNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector? Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
		[Export("setAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlignment_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsExpansionToolTips
	{
		[Export("allowsExpansionToolTips")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsExpansionToolTipsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsExpansionToolTipsHandle);
		}
		[Export("setAllowsExpansionToolTips:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsExpansionToolTips_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsExpansionToolTips_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedStringValue
	{
		[Export("attributedStringValue", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringValueHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringValueHandle));
		}
		[Export("setAttributedStringValue:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedStringValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedStringValue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWritingDirection BaseWritingDirection
	{
		[Export("baseWritingDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWritingDirection)Messaging.Int64_objc_msgSend(base.Handle, selBaseWritingDirectionHandle);
			}
			return (NSWritingDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBaseWritingDirectionHandle);
		}
		[Export("setBaseWritingDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBaseWritingDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBaseWritingDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSCell Cell
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("cell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellHandle));
			}
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static Class CellClass
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selCellClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setCellClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCellClass_Handle, value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Continuous
	{
		[Export("isContinuous")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousHandle);
		}
		[Export("setContinuous:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSControlSize ControlSize
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSText CurrentEditor
	{
		[Export("currentEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSText>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEditorHandle));
			}
			return Runtime.GetNSObject<NSText>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEditorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
		[Export("setDoubleValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDoubleValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDoubleValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FloatValue
	{
		[Export("floatValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFloatValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFloatValueHandle);
		}
		[Export("setFloatValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFloatValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFloatValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont Font
	{
		[Export("font")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle));
		}
		[Export("setFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Formatter
	{
		[Export("formatter", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatterHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatterHandle));
		}
		[Export("setFormatter:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormatter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormatter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool Highlighted
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isHighlighted")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHighlightedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHighlightedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setHighlighted:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHighlighted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHighlighted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoresMultiClick
	{
		[Export("ignoresMultiClick")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoresMultiClickHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoresMultiClickHandle);
		}
		[Export("setIgnoresMultiClick:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIgnoresMultiClick_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIgnoresMultiClick_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int IntValue
	{
		[Export("intValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIntValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIntValueHandle);
		}
		[Export("setIntValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetIntValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetIntValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSLineBreakMode LineBreakMode
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("lineBreakMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLineBreakMode)Messaging.UInt64_objc_msgSend(base.Handle, selLineBreakModeHandle);
			}
			return (NSLineBreakMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineBreakModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLineBreakMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineBreakMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineBreakMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NIntValue
	{
		[Export("integerValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIntegerValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIntegerValueHandle);
		}
		[Export("setIntegerValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetIntegerValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetIntegerValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectValue
	{
		[Export("objectValue", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle));
		}
		[Export("setObjectValue:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RefusesFirstResponder
	{
		[Export("refusesFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRefusesFirstResponderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRefusesFirstResponderHandle);
		}
		[Export("setRefusesFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRefusesFirstResponder_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRefusesFirstResponder_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSCell SelectedCell
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("selectedCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle));
			}
			return Runtime.GetNSObject<NSCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint SelectedTag
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("selectedTag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
		[Export("setTag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetTag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetTag_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool UsesSingleLineMode
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("usesSingleLineMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSingleLineModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSingleLineModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUsesSingleLineMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSingleLineMode_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSingleLineMode_Handle, value);
			}
		}
	}

	[Field("NSControlTextDidBeginEditingNotification", "AppKit")]
	[Advice("Use NSControl.Notifications.ObserveTextDidBeginEditing helper method instead.")]
	public static NSString TextDidBeginEditingNotification
	{
		get
		{
			if (_TextDidBeginEditingNotification == null)
			{
				_TextDidBeginEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSControlTextDidBeginEditingNotification");
			}
			return _TextDidBeginEditingNotification;
		}
	}

	[Field("NSControlTextDidChangeNotification", "AppKit")]
	[Advice("Use NSControl.Notifications.ObserveTextDidChange helper method instead.")]
	public static NSString TextDidChangeNotification
	{
		get
		{
			if (_TextDidChangeNotification == null)
			{
				_TextDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSControlTextDidChangeNotification");
			}
			return _TextDidChangeNotification;
		}
	}

	[Field("NSControlTextDidEndEditingNotification", "AppKit")]
	[Advice("Use NSControl.Notifications.ObserveTextDidEndEditing helper method instead.")]
	public static NSString TextDidEndEditingNotification
	{
		get
		{
			if (_TextDidEndEditingNotification == null)
			{
				_TextDidEndEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSControlTextDidEndEditingNotification");
			}
			return _TextDidEndEditingNotification;
		}
	}

	public event EventHandler Activated
	{
		add
		{
			target = ActionDispatcher.SetupAction(Target, value);
			action = ActionDispatcher.Action;
			MarkDirty();
			Target = target;
			Action = action;
		}
		remove
		{
			ActionDispatcher.RemoveAction(Target, value);
			target = null;
			action = null;
			MarkDirty();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSControl()
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
	public NSControl(NSCoder coder)
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
	protected NSControl(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSControl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSControl(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("abortEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AbortEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAbortEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAbortEditingHandle);
	}

	[Export("calcSize")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Override 'Layout' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CalcSize()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCalcSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCalcSizeHandle);
		}
	}

	[Export("drawCell:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawCell_Handle, aCell.Handle);
		}
	}

	[Export("drawCellInside:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawCellInside(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawCellInside_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawCellInside_Handle, aCell.Handle);
		}
	}

	[Export("drawWithExpansionFrame:inView:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawWithExpansionFrame(CGRect cellFrame, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawWithExpansionFrame_InView_Handle, cellFrame, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawWithExpansionFrame_InView_Handle, cellFrame, view.Handle);
		}
	}

	[Export("editWithFrame:editor:delegate:event:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditWithFrame(CGRect aRect, NSText? textObj, NSObject? anObject, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr(base.Handle, selEditWithFrame_Editor_Delegate_Event_Handle, aRect, textObj?.Handle ?? IntPtr.Zero, anObject?.Handle ?? IntPtr.Zero, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEditWithFrame_Editor_Delegate_Event_Handle, aRect, textObj?.Handle ?? IntPtr.Zero, anObject?.Handle ?? IntPtr.Zero, theEvent.Handle);
		}
	}

	[Export("endEditing:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndEditing(NSText? textObj)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndEditing_Handle, textObj?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndEditing_Handle, textObj?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("invalidateIntrinsicContentSizeForCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateIntrinsicContentSizeForCell(NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateIntrinsicContentSizeForCell_Handle, cell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateIntrinsicContentSizeForCell_Handle, cell.Handle);
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

	[Export("performClick:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClick_Handle, sender.Handle);
		}
	}

	[Export("selectCell:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectCell_Handle, aCell.Handle);
		}
	}

	[Export("selectWithFrame:editor:delegate:start:length:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectWithFrame(CGRect aRect, NSText? textObj, NSObject? anObject, nint selStart, nint selLength)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr_nint_nint(base.Handle, selSelectWithFrame_Editor_Delegate_Start_Length_Handle, aRect, textObj?.Handle ?? IntPtr.Zero, anObject?.Handle ?? IntPtr.Zero, selStart, selLength);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_nint_nint(base.SuperHandle, selSelectWithFrame_Editor_Delegate_Start_Length_Handle, aRect, textObj?.Handle ?? IntPtr.Zero, anObject?.Handle ?? IntPtr.Zero, selStart, selLength);
		}
	}

	[Export("sendAction:to:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendAction(Selector theAction, NSObject theTarget)
	{
		NSApplication.EnsureUIThread();
		if (theAction == null)
		{
			throw new ArgumentNullException("theAction");
		}
		if (theTarget == null)
		{
			throw new ArgumentNullException("theTarget");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSendAction_To_Handle, theAction.Handle, theTarget.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSendAction_To_Handle, theAction.Handle, theTarget.Handle);
	}

	[Export("sendActionOn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SendActionOn(NSEventType mask)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_UInt64(base.Handle, selSendActionOn_Handle, (ulong)mask);
		}
		return Messaging.nint_objc_msgSendSuper_UInt64(base.SuperHandle, selSendActionOn_Handle, (ulong)mask);
	}

	[Export("setNeedsDisplay")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsDisplayHandle);
		}
	}

	[Export("sizeThatFits:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize SizeThatFits(CGSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selSizeThatFits_Handle, size);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selSizeThatFits_Handle, size);
	}

	[Export("sizeToFit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("takeDoubleValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeDoubleValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeDoubleValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeDoubleValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeFloatValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeFloatValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeFloatValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeFloatValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeIntValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeIntValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeIntValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeIntValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeIntegerValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeIntegerValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeIntegerValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeIntegerValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeObjectValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeObjectValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeObjectValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeObjectValueFrom_Handle, sender.Handle);
		}
	}

	[Export("takeStringValueFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeStringValueFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeStringValueFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeStringValueFrom_Handle, sender.Handle);
		}
	}

	[Export("updateCell:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateCell_Handle, aCell.Handle);
		}
	}

	[Export("updateCellInside:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCellInside(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateCellInside_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateCellInside_Handle, aCell.Handle);
		}
	}

	[Export("validateEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ValidateEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateEditingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
		}
	}
}

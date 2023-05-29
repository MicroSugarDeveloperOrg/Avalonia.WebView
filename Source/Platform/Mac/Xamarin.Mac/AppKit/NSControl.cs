using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSControl", true)]
public class NSControl : NSView
{
	private static readonly IntPtr selSelectedCellHandle = Selector.GetHandle("selectedCell");

	private static readonly IntPtr selSelectedTagHandle = Selector.GetHandle("selectedTag");

	private static readonly IntPtr selCurrentEditorHandle = Selector.GetHandle("currentEditor");

	private static readonly IntPtr selCellClassHandle = Selector.GetHandle("cellClass");

	private static readonly IntPtr selSetCellClass_Handle = Selector.GetHandle("setCellClass:");

	private static readonly IntPtr selCellHandle = Selector.GetHandle("cell");

	private static readonly IntPtr selSetCell_Handle = Selector.GetHandle("setCell:");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selSetTag_Handle = Selector.GetHandle("setTag:");

	private static readonly IntPtr selIgnoresMultiClickHandle = Selector.GetHandle("ignoresMultiClick");

	private static readonly IntPtr selSetIgnoresMultiClick_Handle = Selector.GetHandle("setIgnoresMultiClick:");

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selFormatterHandle = Selector.GetHandle("formatter");

	private static readonly IntPtr selSetFormatter_Handle = Selector.GetHandle("setFormatter:");

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	private static readonly IntPtr selSetStringValue_Handle = Selector.GetHandle("setStringValue:");

	private static readonly IntPtr selAttributedStringValueHandle = Selector.GetHandle("attributedStringValue");

	private static readonly IntPtr selSetAttributedStringValue_Handle = Selector.GetHandle("setAttributedStringValue:");

	private static readonly IntPtr selIntValueHandle = Selector.GetHandle("intValue");

	private static readonly IntPtr selSetIntValue_Handle = Selector.GetHandle("setIntValue:");

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	private static readonly IntPtr selSetDoubleValue_Handle = Selector.GetHandle("setDoubleValue:");

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	private static readonly IntPtr selIntegerValueHandle = Selector.GetHandle("integerValue");

	private static readonly IntPtr selSetIntegerValue_Handle = Selector.GetHandle("setIntegerValue:");

	private static readonly IntPtr selRefusesFirstResponderHandle = Selector.GetHandle("refusesFirstResponder");

	private static readonly IntPtr selSetRefusesFirstResponder_Handle = Selector.GetHandle("setRefusesFirstResponder:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr selCalcSizeHandle = Selector.GetHandle("calcSize");

	private static readonly IntPtr selSendActionOn_Handle = Selector.GetHandle("sendActionOn:");

	private static readonly IntPtr selSetNeedsDisplayHandle = Selector.GetHandle("setNeedsDisplay");

	private static readonly IntPtr selUpdateCell_Handle = Selector.GetHandle("updateCell:");

	private static readonly IntPtr selUpdateCellInside_Handle = Selector.GetHandle("updateCellInside:");

	private static readonly IntPtr selDrawCellInside_Handle = Selector.GetHandle("drawCellInside:");

	private static readonly IntPtr selDrawCell_Handle = Selector.GetHandle("drawCell:");

	private static readonly IntPtr selSelectCell_Handle = Selector.GetHandle("selectCell:");

	private static readonly IntPtr selSendActionTo_Handle = Selector.GetHandle("sendAction:to:");

	private static readonly IntPtr selTakeIntValueFrom_Handle = Selector.GetHandle("takeIntValueFrom:");

	private static readonly IntPtr selTakeFloatValueFrom_Handle = Selector.GetHandle("takeFloatValueFrom:");

	private static readonly IntPtr selTakeDoubleValueFrom_Handle = Selector.GetHandle("takeDoubleValueFrom:");

	private static readonly IntPtr selTakeStringValueFrom_Handle = Selector.GetHandle("takeStringValueFrom:");

	private static readonly IntPtr selTakeObjectValueFrom_Handle = Selector.GetHandle("takeObjectValueFrom:");

	private static readonly IntPtr selAbortEditingHandle = Selector.GetHandle("abortEditing");

	private static readonly IntPtr selValidateEditingHandle = Selector.GetHandle("validateEditing");

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	private static readonly IntPtr selTakeIntegerValueFrom_Handle = Selector.GetHandle("takeIntegerValueFrom:");

	private static readonly IntPtr selInvalidateIntrinsicContentSizeForCell_Handle = Selector.GetHandle("invalidateIntrinsicContentSizeForCell:");

	private static readonly IntPtr selPerformClick_Handle = Selector.GetHandle("performClick:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSControl");

	private object __mt_SelectedCell_var;

	private object __mt_CurrentEditor_var;

	private object __mt_Cell_var;

	private object __mt_Target_var;

	private object __mt_Font_var;

	private object __mt_Formatter_var;

	private object __mt_ObjectValue_var;

	private object __mt_AttributedStringValue_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSCell SelectedCell
	{
		[Export("selectedCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_SelectedCell_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedCellHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedCellHandle)))));
		}
	}

	public virtual long SelectedTag
	{
		[Export("selectedTag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSelectedTagHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectedTagHandle);
		}
	}

	public virtual NSText CurrentEditor
	{
		[Export("currentEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSText)(__mt_CurrentEditor_var = ((!IsDirectBinding) ? ((NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEditorHandle))) : ((NSText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEditorHandle)))));
		}
	}

	public static Class CellClass
	{
		[Export("cellClass")]
		get
		{
			NSApplication.EnsureUIThread();
			return new Class(Messaging.IntPtr_objc_msgSend(class_ptr, selCellClassHandle));
		}
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

	public virtual NSCell Cell
	{
		[Export("cell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_Cell_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCellHandle)))));
		}
		[Export("setCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCell_Handle, value.Handle);
			}
			__mt_Cell_var = value;
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

	public new virtual long Tag
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

	public virtual bool IgnoresMultiClick
	{
		[Export("ignoresMultiClick")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoresMultiClickHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoresMultiClickHandle);
		}
		[Export("setIgnoresMultiClick:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIgnoresMultiClick_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIgnoresMultiClick_Handle, value);
			}
		}
	}

	public virtual bool Continuous
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

	public virtual NSObject Formatter
	{
		[Export("formatter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Formatter_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatterHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatterHandle))));
		}
		[Export("setFormatter:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFormatter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFormatter_Handle, value?.Handle ?? IntPtr.Zero);
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
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value.Handle);
			}
			__mt_ObjectValue_var = value;
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

	public virtual bool RefusesFirstResponder
	{
		[Export("refusesFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRefusesFirstResponderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRefusesFirstResponderHandle);
		}
		[Export("setRefusesFirstResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRefusesFirstResponder_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRefusesFirstResponder_Handle, value);
			}
		}
	}

	public event EventHandler Activated
	{
		add
		{
			Target = ActionDispatcher.SetupAction(Target, value);
			Action = ActionDispatcher.Action;
		}
		remove
		{
			ActionDispatcher.RemoveAction(Target, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSControl()
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
	public NSControl(NSCoder coder)
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
	public NSControl(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSControl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSControl(CGRect frameRect)
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

	[Export("sizeToFit")]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("calcSize")]
	public virtual void CalcSize()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCalcSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCalcSizeHandle);
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

	[Export("setNeedsDisplay")]
	public virtual void SetNeedsDisplay()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsDisplayHandle);
		}
	}

	[Export("updateCell:")]
	public virtual void UpdateCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateCell_Handle, aCell.Handle);
		}
	}

	[Export("updateCellInside:")]
	public virtual void UpdateCellInside(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateCellInside_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateCellInside_Handle, aCell.Handle);
		}
	}

	[Export("drawCellInside:")]
	public virtual void DrawCellInside(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawCellInside_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawCellInside_Handle, aCell.Handle);
		}
	}

	[Export("drawCell:")]
	public virtual void DrawCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDrawCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDrawCell_Handle, aCell.Handle);
		}
	}

	[Export("selectCell:")]
	public virtual void SelectCell(NSCell aCell)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectCell_Handle, aCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectCell_Handle, aCell.Handle);
		}
	}

	[Export("sendAction:to:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSendActionTo_Handle, theAction.Handle, theTarget.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSendActionTo_Handle, theAction.Handle, theTarget.Handle);
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

	[Export("abortEditing")]
	public virtual bool AbortEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAbortEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAbortEditingHandle);
	}

	[Export("validateEditing")]
	public virtual void ValidateEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateEditingHandle);
		}
	}

	[Export("mouseDown:")]
	public new virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
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

	[Export("invalidateIntrinsicContentSizeForCell:")]
	public virtual void InvalidateIntrinsicContentSizeForCell(NSCell cell)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateIntrinsicContentSizeForCell_Handle, cell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateIntrinsicContentSizeForCell_Handle, cell.Handle);
		}
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SelectedCell_var = null;
			__mt_CurrentEditor_var = null;
			__mt_Cell_var = null;
			__mt_Target_var = null;
			__mt_Font_var = null;
			__mt_Formatter_var = null;
			__mt_ObjectValue_var = null;
			__mt_AttributedStringValue_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSText", true)]
public class NSText : NSView
{
	[Register]
	private sealed class _NSTextDelegate : NSTextDelegate
	{
		internal NSTextPredicate textShouldBeginEditing;

		internal NSTextPredicate textShouldEndEditing;

		internal EventHandler textDidBeginEditing;

		internal EventHandler textDidEndEditing;

		internal EventHandler textDidChange;

		[Preserve(Conditional = true)]
		public override bool TextShouldBeginEditing(NSText textObject)
		{
			return textShouldBeginEditing?.Invoke(textObject) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool TextShouldEndEditing(NSText textObject)
		{
			return textShouldEndEditing?.Invoke(textObject) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void TextDidBeginEditing(NSNotification notification)
		{
			textDidBeginEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void TextDidEndEditing(NSNotification notification)
		{
			textDidEndEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void TextDidChange(NSNotification notification)
		{
			textDidChange?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selIsRulerVisibleHandle = Selector.GetHandle("isRulerVisible");

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	private static readonly IntPtr selIsRichTextHandle = Selector.GetHandle("isRichText");

	private static readonly IntPtr selSetRichText_Handle = Selector.GetHandle("setRichText:");

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	private static readonly IntPtr selIsFieldEditorHandle = Selector.GetHandle("isFieldEditor");

	private static readonly IntPtr selSetFieldEditor_Handle = Selector.GetHandle("setFieldEditor:");

	private static readonly IntPtr selUsesFontPanelHandle = Selector.GetHandle("usesFontPanel");

	private static readonly IntPtr selSetUsesFontPanel_Handle = Selector.GetHandle("setUsesFontPanel:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selSelectedRangeHandle = Selector.GetHandle("selectedRange");

	private static readonly IntPtr selSetSelectedRange_Handle = Selector.GetHandle("setSelectedRange:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	private static readonly IntPtr selMaxSizeHandle = Selector.GetHandle("maxSize");

	private static readonly IntPtr selSetMaxSize_Handle = Selector.GetHandle("setMaxSize:");

	private static readonly IntPtr selMinSizeHandle = Selector.GetHandle("minSize");

	private static readonly IntPtr selSetMinSize_Handle = Selector.GetHandle("setMinSize:");

	private static readonly IntPtr selIsHorizontallyResizableHandle = Selector.GetHandle("isHorizontallyResizable");

	private static readonly IntPtr selSetHorizontallyResizable_Handle = Selector.GetHandle("setHorizontallyResizable:");

	private static readonly IntPtr selIsVerticallyResizableHandle = Selector.GetHandle("isVerticallyResizable");

	private static readonly IntPtr selSetVerticallyResizable_Handle = Selector.GetHandle("setVerticallyResizable:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selReplaceCharactersInRangeWithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	private static readonly IntPtr selReplaceCharactersInRangeWithRTF_Handle = Selector.GetHandle("replaceCharactersInRange:withRTF:");

	private static readonly IntPtr selReplaceCharactersInRangeWithRTFD_Handle = Selector.GetHandle("replaceCharactersInRange:withRTFD:");

	private static readonly IntPtr selRTFFromRange_Handle = Selector.GetHandle("RTFFromRange:");

	private static readonly IntPtr selRTFDFromRange_Handle = Selector.GetHandle("RTFDFromRange:");

	private static readonly IntPtr selWriteRTFDToFileAtomically_Handle = Selector.GetHandle("writeRTFDToFile:atomically:");

	private static readonly IntPtr selReadRTFDFromFile_Handle = Selector.GetHandle("readRTFDFromFile:");

	private static readonly IntPtr selScrollRangeToVisible_Handle = Selector.GetHandle("scrollRangeToVisible:");

	private static readonly IntPtr selSetTextColorRange_Handle = Selector.GetHandle("setTextColor:range:");

	private static readonly IntPtr selSetFontRange_Handle = Selector.GetHandle("setFont:range:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	private static readonly IntPtr selCopyFont_Handle = Selector.GetHandle("copyFont:");

	private static readonly IntPtr selCopyRuler_Handle = Selector.GetHandle("copyRuler:");

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	private static readonly IntPtr selPasteFont_Handle = Selector.GetHandle("pasteFont:");

	private static readonly IntPtr selPasteRuler_Handle = Selector.GetHandle("pasteRuler:");

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	private static readonly IntPtr selChangeFont_Handle = Selector.GetHandle("changeFont:");

	private static readonly IntPtr selAlignLeft_Handle = Selector.GetHandle("alignLeft:");

	private static readonly IntPtr selAlignRight_Handle = Selector.GetHandle("alignRight:");

	private static readonly IntPtr selAlignCenter_Handle = Selector.GetHandle("alignCenter:");

	private static readonly IntPtr selSubscript_Handle = Selector.GetHandle("subscript:");

	private static readonly IntPtr selSuperscript_Handle = Selector.GetHandle("superscript:");

	private static readonly IntPtr selUnderline_Handle = Selector.GetHandle("underline:");

	private static readonly IntPtr selUnscript_Handle = Selector.GetHandle("unscript:");

	private static readonly IntPtr selShowGuessPanel_Handle = Selector.GetHandle("showGuessPanel:");

	private static readonly IntPtr selCheckSpelling_Handle = Selector.GetHandle("checkSpelling:");

	private static readonly IntPtr selToggleRuler_Handle = Selector.GetHandle("toggleRuler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSText");

	private object __mt_WeakDelegate_var;

	private object __mt_BackgroundColor_var;

	private object __mt_Font_var;

	private object __mt_TextColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsRulerVisible
	{
		[Export("isRulerVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRulerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRulerVisibleHandle);
		}
	}

	public virtual string Value
	{
		[Export("string")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
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

	public NSTextDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSTextDelegate;
		}
		set
		{
			WeakDelegate = value;
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

	public virtual bool RichText
	{
		[Export("isRichText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRichTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRichTextHandle);
		}
		[Export("setRichText:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRichText_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRichText_Handle, value);
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

	public virtual bool FieldEditor
	{
		[Export("isFieldEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFieldEditorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFieldEditorHandle);
		}
		[Export("setFieldEditor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldEditor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldEditor_Handle, value);
			}
		}
	}

	public virtual bool UsesFontPanel
	{
		[Export("usesFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontPanelHandle);
		}
		[Export("setUsesFontPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontPanel_Handle, value);
			}
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
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

	public virtual NSRange SelectedRange
	{
		[Export("selectedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selSelectedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selSelectedRangeHandle);
		}
		[Export("setSelectedRange:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetSelectedRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetSelectedRange_Handle, value);
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

	public virtual NSColor TextColor
	{
		[Export("textColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_TextColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextColorHandle)))));
		}
		[Export("setTextColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextColor_Handle, value.Handle);
			}
			__mt_TextColor_var = value;
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

	public virtual bool HorizontallyResizable
	{
		[Export("isHorizontallyResizable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontallyResizableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontallyResizableHandle);
		}
		[Export("setHorizontallyResizable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontallyResizable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontallyResizable_Handle, value);
			}
		}
	}

	public virtual bool VerticallyResizable
	{
		[Export("isVerticallyResizable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticallyResizableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticallyResizableHandle);
		}
		[Export("setVerticallyResizable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticallyResizable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticallyResizable_Handle, value);
			}
		}
	}

	public NSTextPredicate TextShouldBeginEditing
	{
		get
		{
			return EnsureNSTextDelegate().textShouldBeginEditing;
		}
		set
		{
			EnsureNSTextDelegate().textShouldBeginEditing = value;
		}
	}

	public NSTextPredicate TextShouldEndEditing
	{
		get
		{
			return EnsureNSTextDelegate().textShouldEndEditing;
		}
		set
		{
			EnsureNSTextDelegate().textShouldEndEditing = value;
		}
	}

	public event EventHandler TextDidBeginEditing
	{
		add
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidBeginEditing = (EventHandler)System.Delegate.Combine(nSTextDelegate.textDidBeginEditing, value);
		}
		remove
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidBeginEditing = (EventHandler)System.Delegate.Remove(nSTextDelegate.textDidBeginEditing, value);
		}
	}

	public event EventHandler TextDidEndEditing
	{
		add
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidEndEditing = (EventHandler)System.Delegate.Combine(nSTextDelegate.textDidEndEditing, value);
		}
		remove
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidEndEditing = (EventHandler)System.Delegate.Remove(nSTextDelegate.textDidEndEditing, value);
		}
	}

	public event EventHandler TextDidChange
	{
		add
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidChange = (EventHandler)System.Delegate.Combine(nSTextDelegate.textDidChange, value);
		}
		remove
		{
			_NSTextDelegate nSTextDelegate = EnsureNSTextDelegate();
			nSTextDelegate.textDidChange = (EventHandler)System.Delegate.Remove(nSTextDelegate.textDidChange, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSText()
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
	public NSText(NSCoder coder)
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
	public NSText(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSText(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSText(CGRect frameRect)
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

	[Export("replaceCharactersInRange:withString:")]
	public virtual void Replace(NSRange range, string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRangeWithString_Handle, range, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRangeWithString_Handle, range, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceCharactersInRange:withRTF:")]
	public virtual void ReplaceWithRtf(NSRange range, NSData rtfData)
	{
		NSApplication.EnsureUIThread();
		if (rtfData == null)
		{
			throw new ArgumentNullException("rtfData");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRangeWithRTF_Handle, range, rtfData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRangeWithRTF_Handle, range, rtfData.Handle);
		}
	}

	[Export("replaceCharactersInRange:withRTFD:")]
	public virtual void ReplaceWithRtfd(NSRange range, NSData rtfdData)
	{
		NSApplication.EnsureUIThread();
		if (rtfdData == null)
		{
			throw new ArgumentNullException("rtfdData");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRangeWithRTFD_Handle, range, rtfdData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRangeWithRTFD_Handle, range, rtfdData.Handle);
		}
	}

	[Export("RTFFromRange:")]
	public virtual NSData RtfFromRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRTFFromRange_Handle, range));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRTFFromRange_Handle, range));
	}

	[Export("RTFDFromRange:")]
	public virtual NSData RtfdFromRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRTFDFromRange_Handle, range));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRTFDFromRange_Handle, range));
	}

	[Export("writeRTFDToFile:atomically:")]
	public virtual bool WriteRtfd(string path, bool atomically)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteRTFDToFileAtomically_Handle, arg, atomically) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteRTFDToFileAtomically_Handle, arg, atomically));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readRTFDFromFile:")]
	public virtual bool FromRtfdFile(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadRTFDFromFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selReadRTFDFromFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("scrollRangeToVisible:")]
	public virtual void ScrollRangeToVisible(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selScrollRangeToVisible_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selScrollRangeToVisible_Handle, range);
		}
	}

	[Export("setTextColor:range:")]
	public virtual void SetTextColor(NSColor color, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTextColorRange_Handle, color.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTextColorRange_Handle, color.Handle, range);
		}
	}

	[Export("setFont:range:")]
	public virtual void SetFont(NSFont font, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetFontRange_Handle, font.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetFontRange_Handle, font.Handle, range);
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

	[Export("copy:")]
	public virtual void Copy(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender.Handle);
		}
	}

	[Export("copyFont:")]
	public virtual void CopyFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyFont_Handle, sender.Handle);
		}
	}

	[Export("copyRuler:")]
	public virtual void CopyRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyRuler_Handle, sender.Handle);
		}
	}

	[Export("cut:")]
	public virtual void Cut(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	public virtual void Delete(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("paste:")]
	public virtual void Paste(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("pasteFont:")]
	public virtual void PasteFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteFont_Handle, sender.Handle);
		}
	}

	[Export("pasteRuler:")]
	public virtual void PasteRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteRuler_Handle, sender.Handle);
		}
	}

	[Export("selectAll:")]
	public virtual void SelectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("changeFont:")]
	public virtual void ChangeFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeFont_Handle, sender.Handle);
		}
	}

	[Export("alignLeft:")]
	public virtual void AlignLeft(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignLeft_Handle, sender.Handle);
		}
	}

	[Export("alignRight:")]
	public virtual void AlignRight(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignRight_Handle, sender.Handle);
		}
	}

	[Export("alignCenter:")]
	public virtual void AlignCenter(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignCenter_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignCenter_Handle, sender.Handle);
		}
	}

	[Export("subscript:")]
	public virtual void Subscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSubscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubscript_Handle, sender.Handle);
		}
	}

	[Export("superscript:")]
	public virtual void Superscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSuperscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSuperscript_Handle, sender.Handle);
		}
	}

	[Export("underline:")]
	public virtual void Underline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnderline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnderline_Handle, sender.Handle);
		}
	}

	[Export("unscript:")]
	public virtual void Unscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnscript_Handle, sender.Handle);
		}
	}

	[Export("showGuessPanel:")]
	public virtual void ShowGuessPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowGuessPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowGuessPanel_Handle, sender.Handle);
		}
	}

	[Export("checkSpelling:")]
	public virtual void CheckSpelling(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckSpelling_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckSpelling_Handle, sender.Handle);
		}
	}

	[Export("toggleRuler:")]
	public virtual void ToggleRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleRuler_Handle, sender.Handle);
		}
	}

	private _NSTextDelegate EnsureNSTextDelegate()
	{
		NSTextDelegate nSTextDelegate = Delegate;
		if (nSTextDelegate == null || !(nSTextDelegate is _NSTextDelegate))
		{
			nSTextDelegate = (Delegate = new _NSTextDelegate());
		}
		return (_NSTextDelegate)nSTextDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_BackgroundColor_var = null;
			__mt_Font_var = null;
			__mt_TextColor_var = null;
		}
	}
}

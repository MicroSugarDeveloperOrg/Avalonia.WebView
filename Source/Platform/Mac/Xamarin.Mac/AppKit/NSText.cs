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
	internal class _NSTextDelegate : NSObject, INSTextDelegate, INativeObject, IDisposable
	{
		internal EventHandler? textDidBeginEditing;

		internal EventHandler? textDidChange;

		internal EventHandler? textDidEndEditing;

		internal NSTextPredicate? textShouldBeginEditing;

		internal NSTextPredicate? textShouldEndEditing;

		public _NSTextDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("textDidBeginEditing:")]
		public void TextDidBeginEditing(NSNotification notification)
		{
			textDidBeginEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textDidChange:")]
		public void TextDidChange(NSNotification notification)
		{
			textDidChange?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textDidEndEditing:")]
		public void TextDidEndEditing(NSNotification notification)
		{
			textDidEndEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textShouldBeginEditing:")]
		public bool TextShouldBeginEditing(NSText textObject)
		{
			return textShouldBeginEditing?.Invoke(textObject) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("textShouldEndEditing:")]
		public bool TextShouldEndEditing(NSText textObject)
		{
			return textShouldEndEditing?.Invoke(textObject) ?? true;
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveDidBeginEditing(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginEditing(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndEditing(EventHandler<NSTextDidEndEditingEventArgs> handler)
		{
			EventHandler<NSTextDidEndEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextDidEndEditingEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndEditing(NSObject objectToObserve, EventHandler<NSTextDidEndEditingEventArgs> handler)
		{
			EventHandler<NSTextDidEndEditingEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextDidEndEditingEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRTFDFromRange_ = "RTFDFromRange:";

	private static readonly IntPtr selRTFDFromRange_Handle = Selector.GetHandle("RTFDFromRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRTFFromRange_ = "RTFFromRange:";

	private static readonly IntPtr selRTFFromRange_Handle = Selector.GetHandle("RTFFromRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignCenter_ = "alignCenter:";

	private static readonly IntPtr selAlignCenter_Handle = Selector.GetHandle("alignCenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignLeft_ = "alignLeft:";

	private static readonly IntPtr selAlignLeft_Handle = Selector.GetHandle("alignLeft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignRight_ = "alignRight:";

	private static readonly IntPtr selAlignRight_Handle = Selector.GetHandle("alignRight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseWritingDirection = "baseWritingDirection";

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeFont_ = "changeFont:";

	private static readonly IntPtr selChangeFont_Handle = Selector.GetHandle("changeFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpelling_ = "checkSpelling:";

	private static readonly IntPtr selCheckSpelling_Handle = Selector.GetHandle("checkSpelling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopy_ = "copy:";

	private static readonly IntPtr selCopy_Handle = Selector.GetHandle("copy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyFont_ = "copyFont:";

	private static readonly IntPtr selCopyFont_Handle = Selector.GetHandle("copyFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyRuler_ = "copyRuler:";

	private static readonly IntPtr selCopyRuler_Handle = Selector.GetHandle("copyRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCut_ = "cut:";

	private static readonly IntPtr selCut_Handle = Selector.GetHandle("cut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelete_ = "delete:";

	private static readonly IntPtr selDelete_Handle = Selector.GetHandle("delete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportsGraphics = "importsGraphics";

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFieldEditor = "isFieldEditor";

	private static readonly IntPtr selIsFieldEditorHandle = Selector.GetHandle("isFieldEditor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHorizontallyResizable = "isHorizontallyResizable";

	private static readonly IntPtr selIsHorizontallyResizableHandle = Selector.GetHandle("isHorizontallyResizable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRichText = "isRichText";

	private static readonly IntPtr selIsRichTextHandle = Selector.GetHandle("isRichText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRulerVisible = "isRulerVisible";

	private static readonly IntPtr selIsRulerVisibleHandle = Selector.GetHandle("isRulerVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectable = "isSelectable";

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVerticallyResizable = "isVerticallyResizable";

	private static readonly IntPtr selIsVerticallyResizableHandle = Selector.GetHandle("isVerticallyResizable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxSize = "maxSize";

	private static readonly IntPtr selMaxSizeHandle = Selector.GetHandle("maxSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinSize = "minSize";

	private static readonly IntPtr selMinSizeHandle = Selector.GetHandle("minSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaste_ = "paste:";

	private static readonly IntPtr selPaste_Handle = Selector.GetHandle("paste:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteFont_ = "pasteFont:";

	private static readonly IntPtr selPasteFont_Handle = Selector.GetHandle("pasteFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteRuler_ = "pasteRuler:";

	private static readonly IntPtr selPasteRuler_Handle = Selector.GetHandle("pasteRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadRTFDFromFile_ = "readRTFDFromFile:";

	private static readonly IntPtr selReadRTFDFromFile_Handle = Selector.GetHandle("readRTFDFromFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithRTF_ = "replaceCharactersInRange:withRTF:";

	private static readonly IntPtr selReplaceCharactersInRange_WithRTF_Handle = Selector.GetHandle("replaceCharactersInRange:withRTF:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithRTFD_ = "replaceCharactersInRange:withRTFD:";

	private static readonly IntPtr selReplaceCharactersInRange_WithRTFD_Handle = Selector.GetHandle("replaceCharactersInRange:withRTFD:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithString_ = "replaceCharactersInRange:withString:";

	private static readonly IntPtr selReplaceCharactersInRange_WithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRangeToVisible_ = "scrollRangeToVisible:";

	private static readonly IntPtr selScrollRangeToVisible_Handle = Selector.GetHandle("scrollRangeToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedRange = "selectedRange";

	private static readonly IntPtr selSelectedRangeHandle = Selector.GetHandle("selectedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_ = "setAlignment:";

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseWritingDirection_ = "setBaseWritingDirection:";

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEditable_ = "setEditable:";

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldEditor_ = "setFieldEditor:";

	private static readonly IntPtr selSetFieldEditor_Handle = Selector.GetHandle("setFieldEditor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_Range_ = "setFont:range:";

	private static readonly IntPtr selSetFont_Range_Handle = Selector.GetHandle("setFont:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontallyResizable_ = "setHorizontallyResizable:";

	private static readonly IntPtr selSetHorizontallyResizable_Handle = Selector.GetHandle("setHorizontallyResizable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImportsGraphics_ = "setImportsGraphics:";

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxSize_ = "setMaxSize:";

	private static readonly IntPtr selSetMaxSize_Handle = Selector.GetHandle("setMaxSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinSize_ = "setMinSize:";

	private static readonly IntPtr selSetMinSize_Handle = Selector.GetHandle("setMinSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRichText_ = "setRichText:";

	private static readonly IntPtr selSetRichText_Handle = Selector.GetHandle("setRichText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectable_ = "setSelectable:";

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedRange_ = "setSelectedRange:";

	private static readonly IntPtr selSetSelectedRange_Handle = Selector.GetHandle("setSelectedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ = "setString:";

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextColor_ = "setTextColor:";

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextColor_Range_ = "setTextColor:range:";

	private static readonly IntPtr selSetTextColor_Range_Handle = Selector.GetHandle("setTextColor:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFontPanel_ = "setUsesFontPanel:";

	private static readonly IntPtr selSetUsesFontPanel_Handle = Selector.GetHandle("setUsesFontPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticallyResizable_ = "setVerticallyResizable:";

	private static readonly IntPtr selSetVerticallyResizable_Handle = Selector.GetHandle("setVerticallyResizable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowGuessPanel_ = "showGuessPanel:";

	private static readonly IntPtr selShowGuessPanel_Handle = Selector.GetHandle("showGuessPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToFit = "sizeToFit";

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscript_ = "subscript:";

	private static readonly IntPtr selSubscript_Handle = Selector.GetHandle("subscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperscript_ = "superscript:";

	private static readonly IntPtr selSuperscript_Handle = Selector.GetHandle("superscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextColor = "textColor";

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleRuler_ = "toggleRuler:";

	private static readonly IntPtr selToggleRuler_Handle = Selector.GetHandle("toggleRuler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderline_ = "underline:";

	private static readonly IntPtr selUnderline_Handle = Selector.GetHandle("underline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnscript_ = "unscript:";

	private static readonly IntPtr selUnscript_Handle = Selector.GetHandle("unscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFontPanel = "usesFontPanel";

	private static readonly IntPtr selUsesFontPanelHandle = Selector.GetHandle("usesFontPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteRTFDToFile_Atomically_ = "writeRTFDToFile:atomically:";

	private static readonly IntPtr selWriteRTFDToFile_Atomically_Handle = Selector.GetHandle("writeRTFDToFile:atomically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginEditingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndEditingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovementUserInfoKey;

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
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
	public INSTextDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTextDelegate;
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
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FieldEditor
	{
		[Export("isFieldEditor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFieldEditorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFieldEditorHandle);
		}
		[Export("setFieldEditor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldEditor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldEditor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont Font
	{
		[Export("font", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle));
		}
		[Export("setFont:", ArgumentSemantic.Retain)]
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
	public virtual bool HorizontallyResizable
	{
		[Export("isHorizontallyResizable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontallyResizableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontallyResizableHandle);
		}
		[Export("setHorizontallyResizable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontallyResizable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontallyResizable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ImportsGraphics
	{
		[Export("importsGraphics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImportsGraphicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImportsGraphicsHandle);
		}
		[Export("setImportsGraphics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImportsGraphics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImportsGraphics_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRulerVisible
	{
		[Export("isRulerVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRulerVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRulerVisibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaxSize
	{
		[Export("maxSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxSizeHandle);
		}
		[Export("setMaxSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinSize
	{
		[Export("minSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinSizeHandle);
		}
		[Export("setMinSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RichText
	{
		[Export("isRichText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRichTextHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRichTextHandle);
		}
		[Export("setRichText:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRichText_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRichText_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange SelectedRange
	{
		[Export("selectedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selSelectedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selSelectedRangeHandle);
		}
		[Export("setSelectedRange:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetSelectedRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetSelectedRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor TextColor
	{
		[Export("textColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextColorHandle));
		}
		[Export("setTextColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesFontPanel
	{
		[Export("usesFontPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontPanelHandle);
		}
		[Export("setUsesFontPanel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Value
	{
		[Export("string")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VerticallyResizable
	{
		[Export("isVerticallyResizable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticallyResizableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticallyResizableHandle);
		}
		[Export("setVerticallyResizable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticallyResizable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticallyResizable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSTextDidBeginEditingNotification", "AppKit")]
	[Advice("Use NSText.Notifications.ObserveDidBeginEditing helper method instead.")]
	public static NSString DidBeginEditingNotification
	{
		get
		{
			if (_DidBeginEditingNotification == null)
			{
				_DidBeginEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextDidBeginEditingNotification");
			}
			return _DidBeginEditingNotification;
		}
	}

	[Field("NSTextDidChangeNotification", "AppKit")]
	[Advice("Use NSText.Notifications.ObserveDidChange helper method instead.")]
	public static NSString DidChangeNotification
	{
		get
		{
			if (_DidChangeNotification == null)
			{
				_DidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextDidChangeNotification");
			}
			return _DidChangeNotification;
		}
	}

	[Field("NSTextDidEndEditingNotification", "AppKit")]
	[Advice("Use NSText.Notifications.ObserveDidEndEditing helper method instead.")]
	public static NSString DidEndEditingNotification
	{
		get
		{
			if (_DidEndEditingNotification == null)
			{
				_DidEndEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextDidEndEditingNotification");
			}
			return _DidEndEditingNotification;
		}
	}

	[Field("NSTextMovementUserInfoKey", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString MovementUserInfoKey
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_MovementUserInfoKey == null)
			{
				_MovementUserInfoKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextMovementUserInfoKey");
			}
			return _MovementUserInfoKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSTextDelegate);

	public NSTextPredicate? TextShouldBeginEditing
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

	public NSTextPredicate? TextShouldEndEditing
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSText()
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
	public NSText(NSCoder coder)
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
	protected NSText(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSText(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSText(CGRect frameRect)
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

	[Export("alignCenter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignCenter(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignCenter_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignCenter_Handle, sender.Handle);
		}
	}

	[Export("alignLeft:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignLeft(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignLeft_Handle, sender.Handle);
		}
	}

	[Export("alignRight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AlignRight(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAlignRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAlignRight_Handle, sender.Handle);
		}
	}

	[Export("changeFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeFont_Handle, sender.Handle);
		}
	}

	[Export("checkSpelling:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckSpelling(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckSpelling_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckSpelling_Handle, sender.Handle);
		}
	}

	[Export("copy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Copy(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopy_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopy_Handle, sender.Handle);
		}
	}

	[Export("copyFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CopyFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyFont_Handle, sender.Handle);
		}
	}

	[Export("copyRuler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CopyRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCopyRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyRuler_Handle, sender.Handle);
		}
	}

	[Export("cut:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cut(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCut_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCut_Handle, sender.Handle);
		}
	}

	[Export("delete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Delete(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDelete_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelete_Handle, sender.Handle);
		}
	}

	[Export("readRTFDFromFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FromRtfdFile(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadRTFDFromFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selReadRTFDFromFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("paste:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Paste(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPaste_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPaste_Handle, sender.Handle);
		}
	}

	[Export("pasteFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteFont_Handle, sender.Handle);
		}
	}

	[Export("pasteRuler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PasteRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPasteRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteRuler_Handle, sender.Handle);
		}
	}

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Replace(NSRange range, string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceCharactersInRange:withRTF:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceWithRtf(NSRange range, NSData rtfData)
	{
		NSApplication.EnsureUIThread();
		if (rtfData == null)
		{
			throw new ArgumentNullException("rtfData");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithRTF_Handle, range, rtfData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithRTF_Handle, range, rtfData.Handle);
		}
	}

	[Export("replaceCharactersInRange:withRTFD:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceWithRtfd(NSRange range, NSData rtfdData)
	{
		NSApplication.EnsureUIThread();
		if (rtfdData == null)
		{
			throw new ArgumentNullException("rtfdData");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithRTFD_Handle, range, rtfdData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithRTFD_Handle, range, rtfdData.Handle);
		}
	}

	[Export("RTFFromRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData RtfFromRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRTFFromRange_Handle, range));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRTFFromRange_Handle, range));
	}

	[Export("RTFDFromRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData RtfdFromRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRTFDFromRange_Handle, range));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRTFDFromRange_Handle, range));
	}

	[Export("scrollRangeToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollRangeToVisible(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selScrollRangeToVisible_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selScrollRangeToVisible_Handle, range);
		}
	}

	[Export("selectAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender.Handle);
		}
	}

	[Export("setFont:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFont(NSFont font, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetFont_Range_Handle, font.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetFont_Range_Handle, font.Handle, range);
		}
	}

	[Export("setTextColor:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextColor(NSColor color, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTextColor_Range_Handle, color.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTextColor_Range_Handle, color.Handle, range);
		}
	}

	[Export("showGuessPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowGuessPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowGuessPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowGuessPanel_Handle, sender.Handle);
		}
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

	[Export("subscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Subscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSubscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubscript_Handle, sender.Handle);
		}
	}

	[Export("superscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Superscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSuperscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSuperscript_Handle, sender.Handle);
		}
	}

	[Export("toggleRuler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleRuler(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleRuler_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleRuler_Handle, sender.Handle);
		}
	}

	[Export("underline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Underline(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnderline_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnderline_Handle, sender.Handle);
		}
	}

	[Export("unscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unscript(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnscript_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnscript_Handle, sender.Handle);
		}
	}

	[Export("writeRTFDToFile:atomically:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRtfd(string path, bool atomically)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteRTFDToFile_Atomically_Handle, arg, atomically) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteRTFDToFile_Atomically_Handle, arg, atomically));
		NSString.ReleaseNative(arg);
		return result;
	}

	internal virtual _NSTextDelegate CreateInternalEventDelegateType()
	{
		return new _NSTextDelegate();
	}

	internal _NSTextDelegate EnsureNSTextDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTextDelegate nSTextDelegate = Delegate as _NSTextDelegate;
		if (nSTextDelegate == null)
		{
			nSTextDelegate = (_NSTextDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSTextDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

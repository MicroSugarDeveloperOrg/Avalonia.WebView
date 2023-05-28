using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTextField", true)]
public class NSTextField : NSControl, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityNavigableStaticText, INSAccessibilityStaticText, INSUserInterfaceValidations
{
	[Register]
	internal class _NSTextFieldDelegate : NSObject, INSTextFieldDelegate, INativeObject, IDisposable
	{
		internal EventHandler? changed;

		internal NSControlTextError? didFailToFormatString;

		internal EventHandler<NSControlTextErrorEventArgs>? didFailToValidatePartialString;

		internal NSControlCommand? doCommandBySelector;

		internal EventHandler? editingBegan;

		internal EventHandler? editingEnded;

		internal NSTextFieldGetCandidates? getCandidates;

		internal NSControlTextFilter? getCompletions;

		internal NSTextFieldTextCheckingResults? getTextCheckingResults;

		internal NSControlTextValidation? isValidObject;

		internal NSTextFieldSelectCandidate? shouldSelectCandidate;

		internal NSControlText? textShouldBeginEditing;

		internal NSControlText? textShouldEndEditing;

		public _NSTextFieldDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidChange:")]
		public void Changed(NSNotification notification)
		{
			changed?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("control:didFailToFormatString:errorDescription:")]
		public bool DidFailToFormatString(NSControl control, string str, string error)
		{
			return didFailToFormatString?.Invoke(control, str, error) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("control:didFailToValidatePartialString:errorDescription:")]
		public void DidFailToValidatePartialString(NSControl control, string str, string error)
		{
			EventHandler<NSControlTextErrorEventArgs> eventHandler = didFailToValidatePartialString;
			if (eventHandler != null)
			{
				NSControlTextErrorEventArgs e = new NSControlTextErrorEventArgs(str, error);
				eventHandler(control, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("control:textView:doCommandBySelector:")]
		public bool DoCommandBySelector(NSControl control, NSTextView textView, Selector commandSelector)
		{
			return doCommandBySelector?.Invoke(control, textView, commandSelector) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidBeginEditing:")]
		public void EditingBegan(NSNotification notification)
		{
			editingBegan?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("controlTextDidEndEditing:")]
		public void EditingEnded(NSNotification notification)
		{
			editingEnded?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textField:textView:candidatesForSelectedRange:")]
		public NSObject[] GetCandidates(NSTextField textField, NSTextView textView, NSRange selectedRange)
		{
			return getCandidates?.Invoke(textField, textView, selectedRange);
		}

		[Preserve(Conditional = true)]
		[Export("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		public string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			NSControlTextFilter nSControlTextFilter = getCompletions;
			if (nSControlTextFilter != null)
			{
				return nSControlTextFilter(control, textView, words, charRange, ref index);
			}
			return new string[0];
		}

		[Preserve(Conditional = true)]
		[Export("textField:textView:candidates:forSelectedRange:")]
		public NSTextCheckingResult[] GetTextCheckingResults(NSTextField textField, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			return getTextCheckingResults?.Invoke(textField, textView, candidates, selectedRange);
		}

		[Preserve(Conditional = true)]
		[Export("control:isValidObject:")]
		public bool IsValidObject(NSControl control, NSObject objectToValidate)
		{
			return isValidObject?.Invoke(control, objectToValidate) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("textField:textView:shouldSelectCandidateAtIndex:")]
		public bool ShouldSelectCandidate(NSTextField textField, NSTextView textView, nuint index)
		{
			return shouldSelectCandidate?.Invoke(textField, textView, index) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("control:textShouldBeginEditing:")]
		public bool TextShouldBeginEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldBeginEditing?.Invoke(control, fieldEditor) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("control:textShouldEndEditing:")]
		public bool TextShouldEndEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldEndEditing?.Invoke(control, fieldEditor) ?? true;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstResponder = "acceptsFirstResponder";

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributedStringForRange_ = "accessibilityAttributedStringForRange:";

	private static readonly IntPtr selAccessibilityAttributedStringForRange_Handle = Selector.GetHandle("accessibilityAttributedStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrameForRange_ = "accessibilityFrameForRange:";

	private static readonly IntPtr selAccessibilityFrameForRange_Handle = Selector.GetHandle("accessibilityFrameForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLineForIndex_ = "accessibilityLineForIndex:";

	private static readonly IntPtr selAccessibilityLineForIndex_Handle = Selector.GetHandle("accessibilityLineForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForLine_ = "accessibilityRangeForLine:";

	private static readonly IntPtr selAccessibilityRangeForLine_Handle = Selector.GetHandle("accessibilityRangeForLine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStringForRange_ = "accessibilityStringForRange:";

	private static readonly IntPtr selAccessibilityStringForRange_Handle = Selector.GetHandle("accessibilityStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCharacterRange = "accessibilityVisibleCharacterRange";

	private static readonly IntPtr selAccessibilityVisibleCharacterRangeHandle = Selector.GetHandle("accessibilityVisibleCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDefaultTighteningForTruncation = "allowsDefaultTighteningForTruncation";

	private static readonly IntPtr selAllowsDefaultTighteningForTruncationHandle = Selector.GetHandle("allowsDefaultTighteningForTruncation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEditingTextAttributes = "allowsEditingTextAttributes";

	private static readonly IntPtr selAllowsEditingTextAttributesHandle = Selector.GetHandle("allowsEditingTextAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezelStyle = "bezelStyle";

	private static readonly IntPtr selBezelStyleHandle = Selector.GetHandle("bezelStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportsGraphics = "importsGraphics";

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBezeled = "isBezeled";

	private static readonly IntPtr selIsBezeledHandle = Selector.GetHandle("isBezeled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBordered = "isBordered";

	private static readonly IntPtr selIsBorderedHandle = Selector.GetHandle("isBordered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditable = "isEditable";

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectable = "isSelectable";

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelWithAttributedString_ = "labelWithAttributedString:";

	private static readonly IntPtr selLabelWithAttributedString_Handle = Selector.GetHandle("labelWithAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelWithString_ = "labelWithString:";

	private static readonly IntPtr selLabelWithString_Handle = Selector.GetHandle("labelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumNumberOfLines = "maximumNumberOfLines";

	private static readonly IntPtr selMaximumNumberOfLinesHandle = Selector.GetHandle("maximumNumberOfLines");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderAttributedString = "placeholderAttributedString";

	private static readonly IntPtr selPlaceholderAttributedStringHandle = Selector.GetHandle("placeholderAttributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderString = "placeholderString";

	private static readonly IntPtr selPlaceholderStringHandle = Selector.GetHandle("placeholderString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMaxLayoutWidth = "preferredMaxLayoutWidth";

	private static readonly IntPtr selPreferredMaxLayoutWidthHandle = Selector.GetHandle("preferredMaxLayoutWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectText_ = "selectText:";

	private static readonly IntPtr selSelectText_Handle = Selector.GetHandle("selectText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsDefaultTighteningForTruncation_ = "setAllowsDefaultTighteningForTruncation:";

	private static readonly IntPtr selSetAllowsDefaultTighteningForTruncation_Handle = Selector.GetHandle("setAllowsDefaultTighteningForTruncation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEditingTextAttributes_ = "setAllowsEditingTextAttributes:";

	private static readonly IntPtr selSetAllowsEditingTextAttributes_Handle = Selector.GetHandle("setAllowsEditingTextAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezelStyle_ = "setBezelStyle:";

	private static readonly IntPtr selSetBezelStyle_Handle = Selector.GetHandle("setBezelStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezeled_ = "setBezeled:";

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBordered_ = "setBordered:";

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

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
	private const string selSetImportsGraphics_ = "setImportsGraphics:";

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumNumberOfLines_ = "setMaximumNumberOfLines:";

	private static readonly IntPtr selSetMaximumNumberOfLines_Handle = Selector.GetHandle("setMaximumNumberOfLines:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaceholderAttributedString_ = "setPlaceholderAttributedString:";

	private static readonly IntPtr selSetPlaceholderAttributedString_Handle = Selector.GetHandle("setPlaceholderAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaceholderString_ = "setPlaceholderString:";

	private static readonly IntPtr selSetPlaceholderString_Handle = Selector.GetHandle("setPlaceholderString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMaxLayoutWidth_ = "setPreferredMaxLayoutWidth:";

	private static readonly IntPtr selSetPreferredMaxLayoutWidth_Handle = Selector.GetHandle("setPreferredMaxLayoutWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectable_ = "setSelectable:";

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextColor_ = "setTextColor:";

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextColor = "textColor";

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidBeginEditing_ = "textDidBeginEditing:";

	private static readonly IntPtr selTextDidBeginEditing_Handle = Selector.GetHandle("textDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidChange_ = "textDidChange:";

	private static readonly IntPtr selTextDidChange_Handle = Selector.GetHandle("textDidChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextDidEndEditing_ = "textDidEndEditing:";

	private static readonly IntPtr selTextDidEndEditing_Handle = Selector.GetHandle("textDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextFieldWithString_ = "textFieldWithString:";

	private static readonly IntPtr selTextFieldWithString_Handle = Selector.GetHandle("textFieldWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextShouldBeginEditing_ = "textShouldBeginEditing:";

	private static readonly IntPtr selTextShouldBeginEditing_Handle = Selector.GetHandle("textShouldBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextShouldEndEditing_ = "textShouldEndEditing:";

	private static readonly IntPtr selTextShouldEndEditing_Handle = Selector.GetHandle("textShouldEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWrappingLabelWithString_ = "wrappingLabelWithString:";

	private static readonly IntPtr selWrappingLabelWithString_Handle = Selector.GetHandle("wrappingLabelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public new NSTextFieldCell Cell
	{
		get
		{
			return (NSTextFieldCell)base.Cell;
		}
		set
		{
			base.Cell = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSRange AccessibilityVisibleCharacterRange
	{
		[Export("accessibilityVisibleCharacterRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityVisibleCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCharacterRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AllowsDefaultTighteningForTruncation
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsDefaultTighteningForTruncation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDefaultTighteningForTruncationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDefaultTighteningForTruncationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsDefaultTighteningForTruncation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDefaultTighteningForTruncation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDefaultTighteningForTruncation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsEditingTextAttributes
	{
		[Export("allowsEditingTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEditingTextAttributesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEditingTextAttributesHandle);
		}
		[Export("setAllowsEditingTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEditingTextAttributes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEditingTextAttributes_Handle, value);
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
	public virtual NSTextFieldBezelStyle BezelStyle
	{
		[Export("bezelStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextFieldBezelStyle)Messaging.UInt64_objc_msgSend(base.Handle, selBezelStyleHandle);
			}
			return (NSTextFieldBezelStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBezelStyleHandle);
		}
		[Export("setBezelStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBezelStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBezelStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bezeled
	{
		[Export("isBezeled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBezeledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBezeledHandle);
		}
		[Export("setBezeled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bordered
	{
		[Export("isBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBorderedHandle);
		}
		[Export("setBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSTextFieldDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTextFieldDelegate;
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
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nint MaximumNumberOfLines
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("maximumNumberOfLines", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumNumberOfLinesHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfLinesHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMaximumNumberOfLines:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumNumberOfLines_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumNumberOfLines_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAttributedString PlaceholderAttributedString
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("placeholderAttributedString", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderAttributedStringHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderAttributedStringHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPlaceholderAttributedString:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string PlaceholderString
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("placeholderString", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderStringHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPlaceholderString:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PreferredMaxLayoutWidth
	{
		[Export("preferredMaxLayoutWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPreferredMaxLayoutWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPreferredMaxLayoutWidthHandle);
		}
		[Export("setPreferredMaxLayoutWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPreferredMaxLayoutWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPreferredMaxLayoutWidth_Handle, value);
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSTextFieldDelegate);

	public NSControlTextError? DidFailToFormatString
	{
		get
		{
			return EnsureNSTextFieldDelegate().didFailToFormatString;
		}
		set
		{
			EnsureNSTextFieldDelegate().didFailToFormatString = value;
		}
	}

	public NSControlCommand? DoCommandBySelector
	{
		get
		{
			return EnsureNSTextFieldDelegate().doCommandBySelector;
		}
		set
		{
			EnsureNSTextFieldDelegate().doCommandBySelector = value;
		}
	}

	public NSTextFieldGetCandidates? GetCandidates
	{
		get
		{
			return EnsureNSTextFieldDelegate().getCandidates;
		}
		set
		{
			EnsureNSTextFieldDelegate().getCandidates = value;
		}
	}

	public NSControlTextFilter? GetCompletions
	{
		get
		{
			return EnsureNSTextFieldDelegate().getCompletions;
		}
		set
		{
			EnsureNSTextFieldDelegate().getCompletions = value;
		}
	}

	public NSTextFieldTextCheckingResults? GetTextCheckingResults
	{
		get
		{
			return EnsureNSTextFieldDelegate().getTextCheckingResults;
		}
		set
		{
			EnsureNSTextFieldDelegate().getTextCheckingResults = value;
		}
	}

	public NSControlTextValidation? IsValidObject
	{
		get
		{
			return EnsureNSTextFieldDelegate().isValidObject;
		}
		set
		{
			EnsureNSTextFieldDelegate().isValidObject = value;
		}
	}

	public NSTextFieldSelectCandidate? ShouldSelectCandidate
	{
		get
		{
			return EnsureNSTextFieldDelegate().shouldSelectCandidate;
		}
		set
		{
			EnsureNSTextFieldDelegate().shouldSelectCandidate = value;
		}
	}

	public NSControlText? TextShouldBeginEditing
	{
		get
		{
			return EnsureNSTextFieldDelegate().textShouldBeginEditing;
		}
		set
		{
			EnsureNSTextFieldDelegate().textShouldBeginEditing = value;
		}
	}

	public NSControlText? TextShouldEndEditing
	{
		get
		{
			return EnsureNSTextFieldDelegate().textShouldEndEditing;
		}
		set
		{
			EnsureNSTextFieldDelegate().textShouldEndEditing = value;
		}
	}

	public event EventHandler Changed
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.changed = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.changed, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.changed = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.changed, value);
		}
	}

	public event EventHandler<NSControlTextErrorEventArgs> DidFailToValidatePartialString
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Combine(nSTextFieldDelegate.didFailToValidatePartialString, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Remove(nSTextFieldDelegate.didFailToValidatePartialString, value);
		}
	}

	public event EventHandler EditingBegan
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingBegan = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.editingBegan, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingBegan = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.editingBegan, value);
		}
	}

	public event EventHandler EditingEnded
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingEnded = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.editingEnded, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingEnded = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.editingEnded, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextField()
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
	public NSTextField(NSCoder coder)
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
	protected NSTextField(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextField(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextField(CGRect frameRect)
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

	[Export("labelWithString:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextField CreateLabel(string stringValue)
	{
		NSApplication.EnsureUIThread();
		if (stringValue == null)
		{
			throw new ArgumentNullException("stringValue");
		}
		IntPtr arg = NSString.CreateNative(stringValue);
		NSTextField nSObject = Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLabelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("labelWithAttributedString:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextField CreateLabel(NSAttributedString attributedStringValue)
	{
		NSApplication.EnsureUIThread();
		if (attributedStringValue == null)
		{
			throw new ArgumentNullException("attributedStringValue");
		}
		return Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLabelWithAttributedString_Handle, attributedStringValue.Handle));
	}

	[Export("textFieldWithString:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextField CreateTextField(string? stringValue)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(stringValue);
		NSTextField nSObject = Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextFieldWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("wrappingLabelWithString:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextField CreateWrappingLabel(string stringValue)
	{
		NSApplication.EnsureUIThread();
		if (stringValue == null)
		{
			throw new ArgumentNullException("stringValue");
		}
		IntPtr arg = NSString.CreateNative(stringValue);
		NSTextField nSObject = Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selWrappingLabelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBeginEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidBeginEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidBeginEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChange(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidChange_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidChange_Handle, notification.Handle);
		}
	}

	[Export("textDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidEndEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidEndEditing_Handle, notification.Handle);
		}
	}

	[Export("accessibilityAttributedStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityAttributedStringForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityAttributedStringForRange_Handle, range));
	}

	[Export("accessibilityFrameForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGRect GetAccessibilityFrame(NSRange range)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange(out retval, base.Handle, selAccessibilityFrameForRange_Handle, range);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange(out retval, base.SuperHandle, selAccessibilityFrameForRange_Handle, range);
		}
		return retval;
	}

	[Export("accessibilityLineForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selAccessibilityLineForIndex_Handle, index);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityLineForIndex_Handle, index);
	}

	[Export("accessibilityRangeForLine:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSRange GetAccessibilityRangeForLine(nint lineNumber)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForLine_Handle, lineNumber);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForLine_Handle, lineNumber);
	}

	[Export("accessibilityStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityStringForRange_Handle, range));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityStringForRange_Handle, range));
	}

	[Export("selectText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectText_Handle, sender.Handle);
		}
	}

	[Export("textShouldBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeginEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldBeginEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldBeginEditing_Handle, textObject.Handle);
	}

	[Export("textShouldEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEndEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldEndEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldEndEditing_Handle, textObject.Handle);
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	internal virtual _NSTextFieldDelegate CreateInternalEventDelegateType()
	{
		return new _NSTextFieldDelegate();
	}

	internal _NSTextFieldDelegate EnsureNSTextFieldDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTextFieldDelegate nSTextFieldDelegate = Delegate as _NSTextFieldDelegate;
		if (nSTextFieldDelegate == null)
		{
			nSTextFieldDelegate = (_NSTextFieldDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSTextFieldDelegate;
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

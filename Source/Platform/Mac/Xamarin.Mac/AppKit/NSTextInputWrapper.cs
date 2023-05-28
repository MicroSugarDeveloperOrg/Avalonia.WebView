using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

internal sealed class NSTextInputWrapper : BaseWrapper, INSTextInput, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool HasMarkedText
	{
		[Export("hasMarkedText")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("hasMarkedText"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint ConversationIdentifier
	{
		[Export("conversationIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("conversationIdentifier"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange MarkedRange
	{
		[Export("markedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("markedRange"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange SelectedRange
	{
		[Export("selectedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("selectedRange"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSString[] ValidAttributesForMarkedText
	{
		[Export("validAttributesForMarkedText")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("validAttributesForMarkedText")));
		}
	}

	[Preserve(Conditional = true)]
	public NSTextInputWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("insertText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InsertText(NSObject insertString)
	{
		NSApplication.EnsureUIThread();
		if (insertString == null)
		{
			throw new ArgumentNullException("insertString");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("insertText:"), insertString.Handle);
	}

	[Export("setMarkedText:selectedRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetMarkedText(NSObject @string, NSRange selRange)
	{
		NSApplication.EnsureUIThread();
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setMarkedText:selectedRange:"), @string.Handle, selRange);
	}

	[Export("unmarkText")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void UnmarkText()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("unmarkText"));
	}

	[Export("attributedSubstringFromRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString GetAttributedSubstring(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("attributedSubstringFromRange:"), range));
	}

	[Export("firstRectForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetFirstRectForCharacterRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_NSRange(out var retval, base.Handle, Selector.GetHandle("firstRectForCharacterRange:"), range);
		return retval;
	}

	[Export("characterIndexForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetCharacterIndex(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nuint_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("characterIndexForPoint:"), point);
	}
}

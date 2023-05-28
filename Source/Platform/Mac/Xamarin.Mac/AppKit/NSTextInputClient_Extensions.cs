using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTextInputClient_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertText(this INSTextInputClient This, NSObject text, NSRange replacementRange)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("insertText:replacementRange:"), text.Handle, replacementRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetMarkedText(this INSTextInputClient This, NSObject text, NSRange selectedRange, NSRange replacementRange)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange_NSRange(This.Handle, Selector.GetHandle("setMarkedText:selectedRange:replacementRange:"), text.Handle, selectedRange, replacementRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnmarkText(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("unmarkText"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString GetAttributedSubstring(this INSTextInputClient This, NSRange proposedRange, out NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange_out_NSRange(This.Handle, Selector.GetHandle("attributedSubstringForProposedRange:actualRange:"), proposedRange, out actualRange));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetFirstRect(this INSTextInputClient This, NSRange characterRange, out NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_NSRange_out_NSRange(out var retval, This.Handle, Selector.GetHandle("firstRectForCharacterRange:actualRange:"), characterRange, out actualRange);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCharacterIndex(this INSTextInputClient This, CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nuint_objc_msgSend_CGPoint(This.Handle, Selector.GetHandle("characterIndexForPoint:"), point);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetFractionOfDistanceThroughGlyph(this INSTextInputClient This, CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nfloat_objc_msgSend_CGPoint(This.Handle, Selector.GetHandle("fractionOfDistanceThroughGlyphForPoint:"), point);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetBaselineDelta(this INSTextInputClient This, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nfloat_objc_msgSend_nuint(This.Handle, Selector.GetHandle("baselineDeltaForCharacterAtIndex:"), charIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DrawsVertically(this INSTextInputClient This, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend_nuint(This.Handle, Selector.GetHandle("drawsVerticallyForCharacterAtIndex:"), charIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRange GetSelectedRange(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend(This.Handle, Selector.GetHandle("selectedRange"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRange GetMarkedRange(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend(This.Handle, Selector.GetHandle("markedRange"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHasMarkedText(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("hasMarkedText"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString[] GetValidAttributesForMarkedText(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("validAttributesForMarkedText")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString GetAttributedString(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("attributedString")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindowLevel GetWindowLevel(this INSTextInputClient This)
	{
		NSApplication.EnsureUIThread();
		return (NSWindowLevel)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("windowLevel"));
	}
}

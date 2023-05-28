using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSLayoutManagerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LayoutInvalidated(this INSLayoutManagerDelegate This, NSLayoutManager sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("layoutManagerDidInvalidateLayout:"), sender.Handle);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LayoutCompleted(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer textContainer, bool layoutFinishedFlag)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("layoutManager:didCompleteLayoutForTextContainer:atEnd:"), layoutManager.Handle, textContainer.Handle, layoutFinishedFlag);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary ShouldUseTemporaryAttributes(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSDictionary temporaryAttributes, bool drawingToScreen, nint charIndex, IntPtr effectiveCharRange)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (temporaryAttributes == null)
		{
			throw new ArgumentNullException("temporaryAttributes");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_nint_IntPtr(This.Handle, Selector.GetHandle("layoutManager:shouldUseTemporaryAttributes:forDrawingToScreen:atCharacterIndex:effectiveRange:"), layoutManager.Handle, temporaryAttributes.Handle, drawingToScreen, charIndex, effectiveCharRange));
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint ShouldGenerateGlyphs(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, IntPtr glyphBuffer, IntPtr props, IntPtr charIndexes, NSFont aFont, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (aFont == null)
		{
			throw new ArgumentNullException("aFont");
		}
		return Messaging.nuint_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_NSRange(This.Handle, Selector.GetHandle("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:"), layoutManager.Handle, glyphBuffer, props, charIndexes, aFont.Handle, glyphRange);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetLineSpacingAfterGlyph(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nuint_CGRect(This.Handle, Selector.GetHandle("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager.Handle, glyphIndex, rect);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetParagraphSpacingBeforeGlyph(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nuint_CGRect(This.Handle, Selector.GetHandle("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager.Handle, glyphIndex, rect);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetParagraphSpacingAfterGlyph(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nuint_CGRect(This.Handle, Selector.GetHandle("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager.Handle, glyphIndex, rect);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSControlCharacterAction ShouldUseAction(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSControlCharacterAction action, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return (NSControlCharacterAction)Messaging.Int64_objc_msgSend_IntPtr_Int64_nuint(This.Handle, Selector.GetHandle("layoutManager:shouldUseAction:forControlCharacterAtIndex:"), layoutManager.Handle, (long)action, charIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldBreakLineByWordBeforeCharacter(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:"), layoutManager.Handle, charIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldBreakLineByHyphenatingBeforeCharacter(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:"), layoutManager.Handle, charIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetBoundingBox(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_nuint_IntPtr_CGRect_CGPoint_nuint(out var retval, This.Handle, Selector.GetHandle("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), layoutManager.Handle, glyphIndex, textContainer.Handle, proposedRect, glyphPosition, charIndex);
		return retval;
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeGeometry(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGSize(This.Handle, Selector.GetHandle("layoutManager:textContainer:didChangeGeometryFromSize:"), layoutManager.Handle, textContainer.Handle, oldSize);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSetLineFragmentRect(this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		return Messaging.bool_objc_msgSend_IntPtr_ref_CGRect_ref_CGRect_ref_nfloat_IntPtr_NSRange(This.Handle, Selector.GetHandle("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:"), layoutManager.Handle, ref lineFragmentRect, ref lineFragmentUsedRect, ref baselineOffset, textContainer.Handle, glyphRange);
	}
}

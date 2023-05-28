using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSLayoutManagerDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class NSLayoutManagerDelegate : NSObject, INSLayoutManagerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutManagerDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSLayoutManagerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutManagerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("layoutManager:textContainer:didChangeGeometryFromSize:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeGeometry(NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundingBox(NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetLineSpacingAfterGlyph(NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetParagraphSpacingAfterGlyph(NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetParagraphSpacingBeforeGlyph(NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:didCompleteLayoutForTextContainer:atEnd:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutCompleted(NSLayoutManager layoutManager, NSTextContainer textContainer, bool layoutFinishedFlag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManagerDidInvalidateLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutInvalidated(NSLayoutManager sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBreakLineByHyphenatingBeforeCharacter(NSLayoutManager layoutManager, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBreakLineByWordBeforeCharacter(NSLayoutManager layoutManager, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ShouldGenerateGlyphs(NSLayoutManager layoutManager, IntPtr glyphBuffer, IntPtr props, IntPtr charIndexes, NSFont aFont, NSRange glyphRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSetLineFragmentRect(NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldUseAction:forControlCharacterAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSControlCharacterAction ShouldUseAction(NSLayoutManager layoutManager, NSControlCharacterAction action, nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldUseTemporaryAttributes:forDrawingToScreen:atCharacterIndex:effectiveRange:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ShouldUseTemporaryAttributes(NSLayoutManager layoutManager, NSDictionary temporaryAttributes, bool drawingToScreen, nint charIndex, IntPtr effectiveCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

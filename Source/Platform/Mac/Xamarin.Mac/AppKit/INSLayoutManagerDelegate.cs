using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSLayoutManagerDelegate", WrapperType = typeof(NSLayoutManagerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LayoutInvalidated", Selector = "layoutManagerDidInvalidateLayout:", ParameterType = new Type[] { typeof(NSLayoutManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LayoutCompleted", Selector = "layoutManager:didCompleteLayoutForTextContainer:atEnd:", ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(NSTextContainer),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUseTemporaryAttributes", Selector = "layoutManager:shouldUseTemporaryAttributes:forDrawingToScreen:atCharacterIndex:effectiveRange:", ReturnType = typeof(NSDictionary), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(NSDictionary),
	typeof(bool),
	typeof(nint),
	typeof(IntPtr)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGenerateGlyphs", Selector = "layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:", ReturnType = typeof(nuint), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(IntPtr),
	typeof(IntPtr),
	typeof(IntPtr),
	typeof(NSFont),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLineSpacingAfterGlyph", Selector = "layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParagraphSpacingBeforeGlyph", Selector = "layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParagraphSpacingAfterGlyph", Selector = "layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUseAction", Selector = "layoutManager:shouldUseAction:forControlCharacterAtIndex:", ReturnType = typeof(NSControlCharacterAction), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(NSControlCharacterAction),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBreakLineByWordBeforeCharacter", Selector = "layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBreakLineByHyphenatingBeforeCharacter", Selector = "layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBoundingBox", Selector = "layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(nuint),
	typeof(NSTextContainer),
	typeof(CGRect),
	typeof(CGPoint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeGeometry", Selector = "layoutManager:textContainer:didChangeGeometryFromSize:", ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(NSTextContainer),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSetLineFragmentRect", Selector = "layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSLayoutManager),
	typeof(CGRect),
	typeof(CGRect),
	typeof(nfloat),
	typeof(NSTextContainer),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true, true, true, false, false })]
public interface INSLayoutManagerDelegate : INativeObject, IDisposable
{
}

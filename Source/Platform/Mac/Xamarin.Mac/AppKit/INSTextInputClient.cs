using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTextInputClient", WrapperType = typeof(NSTextInputClientWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertText", Selector = "insertText:replacementRange:", ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMarkedText", Selector = "setMarkedText:selectedRange:replacementRange:", ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnmarkText", Selector = "unmarkText")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAttributedSubstring", Selector = "attributedSubstringForProposedRange:actualRange:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFirstRect", Selector = "firstRectForCharacterRange:actualRange:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCharacterIndex", Selector = "characterIndexForPoint:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFractionOfDistanceThroughGlyph", Selector = "fractionOfDistanceThroughGlyphForPoint:", ReturnType = typeof(nfloat), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBaselineDelta", Selector = "baselineDeltaForCharacterAtIndex:", ReturnType = typeof(nfloat), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawsVertically", Selector = "drawsVerticallyForCharacterAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectedRange", Selector = "selectedRange", PropertyType = typeof(NSRange), GetterSelector = "selectedRange", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MarkedRange", Selector = "markedRange", PropertyType = typeof(NSRange), GetterSelector = "markedRange", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasMarkedText", Selector = "hasMarkedText", PropertyType = typeof(bool), GetterSelector = "hasMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ValidAttributesForMarkedText", Selector = "validAttributesForMarkedText", PropertyType = typeof(NSString[]), GetterSelector = "validAttributesForMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AttributedString", Selector = "attributedString", PropertyType = typeof(NSAttributedString), GetterSelector = "attributedString", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "WindowLevel", Selector = "windowLevel", PropertyType = typeof(NSWindowLevel), GetterSelector = "windowLevel", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSTextInputClient : INativeObject, IDisposable
{
}

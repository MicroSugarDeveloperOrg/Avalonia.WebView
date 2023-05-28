using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTextInput", WrapperType = typeof(NSTextInputWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertText", Selector = "insertText:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMarkedText", Selector = "setMarkedText:selectedRange:", ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnmarkText", Selector = "unmarkText")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttributedSubstring", Selector = "attributedSubstringFromRange:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFirstRectForCharacterRange", Selector = "firstRectForCharacterRange:", ReturnType = typeof(CGRect), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCharacterIndex", Selector = "characterIndexForPoint:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "HasMarkedText", Selector = "hasMarkedText", PropertyType = typeof(bool), GetterSelector = "hasMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ConversationIdentifier", Selector = "conversationIdentifier", PropertyType = typeof(nint), GetterSelector = "conversationIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedRange", Selector = "markedRange", PropertyType = typeof(NSRange), GetterSelector = "markedRange", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedRange", Selector = "selectedRange", PropertyType = typeof(NSRange), GetterSelector = "selectedRange", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ValidAttributesForMarkedText", Selector = "validAttributesForMarkedText", PropertyType = typeof(NSString[]), GetterSelector = "validAttributesForMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSTextInput : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool HasMarkedText
	{
		[Export("hasMarkedText")]
		get;
	}

	[Preserve(Conditional = true)]
	nint ConversationIdentifier
	{
		[Export("conversationIdentifier")]
		get;
	}

	[Preserve(Conditional = true)]
	NSRange MarkedRange
	{
		[Export("markedRange")]
		get;
	}

	[Preserve(Conditional = true)]
	NSRange SelectedRange
	{
		[Export("selectedRange")]
		get;
	}

	[Preserve(Conditional = true)]
	NSString[] ValidAttributesForMarkedText
	{
		[Export("validAttributesForMarkedText")]
		get;
	}

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("insertText:")]
	[Preserve(Conditional = true)]
	void InsertText(NSObject insertString);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setMarkedText:selectedRange:")]
	[Preserve(Conditional = true)]
	void SetMarkedText(NSObject @string, NSRange selRange);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("unmarkText")]
	[Preserve(Conditional = true)]
	void UnmarkText();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("attributedSubstringFromRange:")]
	[Preserve(Conditional = true)]
	NSAttributedString GetAttributedSubstring(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("firstRectForCharacterRange:")]
	[Preserve(Conditional = true)]
	CGRect GetFirstRectForCharacterRange(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("characterIndexForPoint:")]
	[Preserve(Conditional = true)]
	nuint GetCharacterIndex(CGPoint point);
}

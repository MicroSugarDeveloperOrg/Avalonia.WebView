using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSTextCheckingClient", WrapperType = typeof(NSTextCheckingClientWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnnotatedSubstring", Selector = "annotatedSubstringForProposedRange:actualRange:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAnnotations", Selector = "setAnnotations:range:", ParameterType = new Type[]
{
	typeof(NSDictionary<NSString, NSString>),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnnotations", Selector = "addAnnotations:range:", ParameterType = new Type[]
{
	typeof(NSDictionary<NSString, NSString>),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnnotation", Selector = "removeAnnotation:range:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceCharacters", Selector = "replaceCharactersInRange:withAnnotatedString:", ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(NSAttributedString)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectAndShow", Selector = "selectAndShowRange:", ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "viewForRange:firstRect:actualRange:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(CGRect),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true, true })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CandidateListTouchBarItem", Selector = "candidateListTouchBarItem", PropertyType = typeof(NSCandidateListTouchBarItem), GetterSelector = "candidateListTouchBarItem", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSTextCheckingClient : INativeObject, IDisposable, INSTextInputClient, INSTextInputTraits
{
	[Preserve(Conditional = true)]
	NSCandidateListTouchBarItem? CandidateListTouchBarItem
	{
		[Export("candidateListTouchBarItem")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("annotatedSubstringForProposedRange:actualRange:")]
	[Preserve(Conditional = true)]
	NSAttributedString? GetAnnotatedSubstring(NSRange range, ref NSRange actualRange);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setAnnotations:range:")]
	[Preserve(Conditional = true)]
	void SetAnnotations(NSDictionary<NSString, NSString> annotations, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addAnnotations:range:")]
	[Preserve(Conditional = true)]
	void AddAnnotations(NSDictionary<NSString, NSString> annotations, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeAnnotation:range:")]
	[Preserve(Conditional = true)]
	void RemoveAnnotation(string annotationName, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("replaceCharactersInRange:withAnnotatedString:")]
	[Preserve(Conditional = true)]
	void ReplaceCharacters(NSRange range, NSAttributedString annotatedString);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("selectAndShowRange:")]
	[Preserve(Conditional = true)]
	void SelectAndShow(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("viewForRange:firstRect:actualRange:")]
	[Preserve(Conditional = true)]
	NSView? GetView(NSRange range, ref CGRect firstRect, ref NSRange actualRange);
}

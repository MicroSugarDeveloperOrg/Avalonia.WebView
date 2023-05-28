using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTextFinderClient", WrapperType = typeof(NSTextFinderClientWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StringAtIndexeffectiveRangeendsWithSearchBoundary", Selector = "stringAtIndex:effectiveRange:endsWithSearchBoundary:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(NSRange),
	typeof(bool)
}, ParameterByRef = new bool[] { false, true, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StringLength", Selector = "stringLength", ReturnType = typeof(nuint))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ScrollRangeToVisible", Selector = "scrollRangeToVisible:", ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldReplaceCharactersInRangeswithStrings", Selector = "shouldReplaceCharactersInRanges:withStrings:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSArray),
	typeof(NSArray)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceCharactersInRangewithString", Selector = "replaceCharactersInRange:withString:", ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReplaceCharacters", Selector = "didReplaceCharacters")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContentViewAtIndexeffectiveCharacterRange", Selector = "contentViewAtIndex:effectiveCharacterRange:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RectsForCharacterRange", Selector = "rectsForCharacterRange:", ReturnType = typeof(NSArray), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawCharactersInRangeforContentView", Selector = "drawCharactersInRange:forContentView:", ParameterType = new Type[]
{
	typeof(NSRange),
	typeof(NSView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowsMultipleSelection", Selector = "allowsMultipleSelection", PropertyType = typeof(bool), GetterSelector = "allowsMultipleSelection", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Editable", Selector = "editable", PropertyType = typeof(bool), GetterSelector = "isEditable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "String", Selector = "string", PropertyType = typeof(string), GetterSelector = "string", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FirstSelectedRange", Selector = "firstSelectedRange", PropertyType = typeof(NSRange), GetterSelector = "firstSelectedRange", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedRanges", Selector = "selectedRanges", PropertyType = typeof(NSArray), GetterSelector = "selectedRanges", SetterSelector = "setSelectedRanges:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "VisibleCharacterRanges", Selector = "visibleCharacterRanges", PropertyType = typeof(NSArray), GetterSelector = "visibleCharacterRanges", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Selectable", Selector = "selectable", PropertyType = typeof(bool), GetterSelector = "isSelectable", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSTextFinderClient : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get;
	}

	[Preserve(Conditional = true)]
	bool Editable
	{
		[Export("isEditable")]
		get;
	}

	[Preserve(Conditional = true)]
	string String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get;
	}

	[Preserve(Conditional = true)]
	NSRange FirstSelectedRange
	{
		[Export("firstSelectedRange")]
		get;
	}

	[Preserve(Conditional = true)]
	NSArray SelectedRanges
	{
		[Export("selectedRanges", ArgumentSemantic.Copy)]
		get;
		[Export("setSelectedRanges:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSArray VisibleCharacterRanges
	{
		[Export("visibleCharacterRanges", ArgumentSemantic.Copy)]
		get;
	}

	[Preserve(Conditional = true)]
	bool Selectable
	{
		[Export("isSelectable")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("stringAtIndex:effectiveRange:endsWithSearchBoundary:")]
	[Preserve(Conditional = true)]
	string StringAtIndexeffectiveRangeendsWithSearchBoundary(nuint characterIndex, ref NSRange outRange, bool outFlag);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("stringLength")]
	[Preserve(Conditional = true)]
	nuint StringLength();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("scrollRangeToVisible:")]
	[Preserve(Conditional = true)]
	void ScrollRangeToVisible(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("shouldReplaceCharactersInRanges:withStrings:")]
	[Preserve(Conditional = true)]
	bool ShouldReplaceCharactersInRangeswithStrings(NSArray ranges, NSArray strings);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("replaceCharactersInRange:withString:")]
	[Preserve(Conditional = true)]
	void ReplaceCharactersInRangewithString(NSRange range, string str);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didReplaceCharacters")]
	[Preserve(Conditional = true)]
	void DidReplaceCharacters();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("contentViewAtIndex:effectiveCharacterRange:")]
	[Preserve(Conditional = true)]
	NSView ContentViewAtIndexeffectiveCharacterRange(nuint index, ref NSRange outRange);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("rectsForCharacterRange:")]
	[Preserve(Conditional = true)]
	NSArray RectsForCharacterRange(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawCharactersInRange:forContentView:")]
	[Preserve(Conditional = true)]
	void DrawCharactersInRangeforContentView(NSRange range, NSView view);
}

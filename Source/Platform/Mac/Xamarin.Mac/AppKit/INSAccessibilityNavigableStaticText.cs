using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityNavigableStaticText", WrapperType = typeof(NSAccessibilityNavigableStaticTextWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityString", Selector = "accessibilityStringForRange:", ReturnType = typeof(string), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLine", Selector = "accessibilityLineForIndex:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeForLine", Selector = "accessibilityRangeForLine:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityFrame", Selector = "accessibilityFrameForRange:", ReturnType = typeof(CGRect), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
public interface INSAccessibilityNavigableStaticText : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityStaticText
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityStringForRange:")]
	[Preserve(Conditional = true)]
	string? GetAccessibilityString(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityLineForIndex:")]
	[Preserve(Conditional = true)]
	nint GetAccessibilityLine(nint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityRangeForLine:")]
	[Preserve(Conditional = true)]
	NSRange GetAccessibilityRangeForLine(nint lineNumber);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityFrameForRange:")]
	[Preserve(Conditional = true)]
	CGRect GetAccessibilityFrame(NSRange range);
}

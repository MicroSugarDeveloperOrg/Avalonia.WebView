using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityElementLoading", WrapperType = typeof(NSAccessibilityElementLoadingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityElement", Selector = "accessibilityElementWithToken:", ReturnType = typeof(NSAccessibilityElement), ParameterType = new Type[] { typeof(INSSecureCoding) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeInTargetElement", Selector = "accessibilityRangeInTargetElementWithToken:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(INSSecureCoding) }, ParameterByRef = new bool[] { false })]
public interface INSAccessibilityElementLoading : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityElementWithToken:")]
	[Preserve(Conditional = true)]
	NSAccessibilityElement? GetAccessibilityElement(INSSecureCoding token);
}

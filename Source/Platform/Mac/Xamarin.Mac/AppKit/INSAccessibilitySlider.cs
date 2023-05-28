using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilitySlider", WrapperType = typeof(NSAccessibilitySliderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformIncrement", Selector = "accessibilityPerformIncrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDecrement", Selector = "accessibilityPerformDecrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityValue", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilitySlider : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformIncrement")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformIncrement();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformDecrement")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformDecrement();
}

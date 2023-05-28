using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityButton", WrapperType = typeof(NSAccessibilityButtonWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformPress", Selector = "accessibilityPerformPress", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityButton : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformPress")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformPress();
}

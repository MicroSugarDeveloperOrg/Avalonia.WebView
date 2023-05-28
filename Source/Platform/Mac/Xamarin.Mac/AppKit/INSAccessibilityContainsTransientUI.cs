using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityContainsTransientUI", WrapperType = typeof(NSAccessibilityContainsTransientUIWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowAlternateUI", Selector = "accessibilityPerformShowAlternateUI", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowDefaultUI", Selector = "accessibilityPerformShowDefaultUI", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsAccessibilityAlternateUIVisible", Selector = "isAccessibilityAlternateUIVisible", PropertyType = typeof(bool), GetterSelector = "isAccessibilityAlternateUIVisible", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityContainsTransientUI : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	bool IsAccessibilityAlternateUIVisible
	{
		[Export("isAccessibilityAlternateUIVisible")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformShowAlternateUI")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformShowAlternateUI();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformShowDefaultUI")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformShowDefaultUI();
}

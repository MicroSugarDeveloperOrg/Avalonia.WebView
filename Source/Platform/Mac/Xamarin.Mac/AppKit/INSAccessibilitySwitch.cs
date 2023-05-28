using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilitySwitch", WrapperType = typeof(NSAccessibilitySwitchWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformIncrement", Selector = "accessibilityPerformIncrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDecrement", Selector = "accessibilityPerformDecrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(string), GetterSelector = "accessibilityValue", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilitySwitch : INativeObject, IDisposable, INSAccessibilityButton, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	string? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get;
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityRadioButton", WrapperType = typeof(NSAccessibilityRadioButtonWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(NSNumber), GetterSelector = "accessibilityValue", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityRadioButton : INativeObject, IDisposable, INSAccessibilityButton, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	NSNumber? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get;
	}
}

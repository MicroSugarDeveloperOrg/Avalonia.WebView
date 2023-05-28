using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityProgressIndicator", WrapperType = typeof(NSAccessibilityProgressIndicatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(NSNumber), GetterSelector = "accessibilityValue", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityProgressIndicator : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup
{
	[Preserve(Conditional = true)]
	NSNumber? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get;
	}
}

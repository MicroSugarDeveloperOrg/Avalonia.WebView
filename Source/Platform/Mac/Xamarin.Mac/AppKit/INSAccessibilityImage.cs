using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityImage", WrapperType = typeof(NSAccessibilityImageWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityImage : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
	}
}

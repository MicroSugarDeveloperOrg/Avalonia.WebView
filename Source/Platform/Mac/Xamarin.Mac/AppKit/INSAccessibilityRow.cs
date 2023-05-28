using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityRow", WrapperType = typeof(NSAccessibilityRowWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIndex", Selector = "accessibilityIndex", PropertyType = typeof(nint), GetterSelector = "accessibilityIndex", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosureLevel", Selector = "accessibilityDisclosureLevel", PropertyType = typeof(nint), GetterSelector = "accessibilityDisclosureLevel", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityRow : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup
{
	[Preserve(Conditional = true)]
	nint AccessibilityIndex
	{
		[Export("accessibilityIndex")]
		get;
	}
}

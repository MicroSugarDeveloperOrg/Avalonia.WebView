using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityElement", WrapperType = typeof(NSAccessibilityElementProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFrame", Selector = "accessibilityFrame", PropertyType = typeof(CGRect), GetterSelector = "accessibilityFrame", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityParent", Selector = "accessibilityParent", PropertyType = typeof(NSObject), GetterSelector = "accessibilityParent", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityFocused", Selector = "isAccessibilityFocused", PropertyType = typeof(bool), GetterSelector = "isAccessibilityFocused", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityIdentifier", Selector = "accessibilityIdentifier", PropertyType = typeof(string), GetterSelector = "accessibilityIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityElementProtocol : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get;
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityLayoutArea", WrapperType = typeof(NSAccessibilityLayoutAreaWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChildren", Selector = "accessibilityChildren", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityChildren", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedChildren", Selector = "accessibilitySelectedChildren", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedChildren", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocusedUIElement", Selector = "accessibilityFocusedUIElement", PropertyType = typeof(NSObject), GetterSelector = "accessibilityFocusedUIElement", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityLayoutArea : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup
{
	[Preserve(Conditional = true)]
	string AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityChildren
	{
		[Export("accessibilityChildren")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySelectedChildren
	{
		[Export("accessibilitySelectedChildren")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject AccessibilityFocusedUIElement
	{
		[Export("accessibilityFocusedUIElement")]
		get;
	}
}

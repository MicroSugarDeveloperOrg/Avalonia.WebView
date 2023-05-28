using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityTable", WrapperType = typeof(NSAccessibilityTableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRows", Selector = "accessibilityRows", PropertyType = typeof(INSAccessibilityRow[]), GetterSelector = "accessibilityRows", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedRows", Selector = "accessibilitySelectedRows", PropertyType = typeof(INSAccessibilityRow[]), GetterSelector = "accessibilitySelectedRows", SetterSelector = "setAccessibilitySelectedRows:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleRows", Selector = "accessibilityVisibleRows", PropertyType = typeof(INSAccessibilityRow[]), GetterSelector = "accessibilityVisibleRows", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityColumns", Selector = "accessibilityColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityColumns", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleColumns", Selector = "accessibilityVisibleColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleColumns", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedColumns", Selector = "accessibilitySelectedColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedColumns", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityHeaderGroup", Selector = "accessibilityHeaderGroup", PropertyType = typeof(string), GetterSelector = "accessibilityHeaderGroup", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedCells", Selector = "accessibilitySelectedCells", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedCells", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCells", Selector = "accessibilityVisibleCells", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleCells", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityRowHeaderUIElements", Selector = "accessibilityRowHeaderUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityRowHeaderUIElements", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnHeaderUIElements", Selector = "accessibilityColumnHeaderUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityColumnHeaderUIElements", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityTable : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup
{
	[Preserve(Conditional = true)]
	string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
	}

	[Preserve(Conditional = true)]
	INSAccessibilityRow[]? AccessibilityRows
	{
		[Export("accessibilityRows")]
		get;
	}
}

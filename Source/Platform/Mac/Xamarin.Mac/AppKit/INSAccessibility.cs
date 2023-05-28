using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibility", WrapperType = typeof(NSAccessibilityWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLayoutForScreen", Selector = "accessibilityLayoutPointForScreenPoint:", ReturnType = typeof(CGPoint), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLayoutForScreen", Selector = "accessibilityLayoutSizeForScreenSize:", ReturnType = typeof(CGSize), ParameterType = new Type[] { typeof(CGSize) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityScreenForLayout", Selector = "accessibilityScreenPointForLayoutPoint:", ReturnType = typeof(CGPoint), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityScreenForLayout", Selector = "accessibilityScreenSizeForLayoutSize:", ReturnType = typeof(CGSize), ParameterType = new Type[] { typeof(CGSize) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityCellForColumn", Selector = "accessibilityCellForColumn:row:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedString", Selector = "accessibilityAttributedStringForRange:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeForLine", Selector = "accessibilityRangeForLine:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityString", Selector = "accessibilityStringForRange:", ReturnType = typeof(string), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRange", Selector = "accessibilityRangeForPosition:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(CGPoint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRange", Selector = "accessibilityRangeForIndex:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityFrame", Selector = "accessibilityFrameForRange:", ReturnType = typeof(CGRect), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRtf", Selector = "accessibilityRTFForRange:", ReturnType = typeof(NSData), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityStyleRange", Selector = "accessibilityStyleRangeForIndex:", ReturnType = typeof(NSRange), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLine", Selector = "accessibilityLineForIndex:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformCancel", Selector = "accessibilityPerformCancel", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformConfirm", Selector = "accessibilityPerformConfirm", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDecrement", Selector = "accessibilityPerformDecrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDelete", Selector = "accessibilityPerformDelete", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformIncrement", Selector = "accessibilityPerformIncrement", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformPick", Selector = "accessibilityPerformPick", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformPress", Selector = "accessibilityPerformPress", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformRaise", Selector = "accessibilityPerformRaise", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowAlternateUI", Selector = "accessibilityPerformShowAlternateUI", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowDefaultUI", Selector = "accessibilityPerformShowDefaultUI", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowMenu", Selector = "accessibilityPerformShowMenu", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsAccessibilitySelectorAllowed", Selector = "isAccessibilitySelectorAllowed:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(Selector) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFrame", Selector = "accessibilityFrame", PropertyType = typeof(CGRect), GetterSelector = "accessibilityFrame", SetterSelector = "setAccessibilityFrame:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIdentifier", Selector = "accessibilityIdentifier", PropertyType = typeof(string), GetterSelector = "accessibilityIdentifier", SetterSelector = "setAccessibilityIdentifier:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityParent", Selector = "accessibilityParent", PropertyType = typeof(NSObject), GetterSelector = "accessibilityParent", SetterSelector = "setAccessibilityParent:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocused", Selector = "accessibilityFocused", PropertyType = typeof(bool), GetterSelector = "isAccessibilityFocused", SetterSelector = "setAccessibilityFocused:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityElement", Selector = "accessibilityElement", PropertyType = typeof(bool), GetterSelector = "isAccessibilityElement", SetterSelector = "setAccessibilityElement:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityActivationPoint", Selector = "accessibilityActivationPoint", PropertyType = typeof(CGPoint), GetterSelector = "accessibilityActivationPoint", SetterSelector = "setAccessibilityActivationPoint:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTopLevelUIElement", Selector = "accessibilityTopLevelUIElement", PropertyType = typeof(NSObject), GetterSelector = "accessibilityTopLevelUIElement", SetterSelector = "setAccessibilityTopLevelUIElement:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUrl", Selector = "accessibilityURL", PropertyType = typeof(NSUrl), GetterSelector = "accessibilityURL", SetterSelector = "setAccessibilityURL:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityValue", SetterSelector = "setAccessibilityValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValueDescription", Selector = "accessibilityValueDescription", PropertyType = typeof(string), GetterSelector = "accessibilityValueDescription", SetterSelector = "setAccessibilityValueDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleChildren", Selector = "accessibilityVisibleChildren", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleChildren", SetterSelector = "setAccessibilityVisibleChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySubrole", Selector = "accessibilitySubrole", PropertyType = typeof(string), GetterSelector = "accessibilitySubrole", SetterSelector = "setAccessibilitySubrole:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTitle", Selector = "accessibilityTitle", PropertyType = typeof(string), GetterSelector = "accessibilityTitle", SetterSelector = "setAccessibilityTitle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTitleUIElement", Selector = "accessibilityTitleUIElement", PropertyType = typeof(NSObject), GetterSelector = "accessibilityTitleUIElement", SetterSelector = "setAccessibilityTitleUIElement:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityNextContents", Selector = "accessibilityNextContents", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityNextContents", SetterSelector = "setAccessibilityNextContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOrientation", Selector = "accessibilityOrientation", PropertyType = typeof(NSAccessibilityOrientation), GetterSelector = "accessibilityOrientation", SetterSelector = "setAccessibilityOrientation:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOverflowButton", Selector = "accessibilityOverflowButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityOverflowButton", SetterSelector = "setAccessibilityOverflowButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityPlaceholderValue", Selector = "accessibilityPlaceholderValue", PropertyType = typeof(string), GetterSelector = "accessibilityPlaceholderValue", SetterSelector = "setAccessibilityPlaceholderValue:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityPreviousContents", Selector = "accessibilityPreviousContents", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityPreviousContents", SetterSelector = "setAccessibilityPreviousContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRole", Selector = "accessibilityRole", PropertyType = typeof(string), GetterSelector = "accessibilityRole", SetterSelector = "setAccessibilityRole:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRoleDescription", Selector = "accessibilityRoleDescription", PropertyType = typeof(string), GetterSelector = "accessibilityRoleDescription", SetterSelector = "setAccessibilityRoleDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySearchButton", Selector = "accessibilitySearchButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilitySearchButton", SetterSelector = "setAccessibilitySearchButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySearchMenu", Selector = "accessibilitySearchMenu", PropertyType = typeof(NSObject), GetterSelector = "accessibilitySearchMenu", SetterSelector = "setAccessibilitySearchMenu:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelected", Selector = "accessibilitySelected", PropertyType = typeof(bool), GetterSelector = "isAccessibilitySelected", SetterSelector = "setAccessibilitySelected:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedChildren", Selector = "accessibilitySelectedChildren", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedChildren", SetterSelector = "setAccessibilitySelectedChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityServesAsTitleForUIElements", Selector = "accessibilityServesAsTitleForUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityServesAsTitleForUIElements", SetterSelector = "setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityShownMenu", Selector = "accessibilityShownMenu", PropertyType = typeof(NSObject), GetterSelector = "accessibilityShownMenu", SetterSelector = "setAccessibilityShownMenu:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinValue", Selector = "accessibilityMinValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMinValue", SetterSelector = "setAccessibilityMinValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMaxValue", Selector = "accessibilityMaxValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMaxValue", SetterSelector = "setAccessibilityMaxValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLinkedUIElements", Selector = "accessibilityLinkedUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityLinkedUIElements", SetterSelector = "setAccessibilityLinkedUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWindow", Selector = "accessibilityWindow", PropertyType = typeof(NSObject), GetterSelector = "accessibilityWindow", SetterSelector = "setAccessibilityWindow:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHelp", Selector = "accessibilityHelp", PropertyType = typeof(string), GetterSelector = "accessibilityHelp", SetterSelector = "setAccessibilityHelp:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFilename", Selector = "accessibilityFilename", PropertyType = typeof(string), GetterSelector = "accessibilityFilename", SetterSelector = "setAccessibilityFilename:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityExpanded", Selector = "accessibilityExpanded", PropertyType = typeof(bool), GetterSelector = "isAccessibilityExpanded", SetterSelector = "setAccessibilityExpanded:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityEdited", Selector = "accessibilityEdited", PropertyType = typeof(bool), GetterSelector = "isAccessibilityEdited", SetterSelector = "setAccessibilityEdited:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityEnabled", Selector = "accessibilityEnabled", PropertyType = typeof(bool), GetterSelector = "isAccessibilityEnabled", SetterSelector = "setAccessibilityEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChildren", Selector = "accessibilityChildren", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityChildren", SetterSelector = "setAccessibilityChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityClearButton", Selector = "accessibilityClearButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityClearButton", SetterSelector = "setAccessibilityClearButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCancelButton", Selector = "accessibilityCancelButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityCancelButton", SetterSelector = "setAccessibilityCancelButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityProtectedContent", Selector = "accessibilityProtectedContent", PropertyType = typeof(bool), GetterSelector = "isAccessibilityProtectedContent", SetterSelector = "setAccessibilityProtectedContent:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityContents", Selector = "accessibilityContents", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityContents", SetterSelector = "setAccessibilityContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof(string), GetterSelector = "accessibilityLabel", SetterSelector = "setAccessibilityLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityAlternateUIVisible", Selector = "accessibilityAlternateUIVisible", PropertyType = typeof(bool), GetterSelector = "isAccessibilityAlternateUIVisible", SetterSelector = "setAccessibilityAlternateUIVisible:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedFocusElements", Selector = "accessibilitySharedFocusElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySharedFocusElements", SetterSelector = "setAccessibilitySharedFocusElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityApplicationFocusedUIElement", Selector = "accessibilityApplicationFocusedUIElement", PropertyType = typeof(NSObject), GetterSelector = "accessibilityApplicationFocusedUIElement", SetterSelector = "setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMainWindow", Selector = "accessibilityMainWindow", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMainWindow", SetterSelector = "setAccessibilityMainWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHidden", Selector = "accessibilityHidden", PropertyType = typeof(bool), GetterSelector = "isAccessibilityHidden", SetterSelector = "setAccessibilityHidden:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFrontmost", Selector = "accessibilityFrontmost", PropertyType = typeof(bool), GetterSelector = "isAccessibilityFrontmost", SetterSelector = "setAccessibilityFrontmost:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocusedWindow", Selector = "accessibilityFocusedWindow", PropertyType = typeof(NSObject), GetterSelector = "accessibilityFocusedWindow", SetterSelector = "setAccessibilityFocusedWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWindows", Selector = "accessibilityWindows", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityWindows", SetterSelector = "setAccessibilityWindows:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityExtrasMenuBar", Selector = "accessibilityExtrasMenuBar", PropertyType = typeof(NSObject), GetterSelector = "accessibilityExtrasMenuBar", SetterSelector = "setAccessibilityExtrasMenuBar:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMenuBar", Selector = "accessibilityMenuBar", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMenuBar", SetterSelector = "setAccessibilityMenuBar:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnTitles", Selector = "accessibilityColumnTitles", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityColumnTitles", SetterSelector = "setAccessibilityColumnTitles:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOrderedByRow", Selector = "accessibilityOrderedByRow", PropertyType = typeof(bool), GetterSelector = "isAccessibilityOrderedByRow", SetterSelector = "setAccessibilityOrderedByRow:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalUnits", Selector = "accessibilityHorizontalUnits", PropertyType = typeof(NSAccessibilityUnits), GetterSelector = "accessibilityHorizontalUnits", SetterSelector = "setAccessibilityHorizontalUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalUnits", Selector = "accessibilityVerticalUnits", PropertyType = typeof(NSAccessibilityUnits), GetterSelector = "accessibilityVerticalUnits", SetterSelector = "setAccessibilityVerticalUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalUnitDescription", Selector = "accessibilityHorizontalUnitDescription", PropertyType = typeof(string), GetterSelector = "accessibilityHorizontalUnitDescription", SetterSelector = "setAccessibilityHorizontalUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalUnitDescription", Selector = "accessibilityVerticalUnitDescription", PropertyType = typeof(string), GetterSelector = "accessibilityVerticalUnitDescription", SetterSelector = "setAccessibilityVerticalUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHandles", Selector = "accessibilityHandles", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityHandles", SetterSelector = "setAccessibilityHandles:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWarningValue", Selector = "accessibilityWarningValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityWarningValue", SetterSelector = "setAccessibilityWarningValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCriticalValue", Selector = "accessibilityCriticalValue", PropertyType = typeof(NSObject), GetterSelector = "accessibilityCriticalValue", SetterSelector = "setAccessibilityCriticalValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosed", Selector = "accessibilityDisclosed", PropertyType = typeof(bool), GetterSelector = "isAccessibilityDisclosed", SetterSelector = "setAccessibilityDisclosed:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosedByRow", Selector = "accessibilityDisclosedByRow", PropertyType = typeof(NSObject), GetterSelector = "accessibilityDisclosedByRow", SetterSelector = "setAccessibilityDisclosedByRow:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosedRows", Selector = "accessibilityDisclosedRows", PropertyType = typeof(NSObject), GetterSelector = "accessibilityDisclosedRows", SetterSelector = "setAccessibilityDisclosedRows:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosureLevel", Selector = "accessibilityDisclosureLevel", PropertyType = typeof(nint), GetterSelector = "accessibilityDisclosureLevel", SetterSelector = "setAccessibilityDisclosureLevel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerUIElements", Selector = "accessibilityMarkerUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityMarkerUIElements", SetterSelector = "setAccessibilityMarkerUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerValues", Selector = "accessibilityMarkerValues", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMarkerValues", SetterSelector = "setAccessibilityMarkerValues:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerGroupUIElement", Selector = "accessibilityMarkerGroupUIElement", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMarkerGroupUIElement", SetterSelector = "setAccessibilityMarkerGroupUIElement:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUnits", Selector = "accessibilityUnits", PropertyType = typeof(NSAccessibilityUnits), GetterSelector = "accessibilityUnits", SetterSelector = "setAccessibilityUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUnitDescription", Selector = "accessibilityUnitDescription", PropertyType = typeof(string), GetterSelector = "accessibilityUnitDescription", SetterSelector = "setAccessibilityUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRulerMarkerType", Selector = "accessibilityRulerMarkerType", PropertyType = typeof(NSAccessibilityRulerMarkerType), GetterSelector = "accessibilityRulerMarkerType", SetterSelector = "setAccessibilityRulerMarkerType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerTypeDescription", Selector = "accessibilityMarkerTypeDescription", PropertyType = typeof(string), GetterSelector = "accessibilityMarkerTypeDescription", SetterSelector = "setAccessibilityMarkerTypeDescription:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalScrollBar", Selector = "accessibilityHorizontalScrollBar", PropertyType = typeof(NSObject), GetterSelector = "accessibilityHorizontalScrollBar", SetterSelector = "setAccessibilityHorizontalScrollBar:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalScrollBar", Selector = "accessibilityVerticalScrollBar", PropertyType = typeof(NSObject), GetterSelector = "accessibilityVerticalScrollBar", SetterSelector = "setAccessibilityVerticalScrollBar:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityAllowedValues", Selector = "accessibilityAllowedValues", PropertyType = typeof(NSNumber[]), GetterSelector = "accessibilityAllowedValues", SetterSelector = "setAccessibilityAllowedValues:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabelUIElements", Selector = "accessibilityLabelUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityLabelUIElements", SetterSelector = "setAccessibilityLabelUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabelValue", Selector = "accessibilityLabelValue", PropertyType = typeof(float), GetterSelector = "accessibilityLabelValue", SetterSelector = "setAccessibilityLabelValue:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySplitters", Selector = "accessibilitySplitters", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySplitters", SetterSelector = "setAccessibilitySplitters:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDecrementButton", Selector = "accessibilityDecrementButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityDecrementButton", SetterSelector = "setAccessibilityDecrementButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIncrementButton", Selector = "accessibilityIncrementButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityIncrementButton", SetterSelector = "setAccessibilityIncrementButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTabs", Selector = "accessibilityTabs", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityTabs", SetterSelector = "setAccessibilityTabs:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHeader", Selector = "accessibilityHeader", PropertyType = typeof(NSObject), GetterSelector = "accessibilityHeader", SetterSelector = "setAccessibilityHeader:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnCount", Selector = "accessibilityColumnCount", PropertyType = typeof(nint), GetterSelector = "accessibilityColumnCount", SetterSelector = "setAccessibilityColumnCount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowCount", Selector = "accessibilityRowCount", PropertyType = typeof(nint), GetterSelector = "accessibilityRowCount", SetterSelector = "setAccessibilityRowCount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIndex", Selector = "accessibilityIndex", PropertyType = typeof(nint), GetterSelector = "accessibilityIndex", SetterSelector = "setAccessibilityIndex:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumns", Selector = "accessibilityColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityColumns", SetterSelector = "setAccessibilityColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRows", Selector = "accessibilityRows", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityRows", SetterSelector = "setAccessibilityRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleRows", Selector = "accessibilityVisibleRows", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleRows", SetterSelector = "setAccessibilityVisibleRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedRows", Selector = "accessibilitySelectedRows", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedRows", SetterSelector = "setAccessibilitySelectedRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleColumns", Selector = "accessibilityVisibleColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleColumns", SetterSelector = "setAccessibilityVisibleColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedColumns", Selector = "accessibilitySelectedColumns", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedColumns", SetterSelector = "setAccessibilitySelectedColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySortDirection", Selector = "accessibilitySortDirection", PropertyType = typeof(NSAccessibilitySortDirection), GetterSelector = "accessibilitySortDirection", SetterSelector = "setAccessibilitySortDirection:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowHeaderUIElements", Selector = "accessibilityRowHeaderUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityRowHeaderUIElements", SetterSelector = "setAccessibilityRowHeaderUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedCells", Selector = "accessibilitySelectedCells", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySelectedCells", SetterSelector = "setAccessibilitySelectedCells:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCells", Selector = "accessibilityVisibleCells", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityVisibleCells", SetterSelector = "setAccessibilityVisibleCells:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnHeaderUIElements", Selector = "accessibilityColumnHeaderUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilityColumnHeaderUIElements", SetterSelector = "setAccessibilityColumnHeaderUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowIndexRange", Selector = "accessibilityRowIndexRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilityRowIndexRange", SetterSelector = "setAccessibilityRowIndexRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnIndexRange", Selector = "accessibilityColumnIndexRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilityColumnIndexRange", SetterSelector = "setAccessibilityColumnIndexRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityInsertionPointLineNumber", Selector = "accessibilityInsertionPointLineNumber", PropertyType = typeof(nint), GetterSelector = "accessibilityInsertionPointLineNumber", SetterSelector = "setAccessibilityInsertionPointLineNumber:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedCharacterRange", Selector = "accessibilitySharedCharacterRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilitySharedCharacterRange", SetterSelector = "setAccessibilitySharedCharacterRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedTextUIElements", Selector = "accessibilitySharedTextUIElements", PropertyType = typeof(NSObject[]), GetterSelector = "accessibilitySharedTextUIElements", SetterSelector = "setAccessibilitySharedTextUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCharacterRange", Selector = "accessibilityVisibleCharacterRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilityVisibleCharacterRange", SetterSelector = "setAccessibilityVisibleCharacterRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityNumberOfCharacters", Selector = "accessibilityNumberOfCharacters", PropertyType = typeof(nint), GetterSelector = "accessibilityNumberOfCharacters", SetterSelector = "setAccessibilityNumberOfCharacters:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedText", Selector = "accessibilitySelectedText", PropertyType = typeof(string), GetterSelector = "accessibilitySelectedText", SetterSelector = "setAccessibilitySelectedText:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedTextRange", Selector = "accessibilitySelectedTextRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilitySelectedTextRange", SetterSelector = "setAccessibilitySelectedTextRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedTextRanges", Selector = "accessibilitySelectedTextRanges", PropertyType = typeof(NSValue[]), GetterSelector = "accessibilitySelectedTextRanges", SetterSelector = "setAccessibilitySelectedTextRanges:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityToolbarButton", Selector = "accessibilityToolbarButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityToolbarButton", SetterSelector = "setAccessibilityToolbarButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityModal", Selector = "accessibilityModal", PropertyType = typeof(bool), GetterSelector = "isAccessibilityModal", SetterSelector = "setAccessibilityModal:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityProxy", Selector = "accessibilityProxy", PropertyType = typeof(NSObject), GetterSelector = "accessibilityProxy", SetterSelector = "setAccessibilityProxy:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMain", Selector = "accessibilityMain", PropertyType = typeof(bool), GetterSelector = "isAccessibilityMain", SetterSelector = "setAccessibilityMain:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFullScreenButton", Selector = "accessibilityFullScreenButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityFullScreenButton", SetterSelector = "setAccessibilityFullScreenButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityGrowArea", Selector = "accessibilityGrowArea", PropertyType = typeof(NSObject), GetterSelector = "accessibilityGrowArea", SetterSelector = "setAccessibilityGrowArea:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDocument", Selector = "accessibilityDocument", PropertyType = typeof(string), GetterSelector = "accessibilityDocument", SetterSelector = "setAccessibilityDocument:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDefaultButton", Selector = "accessibilityDefaultButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityDefaultButton", SetterSelector = "setAccessibilityDefaultButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCloseButton", Selector = "accessibilityCloseButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityCloseButton", SetterSelector = "setAccessibilityCloseButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityZoomButton", Selector = "accessibilityZoomButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityZoomButton", SetterSelector = "setAccessibilityZoomButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinimizeButton", Selector = "accessibilityMinimizeButton", PropertyType = typeof(NSObject), GetterSelector = "accessibilityMinimizeButton", SetterSelector = "setAccessibilityMinimizeButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinimized", Selector = "accessibilityMinimized", PropertyType = typeof(bool), GetterSelector = "isAccessibilityMinimized", SetterSelector = "setAccessibilityMinimized:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityRequired", Selector = "accessibilityRequired", PropertyType = typeof(bool), GetterSelector = "isAccessibilityRequired", SetterSelector = "setAccessibilityRequired:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityChildrenInNavigationOrder", Selector = "accessibilityChildrenInNavigationOrder", PropertyType = typeof(NSAccessibilityElement[]), GetterSelector = "accessibilityChildrenInNavigationOrder", SetterSelector = "setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomRotors", Selector = "accessibilityCustomRotors", PropertyType = typeof(NSAccessibilityCustomRotor[]), GetterSelector = "accessibilityCustomRotors", SetterSelector = "setAccessibilityCustomRotors:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomActions", Selector = "accessibilityCustomActions", PropertyType = typeof(NSAccessibilityCustomAction[]), GetterSelector = "accessibilityCustomActions", SetterSelector = "setAccessibilityCustomActions:", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface INSAccessibility : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityFrame:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get;
		[Export("setAccessibilityIdentifier:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityParent
	{
		[Export("accessibilityParent", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityParent:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get;
		[Export("setAccessibilityFocused:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityElement
	{
		[Export("isAccessibilityElement")]
		get;
		[Export("setAccessibilityElement:")]
		set;
	}

	[Preserve(Conditional = true)]
	CGPoint AccessibilityActivationPoint
	{
		[Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityTopLevelUIElement
	{
		[Export("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	NSUrl? AccessibilityUrl
	{
		[Export("accessibilityURL", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityURL:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityValue
	{
		[Export("accessibilityValue", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityValue:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityValueDescription
	{
		[Export("accessibilityValueDescription")]
		get;
		[Export("setAccessibilityValueDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityVisibleChildren
	{
		[Export("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilitySubrole
	{
		[Export("accessibilitySubrole")]
		get;
		[Export("setAccessibilitySubrole:")]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityTitle
	{
		[Export("accessibilityTitle")]
		get;
		[Export("setAccessibilityTitle:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityTitleUIElement
	{
		[Export("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityNextContents
	{
		[Export("accessibilityNextContents", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilityOrientation AccessibilityOrientation
	{
		[Export("accessibilityOrientation", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityOverflowButton
	{
		[Export("accessibilityOverflowButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityPlaceholderValue
	{
		[Export("accessibilityPlaceholderValue")]
		get;
		[Export("setAccessibilityPlaceholderValue:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityPreviousContents
	{
		[Export("accessibilityPreviousContents", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityRole
	{
		[Export("accessibilityRole")]
		get;
		[Export("setAccessibilityRole:")]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityRoleDescription
	{
		[Export("accessibilityRoleDescription")]
		get;
		[Export("setAccessibilityRoleDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilitySearchButton
	{
		[Export("accessibilitySearchButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilitySearchMenu
	{
		[Export("accessibilitySearchMenu", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilitySelected
	{
		[Export("isAccessibilitySelected")]
		get;
		[Export("setAccessibilitySelected:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySelectedChildren
	{
		[Export("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityServesAsTitleForUIElements
	{
		[Export("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityShownMenu
	{
		[Export("accessibilityShownMenu", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMinValue
	{
		[Export("accessibilityMinValue", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMaxValue
	{
		[Export("accessibilityMaxValue", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityLinkedUIElements
	{
		[Export("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityWindow
	{
		[Export("accessibilityWindow", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityWindow:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityHelp
	{
		[Export("accessibilityHelp")]
		get;
		[Export("setAccessibilityHelp:")]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityFilename
	{
		[Export("accessibilityFilename")]
		get;
		[Export("setAccessibilityFilename:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityExpanded
	{
		[Export("isAccessibilityExpanded")]
		get;
		[Export("setAccessibilityExpanded:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityEdited
	{
		[Export("isAccessibilityEdited")]
		get;
		[Export("setAccessibilityEdited:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityEnabled
	{
		[Export("isAccessibilityEnabled")]
		get;
		[Export("setAccessibilityEnabled:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityChildren
	{
		[Export("accessibilityChildren", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityChildren:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityClearButton
	{
		[Export("accessibilityClearButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityCancelButton
	{
		[Export("accessibilityCancelButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityProtectedContent
	{
		[Export("isAccessibilityProtectedContent")]
		get;
		[Export("setAccessibilityProtectedContent:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityContents
	{
		[Export("accessibilityContents", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityContents:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get;
		[Export("setAccessibilityLabel:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityAlternateUIVisible
	{
		[Export("isAccessibilityAlternateUIVisible")]
		get;
		[Export("setAccessibilityAlternateUIVisible:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySharedFocusElements
	{
		[Export("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityApplicationFocusedUIElement
	{
		[Export("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMainWindow
	{
		[Export("accessibilityMainWindow", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityHidden
	{
		[Export("isAccessibilityHidden")]
		get;
		[Export("setAccessibilityHidden:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityFrontmost
	{
		[Export("isAccessibilityFrontmost")]
		get;
		[Export("setAccessibilityFrontmost:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityFocusedWindow
	{
		[Export("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityWindows
	{
		[Export("accessibilityWindows", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityWindows:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityExtrasMenuBar
	{
		[Export("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMenuBar
	{
		[Export("accessibilityMenuBar", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityColumnTitles
	{
		[Export("accessibilityColumnTitles", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityOrderedByRow
	{
		[Export("isAccessibilityOrderedByRow")]
		get;
		[Export("setAccessibilityOrderedByRow:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilityUnits AccessibilityHorizontalUnits
	{
		[Export("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilityUnits AccessibilityVerticalUnits
	{
		[Export("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityHorizontalUnitDescription
	{
		[Export("accessibilityHorizontalUnitDescription")]
		get;
		[Export("setAccessibilityHorizontalUnitDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityVerticalUnitDescription
	{
		[Export("accessibilityVerticalUnitDescription")]
		get;
		[Export("setAccessibilityVerticalUnitDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityHandles
	{
		[Export("accessibilityHandles", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityHandles:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityWarningValue
	{
		[Export("accessibilityWarningValue", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityCriticalValue
	{
		[Export("accessibilityCriticalValue", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityDisclosed
	{
		[Export("isAccessibilityDisclosed")]
		get;
		[Export("setAccessibilityDisclosed:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityDisclosedByRow
	{
		[Export("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
		get;
		[Export("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityDisclosedRows
	{
		[Export("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityDisclosureLevel
	{
		[Export("accessibilityDisclosureLevel")]
		get;
		[Export("setAccessibilityDisclosureLevel:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityMarkerUIElements
	{
		[Export("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMarkerValues
	{
		[Export("accessibilityMarkerValues", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMarkerGroupUIElement
	{
		[Export("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilityUnits AccessibilityUnits
	{
		[Export("accessibilityUnits", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityUnits:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityUnitDescription
	{
		[Export("accessibilityUnitDescription")]
		get;
		[Export("setAccessibilityUnitDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType
	{
		[Export("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityMarkerTypeDescription
	{
		[Export("accessibilityMarkerTypeDescription")]
		get;
		[Export("setAccessibilityMarkerTypeDescription:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityHorizontalScrollBar
	{
		[Export("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityVerticalScrollBar
	{
		[Export("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSNumber[]? AccessibilityAllowedValues
	{
		[Export("accessibilityAllowedValues", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityLabelUIElements
	{
		[Export("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	float AccessibilityLabelValue
	{
		[Export("accessibilityLabelValue")]
		get;
		[Export("setAccessibilityLabelValue:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySplitters
	{
		[Export("accessibilitySplitters", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityDecrementButton
	{
		[Export("accessibilityDecrementButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityIncrementButton
	{
		[Export("accessibilityIncrementButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityTabs
	{
		[Export("accessibilityTabs", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityTabs:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityHeader
	{
		[Export("accessibilityHeader", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityHeader:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityColumnCount
	{
		[Export("accessibilityColumnCount")]
		get;
		[Export("setAccessibilityColumnCount:")]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityRowCount
	{
		[Export("accessibilityRowCount")]
		get;
		[Export("setAccessibilityRowCount:")]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityIndex
	{
		[Export("accessibilityIndex")]
		get;
		[Export("setAccessibilityIndex:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityColumns
	{
		[Export("accessibilityColumns", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityColumns:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityRows
	{
		[Export("accessibilityRows", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityRows:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityVisibleRows
	{
		[Export("accessibilityVisibleRows", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySelectedRows
	{
		[Export("accessibilitySelectedRows", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityVisibleColumns
	{
		[Export("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySelectedColumns
	{
		[Export("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSAccessibilitySortDirection AccessibilitySortDirection
	{
		[Export("accessibilitySortDirection", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityRowHeaderUIElements
	{
		[Export("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySelectedCells
	{
		[Export("accessibilitySelectedCells", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityVisibleCells
	{
		[Export("accessibilityVisibleCells", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilityColumnHeaderUIElements
	{
		[Export("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSRange AccessibilityRowIndexRange
	{
		[Export("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSRange AccessibilityColumnIndexRange
	{
		[Export("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityInsertionPointLineNumber
	{
		[Export("accessibilityInsertionPointLineNumber")]
		get;
		[Export("setAccessibilityInsertionPointLineNumber:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSRange AccessibilitySharedCharacterRange
	{
		[Export("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject[]? AccessibilitySharedTextUIElements
	{
		[Export("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSRange AccessibilityVisibleCharacterRange
	{
		[Export("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	nint AccessibilityNumberOfCharacters
	{
		[Export("accessibilityNumberOfCharacters")]
		get;
		[Export("setAccessibilityNumberOfCharacters:")]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilitySelectedText
	{
		[Export("accessibilitySelectedText")]
		get;
		[Export("setAccessibilitySelectedText:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSRange AccessibilitySelectedTextRange
	{
		[Export("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
		get;
		[Export("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	NSValue[]? AccessibilitySelectedTextRanges
	{
		[Export("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
		get;
		[Export("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityToolbarButton
	{
		[Export("accessibilityToolbarButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityModal
	{
		[Export("isAccessibilityModal")]
		get;
		[Export("setAccessibilityModal:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityProxy
	{
		[Export("accessibilityProxy", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityProxy:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityMain
	{
		[Export("isAccessibilityMain")]
		get;
		[Export("setAccessibilityMain:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityFullScreenButton
	{
		[Export("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityGrowArea
	{
		[Export("accessibilityGrowArea", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	string? AccessibilityDocument
	{
		[Export("accessibilityDocument")]
		get;
		[Export("setAccessibilityDocument:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityDefaultButton
	{
		[Export("accessibilityDefaultButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityCloseButton
	{
		[Export("accessibilityCloseButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityZoomButton
	{
		[Export("accessibilityZoomButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	NSObject? AccessibilityMinimizeButton
	{
		[Export("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
		get;
		[Export("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AccessibilityMinimized
	{
		[Export("isAccessibilityMinimized")]
		get;
		[Export("setAccessibilityMinimized:")]
		set;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityLayoutPointForScreenPoint:")]
	[Preserve(Conditional = true)]
	CGPoint GetAccessibilityLayoutForScreen(CGPoint point);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityLayoutSizeForScreenSize:")]
	[Preserve(Conditional = true)]
	CGSize GetAccessibilityLayoutForScreen(CGSize size);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityScreenPointForLayoutPoint:")]
	[Preserve(Conditional = true)]
	CGPoint GetAccessibilityScreenForLayout(CGPoint point);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityScreenSizeForLayoutSize:")]
	[Preserve(Conditional = true)]
	CGSize GetAccessibilityScreenForLayout(CGSize size);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityCellForColumn:row:")]
	[Preserve(Conditional = true)]
	NSObject? GetAccessibilityCellForColumn(nint column, nint row);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityAttributedStringForRange:")]
	[Preserve(Conditional = true)]
	NSAttributedString? GetAccessibilityAttributedString(NSRange range);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityRangeForLine:")]
	[Preserve(Conditional = true)]
	NSRange GetAccessibilityRangeForLine(nint line);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityStringForRange:")]
	[Preserve(Conditional = true)]
	string? GetAccessibilityString(NSRange range);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityRangeForPosition:")]
	[Preserve(Conditional = true)]
	NSRange GetAccessibilityRange(CGPoint point);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityRangeForIndex:")]
	[Preserve(Conditional = true)]
	NSRange GetAccessibilityRange(nint index);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityFrameForRange:")]
	[Preserve(Conditional = true)]
	CGRect GetAccessibilityFrame(NSRange range);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityRTFForRange:")]
	[Preserve(Conditional = true)]
	NSData? GetAccessibilityRtf(NSRange range);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityStyleRangeForIndex:")]
	[Preserve(Conditional = true)]
	NSRange GetAccessibilityStyleRange(nint index);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityLineForIndex:")]
	[Preserve(Conditional = true)]
	nint GetAccessibilityLine(nint index);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformCancel")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformCancel();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformConfirm")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformConfirm();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformDecrement")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformDecrement();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformDelete")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformDelete();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformIncrement")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformIncrement();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformPick")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformPick();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformPress")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformPress();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformRaise")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformRaise();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformShowAlternateUI")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformShowAlternateUI();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformShowDefaultUI")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformShowDefaultUI();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accessibilityPerformShowMenu")]
	[Preserve(Conditional = true)]
	bool AccessibilityPerformShowMenu();

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isAccessibilitySelectorAllowed:")]
	[Preserve(Conditional = true)]
	bool IsAccessibilitySelectorAllowed(Selector selector);
}

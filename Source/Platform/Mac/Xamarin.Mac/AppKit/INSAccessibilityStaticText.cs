using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityStaticText", WrapperType = typeof(NSAccessibilityStaticTextWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedString", Selector = "accessibilityAttributedStringForRange:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof(string), GetterSelector = "accessibilityValue", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCharacterRange", Selector = "accessibilityVisibleCharacterRange", PropertyType = typeof(NSRange), GetterSelector = "accessibilityVisibleCharacterRange", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSAccessibilityStaticText : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
	[Preserve(Conditional = true)]
	string? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get;
	}
}

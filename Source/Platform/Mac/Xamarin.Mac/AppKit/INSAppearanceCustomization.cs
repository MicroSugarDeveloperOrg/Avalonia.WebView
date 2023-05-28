using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAppearanceCustomization", WrapperType = typeof(NSAppearanceCustomizationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Appearance", Selector = "appearance", PropertyType = typeof(NSAppearance), GetterSelector = "appearance", SetterSelector = "setAppearance:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "EffectiveAppearance", Selector = "effectiveAppearance", PropertyType = typeof(NSAppearance), GetterSelector = "effectiveAppearance", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface INSAppearanceCustomization : INativeObject, IDisposable
{
}

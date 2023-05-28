using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFontChanging", WrapperType = typeof(NSFontChangingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeFont", Selector = "changeFont:", ParameterType = new Type[] { typeof(NSFontManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetValidModes", Selector = "validModesForFontPanel:", ReturnType = typeof(NSFontPanelModeMask), ParameterType = new Type[] { typeof(NSFontPanel) }, ParameterByRef = new bool[] { false })]
public interface INSFontChanging : INativeObject, IDisposable
{
}

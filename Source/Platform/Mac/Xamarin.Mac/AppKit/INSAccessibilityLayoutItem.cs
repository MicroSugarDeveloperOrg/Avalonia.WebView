using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityLayoutItem", WrapperType = typeof(NSAccessibilityLayoutItemWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAccessibilityFrame", Selector = "setAccessibilityFrame:", ParameterType = new Type[] { typeof(CGRect) }, ParameterByRef = new bool[] { false })]
public interface INSAccessibilityLayoutItem : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup
{
}

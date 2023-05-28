using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityGroup", WrapperType = typeof(NSAccessibilityGroupWrapper))]
public interface INSAccessibilityGroup : INativeObject, IDisposable, INSAccessibilityElementProtocol
{
}

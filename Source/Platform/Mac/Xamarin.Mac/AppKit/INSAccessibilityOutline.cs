using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityOutline", WrapperType = typeof(NSAccessibilityOutlineWrapper))]
public interface INSAccessibilityOutline : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup, INSAccessibilityTable
{
}

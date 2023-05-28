using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityList", WrapperType = typeof(NSAccessibilityListWrapper))]
public interface INSAccessibilityList : INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAccessibilityGroup, INSAccessibilityTable
{
}

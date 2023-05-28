using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLComponent", WrapperType = typeof(MDLComponentWrapper))]
public interface IMDLComponent : INativeObject, IDisposable
{
}

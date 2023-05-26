using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSProgressReporting", WrapperType = typeof(NSProgressReportingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Progress", Selector = "progress", PropertyType = typeof(NSProgress), GetterSelector = "progress", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSProgressReporting : INativeObject, IDisposable
{
}

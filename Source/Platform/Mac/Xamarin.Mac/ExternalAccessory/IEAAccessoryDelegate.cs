using System;
using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "EAAccessoryDelegate", WrapperType = typeof(EAAccessoryDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Disconnected", Selector = "accessoryDidDisconnect:", ParameterType = new Type[] { typeof(EAAccessory) }, ParameterByRef = new bool[] { false })]
public interface IEAAccessoryDelegate : INativeObject, IDisposable
{
}

using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSUserActivityDelegate", WrapperType = typeof(NSUserActivityDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityWillSave", Selector = "userActivityWillSave:", ParameterType = new Type[] { typeof(NSUserActivity) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityWasContinued", Selector = "userActivityWasContinued:", ParameterType = new Type[] { typeof(NSUserActivity) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityReceivedData", Selector = "userActivity:didReceiveInputStream:outputStream:", ParameterType = new Type[]
{
	typeof(NSUserActivity),
	typeof(NSInputStream),
	typeof(NSOutputStream)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSUserActivityDelegate : INativeObject, IDisposable
{
}

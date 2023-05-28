using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "MCAdvertiserAssistantDelegate", WrapperType = typeof(MCAdvertiserAssistantDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissInvitation", Selector = "advertiserAssistantDidDismissInvitation:", ParameterType = new Type[] { typeof(MCAdvertiserAssistant) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentInvitation", Selector = "advertiserAssistantWillPresentInvitation:", ParameterType = new Type[] { typeof(MCAdvertiserAssistant) }, ParameterByRef = new bool[] { false })]
public interface IMCAdvertiserAssistantDelegate : INativeObject, IDisposable
{
}

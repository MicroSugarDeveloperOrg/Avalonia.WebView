using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "ASWebAuthenticationSessionRequestDelegate", WrapperType = typeof(ASWebAuthenticationSessionRequestDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "authenticationSessionRequest:didCompleteWithCallbackURL:", ParameterType = new Type[]
{
	typeof(ASWebAuthenticationSessionRequest),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "authenticationSessionRequest:didCancelWithError:", ParameterType = new Type[]
{
	typeof(ASWebAuthenticationSessionRequest),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IASWebAuthenticationSessionRequestDelegate : INativeObject, IDisposable
{
}

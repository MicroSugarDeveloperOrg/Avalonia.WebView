using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "ASAuthorizationControllerDelegate", WrapperType = typeof(ASAuthorizationControllerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "authorizationController:didCompleteWithAuthorization:", ParameterType = new Type[]
{
	typeof(ASAuthorizationController),
	typeof(ASAuthorization)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "authorizationController:didCompleteWithError:", ParameterType = new Type[]
{
	typeof(ASAuthorizationController),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IASAuthorizationControllerDelegate : INativeObject, IDisposable
{
}

using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "ASAuthorizationControllerPresentationContextProviding", WrapperType = typeof(ASAuthorizationControllerPresentationContextProvidingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationAnchor", Selector = "presentationAnchorForAuthorizationController:", ReturnType = typeof(NSWindow), ParameterType = new Type[] { typeof(ASAuthorizationController) }, ParameterByRef = new bool[] { false })]
public interface IASAuthorizationControllerPresentationContextProviding : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("presentationAnchorForAuthorizationController:")]
	[Preserve(Conditional = true)]
	NSWindow GetPresentationAnchor(ASAuthorizationController controller);
}

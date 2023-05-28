using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "ASWebAuthenticationPresentationContextProviding", WrapperType = typeof(ASWebAuthenticationPresentationContextProvidingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationAnchor", Selector = "presentationAnchorForWebAuthenticationSession:", ReturnType = typeof(NSWindow), ParameterType = new Type[] { typeof(ASWebAuthenticationSession) }, ParameterByRef = new bool[] { false })]
public interface IASWebAuthenticationPresentationContextProviding : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("presentationAnchorForWebAuthenticationSession:")]
	[Preserve(Conditional = true)]
	NSWindow GetPresentationAnchor(ASWebAuthenticationSession session);
}

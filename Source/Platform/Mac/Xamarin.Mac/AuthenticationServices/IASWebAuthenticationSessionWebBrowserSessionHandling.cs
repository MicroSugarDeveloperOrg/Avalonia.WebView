using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "ASWebAuthenticationSessionWebBrowserSessionHandling", WrapperType = typeof(ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginHandlingWebAuthenticationSessionRequest", Selector = "beginHandlingWebAuthenticationSessionRequest:", ParameterType = new Type[] { typeof(ASWebAuthenticationSessionRequest) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelWebAuthenticationSessionRequest", Selector = "cancelWebAuthenticationSessionRequest:", ParameterType = new Type[] { typeof(ASWebAuthenticationSessionRequest) }, ParameterByRef = new bool[] { false })]
public interface IASWebAuthenticationSessionWebBrowserSessionHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginHandlingWebAuthenticationSessionRequest:")]
	[Preserve(Conditional = true)]
	void BeginHandlingWebAuthenticationSessionRequest(ASWebAuthenticationSessionRequest request);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cancelWebAuthenticationSessionRequest:")]
	[Preserve(Conditional = true)]
	void CancelWebAuthenticationSessionRequest(ASWebAuthenticationSessionRequest request);
}

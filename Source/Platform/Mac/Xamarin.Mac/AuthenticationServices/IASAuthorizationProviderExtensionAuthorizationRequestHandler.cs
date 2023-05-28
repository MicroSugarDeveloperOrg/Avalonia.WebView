using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Protocol(Name = "ASAuthorizationProviderExtensionAuthorizationRequestHandler", WrapperType = typeof(ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginAuthorization", Selector = "beginAuthorizationWithRequest:", ParameterType = new Type[] { typeof(ASAuthorizationProviderExtensionAuthorizationRequest) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelAuthorization", Selector = "cancelAuthorizationWithRequest:", ParameterType = new Type[] { typeof(ASAuthorizationProviderExtensionAuthorizationRequest) }, ParameterByRef = new bool[] { false })]
public interface IASAuthorizationProviderExtensionAuthorizationRequestHandler : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginAuthorizationWithRequest:")]
	[Preserve(Conditional = true)]
	void BeginAuthorization(ASAuthorizationProviderExtensionAuthorizationRequest request);
}

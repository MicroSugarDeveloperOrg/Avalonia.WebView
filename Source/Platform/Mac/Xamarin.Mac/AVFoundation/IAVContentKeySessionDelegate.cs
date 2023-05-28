using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "AVContentKeySessionDelegate", WrapperType = typeof(AVContentKeySessionDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidProvideContentKeyRequest", Selector = "contentKeySession:didProvideContentKeyRequest:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVContentKeyRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvideRenewingContentKeyRequest", Selector = "contentKeySession:didProvideRenewingContentKeyRequest:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVContentKeyRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvidePersistableContentKeyRequest", Selector = "contentKeySession:didProvidePersistableContentKeyRequest:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVPersistableContentKeyRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "contentKeySession:contentKeyRequest:didFailWithError:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVContentKeyRequest),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRetryContentKeyRequest", Selector = "contentKeySession:shouldRetryContentKeyRequest:reason:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVContentKeyRequest),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChange", Selector = "contentKeySessionContentProtectionSessionIdentifierDidChange:", ParameterType = new Type[] { typeof(AVContentKeySession) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(NSData),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSucceed", Selector = "contentKeySession:contentKeyRequestDidSucceed:", ParameterType = new Type[]
{
	typeof(AVContentKeySession),
	typeof(AVContentKeyRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidGenerateExpiredSessionReport", Selector = "contentKeySessionDidGenerateExpiredSessionReport:", ParameterType = new Type[] { typeof(AVContentKeySession) }, ParameterByRef = new bool[] { false })]
public interface IAVContentKeySessionDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("contentKeySession:didProvideContentKeyRequest:")]
	[Preserve(Conditional = true)]
	void DidProvideContentKeyRequest(AVContentKeySession session, AVContentKeyRequest keyRequest);
}

using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLProtocolClient", WrapperType = typeof(NSUrlProtocolClientWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Redirected", Selector = "URLProtocol:wasRedirectedToRequest:redirectResponse:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSUrlRequest),
	typeof(NSUrlResponse)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CachedResponseIsValid", Selector = "URLProtocol:cachedResponseIsValid:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSCachedUrlResponse)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "URLProtocol:didReceiveResponse:cacheStoragePolicy:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSUrlResponse),
	typeof(NSUrlCacheStoragePolicy)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DataLoaded", Selector = "URLProtocol:didLoadData:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "URLProtocolDidFinishLoading:", ParameterType = new Type[] { typeof(NSUrlProtocol) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "URLProtocol:didFailWithError:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "URLProtocol:didReceiveAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelledAuthenticationChallenge", Selector = "URLProtocol:didCancelAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlProtocol),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUrlProtocolClient : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:wasRedirectedToRequest:redirectResponse:")]
	[Preserve(Conditional = true)]
	void Redirected(NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:cachedResponseIsValid:")]
	[Preserve(Conditional = true)]
	void CachedResponseIsValid(NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:didReceiveResponse:cacheStoragePolicy:")]
	[Preserve(Conditional = true)]
	void ReceivedResponse(NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:didLoadData:")]
	[Preserve(Conditional = true)]
	void DataLoaded(NSUrlProtocol protocol, NSData data);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocolDidFinishLoading:")]
	[Preserve(Conditional = true)]
	void FinishedLoading(NSUrlProtocol protocol);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:didFailWithError:")]
	[Preserve(Conditional = true)]
	void FailedWithError(NSUrlProtocol protocol, NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:didReceiveAuthenticationChallenge:")]
	[Preserve(Conditional = true)]
	void ReceivedAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLProtocol:didCancelAuthenticationChallenge:")]
	[Preserve(Conditional = true)]
	void CancelledAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge);
}

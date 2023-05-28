using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAssetResourceLoaderDelegate", WrapperType = typeof(AVAssetResourceLoaderDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldWaitForLoadingOfRequestedResource", Selector = "resourceLoader:shouldWaitForLoadingOfRequestedResource:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVAssetResourceLoader),
	typeof(AVAssetResourceLoadingRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelLoadingRequest", Selector = "resourceLoader:didCancelLoadingRequest:", ParameterType = new Type[]
{
	typeof(AVAssetResourceLoader),
	typeof(AVAssetResourceLoadingRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldWaitForResponseToAuthenticationChallenge", Selector = "resourceLoader:shouldWaitForResponseToAuthenticationChallenge:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVAssetResourceLoader),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelAuthenticationChallenge", Selector = "resourceLoader:didCancelAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(AVAssetResourceLoader),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldWaitForRenewalOfRequestedResource", Selector = "resourceLoader:shouldWaitForRenewalOfRequestedResource:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(AVAssetResourceLoader),
	typeof(AVAssetResourceRenewalRequest)
}, ParameterByRef = new bool[] { false, false })]
public interface IAVAssetResourceLoaderDelegate : INativeObject, IDisposable
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resourceLoader:shouldWaitForLoadingOfRequestedResource:")]
	[Preserve(Conditional = true)]
	bool ShouldWaitForLoadingOfRequestedResource(AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest);
}

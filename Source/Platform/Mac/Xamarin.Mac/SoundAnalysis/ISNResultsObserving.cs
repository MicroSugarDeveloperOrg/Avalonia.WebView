using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SNResultsObserving", WrapperType = typeof(SNResultsObservingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidProduceResult", Selector = "request:didProduceResult:", ParameterType = new Type[]
{
	typeof(ISNRequest),
	typeof(ISNResult)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "request:didFailWithError:", ParameterType = new Type[]
{
	typeof(ISNRequest),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "requestDidComplete:", ParameterType = new Type[] { typeof(ISNRequest) }, ParameterByRef = new bool[] { false })]
public interface ISNResultsObserving : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("request:didProduceResult:")]
	[Preserve(Conditional = true)]
	void DidProduceResult(ISNRequest request, ISNResult result);
}

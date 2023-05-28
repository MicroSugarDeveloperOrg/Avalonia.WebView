using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "SKRequestDelegate", WrapperType = typeof(SKRequestDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestFinished", Selector = "requestDidFinish:", ParameterType = new Type[] { typeof(SKRequest) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestFailed", Selector = "request:didFailWithError:", ParameterType = new Type[]
{
	typeof(SKRequest),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface ISKRequestDelegate : INativeObject, IDisposable
{
}

using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "SKProductsRequestDelegate", WrapperType = typeof(SKProductsRequestDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "productsRequest:didReceiveResponse:", ParameterType = new Type[]
{
	typeof(SKProductsRequest),
	typeof(SKProductsResponse)
}, ParameterByRef = new bool[] { false, false })]
public interface ISKProductsRequestDelegate : INativeObject, IDisposable, ISKRequestDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("productsRequest:didReceiveResponse:")]
	[Preserve(Conditional = true)]
	void ReceivedResponse(SKProductsRequest request, SKProductsResponse response);
}

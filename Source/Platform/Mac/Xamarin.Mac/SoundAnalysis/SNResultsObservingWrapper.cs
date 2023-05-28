using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

internal sealed class SNResultsObservingWrapper : BaseWrapper, ISNResultsObserving, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SNResultsObservingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("request:didProduceResult:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidProduceResult(ISNRequest request, ISNResult result)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("request:didProduceResult:"), request.Handle, result.Handle);
	}
}

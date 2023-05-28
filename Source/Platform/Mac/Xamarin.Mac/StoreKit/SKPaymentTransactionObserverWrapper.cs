using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

internal sealed class SKPaymentTransactionObserverWrapper : BaseWrapper, ISKPaymentTransactionObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKPaymentTransactionObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("paymentQueue:updatedTransactions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void UpdatedTransactions(SKPaymentQueue queue, SKPaymentTransaction[] transactions)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (transactions == null)
		{
			throw new ArgumentNullException("transactions");
		}
		NSArray nSArray = NSArray.FromNSObjects(transactions);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("paymentQueue:updatedTransactions:"), queue.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}

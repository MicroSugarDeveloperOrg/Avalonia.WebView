using System;
using ObjCRuntime;

namespace StoreKit;

public static class SKPaymentQueueDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldContinueTransaction(this ISKPaymentQueueDelegate This, SKPaymentQueue paymentQueue, SKPaymentTransaction transaction, SKStorefront newStorefront)
	{
		if (paymentQueue == null)
		{
			throw new ArgumentNullException("paymentQueue");
		}
		if (transaction == null)
		{
			throw new ArgumentNullException("transaction");
		}
		if (newStorefront == null)
		{
			throw new ArgumentNullException("newStorefront");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("paymentQueue:shouldContinueTransaction:inStorefront:"), paymentQueue.Handle, transaction.Handle, newStorefront.Handle);
	}
}

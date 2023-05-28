using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

public static class SKPaymentTransactionObserver_Extensions
{
	[Obsolete("Use RestoreCompletedTransactionsFinished (SKPaymentQueue) instead.")]
	public static void PaymentQueueRestoreCompletedTransactionsFinished(ISKPaymentTransactionObserver This, SKPaymentQueue queue)
	{
		This.RestoreCompletedTransactionsFinished(queue);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemovedTransactions(this ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKPaymentTransaction[] transactions)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("paymentQueue:removedTransactions:"), queue.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RestoreCompletedTransactionsFailedWithError(this ISKPaymentTransactionObserver This, SKPaymentQueue queue, NSError error)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("paymentQueue:restoreCompletedTransactionsFailedWithError:"), queue.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RestoreCompletedTransactionsFinished(this ISKPaymentTransactionObserver This, SKPaymentQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("paymentQueueRestoreCompletedTransactionsFinished:"), queue.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedDownloads(this ISKPaymentTransactionObserver This, SKPaymentQueue queue, SKDownload[] downloads)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (downloads == null)
		{
			throw new ArgumentNullException("downloads");
		}
		NSArray nSArray = NSArray.FromNSObjects(downloads);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("paymentQueue:updatedDownloads:"), queue.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeStorefront(this ISKPaymentTransactionObserver This, SKPaymentQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("paymentQueueDidChangeStorefront:"), queue.Handle);
	}
}

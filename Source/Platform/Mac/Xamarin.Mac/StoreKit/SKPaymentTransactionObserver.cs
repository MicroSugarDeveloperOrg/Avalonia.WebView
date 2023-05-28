using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Protocol]
[Register("SKPaymentTransactionObserver", false)]
[Model]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public abstract class SKPaymentTransactionObserver : NSObject, ISKPaymentTransactionObserver, INativeObject, IDisposable
{
	[Obsolete("Use RestoreCompletedTransactionsFinished (SKPaymentQueue) instead.")]
	public virtual void PaymentQueueRestoreCompletedTransactionsFinished(SKPaymentQueue queue)
	{
		RestoreCompletedTransactionsFinished(queue);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected SKPaymentTransactionObserver()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKPaymentTransactionObserver(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPaymentTransactionObserver(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("paymentQueueDidChangeStorefront:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeStorefront(SKPaymentQueue queue)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("paymentQueue:removedTransactions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemovedTransactions(SKPaymentQueue queue, SKPaymentTransaction[] transactions)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("paymentQueue:restoreCompletedTransactionsFailedWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreCompletedTransactionsFailedWithError(SKPaymentQueue queue, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("paymentQueueRestoreCompletedTransactionsFinished:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreCompletedTransactionsFinished(SKPaymentQueue queue)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("paymentQueue:updatedDownloads:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedDownloads(SKPaymentQueue queue, SKDownload[] downloads)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("paymentQueue:updatedTransactions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void UpdatedTransactions(SKPaymentQueue queue, SKPaymentTransaction[] transactions);
}

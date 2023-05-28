using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKPaymentQueue", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKPaymentQueue : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPayment_ = "addPayment:";

	private static readonly IntPtr selAddPayment_Handle = Selector.GetHandle("addPayment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTransactionObserver_ = "addTransactionObserver:";

	private static readonly IntPtr selAddTransactionObserver_Handle = Selector.GetHandle("addTransactionObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanMakePayments = "canMakePayments";

	private static readonly IntPtr selCanMakePaymentsHandle = Selector.GetHandle("canMakePayments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelDownloads_ = "cancelDownloads:";

	private static readonly IntPtr selCancelDownloads_Handle = Selector.GetHandle("cancelDownloads:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultQueue = "defaultQueue";

	private static readonly IntPtr selDefaultQueueHandle = Selector.GetHandle("defaultQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishTransaction_ = "finishTransaction:";

	private static readonly IntPtr selFinishTransaction_Handle = Selector.GetHandle("finishTransaction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseDownloads_ = "pauseDownloads:";

	private static readonly IntPtr selPauseDownloads_Handle = Selector.GetHandle("pauseDownloads:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTransactionObserver_ = "removeTransactionObserver:";

	private static readonly IntPtr selRemoveTransactionObserver_Handle = Selector.GetHandle("removeTransactionObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreCompletedTransactions = "restoreCompletedTransactions";

	private static readonly IntPtr selRestoreCompletedTransactionsHandle = Selector.GetHandle("restoreCompletedTransactions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreCompletedTransactionsWithApplicationUsername_ = "restoreCompletedTransactionsWithApplicationUsername:";

	private static readonly IntPtr selRestoreCompletedTransactionsWithApplicationUsername_Handle = Selector.GetHandle("restoreCompletedTransactionsWithApplicationUsername:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeDownloads_ = "resumeDownloads:";

	private static readonly IntPtr selResumeDownloads_Handle = Selector.GetHandle("resumeDownloads:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDownloads_ = "startDownloads:";

	private static readonly IntPtr selStartDownloads_Handle = Selector.GetHandle("startDownloads:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStorefront = "storefront";

	private static readonly IntPtr selStorefrontHandle = Selector.GetHandle("storefront");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactions = "transactions";

	private static readonly IntPtr selTransactionsHandle = Selector.GetHandle("transactions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPaymentQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanMakePayments
	{
		[Export("canMakePayments")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selCanMakePaymentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPaymentQueue DefaultQueue
	{
		[Export("defaultQueue")]
		get
		{
			return Runtime.GetNSObject<SKPaymentQueue>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public ISKPaymentQueueDelegate? Delegate
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			return WeakDelegate as ISKPaymentQueueDelegate;
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual SKStorefront? Storefront
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("storefront")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKStorefront>(Messaging.IntPtr_objc_msgSend(base.Handle, selStorefrontHandle));
			}
			return Runtime.GetNSObject<SKStorefront>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStorefrontHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPaymentTransaction[] Transactions
	{
		[Export("transactions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionsHandle));
			}
			return NSArray.ArrayFromHandle<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSObject? WeakDelegate
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKPaymentQueue()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKPaymentQueue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPaymentQueue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addPayment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddPayment(SKPayment payment)
	{
		if (payment == null)
		{
			throw new ArgumentNullException("payment");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddPayment_Handle, payment.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddPayment_Handle, payment.Handle);
		}
	}

	[Export("addTransactionObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTransactionObserver(ISKPaymentTransactionObserver observer)
	{
		if (observer != null)
		{
			if (!(observer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + observer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTransactionObserver_Handle, observer.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTransactionObserver_Handle, observer.Handle);
			}
			return;
		}
		throw new ArgumentNullException("observer");
	}

	[Export("cancelDownloads:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelDownloads(SKDownload[] downloads)
	{
		if (downloads == null)
		{
			throw new ArgumentNullException("downloads");
		}
		NSArray nSArray = NSArray.FromNSObjects(downloads);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelDownloads_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelDownloads_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("finishTransaction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishTransaction(SKPaymentTransaction transaction)
	{
		if (transaction == null)
		{
			throw new ArgumentNullException("transaction");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishTransaction_Handle, transaction.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishTransaction_Handle, transaction.Handle);
		}
	}

	[Export("pauseDownloads:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseDownloads(SKDownload[] downloads)
	{
		if (downloads == null)
		{
			throw new ArgumentNullException("downloads");
		}
		NSArray nSArray = NSArray.FromNSObjects(downloads);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPauseDownloads_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPauseDownloads_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeTransactionObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTransactionObserver(ISKPaymentTransactionObserver observer)
	{
		if (observer != null)
		{
			if (!(observer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + observer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTransactionObserver_Handle, observer.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTransactionObserver_Handle, observer.Handle);
			}
			return;
		}
		throw new ArgumentNullException("observer");
	}

	[Export("restoreCompletedTransactions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreCompletedTransactions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRestoreCompletedTransactionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRestoreCompletedTransactionsHandle);
		}
	}

	[Export("restoreCompletedTransactionsWithApplicationUsername:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreCompletedTransactions(string? username)
	{
		IntPtr arg = NSString.CreateNative(username);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreCompletedTransactionsWithApplicationUsername_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreCompletedTransactionsWithApplicationUsername_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("resumeDownloads:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeDownloads(SKDownload[] downloads)
	{
		if (downloads == null)
		{
			throw new ArgumentNullException("downloads");
		}
		NSArray nSArray = NSArray.FromNSObjects(downloads);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeDownloads_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeDownloads_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("startDownloads:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartDownloads(SKDownload[] downloads)
	{
		if (downloads == null)
		{
			throw new ArgumentNullException("downloads");
		}
		NSArray nSArray = NSArray.FromNSObjects(downloads);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartDownloads_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartDownloads_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

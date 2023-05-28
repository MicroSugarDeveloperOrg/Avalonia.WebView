using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKPaymentTransaction", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKPaymentTransaction : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloads = "downloads";

	private static readonly IntPtr selDownloadsHandle = Selector.GetHandle("downloads");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginalTransaction = "originalTransaction";

	private static readonly IntPtr selOriginalTransactionHandle = Selector.GetHandle("originalTransaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPayment = "payment";

	private static readonly IntPtr selPaymentHandle = Selector.GetHandle("payment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactionDate = "transactionDate";

	private static readonly IntPtr selTransactionDateHandle = Selector.GetHandle("transactionDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactionIdentifier = "transactionIdentifier";

	private static readonly IntPtr selTransactionIdentifierHandle = Selector.GetHandle("transactionIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactionState = "transactionState";

	private static readonly IntPtr selTransactionStateHandle = Selector.GetHandle("transactionState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPaymentTransaction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKDownload[] Downloads
	{
		[Export("downloads")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKDownload>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadsHandle));
			}
			return NSArray.ArrayFromHandle<SKDownload>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPaymentTransaction? OriginalTransaction
	{
		[Export("originalTransaction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginalTransactionHandle));
			}
			return Runtime.GetNSObject<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginalTransactionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPayment Payment
	{
		[Export("payment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPayment>(Messaging.IntPtr_objc_msgSend(base.Handle, selPaymentHandle));
			}
			return Runtime.GetNSObject<SKPayment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaymentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? TransactionDate
	{
		[Export("transactionDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? TransactionIdentifier
	{
		[Export("transactionIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPaymentTransactionState TransactionState
	{
		[Export("transactionState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKPaymentTransactionState)Messaging.Int64_objc_msgSend(base.Handle, selTransactionStateHandle);
			}
			return (SKPaymentTransactionState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransactionStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKPaymentTransaction()
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
	protected SKPaymentTransaction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPaymentTransaction(IntPtr handle)
		: base(handle)
	{
	}
}

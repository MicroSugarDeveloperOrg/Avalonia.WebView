using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKDatabase", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKDatabase : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOperation_ = "addOperation:";

	private static readonly IntPtr selAddOperation_Handle = Selector.GetHandle("addOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatabaseScope = "databaseScope";

	private static readonly IntPtr selDatabaseScopeHandle = Selector.GetHandle("databaseScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteRecordWithID_CompletionHandler_ = "deleteRecordWithID:completionHandler:";

	private static readonly IntPtr selDeleteRecordWithID_CompletionHandler_Handle = Selector.GetHandle("deleteRecordWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteRecordZoneWithID_CompletionHandler_ = "deleteRecordZoneWithID:completionHandler:";

	private static readonly IntPtr selDeleteRecordZoneWithID_CompletionHandler_Handle = Selector.GetHandle("deleteRecordZoneWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSubscriptionWithID_CompletionHandler_ = "deleteSubscriptionWithID:completionHandler:";

	private static readonly IntPtr selDeleteSubscriptionWithID_CompletionHandler_Handle = Selector.GetHandle("deleteSubscriptionWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllRecordZonesWithCompletionHandler_ = "fetchAllRecordZonesWithCompletionHandler:";

	private static readonly IntPtr selFetchAllRecordZonesWithCompletionHandler_Handle = Selector.GetHandle("fetchAllRecordZonesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllSubscriptionsWithCompletionHandler_ = "fetchAllSubscriptionsWithCompletionHandler:";

	private static readonly IntPtr selFetchAllSubscriptionsWithCompletionHandler_Handle = Selector.GetHandle("fetchAllSubscriptionsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordWithID_CompletionHandler_ = "fetchRecordWithID:completionHandler:";

	private static readonly IntPtr selFetchRecordWithID_CompletionHandler_Handle = Selector.GetHandle("fetchRecordWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRecordZoneWithID_CompletionHandler_ = "fetchRecordZoneWithID:completionHandler:";

	private static readonly IntPtr selFetchRecordZoneWithID_CompletionHandler_Handle = Selector.GetHandle("fetchRecordZoneWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchSubscriptionWithID_CompletionHandler_ = "fetchSubscriptionWithID:completionHandler:";

	private static readonly IntPtr selFetchSubscriptionWithID_CompletionHandler_Handle = Selector.GetHandle("fetchSubscriptionWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformQuery_InZoneWithID_CompletionHandler_ = "performQuery:inZoneWithID:completionHandler:";

	private static readonly IntPtr selPerformQuery_InZoneWithID_CompletionHandler_Handle = Selector.GetHandle("performQuery:inZoneWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveRecord_CompletionHandler_ = "saveRecord:completionHandler:";

	private static readonly IntPtr selSaveRecord_CompletionHandler_Handle = Selector.GetHandle("saveRecord:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveRecordZone_CompletionHandler_ = "saveRecordZone:completionHandler:";

	private static readonly IntPtr selSaveRecordZone_CompletionHandler_Handle = Selector.GetHandle("saveRecordZone:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveSubscription_CompletionHandler_ = "saveSubscription:completionHandler:";

	private static readonly IntPtr selSaveSubscription_CompletionHandler_Handle = Selector.GetHandle("saveSubscription:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKDatabase");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual CKDatabaseScope DatabaseScope
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("databaseScope", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKDatabaseScope)Messaging.Int64_objc_msgSend(base.Handle, selDatabaseScopeHandle);
			}
			return (CKDatabaseScope)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDatabaseScopeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKDatabase(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKDatabase(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOperation(CKDatabaseOperation operation)
	{
		if (operation == null)
		{
			throw new ArgumentNullException("operation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOperation_Handle, operation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOperation_Handle, operation.Handle);
		}
	}

	[Export("deleteRecordWithID:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeleteRecord(CKRecordID recordId, [BlockProxy(typeof(Trampolines.NIDActionArity2V22))] Action<CKRecordID, NSError> completionHandler)
	{
		if (recordId == null)
		{
			throw new ArgumentNullException("recordId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V22.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeleteRecordWithID_CompletionHandler_Handle, recordId.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeleteRecordWithID_CompletionHandler_Handle, recordId.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordID> DeleteRecordAsync(CKRecordID recordId)
	{
		TaskCompletionSource<CKRecordID> tcs = new TaskCompletionSource<CKRecordID>();
		DeleteRecord(recordId, delegate(CKRecordID arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("deleteRecordZoneWithID:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeleteRecordZone(CKRecordZoneID zoneId, [BlockProxy(typeof(Trampolines.NIDActionArity2V25))] Action<CKRecordZoneID, NSError> completionHandler)
	{
		if (zoneId == null)
		{
			throw new ArgumentNullException("zoneId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V25.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeleteRecordZoneWithID_CompletionHandler_Handle, zoneId.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeleteRecordZoneWithID_CompletionHandler_Handle, zoneId.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordZoneID> DeleteRecordZoneAsync(CKRecordZoneID zoneId)
	{
		TaskCompletionSource<CKRecordZoneID> tcs = new TaskCompletionSource<CKRecordZoneID>();
		DeleteRecordZone(zoneId, delegate(CKRecordZoneID arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("deleteSubscriptionWithID:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeleteSubscription(string subscriptionID, [BlockProxy(typeof(Trampolines.NIDCKDatabaseDeleteSubscriptionHandler))] CKDatabaseDeleteSubscriptionHandler completionHandler)
	{
		if (subscriptionID == null)
		{
			throw new ArgumentNullException("subscriptionID");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(subscriptionID);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCKDatabaseDeleteSubscriptionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeleteSubscriptionWithID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeleteSubscriptionWithID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string> DeleteSubscriptionAsync(string subscriptionID)
	{
		TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
		DeleteSubscription(subscriptionID, delegate(string subscriptionId_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(subscriptionId_);
			}
		});
		return tcs.Task;
	}

	[Export("fetchAllRecordZonesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchAllRecordZones([BlockProxy(typeof(Trampolines.NIDActionArity2V26))] Action<CKRecordZone[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V26.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchAllRecordZonesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchAllRecordZonesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordZone[]> FetchAllRecordZonesAsync()
	{
		TaskCompletionSource<CKRecordZone[]> tcs = new TaskCompletionSource<CKRecordZone[]>();
		FetchAllRecordZones(delegate(CKRecordZone[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("fetchAllSubscriptionsWithCompletionHandler:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchAllSubscriptions([BlockProxy(typeof(Trampolines.NIDActionArity2V27))] Action<CKSubscription[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V27.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchAllSubscriptionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchAllSubscriptionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKSubscription[]> FetchAllSubscriptionsAsync()
	{
		TaskCompletionSource<CKSubscription[]> tcs = new TaskCompletionSource<CKSubscription[]>();
		FetchAllSubscriptions(delegate(CKSubscription[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("fetchRecordWithID:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchRecord(CKRecordID recordId, [BlockProxy(typeof(Trampolines.NIDActionArity2V28))] Action<CKRecord, NSError> completionHandler)
	{
		if (recordId == null)
		{
			throw new ArgumentNullException("recordId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V28.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchRecordWithID_CompletionHandler_Handle, recordId.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchRecordWithID_CompletionHandler_Handle, recordId.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecord> FetchRecordAsync(CKRecordID recordId)
	{
		TaskCompletionSource<CKRecord> tcs = new TaskCompletionSource<CKRecord>();
		FetchRecord(recordId, delegate(CKRecord arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("fetchRecordZoneWithID:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchRecordZone(CKRecordZoneID zoneId, [BlockProxy(typeof(Trampolines.NIDActionArity2V29))] Action<CKRecordZone, NSError> completionHandler)
	{
		if (zoneId == null)
		{
			throw new ArgumentNullException("zoneId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V29.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchRecordZoneWithID_CompletionHandler_Handle, zoneId.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchRecordZoneWithID_CompletionHandler_Handle, zoneId.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordZone> FetchRecordZoneAsync(CKRecordZoneID zoneId)
	{
		TaskCompletionSource<CKRecordZone> tcs = new TaskCompletionSource<CKRecordZone>();
		FetchRecordZone(zoneId, delegate(CKRecordZone arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("fetchSubscriptionWithID:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchSubscription(string subscriptionId, [BlockProxy(typeof(Trampolines.NIDActionArity2V30))] Action<CKSubscription, NSError> completionHandler)
	{
		if (subscriptionId == null)
		{
			throw new ArgumentNullException("subscriptionId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(subscriptionId);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V30.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchSubscriptionWithID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchSubscriptionWithID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKSubscription> FetchSubscriptionAsync(string subscriptionId)
	{
		TaskCompletionSource<CKSubscription> tcs = new TaskCompletionSource<CKSubscription>();
		FetchSubscription(subscriptionId, delegate(CKSubscription arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("performQuery:inZoneWithID:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformQuery(CKQuery query, CKRecordZoneID? zoneId, [BlockProxy(typeof(Trampolines.NIDActionArity2V31))] Action<CKRecord[], NSError> completionHandler)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V31.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPerformQuery_InZoneWithID_CompletionHandler_Handle, query.Handle, zoneId?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPerformQuery_InZoneWithID_CompletionHandler_Handle, query.Handle, zoneId?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecord[]> PerformQueryAsync(CKQuery query, CKRecordZoneID? zoneId)
	{
		TaskCompletionSource<CKRecord[]> tcs = new TaskCompletionSource<CKRecord[]>();
		PerformQuery(query, zoneId, delegate(CKRecord[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("saveRecord:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveRecord(CKRecord record, [BlockProxy(typeof(Trampolines.NIDActionArity2V28))] Action<CKRecord, NSError> completionHandler)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V28.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveRecord_CompletionHandler_Handle, record.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveRecord_CompletionHandler_Handle, record.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecord> SaveRecordAsync(CKRecord record)
	{
		TaskCompletionSource<CKRecord> tcs = new TaskCompletionSource<CKRecord>();
		SaveRecord(record, delegate(CKRecord arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("saveRecordZone:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveRecordZone(CKRecordZone zone, [BlockProxy(typeof(Trampolines.NIDActionArity2V29))] Action<CKRecordZone, NSError> completionHandler)
	{
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V29.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveRecordZone_CompletionHandler_Handle, zone.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveRecordZone_CompletionHandler_Handle, zone.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordZone> SaveRecordZoneAsync(CKRecordZone zone)
	{
		TaskCompletionSource<CKRecordZone> tcs = new TaskCompletionSource<CKRecordZone>();
		SaveRecordZone(zone, delegate(CKRecordZone arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("saveSubscription:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveSubscription(CKSubscription subscription, [BlockProxy(typeof(Trampolines.NIDActionArity2V30))] Action<CKSubscription, NSError> completionHandler)
	{
		if (subscription == null)
		{
			throw new ArgumentNullException("subscription");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V30.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveSubscription_CompletionHandler_Handle, subscription.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveSubscription_CompletionHandler_Handle, subscription.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKSubscription> SaveSubscriptionAsync(CKSubscription subscription)
	{
		TaskCompletionSource<CKSubscription> tcs = new TaskCompletionSource<CKSubscription>();
		SaveSubscription(subscription, delegate(CKSubscription arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMetadataQuery", true)]
public class NSMetadataQuery : NSObject
{
	[Register]
	private sealed class _NSMetadataQueryDelegate : NSMetadataQueryDelegate
	{
		internal NSMetadataQueryObject replacementObjectForResultObject;

		internal NSMetadataQueryValue replacementValueForAttributevalue;

		[Preserve(Conditional = true)]
		public override NSObject ReplacementObjectForResultObject(NSMetadataQuery query, NSMetadataItem result)
		{
			return replacementObjectForResultObject?.Invoke(query, result);
		}

		[Preserve(Conditional = true)]
		public override NSObject ReplacementValueForAttributevalue(NSMetadataQuery query, string attributeName, NSObject value)
		{
			return replacementValueForAttributevalue?.Invoke(query, attributeName, value);
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveDidStartGathering(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidStartGatheringNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveGatheringProgress(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(GatheringProgressNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidFinishGathering(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidFinishGatheringNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUpdate(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selIsStartedHandle = Selector.GetHandle("isStarted");

	private static readonly IntPtr selIsGatheringHandle = Selector.GetHandle("isGathering");

	private static readonly IntPtr selIsStoppedHandle = Selector.GetHandle("isStopped");

	private static readonly IntPtr selResultCountHandle = Selector.GetHandle("resultCount");

	private static readonly IntPtr selResultsHandle = Selector.GetHandle("results");

	private static readonly IntPtr selValueListsHandle = Selector.GetHandle("valueLists");

	private static readonly IntPtr selGroupedResultsHandle = Selector.GetHandle("groupedResults");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	private static readonly IntPtr selValueListAttributesHandle = Selector.GetHandle("valueListAttributes");

	private static readonly IntPtr selSetValueListAttributes_Handle = Selector.GetHandle("setValueListAttributes:");

	private static readonly IntPtr selGroupingAttributesHandle = Selector.GetHandle("groupingAttributes");

	private static readonly IntPtr selSetGroupingAttributes_Handle = Selector.GetHandle("setGroupingAttributes:");

	private static readonly IntPtr selNotificationBatchingIntervalHandle = Selector.GetHandle("notificationBatchingInterval");

	private static readonly IntPtr selSetNotificationBatchingInterval_Handle = Selector.GetHandle("setNotificationBatchingInterval:");

	private static readonly IntPtr selSearchScopesHandle = Selector.GetHandle("searchScopes");

	private static readonly IntPtr selSetSearchScopes_Handle = Selector.GetHandle("setSearchScopes:");

	private static readonly IntPtr selStartQueryHandle = Selector.GetHandle("startQuery");

	private static readonly IntPtr selStopQueryHandle = Selector.GetHandle("stopQuery");

	private static readonly IntPtr selDisableUpdatesHandle = Selector.GetHandle("disableUpdates");

	private static readonly IntPtr selEnableUpdatesHandle = Selector.GetHandle("enableUpdates");

	private static readonly IntPtr selResultAtIndex_Handle = Selector.GetHandle("resultAtIndex:");

	private static readonly IntPtr selIndexOfResult_Handle = Selector.GetHandle("indexOfResult:");

	private static readonly IntPtr selValueOfAttributeForResultAtIndex_Handle = Selector.GetHandle("valueOfAttribute:forResultAtIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMetadataQuery");

	private object __mt_Results_var;

	private object __mt_ValueLists_var;

	private object __mt_GroupedResults_var;

	private object __mt_WeakDelegate_var;

	private object __mt_Predicate_var;

	private object __mt_SortDescriptors_var;

	private object __mt_ValueListAttributes_var;

	private object __mt_GroupingAttributes_var;

	private object __mt_SearchScopes_var;

	private static NSString _DidStartGatheringNotification;

	private static NSString _GatheringProgressNotification;

	private static NSString _DidFinishGatheringNotification;

	private static NSString _DidUpdateNotification;

	private static NSString _ResultContentRelevanceAttribute;

	private static NSString _UserHomeScope;

	private static NSString _LocalComputerScope;

	private static NSString _QueryNetworkScope;

	private static NSString _QueryLocalDocumentsScope;

	private static NSString _QueryUbiquitousDocumentsScope;

	private static NSString _QueryUbiquitousDataScope;

	private static NSString _ItemFSNameKey;

	private static NSString _ItemDisplayNameKey;

	private static NSString _ItemURLKey;

	private static NSString _ItemPathKey;

	private static NSString _ItemFSSizeKey;

	private static NSString _ItemFSCreationDateKey;

	private static NSString _ItemFSContentChangeDateKey;

	private static NSString _ItemIsUbiquitousKey;

	private static NSString _UbiquitousItemHasUnresolvedConflictsKey;

	private static NSString _UbiquitousItemIsDownloadedKey;

	private static NSString _UbiquitousItemIsDownloadingKey;

	private static NSString _UbiquitousItemIsUploadedKey;

	private static NSString _UbiquitousItemIsUploadingKey;

	private static NSString _UbiquitousItemPercentDownloadedKey;

	private static NSString _UbiquitousItemPercentUploadedKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsStarted
	{
		[Export("isStarted")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStartedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStartedHandle);
		}
	}

	public virtual bool IsGathering
	{
		[Export("isGathering")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGatheringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGatheringHandle);
		}
	}

	public virtual bool IsStopped
	{
		[Export("isStopped")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStoppedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStoppedHandle);
		}
	}

	public virtual ulong ResultCount
	{
		[Export("resultCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selResultCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultCountHandle);
		}
	}

	public virtual NSMetadataItem[] Results
	{
		[Export("results")]
		get
		{
			return (NSMetadataItem[])(__mt_Results_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultsHandle)) : NSArray.ArrayFromHandle<NSMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultsHandle))));
		}
	}

	public virtual NSDictionary ValueLists
	{
		[Export("valueLists")]
		get
		{
			return (NSDictionary)(__mt_ValueLists_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueListsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueListsHandle)))));
		}
	}

	public virtual NSObject[] GroupedResults
	{
		[Export("groupedResults")]
		get
		{
			return (NSObject[])(__mt_GroupedResults_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupedResultsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupedResultsHandle))));
		}
	}

	public virtual NSMetadataQueryDelegate WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSMetadataQueryDelegate)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? ((NSMetadataQueryDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSMetadataQueryDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSMetadataQueryDelegate Delegate
	{
		get
		{
			return WeakDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSPredicate Predicate
	{
		[Export("predicate")]
		get
		{
			return (NSPredicate)(__mt_Predicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle)))));
		}
		[Export("setPredicate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value.Handle);
			}
			__mt_Predicate_var = value;
		}
	}

	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors")]
		get
		{
			return (NSSortDescriptor[])(__mt_SortDescriptors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle)) : NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle))));
		}
		[Export("setSortDescriptors:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SortDescriptors_var = value;
		}
	}

	public virtual NSObject[] ValueListAttributes
	{
		[Export("valueListAttributes")]
		get
		{
			return (NSObject[])(__mt_ValueListAttributes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueListAttributesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueListAttributesHandle))));
		}
		[Export("setValueListAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueListAttributes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueListAttributes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_ValueListAttributes_var = value;
		}
	}

	public virtual NSArray GroupingAttributes
	{
		[Export("groupingAttributes")]
		get
		{
			return (NSArray)(__mt_GroupingAttributes_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupingAttributesHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupingAttributesHandle)))));
		}
		[Export("setGroupingAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupingAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupingAttributes_Handle, value.Handle);
			}
			__mt_GroupingAttributes_var = value;
		}
	}

	public virtual double NotificationBatchingInterval
	{
		[Export("notificationBatchingInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selNotificationBatchingIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selNotificationBatchingIntervalHandle);
		}
		[Export("setNotificationBatchingInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetNotificationBatchingInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetNotificationBatchingInterval_Handle, value);
			}
		}
	}

	public virtual NSObject[] SearchScopes
	{
		[Export("searchScopes")]
		get
		{
			return (NSObject[])(__mt_SearchScopes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchScopesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchScopesHandle))));
		}
		[Export("setSearchScopes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSearchScopes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSearchScopes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SearchScopes_var = value;
		}
	}

	[Field("NSMetadataQueryDidStartGatheringNotification", "Foundation")]
	public static NSString DidStartGatheringNotification
	{
		get
		{
			if (_DidStartGatheringNotification == null)
			{
				_DidStartGatheringNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidStartGatheringNotification");
			}
			return _DidStartGatheringNotification;
		}
	}

	[Field("NSMetadataQueryGatheringProgressNotification", "Foundation")]
	public static NSString GatheringProgressNotification
	{
		get
		{
			if (_GatheringProgressNotification == null)
			{
				_GatheringProgressNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryGatheringProgressNotification");
			}
			return _GatheringProgressNotification;
		}
	}

	[Field("NSMetadataQueryDidFinishGatheringNotification", "Foundation")]
	public static NSString DidFinishGatheringNotification
	{
		get
		{
			if (_DidFinishGatheringNotification == null)
			{
				_DidFinishGatheringNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidFinishGatheringNotification");
			}
			return _DidFinishGatheringNotification;
		}
	}

	[Field("NSMetadataQueryDidUpdateNotification", "Foundation")]
	public static NSString DidUpdateNotification
	{
		get
		{
			if (_DidUpdateNotification == null)
			{
				_DidUpdateNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryDidUpdateNotification");
			}
			return _DidUpdateNotification;
		}
	}

	[Field("NSMetadataQueryResultContentRelevanceAttribute", "Foundation")]
	public static NSString ResultContentRelevanceAttribute
	{
		get
		{
			if (_ResultContentRelevanceAttribute == null)
			{
				_ResultContentRelevanceAttribute = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryResultContentRelevanceAttribute");
			}
			return _ResultContentRelevanceAttribute;
		}
	}

	[Field("NSMetadataQueryUserHomeScope", "Foundation")]
	public static NSString UserHomeScope
	{
		get
		{
			if (_UserHomeScope == null)
			{
				_UserHomeScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUserHomeScope");
			}
			return _UserHomeScope;
		}
	}

	[Field("NSMetadataQueryLocalComputerScope", "Foundation")]
	public static NSString LocalComputerScope
	{
		get
		{
			if (_LocalComputerScope == null)
			{
				_LocalComputerScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryLocalComputerScope");
			}
			return _LocalComputerScope;
		}
	}

	[Field("NSMetadataQueryNetworkScope", "Foundation")]
	public static NSString QueryNetworkScope
	{
		get
		{
			if (_QueryNetworkScope == null)
			{
				_QueryNetworkScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryNetworkScope");
			}
			return _QueryNetworkScope;
		}
	}

	[Field("NSMetadataQueryLocalDocumentsScope", "Foundation")]
	public static NSString QueryLocalDocumentsScope
	{
		get
		{
			if (_QueryLocalDocumentsScope == null)
			{
				_QueryLocalDocumentsScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryLocalDocumentsScope");
			}
			return _QueryLocalDocumentsScope;
		}
	}

	[Field("NSMetadataQueryUbiquitousDocumentsScope", "Foundation")]
	public static NSString QueryUbiquitousDocumentsScope
	{
		get
		{
			if (_QueryUbiquitousDocumentsScope == null)
			{
				_QueryUbiquitousDocumentsScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDocumentsScope");
			}
			return _QueryUbiquitousDocumentsScope;
		}
	}

	[Field("NSMetadataQueryUbiquitousDataScope", "Foundation")]
	public static NSString QueryUbiquitousDataScope
	{
		get
		{
			if (_QueryUbiquitousDataScope == null)
			{
				_QueryUbiquitousDataScope = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataQueryUbiquitousDataScope");
			}
			return _QueryUbiquitousDataScope;
		}
	}

	[Field("NSMetadataItemFSNameKey", "Foundation")]
	public static NSString ItemFSNameKey
	{
		get
		{
			if (_ItemFSNameKey == null)
			{
				_ItemFSNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSNameKey");
			}
			return _ItemFSNameKey;
		}
	}

	[Field("NSMetadataItemDisplayNameKey", "Foundation")]
	public static NSString ItemDisplayNameKey
	{
		get
		{
			if (_ItemDisplayNameKey == null)
			{
				_ItemDisplayNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemDisplayNameKey");
			}
			return _ItemDisplayNameKey;
		}
	}

	[Field("NSMetadataItemURLKey", "Foundation")]
	public static NSString ItemURLKey
	{
		get
		{
			if (_ItemURLKey == null)
			{
				_ItemURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemURLKey");
			}
			return _ItemURLKey;
		}
	}

	[Field("NSMetadataItemPathKey", "Foundation")]
	public static NSString ItemPathKey
	{
		get
		{
			if (_ItemPathKey == null)
			{
				_ItemPathKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemPathKey");
			}
			return _ItemPathKey;
		}
	}

	[Field("NSMetadataItemFSSizeKey", "Foundation")]
	public static NSString ItemFSSizeKey
	{
		get
		{
			if (_ItemFSSizeKey == null)
			{
				_ItemFSSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSSizeKey");
			}
			return _ItemFSSizeKey;
		}
	}

	[Field("NSMetadataItemFSCreationDateKey", "Foundation")]
	public static NSString ItemFSCreationDateKey
	{
		get
		{
			if (_ItemFSCreationDateKey == null)
			{
				_ItemFSCreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSCreationDateKey");
			}
			return _ItemFSCreationDateKey;
		}
	}

	[Field("NSMetadataItemFSContentChangeDateKey", "Foundation")]
	public static NSString ItemFSContentChangeDateKey
	{
		get
		{
			if (_ItemFSContentChangeDateKey == null)
			{
				_ItemFSContentChangeDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemFSContentChangeDateKey");
			}
			return _ItemFSContentChangeDateKey;
		}
	}

	[Field("NSMetadataItemIsUbiquitousKey", "Foundation")]
	public static NSString ItemIsUbiquitousKey
	{
		get
		{
			if (_ItemIsUbiquitousKey == null)
			{
				_ItemIsUbiquitousKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataItemIsUbiquitousKey");
			}
			return _ItemIsUbiquitousKey;
		}
	}

	[Field("NSMetadataUbiquitousItemHasUnresolvedConflictsKey", "Foundation")]
	public static NSString UbiquitousItemHasUnresolvedConflictsKey
	{
		get
		{
			if (_UbiquitousItemHasUnresolvedConflictsKey == null)
			{
				_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemHasUnresolvedConflictsKey");
			}
			return _UbiquitousItemHasUnresolvedConflictsKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadedKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadedKey == null)
			{
				_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadedKey");
			}
			return _UbiquitousItemIsDownloadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsDownloadingKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadingKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadingKey == null)
			{
				_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsDownloadingKey");
			}
			return _UbiquitousItemIsDownloadingKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsUploadedKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadedKey
	{
		get
		{
			if (_UbiquitousItemIsUploadedKey == null)
			{
				_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadedKey");
			}
			return _UbiquitousItemIsUploadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemIsUploadingKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadingKey
	{
		get
		{
			if (_UbiquitousItemIsUploadingKey == null)
			{
				_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemIsUploadingKey");
			}
			return _UbiquitousItemIsUploadingKey;
		}
	}

	[Field("NSMetadataUbiquitousItemPercentDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentDownloadedKey
	{
		get
		{
			if (_UbiquitousItemPercentDownloadedKey == null)
			{
				_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentDownloadedKey");
			}
			return _UbiquitousItemPercentDownloadedKey;
		}
	}

	[Field("NSMetadataUbiquitousItemPercentUploadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentUploadedKey
	{
		get
		{
			if (_UbiquitousItemPercentUploadedKey == null)
			{
				_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMetadataUbiquitousItemPercentUploadedKey");
			}
			return _UbiquitousItemPercentUploadedKey;
		}
	}

	public NSMetadataQueryObject ReplacementObjectForResultObject
	{
		get
		{
			return EnsureNSMetadataQueryDelegate().replacementObjectForResultObject;
		}
		set
		{
			EnsureNSMetadataQueryDelegate().replacementObjectForResultObject = value;
		}
	}

	public NSMetadataQueryValue ReplacementValueForAttributevalue
	{
		get
		{
			return EnsureNSMetadataQueryDelegate().replacementValueForAttributevalue;
		}
		set
		{
			EnsureNSMetadataQueryDelegate().replacementValueForAttributevalue = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQuery()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMetadataQuery(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataQuery(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataQuery(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startQuery")]
	public virtual bool StartQuery()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartQueryHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartQueryHandle);
	}

	[Export("stopQuery")]
	public virtual void StopQuery()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopQueryHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopQueryHandle);
		}
	}

	[Export("disableUpdates")]
	public virtual void DisableUpdates()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableUpdatesHandle);
		}
	}

	[Export("enableUpdates")]
	public virtual void EnableUpdates()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableUpdatesHandle);
		}
	}

	[Export("resultAtIndex:")]
	public virtual NSObject ResultAtIndex(ulong idx)
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selResultAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selResultAtIndex_Handle, idx));
	}

	[Export("indexOfResult:")]
	public virtual ulong IndexOfResult(NSObject result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selIndexOfResult_Handle, result.Handle);
		}
		return Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfResult_Handle, result.Handle);
	}

	[Export("valueOfAttribute:forResultAtIndex:")]
	public virtual NSObject ValueOfAttribute(string attribyteName, ulong atIndex)
	{
		if (attribyteName == null)
		{
			throw new ArgumentNullException("attribyteName");
		}
		IntPtr arg = NSString.CreateNative(attribyteName);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selValueOfAttributeForResultAtIndex_Handle, arg, atIndex)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selValueOfAttributeForResultAtIndex_Handle, arg, atIndex)));
		NSString.ReleaseNative(arg);
		return result;
	}

	private _NSMetadataQueryDelegate EnsureNSMetadataQueryDelegate()
	{
		NSMetadataQueryDelegate nSMetadataQueryDelegate = Delegate;
		if (nSMetadataQueryDelegate == null || !(nSMetadataQueryDelegate is _NSMetadataQueryDelegate))
		{
			nSMetadataQueryDelegate = (Delegate = new _NSMetadataQueryDelegate());
		}
		return (_NSMetadataQueryDelegate)nSMetadataQueryDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Results_var = null;
			__mt_ValueLists_var = null;
			__mt_GroupedResults_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Predicate_var = null;
			__mt_SortDescriptors_var = null;
			__mt_ValueListAttributes_var = null;
			__mt_GroupingAttributes_var = null;
			__mt_SearchScopes_var = null;
		}
	}
}

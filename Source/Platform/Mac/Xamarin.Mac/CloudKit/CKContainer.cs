using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKContainer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKContainer : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveAccountChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AccountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAccountChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AccountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptShareMetadata_CompletionHandler_ = "acceptShareMetadata:completionHandler:";

	private static readonly IntPtr selAcceptShareMetadata_CompletionHandler_Handle = Selector.GetHandle("acceptShareMetadata:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountStatusWithCompletionHandler_ = "accountStatusWithCompletionHandler:";

	private static readonly IntPtr selAccountStatusWithCompletionHandler_Handle = Selector.GetHandle("accountStatusWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOperation_ = "addOperation:";

	private static readonly IntPtr selAddOperation_Handle = Selector.GetHandle("addOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerIdentifier = "containerIdentifier";

	private static readonly IntPtr selContainerIdentifierHandle = Selector.GetHandle("containerIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerWithIdentifier_ = "containerWithIdentifier:";

	private static readonly IntPtr selContainerWithIdentifier_Handle = Selector.GetHandle("containerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatabaseWithDatabaseScope_ = "databaseWithDatabaseScope:";

	private static readonly IntPtr selDatabaseWithDatabaseScope_Handle = Selector.GetHandle("databaseWithDatabaseScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultContainer = "defaultContainer";

	private static readonly IntPtr selDefaultContainerHandle = Selector.GetHandle("defaultContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverAllContactUserInfosWithCompletionHandler_ = "discoverAllContactUserInfosWithCompletionHandler:";

	private static readonly IntPtr selDiscoverAllContactUserInfosWithCompletionHandler_Handle = Selector.GetHandle("discoverAllContactUserInfosWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverAllIdentitiesWithCompletionHandler_ = "discoverAllIdentitiesWithCompletionHandler:";

	private static readonly IntPtr selDiscoverAllIdentitiesWithCompletionHandler_Handle = Selector.GetHandle("discoverAllIdentitiesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserIdentityWithEmailAddress_CompletionHandler_ = "discoverUserIdentityWithEmailAddress:completionHandler:";

	private static readonly IntPtr selDiscoverUserIdentityWithEmailAddress_CompletionHandler_Handle = Selector.GetHandle("discoverUserIdentityWithEmailAddress:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_ = "discoverUserIdentityWithPhoneNumber:completionHandler:";

	private static readonly IntPtr selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_Handle = Selector.GetHandle("discoverUserIdentityWithPhoneNumber:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserIdentityWithUserRecordID_CompletionHandler_ = "discoverUserIdentityWithUserRecordID:completionHandler:";

	private static readonly IntPtr selDiscoverUserIdentityWithUserRecordID_CompletionHandler_Handle = Selector.GetHandle("discoverUserIdentityWithUserRecordID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserInfoWithEmailAddress_CompletionHandler_ = "discoverUserInfoWithEmailAddress:completionHandler:";

	private static readonly IntPtr selDiscoverUserInfoWithEmailAddress_CompletionHandler_Handle = Selector.GetHandle("discoverUserInfoWithEmailAddress:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserInfoWithUserRecordID_CompletionHandler_ = "discoverUserInfoWithUserRecordID:completionHandler:";

	private static readonly IntPtr selDiscoverUserInfoWithUserRecordID_CompletionHandler_Handle = Selector.GetHandle("discoverUserInfoWithUserRecordID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllLongLivedOperationIDsWithCompletionHandler_ = "fetchAllLongLivedOperationIDsWithCompletionHandler:";

	private static readonly IntPtr selFetchAllLongLivedOperationIDsWithCompletionHandler_Handle = Selector.GetHandle("fetchAllLongLivedOperationIDsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchLongLivedOperationWithID_CompletionHandler_ = "fetchLongLivedOperationWithID:completionHandler:";

	private static readonly IntPtr selFetchLongLivedOperationWithID_CompletionHandler_Handle = Selector.GetHandle("fetchLongLivedOperationWithID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareMetadataWithURL_CompletionHandler_ = "fetchShareMetadataWithURL:completionHandler:";

	private static readonly IntPtr selFetchShareMetadataWithURL_CompletionHandler_Handle = Selector.GetHandle("fetchShareMetadataWithURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareParticipantWithEmailAddress_CompletionHandler_ = "fetchShareParticipantWithEmailAddress:completionHandler:";

	private static readonly IntPtr selFetchShareParticipantWithEmailAddress_CompletionHandler_Handle = Selector.GetHandle("fetchShareParticipantWithEmailAddress:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareParticipantWithPhoneNumber_CompletionHandler_ = "fetchShareParticipantWithPhoneNumber:completionHandler:";

	private static readonly IntPtr selFetchShareParticipantWithPhoneNumber_CompletionHandler_Handle = Selector.GetHandle("fetchShareParticipantWithPhoneNumber:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareParticipantWithUserRecordID_CompletionHandler_ = "fetchShareParticipantWithUserRecordID:completionHandler:";

	private static readonly IntPtr selFetchShareParticipantWithUserRecordID_CompletionHandler_Handle = Selector.GetHandle("fetchShareParticipantWithUserRecordID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchUserRecordIDWithCompletionHandler_ = "fetchUserRecordIDWithCompletionHandler:";

	private static readonly IntPtr selFetchUserRecordIDWithCompletionHandler_Handle = Selector.GetHandle("fetchUserRecordIDWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrivateCloudDatabase = "privateCloudDatabase";

	private static readonly IntPtr selPrivateCloudDatabaseHandle = Selector.GetHandle("privateCloudDatabase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublicCloudDatabase = "publicCloudDatabase";

	private static readonly IntPtr selPublicCloudDatabaseHandle = Selector.GetHandle("publicCloudDatabase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestApplicationPermission_CompletionHandler_ = "requestApplicationPermission:completionHandler:";

	private static readonly IntPtr selRequestApplicationPermission_CompletionHandler_Handle = Selector.GetHandle("requestApplicationPermission:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCloudDatabase = "sharedCloudDatabase";

	private static readonly IntPtr selSharedCloudDatabaseHandle = Selector.GetHandle("sharedCloudDatabase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusForApplicationPermission_CompletionHandler_ = "statusForApplicationPermission:completionHandler:";

	private static readonly IntPtr selStatusForApplicationPermission_CompletionHandler_Handle = Selector.GetHandle("statusForApplicationPermission:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccountChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentUserDefaultName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OwnerDefaultName;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ContainerIdentifier
	{
		[Export("containerIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContainerIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContainerIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKContainer DefaultContainer
	{
		[Export("defaultContainer")]
		get
		{
			return Runtime.GetNSObject<CKContainer>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKDatabase PrivateCloudDatabase
	{
		[Export("privateCloudDatabase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrivateCloudDatabaseHandle));
			}
			return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrivateCloudDatabaseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKDatabase PublicCloudDatabase
	{
		[Export("publicCloudDatabase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSend(base.Handle, selPublicCloudDatabaseHandle));
			}
			return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPublicCloudDatabaseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual CKDatabase SharedCloudDatabase
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("sharedCloudDatabase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSend(base.Handle, selSharedCloudDatabaseHandle));
			}
			return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSharedCloudDatabaseHandle));
		}
	}

	[Field("CKAccountChangedNotification", "CloudKit")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use CKContainer.Notifications.ObserveAccountChanged helper method instead.")]
	public static NSString AccountChangedNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_AccountChangedNotification == null)
			{
				_AccountChangedNotification = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKAccountChangedNotification");
			}
			return _AccountChangedNotification;
		}
	}

	[Field("CKCurrentUserDefaultName", "CloudKit")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString CurrentUserDefaultName
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_CurrentUserDefaultName == null)
			{
				_CurrentUserDefaultName = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKCurrentUserDefaultName");
			}
			return _CurrentUserDefaultName;
		}
	}

	[Field("CKOwnerDefaultName", "CloudKit")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CurrentUserDefaultName' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CurrentUserDefaultName' instead.")]
	public static NSString OwnerDefaultName
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CurrentUserDefaultName' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CurrentUserDefaultName' instead.")]
		get
		{
			if (_OwnerDefaultName == null)
			{
				_OwnerDefaultName = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKOwnerDefaultName");
			}
			return _OwnerDefaultName;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKContainer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKContainer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("acceptShareMetadata:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AcceptShareMetadata(CKShareMetadata metadata, [BlockProxy(typeof(Trampolines.NIDActionArity2V14))] Action<CKShare, NSError> completionHandler)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V14.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAcceptShareMetadata_CompletionHandler_Handle, metadata.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAcceptShareMetadata_CompletionHandler_Handle, metadata.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKShare> AcceptShareMetadataAsync(CKShareMetadata metadata)
	{
		TaskCompletionSource<CKShare> tcs = new TaskCompletionSource<CKShare>();
		AcceptShareMetadata(metadata, delegate(CKShare arg1_, NSError arg2_)
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

	[Export("addOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOperation(CKOperation operation)
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

	[Export("discoverAllContactUserInfosWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverAllIdentities' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverAllIdentities' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverAllContactUserInfos([BlockProxy(typeof(Trampolines.NIDActionArity2V15))] Action<CKDiscoveredUserInfo[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V15.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDiscoverAllContactUserInfosWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDiscoverAllContactUserInfosWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverAllIdentities' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverAllIdentities' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKDiscoveredUserInfo[]> DiscoverAllContactUserInfosAsync()
	{
		TaskCompletionSource<CKDiscoveredUserInfo[]> tcs = new TaskCompletionSource<CKDiscoveredUserInfo[]>();
		DiscoverAllContactUserInfos(delegate(CKDiscoveredUserInfo[] arg1_, NSError arg2_)
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

	[Export("discoverAllIdentitiesWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverAllIdentities([BlockProxy(typeof(Trampolines.NIDActionArity2V16))] Action<CKUserIdentity[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V16.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDiscoverAllIdentitiesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDiscoverAllIdentitiesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKUserIdentity[]> DiscoverAllIdentitiesAsync()
	{
		TaskCompletionSource<CKUserIdentity[]> tcs = new TaskCompletionSource<CKUserIdentity[]>();
		DiscoverAllIdentities(delegate(CKUserIdentity[] arg1_, NSError arg2_)
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

	[Export("discoverUserIdentityWithUserRecordID:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverUserIdentity(CKRecordID userRecordID, [BlockProxy(typeof(Trampolines.NIDActionArity2V17))] Action<CKUserIdentity, NSError> completionHandler)
	{
		if (userRecordID == null)
		{
			throw new ArgumentNullException("userRecordID");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V17.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverUserIdentityWithUserRecordID_CompletionHandler_Handle, userRecordID.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverUserIdentityWithUserRecordID_CompletionHandler_Handle, userRecordID.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKUserIdentity> DiscoverUserIdentityAsync(CKRecordID userRecordID)
	{
		TaskCompletionSource<CKUserIdentity> tcs = new TaskCompletionSource<CKUserIdentity>();
		DiscoverUserIdentity(userRecordID, delegate(CKUserIdentity arg1_, NSError arg2_)
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

	[Export("discoverUserIdentityWithEmailAddress:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverUserIdentityWithEmailAddress(string email, [BlockProxy(typeof(Trampolines.NIDActionArity2V17))] Action<CKUserIdentity, NSError> completionHandler)
	{
		if (email == null)
		{
			throw new ArgumentNullException("email");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(email);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V17.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverUserIdentityWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverUserIdentityWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKUserIdentity> DiscoverUserIdentityWithEmailAddressAsync(string email)
	{
		TaskCompletionSource<CKUserIdentity> tcs = new TaskCompletionSource<CKUserIdentity>();
		DiscoverUserIdentityWithEmailAddress(email, delegate(CKUserIdentity arg1_, NSError arg2_)
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

	[Export("discoverUserIdentityWithPhoneNumber:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverUserIdentityWithPhoneNumber(string phoneNumber, [BlockProxy(typeof(Trampolines.NIDActionArity2V17))] Action<CKUserIdentity, NSError> completionHandler)
	{
		if (phoneNumber == null)
		{
			throw new ArgumentNullException("phoneNumber");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(phoneNumber);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V17.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverUserIdentityWithPhoneNumber_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKUserIdentity> DiscoverUserIdentityWithPhoneNumberAsync(string phoneNumber)
	{
		TaskCompletionSource<CKUserIdentity> tcs = new TaskCompletionSource<CKUserIdentity>();
		DiscoverUserIdentityWithPhoneNumber(phoneNumber, delegate(CKUserIdentity arg1_, NSError arg2_)
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

	[Export("discoverUserInfoWithEmailAddress:completionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverUserIdentityWithEmailAddress' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverUserIdentityWithEmailAddress' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverUserInfo(string email, [BlockProxy(typeof(Trampolines.NIDActionArity2V18))] Action<CKDiscoveredUserInfo, NSError> completionHandler)
	{
		if (email == null)
		{
			throw new ArgumentNullException("email");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(email);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V18.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverUserInfoWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverUserInfoWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverUserIdentityWithEmailAddress' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverUserIdentityWithEmailAddress' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKDiscoveredUserInfo> DiscoverUserInfoAsync(string email)
	{
		TaskCompletionSource<CKDiscoveredUserInfo> tcs = new TaskCompletionSource<CKDiscoveredUserInfo>();
		DiscoverUserInfo(email, delegate(CKDiscoveredUserInfo arg1_, NSError arg2_)
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

	[Export("discoverUserInfoWithUserRecordID:completionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverUserIdentity' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverUserIdentity' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DiscoverUserInfo(CKRecordID userRecordId, [BlockProxy(typeof(Trampolines.NIDActionArity2V18))] Action<CKDiscoveredUserInfo, NSError> completionHandler)
	{
		if (userRecordId == null)
		{
			throw new ArgumentNullException("userRecordId");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V18.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverUserInfoWithUserRecordID_CompletionHandler_Handle, userRecordId.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverUserInfoWithUserRecordID_CompletionHandler_Handle, userRecordId.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'DiscoverUserIdentity' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'DiscoverUserIdentity' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKDiscoveredUserInfo> DiscoverUserInfoAsync(CKRecordID userRecordId)
	{
		TaskCompletionSource<CKDiscoveredUserInfo> tcs = new TaskCompletionSource<CKDiscoveredUserInfo>();
		DiscoverUserInfo(userRecordId, delegate(CKDiscoveredUserInfo arg1_, NSError arg2_)
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

	[Export("fetchAllLongLivedOperationIDsWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchAllLongLivedOperationIDs([BlockProxy(typeof(Trampolines.NIDActionArity2V19))] Action<NSDictionary<NSString, NSOperation>, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V19.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchAllLongLivedOperationIDsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchAllLongLivedOperationIDsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSDictionary<NSString, NSOperation>> FetchAllLongLivedOperationIDsAsync()
	{
		TaskCompletionSource<NSDictionary<NSString, NSOperation>> tcs = new TaskCompletionSource<NSDictionary<NSString, NSOperation>>();
		FetchAllLongLivedOperationIDs(delegate(NSDictionary<NSString, NSOperation> arg1_, NSError arg2_)
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

	[Export("fetchLongLivedOperationWithID:completionHandler:")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchLongLivedOperation(string[] operationID, [BlockProxy(typeof(Trampolines.NIDActionArity2V19))] Action<NSDictionary<NSString, NSOperation>, NSError> completionHandler)
	{
		if (operationID == null)
		{
			throw new ArgumentNullException("operationID");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromStrings(operationID);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V19.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchLongLivedOperationWithID_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchLongLivedOperationWithID_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSDictionary<NSString, NSOperation>> FetchLongLivedOperationAsync(string[] operationID)
	{
		TaskCompletionSource<NSDictionary<NSString, NSOperation>> tcs = new TaskCompletionSource<NSDictionary<NSString, NSOperation>>();
		FetchLongLivedOperation(operationID, delegate(NSDictionary<NSString, NSOperation> arg1_, NSError arg2_)
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

	[Export("fetchShareMetadataWithURL:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchShareMetadata(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity2V20))] Action<CKShareMetadata, NSError> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V20.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchShareMetadataWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchShareMetadataWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKShareMetadata> FetchShareMetadataAsync(NSUrl url)
	{
		TaskCompletionSource<CKShareMetadata> tcs = new TaskCompletionSource<CKShareMetadata>();
		FetchShareMetadata(url, delegate(CKShareMetadata arg1_, NSError arg2_)
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

	[Export("fetchShareParticipantWithUserRecordID:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchShareParticipant(CKRecordID userRecordID, [BlockProxy(typeof(Trampolines.NIDActionArity2V21))] Action<CKShareParticipant, NSError> completionHandler)
	{
		if (userRecordID == null)
		{
			throw new ArgumentNullException("userRecordID");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V21.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchShareParticipantWithUserRecordID_CompletionHandler_Handle, userRecordID.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchShareParticipantWithUserRecordID_CompletionHandler_Handle, userRecordID.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKShareParticipant> FetchShareParticipantAsync(CKRecordID userRecordID)
	{
		TaskCompletionSource<CKShareParticipant> tcs = new TaskCompletionSource<CKShareParticipant>();
		FetchShareParticipant(userRecordID, delegate(CKShareParticipant arg1_, NSError arg2_)
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

	[Export("fetchShareParticipantWithEmailAddress:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchShareParticipantWithEmailAddress(string emailAddress, [BlockProxy(typeof(Trampolines.NIDActionArity2V21))] Action<CKShareParticipant, NSError> completionHandler)
	{
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(emailAddress);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V21.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchShareParticipantWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchShareParticipantWithEmailAddress_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKShareParticipant> FetchShareParticipantWithEmailAddressAsync(string emailAddress)
	{
		TaskCompletionSource<CKShareParticipant> tcs = new TaskCompletionSource<CKShareParticipant>();
		FetchShareParticipantWithEmailAddress(emailAddress, delegate(CKShareParticipant arg1_, NSError arg2_)
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

	[Export("fetchShareParticipantWithPhoneNumber:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchShareParticipantWithPhoneNumber(string phoneNumber, [BlockProxy(typeof(Trampolines.NIDActionArity2V21))] Action<CKShareParticipant, NSError> completionHandler)
	{
		if (phoneNumber == null)
		{
			throw new ArgumentNullException("phoneNumber");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(phoneNumber);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V21.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchShareParticipantWithPhoneNumber_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchShareParticipantWithPhoneNumber_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKShareParticipant> FetchShareParticipantWithPhoneNumberAsync(string phoneNumber)
	{
		TaskCompletionSource<CKShareParticipant> tcs = new TaskCompletionSource<CKShareParticipant>();
		FetchShareParticipantWithPhoneNumber(phoneNumber, delegate(CKShareParticipant arg1_, NSError arg2_)
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

	[Export("fetchUserRecordIDWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchUserRecordId([BlockProxy(typeof(Trampolines.NIDActionArity2V22))] Action<CKRecordID, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V22.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchUserRecordIDWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchUserRecordIDWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKRecordID> FetchUserRecordIdAsync()
	{
		TaskCompletionSource<CKRecordID> tcs = new TaskCompletionSource<CKRecordID>();
		FetchUserRecordId(delegate(CKRecordID arg1_, NSError arg2_)
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

	[Export("containerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKContainer FromIdentifier(string containerIdentifier)
	{
		if (containerIdentifier == null)
		{
			throw new ArgumentNullException("containerIdentifier");
		}
		IntPtr arg = NSString.CreateNative(containerIdentifier);
		CKContainer nSObject = Runtime.GetNSObject<CKContainer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContainerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("accountStatusWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetAccountStatus([BlockProxy(typeof(Trampolines.NIDActionArity2V23))] Action<CKAccountStatus, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V23.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAccountStatusWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccountStatusWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKAccountStatus> GetAccountStatusAsync()
	{
		TaskCompletionSource<CKAccountStatus> tcs = new TaskCompletionSource<CKAccountStatus>();
		GetAccountStatus(delegate(CKAccountStatus arg1_, NSError arg2_)
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

	[Export("databaseWithDatabaseScope:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKDatabase GetDatabase(CKDatabaseScope databaseScope)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selDatabaseWithDatabaseScope_Handle, (long)databaseScope));
		}
		return Runtime.GetNSObject<CKDatabase>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selDatabaseWithDatabaseScope_Handle, (long)databaseScope));
	}

	[Export("requestApplicationPermission:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestApplicationPermission(CKApplicationPermissions applicationPermission, [BlockProxy(typeof(Trampolines.NIDActionArity2V24))] Action<CKApplicationPermissionStatus, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V24.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selRequestApplicationPermission_CompletionHandler_Handle, (ulong)applicationPermission, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selRequestApplicationPermission_CompletionHandler_Handle, (ulong)applicationPermission, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKApplicationPermissionStatus> RequestApplicationPermissionAsync(CKApplicationPermissions applicationPermission)
	{
		TaskCompletionSource<CKApplicationPermissionStatus> tcs = new TaskCompletionSource<CKApplicationPermissionStatus>();
		RequestApplicationPermission(applicationPermission, delegate(CKApplicationPermissionStatus arg1_, NSError arg2_)
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

	[Export("statusForApplicationPermission:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StatusForApplicationPermission(CKApplicationPermissions applicationPermission, [BlockProxy(typeof(Trampolines.NIDActionArity2V24))] Action<CKApplicationPermissionStatus, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V24.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selStatusForApplicationPermission_CompletionHandler_Handle, (ulong)applicationPermission, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selStatusForApplicationPermission_CompletionHandler_Handle, (ulong)applicationPermission, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CKApplicationPermissionStatus> StatusForApplicationPermissionAsync(CKApplicationPermissions applicationPermission)
	{
		TaskCompletionSource<CKApplicationPermissionStatus> tcs = new TaskCompletionSource<CKApplicationPermissionStatus>();
		StatusForApplicationPermission(applicationPermission, delegate(CKApplicationPermissionStatus arg1_, NSError arg2_)
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

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentStoreCoordinator", true)]
public class NSPersistentStoreCoordinator : NSObject, INSLocking, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveDidImportUbiquitousContentChanges(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidImportUbiquitousContentChangesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidImportUbiquitousContentChanges(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidImportUbiquitousContentChangesNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveStoresDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoresDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveStoresDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoresDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveStoresWillChange(EventHandler<NSPersistentStoreCoordinatorStoreChangeEventArgs> handler)
		{
			EventHandler<NSPersistentStoreCoordinatorStoreChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoresWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSPersistentStoreCoordinatorStoreChangeEventArgs(notification));
			});
		}

		public static NSObject ObserveStoresWillChange(NSObject objectToObserve, EventHandler<NSPersistentStoreCoordinatorStoreChangeEventArgs> handler)
		{
			EventHandler<NSPersistentStoreCoordinatorStoreChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoresWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSPersistentStoreCoordinatorStoreChangeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillRemoveStore(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillRemoveStoreNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillRemoveStore(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillRemoveStoreNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForPersistentStore_ = "URLForPersistentStore:";

	private static readonly IntPtr selURLForPersistentStore_Handle = Selector.GetHandle("URLForPersistentStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPersistentStoreWithDescription_CompletionHandler_ = "addPersistentStoreWithDescription:completionHandler:";

	private static readonly IntPtr selAddPersistentStoreWithDescription_CompletionHandler_Handle = Selector.GetHandle("addPersistentStoreWithDescription:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPersistentStoreWithType_Configuration_URL_Options_Error_ = "addPersistentStoreWithType:configuration:URL:options:error:";

	private static readonly IntPtr selAddPersistentStoreWithType_Configuration_URL_Options_Error_Handle = Selector.GetHandle("addPersistentStoreWithType:configuration:URL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPersistentHistoryTokenFromStores_ = "currentPersistentHistoryTokenFromStores:";

	private static readonly IntPtr selCurrentPersistentHistoryTokenFromStores_Handle = Selector.GetHandle("currentPersistentHistoryTokenFromStores:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestroyPersistentStoreAtURL_WithType_Options_Error_ = "destroyPersistentStoreAtURL:withType:options:error:";

	private static readonly IntPtr selDestroyPersistentStoreAtURL_WithType_Options_Error_Handle = Selector.GetHandle("destroyPersistentStoreAtURL:withType:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteRequest_WithContext_Error_ = "executeRequest:withContext:error:";

	private static readonly IntPtr selExecuteRequest_WithContext_Error_Handle = Selector.GetHandle("executeRequest:withContext:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithManagedObjectModel_ = "initWithManagedObjectModel:";

	private static readonly IntPtr selInitWithManagedObjectModel_Handle = Selector.GetHandle("initWithManagedObjectModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLock = "lock";

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectIDForURIRepresentation_ = "managedObjectIDForURIRepresentation:";

	private static readonly IntPtr selManagedObjectIDForURIRepresentation_Handle = Selector.GetHandle("managedObjectIDForURIRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectModel = "managedObjectModel";

	private static readonly IntPtr selManagedObjectModelHandle = Selector.GetHandle("managedObjectModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForPersistentStore_ = "metadataForPersistentStore:";

	private static readonly IntPtr selMetadataForPersistentStore_Handle = Selector.GetHandle("metadataForPersistentStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForPersistentStoreOfType_URL_Error_ = "metadataForPersistentStoreOfType:URL:error:";

	private static readonly IntPtr selMetadataForPersistentStoreOfType_URL_Error_Handle = Selector.GetHandle("metadataForPersistentStoreOfType:URL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForPersistentStoreOfType_URL_Options_Error_ = "metadataForPersistentStoreOfType:URL:options:error:";

	private static readonly IntPtr selMetadataForPersistentStoreOfType_URL_Options_Error_Handle = Selector.GetHandle("metadataForPersistentStoreOfType:URL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForPersistentStoreWithURL_Error_ = "metadataForPersistentStoreWithURL:error:";

	private static readonly IntPtr selMetadataForPersistentStoreWithURL_Error_Handle = Selector.GetHandle("metadataForPersistentStoreWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMigratePersistentStore_ToURL_Options_WithType_Error_ = "migratePersistentStore:toURL:options:withType:error:";

	private static readonly IntPtr selMigratePersistentStore_ToURL_Options_WithType_Error_Handle = Selector.GetHandle("migratePersistentStore:toURL:options:withType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBlock_ = "performBlock:";

	private static readonly IntPtr selPerformBlock_Handle = Selector.GetHandle("performBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBlockAndWait_ = "performBlockAndWait:";

	private static readonly IntPtr selPerformBlockAndWait_Handle = Selector.GetHandle("performBlockAndWait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStoreForURL_ = "persistentStoreForURL:";

	private static readonly IntPtr selPersistentStoreForURL_Handle = Selector.GetHandle("persistentStoreForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStores = "persistentStores";

	private static readonly IntPtr selPersistentStoresHandle = Selector.GetHandle("persistentStores");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterStoreClass_ForStoreType_ = "registerStoreClass:forStoreType:";

	private static readonly IntPtr selRegisterStoreClass_ForStoreType_Handle = Selector.GetHandle("registerStoreClass:forStoreType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredStoreTypes = "registeredStoreTypes";

	private static readonly IntPtr selRegisteredStoreTypesHandle = Selector.GetHandle("registeredStoreTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePersistentStore_Error_ = "removePersistentStore:error:";

	private static readonly IntPtr selRemovePersistentStore_Error_Handle = Selector.GetHandle("removePersistentStore:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveUbiquitousContentAndPersistentStoreAtURL_Options_Error_ = "removeUbiquitousContentAndPersistentStoreAtURL:options:error:";

	private static readonly IntPtr selRemoveUbiquitousContentAndPersistentStoreAtURL_Options_Error_Handle = Selector.GetHandle("removeUbiquitousContentAndPersistentStoreAtURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplacePersistentStoreAtURL_DestinationOptions_WithPersistentStoreFromURL_SourceOptions_StoreType_Error_ = "replacePersistentStoreAtURL:destinationOptions:withPersistentStoreFromURL:sourceOptions:storeType:error:";

	private static readonly IntPtr selReplacePersistentStoreAtURL_DestinationOptions_WithPersistentStoreFromURL_SourceOptions_StoreType_Error_Handle = Selector.GetHandle("replacePersistentStoreAtURL:destinationOptions:withPersistentStoreFromURL:sourceOptions:storeType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ForPersistentStore_ = "setMetadata:forPersistentStore:";

	private static readonly IntPtr selSetMetadata_ForPersistentStore_Handle = Selector.GetHandle("setMetadata:forPersistentStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ForPersistentStoreOfType_URL_Error_ = "setMetadata:forPersistentStoreOfType:URL:error:";

	private static readonly IntPtr selSetMetadata_ForPersistentStoreOfType_URL_Error_Handle = Selector.GetHandle("setMetadata:forPersistentStoreOfType:URL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ForPersistentStoreOfType_URL_Options_Error_ = "setMetadata:forPersistentStoreOfType:URL:options:error:";

	private static readonly IntPtr selSetMetadata_ForPersistentStoreOfType_URL_Options_Error_Handle = Selector.GetHandle("setMetadata:forPersistentStoreOfType:URL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ForPersistentStore_ = "setURL:forPersistentStore:";

	private static readonly IntPtr selSetURL_ForPersistentStore_Handle = Selector.GetHandle("setURL:forPersistentStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryLock = "tryLock";

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlock = "unlock";

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentStoreCoordinator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AddedPersistentStoresKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BinaryStoreInsecureDecodingCompatibilityOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BinaryStoreSecureDecodingClasses;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BinaryStoreType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CoreSpotlightExporter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidImportUbiquitousContentChangesNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HistoryTrackingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IgnorePersistentStoreVersioningOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InMemoryStoreType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InferMappingModelAutomaticallyOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MigratePersistentStoresAutomaticallyOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreOSCompatibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreTimeoutOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreUbiquitousContentNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreUbiquitousContentUrlLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreUbiquitousPeerTokenOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadOnlyPersistentStoreOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RebuildFromUbiquitousContentOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemoveUbiquitousMetadataOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemovedPersistentStoresKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SQLiteAnalyzeOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SQLiteManualVacuumOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SQLitePragmasOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SQLiteStoreType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoreModelVersionHashesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoreModelVersionIdentifiersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoreTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoreUUIDKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoresDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoresWillChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UUIDChangedPersistentStoresKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousContainerIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValidateXMLStoreOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillRemoveStoreNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XMLStoreType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _eUbiquitousContainerIdentifierKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectModel ManagedObjectModel
	{
		[Export("managedObjectModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectModelHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? Name
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStore[] PersistentStores
	{
		[Export("persistentStores", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoresHandle));
			}
			return NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoresHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary RegisteredStoreTypes
	{
		[Export("registeredStoreTypes", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(class_ptr, selRegisteredStoreTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Perform' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Perform' instead.")]
	public virtual bool TryLock
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Perform' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Perform' instead.")]
		[Export("tryLock")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTryLockHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTryLockHandle);
		}
	}

	[Field("NSAddedPersistentStoresKey", "CoreData")]
	public static NSString AddedPersistentStoresKey
	{
		get
		{
			if (_AddedPersistentStoresKey == null)
			{
				_AddedPersistentStoresKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSAddedPersistentStoresKey");
			}
			return _AddedPersistentStoresKey;
		}
	}

	[Field("NSBinaryStoreInsecureDecodingCompatibilityOption", "CoreData")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString BinaryStoreInsecureDecodingCompatibilityOption
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BinaryStoreInsecureDecodingCompatibilityOption == null)
			{
				_BinaryStoreInsecureDecodingCompatibilityOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSBinaryStoreInsecureDecodingCompatibilityOption");
			}
			return _BinaryStoreInsecureDecodingCompatibilityOption;
		}
	}

	[Field("NSBinaryStoreSecureDecodingClasses", "CoreData")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString BinaryStoreSecureDecodingClasses
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BinaryStoreSecureDecodingClasses == null)
			{
				_BinaryStoreSecureDecodingClasses = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSBinaryStoreSecureDecodingClasses");
			}
			return _BinaryStoreSecureDecodingClasses;
		}
	}

	[Field("NSBinaryStoreType", "CoreData")]
	public static NSString BinaryStoreType
	{
		get
		{
			if (_BinaryStoreType == null)
			{
				_BinaryStoreType = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSBinaryStoreType");
			}
			return _BinaryStoreType;
		}
	}

	[Field("NSCoreDataCoreSpotlightExporter", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString CoreSpotlightExporter
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CoreSpotlightExporter == null)
			{
				_CoreSpotlightExporter = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSCoreDataCoreSpotlightExporter");
			}
			return _CoreSpotlightExporter;
		}
	}

	[Field("NSPersistentStoreDidImportUbiquitousContentChangesNotification", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
	[Advice("Use NSPersistentStoreCoordinator.Notifications.ObserveDidImportUbiquitousContentChanges helper method instead.")]
	public static NSString DidImportUbiquitousContentChangesNotification
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
		get
		{
			if (_DidImportUbiquitousContentChangesNotification == null)
			{
				_DidImportUbiquitousContentChangesNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreDidImportUbiquitousContentChangesNotification");
			}
			return _DidImportUbiquitousContentChangesNotification;
		}
	}

	[Field("NSPersistentHistoryTrackingKey", "CoreData")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString HistoryTrackingKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_HistoryTrackingKey == null)
			{
				_HistoryTrackingKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentHistoryTrackingKey");
			}
			return _HistoryTrackingKey;
		}
	}

	[Field("NSIgnorePersistentStoreVersioningOption", "CoreData")]
	public static NSString IgnorePersistentStoreVersioningOption
	{
		get
		{
			if (_IgnorePersistentStoreVersioningOption == null)
			{
				_IgnorePersistentStoreVersioningOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSIgnorePersistentStoreVersioningOption");
			}
			return _IgnorePersistentStoreVersioningOption;
		}
	}

	[Field("NSInMemoryStoreType", "CoreData")]
	public static NSString InMemoryStoreType
	{
		get
		{
			if (_InMemoryStoreType == null)
			{
				_InMemoryStoreType = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSInMemoryStoreType");
			}
			return _InMemoryStoreType;
		}
	}

	[Field("NSInferMappingModelAutomaticallyOption", "CoreData")]
	public static NSString InferMappingModelAutomaticallyOption
	{
		get
		{
			if (_InferMappingModelAutomaticallyOption == null)
			{
				_InferMappingModelAutomaticallyOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSInferMappingModelAutomaticallyOption");
			}
			return _InferMappingModelAutomaticallyOption;
		}
	}

	[Field("NSMigratePersistentStoresAutomaticallyOption", "CoreData")]
	public static NSString MigratePersistentStoresAutomaticallyOption
	{
		get
		{
			if (_MigratePersistentStoresAutomaticallyOption == null)
			{
				_MigratePersistentStoresAutomaticallyOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSMigratePersistentStoresAutomaticallyOption");
			}
			return _MigratePersistentStoresAutomaticallyOption;
		}
	}

	[Field("NSPersistentStoreOSCompatibility", "CoreData")]
	public static NSString PersistentStoreOSCompatibility
	{
		get
		{
			if (_PersistentStoreOSCompatibility == null)
			{
				_PersistentStoreOSCompatibility = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreOSCompatibility");
			}
			return _PersistentStoreOSCompatibility;
		}
	}

	[Field("NSPersistentStoreTimeoutOption", "CoreData")]
	public static NSString PersistentStoreTimeoutOption
	{
		get
		{
			if (_PersistentStoreTimeoutOption == null)
			{
				_PersistentStoreTimeoutOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreTimeoutOption");
			}
			return _PersistentStoreTimeoutOption;
		}
	}

	[Field("NSPersistentStoreUbiquitousContentNameKey", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
	public static NSString PersistentStoreUbiquitousContentNameKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
		get
		{
			if (_PersistentStoreUbiquitousContentNameKey == null)
			{
				_PersistentStoreUbiquitousContentNameKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousContentNameKey");
			}
			return _PersistentStoreUbiquitousContentNameKey;
		}
	}

	[Field("NSPersistentStoreUbiquitousContentURLKey", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
	public static NSString PersistentStoreUbiquitousContentUrlLKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, "Please see the release notes and Core Data documentation.")]
		get
		{
			if (_PersistentStoreUbiquitousContentUrlLKey == null)
			{
				_PersistentStoreUbiquitousContentUrlLKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousContentURLKey");
			}
			return _PersistentStoreUbiquitousContentUrlLKey;
		}
	}

	[Field("NSPersistentStoreUbiquitousPeerTokenOption", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PersistentStoreUbiquitousPeerTokenOption
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PersistentStoreUbiquitousPeerTokenOption == null)
			{
				_PersistentStoreUbiquitousPeerTokenOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousPeerTokenOption");
			}
			return _PersistentStoreUbiquitousPeerTokenOption;
		}
	}

	[Field("NSReadOnlyPersistentStoreOption", "CoreData")]
	public static NSString ReadOnlyPersistentStoreOption
	{
		get
		{
			if (_ReadOnlyPersistentStoreOption == null)
			{
				_ReadOnlyPersistentStoreOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSReadOnlyPersistentStoreOption");
			}
			return _ReadOnlyPersistentStoreOption;
		}
	}

	[Field("NSPersistentStoreRebuildFromUbiquitousContentOption", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RebuildFromUbiquitousContentOption
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RebuildFromUbiquitousContentOption == null)
			{
				_RebuildFromUbiquitousContentOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreRebuildFromUbiquitousContentOption");
			}
			return _RebuildFromUbiquitousContentOption;
		}
	}

	[Field("NSPersistentStoreRemoveUbiquitousMetadataOption", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RemoveUbiquitousMetadataOption
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RemoveUbiquitousMetadataOption == null)
			{
				_RemoveUbiquitousMetadataOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreRemoveUbiquitousMetadataOption");
			}
			return _RemoveUbiquitousMetadataOption;
		}
	}

	[Field("NSRemovedPersistentStoresKey", "CoreData")]
	public static NSString RemovedPersistentStoresKey
	{
		get
		{
			if (_RemovedPersistentStoresKey == null)
			{
				_RemovedPersistentStoresKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSRemovedPersistentStoresKey");
			}
			return _RemovedPersistentStoresKey;
		}
	}

	[Field("NSSQLiteAnalyzeOption", "CoreData")]
	public static NSString SQLiteAnalyzeOption
	{
		get
		{
			if (_SQLiteAnalyzeOption == null)
			{
				_SQLiteAnalyzeOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSSQLiteAnalyzeOption");
			}
			return _SQLiteAnalyzeOption;
		}
	}

	[Field("NSSQLiteManualVacuumOption", "CoreData")]
	public static NSString SQLiteManualVacuumOption
	{
		get
		{
			if (_SQLiteManualVacuumOption == null)
			{
				_SQLiteManualVacuumOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSSQLiteManualVacuumOption");
			}
			return _SQLiteManualVacuumOption;
		}
	}

	[Field("NSSQLitePragmasOption", "CoreData")]
	public static NSString SQLitePragmasOption
	{
		get
		{
			if (_SQLitePragmasOption == null)
			{
				_SQLitePragmasOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSSQLitePragmasOption");
			}
			return _SQLitePragmasOption;
		}
	}

	[Field("NSSQLiteStoreType", "CoreData")]
	public static NSString SQLiteStoreType
	{
		get
		{
			if (_SQLiteStoreType == null)
			{
				_SQLiteStoreType = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSSQLiteStoreType");
			}
			return _SQLiteStoreType;
		}
	}

	[Field("NSStoreModelVersionHashesKey", "CoreData")]
	public static NSString StoreModelVersionHashesKey
	{
		get
		{
			if (_StoreModelVersionHashesKey == null)
			{
				_StoreModelVersionHashesKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSStoreModelVersionHashesKey");
			}
			return _StoreModelVersionHashesKey;
		}
	}

	[Field("NSStoreModelVersionIdentifiersKey", "CoreData")]
	public static NSString StoreModelVersionIdentifiersKey
	{
		get
		{
			if (_StoreModelVersionIdentifiersKey == null)
			{
				_StoreModelVersionIdentifiersKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSStoreModelVersionIdentifiersKey");
			}
			return _StoreModelVersionIdentifiersKey;
		}
	}

	[Field("NSStoreTypeKey", "CoreData")]
	public static NSString StoreTypeKey
	{
		get
		{
			if (_StoreTypeKey == null)
			{
				_StoreTypeKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSStoreTypeKey");
			}
			return _StoreTypeKey;
		}
	}

	[Field("NSStoreUUIDKey", "CoreData")]
	public static NSString StoreUUIDKey
	{
		get
		{
			if (_StoreUUIDKey == null)
			{
				_StoreUUIDKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSStoreUUIDKey");
			}
			return _StoreUUIDKey;
		}
	}

	[Field("NSPersistentStoreCoordinatorStoresDidChangeNotification", "CoreData")]
	[Advice("Use NSPersistentStoreCoordinator.Notifications.ObserveStoresDidChange helper method instead.")]
	public static NSString StoresDidChangeNotification
	{
		get
		{
			if (_StoresDidChangeNotification == null)
			{
				_StoresDidChangeNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreCoordinatorStoresDidChangeNotification");
			}
			return _StoresDidChangeNotification;
		}
	}

	[Field("NSPersistentStoreCoordinatorStoresWillChangeNotification", "CoreData")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use NSPersistentStoreCoordinator.Notifications.ObserveStoresWillChange helper method instead.")]
	public static NSString StoresWillChangeNotification
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_StoresWillChangeNotification == null)
			{
				_StoresWillChangeNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreCoordinatorStoresWillChangeNotification");
			}
			return _StoresWillChangeNotification;
		}
	}

	[Field("NSUUIDChangedPersistentStoresKey", "CoreData")]
	public static NSString UUIDChangedPersistentStoresKey
	{
		get
		{
			if (_UUIDChangedPersistentStoresKey == null)
			{
				_UUIDChangedPersistentStoresKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSUUIDChangedPersistentStoresKey");
			}
			return _UUIDChangedPersistentStoresKey;
		}
	}

	[Field("NSPersistentStoreUbiquitousContainerIdentifierKey", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousContainerIdentifierKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousContainerIdentifierKey == null)
			{
				_UbiquitousContainerIdentifierKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousContainerIdentifierKey");
			}
			return _UbiquitousContainerIdentifierKey;
		}
	}

	[Field("NSValidateXMLStoreOption", "CoreData")]
	public static NSString ValidateXMLStoreOption
	{
		get
		{
			if (_ValidateXMLStoreOption == null)
			{
				_ValidateXMLStoreOption = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSValidateXMLStoreOption");
			}
			return _ValidateXMLStoreOption;
		}
	}

	[Field("NSPersistentStoreCoordinatorWillRemoveStoreNotification", "CoreData")]
	[Advice("Use NSPersistentStoreCoordinator.Notifications.ObserveWillRemoveStore helper method instead.")]
	public static NSString WillRemoveStoreNotification
	{
		get
		{
			if (_WillRemoveStoreNotification == null)
			{
				_WillRemoveStoreNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreCoordinatorWillRemoveStoreNotification");
			}
			return _WillRemoveStoreNotification;
		}
	}

	[Field("NSXMLStoreType", "CoreData")]
	public static NSString XMLStoreType
	{
		get
		{
			if (_XMLStoreType == null)
			{
				_XMLStoreType = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSXMLStoreType");
			}
			return _XMLStoreType;
		}
	}

	[Field("NSPersistentStoreUbiquitousContainerIdentifierKey", "CoreData")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString eUbiquitousContainerIdentifierKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_eUbiquitousContainerIdentifierKey == null)
			{
				_eUbiquitousContainerIdentifierKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousContainerIdentifierKey");
			}
			return _eUbiquitousContainerIdentifierKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPersistentStoreCoordinator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentStoreCoordinator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithManagedObjectModel:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentStoreCoordinator(NSManagedObjectModel model)
		: base(NSObjectFlag.Empty)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithManagedObjectModel_Handle, model.Handle), "initWithManagedObjectModel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithManagedObjectModel_Handle, model.Handle), "initWithManagedObjectModel:");
		}
	}

	[Export("addPersistentStoreWithDescription:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddPersistentStore(NSPersistentStoreDescription storeDescription, [BlockProxy(typeof(Trampolines.NIDActionArity2V37))] Action<NSPersistentStoreDescription, NSError> block)
	{
		if (storeDescription == null)
		{
			throw new ArgumentNullException("storeDescription");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V37.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddPersistentStoreWithDescription_CompletionHandler_Handle, storeDescription.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddPersistentStoreWithDescription_CompletionHandler_Handle, storeDescription.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSPersistentStoreDescription> AddPersistentStoreAsync(NSPersistentStoreDescription storeDescription)
	{
		TaskCompletionSource<NSPersistentStoreDescription> tcs = new TaskCompletionSource<NSPersistentStoreDescription>();
		AddPersistentStore(storeDescription, delegate(NSPersistentStoreDescription arg1_, NSError arg2_)
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

	[Export("addPersistentStoreWithType:configuration:URL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStore AddPersistentStoreWithType(NSString storeType, string? configuration, NSUrl? storeUrl, NSDictionary? options, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(configuration);
		NSPersistentStore result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selAddPersistentStoreWithType_Configuration_URL_Options_Error_Handle, storeType.Handle, arg2, (storeUrl == null) ? IntPtr.Zero : storeUrl.Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selAddPersistentStoreWithType_Configuration_URL_Options_Error_Handle, storeType.Handle, arg2, (storeUrl == null) ? IntPtr.Zero : storeUrl.Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("destroyPersistentStoreAtURL:withType:options:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DestroyPersistentStore(NSUrl url, string storeType, NSDictionary? options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(storeType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selDestroyPersistentStoreAtURL_WithType_Options_Error_Handle, url.Handle, arg2, options?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selDestroyPersistentStoreAtURL_WithType_Options_Error_Handle, url.Handle, arg2, options?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("executeRequest:withContext:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ExecuteRequestwithContexterror(NSPersistentStoreRequest request, NSManagedObjectContext context, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteRequest_WithContext_Error_Handle, request.Handle, context.Handle, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selExecuteRequest_WithContext_Error_Handle, request.Handle, context.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("currentPersistentHistoryTokenFromStores:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentHistoryToken? GetCurrentPersistentHistoryToken(NSObject[]? stores)
	{
		NSArray nSArray = ((stores == null) ? null : NSArray.FromNSObjects(stores));
		NSPersistentHistoryToken result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentHistoryToken>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCurrentPersistentHistoryTokenFromStores_Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSPersistentHistoryToken>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCurrentPersistentHistoryTokenFromStores_Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("metadataForPersistentStoreOfType:URL:options:error:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary<NSString, NSObject>? GetMetadata(string storeType, NSUrl url, NSDictionary? options, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(storeType);
		NSDictionary<NSString, NSObject> nSObject = Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selMetadataForPersistentStoreOfType_URL_Options_Error_Handle, arg2, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("lock")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'PerformAndWait' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'PerformAndWait' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Lock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockHandle);
		}
	}

	[Export("managedObjectIDForURIRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID? ManagedObjectIDForURIRepresentation(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selManagedObjectIDForURIRepresentation_Handle, url.Handle));
		}
		return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selManagedObjectIDForURIRepresentation_Handle, url.Handle));
	}

	[Export("metadataForPersistentStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary MetadataForPersistentStore(NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForPersistentStore_Handle, store.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForPersistentStore_Handle, store.Handle));
	}

	[Export("metadataForPersistentStoreOfType:URL:error:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use the method that takes an out NSError parameter.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use the method that takes an out NSError parameter.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary? MetadataForPersistentStoreOfType(NSString storeType, NSUrl url, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selMetadataForPersistentStoreOfType_URL_Error_Handle, storeType.Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("metadataForPersistentStoreWithURL:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 5, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary MetadataForPersistentStoreWithUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMetadataForPersistentStoreWithURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("migratePersistentStore:toURL:options:withType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStore? MigratePersistentStore(NSPersistentStore store, NSUrl url, NSDictionary? options, NSString storeType, out NSError error)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		IntPtr arg = IntPtr.Zero;
		NSPersistentStore result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMigratePersistentStore_ToURL_Options_WithType_Error_Handle, store.Handle, url.Handle, options?.Handle ?? IntPtr.Zero, storeType.Handle, ref arg)) : Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMigratePersistentStore_ToURL_Options_WithType_Error_Handle, store.Handle, url.Handle, options?.Handle ?? IntPtr.Zero, storeType.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performBlock:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Perform([BlockProxy(typeof(Trampolines.NIDAction))] Action code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, code);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performBlockAndWait:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformAndWait([BlockProxy(typeof(Trampolines.NIDAction))] Action code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, code);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("persistentStoreForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStore PersistentStoreForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPersistentStoreForURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPersistentStoreForURL_Handle, url.Handle));
	}

	[Export("registerStoreClass:forStoreType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterStoreClass(Class storeClass, NSString storeType)
	{
		if (storeClass == null)
		{
			throw new ArgumentNullException("storeClass");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRegisterStoreClass_ForStoreType_Handle, storeClass.Handle, storeType.Handle);
	}

	[Export("removePersistentStore:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemovePersistentStore(NSPersistentStore store, out NSError error)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selRemovePersistentStore_Error_Handle, store.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selRemovePersistentStore_Error_Handle, store.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeUbiquitousContentAndPersistentStoreAtURL:options:error:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Please see the release notes and Core Data documentation.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Please see the release notes and Core Data documentation.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool RemoveUbiquitousContentAndPersistentStore(NSUrl storeUrl, NSDictionary options, out NSError error)
	{
		if (storeUrl == null)
		{
			throw new ArgumentNullException("storeUrl");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selRemoveUbiquitousContentAndPersistentStoreAtURL_Options_Error_Handle, storeUrl.Handle, options.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("replacePersistentStoreAtURL:destinationOptions:withPersistentStoreFromURL:sourceOptions:storeType:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReplacePersistentStore(NSUrl destinationUrl, NSDictionary? destinationOptions, NSUrl sourceUrl, NSDictionary? sourceOptions, string storeType, out NSError error)
	{
		if (destinationUrl == null)
		{
			throw new ArgumentNullException("destinationUrl");
		}
		if (sourceUrl == null)
		{
			throw new ArgumentNullException("sourceUrl");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(storeType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selReplacePersistentStoreAtURL_DestinationOptions_WithPersistentStoreFromURL_SourceOptions_StoreType_Error_Handle, destinationUrl.Handle, destinationOptions?.Handle ?? IntPtr.Zero, sourceUrl.Handle, sourceOptions?.Handle ?? IntPtr.Zero, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selReplacePersistentStoreAtURL_DestinationOptions_WithPersistentStoreFromURL_SourceOptions_StoreType_Error_Handle, destinationUrl.Handle, destinationOptions?.Handle ?? IntPtr.Zero, sourceUrl.Handle, sourceOptions?.Handle ?? IntPtr.Zero, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setMetadata:forPersistentStoreOfType:URL:error:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use the method that takes an 'out NSError' parameter.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use the method that takes an 'out NSError' parameter.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetMetadata(NSDictionary metadata, NSString storeType, NSUrl url, out NSError error)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selSetMetadata_ForPersistentStoreOfType_URL_Error_Handle, metadata.Handle, storeType.Handle, url.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setMetadata:forPersistentStoreOfType:URL:options:error:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetMetadata(NSDictionary<NSString, NSObject>? metadata, string storeType, NSUrl url, NSDictionary? options, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(storeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selSetMetadata_ForPersistentStoreOfType_URL_Options_Error_Handle, metadata?.Handle ?? IntPtr.Zero, arg2, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg);
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setMetadata:forPersistentStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMetadata(NSDictionary? metadata, NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetMetadata_ForPersistentStore_Handle, metadata?.Handle ?? IntPtr.Zero, store.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetMetadata_ForPersistentStore_Handle, metadata?.Handle ?? IntPtr.Zero, store.Handle);
		}
	}

	[Export("setURL:forPersistentStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetUrl(NSUrl url, NSPersistentStore store)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetURL_ForPersistentStore_Handle, url.Handle, store.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetURL_ForPersistentStore_Handle, url.Handle, store.Handle);
	}

	[Export("unlock")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'PerformAndWait' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'PerformAndWait' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unlock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockHandle);
		}
	}

	[Export("URLForPersistentStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UrlForPersistentStore(NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForPersistentStore_Handle, store.Handle));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForPersistentStore_Handle, store.Handle));
	}
}

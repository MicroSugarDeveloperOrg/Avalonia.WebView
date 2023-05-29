using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentStoreCoordinator", true)]
public class NSPersistentStoreCoordinator : NSObject
{
	private static readonly IntPtr selRegisteredStoreTypesHandle = Selector.GetHandle("registeredStoreTypes");

	private static readonly IntPtr selManagedObjectModelHandle = Selector.GetHandle("managedObjectModel");

	private static readonly IntPtr selPersistentStoresHandle = Selector.GetHandle("persistentStores");

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	private static readonly IntPtr selRegisterStoreClassForStoreType_Handle = Selector.GetHandle("registerStoreClass:forStoreType:");

	private static readonly IntPtr selMetadataForPersistentStoreOfTypeURLError_Handle = Selector.GetHandle("metadataForPersistentStoreOfType:URL:error:");

	private static readonly IntPtr selSetMetadataForPersistentStoreOfTypeURLError_Handle = Selector.GetHandle("setMetadata:forPersistentStoreOfType:URL:error:");

	private static readonly IntPtr selSetMetadataForPersistentStore_Handle = Selector.GetHandle("setMetadata:forPersistentStore:");

	private static readonly IntPtr selMetadataForPersistentStore_Handle = Selector.GetHandle("metadataForPersistentStore:");

	private static readonly IntPtr selInitWithManagedObjectModel_Handle = Selector.GetHandle("initWithManagedObjectModel:");

	private static readonly IntPtr selPersistentStoreForURL_Handle = Selector.GetHandle("persistentStoreForURL:");

	private static readonly IntPtr selURLForPersistentStore_Handle = Selector.GetHandle("URLForPersistentStore:");

	private static readonly IntPtr selSetURLForPersistentStore_Handle = Selector.GetHandle("setURL:forPersistentStore:");

	private static readonly IntPtr selAddPersistentStoreWithTypeConfigurationURLOptionsError_Handle = Selector.GetHandle("addPersistentStoreWithType:configuration:URL:options:error:");

	private static readonly IntPtr selRemovePersistentStoreError_Handle = Selector.GetHandle("removePersistentStore:error:");

	private static readonly IntPtr selMigratePersistentStoreToURLOptionsWithTypeError_Handle = Selector.GetHandle("migratePersistentStore:toURL:options:withType:error:");

	private static readonly IntPtr selManagedObjectIDForURIRepresentation_Handle = Selector.GetHandle("managedObjectIDForURIRepresentation:");

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	private static readonly IntPtr selMetadataForPersistentStoreWithURLError_Handle = Selector.GetHandle("metadataForPersistentStoreWithURL:error:");

	private static readonly IntPtr selExecuteRequestWithContextError_Handle = Selector.GetHandle("executeRequest:withContext:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPersistentStoreCoordinator");

	private static object __mt_RegisteredStoreTypes_var_static;

	private object __mt_ManagedObjectModel_var;

	private object __mt_PersistentStores_var;

	private static NSString _SQLiteStoreType;

	private static NSString _XMLStoreType;

	private static NSString _BinaryStoreType;

	private static NSString _InMemoryStoreType;

	private static NSString _StoreUUIDKey;

	private static NSString _AddedPersistentStoresKey;

	private static NSString _RemovedPersistentStoresKey;

	private static NSString _UUIDChangedPersistentStoresKey;

	private static NSString _ReadOnlyPersistentStoreOption;

	private static NSString _ValidateXMLStoreOption;

	private static NSString _PersistentStoreTimeoutOption;

	private static NSString _SQLitePragmasOption;

	private static NSString _SQLiteAnalyzeOption;

	private static NSString _SQLiteManualVacuumOption;

	private static NSString _IgnorePersistentStoreVersioningOption;

	private static NSString _MigratePersistentStoresAutomaticallyOption;

	private static NSString _InferMappingModelAutomaticallyOption;

	private static NSString _StoreModelVersionHashesKey;

	private static NSString _StoreModelVersionIdentifiersKey;

	private static NSString _PersistentStoreOSCompatibility;

	private static NSString _StoreTypeKey;

	private static NSString _StoresDidChangeNotification;

	private static NSString _WillRemoveStoreNotification;

	private static NSString _DidImportUbiquitousContentChangesNotification;

	private static NSString _PersistentStoreUbiquitousContentNameKey;

	private static NSString _PersistentStoreUbiquitousContentUrlLKey;

	public override IntPtr ClassHandle => class_ptr;

	public static NSDictionary RegisteredStoreTypes
	{
		[Export("registeredStoreTypes")]
		get
		{
			return (NSDictionary)(__mt_RegisteredStoreTypes_var_static = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selRegisteredStoreTypesHandle)));
		}
	}

	public virtual NSManagedObjectModel ManagedObjectModel
	{
		[Export("managedObjectModel")]
		get
		{
			return (NSManagedObjectModel)(__mt_ManagedObjectModel_var = ((!IsDirectBinding) ? ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectModelHandle))) : ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectModelHandle)))));
		}
	}

	public virtual NSPersistentStore[] PersistentStores
	{
		[Export("persistentStores")]
		get
		{
			return (NSPersistentStore[])(__mt_PersistentStores_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoresHandle)) : NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoresHandle))));
		}
	}

	public virtual bool TryLock
	{
		[Export("tryLock")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTryLockHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTryLockHandle);
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

	[Field("NSPersistentStoreCoordinatorStoresDidChangeNotification", "CoreData")]
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

	[Field("NSPersistentStoreCoordinatorWillRemoveStoreNotification", "CoreData")]
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

	[Field("NSPersistentStoreDidImportUbiquitousContentChangesNotification", "CoreData")]
	public static NSString DidImportUbiquitousContentChangesNotification
	{
		get
		{
			if (_DidImportUbiquitousContentChangesNotification == null)
			{
				_DidImportUbiquitousContentChangesNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreDidImportUbiquitousContentChangesNotification");
			}
			return _DidImportUbiquitousContentChangesNotification;
		}
	}

	[Field("NSPersistentStoreUbiquitousContentNameKey", "CoreData")]
	public static NSString PersistentStoreUbiquitousContentNameKey
	{
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
	public static NSString PersistentStoreUbiquitousContentUrlLKey
	{
		get
		{
			if (_PersistentStoreUbiquitousContentUrlLKey == null)
			{
				_PersistentStoreUbiquitousContentUrlLKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousContentURLKey");
			}
			return _PersistentStoreUbiquitousContentUrlLKey;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPersistentStoreCoordinator()
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
	public NSPersistentStoreCoordinator(NSCoder coder)
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
	public NSPersistentStoreCoordinator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPersistentStoreCoordinator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("registerStoreClass:forStoreType:")]
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRegisterStoreClassForStoreType_Handle, storeClass.Handle, storeType.Handle);
	}

	[Export("metadataForPersistentStoreOfType:URL:error:")]
	public static NSDictionary MetadataForPersistentStoreOfType(NSString storeType, NSUrl url, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selMetadataForPersistentStoreOfTypeURLError_Handle, storeType.Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setMetadata:forPersistentStoreOfType:URL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSetMetadataForPersistentStoreOfTypeURLError_Handle, metadata.Handle, storeType.Handle, url.Handle, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setMetadata:forPersistentStore:")]
	public virtual void SetMetadata(NSDictionary metadata, NSPersistentStore store)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetMetadataForPersistentStore_Handle, metadata.Handle, store.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetMetadataForPersistentStore_Handle, metadata.Handle, store.Handle);
		}
	}

	[Export("metadataForPersistentStore:")]
	public virtual NSDictionary MetadataForPersistentStore(NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForPersistentStore_Handle, store.Handle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForPersistentStore_Handle, store.Handle));
	}

	[Export("initWithManagedObjectModel:")]
	public NSPersistentStoreCoordinator(NSManagedObjectModel model)
		: base(NSObjectFlag.Empty)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithManagedObjectModel_Handle, model.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithManagedObjectModel_Handle, model.Handle);
		}
	}

	[Export("persistentStoreForURL:")]
	public virtual NSPersistentStore PersistentStoreForUrl(NSUrl URL)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (IsDirectBinding)
		{
			return (NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPersistentStoreForURL_Handle, URL.Handle));
		}
		return (NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPersistentStoreForURL_Handle, URL.Handle));
	}

	[Export("URLForPersistentStore:")]
	public virtual NSUrl UrlForPersistentStore(NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (IsDirectBinding)
		{
			return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForPersistentStore_Handle, store.Handle));
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForPersistentStore_Handle, store.Handle));
	}

	[Export("setURL:forPersistentStore:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetURLForPersistentStore_Handle, url.Handle, store.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetURLForPersistentStore_Handle, url.Handle, store.Handle);
	}

	[Export("addPersistentStoreWithType:configuration:URL:options:error:")]
	public virtual NSPersistentStore AddPersistentStoreWithType(NSString storeType, string configuration, NSUrl storeURL, NSDictionary options, out NSError error)
	{
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		if (storeURL == null)
		{
			throw new ArgumentNullException("storeURL");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(configuration);
		NSPersistentStore result = ((!IsDirectBinding) ? ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddPersistentStoreWithTypeConfigurationURLOptionsError_Handle, storeType.Handle, arg, storeURL.Handle, options?.Handle ?? IntPtr.Zero, intPtr))) : ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddPersistentStoreWithTypeConfigurationURLOptionsError_Handle, storeType.Handle, arg, storeURL.Handle, options?.Handle ?? IntPtr.Zero, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removePersistentStore:error:")]
	public virtual bool RemovePersistentStore(NSPersistentStore store, out NSError error)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemovePersistentStoreError_Handle, store.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemovePersistentStoreError_Handle, store.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("migratePersistentStore:toURL:options:withType:error:")]
	public virtual NSPersistentStore MigratePersistentStore(NSPersistentStore store, NSUrl URL, NSDictionary options, NSString storeType, out NSError error)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (storeType == null)
		{
			throw new ArgumentNullException("storeType");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSPersistentStore result = ((!IsDirectBinding) ? ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMigratePersistentStoreToURLOptionsWithTypeError_Handle, store.Handle, URL.Handle, options.Handle, storeType.Handle, intPtr))) : ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selMigratePersistentStoreToURLOptionsWithTypeError_Handle, store.Handle, URL.Handle, options.Handle, storeType.Handle, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("managedObjectIDForURIRepresentation:")]
	public virtual NSManagedObjectID ManagedObjectIDForURIRepresentation(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selManagedObjectIDForURIRepresentation_Handle, url.Handle));
		}
		return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selManagedObjectIDForURIRepresentation_Handle, url.Handle));
	}

	[Export("lock")]
	public virtual void Lock()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockHandle);
		}
	}

	[Export("unlock")]
	public virtual void Unlock()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockHandle);
		}
	}

	[Export("metadataForPersistentStoreWithURL:error:")]
	[Obsolete("Deprecated in MAC OSX 10.5 and later", false)]
	public static NSDictionary MetadataForPersistentStoreWithUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataForPersistentStoreWithURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("executeRequest:withContext:error:")]
	public virtual NSObject ExecuteRequestwithContexterror(NSPersistentStoreRequest request, NSManagedObjectContext context, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selExecuteRequestWithContextError_Handle, request.Handle, context.Handle, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selExecuteRequestWithContextError_Handle, request.Handle, context.Handle, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ManagedObjectModel_var = null;
			__mt_PersistentStores_var = null;
		}
	}
}

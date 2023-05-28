using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentStore", true)]
public class NSPersistentStore : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveStoreRemoteChange(EventHandler<NSPersistentStoreRemoteChangeEventArgs> handler)
		{
			EventHandler<NSPersistentStoreRemoteChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoreRemoteChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSPersistentStoreRemoteChangeEventArgs(notification));
			});
		}

		public static NSObject ObserveStoreRemoteChange(NSObject objectToObserve, EventHandler<NSPersistentStoreRemoteChangeEventArgs> handler)
		{
			EventHandler<NSPersistentStoreRemoteChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StoreRemoteChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSPersistentStoreRemoteChangeEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfigurationName = "configurationName";

	private static readonly IntPtr selConfigurationNameHandle = Selector.GetHandle("configurationName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoreSpotlightExporter = "coreSpotlightExporter";

	private static readonly IntPtr selCoreSpotlightExporterHandle = Selector.GetHandle("coreSpotlightExporter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidAddToPersistentStoreCoordinator_ = "didAddToPersistentStoreCoordinator:";

	private static readonly IntPtr selDidAddToPersistentStoreCoordinator_Handle = Selector.GetHandle("didAddToPersistentStoreCoordinator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_ = "initWithPersistentStoreCoordinator:configurationName:URL:options:";

	private static readonly IntPtr selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle = Selector.GetHandle("initWithPersistentStoreCoordinator:configurationName:URL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadOnly = "isReadOnly";

	private static readonly IntPtr selIsReadOnlyHandle = Selector.GetHandle("isReadOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadMetadata_ = "loadMetadata:";

	private static readonly IntPtr selLoadMetadata_Handle = Selector.GetHandle("loadMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForPersistentStoreWithURL_Error_ = "metadataForPersistentStoreWithURL:error:";

	private static readonly IntPtr selMetadataForPersistentStoreWithURL_Error_Handle = Selector.GetHandle("metadataForPersistentStoreWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMigrationManagerClass = "migrationManagerClass";

	private static readonly IntPtr selMigrationManagerClassHandle = Selector.GetHandle("migrationManagerClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStoreCoordinator = "persistentStoreCoordinator";

	private static readonly IntPtr selPersistentStoreCoordinatorHandle = Selector.GetHandle("persistentStoreCoordinator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ForPersistentStoreWithURL_Error_ = "setMetadata:forPersistentStoreWithURL:error:";

	private static readonly IntPtr selSetMetadata_ForPersistentStoreWithURL_Error_Handle = Selector.GetHandle("setMetadata:forPersistentStoreWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadOnly_ = "setReadOnly:";

	private static readonly IntPtr selSetReadOnly_Handle = Selector.GetHandle("setReadOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillRemoveFromPersistentStoreCoordinator_ = "willRemoveFromPersistentStoreCoordinator:";

	private static readonly IntPtr selWillRemoveFromPersistentStoreCoordinator_Handle = Selector.GetHandle("willRemoveFromPersistentStoreCoordinator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PersistentStoreCoordinator_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemoteChangeNotificationPostOptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SaveConflictsErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StoreRemoteChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ConfigurationName
	{
		[Export("configurationName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSCoreDataCoreSpotlightDelegate CoreSpotlightExporter
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("coreSpotlightExporter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCoreDataCoreSpotlightDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCoreSpotlightExporterHandle));
			}
			return Runtime.GetNSObject<NSCoreDataCoreSpotlightDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCoreSpotlightExporterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Metadata
	{
		[Export("metadata", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Export("setMetadata:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class MigrationManagerClass
	{
		[Export("migrationManagerClass")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selMigrationManagerClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? Options
	{
		[Export("options", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStoreCoordinator? PersistentStoreCoordinator
	{
		[Export("persistentStoreCoordinator", ArgumentSemantic.Weak)]
		get
		{
			NSPersistentStoreCoordinator nSPersistentStoreCoordinator = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreCoordinatorHandle)) : Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreCoordinatorHandle)));
			MarkDirty();
			__mt_PersistentStoreCoordinator_var = nSPersistentStoreCoordinator;
			return nSPersistentStoreCoordinator;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadOnly
	{
		[Export("isReadOnly")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadOnlyHandle);
		}
		[Export("setReadOnly:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReadOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReadOnly_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[Field("NSPersistentStoreRemoteChangeNotificationPostOptionKey", "CoreData")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString RemoteChangeNotificationPostOptionKey
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RemoteChangeNotificationPostOptionKey == null)
			{
				_RemoteChangeNotificationPostOptionKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreRemoteChangeNotificationPostOptionKey");
			}
			return _RemoteChangeNotificationPostOptionKey;
		}
	}

	[Field("NSPersistentStoreSaveConflictsErrorKey", "CoreData")]
	public static NSString SaveConflictsErrorKey
	{
		get
		{
			if (_SaveConflictsErrorKey == null)
			{
				_SaveConflictsErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreSaveConflictsErrorKey");
			}
			return _SaveConflictsErrorKey;
		}
	}

	[Field("NSPersistentStoreRemoteChangeNotification", "CoreData")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Advice("Use NSPersistentStore.Notifications.ObserveStoreRemoteChange helper method instead.")]
	public static NSString StoreRemoteChangeNotification
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_StoreRemoteChangeNotification == null)
			{
				_StoreRemoteChangeNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreRemoteChangeNotification");
			}
			return _StoreRemoteChangeNotification;
		}
	}

	[Obsolete("Default constructor is not available")]
	public NSPersistentStore()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPersistentStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentStore(NSPersistentStoreCoordinator? root, string? name, NSUrl url, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, root?.Handle ?? IntPtr.Zero, arg, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, root?.Handle ?? IntPtr.Zero, arg, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didAddToPersistentStoreCoordinator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddToPersistentStoreCoordinator(NSPersistentStoreCoordinator coordinator)
	{
		if (coordinator == null)
		{
			throw new ArgumentNullException("coordinator");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAddToPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAddToPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
	}

	[Export("loadMetadata:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadMetadata(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selLoadMetadata_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selLoadMetadata_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("metadataForPersistentStoreWithURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary? MetadataForPersistentStoreWithUrl(NSUrl url, out NSError error)
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

	[Export("setMetadata:forPersistentStoreWithURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetMetadata(NSDictionary? metadata, NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selSetMetadata_ForPersistentStoreWithURL_Error_Handle, metadata?.Handle ?? IntPtr.Zero, url.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("willRemoveFromPersistentStoreCoordinator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRemoveFromPersistentStoreCoordinator(NSPersistentStoreCoordinator? coordinator)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveFromPersistentStoreCoordinator_Handle, coordinator?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveFromPersistentStoreCoordinator_Handle, coordinator?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PersistentStoreCoordinator_var = null;
		}
	}
}

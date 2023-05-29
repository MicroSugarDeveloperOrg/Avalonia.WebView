using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMigrationManager", true)]
public class NSMigrationManager : NSObject
{
	private static readonly IntPtr selMappingModelHandle = Selector.GetHandle("mappingModel");

	private static readonly IntPtr selSourceModelHandle = Selector.GetHandle("sourceModel");

	private static readonly IntPtr selDestinationModelHandle = Selector.GetHandle("destinationModel");

	private static readonly IntPtr selSourceContextHandle = Selector.GetHandle("sourceContext");

	private static readonly IntPtr selDestinationContextHandle = Selector.GetHandle("destinationContext");

	private static readonly IntPtr selCurrentEntityMappingHandle = Selector.GetHandle("currentEntityMapping");

	private static readonly IntPtr selMigrationProgressHandle = Selector.GetHandle("migrationProgress");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	private static readonly IntPtr selUsesStoreSpecificMigrationManagerHandle = Selector.GetHandle("usesStoreSpecificMigrationManager");

	private static readonly IntPtr selSetUsesStoreSpecificMigrationManager_Handle = Selector.GetHandle("setUsesStoreSpecificMigrationManager:");

	private static readonly IntPtr selInitWithSourceModelDestinationModel_Handle = Selector.GetHandle("initWithSourceModel:destinationModel:");

	private static readonly IntPtr selMigrateStoreFromURLTypeOptionsWithMappingModelToDestinationURLDestinationTypeDestinationOptionsError_Handle = Selector.GetHandle("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:");

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	private static readonly IntPtr selSourceEntityForEntityMapping_Handle = Selector.GetHandle("sourceEntityForEntityMapping:");

	private static readonly IntPtr selDestinationEntityForEntityMapping_Handle = Selector.GetHandle("destinationEntityForEntityMapping:");

	private static readonly IntPtr selAssociateSourceInstanceWithDestinationInstanceForEntityMapping_Handle = Selector.GetHandle("associateSourceInstance:withDestinationInstance:forEntityMapping:");

	private static readonly IntPtr selDestinationInstancesForEntityMappingNamedSourceInstances_Handle = Selector.GetHandle("destinationInstancesForEntityMappingNamed:sourceInstances:");

	private static readonly IntPtr selSourceInstancesForEntityMappingNamedDestinationInstances_Handle = Selector.GetHandle("sourceInstancesForEntityMappingNamed:destinationInstances:");

	private static readonly IntPtr selCancelMigrationWithError_Handle = Selector.GetHandle("cancelMigrationWithError:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMigrationManager");

	private object __mt_MappingModel_var;

	private object __mt_SourceModel_var;

	private object __mt_DestinationModel_var;

	private object __mt_SourceContext_var;

	private object __mt_DestinationContext_var;

	private object __mt_CurrentEntityMapping_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSMappingModel MappingModel
	{
		[Export("mappingModel")]
		get
		{
			return (NSMappingModel)(__mt_MappingModel_var = ((!IsDirectBinding) ? ((NSMappingModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMappingModelHandle))) : ((NSMappingModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMappingModelHandle)))));
		}
	}

	public virtual NSManagedObjectModel SourceModel
	{
		[Export("sourceModel")]
		get
		{
			return (NSManagedObjectModel)(__mt_SourceModel_var = ((!IsDirectBinding) ? ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceModelHandle))) : ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceModelHandle)))));
		}
	}

	public virtual NSManagedObjectModel DestinationModel
	{
		[Export("destinationModel")]
		get
		{
			return (NSManagedObjectModel)(__mt_DestinationModel_var = ((!IsDirectBinding) ? ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationModelHandle))) : ((NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationModelHandle)))));
		}
	}

	public virtual NSManagedObjectContext SourceContext
	{
		[Export("sourceContext")]
		get
		{
			return (NSManagedObjectContext)(__mt_SourceContext_var = ((!IsDirectBinding) ? ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceContextHandle))) : ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceContextHandle)))));
		}
	}

	public virtual NSManagedObjectContext DestinationContext
	{
		[Export("destinationContext")]
		get
		{
			return (NSManagedObjectContext)(__mt_DestinationContext_var = ((!IsDirectBinding) ? ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationContextHandle))) : ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationContextHandle)))));
		}
	}

	public virtual NSEntityMapping CurrentEntityMapping
	{
		[Export("currentEntityMapping")]
		get
		{
			return (NSEntityMapping)(__mt_CurrentEntityMapping_var = ((!IsDirectBinding) ? ((NSEntityMapping)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEntityMappingHandle))) : ((NSEntityMapping)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEntityMappingHandle)))));
		}
	}

	public virtual float MigrationProgress
	{
		[Export("migrationProgress")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMigrationProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMigrationProgressHandle);
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
		[Export("setUserInfo:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserInfo_Handle, value.Handle);
			}
			__mt_UserInfo_var = value;
		}
	}

	[Since(5, 0)]
	public virtual bool UsesStoreSpecificMigrationManager
	{
		[Export("usesStoreSpecificMigrationManager")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesStoreSpecificMigrationManagerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesStoreSpecificMigrationManagerHandle);
		}
		[Export("setUsesStoreSpecificMigrationManager:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesStoreSpecificMigrationManager_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesStoreSpecificMigrationManager_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMigrationManager()
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
	public NSMigrationManager(NSCoder coder)
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
	public NSMigrationManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMigrationManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceModel:destinationModel:")]
	public NSMigrationManager(NSManagedObjectModel sourceModel, NSManagedObjectModel destinationModel)
		: base(NSObjectFlag.Empty)
	{
		if (sourceModel == null)
		{
			throw new ArgumentNullException("sourceModel");
		}
		if (destinationModel == null)
		{
			throw new ArgumentNullException("destinationModel");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSourceModelDestinationModel_Handle, sourceModel.Handle, destinationModel.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceModelDestinationModel_Handle, sourceModel.Handle, destinationModel.Handle);
		}
	}

	[Export("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:")]
	public virtual bool MigrateStoreFromUrl(NSUrl sourceURL, string sStoreType, NSDictionary sOptions, NSMappingModel mappings, NSUrl dURL, string dStoreType, NSDictionary dOptions, out NSError error)
	{
		if (sourceURL == null)
		{
			throw new ArgumentNullException("sourceURL");
		}
		if (sStoreType == null)
		{
			throw new ArgumentNullException("sStoreType");
		}
		if (sOptions == null)
		{
			throw new ArgumentNullException("sOptions");
		}
		if (mappings == null)
		{
			throw new ArgumentNullException("mappings");
		}
		if (dURL == null)
		{
			throw new ArgumentNullException("dURL");
		}
		if (dStoreType == null)
		{
			throw new ArgumentNullException("dStoreType");
		}
		if (dOptions == null)
		{
			throw new ArgumentNullException("dOptions");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(sStoreType);
		IntPtr arg2 = NSString.CreateNative(dStoreType);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMigrateStoreFromURLTypeOptionsWithMappingModelToDestinationURLDestinationTypeDestinationOptionsError_Handle, sourceURL.Handle, arg, sOptions.Handle, mappings.Handle, dURL.Handle, arg2, dOptions.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selMigrateStoreFromURLTypeOptionsWithMappingModelToDestinationURLDestinationTypeDestinationOptionsError_Handle, sourceURL.Handle, arg, sOptions.Handle, mappings.Handle, dURL.Handle, arg2, dOptions.Handle, intPtr));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("reset")]
	public virtual void Reset()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("sourceEntityForEntityMapping:")]
	public virtual NSEntityDescription SourceEntityForEntityMapping(NSEntityMapping mEntity)
	{
		if (mEntity == null)
		{
			throw new ArgumentNullException("mEntity");
		}
		if (IsDirectBinding)
		{
			return (NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSourceEntityForEntityMapping_Handle, mEntity.Handle));
		}
		return (NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSourceEntityForEntityMapping_Handle, mEntity.Handle));
	}

	[Export("destinationEntityForEntityMapping:")]
	public virtual NSEntityDescription DestinationEntityForEntityMapping(NSEntityMapping mEntity)
	{
		if (mEntity == null)
		{
			throw new ArgumentNullException("mEntity");
		}
		if (IsDirectBinding)
		{
			return (NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDestinationEntityForEntityMapping_Handle, mEntity.Handle));
		}
		return (NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDestinationEntityForEntityMapping_Handle, mEntity.Handle));
	}

	[Export("associateSourceInstance:withDestinationInstance:forEntityMapping:")]
	public virtual void AssociateSourceInstance(NSManagedObject sourceInstance, NSManagedObject destinationInstance, NSEntityMapping entityMapping)
	{
		if (sourceInstance == null)
		{
			throw new ArgumentNullException("sourceInstance");
		}
		if (destinationInstance == null)
		{
			throw new ArgumentNullException("destinationInstance");
		}
		if (entityMapping == null)
		{
			throw new ArgumentNullException("entityMapping");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAssociateSourceInstanceWithDestinationInstanceForEntityMapping_Handle, sourceInstance.Handle, destinationInstance.Handle, entityMapping.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAssociateSourceInstanceWithDestinationInstanceForEntityMapping_Handle, sourceInstance.Handle, destinationInstance.Handle, entityMapping.Handle);
		}
	}

	[Export("destinationInstancesForEntityMappingNamed:sourceInstances:")]
	public virtual NSManagedObject[] DestinationInstancesForEntityMappingNamed(string mappingName, NSManagedObject[] sourceInstances)
	{
		if (mappingName == null)
		{
			throw new ArgumentNullException("mappingName");
		}
		if (sourceInstances == null)
		{
			throw new ArgumentNullException("sourceInstances");
		}
		IntPtr arg = NSString.CreateNative(mappingName);
		NSArray nSArray = NSArray.FromNSObjects(sourceInstances);
		NSManagedObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDestinationInstancesForEntityMappingNamedSourceInstances_Handle, arg, nSArray.Handle)) : NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDestinationInstancesForEntityMappingNamedSourceInstances_Handle, arg, nSArray.Handle)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("sourceInstancesForEntityMappingNamed:destinationInstances:")]
	public virtual NSManagedObject[] SourceInstancesForEntityMappingNamed(string mappingName, NSManagedObject[] destinationInstances)
	{
		if (mappingName == null)
		{
			throw new ArgumentNullException("mappingName");
		}
		if (destinationInstances == null)
		{
			throw new ArgumentNullException("destinationInstances");
		}
		IntPtr arg = NSString.CreateNative(mappingName);
		NSArray nSArray = NSArray.FromNSObjects(destinationInstances);
		NSManagedObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSourceInstancesForEntityMappingNamedDestinationInstances_Handle, arg, nSArray.Handle)) : NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSourceInstancesForEntityMappingNamedDestinationInstances_Handle, arg, nSArray.Handle)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("cancelMigrationWithError:")]
	public virtual void CancelMigrationWithError(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelMigrationWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelMigrationWithError_Handle, error.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MappingModel_var = null;
			__mt_SourceModel_var = null;
			__mt_DestinationModel_var = null;
			__mt_SourceContext_var = null;
			__mt_DestinationContext_var = null;
			__mt_CurrentEntityMapping_var = null;
			__mt_UserInfo_var = null;
		}
	}
}

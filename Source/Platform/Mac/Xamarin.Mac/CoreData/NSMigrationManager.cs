using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMigrationManager", true)]
public class NSMigrationManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_ = "associateSourceInstance:withDestinationInstance:forEntityMapping:";

	private static readonly IntPtr selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_Handle = Selector.GetHandle("associateSourceInstance:withDestinationInstance:forEntityMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelMigrationWithError_ = "cancelMigrationWithError:";

	private static readonly IntPtr selCancelMigrationWithError_Handle = Selector.GetHandle("cancelMigrationWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentEntityMapping = "currentEntityMapping";

	private static readonly IntPtr selCurrentEntityMappingHandle = Selector.GetHandle("currentEntityMapping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationContext = "destinationContext";

	private static readonly IntPtr selDestinationContextHandle = Selector.GetHandle("destinationContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationEntityForEntityMapping_ = "destinationEntityForEntityMapping:";

	private static readonly IntPtr selDestinationEntityForEntityMapping_Handle = Selector.GetHandle("destinationEntityForEntityMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationInstancesForEntityMappingNamed_SourceInstances_ = "destinationInstancesForEntityMappingNamed:sourceInstances:";

	private static readonly IntPtr selDestinationInstancesForEntityMappingNamed_SourceInstances_Handle = Selector.GetHandle("destinationInstancesForEntityMappingNamed:sourceInstances:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationModel = "destinationModel";

	private static readonly IntPtr selDestinationModelHandle = Selector.GetHandle("destinationModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceModel_DestinationModel_ = "initWithSourceModel:destinationModel:";

	private static readonly IntPtr selInitWithSourceModel_DestinationModel_Handle = Selector.GetHandle("initWithSourceModel:destinationModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMappingModel = "mappingModel";

	private static readonly IntPtr selMappingModelHandle = Selector.GetHandle("mappingModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_ = "migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:";

	private static readonly IntPtr selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_Handle = Selector.GetHandle("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMigrationProgress = "migrationProgress";

	private static readonly IntPtr selMigrationProgressHandle = Selector.GetHandle("migrationProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInfo_ = "setUserInfo:";

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesStoreSpecificMigrationManager_ = "setUsesStoreSpecificMigrationManager:";

	private static readonly IntPtr selSetUsesStoreSpecificMigrationManager_Handle = Selector.GetHandle("setUsesStoreSpecificMigrationManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceContext = "sourceContext";

	private static readonly IntPtr selSourceContextHandle = Selector.GetHandle("sourceContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceEntityForEntityMapping_ = "sourceEntityForEntityMapping:";

	private static readonly IntPtr selSourceEntityForEntityMapping_Handle = Selector.GetHandle("sourceEntityForEntityMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceInstancesForEntityMappingNamed_DestinationInstances_ = "sourceInstancesForEntityMappingNamed:destinationInstances:";

	private static readonly IntPtr selSourceInstancesForEntityMappingNamed_DestinationInstances_Handle = Selector.GetHandle("sourceInstancesForEntityMappingNamed:destinationInstances:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceModel = "sourceModel";

	private static readonly IntPtr selSourceModelHandle = Selector.GetHandle("sourceModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesStoreSpecificMigrationManager = "usesStoreSpecificMigrationManager";

	private static readonly IntPtr selUsesStoreSpecificMigrationManagerHandle = Selector.GetHandle("usesStoreSpecificMigrationManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMigrationManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityMapping CurrentEntityMapping
	{
		[Export("currentEntityMapping", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentEntityMappingHandle));
			}
			return Runtime.GetNSObject<NSEntityMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentEntityMappingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext DestinationContext
	{
		[Export("destinationContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectModel DestinationModel
	{
		[Export("destinationModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationModelHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMappingModel MappingModel
	{
		[Export("mappingModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMappingModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selMappingModelHandle));
			}
			return Runtime.GetNSObject<NSMappingModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMappingModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MigrationProgress
	{
		[Export("migrationProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMigrationProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMigrationProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext SourceContext
	{
		[Export("sourceContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectModel SourceModel
	{
		[Export("sourceModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceModelHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? UserInfo
	{
		[Export("userInfo", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
		[Export("setUserInfo:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesStoreSpecificMigrationManager
	{
		[Export("usesStoreSpecificMigrationManager")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesStoreSpecificMigrationManagerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesStoreSpecificMigrationManagerHandle);
		}
		[Export("setUsesStoreSpecificMigrationManager:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesStoreSpecificMigrationManager_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesStoreSpecificMigrationManager_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMigrationManager()
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
	protected NSMigrationManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMigrationManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceModel:destinationModel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSourceModel_DestinationModel_Handle, sourceModel.Handle, destinationModel.Handle), "initWithSourceModel:destinationModel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceModel_DestinationModel_Handle, sourceModel.Handle, destinationModel.Handle), "initWithSourceModel:destinationModel:");
		}
	}

	[Export("associateSourceInstance:withDestinationInstance:forEntityMapping:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_Handle, sourceInstance.Handle, destinationInstance.Handle, entityMapping.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAssociateSourceInstance_WithDestinationInstance_ForEntityMapping_Handle, sourceInstance.Handle, destinationInstance.Handle, entityMapping.Handle);
		}
	}

	[Export("cancelMigrationWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelMigrationWithError(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelMigrationWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelMigrationWithError_Handle, error.Handle);
		}
	}

	[Export("destinationEntityForEntityMapping:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? DestinationEntityForEntityMapping(NSEntityMapping mEntity)
	{
		if (mEntity == null)
		{
			throw new ArgumentNullException("mEntity");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDestinationEntityForEntityMapping_Handle, mEntity.Handle));
		}
		return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDestinationEntityForEntityMapping_Handle, mEntity.Handle));
	}

	[Export("destinationInstancesForEntityMappingNamed:sourceInstances:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject[] DestinationInstancesForEntityMappingNamed(string mappingName, NSManagedObject[]? sourceInstances)
	{
		if (mappingName == null)
		{
			throw new ArgumentNullException("mappingName");
		}
		IntPtr arg = NSString.CreateNative(mappingName);
		NSArray nSArray = ((sourceInstances == null) ? null : NSArray.FromNSObjects(sourceInstances));
		NSManagedObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDestinationInstancesForEntityMappingNamed_SourceInstances_Handle, arg, nSArray?.Handle ?? IntPtr.Zero)) : NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDestinationInstancesForEntityMappingNamed_SourceInstances_Handle, arg, nSArray?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		nSArray?.Dispose();
		return result;
	}

	[Export("migrateStoreFromURL:type:options:withMappingModel:toDestinationURL:destinationType:destinationOptions:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MigrateStoreFromUrl(NSUrl sourceUrl, string sStoreType, NSDictionary? sOptions, NSMappingModel? mappings, NSUrl dUrl, string dStoreType, NSDictionary? dOptions, out NSError error)
	{
		if (sourceUrl == null)
		{
			throw new ArgumentNullException("sourceUrl");
		}
		if (sStoreType == null)
		{
			throw new ArgumentNullException("sStoreType");
		}
		if (dUrl == null)
		{
			throw new ArgumentNullException("dUrl");
		}
		if (dStoreType == null)
		{
			throw new ArgumentNullException("dStoreType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(sStoreType);
		IntPtr arg3 = NSString.CreateNative(dStoreType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_Handle, sourceUrl.Handle, arg2, sOptions?.Handle ?? IntPtr.Zero, mappings?.Handle ?? IntPtr.Zero, dUrl.Handle, arg3, dOptions?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMigrateStoreFromURL_Type_Options_WithMappingModel_ToDestinationURL_DestinationType_DestinationOptions_Error_Handle, sourceUrl.Handle, arg2, sOptions?.Handle ?? IntPtr.Zero, mappings?.Handle ?? IntPtr.Zero, dUrl.Handle, arg3, dOptions?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("sourceEntityForEntityMapping:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? SourceEntityForEntityMapping(NSEntityMapping mEntity)
	{
		if (mEntity == null)
		{
			throw new ArgumentNullException("mEntity");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSourceEntityForEntityMapping_Handle, mEntity.Handle));
		}
		return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSourceEntityForEntityMapping_Handle, mEntity.Handle));
	}

	[Export("sourceInstancesForEntityMappingNamed:destinationInstances:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject[] SourceInstancesForEntityMappingNamed(string mappingName, NSManagedObject[]? destinationInstances)
	{
		if (mappingName == null)
		{
			throw new ArgumentNullException("mappingName");
		}
		IntPtr arg = NSString.CreateNative(mappingName);
		NSArray nSArray = ((destinationInstances == null) ? null : NSArray.FromNSObjects(destinationInstances));
		NSManagedObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSourceInstancesForEntityMappingNamed_DestinationInstances_Handle, arg, nSArray?.Handle ?? IntPtr.Zero)) : NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSourceInstancesForEntityMappingNamed_DestinationInstances_Handle, arg, nSArray?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		nSArray?.Dispose();
		return result;
	}
}

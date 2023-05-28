using System;
using System.ComponentModel;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentCloudKitContainer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSPersistentCloudKitContainer : NSPersistentContainer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ManagedObjectModel_ = "initWithName:managedObjectModel:";

	private static readonly IntPtr selInitWithName_ManagedObjectModel_Handle = Selector.GetHandle("initWithName:managedObjectModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitializeCloudKitSchemaWithOptions_Error_ = "initializeCloudKitSchemaWithOptions:error:";

	private static readonly IntPtr selInitializeCloudKitSchemaWithOptions_Error_Handle = Selector.GetHandle("initializeCloudKitSchemaWithOptions:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordForManagedObjectID_ = "recordForManagedObjectID:";

	private static readonly IntPtr selRecordForManagedObjectID_Handle = Selector.GetHandle("recordForManagedObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordIDForManagedObjectID_ = "recordIDForManagedObjectID:";

	private static readonly IntPtr selRecordIDForManagedObjectID_Handle = Selector.GetHandle("recordIDForManagedObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordIDsForManagedObjectIDs_ = "recordIDsForManagedObjectIDs:";

	private static readonly IntPtr selRecordIDsForManagedObjectIDs_Handle = Selector.GetHandle("recordIDsForManagedObjectIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordsForManagedObjectIDs_ = "recordsForManagedObjectIDs:";

	private static readonly IntPtr selRecordsForManagedObjectIDs_Handle = Selector.GetHandle("recordsForManagedObjectIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentCloudKitContainer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPersistentCloudKitContainer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentCloudKitContainer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:managedObjectModel:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentCloudKitContainer(string name, NSManagedObjectModel model)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_ManagedObjectModel_Handle, arg, model.Handle), "initWithName:managedObjectModel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_ManagedObjectModel_Handle, arg, model.Handle), "initWithName:managedObjectModel:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("recordForManagedObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecord? GetRecord(NSManagedObjectID managedObjectId)
	{
		if (managedObjectId == null)
		{
			throw new ArgumentNullException("managedObjectId");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CKRecord>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecordForManagedObjectID_Handle, managedObjectId.Handle));
		}
		return Runtime.GetNSObject<CKRecord>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordForManagedObjectID_Handle, managedObjectId.Handle));
	}

	[Export("recordIDForManagedObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordID? GetRecordId(NSManagedObjectID managedObjectId)
	{
		if (managedObjectId == null)
		{
			throw new ArgumentNullException("managedObjectId");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CKRecordID>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecordIDForManagedObjectID_Handle, managedObjectId.Handle));
		}
		return Runtime.GetNSObject<CKRecordID>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordIDForManagedObjectID_Handle, managedObjectId.Handle));
	}

	[Export("recordIDsForManagedObjectIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSManagedObjectID, CKRecordID> GetRecordIds(NSManagedObjectID[] managedObjectIds)
	{
		if (managedObjectIds == null)
		{
			throw new ArgumentNullException("managedObjectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(managedObjectIds);
		NSDictionary<NSManagedObjectID, CKRecordID> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSManagedObjectID, CKRecordID>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordIDsForManagedObjectIDs_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSDictionary<NSManagedObjectID, CKRecordID>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecordIDsForManagedObjectIDs_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("recordsForManagedObjectIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSManagedObjectID, CKRecord> GetRecords(NSManagedObjectID[] managedObjectIds)
	{
		if (managedObjectIds == null)
		{
			throw new ArgumentNullException("managedObjectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(managedObjectIds);
		NSDictionary<NSManagedObjectID, CKRecord> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSManagedObjectID, CKRecord>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecordsForManagedObjectIDs_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSDictionary<NSManagedObjectID, CKRecord>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecordsForManagedObjectIDs_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("initializeCloudKitSchemaWithOptions:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Initialize(NSPersistentCloudKitContainerSchemaInitializationOptions options, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_UInt64_ref_IntPtr(base.SuperHandle, selInitializeCloudKitSchemaWithOptions_Error_Handle, (ulong)options, ref arg) : Messaging.bool_objc_msgSend_UInt64_ref_IntPtr(base.Handle, selInitializeCloudKitSchemaWithOptions_Error_Handle, (ulong)options, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAtomicStore", true)]
public class NSAtomicStore : NSPersistentStore
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddCacheNodes_ = "addCacheNodes:";

	private static readonly IntPtr selAddCacheNodes_Handle = Selector.GetHandle("addCacheNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheNodeForObjectID_ = "cacheNodeForObjectID:";

	private static readonly IntPtr selCacheNodeForObjectID_Handle = Selector.GetHandle("cacheNodeForObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheNodes = "cacheNodes";

	private static readonly IntPtr selCacheNodesHandle = Selector.GetHandle("cacheNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_ = "initWithPersistentStoreCoordinator:configurationName:URL:options:";

	private static readonly IntPtr selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle = Selector.GetHandle("initWithPersistentStoreCoordinator:configurationName:URL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoad_ = "load:";

	private static readonly IntPtr selLoad_Handle = Selector.GetHandle("load:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCacheNodeForManagedObject_ = "newCacheNodeForManagedObject:";

	private static readonly IntPtr selNewCacheNodeForManagedObject_Handle = Selector.GetHandle("newCacheNodeForManagedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewReferenceObjectForManagedObject_ = "newReferenceObjectForManagedObject:";

	private static readonly IntPtr selNewReferenceObjectForManagedObject_Handle = Selector.GetHandle("newReferenceObjectForManagedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectIDForEntity_ReferenceObject_ = "objectIDForEntity:referenceObject:";

	private static readonly IntPtr selObjectIDForEntity_ReferenceObject_Handle = Selector.GetHandle("objectIDForEntity:referenceObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceObjectForObjectID_ = "referenceObjectForObjectID:";

	private static readonly IntPtr selReferenceObjectForObjectID_Handle = Selector.GetHandle("referenceObjectForObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSave_ = "save:";

	private static readonly IntPtr selSave_Handle = Selector.GetHandle("save:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCacheNode_FromManagedObject_ = "updateCacheNode:fromManagedObject:";

	private static readonly IntPtr selUpdateCacheNode_FromManagedObject_Handle = Selector.GetHandle("updateCacheNode:fromManagedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillRemoveCacheNodes_ = "willRemoveCacheNodes:";

	private static readonly IntPtr selWillRemoveCacheNodes_Handle = Selector.GetHandle("willRemoveCacheNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAtomicStore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet CacheNodes
	{
		[Export("cacheNodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selCacheNodesHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCacheNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAtomicStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAtomicStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAtomicStore(NSPersistentStoreCoordinator coordinator, string configurationName, NSUrl url, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (coordinator == null)
		{
			throw new ArgumentNullException("coordinator");
		}
		if (configurationName == null)
		{
			throw new ArgumentNullException("configurationName");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(configurationName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, coordinator.Handle, arg, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, coordinator.Handle, arg, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addCacheNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddCacheNodes(NSSet cacheNodes)
	{
		if (cacheNodes == null)
		{
			throw new ArgumentNullException("cacheNodes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddCacheNodes_Handle, cacheNodes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddCacheNodes_Handle, cacheNodes.Handle);
		}
	}

	[Export("cacheNodeForObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAtomicStoreCacheNode? CacheNodeForObjectID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCacheNodeForObjectID_Handle, objectID.Handle));
		}
		return Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCacheNodeForObjectID_Handle, objectID.Handle));
	}

	[Export("load:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Load(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selLoad_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selLoad_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("newCacheNodeForManagedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAtomicStoreCacheNode NewCacheNodeForManagedObject(NSManagedObject managedObject)
	{
		if (managedObject == null)
		{
			throw new ArgumentNullException("managedObject");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCacheNodeForManagedObject_Handle, managedObject.Handle));
		}
		return Runtime.GetNSObject<NSAtomicStoreCacheNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCacheNodeForManagedObject_Handle, managedObject.Handle));
	}

	[Export("newReferenceObjectForManagedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAtomicStore NewReferenceObjectForManagedObject(NSManagedObject managedObject)
	{
		if (managedObject == null)
		{
			throw new ArgumentNullException("managedObject");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAtomicStore>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewReferenceObjectForManagedObject_Handle, managedObject.Handle));
		}
		return Runtime.GetNSObject<NSAtomicStore>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewReferenceObjectForManagedObject_Handle, managedObject.Handle));
	}

	[Export("objectIDForEntity:referenceObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID ObjectIDForEntity(NSEntityDescription entity, NSObject data)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectIDForEntity_ReferenceObject_Handle, entity.Handle, data.Handle));
		}
		return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectIDForEntity_ReferenceObject_Handle, entity.Handle, data.Handle));
	}

	[Export("referenceObjectForObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAtomicStore ReferenceObjectForObjectID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAtomicStore>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReferenceObjectForObjectID_Handle, objectID.Handle));
		}
		return Runtime.GetNSObject<NSAtomicStore>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReferenceObjectForObjectID_Handle, objectID.Handle));
	}

	[Export("save:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selSave_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selSave_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("updateCacheNode:fromManagedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCacheNode(NSAtomicStoreCacheNode node, NSManagedObject managedObject)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (managedObject == null)
		{
			throw new ArgumentNullException("managedObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdateCacheNode_FromManagedObject_Handle, node.Handle, managedObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdateCacheNode_FromManagedObject_Handle, node.Handle, managedObject.Handle);
		}
	}

	[Export("willRemoveCacheNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRemoveCacheNodes(NSSet cacheNodes)
	{
		if (cacheNodes == null)
		{
			throw new ArgumentNullException("cacheNodes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveCacheNodes_Handle, cacheNodes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveCacheNodes_Handle, cacheNodes.Handle);
		}
	}
}

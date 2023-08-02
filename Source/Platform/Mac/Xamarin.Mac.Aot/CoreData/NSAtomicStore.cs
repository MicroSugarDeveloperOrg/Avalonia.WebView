using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAtomicStore", true)]
public class NSAtomicStore : NSPersistentStore
{
	private static readonly IntPtr selCacheNodesHandle = Selector.GetHandle("cacheNodes");

	private static readonly IntPtr selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle = Selector.GetHandle("initWithPersistentStoreCoordinator:configurationName:URL:options:");

	private static readonly IntPtr selLoad_Handle = Selector.GetHandle("load:");

	private static readonly IntPtr selSave_Handle = Selector.GetHandle("save:");

	private static readonly IntPtr selNewCacheNodeForManagedObject_Handle = Selector.GetHandle("newCacheNodeForManagedObject:");

	private static readonly IntPtr selUpdateCacheNodeFromManagedObject_Handle = Selector.GetHandle("updateCacheNode:fromManagedObject:");

	private static readonly IntPtr selAddCacheNodes_Handle = Selector.GetHandle("addCacheNodes:");

	private static readonly IntPtr selWillRemoveCacheNodes_Handle = Selector.GetHandle("willRemoveCacheNodes:");

	private static readonly IntPtr selCacheNodeForObjectID_Handle = Selector.GetHandle("cacheNodeForObjectID:");

	private static readonly IntPtr selObjectIDForEntityReferenceObject_Handle = Selector.GetHandle("objectIDForEntity:referenceObject:");

	private static readonly IntPtr selNewReferenceObjectForManagedObject_Handle = Selector.GetHandle("newReferenceObjectForManagedObject:");

	private static readonly IntPtr selReferenceObjectForObjectID_Handle = Selector.GetHandle("referenceObjectForObjectID:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAtomicStore");

	private object __mt_CacheNodes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSSet CacheNodes
	{
		[Export("cacheNodes")]
		get
		{
			return (NSSet)(__mt_CacheNodes_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCacheNodesHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCacheNodesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSAtomicStore(NSCoder coder)
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
	public NSAtomicStore(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAtomicStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
	public NSAtomicStore(NSPersistentStoreCoordinator coordinator, string configurationName, NSUrl url, NSDictionary options)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle, coordinator.Handle, arg, url.Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle, coordinator.Handle, arg, url.Handle, options?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("load:")]
	public virtual bool Load(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoad_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLoad_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("save:")]
	public virtual bool Save(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSave_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSave_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("newCacheNodeForManagedObject:")]
	public virtual NSAtomicStoreCacheNode NewCacheNodeForManagedObject(NSManagedObject managedObject)
	{
		if (managedObject == null)
		{
			throw new ArgumentNullException("managedObject");
		}
		if (IsDirectBinding)
		{
			return (NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCacheNodeForManagedObject_Handle, managedObject.Handle));
		}
		return (NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCacheNodeForManagedObject_Handle, managedObject.Handle));
	}

	[Export("updateCacheNode:fromManagedObject:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdateCacheNodeFromManagedObject_Handle, node.Handle, managedObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdateCacheNodeFromManagedObject_Handle, node.Handle, managedObject.Handle);
		}
	}

	[Export("addCacheNodes:")]
	public virtual void AddCacheNodes(NSSet cacheNodes)
	{
		if (cacheNodes == null)
		{
			throw new ArgumentNullException("cacheNodes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddCacheNodes_Handle, cacheNodes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddCacheNodes_Handle, cacheNodes.Handle);
		}
	}

	[Export("willRemoveCacheNodes:")]
	public virtual void WillRemoveCacheNodes(NSSet cacheNodes)
	{
		if (cacheNodes == null)
		{
			throw new ArgumentNullException("cacheNodes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveCacheNodes_Handle, cacheNodes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveCacheNodes_Handle, cacheNodes.Handle);
		}
	}

	[Export("cacheNodeForObjectID:")]
	public virtual NSAtomicStoreCacheNode CacheNodeForObjectID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (IsDirectBinding)
		{
			return (NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCacheNodeForObjectID_Handle, objectID.Handle));
		}
		return (NSAtomicStoreCacheNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCacheNodeForObjectID_Handle, objectID.Handle));
	}

	[Export("objectIDForEntity:referenceObject:")]
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
		if (IsDirectBinding)
		{
			return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectIDForEntityReferenceObject_Handle, entity.Handle, data.Handle));
		}
		return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectIDForEntityReferenceObject_Handle, entity.Handle, data.Handle));
	}

	[Export("newReferenceObjectForManagedObject:")]
	public virtual NSAtomicStore NewReferenceObjectForManagedObject(NSManagedObject managedObject)
	{
		if (managedObject == null)
		{
			throw new ArgumentNullException("managedObject");
		}
		if (IsDirectBinding)
		{
			return (NSAtomicStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewReferenceObjectForManagedObject_Handle, managedObject.Handle));
		}
		return (NSAtomicStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewReferenceObjectForManagedObject_Handle, managedObject.Handle));
	}

	[Export("referenceObjectForObjectID:")]
	public virtual NSAtomicStore ReferenceObjectForObjectID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (IsDirectBinding)
		{
			return (NSAtomicStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReferenceObjectForObjectID_Handle, objectID.Handle));
		}
		return (NSAtomicStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReferenceObjectForObjectID_Handle, objectID.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CacheNodes_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSIncrementalStore", true)]
public class NSIncrementalStore : NSPersistentStore
{
	private static readonly IntPtr selLoadMetadata_Handle = Selector.GetHandle("loadMetadata:");

	private static readonly IntPtr selExecuteRequestWithContextError_Handle = Selector.GetHandle("executeRequest:withContext:error:");

	private static readonly IntPtr selNewValuesForObjectWithIDWithContextError_Handle = Selector.GetHandle("newValuesForObjectWithID:withContext:error:");

	private static readonly IntPtr selNewValueForRelationshipForObjectWithIDWithContextError_Handle = Selector.GetHandle("newValueForRelationship:forObjectWithID:withContext:error:");

	private static readonly IntPtr selIdentifierForNewStoreAtURL_Handle = Selector.GetHandle("identifierForNewStoreAtURL:");

	private static readonly IntPtr selObtainPermanentIDsForObjectsError_Handle = Selector.GetHandle("obtainPermanentIDsForObjects:error:");

	private static readonly IntPtr selManagedObjectContextDidRegisterObjectsWithIDs_Handle = Selector.GetHandle("managedObjectContextDidRegisterObjectsWithIDs:");

	private static readonly IntPtr selManagedObjectContextDidUnregisterObjectsWithIDs_Handle = Selector.GetHandle("managedObjectContextDidUnregisterObjectsWithIDs:");

	private static readonly IntPtr selNewObjectIDForEntityReferenceObject_Handle = Selector.GetHandle("newObjectIDForEntity:referenceObject:");

	private static readonly IntPtr selReferenceObjectForObjectID_Handle = Selector.GetHandle("referenceObjectForObjectID:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSIncrementalStore");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIncrementalStore()
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
	public NSIncrementalStore(NSCoder coder)
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
	public NSIncrementalStore(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSIncrementalStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadMetadata:")]
	public virtual bool LoadMetadata(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadMetadata_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLoadMetadata_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("executeRequest:withContext:error:")]
	public virtual NSObject ExecuteRequest(NSPersistentStoreRequest request, NSManagedObjectContext context, out NSError error)
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

	[Export("newValuesForObjectWithID:withContext:error:")]
	public virtual NSIncrementalStoreNode NewValues(NSManagedObjectID forObjectId, NSManagedObjectContext context, out NSError error)
	{
		if (forObjectId == null)
		{
			throw new ArgumentNullException("forObjectId");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSIncrementalStoreNode result = ((!IsDirectBinding) ? ((NSIncrementalStoreNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewValuesForObjectWithIDWithContextError_Handle, forObjectId.Handle, context.Handle, intPtr))) : ((NSIncrementalStoreNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewValuesForObjectWithIDWithContextError_Handle, forObjectId.Handle, context.Handle, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("newValueForRelationship:forObjectWithID:withContext:error:")]
	public virtual NSObject NewValue(NSRelationshipDescription forRelationship, NSManagedObjectID forObjectI, NSManagedObjectContext context, out NSError error)
	{
		if (forRelationship == null)
		{
			throw new ArgumentNullException("forRelationship");
		}
		if (forObjectI == null)
		{
			throw new ArgumentNullException("forObjectI");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewValueForRelationshipForObjectWithIDWithContextError_Handle, forRelationship.Handle, forObjectI.Handle, context.Handle, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selNewValueForRelationshipForObjectWithIDWithContextError_Handle, forRelationship.Handle, forObjectI.Handle, context.Handle, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("identifierForNewStoreAtURL:")]
	public static NSObject IdentifierForNewStoreAtURL(NSUrl storeURL)
	{
		if (storeURL == null)
		{
			throw new ArgumentNullException("storeURL");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selIdentifierForNewStoreAtURL_Handle, storeURL.Handle));
	}

	[Export("obtainPermanentIDsForObjects:error:")]
	public virtual NSObject[] ObtainPermanentIds(NSObject[] array, out NSError error)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(array);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObtainPermanentIDsForObjectsError_Handle, nSArray.Handle, intPtr)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObtainPermanentIDsForObjectsError_Handle, nSArray.Handle, intPtr)));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("managedObjectContextDidRegisterObjectsWithIDs:")]
	public virtual void ManagedObjectContextDidRegisterObjectsWithIds(NSObject[] objectIds)
	{
		if (objectIds == null)
		{
			throw new ArgumentNullException("objectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectIds);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selManagedObjectContextDidRegisterObjectsWithIDs_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selManagedObjectContextDidRegisterObjectsWithIDs_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("managedObjectContextDidUnregisterObjectsWithIDs:")]
	public virtual void ManagedObjectContextDidUnregisterObjectsWithIds(NSObject[] objectIds)
	{
		if (objectIds == null)
		{
			throw new ArgumentNullException("objectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectIds);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selManagedObjectContextDidUnregisterObjectsWithIDs_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selManagedObjectContextDidUnregisterObjectsWithIDs_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("newObjectIDForEntity:referenceObject:")]
	public virtual NSManagedObjectID NewObjectIdFor(NSEntityDescription forEntity, NSObject referenceObject)
	{
		if (forEntity == null)
		{
			throw new ArgumentNullException("forEntity");
		}
		if (referenceObject == null)
		{
			throw new ArgumentNullException("referenceObject");
		}
		if (IsDirectBinding)
		{
			return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selNewObjectIDForEntityReferenceObject_Handle, forEntity.Handle, referenceObject.Handle));
		}
		return (NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selNewObjectIDForEntityReferenceObject_Handle, forEntity.Handle, referenceObject.Handle));
	}

	[Export("referenceObjectForObjectID:")]
	public virtual NSObject ReferenceObjectForObject(NSManagedObjectID objectId)
	{
		if (objectId == null)
		{
			throw new ArgumentNullException("objectId");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReferenceObjectForObjectID_Handle, objectId.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReferenceObjectForObjectID_Handle, objectId.Handle));
	}
}

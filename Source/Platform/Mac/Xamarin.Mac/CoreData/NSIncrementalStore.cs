using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSIncrementalStore", true)]
public class NSIncrementalStore : NSPersistentStore
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteRequest_WithContext_Error_ = "executeRequest:withContext:error:";

	private static readonly IntPtr selExecuteRequest_WithContext_Error_Handle = Selector.GetHandle("executeRequest:withContext:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifierForNewStoreAtURL_ = "identifierForNewStoreAtURL:";

	private static readonly IntPtr selIdentifierForNewStoreAtURL_Handle = Selector.GetHandle("identifierForNewStoreAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_ = "initWithPersistentStoreCoordinator:configurationName:URL:options:";

	private static readonly IntPtr selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle = Selector.GetHandle("initWithPersistentStoreCoordinator:configurationName:URL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadMetadata_ = "loadMetadata:";

	private static readonly IntPtr selLoadMetadata_Handle = Selector.GetHandle("loadMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectContextDidRegisterObjectsWithIDs_ = "managedObjectContextDidRegisterObjectsWithIDs:";

	private static readonly IntPtr selManagedObjectContextDidRegisterObjectsWithIDs_Handle = Selector.GetHandle("managedObjectContextDidRegisterObjectsWithIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectContextDidUnregisterObjectsWithIDs_ = "managedObjectContextDidUnregisterObjectsWithIDs:";

	private static readonly IntPtr selManagedObjectContextDidUnregisterObjectsWithIDs_Handle = Selector.GetHandle("managedObjectContextDidUnregisterObjectsWithIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewObjectIDForEntity_ReferenceObject_ = "newObjectIDForEntity:referenceObject:";

	private static readonly IntPtr selNewObjectIDForEntity_ReferenceObject_Handle = Selector.GetHandle("newObjectIDForEntity:referenceObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewValueForRelationship_ForObjectWithID_WithContext_Error_ = "newValueForRelationship:forObjectWithID:withContext:error:";

	private static readonly IntPtr selNewValueForRelationship_ForObjectWithID_WithContext_Error_Handle = Selector.GetHandle("newValueForRelationship:forObjectWithID:withContext:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewValuesForObjectWithID_WithContext_Error_ = "newValuesForObjectWithID:withContext:error:";

	private static readonly IntPtr selNewValuesForObjectWithID_WithContext_Error_Handle = Selector.GetHandle("newValuesForObjectWithID:withContext:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObtainPermanentIDsForObjects_Error_ = "obtainPermanentIDsForObjects:error:";

	private static readonly IntPtr selObtainPermanentIDsForObjects_Error_Handle = Selector.GetHandle("obtainPermanentIDsForObjects:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceObjectForObjectID_ = "referenceObjectForObjectID:";

	private static readonly IntPtr selReferenceObjectForObjectID_Handle = Selector.GetHandle("referenceObjectForObjectID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSIncrementalStore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIncrementalStore()
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
	protected NSIncrementalStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSIncrementalStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSIncrementalStore(NSPersistentStoreCoordinator root, string name, NSUrl url, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, root.Handle, arg, url.Handle, options.Handle), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersistentStoreCoordinator_ConfigurationName_URL_Options_Handle, root.Handle, arg, url.Handle, options.Handle), "initWithPersistentStoreCoordinator:configurationName:URL:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("executeRequest:withContext:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ExecuteRequest(NSPersistentStoreRequest request, NSManagedObjectContext? context, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteRequest_WithContext_Error_Handle, request.Handle, context?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selExecuteRequest_WithContext_Error_Handle, request.Handle, context?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("identifierForNewStoreAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject IdentifierForNewStoreAtURL(NSUrl storeUrl)
	{
		if (storeUrl == null)
		{
			throw new ArgumentNullException("storeUrl");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selIdentifierForNewStoreAtURL_Handle, storeUrl.Handle));
	}

	[Export("loadMetadata:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool LoadMetadata(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selLoadMetadata_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selLoadMetadata_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("managedObjectContextDidRegisterObjectsWithIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ManagedObjectContextDidRegisterObjectsWithIds(NSObject[] objectIds)
	{
		if (objectIds == null)
		{
			throw new ArgumentNullException("objectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectIds);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ManagedObjectContextDidUnregisterObjectsWithIds(NSObject[] objectIds)
	{
		if (objectIds == null)
		{
			throw new ArgumentNullException("objectIds");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectIds);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selNewObjectIDForEntity_ReferenceObject_Handle, forEntity.Handle, referenceObject.Handle));
		}
		return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selNewObjectIDForEntity_ReferenceObject_Handle, forEntity.Handle, referenceObject.Handle));
	}

	[Export("newValueForRelationship:forObjectWithID:withContext:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? NewValue(NSRelationshipDescription forRelationship, NSManagedObjectID forObjectI, NSManagedObjectContext? context, out NSError error)
	{
		if (forRelationship == null)
		{
			throw new ArgumentNullException("forRelationship");
		}
		if (forObjectI == null)
		{
			throw new ArgumentNullException("forObjectI");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewValueForRelationship_ForObjectWithID_WithContext_Error_Handle, forRelationship.Handle, forObjectI.Handle, context?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewValueForRelationship_ForObjectWithID_WithContext_Error_Handle, forRelationship.Handle, forObjectI.Handle, context?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("newValuesForObjectWithID:withContext:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIncrementalStoreNode? NewValues(NSManagedObjectID forObjectId, NSManagedObjectContext context, out NSError error)
	{
		if (forObjectId == null)
		{
			throw new ArgumentNullException("forObjectId");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = IntPtr.Zero;
		NSIncrementalStoreNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSIncrementalStoreNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewValuesForObjectWithID_WithContext_Error_Handle, forObjectId.Handle, context.Handle, ref arg)) : Runtime.GetNSObject<NSIncrementalStoreNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewValuesForObjectWithID_WithContext_Error_Handle, forObjectId.Handle, context.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("obtainPermanentIDsForObjects:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? ObtainPermanentIds(NSObject[] array, out NSError error)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(array);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selObtainPermanentIDsForObjects_Error_Handle, nSArray.Handle, ref arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selObtainPermanentIDsForObjects_Error_Handle, nSArray.Handle, ref arg)));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("referenceObjectForObjectID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ReferenceObjectForObject(NSManagedObjectID objectId)
	{
		if (objectId == null)
		{
			throw new ArgumentNullException("objectId");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReferenceObjectForObjectID_Handle, objectId.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReferenceObjectForObjectID_Handle, objectId.Handle));
	}
}

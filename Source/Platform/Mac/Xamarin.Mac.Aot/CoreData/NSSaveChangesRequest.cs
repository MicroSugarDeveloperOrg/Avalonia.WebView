using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSSaveChangesRequest", true)]
public class NSSaveChangesRequest : NSPersistentStoreRequest
{
	private static readonly IntPtr selInsertedObjectsHandle = Selector.GetHandle("insertedObjects");

	private static readonly IntPtr selUpdatedObjectsHandle = Selector.GetHandle("updatedObjects");

	private static readonly IntPtr selDeletedObjectsHandle = Selector.GetHandle("deletedObjects");

	private static readonly IntPtr selLockedObjectsHandle = Selector.GetHandle("lockedObjects");

	private static readonly IntPtr selInitWithInsertedObjectsUpdatedObjectsDeletedObjectsLockedObjects_Handle = Selector.GetHandle("initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSaveChangesRequest");

	private object __mt_InsertedObjects_var;

	private object __mt_UpdatedObjects_var;

	private object __mt_DeletedObjects_var;

	private object __mt_LockedObjects_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSSet InsertedObjects
	{
		[Export("insertedObjects")]
		get
		{
			return (NSSet)(__mt_InsertedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedObjectsHandle)))));
		}
	}

	public virtual NSSet UpdatedObjects
	{
		[Export("updatedObjects")]
		get
		{
			return (NSSet)(__mt_UpdatedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpdatedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUpdatedObjectsHandle)))));
		}
	}

	public virtual NSSet DeletedObjects
	{
		[Export("deletedObjects")]
		get
		{
			return (NSSet)(__mt_DeletedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeletedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeletedObjectsHandle)))));
		}
	}

	public virtual NSSet LockedObjects
	{
		[Export("lockedObjects")]
		get
		{
			return (NSSet)(__mt_LockedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLockedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLockedObjectsHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSaveChangesRequest()
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
	public NSSaveChangesRequest(NSCoder coder)
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
	public NSSaveChangesRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSaveChangesRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:")]
	public NSSaveChangesRequest(NSSet insertedObjects, NSSet updatedObjects, NSSet deletedObjects, NSSet lockedObjects)
		: base(NSObjectFlag.Empty)
	{
		if (insertedObjects == null)
		{
			throw new ArgumentNullException("insertedObjects");
		}
		if (updatedObjects == null)
		{
			throw new ArgumentNullException("updatedObjects");
		}
		if (deletedObjects == null)
		{
			throw new ArgumentNullException("deletedObjects");
		}
		if (lockedObjects == null)
		{
			throw new ArgumentNullException("lockedObjects");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithInsertedObjectsUpdatedObjectsDeletedObjectsLockedObjects_Handle, insertedObjects.Handle, updatedObjects.Handle, deletedObjects.Handle, lockedObjects.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithInsertedObjectsUpdatedObjectsDeletedObjectsLockedObjects_Handle, insertedObjects.Handle, updatedObjects.Handle, deletedObjects.Handle, lockedObjects.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InsertedObjects_var = null;
			__mt_UpdatedObjects_var = null;
			__mt_DeletedObjects_var = null;
			__mt_LockedObjects_var = null;
		}
	}
}

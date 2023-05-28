using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSSaveChangesRequest", true)]
public class NSSaveChangesRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeletedObjects = "deletedObjects";

	private static readonly IntPtr selDeletedObjectsHandle = Selector.GetHandle("deletedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInsertedObjects_UpdatedObjects_DeletedObjects_LockedObjects_ = "initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:";

	private static readonly IntPtr selInitWithInsertedObjects_UpdatedObjects_DeletedObjects_LockedObjects_Handle = Selector.GetHandle("initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertedObjects = "insertedObjects";

	private static readonly IntPtr selInsertedObjectsHandle = Selector.GetHandle("insertedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockedObjects = "lockedObjects";

	private static readonly IntPtr selLockedObjectsHandle = Selector.GetHandle("lockedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdatedObjects = "updatedObjects";

	private static readonly IntPtr selUpdatedObjectsHandle = Selector.GetHandle("updatedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSaveChangesRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? DeletedObjects
	{
		[Export("deletedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeletedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeletedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? InsertedObjects
	{
		[Export("insertedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? LockedObjects
	{
		[Export("lockedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selLockedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLockedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? UpdatedObjects
	{
		[Export("updatedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selUpdatedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpdatedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSaveChangesRequest()
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
	protected NSSaveChangesRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSaveChangesRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSaveChangesRequest(NSSet? insertedObjects, NSSet? updatedObjects, NSSet? deletedObjects, NSSet? lockedObjects)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithInsertedObjects_UpdatedObjects_DeletedObjects_LockedObjects_Handle, insertedObjects?.Handle ?? IntPtr.Zero, updatedObjects?.Handle ?? IntPtr.Zero, deletedObjects?.Handle ?? IntPtr.Zero, lockedObjects?.Handle ?? IntPtr.Zero), "initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithInsertedObjects_UpdatedObjects_DeletedObjects_LockedObjects_Handle, insertedObjects?.Handle ?? IntPtr.Zero, updatedObjects?.Handle ?? IntPtr.Zero, deletedObjects?.Handle ?? IntPtr.Zero, lockedObjects?.Handle ?? IntPtr.Zero), "initWithInsertedObjects:updatedObjects:deletedObjects:lockedObjects:");
		}
	}
}

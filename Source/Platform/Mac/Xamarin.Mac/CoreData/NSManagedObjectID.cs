using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectID", true)]
public class NSManagedObjectID : NSObject
{
	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	private static readonly IntPtr selPersistentStoreHandle = Selector.GetHandle("persistentStore");

	private static readonly IntPtr selIsTemporaryIDHandle = Selector.GetHandle("isTemporaryID");

	private static readonly IntPtr selURIRepresentationHandle = Selector.GetHandle("URIRepresentation");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSManagedObjectID");

	private object __mt_Entity_var;

	private object __mt_PersistentStore_var;

	private object __mt_URIRepresentation_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEntityDescription Entity
	{
		[Export("entity")]
		get
		{
			return (NSEntityDescription)(__mt_Entity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle)))));
		}
	}

	public virtual NSPersistentStore PersistentStore
	{
		[Export("persistentStore")]
		get
		{
			return (NSPersistentStore)(__mt_PersistentStore_var = ((!IsDirectBinding) ? ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreHandle))) : ((NSPersistentStore)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreHandle)))));
		}
	}

	public virtual bool IsTemporaryID
	{
		[Export("isTemporaryID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemporaryIDHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemporaryIDHandle);
		}
	}

	public virtual NSUrl URIRepresentation
	{
		[Export("URIRepresentation")]
		get
		{
			return (NSUrl)(__mt_URIRepresentation_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURIRepresentationHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURIRepresentationHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSManagedObjectID(NSCoder coder)
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
	public NSManagedObjectID(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSManagedObjectID(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Entity_var = null;
			__mt_PersistentStore_var = null;
			__mt_URIRepresentation_var = null;
		}
	}
}

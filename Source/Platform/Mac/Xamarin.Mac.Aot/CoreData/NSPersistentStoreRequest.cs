using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentStoreRequest", true)]
public class NSPersistentStoreRequest : NSObject
{
	private static readonly IntPtr selRequestTypeHandle = Selector.GetHandle("requestType");

	private static readonly IntPtr selAffectedStoresHandle = Selector.GetHandle("affectedStores");

	private static readonly IntPtr selSetAffectedStores_Handle = Selector.GetHandle("setAffectedStores:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPersistentStoreRequest");

	private object __mt_AffectedStores_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPersistentStoreRequestType RequestType
	{
		[Export("requestType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSPersistentStoreRequestType)Messaging.UInt64_objc_msgSend(base.Handle, selRequestTypeHandle);
			}
			return (NSPersistentStoreRequestType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRequestTypeHandle);
		}
	}

	public virtual NSPersistentStore[] AffectedStores
	{
		[Export("affectedStores")]
		get
		{
			return (NSPersistentStore[])(__mt_AffectedStores_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAffectedStoresHandle)) : NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selAffectedStoresHandle))));
		}
		[Export("setAffectedStores:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAffectedStores_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAffectedStores_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_AffectedStores_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPersistentStoreRequest()
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
	public NSPersistentStoreRequest(NSCoder coder)
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
	public NSPersistentStoreRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPersistentStoreRequest(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AffectedStores_var = null;
		}
	}
}

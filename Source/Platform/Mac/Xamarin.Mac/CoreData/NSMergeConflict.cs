using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMergeConflict", true)]
public class NSMergeConflict : NSObject
{
	private static readonly IntPtr selSourceObjectHandle = Selector.GetHandle("sourceObject");

	private static readonly IntPtr selObjectSnapshotHandle = Selector.GetHandle("objectSnapshot");

	private static readonly IntPtr selCachedSnapshotHandle = Selector.GetHandle("cachedSnapshot");

	private static readonly IntPtr selPersistedSnapshotHandle = Selector.GetHandle("persistedSnapshot");

	private static readonly IntPtr selNewVersionNumberHandle = Selector.GetHandle("newVersionNumber");

	private static readonly IntPtr selOldVersionNumberHandle = Selector.GetHandle("oldVersionNumber");

	private static readonly IntPtr selInitWithSourceNewVersionOldVersionCachedSnapshotPersistedSnapshot_Handle = Selector.GetHandle("initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMergeConflict");

	private object __mt_SourceObject_var;

	private object __mt_ObjectSnapshot_var;

	private object __mt_CachedSnapshot_var;

	private object __mt_PersistedSnapshot_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSManagedObject SourceObject
	{
		[Export("sourceObject")]
		get
		{
			return (NSManagedObject)(__mt_SourceObject_var = ((!IsDirectBinding) ? ((NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceObjectHandle))) : ((NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceObjectHandle)))));
		}
	}

	public virtual NSDictionary ObjectSnapshot
	{
		[Export("objectSnapshot")]
		get
		{
			return (NSDictionary)(__mt_ObjectSnapshot_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectSnapshotHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectSnapshotHandle)))));
		}
	}

	public virtual NSDictionary CachedSnapshot
	{
		[Export("cachedSnapshot")]
		get
		{
			return (NSDictionary)(__mt_CachedSnapshot_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCachedSnapshotHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCachedSnapshotHandle)))));
		}
	}

	public virtual NSDictionary PersistedSnapshot
	{
		[Export("persistedSnapshot")]
		get
		{
			return (NSDictionary)(__mt_PersistedSnapshot_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistedSnapshotHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistedSnapshotHandle)))));
		}
	}

	public virtual uint NewVersionNumber
	{
		[Export("newVersionNumber")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selNewVersionNumberHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selNewVersionNumberHandle);
		}
	}

	public virtual uint OldVersionNumber
	{
		[Export("oldVersionNumber")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selOldVersionNumberHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selOldVersionNumberHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMergeConflict()
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
	public NSMergeConflict(NSCoder coder)
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
	public NSMergeConflict(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMergeConflict(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:")]
	public NSMergeConflict(NSManagedObject srcObject, uint newvers, uint oldvers, NSDictionary cachesnap, NSDictionary persnap)
		: base(NSObjectFlag.Empty)
	{
		if (srcObject == null)
		{
			throw new ArgumentNullException("srcObject");
		}
		if (cachesnap == null)
		{
			throw new ArgumentNullException("cachesnap");
		}
		if (persnap == null)
		{
			throw new ArgumentNullException("persnap");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr(base.Handle, selInitWithSourceNewVersionOldVersionCachedSnapshotPersistedSnapshot_Handle, srcObject.Handle, newvers, oldvers, cachesnap.Handle, persnap.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceNewVersionOldVersionCachedSnapshotPersistedSnapshot_Handle, srcObject.Handle, newvers, oldvers, cachesnap.Handle, persnap.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SourceObject_var = null;
			__mt_ObjectSnapshot_var = null;
			__mt_CachedSnapshot_var = null;
			__mt_PersistedSnapshot_var = null;
		}
	}
}

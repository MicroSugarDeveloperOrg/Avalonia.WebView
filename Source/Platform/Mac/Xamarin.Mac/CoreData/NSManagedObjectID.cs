using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectID", true)]
public class NSManagedObjectID : NSObject, INSCopying, INativeObject, IDisposable, INSFetchRequestResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURIRepresentation = "URIRepresentation";

	private static readonly IntPtr selURIRepresentationHandle = Selector.GetHandle("URIRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTemporaryID = "isTemporaryID";

	private static readonly IntPtr selIsTemporaryIDHandle = Selector.GetHandle("isTemporaryID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStore = "persistentStore";

	private static readonly IntPtr selPersistentStoreHandle = Selector.GetHandle("persistentStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSManagedObjectID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PersistentStore_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription Entity
	{
		[Export("entity", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle));
			}
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsTemporaryID
	{
		[Export("isTemporaryID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemporaryIDHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemporaryIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStore? PersistentStore
	{
		[Export("persistentStore", ArgumentSemantic.Weak)]
		get
		{
			NSPersistentStore nSPersistentStore = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreHandle)) : Runtime.GetNSObject<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreHandle)));
			MarkDirty();
			__mt_PersistentStore_var = nSPersistentStore;
			return nSPersistentStore;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl URIRepresentation
	{
		[Export("URIRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURIRepresentationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURIRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSManagedObjectID(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSManagedObjectID(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PersistentStore_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentHistoryChange", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public abstract class NSPersistentHistoryChange : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeID = "changeID";

	private static readonly IntPtr selChangeIDHandle = Selector.GetHandle("changeID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeType = "changeType";

	private static readonly IntPtr selChangeTypeHandle = Selector.GetHandle("changeType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangedObjectID = "changedObjectID";

	private static readonly IntPtr selChangedObjectIDHandle = Selector.GetHandle("changedObjectID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityDescription = "entityDescription";

	private static readonly IntPtr selEntityDescriptionHandle = Selector.GetHandle("entityDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityDescriptionWithContext_ = "entityDescriptionWithContext:";

	private static readonly IntPtr selEntityDescriptionWithContext_Handle = Selector.GetHandle("entityDescriptionWithContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequest = "fetchRequest";

	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTombstone = "tombstone";

	private static readonly IntPtr selTombstoneHandle = Selector.GetHandle("tombstone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransaction = "transaction";

	private static readonly IntPtr selTransactionHandle = Selector.GetHandle("transaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdatedProperties = "updatedProperties";

	private static readonly IntPtr selUpdatedPropertiesHandle = Selector.GetHandle("updatedProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentHistoryChange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long ChangeId
	{
		[Export("changeID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selChangeIDHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChangeIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentHistoryChangeType ChangeType
	{
		[Export("changeType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSPersistentHistoryChangeType)Messaging.Int64_objc_msgSend(base.Handle, selChangeTypeHandle);
			}
			return (NSPersistentHistoryChangeType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChangeTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID ChangedObjectId
	{
		[Export("changedObjectID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedObjectIDHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedObjectIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSEntityDescription? EntityDescription
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("entityDescription")]
		get
		{
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(class_ptr, selEntityDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSFetchRequest? FetchRequest
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("fetchRequest")]
		get
		{
			return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend(class_ptr, selFetchRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? Tombstone
	{
		[Export("tombstone", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTombstoneHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTombstoneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentHistoryTransaction? Transaction
	{
		[Export("transaction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersistentHistoryTransaction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionHandle));
			}
			return Runtime.GetNSObject<NSPersistentHistoryTransaction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet<NSPropertyDescription>? UpdatedProperties
	{
		[Export("updatedProperties", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSPropertyDescription>>(Messaging.IntPtr_objc_msgSend(base.Handle, selUpdatedPropertiesHandle));
			}
			return Runtime.GetNSObject<NSSet<NSPropertyDescription>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpdatedPropertiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSPersistentHistoryChange()
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
	protected NSPersistentHistoryChange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentHistoryChange(IntPtr handle)
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

	[Export("entityDescriptionWithContext:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEntityDescription? GetEntityDescription(NSManagedObjectContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEntityDescriptionWithContext_Handle, context.Handle));
	}
}

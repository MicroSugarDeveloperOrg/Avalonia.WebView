using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreData;

[Register("NSMergeConflict", true)]
public class NSMergeConflict : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCachedSnapshot = "cachedSnapshot";

	private static readonly IntPtr selCachedSnapshotHandle = Selector.GetHandle("cachedSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_NewVersion_OldVersion_CachedSnapshot_PersistedSnapshot_ = "initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:";

	private static readonly IntPtr selInitWithSource_NewVersion_OldVersion_CachedSnapshot_PersistedSnapshot_Handle = Selector.GetHandle("initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewVersionNumber = "newVersionNumber";

	private static readonly IntPtr selNewVersionNumberHandle = Selector.GetHandle("newVersionNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectSnapshot = "objectSnapshot";

	private static readonly IntPtr selObjectSnapshotHandle = Selector.GetHandle("objectSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOldVersionNumber = "oldVersionNumber";

	private static readonly IntPtr selOldVersionNumberHandle = Selector.GetHandle("oldVersionNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistedSnapshot = "persistedSnapshot";

	private static readonly IntPtr selPersistedSnapshotHandle = Selector.GetHandle("persistedSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceObject = "sourceObject";

	private static readonly IntPtr selSourceObjectHandle = Selector.GetHandle("sourceObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMergeConflict");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary CachedSnapshot
	{
		[Export("cachedSnapshot", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selCachedSnapshotHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCachedSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NewVersionNumber
	{
		[Export("newVersionNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNewVersionNumberHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNewVersionNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ObjectSnapshot
	{
		[Export("objectSnapshot", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectSnapshotHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint OldVersionNumber
	{
		[Export("oldVersionNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOldVersionNumberHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOldVersionNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary PersistedSnapshot
	{
		[Export("persistedSnapshot", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistedSnapshotHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistedSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject SourceObject
	{
		[Export("sourceObject", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceObjectHandle));
			}
			return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceObjectHandle));
		}
	}

	[Obsolete("Default constructor is not available")]
	public NSMergeConflict()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMergeConflict(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMergeConflict(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMergeConflict(NSManagedObject srcObject, nuint newvers, nuint oldvers, NSDictionary? cachesnap, NSDictionary? persnap)
		: base(NSObjectFlag.Empty)
	{
		if (srcObject == null)
		{
			throw new ArgumentNullException("srcObject");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_IntPtr_IntPtr(base.Handle, selInitWithSource_NewVersion_OldVersion_CachedSnapshot_PersistedSnapshot_Handle, srcObject.Handle, newvers, oldvers, cachesnap?.Handle ?? IntPtr.Zero, persnap?.Handle ?? IntPtr.Zero), "initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_NewVersion_OldVersion_CachedSnapshot_PersistedSnapshot_Handle, srcObject.Handle, newvers, oldvers, cachesnap?.Handle ?? IntPtr.Zero, persnap?.Handle ?? IntPtr.Zero), "initWithSource:newVersion:oldVersion:cachedSnapshot:persistedSnapshot:");
		}
	}
}

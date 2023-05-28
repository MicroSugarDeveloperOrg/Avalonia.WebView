using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMergePolicy", true)]
public class NSMergePolicy : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorMergePolicy = "errorMergePolicy";

	private static readonly IntPtr selErrorMergePolicyHandle = Selector.GetHandle("errorMergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMergeType_ = "initWithMergeType:";

	private static readonly IntPtr selInitWithMergeType_Handle = Selector.GetHandle("initWithMergeType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeByPropertyObjectTrumpMergePolicy = "mergeByPropertyObjectTrumpMergePolicy";

	private static readonly IntPtr selMergeByPropertyObjectTrumpMergePolicyHandle = Selector.GetHandle("mergeByPropertyObjectTrumpMergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeByPropertyStoreTrumpMergePolicy = "mergeByPropertyStoreTrumpMergePolicy";

	private static readonly IntPtr selMergeByPropertyStoreTrumpMergePolicyHandle = Selector.GetHandle("mergeByPropertyStoreTrumpMergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeType = "mergeType";

	private static readonly IntPtr selMergeTypeHandle = Selector.GetHandle("mergeType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverwriteMergePolicy = "overwriteMergePolicy";

	private static readonly IntPtr selOverwriteMergePolicyHandle = Selector.GetHandle("overwriteMergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveConflicts_Error_ = "resolveConflicts:error:";

	private static readonly IntPtr selResolveConflicts_Error_Handle = Selector.GetHandle("resolveConflicts:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveConstraintConflicts_Error_ = "resolveConstraintConflicts:error:";

	private static readonly IntPtr selResolveConstraintConflicts_Error_Handle = Selector.GetHandle("resolveConstraintConflicts:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveOptimisticLockingVersionConflicts_Error_ = "resolveOptimisticLockingVersionConflicts:error:";

	private static readonly IntPtr selResolveOptimisticLockingVersionConflicts_Error_Handle = Selector.GetHandle("resolveOptimisticLockingVersionConflicts:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRollbackMergePolicy = "rollbackMergePolicy";

	private static readonly IntPtr selRollbackMergePolicyHandle = Selector.GetHandle("rollbackMergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMergePolicy");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSMergePolicy ErrorPolicy
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("errorMergePolicy", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSMergePolicy>(Messaging.IntPtr_objc_msgSend(class_ptr, selErrorMergePolicyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSMergePolicy MergeByPropertyObjectTrumpPolicy
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("mergeByPropertyObjectTrumpMergePolicy", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSMergePolicy>(Messaging.IntPtr_objc_msgSend(class_ptr, selMergeByPropertyObjectTrumpMergePolicyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSMergePolicy MergeByPropertyStoreTrumpPolicy
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("mergeByPropertyStoreTrumpMergePolicy", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSMergePolicy>(Messaging.IntPtr_objc_msgSend(class_ptr, selMergeByPropertyStoreTrumpMergePolicyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMergePolicyType MergeType
	{
		[Export("mergeType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSMergePolicyType)Messaging.UInt64_objc_msgSend(base.Handle, selMergeTypeHandle);
			}
			return (NSMergePolicyType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMergeTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSMergePolicy OverwritePolicy
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("overwriteMergePolicy", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSMergePolicy>(Messaging.IntPtr_objc_msgSend(class_ptr, selOverwriteMergePolicyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSMergePolicy RollbackPolicy
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("rollbackMergePolicy", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSMergePolicy>(Messaging.IntPtr_objc_msgSend(class_ptr, selRollbackMergePolicyHandle));
		}
	}

	[Obsolete("Default constructor is not available")]
	public NSMergePolicy()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMergePolicy(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMergePolicy(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMergeType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMergePolicy(NSMergePolicyType ty)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithMergeType_Handle, (ulong)ty), "initWithMergeType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithMergeType_Handle, (ulong)ty), "initWithMergeType:");
		}
	}

	[Export("resolveConflicts:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ResolveConflictserror(NSMergeConflict[] list, out NSError error)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(list);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selResolveConflicts_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selResolveConflicts_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("resolveConstraintConflicts:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ResolveConstraintConflicts(NSConstraintConflict[] list, out NSError error)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(list);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selResolveConstraintConflicts_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selResolveConstraintConflicts_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("resolveOptimisticLockingVersionConflicts:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ResolveOptimisticLockingVersionConflicts(NSMergeConflict[] list, out NSError error)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(list);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selResolveOptimisticLockingVersionConflicts_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selResolveOptimisticLockingVersionConflicts_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

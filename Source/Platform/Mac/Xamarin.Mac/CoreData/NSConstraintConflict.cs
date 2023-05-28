using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSConstraintConflict", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSConstraintConflict : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConflictingObjects = "conflictingObjects";

	private static readonly IntPtr selConflictingObjectsHandle = Selector.GetHandle("conflictingObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConflictingSnapshots = "conflictingSnapshots";

	private static readonly IntPtr selConflictingSnapshotsHandle = Selector.GetHandle("conflictingSnapshots");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraint = "constraint";

	private static readonly IntPtr selConstraintHandle = Selector.GetHandle("constraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintValues = "constraintValues";

	private static readonly IntPtr selConstraintValuesHandle = Selector.GetHandle("constraintValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatabaseObject = "databaseObject";

	private static readonly IntPtr selDatabaseObjectHandle = Selector.GetHandle("databaseObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatabaseSnapshot = "databaseSnapshot";

	private static readonly IntPtr selDatabaseSnapshotHandle = Selector.GetHandle("databaseSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithConstraint_DatabaseObject_DatabaseSnapshot_ConflictingObjects_ConflictingSnapshots_ = "initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:";

	private static readonly IntPtr selInitWithConstraint_DatabaseObject_DatabaseSnapshot_ConflictingObjects_ConflictingSnapshots_Handle = Selector.GetHandle("initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSConstraintConflict");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject[] ConflictingObjects
	{
		[Export("conflictingObjects", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selConflictingObjectsHandle));
			}
			return NSArray.ArrayFromHandle<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConflictingObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary[] ConflictingSnapshots
	{
		[Export("conflictingSnapshots", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selConflictingSnapshotsHandle));
			}
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConflictingSnapshotsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Constraint
	{
		[Export("constraint", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject> ConstraintValues
	{
		[Export("constraintValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject? DatabaseObject
	{
		[Export("databaseObject", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selDatabaseObjectHandle));
			}
			return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDatabaseObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>? DatabaseSnapshot
	{
		[Export("databaseSnapshot", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selDatabaseSnapshotHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDatabaseSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSConstraintConflict()
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
	protected NSConstraintConflict(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSConstraintConflict(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSConstraintConflict(string[] contraint, NSManagedObject? databaseObject, NSDictionary? databaseSnapshot, NSManagedObject[] conflictingObjects, NSObject[] conflictingSnapshots)
		: base(NSObjectFlag.Empty)
	{
		if (contraint == null)
		{
			throw new ArgumentNullException("contraint");
		}
		if (conflictingObjects == null)
		{
			throw new ArgumentNullException("conflictingObjects");
		}
		if (conflictingSnapshots == null)
		{
			throw new ArgumentNullException("conflictingSnapshots");
		}
		NSArray nSArray = NSArray.FromStrings(contraint);
		NSArray nSArray2 = NSArray.FromNSObjects(conflictingObjects);
		NSArray nSArray3 = NSArray.FromNSObjects(conflictingSnapshots);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithConstraint_DatabaseObject_DatabaseSnapshot_ConflictingObjects_ConflictingSnapshots_Handle, nSArray.Handle, databaseObject?.Handle ?? IntPtr.Zero, databaseSnapshot?.Handle ?? IntPtr.Zero, nSArray2.Handle, nSArray3.Handle), "initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithConstraint_DatabaseObject_DatabaseSnapshot_ConflictingObjects_ConflictingSnapshots_Handle, nSArray.Handle, databaseObject?.Handle ?? IntPtr.Zero, databaseSnapshot?.Handle ?? IntPtr.Zero, nSArray2.Handle, nSArray3.Handle), "initWithConstraint:databaseObject:databaseSnapshot:conflictingObjects:conflictingSnapshots:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityMigrationPolicy", true)]
public class NSEntityMigrationPolicy : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginEntityMapping_Manager_Error_ = "beginEntityMapping:manager:error:";

	private static readonly IntPtr selBeginEntityMapping_Manager_Error_Handle = Selector.GetHandle("beginEntityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDestinationInstancesForSourceInstance_EntityMapping_Manager_Error_ = "createDestinationInstancesForSourceInstance:entityMapping:manager:error:";

	private static readonly IntPtr selCreateDestinationInstancesForSourceInstance_EntityMapping_Manager_Error_Handle = Selector.GetHandle("createDestinationInstancesForSourceInstance:entityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRelationshipsForDestinationInstance_EntityMapping_Manager_Error_ = "createRelationshipsForDestinationInstance:entityMapping:manager:error:";

	private static readonly IntPtr selCreateRelationshipsForDestinationInstance_EntityMapping_Manager_Error_Handle = Selector.GetHandle("createRelationshipsForDestinationInstance:entityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndEntityMapping_Manager_Error_ = "endEntityMapping:manager:error:";

	private static readonly IntPtr selEndEntityMapping_Manager_Error_Handle = Selector.GetHandle("endEntityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndInstanceCreationForEntityMapping_Manager_Error_ = "endInstanceCreationForEntityMapping:manager:error:";

	private static readonly IntPtr selEndInstanceCreationForEntityMapping_Manager_Error_Handle = Selector.GetHandle("endInstanceCreationForEntityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndRelationshipCreationForEntityMapping_Manager_Error_ = "endRelationshipCreationForEntityMapping:manager:error:";

	private static readonly IntPtr selEndRelationshipCreationForEntityMapping_Manager_Error_Handle = Selector.GetHandle("endRelationshipCreationForEntityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformCustomValidationForEntityMapping_Manager_Error_ = "performCustomValidationForEntityMapping:manager:error:";

	private static readonly IntPtr selPerformCustomValidationForEntityMapping_Manager_Error_Handle = Selector.GetHandle("performCustomValidationForEntityMapping:manager:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSEntityMigrationPolicy");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityMigrationPolicy()
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
	protected NSEntityMigrationPolicy(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSEntityMigrationPolicy(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginEntityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BeginEntityMapping(NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selBeginEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selBeginEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createDestinationInstancesForSourceInstance:entityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateDestinationInstancesForSourceInstance(NSManagedObject sInstance, NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (sInstance == null)
		{
			throw new ArgumentNullException("sInstance");
		}
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCreateDestinationInstancesForSourceInstance_EntityMapping_Manager_Error_Handle, sInstance.Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCreateDestinationInstancesForSourceInstance_EntityMapping_Manager_Error_Handle, sInstance.Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createRelationshipsForDestinationInstance:entityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateRelationshipsForDestinationInstance(NSManagedObject dInstance, NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (dInstance == null)
		{
			throw new ArgumentNullException("dInstance");
		}
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCreateRelationshipsForDestinationInstance_EntityMapping_Manager_Error_Handle, dInstance.Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCreateRelationshipsForDestinationInstance_EntityMapping_Manager_Error_Handle, dInstance.Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("endEntityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EndEntityMapping(NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selEndEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selEndEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("endInstanceCreationForEntityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EndInstanceCreationForEntityMapping(NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selEndInstanceCreationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selEndInstanceCreationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("endRelationshipCreationForEntityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EndRelationshipCreationForEntityMapping(NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selEndRelationshipCreationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selEndRelationshipCreationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performCustomValidationForEntityMapping:manager:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformCustomValidationForEntityMapping(NSEntityMapping mapping, NSMigrationManager manager, out NSError error)
	{
		if (mapping == null)
		{
			throw new ArgumentNullException("mapping");
		}
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformCustomValidationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformCustomValidationForEntityMapping_Manager_Error_Handle, mapping.Handle, manager.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSEntityMigrationPolicy", true)]
public class NSEntityMigrationPolicy : NSObject
{
	private static readonly IntPtr selBeginEntityMappingManagerError_Handle = Selector.GetHandle("beginEntityMapping:manager:error:");

	private static readonly IntPtr selCreateDestinationInstancesForSourceInstanceEntityMappingManagerError_Handle = Selector.GetHandle("createDestinationInstancesForSourceInstance:entityMapping:manager:error:");

	private static readonly IntPtr selEndInstanceCreationForEntityMappingManagerError_Handle = Selector.GetHandle("endInstanceCreationForEntityMapping:manager:error:");

	private static readonly IntPtr selCreateRelationshipsForDestinationInstanceEntityMappingManagerError_Handle = Selector.GetHandle("createRelationshipsForDestinationInstance:entityMapping:manager:error:");

	private static readonly IntPtr selEndRelationshipCreationForEntityMappingManagerError_Handle = Selector.GetHandle("endRelationshipCreationForEntityMapping:manager:error:");

	private static readonly IntPtr selPerformCustomValidationForEntityMappingManagerError_Handle = Selector.GetHandle("performCustomValidationForEntityMapping:manager:error:");

	private static readonly IntPtr selEndEntityMappingManagerError_Handle = Selector.GetHandle("endEntityMapping:manager:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSEntityMigrationPolicy");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEntityMigrationPolicy()
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
	public NSEntityMigrationPolicy(NSCoder coder)
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
	public NSEntityMigrationPolicy(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEntityMigrationPolicy(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginEntityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("createDestinationInstancesForSourceInstance:entityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateDestinationInstancesForSourceInstanceEntityMappingManagerError_Handle, sInstance.Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selCreateDestinationInstancesForSourceInstanceEntityMappingManagerError_Handle, sInstance.Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("endInstanceCreationForEntityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEndInstanceCreationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEndInstanceCreationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("createRelationshipsForDestinationInstance:entityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateRelationshipsForDestinationInstanceEntityMappingManagerError_Handle, dInstance.Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selCreateRelationshipsForDestinationInstanceEntityMappingManagerError_Handle, dInstance.Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("endRelationshipCreationForEntityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEndRelationshipCreationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEndRelationshipCreationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("performCustomValidationForEntityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPerformCustomValidationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPerformCustomValidationForEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("endEntityMapping:manager:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEndEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEndEntityMappingManagerError_Handle, mapping.Handle, manager.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}

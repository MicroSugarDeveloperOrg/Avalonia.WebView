using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMergePolicy", true)]
public class NSMergePolicy : NSObject
{
	private static readonly IntPtr selMergeTypeHandle = Selector.GetHandle("mergeType");

	private static readonly IntPtr selInitWithMergeType_Handle = Selector.GetHandle("initWithMergeType:");

	private static readonly IntPtr selResolveConflictsError_Handle = Selector.GetHandle("resolveConflicts:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMergePolicy");

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSMergePolicyType MergeType
	{
		[Export("mergeType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSMergePolicyType)Messaging.UInt64_objc_msgSend(base.Handle, selMergeTypeHandle);
			}
			return (NSMergePolicyType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMergeTypeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMergePolicy()
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
	public NSMergePolicy(NSCoder coder)
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
	public NSMergePolicy(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMergePolicy(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMergeType:")]
	public NSMergePolicy(NSMergePolicyType ty)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithMergeType_Handle, (ulong)ty);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithMergeType_Handle, (ulong)ty);
		}
	}

	[Export("resolveConflicts:error:")]
	public virtual bool ResolveConflictserror(NSMergeConflict[] list, out NSError error)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(list);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selResolveConflictsError_Handle, nSArray.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selResolveConflictsError_Handle, nSArray.Handle, intPtr));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}

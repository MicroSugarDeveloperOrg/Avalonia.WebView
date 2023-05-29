using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCompoundPredicate", true)]
public class NSCompoundPredicate : NSPredicate
{
	private static readonly IntPtr selCompoundPredicateTypeHandle = Selector.GetHandle("compoundPredicateType");

	private static readonly IntPtr selSubpredicatesHandle = Selector.GetHandle("subpredicates");

	private static readonly IntPtr selInitWithTypeSubpredicates_Handle = Selector.GetHandle("initWithType:subpredicates:");

	private static readonly IntPtr selAndPredicateWithSubpredicates_Handle = Selector.GetHandle("andPredicateWithSubpredicates:");

	private static readonly IntPtr selOrPredicateWithSubpredicates_Handle = Selector.GetHandle("orPredicateWithSubpredicates:");

	private static readonly IntPtr selNotPredicateWithSubpredicate_Handle = Selector.GetHandle("notPredicateWithSubpredicate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCompoundPredicate");

	private object __mt_Subpredicates_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSCompoundPredicateType Type
	{
		[Export("compoundPredicateType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSCompoundPredicateType)Messaging.UInt64_objc_msgSend(base.Handle, selCompoundPredicateTypeHandle);
			}
			return (NSCompoundPredicateType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCompoundPredicateTypeHandle);
		}
	}

	public virtual NSPredicate[] Subpredicates
	{
		[Export("subpredicates")]
		get
		{
			return (NSPredicate[])(__mt_Subpredicates_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubpredicatesHandle)) : NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubpredicatesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCompoundPredicate(NSCoder coder)
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
	public NSCompoundPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCompoundPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:subpredicates:")]
	public NSCompoundPredicate(NSCompoundPredicateType type, NSPredicate[] subpredicates)
		: base(NSObjectFlag.Empty)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selInitWithTypeSubpredicates_Handle, (ulong)type, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selInitWithTypeSubpredicates_Handle, (ulong)type, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("andPredicateWithSubpredicates:")]
	public static NSPredicate CreateAndPredicate(NSPredicate[] subpredicates)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSPredicate result = (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAndPredicateWithSubpredicates_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("orPredicateWithSubpredicates:")]
	public static NSPredicate CreateOrPredicate(NSPredicate[] subpredicates)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSPredicate result = (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selOrPredicateWithSubpredicates_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("notPredicateWithSubpredicate:")]
	public static NSPredicate CreateNotPredicate(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNotPredicateWithSubpredicate_Handle, predicate.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Subpredicates_var = null;
		}
	}
}

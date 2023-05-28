using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCompoundPredicate", true)]
public class NSCompoundPredicate : NSPredicate, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAndPredicateWithSubpredicates_ = "andPredicateWithSubpredicates:";

	private static readonly IntPtr selAndPredicateWithSubpredicates_Handle = Selector.GetHandle("andPredicateWithSubpredicates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompoundPredicateType = "compoundPredicateType";

	private static readonly IntPtr selCompoundPredicateTypeHandle = Selector.GetHandle("compoundPredicateType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_Subpredicates_ = "initWithType:subpredicates:";

	private static readonly IntPtr selInitWithType_Subpredicates_Handle = Selector.GetHandle("initWithType:subpredicates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotPredicateWithSubpredicate_ = "notPredicateWithSubpredicate:";

	private static readonly IntPtr selNotPredicateWithSubpredicate_Handle = Selector.GetHandle("notPredicateWithSubpredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrPredicateWithSubpredicates_ = "orPredicateWithSubpredicates:";

	private static readonly IntPtr selOrPredicateWithSubpredicates_Handle = Selector.GetHandle("orPredicateWithSubpredicates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubpredicates = "subpredicates";

	private static readonly IntPtr selSubpredicatesHandle = Selector.GetHandle("subpredicates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCompoundPredicate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate[] Subpredicates
	{
		[Export("subpredicates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubpredicatesHandle));
			}
			return NSArray.ArrayFromHandle<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubpredicatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCompoundPredicateType Type
	{
		[Export("compoundPredicateType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSCompoundPredicateType)Messaging.UInt64_objc_msgSend(base.Handle, selCompoundPredicateTypeHandle);
			}
			return (NSCompoundPredicateType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCompoundPredicateTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCompoundPredicate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCompoundPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCompoundPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:subpredicates:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCompoundPredicate(NSCompoundPredicateType type, NSPredicate[] subpredicates)
		: base(NSObjectFlag.Empty)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selInitWithType_Subpredicates_Handle, (ulong)type, nSArray.Handle), "initWithType:subpredicates:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selInitWithType_Subpredicates_Handle, (ulong)type, nSArray.Handle), "initWithType:subpredicates:");
		}
		nSArray.Dispose();
	}

	[Export("andPredicateWithSubpredicates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCompoundPredicate CreateAndPredicate(NSPredicate[] subpredicates)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSCompoundPredicate nSObject = Runtime.GetNSObject<NSCompoundPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAndPredicateWithSubpredicates_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("notPredicateWithSubpredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCompoundPredicate CreateNotPredicate(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return Runtime.GetNSObject<NSCompoundPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNotPredicateWithSubpredicate_Handle, predicate.Handle));
	}

	[Export("orPredicateWithSubpredicates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCompoundPredicate CreateOrPredicate(NSPredicate[] subpredicates)
	{
		if (subpredicates == null)
		{
			throw new ArgumentNullException("subpredicates");
		}
		NSArray nSArray = NSArray.FromNSObjects(subpredicates);
		NSCompoundPredicate nSObject = Runtime.GetNSObject<NSCompoundPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selOrPredicateWithSubpredicates_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}

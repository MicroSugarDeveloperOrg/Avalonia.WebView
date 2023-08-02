using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPredicate", true)]
public class NSPredicate : NSObject
{
	private static readonly IntPtr selPredicateFormatHandle = Selector.GetHandle("predicateFormat");

	private static readonly IntPtr selPredicateWithFormatArgumentArray_Handle = Selector.GetHandle("predicateWithFormat:argumentArray:");

	private static readonly IntPtr selPredicateWithValue_Handle = Selector.GetHandle("predicateWithValue:");

	private static readonly IntPtr selPredicateWithBlock_Handle = Selector.GetHandle("predicateWithBlock:");

	private static readonly IntPtr selPredicateWithSubstitutionVariables_Handle = Selector.GetHandle("predicateWithSubstitutionVariables:");

	private static readonly IntPtr selEvaluateWithObject_Handle = Selector.GetHandle("evaluateWithObject:");

	private static readonly IntPtr selEvaluateWithObjectSubstitutionVariables_Handle = Selector.GetHandle("evaluateWithObject:substitutionVariables:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPredicate");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string PredicateFormat
	{
		[Export("predicateFormat")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateFormatHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPredicate(NSCoder coder)
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
	public NSPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("predicateWithFormat:argumentArray:")]
	public static NSPredicate FromFormat(string predicateFormat, NSObject[] arguments)
	{
		if (predicateFormat == null)
		{
			throw new ArgumentNullException("predicateFormat");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(predicateFormat);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		NSPredicate result = (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPredicateWithFormatArgumentArray_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("predicateWithValue:")]
	public static NSPredicate FromValue(bool value)
	{
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selPredicateWithValue_Handle, value));
	}

	[Export("predicateWithBlock:")]
	public unsafe static NSPredicate FromExpression(NSPredicateEvaluator evaluator)
	{
		if (evaluator == null)
		{
			throw new ArgumentNullException("evaluator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSPredicateEvaluator.Handler, evaluator);
		NSPredicate result = (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateWithBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("predicateWithSubstitutionVariables:")]
	public virtual NSPredicate PredicateWithSubstitutionVariables(NSDictionary substitutionVariables)
	{
		if (substitutionVariables == null)
		{
			throw new ArgumentNullException("substitutionVariables");
		}
		if (IsDirectBinding)
		{
			return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredicateWithSubstitutionVariables_Handle, substitutionVariables.Handle));
		}
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredicateWithSubstitutionVariables_Handle, substitutionVariables.Handle));
	}

	[Export("evaluateWithObject:")]
	public virtual bool EvaluateWithObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selEvaluateWithObject_Handle, obj.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluateWithObject_Handle, obj.Handle);
	}

	[Export("evaluateWithObject:substitutionVariables:")]
	public virtual bool EvaluateWithObject(NSObject obj, NSDictionary substitutionVariables)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (substitutionVariables == null)
		{
			throw new ArgumentNullException("substitutionVariables");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEvaluateWithObjectSubstitutionVariables_Handle, obj.Handle, substitutionVariables.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEvaluateWithObjectSubstitutionVariables_Handle, obj.Handle, substitutionVariables.Handle);
	}
}

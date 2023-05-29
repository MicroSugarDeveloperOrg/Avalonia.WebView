using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSComparisonPredicate", true)]
public class NSComparisonPredicate : NSPredicate
{
	private static readonly IntPtr selPredicateOperatorTypeHandle = Selector.GetHandle("predicateOperatorType");

	private static readonly IntPtr selComparisonPredicateModifierHandle = Selector.GetHandle("comparisonPredicateModifier");

	private static readonly IntPtr selLeftExpressionHandle = Selector.GetHandle("leftExpression");

	private static readonly IntPtr selRightExpressionHandle = Selector.GetHandle("rightExpression");

	private static readonly IntPtr selCustomSelectorHandle = Selector.GetHandle("customSelector");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selPredicateWithLeftExpressionRightExpressionModifierTypeOptions_Handle = Selector.GetHandle("predicateWithLeftExpression:rightExpression:modifier:type:options:");

	private static readonly IntPtr selPredicateWithLeftExpressionRightExpressionCustomSelector_Handle = Selector.GetHandle("predicateWithLeftExpression:rightExpression:customSelector:");

	private static readonly IntPtr selInitWithLeftExpressionRightExpressionModifierTypeOptions_Handle = Selector.GetHandle("initWithLeftExpression:rightExpression:modifier:type:options:");

	private static readonly IntPtr selInitWithLeftExpressionRightExpressionCustomSelector_Handle = Selector.GetHandle("initWithLeftExpression:rightExpression:customSelector:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSComparisonPredicate");

	private object __mt_LeftExpression_var;

	private object __mt_RightExpression_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPredicateOperatorType PredicateOperatorType
	{
		[Export("predicateOperatorType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSPredicateOperatorType)Messaging.UInt64_objc_msgSend(base.Handle, selPredicateOperatorTypeHandle);
			}
			return (NSPredicateOperatorType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPredicateOperatorTypeHandle);
		}
	}

	public virtual NSComparisonPredicateModifier ComparisonPredicateModifier
	{
		[Export("comparisonPredicateModifier")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSend(base.Handle, selComparisonPredicateModifierHandle);
			}
			return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selComparisonPredicateModifierHandle);
		}
	}

	public virtual NSExpression LeftExpression
	{
		[Export("leftExpression")]
		get
		{
			return (NSExpression)(__mt_LeftExpression_var = ((!IsDirectBinding) ? ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftExpressionHandle))) : ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftExpressionHandle)))));
		}
	}

	public virtual NSExpression RightExpression
	{
		[Export("rightExpression")]
		get
		{
			return (NSExpression)(__mt_RightExpression_var = ((!IsDirectBinding) ? ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightExpressionHandle))) : ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRightExpressionHandle)))));
		}
	}

	public virtual Selector CustomSelector
	{
		[Export("customSelector")]
		get
		{
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomSelectorHandle));
		}
	}

	public virtual NSComparisonPredicateOptions Options
	{
		[Export("options")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComparisonPredicate()
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
	public NSComparisonPredicate(NSCoder coder)
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
	public NSComparisonPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSComparisonPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("predicateWithLeftExpression:rightExpression:modifier:type:options:")]
	public static NSPredicate Create(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier comparisonModifier, NSPredicateOperatorType operatorType, NSComparisonPredicateOptions comparisonOptions)
	{
		if (leftExpression == null)
		{
			throw new ArgumentNullException("leftExpression");
		}
		if (rightExpression == null)
		{
			throw new ArgumentNullException("rightExpression");
		}
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64(class_ptr, selPredicateWithLeftExpressionRightExpressionModifierTypeOptions_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions));
	}

	[Export("predicateWithLeftExpression:rightExpression:customSelector:")]
	public static NSPredicate FromSelector(NSExpression leftExpression, NSExpression rightExpression, Selector selector)
	{
		if (leftExpression == null)
		{
			throw new ArgumentNullException("leftExpression");
		}
		if (rightExpression == null)
		{
			throw new ArgumentNullException("rightExpression");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return (NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPredicateWithLeftExpressionRightExpressionCustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle));
	}

	[Export("initWithLeftExpression:rightExpression:modifier:type:options:")]
	public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier comparisonModifier, NSPredicateOperatorType operatorType, NSComparisonPredicateOptions comparisonOptions)
		: base(NSObjectFlag.Empty)
	{
		if (leftExpression == null)
		{
			throw new ArgumentNullException("leftExpression");
		}
		if (rightExpression == null)
		{
			throw new ArgumentNullException("rightExpression");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64(base.Handle, selInitWithLeftExpressionRightExpressionModifierTypeOptions_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_UInt64(base.SuperHandle, selInitWithLeftExpressionRightExpressionModifierTypeOptions_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions);
		}
	}

	[Export("initWithLeftExpression:rightExpression:customSelector:")]
	public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, Selector selector)
		: base(NSObjectFlag.Empty)
	{
		if (leftExpression == null)
		{
			throw new ArgumentNullException("leftExpression");
		}
		if (rightExpression == null)
		{
			throw new ArgumentNullException("rightExpression");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithLeftExpressionRightExpressionCustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithLeftExpressionRightExpressionCustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LeftExpression_var = null;
			__mt_RightExpression_var = null;
		}
	}
}

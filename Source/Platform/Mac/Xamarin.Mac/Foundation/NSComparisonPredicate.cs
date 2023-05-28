using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSComparisonPredicate", true)]
public class NSComparisonPredicate : NSPredicate, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComparisonPredicateModifier = "comparisonPredicateModifier";

	private static readonly IntPtr selComparisonPredicateModifierHandle = Selector.GetHandle("comparisonPredicateModifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomSelector = "customSelector";

	private static readonly IntPtr selCustomSelectorHandle = Selector.GetHandle("customSelector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftExpression_RightExpression_CustomSelector_ = "initWithLeftExpression:rightExpression:customSelector:";

	private static readonly IntPtr selInitWithLeftExpression_RightExpression_CustomSelector_Handle = Selector.GetHandle("initWithLeftExpression:rightExpression:customSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftExpression_RightExpression_Modifier_Type_Options_ = "initWithLeftExpression:rightExpression:modifier:type:options:";

	private static readonly IntPtr selInitWithLeftExpression_RightExpression_Modifier_Type_Options_Handle = Selector.GetHandle("initWithLeftExpression:rightExpression:modifier:type:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftExpression = "leftExpression";

	private static readonly IntPtr selLeftExpressionHandle = Selector.GetHandle("leftExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateOperatorType = "predicateOperatorType";

	private static readonly IntPtr selPredicateOperatorTypeHandle = Selector.GetHandle("predicateOperatorType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithLeftExpression_RightExpression_CustomSelector_ = "predicateWithLeftExpression:rightExpression:customSelector:";

	private static readonly IntPtr selPredicateWithLeftExpression_RightExpression_CustomSelector_Handle = Selector.GetHandle("predicateWithLeftExpression:rightExpression:customSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_ = "predicateWithLeftExpression:rightExpression:modifier:type:options:";

	private static readonly IntPtr selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_Handle = Selector.GetHandle("predicateWithLeftExpression:rightExpression:modifier:type:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightExpression = "rightExpression";

	private static readonly IntPtr selRightExpressionHandle = Selector.GetHandle("rightExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSComparisonPredicate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonPredicateModifier ComparisonPredicateModifier
	{
		[Export("comparisonPredicateModifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSend(base.Handle, selComparisonPredicateModifierHandle);
			}
			return (NSComparisonPredicateModifier)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selComparisonPredicateModifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector CustomSelector
	{
		[Export("customSelector")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomSelectorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression LeftExpression
	{
		[Export("leftExpression")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonPredicateOptions Options
	{
		[Export("options")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSComparisonPredicateOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicateOperatorType PredicateOperatorType
	{
		[Export("predicateOperatorType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSPredicateOperatorType)Messaging.UInt64_objc_msgSend(base.Handle, selPredicateOperatorTypeHandle);
			}
			return (NSPredicateOperatorType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPredicateOperatorTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression RightExpression
	{
		[Export("rightExpression")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComparisonPredicate()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSComparisonPredicate(NSCoder coder)
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
	protected NSComparisonPredicate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSComparisonPredicate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLeftExpression:rightExpression:modifier:type:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64(base.Handle, selInitWithLeftExpression_RightExpression_Modifier_Type_Options_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions), "initWithLeftExpression:rightExpression:modifier:type:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_UInt64(base.SuperHandle, selInitWithLeftExpression_RightExpression_Modifier_Type_Options_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions), "initWithLeftExpression:rightExpression:modifier:type:options:");
		}
	}

	[Export("initWithLeftExpression:rightExpression:customSelector:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithLeftExpression_RightExpression_CustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle), "initWithLeftExpression:rightExpression:customSelector:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithLeftExpression_RightExpression_CustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle), "initWithLeftExpression:rightExpression:customSelector:");
		}
	}

	[Export("predicateWithLeftExpression:rightExpression:modifier:type:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSComparisonPredicate Create(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier comparisonModifier, NSPredicateOperatorType operatorType, NSComparisonPredicateOptions comparisonOptions)
	{
		if (leftExpression == null)
		{
			throw new ArgumentNullException("leftExpression");
		}
		if (rightExpression == null)
		{
			throw new ArgumentNullException("rightExpression");
		}
		return Runtime.GetNSObject<NSComparisonPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64(class_ptr, selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_Handle, leftExpression.Handle, rightExpression.Handle, (ulong)comparisonModifier, (ulong)operatorType, (ulong)comparisonOptions));
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

	[Export("predicateWithLeftExpression:rightExpression:customSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSComparisonPredicate FromSelector(NSExpression leftExpression, NSExpression rightExpression, Selector selector)
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
		return Runtime.GetNSObject<NSComparisonPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPredicateWithLeftExpression_RightExpression_CustomSelector_Handle, leftExpression.Handle, rightExpression.Handle, selector.Handle));
	}
}

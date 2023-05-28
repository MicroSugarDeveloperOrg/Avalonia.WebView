using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSExpression", true)]
public class NSExpression : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowEvaluation = "allowEvaluation";

	private static readonly IntPtr selAllowEvaluationHandle = Selector.GetHandle("allowEvaluation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArguments = "arguments";

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollection = "collection";

	private static readonly IntPtr selCollectionHandle = Selector.GetHandle("collection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstantValue = "constantValue";

	private static readonly IntPtr selConstantValueHandle = Selector.GetHandle("constantValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionBlock = "expressionBlock";

	private static readonly IntPtr selExpressionBlockHandle = Selector.GetHandle("expressionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForAggregate_ = "expressionForAggregate:";

	private static readonly IntPtr selExpressionForAggregate_Handle = Selector.GetHandle("expressionForAggregate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForAnyKey = "expressionForAnyKey";

	private static readonly IntPtr selExpressionForAnyKeyHandle = Selector.GetHandle("expressionForAnyKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForBlock_Arguments_ = "expressionForBlock:arguments:";

	private static readonly IntPtr selExpressionForBlock_Arguments_Handle = Selector.GetHandle("expressionForBlock:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForConditional_TrueExpression_FalseExpression_ = "expressionForConditional:trueExpression:falseExpression:";

	private static readonly IntPtr selExpressionForConditional_TrueExpression_FalseExpression_Handle = Selector.GetHandle("expressionForConditional:trueExpression:falseExpression:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForConstantValue_ = "expressionForConstantValue:";

	private static readonly IntPtr selExpressionForConstantValue_Handle = Selector.GetHandle("expressionForConstantValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForEvaluatedObject = "expressionForEvaluatedObject";

	private static readonly IntPtr selExpressionForEvaluatedObjectHandle = Selector.GetHandle("expressionForEvaluatedObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForFunction_Arguments_ = "expressionForFunction:arguments:";

	private static readonly IntPtr selExpressionForFunction_Arguments_Handle = Selector.GetHandle("expressionForFunction:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForFunction_SelectorName_Arguments_ = "expressionForFunction:selectorName:arguments:";

	private static readonly IntPtr selExpressionForFunction_SelectorName_Arguments_Handle = Selector.GetHandle("expressionForFunction:selectorName:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForIntersectSet_With_ = "expressionForIntersectSet:with:";

	private static readonly IntPtr selExpressionForIntersectSet_With_Handle = Selector.GetHandle("expressionForIntersectSet:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForKeyPath_ = "expressionForKeyPath:";

	private static readonly IntPtr selExpressionForKeyPath_Handle = Selector.GetHandle("expressionForKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForMinusSet_With_ = "expressionForMinusSet:with:";

	private static readonly IntPtr selExpressionForMinusSet_With_Handle = Selector.GetHandle("expressionForMinusSet:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForSubquery_UsingIteratorVariable_Predicate_ = "expressionForSubquery:usingIteratorVariable:predicate:";

	private static readonly IntPtr selExpressionForSubquery_UsingIteratorVariable_Predicate_Handle = Selector.GetHandle("expressionForSubquery:usingIteratorVariable:predicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForUnionSet_With_ = "expressionForUnionSet:with:";

	private static readonly IntPtr selExpressionForUnionSet_With_Handle = Selector.GetHandle("expressionForUnionSet:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForVariable_ = "expressionForVariable:";

	private static readonly IntPtr selExpressionForVariable_Handle = Selector.GetHandle("expressionForVariable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionType = "expressionType";

	private static readonly IntPtr selExpressionTypeHandle = Selector.GetHandle("expressionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionValueWithObject_Context_ = "expressionValueWithObject:context:";

	private static readonly IntPtr selExpressionValueWithObject_Context_Handle = Selector.GetHandle("expressionValueWithObject:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionWithFormat_ = "expressionWithFormat:";

	private static readonly IntPtr selExpressionWithFormat_Handle = Selector.GetHandle("expressionWithFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionWithFormat_ArgumentArray_ = "expressionWithFormat:argumentArray:";

	private static readonly IntPtr selExpressionWithFormat_ArgumentArray_Handle = Selector.GetHandle("expressionWithFormat:argumentArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFalseExpression = "falseExpression";

	private static readonly IntPtr selFalseExpressionHandle = Selector.GetHandle("falseExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFunction = "function";

	private static readonly IntPtr selFunctionHandle = Selector.GetHandle("function");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithExpressionType_ = "initWithExpressionType:";

	private static readonly IntPtr selInitWithExpressionType_Handle = Selector.GetHandle("initWithExpressionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyPath = "keyPath";

	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftExpression = "leftExpression";

	private static readonly IntPtr selLeftExpressionHandle = Selector.GetHandle("leftExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperand = "operand";

	private static readonly IntPtr selOperandHandle = Selector.GetHandle("operand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightExpression = "rightExpression";

	private static readonly IntPtr selRightExpressionHandle = Selector.GetHandle("rightExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrueExpression = "trueExpression";

	private static readonly IntPtr selTrueExpressionHandle = Selector.GetHandle("trueExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVariable = "variable";

	private static readonly IntPtr selVariableHandle = Selector.GetHandle("variable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSExpression");

	[Export("arguments")]
	public virtual NSExpression[] Arguments
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Function && expressionType != NSExpressionType.Block && expressionType != NSExpressionType.KeyPath)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the Arguments property. Expressions that support the property " + "are of type Function, Block and KeyPath");
			}
			return _Arguments;
		}
	}

	[Export("collection")]
	public virtual NSObject Collection
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.NSAggregate)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the Collection property. Expressions that support the property " + "are of type NSAggregate");
			}
			return _Collection;
		}
	}

	[Export("predicate")]
	public virtual NSPredicate Predicate
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Conditional && expressionType != NSExpressionType.Subquery)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the Predicate property. Expressions that support the property " + "are of type Conditional and Subquery");
			}
			return _Predicate;
		}
	}

	[Export("expressionBlock")]
	public virtual NSExpressionCallbackHandler Block
	{
		get
		{
			if (ExpressionType != NSExpressionType.Block)
			{
				throw new InvalidOperationException($"NSExpressions of type {ExpressionType} do not support the Block property. Expressions that support the property " + "are created via the FromFunction (NSExpressionHandler target, NSExpression[] parameters) method.");
			}
			return _Block;
		}
	}

	[Export("constantValue")]
	public virtual NSObject ConstantValue
	{
		get
		{
			if (ExpressionType != NSExpressionType.ConstantValue)
			{
				throw new InvalidOperationException($"NSExpressions of type {ExpressionType} do not support the ConstantValue property. Expressions that support the property " + "are created via the FromConstant methods.");
			}
			return _ConstantValue;
		}
	}

	[Export("keyPath")]
	public virtual string KeyPath
	{
		get
		{
			if (ExpressionType != NSExpressionType.KeyPath)
			{
				throw new InvalidOperationException($"NSExpressions of type {ExpressionType} do not support the KeyPath property. Expressions that support the property " + "are created via the FromKeyPath method.");
			}
			return _KeyPath;
		}
	}

	[Export("leftExpression")]
	public virtual NSExpression LeftExpression
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Conditional && expressionType != NSExpressionType.IntersectSet && expressionType != NSExpressionType.MinusSet && expressionType != NSExpressionType.Subquery && expressionType != NSExpressionType.UnionSet)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the LeftExpression property. Expressions that support the property " + "are of type Conditional, IntersectSet, MinusSet, Subquery or UnionSet");
			}
			return _LeftExpression;
		}
	}

	[Mac(10, 11)]
	[iOS(9, 0)]
	[Export("trueExpression")]
	public virtual NSExpression TrueExpression
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Conditional && expressionType != NSExpressionType.Subquery)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the TrueExpression property. Expressions that support the property " + "are of type Conditional and Subquery");
			}
			return _TrueExpression;
		}
	}

	[Mac(10, 11)]
	[iOS(9, 0)]
	[Export("falseExpression")]
	public virtual NSExpression FalseExpression
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Conditional && expressionType != NSExpressionType.Subquery)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the FalseExpression property. Expressions that support the property " + "are of type Conditional and Subquery");
			}
			return _FalseExpression;
		}
	}

	[Export("rightExpression")]
	public virtual NSExpression RightExpression
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.Conditional && expressionType != NSExpressionType.IntersectSet && expressionType != NSExpressionType.MinusSet && expressionType != NSExpressionType.Subquery && expressionType != NSExpressionType.UnionSet)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the RightExpression property. Expressions that support the property " + "are of type Conditional, IntersectSet, MinusSet, Subquery or UnionSet");
			}
			return _RightExpression;
		}
	}

	[Export("function")]
	public virtual string Function
	{
		get
		{
			if (ExpressionType != NSExpressionType.Function)
			{
				throw new InvalidOperationException($"NSExpressions of type {ExpressionType} do not support the Function property. Expressions that support the property " + "are created via the FromFunction (FromFunction (string name, NSExpression[] parameters) or FromFormat methods.");
			}
			return _Function;
		}
	}

	[Export("variable")]
	public virtual string Variable
	{
		get
		{
			if (ExpressionType != NSExpressionType.Variable)
			{
				throw new InvalidOperationException($"NSExpressions of type {ExpressionType} do not support the Function property. Expressions that support the property " + "are created via the FromVariable method.");
			}
			return _Variable;
		}
	}

	[Export("operand")]
	public virtual NSExpression Operand
	{
		get
		{
			NSExpressionType expressionType = ExpressionType;
			if (expressionType != NSExpressionType.KeyPath && expressionType != NSExpressionType.Function)
			{
				throw new InvalidOperationException($"NSExpressions of type {expressionType} do not support the Arguments property. Expressions that support the property " + "are of type Function, Block and KeyPath");
			}
			return _Operand;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression ExpressionForEvaluatedObject
	{
		[Export("expressionForEvaluatedObject")]
		get
		{
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(class_ptr, selExpressionForEvaluatedObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpressionType ExpressionType
	{
		[Export("expressionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSExpressionType)Messaging.UInt64_objc_msgSend(base.Handle, selExpressionTypeHandle);
			}
			return (NSExpressionType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selExpressionTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSExpression[] _Arguments
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentsHandle));
			}
			return NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSExpressionCallbackHandler _Block
	{
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExpressionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selExpressionBlockHandle));
			return Trampolines.NIDNSExpressionCallbackHandler.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSObject _Collection
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSObject _ConstantValue
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConstantValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstantValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	internal NSExpression _FalseExpression
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selFalseExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFalseExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal string _Function
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFunctionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFunctionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal string _KeyPath
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSExpression _LeftExpression
	{
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
	internal NSExpression _Operand
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selOperandHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSPredicate _Predicate
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSExpression _RightExpression
	{
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
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	internal NSExpression _TrueExpression
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrueExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrueExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal string _Variable
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVariableHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVariableHandle));
		}
	}

	[Obsolete("Use 'EvaluateWith' instead.")]
	public virtual NSExpression ExpressionValueWithObject(NSObject obj, NSMutableDictionary context)
	{
		NSObject nSObject = EvaluateWith(obj, context);
		return nSObject as NSExpression;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSExpression(NSCoder coder)
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
	protected NSExpression(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSExpression(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithExpressionType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSExpression(NSExpressionType type)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithExpressionType_Handle, (ulong)type), "initWithExpressionType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithExpressionType_Handle, (ulong)type), "initWithExpressionType:");
		}
	}

	[Export("allowEvaluation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AllowEvaluation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAllowEvaluationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAllowEvaluationHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
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

	[Export("expressionValueWithObject:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? EvaluateWith(NSObject? obj, NSMutableDictionary? context)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selExpressionValueWithObject_Context_Handle, obj?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExpressionValueWithObject_Context_Handle, obj?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero));
	}

	[Export("expressionForAggregate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromAggregate(NSExpression[] subexpressions)
	{
		if (subexpressions == null)
		{
			throw new ArgumentNullException("subexpressions");
		}
		NSArray nSArray = NSArray.FromNSObjects(subexpressions);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForAggregate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForAnyKey")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromAnyKey()
	{
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(class_ptr, selExpressionForAnyKeyHandle));
	}

	[Export("expressionForConditional:trueExpression:falseExpression:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromConditional(NSPredicate predicate, NSExpression trueExpression, NSExpression falseExpression)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (trueExpression == null)
		{
			throw new ArgumentNullException("trueExpression");
		}
		if (falseExpression == null)
		{
			throw new ArgumentNullException("falseExpression");
		}
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selExpressionForConditional_TrueExpression_FalseExpression_Handle, predicate.Handle, trueExpression.Handle, falseExpression.Handle));
	}

	[Export("expressionForConstantValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromConstant(NSObject? obj)
	{
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForConstantValue_Handle, obj?.Handle ?? IntPtr.Zero));
	}

	[Export("expressionWithFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromFormat(string expressionFormat)
	{
		if (expressionFormat == null)
		{
			throw new ArgumentNullException("expressionFormat");
		}
		IntPtr arg = NSString.CreateNative(expressionFormat);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionWithFormat_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("expressionWithFormat:argumentArray:")]
	[Obsolete("Use 'FromFormat (string, NSObject[])' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromFormat(string format, NSExpression[] parameters)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr arg = NSString.CreateNative(format);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionWithFormat_ArgumentArray_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionWithFormat:argumentArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromFormat(string format, NSObject[] parameters)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr arg = NSString.CreateNative(format);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionWithFormat_ArgumentArray_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForFunction:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromFunction(string name, NSExpression[] parameters)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForFunction_Arguments_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForFunction:selectorName:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromFunction(NSExpression target, string name, NSExpression[] parameters)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selExpressionForFunction_SelectorName_Arguments_Handle, target.Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForBlock:arguments:")]
	[Obsolete("Use 'FromFunction (NSExpressionCallbackHandler, NSExpression[])' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSExpression FromFunction([BlockProxy(typeof(Trampolines.NIDNSExpressionHandler))] NSExpressionHandler target, NSExpression[] parameters)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSExpressionHandler.Handler, target);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForBlock_Arguments_Handle, (IntPtr)ptr, nSArray.Handle));
		ptr->CleanupBlock();
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForBlock:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSExpression FromFunction([BlockProxy(typeof(Trampolines.NIDNSExpressionCallbackHandler))] NSExpressionCallbackHandler target, NSExpression[] parameters)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSExpressionCallbackHandler.Handler, target);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForBlock_Arguments_Handle, (IntPtr)ptr, nSArray.Handle));
		ptr->CleanupBlock();
		nSArray.Dispose();
		return nSObject;
	}

	[Export("expressionForIntersectSet:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromIntersectSet(NSExpression left, NSExpression right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForIntersectSet_With_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromKeyPath(string keyPath)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("expressionForMinusSet:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromMinusSet(NSExpression left, NSExpression right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForMinusSet_With_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForSubquery:usingIteratorVariable:predicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromSubquery(NSExpression expression, string variable, NSObject predicate)
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		if (variable == null)
		{
			throw new ArgumentNullException("variable");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		IntPtr arg = NSString.CreateNative(variable);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selExpressionForSubquery_UsingIteratorVariable_Predicate_Handle, expression.Handle, arg, predicate.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("expressionForUnionSet:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromUnionSet(NSExpression left, NSExpression right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForUnionSet_With_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForVariable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSExpression FromVariable(string string1)
	{
		if (string1 == null)
		{
			throw new ArgumentNullException("string1");
		}
		IntPtr arg = NSString.CreateNative(string1);
		NSExpression nSObject = Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForVariable_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSExpression", true)]
public class NSExpression : NSObject
{
	private static readonly IntPtr selExpressionForEvaluatedObjectHandle = Selector.GetHandle("expressionForEvaluatedObject");

	private static readonly IntPtr selExpressionTypeHandle = Selector.GetHandle("expressionType");

	private static readonly IntPtr selConstantValueHandle = Selector.GetHandle("constantValue");

	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	private static readonly IntPtr selFunctionHandle = Selector.GetHandle("function");

	private static readonly IntPtr selVariableHandle = Selector.GetHandle("variable");

	private static readonly IntPtr selOperandHandle = Selector.GetHandle("operand");

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	private static readonly IntPtr selCollectionHandle = Selector.GetHandle("collection");

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	private static readonly IntPtr selLeftExpressionHandle = Selector.GetHandle("leftExpression");

	private static readonly IntPtr selRightExpressionHandle = Selector.GetHandle("rightExpression");

	private static readonly IntPtr selExpressionForConstantValue_Handle = Selector.GetHandle("expressionForConstantValue:");

	private static readonly IntPtr selExpressionForVariable_Handle = Selector.GetHandle("expressionForVariable:");

	private static readonly IntPtr selExpressionForKeyPath_Handle = Selector.GetHandle("expressionForKeyPath:");

	private static readonly IntPtr selExpressionForFunctionArguments_Handle = Selector.GetHandle("expressionForFunction:arguments:");

	private static readonly IntPtr selExpressionWithFormatArgumentArray_Handle = Selector.GetHandle("expressionWithFormat:argumentArray:");

	private static readonly IntPtr selExpressionForAggregate_Handle = Selector.GetHandle("expressionForAggregate:");

	private static readonly IntPtr selExpressionForUnionSetWith_Handle = Selector.GetHandle("expressionForUnionSet:with:");

	private static readonly IntPtr selExpressionForIntersectSetWith_Handle = Selector.GetHandle("expressionForIntersectSet:with:");

	private static readonly IntPtr selExpressionForMinusSetWith_Handle = Selector.GetHandle("expressionForMinusSet:with:");

	private static readonly IntPtr selExpressionForSubqueryUsingIteratorVariablePredicate_Handle = Selector.GetHandle("expressionForSubquery:usingIteratorVariable:predicate:");

	private static readonly IntPtr selExpressionForFunctionSelectorNameArguments_Handle = Selector.GetHandle("expressionForFunction:selectorName:arguments:");

	private static readonly IntPtr selExpressionForBlockArguments_Handle = Selector.GetHandle("expressionForBlock:arguments:");

	private static readonly IntPtr selInitWithExpressionType_Handle = Selector.GetHandle("initWithExpressionType:");

	private static readonly IntPtr selExpressionValueWithObjectContext_Handle = Selector.GetHandle("expressionValueWithObject:context:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSExpression");

	private static object __mt_ExpressionForEvaluatedObject_var_static;

	private object __mt_ConstantValue_var;

	private object __mt_Operand_var;

	private object __mt_Arguments_var;

	private object __mt_Collection_var;

	private object __mt_Predicate_var;

	private object __mt_LeftExpression_var;

	private object __mt_RightExpression_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSExpression ExpressionForEvaluatedObject
	{
		[Export("expressionForEvaluatedObject")]
		get
		{
			return (NSExpression)(__mt_ExpressionForEvaluatedObject_var_static = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selExpressionForEvaluatedObjectHandle)));
		}
	}

	public virtual NSExpressionType ExpressionType
	{
		[Export("expressionType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSExpressionType)Messaging.UInt64_objc_msgSend(base.Handle, selExpressionTypeHandle);
			}
			return (NSExpressionType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selExpressionTypeHandle);
		}
	}

	public virtual NSObject ConstantValue
	{
		[Export("constantValue")]
		get
		{
			return (NSObject)(__mt_ConstantValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstantValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConstantValueHandle))));
		}
	}

	public virtual string KeyPath
	{
		[Export("keyPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
	}

	public virtual string Function
	{
		[Export("function")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFunctionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFunctionHandle));
		}
	}

	public virtual string Variable
	{
		[Export("variable")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVariableHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVariableHandle));
		}
	}

	public virtual NSExpression Operand
	{
		[Export("operand")]
		get
		{
			return (NSExpression)(__mt_Operand_var = ((!IsDirectBinding) ? ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperandHandle))) : ((NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOperandHandle)))));
		}
	}

	public virtual NSExpression[] Arguments
	{
		[Export("arguments")]
		get
		{
			return (NSExpression[])(__mt_Arguments_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentsHandle)) : NSArray.ArrayFromHandle<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentsHandle))));
		}
	}

	public virtual NSObject Collection
	{
		[Export("collection")]
		get
		{
			return (NSObject)(__mt_Collection_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionHandle))));
		}
	}

	public virtual NSPredicate Predicate
	{
		[Export("predicate")]
		get
		{
			return (NSPredicate)(__mt_Predicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle)))));
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSExpression(NSCoder coder)
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
	public NSExpression(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSExpression(IntPtr handle)
		: base(handle)
	{
	}

	[Export("expressionForConstantValue:")]
	public static NSExpression FromConstant(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForConstantValue_Handle, obj.Handle));
	}

	[Export("expressionForVariable:")]
	public static NSExpression FromVariable(string string1)
	{
		if (string1 == null)
		{
			throw new ArgumentNullException("string1");
		}
		IntPtr arg = NSString.CreateNative(string1);
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForVariable_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("expressionForKeyPath:")]
	public static NSExpression FromKeyPath(string keyPath)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("expressionForFunction:arguments:")]
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
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForFunctionArguments_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("expressionWithFormat:argumentArray:")]
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
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionWithFormatArgumentArray_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("expressionForAggregate:")]
	public static NSExpression FromAggregate(NSExpression[] subexpressions)
	{
		if (subexpressions == null)
		{
			throw new ArgumentNullException("subexpressions");
		}
		NSArray nSArray = NSArray.FromNSObjects(subexpressions);
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExpressionForAggregate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("expressionForUnionSet:with:")]
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
		return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForUnionSetWith_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForIntersectSet:with:")]
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
		return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForIntersectSetWith_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForMinusSet:with:")]
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
		return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForMinusSetWith_Handle, left.Handle, right.Handle));
	}

	[Export("expressionForSubquery:usingIteratorVariable:predicate:")]
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
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selExpressionForSubqueryUsingIteratorVariablePredicate_Handle, expression.Handle, arg, predicate.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("expressionForFunction:selectorName:arguments:")]
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
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selExpressionForFunctionSelectorNameArguments_Handle, target.Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("expressionForBlock:arguments:")]
	public unsafe static NSExpression FromFunction(NSExpressionHandler target, NSExpression[] parameters)
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
		blockLiteral.SetupBlock(Trampolines.SDNSExpressionHandler.Handler, target);
		NSArray nSArray = NSArray.FromNSObjects(parameters);
		NSExpression result = (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExpressionForBlockArguments_Handle, (IntPtr)ptr, nSArray.Handle));
		ptr->CleanupBlock();
		nSArray.Dispose();
		return result;
	}

	[Export("initWithExpressionType:")]
	public NSExpression(NSExpressionType type)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithExpressionType_Handle, (ulong)type);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithExpressionType_Handle, (ulong)type);
		}
	}

	[Export("expressionValueWithObject:context:")]
	public virtual NSExpression ExpressionValueWithObject(NSObject object1, NSMutableDictionary context)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (IsDirectBinding)
		{
			return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selExpressionValueWithObjectContext_Handle, object1.Handle, context.Handle));
		}
		return (NSExpression)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExpressionValueWithObjectContext_Handle, object1.Handle, context.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ConstantValue_var = null;
			__mt_Operand_var = null;
			__mt_Arguments_var = null;
			__mt_Collection_var = null;
			__mt_Predicate_var = null;
			__mt_LeftExpression_var = null;
			__mt_RightExpression_var = null;
		}
	}
}

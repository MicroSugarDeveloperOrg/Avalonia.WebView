using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace JavaScriptCore;

[Register("JSValue", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class JSValue : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSValueRef = "JSValueRef";

	private static readonly IntPtr selJSValueRefHandle = Selector.GetHandle("JSValueRef");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallWithArguments_ = "callWithArguments:";

	private static readonly IntPtr selCallWithArguments_Handle = Selector.GetHandle("callWithArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstructWithArguments_ = "constructWithArguments:";

	private static readonly IntPtr selConstructWithArguments_Handle = Selector.GetHandle("constructWithArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContext = "context";

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefineProperty_Descriptor_ = "defineProperty:descriptor:";

	private static readonly IntPtr selDefineProperty_Descriptor_Handle = Selector.GetHandle("defineProperty:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteProperty_ = "deleteProperty:";

	private static readonly IntPtr selDeleteProperty_Handle = Selector.GetHandle("deleteProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasProperty_ = "hasProperty:";

	private static readonly IntPtr selHasProperty_Handle = Selector.GetHandle("hasProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvokeMethod_WithArguments_ = "invokeMethod:withArguments:";

	private static readonly IntPtr selInvokeMethod_WithArguments_Handle = Selector.GetHandle("invokeMethod:withArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsArray = "isArray";

	private static readonly IntPtr selIsArrayHandle = Selector.GetHandle("isArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBoolean = "isBoolean";

	private static readonly IntPtr selIsBooleanHandle = Selector.GetHandle("isBoolean");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDate = "isDate";

	private static readonly IntPtr selIsDateHandle = Selector.GetHandle("isDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToObject_ = "isEqualToObject:";

	private static readonly IntPtr selIsEqualToObject_Handle = Selector.GetHandle("isEqualToObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualWithTypeCoercionToObject_ = "isEqualWithTypeCoercionToObject:";

	private static readonly IntPtr selIsEqualWithTypeCoercionToObject_Handle = Selector.GetHandle("isEqualWithTypeCoercionToObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInstanceOf_ = "isInstanceOf:";

	private static readonly IntPtr selIsInstanceOf_Handle = Selector.GetHandle("isInstanceOf:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNull = "isNull";

	private static readonly IntPtr selIsNullHandle = Selector.GetHandle("isNull");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNumber = "isNumber";

	private static readonly IntPtr selIsNumberHandle = Selector.GetHandle("isNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsObject = "isObject";

	private static readonly IntPtr selIsObjectHandle = Selector.GetHandle("isObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsString = "isString";

	private static readonly IntPtr selIsStringHandle = Selector.GetHandle("isString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSymbol = "isSymbol";

	private static readonly IntPtr selIsSymbolHandle = Selector.GetHandle("isSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUndefined = "isUndefined";

	private static readonly IntPtr selIsUndefinedHandle = Selector.GetHandle("isUndefined");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_AtIndexedSubscript_ = "setObject:atIndexedSubscript:";

	private static readonly IntPtr selSetObject_AtIndexedSubscript_Handle = Selector.GetHandle("setObject:atIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

	private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_AtIndex_ = "setValue:atIndex:";

	private static readonly IntPtr selSetValue_AtIndex_Handle = Selector.GetHandle("setValue:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForProperty_ = "setValue:forProperty:";

	private static readonly IntPtr selSetValue_ForProperty_Handle = Selector.GetHandle("setValue:forProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToArray = "toArray";

	private static readonly IntPtr selToArrayHandle = Selector.GetHandle("toArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToBool = "toBool";

	private static readonly IntPtr selToBoolHandle = Selector.GetHandle("toBool");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToDate = "toDate";

	private static readonly IntPtr selToDateHandle = Selector.GetHandle("toDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToDictionary = "toDictionary";

	private static readonly IntPtr selToDictionaryHandle = Selector.GetHandle("toDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToDouble = "toDouble";

	private static readonly IntPtr selToDoubleHandle = Selector.GetHandle("toDouble");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToInt32 = "toInt32";

	private static readonly IntPtr selToInt32Handle = Selector.GetHandle("toInt32");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToNumber = "toNumber";

	private static readonly IntPtr selToNumberHandle = Selector.GetHandle("toNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToObject = "toObject";

	private static readonly IntPtr selToObjectHandle = Selector.GetHandle("toObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToObjectOfClass_ = "toObjectOfClass:";

	private static readonly IntPtr selToObjectOfClass_Handle = Selector.GetHandle("toObjectOfClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToPoint = "toPoint";

	private static readonly IntPtr selToPointHandle = Selector.GetHandle("toPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToRange = "toRange";

	private static readonly IntPtr selToRangeHandle = Selector.GetHandle("toRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToRect = "toRect";

	private static readonly IntPtr selToRectHandle = Selector.GetHandle("toRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToSize = "toSize";

	private static readonly IntPtr selToSizeHandle = Selector.GetHandle("toSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToString = "toString";

	private static readonly IntPtr selToStringHandle = Selector.GetHandle("toString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToUInt32 = "toUInt32";

	private static readonly IntPtr selToUInt32Handle = Selector.GetHandle("toUInt32");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueAtIndex_ = "valueAtIndex:";

	private static readonly IntPtr selValueAtIndex_Handle = Selector.GetHandle("valueAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForProperty_ = "valueForProperty:";

	private static readonly IntPtr selValueForProperty_Handle = Selector.GetHandle("valueForProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithBool_InContext_ = "valueWithBool:inContext:";

	private static readonly IntPtr selValueWithBool_InContext_Handle = Selector.GetHandle("valueWithBool:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithDouble_InContext_ = "valueWithDouble:inContext:";

	private static readonly IntPtr selValueWithDouble_InContext_Handle = Selector.GetHandle("valueWithDouble:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithInt32_InContext_ = "valueWithInt32:inContext:";

	private static readonly IntPtr selValueWithInt32_InContext_Handle = Selector.GetHandle("valueWithInt32:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithJSValueRef_InContext_ = "valueWithJSValueRef:inContext:";

	private static readonly IntPtr selValueWithJSValueRef_InContext_Handle = Selector.GetHandle("valueWithJSValueRef:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewArrayInContext_ = "valueWithNewArrayInContext:";

	private static readonly IntPtr selValueWithNewArrayInContext_Handle = Selector.GetHandle("valueWithNewArrayInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewErrorFromMessage_InContext_ = "valueWithNewErrorFromMessage:inContext:";

	private static readonly IntPtr selValueWithNewErrorFromMessage_InContext_Handle = Selector.GetHandle("valueWithNewErrorFromMessage:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewObjectInContext_ = "valueWithNewObjectInContext:";

	private static readonly IntPtr selValueWithNewObjectInContext_Handle = Selector.GetHandle("valueWithNewObjectInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewPromiseInContext_FromExecutor_ = "valueWithNewPromiseInContext:fromExecutor:";

	private static readonly IntPtr selValueWithNewPromiseInContext_FromExecutor_Handle = Selector.GetHandle("valueWithNewPromiseInContext:fromExecutor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewPromiseRejectedWithReason_InContext_ = "valueWithNewPromiseRejectedWithReason:inContext:";

	private static readonly IntPtr selValueWithNewPromiseRejectedWithReason_InContext_Handle = Selector.GetHandle("valueWithNewPromiseRejectedWithReason:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewPromiseResolvedWithResult_InContext_ = "valueWithNewPromiseResolvedWithResult:inContext:";

	private static readonly IntPtr selValueWithNewPromiseResolvedWithResult_InContext_Handle = Selector.GetHandle("valueWithNewPromiseResolvedWithResult:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewRegularExpressionFromPattern_Flags_InContext_ = "valueWithNewRegularExpressionFromPattern:flags:inContext:";

	private static readonly IntPtr selValueWithNewRegularExpressionFromPattern_Flags_InContext_Handle = Selector.GetHandle("valueWithNewRegularExpressionFromPattern:flags:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNewSymbolFromDescription_InContext_ = "valueWithNewSymbolFromDescription:inContext:";

	private static readonly IntPtr selValueWithNewSymbolFromDescription_InContext_Handle = Selector.GetHandle("valueWithNewSymbolFromDescription:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNullInContext_ = "valueWithNullInContext:";

	private static readonly IntPtr selValueWithNullInContext_Handle = Selector.GetHandle("valueWithNullInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithObject_InContext_ = "valueWithObject:inContext:";

	private static readonly IntPtr selValueWithObject_InContext_Handle = Selector.GetHandle("valueWithObject:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithPoint_InContext_ = "valueWithPoint:inContext:";

	private static readonly IntPtr selValueWithPoint_InContext_Handle = Selector.GetHandle("valueWithPoint:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithRange_InContext_ = "valueWithRange:inContext:";

	private static readonly IntPtr selValueWithRange_InContext_Handle = Selector.GetHandle("valueWithRange:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithRect_InContext_ = "valueWithRect:inContext:";

	private static readonly IntPtr selValueWithRect_InContext_Handle = Selector.GetHandle("valueWithRect:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithSize_InContext_ = "valueWithSize:inContext:";

	private static readonly IntPtr selValueWithSize_InContext_Handle = Selector.GetHandle("valueWithSize:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithUInt32_InContext_ = "valueWithUInt32:inContext:";

	private static readonly IntPtr selValueWithUInt32_InContext_Handle = Selector.GetHandle("valueWithUInt32:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithUndefinedInContext_ = "valueWithUndefinedInContext:";

	private static readonly IntPtr selValueWithUndefinedInContext_Handle = Selector.GetHandle("valueWithUndefinedInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("JSValue");

	public JSValue this[nuint index]
	{
		get
		{
			return _ObjectAtIndexedSubscript(index);
		}
		set
		{
			_SetObject(value, index);
		}
	}

	public JSValue this[NSObject key]
	{
		get
		{
			return _ObjectForKeyedSubscript(key);
		}
		set
		{
			_SetObject(value, key);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSContext Context
	{
		[Export("context", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle));
			}
			return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool IsArray
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isArray")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsArrayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsArrayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsBoolean
	{
		[Export("isBoolean")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBooleanHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBooleanHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool IsDate
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsNull
	{
		[Export("isNull")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsNullHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsNullHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsNumber
	{
		[Export("isNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsNumberHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsObject
	{
		[Export("isObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsObjectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsObjectHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsString
	{
		[Export("isString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStringHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStringHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool IsSymbol
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isSymbol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSymbolHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSymbolHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUndefined
	{
		[Export("isUndefined")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndefinedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndefinedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr JSValueRefPtr
	{
		[Export("JSValueRef")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selJSValueRefHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJSValueRefHandle);
		}
	}

	public override string ToString()
	{
		return _ToString();
	}

	public static JSValue From(string value, JSContext context)
	{
		using NSString value2 = new NSString(value);
		return From((NSObject)value2, context);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected JSValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal JSValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("callWithArguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue Call(params JSValue[] arguments)
	{
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCallWithArguments_Handle, nSArray.Handle)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCallWithArguments_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("constructWithArguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue Construct(params JSValue[] arguments)
	{
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConstructWithArguments_Handle, nSArray.Handle)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConstructWithArguments_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("valueWithNewArrayInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateArray(JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithNewArrayInContext_Handle, context.Handle));
	}

	[Export("valueWithNewErrorFromMessage:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateError(string message, JSContext context)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = NSString.CreateNative(message);
		JSValue nSObject = Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithNewErrorFromMessage_InContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("valueWithNewObjectInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateObject(JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithNewObjectInContext_Handle, context.Handle));
	}

	[Export("valueWithNewPromiseInContext:fromExecutor:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static JSValue CreatePromise(JSContext context, [BlockProxy(typeof(Trampolines.NIDJSPromiseCreationExecutor))] JSPromiseCreationExecutor callback)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDJSPromiseCreationExecutor.Handler, callback);
		JSValue nSObject = Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithNewPromiseInContext_FromExecutor_Handle, context.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("valueWithNewRegularExpressionFromPattern:flags:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateRegularExpression(string pattern, string flags, JSContext context)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		if (flags == null)
		{
			throw new ArgumentNullException("flags");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = NSString.CreateNative(pattern);
		IntPtr arg2 = NSString.CreateNative(flags);
		JSValue nSObject = Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selValueWithNewRegularExpressionFromPattern_Flags_InContext_Handle, arg, arg2, context.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("valueWithNewPromiseRejectedWithReason:inContext:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateRejectedPromise(NSObject reason, JSContext context)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithNewPromiseRejectedWithReason_InContext_Handle, reason.Handle, context.Handle));
	}

	[Export("valueWithNewPromiseResolvedWithResult:inContext:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateResolvedPromise(NSObject result, JSContext context)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithNewPromiseResolvedWithResult_InContext_Handle, result.Handle, context.Handle));
	}

	[Export("valueWithNewSymbolFromDescription:inContext:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CreateSymbol(string description, JSContext context)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		IntPtr arg = NSString.CreateNative(description);
		JSValue nSObject = Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithNewSymbolFromDescription_InContext_Handle, arg, context.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("defineProperty:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DefineProperty(string property, NSObject descriptor)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = NSString.CreateNative(property);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDefineProperty_Descriptor_Handle, arg, descriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDefineProperty_Descriptor_Handle, arg, descriptor.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("deleteProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeleteProperty(string property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = NSString.CreateNative(property);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteProperty_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selDeleteProperty_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("valueWithObject:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(NSObject value, JSContext context)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithObject_InContext_Handle, value.Handle, context.Handle));
	}

	[Export("valueWithBool:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(bool value, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(class_ptr, selValueWithBool_InContext_Handle, value, context.Handle));
	}

	[Export("valueWithDouble:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(double value, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_Double_IntPtr(class_ptr, selValueWithDouble_InContext_Handle, value, context.Handle));
	}

	[Export("valueWithInt32:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(int ivalue, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_int_IntPtr(class_ptr, selValueWithInt32_InContext_Handle, ivalue, context.Handle));
	}

	[Export("valueWithUInt32:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(uint value, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr(class_ptr, selValueWithUInt32_InContext_Handle, value, context.Handle));
	}

	[Export("valueWithPoint:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(CGPoint point, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr(class_ptr, selValueWithPoint_InContext_Handle, point, context.Handle));
	}

	[Export("valueWithRange:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(NSRange range, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selValueWithRange_InContext_Handle, range, context.Handle));
	}

	[Export("valueWithRect:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(CGRect rect, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(class_ptr, selValueWithRect_InContext_Handle, rect, context.Handle));
	}

	[Export("valueWithSize:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue From(CGSize size, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(class_ptr, selValueWithSize_InContext_Handle, size, context.Handle));
	}

	[Export("valueWithJSValueRef:inContext:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue FromJSJSValueRef(IntPtr nativeJsValueRefvalue, JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithJSValueRef_InContext_Handle, nativeJsValueRefvalue, context.Handle));
	}

	[Export("valueForProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue GetProperty(string property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = NSString.CreateNative(property);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForProperty_Handle, arg)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForProperty_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("valueAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue GetValueAt(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selValueAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selValueAtIndex_Handle, index));
	}

	[Export("hasProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasProperty(string property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = NSString.CreateNative(property);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasProperty_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasProperty_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("invokeMethod:withArguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue Invoke(string method, params JSValue[] arguments)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(method);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInvokeMethod_WithArguments_Handle, arg, nSArray.Handle)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInvokeMethod_WithArguments_Handle, arg, nSArray.Handle)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("isEqualToObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualTo(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToObject_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToObject_Handle, value.Handle);
	}

	[Export("isEqualWithTypeCoercionToObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualWithTypeCoercionTo(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualWithTypeCoercionToObject_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualWithTypeCoercionToObject_Handle, value.Handle);
	}

	[Export("isInstanceOf:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInstanceOf(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsInstanceOf_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsInstanceOf_Handle, value.Handle);
	}

	[Export("valueWithNullInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue Null(JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithNullInContext_Handle, context.Handle));
	}

	[Export("setValue:forProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetProperty(NSObject value, string property)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = NSString.CreateNative(property);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForProperty_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForProperty_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setValue:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(JSValue value, nuint index)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetValue_AtIndex_Handle, value.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetValue_AtIndex_Handle, value.Handle, index);
		}
	}

	[Export("toArray")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue[] ToArray()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<JSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selToArrayHandle));
		}
		return NSArray.ArrayFromHandle<JSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToArrayHandle));
	}

	[Export("toBool")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ToBool()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selToBoolHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selToBoolHandle);
	}

	[Export("toDate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate ToDate()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selToDateHandle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToDateHandle));
	}

	[Export("toDictionary")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ToDictionary()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selToDictionaryHandle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToDictionaryHandle));
	}

	[Export("toDouble")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ToDouble()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selToDoubleHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selToDoubleHandle);
	}

	[Export("toInt32")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ToInt32()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend(base.Handle, selToInt32Handle);
		}
		return Messaging.int_objc_msgSendSuper(base.SuperHandle, selToInt32Handle);
	}

	[Export("toNumber")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber ToNumber()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selToNumberHandle));
		}
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToNumberHandle));
	}

	[Export("toObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ToObject()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selToObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToObjectHandle));
	}

	[Export("toObjectOfClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ToObject(Class ofExpectedClass)
	{
		if (ofExpectedClass == null)
		{
			throw new ArgumentNullException("ofExpectedClass");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToObjectOfClass_Handle, ofExpectedClass.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToObjectOfClass_Handle, ofExpectedClass.Handle));
	}

	[Export("toPoint")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ToPoint()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, selToPointHandle);
		}
		return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selToPointHandle);
	}

	[Export("toRange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange ToRange()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend(base.Handle, selToRangeHandle);
		}
		return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selToRangeHandle);
	}

	[Export("toRect")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ToRect()
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selToRectHandle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selToRectHandle);
		}
		return retval;
	}

	[Export("toSize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ToSize()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend(base.Handle, selToSizeHandle);
		}
		return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selToSizeHandle);
	}

	[Export("toUInt32")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ToUInt32()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(base.Handle, selToUInt32Handle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selToUInt32Handle);
	}

	[Export("valueWithUndefinedInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue Undefined(JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithUndefinedInContext_Handle, context.Handle));
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual JSValue _ObjectAtIndexedSubscript(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, index));
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, index));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual JSValue _ObjectForKeyedSubscript(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, key.Handle));
		}
		return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, key.Handle));
	}

	[Export("setObject:forKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetObject(JSValue obj, NSObject key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, key.Handle);
		}
	}

	[Export("setObject:atIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetObject(JSValue obj, nuint index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetObject_AtIndexedSubscript_Handle, obj.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetObject_AtIndexedSubscript_Handle, obj.Handle, index);
		}
	}

	[Export("toString")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual string _ToString()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToStringHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToStringHandle));
	}
}

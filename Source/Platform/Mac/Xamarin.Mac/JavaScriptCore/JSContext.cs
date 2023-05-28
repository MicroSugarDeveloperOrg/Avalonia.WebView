using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Register("JSContext", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class JSContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSGlobalContextRef = "JSGlobalContextRef";

	private static readonly IntPtr selJSGlobalContextRefHandle = Selector.GetHandle("JSGlobalContextRef");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithJSGlobalContextRef_ = "contextWithJSGlobalContextRef:";

	private static readonly IntPtr selContextWithJSGlobalContextRef_Handle = Selector.GetHandle("contextWithJSGlobalContextRef:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentArguments = "currentArguments";

	private static readonly IntPtr selCurrentArgumentsHandle = Selector.GetHandle("currentArguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentCallee = "currentCallee";

	private static readonly IntPtr selCurrentCalleeHandle = Selector.GetHandle("currentCallee");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentContext = "currentContext";

	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentThis = "currentThis";

	private static readonly IntPtr selCurrentThisHandle = Selector.GetHandle("currentThis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateScript_ = "evaluateScript:";

	private static readonly IntPtr selEvaluateScript_Handle = Selector.GetHandle("evaluateScript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateScript_WithSourceURL_ = "evaluateScript:withSourceURL:";

	private static readonly IntPtr selEvaluateScript_WithSourceURL_Handle = Selector.GetHandle("evaluateScript:withSourceURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selException = "exception";

	private static readonly IntPtr selExceptionHandle = Selector.GetHandle("exception");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExceptionHandler = "exceptionHandler";

	private static readonly IntPtr selExceptionHandlerHandle = Selector.GetHandle("exceptionHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalObject = "globalObject";

	private static readonly IntPtr selGlobalObjectHandle = Selector.GetHandle("globalObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVirtualMachine_ = "initWithVirtualMachine:";

	private static readonly IntPtr selInitWithVirtualMachine_Handle = Selector.GetHandle("initWithVirtualMachine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetException_ = "setException:";

	private static readonly IntPtr selSetException_Handle = Selector.GetHandle("setException:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExceptionHandler_ = "setExceptionHandler:";

	private static readonly IntPtr selSetExceptionHandler_Handle = Selector.GetHandle("setExceptionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

	private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVirtualMachine = "virtualMachine";

	private static readonly IntPtr selVirtualMachineHandle = Selector.GetHandle("virtualMachine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("JSContext");

	public JSValue this[NSObject key]
	{
		get
		{
			return _GetObject(key);
		}
		set
		{
			_SetObject(value, key);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue[] CurrentArguments
	{
		[Export("currentArguments")]
		get
		{
			return NSArray.ArrayFromHandle<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentArgumentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static JSValue CurrentCallee
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("currentCallee")]
		get
		{
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCalleeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSValue CurrentThis
	{
		[Export("currentThis")]
		get
		{
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentThisHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue? Exception
	{
		[Export("exception", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selExceptionHandle));
			}
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExceptionHandle));
		}
		[Export("setException:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetException_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetException_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual JSContextExceptionHandler ExceptionHandler
	{
		[Export("exceptionHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDJSContextExceptionHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExceptionHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selExceptionHandlerHandle));
			return Trampolines.NIDJSContextExceptionHandler.Create(block);
		}
		[Export("setExceptionHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDJSContextExceptionHandler))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDJSContextExceptionHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExceptionHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExceptionHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue GlobalObject
	{
		[Export("globalObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selGlobalObjectHandle));
			}
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlobalObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual IntPtr JSGlobalContextRefPtr
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("JSGlobalContextRef")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selJSGlobalContextRefHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJSGlobalContextRefHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual string? Name
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSVirtualMachine VirtualMachine
	{
		[Export("virtualMachine", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSVirtualMachine>(Messaging.IntPtr_objc_msgSend(base.Handle, selVirtualMachineHandle));
			}
			return Runtime.GetNSObject<JSVirtualMachine>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVirtualMachineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected JSContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal JSContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public JSContext()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithVirtualMachine:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public JSContext(JSVirtualMachine virtualMachine)
		: base(NSObjectFlag.Empty)
	{
		if (virtualMachine == null)
		{
			throw new ArgumentNullException("virtualMachine");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVirtualMachine_Handle, virtualMachine.Handle), "initWithVirtualMachine:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVirtualMachine_Handle, virtualMachine.Handle), "initWithVirtualMachine:");
		}
	}

	[Export("evaluateScript:withSourceURL:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue EvaluateScript(string script, NSUrl sourceUrl)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		if (sourceUrl == null)
		{
			throw new ArgumentNullException("sourceUrl");
		}
		IntPtr arg = NSString.CreateNative(script);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEvaluateScript_WithSourceURL_Handle, arg, sourceUrl.Handle)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selEvaluateScript_WithSourceURL_Handle, arg, sourceUrl.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("evaluateScript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue EvaluateScript(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		JSValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluateScript_Handle, arg)) : Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEvaluateScript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contextWithJSGlobalContextRef:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSContext FromJSGlobalContextRef(IntPtr nativeJsGlobalContextRef)
	{
		return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContextWithJSGlobalContextRef_Handle, nativeJsGlobalContextRef));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual JSValue _GetObject(NSObject key)
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
}

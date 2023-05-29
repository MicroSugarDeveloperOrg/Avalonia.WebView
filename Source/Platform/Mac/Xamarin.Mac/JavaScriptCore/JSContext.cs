using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace JavaScriptCore;

[Register("JSContext", true)]
public class JSContext : NSObject
{
    private const string selJSGlobalContextRef = "JSGlobalContextRef";

    private static readonly IntPtr selJSGlobalContextRefHandle = Selector.GetHandle("JSGlobalContextRef");

    private const string selContextWithJSGlobalContextRef_ = "contextWithJSGlobalContextRef:";

    private static readonly IntPtr selContextWithJSGlobalContextRef_Handle = Selector.GetHandle("contextWithJSGlobalContextRef:");

    private const string selCurrentArguments = "currentArguments";

    private static readonly IntPtr selCurrentArgumentsHandle = Selector.GetHandle("currentArguments");

    private const string selCurrentCallee = "currentCallee";

    private static readonly IntPtr selCurrentCalleeHandle = Selector.GetHandle("currentCallee");

    private const string selCurrentContext = "currentContext";

    private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

    private const string selCurrentThis = "currentThis";

    private static readonly IntPtr selCurrentThisHandle = Selector.GetHandle("currentThis");

    private const string selEvaluateScript_ = "evaluateScript:";

    private static readonly IntPtr selEvaluateScript_Handle = Selector.GetHandle("evaluateScript:");

    private const string selEvaluateScript_WithSourceURL_ = "evaluateScript:withSourceURL:";

    private static readonly IntPtr selEvaluateScript_WithSourceURL_Handle = Selector.GetHandle("evaluateScript:withSourceURL:");

    private const string selException = "exception";

    private static readonly IntPtr selExceptionHandle = Selector.GetHandle("exception");

    private const string selExceptionHandler = "exceptionHandler";

    private static readonly IntPtr selExceptionHandlerHandle = Selector.GetHandle("exceptionHandler");

    private const string selGlobalObject = "globalObject";

    private static readonly IntPtr selGlobalObjectHandle = Selector.GetHandle("globalObject");

    private const string selInit = "init";

    private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

    private const string selInitWithVirtualMachine_ = "initWithVirtualMachine:";

    private static readonly IntPtr selInitWithVirtualMachine_Handle = Selector.GetHandle("initWithVirtualMachine:");

    private const string selName = "name";

    private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

    private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

    private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

    private const string selSetException_ = "setException:";

    private static readonly IntPtr selSetException_Handle = Selector.GetHandle("setException:");

    private const string selSetExceptionHandler_ = "setExceptionHandler:";

    private static readonly IntPtr selSetExceptionHandler_Handle = Selector.GetHandle("setExceptionHandler:");

    private const string selSetName_ = "setName:";

    private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

    private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

    private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

    private const string selVirtualMachine = "virtualMachine";

    private static readonly IntPtr selVirtualMachineHandle = Selector.GetHandle("virtualMachine");

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

    public static JSValue[] CurrentArguments
    {
        [Export("currentArguments")]
        get
        {
            return NSArray.ArrayFromHandle<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentArgumentsHandle));
        }
    }

    public static JSValue CurrentCallee
    {
        [Export("currentCallee")]
        get
        {
            return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCalleeHandle));
        }
    }

    public static JSContext CurrentContext
    {
        [Export("currentContext")]
        get
        {
            return Runtime.GetNSObjectTx<JSContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle));
        }
    }

    public static JSValue CurrentThis
    {
        [Export("currentThis")]
        get
        {
            return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentThisHandle));
        }
    }

    public virtual JSValue? Exception
    {
        [Export("exception", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend(Handle, selExceptionHandle));
            }
            return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selExceptionHandle));
        }
        [Export("setException:", ArgumentSemantic.Retain)]
        set
        {
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetException_Handle, value?.Handle ?? IntPtr.Zero);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetException_Handle, value?.Handle ?? IntPtr.Zero);
            }
        }
    }

    public unsafe virtual JSContextExceptionHandler ExceptionHandler
    {
        [Export("exceptionHandler", ArgumentSemantic.Copy)]
        get
        {
            IntPtr block = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selExceptionHandlerHandle) : Messaging.IntPtr_objc_msgSend(Handle, selExceptionHandlerHandle));
            return Trampolines.NIDJSContextExceptionHandler.Create(block);
        }
        [Export("setExceptionHandler:", ArgumentSemantic.Copy)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            BlockLiteral blockLiteral = default(BlockLiteral);
            BlockLiteral* ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDJSContextExceptionHandler.Handler, value);
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetExceptionHandler_Handle, (IntPtr)ptr);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetExceptionHandler_Handle, (IntPtr)ptr);
            }
            ptr->CleanupBlock();
        }
    }

    public virtual JSValue GlobalObject
    {
        [Export("globalObject")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend(Handle, selGlobalObjectHandle));
            }
            return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selGlobalObjectHandle));
        }
    }

    public virtual IntPtr JSGlobalContextRefPtr
    {
        [Export("JSGlobalContextRef")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.IntPtr_objc_msgSend(Handle, selJSGlobalContextRefHandle);
            }
            return Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selJSGlobalContextRefHandle);
        }
    }

    public virtual string? Name
    {
        [Export("name")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selNameHandle));
        }
        [Export("setName:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetName_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetName_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    public virtual JSVirtualMachine VirtualMachine
    {
        [Export("virtualMachine", ArgumentSemantic.Retain)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<JSVirtualMachine>(Messaging.IntPtr_objc_msgSend(Handle, selVirtualMachineHandle));
            }
            return Runtime.GetNSObjectTx<JSVirtualMachine>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selVirtualMachineHandle));
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected JSContext(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal JSContext(IntPtr handle)
        : base(handle)
    {
    }

    [Export("init")]
    public JSContext()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [Export("initWithVirtualMachine:")]
    public JSContext(JSVirtualMachine virtualMachine)
        : base(NSObjectFlag.Empty)
    {
        if (virtualMachine == null)
        {
            throw new ArgumentNullException("virtualMachine");
        }
        if (IsDirectBinding)
            InitializeWithHandle(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithVirtualMachine_Handle, virtualMachine.Handle));
        else
            InitializeWithHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithVirtualMachine_Handle, virtualMachine.Handle));
    }

    [Export("evaluateScript:withSourceURL:")]
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
        JSValue result = ((!IsDirectBinding) ? Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selEvaluateScript_WithSourceURL_Handle, arg, sourceUrl.Handle)) : Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selEvaluateScript_WithSourceURL_Handle, arg, sourceUrl.Handle)));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("evaluateScript:")]
    public virtual JSValue EvaluateScript(string script)
    {
        if (script == null)
        {
            throw new ArgumentNullException("script");
        }
        IntPtr arg = NSString.CreateNative(script);
        JSValue result = ((!IsDirectBinding) ? Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selEvaluateScript_Handle, arg)) : Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selEvaluateScript_Handle, arg)));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("contextWithJSGlobalContextRef:")]
    public static JSContext FromJSGlobalContextRef(IntPtr nativeJsGlobalContextRef)
    {
        return Runtime.GetNSObjectTx<JSContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContextWithJSGlobalContextRef_Handle, nativeJsGlobalContextRef));
    }

    [Export("objectForKeyedSubscript:")]
    internal virtual JSValue _GetObject(NSObject key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (IsDirectBinding)
        {
            return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selObjectForKeyedSubscript_Handle, key.Handle));
        }
        return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selObjectForKeyedSubscript_Handle, key.Handle));
    }

    [Export("setObject:forKeyedSubscript:")]
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
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, key.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, key.Handle);
        }
    }
}

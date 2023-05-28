using System;
using System.ComponentModel;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

[Register("WebScriptObject", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebScriptObject : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSObject = "JSObject";

	private static readonly IntPtr selJSObjectHandle = Selector.GetHandle("JSObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSValue = "JSValue";

	private static readonly IntPtr selJSValueHandle = Selector.GetHandle("JSValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallWebScriptMethod_WithArguments_ = "callWebScriptMethod:withArguments:";

	private static readonly IntPtr selCallWebScriptMethod_WithArguments_Handle = Selector.GetHandle("callWebScriptMethod:withArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateWebScript_ = "evaluateWebScript:";

	private static readonly IntPtr selEvaluateWebScript_Handle = Selector.GetHandle("evaluateWebScript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveWebScriptKey_ = "removeWebScriptKey:";

	private static readonly IntPtr selRemoveWebScriptKey_Handle = Selector.GetHandle("removeWebScriptKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetException_ = "setException:";

	private static readonly IntPtr selSetException_Handle = Selector.GetHandle("setException:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWebScriptValueAtIndex_Value_ = "setWebScriptValueAtIndex:value:";

	private static readonly IntPtr selSetWebScriptValueAtIndex_Value_Handle = Selector.GetHandle("setWebScriptValueAtIndex:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringRepresentation = "stringRepresentation";

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThrowException_ = "throwException:";

	private static readonly IntPtr selThrowException_Handle = Selector.GetHandle("throwException:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebScriptValueAtIndex_ = "webScriptValueAtIndex:";

	private static readonly IntPtr selWebScriptValueAtIndex_Handle = Selector.GetHandle("webScriptValueAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebScriptObject");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr JSObject
	{
		[Export("JSObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selJSObjectHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJSObjectHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual JSValue JSValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("JSValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selJSValueHandle));
			}
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJSValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringRepresentation
	{
		[Export("stringRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebScriptObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebScriptObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("callWebScriptMethod:withArguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CallWebScriptMethod(string name, NSObject[] arguments)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCallWebScriptMethod_WithArguments_Handle, arg, nSArray.Handle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCallWebScriptMethod_WithArguments_Handle, arg, nSArray.Handle)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("evaluateWebScript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject EvaluateWebScript(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluateWebScript_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEvaluateWebScript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeWebScriptKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveWebScriptKey(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWebScriptKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWebScriptKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setException:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetException(string description)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		IntPtr arg = NSString.CreateNative(description);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetException_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetException_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setWebScriptValueAtIndex:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWebScriptValueAtIndex(int index, NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selSetWebScriptValueAtIndex_Value_Handle, index, value.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selSetWebScriptValueAtIndex_Value_Handle, index, value.Handle);
		}
	}

	[Export("throwException:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ThrowException(string exceptionMessage)
	{
		if (exceptionMessage == null)
		{
			throw new ArgumentNullException("exceptionMessage");
		}
		IntPtr arg = NSString.CreateNative(exceptionMessage);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selThrowException_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("webScriptValueAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject WebScriptValueAtIndex(int index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selWebScriptValueAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selWebScriptValueAtIndex_Handle, index));
	}
}

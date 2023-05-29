using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebScriptObject", true)]
public class WebScriptObject : NSObject
{
	private static readonly IntPtr selJSObjectHandle = Selector.GetHandle("JSObject");

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	private static readonly IntPtr selThrowException_Handle = Selector.GetHandle("throwException:");

	private static readonly IntPtr selCallWebScriptMethodWithArguments_Handle = Selector.GetHandle("callWebScriptMethod:withArguments:");

	private static readonly IntPtr selEvaluateWebScript_Handle = Selector.GetHandle("evaluateWebScript:");

	private static readonly IntPtr selRemoveWebScriptKey_Handle = Selector.GetHandle("removeWebScriptKey:");

	private static readonly IntPtr selWebScriptValueAtIndex_Handle = Selector.GetHandle("webScriptValueAtIndex:");

	private static readonly IntPtr selSetWebScriptValueAtIndexValue_Handle = Selector.GetHandle("setWebScriptValueAtIndex:value:");

	private static readonly IntPtr selSetException_Handle = Selector.GetHandle("setException:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebScriptObject");

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr JSObject
	{
		[Export("JSObject")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selJSObjectHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJSObjectHandle);
		}
	}

	public virtual string StringRepresentation
	{
		[Export("stringRepresentation")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebScriptObject(NSCoder coder)
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
	public WebScriptObject(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebScriptObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("throwException:")]
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

	[Export("callWebScriptMethod:withArguments:")]
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
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCallWebScriptMethodWithArguments_Handle, arg, nSArray.Handle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCallWebScriptMethodWithArguments_Handle, arg, nSArray.Handle)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	[Export("evaluateWebScript:")]
	public virtual NSObject EvaluateWebScript(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEvaluateWebScript_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEvaluateWebScript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeWebScriptKey:")]
	public virtual void RemoveWebScriptKey(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWebScriptKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWebScriptKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("webScriptValueAtIndex:")]
	public virtual NSObject WebScriptValueAtIndex(int index)
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selWebScriptValueAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selWebScriptValueAtIndex_Handle, index));
	}

	[Export("setWebScriptValueAtIndex:value:")]
	public virtual void SetWebScriptValueAtIndexvalue(int index, NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selSetWebScriptValueAtIndexValue_Handle, index, value.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selSetWebScriptValueAtIndexValue_Handle, index, value.Handle);
		}
	}

	[Export("setException:")]
	public virtual void SetException(string description)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		IntPtr arg = NSString.CreateNative(description);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetException_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetException_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

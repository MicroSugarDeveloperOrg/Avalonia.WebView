using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Register("JSManagedValue", true)]
public class JSManagedValue : NSObject
{
	private const string selInitWithValue_ = "initWithValue:";

	private static readonly IntPtr selInitWithValue_Handle = Selector.GetHandle("initWithValue:");

	private const string selManagedValueWithValue_ = "managedValueWithValue:";

	private static readonly IntPtr selManagedValueWithValue_Handle = Selector.GetHandle("managedValueWithValue:");

	private const string selManagedValueWithValue_AndOwner_ = "managedValueWithValue:andOwner:";

	private static readonly IntPtr selManagedValueWithValue_AndOwner_Handle = Selector.GetHandle("managedValueWithValue:andOwner:");

	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("JSManagedValue");

	public override IntPtr ClassHandle => class_ptr;

	public virtual JSValue Value
	{
		[Export("value")]
		get
		{
			if (IsDirectBinding)
			{
				return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSend(Handle, selValueHandle));
			}
			return Runtime.GetNSObjectTx<JSValue>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selValueHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public JSManagedValue()
		: base(NSObjectFlag.Empty)
	{
		InitializeHandle(Selector.Init);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected JSManagedValue(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal JSManagedValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithValue:")]
	public JSManagedValue(JSValue value)
		: base(NSObjectFlag.Empty)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
            InitializeWithHandle(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInitWithValue_Handle, value.Handle));
        else
            InitializeWithHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInitWithValue_Handle, value.Handle));

    }

    [Export("managedValueWithValue:")]
	public static JSManagedValue Get(JSValue value)
	{
		if (value == null)
            throw new ArgumentNullException("value");

        return Runtime.GetNSObjectTx<JSManagedValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selManagedValueWithValue_Handle, value.Handle));
	}

	[Export("managedValueWithValue:andOwner:")]
	public static JSManagedValue Get(JSValue value, NSObject owner)
	{
		if (value == null)
            throw new ArgumentNullException("value");

        if (owner == null)
            throw new ArgumentNullException("owner");

        return Runtime.GetNSObjectTx<JSManagedValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selManagedValueWithValue_AndOwner_Handle, value.Handle, owner.Handle));
	}
}

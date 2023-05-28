using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Register("JSManagedValue", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class JSManagedValue : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithValue_ = "initWithValue:";

	private static readonly IntPtr selInitWithValue_Handle = Selector.GetHandle("initWithValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedValueWithValue_ = "managedValueWithValue:";

	private static readonly IntPtr selManagedValueWithValue_Handle = Selector.GetHandle("managedValueWithValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedValueWithValue_AndOwner_ = "managedValueWithValue:andOwner:";

	private static readonly IntPtr selManagedValueWithValue_AndOwner_Handle = Selector.GetHandle("managedValueWithValue:andOwner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("JSManagedValue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual JSValue Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return Runtime.GetNSObject<JSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public JSManagedValue()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected JSManagedValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal JSManagedValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public JSManagedValue(JSValue value)
		: base(NSObjectFlag.Empty)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithValue_Handle, value.Handle), "initWithValue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithValue_Handle, value.Handle), "initWithValue:");
		}
	}

	[Export("managedValueWithValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSManagedValue Get(JSValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Runtime.GetNSObject<JSManagedValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selManagedValueWithValue_Handle, value.Handle));
	}

	[Export("managedValueWithValue:andOwner:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static JSManagedValue Get(JSValue value, NSObject owner)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		return Runtime.GetNSObject<JSManagedValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selManagedValueWithValue_AndOwner_Handle, value.Handle, owner.Handle));
	}
}

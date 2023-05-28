using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAPropertyAnimation", true)]
public class CAPropertyAnimation : CAAnimation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithKeyPath_ = "animationWithKeyPath:";

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdditive = "isAdditive";

	private static readonly IntPtr selIsAdditiveHandle = Selector.GetHandle("isAdditive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCumulative = "isCumulative";

	private static readonly IntPtr selIsCumulativeHandle = Selector.GetHandle("isCumulative");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyPath = "keyPath";

	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdditive_ = "setAdditive:";

	private static readonly IntPtr selSetAdditive_Handle = Selector.GetHandle("setAdditive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCumulative_ = "setCumulative:";

	private static readonly IntPtr selSetCumulative_Handle = Selector.GetHandle("setCumulative:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyPath_ = "setKeyPath:";

	private static readonly IntPtr selSetKeyPath_Handle = Selector.GetHandle("setKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueFunction_ = "setValueFunction:";

	private static readonly IntPtr selSetValueFunction_Handle = Selector.GetHandle("setValueFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueFunction = "valueFunction";

	private static readonly IntPtr selValueFunctionHandle = Selector.GetHandle("valueFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAPropertyAnimation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Additive
	{
		[Export("isAdditive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdditiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdditiveHandle);
		}
		[Export("setAdditive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdditive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdditive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cumulative
	{
		[Export("isCumulative")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCumulativeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCumulativeHandle);
		}
		[Export("setCumulative:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCumulative_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCumulative_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? KeyPath
	{
		[Export("keyPath", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
		[Export("setKeyPath:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAValueFunction? ValueFunction
	{
		[Export("valueFunction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CAValueFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueFunctionHandle));
			}
			return Runtime.GetNSObject<CAValueFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueFunctionHandle));
		}
		[Export("setValueFunction:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueFunction_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueFunction_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAPropertyAnimation()
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
	public CAPropertyAnimation(NSCoder coder)
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
	protected CAPropertyAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAPropertyAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAPropertyAnimation FromKeyPath(string? path)
	{
		IntPtr arg = NSString.CreateNative(path);
		CAPropertyAnimation nSObject = Runtime.GetNSObject<CAPropertyAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

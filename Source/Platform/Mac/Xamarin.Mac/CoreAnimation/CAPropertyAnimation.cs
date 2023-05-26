using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAPropertyAnimation", true)]
public class CAPropertyAnimation : CAAnimation
{
	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	private static readonly IntPtr selSetKeyPath_Handle = Selector.GetHandle("setKeyPath:");

	private static readonly IntPtr selIsAdditiveHandle = Selector.GetHandle("isAdditive");

	private static readonly IntPtr selSetAdditive_Handle = Selector.GetHandle("setAdditive:");

	private static readonly IntPtr selIsCumulativeHandle = Selector.GetHandle("isCumulative");

	private static readonly IntPtr selSetCumulative_Handle = Selector.GetHandle("setCumulative:");

	private static readonly IntPtr selValueFunctionHandle = Selector.GetHandle("valueFunction");

	private static readonly IntPtr selSetValueFunction_Handle = Selector.GetHandle("setValueFunction:");

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAPropertyAnimation");

	private object __mt_ValueFunction_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string KeyPath
	{
		[Export("keyPath", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
		[Export("setKeyPath:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual bool Additive
	{
		[Export("isAdditive")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdditiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdditiveHandle);
		}
		[Export("setAdditive:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdditive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdditive_Handle, value);
			}
		}
	}

	public virtual bool Cumulative
	{
		[Export("isCumulative")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCumulativeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCumulativeHandle);
		}
		[Export("setCumulative:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCumulative_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCumulative_Handle, value);
			}
		}
	}

	public virtual CAValueFunction ValueFunction
	{
		[Export("valueFunction", ArgumentSemantic.Retain)]
		get
		{
			return (CAValueFunction)(__mt_ValueFunction_var = ((!IsDirectBinding) ? ((CAValueFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueFunctionHandle))) : ((CAValueFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueFunctionHandle)))));
		}
		[Export("setValueFunction:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueFunction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueFunction_Handle, value.Handle);
			}
			__mt_ValueFunction_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAPropertyAnimation()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAPropertyAnimation(NSCoder coder)
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
	public CAPropertyAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAPropertyAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	public static CAPropertyAnimation FromKeyPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		CAPropertyAnimation result = (CAPropertyAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ValueFunction_var = null;
		}
	}
}

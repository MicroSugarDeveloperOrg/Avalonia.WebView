using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CABasicAnimation", true)]
public class CABasicAnimation : CAPropertyAnimation
{
	private static readonly IntPtr selFromValueHandle = Selector.GetHandle("fromValue");

	private static readonly IntPtr selSetFromValue_Handle = Selector.GetHandle("setFromValue:");

	private static readonly IntPtr selToValueHandle = Selector.GetHandle("toValue");

	private static readonly IntPtr selSetToValue_Handle = Selector.GetHandle("setToValue:");

	private static readonly IntPtr selByValueHandle = Selector.GetHandle("byValue");

	private static readonly IntPtr selSetByValue_Handle = Selector.GetHandle("setByValue:");

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CABasicAnimation");

	private object __mt_From_var;

	private object __mt_To_var;

	private object __mt_By_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject From
	{
		[Export("fromValue", ArgumentSemantic.Retain)]
		get
		{
			return (NSObject)(__mt_From_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFromValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFromValueHandle))));
		}
		[Export("setFromValue:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFromValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFromValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_From_var = value;
		}
	}

	public virtual NSObject To
	{
		[Export("toValue", ArgumentSemantic.Retain)]
		get
		{
			return (NSObject)(__mt_To_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selToValueHandle))));
		}
		[Export("setToValue:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_To_var = value;
		}
	}

	public virtual NSObject By
	{
		[Export("byValue", ArgumentSemantic.Retain)]
		get
		{
			return (NSObject)(__mt_By_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selByValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selByValueHandle))));
		}
		[Export("setByValue:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetByValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetByValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_By_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CABasicAnimation()
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
	public CABasicAnimation(NSCoder coder)
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
	public CABasicAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CABasicAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	public new static CABasicAnimation FromKeyPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		CABasicAnimation result = (CABasicAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_From_var = null;
			__mt_To_var = null;
			__mt_By_var = null;
		}
	}
}

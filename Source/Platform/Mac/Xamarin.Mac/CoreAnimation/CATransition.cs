using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CATransition", true)]
public class CATransition : CAAnimation
{
	private const string Fade = "fade";

	private const string MoveIn = "moveIn";

	private const string Push = "push";

	private const string Reveal = "reveal";

	private const string FromRight = "fromRight";

	private const string FromLeft = "fromLeft";

	private const string FromTop = "fromTop";

	private const string FromBottom = "fromBottom";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	private static readonly IntPtr selSubtypeHandle = Selector.GetHandle("subtype");

	private static readonly IntPtr selSetSubtype_Handle = Selector.GetHandle("setSubtype:");

	private static readonly IntPtr selStartProgressHandle = Selector.GetHandle("startProgress");

	private static readonly IntPtr selSetStartProgress_Handle = Selector.GetHandle("setStartProgress:");

	private static readonly IntPtr selEndProgressHandle = Selector.GetHandle("endProgress");

	private static readonly IntPtr selSetEndProgress_Handle = Selector.GetHandle("setEndProgress:");

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	private static readonly IntPtr selSetFilter_Handle = Selector.GetHandle("setFilter:");

	private static readonly IntPtr selAnimationHandle = Selector.GetHandle("animation");

	private static readonly IntPtr class_ptr = Class.GetHandle("CATransition");

	private object __mt_filter_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Type
	{
		[Export("type", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
		[Export("setType:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Subtype
	{
		[Export("subtype", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtypeHandle));
		}
		[Export("setSubtype:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubtype_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubtype_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual float StartProgress
	{
		[Export("startProgress")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStartProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStartProgressHandle);
		}
		[Export("setStartProgress:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStartProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStartProgress_Handle, value);
			}
		}
	}

	public virtual float EndProgress
	{
		[Export("endProgress")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEndProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEndProgressHandle);
		}
		[Export("setEndProgress:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEndProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEndProgress_Handle, value);
			}
		}
	}

	public virtual NSObject filter
	{
		[Export("filter", ArgumentSemantic.Retain)]
		get
		{
			return (NSObject)(__mt_filter_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle))));
		}
		[Export("setFilter:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_filter_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATransition()
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
	public CATransition(NSCoder coder)
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
	public CATransition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CATransition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animation")]
	public new static CATransition CreateAnimation()
	{
		return (CATransition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_filter_var = null;
		}
	}
}

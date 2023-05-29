using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAAnimationGroup", true)]
public class CAAnimationGroup : CAAnimation
{
	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	private static readonly IntPtr selAnimationHandle = Selector.GetHandle("animation");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAAnimationGroup");

	private object __mt_Animations_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CAAnimation[] Animations
	{
		[Export("animations", ArgumentSemantic.Copy)]
		get
		{
			return (CAAnimation[])(__mt_Animations_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CAAnimation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle)) : NSArray.ArrayFromHandle<CAAnimation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle))));
		}
		[Export("setAnimations:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Animations_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAAnimationGroup()
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
	public CAAnimationGroup(NSCoder coder)
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
	public CAAnimationGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAAnimationGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animation")]
	public new static CAAnimationGroup CreateAnimation()
	{
		return (CAAnimationGroup)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Animations_var = null;
		}
	}
}

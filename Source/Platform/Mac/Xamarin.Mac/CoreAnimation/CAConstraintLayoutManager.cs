using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAConstraintLayoutManager", true)]
public class CAConstraintLayoutManager : NSObject
{
	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAConstraintLayoutManager");

	private static object __mt_LayoutManager_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static CAConstraintLayoutManager LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			return (CAConstraintLayoutManager)(__mt_LayoutManager_var_static = (CAConstraintLayoutManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayoutManagerHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAConstraintLayoutManager()
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
	public CAConstraintLayoutManager(NSCoder coder)
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
	public CAConstraintLayoutManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAConstraintLayoutManager(IntPtr handle)
		: base(handle)
	{
	}
}

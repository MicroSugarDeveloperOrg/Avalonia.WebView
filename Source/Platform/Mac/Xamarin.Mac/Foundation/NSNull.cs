using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNull", true)]
public class NSNull : NSObject
{
	private static readonly IntPtr selNullHandle = Selector.GetHandle("null");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNull");

	private static object __mt_Null_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSNull Null
	{
		[Export("null")]
		get
		{
			return (NSNull)(__mt_Null_var_static = (NSNull)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selNullHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNull()
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
	public NSNull(NSCoder coder)
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
	public NSNull(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNull(IntPtr handle)
		: base(handle)
	{
	}
}

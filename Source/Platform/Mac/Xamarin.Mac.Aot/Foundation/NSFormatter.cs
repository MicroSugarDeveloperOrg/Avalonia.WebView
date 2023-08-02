using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSFormatter", true)]
public class NSFormatter : NSObject
{
	private static readonly IntPtr selStringForObjectValue_Handle = Selector.GetHandle("stringForObjectValue:");

	private static readonly IntPtr selEditingStringForObjectValue_Handle = Selector.GetHandle("editingStringForObjectValue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFormatter()
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
	public NSFormatter(NSCoder coder)
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
	public NSFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringForObjectValue:")]
	public virtual string StringFor(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForObjectValue_Handle, value.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForObjectValue_Handle, value.Handle));
	}

	[Export("editingStringForObjectValue:")]
	public virtual string EditingStringFor(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEditingStringForObjectValue_Handle, value.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEditingStringForObjectValue_Handle, value.Handle));
	}
}

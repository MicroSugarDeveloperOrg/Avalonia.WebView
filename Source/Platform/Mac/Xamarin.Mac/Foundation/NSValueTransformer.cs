using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSValueTransformer", true)]
public class NSValueTransformer : NSObject
{
	private static readonly IntPtr selReverseTransformedValue_Handle = Selector.GetHandle("reverseTransformedValue:");

	private static readonly IntPtr selTransformedValue_Handle = Selector.GetHandle("transformedValue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSValueTransformer");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSValueTransformer()
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
	public NSValueTransformer(NSCoder coder)
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
	public NSValueTransformer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSValueTransformer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reverseTransformedValue:")]
	public virtual NSObject ReverseTransformedValue(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReverseTransformedValue_Handle, value.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReverseTransformedValue_Handle, value.Handle));
	}

	[Export("transformedValue:")]
	public virtual NSObject TransformedValue(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTransformedValue_Handle, value.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformedValue_Handle, value.Handle));
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSValue", true)]
public class DomCssValue : DomObject
{
	private static readonly IntPtr selCssTextHandle = Selector.GetHandle("cssText");

	private static readonly IntPtr selSetCssText_Handle = Selector.GetHandle("setCssText:");

	private static readonly IntPtr selCssValueTypeHandle = Selector.GetHandle("cssValueType");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCSSValue");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string CssText
	{
		[Export("cssText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCssTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssTextHandle));
		}
		[Export("setCssText:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCssText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCssText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomCssValueType Type
	{
		[Export("cssValueType")]
		get
		{
			if (IsDirectBinding)
			{
				return (DomCssValueType)Messaging.UInt16_objc_msgSend(base.Handle, selCssValueTypeHandle);
			}
			return (DomCssValueType)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selCssValueTypeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCssValue(NSCoder coder)
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
	public DomCssValue(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCssValue(IntPtr handle)
		: base(handle)
	{
	}
}

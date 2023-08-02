using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSRule", true)]
public class DomCssRule : DomObject
{
	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selCssTextHandle = Selector.GetHandle("cssText");

	private static readonly IntPtr selSetCssText_Handle = Selector.GetHandle("setCssText:");

	private static readonly IntPtr selParentStyleSheetHandle = Selector.GetHandle("parentStyleSheet");

	private static readonly IntPtr selParentRuleHandle = Selector.GetHandle("parentRule");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCSSRule");

	private object __mt_ParentStyleSheet_var;

	private object __mt_ParentRule_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomCssRuleType Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return (DomCssRuleType)Messaging.UInt16_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (DomCssRuleType)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

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

	public virtual DomCssStyleSheet ParentStyleSheet
	{
		[Export("parentStyleSheet")]
		get
		{
			return (DomCssStyleSheet)(__mt_ParentStyleSheet_var = ((!IsDirectBinding) ? ((DomCssStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentStyleSheetHandle))) : ((DomCssStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentStyleSheetHandle)))));
		}
	}

	public virtual DomCssRule ParentRule
	{
		[Export("parentRule")]
		get
		{
			return (DomCssRule)(__mt_ParentRule_var = ((!IsDirectBinding) ? ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentRuleHandle))) : ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentRuleHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCssRule(NSCoder coder)
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
	public DomCssRule(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCssRule(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentStyleSheet_var = null;
			__mt_ParentRule_var = null;
		}
	}
}

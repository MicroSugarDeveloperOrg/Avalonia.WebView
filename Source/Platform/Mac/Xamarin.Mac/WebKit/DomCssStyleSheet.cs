using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSStyleSheet", true)]
public class DomCssStyleSheet : DomStyleSheet
{
	private static readonly IntPtr selOwnerRuleHandle = Selector.GetHandle("ownerRule");

	private static readonly IntPtr selCssRulesHandle = Selector.GetHandle("cssRules");

	private static readonly IntPtr selRulesHandle = Selector.GetHandle("rules");

	private static readonly IntPtr selInsertRuleIndex_Handle = Selector.GetHandle("insertRule:index:");

	private static readonly IntPtr selDeleteRule_Handle = Selector.GetHandle("deleteRule:");

	private static readonly IntPtr selAddRuleStyleIndex_Handle = Selector.GetHandle("addRule:style:index:");

	private static readonly IntPtr selRemoveRule_Handle = Selector.GetHandle("removeRule:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCSSStyleSheet");

	private object __mt_OwnerRule_var;

	private object __mt_CssRules_var;

	private object __mt_Rules_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomCssRule OwnerRule
	{
		[Export("ownerRule")]
		get
		{
			return (DomCssRule)(__mt_OwnerRule_var = ((!IsDirectBinding) ? ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerRuleHandle))) : ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerRuleHandle)))));
		}
	}

	public virtual DomCssRuleList CssRules
	{
		[Export("cssRules")]
		get
		{
			return (DomCssRuleList)(__mt_CssRules_var = ((!IsDirectBinding) ? ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssRulesHandle))) : ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCssRulesHandle)))));
		}
	}

	public virtual DomCssRuleList Rules
	{
		[Export("rules")]
		get
		{
			return (DomCssRuleList)(__mt_Rules_var = ((!IsDirectBinding) ? ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRulesHandle))) : ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRulesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCssStyleSheet(NSCoder coder)
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
	public DomCssStyleSheet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCssStyleSheet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("insertRule:index:")]
	public virtual uint InsertRule(string rule, uint index)
	{
		if (rule == null)
		{
			throw new ArgumentNullException("rule");
		}
		IntPtr arg = NSString.CreateNative(rule);
		uint result = ((!IsDirectBinding) ? Messaging.UInt32_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selInsertRuleIndex_Handle, arg, index) : Messaging.UInt32_objc_msgSend_IntPtr_UInt32(base.Handle, selInsertRuleIndex_Handle, arg, index));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("deleteRule:")]
	public virtual void DeleteRule(uint index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selDeleteRule_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selDeleteRule_Handle, index);
		}
	}

	[Export("addRule:style:index:")]
	public virtual int AddRule(string selector, string style, uint index)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (style == null)
		{
			throw new ArgumentNullException("style");
		}
		IntPtr arg = NSString.CreateNative(selector);
		IntPtr arg2 = NSString.CreateNative(style);
		int result = ((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_UInt32(base.SuperHandle, selAddRuleStyleIndex_Handle, arg, arg2, index) : Messaging.int_objc_msgSend_IntPtr_IntPtr_UInt32(base.Handle, selAddRuleStyleIndex_Handle, arg, arg2, index));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("removeRule:")]
	public virtual void RemoveRule(uint index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveRule_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveRule_Handle, index);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OwnerRule_var = null;
			__mt_CssRules_var = null;
			__mt_Rules_var = null;
		}
	}
}

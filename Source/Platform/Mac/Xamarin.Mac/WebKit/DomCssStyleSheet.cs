using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSStyleSheet", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCssStyleSheet : DomStyleSheet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRule_Style_Index_ = "addRule:style:index:";

	private static readonly IntPtr selAddRule_Style_Index_Handle = Selector.GetHandle("addRule:style:index:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCssRules = "cssRules";

	private static readonly IntPtr selCssRulesHandle = Selector.GetHandle("cssRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteRule_ = "deleteRule:";

	private static readonly IntPtr selDeleteRule_Handle = Selector.GetHandle("deleteRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRule_Index_ = "insertRule:index:";

	private static readonly IntPtr selInsertRule_Index_Handle = Selector.GetHandle("insertRule:index:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwnerRule = "ownerRule";

	private static readonly IntPtr selOwnerRuleHandle = Selector.GetHandle("ownerRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRule_ = "removeRule:";

	private static readonly IntPtr selRemoveRule_Handle = Selector.GetHandle("removeRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRules = "rules";

	private static readonly IntPtr selRulesHandle = Selector.GetHandle("rules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSStyleSheet");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRuleList CssRules
	{
		[Export("cssRules", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSend(base.Handle, selCssRulesHandle));
			}
			return Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssRulesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRule OwnerRule
	{
		[Export("ownerRule", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerRuleHandle));
			}
			return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerRuleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRuleList Rules
	{
		[Export("rules", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSend(base.Handle, selRulesHandle));
			}
			return Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRulesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCssStyleSheet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCssStyleSheet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addRule:style:index:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_UInt32(base.SuperHandle, selAddRule_Style_Index_Handle, arg, arg2, index) : Messaging.int_objc_msgSend_IntPtr_IntPtr_UInt32(base.Handle, selAddRule_Style_Index_Handle, arg, arg2, index));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("deleteRule:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteRule(uint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selDeleteRule_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selDeleteRule_Handle, index);
		}
	}

	[Export("insertRule:index:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint InsertRule(string rule, uint index)
	{
		if (rule == null)
		{
			throw new ArgumentNullException("rule");
		}
		IntPtr arg = NSString.CreateNative(rule);
		uint result = ((!base.IsDirectBinding) ? Messaging.UInt32_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selInsertRule_Index_Handle, arg, index) : Messaging.UInt32_objc_msgSend_IntPtr_UInt32(base.Handle, selInsertRule_Index_Handle, arg, index));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeRule:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRule(uint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveRule_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveRule_Handle, index);
		}
	}
}

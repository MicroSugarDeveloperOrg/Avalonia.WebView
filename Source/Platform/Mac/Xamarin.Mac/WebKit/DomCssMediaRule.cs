using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSMediaRule", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCssMediaRule : DomCssRule
{
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
	private const string selMedia = "media";

	private static readonly IntPtr selMediaHandle = Selector.GetHandle("media");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSMediaRule");

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
	public virtual DomMediaList Media
	{
		[Export("media", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomMediaList>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaHandle));
			}
			return Runtime.GetNSObject<DomMediaList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCssMediaRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCssMediaRule(IntPtr handle)
		: base(handle)
	{
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
}

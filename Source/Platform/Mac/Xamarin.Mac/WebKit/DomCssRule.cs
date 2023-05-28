using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSRule", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCssRule : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCssText = "cssText";

	private static readonly IntPtr selCssTextHandle = Selector.GetHandle("cssText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentRule = "parentRule";

	private static readonly IntPtr selParentRuleHandle = Selector.GetHandle("parentRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentStyleSheet = "parentStyleSheet";

	private static readonly IntPtr selParentStyleSheetHandle = Selector.GetHandle("parentStyleSheet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCssText_ = "setCssText:";

	private static readonly IntPtr selSetCssText_Handle = Selector.GetHandle("setCssText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CssText
	{
		[Export("cssText", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCssTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssTextHandle));
		}
		[Export("setCssText:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRule ParentRule
	{
		[Export("parentRule", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentRuleHandle));
			}
			return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentRuleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssStyleSheet ParentStyleSheet
	{
		[Export("parentStyleSheet", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentStyleSheetHandle));
			}
			return Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentStyleSheetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRuleType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (DomCssRuleType)Messaging.UInt16_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (DomCssRuleType)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCssRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCssRule(IntPtr handle)
		: base(handle)
	{
	}
}

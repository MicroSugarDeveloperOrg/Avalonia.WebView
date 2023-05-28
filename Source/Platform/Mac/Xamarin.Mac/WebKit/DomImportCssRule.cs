using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSImportRule", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomImportCssRule : DomCssRule
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHref = "href";

	private static readonly IntPtr selHrefHandle = Selector.GetHandle("href");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMedia = "media";

	private static readonly IntPtr selMediaHandle = Selector.GetHandle("media");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyleSheet = "styleSheet";

	private static readonly IntPtr selStyleSheetHandle = Selector.GetHandle("styleSheet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSImportRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Href
	{
		[Export("href")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHrefHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHrefHandle));
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
	public virtual DomCssStyleSheet StyleSheet
	{
		[Export("styleSheet", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleSheetHandle));
			}
			return Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleSheetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomImportCssRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomImportCssRule(IntPtr handle)
		: base(handle)
	{
	}
}

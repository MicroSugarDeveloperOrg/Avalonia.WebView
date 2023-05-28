using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLPreElement", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlPreElement : DomHtmlElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_ = "setWidth:";

	private static readonly IntPtr selSetWidth_Handle = Selector.GetHandle("setWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWrap_ = "setWrap:";

	private static readonly IntPtr selSetWrap_Handle = Selector.GetHandle("setWrap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWrap = "wrap";

	private static readonly IntPtr selWrapHandle = Selector.GetHandle("wrap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLPreElement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Width
	{
		[Export("width")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
		[Export("setWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Wrap
	{
		[Export("wrap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWrapHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWrapHandle);
		}
		[Export("setWrap:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWrap_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWrap_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlPreElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlPreElement(IntPtr handle)
		: base(handle)
	{
	}
}

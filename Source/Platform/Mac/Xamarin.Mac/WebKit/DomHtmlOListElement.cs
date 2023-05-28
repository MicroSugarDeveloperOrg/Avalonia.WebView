using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLOListElement", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlOListElement : DomHtmlElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompact = "compact";

	private static readonly IntPtr selCompactHandle = Selector.GetHandle("compact");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompact_ = "setCompact:";

	private static readonly IntPtr selSetCompact_Handle = Selector.GetHandle("setCompact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStart_ = "setStart:";

	private static readonly IntPtr selSetStart_Handle = Selector.GetHandle("setStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetType_ = "setType:";

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLOListElement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Compact
	{
		[Export("compact")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCompactHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCompactHandle);
		}
		[Export("setCompact:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCompact_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCompact_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Start
	{
		[Export("start")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selStartHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
		[Export("setStart:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetStart_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
		[Export("setType:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlOListElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlOListElement(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMAttr", true)]
public class DomAttr : DomNode
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSpecifiedHandle = Selector.GetHandle("specified");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	private static readonly IntPtr selOwnerElementHandle = Selector.GetHandle("ownerElement");

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMAttr");

	private object __mt_OwnerElement_var;

	private object __mt_Style_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual bool Specified
	{
		[Export("specified")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSpecifiedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSpecifiedHandle);
		}
	}

	public virtual string Value
	{
		[Export("value")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
		[Export("setValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomElement OwnerElement
	{
		[Export("ownerElement")]
		get
		{
			return (DomElement)(__mt_OwnerElement_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerElementHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerElementHandle)))));
		}
	}

	public virtual DomCssStyleDeclaration Style
	{
		[Export("style")]
		get
		{
			return (DomCssStyleDeclaration)(__mt_Style_var = ((!IsDirectBinding) ? ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleHandle))) : ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomAttr(NSCoder coder)
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
	public DomAttr(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomAttr(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OwnerElement_var = null;
			__mt_Style_var = null;
		}
	}
}

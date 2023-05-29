using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMStyleSheet", true)]
public class DomStyleSheet : DomObject
{
	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selDisabledHandle = Selector.GetHandle("disabled");

	private static readonly IntPtr selSetDisabled_Handle = Selector.GetHandle("setDisabled:");

	private static readonly IntPtr selOwnerNodeHandle = Selector.GetHandle("ownerNode");

	private static readonly IntPtr selParentStyleSheetHandle = Selector.GetHandle("parentStyleSheet");

	private static readonly IntPtr selHrefHandle = Selector.GetHandle("href");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selMediaHandle = Selector.GetHandle("media");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMStyleSheet");

	private object __mt_OwnerNode_var;

	private object __mt_ParentStyleSheet_var;

	private object __mt_Media_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	public virtual bool Disabled
	{
		[Export("disabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisabledHandle);
		}
		[Export("setDisabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisabled_Handle, value);
			}
		}
	}

	public virtual DomNode OwnerNode
	{
		[Export("ownerNode")]
		get
		{
			return (DomNode)(__mt_OwnerNode_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerNodeHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerNodeHandle)))));
		}
	}

	public virtual DomStyleSheet ParentStyleSheet
	{
		[Export("parentStyleSheet")]
		get
		{
			return (DomStyleSheet)(__mt_ParentStyleSheet_var = ((!IsDirectBinding) ? ((DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentStyleSheetHandle))) : ((DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentStyleSheetHandle)))));
		}
	}

	public virtual string Href
	{
		[Export("href")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHrefHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHrefHandle));
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	public virtual DomMediaList Media
	{
		[Export("media")]
		get
		{
			return (DomMediaList)(__mt_Media_var = ((!IsDirectBinding) ? ((DomMediaList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaHandle))) : ((DomMediaList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomStyleSheet(NSCoder coder)
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
	public DomStyleSheet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomStyleSheet(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OwnerNode_var = null;
			__mt_ParentStyleSheet_var = null;
			__mt_Media_var = null;
		}
	}
}

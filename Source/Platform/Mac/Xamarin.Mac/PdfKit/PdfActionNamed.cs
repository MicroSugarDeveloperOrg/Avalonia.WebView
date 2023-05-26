using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionNamed", true)]
public class PdfActionNamed : PdfAction
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFActionNamed");

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfActionNamedName Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfActionNamedName)Messaging.int_objc_msgSend(base.Handle, selNameHandle);
			}
			return (PdfActionNamedName)Messaging.int_objc_msgSendSuper(base.SuperHandle, selNameHandle);
		}
		[Export("setName:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetName_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetName_Handle, (int)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionNamed()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PdfActionNamed(NSCoder coder)
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
	public PdfActionNamed(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfActionNamed(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:")]
	public PdfActionNamed(PdfActionNamedName name)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithName_Handle, (int)name);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithName_Handle, (int)name);
		}
	}
}

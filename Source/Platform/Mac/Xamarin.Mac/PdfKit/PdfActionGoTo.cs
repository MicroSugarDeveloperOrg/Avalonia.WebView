using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionGoTo", true)]
public class PdfActionGoTo : PdfAction
{
	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	private static readonly IntPtr selSetDestination_Handle = Selector.GetHandle("setDestination:");

	private static readonly IntPtr selInitWithDestination_Handle = Selector.GetHandle("initWithDestination:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFActionGoTo");

	private object __mt_Destination_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfDestination Destination
	{
		[Export("destination")]
		get
		{
			return (PdfDestination)(__mt_Destination_var = ((!IsDirectBinding) ? ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationHandle))) : ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationHandle)))));
		}
		[Export("setDestination:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestination_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestination_Handle, value.Handle);
			}
			__mt_Destination_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionGoTo()
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
	public PdfActionGoTo(NSCoder coder)
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
	public PdfActionGoTo(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfActionGoTo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDestination:")]
	public PdfActionGoTo(PdfDestination destination)
		: base(NSObjectFlag.Empty)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDestination_Handle, destination.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDestination_Handle, destination.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Destination_var = null;
		}
	}
}

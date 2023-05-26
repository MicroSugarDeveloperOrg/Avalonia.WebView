using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationLine", true)]
public class PdfAnnotationLine : PdfAnnotation
{
	private static readonly IntPtr selStartPointHandle = Selector.GetHandle("startPoint");

	private static readonly IntPtr selSetStartPoint_Handle = Selector.GetHandle("setStartPoint:");

	private static readonly IntPtr selEndPointHandle = Selector.GetHandle("endPoint");

	private static readonly IntPtr selSetEndPoint_Handle = Selector.GetHandle("setEndPoint:");

	private static readonly IntPtr selStartLineStyleHandle = Selector.GetHandle("startLineStyle");

	private static readonly IntPtr selSetStartLineStyle_Handle = Selector.GetHandle("setStartLineStyle:");

	private static readonly IntPtr selEndLineStyleHandle = Selector.GetHandle("endLineStyle");

	private static readonly IntPtr selSetEndLineStyle_Handle = Selector.GetHandle("setEndLineStyle:");

	private static readonly IntPtr selInteriorColorHandle = Selector.GetHandle("interiorColor");

	private static readonly IntPtr selSetInteriorColor_Handle = Selector.GetHandle("setInteriorColor:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFAnnotationLine");

	private object __mt_InteriorColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGPoint StartPoint
	{
		[Export("startPoint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selStartPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selStartPointHandle);
		}
		[Export("setStartPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetStartPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetStartPoint_Handle, value);
			}
		}
	}

	public virtual CGPoint EndPoint
	{
		[Export("endPoint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selEndPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selEndPointHandle);
		}
		[Export("setEndPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetEndPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetEndPoint_Handle, value);
			}
		}
	}

	public virtual PdfLineStyle StartLineStyle
	{
		[Export("startLineStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfLineStyle)Messaging.int_objc_msgSend(base.Handle, selStartLineStyleHandle);
			}
			return (PdfLineStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStartLineStyleHandle);
		}
		[Export("setStartLineStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetStartLineStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetStartLineStyle_Handle, (int)value);
			}
		}
	}

	public virtual PdfLineStyle EndLineStyle
	{
		[Export("endLineStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfLineStyle)Messaging.int_objc_msgSend(base.Handle, selEndLineStyleHandle);
			}
			return (PdfLineStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selEndLineStyleHandle);
		}
		[Export("setEndLineStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetEndLineStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetEndLineStyle_Handle, (int)value);
			}
		}
	}

	public virtual NSColor InteriorColor
	{
		[Export("interiorColor")]
		get
		{
			return (NSColor)(__mt_InteriorColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInteriorColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInteriorColorHandle)))));
		}
		[Export("setInteriorColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInteriorColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInteriorColor_Handle, value.Handle);
			}
			__mt_InteriorColor_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationLine()
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
	public PdfAnnotationLine(NSCoder coder)
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
	public PdfAnnotationLine(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfAnnotationLine(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InteriorColor_var = null;
		}
	}
}

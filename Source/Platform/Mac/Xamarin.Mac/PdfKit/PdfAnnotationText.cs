using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationText", true)]
public class PdfAnnotationText : PdfAnnotation
{
	private static readonly IntPtr selIconTypeHandle = Selector.GetHandle("iconType");

	private static readonly IntPtr selSetIconType_Handle = Selector.GetHandle("setIconType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFAnnotationText");

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfTextAnnotationIconType IconType
	{
		[Export("iconType")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfTextAnnotationIconType)Messaging.int_objc_msgSend(base.Handle, selIconTypeHandle);
			}
			return (PdfTextAnnotationIconType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selIconTypeHandle);
		}
		[Export("setIconType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetIconType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetIconType_Handle, (int)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationText()
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
	public PdfAnnotationText(NSCoder coder)
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
	public PdfAnnotationText(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfAnnotationText(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationMarkup", true)]
public class PdfAnnotationMarkup : PdfAnnotation
{
	private static readonly IntPtr selQuadrilateralPointsHandle = Selector.GetHandle("quadrilateralPoints");

	private static readonly IntPtr selSetQuadrilateralPoints_Handle = Selector.GetHandle("setQuadrilateralPoints:");

	private static readonly IntPtr selMarkupTypeHandle = Selector.GetHandle("markupType");

	private static readonly IntPtr selSetMarkupType_Handle = Selector.GetHandle("setMarkupType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFAnnotationMarkup");

	private object __mt_QuadrilateralPoints_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSArray QuadrilateralPoints
	{
		[Export("quadrilateralPoints")]
		get
		{
			return (NSArray)(__mt_QuadrilateralPoints_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuadrilateralPointsHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selQuadrilateralPointsHandle)))));
		}
		[Export("setQuadrilateralPoints:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQuadrilateralPoints_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQuadrilateralPoints_Handle, value.Handle);
			}
			__mt_QuadrilateralPoints_var = value;
		}
	}

	public virtual PdfMarkupType MarkupType
	{
		[Export("markupType")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfMarkupType)Messaging.int_objc_msgSend(base.Handle, selMarkupTypeHandle);
			}
			return (PdfMarkupType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selMarkupTypeHandle);
		}
		[Export("setMarkupType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMarkupType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMarkupType_Handle, (int)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationMarkup()
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
	public PdfAnnotationMarkup(NSCoder coder)
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
	public PdfAnnotationMarkup(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfAnnotationMarkup(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_QuadrilateralPoints_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFDestination", true)]
public class PdfDestination : NSObject
{
	private static readonly IntPtr selPageHandle = Selector.GetHandle("page");

	private static readonly IntPtr selPointHandle = Selector.GetHandle("point");

	private static readonly IntPtr selInitWithPageAtPoint_Handle = Selector.GetHandle("initWithPage:atPoint:");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFDestination");

	private object __mt_Page_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfPage Page
	{
		[Export("page")]
		get
		{
			return (PdfPage)(__mt_Page_var = ((!IsDirectBinding) ? ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageHandle))) : ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPageHandle)))));
		}
	}

	public virtual CGPoint Point
	{
		[Export("point")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPointHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfDestination()
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
	public PdfDestination(NSCoder coder)
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
	public PdfDestination(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfDestination(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPage:atPoint:")]
	public PdfDestination(PdfPage page, CGPoint point)
		: base(NSObjectFlag.Empty)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint(base.Handle, selInitWithPageAtPoint_Handle, page.Handle, point);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selInitWithPageAtPoint_Handle, page.Handle, point);
		}
	}

	[Export("compare:")]
	public virtual NSComparisonResult Compare(PdfDestination destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, destination.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, destination.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Page_var = null;
		}
	}
}

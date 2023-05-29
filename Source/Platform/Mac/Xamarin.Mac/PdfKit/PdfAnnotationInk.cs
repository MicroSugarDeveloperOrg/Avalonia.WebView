using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationInk", true)]
public class PdfAnnotationInk : PdfAnnotation
{
	private static readonly IntPtr selPathsHandle = Selector.GetHandle("paths");

	private static readonly IntPtr selAddBezierPath_Handle = Selector.GetHandle("addBezierPath:");

	private static readonly IntPtr selRemoveBezierPath_Handle = Selector.GetHandle("removeBezierPath:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFAnnotationInk");

	private object __mt_Paths_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSBezierPath[] Paths
	{
		[Export("paths")]
		get
		{
			return (NSBezierPath[])(__mt_Paths_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathsHandle)) : NSArray.ArrayFromHandle<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationInk()
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
	public PdfAnnotationInk(NSCoder coder)
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
	public PdfAnnotationInk(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfAnnotationInk(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addBezierPath:")]
	public virtual void AddBezierPathpath(NSBezierPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddBezierPath_Handle, path.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddBezierPath_Handle, path.Handle);
		}
	}

	[Export("removeBezierPath:")]
	public virtual void RemoveBezierPathpath(NSBezierPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveBezierPath_Handle, path.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveBezierPath_Handle, path.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Paths_var = null;
		}
	}
}

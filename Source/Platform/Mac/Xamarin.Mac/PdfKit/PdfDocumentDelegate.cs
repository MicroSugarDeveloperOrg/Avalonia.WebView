using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PdfDocumentDelegate", true)]
[Model]
public class PdfDocumentDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfDocumentDelegate()
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
	public PdfDocumentDelegate(NSCoder coder)
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
	public PdfDocumentDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfDocumentDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("didMatchString:")]
	public virtual void DidMatchString(PdfSelection sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("classForAnnotationClass:")]
	public virtual Class ClassForAnnotationClass(Class sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("documentDidEndDocumentFind:")]
	public virtual void FindFinished(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("documentDidBeginPageFind:")]
	public virtual void PageFindStarted(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("documentDidEndPageFind:")]
	public virtual void PageFindFinished(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("documentDidFindMatch:")]
	public virtual void MatchFound(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotation", true)]
public class PdfAnnotation : NSObject
{
	private static readonly IntPtr selPageHandle = Selector.GetHandle("page");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	private static readonly IntPtr selSetModificationDate_Handle = Selector.GetHandle("setModificationDate:");

	private static readonly IntPtr selUserNameHandle = Selector.GetHandle("userName");

	private static readonly IntPtr selSetUserName_Handle = Selector.GetHandle("setUserName:");

	private static readonly IntPtr selPopupHandle = Selector.GetHandle("popup");

	private static readonly IntPtr selSetPopup_Handle = Selector.GetHandle("setPopup:");

	private static readonly IntPtr selShouldDisplayHandle = Selector.GetHandle("shouldDisplay");

	private static readonly IntPtr selSetShouldDisplay_Handle = Selector.GetHandle("setShouldDisplay:");

	private static readonly IntPtr selShouldPrintHandle = Selector.GetHandle("shouldPrint");

	private static readonly IntPtr selSetShouldPrint_Handle = Selector.GetHandle("setShouldPrint:");

	private static readonly IntPtr selBorderHandle = Selector.GetHandle("border");

	private static readonly IntPtr selSetBorder_Handle = Selector.GetHandle("setBorder:");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selMouseUpActionHandle = Selector.GetHandle("mouseUpAction");

	private static readonly IntPtr selSetMouseUpAction_Handle = Selector.GetHandle("setMouseUpAction:");

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	private static readonly IntPtr selHasAppearanceStreamHandle = Selector.GetHandle("hasAppearanceStream");

	private static readonly IntPtr selInitWithBounds_Handle = Selector.GetHandle("initWithBounds:");

	private static readonly IntPtr selRemoveAllAppearanceStreamsHandle = Selector.GetHandle("removeAllAppearanceStreams");

	private static readonly IntPtr selDrawWithBox_Handle = Selector.GetHandle("drawWithBox:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFAnnotation");

	private object __mt_Page_var;

	private object __mt_ModificationDate_var;

	private object __mt_Popup_var;

	private object __mt_Border_var;

	private object __mt_Color_var;

	private object __mt_MouseUpAction_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfPage Page
	{
		[Export("page")]
		get
		{
			return (PdfPage)(__mt_Page_var = ((!IsDirectBinding) ? ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageHandle))) : ((PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPageHandle)))));
		}
	}

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

	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
		[Export("setBounds:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetBounds_Handle, value);
			}
		}
	}

	public virtual NSDate ModificationDate
	{
		[Export("modificationDate")]
		get
		{
			return (NSDate)(__mt_ModificationDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle)))));
		}
		[Export("setModificationDate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetModificationDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetModificationDate_Handle, value.Handle);
			}
			__mt_ModificationDate_var = value;
		}
	}

	public virtual string UserName
	{
		[Export("userName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserNameHandle));
		}
		[Export("setUserName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual PdfAnnotationPopup Popup
	{
		[Export("popup")]
		get
		{
			return (PdfAnnotationPopup)(__mt_Popup_var = ((!IsDirectBinding) ? ((PdfAnnotationPopup)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPopupHandle))) : ((PdfAnnotationPopup)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPopupHandle)))));
		}
		[Export("setPopup:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPopup_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPopup_Handle, value.Handle);
			}
			__mt_Popup_var = value;
		}
	}

	public virtual bool ShouldDisplay
	{
		[Export("shouldDisplay")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDisplayHandle);
		}
		[Export("setShouldDisplay:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldDisplay_Handle, value);
			}
		}
	}

	public virtual bool ShouldPrint
	{
		[Export("shouldPrint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldPrintHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldPrintHandle);
		}
		[Export("setShouldPrint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldPrint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldPrint_Handle, value);
			}
		}
	}

	public virtual PdfBorder Border
	{
		[Export("border")]
		get
		{
			return (PdfBorder)(__mt_Border_var = ((!IsDirectBinding) ? ((PdfBorder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBorderHandle))) : ((PdfBorder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBorderHandle)))));
		}
		[Export("setBorder:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorder_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorder_Handle, value.Handle);
			}
			__mt_Border_var = value;
		}
	}

	public virtual NSColor Color
	{
		[Export("color")]
		get
		{
			return (NSColor)(__mt_Color_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle)))));
		}
		[Export("setColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
			__mt_Color_var = value;
		}
	}

	public virtual PdfAction MouseUpAction
	{
		[Export("mouseUpAction")]
		get
		{
			return (PdfAction)(__mt_MouseUpAction_var = ((!IsDirectBinding) ? ((PdfAction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMouseUpActionHandle))) : ((PdfAction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMouseUpActionHandle)))));
		}
		[Export("setMouseUpAction:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMouseUpAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMouseUpAction_Handle, value.Handle);
			}
			__mt_MouseUpAction_var = value;
		}
	}

	public virtual string Contents
	{
		[Export("contents")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle));
		}
		[Export("setContents:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ToolTip
	{
		[Export("toolTip")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolTipHandle));
		}
	}

	public virtual bool HasAppearanceStream
	{
		[Export("hasAppearanceStream")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAppearanceStreamHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAppearanceStreamHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotation()
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
	public PdfAnnotation(NSCoder coder)
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
	public PdfAnnotation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfAnnotation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBounds:")]
	public PdfAnnotation(CGRect bounds)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithBounds_Handle, bounds);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithBounds_Handle, bounds);
		}
	}

	[Export("removeAllAppearanceStreams")]
	public virtual void RemoveAllAppearanceStreams()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAppearanceStreamsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAppearanceStreamsHandle);
		}
	}

	[Export("drawWithBox:")]
	public virtual void Draw(PdfDisplayBox box)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selDrawWithBox_Handle, (int)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selDrawWithBox_Handle, (int)box);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Page_var = null;
			__mt_ModificationDate_var = null;
			__mt_Popup_var = null;
			__mt_Border_var = null;
			__mt_Color_var = null;
			__mt_MouseUpAction_var = null;
		}
	}
}

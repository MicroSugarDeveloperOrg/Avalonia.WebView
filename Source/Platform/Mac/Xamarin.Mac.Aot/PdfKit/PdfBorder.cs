using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFBorder", true)]
public class PdfBorder : NSObject
{
	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	private static readonly IntPtr selHorizontalCornerRadiusHandle = Selector.GetHandle("horizontalCornerRadius");

	private static readonly IntPtr selSetHorizontalCornerRadius_Handle = Selector.GetHandle("setHorizontalCornerRadius:");

	private static readonly IntPtr selVerticalCornerRadiusHandle = Selector.GetHandle("verticalCornerRadius");

	private static readonly IntPtr selSetVerticalCornerRadius_Handle = Selector.GetHandle("setVerticalCornerRadius:");

	private static readonly IntPtr selDashPatternHandle = Selector.GetHandle("dashPattern");

	private static readonly IntPtr selSetDashPattern_Handle = Selector.GetHandle("setDashPattern:");

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFBorder");

	private object __mt_DashPattern_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfBorderStyle Style
	{
		[Export("style")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfBorderStyle)Messaging.int_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (PdfBorderStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
		}
		[Export("setStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetStyle_Handle, (int)value);
			}
		}
	}

	public virtual float LineWidth
	{
		[Export("lineWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	public virtual float HorizontalCornerRadius
	{
		[Export("horizontalCornerRadius")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHorizontalCornerRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHorizontalCornerRadiusHandle);
		}
		[Export("setHorizontalCornerRadius:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHorizontalCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHorizontalCornerRadius_Handle, value);
			}
		}
	}

	public virtual float VerticalCornerRadius
	{
		[Export("verticalCornerRadius")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVerticalCornerRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVerticalCornerRadiusHandle);
		}
		[Export("setVerticalCornerRadius:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVerticalCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVerticalCornerRadius_Handle, value);
			}
		}
	}

	public virtual NSArray DashPattern
	{
		[Export("dashPattern")]
		get
		{
			return (NSArray)(__mt_DashPattern_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDashPatternHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDashPatternHandle)))));
		}
		[Export("setDashPattern:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDashPattern_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDashPattern_Handle, value.Handle);
			}
			__mt_DashPattern_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfBorder()
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
	public PdfBorder(NSCoder coder)
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
	public PdfBorder(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfBorder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawInRect:")]
	public virtual void Draw(CGRect rect)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DashPattern_var = null;
		}
	}
}

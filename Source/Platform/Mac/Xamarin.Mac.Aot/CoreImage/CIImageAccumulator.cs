using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIImageAccumulator", true)]
public class CIImageAccumulator : NSObject
{
	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selImageAccumulatorWithExtentFormat_Handle = Selector.GetHandle("imageAccumulatorWithExtent:format:");

	private static readonly IntPtr selInitWithExtentFormat_Handle = Selector.GetHandle("initWithExtent:format:");

	private static readonly IntPtr selSetImageDirtyRect_Handle = Selector.GetHandle("setImage:dirtyRect:");

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIImageAccumulator");

	private object __mt_Image_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	public virtual long CIImageFormat
	{
		[Export("format")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFormatHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFormatHandle);
		}
	}

	public virtual CIImage Image
	{
		[Export("image")]
		get
		{
			return (CIImage)(__mt_Image_var = ((!IsDirectBinding) ? ((CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
		[Export("setImage:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
			__mt_Image_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIImageAccumulator()
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
	public CIImageAccumulator(NSCoder coder)
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
	public CIImageAccumulator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIImageAccumulator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageAccumulatorWithExtent:format:")]
	public static CIImageAccumulator FromRectangle(CGRect rect, long ciImageFormat)
	{
		return (CIImageAccumulator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect_Int64(class_ptr, selImageAccumulatorWithExtentFormat_Handle, rect, ciImageFormat));
	}

	[Export("initWithExtent:format:")]
	public CIImageAccumulator(CGRect rectangle, long ciImageFormat)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_Int64(base.Handle, selInitWithExtentFormat_Handle, rectangle, ciImageFormat);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_Int64(base.SuperHandle, selInitWithExtentFormat_Handle, rectangle, ciImageFormat);
		}
	}

	[Export("setImage:dirtyRect:")]
	public virtual void SetImageDirty(CIImage image, CGRect dirtyRect)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect(base.Handle, selSetImageDirtyRect_Handle, image.Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selSetImageDirtyRect_Handle, image.Handle, dirtyRect);
		}
	}

	[Export("clear")]
	public virtual void Clear()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Image_var = null;
		}
	}
}

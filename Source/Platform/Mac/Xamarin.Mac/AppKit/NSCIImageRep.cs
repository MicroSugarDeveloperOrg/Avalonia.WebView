using System;
using System.ComponentModel;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCIImageRep", true)]
public class NSCIImageRep : NSImageRep
{
	private static readonly IntPtr selCIImageHandle = Selector.GetHandle("CIImage");

	private static readonly IntPtr selImageRepWithCIImage_Handle = Selector.GetHandle("imageRepWithCIImage:");

	private static readonly IntPtr selInitWithCIImage_Handle = Selector.GetHandle("initWithCIImage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCIImageRep");

	private object __mt_CIImage_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CIImage CIImage
	{
		[Export("CIImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CIImage)(__mt_CIImage_var = ((!IsDirectBinding) ? ((CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCIImageHandle))) : ((CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCIImageHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCIImageRep(NSCoder coder)
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
	public NSCIImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCIImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageRepWithCIImage:")]
	public static NSCIImageRep FromCIImage(CIImage image)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return (NSCIImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithCIImage_Handle, image.Handle));
	}

	[Export("initWithCIImage:")]
	public NSCIImageRep(CIImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCIImage_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCIImage_Handle, image.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CIImage_var = null;
		}
	}
}

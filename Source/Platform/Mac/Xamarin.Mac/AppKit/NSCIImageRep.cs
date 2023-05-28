using System;
using System.ComponentModel;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCIImageRep", true)]
public class NSCIImageRep : NSImageRep
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCIImage = "CIImage";

	private static readonly IntPtr selCIImageHandle = Selector.GetHandle("CIImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepWithCIImage_ = "imageRepWithCIImage:";

	private static readonly IntPtr selImageRepWithCIImage_Handle = Selector.GetHandle("imageRepWithCIImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCIImage_ = "initWithCIImage:";

	private static readonly IntPtr selInitWithCIImage_Handle = Selector.GetHandle("initWithCIImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCIImageRep");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CIImage
	{
		[Export("CIImage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selCIImageHandle));
			}
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCIImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCIImageRep(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCIImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCIImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCIImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCIImageRep(CIImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCIImage_Handle, image.Handle), "initWithCIImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCIImage_Handle, image.Handle), "initWithCIImage:");
		}
	}

	[Export("imageRepWithCIImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCIImageRep FromCIImage(CIImage image)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<NSCIImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithCIImage_Handle, image.Handle));
	}
}

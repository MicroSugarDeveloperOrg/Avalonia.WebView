using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIContext", true)]
public class CIContext : NSObject
{
	private static readonly IntPtr selContextWithCGContextOptions_Handle = Selector.GetHandle("contextWithCGContext:options:");

	private static readonly IntPtr selDrawImageAtPointFromRect_Handle = Selector.GetHandle("drawImage:atPoint:fromRect:");

	private static readonly IntPtr selDrawImageInRectFromRect_Handle = Selector.GetHandle("drawImage:inRect:fromRect:");

	private static readonly IntPtr selCreateCGImageFromRect_Handle = Selector.GetHandle("createCGImage:fromRect:");

	private static readonly IntPtr selCreateCGImageFromRectFormatColorSpace_Handle = Selector.GetHandle("createCGImage:fromRect:format:colorSpace:");

	private static readonly IntPtr selCreateCGLayerWithSizeInfo_Handle = Selector.GetHandle("createCGLayerWithSize:info:");

	private static readonly IntPtr selRenderToBitmapRowBytesBoundsFormatColorSpace_Handle = Selector.GetHandle("render:toBitmap:rowBytes:bounds:format:colorSpace:");

	private static readonly IntPtr selReclaimResourcesHandle = Selector.GetHandle("reclaimResources");

	private static readonly IntPtr selClearCachesHandle = Selector.GetHandle("clearCaches");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIContext");

	private static NSString _OutputColorSpace;

	private static NSString _WorkingColorSpace;

	private static NSString _UseSoftwareRenderer;

	public override IntPtr ClassHandle => class_ptr;

	[Field("kCIContextOutputColorSpace", "Quartz")]
	internal static NSString OutputColorSpace
	{
		get
		{
			if (_OutputColorSpace == null)
			{
				_OutputColorSpace = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextOutputColorSpace");
			}
			return _OutputColorSpace;
		}
	}

	[Field("kCIContextWorkingColorSpace", "Quartz")]
	internal static NSString WorkingColorSpace
	{
		get
		{
			if (_WorkingColorSpace == null)
			{
				_WorkingColorSpace = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextWorkingColorSpace");
			}
			return _WorkingColorSpace;
		}
	}

	[Field("kCIContextUseSoftwareRenderer", "Quartz")]
	internal static NSString UseSoftwareRenderer
	{
		get
		{
			if (_UseSoftwareRenderer == null)
			{
				_UseSoftwareRenderer = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextUseSoftwareRenderer");
			}
			return _UseSoftwareRenderer;
		}
	}

	public static CIContext FromContext(CGContext ctx, CIContextOptions options)
	{
		NSDictionary options2 = options?.ToDictionary();
		return FromContext(ctx, options2);
	}

	public static CIContext FromContext(CGContext ctx)
	{
		return FromContext(ctx, (CIContextOptions)null);
	}

	public CGLayer CreateCGLayer(CGSize size)
	{
		return CreateCGLayer(size, null);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIContext(NSCoder coder)
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
	public CIContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("contextWithCGContext:options:")]
	internal static CIContext FromContext(CGContext ctx, NSDictionary options)
	{
		return (CIContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContextWithCGContextOptions_Handle, ctx.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("drawImage:atPoint:fromRect:")]
	[Obsolete("Deprecated in iOS 6.0. Use DrawImage (CIImage, RectangleF, RectangleF) instead", false)]
	public virtual void DrawImage(CIImage image, CGPoint atPoint, CGRect fromRect)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_CGRect(base.Handle, selDrawImageAtPointFromRect_Handle, image.Handle, atPoint, fromRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_CGRect(base.SuperHandle, selDrawImageAtPointFromRect_Handle, image.Handle, atPoint, fromRect);
		}
	}

	[Export("drawImage:inRect:fromRect:")]
	public virtual void DrawImage(CIImage image, CGRect inRectangle, CGRect fromRectangle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_CGRect(base.Handle, selDrawImageInRectFromRect_Handle, image.Handle, inRectangle, fromRectangle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_CGRect(base.SuperHandle, selDrawImageInRectFromRect_Handle, image.Handle, inRectangle, fromRectangle);
		}
	}

	[Export("createCGImage:fromRect:")]
	public virtual CGImage CreateCGImage(CIImage image, CGRect fromRectangle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		CGImage cGImage = ((!IsDirectBinding) ? new CGImage(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selCreateCGImageFromRect_Handle, image.Handle, fromRectangle)) : new CGImage(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(base.Handle, selCreateCGImageFromRect_Handle, image.Handle, fromRectangle)));
		Messaging.void_objc_msgSend(cGImage.Handle, Selector.GetHandle("release"));
		return cGImage;
	}

	[Export("createCGImage:fromRect:format:colorSpace:")]
	public virtual CGImage CreateCGImage(CIImage image, CGRect fromRect, long ciImageFormat, CGColorSpace colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		CGImage cGImage = ((!IsDirectBinding) ? new CGImage(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect_Int64_IntPtr(base.SuperHandle, selCreateCGImageFromRectFormatColorSpace_Handle, image.Handle, fromRect, ciImageFormat, colorSpace?.Handle ?? IntPtr.Zero)) : new CGImage(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_Int64_IntPtr(base.Handle, selCreateCGImageFromRectFormatColorSpace_Handle, image.Handle, fromRect, ciImageFormat, colorSpace?.Handle ?? IntPtr.Zero)));
		Messaging.void_objc_msgSend(cGImage.Handle, Selector.GetHandle("release"));
		return cGImage;
	}

	[Export("createCGLayerWithSize:info:")]
	internal virtual CGLayer CreateCGLayer(CGSize size, NSDictionary info)
	{
		if (IsDirectBinding)
		{
			return new CGLayer(Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(base.Handle, selCreateCGLayerWithSizeInfo_Handle, size, info?.Handle ?? IntPtr.Zero));
		}
		return new CGLayer(Messaging.IntPtr_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selCreateCGLayerWithSizeInfo_Handle, size, info?.Handle ?? IntPtr.Zero));
	}

	[Export("render:toBitmap:rowBytes:bounds:format:colorSpace:")]
	public virtual void RenderToBitmap(CIImage image, IntPtr bitmapPtr, long bytesPerRow, CGRect bounds, long bitmapFormat, CGColorSpace colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_CGRect_Int64_IntPtr(base.Handle, selRenderToBitmapRowBytesBoundsFormatColorSpace_Handle, image.Handle, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64_CGRect_Int64_IntPtr(base.SuperHandle, selRenderToBitmapRowBytesBoundsFormatColorSpace_Handle, image.Handle, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace.Handle);
		}
	}

	[Export("reclaimResources")]
	public virtual void ReclaimResources()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReclaimResourcesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReclaimResourcesHandle);
		}
	}

	[Export("clearCaches")]
	public virtual void ClearCaches()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearCachesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearCachesHandle);
		}
	}
}

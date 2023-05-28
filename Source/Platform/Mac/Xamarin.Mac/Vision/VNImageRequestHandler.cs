using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace Vision;

[Register("VNImageRequestHandler", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNImageRequestHandler : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_Options_ = "initWithCGImage:options:";

	private static readonly IntPtr selInitWithCGImage_Options_Handle = Selector.GetHandle("initWithCGImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_Orientation_Options_ = "initWithCGImage:orientation:options:";

	private static readonly IntPtr selInitWithCGImage_Orientation_Options_Handle = Selector.GetHandle("initWithCGImage:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCIImage_Options_ = "initWithCIImage:options:";

	private static readonly IntPtr selInitWithCIImage_Options_Handle = Selector.GetHandle("initWithCIImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCIImage_Orientation_Options_ = "initWithCIImage:orientation:options:";

	private static readonly IntPtr selInitWithCIImage_Orientation_Options_Handle = Selector.GetHandle("initWithCIImage:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVPixelBuffer_Options_ = "initWithCVPixelBuffer:options:";

	private static readonly IntPtr selInitWithCVPixelBuffer_Options_Handle = Selector.GetHandle("initWithCVPixelBuffer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVPixelBuffer_Orientation_Options_ = "initWithCVPixelBuffer:orientation:options:";

	private static readonly IntPtr selInitWithCVPixelBuffer_Orientation_Options_Handle = Selector.GetHandle("initWithCVPixelBuffer:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_ = "initWithData:options:";

	private static readonly IntPtr selInitWithData_Options_Handle = Selector.GetHandle("initWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Orientation_Options_ = "initWithData:orientation:options:";

	private static readonly IntPtr selInitWithData_Orientation_Options_Handle = Selector.GetHandle("initWithData:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Orientation_Options_ = "initWithURL:orientation:options:";

	private static readonly IntPtr selInitWithURL_Orientation_Options_Handle = Selector.GetHandle("initWithURL:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_Error_ = "performRequests:error:";

	private static readonly IntPtr selPerformRequests_Error_Handle = Selector.GetHandle("performRequests:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNImageRequestHandler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNImageRequestHandler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNImageRequestHandler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCVPixelBuffer:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CVPixelBuffer pixelBuffer, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCVPixelBuffer_Options_Handle, pixelBuffer.Handle, options.Handle), "initWithCVPixelBuffer:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCVPixelBuffer_Options_Handle, pixelBuffer.Handle, options.Handle), "initWithCVPixelBuffer:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CVPixelBuffer pixelBuffer, VNImageOptions imageOptions)
		: this(pixelBuffer, imageOptions.GetDictionary())
	{
	}

	[Export("initWithCVPixelBuffer:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithCVPixelBuffer_Orientation_Options_Handle, pixelBuffer.Handle, (int)orientation, options.Handle), "initWithCVPixelBuffer:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithCVPixelBuffer_Orientation_Options_Handle, pixelBuffer.Handle, (int)orientation, options.Handle), "initWithCVPixelBuffer:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, VNImageOptions imageOptions)
		: this(pixelBuffer, orientation, imageOptions.GetDictionary())
	{
	}

	[Export("initWithCGImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CGImage image, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCGImage_Options_Handle, image.Handle, options.Handle), "initWithCGImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCGImage_Options_Handle, image.Handle, options.Handle), "initWithCGImage:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CGImage image, VNImageOptions imageOptions)
		: this(image, imageOptions.GetDictionary())
	{
	}

	[Export("initWithCGImage:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CGImage image, CGImagePropertyOrientation orientation, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithCGImage_Orientation_Options_Handle, image.Handle, (int)orientation, options.Handle), "initWithCGImage:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithCGImage_Orientation_Options_Handle, image.Handle, (int)orientation, options.Handle), "initWithCGImage:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CGImage image, CGImagePropertyOrientation orientation, VNImageOptions imageOptions)
		: this(image, orientation, imageOptions.GetDictionary())
	{
	}

	[Export("initWithCIImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CIImage image, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCIImage_Options_Handle, image.Handle, options.Handle), "initWithCIImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCIImage_Options_Handle, image.Handle, options.Handle), "initWithCIImage:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CIImage image, VNImageOptions imageOptions)
		: this(image, imageOptions.GetDictionary())
	{
	}

	[Export("initWithCIImage:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CIImage image, CGImagePropertyOrientation orientation, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithCIImage_Orientation_Options_Handle, image.Handle, (int)orientation, options.Handle), "initWithCIImage:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithCIImage_Orientation_Options_Handle, image.Handle, (int)orientation, options.Handle), "initWithCIImage:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(CIImage image, CGImagePropertyOrientation orientation, VNImageOptions imageOptions)
		: this(image, orientation, imageOptions.GetDictionary())
	{
	}

	[Export("initWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSUrl imageUrl, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, imageUrl.Handle, options.Handle), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, imageUrl.Handle, options.Handle), "initWithURL:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSUrl imageUrl, VNImageOptions imageOptions)
		: this(imageUrl, imageOptions.GetDictionary())
	{
	}

	[Export("initWithURL:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSUrl imageUrl, CGImagePropertyOrientation orientation, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithURL_Orientation_Options_Handle, imageUrl.Handle, (int)orientation, options.Handle), "initWithURL:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithURL_Orientation_Options_Handle, imageUrl.Handle, (int)orientation, options.Handle), "initWithURL:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSUrl imageUrl, CGImagePropertyOrientation orientation, VNImageOptions imageOptions)
		: this(imageUrl, orientation, imageOptions.GetDictionary())
	{
	}

	[Export("initWithData:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSData imageData, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Options_Handle, imageData.Handle, options.Handle), "initWithData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Options_Handle, imageData.Handle, options.Handle), "initWithData:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSData imageData, VNImageOptions imageOptions)
		: this(imageData, imageOptions.GetDictionary())
	{
	}

	[Export("initWithData:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSData imageData, CGImagePropertyOrientation orientation, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithData_Orientation_Options_Handle, imageData.Handle, (int)orientation, options.Handle), "initWithData:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithData_Orientation_Options_Handle, imageData.Handle, (int)orientation, options.Handle), "initWithData:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRequestHandler(NSData imageData, CGImagePropertyOrientation orientation, VNImageOptions imageOptions)
		: this(imageData, orientation, imageOptions.GetDictionary())
	{
	}

	[Export("performRequests:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

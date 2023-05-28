using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace Vision;

[Register("VNSequenceRequestHandler", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNSequenceRequestHandler : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCGImage_Error_ = "performRequests:onCGImage:error:";

	private static readonly IntPtr selPerformRequests_OnCGImage_Error_Handle = Selector.GetHandle("performRequests:onCGImage:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCGImage_Orientation_Error_ = "performRequests:onCGImage:orientation:error:";

	private static readonly IntPtr selPerformRequests_OnCGImage_Orientation_Error_Handle = Selector.GetHandle("performRequests:onCGImage:orientation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCIImage_Error_ = "performRequests:onCIImage:error:";

	private static readonly IntPtr selPerformRequests_OnCIImage_Error_Handle = Selector.GetHandle("performRequests:onCIImage:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCIImage_Orientation_Error_ = "performRequests:onCIImage:orientation:error:";

	private static readonly IntPtr selPerformRequests_OnCIImage_Orientation_Error_Handle = Selector.GetHandle("performRequests:onCIImage:orientation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCVPixelBuffer_Error_ = "performRequests:onCVPixelBuffer:error:";

	private static readonly IntPtr selPerformRequests_OnCVPixelBuffer_Error_Handle = Selector.GetHandle("performRequests:onCVPixelBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnCVPixelBuffer_Orientation_Error_ = "performRequests:onCVPixelBuffer:orientation:error:";

	private static readonly IntPtr selPerformRequests_OnCVPixelBuffer_Orientation_Error_Handle = Selector.GetHandle("performRequests:onCVPixelBuffer:orientation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnImageData_Error_ = "performRequests:onImageData:error:";

	private static readonly IntPtr selPerformRequests_OnImageData_Error_Handle = Selector.GetHandle("performRequests:onImageData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnImageData_Orientation_Error_ = "performRequests:onImageData:orientation:error:";

	private static readonly IntPtr selPerformRequests_OnImageData_Orientation_Error_Handle = Selector.GetHandle("performRequests:onImageData:orientation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnImageURL_Error_ = "performRequests:onImageURL:error:";

	private static readonly IntPtr selPerformRequests_OnImageURL_Error_Handle = Selector.GetHandle("performRequests:onImageURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests_OnImageURL_Orientation_Error_ = "performRequests:onImageURL:orientation:error:";

	private static readonly IntPtr selPerformRequests_OnImageURL_Orientation_Error_Handle = Selector.GetHandle("performRequests:onImageURL:orientation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNSequenceRequestHandler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNSequenceRequestHandler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNSequenceRequestHandler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNSequenceRequestHandler()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("performRequests:onCVPixelBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CVPixelBuffer pixelBuffer, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCVPixelBuffer_Error_Handle, nSArray.Handle, pixelBuffer.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_OnCVPixelBuffer_Error_Handle, nSArray.Handle, pixelBuffer.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onCVPixelBuffer:orientation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCVPixelBuffer_Orientation_Error_Handle, nSArray.Handle, pixelBuffer.Handle, (int)orientation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selPerformRequests_OnCVPixelBuffer_Orientation_Error_Handle, nSArray.Handle, pixelBuffer.Handle, (int)orientation, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onCGImage:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CGImage image, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCGImage_Error_Handle, nSArray.Handle, image.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_OnCGImage_Error_Handle, nSArray.Handle, image.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onCGImage:orientation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CGImage image, CGImagePropertyOrientation orientation, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCGImage_Orientation_Error_Handle, nSArray.Handle, image.Handle, (int)orientation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selPerformRequests_OnCGImage_Orientation_Error_Handle, nSArray.Handle, image.Handle, (int)orientation, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onCIImage:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CIImage image, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCIImage_Error_Handle, nSArray.Handle, image.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_OnCIImage_Error_Handle, nSArray.Handle, image.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onCIImage:orientation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, CIImage image, CGImagePropertyOrientation orientation, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selPerformRequests_OnCIImage_Orientation_Error_Handle, nSArray.Handle, image.Handle, (int)orientation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selPerformRequests_OnCIImage_Orientation_Error_Handle, nSArray.Handle, image.Handle, (int)orientation, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onImageURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, NSUrl imageUrl, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_OnImageURL_Error_Handle, nSArray.Handle, imageUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_OnImageURL_Error_Handle, nSArray.Handle, imageUrl.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onImageURL:orientation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, NSUrl imageUrl, CGImagePropertyOrientation orientation, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selPerformRequests_OnImageURL_Orientation_Error_Handle, nSArray.Handle, imageUrl.Handle, (int)orientation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selPerformRequests_OnImageURL_Orientation_Error_Handle, nSArray.Handle, imageUrl.Handle, (int)orientation, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onImageData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, NSData imageData, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPerformRequests_OnImageData_Error_Handle, nSArray.Handle, imageData.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPerformRequests_OnImageData_Error_Handle, nSArray.Handle, imageData.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performRequests:onImageData:orientation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Perform(VNRequest[] requests, NSData imageData, CGImagePropertyOrientation orientation, out NSError error)
	{
		if (requests == null)
		{
			throw new ArgumentNullException("requests");
		}
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(requests);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selPerformRequests_OnImageData_Orientation_Error_Handle, nSArray.Handle, imageData.Handle, (int)orientation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selPerformRequests_OnImageData_Orientation_Error_Handle, nSArray.Handle, imageData.Handle, (int)orientation, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace Vision;

[Register("VNImageRegistrationRequest", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public abstract class VNImageRegistrationRequest : VNTargetedImageRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCGImage_Options_ = "initWithTargetedCGImage:options:";

	private static readonly IntPtr selInitWithTargetedCGImage_Options_Handle = Selector.GetHandle("initWithTargetedCGImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCGImage_Options_CompletionHandler_ = "initWithTargetedCGImage:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCGImage_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCGImage:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCGImage_Orientation_Options_ = "initWithTargetedCGImage:orientation:options:";

	private static readonly IntPtr selInitWithTargetedCGImage_Orientation_Options_Handle = Selector.GetHandle("initWithTargetedCGImage:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_ = "initWithTargetedCGImage:orientation:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCGImage:orientation:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCIImage_Options_ = "initWithTargetedCIImage:options:";

	private static readonly IntPtr selInitWithTargetedCIImage_Options_Handle = Selector.GetHandle("initWithTargetedCIImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCIImage_Options_CompletionHandler_ = "initWithTargetedCIImage:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCIImage_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCIImage:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCIImage_Orientation_Options_ = "initWithTargetedCIImage:orientation:options:";

	private static readonly IntPtr selInitWithTargetedCIImage_Orientation_Options_Handle = Selector.GetHandle("initWithTargetedCIImage:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_ = "initWithTargetedCIImage:orientation:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCIImage:orientation:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCVPixelBuffer_Options_ = "initWithTargetedCVPixelBuffer:options:";

	private static readonly IntPtr selInitWithTargetedCVPixelBuffer_Options_Handle = Selector.GetHandle("initWithTargetedCVPixelBuffer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_ = "initWithTargetedCVPixelBuffer:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCVPixelBuffer:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCVPixelBuffer_Orientation_Options_ = "initWithTargetedCVPixelBuffer:orientation:options:";

	private static readonly IntPtr selInitWithTargetedCVPixelBuffer_Orientation_Options_Handle = Selector.GetHandle("initWithTargetedCVPixelBuffer:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_ = "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageData_Options_ = "initWithTargetedImageData:options:";

	private static readonly IntPtr selInitWithTargetedImageData_Options_Handle = Selector.GetHandle("initWithTargetedImageData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageData_Options_CompletionHandler_ = "initWithTargetedImageData:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedImageData_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedImageData:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageData_Orientation_Options_ = "initWithTargetedImageData:orientation:options:";

	private static readonly IntPtr selInitWithTargetedImageData_Orientation_Options_Handle = Selector.GetHandle("initWithTargetedImageData:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageData_Orientation_Options_CompletionHandler_ = "initWithTargetedImageData:orientation:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedImageData_Orientation_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedImageData:orientation:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageURL_Options_ = "initWithTargetedImageURL:options:";

	private static readonly IntPtr selInitWithTargetedImageURL_Options_Handle = Selector.GetHandle("initWithTargetedImageURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageURL_Options_CompletionHandler_ = "initWithTargetedImageURL:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedImageURL_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedImageURL:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageURL_Orientation_Options_ = "initWithTargetedImageURL:orientation:options:";

	private static readonly IntPtr selInitWithTargetedImageURL_Orientation_Options_Handle = Selector.GetHandle("initWithTargetedImageURL:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_ = "initWithTargetedImageURL:orientation:options:completionHandler:";

	private static readonly IntPtr selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_Handle = Selector.GetHandle("initWithTargetedImageURL:orientation:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNImageRegistrationRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNImageRegistrationRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNImageRegistrationRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTargetedCVPixelBuffer:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTargetedCVPixelBuffer_Options_Handle, pixelBuffer.Handle, optionsDict.Handle), "initWithTargetedCVPixelBuffer:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCVPixelBuffer_Options_Handle, pixelBuffer.Handle, optionsDict.Handle), "initWithTargetedCVPixelBuffer:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, VNImageOptions options)
		: this(pixelBuffer, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCVPixelBuffer:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_Handle, pixelBuffer.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCVPixelBuffer:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCVPixelBuffer_Options_CompletionHandler_Handle, pixelBuffer.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCVPixelBuffer:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(pixelBuffer, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedCVPixelBuffer:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithTargetedCVPixelBuffer_Orientation_Options_Handle, pixelBuffer.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCVPixelBuffer:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithTargetedCVPixelBuffer_Orientation_Options_Handle, pixelBuffer.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCVPixelBuffer:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, VNImageOptions options)
		: this(pixelBuffer, orientation, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCVPixelBuffer:orientation:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(base.Handle, selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_Handle, pixelBuffer.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCVPixelBuffer_Orientation_Options_CompletionHandler_Handle, pixelBuffer.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCVPixelBuffer:orientation:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CVPixelBuffer pixelBuffer, CGImagePropertyOrientation orientation, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(pixelBuffer, orientation, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedCGImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTargetedCGImage_Options_Handle, cgImage.Handle, optionsDict.Handle), "initWithTargetedCGImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCGImage_Options_Handle, cgImage.Handle, optionsDict.Handle), "initWithTargetedCGImage:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, VNImageOptions options)
		: this(cgImage, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCGImage:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CGImage cgImage, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetedCGImage_Options_CompletionHandler_Handle, cgImage.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCGImage:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCGImage_Options_CompletionHandler_Handle, cgImage.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCGImage:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(cgImage, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedCGImage:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, CGImagePropertyOrientation orientation, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithTargetedCGImage_Orientation_Options_Handle, cgImage.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCGImage:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithTargetedCGImage_Orientation_Options_Handle, cgImage.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCGImage:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, CGImagePropertyOrientation orientation, VNImageOptions options)
		: this(cgImage, orientation, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCGImage:orientation:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CGImage cgImage, CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(base.Handle, selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_Handle, cgImage.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCGImage:orientation:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCGImage_Orientation_Options_CompletionHandler_Handle, cgImage.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCGImage:orientation:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CGImage cgImage, CGImagePropertyOrientation orientation, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(cgImage, orientation, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedCIImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTargetedCIImage_Options_Handle, ciImage.Handle, optionsDict.Handle), "initWithTargetedCIImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCIImage_Options_Handle, ciImage.Handle, optionsDict.Handle), "initWithTargetedCIImage:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, VNImageOptions options)
		: this(ciImage, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCIImage:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CIImage ciImage, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetedCIImage_Options_CompletionHandler_Handle, ciImage.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCIImage:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCIImage_Options_CompletionHandler_Handle, ciImage.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCIImage:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(ciImage, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedCIImage:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, CGImagePropertyOrientation orientation, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithTargetedCIImage_Orientation_Options_Handle, ciImage.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCIImage:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithTargetedCIImage_Orientation_Options_Handle, ciImage.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedCIImage:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, CGImagePropertyOrientation orientation, VNImageOptions options)
		: this(ciImage, orientation, options.GetDictionary())
	{
	}

	[Export("initWithTargetedCIImage:orientation:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(CIImage ciImage, CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(base.Handle, selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_Handle, ciImage.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCIImage:orientation:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedCIImage_Orientation_Options_CompletionHandler_Handle, ciImage.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedCIImage:orientation:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(CIImage ciImage, CGImagePropertyOrientation orientation, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(ciImage, orientation, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedImageURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageURL_Options_Handle, imageUrl.Handle, optionsDict.Handle), "initWithTargetedImageURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageURL_Options_Handle, imageUrl.Handle, optionsDict.Handle), "initWithTargetedImageURL:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, VNImageOptions options)
		: this(imageUrl, options.GetDictionary())
	{
	}

	[Export("initWithTargetedImageURL:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(NSUrl imageUrl, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageURL_Options_CompletionHandler_Handle, imageUrl.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageURL:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageURL_Options_CompletionHandler_Handle, imageUrl.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageURL:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(imageUrl, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedImageURL:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, CGImagePropertyOrientation orientation, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithTargetedImageURL_Orientation_Options_Handle, imageUrl.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedImageURL:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithTargetedImageURL_Orientation_Options_Handle, imageUrl.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedImageURL:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, CGImagePropertyOrientation orientation, VNImageOptions options)
		: this(imageUrl, orientation, options.GetDictionary())
	{
	}

	[Export("initWithTargetedImageURL:orientation:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(NSUrl imageUrl, CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (imageUrl == null)
		{
			throw new ArgumentNullException("imageUrl");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_Handle, imageUrl.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageURL:orientation:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageURL_Orientation_Options_CompletionHandler_Handle, imageUrl.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageURL:orientation:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSUrl imageUrl, CGImagePropertyOrientation orientation, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(imageUrl, orientation, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedImageData:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageData_Options_Handle, imageData.Handle, optionsDict.Handle), "initWithTargetedImageData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageData_Options_Handle, imageData.Handle, optionsDict.Handle), "initWithTargetedImageData:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, VNImageOptions options)
		: this(imageData, options.GetDictionary())
	{
	}

	[Export("initWithTargetedImageData:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(NSData imageData, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageData_Options_CompletionHandler_Handle, imageData.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageData:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageData_Options_CompletionHandler_Handle, imageData.Handle, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageData:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(imageData, options.GetDictionary(), completionHandler)
	{
	}

	[Export("initWithTargetedImageData:orientation:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, CGImagePropertyOrientation orientation, NSDictionary optionsDict)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selInitWithTargetedImageData_Orientation_Options_Handle, imageData.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedImageData:orientation:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selInitWithTargetedImageData_Orientation_Options_Handle, imageData.Handle, (int)orientation, optionsDict.Handle), "initWithTargetedImageData:orientation:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, CGImagePropertyOrientation orientation, VNImageOptions options)
		: this(imageData, orientation, options.GetDictionary())
	{
	}

	[Export("initWithTargetedImageData:orientation:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageRegistrationRequest(NSData imageData, CGImagePropertyOrientation orientation, NSDictionary optionsDict, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (imageData == null)
		{
			throw new ArgumentNullException("imageData");
		}
		if (optionsDict == null)
		{
			throw new ArgumentNullException("optionsDict");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(base.Handle, selInitWithTargetedImageData_Orientation_Options_CompletionHandler_Handle, imageData.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageData:orientation:options:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr(base.SuperHandle, selInitWithTargetedImageData_Orientation_Options_CompletionHandler_Handle, imageData.Handle, (int)orientation, optionsDict.Handle, (IntPtr)ptr), "initWithTargetedImageData:orientation:options:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNImageRegistrationRequest(NSData imageData, CGImagePropertyOrientation orientation, VNImageOptions options, [BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler completionHandler)
		: this(imageData, orientation, options.GetDictionary(), completionHandler)
	{
	}
}

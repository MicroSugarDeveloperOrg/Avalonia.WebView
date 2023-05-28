using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using IOSurface;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

[Register("CIContext", true)]
public class CIContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearCaches = "clearCaches";

	private static readonly IntPtr selClearCachesHandle = Selector.GetHandle("clearCaches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContext = "context";

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextForOfflineGPUAtIndex_ = "contextForOfflineGPUAtIndex:";

	private static readonly IntPtr selContextForOfflineGPUAtIndex_Handle = Selector.GetHandle("contextForOfflineGPUAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithCGContext_Options_ = "contextWithCGContext:options:";

	private static readonly IntPtr selContextWithCGContext_Options_Handle = Selector.GetHandle("contextWithCGContext:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithMTLCommandQueue_ = "contextWithMTLCommandQueue:";

	private static readonly IntPtr selContextWithMTLCommandQueue_Handle = Selector.GetHandle("contextWithMTLCommandQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithMTLCommandQueue_Options_ = "contextWithMTLCommandQueue:options:";

	private static readonly IntPtr selContextWithMTLCommandQueue_Options_Handle = Selector.GetHandle("contextWithMTLCommandQueue:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithMTLDevice_ = "contextWithMTLDevice:";

	private static readonly IntPtr selContextWithMTLDevice_Handle = Selector.GetHandle("contextWithMTLDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithMTLDevice_Options_ = "contextWithMTLDevice:options:";

	private static readonly IntPtr selContextWithMTLDevice_Options_Handle = Selector.GetHandle("contextWithMTLDevice:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextWithOptions_ = "contextWithOptions:";

	private static readonly IntPtr selContextWithOptions_Handle = Selector.GetHandle("contextWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCGImage_FromRect_ = "createCGImage:fromRect:";

	private static readonly IntPtr selCreateCGImage_FromRect_Handle = Selector.GetHandle("createCGImage:fromRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCGImage_FromRect_Format_ColorSpace_ = "createCGImage:fromRect:format:colorSpace:";

	private static readonly IntPtr selCreateCGImage_FromRect_Format_ColorSpace_Handle = Selector.GetHandle("createCGImage:fromRect:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCGImage_FromRect_Format_ColorSpace_Deferred_ = "createCGImage:fromRect:format:colorSpace:deferred:";

	private static readonly IntPtr selCreateCGImage_FromRect_Format_ColorSpace_Deferred_Handle = Selector.GetHandle("createCGImage:fromRect:format:colorSpace:deferred:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCGLayerWithSize_Info_ = "createCGLayerWithSize:info:";

	private static readonly IntPtr selCreateCGLayerWithSize_Info_Handle = Selector.GetHandle("createCGLayerWithSize:info:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawImage_AtPoint_FromRect_ = "drawImage:atPoint:fromRect:";

	private static readonly IntPtr selDrawImage_AtPoint_FromRect_Handle = Selector.GetHandle("drawImage:atPoint:fromRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawImage_InRect_FromRect_ = "drawImage:inRect:fromRect:";

	private static readonly IntPtr selDrawImage_InRect_FromRect_Handle = Selector.GetHandle("drawImage:inRect:fromRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOptions_ = "initWithOptions:";

	private static readonly IntPtr selInitWithOptions_Handle = Selector.GetHandle("initWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOfflineGPUCount = "offlineGPUCount";

	private static readonly IntPtr selOfflineGPUCountHandle = Selector.GetHandle("offlineGPUCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReclaimResources = "reclaimResources";

	private static readonly IntPtr selReclaimResourcesHandle = Selector.GetHandle("reclaimResources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_ = "render:toBitmap:rowBytes:bounds:format:colorSpace:";

	private static readonly IntPtr selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_Handle = Selector.GetHandle("render:toBitmap:rowBytes:bounds:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender_ToCVPixelBuffer_ = "render:toCVPixelBuffer:";

	private static readonly IntPtr selRender_ToCVPixelBuffer_Handle = Selector.GetHandle("render:toCVPixelBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender_ToCVPixelBuffer_Bounds_ColorSpace_ = "render:toCVPixelBuffer:bounds:colorSpace:";

	private static readonly IntPtr selRender_ToCVPixelBuffer_Bounds_ColorSpace_Handle = Selector.GetHandle("render:toCVPixelBuffer:bounds:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender_ToIOSurface_Bounds_ColorSpace_ = "render:toIOSurface:bounds:colorSpace:";

	private static readonly IntPtr selRender_ToIOSurface_Bounds_ColorSpace_Handle = Selector.GetHandle("render:toIOSurface:bounds:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_ = "render:toMTLTexture:commandBuffer:bounds:colorSpace:";

	private static readonly IntPtr selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_Handle = Selector.GetHandle("render:toMTLTexture:commandBuffer:bounds:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorkingColorSpace = "workingColorSpace";

	private static readonly IntPtr selWorkingColorSpaceHandle = Selector.GetHandle("workingColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorkingFormat = "workingFormat";

	private static readonly IntPtr selWorkingFormatHandle = Selector.GetHandle("workingFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowLowPower;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CacheIntermediates;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HighQualityDownsample;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputPremultiplied;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PriorityRequestLow;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UseSoftwareRenderer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WorkingFormatField;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __WorkingColorSpace;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int OfflineGPUCount
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("offlineGPUCount")]
		get
		{
			return Messaging.int_objc_msgSend(class_ptr, selOfflineGPUCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CGColorSpace WorkingColorSpace
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("workingColorSpace")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWorkingColorSpaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selWorkingColorSpaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual CIFormat WorkingFormat
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("workingFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CIFormat)Messaging.int_objc_msgSend(base.Handle, selWorkingFormatHandle);
			}
			return (CIFormat)Messaging.int_objc_msgSendSuper(base.SuperHandle, selWorkingFormatHandle);
		}
	}

	[Field("kCIContextAllowLowPower", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	internal static NSString AllowLowPower
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowLowPower == null)
			{
				_AllowLowPower = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIContextAllowLowPower");
			}
			return _AllowLowPower;
		}
	}

	[Field("kCIContextCacheIntermediates", "Quartz")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal static NSString CacheIntermediates
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CacheIntermediates == null)
			{
				_CacheIntermediates = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextCacheIntermediates");
			}
			return _CacheIntermediates;
		}
	}

	[Field("kCIContextHighQualityDownsample", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	internal static NSString HighQualityDownsample
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_HighQualityDownsample == null)
			{
				_HighQualityDownsample = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextHighQualityDownsample");
			}
			return _HighQualityDownsample;
		}
	}

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

	[Field("kCIContextOutputPremultiplied", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static NSString OutputPremultiplied
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OutputPremultiplied == null)
			{
				_OutputPremultiplied = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextOutputPremultiplied");
			}
			return _OutputPremultiplied;
		}
	}

	[Field("kCIContextPriorityRequestLow", "Quartz")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	internal static NSString PriorityRequestLow
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_PriorityRequestLow == null)
			{
				_PriorityRequestLow = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextPriorityRequestLow");
			}
			return _PriorityRequestLow;
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

	[Field("kCIContextWorkingFormat", "Quartz")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	internal static NSString WorkingFormatField
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_WorkingFormatField == null)
			{
				_WorkingFormatField = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextWorkingFormat");
			}
			return _WorkingFormatField;
		}
	}

	[Field("kCIContextWorkingColorSpace", "Quartz")]
	internal static NSString _WorkingColorSpace
	{
		get
		{
			if (__WorkingColorSpace == null)
			{
				__WorkingColorSpace = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIContextWorkingColorSpace");
			}
			return __WorkingColorSpace;
		}
	}

	[iOS(8, 0)]
	public CIContext(CIContextOptions options)
		: this(options?.Dictionary)
	{
	}

	public static CIContext FromContext(CGContext ctx, CIContextOptions options)
	{
		return FromContext(ctx, options?.Dictionary);
	}

	public static CIContext FromContext(CGContext ctx)
	{
		return FromContext(ctx, (CIContextOptions)null);
	}

	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public CGLayer CreateCGLayer(CGSize size)
	{
		return CreateCGLayer(size, null);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIContext()
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

	[Export("initWithOptions:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal CIContext(NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOptions_Handle, options?.Handle ?? IntPtr.Zero), "initWithOptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOptions_Handle, options?.Handle ?? IntPtr.Zero), "initWithOptions:");
		}
	}

	[Export("clearCaches")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearCaches()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearCachesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearCachesHandle);
		}
	}

	[Export("context")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext Create()
	{
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selContextHandle));
	}

	[Export("contextWithMTLCommandQueue:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext Create(IMTLCommandQueue commandQueue)
	{
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContextWithMTLCommandQueue_Handle, commandQueue.Handle));
	}

	[Export("contextWithMTLCommandQueue:options:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext Create(IMTLCommandQueue commandQueue, NSDictionary<NSString, NSObject>? options)
	{
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContextWithMTLCommandQueue_Options_Handle, commandQueue.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("createCGImage:fromRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CGImage? CreateCGImage(CIImage image, CGRect fromRectangle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selCreateCGImage_FromRect_Handle, image.Handle, fromRectangle) : Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(base.Handle, selCreateCGImage_FromRect_Handle, image.Handle, fromRectangle));
		CGImage result = null;
		if (intPtr != IntPtr.Zero)
		{
			result = new CGImage(intPtr);
			Messaging.void_objc_msgSend(intPtr, Selector.GetHandle("release"));
		}
		return result;
	}

	[Export("createCGImage:fromRect:format:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CGImage? CreateCGImage(CIImage image, CGRect fromRect, int ciImageFormat, CGColorSpace? colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect_int_IntPtr(base.SuperHandle, selCreateCGImage_FromRect_Format_ColorSpace_Handle, image.Handle, fromRect, ciImageFormat, colorSpace?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_int_IntPtr(base.Handle, selCreateCGImage_FromRect_Format_ColorSpace_Handle, image.Handle, fromRect, ciImageFormat, colorSpace?.Handle ?? IntPtr.Zero));
		CGImage result = null;
		if (intPtr != IntPtr.Zero)
		{
			result = new CGImage(intPtr);
			Messaging.void_objc_msgSend(intPtr, Selector.GetHandle("release"));
		}
		return result;
	}

	[Export("createCGImage:fromRect:format:colorSpace:deferred:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CGImage? CreateCGImage(CIImage image, CGRect fromRect, CIFormat format, CGColorSpace? colorSpace, bool deferred)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect_int_IntPtr_bool(base.SuperHandle, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_Handle, image.Handle, fromRect, (int)format, colorSpace?.Handle ?? IntPtr.Zero, deferred) : Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_int_IntPtr_bool(base.Handle, selCreateCGImage_FromRect_Format_ColorSpace_Deferred_Handle, image.Handle, fromRect, (int)format, colorSpace?.Handle ?? IntPtr.Zero, deferred));
		CGImage result = null;
		if (intPtr != IntPtr.Zero)
		{
			result = new CGImage(intPtr);
			Messaging.void_objc_msgSend(intPtr, Selector.GetHandle("release"));
		}
		return result;
	}

	[Export("createCGLayerWithSize:info:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual CGLayer CreateCGLayer(CGSize size, NSDictionary? info)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selCreateCGLayerWithSize_Info_Handle, size, info?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(base.Handle, selCreateCGLayerWithSize_Info_Handle, size, info?.Handle ?? IntPtr.Zero));
		return (intPtr == IntPtr.Zero) ? null : new CGLayer(intPtr);
	}

	[Export("drawImage:atPoint:fromRect:")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'DrawImage (image, CGRect, CGRect)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawImage(CIImage image, CGPoint atPoint, CGRect fromRect)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_CGRect(base.Handle, selDrawImage_AtPoint_FromRect_Handle, image.Handle, atPoint, fromRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_CGRect(base.SuperHandle, selDrawImage_AtPoint_FromRect_Handle, image.Handle, atPoint, fromRect);
		}
	}

	[Export("drawImage:inRect:fromRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawImage(CIImage image, CGRect inRectangle, CGRect fromRectangle)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_CGRect(base.Handle, selDrawImage_InRect_FromRect_Handle, image.Handle, inRectangle, fromRectangle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_CGRect(base.SuperHandle, selDrawImage_InRect_FromRect_Handle, image.Handle, inRectangle, fromRectangle);
		}
	}

	[Export("contextWithCGContext:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIContext FromContext(CGContext ctx, NSDictionary? options)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContextWithCGContext_Options_Handle, ctx.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("contextWithMTLDevice:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext FromMetalDevice(IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContextWithMTLDevice_Handle, device.Handle));
	}

	[Export("contextWithMTLDevice:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIContext FromMetalDevice(IMTLDevice device, NSDictionary? options)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContextWithMTLDevice_Options_Handle, device.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("contextWithMTLDevice:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext FromMetalDevice(IMTLDevice device, NSDictionary<NSString, NSObject>? options)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContextWithMTLDevice_Options_Handle, device.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("contextForOfflineGPUAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIContext FromOfflineGpu(int gpuIndex)
	{
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selContextForOfflineGPUAtIndex_Handle, gpuIndex));
	}

	[Export("contextWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIContext FromOptions(NSDictionary? dictionary)
	{
		return Runtime.GetNSObject<CIContext>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContextWithOptions_Handle, dictionary?.Handle ?? IntPtr.Zero));
	}

	[Export("reclaimResources")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReclaimResources()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReclaimResourcesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReclaimResourcesHandle);
		}
	}

	[Export("render:toCVPixelBuffer:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CIImage image, CVPixelBuffer buffer)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRender_ToCVPixelBuffer_Handle, image.Handle, buffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRender_ToCVPixelBuffer_Handle, image.Handle, buffer.Handle);
		}
	}

	[Export("render:toCVPixelBuffer:bounds:colorSpace:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CIImage image, CVPixelBuffer buffer, CGRect rectangle, CGColorSpace? cs)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr(base.Handle, selRender_ToCVPixelBuffer_Bounds_ColorSpace_Handle, image.Handle, buffer.Handle, rectangle, cs?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr(base.SuperHandle, selRender_ToCVPixelBuffer_Bounds_ColorSpace_Handle, image.Handle, buffer.Handle, rectangle, cs?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("render:toIOSurface:bounds:colorSpace:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CIImage image, global::IOSurface.IOSurface surface, CGRect bounds, CGColorSpace? colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr(base.Handle, selRender_ToIOSurface_Bounds_ColorSpace_Handle, image.Handle, surface.Handle, bounds, colorSpace?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr(base.SuperHandle, selRender_ToIOSurface_Bounds_ColorSpace_Handle, image.Handle, surface.Handle, bounds, colorSpace?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("render:toMTLTexture:commandBuffer:bounds:colorSpace:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CIImage image, IMTLTexture texture, IMTLCommandBuffer? commandBuffer, CGRect bounds, CGColorSpace? colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect_IntPtr(base.Handle, selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_Handle, image.Handle, texture.Handle, commandBuffer?.Handle ?? IntPtr.Zero, bounds, colorSpace?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGRect_IntPtr(base.SuperHandle, selRender_ToMTLTexture_CommandBuffer_Bounds_ColorSpace_Handle, image.Handle, texture.Handle, commandBuffer?.Handle ?? IntPtr.Zero, bounds, colorSpace?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("render:toBitmap:rowBytes:bounds:format:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenderToBitmap(CIImage image, IntPtr bitmapPtr, nint bytesPerRow, CGRect bounds, int bitmapFormat, CGColorSpace? colorSpace)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nint_CGRect_int_IntPtr(base.Handle, selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_Handle, image.Handle, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nint_CGRect_int_IntPtr(base.SuperHandle, selRender_ToBitmap_RowBytes_Bounds_Format_ColorSpace_Handle, image.Handle, bitmapPtr, bytesPerRow, bounds, bitmapFormat, colorSpace?.Handle ?? IntPtr.Zero);
		}
	}
}

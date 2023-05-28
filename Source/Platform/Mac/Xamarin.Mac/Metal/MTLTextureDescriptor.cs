using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLTextureDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLTextureDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowGPUOptimizedContents = "allowGPUOptimizedContents";

	private static readonly IntPtr selAllowGPUOptimizedContentsHandle = Selector.GetHandle("allowGPUOptimizedContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayLength = "arrayLength";

	private static readonly IntPtr selArrayLengthHandle = Selector.GetHandle("arrayLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCpuCacheMode = "cpuCacheMode";

	private static readonly IntPtr selCpuCacheModeHandle = Selector.GetHandle("cpuCacheMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepth = "depth";

	private static readonly IntPtr selDepthHandle = Selector.GetHandle("depth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHazardTrackingMode = "hazardTrackingMode";

	private static readonly IntPtr selHazardTrackingModeHandle = Selector.GetHandle("hazardTrackingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMipmapLevelCount = "mipmapLevelCount";

	private static readonly IntPtr selMipmapLevelCountHandle = Selector.GetHandle("mipmapLevelCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceOptions = "resourceOptions";

	private static readonly IntPtr selResourceOptionsHandle = Selector.GetHandle("resourceOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleCount = "sampleCount";

	private static readonly IntPtr selSampleCountHandle = Selector.GetHandle("sampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowGPUOptimizedContents_ = "setAllowGPUOptimizedContents:";

	private static readonly IntPtr selSetAllowGPUOptimizedContents_Handle = Selector.GetHandle("setAllowGPUOptimizedContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrayLength_ = "setArrayLength:";

	private static readonly IntPtr selSetArrayLength_Handle = Selector.GetHandle("setArrayLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCpuCacheMode_ = "setCpuCacheMode:";

	private static readonly IntPtr selSetCpuCacheMode_Handle = Selector.GetHandle("setCpuCacheMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepth_ = "setDepth:";

	private static readonly IntPtr selSetDepth_Handle = Selector.GetHandle("setDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHazardTrackingMode_ = "setHazardTrackingMode:";

	private static readonly IntPtr selSetHazardTrackingMode_Handle = Selector.GetHandle("setHazardTrackingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeight_ = "setHeight:";

	private static readonly IntPtr selSetHeight_Handle = Selector.GetHandle("setHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMipmapLevelCount_ = "setMipmapLevelCount:";

	private static readonly IntPtr selSetMipmapLevelCount_Handle = Selector.GetHandle("setMipmapLevelCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelFormat_ = "setPixelFormat:";

	private static readonly IntPtr selSetPixelFormat_Handle = Selector.GetHandle("setPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResourceOptions_ = "setResourceOptions:";

	private static readonly IntPtr selSetResourceOptions_Handle = Selector.GetHandle("setResourceOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleCount_ = "setSampleCount:";

	private static readonly IntPtr selSetSampleCount_Handle = Selector.GetHandle("setSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStorageMode_ = "setStorageMode:";

	private static readonly IntPtr selSetStorageMode_Handle = Selector.GetHandle("setStorageMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSwizzle_ = "setSwizzle:";

	private static readonly IntPtr selSetSwizzle_Handle = Selector.GetHandle("setSwizzle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextureType_ = "setTextureType:";

	private static readonly IntPtr selSetTextureType_Handle = Selector.GetHandle("setTextureType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsage_ = "setUsage:";

	private static readonly IntPtr selSetUsage_Handle = Selector.GetHandle("setUsage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_ = "setWidth:";

	private static readonly IntPtr selSetWidth_Handle = Selector.GetHandle("setWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStorageMode = "storageMode";

	private static readonly IntPtr selStorageModeHandle = Selector.GetHandle("storageMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSwizzle = "swizzle";

	private static readonly IntPtr selSwizzleHandle = Selector.GetHandle("swizzle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture2DDescriptorWithPixelFormat_Width_Height_Mipmapped_ = "texture2DDescriptorWithPixelFormat:width:height:mipmapped:";

	private static readonly IntPtr selTexture2DDescriptorWithPixelFormat_Width_Height_Mipmapped_Handle = Selector.GetHandle("texture2DDescriptorWithPixelFormat:width:height:mipmapped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureBufferDescriptorWithPixelFormat_Width_ResourceOptions_Usage_ = "textureBufferDescriptorWithPixelFormat:width:resourceOptions:usage:";

	private static readonly IntPtr selTextureBufferDescriptorWithPixelFormat_Width_ResourceOptions_Usage_Handle = Selector.GetHandle("textureBufferDescriptorWithPixelFormat:width:resourceOptions:usage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureCubeDescriptorWithPixelFormat_Size_Mipmapped_ = "textureCubeDescriptorWithPixelFormat:size:mipmapped:";

	private static readonly IntPtr selTextureCubeDescriptorWithPixelFormat_Size_Mipmapped_Handle = Selector.GetHandle("textureCubeDescriptorWithPixelFormat:size:mipmapped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureType = "textureType";

	private static readonly IntPtr selTextureTypeHandle = Selector.GetHandle("textureType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsage = "usage";

	private static readonly IntPtr selUsageHandle = Selector.GetHandle("usage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLTextureDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool AllowGpuOptimizedContents
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("allowGPUOptimizedContents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowGPUOptimizedContentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowGPUOptimizedContentsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setAllowGPUOptimizedContents:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowGPUOptimizedContents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowGPUOptimizedContents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ArrayLength
	{
		[Export("arrayLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selArrayLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selArrayLengthHandle);
		}
		[Export("setArrayLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetArrayLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetArrayLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MTLCpuCacheMode CpuCacheMode
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("cpuCacheMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, selCpuCacheModeHandle);
			}
			return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCpuCacheModeHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setCpuCacheMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCpuCacheMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCpuCacheMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Depth
	{
		[Export("depth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDepthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDepthHandle);
		}
		[Export("setDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MTLHazardTrackingMode HazardTrackingMode
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("hazardTrackingMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLHazardTrackingMode)Messaging.UInt64_objc_msgSend(base.Handle, selHazardTrackingModeHandle);
			}
			return (MTLHazardTrackingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHazardTrackingModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setHazardTrackingMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetHazardTrackingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetHazardTrackingMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Height
	{
		[Export("height")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selHeightHandle);
		}
		[Export("setHeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MipmapLevelCount
	{
		[Export("mipmapLevelCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMipmapLevelCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMipmapLevelCountHandle);
		}
		[Export("setMipmapLevelCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMipmapLevelCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMipmapLevelCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLPixelFormat PixelFormat
	{
		[Export("pixelFormat", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle);
		}
		[Export("setPixelFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPixelFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPixelFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLResourceOptions ResourceOptions
	{
		[Export("resourceOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLResourceOptions)Messaging.UInt64_objc_msgSend(base.Handle, selResourceOptionsHandle);
			}
			return (MTLResourceOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResourceOptionsHandle);
		}
		[Export("setResourceOptions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResourceOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResourceOptions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SampleCount
	{
		[Export("sampleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSampleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSampleCountHandle);
		}
		[Export("setSampleCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MTLStorageMode StorageMode
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("storageMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStorageMode)Messaging.UInt64_objc_msgSend(base.Handle, selStorageModeHandle);
			}
			return (MTLStorageMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStorageModeHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setStorageMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStorageMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStorageMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MTLTextureSwizzleChannels Swizzle
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("swizzle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.MTLTextureSwizzleChannels_objc_msgSend(base.Handle, selSwizzleHandle);
			}
			return Messaging.MTLTextureSwizzleChannels_objc_msgSendSuper(base.SuperHandle, selSwizzleHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setSwizzle:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLTextureSwizzleChannels(base.Handle, selSetSwizzle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLTextureSwizzleChannels(base.SuperHandle, selSetSwizzle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLTextureType TextureType
	{
		[Export("textureType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureType)Messaging.UInt64_objc_msgSend(base.Handle, selTextureTypeHandle);
			}
			return (MTLTextureType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTextureTypeHandle);
		}
		[Export("setTextureType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTextureType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTextureType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MTLTextureUsage Usage
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("usage", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selUsageHandle);
			}
			return (MTLTextureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsageHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setUsage:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetUsage_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetUsage_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Width
	{
		[Export("width")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
		[Export("setWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLTextureDescriptor()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLTextureDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLTextureDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("texture2DDescriptorWithPixelFormat:width:height:mipmapped:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLTextureDescriptor CreateTexture2DDescriptor(MTLPixelFormat pixelFormat, nuint width, nuint height, bool mipmapped)
	{
		return Runtime.GetNSObject<MTLTextureDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_nuint_nuint_bool(class_ptr, selTexture2DDescriptorWithPixelFormat_Width_Height_Mipmapped_Handle, (ulong)pixelFormat, width, height, mipmapped));
	}

	[Export("textureBufferDescriptorWithPixelFormat:width:resourceOptions:usage:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLTextureDescriptor CreateTextureBufferDescriptor(MTLPixelFormat pixelFormat, nuint width, MTLResourceOptions resourceOptions, MTLTextureUsage usage)
	{
		return Runtime.GetNSObject<MTLTextureDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_nuint_UInt64_UInt64(class_ptr, selTextureBufferDescriptorWithPixelFormat_Width_ResourceOptions_Usage_Handle, (ulong)pixelFormat, width, (ulong)resourceOptions, (ulong)usage));
	}

	[Export("textureCubeDescriptorWithPixelFormat:size:mipmapped:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLTextureDescriptor CreateTextureCubeDescriptor(MTLPixelFormat pixelFormat, nuint size, bool mipmapped)
	{
		return Runtime.GetNSObject<MTLTextureDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_nuint_bool(class_ptr, selTextureCubeDescriptorWithPixelFormat_Size_Mipmapped_Handle, (ulong)pixelFormat, size, mipmapped));
	}
}

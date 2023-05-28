using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImageDescriptor", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public class MPSImageDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelFormat = "channelFormat";

	private static readonly IntPtr selChannelFormatHandle = Selector.GetHandle("channelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCpuCacheMode = "cpuCacheMode";

	private static readonly IntPtr selCpuCacheModeHandle = Selector.GetHandle("cpuCacheMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureChannels = "featureChannels";

	private static readonly IntPtr selFeatureChannelsHandle = Selector.GetHandle("featureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_ = "imageDescriptorWithChannelFormat:width:height:featureChannels:";

	private static readonly IntPtr selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_Handle = Selector.GetHandle("imageDescriptorWithChannelFormat:width:height:featureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_NumberOfImages_Usage_ = "imageDescriptorWithChannelFormat:width:height:featureChannels:numberOfImages:usage:";

	private static readonly IntPtr selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_NumberOfImages_Usage_Handle = Selector.GetHandle("imageDescriptorWithChannelFormat:width:height:featureChannels:numberOfImages:usage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfImages = "numberOfImages";

	private static readonly IntPtr selNumberOfImagesHandle = Selector.GetHandle("numberOfImages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannelFormat_ = "setChannelFormat:";

	private static readonly IntPtr selSetChannelFormat_Handle = Selector.GetHandle("setChannelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCpuCacheMode_ = "setCpuCacheMode:";

	private static readonly IntPtr selSetCpuCacheMode_Handle = Selector.GetHandle("setCpuCacheMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFeatureChannels_ = "setFeatureChannels:";

	private static readonly IntPtr selSetFeatureChannels_Handle = Selector.GetHandle("setFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeight_ = "setHeight:";

	private static readonly IntPtr selSetHeight_Handle = Selector.GetHandle("setHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfImages_ = "setNumberOfImages:";

	private static readonly IntPtr selSetNumberOfImages_Handle = Selector.GetHandle("setNumberOfImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStorageMode_ = "setStorageMode:";

	private static readonly IntPtr selSetStorageMode_Handle = Selector.GetHandle("setStorageMode:");

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
	private const string selUsage = "usage";

	private static readonly IntPtr selUsageHandle = Selector.GetHandle("usage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageFeatureChannelFormat ChannelFormat
	{
		[Export("channelFormat", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selChannelFormatHandle);
			}
			return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selChannelFormatHandle);
		}
		[Export("setChannelFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetChannelFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetChannelFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, selCpuCacheModeHandle);
			}
			return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCpuCacheModeHandle);
		}
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
	public virtual nuint FeatureChannels
	{
		[Export("featureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFeatureChannelsHandle);
		}
		[Export("setFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFeatureChannels_Handle, value);
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
	public virtual nuint NumberOfImages
	{
		[Export("numberOfImages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfImagesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfImagesHandle);
		}
		[Export("setNumberOfImages:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfImages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfImages_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLPixelFormat PixelFormat
	{
		[Export("pixelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStorageMode StorageMode
	{
		[Export("storageMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStorageMode)Messaging.UInt64_objc_msgSend(base.Handle, selStorageModeHandle);
			}
			return (MTLStorageMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStorageModeHandle);
		}
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
	public virtual MTLTextureUsage Usage
	{
		[Export("usage", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selUsageHandle);
			}
			return (MTLTextureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsageHandle);
		}
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
	protected MPSImageDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageDescriptor(IntPtr handle)
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

	[Export("imageDescriptorWithChannelFormat:width:height:featureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSImageDescriptor GetImageDescriptor(MPSImageFeatureChannelFormat channelFormat, nuint width, nuint height, nuint featureChannels)
	{
		return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_nuint_nuint_nuint(class_ptr, selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_Handle, (ulong)channelFormat, width, height, featureChannels));
	}

	[Export("imageDescriptorWithChannelFormat:width:height:featureChannels:numberOfImages:usage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSImageDescriptor GetImageDescriptor(MPSImageFeatureChannelFormat channelFormat, nuint width, nuint height, nuint featureChannels, nuint numberOfImages, MTLTextureUsage usage)
	{
		return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_nuint_nuint_nuint_nuint_UInt64(class_ptr, selImageDescriptorWithChannelFormat_Width_Height_FeatureChannels_NumberOfImages_Usage_Handle, (ulong)channelFormat, width, height, featureChannels, numberOfImages, (ulong)usage));
	}
}

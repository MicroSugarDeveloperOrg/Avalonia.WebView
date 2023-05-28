using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImage", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public class MPSImage : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchRepresentation = "batchRepresentation";

	private static readonly IntPtr selBatchRepresentationHandle = Selector.GetHandle("batchRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchRepresentationWithSubRange_ = "batchRepresentationWithSubRange:";

	private static readonly IntPtr selBatchRepresentationWithSubRange_Handle = Selector.GetHandle("batchRepresentationWithSubRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAllocator = "defaultAllocator";

	private static readonly IntPtr selDefaultAllocatorHandle = Selector.GetHandle("defaultAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureChannelFormat = "featureChannelFormat";

	private static readonly IntPtr selFeatureChannelFormatHandle = Selector.GetHandle("featureChannelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureChannels = "featureChannels";

	private static readonly IntPtr selFeatureChannelsHandle = Selector.GetHandle("featureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ImageDescriptor_ = "initWithDevice:imageDescriptor:";

	private static readonly IntPtr selInitWithDevice_ImageDescriptor_Handle = Selector.GetHandle("initWithDevice:imageDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithParentImage_SliceRange_FeatureChannels_ = "initWithParentImage:sliceRange:featureChannels:";

	private static readonly IntPtr selInitWithParentImage_SliceRange_FeatureChannels_Handle = Selector.GetHandle("initWithParentImage:sliceRange:featureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_FeatureChannels_ = "initWithTexture:featureChannels:";

	private static readonly IntPtr selInitWithTexture_FeatureChannels_Handle = Selector.GetHandle("initWithTexture:featureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfImages = "numberOfImages";

	private static readonly IntPtr selNumberOfImagesHandle = Selector.GetHandle("numberOfImages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParent = "parent";

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelSize = "pixelSize";

	private static readonly IntPtr selPixelSizeHandle = Selector.GetHandle("pixelSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrecision = "precision";

	private static readonly IntPtr selPrecisionHandle = Selector.GetHandle("precision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_ = "readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";

	private static readonly IntPtr selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle = Selector.GetHandle("readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_ = "readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:";

	private static readonly IntPtr selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle = Selector.GetHandle("readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadBytes_DataLayout_ImageIndex_ = "readBytes:dataLayout:imageIndex:";

	private static readonly IntPtr selReadBytes_DataLayout_ImageIndex_Handle = Selector.GetHandle("readBytes:dataLayout:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceSize = "resourceSize";

	private static readonly IntPtr selResourceSizeHandle = Selector.GetHandle("resourceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPurgeableState_ = "setPurgeableState:";

	private static readonly IntPtr selSetPurgeableState_Handle = Selector.GetHandle("setPurgeableState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubImageWithFeatureChannelRange_ = "subImageWithFeatureChannelRange:";

	private static readonly IntPtr selSubImageWithFeatureChannelRange_Handle = Selector.GetHandle("subImageWithFeatureChannelRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeOnCommandBuffer_ = "synchronizeOnCommandBuffer:";

	private static readonly IntPtr selSynchronizeOnCommandBuffer_Handle = Selector.GetHandle("synchronizeOnCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture = "texture";

	private static readonly IntPtr selTextureHandle = Selector.GetHandle("texture");

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
	private const string selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_ = "writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";

	private static readonly IntPtr selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle = Selector.GetHandle("writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_ = "writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:";

	private static readonly IntPtr selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle = Selector.GetHandle("writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_ = "writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:";

	private static readonly IntPtr selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle = Selector.GetHandle("writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteBytes_DataLayout_ImageIndex_ = "writeBytes:dataLayout:imageIndex:";

	private static readonly IntPtr selWriteBytes_DataLayout_ImageIndex_Handle = Selector.GetHandle("writeBytes:dataLayout:imageIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImage");

	[iOS(13, 0)]
	[TV(12, 0)]
	[Mac(10, 15)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	public MPSImageType ImageType => MPSGetImageType(base.Handle);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> BatchRepresentation
	{
		[Export("batchRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend(base.Handle, selBatchRepresentationHandle));
			}
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBatchRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static IMPSImageAllocator DefaultAllocator
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("defaultAllocator")]
		get
		{
			return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultAllocatorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice Device
	{
		[Export("device", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MPSImageFeatureChannelFormat FeatureChannelFormat
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("featureChannelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selFeatureChannelFormatHandle);
			}
			return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFeatureChannelFormatHandle);
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	public virtual MPSImage? Parent
	{
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Export("parent", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle));
			}
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle));
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
	public virtual nuint PixelSize
	{
		[Export("pixelSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPixelSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPixelSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Precision
	{
		[Export("precision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrecisionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrecisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	public virtual nuint ResourceSize
	{
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Export("resourceSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResourceSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResourceSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture Texture
	{
		[Export("texture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLTextureType TextureType
	{
		[Export("textureType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureType)Messaging.UInt64_objc_msgSend(base.Handle, selTextureTypeHandle);
			}
			return (MTLTextureType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTextureTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLTextureUsage Usage
	{
		[Export("usage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selUsageHandle);
			}
			return (MTLTextureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsageHandle);
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
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[iOS(13, 0)]
	[TV(12, 0)]
	[Mac(10, 15)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	private static extern MPSImageType MPSGetImageType(IntPtr image);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSImage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:imageDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImage(IMTLDevice device, MPSImageDescriptor imageDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (imageDescriptor == null)
		{
			throw new ArgumentNullException("imageDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_ImageDescriptor_Handle, device.Handle, imageDescriptor.Handle), "initWithDevice:imageDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_ImageDescriptor_Handle, device.Handle, imageDescriptor.Handle), "initWithDevice:imageDescriptor:");
		}
	}

	[Export("initWithParentImage:sliceRange:featureChannels:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImage(MPSImage parent, NSRange sliceRange, nuint featureChannels)
		: base(NSObjectFlag.Empty)
	{
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_nuint(base.Handle, selInitWithParentImage_SliceRange_FeatureChannels_Handle, parent.Handle, sliceRange, featureChannels), "initWithParentImage:sliceRange:featureChannels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange_nuint(base.SuperHandle, selInitWithParentImage_SliceRange_FeatureChannels_Handle, parent.Handle, sliceRange, featureChannels), "initWithParentImage:sliceRange:featureChannels:");
		}
	}

	[Export("initWithTexture:featureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImage(IMTLTexture texture, nuint featureChannels)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithTexture_FeatureChannels_Handle, texture.Handle, featureChannels), "initWithTexture:featureChannels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithTexture_FeatureChannels_Handle, texture.Handle, featureChannels), "initWithTexture:featureChannels:");
		}
	}

	[Export("batchRepresentationWithSubRange:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> GetBatchRepresentation(NSRange subRange)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selBatchRepresentationWithSubRange_Handle, subRange));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selBatchRepresentationWithSubRange_Handle, subRange));
	}

	[Export("subImageWithFeatureChannelRange:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage GetSubImage(NSRange featureChannelRange)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selSubImageWithFeatureChannelRange_Handle, featureChannelRange));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selSubImageWithFeatureChannelRange_Handle, featureChannelRange));
	}

	[Export("readBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.Handle, selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.SuperHandle, selReadBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
		}
	}

	[Export("readBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.Handle, selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.SuperHandle, selReadBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
	}

	[Export("readBytes:dataLayout:imageIndex:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint(base.Handle, selReadBytes_DataLayout_ImageIndex_Handle, dataBytes, (ulong)dataLayout, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint(base.SuperHandle, selReadBytes_DataLayout_ImageIndex_Handle, dataBytes, (ulong)dataLayout, imageIndex);
		}
	}

	[Export("setPurgeableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSPurgeableState SetPurgeableState(MPSPurgeableState state)
	{
		if (base.IsDirectBinding)
		{
			return (MPSPurgeableState)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selSetPurgeableState_Handle, (ulong)state);
		}
		return (MPSPurgeableState)Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPurgeableState_Handle, (ulong)state);
	}

	[Export("synchronizeOnCommandBuffer:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Synchronize(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSynchronizeOnCommandBuffer_Handle, commandBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSynchronizeOnCommandBuffer_Handle, commandBuffer.Handle);
		}
	}

	[Export("writeBytes:dataLayout:bytesPerRow:region:featureChannelInfo:imageIndex:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.Handle, selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.SuperHandle, selWriteBytes_DataLayout_BytesPerRow_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, region, featureChannelInfo, imageIndex);
		}
	}

	[Export("writeBytes:dataLayout:bytesPerColumn:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint bytesPerColumn, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.Handle, selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerColumn, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.SuperHandle, selWriteBytes_DataLayout_BytesPerColumn_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerColumn, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
	}

	[Export("writeBytes:dataLayout:bytesPerRow:bytesPerImage:region:featureChannelInfo:imageIndex:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, MPSImageReadWriteParams featureChannelInfo, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.Handle, selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint_nuint_MTLRegion_MPSImageReadWriteParams_nuint(base.SuperHandle, selWriteBytes_DataLayout_BytesPerRow_BytesPerImage_Region_FeatureChannelInfo_ImageIndex_Handle, dataBytes, (ulong)dataLayout, bytesPerRow, bytesPerImage, region, featureChannelInfo, imageIndex);
		}
	}

	[Export("writeBytes:dataLayout:imageIndex:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteBytes(IntPtr dataBytes, MPSDataLayout dataLayout, nuint imageIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_nuint(base.Handle, selWriteBytes_DataLayout_ImageIndex_Handle, dataBytes, (ulong)dataLayout, imageIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_nuint(base.SuperHandle, selWriteBytes_DataLayout_ImageIndex_Handle, dataBytes, (ulong)dataLayout, imageIndex);
		}
	}
}

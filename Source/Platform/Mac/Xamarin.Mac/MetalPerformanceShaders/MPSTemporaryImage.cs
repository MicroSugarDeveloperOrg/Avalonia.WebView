using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSTemporaryImage", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public class MPSTemporaryImage : MPSImage
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAllocator = "defaultAllocator";

	private static readonly IntPtr selDefaultAllocatorHandle = Selector.GetHandle("defaultAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithParentImage_SliceRange_FeatureChannels_ = "initWithParentImage:sliceRange:featureChannels:";

	private static readonly IntPtr selInitWithParentImage_SliceRange_FeatureChannels_Handle = Selector.GetHandle("initWithParentImage:sliceRange:featureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefetchStorageWithCommandBuffer_ImageDescriptorList_ = "prefetchStorageWithCommandBuffer:imageDescriptorList:";

	private static readonly IntPtr selPrefetchStorageWithCommandBuffer_ImageDescriptorList_Handle = Selector.GetHandle("prefetchStorageWithCommandBuffer:imageDescriptorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCount = "readCount";

	private static readonly IntPtr selReadCountHandle = Selector.GetHandle("readCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadCount_ = "setReadCount:";

	private static readonly IntPtr selSetReadCount_Handle = Selector.GetHandle("setReadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryImageWithCommandBuffer_ImageDescriptor_ = "temporaryImageWithCommandBuffer:imageDescriptor:";

	private static readonly IntPtr selTemporaryImageWithCommandBuffer_ImageDescriptor_Handle = Selector.GetHandle("temporaryImageWithCommandBuffer:imageDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryImageWithCommandBuffer_TextureDescriptor_ = "temporaryImageWithCommandBuffer:textureDescriptor:";

	private static readonly IntPtr selTemporaryImageWithCommandBuffer_TextureDescriptor_Handle = Selector.GetHandle("temporaryImageWithCommandBuffer:textureDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryImageWithCommandBuffer_TextureDescriptor_FeatureChannels_ = "temporaryImageWithCommandBuffer:textureDescriptor:featureChannels:";

	private static readonly IntPtr selTemporaryImageWithCommandBuffer_TextureDescriptor_FeatureChannels_Handle = Selector.GetHandle("temporaryImageWithCommandBuffer:textureDescriptor:featureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSTemporaryImage");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public new static IMPSImageAllocator DefaultAllocator
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
	public virtual nuint ReadCount
	{
		[Export("readCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selReadCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selReadCountHandle);
		}
		[Export("setReadCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetReadCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetReadCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSTemporaryImage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSTemporaryImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithParentImage:sliceRange:featureChannels:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSTemporaryImage(MPSImage parent, NSRange sliceRange, nuint featureChannels)
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

	[Export("temporaryImageWithCommandBuffer:imageDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryImage GetTemporaryImage(IMTLCommandBuffer commandBuffer, MPSImageDescriptor imageDescriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (imageDescriptor == null)
		{
			throw new ArgumentNullException("imageDescriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryImageWithCommandBuffer_ImageDescriptor_Handle, commandBuffer.Handle, imageDescriptor.Handle));
	}

	[Export("temporaryImageWithCommandBuffer:textureDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryImage GetTemporaryImage(IMTLCommandBuffer commandBuffer, MTLTextureDescriptor textureDescriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (textureDescriptor == null)
		{
			throw new ArgumentNullException("textureDescriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryImageWithCommandBuffer_TextureDescriptor_Handle, commandBuffer.Handle, textureDescriptor.Handle));
	}

	[Export("temporaryImageWithCommandBuffer:textureDescriptor:featureChannels:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryImage GetTemporaryImage(IMTLCommandBuffer commandBuffer, MTLTextureDescriptor textureDescriptor, nuint featureChannels)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (textureDescriptor == null)
		{
			throw new ArgumentNullException("textureDescriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(class_ptr, selTemporaryImageWithCommandBuffer_TextureDescriptor_FeatureChannels_Handle, commandBuffer.Handle, textureDescriptor.Handle, featureChannels));
	}

	[Export("prefetchStorageWithCommandBuffer:imageDescriptorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrefetchStorage(IMTLCommandBuffer commandBuffer, MPSImageDescriptor[] descriptorList)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptorList == null)
		{
			throw new ArgumentNullException("descriptorList");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptorList);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPrefetchStorageWithCommandBuffer_ImageDescriptorList_Handle, commandBuffer.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}

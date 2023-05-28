using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSState", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSState : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferSizeAtIndex_ = "bufferSizeAtIndex:";

	private static readonly IntPtr selBufferSizeAtIndex_Handle = Selector.GetHandle("bufferSizeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_ = "destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:";

	private static readonly IntPtr selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle = Selector.GetHandle("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_BufferSize_ = "initWithDevice:bufferSize:";

	private static readonly IntPtr selInitWithDevice_BufferSize_Handle = Selector.GetHandle("initWithDevice:bufferSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ResourceList_ = "initWithDevice:resourceList:";

	private static readonly IntPtr selInitWithDevice_ResourceList_Handle = Selector.GetHandle("initWithDevice:resourceList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_TextureDescriptor_ = "initWithDevice:textureDescriptor:";

	private static readonly IntPtr selInitWithDevice_TextureDescriptor_Handle = Selector.GetHandle("initWithDevice:textureDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithResource_ = "initWithResource:";

	private static readonly IntPtr selInitWithResource_Handle = Selector.GetHandle("initWithResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithResources_ = "initWithResources:";

	private static readonly IntPtr selInitWithResources_Handle = Selector.GetHandle("initWithResources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTemporary = "isTemporary";

	private static readonly IntPtr selIsTemporaryHandle = Selector.GetHandle("isTemporary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCount = "readCount";

	private static readonly IntPtr selReadCountHandle = Selector.GetHandle("readCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResource = "resource";

	private static readonly IntPtr selResourceHandle = Selector.GetHandle("resource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceAtIndex_AllocateMemory_ = "resourceAtIndex:allocateMemory:";

	private static readonly IntPtr selResourceAtIndex_AllocateMemory_Handle = Selector.GetHandle("resourceAtIndex:allocateMemory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceCount = "resourceCount";

	private static readonly IntPtr selResourceCountHandle = Selector.GetHandle("resourceCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceSize = "resourceSize";

	private static readonly IntPtr selResourceSizeHandle = Selector.GetHandle("resourceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceTypeAtIndex_ = "resourceTypeAtIndex:";

	private static readonly IntPtr selResourceTypeAtIndex_Handle = Selector.GetHandle("resourceTypeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadCount_ = "setReadCount:";

	private static readonly IntPtr selSetReadCount_Handle = Selector.GetHandle("setReadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeOnCommandBuffer_ = "synchronizeOnCommandBuffer:";

	private static readonly IntPtr selSynchronizeOnCommandBuffer_Handle = Selector.GetHandle("synchronizeOnCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_ = "temporaryStateWithCommandBuffer:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_BufferSize_ = "temporaryStateWithCommandBuffer:bufferSize:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_BufferSize_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:bufferSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_ResourceList_ = "temporaryStateWithCommandBuffer:resourceList:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_ResourceList_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:resourceList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_TextureDescriptor_ = "temporaryStateWithCommandBuffer:textureDescriptor:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_TextureDescriptor_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:textureDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureInfoAtIndex_ = "textureInfoAtIndex:";

	private static readonly IntPtr selTextureInfoAtIndex_Handle = Selector.GetHandle("textureInfoAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsTemporary
	{
		[Export("isTemporary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemporaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemporaryHandle);
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
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	public virtual IMTLResource? Resource
	{
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Please use 'GetResource (nuint, bool)' instead.")]
		[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
		[Export("resource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLResource>(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLResource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	public virtual nuint ResourceCount
	{
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Export("resourceCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResourceCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResourceCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	public virtual nuint ResourceSize
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:bufferSize:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSState(IMTLDevice device, nuint bufferSize)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithDevice_BufferSize_Handle, device.Handle, bufferSize), "initWithDevice:bufferSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithDevice_BufferSize_Handle, device.Handle, bufferSize), "initWithDevice:bufferSize:");
		}
	}

	[Export("initWithDevice:textureDescriptor:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSState(IMTLDevice device, MTLTextureDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_TextureDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:textureDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_TextureDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:textureDescriptor:");
		}
	}

	[Export("initWithResource:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSState(IMTLResource? resource)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithResource_Handle, resource?.Handle ?? IntPtr.Zero), "initWithResource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithResource_Handle, resource?.Handle ?? IntPtr.Zero), "initWithResource:");
		}
	}

	[Export("initWithDevice:resourceList:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSState(IMTLDevice device, MPSStateResourceList resourceList)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resourceList == null)
		{
			throw new ArgumentNullException("resourceList");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_ResourceList_Handle, device.Handle, resourceList.Handle), "initWithDevice:resourceList:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_ResourceList_Handle, device.Handle, resourceList.Handle), "initWithDevice:resourceList:");
		}
	}

	[Export("initWithResources:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSState(IMTLResource[]? resources)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((resources == null) ? null : NSArray.FromNSObjects(resources));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithResources_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithResources:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithResources_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithResources:");
		}
		nSArray?.Dispose();
	}

	[Export("temporaryStateWithCommandBuffer:bufferSize:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSState CreateTemporaryState(IMTLCommandBuffer commandBuffer, nuint bufferSize)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selTemporaryStateWithCommandBuffer_BufferSize_Handle, commandBuffer.Handle, bufferSize));
	}

	[Export("temporaryStateWithCommandBuffer:textureDescriptor:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSState CreateTemporaryState(IMTLCommandBuffer commandBuffer, MTLTextureDescriptor descriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_TextureDescriptor_Handle, commandBuffer.Handle, descriptor.Handle));
	}

	[Export("temporaryStateWithCommandBuffer:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSState CreateTemporaryState(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_Handle, commandBuffer.Handle));
	}

	[Export("temporaryStateWithCommandBuffer:resourceList:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSState CreateTemporaryState(IMTLCommandBuffer commandBuffer, MPSStateResourceList resourceList)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (resourceList == null)
		{
			throw new ArgumentNullException("resourceList");
		}
		return Runtime.GetNSObject<MPSState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_ResourceList_Handle, commandBuffer.Handle, resourceList.Handle));
	}

	[Export("bufferSizeAtIndex:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetBufferSize(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selBufferSizeAtIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selBufferSizeAtIndex_Handle, index);
	}

	[Export("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageDescriptor GetDestinationImageDescriptor(NSArray<MPSImage> sourceImages, NSArray<MPSState>? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
	{
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (kernel == null)
		{
			throw new ArgumentNullException("kernel");
		}
		if (inDescriptor == null)
		{
			throw new ArgumentNullException("inDescriptor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle, sourceImages.Handle, sourceStates?.Handle ?? IntPtr.Zero, kernel.Handle, inDescriptor.Handle));
		}
		return Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle, sourceImages.Handle, sourceStates?.Handle ?? IntPtr.Zero, kernel.Handle, inDescriptor.Handle));
	}

	[Export("resourceAtIndex:allocateMemory:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLResource? GetResource(nuint index, bool allocateMemory)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMTLResource>(Messaging.IntPtr_objc_msgSend_nuint_bool(base.Handle, selResourceAtIndex_AllocateMemory_Handle, index, allocateMemory), owns: false);
		}
		return Runtime.GetINativeObject<IMTLResource>(Messaging.IntPtr_objc_msgSendSuper_nuint_bool(base.SuperHandle, selResourceAtIndex_AllocateMemory_Handle, index, allocateMemory), owns: false);
	}

	[Export("resourceTypeAtIndex:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSStateResourceType GetResourceType(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return (MPSStateResourceType)Messaging.UInt64_objc_msgSend_nuint(base.Handle, selResourceTypeAtIndex_Handle, index);
		}
		return (MPSStateResourceType)Messaging.UInt64_objc_msgSendSuper_nuint(base.SuperHandle, selResourceTypeAtIndex_Handle, index);
	}

	[Export("textureInfoAtIndex:")]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSStateTextureInfo GetTextureInfo(nuint index)
	{
		MPSStateTextureInfo retval;
		if (base.IsDirectBinding)
		{
			Messaging.MPSStateTextureInfo_objc_msgSend_stret_nuint(out retval, base.Handle, selTextureInfoAtIndex_Handle, index);
		}
		else
		{
			Messaging.MPSStateTextureInfo_objc_msgSendSuper_stret_nuint(out retval, base.SuperHandle, selTextureInfoAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("synchronizeOnCommandBuffer:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
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
}

using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSNNGraph", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNGraph : MPSKernel, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationImageAllocator = "destinationImageAllocator";

	private static readonly IntPtr selDestinationImageAllocatorHandle = Selector.GetHandle("destinationImageAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_SourceStates_ = "encodeBatchToCommandBuffer:sourceImages:sourceStates:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_SourceStates_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:sourceStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_ = "encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImages_ = "encodeToCommandBuffer:sourceImages:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImages_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_ = "encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteAsyncWithSourceImages_CompletionHandler_ = "executeAsyncWithSourceImages:completionHandler:";

	private static readonly IntPtr selExecuteAsyncWithSourceImages_CompletionHandler_Handle = Selector.GetHandle("executeAsyncWithSourceImages:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithDevice_ResultImage_ResultImageIsNeeded_ = "graphWithDevice:resultImage:resultImageIsNeeded:";

	private static readonly IntPtr selGraphWithDevice_ResultImage_ResultImageIsNeeded_Handle = Selector.GetHandle("graphWithDevice:resultImage:resultImageIsNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithDevice_ResultImages_ResultsAreNeeded_ = "graphWithDevice:resultImages:resultsAreNeeded:";

	private static readonly IntPtr selGraphWithDevice_ResultImages_ResultsAreNeeded_Handle = Selector.GetHandle("graphWithDevice:resultImages:resultsAreNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ResultImage_ = "initWithDevice:resultImage:";

	private static readonly IntPtr selInitWithDevice_ResultImage_Handle = Selector.GetHandle("initWithDevice:resultImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ResultImage_ResultImageIsNeeded_ = "initWithDevice:resultImage:resultImageIsNeeded:";

	private static readonly IntPtr selInitWithDevice_ResultImage_ResultImageIsNeeded_Handle = Selector.GetHandle("initWithDevice:resultImage:resultImageIsNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntermediateImageHandles = "intermediateImageHandles";

	private static readonly IntPtr selIntermediateImageHandlesHandle = Selector.GetHandle("intermediateImageHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputStateIsTemporary = "outputStateIsTemporary";

	private static readonly IntPtr selOutputStateIsTemporaryHandle = Selector.GetHandle("outputStateIsTemporary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCountForSourceImageAtIndex_ = "readCountForSourceImageAtIndex:";

	private static readonly IntPtr selReadCountForSourceImageAtIndex_Handle = Selector.GetHandle("readCountForSourceImageAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCountForSourceStateAtIndex_ = "readCountForSourceStateAtIndex:";

	private static readonly IntPtr selReadCountForSourceStateAtIndex_Handle = Selector.GetHandle("readCountForSourceStateAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadFromDataSources = "reloadFromDataSources";

	private static readonly IntPtr selReloadFromDataSourcesHandle = Selector.GetHandle("reloadFromDataSources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultHandle = "resultHandle";

	private static readonly IntPtr selResultHandleHandle = Selector.GetHandle("resultHandle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultImageIsNeeded = "resultImageIsNeeded";

	private static readonly IntPtr selResultImageIsNeededHandle = Selector.GetHandle("resultImageIsNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateHandles = "resultStateHandles";

	private static readonly IntPtr selResultStateHandlesHandle = Selector.GetHandle("resultStateHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationImageAllocator_ = "setDestinationImageAllocator:";

	private static readonly IntPtr selSetDestinationImageAllocator_Handle = Selector.GetHandle("setDestinationImageAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormat_ = "setFormat:";

	private static readonly IntPtr selSetFormat_Handle = Selector.GetHandle("setFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputStateIsTemporary_ = "setOutputStateIsTemporary:";

	private static readonly IntPtr selSetOutputStateIsTemporary_Handle = Selector.GetHandle("setOutputStateIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceImageHandles = "sourceImageHandles";

	private static readonly IntPtr selSourceImageHandlesHandle = Selector.GetHandle("sourceImageHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceStateHandles = "sourceStateHandles";

	private static readonly IntPtr selSourceStateHandlesHandle = Selector.GetHandle("sourceStateHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSImageAllocator DestinationImageAllocator
	{
		[Export("destinationImageAllocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationImageAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationImageAllocatorHandle), owns: false);
		}
		[Export("setDestinationImageAllocator:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationImageAllocator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationImageAllocator_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSImageFeatureChannelFormat Format
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("format", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selFormatHandle);
			}
			return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle[]? IntermediateImageHandles
	{
		[Export("intermediateImageHandles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selIntermediateImageHandlesHandle));
			}
			return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIntermediateImageHandlesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOutputStateTemporary
	{
		[Export("outputStateIsTemporary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selOutputStateIsTemporaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selOutputStateIsTemporaryHandle);
		}
		[Export("setOutputStateIsTemporary:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOutputStateIsTemporary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOutputStateIsTemporary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle? ResultHandle
	{
		[Export("resultHandle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultHandleHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultHandleHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual bool ResultImageIsNeeded
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("resultImageIsNeeded")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selResultImageIsNeededHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResultImageIsNeededHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle[]? ResultStateHandles
	{
		[Export("resultStateHandles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultStateHandlesHandle));
			}
			return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultStateHandlesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle[] SourceImageHandles
	{
		[Export("sourceImageHandles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceImageHandlesHandle));
			}
			return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceImageHandlesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle[]? SourceStateHandles
	{
		[Export("sourceStateHandles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceStateHandlesHandle));
			}
			return NSArray.ArrayFromHandle<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceStateHandlesHandle));
		}
	}

	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public unsafe static MPSNNGraph Create(IMTLDevice device, MPSNNImageNode[] resultImages, bool[] resultsAreNeeded)
	{
		fixed (bool* ptr = resultsAreNeeded)
		{
			void* ptr2 = ptr;
			return Create(device, resultImages, (IntPtr)ptr2);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNGraph(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:resultImage:resultImageIsNeeded:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNGraph(IMTLDevice device, MPSNNImageNode resultImage, bool resultIsNeeded)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resultImage == null)
		{
			throw new ArgumentNullException("resultImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithDevice_ResultImage_ResultImageIsNeeded_Handle, device.Handle, resultImage.Handle, resultIsNeeded), "initWithDevice:resultImage:resultImageIsNeeded:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithDevice_ResultImage_ResultImageIsNeeded_Handle, device.Handle, resultImage.Handle, resultIsNeeded), "initWithDevice:resultImage:resultImageIsNeeded:");
		}
	}

	[Export("initWithDevice:resultImage:")]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use '.ctor (IMTLDevice, MPSNNImageNode, bool)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNGraph(IMTLDevice device, MPSNNImageNode resultImage)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resultImage == null)
		{
			throw new ArgumentNullException("resultImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_ResultImage_Handle, device.Handle, resultImage.Handle), "initWithDevice:resultImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_ResultImage_Handle, device.Handle, resultImage.Handle), "initWithDevice:resultImage:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNGraph(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("graphWithDevice:resultImage:resultImageIsNeeded:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNGraph? Create(IMTLDevice device, MPSNNImageNode resultImage, bool resultIsNeeded)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resultImage == null)
		{
			throw new ArgumentNullException("resultImage");
		}
		return Runtime.GetNSObject<MPSNNGraph>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(class_ptr, selGraphWithDevice_ResultImage_ResultImageIsNeeded_Handle, device.Handle, resultImage.Handle, resultIsNeeded));
	}

	[Export("graphWithDevice:resultImages:resultsAreNeeded:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNGraph? Create(IMTLDevice device, MPSNNImageNode[] resultImages, IntPtr resultsAreNeeded)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resultImages == null)
		{
			throw new ArgumentNullException("resultImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(resultImages);
		MPSNNGraph nSObject = Runtime.GetNSObject<MPSNNGraph>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selGraphWithDevice_ResultImages_ResultsAreNeeded_Handle, device.Handle, nSArray.Handle, resultsAreNeeded));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage>? EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImages, NSArray<MPSState>[]? sourceStates, NSMutableArray<NSArray<MPSImage>>? intermediateImages, NSMutableArray<NSArray<MPSState>>? destinationStates)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSImage> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, intermediateImages?.Handle ?? IntPtr.Zero, destinationStates?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, intermediateImages?.Handle ?? IntPtr.Zero, destinationStates?.Handle ?? IntPtr.Zero)));
		nSArray.Dispose();
		nSArray2?.Dispose();
		return result;
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:sourceStates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage>? EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage>[] sourceImages, NSArray<MPSState>[]? sourceStates)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		NSArray<MPSImage> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_SourceStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero)));
		nSArray.Dispose();
		nSArray2?.Dispose();
		return result;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceImages:sourceStates:intermediateImages:destinationStates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages, MPSState[]? sourceStates, NSMutableArray<MPSImage>? intermediateImages, NSMutableArray<MPSState>? destinationStates)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		MPSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, intermediateImages?.Handle ?? IntPtr.Zero, destinationStates?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImages_SourceStates_IntermediateImages_DestinationStates_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, intermediateImages?.Handle ?? IntPtr.Zero, destinationStates?.Handle ?? IntPtr.Zero)));
		nSArray.Dispose();
		nSArray2?.Dispose();
		return result;
	}

	[Export("encodeToCommandBuffer:sourceImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage[] sourceImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		MPSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImages_Handle, commandBuffer.Handle, nSArray.Handle)) : Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImages_Handle, commandBuffer.Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("executeAsyncWithSourceImages:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual MPSImage Execute(MPSImage[] sourceImages, [BlockProxy(typeof(Trampolines.NIDActionArity2V71))] Action<MPSImage, NSError> handler)
	{
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V71.Handler, handler);
		MPSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExecuteAsyncWithSourceImages_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr)) : Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selExecuteAsyncWithSourceImages_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr)));
		nSArray.Dispose();
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MPSImage> ExecuteAsync(MPSImage[] sourceImages)
	{
		TaskCompletionSource<MPSImage> tcs = new TaskCompletionSource<MPSImage>();
		Execute(sourceImages, delegate(MPSImage arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MPSImage> ExecuteAsync(MPSImage[] sourceImages, out MPSImage result)
	{
		TaskCompletionSource<MPSImage> tcs = new TaskCompletionSource<MPSImage>();
		result = Execute(sourceImages, delegate(MPSImage arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("readCountForSourceImageAtIndex:")]
	[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetReadCountForSourceImage(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selReadCountForSourceImageAtIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selReadCountForSourceImageAtIndex_Handle, index);
	}

	[Export("readCountForSourceStateAtIndex:")]
	[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetReadCountForSourceState(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selReadCountForSourceStateAtIndex_Handle, index);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selReadCountForSourceStateAtIndex_Handle, index);
	}

	[Export("reloadFromDataSources")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadFromDataSources()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadFromDataSourcesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadFromDataSourcesHandle);
		}
	}
}

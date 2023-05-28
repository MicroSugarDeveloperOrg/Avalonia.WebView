using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSNDArray", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSNDArray : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayViewWithCommandBuffer_Descriptor_Aliasing_ = "arrayViewWithCommandBuffer:descriptor:aliasing:";

	private static readonly IntPtr selArrayViewWithCommandBuffer_Descriptor_Aliasing_Handle = Selector.GetHandle("arrayViewWithCommandBuffer:descriptor:aliasing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataTypeSize = "dataTypeSize";

	private static readonly IntPtr selDataTypeSizeHandle = Selector.GetHandle("dataTypeSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAllocator = "defaultAllocator";

	private static readonly IntPtr selDefaultAllocatorHandle = Selector.GetHandle("defaultAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptor = "descriptor";

	private static readonly IntPtr selDescriptorHandle = Selector.GetHandle("descriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportDataWithCommandBuffer_ToBuffer_DestinationDataType_Offset_RowStrides_ = "exportDataWithCommandBuffer:toBuffer:destinationDataType:offset:rowStrides:";

	private static readonly IntPtr selExportDataWithCommandBuffer_ToBuffer_DestinationDataType_Offset_RowStrides_Handle = Selector.GetHandle("exportDataWithCommandBuffer:toBuffer:destinationDataType:offset:rowStrides:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportDataWithCommandBuffer_ToImages_Offset_ = "exportDataWithCommandBuffer:toImages:offset:";

	private static readonly IntPtr selExportDataWithCommandBuffer_ToImages_Offset_Handle = Selector.GetHandle("exportDataWithCommandBuffer:toImages:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportDataWithCommandBuffer_FromBuffer_SourceDataType_Offset_RowStrides_ = "importDataWithCommandBuffer:fromBuffer:sourceDataType:offset:rowStrides:";

	private static readonly IntPtr selImportDataWithCommandBuffer_FromBuffer_SourceDataType_Offset_RowStrides_Handle = Selector.GetHandle("importDataWithCommandBuffer:fromBuffer:sourceDataType:offset:rowStrides:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportDataWithCommandBuffer_FromImages_Offset_ = "importDataWithCommandBuffer:fromImages:offset:";

	private static readonly IntPtr selImportDataWithCommandBuffer_FromImages_Offset_Handle = Selector.GetHandle("importDataWithCommandBuffer:fromImages:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Descriptor_ = "initWithDevice:descriptor:";

	private static readonly IntPtr selInitWithDevice_Descriptor_Handle = Selector.GetHandle("initWithDevice:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Scalar_ = "initWithDevice:scalar:";

	private static readonly IntPtr selInitWithDevice_Scalar_Handle = Selector.GetHandle("initWithDevice:scalar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthOfDimension_ = "lengthOfDimension:";

	private static readonly IntPtr selLengthOfDimension_Handle = Selector.GetHandle("lengthOfDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfDimensions = "numberOfDimensions";

	private static readonly IntPtr selNumberOfDimensionsHandle = Selector.GetHandle("numberOfDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParent = "parent";

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadBytes_StrideBytes_ = "readBytes:strideBytes:";

	private static readonly IntPtr selReadBytes_StrideBytes_Handle = Selector.GetHandle("readBytes:strideBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceSize = "resourceSize";

	private static readonly IntPtr selResourceSizeHandle = Selector.GetHandle("resourceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeOnCommandBuffer_ = "synchronizeOnCommandBuffer:";

	private static readonly IntPtr selSynchronizeOnCommandBuffer_Handle = Selector.GetHandle("synchronizeOnCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteBytes_StrideBytes_ = "writeBytes:strideBytes:";

	private static readonly IntPtr selWriteBytes_StrideBytes_Handle = Selector.GetHandle("writeBytes:strideBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNDArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataType DataType
	{
		[Export("dataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MPSDataType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DataTypeSize
	{
		[Export("dataTypeSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDataTypeSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDataTypeSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMPSNDArrayAllocator DefaultAllocator
	{
		[Export("defaultAllocator")]
		get
		{
			return Runtime.GetINativeObject<IMPSNDArrayAllocator>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultAllocatorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNDArrayDescriptor Descriptor
	{
		[Export("descriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNDArrayDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSNDArrayDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptorHandle));
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
	public virtual nuint NumberOfDimensions
	{
		[Export("numberOfDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfDimensionsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNDArray? Parent
	{
		[Export("parent", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNDArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle));
			}
			return Runtime.GetNSObject<MPSNDArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResourceSize
	{
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

	public void ExportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType sourceDataType, nuint offset)
	{
		ExportData(cmdBuf, buffer, sourceDataType, offset, IntPtr.Zero);
	}

	public unsafe void ExportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType sourceDataType, nuint offset, nint[] rowStrides)
	{
		fixed (nint* ptr = rowStrides)
		{
			ExportData(cmdBuf, buffer, sourceDataType, offset, (IntPtr)ptr);
		}
	}

	public void ImportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType sourceDataType, nuint offset)
	{
		ImportData(cmdBuf, buffer, sourceDataType, offset, IntPtr.Zero);
	}

	public unsafe void ImportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType sourceDataType, nuint offset, nint[] rowStrides)
	{
		fixed (nint* ptr = rowStrides)
		{
			ImportData(cmdBuf, buffer, sourceDataType, offset, (IntPtr)ptr);
		}
	}

	public void WriteBytes(IntPtr buffer)
	{
		WriteBytes(buffer, IntPtr.Zero);
	}

	public unsafe void WriteBytes(IntPtr buffer, nint[] strideBytesPerDimension)
	{
		fixed (nint* ptr = strideBytesPerDimension)
		{
			WriteBytes(buffer, (IntPtr)ptr);
		}
	}

	public void ReadBytes(IntPtr buffer)
	{
		ReadBytes(buffer, IntPtr.Zero);
	}

	public unsafe void ReadBytes(IntPtr buffer, nint[] strideBytesPerDimension)
	{
		fixed (nint* ptr = strideBytesPerDimension)
		{
			ReadBytes(buffer, (IntPtr)ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNDArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNDArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:descriptor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNDArray(IMTLDevice device, MPSNDArrayDescriptor descriptor)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_Descriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:descriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_Descriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:descriptor:");
		}
	}

	[Export("initWithDevice:scalar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNDArray(IMTLDevice device, double value)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double(base.Handle, selInitWithDevice_Scalar_Handle, device.Handle, value), "initWithDevice:scalar:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selInitWithDevice_Scalar_Handle, device.Handle, value), "initWithDevice:scalar:");
		}
	}

	[Export("arrayViewWithCommandBuffer:descriptor:aliasing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNDArray? Create(IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSAliasingStrategy aliasing)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSNDArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selArrayViewWithCommandBuffer_Descriptor_Aliasing_Handle, cmdBuf.Handle, descriptor.Handle, (ulong)aliasing));
		}
		return Runtime.GetNSObject<MPSNDArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selArrayViewWithCommandBuffer_Descriptor_Aliasing_Handle, cmdBuf.Handle, descriptor.Handle, (ulong)aliasing));
	}

	[Export("exportDataWithCommandBuffer:toBuffer:destinationDataType:offset:rowStrides:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType destinationDataType, nuint offset, IntPtr rowStrides)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_nuint_IntPtr(base.Handle, selExportDataWithCommandBuffer_ToBuffer_DestinationDataType_Offset_RowStrides_Handle, cmdBuf.Handle, buffer.Handle, (uint)destinationDataType, offset, rowStrides);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_nuint_IntPtr(base.SuperHandle, selExportDataWithCommandBuffer_ToBuffer_DestinationDataType_Offset_RowStrides_Handle, cmdBuf.Handle, buffer.Handle, (uint)destinationDataType, offset, rowStrides);
		}
	}

	[Export("exportDataWithCommandBuffer:toImages:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExportData(IMTLCommandBuffer cmdBuf, MPSImage[] images, MPSImageCoordinate offset)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		NSArray nSArray = NSArray.FromNSObjects(images);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_MPSImageCoordinate(base.Handle, selExportDataWithCommandBuffer_ToImages_Offset_Handle, cmdBuf.Handle, nSArray.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_MPSImageCoordinate(base.SuperHandle, selExportDataWithCommandBuffer_ToImages_Offset_Handle, cmdBuf.Handle, nSArray.Handle, offset);
		}
		nSArray.Dispose();
	}

	[Export("lengthOfDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetLength(nuint dimensionIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selLengthOfDimension_Handle, dimensionIndex);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selLengthOfDimension_Handle, dimensionIndex);
	}

	[Export("importDataWithCommandBuffer:fromBuffer:sourceDataType:offset:rowStrides:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ImportData(IMTLCommandBuffer cmdBuf, IMTLBuffer buffer, MPSDataType sourceDataType, nuint offset, IntPtr rowStrides)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_nuint_IntPtr(base.Handle, selImportDataWithCommandBuffer_FromBuffer_SourceDataType_Offset_RowStrides_Handle, cmdBuf.Handle, buffer.Handle, (uint)sourceDataType, offset, rowStrides);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_nuint_IntPtr(base.SuperHandle, selImportDataWithCommandBuffer_FromBuffer_SourceDataType_Offset_RowStrides_Handle, cmdBuf.Handle, buffer.Handle, (uint)sourceDataType, offset, rowStrides);
		}
	}

	[Export("importDataWithCommandBuffer:fromImages:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ImportData(IMTLCommandBuffer cmdBuf, MPSImage[] images, MPSImageCoordinate offset)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		NSArray nSArray = NSArray.FromNSObjects(images);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_MPSImageCoordinate(base.Handle, selImportDataWithCommandBuffer_FromImages_Offset_Handle, cmdBuf.Handle, nSArray.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_MPSImageCoordinate(base.SuperHandle, selImportDataWithCommandBuffer_FromImages_Offset_Handle, cmdBuf.Handle, nSArray.Handle, offset);
		}
		nSArray.Dispose();
	}

	[Export("readBytes:strideBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadBytes(IntPtr buffer, IntPtr strideBytesPerDimension)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReadBytes_StrideBytes_Handle, buffer, strideBytesPerDimension);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReadBytes_StrideBytes_Handle, buffer, strideBytesPerDimension);
		}
	}

	[Export("synchronizeOnCommandBuffer:")]
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

	[Export("writeBytes:strideBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteBytes(IntPtr buffer, IntPtr strideBytesPerDimension)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteBytes_StrideBytes_Handle, buffer, strideBytesPerDimension);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteBytes_StrideBytes_Handle, buffer, strideBytesPerDimension);
		}
	}
}

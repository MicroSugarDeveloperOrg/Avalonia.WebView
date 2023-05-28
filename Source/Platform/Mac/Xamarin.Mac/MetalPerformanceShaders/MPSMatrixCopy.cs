using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixCopy", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSMatrixCopy : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyColumns = "copyColumns";

	private static readonly IntPtr selCopyColumnsHandle = Selector.GetHandle("copyColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyRows = "copyRows";

	private static readonly IntPtr selCopyRowsHandle = Selector.GetHandle("copyRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationsAreTransposed = "destinationsAreTransposed";

	private static readonly IntPtr selDestinationsAreTransposedHandle = Selector.GetHandle("destinationsAreTransposed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_CopyDescriptor_ = "encodeToCommandBuffer:copyDescriptor:";

	private static readonly IntPtr selEncodeToCommandBuffer_CopyDescriptor_Handle = Selector.GetHandle("encodeToCommandBuffer:copyDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_CopyDescriptor_RowPermuteIndices_RowPermuteOffset_ColumnPermuteIndices_ColumnPermuteOffset_ = "encodeToCommandBuffer:copyDescriptor:rowPermuteIndices:rowPermuteOffset:columnPermuteIndices:columnPermuteOffset:";

	private static readonly IntPtr selEncodeToCommandBuffer_CopyDescriptor_RowPermuteIndices_RowPermuteOffset_ColumnPermuteIndices_ColumnPermuteOffset_Handle = Selector.GetHandle("encodeToCommandBuffer:copyDescriptor:rowPermuteIndices:rowPermuteOffset:columnPermuteIndices:columnPermuteOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_CopyRows_CopyColumns_SourcesAreTransposed_DestinationsAreTransposed_ = "initWithDevice:copyRows:copyColumns:sourcesAreTransposed:destinationsAreTransposed:";

	private static readonly IntPtr selInitWithDevice_CopyRows_CopyColumns_SourcesAreTransposed_DestinationsAreTransposed_Handle = Selector.GetHandle("initWithDevice:copyRows:copyColumns:sourcesAreTransposed:destinationsAreTransposed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourcesAreTransposed = "sourcesAreTransposed";

	private static readonly IntPtr selSourcesAreTransposedHandle = Selector.GetHandle("sourcesAreTransposed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixCopy");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AreDestinationsTransposed
	{
		[Export("destinationsAreTransposed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDestinationsAreTransposedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDestinationsAreTransposedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AreSourcesTransposed
	{
		[Export("sourcesAreTransposed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSourcesAreTransposedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSourcesAreTransposedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CopyColumns
	{
		[Export("copyColumns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCopyColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCopyColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CopyRows
	{
		[Export("copyRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCopyRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCopyRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixCopy(NSCoder coder)
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
	protected MPSMatrixCopy(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixCopy(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:copyRows:copyColumns:sourcesAreTransposed:destinationsAreTransposed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixCopy(IMTLDevice device, nuint copyRows, nuint copyColumns, bool areSourcesTransposed, bool areDestinationsTransposed)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_bool_bool(base.Handle, selInitWithDevice_CopyRows_CopyColumns_SourcesAreTransposed_DestinationsAreTransposed_Handle, device.Handle, copyRows, copyColumns, areSourcesTransposed, areDestinationsTransposed), "initWithDevice:copyRows:copyColumns:sourcesAreTransposed:destinationsAreTransposed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_bool_bool(base.SuperHandle, selInitWithDevice_CopyRows_CopyColumns_SourcesAreTransposed_DestinationsAreTransposed_Handle, device.Handle, copyRows, copyColumns, areSourcesTransposed, areDestinationsTransposed), "initWithDevice:copyRows:copyColumns:sourcesAreTransposed:destinationsAreTransposed:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixCopy(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:copyDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer cmdBuf, MPSMatrixCopyDescriptor copyDescriptor)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (copyDescriptor == null)
		{
			throw new ArgumentNullException("copyDescriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_CopyDescriptor_Handle, cmdBuf.Handle, copyDescriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_CopyDescriptor_Handle, cmdBuf.Handle, copyDescriptor.Handle);
		}
	}

	[Export("encodeToCommandBuffer:copyDescriptor:rowPermuteIndices:rowPermuteOffset:columnPermuteIndices:columnPermuteOffset:")]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSMatrixCopyDescriptor copyDescriptor, MPSVector? rowPermuteIndices, nuint rowPermuteOffset, MPSVector? columnPermuteIndices, nuint columnPermuteOffset)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (copyDescriptor == null)
		{
			throw new ArgumentNullException("copyDescriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint(base.Handle, selEncodeToCommandBuffer_CopyDescriptor_RowPermuteIndices_RowPermuteOffset_ColumnPermuteIndices_ColumnPermuteOffset_Handle, commandBuffer.Handle, copyDescriptor.Handle, rowPermuteIndices?.Handle ?? IntPtr.Zero, rowPermuteOffset, columnPermuteIndices?.Handle ?? IntPtr.Zero, columnPermuteOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selEncodeToCommandBuffer_CopyDescriptor_RowPermuteIndices_RowPermuteOffset_ColumnPermuteIndices_ColumnPermuteOffset_Handle, commandBuffer.Handle, copyDescriptor.Handle, rowPermuteIndices?.Handle ?? IntPtr.Zero, rowPermuteOffset, columnPermuteIndices?.Handle ?? IntPtr.Zero, columnPermuteOffset);
		}
	}
}

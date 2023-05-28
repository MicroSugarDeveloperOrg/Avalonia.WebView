using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixCopyDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSMatrixCopyDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithSourceMatrix_DestinationMatrix_Offsets_ = "descriptorWithSourceMatrix:destinationMatrix:offsets:";

	private static readonly IntPtr selDescriptorWithSourceMatrix_DestinationMatrix_Offsets_Handle = Selector.GetHandle("descriptorWithSourceMatrix:destinationMatrix:offsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Count_ = "initWithDevice:count:";

	private static readonly IntPtr selInitWithDevice_Count_Handle = Selector.GetHandle("initWithDevice:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceMatrices_DestinationMatrices_OffsetVector_Offset_ = "initWithSourceMatrices:destinationMatrices:offsetVector:offset:";

	private static readonly IntPtr selInitWithSourceMatrices_DestinationMatrices_OffsetVector_Offset_Handle = Selector.GetHandle("initWithSourceMatrices:destinationMatrices:offsetVector:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCopyOperationAtIndex_SourceMatrix_DestinationMatrix_Offsets_ = "setCopyOperationAtIndex:sourceMatrix:destinationMatrix:offsets:";

	private static readonly IntPtr selSetCopyOperationAtIndex_SourceMatrix_DestinationMatrix_Offsets_Handle = Selector.GetHandle("setCopyOperationAtIndex:sourceMatrix:destinationMatrix:offsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixCopyDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSMatrixCopyDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixCopyDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:count:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixCopyDescriptor(IMTLDevice device, nuint count)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithDevice_Count_Handle, device.Handle, count), "initWithDevice:count:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithDevice_Count_Handle, device.Handle, count), "initWithDevice:count:");
		}
	}

	[Export("initWithSourceMatrices:destinationMatrices:offsetVector:offset:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixCopyDescriptor(MPSMatrix[] sourceMatrices, MPSMatrix[] destinationMatrices, MPSVector? offsets, nuint byteOffset)
		: base(NSObjectFlag.Empty)
	{
		if (sourceMatrices == null)
		{
			throw new ArgumentNullException("sourceMatrices");
		}
		if (destinationMatrices == null)
		{
			throw new ArgumentNullException("destinationMatrices");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceMatrices);
		NSArray nSArray2 = NSArray.FromNSObjects(destinationMatrices);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selInitWithSourceMatrices_DestinationMatrices_OffsetVector_Offset_Handle, nSArray.Handle, nSArray2.Handle, offsets?.Handle ?? IntPtr.Zero, byteOffset), "initWithSourceMatrices:destinationMatrices:offsetVector:offset:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selInitWithSourceMatrices_DestinationMatrices_OffsetVector_Offset_Handle, nSArray.Handle, nSArray2.Handle, offsets?.Handle ?? IntPtr.Zero, byteOffset), "initWithSourceMatrices:destinationMatrices:offsetVector:offset:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("descriptorWithSourceMatrix:destinationMatrix:offsets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixCopyDescriptor Create(MPSMatrix sourceMatrix, MPSMatrix destinationMatrix, MPSMatrixCopyOffsets offsets)
	{
		if (sourceMatrix == null)
		{
			throw new ArgumentNullException("sourceMatrix");
		}
		if (destinationMatrix == null)
		{
			throw new ArgumentNullException("destinationMatrix");
		}
		return Runtime.GetNSObject<MPSMatrixCopyDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_MPSMatrixCopyOffsets(class_ptr, selDescriptorWithSourceMatrix_DestinationMatrix_Offsets_Handle, sourceMatrix.Handle, destinationMatrix.Handle, offsets));
	}

	[Export("setCopyOperationAtIndex:sourceMatrix:destinationMatrix:offsets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCopyOperation(nuint index, MPSMatrix sourceMatrix, MPSMatrix destinationMatrix, MPSMatrixCopyOffsets offsets)
	{
		if (sourceMatrix == null)
		{
			throw new ArgumentNullException("sourceMatrix");
		}
		if (destinationMatrix == null)
		{
			throw new ArgumentNullException("destinationMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_IntPtr_IntPtr_MPSMatrixCopyOffsets(base.Handle, selSetCopyOperationAtIndex_SourceMatrix_DestinationMatrix_Offsets_Handle, index, sourceMatrix.Handle, destinationMatrix.Handle, offsets);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_IntPtr_IntPtr_MPSMatrixCopyOffsets(base.SuperHandle, selSetCopyOperationAtIndex_SourceMatrix_DestinationMatrix_Offsets_Handle, index, sourceMatrix.Handle, destinationMatrix.Handle, offsets);
		}
	}
}

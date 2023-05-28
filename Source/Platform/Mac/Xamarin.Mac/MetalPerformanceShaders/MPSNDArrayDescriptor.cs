using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNDArrayDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSNDArrayDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithDataType_DimensionCount_DimensionSizes_ = "descriptorWithDataType:dimensionCount:dimensionSizes:";

	private static readonly IntPtr selDescriptorWithDataType_DimensionCount_DimensionSizes_Handle = Selector.GetHandle("descriptorWithDataType:dimensionCount:dimensionSizes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithDataType_Shape_ = "descriptorWithDataType:shape:";

	private static readonly IntPtr selDescriptorWithDataType_Shape_Handle = Selector.GetHandle("descriptorWithDataType:shape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthOfDimension_ = "lengthOfDimension:";

	private static readonly IntPtr selLengthOfDimension_Handle = Selector.GetHandle("lengthOfDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfDimensions = "numberOfDimensions";

	private static readonly IntPtr selNumberOfDimensionsHandle = Selector.GetHandle("numberOfDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReshapeWithDimensionCount_DimensionSizes_ = "reshapeWithDimensionCount:dimensionSizes:";

	private static readonly IntPtr selReshapeWithDimensionCount_DimensionSizes_Handle = Selector.GetHandle("reshapeWithDimensionCount:dimensionSizes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReshapeWithShape_ = "reshapeWithShape:";

	private static readonly IntPtr selReshapeWithShape_Handle = Selector.GetHandle("reshapeWithShape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataType_ = "setDataType:";

	private static readonly IntPtr selSetDataType_Handle = Selector.GetHandle("setDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfDimensions_ = "setNumberOfDimensions:";

	private static readonly IntPtr selSetNumberOfDimensions_Handle = Selector.GetHandle("setNumberOfDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSliceDimension_WithSubrange_ = "sliceDimension:withSubrange:";

	private static readonly IntPtr selSliceDimension_WithSubrange_Handle = Selector.GetHandle("sliceDimension:withSubrange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSliceRangeForDimension_ = "sliceRangeForDimension:";

	private static readonly IntPtr selSliceRangeForDimension_Handle = Selector.GetHandle("sliceRangeForDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransposeDimension_WithDimension_ = "transposeDimension:withDimension:";

	private static readonly IntPtr selTransposeDimension_WithDimension_Handle = Selector.GetHandle("transposeDimension:withDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNDArrayDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataType DataType
	{
		[Export("dataType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MPSDataType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
		[Export("setDataType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetDataType_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetDataType_Handle, (uint)value);
			}
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
		[Export("setNumberOfDimensions:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfDimensions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfDimensions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNDArrayDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNDArrayDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("descriptorWithDataType:dimensionCount:dimensionSizes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNDArrayDescriptor Create(MPSDataType dataType, nuint numberOfDimensions, IntPtr dimensionSizes)
	{
		return Runtime.GetNSObject<MPSNDArrayDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32_nuint_IntPtr(class_ptr, selDescriptorWithDataType_DimensionCount_DimensionSizes_Handle, (uint)dataType, numberOfDimensions, dimensionSizes));
	}

	[Export("descriptorWithDataType:shape:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNDArrayDescriptor Create(MPSDataType dataType, [BindAs(typeof(nuint[]), OriginalType = typeof(NSNumber[]))] nuint[] shape)
	{
		if (shape == null)
		{
			throw new ArgumentNullException("shape");
		}
		NSArray nSArray = NSArray.FromNSObjects((nuint o) => new NSNumber(o), shape);
		MPSNDArrayDescriptor nSObject = Runtime.GetNSObject<MPSNDArrayDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr(class_ptr, selDescriptorWithDataType_Shape_Handle, (uint)dataType, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return nSObject;
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

	[Export("sliceRangeForDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDimensionSlice GetSliceRange(nuint dimensionIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.MPSDimensionSlice_objc_msgSend_nuint(base.Handle, selSliceRangeForDimension_Handle, dimensionIndex);
		}
		return Messaging.MPSDimensionSlice_objc_msgSendSuper_nuint(base.SuperHandle, selSliceRangeForDimension_Handle, dimensionIndex);
	}

	[Export("reshapeWithDimensionCount:dimensionSizes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reshape(nuint numberOfDimensions, IntPtr dimensionSizes)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_IntPtr(base.Handle, selReshapeWithDimensionCount_DimensionSizes_Handle, numberOfDimensions, dimensionSizes);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selReshapeWithDimensionCount_DimensionSizes_Handle, numberOfDimensions, dimensionSizes);
		}
	}

	[Export("reshapeWithShape:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reshape([BindAs(typeof(nuint[]), OriginalType = typeof(NSNumber[]))] nuint[] shape)
	{
		if (shape == null)
		{
			throw new ArgumentNullException("shape");
		}
		NSArray nSArray = NSArray.FromNSObjects((nuint o) => new NSNumber(o), shape);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReshapeWithShape_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReshapeWithShape_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		nSArray?.Dispose();
	}

	[Export("sliceDimension:withSubrange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Slice(nuint dimensionIndex, MPSDimensionSlice subRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_MPSDimensionSlice(base.Handle, selSliceDimension_WithSubrange_Handle, dimensionIndex, subRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_MPSDimensionSlice(base.SuperHandle, selSliceDimension_WithSubrange_Handle, dimensionIndex, subRange);
		}
	}

	[Export("transposeDimension:withDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Transpose(nuint dimensionIndex, nuint dimensionIndex2)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_nuint(base.Handle, selTransposeDimension_WithDimension_Handle, dimensionIndex, dimensionIndex2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_nuint(base.SuperHandle, selTransposeDimension_WithDimension_Handle, dimensionIndex, dimensionIndex2);
		}
	}
}

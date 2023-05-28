using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSRayIntersector", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSRayIntersector : MPSKernel, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBoxIntersectionTestType = "boundingBoxIntersectionTestType";

	private static readonly IntPtr selBoundingBoxIntersectionTestTypeHandle = Selector.GetHandle("boundingBoxIntersectionTestType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCullMode = "cullMode";

	private static readonly IntPtr selCullModeHandle = Selector.GetHandle("cullMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCount_AccelerationStructure_ = "encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCount:accelerationStructure:";

	private static readonly IntPtr selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCount_AccelerationStructure_Handle = Selector.GetHandle("encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCount:accelerationStructure:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCountBuffer_RayCountBufferOffset_AccelerationStructure_ = "encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCountBuffer:rayCountBufferOffset:accelerationStructure:";

	private static readonly IntPtr selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCountBuffer_RayCountBufferOffset_AccelerationStructure_Handle = Selector.GetHandle("encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCountBuffer:rayCountBufferOffset:accelerationStructure:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrontFacingWinding = "frontFacingWinding";

	private static readonly IntPtr selFrontFacingWindingHandle = Selector.GetHandle("frontFacingWinding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectionDataType = "intersectionDataType";

	private static readonly IntPtr selIntersectionDataTypeHandle = Selector.GetHandle("intersectionDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectionStride = "intersectionStride";

	private static readonly IntPtr selIntersectionStrideHandle = Selector.GetHandle("intersectionStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRayDataType = "rayDataType";

	private static readonly IntPtr selRayDataTypeHandle = Selector.GetHandle("rayDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRayMaskOptions = "rayMaskOptions";

	private static readonly IntPtr selRayMaskOptionsHandle = Selector.GetHandle("rayMaskOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRayStride = "rayStride";

	private static readonly IntPtr selRayStrideHandle = Selector.GetHandle("rayStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedMinimumRayBatchSizeForRayCount_ = "recommendedMinimumRayBatchSizeForRayCount:";

	private static readonly IntPtr selRecommendedMinimumRayBatchSizeForRayCount_Handle = Selector.GetHandle("recommendedMinimumRayBatchSizeForRayCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundingBoxIntersectionTestType_ = "setBoundingBoxIntersectionTestType:";

	private static readonly IntPtr selSetBoundingBoxIntersectionTestType_Handle = Selector.GetHandle("setBoundingBoxIntersectionTestType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCullMode_ = "setCullMode:";

	private static readonly IntPtr selSetCullMode_Handle = Selector.GetHandle("setCullMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrontFacingWinding_ = "setFrontFacingWinding:";

	private static readonly IntPtr selSetFrontFacingWinding_Handle = Selector.GetHandle("setFrontFacingWinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntersectionDataType_ = "setIntersectionDataType:";

	private static readonly IntPtr selSetIntersectionDataType_Handle = Selector.GetHandle("setIntersectionDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntersectionStride_ = "setIntersectionStride:";

	private static readonly IntPtr selSetIntersectionStride_Handle = Selector.GetHandle("setIntersectionStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRayDataType_ = "setRayDataType:";

	private static readonly IntPtr selSetRayDataType_Handle = Selector.GetHandle("setRayDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRayMaskOptions_ = "setRayMaskOptions:";

	private static readonly IntPtr selSetRayMaskOptions_Handle = Selector.GetHandle("setRayMaskOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRayStride_ = "setRayStride:";

	private static readonly IntPtr selSetRayStride_Handle = Selector.GetHandle("setRayStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTriangleIntersectionTestType_ = "setTriangleIntersectionTestType:";

	private static readonly IntPtr selSetTriangleIntersectionTestType_Handle = Selector.GetHandle("setTriangleIntersectionTestType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriangleIntersectionTestType = "triangleIntersectionTestType";

	private static readonly IntPtr selTriangleIntersectionTestTypeHandle = Selector.GetHandle("triangleIntersectionTestType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRayIntersector");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSBoundingBoxIntersectionTestType BoundingBoxIntersectionTestType
	{
		[Export("boundingBoxIntersectionTestType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSBoundingBoxIntersectionTestType)Messaging.UInt64_objc_msgSend(base.Handle, selBoundingBoxIntersectionTestTypeHandle);
			}
			return (MPSBoundingBoxIntersectionTestType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBoundingBoxIntersectionTestTypeHandle);
		}
		[Export("setBoundingBoxIntersectionTestType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBoundingBoxIntersectionTestType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBoundingBoxIntersectionTestType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLCullMode CullMode
	{
		[Export("cullMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCullMode)Messaging.UInt64_objc_msgSend(base.Handle, selCullModeHandle);
			}
			return (MTLCullMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCullModeHandle);
		}
		[Export("setCullMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCullMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCullMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLWinding FrontFacingWinding
	{
		[Export("frontFacingWinding", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLWinding)Messaging.UInt64_objc_msgSend(base.Handle, selFrontFacingWindingHandle);
			}
			return (MTLWinding)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFrontFacingWindingHandle);
		}
		[Export("setFrontFacingWinding:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFrontFacingWinding_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFrontFacingWinding_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSIntersectionDataType IntersectionDataType
	{
		[Export("intersectionDataType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSIntersectionDataType)Messaging.UInt64_objc_msgSend(base.Handle, selIntersectionDataTypeHandle);
			}
			return (MPSIntersectionDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selIntersectionDataTypeHandle);
		}
		[Export("setIntersectionDataType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetIntersectionDataType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetIntersectionDataType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IntersectionStride
	{
		[Export("intersectionStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selIntersectionStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selIntersectionStrideHandle);
		}
		[Export("setIntersectionStride:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetIntersectionStride_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetIntersectionStride_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRayDataType RayDataType
	{
		[Export("rayDataType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSRayDataType)Messaging.UInt64_objc_msgSend(base.Handle, selRayDataTypeHandle);
			}
			return (MPSRayDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRayDataTypeHandle);
		}
		[Export("setRayDataType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRayDataType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRayDataType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSRayMaskOptions RayMaskOptions
	{
		[Export("rayMaskOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSRayMaskOptions)Messaging.UInt64_objc_msgSend(base.Handle, selRayMaskOptionsHandle);
			}
			return (MPSRayMaskOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRayMaskOptionsHandle);
		}
		[Export("setRayMaskOptions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRayMaskOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRayMaskOptions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint RayStride
	{
		[Export("rayStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRayStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRayStrideHandle);
		}
		[Export("setRayStride:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRayStride_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRayStride_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSTriangleIntersectionTestType TriangleIntersectionTestType
	{
		[Export("triangleIntersectionTestType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSTriangleIntersectionTestType)Messaging.UInt64_objc_msgSend(base.Handle, selTriangleIntersectionTestTypeHandle);
			}
			return (MPSTriangleIntersectionTestType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTriangleIntersectionTestTypeHandle);
		}
		[Export("setTriangleIntersectionTestType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTriangleIntersectionTestType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTriangleIntersectionTestType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSRayIntersector(NSCoder coder)
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
	protected MPSRayIntersector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRayIntersector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRayIntersector(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRayIntersector(NSCoder aDecoder, IMTLDevice device)
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

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSRayIntersector Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSRayIntersector mPSRayIntersector = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSRayIntersector>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSRayIntersector>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSRayIntersector != null)
		{
			Messaging.void_objc_msgSend(mPSRayIntersector.Handle, Selector.GetHandle("release"));
		}
		return mPSRayIntersector;
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(NSCoder coder)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, coder.Handle);
		}
	}

	[Export("encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCount:accelerationStructure:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeIntersection(IMTLCommandBuffer commandBuffer, MPSIntersectionType intersectionType, IMTLBuffer rayBuffer, nuint rayBufferOffset, IMTLBuffer intersectionBuffer, nuint intersectionBufferOffset, nuint rayCount, MPSAccelerationStructure accelerationStructure)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (rayBuffer == null)
		{
			throw new ArgumentNullException("rayBuffer");
		}
		if (intersectionBuffer == null)
		{
			throw new ArgumentNullException("intersectionBuffer");
		}
		if (accelerationStructure == null)
		{
			throw new ArgumentNullException("accelerationStructure");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_nuint_IntPtr_nuint_nuint_IntPtr(base.Handle, selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCount_AccelerationStructure_Handle, commandBuffer.Handle, (ulong)intersectionType, rayBuffer.Handle, rayBufferOffset, intersectionBuffer.Handle, intersectionBufferOffset, rayCount, accelerationStructure.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_nuint_IntPtr_nuint_nuint_IntPtr(base.SuperHandle, selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCount_AccelerationStructure_Handle, commandBuffer.Handle, (ulong)intersectionType, rayBuffer.Handle, rayBufferOffset, intersectionBuffer.Handle, intersectionBufferOffset, rayCount, accelerationStructure.Handle);
		}
	}

	[Export("encodeIntersectionToCommandBuffer:intersectionType:rayBuffer:rayBufferOffset:intersectionBuffer:intersectionBufferOffset:rayCountBuffer:rayCountBufferOffset:accelerationStructure:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeIntersection(IMTLCommandBuffer commandBuffer, MPSIntersectionType intersectionType, IMTLBuffer rayBuffer, nuint rayBufferOffset, IMTLBuffer intersectionBuffer, nuint intersectionBufferOffset, IMTLBuffer rayCountBuffer, nuint rayCountBufferOffset, MPSAccelerationStructure accelerationStructure)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (rayBuffer == null)
		{
			throw new ArgumentNullException("rayBuffer");
		}
		if (intersectionBuffer == null)
		{
			throw new ArgumentNullException("intersectionBuffer");
		}
		if (rayCountBuffer == null)
		{
			throw new ArgumentNullException("rayCountBuffer");
		}
		if (accelerationStructure == null)
		{
			throw new ArgumentNullException("accelerationStructure");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_nuint_IntPtr_nuint_IntPtr_nuint_IntPtr(base.Handle, selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCountBuffer_RayCountBufferOffset_AccelerationStructure_Handle, commandBuffer.Handle, (ulong)intersectionType, rayBuffer.Handle, rayBufferOffset, intersectionBuffer.Handle, intersectionBufferOffset, rayCountBuffer.Handle, rayCountBufferOffset, accelerationStructure.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_nuint_IntPtr_nuint_IntPtr_nuint_IntPtr(base.SuperHandle, selEncodeIntersectionToCommandBuffer_IntersectionType_RayBuffer_RayBufferOffset_IntersectionBuffer_IntersectionBufferOffset_RayCountBuffer_RayCountBufferOffset_AccelerationStructure_Handle, commandBuffer.Handle, (ulong)intersectionType, rayBuffer.Handle, rayBufferOffset, intersectionBuffer.Handle, intersectionBufferOffset, rayCountBuffer.Handle, rayCountBufferOffset, accelerationStructure.Handle);
		}
	}

	[Export("recommendedMinimumRayBatchSizeForRayCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetRecommendedMinimumRayBatchSize(nuint rayCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selRecommendedMinimumRayBatchSizeForRayCount_Handle, rayCount);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selRecommendedMinimumRayBatchSizeForRayCount_Handle, rayCount);
	}
}

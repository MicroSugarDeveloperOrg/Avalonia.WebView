using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageFindKeypoints", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSImageFindKeypoints : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceTexture_Regions_NumberOfRegions_KeypointCountBuffer_KeypointCountBufferOffset_KeypointDataBuffer_KeypointDataBufferOffset_ = "encodeToCommandBuffer:sourceTexture:regions:numberOfRegions:keypointCountBuffer:keypointCountBufferOffset:keypointDataBuffer:keypointDataBufferOffset:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceTexture_Regions_NumberOfRegions_KeypointCountBuffer_KeypointCountBufferOffset_KeypointDataBuffer_KeypointDataBufferOffset_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceTexture:regions:numberOfRegions:keypointCountBuffer:keypointCountBufferOffset:keypointDataBuffer:keypointDataBufferOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Info_ = "initWithDevice:info:";

	private static readonly IntPtr selInitWithDevice_Info_Handle = Selector.GetHandle("initWithDevice:info:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeypointRangeInfo = "keypointRangeInfo";

	private static readonly IntPtr selKeypointRangeInfoHandle = Selector.GetHandle("keypointRangeInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageFindKeypoints");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageKeypointRangeInfo KeypointRangeInfo
	{
		[Export("keypointRangeInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.MPSImageKeypointRangeInfo_objc_msgSend(base.Handle, selKeypointRangeInfoHandle);
			}
			return Messaging.MPSImageKeypointRangeInfo_objc_msgSendSuper(base.SuperHandle, selKeypointRangeInfoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageFindKeypoints(NSCoder coder)
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
	protected MPSImageFindKeypoints(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageFindKeypoints(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:info:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageFindKeypoints(IMTLDevice device, MPSImageKeypointRangeInfo info)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MPSImageKeypointRangeInfo(base.Handle, selInitWithDevice_Info_Handle, device.Handle, info), "initWithDevice:info:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MPSImageKeypointRangeInfo(base.SuperHandle, selInitWithDevice_Info_Handle, device.Handle, info), "initWithDevice:info:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageFindKeypoints(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceTexture:regions:numberOfRegions:keypointCountBuffer:keypointCountBufferOffset:keypointDataBuffer:keypointDataBufferOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture source, MTLRegion regions, nuint numberOfRegions, IMTLBuffer keypointCountBuffer, nuint keypointCountBufferOffset, IMTLBuffer keypointDataBuffer, nuint keypointDataBufferOffset)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keypointCountBuffer == null)
		{
			throw new ArgumentNullException("keypointCountBuffer");
		}
		if (keypointDataBuffer == null)
		{
			throw new ArgumentNullException("keypointDataBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_MTLRegion_nuint_IntPtr_nuint_IntPtr_nuint(base.Handle, selEncodeToCommandBuffer_SourceTexture_Regions_NumberOfRegions_KeypointCountBuffer_KeypointCountBufferOffset_KeypointDataBuffer_KeypointDataBufferOffset_Handle, commandBuffer.Handle, source.Handle, regions, numberOfRegions, keypointCountBuffer.Handle, keypointCountBufferOffset, keypointDataBuffer.Handle, keypointDataBufferOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_MTLRegion_nuint_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selEncodeToCommandBuffer_SourceTexture_Regions_NumberOfRegions_KeypointCountBuffer_KeypointCountBufferOffset_KeypointDataBuffer_KeypointDataBufferOffset_Handle, commandBuffer.Handle, source.Handle, regions, numberOfRegions, keypointCountBuffer.Handle, keypointCountBufferOffset, keypointDataBuffer.Handle, keypointDataBufferOffset);
		}
	}
}

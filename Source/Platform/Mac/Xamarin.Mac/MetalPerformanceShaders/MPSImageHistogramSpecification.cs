using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImageHistogramSpecification", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageHistogramSpecification : MPSUnaryImageKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeTransformToCommandBuffer_SourceTexture_SourceHistogram_SourceHistogramOffset_DesiredHistogram_DesiredHistogramOffset_ = "encodeTransformToCommandBuffer:sourceTexture:sourceHistogram:sourceHistogramOffset:desiredHistogram:desiredHistogramOffset:";

	private static readonly IntPtr selEncodeTransformToCommandBuffer_SourceTexture_SourceHistogram_SourceHistogramOffset_DesiredHistogram_DesiredHistogramOffset_Handle = Selector.GetHandle("encodeTransformToCommandBuffer:sourceTexture:sourceHistogram:sourceHistogramOffset:desiredHistogram:desiredHistogramOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHistogramInfo = "histogramInfo";

	private static readonly IntPtr selHistogramInfoHandle = Selector.GetHandle("histogramInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_HistogramInfo_ = "initWithDevice:histogramInfo:";

	private static readonly IntPtr selInitWithDevice_HistogramInfo_Handle = Selector.GetHandle("initWithDevice:histogramInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageHistogramSpecification");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageHistogramInfo HistogramInfo
	{
		[Export("histogramInfo")]
		get
		{
			MPSImageHistogramInfo retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__MPSImageHistogramInfo_objc_msgSend_stret(out retval, base.Handle, selHistogramInfoHandle);
			}
			else
			{
				Messaging.xamarin_simd__MPSImageHistogramInfo_objc_msgSendSuper_stret(out retval, base.SuperHandle, selHistogramInfoHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageHistogramSpecification(NSCoder coder)
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
	protected MPSImageHistogramSpecification(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageHistogramSpecification(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:histogramInfo:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageHistogramSpecification(IMTLDevice device, ref MPSImageHistogramInfo histogramInfo)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_ref_MPSImageHistogramInfo(base.Handle, selInitWithDevice_HistogramInfo_Handle, device.Handle, ref histogramInfo), "initWithDevice:histogramInfo:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_ref_MPSImageHistogramInfo(base.SuperHandle, selInitWithDevice_HistogramInfo_Handle, device.Handle, ref histogramInfo), "initWithDevice:histogramInfo:");
		}
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageHistogramSpecification(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeTransformToCommandBuffer:sourceTexture:sourceHistogram:sourceHistogramOffset:desiredHistogram:desiredHistogramOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTransformToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture source, IMTLBuffer sourceHistogram, nuint sourceHistogramOffset, IMTLBuffer desiredHistogram, nuint desiredHistogramOffset)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (sourceHistogram == null)
		{
			throw new ArgumentNullException("sourceHistogram");
		}
		if (desiredHistogram == null)
		{
			throw new ArgumentNullException("desiredHistogram");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint(base.Handle, selEncodeTransformToCommandBuffer_SourceTexture_SourceHistogram_SourceHistogramOffset_DesiredHistogram_DesiredHistogramOffset_Handle, commandBuffer.Handle, source.Handle, sourceHistogram.Handle, sourceHistogramOffset, desiredHistogram.Handle, desiredHistogramOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selEncodeTransformToCommandBuffer_SourceTexture_SourceHistogram_SourceHistogramOffset_DesiredHistogram_DesiredHistogramOffset_Handle, commandBuffer.Handle, source.Handle, sourceHistogram.Handle, sourceHistogramOffset, desiredHistogram.Handle, desiredHistogramOffset);
		}
	}
}

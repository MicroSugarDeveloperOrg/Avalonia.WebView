using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImageHistogram", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageHistogram : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRectSource = "clipRectSource";

	private static readonly IntPtr selClipRectSourceHandle = Selector.GetHandle("clipRectSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceTexture_Histogram_HistogramOffset_ = "encodeToCommandBuffer:sourceTexture:histogram:histogramOffset:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceTexture_Histogram_HistogramOffset_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceTexture:histogram:histogramOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHistogramInfo = "histogramInfo";

	private static readonly IntPtr selHistogramInfoHandle = Selector.GetHandle("histogramInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHistogramSizeForSourceFormat_ = "histogramSizeForSourceFormat:";

	private static readonly IntPtr selHistogramSizeForSourceFormat_Handle = Selector.GetHandle("histogramSizeForSourceFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_HistogramInfo_ = "initWithDevice:histogramInfo:";

	private static readonly IntPtr selInitWithDevice_HistogramInfo_Handle = Selector.GetHandle("initWithDevice:histogramInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinPixelThresholdValue = "minPixelThresholdValue";

	private static readonly IntPtr selMinPixelThresholdValueHandle = Selector.GetHandle("minPixelThresholdValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClipRectSource_ = "setClipRectSource:";

	private static readonly IntPtr selSetClipRectSource_Handle = Selector.GetHandle("setClipRectSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinPixelThresholdValue_ = "setMinPixelThresholdValue:";

	private static readonly IntPtr selSetMinPixelThresholdValue_Handle = Selector.GetHandle("setMinPixelThresholdValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroHistogram_ = "setZeroHistogram:";

	private static readonly IntPtr selSetZeroHistogram_Handle = Selector.GetHandle("setZeroHistogram:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroHistogram = "zeroHistogram";

	private static readonly IntPtr selZeroHistogramHandle = Selector.GetHandle("zeroHistogram");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageHistogram");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion ClipRectSource
	{
		[Export("clipRectSource", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selClipRectSourceHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClipRectSourceHandle);
			}
			return retval;
		}
		[Export("setClipRectSource:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetClipRectSource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetClipRectSource_Handle, value);
			}
		}
	}

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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual Vector4 MinPixelThresholdValue
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("minPixelThresholdValue", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector4_objc_msgSend(base.Handle, selMinPixelThresholdValueHandle);
			}
			return Messaging.xamarin_simd__Vector4_objc_msgSendSuper(base.SuperHandle, selMinPixelThresholdValueHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setMinPixelThresholdValue:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector4(base.Handle, selSetMinPixelThresholdValue_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetMinPixelThresholdValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ZeroHistogram
	{
		[Export("zeroHistogram")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selZeroHistogramHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selZeroHistogramHandle);
		}
		[Export("setZeroHistogram:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetZeroHistogram_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetZeroHistogram_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageHistogram(NSCoder coder)
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
	protected MPSImageHistogram(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageHistogram(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageHistogram(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:histogramInfo:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageHistogram(IMTLDevice device, ref MPSImageHistogramInfo histogramInfo)
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

	[Export("encodeToCommandBuffer:sourceTexture:histogram:histogramOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, IMTLTexture source, IMTLBuffer histogram, nuint histogramOffset)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (histogram == null)
		{
			throw new ArgumentNullException("histogram");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selEncodeToCommandBuffer_SourceTexture_Histogram_HistogramOffset_Handle, commandBuffer.Handle, source.Handle, histogram.Handle, histogramOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selEncodeToCommandBuffer_SourceTexture_Histogram_HistogramOffset_Handle, commandBuffer.Handle, source.Handle, histogram.Handle, histogramOffset);
		}
	}

	[Export("histogramSizeForSourceFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetHistogramSize(MTLPixelFormat sourceFormat)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_UInt64(base.Handle, selHistogramSizeForSourceFormat_Handle, (ulong)sourceFormat);
		}
		return Messaging.nuint_objc_msgSendSuper_UInt64(base.SuperHandle, selHistogramSizeForSourceFormat_Handle, (ulong)sourceFormat);
	}
}

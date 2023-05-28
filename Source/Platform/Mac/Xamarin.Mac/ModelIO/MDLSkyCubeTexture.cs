using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLSkyCubeTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLSkyCubeTexture : MDLTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrightness = "brightness";

	private static readonly IntPtr selBrightnessHandle = Selector.GetHandle("brightness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContrast = "contrast";

	private static readonly IntPtr selContrastHandle = Selector.GetHandle("contrast");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposure = "exposure";

	private static readonly IntPtr selExposureHandle = Selector.GetHandle("exposure");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGamma = "gamma";

	private static readonly IntPtr selGammaHandle = Selector.GetHandle("gamma");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroundAlbedo = "groundAlbedo";

	private static readonly IntPtr selGroundAlbedoHandle = Selector.GetHandle("groundAlbedo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroundColor = "groundColor";

	private static readonly IntPtr selGroundColorHandle = Selector.GetHandle("groundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighDynamicRangeCompression = "highDynamicRangeCompression";

	private static readonly IntPtr selHighDynamicRangeCompressionHandle = Selector.GetHandle("highDynamicRangeCompression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizonElevation = "horizonElevation";

	private static readonly IntPtr selHorizonElevationHandle = Selector.GetHandle("horizonElevation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_ = "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:";

	private static readonly IntPtr selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_Handle = Selector.GetHandle("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_ = "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:";

	private static readonly IntPtr selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_Handle = Selector.GetHandle("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaturation = "saturation";

	private static readonly IntPtr selSaturationHandle = Selector.GetHandle("saturation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBrightness_ = "setBrightness:";

	private static readonly IntPtr selSetBrightness_Handle = Selector.GetHandle("setBrightness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContrast_ = "setContrast:";

	private static readonly IntPtr selSetContrast_Handle = Selector.GetHandle("setContrast:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExposure_ = "setExposure:";

	private static readonly IntPtr selSetExposure_Handle = Selector.GetHandle("setExposure:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGamma_ = "setGamma:";

	private static readonly IntPtr selSetGamma_Handle = Selector.GetHandle("setGamma:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroundAlbedo_ = "setGroundAlbedo:";

	private static readonly IntPtr selSetGroundAlbedo_Handle = Selector.GetHandle("setGroundAlbedo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroundColor_ = "setGroundColor:";

	private static readonly IntPtr selSetGroundColor_Handle = Selector.GetHandle("setGroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighDynamicRangeCompression_ = "setHighDynamicRangeCompression:";

	private static readonly IntPtr selSetHighDynamicRangeCompression_Handle = Selector.GetHandle("setHighDynamicRangeCompression:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizonElevation_ = "setHorizonElevation:";

	private static readonly IntPtr selSetHorizonElevation_Handle = Selector.GetHandle("setHorizonElevation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSaturation_ = "setSaturation:";

	private static readonly IntPtr selSetSaturation_Handle = Selector.GetHandle("setSaturation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSunAzimuth_ = "setSunAzimuth:";

	private static readonly IntPtr selSetSunAzimuth_Handle = Selector.GetHandle("setSunAzimuth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSunElevation_ = "setSunElevation:";

	private static readonly IntPtr selSetSunElevation_Handle = Selector.GetHandle("setSunElevation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTurbidity_ = "setTurbidity:";

	private static readonly IntPtr selSetTurbidity_Handle = Selector.GetHandle("setTurbidity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpperAtmosphereScattering_ = "setUpperAtmosphereScattering:";

	private static readonly IntPtr selSetUpperAtmosphereScattering_Handle = Selector.GetHandle("setUpperAtmosphereScattering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSunAzimuth = "sunAzimuth";

	private static readonly IntPtr selSunAzimuthHandle = Selector.GetHandle("sunAzimuth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSunElevation = "sunElevation";

	private static readonly IntPtr selSunElevationHandle = Selector.GetHandle("sunElevation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurbidity = "turbidity";

	private static readonly IntPtr selTurbidityHandle = Selector.GetHandle("turbidity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTexture = "updateTexture";

	private static readonly IntPtr selUpdateTextureHandle = Selector.GetHandle("updateTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpperAtmosphereScattering = "upperAtmosphereScattering";

	private static readonly IntPtr selUpperAtmosphereScatteringHandle = Selector.GetHandle("upperAtmosphereScattering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLSkyCubeTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Brightness
	{
		[Export("brightness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBrightnessHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBrightnessHandle);
		}
		[Export("setBrightness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBrightness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBrightness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Contrast
	{
		[Export("contrast")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selContrastHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selContrastHandle);
		}
		[Export("setContrast:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetContrast_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetContrast_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Exposure
	{
		[Export("exposure")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selExposureHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selExposureHandle);
		}
		[Export("setExposure:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetExposure_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetExposure_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Gamma
	{
		[Export("gamma")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGammaHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGammaHandle);
		}
		[Export("setGamma:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGamma_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGamma_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GroundAlbedo
	{
		[Export("groundAlbedo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGroundAlbedoHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGroundAlbedoHandle);
		}
		[Export("setGroundAlbedo:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGroundAlbedo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGroundAlbedo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? GroundColor
	{
		[Export("groundColor", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroundColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selGroundColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setGroundColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 HighDynamicRangeCompression
	{
		[Export("highDynamicRangeCompression", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selHighDynamicRangeCompressionHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selHighDynamicRangeCompressionHandle);
		}
		[Export("setHighDynamicRangeCompression:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetHighDynamicRangeCompression_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetHighDynamicRangeCompression_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HorizonElevation
	{
		[Export("horizonElevation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHorizonElevationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHorizonElevationHandle);
		}
		[Export("setHorizonElevation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHorizonElevation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHorizonElevation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Saturation
	{
		[Export("saturation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSaturationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSaturationHandle);
		}
		[Export("setSaturation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSaturation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSaturation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual float SunAzimuth
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("sunAzimuth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSunAzimuthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSunAzimuthHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setSunAzimuth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSunAzimuth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSunAzimuth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SunElevation
	{
		[Export("sunElevation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSunElevationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSunElevationHandle);
		}
		[Export("setSunElevation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSunElevation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSunElevation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Turbidity
	{
		[Export("turbidity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTurbidityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTurbidityHandle);
		}
		[Export("setTurbidity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetTurbidity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetTurbidity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float UpperAtmosphereScattering
	{
		[Export("upperAtmosphereScattering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selUpperAtmosphereScatteringHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selUpperAtmosphereScatteringHandle);
		}
		[Export("setUpperAtmosphereScattering:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetUpperAtmosphereScattering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetUpperAtmosphereScattering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLSkyCubeTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLSkyCubeTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSkyCubeTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool(base.Handle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle, pixelData?.Handle ?? IntPtr.Zero, topLeftOrigin, arg, dimensions, rowStride, channelCount, (long)channelEncoding, isCube), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool(base.SuperHandle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle, pixelData?.Handle ?? IntPtr.Zero, topLeftOrigin, arg, dimensions, rowStride, channelCount, (long)channelEncoding, isCube), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSkyCubeTexture(string? name, MDLTextureChannelEncoding channelEncoding, Vector2i textureDimensions, float turbidity, float sunElevation, float upperAtmosphereScattering, float groundAlbedo)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Int64_Vector2i_float_float_float_float(base.Handle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_Handle, arg, (long)channelEncoding, textureDimensions, turbidity, sunElevation, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Int64_Vector2i_float_float_float_float(base.SuperHandle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_UpperAtmosphereScattering_GroundAlbedo_Handle, arg, (long)channelEncoding, textureDimensions, turbidity, sunElevation, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSkyCubeTexture(string? name, MDLTextureChannelEncoding channelEncoding, Vector2i textureDimensions, float turbidity, float sunElevation, float sunAzimuth, float upperAtmosphereScattering, float groundAlbedo)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Int64_Vector2i_float_float_float_float_float(base.Handle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_Handle, arg, (long)channelEncoding, textureDimensions, turbidity, sunElevation, sunAzimuth, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Int64_Vector2i_float_float_float_float_float(base.SuperHandle, selInitWithName_ChannelEncoding_TextureDimensions_Turbidity_SunElevation_SunAzimuth_UpperAtmosphereScattering_GroundAlbedo_Handle, arg, (long)channelEncoding, textureDimensions, turbidity, sunElevation, sunAzimuth, upperAtmosphereScattering, groundAlbedo), "initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updateTexture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateTexture()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateTextureHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateTextureHandle);
		}
	}
}

using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLColorSwatchTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLColorSwatchTexture : MDLTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColorGradientFrom_ToColor_Name_TextureDimensions_ = "initWithColorGradientFrom:toColor:name:textureDimensions:";

	private static readonly IntPtr selInitWithColorGradientFrom_ToColor_Name_TextureDimensions_Handle = Selector.GetHandle("initWithColorGradientFrom:toColor:name:textureDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColorTemperatureGradientFrom_ToColorTemperature_Name_TextureDimensions_ = "initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:";

	private static readonly IntPtr selInitWithColorTemperatureGradientFrom_ToColorTemperature_Name_TextureDimensions_Handle = Selector.GetHandle("initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLColorSwatchTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLColorSwatchTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLColorSwatchTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLColorSwatchTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
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

	[Export("initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLColorSwatchTexture(float colorTemperature1, float colorTemperature2, string? name, Vector2i textureDimensions)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_float_IntPtr_Vector2i(base.Handle, selInitWithColorTemperatureGradientFrom_ToColorTemperature_Name_TextureDimensions_Handle, colorTemperature1, colorTemperature2, arg, textureDimensions), "initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_float_IntPtr_Vector2i(base.SuperHandle, selInitWithColorTemperatureGradientFrom_ToColorTemperature_Name_TextureDimensions_Handle, colorTemperature1, colorTemperature2, arg, textureDimensions), "initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithColorGradientFrom:toColor:name:textureDimensions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLColorSwatchTexture(CGColor color1, CGColor color2, string? name, Vector2i textureDimensions)
		: base(NSObjectFlag.Empty)
	{
		if (color1 == null)
		{
			throw new ArgumentNullException("color1");
		}
		if (color2 == null)
		{
			throw new ArgumentNullException("color2");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Vector2i(base.Handle, selInitWithColorGradientFrom_ToColor_Name_TextureDimensions_Handle, color1.Handle, color2.Handle, arg, textureDimensions), "initWithColorGradientFrom:toColor:name:textureDimensions:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Vector2i(base.SuperHandle, selInitWithColorGradientFrom_ToColor_Name_TextureDimensions_Handle, color1.Handle, color2.Handle, arg, textureDimensions), "initWithColorGradientFrom:toColor:name:textureDimensions:");
		}
		NSString.ReleaseNative(arg);
	}
}

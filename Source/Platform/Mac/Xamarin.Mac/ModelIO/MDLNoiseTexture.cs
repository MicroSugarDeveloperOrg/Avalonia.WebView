using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLNoiseTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLNoiseTexture : MDLTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_ = "initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:";

	private static readonly IntPtr selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_Handle = Selector.GetHandle("initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_ = "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:";

	private static readonly IntPtr selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_Handle = Selector.GetHandle("initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_ = "initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:";

	private static readonly IntPtr selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_Handle = Selector.GetHandle("initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLNoiseTexture");

	public override IntPtr ClassHandle => class_ptr;

	[iOS(9, 0)]
	[Mac(10, 11)]
	public MDLNoiseTexture(float input, string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding)
		: this(input, name, textureDimensions, channelEncoding, MDLNoiseTextureType.Vector)
	{
	}

	[iOS(10, 2)]
	[Mac(10, 12)]
	public MDLNoiseTexture(float input, string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding, MDLNoiseTextureType type)
	{
		switch (type)
		{
		case MDLNoiseTextureType.Vector:
			base.Handle = InitVectorNoiseWithSmoothness(input, name, textureDimensions, channelEncoding);
			break;
		case MDLNoiseTextureType.Cellular:
			base.Handle = InitCellularNoiseWithFrequency(input, name, textureDimensions, channelEncoding);
			break;
		default:
			throw new ArgumentException("type");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLNoiseTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLNoiseTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLNoiseTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
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

	[Export("initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLNoiseTexture(float smoothness, string? name, Vector2i textureDimensions, int channelCount, MDLTextureChannelEncoding channelEncoding, bool grayscale)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_Int64_bool(base.Handle, selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_Handle, smoothness, arg, textureDimensions, channelCount, (long)channelEncoding, grayscale), "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_Int64_bool(base.SuperHandle, selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_Handle, smoothness, arg, textureDimensions, channelCount, (long)channelEncoding, grayscale), "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitCellularNoiseWithFrequency(float frequency, string? name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding)
	{
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_Int64(base.SuperHandle, selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_Handle, frequency, arg, textureDimensions, (long)channelEncoding) : Messaging.xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_Int64(base.Handle, selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_Handle, frequency, arg, textureDimensions, (long)channelEncoding));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitVectorNoiseWithSmoothness(float smoothness, string? name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding)
	{
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_Int64(base.SuperHandle, selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_Handle, smoothness, arg, textureDimensions, (long)channelEncoding) : Messaging.xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_Int64(base.Handle, selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_Handle, smoothness, arg, textureDimensions, (long)channelEncoding));
		NSString.ReleaseNative(arg);
		return result;
	}
}

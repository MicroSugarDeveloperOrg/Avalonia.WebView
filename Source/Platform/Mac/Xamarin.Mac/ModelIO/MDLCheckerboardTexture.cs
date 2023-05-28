using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLCheckerboardTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLCheckerboardTexture : MDLTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor1 = "color1";

	private static readonly IntPtr selColor1Handle = Selector.GetHandle("color1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor2 = "color2";

	private static readonly IntPtr selColor2Handle = Selector.GetHandle("color2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDivisions = "divisions";

	private static readonly IntPtr selDivisionsHandle = Selector.GetHandle("divisions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDivisions_Name_Dimensions_ChannelCount_ChannelEncoding_Color1_Color2_ = "initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:";

	private static readonly IntPtr selInitWithDivisions_Name_Dimensions_ChannelCount_ChannelEncoding_Color1_Color2_Handle = Selector.GetHandle("initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor1_ = "setColor1:";

	private static readonly IntPtr selSetColor1_Handle = Selector.GetHandle("setColor1:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor2_ = "setColor2:";

	private static readonly IntPtr selSetColor2_Handle = Selector.GetHandle("setColor2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDivisions_ = "setDivisions:";

	private static readonly IntPtr selSetDivisions_Handle = Selector.GetHandle("setDivisions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLCheckerboardTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? Color1
	{
		[Export("color1", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColor1Handle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColor1Handle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setColor1:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor1_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor1_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? Color2
	{
		[Export("color2", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColor2Handle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColor2Handle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setColor2:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor2_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor2_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Divisions
	{
		[Export("divisions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selDivisionsHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selDivisionsHandle);
		}
		[Export("setDivisions:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetDivisions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetDivisions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLCheckerboardTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLCheckerboardTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLCheckerboardTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
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

	[Export("initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLCheckerboardTexture(float divisions, string? name, Vector2i dimensions, int channelCount, MDLTextureChannelEncoding channelEncoding, CGColor color1, CGColor color2)
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
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_Int64_IntPtr_IntPtr(base.Handle, selInitWithDivisions_Name_Dimensions_ChannelCount_ChannelEncoding_Color1_Color2_Handle, divisions, arg, dimensions, channelCount, (long)channelEncoding, color1.Handle, color2.Handle), "initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_Int64_IntPtr_IntPtr(base.SuperHandle, selInitWithDivisions_Name_Dimensions_ChannelCount_ChannelEncoding_Color1_Color2_Handle, divisions, arg, dimensions, channelCount, (long)channelEncoding, color1.Handle, color2.Handle), "initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:");
		}
		NSString.ReleaseNative(arg);
	}
}

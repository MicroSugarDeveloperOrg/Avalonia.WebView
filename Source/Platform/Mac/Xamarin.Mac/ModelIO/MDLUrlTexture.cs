using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLURLTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLUrlTexture : MDLTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Name_ = "initWithURL:name:";

	private static readonly IntPtr selInitWithURL_Name_Handle = Selector.GetHandle("initWithURL:name:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLURLTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLUrlTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLUrlTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLUrlTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
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

	[Export("initWithURL:name:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLUrlTexture(NSUrl url, string? name)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Name_Handle, url.Handle, arg), "initWithURL:name:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Name_Handle, url.Handle, arg), "initWithURL:name:");
		}
		NSString.ReleaseNative(arg);
	}
}

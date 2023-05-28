using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDeviceFormat", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class AVCaptureDeviceFormat : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoFocusSystem = "autoFocusSystem";

	private static readonly IntPtr selAutoFocusSystemHandle = Selector.GetHandle("autoFocusSystem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescription = "formatDescription";

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedColorSpaces = "supportedColorSpaces";

	private static readonly IntPtr selSupportedColorSpacesHandle = Selector.GetHandle("supportedColorSpaces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoSupportedFrameRateRanges = "videoSupportedFrameRateRanges";

	private static readonly IntPtr selVideoSupportedFrameRateRangesHandle = Selector.GetHandle("videoSupportedFrameRateRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureDeviceFormat");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual AVCaptureAutoFocusSystem AutoFocusSystem
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("autoFocusSystem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVCaptureAutoFocusSystem)Messaging.Int64_objc_msgSend(base.Handle, selAutoFocusSystemHandle);
			}
			return (AVCaptureAutoFocusSystem)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAutoFocusSystemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMFormatDescription FormatDescription
	{
		[Export("formatDescription", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return CMFormatDescription.Create(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle));
			}
			return CMFormatDescription.Create(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString MediaType
	{
		[Export("mediaType", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual NSNumber[] SupportedColorSpaces
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("supportedColorSpaces")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedColorSpacesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedColorSpacesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVFrameRateRange[] VideoSupportedFrameRateRanges
	{
		[Export("videoSupportedFrameRateRanges", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVFrameRateRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSupportedFrameRateRangesHandle));
			}
			return NSArray.ArrayFromHandle<AVFrameRateRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSupportedFrameRateRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureDeviceFormat(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureDeviceFormat(IntPtr handle)
		: base(handle)
	{
	}
}

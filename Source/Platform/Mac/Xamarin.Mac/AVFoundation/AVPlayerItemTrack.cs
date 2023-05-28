using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemTrack", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerItemTrack : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetTrack = "assetTrack";

	private static readonly IntPtr selAssetTrackHandle = Selector.GetHandle("assetTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentVideoFrameRate = "currentVideoFrameRate";

	private static readonly IntPtr selCurrentVideoFrameRateHandle = Selector.GetHandle("currentVideoFrameRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoFieldMode_ = "setVideoFieldMode:";

	private static readonly IntPtr selSetVideoFieldMode_Handle = Selector.GetHandle("setVideoFieldMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoFieldMode = "videoFieldMode";

	private static readonly IntPtr selVideoFieldModeHandle = Selector.GetHandle("videoFieldMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VideoFieldModeDeinterlaceFields;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack? AssetTrack
	{
		[Export("assetTrack")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetTrackHandle));
			}
			return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetTrackHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual float CurrentVideoFrameRate
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("currentVideoFrameRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCurrentVideoFrameRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCurrentVideoFrameRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? VideoFieldMode
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("videoFieldMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoFieldModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoFieldModeHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setVideoFieldMode:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoFieldMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoFieldMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("AVPlayerItemTrackVideoFieldModeDeinterlaceFields", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString VideoFieldModeDeinterlaceFields
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_VideoFieldModeDeinterlaceFields == null)
			{
				_VideoFieldModeDeinterlaceFields = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemTrackVideoFieldModeDeinterlaceFields");
			}
			return _VideoFieldModeDeinterlaceFields;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemTrack()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerItemTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemTrack(IntPtr handle)
		: base(handle)
	{
	}
}

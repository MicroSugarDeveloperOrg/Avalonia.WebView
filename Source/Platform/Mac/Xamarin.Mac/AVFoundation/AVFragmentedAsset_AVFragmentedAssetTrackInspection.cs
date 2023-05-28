using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVFragmentedAsset_AVFragmentedAssetTrackInspection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackWithTrackID_ = "trackWithTrackID:";

	private static readonly IntPtr selTrackWithTrackID_Handle = Selector.GetHandle("trackWithTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracksWithMediaCharacteristic_ = "tracksWithMediaCharacteristic:";

	private static readonly IntPtr selTracksWithMediaCharacteristic_Handle = Selector.GetHandle("tracksWithMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracksWithMediaType_ = "tracksWithMediaType:";

	private static readonly IntPtr selTracksWithMediaType_Handle = Selector.GetHandle("tracksWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVFragmentedAsset");

	[Export("trackWithTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetTrack? GetTrack(this AVFragmentedAsset This, int trackID)
	{
		return Runtime.GetNSObject<AVFragmentedAssetTrack>(Messaging.IntPtr_objc_msgSend_int(This.Handle, selTrackWithTrackID_Handle, trackID));
	}

	[Export("tracksWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetTrack[] GetTracks(this AVFragmentedAsset This, string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr intPtr = NSString.CreateNative(mediaType);
		AVFragmentedAssetTrack[] result = NSArray.ArrayFromHandle<AVFragmentedAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaType_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetTrack[] GetTracks(this AVFragmentedAsset This, AVMediaTypes mediaType)
	{
		return This.GetTracks(mediaType.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetTrack[] GetTracks(this AVFragmentedAsset This, AVMediaCharacteristics mediaCharacteristic)
	{
		return This.GetTracksWithMediaCharacteristic(mediaCharacteristic.GetConstant());
	}

	[Export("tracksWithMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedAssetTrack[] GetTracksWithMediaCharacteristic(this AVFragmentedAsset This, string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr intPtr = NSString.CreateNative(mediaCharacteristic);
		AVFragmentedAssetTrack[] result = NSArray.ArrayFromHandle<AVFragmentedAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaCharacteristic_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}
}

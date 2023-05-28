using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public static class AVFragmentedMovie_AVFragmentedMovieTrackInspection
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
	private static readonly IntPtr class_ptr = Class.GetHandle("AVFragmentedMovie");

	[Export("trackWithTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieTrack? GetTrack(this AVFragmentedMovie This, int trackID)
	{
		return Runtime.GetNSObject<AVFragmentedMovieTrack>(Messaging.IntPtr_objc_msgSend_int(This.Handle, selTrackWithTrackID_Handle, trackID));
	}

	[Export("tracksWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieTrack[] GetTracks(this AVFragmentedMovie This, string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr intPtr = NSString.CreateNative(mediaType);
		AVFragmentedMovieTrack[] result = NSArray.ArrayFromHandle<AVFragmentedMovieTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaType_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieTrack[] GetTracks(this AVFragmentedMovie This, AVMediaTypes mediaType)
	{
		return This.GetTracks(mediaType.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieTrack[] GetTracks(this AVFragmentedMovie This, AVMediaCharacteristics mediaCharacteristic)
	{
		return This.GetTracksWithMediaCharacteristic(mediaCharacteristic.GetConstant());
	}

	[Export("tracksWithMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieTrack[] GetTracksWithMediaCharacteristic(this AVFragmentedMovie This, string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr intPtr = NSString.CreateNative(mediaCharacteristic);
		AVFragmentedMovieTrack[] result = NSArray.ArrayFromHandle<AVFragmentedMovieTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaCharacteristic_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVMutableComposition_AVMutableCompositionTrackInspection
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
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableComposition");

	[Export("trackWithTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableCompositionTrack? GetTrack(this AVMutableComposition This, int trackID)
	{
		return Runtime.GetNSObject<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSend_int(This.Handle, selTrackWithTrackID_Handle, trackID));
	}

	[Export("tracksWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableCompositionTrack[] GetTracks(this AVMutableComposition This, string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr intPtr = NSString.CreateNative(mediaType);
		AVMutableCompositionTrack[] result = NSArray.ArrayFromHandle<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaType_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableCompositionTrack[] GetTracks(this AVMutableComposition This, AVMediaTypes mediaType)
	{
		return This.GetTracks(mediaType.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableCompositionTrack[] GetTracks(this AVMutableComposition This, AVMediaCharacteristics mediaCharacteristic)
	{
		return This.GetTracksWithMediaCharacteristic(mediaCharacteristic.GetConstant());
	}

	[Export("tracksWithMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableCompositionTrack[] GetTracksWithMediaCharacteristic(this AVMutableComposition This, string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr intPtr = NSString.CreateNative(mediaCharacteristic);
		AVMutableCompositionTrack[] result = NSArray.ArrayFromHandle<AVMutableCompositionTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selTracksWithMediaCharacteristic_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}
}

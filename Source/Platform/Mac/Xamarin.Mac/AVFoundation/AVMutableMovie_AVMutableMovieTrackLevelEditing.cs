using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public static class AVMutableMovie_AVMutableMovieTrackLevelEditing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMutableTrackWithMediaType_CopySettingsFromTrack_Options_ = "addMutableTrackWithMediaType:copySettingsFromTrack:options:";

	private static readonly IntPtr selAddMutableTrackWithMediaType_CopySettingsFromTrack_Options_Handle = Selector.GetHandle("addMutableTrackWithMediaType:copySettingsFromTrack:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMutableTracksCopyingSettingsFromTracks_Options_ = "addMutableTracksCopyingSettingsFromTracks:options:";

	private static readonly IntPtr selAddMutableTracksCopyingSettingsFromTracks_Options_Handle = Selector.GetHandle("addMutableTracksCopyingSettingsFromTracks:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableTrackCompatibleWithTrack_ = "mutableTrackCompatibleWithTrack:";

	private static readonly IntPtr selMutableTrackCompatibleWithTrack_Handle = Selector.GetHandle("mutableTrackCompatibleWithTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrack_ = "removeTrack:";

	private static readonly IntPtr selRemoveTrack_Handle = Selector.GetHandle("removeTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableMovie");

	[Export("addMutableTrackWithMediaType:copySettingsFromTrack:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovieTrack? AddMutableTrack(this AVMutableMovie This, string mediaType, AVAssetTrack? track, NSDictionary<NSString, NSObject>? options)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr intPtr = NSString.CreateNative(mediaType);
		AVMutableMovieTrack nSObject = Runtime.GetNSObject<AVMutableMovieTrack>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, selAddMutableTrackWithMediaType_CopySettingsFromTrack_Options_Handle, intPtr, track?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("addMutableTracksCopyingSettingsFromTracks:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovieTrack[] AddMutableTracks(this AVMutableMovie This, AVAssetTrack[] existingTracks, NSDictionary<NSString, NSObject>? options)
	{
		if (existingTracks == null)
		{
			throw new ArgumentNullException("existingTracks");
		}
		NSArray nSArray = NSArray.FromNSObjects(existingTracks);
		AVMutableMovieTrack[] result = NSArray.ArrayFromHandle<AVMutableMovieTrack>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, selAddMutableTracksCopyingSettingsFromTracks_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("mutableTrackCompatibleWithTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableMovieTrack? GetMutableTrack(this AVMutableMovie This, AVAssetTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return Runtime.GetNSObject<AVMutableMovieTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selMutableTrackCompatibleWithTrack_Handle, track.Handle));
	}

	[Export("removeTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveTrack(this AVMutableMovie This, AVMovieTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selRemoveTrack_Handle, track.Handle);
	}
}

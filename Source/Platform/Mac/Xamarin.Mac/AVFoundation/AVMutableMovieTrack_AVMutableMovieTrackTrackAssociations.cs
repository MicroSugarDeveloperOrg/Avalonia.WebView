using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public static class AVMutableMovieTrack_AVMutableMovieTrackTrackAssociations
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTrackAssociationToTrack_Type_ = "addTrackAssociationToTrack:type:";

	private static readonly IntPtr selAddTrackAssociationToTrack_Type_Handle = Selector.GetHandle("addTrackAssociationToTrack:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrackAssociationToTrack_Type_ = "removeTrackAssociationToTrack:type:";

	private static readonly IntPtr selRemoveTrackAssociationToTrack_Type_Handle = Selector.GetHandle("removeTrackAssociationToTrack:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableMovieTrack");

	[Export("addTrackAssociationToTrack:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddTrackAssociation(this AVMutableMovieTrack This, AVMovieTrack movieTrack, string trackAssociationType)
	{
		if (movieTrack == null)
		{
			throw new ArgumentNullException("movieTrack");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		IntPtr intPtr = NSString.CreateNative(trackAssociationType);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, selAddTrackAssociationToTrack_Type_Handle, movieTrack.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("removeTrackAssociationToTrack:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveTrackAssociation(this AVMutableMovieTrack This, AVMovieTrack movieTrack, string trackAssociationType)
	{
		if (movieTrack == null)
		{
			throw new ArgumentNullException("movieTrack");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		IntPtr intPtr = NSString.CreateNative(trackAssociationType);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, selRemoveTrackAssociationToTrack_Type_Handle, movieTrack.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}

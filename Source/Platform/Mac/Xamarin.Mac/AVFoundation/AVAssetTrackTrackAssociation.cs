using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVAssetTrackTrackAssociation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioFallback;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForcedSubtitlesOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MetadataReferent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionFollower;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Timecode;

	[Field("AVTrackAssociationTypeAudioFallback", "AVFoundation")]
	public static NSString AudioFallback
	{
		get
		{
			if (_AudioFallback == null)
			{
				_AudioFallback = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeAudioFallback");
			}
			return _AudioFallback;
		}
	}

	[Field("AVTrackAssociationTypeChapterList", "AVFoundation")]
	public static NSString ChapterList
	{
		get
		{
			if (_ChapterList == null)
			{
				_ChapterList = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeChapterList");
			}
			return _ChapterList;
		}
	}

	[Field("AVTrackAssociationTypeForcedSubtitlesOnly", "AVFoundation")]
	public static NSString ForcedSubtitlesOnly
	{
		get
		{
			if (_ForcedSubtitlesOnly == null)
			{
				_ForcedSubtitlesOnly = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeForcedSubtitlesOnly");
			}
			return _ForcedSubtitlesOnly;
		}
	}

	[Field("AVTrackAssociationTypeMetadataReferent", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MetadataReferent
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MetadataReferent == null)
			{
				_MetadataReferent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeMetadataReferent");
			}
			return _MetadataReferent;
		}
	}

	[Field("AVTrackAssociationTypeSelectionFollower", "AVFoundation")]
	public static NSString SelectionFollower
	{
		get
		{
			if (_SelectionFollower == null)
			{
				_SelectionFollower = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeSelectionFollower");
			}
			return _SelectionFollower;
		}
	}

	[Field("AVTrackAssociationTypeTimecode", "AVFoundation")]
	public static NSString Timecode
	{
		get
		{
			if (_Timecode == null)
			{
				_Timecode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVTrackAssociationTypeTimecode");
			}
			return _Timecode;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPRemoteCommandCenter", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPRemoteCommandCenter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBookmarkCommand = "bookmarkCommand";

	private static readonly IntPtr selBookmarkCommandHandle = Selector.GetHandle("bookmarkCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangePlaybackPositionCommand = "changePlaybackPositionCommand";

	private static readonly IntPtr selChangePlaybackPositionCommandHandle = Selector.GetHandle("changePlaybackPositionCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangePlaybackRateCommand = "changePlaybackRateCommand";

	private static readonly IntPtr selChangePlaybackRateCommandHandle = Selector.GetHandle("changePlaybackRateCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRepeatModeCommand = "changeRepeatModeCommand";

	private static readonly IntPtr selChangeRepeatModeCommandHandle = Selector.GetHandle("changeRepeatModeCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeShuffleModeCommand = "changeShuffleModeCommand";

	private static readonly IntPtr selChangeShuffleModeCommandHandle = Selector.GetHandle("changeShuffleModeCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableLanguageOptionCommand = "disableLanguageOptionCommand";

	private static readonly IntPtr selDisableLanguageOptionCommandHandle = Selector.GetHandle("disableLanguageOptionCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDislikeCommand = "dislikeCommand";

	private static readonly IntPtr selDislikeCommandHandle = Selector.GetHandle("dislikeCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableLanguageOptionCommand = "enableLanguageOptionCommand";

	private static readonly IntPtr selEnableLanguageOptionCommandHandle = Selector.GetHandle("enableLanguageOptionCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLikeCommand = "likeCommand";

	private static readonly IntPtr selLikeCommandHandle = Selector.GetHandle("likeCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextTrackCommand = "nextTrackCommand";

	private static readonly IntPtr selNextTrackCommandHandle = Selector.GetHandle("nextTrackCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseCommand = "pauseCommand";

	private static readonly IntPtr selPauseCommandHandle = Selector.GetHandle("pauseCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayCommand = "playCommand";

	private static readonly IntPtr selPlayCommandHandle = Selector.GetHandle("playCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousTrackCommand = "previousTrackCommand";

	private static readonly IntPtr selPreviousTrackCommandHandle = Selector.GetHandle("previousTrackCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRatingCommand = "ratingCommand";

	private static readonly IntPtr selRatingCommandHandle = Selector.GetHandle("ratingCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekBackwardCommand = "seekBackwardCommand";

	private static readonly IntPtr selSeekBackwardCommandHandle = Selector.GetHandle("seekBackwardCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekForwardCommand = "seekForwardCommand";

	private static readonly IntPtr selSeekForwardCommandHandle = Selector.GetHandle("seekForwardCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCommandCenter = "sharedCommandCenter";

	private static readonly IntPtr selSharedCommandCenterHandle = Selector.GetHandle("sharedCommandCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkipBackwardCommand = "skipBackwardCommand";

	private static readonly IntPtr selSkipBackwardCommandHandle = Selector.GetHandle("skipBackwardCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkipForwardCommand = "skipForwardCommand";

	private static readonly IntPtr selSkipForwardCommandHandle = Selector.GetHandle("skipForwardCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopCommand = "stopCommand";

	private static readonly IntPtr selStopCommandHandle = Selector.GetHandle("stopCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTogglePlayPauseCommand = "togglePlayPauseCommand";

	private static readonly IntPtr selTogglePlayPauseCommandHandle = Selector.GetHandle("togglePlayPauseCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPRemoteCommandCenter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPFeedbackCommand BookmarkCommand
	{
		[Export("bookmarkCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selBookmarkCommandHandle));
			}
			return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBookmarkCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	public virtual MPChangePlaybackPositionCommand ChangePlaybackPositionCommand
	{
		[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
		[Export("changePlaybackPositionCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPChangePlaybackPositionCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangePlaybackPositionCommandHandle));
			}
			return Runtime.GetNSObject<MPChangePlaybackPositionCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangePlaybackPositionCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPChangePlaybackRateCommand ChangePlaybackRateCommand
	{
		[Export("changePlaybackRateCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPChangePlaybackRateCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangePlaybackRateCommandHandle));
			}
			return Runtime.GetNSObject<MPChangePlaybackRateCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangePlaybackRateCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual MPChangeRepeatModeCommand ChangeRepeatModeCommand
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("changeRepeatModeCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPChangeRepeatModeCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangeRepeatModeCommandHandle));
			}
			return Runtime.GetNSObject<MPChangeRepeatModeCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangeRepeatModeCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual MPChangeShuffleModeCommand ChangeShuffleModeCommand
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("changeShuffleModeCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPChangeShuffleModeCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangeShuffleModeCommandHandle));
			}
			return Runtime.GetNSObject<MPChangeShuffleModeCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangeShuffleModeCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MPRemoteCommand DisableLanguageOptionCommand
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("disableLanguageOptionCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selDisableLanguageOptionCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisableLanguageOptionCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPFeedbackCommand DislikeCommand
	{
		[Export("dislikeCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selDislikeCommandHandle));
			}
			return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDislikeCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MPRemoteCommand EnableLanguageOptionCommand
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("enableLanguageOptionCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnableLanguageOptionCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnableLanguageOptionCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPFeedbackCommand LikeCommand
	{
		[Export("likeCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selLikeCommandHandle));
			}
			return Runtime.GetNSObject<MPFeedbackCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLikeCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand NextTrackCommand
	{
		[Export("nextTrackCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextTrackCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextTrackCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand PauseCommand
	{
		[Export("pauseCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selPauseCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPauseCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand PlayCommand
	{
		[Export("playCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand PreviousTrackCommand
	{
		[Export("previousTrackCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousTrackCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousTrackCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRatingCommand RatingCommand
	{
		[Export("ratingCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRatingCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selRatingCommandHandle));
			}
			return Runtime.GetNSObject<MPRatingCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRatingCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand SeekBackwardCommand
	{
		[Export("seekBackwardCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selSeekBackwardCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSeekBackwardCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand SeekForwardCommand
	{
		[Export("seekForwardCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selSeekForwardCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSeekForwardCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public static MPRemoteCommandCenter Shared
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("sharedCommandCenter")]
		get
		{
			return Runtime.GetNSObject<MPRemoteCommandCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCommandCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSkipIntervalCommand SkipBackwardCommand
	{
		[Export("skipBackwardCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSkipIntervalCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selSkipBackwardCommandHandle));
			}
			return Runtime.GetNSObject<MPSkipIntervalCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSkipBackwardCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSkipIntervalCommand SkipForwardCommand
	{
		[Export("skipForwardCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSkipIntervalCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selSkipForwardCommandHandle));
			}
			return Runtime.GetNSObject<MPSkipIntervalCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSkipForwardCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand StopCommand
	{
		[Export("stopCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selStopCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStopCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPRemoteCommand TogglePlayPauseCommand
	{
		[Export("togglePlayPauseCommand")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSend(base.Handle, selTogglePlayPauseCommandHandle));
			}
			return Runtime.GetNSObject<MPRemoteCommand>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTogglePlayPauseCommandHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPRemoteCommandCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPRemoteCommandCenter(IntPtr handle)
		: base(handle)
	{
	}
}

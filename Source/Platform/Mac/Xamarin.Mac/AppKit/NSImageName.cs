using ObjCRuntime;

namespace AppKit;

public enum NSImageName
{
	QuickLookTemplate,
	BluetoothTemplate,
	IChatTheaterTemplate,
	SlideshowTemplate,
	ActionTemplate,
	SmartBadgeTemplate,
	PathTemplate,
	InvalidDataFreestandingTemplate,
	LockLockedTemplate,
	LockUnlockedTemplate,
	GoRightTemplate,
	GoLeftTemplate,
	RightFacingTriangleTemplate,
	LeftFacingTriangleTemplate,
	AddTemplate,
	RemoveTemplate,
	RevealFreestandingTemplate,
	FollowLinkFreestandingTemplate,
	EnterFullScreenTemplate,
	ExitFullScreenTemplate,
	StopProgressTemplate,
	StopProgressFreestandingTemplate,
	RefreshTemplate,
	RefreshFreestandingTemplate,
	Folder,
	TrashEmpty,
	TrashFull,
	HomeTemplate,
	BookmarksTemplate,
	Caution,
	StatusAvailable,
	StatusPartiallyAvailable,
	StatusUnavailable,
	StatusNone,
	ApplicationIcon,
	MenuOnStateTemplate,
	MenuMixedStateTemplate,
	UserGuest,
	MobileMe,
	ShareTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAddDetailTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAddTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAlarmTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioInputMuteTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioInputTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioOutputMuteTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioOutputVolumeHighTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioOutputVolumeLowTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioOutputVolumeMediumTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarAudioOutputVolumeOffTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarBookmarksTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarColorPickerFill,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarColorPickerFont,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarColorPickerStroke,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarCommunicationAudioTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarCommunicationVideoTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarComposeTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarDeleteTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarDownloadTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarEnterFullScreenTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarExitFullScreenTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarFastForwardTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarFolderCopyToTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarFolderMoveToTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarFolderTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarGetInfoTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarGoBackTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarGoDownTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarGoForwardTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarGoUpTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarHistoryTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarIconViewTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarListViewTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarMailTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarNewFolderTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarNewMessageTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarOpenInBrowserTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarPauseTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarPlayheadTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarPlayPauseTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarPlayTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarQuickLookTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRecordStartTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRecordStopTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRefreshTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRewindTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRotateLeftTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarRotateRightTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSearchTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarShareTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSidebarTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipAhead15SecondsTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipAhead30SecondsTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipAheadTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipBack15SecondsTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipBack30SecondsTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipBackTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipToEndTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSkipToStartTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarSlideshowTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTagIconTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextBoldTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextBoxTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextCenterAlignTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextItalicTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextJustifiedAlignTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextLeftAlignTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextListTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextRightAlignTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextStrikethroughTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarTextUnderlineTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarUserAddTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarUserGroupTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarUserTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarVolumeDownTemplate,
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	TouchBarVolumeUpTemplate,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	TouchBarRemoveTemplate
}

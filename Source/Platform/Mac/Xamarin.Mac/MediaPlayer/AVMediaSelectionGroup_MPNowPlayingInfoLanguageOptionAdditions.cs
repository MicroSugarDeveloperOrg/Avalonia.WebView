using System;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVMediaSelectionGroup_MPNowPlayingInfoLanguageOptionAdditions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeNowPlayingInfoLanguageOptionGroup = "makeNowPlayingInfoLanguageOptionGroup";

	private static readonly IntPtr selMakeNowPlayingInfoLanguageOptionGroupHandle = Selector.GetHandle("makeNowPlayingInfoLanguageOptionGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMediaSelectionGroup");

	[Export("makeNowPlayingInfoLanguageOptionGroup")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPNowPlayingInfoLanguageOptionGroup CreateNowPlayingInfoLanguageOptionGroup(this AVMediaSelectionGroup This)
	{
		return Runtime.GetNSObject<MPNowPlayingInfoLanguageOptionGroup>(Messaging.IntPtr_objc_msgSend(This.Handle, selMakeNowPlayingInfoLanguageOptionGroupHandle));
	}
}

using System;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVMediaSelectionOption_MPNowPlayingInfoLanguageOptionAdditions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeNowPlayingInfoLanguageOption = "makeNowPlayingInfoLanguageOption";

	private static readonly IntPtr selMakeNowPlayingInfoLanguageOptionHandle = Selector.GetHandle("makeNowPlayingInfoLanguageOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVMediaSelectionOption");

	[Export("makeNowPlayingInfoLanguageOption")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPNowPlayingInfoLanguageOption CreateNowPlayingInfoLanguageOption(this AVMediaSelectionOption This)
	{
		return Runtime.GetNSObject<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSend(This.Handle, selMakeNowPlayingInfoLanguageOptionHandle));
	}
}

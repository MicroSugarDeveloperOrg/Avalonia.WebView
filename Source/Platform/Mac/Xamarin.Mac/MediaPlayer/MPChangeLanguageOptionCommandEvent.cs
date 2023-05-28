using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPChangeLanguageOptionCommandEvent", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPChangeLanguageOptionCommandEvent : MPRemoteCommandEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageOption = "languageOption";

	private static readonly IntPtr selLanguageOptionHandle = Selector.GetHandle("languageOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetting = "setting";

	private static readonly IntPtr selSettingHandle = Selector.GetHandle("setting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPChangeLanguageOptionCommandEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPNowPlayingInfoLanguageOption LanguageOption
	{
		[Export("languageOption")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageOptionHandle));
			}
			return Runtime.GetNSObject<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual MPChangeLanguageOptionSetting Setting
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPChangeLanguageOptionSetting)Messaging.Int64_objc_msgSend(base.Handle, selSettingHandle);
			}
			return (MPChangeLanguageOptionSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPChangeLanguageOptionCommandEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPChangeLanguageOptionCommandEvent(IntPtr handle)
		: base(handle)
	{
	}
}

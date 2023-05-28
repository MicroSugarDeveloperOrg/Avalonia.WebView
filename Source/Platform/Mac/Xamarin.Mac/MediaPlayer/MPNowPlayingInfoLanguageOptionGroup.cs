using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPNowPlayingInfoLanguageOptionGroup", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPNowPlayingInfoLanguageOptionGroup : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowEmptySelection = "allowEmptySelection";

	private static readonly IntPtr selAllowEmptySelectionHandle = Selector.GetHandle("allowEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultLanguageOption = "defaultLanguageOption";

	private static readonly IntPtr selDefaultLanguageOptionHandle = Selector.GetHandle("defaultLanguageOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLanguageOptions_DefaultLanguageOption_AllowEmptySelection_ = "initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:";

	private static readonly IntPtr selInitWithLanguageOptions_DefaultLanguageOption_AllowEmptySelection_Handle = Selector.GetHandle("initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageOptions = "languageOptions";

	private static readonly IntPtr selLanguageOptionsHandle = Selector.GetHandle("languageOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPNowPlayingInfoLanguageOptionGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowEmptySelection
	{
		[Export("allowEmptySelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowEmptySelectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPNowPlayingInfoLanguageOption? DefaultLanguageOption
	{
		[Export("defaultLanguageOption")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultLanguageOptionHandle));
			}
			return Runtime.GetNSObject<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultLanguageOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPNowPlayingInfoLanguageOption[] LanguageOptions
	{
		[Export("languageOptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageOptionsHandle));
			}
			return NSArray.ArrayFromHandle<MPNowPlayingInfoLanguageOption>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPNowPlayingInfoLanguageOptionGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPNowPlayingInfoLanguageOptionGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPNowPlayingInfoLanguageOptionGroup(MPNowPlayingInfoLanguageOption[] languageOptions, MPNowPlayingInfoLanguageOption? defaultLanguageOption, bool allowEmptySelection)
		: base(NSObjectFlag.Empty)
	{
		if (languageOptions == null)
		{
			throw new ArgumentNullException("languageOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(languageOptions);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithLanguageOptions_DefaultLanguageOption_AllowEmptySelection_Handle, nSArray.Handle, defaultLanguageOption?.Handle ?? IntPtr.Zero, allowEmptySelection), "initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithLanguageOptions_DefaultLanguageOption_AllowEmptySelection_Handle, nSArray.Handle, defaultLanguageOption?.Handle ?? IntPtr.Zero, allowEmptySelection), "initWithLanguageOptions:defaultLanguageOption:allowEmptySelection:");
		}
		nSArray.Dispose();
	}
}

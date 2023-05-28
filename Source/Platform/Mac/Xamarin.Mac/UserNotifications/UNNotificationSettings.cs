using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNNotificationSettings", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class UNNotificationSettings : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertSetting = "alertSetting";

	private static readonly IntPtr selAlertSettingHandle = Selector.GetHandle("alertSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertStyle = "alertStyle";

	private static readonly IntPtr selAlertStyleHandle = Selector.GetHandle("alertStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBadgeSetting = "badgeSetting";

	private static readonly IntPtr selBadgeSettingHandle = Selector.GetHandle("badgeSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCriticalAlertSetting = "criticalAlertSetting";

	private static readonly IntPtr selCriticalAlertSettingHandle = Selector.GetHandle("criticalAlertSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockScreenSetting = "lockScreenSetting";

	private static readonly IntPtr selLockScreenSettingHandle = Selector.GetHandle("lockScreenSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationCenterSetting = "notificationCenterSetting";

	private static readonly IntPtr selNotificationCenterSettingHandle = Selector.GetHandle("notificationCenterSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvidesAppNotificationSettings = "providesAppNotificationSettings";

	private static readonly IntPtr selProvidesAppNotificationSettingsHandle = Selector.GetHandle("providesAppNotificationSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowPreviewsSetting = "showPreviewsSetting";

	private static readonly IntPtr selShowPreviewsSettingHandle = Selector.GetHandle("showPreviewsSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSoundSetting = "soundSetting";

	private static readonly IntPtr selSoundSettingHandle = Selector.GetHandle("soundSetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNNotificationSettings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting AlertSetting
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("alertSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selAlertSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAlertSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual UNAlertStyle AlertStyle
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("alertStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNAlertStyle)Messaging.Int64_objc_msgSend(base.Handle, selAlertStyleHandle);
			}
			return (UNAlertStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAlertStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual UNAuthorizationStatus AuthorizationStatus
	{
		[Export("authorizationStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNAuthorizationStatus)Messaging.Int64_objc_msgSend(base.Handle, selAuthorizationStatusHandle);
			}
			return (UNAuthorizationStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting BadgeSetting
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("badgeSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selBadgeSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBadgeSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting CriticalAlertSetting
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("criticalAlertSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selCriticalAlertSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCriticalAlertSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting LockScreenSetting
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("lockScreenSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selLockScreenSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLockScreenSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting NotificationCenterSetting
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("notificationCenterSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selNotificationCenterSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNotificationCenterSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool ProvidesAppNotificationSettings
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("providesAppNotificationSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selProvidesAppNotificationSettingsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selProvidesAppNotificationSettingsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual UNShowPreviewsSetting ShowPreviewsSetting
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("showPreviewsSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNShowPreviewsSetting)Messaging.Int64_objc_msgSend(base.Handle, selShowPreviewsSettingHandle);
			}
			return (UNShowPreviewsSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selShowPreviewsSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual UNNotificationSetting SoundSetting
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("soundSetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationSetting)Messaging.Int64_objc_msgSend(base.Handle, selSoundSettingHandle);
			}
			return (UNNotificationSetting)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSoundSettingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public UNNotificationSettings(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected UNNotificationSettings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNNotificationSettings(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}

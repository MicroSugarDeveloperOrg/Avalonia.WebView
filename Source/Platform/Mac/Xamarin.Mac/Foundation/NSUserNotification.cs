using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUserNotification", true)]
[MountainLion]
public class NSUserNotification : NSObject
{
	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selSubtitleHandle = Selector.GetHandle("subtitle");

	private static readonly IntPtr selSetSubtitle_Handle = Selector.GetHandle("setSubtitle:");

	private static readonly IntPtr selInformativeTextHandle = Selector.GetHandle("informativeText");

	private static readonly IntPtr selSetInformativeText_Handle = Selector.GetHandle("setInformativeText:");

	private static readonly IntPtr selActionButtonTitleHandle = Selector.GetHandle("actionButtonTitle");

	private static readonly IntPtr selSetActionButtonTitle_Handle = Selector.GetHandle("setActionButtonTitle:");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle("setUserInfo:");

	private static readonly IntPtr selDeliveryDateHandle = Selector.GetHandle("deliveryDate");

	private static readonly IntPtr selSetDeliveryDate_Handle = Selector.GetHandle("setDeliveryDate:");

	private static readonly IntPtr selDeliveryTimeZoneHandle = Selector.GetHandle("deliveryTimeZone");

	private static readonly IntPtr selSetDeliveryTimeZone_Handle = Selector.GetHandle("setDeliveryTimeZone:");

	private static readonly IntPtr selDeliveryRepeatIntervalHandle = Selector.GetHandle("deliveryRepeatInterval");

	private static readonly IntPtr selSetDeliveryRepeatInterval_Handle = Selector.GetHandle("setDeliveryRepeatInterval:");

	private static readonly IntPtr selActualDeliveryDateHandle = Selector.GetHandle("actualDeliveryDate");

	private static readonly IntPtr selIsPresentedHandle = Selector.GetHandle("isPresented");

	private static readonly IntPtr selIsRemoteHandle = Selector.GetHandle("isRemote");

	private static readonly IntPtr selSoundNameHandle = Selector.GetHandle("soundName");

	private static readonly IntPtr selSetSoundName_Handle = Selector.GetHandle("setSoundName:");

	private static readonly IntPtr selHasActionButtonHandle = Selector.GetHandle("hasActionButton");

	private static readonly IntPtr selSetHasActionButton_Handle = Selector.GetHandle("setHasActionButton:");

	private static readonly IntPtr selActivationTypeHandle = Selector.GetHandle("activationType");

	private static readonly IntPtr selOtherButtonTitleHandle = Selector.GetHandle("otherButtonTitle");

	private static readonly IntPtr selSetOtherButtonTitle_Handle = Selector.GetHandle("setOtherButtonTitle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUserNotification");

	private object __mt_UserInfo_var;

	private object __mt_DeliveryDate_var;

	private object __mt_DeliveryTimeZone_var;

	private object __mt_DeliveryRepeatInterval_var;

	private object __mt_ActualDeliveryDate_var;

	private static NSString _NSUserNotificationDefaultSoundName;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Subtitle
	{
		[Export("subtitle", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtitleHandle));
		}
		[Export("setSubtitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubtitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubtitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string InformativeText
	{
		[Export("informativeText", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInformativeTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInformativeTextHandle));
		}
		[Export("setInformativeText:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInformativeText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInformativeText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ActionButtonTitle
	{
		[Export("actionButtonTitle", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionButtonTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionButtonTitleHandle));
		}
		[Export("setActionButtonTitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActionButtonTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActionButtonTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
		[Export("setUserInfo:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserInfo_Handle, value.Handle);
			}
			__mt_UserInfo_var = value;
		}
	}

	public virtual NSDate DeliveryDate
	{
		[Export("deliveryDate", ArgumentSemantic.Copy)]
		get
		{
			return (NSDate)(__mt_DeliveryDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeliveryDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeliveryDateHandle)))));
		}
		[Export("setDeliveryDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDeliveryDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDeliveryDate_Handle, value.Handle);
			}
			__mt_DeliveryDate_var = value;
		}
	}

	public virtual NSTimeZone DeliveryTimeZone
	{
		[Export("deliveryTimeZone", ArgumentSemantic.Copy)]
		get
		{
			return (NSTimeZone)(__mt_DeliveryTimeZone_var = ((!IsDirectBinding) ? ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeliveryTimeZoneHandle))) : ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeliveryTimeZoneHandle)))));
		}
		[Export("setDeliveryTimeZone:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDeliveryTimeZone_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDeliveryTimeZone_Handle, value.Handle);
			}
			__mt_DeliveryTimeZone_var = value;
		}
	}

	public virtual NSDateComponents DeliveryRepeatInterval
	{
		[Export("deliveryRepeatInterval", ArgumentSemantic.Copy)]
		get
		{
			return (NSDateComponents)(__mt_DeliveryRepeatInterval_var = ((!IsDirectBinding) ? ((NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeliveryRepeatIntervalHandle))) : ((NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeliveryRepeatIntervalHandle)))));
		}
		[Export("setDeliveryRepeatInterval:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDeliveryRepeatInterval_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDeliveryRepeatInterval_Handle, value.Handle);
			}
			__mt_DeliveryRepeatInterval_var = value;
		}
	}

	public virtual NSDate ActualDeliveryDate
	{
		[Export("actualDeliveryDate")]
		get
		{
			return (NSDate)(__mt_ActualDeliveryDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActualDeliveryDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selActualDeliveryDateHandle)))));
		}
	}

	public virtual bool Presented
	{
		[Export("isPresented")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPresentedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPresentedHandle);
		}
	}

	public virtual bool Remote
	{
		[Export("isRemote")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemoteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemoteHandle);
		}
	}

	public virtual string SoundName
	{
		[Export("soundName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSoundNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSoundNameHandle));
		}
		[Export("setSoundName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSoundName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSoundName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool HasActionButton
	{
		[Export("hasActionButton")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasActionButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasActionButtonHandle);
		}
		[Export("setHasActionButton:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasActionButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasActionButton_Handle, value);
			}
		}
	}

	public virtual NSUserNotificationActivationType ActivationType
	{
		[Export("activationType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSUserNotificationActivationType)Messaging.int_objc_msgSend(base.Handle, selActivationTypeHandle);
			}
			return (NSUserNotificationActivationType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selActivationTypeHandle);
		}
	}

	public virtual string OtherButtonTitle
	{
		[Export("otherButtonTitle", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOtherButtonTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOtherButtonTitleHandle));
		}
		[Export("setOtherButtonTitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOtherButtonTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOtherButtonTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("NSUserNotificationDefaultSoundName", "Foundation")]
	public static NSString NSUserNotificationDefaultSoundName
	{
		get
		{
			if (_NSUserNotificationDefaultSoundName == null)
			{
				_NSUserNotificationDefaultSoundName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUserNotificationDefaultSoundName");
			}
			return _NSUserNotificationDefaultSoundName;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserNotification()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUserNotification(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUserNotification(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUserNotification(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_UserInfo_var = null;
			__mt_DeliveryDate_var = null;
			__mt_DeliveryTimeZone_var = null;
			__mt_DeliveryRepeatInterval_var = null;
			__mt_ActualDeliveryDate_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureConnection", true)]
public class QTCaptureConnection : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveAttributeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AttributeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAttributeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AttributeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveAttributeWillChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AttributeWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAttributeWillChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AttributeWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFormatDescriptionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFormatDescriptionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFormatDescriptionWillChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFormatDescriptionWillChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeIsReadOnly_ = "attributeIsReadOnly:";

	private static readonly IntPtr selAttributeIsReadOnly_Handle = Selector.GetHandle("attributeIsReadOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionAttributes = "connectionAttributes";

	private static readonly IntPtr selConnectionAttributesHandle = Selector.GetHandle("connectionAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescription = "formatDescription";

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwner = "owner";

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConnectionAttributes_ = "setConnectionAttributes:";

	private static readonly IntPtr selSetConnectionAttributes_Handle = Selector.GetHandle("setConnectionAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeWillChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioAveragePowerLevelsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioMasterVolumeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioPeakHoldLevelsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioVolumesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedAttributeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnabledAudioChannelsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatDescriptionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatDescriptionWillChangeNotification;

	public QTMediaType MediaTypeValue => QTMedia.QTMediaTypeFromNSString((NSString)MediaType);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ConnectionAttributes
	{
		[Export("connectionAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionAttributesHandle));
		}
		[Export("setConnectionAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConnectionAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConnectionAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTFormatDescription FormatDescription
	{
		[Export("formatDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTFormatDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle));
			}
			return Runtime.GetNSObject<QTFormatDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle));
		}
	}

	[Field("QTCaptureConnectionAttributeDidChangeNotification", "QTKit")]
	[Advice("Use QTCaptureConnection.Notifications.ObserveAttributeDidChange helper method instead.")]
	public static NSString AttributeDidChangeNotification
	{
		get
		{
			if (_AttributeDidChangeNotification == null)
			{
				_AttributeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAttributeDidChangeNotification");
			}
			return _AttributeDidChangeNotification;
		}
	}

	[Field("QTCaptureConnectionAttributeWillChangeNotification", "QTKit")]
	[Advice("Use QTCaptureConnection.Notifications.ObserveAttributeWillChange helper method instead.")]
	public static NSString AttributeWillChangeNotification
	{
		get
		{
			if (_AttributeWillChangeNotification == null)
			{
				_AttributeWillChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAttributeWillChangeNotification");
			}
			return _AttributeWillChangeNotification;
		}
	}

	[Field("QTCaptureConnectionAudioAveragePowerLevelsAttribute", "QTKit")]
	public static NSString AudioAveragePowerLevelsAttribute
	{
		get
		{
			if (_AudioAveragePowerLevelsAttribute == null)
			{
				_AudioAveragePowerLevelsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAudioAveragePowerLevelsAttribute");
			}
			return _AudioAveragePowerLevelsAttribute;
		}
	}

	[Field("QTCaptureConnectionAudioMasterVolumeAttribute", "QTKit")]
	public static NSString AudioMasterVolumeAttribute
	{
		get
		{
			if (_AudioMasterVolumeAttribute == null)
			{
				_AudioMasterVolumeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAudioMasterVolumeAttribute");
			}
			return _AudioMasterVolumeAttribute;
		}
	}

	[Field("QTCaptureConnectionAudioPeakHoldLevelsAttribute", "QTKit")]
	public static NSString AudioPeakHoldLevelsAttribute
	{
		get
		{
			if (_AudioPeakHoldLevelsAttribute == null)
			{
				_AudioPeakHoldLevelsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAudioPeakHoldLevelsAttribute");
			}
			return _AudioPeakHoldLevelsAttribute;
		}
	}

	[Field("QTCaptureConnectionAudioVolumesAttribute", "QTKit")]
	public static NSString AudioVolumesAttribute
	{
		get
		{
			if (_AudioVolumesAttribute == null)
			{
				_AudioVolumesAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionAudioVolumesAttribute");
			}
			return _AudioVolumesAttribute;
		}
	}

	[Field("QTCaptureConnectionChangedAttributeKey", "QTKit")]
	public static NSString ChangedAttributeKey
	{
		get
		{
			if (_ChangedAttributeKey == null)
			{
				_ChangedAttributeKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionChangedAttributeKey");
			}
			return _ChangedAttributeKey;
		}
	}

	[Field("QTCaptureConnectionEnabledAudioChannelsAttribute", "QTKit")]
	public static NSString EnabledAudioChannelsAttribute
	{
		get
		{
			if (_EnabledAudioChannelsAttribute == null)
			{
				_EnabledAudioChannelsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionEnabledAudioChannelsAttribute");
			}
			return _EnabledAudioChannelsAttribute;
		}
	}

	[Field("QTCaptureConnectionFormatDescriptionDidChangeNotification", "QTKit")]
	[Advice("Use QTCaptureConnection.Notifications.ObserveFormatDescriptionDidChange helper method instead.")]
	public static NSString FormatDescriptionDidChangeNotification
	{
		get
		{
			if (_FormatDescriptionDidChangeNotification == null)
			{
				_FormatDescriptionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionFormatDescriptionDidChangeNotification");
			}
			return _FormatDescriptionDidChangeNotification;
		}
	}

	[Field("QTCaptureConnectionFormatDescriptionWillChangeNotification", "QTKit")]
	[Advice("Use QTCaptureConnection.Notifications.ObserveFormatDescriptionWillChange helper method instead.")]
	public static NSString FormatDescriptionWillChangeNotification
	{
		get
		{
			if (_FormatDescriptionWillChangeNotification == null)
			{
				_FormatDescriptionWillChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureConnectionFormatDescriptionWillChangeNotification");
			}
			return _FormatDescriptionWillChangeNotification;
		}
	}

	public NSObject GetAttribute(string attributeKey)
	{
		return GetAttribute((NSString)attributeKey);
	}

	public void SetAttribute(NSObject attribute, string key)
	{
		SetAttribute(attribute, (NSString)key);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureConnection()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(NSString attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, attributeKey.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, attributeKey.Handle));
	}

	[Export("attributeIsReadOnly:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAttributeReadOnly(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeIsReadOnly_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAttributeIsReadOnly_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttribute:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttribute(NSObject attribute, NSString key)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_ForKey_Handle, attribute.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_ForKey_Handle, attribute.Handle, key.Handle);
		}
	}
}

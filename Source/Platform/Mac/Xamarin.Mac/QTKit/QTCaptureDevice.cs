using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDevice", true)]
public class QTCaptureDevice : NSObject, INSCoding, INativeObject, IDisposable
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

		public static NSObject ObserveFormatDescriptionsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFormatDescriptionsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFormatDescriptionsWillChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionsWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFormatDescriptionsWillChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FormatDescriptionsWillChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasConnected(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasConnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasConnected(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasConnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasDisconnected(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDisconnectedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasDisconnected(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDisconnectedNotification, delegate(NSNotification notification)
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
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultInputDeviceWithMediaType_ = "defaultInputDeviceWithMediaType:";

	private static readonly IntPtr selDefaultInputDeviceWithMediaType_Handle = Selector.GetHandle("defaultInputDeviceWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceAttributes = "deviceAttributes";

	private static readonly IntPtr selDeviceAttributesHandle = Selector.GetHandle("deviceAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceWithUniqueID_ = "deviceWithUniqueID:";

	private static readonly IntPtr selDeviceWithUniqueID_Handle = Selector.GetHandle("deviceWithUniqueID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescriptions = "formatDescriptions";

	private static readonly IntPtr selFormatDescriptionsHandle = Selector.GetHandle("formatDescriptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMediaType_ = "hasMediaType:";

	private static readonly IntPtr selHasMediaType_Handle = Selector.GetHandle("hasMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputDevices = "inputDevices";

	private static readonly IntPtr selInputDevicesHandle = Selector.GetHandle("inputDevices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputDevicesWithMediaType_ = "inputDevicesWithMediaType:";

	private static readonly IntPtr selInputDevicesWithMediaType_Handle = Selector.GetHandle("inputDevicesWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConnected = "isConnected";

	private static readonly IntPtr selIsConnectedHandle = Selector.GetHandle("isConnected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInUseByAnotherApplication = "isInUseByAnotherApplication";

	private static readonly IntPtr selIsInUseByAnotherApplicationHandle = Selector.GetHandle("isInUseByAnotherApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpen = "isOpen";

	private static readonly IntPtr selIsOpenHandle = Selector.GetHandle("isOpen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDisplayName = "localizedDisplayName";

	private static readonly IntPtr selLocalizedDisplayNameHandle = Selector.GetHandle("localizedDisplayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelUniqueID = "modelUniqueID";

	private static readonly IntPtr selModelUniqueIDHandle = Selector.GetHandle("modelUniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpen_ = "open:";

	private static readonly IntPtr selOpen_Handle = Selector.GetHandle("open:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeviceAttributes_ = "setDeviceAttributes:";

	private static readonly IntPtr selSetDeviceAttributes_Handle = Selector.GetHandle("setDeviceAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueID = "uniqueID";

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVCTransportControlsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVCTransportControlsPlaybackModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVCTransportControlsSpeedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeWillChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AvailableInputSourcesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedAttributeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatDescriptionsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatDescriptionsWillChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputSourceIdentifierAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputSourceIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputSourceLocalizedDisplayNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LegacySequenceGrabberAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkedDevicesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SuspendedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasConnectedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasDisconnectedNotification;

	public bool IsAvcTransportControlReadOnly => IsAttributeReadOnly(AVCTransportControlsAttribute);

	public QTCaptureDeviceTransportControl AvcTransportControl
	{
		get
		{
			NSDictionary nSDictionary = (NSDictionary)GetAttribute(AVCTransportControlsAttribute);
			if (nSDictionary == null)
			{
				return null;
			}
			return new QTCaptureDeviceTransportControl(nSDictionary);
		}
		set
		{
			NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
			if (value.Speed.HasValue)
			{
				nSMutableDictionary[AVCTransportControlsSpeedKey] = NSNumber.FromInt32((int)value.Speed.Value);
			}
			if (value.PlaybackMode.HasValue)
			{
				nSMutableDictionary[AVCTransportControlsSpeedKey] = NSNumber.FromInt32((int)value.PlaybackMode.Value);
			}
			SetAttribute(nSMutableDictionary, AVCTransportControlsAttribute);
		}
	}

	public bool IsSuspended => ((NSNumber)GetAttribute(SuspendedAttribute))?.BoolValue ?? false;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DeviceAttributes
	{
		[Export("deviceAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceAttributesHandle));
		}
		[Export("setDeviceAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDeviceAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDeviceAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTFormatDescription[] FormatDescriptions
	{
		[Export("formatDescriptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTFormatDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionsHandle));
			}
			return NSArray.ArrayFromHandle<QTFormatDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTCaptureDevice[] InputDevices
	{
		[Export("inputDevices")]
		get
		{
			return NSArray.ArrayFromHandle<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend(class_ptr, selInputDevicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsConnected
	{
		[Export("isConnected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConnectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConnectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInUseByAnotherApplication
	{
		[Export("isInUseByAnotherApplication")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInUseByAnotherApplicationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInUseByAnotherApplicationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOpen
	{
		[Export("isOpen")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedDisplayName
	{
		[Export("localizedDisplayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ModelUniqueID
	{
		[Export("modelUniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModelUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelUniqueIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UniqueID
	{
		[Export("uniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle));
		}
	}

	[Field("QTCaptureDeviceAVCTransportControlsAttribute", "QTKit")]
	public static NSString AVCTransportControlsAttribute
	{
		get
		{
			if (_AVCTransportControlsAttribute == null)
			{
				_AVCTransportControlsAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAVCTransportControlsAttribute");
			}
			return _AVCTransportControlsAttribute;
		}
	}

	[Field("QTCaptureDeviceAVCTransportControlsPlaybackModeKey", "QTKit")]
	public static NSString AVCTransportControlsPlaybackModeKey
	{
		get
		{
			if (_AVCTransportControlsPlaybackModeKey == null)
			{
				_AVCTransportControlsPlaybackModeKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAVCTransportControlsPlaybackModeKey");
			}
			return _AVCTransportControlsPlaybackModeKey;
		}
	}

	[Field("QTCaptureDeviceAVCTransportControlsSpeedKey", "QTKit")]
	public static NSString AVCTransportControlsSpeedKey
	{
		get
		{
			if (_AVCTransportControlsSpeedKey == null)
			{
				_AVCTransportControlsSpeedKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAVCTransportControlsSpeedKey");
			}
			return _AVCTransportControlsSpeedKey;
		}
	}

	[Field("QTCaptureDeviceAttributeDidChangeNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveAttributeDidChange helper method instead.")]
	public static NSString AttributeDidChangeNotification
	{
		get
		{
			if (_AttributeDidChangeNotification == null)
			{
				_AttributeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAttributeDidChangeNotification");
			}
			return _AttributeDidChangeNotification;
		}
	}

	[Field("QTCaptureDeviceAttributeWillChangeNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveAttributeWillChange helper method instead.")]
	public static NSString AttributeWillChangeNotification
	{
		get
		{
			if (_AttributeWillChangeNotification == null)
			{
				_AttributeWillChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAttributeWillChangeNotification");
			}
			return _AttributeWillChangeNotification;
		}
	}

	[Field("QTCaptureDeviceAvailableInputSourcesAttribute", "QTKit")]
	public static NSString AvailableInputSourcesAttribute
	{
		get
		{
			if (_AvailableInputSourcesAttribute == null)
			{
				_AvailableInputSourcesAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceAvailableInputSourcesAttribute");
			}
			return _AvailableInputSourcesAttribute;
		}
	}

	[Field("QTCaptureDeviceChangedAttributeKey", "QTKit")]
	public static NSString ChangedAttributeKey
	{
		get
		{
			if (_ChangedAttributeKey == null)
			{
				_ChangedAttributeKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceChangedAttributeKey");
			}
			return _ChangedAttributeKey;
		}
	}

	[Field("QTCaptureDeviceFormatDescriptionsDidChangeNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveFormatDescriptionsDidChange helper method instead.")]
	public static NSString FormatDescriptionsDidChangeNotification
	{
		get
		{
			if (_FormatDescriptionsDidChangeNotification == null)
			{
				_FormatDescriptionsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceFormatDescriptionsDidChangeNotification");
			}
			return _FormatDescriptionsDidChangeNotification;
		}
	}

	[Field("QTCaptureDeviceFormatDescriptionsWillChangeNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveFormatDescriptionsWillChange helper method instead.")]
	public static NSString FormatDescriptionsWillChangeNotification
	{
		get
		{
			if (_FormatDescriptionsWillChangeNotification == null)
			{
				_FormatDescriptionsWillChangeNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceFormatDescriptionsWillChangeNotification");
			}
			return _FormatDescriptionsWillChangeNotification;
		}
	}

	[Field("QTCaptureDeviceInputSourceIdentifierAttribute", "QTKit")]
	public static NSString InputSourceIdentifierAttribute
	{
		get
		{
			if (_InputSourceIdentifierAttribute == null)
			{
				_InputSourceIdentifierAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceInputSourceIdentifierAttribute");
			}
			return _InputSourceIdentifierAttribute;
		}
	}

	[Field("QTCaptureDeviceInputSourceIdentifierKey", "QTKit")]
	public static NSString InputSourceIdentifierKey
	{
		get
		{
			if (_InputSourceIdentifierKey == null)
			{
				_InputSourceIdentifierKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceInputSourceIdentifierKey");
			}
			return _InputSourceIdentifierKey;
		}
	}

	[Field("QTCaptureDeviceInputSourceLocalizedDisplayNameKey", "QTKit")]
	public static NSString InputSourceLocalizedDisplayNameKey
	{
		get
		{
			if (_InputSourceLocalizedDisplayNameKey == null)
			{
				_InputSourceLocalizedDisplayNameKey = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceInputSourceLocalizedDisplayNameKey");
			}
			return _InputSourceLocalizedDisplayNameKey;
		}
	}

	[Field("QTCaptureDeviceLegacySequenceGrabberAttribute", "QTKit")]
	[Introduced(PlatformName.MacOSX, 10, 5, 0, PlatformArchitecture.Arch32, null)]
	public static NSString LegacySequenceGrabberAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 5, 0, PlatformArchitecture.Arch32, null)]
		get
		{
			if (_LegacySequenceGrabberAttribute == null)
			{
				_LegacySequenceGrabberAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceLegacySequenceGrabberAttribute");
			}
			return _LegacySequenceGrabberAttribute;
		}
	}

	[Field("QTCaptureDeviceLinkedDevicesAttribute", "QTKit")]
	public static NSString LinkedDevicesAttribute
	{
		get
		{
			if (_LinkedDevicesAttribute == null)
			{
				_LinkedDevicesAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceLinkedDevicesAttribute");
			}
			return _LinkedDevicesAttribute;
		}
	}

	[Field("QTCaptureDeviceSuspendedAttribute", "QTKit")]
	public static NSString SuspendedAttribute
	{
		get
		{
			if (_SuspendedAttribute == null)
			{
				_SuspendedAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceSuspendedAttribute");
			}
			return _SuspendedAttribute;
		}
	}

	[Field("QTCaptureDeviceWasConnectedNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveWasConnected helper method instead.")]
	public static NSString WasConnectedNotification
	{
		get
		{
			if (_WasConnectedNotification == null)
			{
				_WasConnectedNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceWasConnectedNotification");
			}
			return _WasConnectedNotification;
		}
	}

	[Field("QTCaptureDeviceWasDisconnectedNotification", "QTKit")]
	[Advice("Use QTCaptureDevice.Notifications.ObserveWasDisconnected helper method instead.")]
	public static NSString WasDisconnectedNotification
	{
		get
		{
			if (_WasDisconnectedNotification == null)
			{
				_WasDisconnectedNotification = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceWasDisconnectedNotification");
			}
			return _WasDisconnectedNotification;
		}
	}

	public static QTCaptureDevice[] GetInputDevices(QTMediaType mediaType)
	{
		NSString nSString = QTMedia.NSStringFromQTMediaType(mediaType);
		if (nSString == null)
		{
			return null;
		}
		return _GetInputDevices(nSString);
	}

	public static QTCaptureDevice GetDefaultInputDevice(QTMediaType mediaType)
	{
		NSString nSString = QTMedia.NSStringFromQTMediaType(mediaType);
		if (nSString == null)
		{
			return null;
		}
		return _GetDefaultInputDevice(nSString);
	}

	public bool HasMediaType(QTMediaType mediaType)
	{
		return _HasMediaType(QTMedia.NSStringFromQTMediaType(mediaType));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureDevice(NSCoder coder)
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
	protected QTCaptureDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
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

	[Export("deviceWithUniqueID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTCaptureDevice FromUniqueID(string deviceUniqueID)
	{
		if (deviceUniqueID == null)
		{
			throw new ArgumentNullException("deviceUniqueID");
		}
		IntPtr arg = NSString.CreateNative(deviceUniqueID);
		QTCaptureDevice nSObject = Runtime.GetNSObject<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceWithUniqueID_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("open:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Open(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selOpen_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selOpen_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setAttribute:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttribute(NSObject attribute, string attributeKey)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_ForKey_Handle, attribute.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_ForKey_Handle, attribute.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("defaultInputDeviceWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static QTCaptureDevice _GetDefaultInputDevice(NSString forMediaType)
	{
		if (forMediaType == null)
		{
			throw new ArgumentNullException("forMediaType");
		}
		return Runtime.GetNSObject<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultInputDeviceWithMediaType_Handle, forMediaType.Handle));
	}

	[Export("inputDevicesWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static QTCaptureDevice[] _GetInputDevices(NSString forMediaType)
	{
		if (forMediaType == null)
		{
			throw new ArgumentNullException("forMediaType");
		}
		return NSArray.ArrayFromHandle<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputDevicesWithMediaType_Handle, forMediaType.Handle));
	}

	[Export("hasMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _HasMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaType_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}

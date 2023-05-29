using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDevice", true)]
public class QTCaptureDevice : NSObject
{
	private static readonly IntPtr selInputDevicesHandle = Selector.GetHandle("inputDevices");

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	private static readonly IntPtr selModelUniqueIDHandle = Selector.GetHandle("modelUniqueID");

	private static readonly IntPtr selLocalizedDisplayNameHandle = Selector.GetHandle("localizedDisplayName");

	private static readonly IntPtr selFormatDescriptionsHandle = Selector.GetHandle("formatDescriptions");

	private static readonly IntPtr selIsConnectedHandle = Selector.GetHandle("isConnected");

	private static readonly IntPtr selIsInUseByAnotherApplicationHandle = Selector.GetHandle("isInUseByAnotherApplication");

	private static readonly IntPtr selIsOpenHandle = Selector.GetHandle("isOpen");

	private static readonly IntPtr selDeviceAttributesHandle = Selector.GetHandle("deviceAttributes");

	private static readonly IntPtr selSetDeviceAttributes_Handle = Selector.GetHandle("setDeviceAttributes:");

	private static readonly IntPtr selInputDevicesWithMediaType_Handle = Selector.GetHandle("inputDevicesWithMediaType:");

	private static readonly IntPtr selDefaultInputDeviceWithMediaType_Handle = Selector.GetHandle("defaultInputDeviceWithMediaType:");

	private static readonly IntPtr selDeviceWithUniqueID_Handle = Selector.GetHandle("deviceWithUniqueID:");

	private static readonly IntPtr selHasMediaType_Handle = Selector.GetHandle("hasMediaType:");

	private static readonly IntPtr selAttributeIsReadOnly_Handle = Selector.GetHandle("attributeIsReadOnly:");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selSetAttributeForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	private static readonly IntPtr selOpen_Handle = Selector.GetHandle("open:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureDevice");

	private static object __mt_InputDevices_var_static;

	private object __mt_FormatDescriptions_var;

	private object __mt_DeviceAttributes_var;

	private static NSString _WasConnectedNotification;

	private static NSString _WasDisconnectedNotification;

	private static NSString _FormatDescriptionsWillChangeNotification;

	private static NSString _FormatDescriptionsDidChangeNotification;

	private static NSString _AttributeWillChangeNotification;

	private static NSString _AttributeDidChangeNotification;

	private static NSString _ChangedAttributeKey;

	private static NSString _LinkedDevicesAttribute;

	private static NSString _AvailableInputSourcesAttribute;

	private static NSString _InputSourceIdentifierAttribute;

	private static NSString _InputSourceIdentifierKey;

	private static NSString _InputSourceLocalizedDisplayNameKey;

	private static NSString _LegacySequenceGrabberAttribute;

	private static NSString _AVCTransportControlsAttribute;

	private static NSString _AVCTransportControlsPlaybackModeKey;

	private static NSString _AVCTransportControlsSpeedKey;

	private static NSString _SuspendedAttribute;

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

	public static QTCaptureDevice[] InputDevices
	{
		[Export("inputDevices")]
		get
		{
			return (QTCaptureDevice[])(__mt_InputDevices_var_static = NSArray.ArrayFromHandle<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend(class_ptr, selInputDevicesHandle)));
		}
	}

	public virtual string UniqueID
	{
		[Export("uniqueID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle));
		}
	}

	public virtual string ModelUniqueID
	{
		[Export("modelUniqueID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModelUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelUniqueIDHandle));
		}
	}

	public virtual string LocalizedDisplayName
	{
		[Export("localizedDisplayName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDisplayNameHandle));
		}
	}

	public virtual QTFormatDescription[] FormatDescriptions
	{
		[Export("formatDescriptions")]
		get
		{
			return (QTFormatDescription[])(__mt_FormatDescriptions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTFormatDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionsHandle)) : NSArray.ArrayFromHandle<QTFormatDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionsHandle))));
		}
	}

	public virtual bool IsConnected
	{
		[Export("isConnected")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConnectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConnectedHandle);
		}
	}

	public virtual bool IsInUseByAnotherApplication
	{
		[Export("isInUseByAnotherApplication")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInUseByAnotherApplicationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInUseByAnotherApplicationHandle);
		}
	}

	public virtual bool IsOpen
	{
		[Export("isOpen")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpenHandle);
		}
	}

	public virtual NSDictionary DeviceAttributes
	{
		[Export("deviceAttributes")]
		get
		{
			return (NSDictionary)(__mt_DeviceAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceAttributesHandle)))));
		}
		[Export("setDeviceAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDeviceAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDeviceAttributes_Handle, value.Handle);
			}
			__mt_DeviceAttributes_var = value;
		}
	}

	[Field("QTCaptureDeviceWasConnectedNotification", "QTKit")]
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

	[Field("QTCaptureDeviceFormatDescriptionsWillChangeNotification", "QTKit")]
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

	[Field("QTCaptureDeviceFormatDescriptionsDidChangeNotification", "QTKit")]
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

	[Field("QTCaptureDeviceAttributeWillChangeNotification", "QTKit")]
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

	[Field("QTCaptureDeviceAttributeDidChangeNotification", "QTKit")]
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
	public static NSString LegacySequenceGrabberAttribute
	{
		get
		{
			if (_LegacySequenceGrabberAttribute == null)
			{
				_LegacySequenceGrabberAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTCaptureDeviceLegacySequenceGrabberAttribute");
			}
			return _LegacySequenceGrabberAttribute;
		}
	}

	[Field("QTCaptureDeviceAVCTransportControlsAttribute", "QTKit")]
	internal static NSString AVCTransportControlsAttribute
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
	internal static NSString AVCTransportControlsPlaybackModeKey
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
	internal static NSString AVCTransportControlsSpeedKey
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

	[Field("QTCaptureDeviceSuspendedAttribute", "QTKit")]
	internal static NSString SuspendedAttribute
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

	private static NSString FromMediaType(QTMediaType mediaType)
	{
		return mediaType switch
		{
			QTMediaType.Video => QTMedia.TypeVideo, 
			QTMediaType.Sound => QTMedia.TypeSound, 
			QTMediaType.Text => QTMedia.TypeText, 
			QTMediaType.Base => QTMedia.TypeBase, 
			QTMediaType.Mpeg => QTMedia.TypeMpeg, 
			QTMediaType.Music => QTMedia.TypeMusic, 
			QTMediaType.TimeCode => QTMedia.TypeTimeCode, 
			QTMediaType.Sprite => QTMedia.TypeSprite, 
			QTMediaType.Flash => QTMedia.TypeFlash, 
			QTMediaType.Movie => QTMedia.TypeMovie, 
			QTMediaType.Tween => QTMedia.TypeTween, 
			QTMediaType.Type3D => QTMedia.Type3D, 
			QTMediaType.Skin => QTMedia.TypeSkin, 
			QTMediaType.Qtvr => QTMedia.TypeQTVR, 
			QTMediaType.Hint => QTMedia.TypeHint, 
			QTMediaType.Stream => QTMedia.TypeStream, 
			QTMediaType.Muxed => QTMedia.TypeMuxed, 
			QTMediaType.QuartzComposer => QTMedia.TypeQuartzComposer, 
			_ => null, 
		};
	}

	public static QTCaptureDevice[] GetInputDevices(QTMediaType mediaType)
	{
		NSString nSString = FromMediaType(mediaType);
		if (nSString == null)
		{
			return null;
		}
		return _GetInputDevices(nSString);
	}

	public static QTCaptureDevice GetDefaultInputDevice(QTMediaType mediaType)
	{
		NSString nSString = FromMediaType(mediaType);
		if (nSString == null)
		{
			return null;
		}
		return _GetDefaultInputDevice(nSString);
	}

	public bool HasMediaType(QTMediaType mediaType)
	{
		return _HasMediaType(FromMediaType(mediaType));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureDevice(NSCoder coder)
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
	public QTCaptureDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("inputDevicesWithMediaType:")]
	internal static QTCaptureDevice[] _GetInputDevices(NSString forMediaType)
	{
		if (forMediaType == null)
		{
			throw new ArgumentNullException("forMediaType");
		}
		return NSArray.ArrayFromHandle<QTCaptureDevice>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputDevicesWithMediaType_Handle, forMediaType.Handle));
	}

	[Export("defaultInputDeviceWithMediaType:")]
	internal static QTCaptureDevice _GetDefaultInputDevice(NSString forMediaType)
	{
		if (forMediaType == null)
		{
			throw new ArgumentNullException("forMediaType");
		}
		return (QTCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultInputDeviceWithMediaType_Handle, forMediaType.Handle));
	}

	[Export("deviceWithUniqueID:")]
	public static QTCaptureDevice FromUniqueID(string deviceUniqueID)
	{
		if (deviceUniqueID == null)
		{
			throw new ArgumentNullException("deviceUniqueID");
		}
		IntPtr arg = NSString.CreateNative(deviceUniqueID);
		QTCaptureDevice result = (QTCaptureDevice)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDeviceWithUniqueID_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasMediaType:")]
	internal virtual bool _HasMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaType_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("attributeIsReadOnly:")]
	public virtual bool IsAttributeReadOnly(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeIsReadOnly_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAttributeIsReadOnly_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("attributeForKey:")]
	public virtual NSObject GetAttribute(string attributeKey)
	{
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttribute:forKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributeForKey_Handle, attribute.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributeForKey_Handle, attribute.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("open:")]
	public virtual bool Open(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpen_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpen_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("close")]
	public virtual void Close()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FormatDescriptions_var = null;
			__mt_DeviceAttributes_var = null;
		}
	}
}

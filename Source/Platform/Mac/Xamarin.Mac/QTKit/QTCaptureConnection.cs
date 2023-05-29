using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureConnection", true)]
public class QTCaptureConnection : NSObject
{
	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selConnectionAttributesHandle = Selector.GetHandle("connectionAttributes");

	private static readonly IntPtr selSetConnectionAttributes_Handle = Selector.GetHandle("setConnectionAttributes:");

	private static readonly IntPtr selAttributeIsReadOnly_Handle = Selector.GetHandle("attributeIsReadOnly:");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selSetAttributeForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureConnection");

	private object __mt_Owner_var;

	private object __mt_FormatDescription_var;

	private object __mt_ConnectionAttributes_var;

	private static NSString _FormatDescriptionWillChangeNotification;

	private static NSString _FormatDescriptionDidChangeNotification;

	private static NSString _AttributeWillChangeNotification;

	private static NSString _AttributeDidChangeNotification;

	private static NSString _ChangedAttributeKey;

	private static NSString _AudioAveragePowerLevelsAttribute;

	private static NSString _AudioPeakHoldLevelsAttribute;

	private static NSString _AudioMasterVolumeAttribute;

	private static NSString _AudioVolumesAttribute;

	private static NSString _EnabledAudioChannelsAttribute;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			return (NSObject)(__mt_Owner_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle))));
		}
	}

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual QTFormatDescription FormatDescription
	{
		[Export("formatDescription")]
		get
		{
			return (QTFormatDescription)(__mt_FormatDescription_var = ((!IsDirectBinding) ? ((QTFormatDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle))) : ((QTFormatDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle)))));
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	public virtual NSDictionary ConnectionAttributes
	{
		[Export("connectionAttributes")]
		get
		{
			return (NSDictionary)(__mt_ConnectionAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionAttributesHandle)))));
		}
		[Export("setConnectionAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConnectionAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConnectionAttributes_Handle, value.Handle);
			}
			__mt_ConnectionAttributes_var = value;
		}
	}

	[Field("QTCaptureConnectionFormatDescriptionWillChangeNotification", "QTKit")]
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

	[Field("QTCaptureConnectionFormatDescriptionDidChangeNotification", "QTKit")]
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

	[Field("QTCaptureConnectionAttributeWillChangeNotification", "QTKit")]
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

	[Field("QTCaptureConnectionAttributeDidChangeNotification", "QTKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureConnection()
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
	public QTCaptureConnection(NSCoder coder)
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
	public QTCaptureConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureConnection(IntPtr handle)
		: base(handle)
	{
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
	public virtual void SetAttribute(NSObject attribute, string key)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Owner_var = null;
			__mt_FormatDescription_var = null;
			__mt_ConnectionAttributes_var = null;
		}
	}
}

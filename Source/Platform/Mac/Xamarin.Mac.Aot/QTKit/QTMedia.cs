using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMedia", true)]
public class QTMedia : NSObject
{
	private static readonly IntPtr selTrackHandle = Selector.GetHandle("track");

	private static readonly IntPtr selQuickTimeMediaHandle = Selector.GetHandle("quickTimeMedia");

	private static readonly IntPtr selMediaAttributesHandle = Selector.GetHandle("mediaAttributes");

	private static readonly IntPtr selSetMediaAttributes_Handle = Selector.GetHandle("setMediaAttributes:");

	private static readonly IntPtr selMediaWithQuickTimeMediaError_Handle = Selector.GetHandle("mediaWithQuickTimeMedia:error:");

	private static readonly IntPtr selInitWithQuickTimeMediaError_Handle = Selector.GetHandle("initWithQuickTimeMedia:error:");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selSetAttributeForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	private static readonly IntPtr selHasCharacteristic_Handle = Selector.GetHandle("hasCharacteristic:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTMedia");

	private object __mt_Track_var;

	private object __mt_MediaAttributes_var;

	private static NSString _TypeVideo;

	private static NSString _TypeSound;

	private static NSString _TypeText;

	private static NSString _TypeBase;

	private static NSString _TypeMpeg;

	private static NSString _TypeMusic;

	private static NSString _TypeTimeCode;

	private static NSString _TypeSprite;

	private static NSString _TypeFlash;

	private static NSString _TypeMovie;

	private static NSString _TypeTween;

	private static NSString _Type3D;

	private static NSString _TypeSkin;

	private static NSString _TypeQTVR;

	private static NSString _TypeHint;

	private static NSString _TypeStream;

	private static NSString _TypeMuxed;

	private static NSString _TypeQuartzComposer;

	private static NSString _CharacteristicVisual;

	private static NSString _CharacteristicAudio;

	private static NSString _CharacteristicCanSendVideo;

	private static NSString _CharacteristicProvidesActions;

	private static NSString _CharacteristicNonLinear;

	private static NSString _CharacteristicCanStep;

	private static NSString _CharacteristicHasNoDuration;

	private static NSString _CharacteristicHasSkinData;

	private static NSString _CharacteristicProvidesKeyFocus;

	private static NSString _CharacteristicHasVideoFrameRate;

	private static NSString _CreationTimeAttribute;

	private static NSString _DurationAttribute;

	private static NSString _ModificationTimeAttribute;

	private static NSString _SampleCountAttribute;

	private static NSString _QualityAttribute;

	private static NSString _TimeScaleAttribute;

	private static NSString _TypeAttribute;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTTrack Track
	{
		[Export("track")]
		get
		{
			return (QTTrack)(__mt_Track_var = ((!IsDirectBinding) ? ((QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackHandle))) : ((QTTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackHandle)))));
		}
	}

	public virtual IntPtr QuickTimeMedia
	{
		[Export("quickTimeMedia")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeMediaHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeMediaHandle);
		}
	}

	public virtual NSDictionary MediaAttributes
	{
		[Export("mediaAttributes")]
		get
		{
			return (NSDictionary)(__mt_MediaAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaAttributesHandle)))));
		}
		[Export("setMediaAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaAttributes_Handle, value.Handle);
			}
			__mt_MediaAttributes_var = value;
		}
	}

	[Field("QTMediaTypeVideo", "QTKit")]
	internal static NSString TypeVideo
	{
		get
		{
			if (_TypeVideo == null)
			{
				_TypeVideo = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeVideo");
			}
			return _TypeVideo;
		}
	}

	[Field("QTMediaTypeSound", "QTKit")]
	internal static NSString TypeSound
	{
		get
		{
			if (_TypeSound == null)
			{
				_TypeSound = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeSound");
			}
			return _TypeSound;
		}
	}

	[Field("QTMediaTypeText", "QTKit")]
	internal static NSString TypeText
	{
		get
		{
			if (_TypeText == null)
			{
				_TypeText = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeText");
			}
			return _TypeText;
		}
	}

	[Field("QTMediaTypeBase", "QTKit")]
	internal static NSString TypeBase
	{
		get
		{
			if (_TypeBase == null)
			{
				_TypeBase = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeBase");
			}
			return _TypeBase;
		}
	}

	[Field("QTMediaTypeMPEG", "QTKit")]
	internal static NSString TypeMpeg
	{
		get
		{
			if (_TypeMpeg == null)
			{
				_TypeMpeg = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeMPEG");
			}
			return _TypeMpeg;
		}
	}

	[Field("QTMediaTypeMusic", "QTKit")]
	internal static NSString TypeMusic
	{
		get
		{
			if (_TypeMusic == null)
			{
				_TypeMusic = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeMusic");
			}
			return _TypeMusic;
		}
	}

	[Field("QTMediaTypeTimeCode", "QTKit")]
	internal static NSString TypeTimeCode
	{
		get
		{
			if (_TypeTimeCode == null)
			{
				_TypeTimeCode = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeTimeCode");
			}
			return _TypeTimeCode;
		}
	}

	[Field("QTMediaTypeSprite", "QTKit")]
	internal static NSString TypeSprite
	{
		get
		{
			if (_TypeSprite == null)
			{
				_TypeSprite = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeSprite");
			}
			return _TypeSprite;
		}
	}

	[Field("QTMediaTypeFlash", "QTKit")]
	internal static NSString TypeFlash
	{
		get
		{
			if (_TypeFlash == null)
			{
				_TypeFlash = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeFlash");
			}
			return _TypeFlash;
		}
	}

	[Field("QTMediaTypeMovie", "QTKit")]
	internal static NSString TypeMovie
	{
		get
		{
			if (_TypeMovie == null)
			{
				_TypeMovie = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeMovie");
			}
			return _TypeMovie;
		}
	}

	[Field("QTMediaTypeTween", "QTKit")]
	internal static NSString TypeTween
	{
		get
		{
			if (_TypeTween == null)
			{
				_TypeTween = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeTween");
			}
			return _TypeTween;
		}
	}

	[Field("QTMediaType3D", "QTKit")]
	internal static NSString Type3D
	{
		get
		{
			if (_Type3D == null)
			{
				_Type3D = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaType3D");
			}
			return _Type3D;
		}
	}

	[Field("QTMediaTypeSkin", "QTKit")]
	internal static NSString TypeSkin
	{
		get
		{
			if (_TypeSkin == null)
			{
				_TypeSkin = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeSkin");
			}
			return _TypeSkin;
		}
	}

	[Field("QTMediaTypeQTVR", "QTKit")]
	internal static NSString TypeQTVR
	{
		get
		{
			if (_TypeQTVR == null)
			{
				_TypeQTVR = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeQTVR");
			}
			return _TypeQTVR;
		}
	}

	[Field("QTMediaTypeHint", "QTKit")]
	internal static NSString TypeHint
	{
		get
		{
			if (_TypeHint == null)
			{
				_TypeHint = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeHint");
			}
			return _TypeHint;
		}
	}

	[Field("QTMediaTypeStream", "QTKit")]
	internal static NSString TypeStream
	{
		get
		{
			if (_TypeStream == null)
			{
				_TypeStream = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeStream");
			}
			return _TypeStream;
		}
	}

	[Field("QTMediaTypeMuxed", "QTKit")]
	internal static NSString TypeMuxed
	{
		get
		{
			if (_TypeMuxed == null)
			{
				_TypeMuxed = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeMuxed");
			}
			return _TypeMuxed;
		}
	}

	[Field("QTMediaTypeQuartzComposer", "QTKit")]
	internal static NSString TypeQuartzComposer
	{
		get
		{
			if (_TypeQuartzComposer == null)
			{
				_TypeQuartzComposer = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeQuartzComposer");
			}
			return _TypeQuartzComposer;
		}
	}

	[Field("QTMediaCharacteristicVisual", "QTKit")]
	public static NSString CharacteristicVisual
	{
		get
		{
			if (_CharacteristicVisual == null)
			{
				_CharacteristicVisual = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicVisual");
			}
			return _CharacteristicVisual;
		}
	}

	[Field("QTMediaCharacteristicAudio", "QTKit")]
	public static NSString CharacteristicAudio
	{
		get
		{
			if (_CharacteristicAudio == null)
			{
				_CharacteristicAudio = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicAudio");
			}
			return _CharacteristicAudio;
		}
	}

	[Field("QTMediaCharacteristicCanSendVideo", "QTKit")]
	public static NSString CharacteristicCanSendVideo
	{
		get
		{
			if (_CharacteristicCanSendVideo == null)
			{
				_CharacteristicCanSendVideo = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicCanSendVideo");
			}
			return _CharacteristicCanSendVideo;
		}
	}

	[Field("QTMediaCharacteristicProvidesActions", "QTKit")]
	public static NSString CharacteristicProvidesActions
	{
		get
		{
			if (_CharacteristicProvidesActions == null)
			{
				_CharacteristicProvidesActions = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicProvidesActions");
			}
			return _CharacteristicProvidesActions;
		}
	}

	[Field("QTMediaCharacteristicNonLinear", "QTKit")]
	public static NSString CharacteristicNonLinear
	{
		get
		{
			if (_CharacteristicNonLinear == null)
			{
				_CharacteristicNonLinear = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicNonLinear");
			}
			return _CharacteristicNonLinear;
		}
	}

	[Field("QTMediaCharacteristicCanStep", "QTKit")]
	public static NSString CharacteristicCanStep
	{
		get
		{
			if (_CharacteristicCanStep == null)
			{
				_CharacteristicCanStep = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicCanStep");
			}
			return _CharacteristicCanStep;
		}
	}

	[Field("QTMediaCharacteristicHasNoDuration", "QTKit")]
	public static NSString CharacteristicHasNoDuration
	{
		get
		{
			if (_CharacteristicHasNoDuration == null)
			{
				_CharacteristicHasNoDuration = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicHasNoDuration");
			}
			return _CharacteristicHasNoDuration;
		}
	}

	[Field("QTMediaCharacteristicHasSkinData", "QTKit")]
	public static NSString CharacteristicHasSkinData
	{
		get
		{
			if (_CharacteristicHasSkinData == null)
			{
				_CharacteristicHasSkinData = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicHasSkinData");
			}
			return _CharacteristicHasSkinData;
		}
	}

	[Field("QTMediaCharacteristicProvidesKeyFocus", "QTKit")]
	public static NSString CharacteristicProvidesKeyFocus
	{
		get
		{
			if (_CharacteristicProvidesKeyFocus == null)
			{
				_CharacteristicProvidesKeyFocus = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicProvidesKeyFocus");
			}
			return _CharacteristicProvidesKeyFocus;
		}
	}

	[Field("QTMediaCharacteristicHasVideoFrameRate", "QTKit")]
	public static NSString CharacteristicHasVideoFrameRate
	{
		get
		{
			if (_CharacteristicHasVideoFrameRate == null)
			{
				_CharacteristicHasVideoFrameRate = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCharacteristicHasVideoFrameRate");
			}
			return _CharacteristicHasVideoFrameRate;
		}
	}

	[Field("QTMediaCreationTimeAttribute", "QTKit")]
	public static NSString CreationTimeAttribute
	{
		get
		{
			if (_CreationTimeAttribute == null)
			{
				_CreationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaCreationTimeAttribute");
			}
			return _CreationTimeAttribute;
		}
	}

	[Field("QTMediaDurationAttribute", "QTKit")]
	public static NSString DurationAttribute
	{
		get
		{
			if (_DurationAttribute == null)
			{
				_DurationAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaDurationAttribute");
			}
			return _DurationAttribute;
		}
	}

	[Field("QTMediaModificationTimeAttribute", "QTKit")]
	public static NSString ModificationTimeAttribute
	{
		get
		{
			if (_ModificationTimeAttribute == null)
			{
				_ModificationTimeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaModificationTimeAttribute");
			}
			return _ModificationTimeAttribute;
		}
	}

	[Field("QTMediaSampleCountAttribute", "QTKit")]
	public static NSString SampleCountAttribute
	{
		get
		{
			if (_SampleCountAttribute == null)
			{
				_SampleCountAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaSampleCountAttribute");
			}
			return _SampleCountAttribute;
		}
	}

	[Field("QTMediaQualityAttribute", "QTKit")]
	public static NSString QualityAttribute
	{
		get
		{
			if (_QualityAttribute == null)
			{
				_QualityAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaQualityAttribute");
			}
			return _QualityAttribute;
		}
	}

	[Field("QTMediaTimeScaleAttribute", "QTKit")]
	public static NSString TimeScaleAttribute
	{
		get
		{
			if (_TimeScaleAttribute == null)
			{
				_TimeScaleAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTimeScaleAttribute");
			}
			return _TimeScaleAttribute;
		}
	}

	[Field("QTMediaTypeAttribute", "QTKit")]
	public static NSString TypeAttribute
	{
		get
		{
			if (_TypeAttribute == null)
			{
				_TypeAttribute = Dlfcn.GetStringConstant(Libraries.QTKit.Handle, "QTMediaTypeAttribute");
			}
			return _TypeAttribute;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMedia()
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
	public QTMedia(NSCoder coder)
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
	public QTMedia(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTMedia(IntPtr handle)
		: base(handle)
	{
	}

	[Export("mediaWithQuickTimeMedia:error:")]
	public static NSObject FromQuickTimeMedia(IntPtr quicktimeMedia, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMediaWithQuickTimeMediaError_Handle, quicktimeMedia, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	[Export("initWithQuickTimeMedia:error:")]
	public virtual IntPtr Conditions(IntPtr quicktimeMedia, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithQuickTimeMediaError_Handle, quicktimeMedia, intPtr) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithQuickTimeMediaError_Handle, quicktimeMedia, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
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
	public virtual void SetAttribute(NSObject value, string attributeKey)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (attributeKey == null)
		{
			throw new ArgumentNullException("attributeKey");
		}
		IntPtr arg = NSString.CreateNative(attributeKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributeForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributeForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("hasCharacteristic:")]
	public virtual bool HasCharacteristic(string characteristic)
	{
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		IntPtr arg = NSString.CreateNative(characteristic);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasCharacteristic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasCharacteristic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Track_var = null;
			__mt_MediaAttributes_var = null;
		}
	}
}

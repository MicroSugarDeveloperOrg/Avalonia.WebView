using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMedia", true)]
public class QTMedia : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasCharacteristic_ = "hasCharacteristic:";

	private static readonly IntPtr selHasCharacteristic_Handle = Selector.GetHandle("hasCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithQuickTimeMedia_Error_ = "initWithQuickTimeMedia:error:";

	private static readonly IntPtr selInitWithQuickTimeMedia_Error_Handle = Selector.GetHandle("initWithQuickTimeMedia:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaAttributes = "mediaAttributes";

	private static readonly IntPtr selMediaAttributesHandle = Selector.GetHandle("mediaAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaWithQuickTimeMedia_Error_ = "mediaWithQuickTimeMedia:error:";

	private static readonly IntPtr selMediaWithQuickTimeMedia_Error_Handle = Selector.GetHandle("mediaWithQuickTimeMedia:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickTimeMedia = "quickTimeMedia";

	private static readonly IntPtr selQuickTimeMediaHandle = Selector.GetHandle("quickTimeMedia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaAttributes_ = "setMediaAttributes:";

	private static readonly IntPtr selSetMediaAttributes_Handle = Selector.GetHandle("setMediaAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrack = "track";

	private static readonly IntPtr selTrackHandle = Selector.GetHandle("track");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTMedia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicAudio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicCanSendVideo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicCanStep;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicHasNoDuration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicHasSkinData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicHasVideoFrameRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicNonLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicProvidesActions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicProvidesKeyFocus;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicVisual;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DurationAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModificationTimeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QualityAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SampleCountAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeScaleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type3D;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeBase;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeFlash;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeHint;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeMovie;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeMpeg;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeMusic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeMuxed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeQTVR;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeQuartzComposer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSkin;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSound;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSprite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeStream;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeTimeCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeTween;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeVideo;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary MediaAttributes
	{
		[Export("mediaAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaAttributesHandle));
		}
		[Export("setMediaAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual IntPtr QuickTimeMedia
	{
		[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("quickTimeMedia")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeMediaHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeMediaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTrack Track
	{
		[Export("track")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackHandle));
			}
			return Runtime.GetNSObject<QTTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackHandle));
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

	internal static QTMediaType QTMediaTypeFromNSString(NSString str)
	{
		if (str == TypeVideo)
		{
			return QTMediaType.Video;
		}
		if (str == TypeSound)
		{
			return QTMediaType.Sound;
		}
		if (str == TypeText)
		{
			return QTMediaType.Text;
		}
		if (str == TypeBase)
		{
			return QTMediaType.Base;
		}
		if (str == TypeMusic)
		{
			return QTMediaType.Music;
		}
		if (str == TypeTimeCode)
		{
			return QTMediaType.TimeCode;
		}
		if (str == TypeSprite)
		{
			return QTMediaType.Sprite;
		}
		if (str == TypeFlash)
		{
			return QTMediaType.Flash;
		}
		if (str == TypeMovie)
		{
			return QTMediaType.Movie;
		}
		if (str == TypeTween)
		{
			return QTMediaType.Tween;
		}
		if (str == Type3D)
		{
			return QTMediaType.Type3D;
		}
		if (str == TypeSkin)
		{
			return QTMediaType.Skin;
		}
		if (str == TypeQTVR)
		{
			return QTMediaType.Qtvr;
		}
		if (str == TypeHint)
		{
			return QTMediaType.Hint;
		}
		if (str == TypeStream)
		{
			return QTMediaType.Stream;
		}
		if (str == TypeMuxed)
		{
			return QTMediaType.Muxed;
		}
		if (str == TypeQuartzComposer)
		{
			return QTMediaType.QuartzComposer;
		}
		throw new ArgumentException("No enum found matching the supplied NSString");
	}

	internal static NSString NSStringFromQTMediaType(QTMediaType mediaType)
	{
		return mediaType switch
		{
			QTMediaType.Video => TypeVideo, 
			QTMediaType.Sound => TypeSound, 
			QTMediaType.Text => TypeText, 
			QTMediaType.Base => TypeBase, 
			QTMediaType.Mpeg => TypeMpeg, 
			QTMediaType.Music => TypeMusic, 
			QTMediaType.TimeCode => TypeTimeCode, 
			QTMediaType.Sprite => TypeSprite, 
			QTMediaType.Flash => TypeFlash, 
			QTMediaType.Movie => TypeMovie, 
			QTMediaType.Tween => TypeTween, 
			QTMediaType.Type3D => Type3D, 
			QTMediaType.Skin => TypeSkin, 
			QTMediaType.Qtvr => TypeQTVR, 
			QTMediaType.Hint => TypeHint, 
			QTMediaType.Stream => TypeStream, 
			QTMediaType.Muxed => TypeMuxed, 
			QTMediaType.QuartzComposer => TypeQuartzComposer, 
			_ => throw new ArgumentException("No enum found matching the supplied NSString"), 
		};
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMedia()
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
	protected QTMedia(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTMedia(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithQuickTimeMedia:error:")]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Conditions(IntPtr quicktimeMedia, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithQuickTimeMedia_Error_Handle, quicktimeMedia, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithQuickTimeMedia_Error_Handle, quicktimeMedia, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IntPtr Constructors(IntPtr quicktimeMedia, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithQuickTimeMedia_Error_Handle, quicktimeMedia, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("mediaWithQuickTimeMedia:error:")]
	[Introduced(PlatformName.MacOSX, 10, 3, 0, PlatformArchitecture.Arch32, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject FromQuickTimeMedia(IntPtr quicktimeMedia, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selMediaWithQuickTimeMedia_Error_Handle, quicktimeMedia, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
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

	[Export("hasCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasCharacteristic(string characteristic)
	{
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		IntPtr arg = NSString.CreateNative(characteristic);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasCharacteristic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasCharacteristic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttribute:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_ForKey_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_ForKey_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

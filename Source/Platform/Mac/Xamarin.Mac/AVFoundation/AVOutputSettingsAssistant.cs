using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVOutputSettingsAssistant", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class AVOutputSettingsAssistant : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioSettings = "audioSettings";

	private static readonly IntPtr selAudioSettingsHandle = Selector.GetHandle("audioSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableOutputSettingsPresets = "availableOutputSettingsPresets";

	private static readonly IntPtr selAvailableOutputSettingsPresetsHandle = Selector.GetHandle("availableOutputSettingsPresets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFileType = "outputFileType";

	private static readonly IntPtr selOutputFileTypeHandle = Selector.GetHandle("outputFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputSettingsAssistantWithPreset_ = "outputSettingsAssistantWithPreset:";

	private static readonly IntPtr selOutputSettingsAssistantWithPreset_Handle = Selector.GetHandle("outputSettingsAssistantWithPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceAudioFormat_ = "setSourceAudioFormat:";

	private static readonly IntPtr selSetSourceAudioFormat_Handle = Selector.GetHandle("setSourceAudioFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceVideoAverageFrameDuration_ = "setSourceVideoAverageFrameDuration:";

	private static readonly IntPtr selSetSourceVideoAverageFrameDuration_Handle = Selector.GetHandle("setSourceVideoAverageFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceVideoFormat_ = "setSourceVideoFormat:";

	private static readonly IntPtr selSetSourceVideoFormat_Handle = Selector.GetHandle("setSourceVideoFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceVideoMinFrameDuration_ = "setSourceVideoMinFrameDuration:";

	private static readonly IntPtr selSetSourceVideoMinFrameDuration_Handle = Selector.GetHandle("setSourceVideoMinFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceAudioFormat = "sourceAudioFormat";

	private static readonly IntPtr selSourceAudioFormatHandle = Selector.GetHandle("sourceAudioFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceVideoAverageFrameDuration = "sourceVideoAverageFrameDuration";

	private static readonly IntPtr selSourceVideoAverageFrameDurationHandle = Selector.GetHandle("sourceVideoAverageFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceVideoFormat = "sourceVideoFormat";

	private static readonly IntPtr selSourceVideoFormatHandle = Selector.GetHandle("sourceVideoFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceVideoMinFrameDuration = "sourceVideoMinFrameDuration";

	private static readonly IntPtr selSourceVideoMinFrameDurationHandle = Selector.GetHandle("sourceVideoMinFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoSettings = "videoSettings";

	private static readonly IntPtr selVideoSettingsHandle = Selector.GetHandle("videoSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVOutputSettingsAssistant");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Preset1280x720;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Preset1920x1080;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Preset3840x2160;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Preset640x480;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Preset960x540;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __PresetHevc1920x1080;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __PresetHevc3840x2160;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings? AudioSettings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakAudioSettings != null) ? new NSMutableDictionary(WeakAudioSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] AvailableOutputSettingsPresets
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("availableOutputSettingsPresets")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableOutputSettingsPresetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsCompressed CompressedVideoSettings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakVideoSettings != null) ? new NSMutableDictionary(WeakVideoSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsCompressed(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OutputFileType
	{
		[Export("outputFileType", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMAudioFormatDescription? SourceAudioFormat
	{
		[Export("sourceAudioFormat", ArgumentSemantic.Copy)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceAudioFormatHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selSourceAudioFormatHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMAudioFormatDescription(intPtr);
		}
		[Export("setSourceAudioFormat:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceAudioFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceAudioFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime SourceVideoAverageFrameDuration
	{
		[Export("sourceVideoAverageFrameDuration", ArgumentSemantic.Copy)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selSourceVideoAverageFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSourceVideoAverageFrameDurationHandle);
			}
			return retval;
		}
		[Export("setSourceVideoAverageFrameDuration:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetSourceVideoAverageFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetSourceVideoAverageFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMVideoFormatDescription? SourceVideoFormat
	{
		[Export("sourceVideoFormat", ArgumentSemantic.Copy)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceVideoFormatHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selSourceVideoFormatHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMVideoFormatDescription(intPtr);
		}
		[Export("setSourceVideoFormat:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSourceVideoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSourceVideoFormat_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CMTime SourceVideoMinFrameDuration
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sourceVideoMinFrameDuration", ArgumentSemantic.Copy)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selSourceVideoMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSourceVideoMinFrameDurationHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSourceVideoMinFrameDuration:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetSourceVideoMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetSourceVideoMinFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsUncompressed UnCompressedVideoSettings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakVideoSettings != null) ? new NSMutableDictionary(WeakVideoSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsUncompressed(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakAudioSettings
	{
		[Export("audioSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakVideoSettings
	{
		[Export("videoSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSettingsHandle));
		}
	}

	[Field("AVOutputSettingsPreset1280x720", "AVFoundation")]
	internal static NSString _Preset1280x720
	{
		get
		{
			if (__Preset1280x720 == null)
			{
				__Preset1280x720 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1280x720");
			}
			return __Preset1280x720;
		}
	}

	[Field("AVOutputSettingsPreset1920x1080", "AVFoundation")]
	internal static NSString _Preset1920x1080
	{
		get
		{
			if (__Preset1920x1080 == null)
			{
				__Preset1920x1080 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1920x1080");
			}
			return __Preset1920x1080;
		}
	}

	[Field("AVOutputSettingsPreset3840x2160", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal static NSString _Preset3840x2160
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (__Preset3840x2160 == null)
			{
				__Preset3840x2160 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset3840x2160");
			}
			return __Preset3840x2160;
		}
	}

	[Field("AVOutputSettingsPreset640x480", "AVFoundation")]
	internal static NSString _Preset640x480
	{
		get
		{
			if (__Preset640x480 == null)
			{
				__Preset640x480 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset640x480");
			}
			return __Preset640x480;
		}
	}

	[Field("AVOutputSettingsPreset960x540", "AVFoundation")]
	internal static NSString _Preset960x540
	{
		get
		{
			if (__Preset960x540 == null)
			{
				__Preset960x540 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset960x540");
			}
			return __Preset960x540;
		}
	}

	[Field("AVOutputSettingsPresetHEVC1920x1080", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	internal static NSString _PresetHevc1920x1080
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (__PresetHevc1920x1080 == null)
			{
				__PresetHevc1920x1080 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080");
			}
			return __PresetHevc1920x1080;
		}
	}

	[Field("AVOutputSettingsPresetHEVC3840x2160", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	internal static NSString _PresetHevc3840x2160
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (__PresetHevc3840x2160 == null)
			{
				__PresetHevc3840x2160 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160");
			}
			return __PresetHevc3840x2160;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVOutputSettingsAssistant(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVOutputSettingsAssistant(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outputSettingsAssistantWithPreset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVOutputSettingsAssistant? FromPreset(string presetIdentifier)
	{
		if (presetIdentifier == null)
		{
			throw new ArgumentNullException("presetIdentifier");
		}
		IntPtr arg = NSString.CreateNative(presetIdentifier);
		AVOutputSettingsAssistant nSObject = Runtime.GetNSObject<AVOutputSettingsAssistant>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selOutputSettingsAssistantWithPreset_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

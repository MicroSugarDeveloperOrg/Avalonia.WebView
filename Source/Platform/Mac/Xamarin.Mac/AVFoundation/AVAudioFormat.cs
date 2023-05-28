using System;
using System.ComponentModel;
using AudioToolbox;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioFormat", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioFormat : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelCount = "channelCount";

	private static readonly IntPtr selChannelCountHandle = Selector.GetHandle("channelCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelLayout = "channelLayout";

	private static readonly IntPtr selChannelLayoutHandle = Selector.GetHandle("channelLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonFormat = "commonFormat";

	private static readonly IntPtr selCommonFormatHandle = Selector.GetHandle("commonFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescription = "formatDescription";

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitStandardFormatWithSampleRate_ChannelLayout_ = "initStandardFormatWithSampleRate:channelLayout:";

	private static readonly IntPtr selInitStandardFormatWithSampleRate_ChannelLayout_Handle = Selector.GetHandle("initStandardFormatWithSampleRate:channelLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitStandardFormatWithSampleRate_Channels_ = "initStandardFormatWithSampleRate:channels:";

	private static readonly IntPtr selInitStandardFormatWithSampleRate_Channels_Handle = Selector.GetHandle("initStandardFormatWithSampleRate:channels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCMAudioFormatDescription_ = "initWithCMAudioFormatDescription:";

	private static readonly IntPtr selInitWithCMAudioFormatDescription_Handle = Selector.GetHandle("initWithCMAudioFormatDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCommonFormat_SampleRate_Channels_Interleaved_ = "initWithCommonFormat:sampleRate:channels:interleaved:";

	private static readonly IntPtr selInitWithCommonFormat_SampleRate_Channels_Interleaved_Handle = Selector.GetHandle("initWithCommonFormat:sampleRate:channels:interleaved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCommonFormat_SampleRate_Interleaved_ChannelLayout_ = "initWithCommonFormat:sampleRate:interleaved:channelLayout:";

	private static readonly IntPtr selInitWithCommonFormat_SampleRate_Interleaved_ChannelLayout_Handle = Selector.GetHandle("initWithCommonFormat:sampleRate:interleaved:channelLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSettings_ = "initWithSettings:";

	private static readonly IntPtr selInitWithSettings_Handle = Selector.GetHandle("initWithSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStreamDescription_ = "initWithStreamDescription:";

	private static readonly IntPtr selInitWithStreamDescription_Handle = Selector.GetHandle("initWithStreamDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStreamDescription_ChannelLayout_ = "initWithStreamDescription:channelLayout:";

	private static readonly IntPtr selInitWithStreamDescription_ChannelLayout_Handle = Selector.GetHandle("initWithStreamDescription:channelLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqual_ = "isEqual:";

	private static readonly IntPtr selIsEqual_Handle = Selector.GetHandle("isEqual:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInterleaved = "isInterleaved";

	private static readonly IntPtr selIsInterleavedHandle = Selector.GetHandle("isInterleaved");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStandard = "isStandard";

	private static readonly IntPtr selIsStandardHandle = Selector.GetHandle("isStandard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagicCookie = "magicCookie";

	private static readonly IntPtr selMagicCookieHandle = Selector.GetHandle("magicCookie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleRate = "sampleRate";

	private static readonly IntPtr selSampleRateHandle = Selector.GetHandle("sampleRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagicCookie_ = "setMagicCookie:";

	private static readonly IntPtr selSetMagicCookie_Handle = Selector.GetHandle("setMagicCookie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSettings = "settings";

	private static readonly IntPtr selSettingsHandle = Selector.GetHandle("settings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamDescription = "streamDescription";

	private static readonly IntPtr selStreamDescriptionHandle = Selector.GetHandle("streamDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioFormat");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ChannelCount
	{
		[Export("channelCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selChannelCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selChannelCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioChannelLayout? ChannelLayout
	{
		[Export("channelLayout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioChannelLayout>(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelLayoutHandle));
			}
			return Runtime.GetNSObject<AVAudioChannelLayout>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelLayoutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioCommonFormat CommonFormat
	{
		[Export("commonFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioCommonFormat)Messaging.UInt64_objc_msgSend(base.Handle, selCommonFormatHandle);
			}
			return (AVAudioCommonFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCommonFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual CMAudioFormatDescription FormatDescription
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("formatDescription")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMAudioFormatDescription(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Interleaved
	{
		[Export("isInterleaved")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInterleavedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInterleavedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSData? MagicCookie
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("magicCookie", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selMagicCookieHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMagicCookieHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setMagicCookie:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMagicCookie_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMagicCookie_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double SampleRate
	{
		[Export("sampleRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSampleRateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSampleRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings Settings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakSettings != null) ? new NSMutableDictionary(WeakSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Standard
	{
		[Export("isStandard")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStandardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStandardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioStreamBasicDescription StreamDescription
	{
		[Export("streamDescription")]
		get
		{
			AudioStreamBasicDescription retval;
			if (base.IsDirectBinding)
			{
				Messaging.AudioStreamBasicDescription_objc_msgSend_stret(out retval, base.Handle, selStreamDescriptionHandle);
			}
			else
			{
				Messaging.AudioStreamBasicDescription_objc_msgSendSuper_stret(out retval, base.SuperHandle, selStreamDescriptionHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary WeakSettings
	{
		[Export("settings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSettingsHandle));
		}
	}

	public static bool operator ==(AVAudioFormat a, AVAudioFormat b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(AVAudioFormat a, AVAudioFormat b)
	{
		return !a.Equals(b);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioFormat()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAudioFormat(NSCoder coder)
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
	protected AVAudioFormat(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioFormat(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStreamDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(ref AudioStreamBasicDescription description)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_ref_AudioStreamBasicDescription(base.Handle, selInitWithStreamDescription_Handle, ref description), "initWithStreamDescription:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription(base.SuperHandle, selInitWithStreamDescription_Handle, ref description), "initWithStreamDescription:");
		}
	}

	[Export("initWithStreamDescription:channelLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(ref AudioStreamBasicDescription description, AVAudioChannelLayout? layout)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_ref_AudioStreamBasicDescription_IntPtr(base.Handle, selInitWithStreamDescription_ChannelLayout_Handle, ref description, (layout == null) ? IntPtr.Zero : layout.Handle), "initWithStreamDescription:channelLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription_IntPtr(base.SuperHandle, selInitWithStreamDescription_ChannelLayout_Handle, ref description, (layout == null) ? IntPtr.Zero : layout.Handle), "initWithStreamDescription:channelLayout:");
		}
	}

	[Export("initStandardFormatWithSampleRate:channels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(double sampleRate, uint channels)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_UInt32(base.Handle, selInitStandardFormatWithSampleRate_Channels_Handle, sampleRate, channels), "initStandardFormatWithSampleRate:channels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_UInt32(base.SuperHandle, selInitStandardFormatWithSampleRate_Channels_Handle, sampleRate, channels), "initStandardFormatWithSampleRate:channels:");
		}
	}

	[Export("initStandardFormatWithSampleRate:channelLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(double sampleRate, AVAudioChannelLayout layout)
		: base(NSObjectFlag.Empty)
	{
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_IntPtr(base.Handle, selInitStandardFormatWithSampleRate_ChannelLayout_Handle, sampleRate, layout.Handle), "initStandardFormatWithSampleRate:channelLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selInitStandardFormatWithSampleRate_ChannelLayout_Handle, sampleRate, layout.Handle), "initStandardFormatWithSampleRate:channelLayout:");
		}
	}

	[Export("initWithCommonFormat:sampleRate:channels:interleaved:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(AVAudioCommonFormat format, double sampleRate, uint channels, bool interleaved)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_Double_UInt32_bool(base.Handle, selInitWithCommonFormat_SampleRate_Channels_Interleaved_Handle, (ulong)format, sampleRate, channels, interleaved), "initWithCommonFormat:sampleRate:channels:interleaved:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_Double_UInt32_bool(base.SuperHandle, selInitWithCommonFormat_SampleRate_Channels_Interleaved_Handle, (ulong)format, sampleRate, channels, interleaved), "initWithCommonFormat:sampleRate:channels:interleaved:");
		}
	}

	[Export("initWithCommonFormat:sampleRate:interleaved:channelLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(AVAudioCommonFormat format, double sampleRate, bool interleaved, AVAudioChannelLayout layout)
		: base(NSObjectFlag.Empty)
	{
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_Double_bool_IntPtr(base.Handle, selInitWithCommonFormat_SampleRate_Interleaved_ChannelLayout_Handle, (ulong)format, sampleRate, interleaved, layout.Handle), "initWithCommonFormat:sampleRate:interleaved:channelLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_Double_bool_IntPtr(base.SuperHandle, selInitWithCommonFormat_SampleRate_Interleaved_ChannelLayout_Handle, (ulong)format, sampleRate, interleaved, layout.Handle), "initWithCommonFormat:sampleRate:interleaved:channelLayout:");
		}
	}

	[Export("initWithSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(NSDictionary settings)
		: base(NSObjectFlag.Empty)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSettings_Handle, settings.Handle), "initWithSettings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSettings_Handle, settings.Handle), "initWithSettings:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(AudioSettings settings)
		: this(settings.GetDictionary())
	{
	}

	[Export("initWithCMAudioFormatDescription:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFormat(CMAudioFormatDescription formatDescription)
		: base(NSObjectFlag.Empty)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCMAudioFormatDescription_Handle, formatDescription.Handle), "initWithCMAudioFormatDescription:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCMAudioFormatDescription_Handle, formatDescription.Handle), "initWithCMAudioFormatDescription:");
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

	[Export("isEqual:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual bool IsEqual(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqual_Handle, obj.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqual_Handle, obj.Handle);
	}
}

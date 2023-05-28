using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSpeechUtterance", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class AVSpeechUtterance : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedSpeechString = "attributedSpeechString";

	private static readonly IntPtr selAttributedSpeechStringHandle = Selector.GetHandle("attributedSpeechString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttributedString_ = "initWithAttributedString:";

	private static readonly IntPtr selInitWithAttributedString_Handle = Selector.GetHandle("initWithAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPitchMultiplier = "pitchMultiplier";

	private static readonly IntPtr selPitchMultiplierHandle = Selector.GetHandle("pitchMultiplier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostUtteranceDelay = "postUtteranceDelay";

	private static readonly IntPtr selPostUtteranceDelayHandle = Selector.GetHandle("postUtteranceDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreUtteranceDelay = "preUtteranceDelay";

	private static readonly IntPtr selPreUtteranceDelayHandle = Selector.GetHandle("preUtteranceDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPitchMultiplier_ = "setPitchMultiplier:";

	private static readonly IntPtr selSetPitchMultiplier_Handle = Selector.GetHandle("setPitchMultiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostUtteranceDelay_ = "setPostUtteranceDelay:";

	private static readonly IntPtr selSetPostUtteranceDelay_Handle = Selector.GetHandle("setPostUtteranceDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreUtteranceDelay_ = "setPreUtteranceDelay:";

	private static readonly IntPtr selSetPreUtteranceDelay_Handle = Selector.GetHandle("setPreUtteranceDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoice_ = "setVoice:";

	private static readonly IntPtr selSetVoice_Handle = Selector.GetHandle("setVoice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeechString = "speechString";

	private static readonly IntPtr selSpeechStringHandle = Selector.GetHandle("speechString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeechUtteranceWithAttributedString_ = "speechUtteranceWithAttributedString:";

	private static readonly IntPtr selSpeechUtteranceWithAttributedString_Handle = Selector.GetHandle("speechUtteranceWithAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeechUtteranceWithString_ = "speechUtteranceWithString:";

	private static readonly IntPtr selSpeechUtteranceWithString_Handle = Selector.GetHandle("speechUtteranceWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoice = "voice";

	private static readonly IntPtr selVoiceHandle = Selector.GetHandle("voice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSpeechUtterance");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NSAttributedString AttributedSpeechString
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("attributedSpeechString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedSpeechStringHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedSpeechStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PitchMultiplier
	{
		[Export("pitchMultiplier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPitchMultiplierHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPitchMultiplierHandle);
		}
		[Export("setPitchMultiplier:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPitchMultiplier_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPitchMultiplier_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double PostUtteranceDelay
	{
		[Export("postUtteranceDelay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPostUtteranceDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPostUtteranceDelayHandle);
		}
		[Export("setPostUtteranceDelay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPostUtteranceDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPostUtteranceDelay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double PreUtteranceDelay
	{
		[Export("preUtteranceDelay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPreUtteranceDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPreUtteranceDelayHandle);
		}
		[Export("setPreUtteranceDelay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPreUtteranceDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPreUtteranceDelay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SpeechString
	{
		[Export("speechString", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSpeechStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpeechStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSpeechSynthesisVoice? Voice
	{
		[Export("voice", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVSpeechSynthesisVoice>(Messaging.IntPtr_objc_msgSend(base.Handle, selVoiceHandle));
			}
			return Runtime.GetNSObject<AVSpeechSynthesisVoice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVoiceHandle));
		}
		[Export("setVoice:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVoice_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVoice_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[Field("AVSpeechUtteranceDefaultSpeechRate", "AVFoundation")]
	public static float DefaultSpeechRate => Dlfcn.GetFloat(Libraries.AVFoundation.Handle, "AVSpeechUtteranceDefaultSpeechRate");

	[Field("AVSpeechUtteranceMaximumSpeechRate", "AVFoundation")]
	public static float MaximumSpeechRate => Dlfcn.GetFloat(Libraries.AVFoundation.Handle, "AVSpeechUtteranceMaximumSpeechRate");

	[Field("AVSpeechUtteranceMinimumSpeechRate", "AVFoundation")]
	public static float MinimumSpeechRate => Dlfcn.GetFloat(Libraries.AVFoundation.Handle, "AVSpeechUtteranceMinimumSpeechRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSpeechUtterance()
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
	public AVSpeechUtterance(NSCoder coder)
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
	protected AVSpeechUtterance(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSpeechUtterance(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVSpeechUtterance(string speechString)
		: base(NSObjectFlag.Empty)
	{
		if (speechString == null)
		{
			throw new ArgumentNullException("speechString");
		}
		IntPtr arg = NSString.CreateNative(speechString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithAttributedString:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVSpeechUtterance(NSAttributedString speechString)
		: base(NSObjectFlag.Empty)
	{
		if (speechString == null)
		{
			throw new ArgumentNullException("speechString");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributedString_Handle, speechString.Handle), "initWithAttributedString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributedString_Handle, speechString.Handle), "initWithAttributedString:");
		}
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

	[Export("speechUtteranceWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVSpeechUtterance FromString(string speechString)
	{
		if (speechString == null)
		{
			throw new ArgumentNullException("speechString");
		}
		IntPtr arg = NSString.CreateNative(speechString);
		AVSpeechUtterance nSObject = Runtime.GetNSObject<AVSpeechUtterance>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSpeechUtteranceWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("speechUtteranceWithAttributedString:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVSpeechUtterance FromString(NSAttributedString speechString)
	{
		if (speechString == null)
		{
			throw new ArgumentNullException("speechString");
		}
		return Runtime.GetNSObject<AVSpeechUtterance>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSpeechUtteranceWithAttributedString_Handle, speechString.Handle));
	}
}

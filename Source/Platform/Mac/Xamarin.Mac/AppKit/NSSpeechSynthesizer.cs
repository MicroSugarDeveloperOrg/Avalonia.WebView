using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpeechSynthesizer", true)]
public class NSSpeechSynthesizer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSpeechDictionary_ = "addSpeechDictionary:";

	private static readonly IntPtr selAddSpeechDictionary_Handle = Selector.GetHandle("addSpeechDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesForVoice_ = "attributesForVoice:";

	private static readonly IntPtr selAttributesForVoice_Handle = Selector.GetHandle("attributesForVoice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableVoices = "availableVoices";

	private static readonly IntPtr selAvailableVoicesHandle = Selector.GetHandle("availableVoices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueSpeaking = "continueSpeaking";

	private static readonly IntPtr selContinueSpeakingHandle = Selector.GetHandle("continueSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultVoice = "defaultVoice";

	private static readonly IntPtr selDefaultVoiceHandle = Selector.GetHandle("defaultVoice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVoice_ = "initWithVoice:";

	private static readonly IntPtr selInitWithVoice_Handle = Selector.GetHandle("initWithVoice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnyApplicationSpeaking = "isAnyApplicationSpeaking";

	private static readonly IntPtr selIsAnyApplicationSpeakingHandle = Selector.GetHandle("isAnyApplicationSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSpeaking = "isSpeaking";

	private static readonly IntPtr selIsSpeakingHandle = Selector.GetHandle("isSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForProperty_Error_ = "objectForProperty:error:";

	private static readonly IntPtr selObjectForProperty_Error_Handle = Selector.GetHandle("objectForProperty:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseSpeakingAtBoundary_ = "pauseSpeakingAtBoundary:";

	private static readonly IntPtr selPauseSpeakingAtBoundary_Handle = Selector.GetHandle("pauseSpeakingAtBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhonemesFromText_ = "phonemesFromText:";

	private static readonly IntPtr selPhonemesFromText_Handle = Selector.GetHandle("phonemesFromText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForProperty_Error_ = "setObject:forProperty:error:";

	private static readonly IntPtr selSetObject_ForProperty_Error_Handle = Selector.GetHandle("setObject:forProperty:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesFeedbackWindow_ = "setUsesFeedbackWindow:";

	private static readonly IntPtr selSetUsesFeedbackWindow_Handle = Selector.GetHandle("setUsesFeedbackWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoice_ = "setVoice:";

	private static readonly IntPtr selSetVoice_Handle = Selector.GetHandle("setVoice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSpeakingString_ = "startSpeakingString:";

	private static readonly IntPtr selStartSpeakingString_Handle = Selector.GetHandle("startSpeakingString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSpeakingString_ToURL_ = "startSpeakingString:toURL:";

	private static readonly IntPtr selStartSpeakingString_ToURL_Handle = Selector.GetHandle("startSpeakingString:toURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSpeaking = "stopSpeaking";

	private static readonly IntPtr selStopSpeakingHandle = Selector.GetHandle("stopSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSpeakingAtBoundary_ = "stopSpeakingAtBoundary:";

	private static readonly IntPtr selStopSpeakingAtBoundary_Handle = Selector.GetHandle("stopSpeakingAtBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesFeedbackWindow = "usesFeedbackWindow";

	private static readonly IntPtr selUsesFeedbackWindowHandle = Selector.GetHandle("usesFeedbackWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoice = "voice";

	private static readonly IntPtr selVoiceHandle = Selector.GetHandle("voice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSpeechSynthesizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public string Voice
	{
		get
		{
			return GetVoice();
		}
		set
		{
			SetVoice(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AvailableVoices
	{
		[Export("availableVoices")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableVoicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string DefaultVoice
	{
		[Export("defaultVoice")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultVoiceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSSpeechSynthesizerDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSSpeechSynthesizerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAnyApplicationSpeaking
	{
		[Export("isAnyApplicationSpeaking")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAnyApplicationSpeakingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSpeaking
	{
		[Export("isSpeaking")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpeakingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpeakingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual bool UsesFeedbackWindow
	{
		[Export("usesFeedbackWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFeedbackWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFeedbackWindowHandle);
		}
		[Export("setUsesFeedbackWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFeedbackWindow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFeedbackWindow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpeechSynthesizer()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSSpeechSynthesizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSpeechSynthesizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithVoice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSpeechSynthesizer(string voice)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVoice_Handle, arg), "initWithVoice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVoice_Handle, arg), "initWithVoice:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addSpeechDictionary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSpeechDictionary(NSDictionary speechDictionary)
	{
		NSApplication.EnsureUIThread();
		if (speechDictionary == null)
		{
			throw new ArgumentNullException("speechDictionary");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSpeechDictionary_Handle, speechDictionary.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSpeechDictionary_Handle, speechDictionary.Handle);
		}
	}

	[Export("attributesForVoice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary AttributesForVoice(string voice)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAttributesForVoice_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("continueSpeaking")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContinueSpeaking()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selContinueSpeakingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selContinueSpeakingHandle);
		}
	}

	[Export("voice")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual string GetVoice()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVoiceHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVoiceHandle));
	}

	[Export("objectForProperty:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectForProperty(string property, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(property);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selObjectForProperty_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selObjectForProperty_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("pauseSpeakingAtBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseSpeaking(NSSpeechBoundary boundary)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selPauseSpeakingAtBoundary_Handle, (ulong)boundary);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selPauseSpeakingAtBoundary_Handle, (ulong)boundary);
		}
	}

	[Export("phonemesFromText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PhonemesFromText(string text)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPhonemesFromText_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPhonemesFromText_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setObject:forProperty:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetObjectforProperty(NSObject theObject, string property, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (theObject == null)
		{
			throw new ArgumentNullException("theObject");
		}
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(property);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selSetObject_ForProperty_Error_Handle, theObject.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selSetObject_ForProperty_Error_Handle, theObject.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setVoice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetVoice(string voice)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVoice_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetVoice_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("startSpeakingString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartSpeakingString(string theString)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		IntPtr arg = NSString.CreateNative(theString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeakingString_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selStartSpeakingString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("startSpeakingString:toURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartSpeakingStringtoURL(string theString, NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(theString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartSpeakingString_ToURL_Handle, arg, url.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartSpeakingString_ToURL_Handle, arg, url.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stopSpeaking")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSpeaking()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopSpeakingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopSpeakingHandle);
		}
	}

	[Export("stopSpeakingAtBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSpeaking(NSSpeechBoundary boundary)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selStopSpeakingAtBoundary_Handle, (ulong)boundary);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selStopSpeakingAtBoundary_Handle, (ulong)boundary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

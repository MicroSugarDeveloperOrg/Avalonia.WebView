using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpeechSynthesizer", true)]
public class NSSpeechSynthesizer : NSObject
{
	private static readonly IntPtr selIsSpeakingHandle = Selector.GetHandle("isSpeaking");

	private static readonly IntPtr selIsAnyApplicationSpeakingHandle = Selector.GetHandle("isAnyApplicationSpeaking");

	private static readonly IntPtr selDefaultVoiceHandle = Selector.GetHandle("defaultVoice");

	private static readonly IntPtr selAvailableVoicesHandle = Selector.GetHandle("availableVoices");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr selUsesFeedbackWindowHandle = Selector.GetHandle("usesFeedbackWindow");

	private static readonly IntPtr selSetUsesFeedbackWindow_Handle = Selector.GetHandle("setUsesFeedbackWindow:");

	private static readonly IntPtr selInitWithVoice_Handle = Selector.GetHandle("initWithVoice:");

	private static readonly IntPtr selStartSpeakingString_Handle = Selector.GetHandle("startSpeakingString:");

	private static readonly IntPtr selStartSpeakingStringToURL_Handle = Selector.GetHandle("startSpeakingString:toURL:");

	private static readonly IntPtr selStopSpeakingHandle = Selector.GetHandle("stopSpeaking");

	private static readonly IntPtr selStopSpeakingAtBoundary_Handle = Selector.GetHandle("stopSpeakingAtBoundary:");

	private static readonly IntPtr selPauseSpeakingAtBoundary_Handle = Selector.GetHandle("pauseSpeakingAtBoundary:");

	private static readonly IntPtr selContinueSpeakingHandle = Selector.GetHandle("continueSpeaking");

	private static readonly IntPtr selAddSpeechDictionary_Handle = Selector.GetHandle("addSpeechDictionary:");

	private static readonly IntPtr selPhonemesFromText_Handle = Selector.GetHandle("phonemesFromText:");

	private static readonly IntPtr selObjectForPropertyError_Handle = Selector.GetHandle("objectForProperty:error:");

	private static readonly IntPtr selSetObjectForPropertyError_Handle = Selector.GetHandle("setObject:forProperty:error:");

	private static readonly IntPtr selAttributesForVoice_Handle = Selector.GetHandle("attributesForVoice:");

	private static readonly IntPtr selVoiceHandle = Selector.GetHandle("voice");

	private static readonly IntPtr selSetVoice_Handle = Selector.GetHandle("setVoice:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSpeechSynthesizer");

	private object __mt_WeakDelegate_var;

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

	public virtual bool IsSpeaking
	{
		[Export("isSpeaking")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpeakingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpeakingHandle);
		}
	}

	public static bool IsAnyApplicationSpeaking
	{
		[Export("isAnyApplicationSpeaking")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAnyApplicationSpeakingHandle);
		}
	}

	public static string DefaultVoice
	{
		[Export("defaultVoice")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultVoiceHandle));
		}
	}

	public static string[] AvailableVoices
	{
		[Export("availableVoices")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableVoicesHandle));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSSpeechSynthesizerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSpeechSynthesizerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	public virtual bool UsesFeedbackWindow
	{
		[Export("usesFeedbackWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFeedbackWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFeedbackWindowHandle);
		}
		[Export("setUsesFeedbackWindow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFeedbackWindow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFeedbackWindow_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpeechSynthesizer()
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
	public NSSpeechSynthesizer(NSCoder coder)
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
	public NSSpeechSynthesizer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSpeechSynthesizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithVoice:")]
	public NSSpeechSynthesizer(string voice)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVoice_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVoice_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("startSpeakingString:")]
	public virtual bool StartSpeakingString(string theString)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		IntPtr arg = NSString.CreateNative(theString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartSpeakingString_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selStartSpeakingString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("startSpeakingString:toURL:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartSpeakingStringToURL_Handle, arg, url.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartSpeakingStringToURL_Handle, arg, url.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stopSpeaking")]
	public virtual void StopSpeaking()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopSpeakingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopSpeakingHandle);
		}
	}

	[Export("stopSpeakingAtBoundary:")]
	public virtual void StopSpeaking(NSSpeechBoundary boundary)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selStopSpeakingAtBoundary_Handle, (ulong)boundary);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selStopSpeakingAtBoundary_Handle, (ulong)boundary);
		}
	}

	[Export("pauseSpeakingAtBoundary:")]
	public virtual void PauseSpeaking(NSSpeechBoundary boundary)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selPauseSpeakingAtBoundary_Handle, (ulong)boundary);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selPauseSpeakingAtBoundary_Handle, (ulong)boundary);
		}
	}

	[Export("continueSpeaking")]
	public virtual void ContinueSpeaking()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selContinueSpeakingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selContinueSpeakingHandle);
		}
	}

	[Export("addSpeechDictionary:")]
	public virtual void AddSpeechDictionary(NSDictionary speechDictionary)
	{
		NSApplication.EnsureUIThread();
		if (speechDictionary == null)
		{
			throw new ArgumentNullException("speechDictionary");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSpeechDictionary_Handle, speechDictionary.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSpeechDictionary_Handle, speechDictionary.Handle);
		}
	}

	[Export("phonemesFromText:")]
	public virtual string PhonemesFromText(string text)
	{
		NSApplication.EnsureUIThread();
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPhonemesFromText_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPhonemesFromText_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectForProperty:error:")]
	public virtual NSObject ObjectForProperty(string property, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(property);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObjectForPropertyError_Handle, arg, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selObjectForPropertyError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setObject:forProperty:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(property);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetObjectForPropertyError_Handle, theObject.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetObjectForPropertyError_Handle, theObject.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("attributesForVoice:")]
	public static NSDictionary AttributesForVoice(string voice)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAttributesForVoice_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("voice")]
	protected virtual string GetVoice()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVoiceHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVoiceHandle));
	}

	[Export("setVoice:")]
	protected virtual bool SetVoice(string voice)
	{
		NSApplication.EnsureUIThread();
		if (voice == null)
		{
			throw new ArgumentNullException("voice");
		}
		IntPtr arg = NSString.CreateNative(voice);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVoice_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetVoice_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

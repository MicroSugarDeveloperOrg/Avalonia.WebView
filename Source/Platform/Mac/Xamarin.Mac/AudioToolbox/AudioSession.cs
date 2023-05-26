using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AudioToolbox;

public static class AudioSession
{
	private delegate void InterruptionListener(IntPtr userData, uint state);

	private delegate void _PropertyListener(IntPtr userData, AudioSessionProperty prop, int size, IntPtr data);

	public delegate void PropertyListener(AudioSessionProperty prop, int size, IntPtr data);

	private static bool initialized;

	internal static NSString AudioRouteKey_Type;

	internal static NSString AudioRouteKey_Inputs;

	internal static NSString AudioRouteKey_Outputs;

	private static NSString InputRoute_LineIn;

	private static NSString InputRoute_BuiltInMic;

	private static NSString InputRoute_HeadsetMic;

	private static NSString InputRoute_BluetoothHFP;

	private static NSString InputRoute_USBAudio;

	private static NSString OutputRoute_LineOut;

	private static NSString OutputRoute_Headphones;

	private static NSString OutputRoute_BluetoothHFP;

	private static NSString OutputRoute_BluetoothA2DP;

	private static NSString OutputRoute_BuiltInReceiver;

	private static NSString OutputRoute_BuiltInSpeaker;

	private static NSString OutputRoute_USBAudio;

	private static NSString OutputRoute_HDMI;

	private static NSString OutputRoute_AirPlay;

	private static NSString InputSourceKey_ID;

	private static NSString InputSourceKey_Description;

	private static NSString OutputDestinationKey_ID;

	private static NSString OutputDestinationKey_Description;

	private static Dictionary<AudioSessionProperty, List<PropertyListener>> listeners;

	private static Dictionary<object, PropertyListener> strongListenerHash;

	public static double PreferredHardwareSampleRate
	{
		get
		{
			return GetDouble(AudioSessionProperty.PreferredHardwareSampleRate);
		}
		set
		{
			SetDouble(AudioSessionProperty.PreferredHardwareSampleRate, value);
		}
	}

	public static float PreferredHardwareIOBufferDuration
	{
		get
		{
			return GetFloat(AudioSessionProperty.PreferredHardwareIOBufferDuration);
		}
		set
		{
			SetFloat(AudioSessionProperty.PreferredHardwareIOBufferDuration, value);
		}
	}

	public static AudioSessionCategory Category
	{
		get
		{
			return (AudioSessionCategory)GetInt(AudioSessionProperty.AudioCategory);
		}
		set
		{
			SetInt(AudioSessionProperty.AudioCategory, (int)value);
		}
	}

	[Since(4, 0)]
	public static AudioSessionInterruptionType InterruptionType => (AudioSessionInterruptionType)GetInt(AudioSessionProperty.InterruptionType);

	[Obsolete("Deprecated in iOS 5.0. Use InputRoute or OutputRoute instead")]
	public static string AudioRoute => CFString.FetchString(GetIntPtr(AudioSessionProperty.AudioRoute));

	[Since(5, 0)]
	public static AccessoryInfo[] InputSources => ExtractAccessoryInfo(GetIntPtr(AudioSessionProperty.InputSources), InputSourceKey_ID, InputSourceKey_Description);

	[Since(5, 0)]
	public static AccessoryInfo[] OutputDestinations => ExtractAccessoryInfo(GetIntPtr(AudioSessionProperty.OutputDestinations), OutputDestinationKey_ID, OutputDestinationKey_Description);

	[Since(5, 0)]
	public static AudioSessionInputRouteKind InputRoute => GetInputRoute((NSArray)AudioRouteDescription[AudioRouteKey_Inputs]);

	[Since(5, 0)]
	public static AudioSessionOutputRouteKind[] OutputRoutes => GetOutputRoutes((NSArray)AudioRouteDescription[AudioRouteKey_Outputs]);

	private static NSDictionary AudioRouteDescription
	{
		get
		{
			NSDictionary nSDictionary = new NSDictionary(GetIntPtr(AudioSessionProperty.AudioRouteDescription));
			nSDictionary.Release();
			return nSDictionary;
		}
	}

	public static double CurrentHardwareSampleRate => GetDouble(AudioSessionProperty.CurrentHardwareSampleRate);

	public static int CurrentHardwareInputNumberChannels => GetInt(AudioSessionProperty.CurrentHardwareInputNumberChannels);

	public static int CurrentHardwareOutputNumberChannels => GetInt(AudioSessionProperty.CurrentHardwareOutputNumberChannels);

	public static float CurrentHardwareOutputVolume => GetFloat(AudioSessionProperty.CurrentHardwareOutputVolume);

	public static float CurrentHardwareInputLatency => GetFloat(AudioSessionProperty.CurrentHardwareInputLatency);

	public static float CurrentHardwareOutputLatency => GetFloat(AudioSessionProperty.CurrentHardwareOutputLatency);

	public static float CurrentHardwareIOBufferDuration => GetFloat(AudioSessionProperty.CurrentHardwareIOBufferDuration);

	public static bool OtherAudioIsPlaying => GetInt(AudioSessionProperty.OtherAudioIsPlaying) != 0;

	public static AudioSessionRoutingOverride RoutingOverride
	{
		set
		{
			SetInt(AudioSessionProperty.OverrideAudioRoute, (int)value);
		}
	}

	public static bool AudioInputAvailable => GetInt(AudioSessionProperty.AudioInputAvailable) != 0;

	public static bool AudioShouldDuck
	{
		get
		{
			return GetInt(AudioSessionProperty.OtherMixableAudioShouldDuck) != 0;
		}
		set
		{
			SetInt(AudioSessionProperty.OtherMixableAudioShouldDuck, value ? 1 : 0);
		}
	}

	public static bool OverrideCategoryMixWithOthers
	{
		get
		{
			return GetInt(AudioSessionProperty.OverrideCategoryMixWithOthers) != 0;
		}
		set
		{
			SetInt(AudioSessionProperty.OverrideCategoryMixWithOthers, value ? 1 : 0);
		}
	}

	public static bool OverrideCategoryDefaultToSpeaker
	{
		get
		{
			return GetInt(AudioSessionProperty.OverrideCategoryDefaultToSpeaker) != 0;
		}
		set
		{
			SetInt(AudioSessionProperty.OverrideCategoryDefaultToSpeaker, value ? 1 : 0);
		}
	}

	public static bool OverrideCategoryEnableBluetoothInput
	{
		get
		{
			return GetInt(AudioSessionProperty.OverrideCategoryEnableBluetoothInput) != 0;
		}
		set
		{
			SetInt(AudioSessionProperty.OverrideCategoryEnableBluetoothInput, value ? 1 : 0);
		}
	}

	[Since(5, 0)]
	public static AudioSessionMode Mode
	{
		get
		{
			return (AudioSessionMode)GetInt(AudioSessionProperty.Mode);
		}
		set
		{
			SetInt(AudioSessionProperty.Mode, (int)value);
		}
	}

	[Since(5, 0)]
	public static bool InputGainAvailable => GetInt(AudioSessionProperty.InputGainAvailable) != 0;

	[Since(5, 0)]
	public static float InputGainScalar
	{
		get
		{
			return GetFloat(AudioSessionProperty.InputGainScalar);
		}
		set
		{
			SetFloat(AudioSessionProperty.InputGainScalar, value);
		}
	}

	public static event EventHandler Interrupted;

	public static event EventHandler Resumed;

	public static event EventHandler<AudioSessionRouteChangeEventArgs> AudioRouteChanged
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.AudioRouteChange, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(null, new AudioSessionRouteChangeEventArgs(data));
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.AudioRouteChange, value);
		}
	}

	public static event Action<float> CurrentHardwareOutputVolumeChanged
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.CurrentHardwareOutputVolume, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value((long)data);
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.CurrentHardwareOutputVolume, value);
		}
	}

	public static event Action<bool> AudioInputBecameAvailable
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.AudioInputAvailable, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(data != IntPtr.Zero);
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.AudioInputAvailable, value);
		}
	}

	public static event Action<bool> ServerDied
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.ServerDied, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(data != IntPtr.Zero);
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.ServerDied, value);
		}
	}

	[Since(5, 0)]
	public static event Action<bool> InputGainBecameAvailable
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.InputGainAvailable, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(data != IntPtr.Zero);
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.InputGainAvailable, value);
		}
	}

	[Since(5, 0)]
	public static event Action<float> InputGainScalarChanged
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.InputGainScalar, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value((long)data);
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.InputGainScalar, value);
		}
	}

	[Since(5, 0)]
	public static event Action<AccessoryInfo[]> InputSourcesChanged
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.InputSources, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(ExtractAccessoryInfo(data, InputSourceKey_ID, InputSourceKey_Description));
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.InputSources, value);
		}
	}

	[Since(5, 0)]
	public static event Action<AccessoryInfo[]> OutputDestinationsChanged
	{
		add
		{
			AddListenerEvent(AudioSessionProperty.OutputDestinations, value, delegate(AudioSessionProperty prop, int size, IntPtr data)
			{
				value(ExtractAccessoryInfo(data, OutputDestinationKey_ID, OutputDestinationKey_Description));
			});
		}
		remove
		{
			RemoveListenerEvent(AudioSessionProperty.OutputDestinations, value);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionInitialize(IntPtr cfRunLoop, IntPtr cfstr_runMode, InterruptionListener listener, IntPtr userData);

	public static void Initialize()
	{
		Initialize(null, null);
	}

	public static void Initialize(CFRunLoop runLoop, string runMode)
	{
		CFString cFString = ((runMode == null) ? null : new CFString(runMode));
		int num = AudioSessionInitialize((runLoop == null) ? IntPtr.Zero : runLoop.Handle, cFString?.Handle ?? IntPtr.Zero, Interruption, IntPtr.Zero);
		if (num != 0 && num != 1768843636)
		{
			throw new AudioSessionException(num);
		}
		if (!initialized)
		{
			IntPtr handle = Dlfcn.dlopen("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", 0);
			AudioRouteKey_Inputs = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_AudioRouteKey_Inputs"));
			AudioRouteKey_Outputs = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_AudioRouteKey_Outputs"));
			AudioRouteKey_Type = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_AudioRouteKey_Type"));
			InputRoute_LineIn = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionInputRoute_LineIn"));
			InputRoute_BuiltInMic = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionInputRoute_BuiltInMic"));
			InputRoute_HeadsetMic = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionInputRoute_HeadsetMic"));
			InputRoute_BluetoothHFP = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionInputRoute_BluetoothHFP"));
			InputRoute_USBAudio = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionInputRoute_USBAudio"));
			OutputRoute_LineOut = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_LineOut"));
			OutputRoute_Headphones = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_Headphones"));
			OutputRoute_BluetoothHFP = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_BluetoothHFP"));
			OutputRoute_BluetoothA2DP = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_BluetoothA2DP"));
			OutputRoute_BuiltInReceiver = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_BuiltInReceiver"));
			OutputRoute_BuiltInSpeaker = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_BuiltInSpeaker"));
			OutputRoute_USBAudio = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_USBAudio"));
			OutputRoute_HDMI = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_HDMI"));
			OutputRoute_AirPlay = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSessionOutputRoute_AirPlay"));
			InputSourceKey_ID = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_InputSourceKey_ID"));
			InputSourceKey_Description = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_InputSourceKey_Description"));
			OutputDestinationKey_ID = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_OutputDestinationKey_ID"));
			OutputDestinationKey_Description = new NSString(Dlfcn.GetIntPtr(handle, "kAudioSession_OutputDestinationKey_Description"));
			Dlfcn.dlclose(handle);
			initialized = true;
		}
	}

	[MonoPInvokeCallback(typeof(InterruptionListener))]
	private static void Interruption(IntPtr userData, uint state)
	{
		((state == 1) ? AudioSession.Interrupted : AudioSession.Resumed)?.Invoke(null, EventArgs.Empty);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionSetActive(int active);

	public static void SetActive(bool active)
	{
		int num = AudioSessionSetActive(active ? 1 : 0);
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioSessionErrors AudioSessionSetActive(int active, AudioSessionActiveFlags inFlags);

	[Since(4, 0)]
	public static AudioSessionErrors SetActive(bool active, AudioSessionActiveFlags flags)
	{
		return AudioSessionSetActive(active ? 1 : 0, flags);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionGetProperty(AudioSessionProperty id, ref int size, IntPtr data);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionSetProperty(AudioSessionProperty id, int size, IntPtr data);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioSessionGetPropertySize(AudioSessionProperty id, out int size);

	private unsafe static double GetDouble(AudioSessionProperty property)
	{
		double result = 0.0;
		int size = 8;
		int num = AudioSessionGetProperty(property, ref size, (IntPtr)(&result));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
		return result;
	}

	private unsafe static float GetFloat(AudioSessionProperty property)
	{
		float result = 0f;
		int size = 4;
		int num = AudioSessionGetProperty(property, ref size, (IntPtr)(&result));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
		return result;
	}

	private unsafe static int GetInt(AudioSessionProperty property)
	{
		int result = 0;
		int size = 4;
		int num = AudioSessionGetProperty(property, ref size, (IntPtr)(&result));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
		return result;
	}

	private unsafe static IntPtr GetIntPtr(AudioSessionProperty property)
	{
		int size = IntPtr.Size;
		IntPtr result = default(IntPtr);
		int num = AudioSessionGetProperty(property, ref size, (IntPtr)(&result));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
		return result;
	}

	private unsafe static void SetDouble(AudioSessionProperty property, double val)
	{
		int num = AudioSessionSetProperty(property, 8, (IntPtr)(&val));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
	}

	private unsafe static void SetInt(AudioSessionProperty property, int val)
	{
		int num = AudioSessionSetProperty(property, 4, (IntPtr)(&val));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
	}

	private unsafe static void SetFloat(AudioSessionProperty property, float val)
	{
		int num = AudioSessionSetProperty(property, 4, (IntPtr)(&val));
		if (num != 0)
		{
			throw new AudioSessionException(num);
		}
	}

	private static AccessoryInfo[] ExtractAccessoryInfo(IntPtr ptr, NSString id, NSString description)
	{
		using CFArray cFArray = new CFArray(ptr);
		AccessoryInfo[] array = new AccessoryInfo[cFArray.Count];
		for (int i = 0; i < array.Length; i++)
		{
			IntPtr value = cFArray.GetValue(i);
			NSNumber nSNumber = new NSNumber(CFDictionary.GetValue(value, id.Handle));
			string description2 = CFString.FetchString(CFDictionary.GetValue(value, description.Handle));
			array[i] = new AccessoryInfo((int)nSNumber, description2);
			id.Dispose();
		}
		return array;
	}

	internal static AudioSessionInputRouteKind GetInputRoute(NSArray arr)
	{
		if (arr == null || arr.Count == 0L)
		{
			return AudioSessionInputRouteKind.None;
		}
		NSDictionary nSDictionary = new NSDictionary(arr.ValueAt(0uL));
		if (nSDictionary == null || nSDictionary.Count == 0L)
		{
			return AudioSessionInputRouteKind.None;
		}
		NSString nSString = (NSString)nSDictionary[AudioRouteKey_Type];
		if (nSString == null)
		{
			return AudioSessionInputRouteKind.None;
		}
		if (nSString == InputRoute_LineIn)
		{
			return AudioSessionInputRouteKind.LineIn;
		}
		if (nSString == InputRoute_BuiltInMic)
		{
			return AudioSessionInputRouteKind.BuiltInMic;
		}
		if (nSString == InputRoute_HeadsetMic)
		{
			return AudioSessionInputRouteKind.HeadsetMic;
		}
		if (nSString == InputRoute_BluetoothHFP)
		{
			return AudioSessionInputRouteKind.BluetoothHFP;
		}
		if (nSString == InputRoute_USBAudio)
		{
			return AudioSessionInputRouteKind.USBAudio;
		}
		return (AudioSessionInputRouteKind)(int)nSString.Handle;
	}

	internal static AudioSessionOutputRouteKind[] GetOutputRoutes(NSArray arr)
	{
		if (arr == null || arr.Count == 0L)
		{
			return null;
		}
		AudioSessionOutputRouteKind[] array = new AudioSessionOutputRouteKind[arr.Count];
		for (uint num = 0u; num < arr.Count; num++)
		{
			NSDictionary nSDictionary = new NSDictionary(arr.ValueAt(num));
			array[num] = AudioSessionOutputRouteKind.None;
			if (nSDictionary == null || nSDictionary.Count == 0L)
			{
				continue;
			}
			NSString nSString = (NSString)nSDictionary[AudioRouteKey_Type];
			if (!(nSString == null))
			{
				if (nSString == OutputRoute_LineOut)
				{
					array[num] = AudioSessionOutputRouteKind.LineOut;
				}
				else if (nSString == OutputRoute_Headphones)
				{
					array[num] = AudioSessionOutputRouteKind.Headphones;
				}
				else if (nSString == OutputRoute_BluetoothHFP)
				{
					array[num] = AudioSessionOutputRouteKind.BluetoothHFP;
				}
				else if (nSString == OutputRoute_BluetoothA2DP)
				{
					array[num] = AudioSessionOutputRouteKind.BluetoothA2DP;
				}
				else if (nSString == OutputRoute_BuiltInReceiver)
				{
					array[num] = AudioSessionOutputRouteKind.BuiltInReceiver;
				}
				else if (nSString == OutputRoute_BuiltInSpeaker)
				{
					array[num] = AudioSessionOutputRouteKind.BuiltInSpeaker;
				}
				else if (nSString == OutputRoute_USBAudio)
				{
					array[num] = AudioSessionOutputRouteKind.USBAudio;
				}
				else if (nSString == OutputRoute_HDMI)
				{
					array[num] = AudioSessionOutputRouteKind.HDMI;
				}
				else if (nSString == OutputRoute_AirPlay)
				{
					array[num] = AudioSessionOutputRouteKind.AirPlay;
				}
				else
				{
					array[num] = (AudioSessionOutputRouteKind)(int)nSString.Handle;
				}
			}
		}
		return array;
	}

	[MonoPInvokeCallback(typeof(_PropertyListener))]
	private static void Listener(IntPtr userData, AudioSessionProperty prop, int size, IntPtr data)
	{
		if (!listeners.TryGetValue(prop, out var value))
		{
			return;
		}
		foreach (PropertyListener item in value)
		{
			item(prop, size, data);
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioSessionErrors AudioSessionAddPropertyListener(AudioSessionProperty id, _PropertyListener inProc, IntPtr userData);

	public static AudioSessionErrors AddListener(AudioSessionProperty property, PropertyListener listener)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (listeners == null)
		{
			listeners = new Dictionary<AudioSessionProperty, List<PropertyListener>>();
		}
		listeners.TryGetValue(property, out var value);
		value = (listeners[property] = new List<PropertyListener>());
		value.Add(listener);
		if (value.Count == 1)
		{
			return AudioSessionAddPropertyListener(property, Listener, IntPtr.Zero);
		}
		return AudioSessionErrors.None;
	}

	public static void RemoveListener(AudioSessionProperty property, PropertyListener listener)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		listeners.TryGetValue(property, out var _);
	}

	private static void AddListenerEvent(AudioSessionProperty property, object handler, PropertyListener listener)
	{
		if (strongListenerHash == null)
		{
			Interlocked.CompareExchange(ref strongListenerHash, new Dictionary<object, PropertyListener>(), null);
		}
		lock (strongListenerHash)
		{
			strongListenerHash[handler] = listener;
		}
		AddListener(property, listener);
	}

	private static void RemoveListenerEvent(AudioSessionProperty property, object handler)
	{
		if (strongListenerHash == null)
		{
			return;
		}
		PropertyListener value;
		lock (strongListenerHash)
		{
			if (!strongListenerHash.TryGetValue(handler, out value))
			{
				return;
			}
			strongListenerHash.Remove(handler);
		}
		RemoveListener(AudioSessionProperty.CurrentHardwareOutputVolume, value);
	}
}

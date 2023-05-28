using System;
using System.Runtime.InteropServices;
using AppKit;
using AudioToolbox;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

public class AudioComponent : INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public string Name
	{
		get
		{
			if (AudioComponentCopyName(handle, out var cfstr) == 0)
			{
				return CFString.FetchString(cfstr);
			}
			return null;
		}
	}

	public AudioComponentDescription? Description
	{
		get
		{
			if (AudioComponentGetDescription(handle, out var desc) == 0)
			{
				return desc;
			}
			return null;
		}
	}

	public Version Version
	{
		get
		{
			if (AudioComponentGetVersion(handle, out var version) == 0)
			{
				return new Version(version >> 16, (version >> 8) & 0xFF, version & 0xFF);
			}
			return null;
		}
	}

	[NoWatch]
	[NoTV]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public AudioComponentInfo[] ComponentList
	{
		get
		{
			using CFString cFString = new CFString(Name);
			IntPtr intPtr = AudioUnitExtensionCopyComponentList(cFString.Handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			using NSArray nSArray = Runtime.GetNSObject<NSArray>(intPtr, owns: true);
			if (nSArray == null)
			{
				return null;
			}
			NSDictionary[] array = NSArray.FromArray<NSDictionary>(nSArray);
			AudioComponentInfo[] array2 = new AudioComponentInfo[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new AudioComponentInfo(array[i]);
			}
			return array2;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			using CFString cFString = new CFString(Name);
			NSDictionary[] array = new NSDictionary[value.Length];
			for (int i = 0; i < value.Length; i++)
			{
				array[i] = value[i].Dictionary;
			}
			using NSArray nSArray = NSArray.FromNSObjects(array);
			AudioConverterError audioConverterError = (AudioConverterError)AudioUnitExtensionSetComponentList(cFString.Handle, nSArray.Handle);
			if (audioConverterError == AudioConverterError.None)
			{
				return;
			}
			throw new InvalidOperationException("ComponentList could not be set, error " + audioConverterError);
		}
	}

	internal AudioComponent(IntPtr handle)
	{
		this.handle = handle;
	}

	public AudioUnit CreateAudioUnit()
	{
		return new AudioUnit(this);
	}

	public static AudioComponent FindNextComponent(AudioComponent cmp, ref AudioComponentDescription cd)
	{
		IntPtr inComponent = cmp?.Handle ?? IntPtr.Zero;
		inComponent = AudioComponentFindNext(inComponent, ref cd);
		return (inComponent != IntPtr.Zero) ? new AudioComponent(inComponent) : null;
	}

	public static AudioComponent FindComponent(ref AudioComponentDescription cd)
	{
		return FindNextComponent(null, ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeOutput output)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateOutput(output);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeMusicDevice musicDevice)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateMusicDevice(musicDevice);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeConverter conveter)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateConverter(conveter);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeEffect effect)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateEffect(effect);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeMixer mixer)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateMixer(mixer);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypePanner panner)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreatePanner(panner);
		return FindComponent(ref cd);
	}

	public static AudioComponent FindComponent(AudioTypeGenerator generator)
	{
		AudioComponentDescription cd = AudioComponentDescription.CreateGenerator(generator);
		return FindComponent(ref cd);
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern IntPtr AudioComponentFindNext(IntPtr inComponent, ref AudioComponentDescription inDesc);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentCopyName(IntPtr component, out IntPtr cfstr);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentGetDescription(IntPtr component, out AudioComponentDescription desc);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentGetVersion(IntPtr component, out int version);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	[Mac(10, 11)]
	private static extern IntPtr AudioComponentGetIcon(IntPtr comp);

	[Mac(10, 11)]
	public NSImage GetIcon()
	{
		return new NSImage(AudioComponentGetIcon(handle));
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	[NoWatch]
	[NoTV]
	[Mac(10, 13)]
	[iOS(11, 0)]
	private static extern int AudioUnitExtensionSetComponentList(IntPtr extensionIdentifier, IntPtr audioComponentInfo);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	[NoWatch]
	[NoTV]
	[Mac(10, 13)]
	[iOS(11, 0)]
	private static extern IntPtr AudioUnitExtensionCopyComponentList(IntPtr extensionIdentifier);
}

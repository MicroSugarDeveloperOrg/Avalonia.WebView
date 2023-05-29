using System;
using System.Runtime.InteropServices;
using CoreFoundation;
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

	public AudioComponentDescription Description
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

	internal AudioComponent(IntPtr handle)
	{
		this.handle = handle;
	}

	public AudioUnit CreateAudioUnit()
	{
		return new AudioUnit(this);
	}

	public static AudioComponent FindNextComponent(AudioComponent cmp, AudioComponentDescription cd)
	{
		IntPtr intPtr = ((cmp != null) ? AudioComponentFindNext(cmp.Handle, cd) : AudioComponentFindNext(IntPtr.Zero, cd));
		if (intPtr != IntPtr.Zero)
		{
			return new AudioComponent(intPtr);
		}
		return null;
	}

	public static AudioComponent FindComponent(AudioComponentDescription cd)
	{
		return FindNextComponent(null, cd);
	}

	public static AudioComponent FindComponent(AudioTypeOutput output)
	{
		return FindComponent(AudioComponentDescription.CreateOutput(output));
	}

	public static AudioComponent FindComponent(AudioTypeMusicDevice musicDevice)
	{
		return FindComponent(AudioComponentDescription.CreateMusicDevice(musicDevice));
	}

	public static AudioComponent FindComponent(AudioTypeConverter conveter)
	{
		return FindComponent(AudioComponentDescription.CreateConverter(conveter));
	}

	public static AudioComponent FindComponent(AudioTypeEffect effect)
	{
		return FindComponent(AudioComponentDescription.CreateEffect(effect));
	}

	public static AudioComponent FindComponent(AudioTypeMixer mixer)
	{
		return FindComponent(AudioComponentDescription.CreateMixer(mixer));
	}

	public static AudioComponent FindComponent(AudioTypePanner panner)
	{
		return FindComponent(AudioComponentDescription.CreatePanner(panner));
	}

	public static AudioComponent FindComponent(AudioTypeGenerator generator)
	{
		return FindComponent(AudioComponentDescription.CreateGenerator(generator));
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern IntPtr AudioComponentFindNext(IntPtr inComponent, AudioComponentDescription inDesc);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentCopyName(IntPtr component, out IntPtr cfstr);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentGetDescription(IntPtr component, out AudioComponentDescription desc);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentCount(AudioComponentDescription desc);

	private static int CountMatches(AudioComponentDescription desc)
	{
		if (desc == null)
		{
			throw new ArgumentNullException("desc");
		}
		return AudioComponentCount(desc);
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentGetVersion(IntPtr component, out int version);
}

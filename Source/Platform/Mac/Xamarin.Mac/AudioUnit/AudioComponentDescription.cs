using System.Runtime.InteropServices;

namespace AudioUnit;

public struct AudioComponentDescription
{
	[MarshalAs(UnmanagedType.U4)]
	public AudioComponentType ComponentType;

	[MarshalAs(UnmanagedType.U4)]
	public int ComponentSubType;

	[MarshalAs(UnmanagedType.U4)]
	public AudioComponentManufacturerType ComponentManufacturer;

	public AudioComponentFlag ComponentFlags;

	public int ComponentFlagsMask;

	internal AudioComponentDescription(AudioComponentType type, int subType)
	{
		ComponentType = type;
		ComponentSubType = subType;
		ComponentManufacturer = AudioComponentManufacturerType.Apple;
		ComponentFlags = (AudioComponentFlag)0;
		ComponentFlagsMask = 0;
	}

	public static AudioComponentDescription CreateGeneric(AudioComponentType type, int subType)
	{
		return new AudioComponentDescription(type, subType);
	}

	public static AudioComponentDescription CreateOutput(AudioTypeOutput outputType)
	{
		return new AudioComponentDescription(AudioComponentType.Output, (int)outputType);
	}

	public static AudioComponentDescription CreateMusicDevice(AudioTypeMusicDevice musicDevice)
	{
		return new AudioComponentDescription(AudioComponentType.MusicDevice, (int)musicDevice);
	}

	public static AudioComponentDescription CreateConverter(AudioTypeConverter converter)
	{
		return new AudioComponentDescription(AudioComponentType.FormatConverter, (int)converter);
	}

	public static AudioComponentDescription CreateEffect(AudioTypeEffect effect)
	{
		return new AudioComponentDescription(AudioComponentType.Effect, (int)effect);
	}

	public static AudioComponentDescription CreateMixer(AudioTypeMixer mixer)
	{
		return new AudioComponentDescription(AudioComponentType.Mixer, (int)mixer);
	}

	public static AudioComponentDescription CreatePanner(AudioTypePanner panner)
	{
		return new AudioComponentDescription(AudioComponentType.Panner, (int)panner);
	}

	public static AudioComponentDescription CreateGenerator(AudioTypeGenerator generator)
	{
		return new AudioComponentDescription(AudioComponentType.Generator, (int)generator);
	}

	public override string ToString()
	{
		return ComponentType switch
		{
			AudioComponentType.Output => $"[componentType={ComponentType}, subType={(AudioTypeOutput)ComponentSubType}]", 
			AudioComponentType.MusicDevice => $"[componentType={ComponentType}, subType={(AudioTypeMusicDevice)ComponentSubType}]", 
			AudioComponentType.FormatConverter => $"[componentType={ComponentType}, subType={(AudioTypeConverter)ComponentSubType}]", 
			AudioComponentType.Effect => $"[componentType={ComponentType}, subType={(AudioTypeEffect)ComponentSubType}]", 
			AudioComponentType.Mixer => $"[componentType={ComponentType}, subType={(AudioTypeMixer)ComponentSubType}]", 
			AudioComponentType.Panner => $"[componentType={ComponentType}, subType={(AudioTypePanner)ComponentSubType}]", 
			AudioComponentType.Generator => $"[componentType={ComponentType}, subType={(AudioTypeGenerator)ComponentSubType}]", 
			_ => $"[componentType={ComponentType}, subType={ComponentSubType}]", 
		};
	}
}

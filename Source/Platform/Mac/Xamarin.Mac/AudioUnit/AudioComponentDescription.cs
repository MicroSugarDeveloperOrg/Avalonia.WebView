using System.Runtime.InteropServices;

namespace AudioUnit;

[StructLayout(LayoutKind.Sequential)]
public class AudioComponentDescription
{
	[MarshalAs(UnmanagedType.U4)]
	public AudioComponentType ComponentType;

	[MarshalAs(UnmanagedType.U4)]
	public int ComponentSubType;

	[MarshalAs(UnmanagedType.U4)]
	public AudioComponentManufacturerType ComponentManufacturer;

	public AudioComponentFlag ComponentFlags;

	public int ComponentFlagsMask;

	public AudioComponentDescription()
	{
	}

	internal AudioComponentDescription(AudioComponentType type, int subType)
	{
		ComponentType = type;
		ComponentSubType = subType;
		ComponentManufacturer = AudioComponentManufacturerType.Apple;
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
			AudioComponentType.Output => $"[componetType={ComponentType}, subType={(AudioTypeOutput)ComponentSubType}]", 
			AudioComponentType.MusicDevice => $"[componetType={ComponentType}, subType={(AudioTypeMusicDevice)ComponentSubType}]", 
			AudioComponentType.FormatConverter => $"[componetType={ComponentType}, subType={(AudioTypeConverter)ComponentSubType}]", 
			AudioComponentType.Effect => $"[componetType={ComponentType}, subType={(AudioTypeEffect)ComponentSubType}]", 
			AudioComponentType.Mixer => $"[componetType={ComponentType}, subType={(AudioTypeMixer)ComponentSubType}]", 
			AudioComponentType.Panner => $"[componetType={ComponentType}, subType={(AudioTypePanner)ComponentSubType}]", 
			AudioComponentType.Generator => $"[componetType={ComponentType}, subType={(AudioTypeGenerator)ComponentSubType}]", 
			_ => $"[componetType={ComponentType}, subType={ComponentSubType}]", 
		};
	}
}

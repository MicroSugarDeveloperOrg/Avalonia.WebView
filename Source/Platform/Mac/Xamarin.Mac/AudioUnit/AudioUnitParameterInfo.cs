using CoreFoundation;

namespace AudioUnit;

public class AudioUnitParameterInfo
{
	public string UnitName { get; private set; }

	public AudioUnitClumpID ClumpID { get; private set; }

	public string Name { get; private set; }

	public AudioUnitParameterUnit Unit { get; private set; }

	public float MinValue { get; private set; }

	public float MaxValue { get; private set; }

	public float DefaultValue { get; private set; }

	public AudioUnitParameterFlag Flags { get; private set; }

	public AudioUnitParameterType Type { get; private set; }

	internal static AudioUnitParameterInfo Create(AudioUnitParameterInfoNative native, AudioUnitParameterType type)
	{
		AudioUnitParameterInfo audioUnitParameterInfo = new AudioUnitParameterInfo();
		audioUnitParameterInfo.Flags = native.Flags & ~(AudioUnitParameterFlag.CFNameRelease | AudioUnitParameterFlag.HasCFNameString);
		audioUnitParameterInfo.Unit = native.Unit;
		audioUnitParameterInfo.MinValue = native.MinValue;
		audioUnitParameterInfo.MaxValue = native.MaxValue;
		audioUnitParameterInfo.DefaultValue = native.DefaultValue;
		audioUnitParameterInfo.ClumpID = native.ClumpID;
		audioUnitParameterInfo.Type = type;
		if ((native.Flags & AudioUnitParameterFlag.HasCFNameString) != 0)
		{
			audioUnitParameterInfo.Name = CFString.FetchString(native.NameString);
			if ((native.Flags & AudioUnitParameterFlag.CFNameRelease) != 0)
			{
				CFObject.CFRelease(native.NameString);
			}
		}
		if (native.Unit == AudioUnitParameterUnit.CustomUnit)
		{
			audioUnitParameterInfo.UnitName = CFString.FetchString(native.UnitName);
		}
		return audioUnitParameterInfo;
	}
}

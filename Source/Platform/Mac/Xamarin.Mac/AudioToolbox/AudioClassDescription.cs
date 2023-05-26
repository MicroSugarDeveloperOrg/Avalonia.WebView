using AudioUnit;

namespace AudioToolbox;

public struct AudioClassDescription
{
	public AudioCodecComponentType Type;

	public AudioFormatType SubType;

	public AudioCodecManufacturer Manufacturer;

	public bool IsHardwareCodec => Manufacturer == AudioCodecManufacturer.AppleHardware;

	public AudioClassDescription(AudioCodecComponentType type, AudioFormatType subType, AudioCodecManufacturer manufacturer)
	{
		Type = type;
		SubType = subType;
		Manufacturer = manufacturer;
	}
}

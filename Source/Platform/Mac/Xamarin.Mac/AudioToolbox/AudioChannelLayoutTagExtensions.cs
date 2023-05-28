namespace AudioToolbox;

public static class AudioChannelLayoutTagExtensions
{
	public static AudioChannelBit? ToAudioChannel(this AudioChannelLayoutTag layoutTag)
	{
		int ioDataSize = 4;
		int inSpecifier = (int)layoutTag;
		if (AudioFormatPropertyNative.AudioFormatGetProperty(AudioFormatProperty.BitmapForLayoutTag, 4, ref inSpecifier, ref ioDataSize, out var outPropertyData) != 0)
		{
			return null;
		}
		return (AudioChannelBit)outPropertyData;
	}

	public static uint GetNumberOfChannels(this AudioChannelLayoutTag inLayoutTag)
	{
		return (uint)(inLayoutTag & (AudioChannelLayoutTag)65535u);
	}

	public static bool IsReserved(this AudioChannelLayoutTag value)
	{
		return (uint)value >= 4026531840u && (uint)value <= 4294967294u;
	}
}

using AudioToolbox;
using Foundation;

namespace AVFoundation;

[Advice("Use AudioSettings instead")]
public class AVAudioPlayerSettings
{
	private NSDictionary dict;

	public AudioChannelLayout AudioChannelLayout
	{
		get
		{
			if (!(dict.ObjectForKey(AVAudioSettings.AVChannelLayoutKey) is NSData nSData))
			{
				return new AudioChannelLayout();
			}
			return AudioChannelLayout.FromHandle(nSData.Bytes);
		}
	}

	public int EncoderBitRateKey
	{
		get
		{
			if (dict.ObjectForKey(AVAudioSettings.AVEncoderBitRateKey) is NSNumber nSNumber)
			{
				return nSNumber.Int32Value;
			}
			return 0;
		}
	}

	public AudioFormatType AudioFormat
	{
		get
		{
			if (dict.ObjectForKey(AVAudioSettings.AVFormatIDKey) is NSNumber nSNumber)
			{
				return (AudioFormatType)nSNumber.Int32Value;
			}
			return (AudioFormatType)(-1);
		}
	}

	public int NumberChannels
	{
		get
		{
			if (dict.ObjectForKey(AVAudioSettings.AVNumberOfChannelsKey) is NSNumber nSNumber)
			{
				return nSNumber.Int32Value;
			}
			return 1;
		}
	}

	public float SampleRate
	{
		get
		{
			if (dict.ObjectForKey(AVAudioSettings.AVSampleRateKey) is NSNumber nSNumber)
			{
				return nSNumber.FloatValue;
			}
			return 0f;
		}
	}

	internal AVAudioPlayerSettings(NSDictionary dictionary)
	{
		dict = dictionary;
	}

	public static implicit operator NSDictionary(AVAudioPlayerSettings settings)
	{
		return settings.dict;
	}
}

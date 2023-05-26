using System;
using AudioToolbox;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Since(6, 0)]
public class AudioSettings : DictionaryContainer
{
	public AudioFormatType? Format
	{
		get
		{
			return (AudioFormatType?)GetInt32Value(AVAudioSettings.AVFormatIDKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVFormatIDKey, (int?)value);
		}
	}

	public float? SampleRate
	{
		get
		{
			return GetFloatValue(AVAudioSettings.AVSampleRateKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVSampleRateKey, value);
		}
	}

	public int? NumberChannels
	{
		get
		{
			return GetInt32Value(AVAudioSettings.AVNumberOfChannelsKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVNumberOfChannelsKey, value);
		}
	}

	public int? LinearPcmBitDepth
	{
		get
		{
			return GetInt32Value(AVAudioSettings.AVLinearPCMBitDepthKey);
		}
		set
		{
			if (value != 8 && value != 16 && value != 24 && value != 32)
			{
				throw new ArgumentOutOfRangeException("value must be of 8, 16, 24 or 32");
			}
			SetNumberValue(AVAudioSettings.AVLinearPCMBitDepthKey, value);
		}
	}

	public bool? LinearPcmBigEndian
	{
		get
		{
			return GetBoolValue(AVAudioSettings.AVLinearPCMIsBigEndianKey);
		}
		set
		{
			SetBooleanValue(AVAudioSettings.AVLinearPCMIsBigEndianKey, value);
		}
	}

	public bool? LinearPcmFloat
	{
		get
		{
			return GetBoolValue(AVAudioSettings.AVLinearPCMIsFloatKey);
		}
		set
		{
			SetBooleanValue(AVAudioSettings.AVLinearPCMIsFloatKey, value);
		}
	}

	public bool? LinearPcmNonInterleaved
	{
		get
		{
			return GetBoolValue(AVAudioSettings.AVLinearPCMIsNonInterleaved);
		}
		set
		{
			SetBooleanValue(AVAudioSettings.AVLinearPCMIsNonInterleaved, value);
		}
	}

	public AVAudioQuality? AudioQuality
	{
		get
		{
			return (AVAudioQuality?)GetInt32Value(AVAudioSettings.AVEncoderAudioQualityKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVEncoderAudioQualityKey, (int?)value);
		}
	}

	public AVAudioQuality? SampleRateConverterAudioQuality
	{
		get
		{
			return (AVAudioQuality?)GetInt32Value(AVAudioSettings.AVSampleRateConverterAudioQualityKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVSampleRateConverterAudioQualityKey, (int?)value);
		}
	}

	public int? EncoderBitRate
	{
		get
		{
			return GetInt32Value(AVAudioSettings.AVEncoderBitRateKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVEncoderBitRateKey, value);
		}
	}

	public int? EncoderBitRatePerChannel
	{
		get
		{
			return GetInt32Value(AVAudioSettings.AVEncoderBitRatePerChannelKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVEncoderBitRatePerChannelKey, value);
		}
	}

	public int? EncoderBitDepthHint
	{
		get
		{
			return GetInt32Value(AVAudioSettings.AVEncoderBitDepthHintKey);
		}
		set
		{
			if (value < 8 || value > 32)
			{
				throw new ArgumentOutOfRangeException("value is required to be between 8 and 32");
			}
			SetNumberValue(AVAudioSettings.AVEncoderBitDepthHintKey, value);
		}
	}

	public AudioChannelLayout ChannelLayout
	{
		set
		{
			SetNativeValue(AVAudioSettings.AVChannelLayoutKey, value?.AsData());
		}
	}

	public AudioSettings()
		: base(new NSMutableDictionary())
	{
	}

	public AudioSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

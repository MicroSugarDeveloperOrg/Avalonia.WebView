using AudioToolbox;
using Foundation;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

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

	public double? SampleRate
	{
		get
		{
			return GetDoubleValue(AVAudioSettings.AVSampleRateKey);
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
			return (AVAudioQuality?)(long?)GetNIntValue(AVAudioSettings.AVEncoderAudioQualityKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVEncoderAudioQualityKey, (nint?)(long?)value);
		}
	}

	public AVAudioQuality? SampleRateConverterAudioQuality
	{
		get
		{
			return (AVAudioQuality?)(long?)GetNIntValue(AVAudioSettings.AVSampleRateConverterAudioQualityKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVSampleRateConverterAudioQualityKey, (nint?)(long?)value);
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

	[iOS(7, 0)]
	public AVAudioBitRateStrategy? BitRateStrategy
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(AVAudioSettings.AVEncoderBitRateStrategyKey);
			if (nSStringValue == AVAudioSettings._Constant)
			{
				return AVAudioBitRateStrategy.Constant;
			}
			if (nSStringValue == AVAudioSettings._LongTermAverage)
			{
				return AVAudioBitRateStrategy.LongTermAverage;
			}
			if (nSStringValue == AVAudioSettings._VariableConstrained)
			{
				return AVAudioBitRateStrategy.VariableConstrained;
			}
			if (nSStringValue == AVAudioSettings._Variable)
			{
				return AVAudioBitRateStrategy.Variable;
			}
			return null;
		}
		set
		{
			NSString value2 = null;
			switch (value)
			{
			case AVAudioBitRateStrategy.Constant:
				value2 = AVAudioSettings._Constant;
				break;
			case AVAudioBitRateStrategy.LongTermAverage:
				value2 = AVAudioSettings._LongTermAverage;
				break;
			case AVAudioBitRateStrategy.VariableConstrained:
				value2 = AVAudioSettings._VariableConstrained;
				break;
			case AVAudioBitRateStrategy.Variable:
				value2 = AVAudioSettings._Variable;
				break;
			default:
				throw new ArgumentOutOfRangeException("value");
			case null:
				break;
			}
			SetStringValue(AVAudioSettings.AVEncoderBitRateStrategyKey, value2);
		}
	}

	[iOS(7, 0)]
	public AVSampleRateConverterAlgorithm? SampleRateConverterAlgorithm
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(AVAudioSettings.AVSampleRateConverterAlgorithmKey);
			if (nSStringValue == AVAudioSettings.AVSampleRateConverterAlgorithm_Normal)
			{
				return AVSampleRateConverterAlgorithm.Normal;
			}
			if (nSStringValue == AVAudioSettings.AVSampleRateConverterAlgorithm_Mastering)
			{
				return AVSampleRateConverterAlgorithm.Mastering;
			}
			return null;
		}
		set
		{
			NSString value2 = null;
			switch (value)
			{
			case AVSampleRateConverterAlgorithm.Mastering:
				value2 = AVAudioSettings.AVSampleRateConverterAlgorithm_Mastering;
				break;
			case AVSampleRateConverterAlgorithm.Normal:
				value2 = AVAudioSettings.AVSampleRateConverterAlgorithm_Normal;
				break;
			default:
				throw new ArgumentOutOfRangeException("value");
			case null:
				break;
			}
			SetStringValue(AVAudioSettings.AVSampleRateConverterAlgorithmKey, value2);
		}
	}

	[iOS(7, 0)]
	public AVAudioQuality? EncoderAudioQualityForVBR
	{
		get
		{
			return (AVAudioQuality?)(long?)GetNIntValue(AVAudioSettings.AVEncoderAudioQualityForVBRKey);
		}
		set
		{
			SetNumberValue(AVAudioSettings.AVEncoderAudioQualityForVBRKey, (nint?)(long?)value);
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

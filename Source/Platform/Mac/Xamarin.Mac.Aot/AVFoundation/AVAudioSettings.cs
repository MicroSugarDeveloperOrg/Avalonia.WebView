using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAudioSettings
{
	private static NSString _AVFormatIDKey;

	private static NSString _AVSampleRateKey;

	private static NSString _AVNumberOfChannelsKey;

	private static NSString _AVLinearPCMBitDepthKey;

	private static NSString _AVLinearPCMIsBigEndianKey;

	private static NSString _AVLinearPCMIsFloatKey;

	private static NSString _AVLinearPCMIsNonInterleaved;

	private static NSString _AVEncoderAudioQualityKey;

	private static NSString _AVEncoderBitRateKey;

	private static NSString _AVEncoderBitRatePerChannelKey;

	private static NSString _AVEncoderBitDepthHintKey;

	private static NSString _AVSampleRateConverterAudioQualityKey;

	private static NSString _AVChannelLayoutKey;

	[Field("AVFormatIDKey", "AVFoundation")]
	public static NSString AVFormatIDKey
	{
		get
		{
			if (_AVFormatIDKey == null)
			{
				_AVFormatIDKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFormatIDKey");
			}
			return _AVFormatIDKey;
		}
	}

	[Field("AVSampleRateKey", "AVFoundation")]
	public static NSString AVSampleRateKey
	{
		get
		{
			if (_AVSampleRateKey == null)
			{
				_AVSampleRateKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateKey");
			}
			return _AVSampleRateKey;
		}
	}

	[Field("AVNumberOfChannelsKey", "AVFoundation")]
	public static NSString AVNumberOfChannelsKey
	{
		get
		{
			if (_AVNumberOfChannelsKey == null)
			{
				_AVNumberOfChannelsKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVNumberOfChannelsKey");
			}
			return _AVNumberOfChannelsKey;
		}
	}

	[Field("AVLinearPCMBitDepthKey", "AVFoundation")]
	public static NSString AVLinearPCMBitDepthKey
	{
		get
		{
			if (_AVLinearPCMBitDepthKey == null)
			{
				_AVLinearPCMBitDepthKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLinearPCMBitDepthKey");
			}
			return _AVLinearPCMBitDepthKey;
		}
	}

	[Field("AVLinearPCMIsBigEndianKey", "AVFoundation")]
	public static NSString AVLinearPCMIsBigEndianKey
	{
		get
		{
			if (_AVLinearPCMIsBigEndianKey == null)
			{
				_AVLinearPCMIsBigEndianKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLinearPCMIsBigEndianKey");
			}
			return _AVLinearPCMIsBigEndianKey;
		}
	}

	[Field("AVLinearPCMIsFloatKey", "AVFoundation")]
	public static NSString AVLinearPCMIsFloatKey
	{
		get
		{
			if (_AVLinearPCMIsFloatKey == null)
			{
				_AVLinearPCMIsFloatKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLinearPCMIsFloatKey");
			}
			return _AVLinearPCMIsFloatKey;
		}
	}

	[Field("AVLinearPCMIsNonInterleaved", "AVFoundation")]
	public static NSString AVLinearPCMIsNonInterleaved
	{
		get
		{
			if (_AVLinearPCMIsNonInterleaved == null)
			{
				_AVLinearPCMIsNonInterleaved = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLinearPCMIsNonInterleaved");
			}
			return _AVLinearPCMIsNonInterleaved;
		}
	}

	[Field("AVEncoderAudioQualityKey", "AVFoundation")]
	public static NSString AVEncoderAudioQualityKey
	{
		get
		{
			if (_AVEncoderAudioQualityKey == null)
			{
				_AVEncoderAudioQualityKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderAudioQualityKey");
			}
			return _AVEncoderAudioQualityKey;
		}
	}

	[Field("AVEncoderBitRateKey", "AVFoundation")]
	public static NSString AVEncoderBitRateKey
	{
		get
		{
			if (_AVEncoderBitRateKey == null)
			{
				_AVEncoderBitRateKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderBitRateKey");
			}
			return _AVEncoderBitRateKey;
		}
	}

	[Field("AVEncoderBitRatePerChannelKey", "AVFoundation")]
	public static NSString AVEncoderBitRatePerChannelKey
	{
		get
		{
			if (_AVEncoderBitRatePerChannelKey == null)
			{
				_AVEncoderBitRatePerChannelKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderBitRatePerChannelKey");
			}
			return _AVEncoderBitRatePerChannelKey;
		}
	}

	[Field("AVEncoderBitDepthHintKey", "AVFoundation")]
	public static NSString AVEncoderBitDepthHintKey
	{
		get
		{
			if (_AVEncoderBitDepthHintKey == null)
			{
				_AVEncoderBitDepthHintKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderBitDepthHintKey");
			}
			return _AVEncoderBitDepthHintKey;
		}
	}

	[Field("AVSampleRateConverterAudioQualityKey", "AVFoundation")]
	public static NSString AVSampleRateConverterAudioQualityKey
	{
		get
		{
			if (_AVSampleRateConverterAudioQualityKey == null)
			{
				_AVSampleRateConverterAudioQualityKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateConverterAudioQualityKey");
			}
			return _AVSampleRateConverterAudioQualityKey;
		}
	}

	[Field("AVChannelLayoutKey", "AVFoundation")]
	public static NSString AVChannelLayoutKey
	{
		get
		{
			if (_AVChannelLayoutKey == null)
			{
				_AVChannelLayoutKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVChannelLayoutKey");
			}
			return _AVChannelLayoutKey;
		}
	}
}

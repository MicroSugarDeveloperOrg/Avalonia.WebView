using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public static class AVAudioSettings
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVChannelLayoutKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderAudioQualityForVBRKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderAudioQualityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderBitDepthHintKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderBitRatePerChannelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVEncoderBitRateStrategyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVFormatIDKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVLinearPCMBitDepthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVLinearPCMIsBigEndianKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVLinearPCMIsFloatKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVLinearPCMIsNonInterleaved;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVNumberOfChannelsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateConverterAlgorithmKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateConverterAlgorithm_Mastering;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateConverterAlgorithm_MinimumPhase;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateConverterAlgorithm_Normal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateConverterAudioQualityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVSampleRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Constant;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __LongTermAverage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Variable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __VariableConstrained;

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

	[Field("AVEncoderAudioQualityForVBRKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString AVEncoderAudioQualityForVBRKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AVEncoderAudioQualityForVBRKey == null)
			{
				_AVEncoderAudioQualityForVBRKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderAudioQualityForVBRKey");
			}
			return _AVEncoderAudioQualityForVBRKey;
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

	[Field("AVEncoderBitRateStrategyKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString AVEncoderBitRateStrategyKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AVEncoderBitRateStrategyKey == null)
			{
				_AVEncoderBitRateStrategyKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVEncoderBitRateStrategyKey");
			}
			return _AVEncoderBitRateStrategyKey;
		}
	}

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

	[Field("AVSampleRateConverterAlgorithmKey", "AVFoundation")]
	internal static NSString AVSampleRateConverterAlgorithmKey
	{
		get
		{
			if (_AVSampleRateConverterAlgorithmKey == null)
			{
				_AVSampleRateConverterAlgorithmKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithmKey");
			}
			return _AVSampleRateConverterAlgorithmKey;
		}
	}

	[Field("AVSampleRateConverterAlgorithm_Mastering", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString AVSampleRateConverterAlgorithm_Mastering
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AVSampleRateConverterAlgorithm_Mastering == null)
			{
				_AVSampleRateConverterAlgorithm_Mastering = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_Mastering");
			}
			return _AVSampleRateConverterAlgorithm_Mastering;
		}
	}

	[Field("AVSampleRateConverterAlgorithm_MinimumPhase", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString AVSampleRateConverterAlgorithm_MinimumPhase
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_AVSampleRateConverterAlgorithm_MinimumPhase == null)
			{
				_AVSampleRateConverterAlgorithm_MinimumPhase = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_MinimumPhase");
			}
			return _AVSampleRateConverterAlgorithm_MinimumPhase;
		}
	}

	[Field("AVSampleRateConverterAlgorithm_Normal", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString AVSampleRateConverterAlgorithm_Normal
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AVSampleRateConverterAlgorithm_Normal == null)
			{
				_AVSampleRateConverterAlgorithm_Normal = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVSampleRateConverterAlgorithm_Normal");
			}
			return _AVSampleRateConverterAlgorithm_Normal;
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

	[Field("AVAudioFileTypeKey", "AVFoundation")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString FileTypeKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileTypeKey == null)
			{
				_FileTypeKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioFileTypeKey");
			}
			return _FileTypeKey;
		}
	}

	[Field("AVAudioBitRateStrategy_Constant", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString _Constant
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (__Constant == null)
			{
				__Constant = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_Constant");
			}
			return __Constant;
		}
	}

	[Field("AVAudioBitRateStrategy_LongTermAverage", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString _LongTermAverage
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (__LongTermAverage == null)
			{
				__LongTermAverage = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_LongTermAverage");
			}
			return __LongTermAverage;
		}
	}

	[Field("AVAudioBitRateStrategy_Variable", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString _Variable
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (__Variable == null)
			{
				__Variable = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_Variable");
			}
			return __Variable;
		}
	}

	[Field("AVAudioBitRateStrategy_VariableConstrained", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static NSString _VariableConstrained
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (__VariableConstrained == null)
			{
				__VariableConstrained = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioBitRateStrategy_VariableConstrained");
			}
			return __VariableConstrained;
		}
	}
}

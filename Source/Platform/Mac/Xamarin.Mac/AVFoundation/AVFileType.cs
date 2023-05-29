using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVFileType
{
	private static NSString _QuickTimeMovie;

	private static NSString _Mpeg4;

	private static NSString _AppleM4V;

	private static NSString _ThreeGpp;

	private static NSString _AppleM4A;

	private static NSString _CoreAudioFormat;

	private static NSString _Wave;

	private static NSString _Aiff;

	private static NSString _Aifc;

	private static NSString _Amr;

	[Field("AVFileTypeQuickTimeMovie", "AVFoundation")]
	public static NSString QuickTimeMovie
	{
		get
		{
			if (_QuickTimeMovie == null)
			{
				_QuickTimeMovie = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeQuickTimeMovie");
			}
			return _QuickTimeMovie;
		}
	}

	[Field("AVFileTypeMPEG4", "AVFoundation")]
	public static NSString Mpeg4
	{
		get
		{
			if (_Mpeg4 == null)
			{
				_Mpeg4 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeMPEG4");
			}
			return _Mpeg4;
		}
	}

	[Field("AVFileTypeAppleM4V", "AVFoundation")]
	public static NSString AppleM4V
	{
		get
		{
			if (_AppleM4V == null)
			{
				_AppleM4V = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4V");
			}
			return _AppleM4V;
		}
	}

	[Field("AVFileType3GPP", "AVFoundation")]
	public static NSString ThreeGpp
	{
		get
		{
			if (_ThreeGpp == null)
			{
				_ThreeGpp = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileType3GPP");
			}
			return _ThreeGpp;
		}
	}

	[Field("AVFileTypeAppleM4A", "AVFoundation")]
	public static NSString AppleM4A
	{
		get
		{
			if (_AppleM4A == null)
			{
				_AppleM4A = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4A");
			}
			return _AppleM4A;
		}
	}

	[Field("AVFileTypeCoreAudioFormat", "AVFoundation")]
	public static NSString CoreAudioFormat
	{
		get
		{
			if (_CoreAudioFormat == null)
			{
				_CoreAudioFormat = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeCoreAudioFormat");
			}
			return _CoreAudioFormat;
		}
	}

	[Field("AVFileTypeWAVE", "AVFoundation")]
	public static NSString Wave
	{
		get
		{
			if (_Wave == null)
			{
				_Wave = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeWAVE");
			}
			return _Wave;
		}
	}

	[Field("AVFileTypeAIFF", "AVFoundation")]
	public static NSString Aiff
	{
		get
		{
			if (_Aiff == null)
			{
				_Aiff = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAIFF");
			}
			return _Aiff;
		}
	}

	[Field("AVFileTypeAIFC", "AVFoundation")]
	public static NSString Aifc
	{
		get
		{
			if (_Aifc == null)
			{
				_Aifc = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAIFC");
			}
			return _Aifc;
		}
	}

	[Field("AVFileTypeAMR", "AVFoundation")]
	public static NSString Amr
	{
		get
		{
			if (_Amr == null)
			{
				_Amr = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAMR");
			}
			return _Amr;
		}
	}
}

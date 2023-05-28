using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVMediaCharacteristicsExtensions
{
	private static IntPtr[] values = new IntPtr[15];

	[Field("AVMediaCharacteristicVisual", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicVisual
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicVisual", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicAudible", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicAudible
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicAudible", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicLegible", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicLegible
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicLegible", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicFrameBased", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicFrameBased
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicFrameBased", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Field("AVMediaCharacteristicUsesWideGamutColorSpace", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicUsesWideGamutColorSpace
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicUsesWideGamutColorSpace", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicIsMainProgramContent", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicIsMainProgramContent
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsMainProgramContent", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicIsAuxiliaryContent", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicIsAuxiliaryContent
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsAuxiliaryContent", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicContainsOnlyForcedSubtitles", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicContainsOnlyForcedSubtitles
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsOnlyForcedSubtitles", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicTranscribesSpokenDialogForAccessibility
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicDescribesMusicAndSoundForAccessibility
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", storage);
			}
		}
	}

	[Field("AVMediaCharacteristicDescribesVideoForAccessibility", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicDescribesVideoForAccessibility
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesVideoForAccessibility", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVMediaCharacteristicLanguageTranslation", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicLanguageTranslation
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicLanguageTranslation", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVMediaCharacteristicDubbedTranslation", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicDubbedTranslation
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDubbedTranslation", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVMediaCharacteristicVoiceOverTranslation", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicVoiceOverTranslation
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicVoiceOverTranslation", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVMediaCharacteristicIsOriginalContent", "AVFoundation")]
	internal unsafe static IntPtr AVMediaCharacteristicIsOriginalContent
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsOriginalContent", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVMediaCharacteristics self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVMediaCharacteristicVisual;
			break;
		case 1:
			ptr = AVMediaCharacteristicAudible;
			break;
		case 2:
			ptr = AVMediaCharacteristicLegible;
			break;
		case 3:
			ptr = AVMediaCharacteristicFrameBased;
			break;
		case 4:
			ptr = AVMediaCharacteristicUsesWideGamutColorSpace;
			break;
		case 5:
			ptr = AVMediaCharacteristicIsMainProgramContent;
			break;
		case 6:
			ptr = AVMediaCharacteristicIsAuxiliaryContent;
			break;
		case 7:
			ptr = AVMediaCharacteristicContainsOnlyForcedSubtitles;
			break;
		case 8:
			ptr = AVMediaCharacteristicTranscribesSpokenDialogForAccessibility;
			break;
		case 9:
			ptr = AVMediaCharacteristicDescribesMusicAndSoundForAccessibility;
			break;
		case 10:
			ptr = AVMediaCharacteristicDescribesVideoForAccessibility;
			break;
		case 12:
			ptr = AVMediaCharacteristicLanguageTranslation;
			break;
		case 13:
			ptr = AVMediaCharacteristicDubbedTranslation;
			break;
		case 14:
			ptr = AVMediaCharacteristicVoiceOverTranslation;
			break;
		case 15:
			ptr = AVMediaCharacteristicIsOriginalContent;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVMediaCharacteristics GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVMediaCharacteristicVisual))
		{
			return AVMediaCharacteristics.Visual;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicAudible))
		{
			return AVMediaCharacteristics.Audible;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicLegible))
		{
			return AVMediaCharacteristics.Legible;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicFrameBased))
		{
			return AVMediaCharacteristics.FrameBased;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicUsesWideGamutColorSpace))
		{
			return AVMediaCharacteristics.UsesWideGamutColorSpace;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicIsMainProgramContent))
		{
			return AVMediaCharacteristics.IsMainProgramContent;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicIsAuxiliaryContent))
		{
			return AVMediaCharacteristics.IsAuxiliaryContent;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicContainsOnlyForcedSubtitles))
		{
			return AVMediaCharacteristics.ContainsOnlyForcedSubtitles;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicTranscribesSpokenDialogForAccessibility))
		{
			return AVMediaCharacteristics.TranscribesSpokenDialogForAccessibility;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicDescribesMusicAndSoundForAccessibility))
		{
			return AVMediaCharacteristics.DescribesMusicAndSoundForAccessibility;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicDescribesVideoForAccessibility))
		{
			return AVMediaCharacteristics.DescribesVideoForAccessibility;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicLanguageTranslation))
		{
			return AVMediaCharacteristics.LanguageTranslation;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicDubbedTranslation))
		{
			return AVMediaCharacteristics.DubbedTranslation;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicVoiceOverTranslation))
		{
			return AVMediaCharacteristics.VoiceOverTranslation;
		}
		if (constant.IsEqualTo(AVMediaCharacteristicIsOriginalContent))
		{
			return AVMediaCharacteristics.IsOriginalContent;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

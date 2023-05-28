using Foundation;
using ObjCRuntime;

namespace MediaAccessibility;

public static class MAMediaCharacteristic
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesMusicAndSoundForAccessibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesVideoForAccessibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranscribesSpokenDialogForAccessibility;

	[Field("MAMediaCharacteristicDescribesMusicAndSoundForAccessibility", "MediaAccessibility")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DescribesMusicAndSoundForAccessibility
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DescribesMusicAndSoundForAccessibility == null)
			{
				_DescribesMusicAndSoundForAccessibility = Dlfcn.GetStringConstant(Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicDescribesMusicAndSoundForAccessibility");
			}
			return _DescribesMusicAndSoundForAccessibility;
		}
	}

	[Field("MAMediaCharacteristicDescribesVideoForAccessibility", "MediaAccessibility")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString DescribesVideoForAccessibility
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_DescribesVideoForAccessibility == null)
			{
				_DescribesVideoForAccessibility = Dlfcn.GetStringConstant(Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicDescribesVideoForAccessibility");
			}
			return _DescribesVideoForAccessibility;
		}
	}

	[Field("MAMediaCharacteristicTranscribesSpokenDialogForAccessibility", "MediaAccessibility")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TranscribesSpokenDialogForAccessibility
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TranscribesSpokenDialogForAccessibility == null)
			{
				_TranscribesSpokenDialogForAccessibility = Dlfcn.GetStringConstant(Libraries.MediaAccessibility.Handle, "MAMediaCharacteristicTranscribesSpokenDialogForAccessibility");
			}
			return _TranscribesSpokenDialogForAccessibility;
		}
	}
}

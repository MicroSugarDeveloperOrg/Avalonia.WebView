using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class CGPdfTagPropertyKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActualTextKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlternativeTextKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LanguageTextKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleTextKey;

	[Field("kCGPDFTagPropertyActualText", "CoreGraphics")]
	public static NSString ActualTextKey
	{
		get
		{
			if (_ActualTextKey == null)
			{
				_ActualTextKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyActualText");
			}
			return _ActualTextKey;
		}
	}

	[Field("kCGPDFTagPropertyAlternativeText", "CoreGraphics")]
	public static NSString AlternativeTextKey
	{
		get
		{
			if (_AlternativeTextKey == null)
			{
				_AlternativeTextKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyAlternativeText");
			}
			return _AlternativeTextKey;
		}
	}

	[Field("kCGPDFTagPropertyLanguageText", "CoreGraphics")]
	public static NSString LanguageTextKey
	{
		get
		{
			if (_LanguageTextKey == null)
			{
				_LanguageTextKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyLanguageText");
			}
			return _LanguageTextKey;
		}
	}

	[Field("kCGPDFTagPropertyTitleText", "CoreGraphics")]
	public static NSString TitleTextKey
	{
		get
		{
			if (_TitleTextKey == null)
			{
				_TitleTextKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyTitleText");
			}
			return _TitleTextKey;
		}
	}
}

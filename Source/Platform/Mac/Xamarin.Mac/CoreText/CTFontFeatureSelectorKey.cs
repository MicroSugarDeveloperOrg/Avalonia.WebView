using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontFeatureSelectorKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Default;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SampleText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Setting;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TooltipText;

	[Field("kCTFontFeatureSelectorDefaultKey", "CoreText")]
	public static NSString Default
	{
		get
		{
			if (_Default == null)
			{
				_Default = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureSelectorDefaultKey");
			}
			return _Default;
		}
	}

	[Field("kCTFontFeatureSelectorIdentifierKey", "CoreText")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureSelectorIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("kCTFontFeatureSelectorNameKey", "CoreText")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureSelectorNameKey");
			}
			return _Name;
		}
	}

	[Field("kCTFontFeatureSampleTextKey", "CoreText")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString SampleText
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SampleText == null)
			{
				_SampleText = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureSampleTextKey");
			}
			return _SampleText;
		}
	}

	[Field("kCTFontFeatureSelectorSettingKey", "CoreText")]
	public static NSString Setting
	{
		get
		{
			if (_Setting == null)
			{
				_Setting = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureSelectorSettingKey");
			}
			return _Setting;
		}
	}

	[Field("kCTFontFeatureTooltipTextKey", "CoreText")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString TooltipText
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TooltipText == null)
			{
				_TooltipText = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureTooltipTextKey");
			}
			return _TooltipText;
		}
	}
}

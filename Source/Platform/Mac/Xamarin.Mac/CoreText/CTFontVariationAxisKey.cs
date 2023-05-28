using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontVariationAxisKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DefaultValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Hidden;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaximumValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinimumValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[Field("kCTFontVariationAxisDefaultValueKey", "CoreText")]
	public static NSString DefaultValue
	{
		get
		{
			if (_DefaultValue == null)
			{
				_DefaultValue = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisDefaultValueKey");
			}
			return _DefaultValue;
		}
	}

	[Field("kCTFontVariationAxisHiddenKey", "CoreText")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString Hidden
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Hidden == null)
			{
				_Hidden = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisHiddenKey");
			}
			return _Hidden;
		}
	}

	[Field("kCTFontVariationAxisIdentifierKey", "CoreText")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("kCTFontVariationAxisMaximumValueKey", "CoreText")]
	public static NSString MaximumValue
	{
		get
		{
			if (_MaximumValue == null)
			{
				_MaximumValue = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisMaximumValueKey");
			}
			return _MaximumValue;
		}
	}

	[Field("kCTFontVariationAxisMinimumValueKey", "CoreText")]
	public static NSString MinimumValue
	{
		get
		{
			if (_MinimumValue == null)
			{
				_MinimumValue = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisMinimumValueKey");
			}
			return _MinimumValue;
		}
	}

	[Field("kCTFontVariationAxisNameKey", "CoreText")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontVariationAxisNameKey");
			}
			return _Name;
		}
	}
}

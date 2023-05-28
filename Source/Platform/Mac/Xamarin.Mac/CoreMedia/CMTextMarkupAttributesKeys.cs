using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class CMTextMarkupAttributesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundColorARGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BaseFontSizePercentageRelativeToVideoHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoldStyle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontFamilyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForegroundColorARGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItalicStyle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RelativeFontSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnderlineStyle;

	[Field("kCMTextMarkupAttribute_BackgroundColorARGB", "CoreMedia")]
	internal static NSString BackgroundColorARGB
	{
		get
		{
			if (_BackgroundColorARGB == null)
			{
				_BackgroundColorARGB = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BackgroundColorARGB");
			}
			return _BackgroundColorARGB;
		}
	}

	[Field("kCMTextMarkupAttribute_BaseFontSizePercentageRelativeToVideoHeight", "CoreMedia")]
	internal static NSString BaseFontSizePercentageRelativeToVideoHeight
	{
		get
		{
			if (_BaseFontSizePercentageRelativeToVideoHeight == null)
			{
				_BaseFontSizePercentageRelativeToVideoHeight = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BaseFontSizePercentageRelativeToVideoHeight");
			}
			return _BaseFontSizePercentageRelativeToVideoHeight;
		}
	}

	[Field("kCMTextMarkupAttribute_BoldStyle", "CoreMedia")]
	internal static NSString BoldStyle
	{
		get
		{
			if (_BoldStyle == null)
			{
				_BoldStyle = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BoldStyle");
			}
			return _BoldStyle;
		}
	}

	[Field("kCMTextMarkupAttribute_FontFamilyName", "CoreMedia")]
	internal static NSString FontFamilyName
	{
		get
		{
			if (_FontFamilyName == null)
			{
				_FontFamilyName = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_FontFamilyName");
			}
			return _FontFamilyName;
		}
	}

	[Field("kCMTextMarkupAttribute_ForegroundColorARGB", "CoreMedia")]
	internal static NSString ForegroundColorARGB
	{
		get
		{
			if (_ForegroundColorARGB == null)
			{
				_ForegroundColorARGB = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_ForegroundColorARGB");
			}
			return _ForegroundColorARGB;
		}
	}

	[Field("kCMTextMarkupAttribute_ItalicStyle", "CoreMedia")]
	internal static NSString ItalicStyle
	{
		get
		{
			if (_ItalicStyle == null)
			{
				_ItalicStyle = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_ItalicStyle");
			}
			return _ItalicStyle;
		}
	}

	[Field("kCMTextMarkupAttribute_RelativeFontSize", "CoreMedia")]
	internal static NSString RelativeFontSize
	{
		get
		{
			if (_RelativeFontSize == null)
			{
				_RelativeFontSize = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_RelativeFontSize");
			}
			return _RelativeFontSize;
		}
	}

	[Field("kCMTextMarkupAttribute_UnderlineStyle", "CoreMedia")]
	internal static NSString UnderlineStyle
	{
		get
		{
			if (_UnderlineStyle == null)
			{
				_UnderlineStyle = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_UnderlineStyle");
			}
			return _UnderlineStyle;
		}
	}
}

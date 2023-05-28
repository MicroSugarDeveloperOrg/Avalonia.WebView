using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityFontKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontFamilyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleNameKey;

	[Field("NSAccessibilityFontFamilyKey", "AppKit")]
	public static NSString FontFamilyKey
	{
		get
		{
			if (_FontFamilyKey == null)
			{
				_FontFamilyKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFontFamilyKey");
			}
			return _FontFamilyKey;
		}
	}

	[Field("NSAccessibilityFontNameKey", "AppKit")]
	public static NSString FontNameKey
	{
		get
		{
			if (_FontNameKey == null)
			{
				_FontNameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFontNameKey");
			}
			return _FontNameKey;
		}
	}

	[Field("NSAccessibilityFontSizeKey", "AppKit")]
	public static NSString FontSizeKey
	{
		get
		{
			if (_FontSizeKey == null)
			{
				_FontSizeKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFontSizeKey");
			}
			return _FontSizeKey;
		}
	}

	[Field("NSAccessibilityVisibleNameKey", "AppKit")]
	public static NSString VisibleNameKey
	{
		get
		{
			if (_VisibleNameKey == null)
			{
				_VisibleNameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleNameKey");
			}
			return _VisibleNameKey;
		}
	}
}

using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontFeatureKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Exclusive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Selectors;

	[Field("kCTFontFeatureTypeExclusiveKey", "CoreText")]
	public static NSString Exclusive
	{
		get
		{
			if (_Exclusive == null)
			{
				_Exclusive = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureTypeExclusiveKey");
			}
			return _Exclusive;
		}
	}

	[Field("kCTFontFeatureTypeIdentifierKey", "CoreText")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureTypeIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("kCTFontFeatureTypeNameKey", "CoreText")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureTypeNameKey");
			}
			return _Name;
		}
	}

	[Field("kCTFontFeatureTypeSelectorsKey", "CoreText")]
	public static NSString Selectors
	{
		get
		{
			if (_Selectors == null)
			{
				_Selectors = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontFeatureTypeSelectorsKey");
			}
			return _Selectors;
		}
	}
}

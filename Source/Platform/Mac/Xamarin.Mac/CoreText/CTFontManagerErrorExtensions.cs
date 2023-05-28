using Foundation;
using ObjCRuntime;

namespace CoreText;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CTFontManagerErrorExtensions
{
	[Field("kCTFontManagerErrorDomain", "CoreText")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CTFontManagerError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontManagerErrorDomain");
		}
		return _domain;
	}
}

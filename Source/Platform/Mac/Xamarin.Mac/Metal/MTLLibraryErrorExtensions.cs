using Foundation;
using ObjCRuntime;

namespace Metal;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLLibraryErrorExtensions
{
	[Field("MTLLibraryErrorDomain", "Metal")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MTLLibraryError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Metal.Handle, "MTLLibraryErrorDomain");
		}
		return _domain;
	}
}

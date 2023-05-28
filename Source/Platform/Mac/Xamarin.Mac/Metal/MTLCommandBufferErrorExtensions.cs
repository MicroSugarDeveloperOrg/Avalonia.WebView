using Foundation;
using ObjCRuntime;

namespace Metal;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLCommandBufferErrorExtensions
{
	[Field("MTLCommandBufferErrorDomain", "Metal")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MTLCommandBufferError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Metal.Handle, "MTLCommandBufferErrorDomain");
		}
		return _domain;
	}
}

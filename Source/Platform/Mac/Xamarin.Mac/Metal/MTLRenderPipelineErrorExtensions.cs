using Foundation;
using ObjCRuntime;

namespace Metal;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLRenderPipelineErrorExtensions
{
	[Field("MTLRenderPipelineErrorDomain", "Metal")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MTLRenderPipelineError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Metal.Handle, "MTLRenderPipelineErrorDomain");
		}
		return _domain;
	}
}

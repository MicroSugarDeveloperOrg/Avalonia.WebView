using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CGImageMetadataErrorsExtensions
{
	[Field("kCFErrorDomainCGImageMetadata", "ImageIO")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CGImageMetadataErrors self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCFErrorDomainCGImageMetadata");
		}
		return _domain;
	}
}

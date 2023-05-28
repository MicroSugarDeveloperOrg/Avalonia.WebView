using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SNErrorCodeExtensions
{
	[Field("SNErrorDomain", "SoundAnalysis")]
	private static NSString? _domain;

	public static NSString? GetDomain(this SNErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.SoundAnalysis.Handle, "SNErrorDomain");
		}
		return _domain;
	}
}

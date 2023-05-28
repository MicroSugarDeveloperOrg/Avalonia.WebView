using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AEAssessmentErrorCodeExtensions
{
	[Field("AEAssessmentErrorDomain", "AutomaticAssessmentConfiguration")]
	private static NSString? _domain;

	public static NSString? GetDomain(this AEAssessmentErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.AutomaticAssessmentConfiguration.Handle, "AEAssessmentErrorDomain");
		}
		return _domain;
	}
}

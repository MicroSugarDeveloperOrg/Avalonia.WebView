using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class NSUserActivityType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BrowsingWeb;

	[Field("NSUserActivityTypeBrowsingWeb", "Foundation")]
	public static NSString BrowsingWeb
	{
		get
		{
			if (_BrowsingWeb == null)
			{
				_BrowsingWeb = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUserActivityTypeBrowsingWeb");
			}
			return _BrowsingWeb;
		}
	}
}

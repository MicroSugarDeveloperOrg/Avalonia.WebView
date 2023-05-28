using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
internal static class NSAttributedStringDocumentReadingOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadAccessUrlKey;

	[Field("NSReadAccessURLDocumentOption", "WebKit")]
	public static NSString ReadAccessUrlKey
	{
		get
		{
			if (_ReadAccessUrlKey == null)
			{
				_ReadAccessUrlKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "NSReadAccessURLDocumentOption");
			}
			return _ReadAccessUrlKey;
		}
	}
}

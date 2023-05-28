using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAboutPanelOption
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationIcon;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Credits;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Version;

	[Field("NSAboutPanelOptionApplicationIcon", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ApplicationIcon
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplicationIcon == null)
			{
				_ApplicationIcon = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationIcon");
			}
			return _ApplicationIcon;
		}
	}

	[Field("NSAboutPanelOptionApplicationName", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ApplicationName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplicationName == null)
			{
				_ApplicationName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationName");
			}
			return _ApplicationName;
		}
	}

	[Field("NSAboutPanelOptionApplicationVersion", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ApplicationVersion
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplicationVersion == null)
			{
				_ApplicationVersion = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAboutPanelOptionApplicationVersion");
			}
			return _ApplicationVersion;
		}
	}

	[Field("NSAboutPanelOptionCredits", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString Credits
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_Credits == null)
			{
				_Credits = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAboutPanelOptionCredits");
			}
			return _Credits;
		}
	}

	[Field("NSAboutPanelOptionVersion", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString Version
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_Version == null)
			{
				_Version = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAboutPanelOptionVersion");
			}
			return _Version;
		}
	}
}

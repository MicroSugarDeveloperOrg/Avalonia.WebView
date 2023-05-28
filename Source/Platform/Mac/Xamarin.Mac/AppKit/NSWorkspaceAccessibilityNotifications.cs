using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSWorkspaceAccessibilityNotifications
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayOptionsDidChangeNotification;

	[Field("NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString DisplayOptionsDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_DisplayOptionsDidChangeNotification == null)
			{
				_DisplayOptionsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification");
			}
			return _DisplayOptionsDidChangeNotification;
		}
	}
}

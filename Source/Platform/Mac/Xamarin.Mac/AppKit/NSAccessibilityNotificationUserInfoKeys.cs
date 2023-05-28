using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityNotificationUserInfoKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnouncementKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PriorityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementsKey;

	[Field("NSAccessibilityAnnouncementKey", "AppKit")]
	public static NSString AnnouncementKey
	{
		get
		{
			if (_AnnouncementKey == null)
			{
				_AnnouncementKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnouncementKey");
			}
			return _AnnouncementKey;
		}
	}

	[Field("NSAccessibilityPriorityKey", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString PriorityKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PriorityKey == null)
			{
				_PriorityKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPriorityKey");
			}
			return _PriorityKey;
		}
	}

	[Field("NSAccessibilityUIElementsKey", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UIElementsKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UIElementsKey == null)
			{
				_UIElementsKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUIElementsKey");
			}
			return _UIElementsKey;
		}
	}
}

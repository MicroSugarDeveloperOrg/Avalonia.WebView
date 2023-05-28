using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityNotifications
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnouncementRequestedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationActivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationDeactivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationHiddenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationShownNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DrawerCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HelpTagCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCollapsedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCountChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowExpandedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedCellsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedColumnsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedRowsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SheetCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementDestroyedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementFocusedChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnitsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowDeminiaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMiniaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowResizedNotification;

	[Field("NSAccessibilityAnnouncementRequestedNotification", "AppKit")]
	public static NSString AnnouncementRequestedNotification
	{
		get
		{
			if (_AnnouncementRequestedNotification == null)
			{
				_AnnouncementRequestedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnouncementRequestedNotification");
			}
			return _AnnouncementRequestedNotification;
		}
	}

	[Field("NSAccessibilityApplicationActivatedNotification", "AppKit")]
	public static NSString ApplicationActivatedNotification
	{
		get
		{
			if (_ApplicationActivatedNotification == null)
			{
				_ApplicationActivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationActivatedNotification");
			}
			return _ApplicationActivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationDeactivatedNotification", "AppKit")]
	public static NSString ApplicationDeactivatedNotification
	{
		get
		{
			if (_ApplicationDeactivatedNotification == null)
			{
				_ApplicationDeactivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationDeactivatedNotification");
			}
			return _ApplicationDeactivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationHiddenNotification", "AppKit")]
	public static NSString ApplicationHiddenNotification
	{
		get
		{
			if (_ApplicationHiddenNotification == null)
			{
				_ApplicationHiddenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationHiddenNotification");
			}
			return _ApplicationHiddenNotification;
		}
	}

	[Field("NSAccessibilityApplicationShownNotification", "AppKit")]
	public static NSString ApplicationShownNotification
	{
		get
		{
			if (_ApplicationShownNotification == null)
			{
				_ApplicationShownNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationShownNotification");
			}
			return _ApplicationShownNotification;
		}
	}

	[Field("NSAccessibilityCreatedNotification", "AppKit")]
	public static NSString CreatedNotification
	{
		get
		{
			if (_CreatedNotification == null)
			{
				_CreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCreatedNotification");
			}
			return _CreatedNotification;
		}
	}

	[Field("NSAccessibilityDrawerCreatedNotification", "AppKit")]
	public static NSString DrawerCreatedNotification
	{
		get
		{
			if (_DrawerCreatedNotification == null)
			{
				_DrawerCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDrawerCreatedNotification");
			}
			return _DrawerCreatedNotification;
		}
	}

	[Field("NSAccessibilityFocusedWindowChangedNotification", "AppKit")]
	public static NSString FocusedWindowChangedNotification
	{
		get
		{
			if (_FocusedWindowChangedNotification == null)
			{
				_FocusedWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowChangedNotification");
			}
			return _FocusedWindowChangedNotification;
		}
	}

	[Field("NSAccessibilityHelpTagCreatedNotification", "AppKit")]
	public static NSString HelpTagCreatedNotification
	{
		get
		{
			if (_HelpTagCreatedNotification == null)
			{
				_HelpTagCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHelpTagCreatedNotification");
			}
			return _HelpTagCreatedNotification;
		}
	}

	[Field("NSAccessibilityLayoutChangedNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LayoutChangedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LayoutChangedNotification == null)
			{
				_LayoutChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLayoutChangedNotification");
			}
			return _LayoutChangedNotification;
		}
	}

	[Field("NSAccessibilityMainWindowChangedNotification", "AppKit")]
	public static NSString MainWindowChangedNotification
	{
		get
		{
			if (_MainWindowChangedNotification == null)
			{
				_MainWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMainWindowChangedNotification");
			}
			return _MainWindowChangedNotification;
		}
	}

	[Field("NSAccessibilityMovedNotification", "AppKit")]
	public static NSString MovedNotification
	{
		get
		{
			if (_MovedNotification == null)
			{
				_MovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMovedNotification");
			}
			return _MovedNotification;
		}
	}

	[Field("NSAccessibilityResizedNotification", "AppKit")]
	public static NSString ResizedNotification
	{
		get
		{
			if (_ResizedNotification == null)
			{
				_ResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityResizedNotification");
			}
			return _ResizedNotification;
		}
	}

	[Field("NSAccessibilityRowCollapsedNotification", "AppKit")]
	public static NSString RowCollapsedNotification
	{
		get
		{
			if (_RowCollapsedNotification == null)
			{
				_RowCollapsedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCollapsedNotification");
			}
			return _RowCollapsedNotification;
		}
	}

	[Field("NSAccessibilityRowCountChangedNotification", "AppKit")]
	public static NSString RowCountChangedNotification
	{
		get
		{
			if (_RowCountChangedNotification == null)
			{
				_RowCountChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCountChangedNotification");
			}
			return _RowCountChangedNotification;
		}
	}

	[Field("NSAccessibilityRowExpandedNotification", "AppKit")]
	public static NSString RowExpandedNotification
	{
		get
		{
			if (_RowExpandedNotification == null)
			{
				_RowExpandedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowExpandedNotification");
			}
			return _RowExpandedNotification;
		}
	}

	[Field("NSAccessibilitySelectedCellsChangedNotification", "AppKit")]
	public static NSString SelectedCellsChangedNotification
	{
		get
		{
			if (_SelectedCellsChangedNotification == null)
			{
				_SelectedCellsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsChangedNotification");
			}
			return _SelectedCellsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenChangedNotification", "AppKit")]
	public static NSString SelectedChildrenChangedNotification
	{
		get
		{
			if (_SelectedChildrenChangedNotification == null)
			{
				_SelectedChildrenChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenChangedNotification");
			}
			return _SelectedChildrenChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenMovedNotification", "AppKit")]
	public static NSString SelectedChildrenMovedNotification
	{
		get
		{
			if (_SelectedChildrenMovedNotification == null)
			{
				_SelectedChildrenMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenMovedNotification");
			}
			return _SelectedChildrenMovedNotification;
		}
	}

	[Field("NSAccessibilitySelectedColumnsChangedNotification", "AppKit")]
	public static NSString SelectedColumnsChangedNotification
	{
		get
		{
			if (_SelectedColumnsChangedNotification == null)
			{
				_SelectedColumnsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsChangedNotification");
			}
			return _SelectedColumnsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedRowsChangedNotification", "AppKit")]
	public static NSString SelectedRowsChangedNotification
	{
		get
		{
			if (_SelectedRowsChangedNotification == null)
			{
				_SelectedRowsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsChangedNotification");
			}
			return _SelectedRowsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedTextChangedNotification", "AppKit")]
	public static NSString SelectedTextChangedNotification
	{
		get
		{
			if (_SelectedTextChangedNotification == null)
			{
				_SelectedTextChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextChangedNotification");
			}
			return _SelectedTextChangedNotification;
		}
	}

	[Field("NSAccessibilitySheetCreatedNotification", "AppKit")]
	public static NSString SheetCreatedNotification
	{
		get
		{
			if (_SheetCreatedNotification == null)
			{
				_SheetCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySheetCreatedNotification");
			}
			return _SheetCreatedNotification;
		}
	}

	[Field("NSAccessibilityTitleChangedNotification", "AppKit")]
	public static NSString TitleChangedNotification
	{
		get
		{
			if (_TitleChangedNotification == null)
			{
				_TitleChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTitleChangedNotification");
			}
			return _TitleChangedNotification;
		}
	}

	[Field("NSAccessibilityUIElementDestroyedNotification", "AppKit")]
	public static NSString UIElementDestroyedNotification
	{
		get
		{
			if (_UIElementDestroyedNotification == null)
			{
				_UIElementDestroyedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUIElementDestroyedNotification");
			}
			return _UIElementDestroyedNotification;
		}
	}

	[Field("NSAccessibilityFocusedUIElementChangedNotification", "AppKit")]
	public static NSString UIElementFocusedChangedNotification
	{
		get
		{
			if (_UIElementFocusedChangedNotification == null)
			{
				_UIElementFocusedChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementChangedNotification");
			}
			return _UIElementFocusedChangedNotification;
		}
	}

	[Field("NSAccessibilityUnitsChangedNotification", "AppKit")]
	public static NSString UnitsChangedNotification
	{
		get
		{
			if (_UnitsChangedNotification == null)
			{
				_UnitsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnitsChangedNotification");
			}
			return _UnitsChangedNotification;
		}
	}

	[Field("NSAccessibilityValueChangedNotification", "AppKit")]
	public static NSString ValueChangedNotification
	{
		get
		{
			if (_ValueChangedNotification == null)
			{
				_ValueChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityValueChangedNotification");
			}
			return _ValueChangedNotification;
		}
	}

	[Field("NSAccessibilityWindowCreatedNotification", "AppKit")]
	public static NSString WindowCreatedNotification
	{
		get
		{
			if (_WindowCreatedNotification == null)
			{
				_WindowCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowCreatedNotification");
			}
			return _WindowCreatedNotification;
		}
	}

	[Field("NSAccessibilityWindowDeminiaturizedNotification", "AppKit")]
	public static NSString WindowDeminiaturizedNotification
	{
		get
		{
			if (_WindowDeminiaturizedNotification == null)
			{
				_WindowDeminiaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowDeminiaturizedNotification");
			}
			return _WindowDeminiaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMiniaturizedNotification", "AppKit")]
	public static NSString WindowMiniaturizedNotification
	{
		get
		{
			if (_WindowMiniaturizedNotification == null)
			{
				_WindowMiniaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMiniaturizedNotification");
			}
			return _WindowMiniaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMovedNotification", "AppKit")]
	public static NSString WindowMovedNotification
	{
		get
		{
			if (_WindowMovedNotification == null)
			{
				_WindowMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMovedNotification");
			}
			return _WindowMovedNotification;
		}
	}

	[Field("NSAccessibilityWindowResizedNotification", "AppKit")]
	public static NSString WindowResizedNotification
	{
		get
		{
			if (_WindowResizedNotification == null)
			{
				_WindowResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowResizedNotification");
			}
			return _WindowResizedNotification;
		}
	}
}

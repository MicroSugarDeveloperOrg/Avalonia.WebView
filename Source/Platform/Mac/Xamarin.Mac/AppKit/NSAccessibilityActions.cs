using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityActions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CancelAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConfirmAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DecrementAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeleteAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IncrementAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PickAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PressAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RaiseAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowAlternateUIAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowDefaultUIAction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShowMenu;

	[Field("NSAccessibilityCancelAction", "AppKit")]
	public static NSString CancelAction
	{
		get
		{
			if (_CancelAction == null)
			{
				_CancelAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCancelAction");
			}
			return _CancelAction;
		}
	}

	[Field("NSAccessibilityConfirmAction", "AppKit")]
	public static NSString ConfirmAction
	{
		get
		{
			if (_ConfirmAction == null)
			{
				_ConfirmAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityConfirmAction");
			}
			return _ConfirmAction;
		}
	}

	[Field("NSAccessibilityDecrementAction", "AppKit")]
	public static NSString DecrementAction
	{
		get
		{
			if (_DecrementAction == null)
			{
				_DecrementAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDecrementAction");
			}
			return _DecrementAction;
		}
	}

	[Field("NSAccessibilityDeleteAction", "AppKit")]
	public static NSString DeleteAction
	{
		get
		{
			if (_DeleteAction == null)
			{
				_DeleteAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDeleteAction");
			}
			return _DeleteAction;
		}
	}

	[Field("NSAccessibilityIncrementAction", "AppKit")]
	public static NSString IncrementAction
	{
		get
		{
			if (_IncrementAction == null)
			{
				_IncrementAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIncrementAction");
			}
			return _IncrementAction;
		}
	}

	[Field("NSAccessibilityPickAction", "AppKit")]
	public static NSString PickAction
	{
		get
		{
			if (_PickAction == null)
			{
				_PickAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPickAction");
			}
			return _PickAction;
		}
	}

	[Field("NSAccessibilityPressAction", "AppKit")]
	public static NSString PressAction
	{
		get
		{
			if (_PressAction == null)
			{
				_PressAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPressAction");
			}
			return _PressAction;
		}
	}

	[Field("NSAccessibilityRaiseAction", "AppKit")]
	public static NSString RaiseAction
	{
		get
		{
			if (_RaiseAction == null)
			{
				_RaiseAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRaiseAction");
			}
			return _RaiseAction;
		}
	}

	[Field("NSAccessibilityShowAlternateUIAction", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ShowAlternateUIAction
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ShowAlternateUIAction == null)
			{
				_ShowAlternateUIAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityShowAlternateUIAction");
			}
			return _ShowAlternateUIAction;
		}
	}

	[Field("NSAccessibilityShowDefaultUIAction", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ShowDefaultUIAction
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ShowDefaultUIAction == null)
			{
				_ShowDefaultUIAction = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityShowDefaultUIAction");
			}
			return _ShowDefaultUIAction;
		}
	}

	[Field("NSAccessibilityShowMenuAction", "AppKit")]
	public static NSString ShowMenu
	{
		get
		{
			if (_ShowMenu == null)
			{
				_ShowMenu = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityShowMenuAction");
			}
			return _ShowMenu;
		}
	}
}

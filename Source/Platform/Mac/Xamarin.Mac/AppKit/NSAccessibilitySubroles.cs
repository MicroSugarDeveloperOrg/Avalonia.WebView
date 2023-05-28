using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilitySubroles
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CloseButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CollectionListSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentListSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DecrementArrowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DecrementPageSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DefinitionListSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescriptionListSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DialogSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FloatingWindowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FullScreenButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IncrementArrowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IncrementPageSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinimizeButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutlineRowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RatingIndicatorSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SearchFieldSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SectionListSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SecureTextFieldSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SortButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StandardWindowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SwitchSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemDialogSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemFloatingWindowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TabButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TableRowSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextAttachmentSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextLinkSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimelineSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ToggleSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ToolbarButtonSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnknownSubrole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ZoomButtonSubrole;

	[Field("NSAccessibilityCloseButtonSubrole", "AppKit")]
	public static NSString CloseButtonSubrole
	{
		get
		{
			if (_CloseButtonSubrole == null)
			{
				_CloseButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCloseButtonSubrole");
			}
			return _CloseButtonSubrole;
		}
	}

	[Field("NSAccessibilityCollectionListSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString CollectionListSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_CollectionListSubrole == null)
			{
				_CollectionListSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCollectionListSubrole");
			}
			return _CollectionListSubrole;
		}
	}

	[Field("NSAccessibilityContentListSubrole", "AppKit")]
	public static NSString ContentListSubrole
	{
		get
		{
			if (_ContentListSubrole == null)
			{
				_ContentListSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityContentListSubrole");
			}
			return _ContentListSubrole;
		}
	}

	[Field("NSAccessibilityDecrementArrowSubrole", "AppKit")]
	public static NSString DecrementArrowSubrole
	{
		get
		{
			if (_DecrementArrowSubrole == null)
			{
				_DecrementArrowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDecrementArrowSubrole");
			}
			return _DecrementArrowSubrole;
		}
	}

	[Field("NSAccessibilityDecrementPageSubrole", "AppKit")]
	public static NSString DecrementPageSubrole
	{
		get
		{
			if (_DecrementPageSubrole == null)
			{
				_DecrementPageSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDecrementPageSubrole");
			}
			return _DecrementPageSubrole;
		}
	}

	[Field("NSAccessibilityDefinitionListSubrole", "AppKit")]
	public static NSString DefinitionListSubrole
	{
		get
		{
			if (_DefinitionListSubrole == null)
			{
				_DefinitionListSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDefinitionListSubrole");
			}
			return _DefinitionListSubrole;
		}
	}

	[Field("NSAccessibilityDescriptionListSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString DescriptionListSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_DescriptionListSubrole == null)
			{
				_DescriptionListSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDescriptionListSubrole");
			}
			return _DescriptionListSubrole;
		}
	}

	[Field("NSAccessibilityDialogSubrole", "AppKit")]
	public static NSString DialogSubrole
	{
		get
		{
			if (_DialogSubrole == null)
			{
				_DialogSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDialogSubrole");
			}
			return _DialogSubrole;
		}
	}

	[Field("NSAccessibilityFloatingWindowSubrole", "AppKit")]
	public static NSString FloatingWindowSubrole
	{
		get
		{
			if (_FloatingWindowSubrole == null)
			{
				_FloatingWindowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFloatingWindowSubrole");
			}
			return _FloatingWindowSubrole;
		}
	}

	[Field("NSAccessibilityFullScreenButtonSubrole", "AppKit")]
	public static NSString FullScreenButtonSubrole
	{
		get
		{
			if (_FullScreenButtonSubrole == null)
			{
				_FullScreenButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFullScreenButtonSubrole");
			}
			return _FullScreenButtonSubrole;
		}
	}

	[Field("NSAccessibilityIncrementArrowSubrole", "AppKit")]
	public static NSString IncrementArrowSubrole
	{
		get
		{
			if (_IncrementArrowSubrole == null)
			{
				_IncrementArrowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIncrementArrowSubrole");
			}
			return _IncrementArrowSubrole;
		}
	}

	[Field("NSAccessibilityIncrementPageSubrole", "AppKit")]
	public static NSString IncrementPageSubrole
	{
		get
		{
			if (_IncrementPageSubrole == null)
			{
				_IncrementPageSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIncrementPageSubrole");
			}
			return _IncrementPageSubrole;
		}
	}

	[Field("NSAccessibilityMinimizeButtonSubrole", "AppKit")]
	public static NSString MinimizeButtonSubrole
	{
		get
		{
			if (_MinimizeButtonSubrole == null)
			{
				_MinimizeButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMinimizeButtonSubrole");
			}
			return _MinimizeButtonSubrole;
		}
	}

	[Field("NSAccessibilityOutlineRowSubrole", "AppKit")]
	public static NSString OutlineRowSubrole
	{
		get
		{
			if (_OutlineRowSubrole == null)
			{
				_OutlineRowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityOutlineRowSubrole");
			}
			return _OutlineRowSubrole;
		}
	}

	[Field("NSAccessibilityRatingIndicatorSubrole", "AppKit")]
	public static NSString RatingIndicatorSubrole
	{
		get
		{
			if (_RatingIndicatorSubrole == null)
			{
				_RatingIndicatorSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRatingIndicatorSubrole");
			}
			return _RatingIndicatorSubrole;
		}
	}

	[Field("NSAccessibilitySearchFieldSubrole", "AppKit")]
	public static NSString SearchFieldSubrole
	{
		get
		{
			if (_SearchFieldSubrole == null)
			{
				_SearchFieldSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySearchFieldSubrole");
			}
			return _SearchFieldSubrole;
		}
	}

	[Field("NSAccessibilitySectionListSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString SectionListSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_SectionListSubrole == null)
			{
				_SectionListSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySectionListSubrole");
			}
			return _SectionListSubrole;
		}
	}

	[Field("NSAccessibilitySecureTextFieldSubrole", "AppKit")]
	public static NSString SecureTextFieldSubrole
	{
		get
		{
			if (_SecureTextFieldSubrole == null)
			{
				_SecureTextFieldSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySecureTextFieldSubrole");
			}
			return _SecureTextFieldSubrole;
		}
	}

	[Field("NSAccessibilitySortButtonSubrole", "AppKit")]
	public static NSString SortButtonSubrole
	{
		get
		{
			if (_SortButtonSubrole == null)
			{
				_SortButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySortButtonSubrole");
			}
			return _SortButtonSubrole;
		}
	}

	[Field("NSAccessibilityStandardWindowSubrole", "AppKit")]
	public static NSString StandardWindowSubrole
	{
		get
		{
			if (_StandardWindowSubrole == null)
			{
				_StandardWindowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityStandardWindowSubrole");
			}
			return _StandardWindowSubrole;
		}
	}

	[Field("NSAccessibilitySwitchSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SwitchSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SwitchSubrole == null)
			{
				_SwitchSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySwitchSubrole");
			}
			return _SwitchSubrole;
		}
	}

	[Field("NSAccessibilitySystemDialogSubrole", "AppKit")]
	public static NSString SystemDialogSubrole
	{
		get
		{
			if (_SystemDialogSubrole == null)
			{
				_SystemDialogSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySystemDialogSubrole");
			}
			return _SystemDialogSubrole;
		}
	}

	[Field("NSAccessibilitySystemFloatingWindowSubrole", "AppKit")]
	public static NSString SystemFloatingWindowSubrole
	{
		get
		{
			if (_SystemFloatingWindowSubrole == null)
			{
				_SystemFloatingWindowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySystemFloatingWindowSubrole");
			}
			return _SystemFloatingWindowSubrole;
		}
	}

	[Field("NSAccessibilityTabButtonSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString TabButtonSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_TabButtonSubrole == null)
			{
				_TabButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTabButtonSubrole");
			}
			return _TabButtonSubrole;
		}
	}

	[Field("NSAccessibilityTableRowSubrole", "AppKit")]
	public static NSString TableRowSubrole
	{
		get
		{
			if (_TableRowSubrole == null)
			{
				_TableRowSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTableRowSubrole");
			}
			return _TableRowSubrole;
		}
	}

	[Field("NSAccessibilityTextAttachmentSubrole", "AppKit")]
	public static NSString TextAttachmentSubrole
	{
		get
		{
			if (_TextAttachmentSubrole == null)
			{
				_TextAttachmentSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTextAttachmentSubrole");
			}
			return _TextAttachmentSubrole;
		}
	}

	[Field("NSAccessibilityTextLinkSubrole", "AppKit")]
	public static NSString TextLinkSubrole
	{
		get
		{
			if (_TextLinkSubrole == null)
			{
				_TextLinkSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTextLinkSubrole");
			}
			return _TextLinkSubrole;
		}
	}

	[Field("NSAccessibilityTimelineSubrole", "AppKit")]
	public static NSString TimelineSubrole
	{
		get
		{
			if (_TimelineSubrole == null)
			{
				_TimelineSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTimelineSubrole");
			}
			return _TimelineSubrole;
		}
	}

	[Field("NSAccessibilityToggleSubrole", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ToggleSubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ToggleSubrole == null)
			{
				_ToggleSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityToggleSubrole");
			}
			return _ToggleSubrole;
		}
	}

	[Field("NSAccessibilityToolbarButtonSubrole", "AppKit")]
	public static NSString ToolbarButtonSubrole
	{
		get
		{
			if (_ToolbarButtonSubrole == null)
			{
				_ToolbarButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityToolbarButtonSubrole");
			}
			return _ToolbarButtonSubrole;
		}
	}

	[Field("NSAccessibilityUnknownSubrole", "AppKit")]
	public static NSString UnknownSubrole
	{
		get
		{
			if (_UnknownSubrole == null)
			{
				_UnknownSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnknownSubrole");
			}
			return _UnknownSubrole;
		}
	}

	[Field("NSAccessibilityZoomButtonSubrole", "AppKit")]
	public static NSString ZoomButtonSubrole
	{
		get
		{
			if (_ZoomButtonSubrole == null)
			{
				_ZoomButtonSubrole = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityZoomButtonSubrole");
			}
			return _ZoomButtonSubrole;
		}
	}
}

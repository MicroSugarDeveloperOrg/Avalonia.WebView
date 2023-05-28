using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityAttributes
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActivationPointAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowedValuesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlternateUIVisibleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttachmentTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributedStringForRangeParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutocorrectedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundColorTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoundsForRangeParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CancelButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CellForColumnAndRowParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChildrenAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ClearButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CloseButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnCountAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnHeaderUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnIndexRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnTitlesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsProtectedContentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CriticalValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CustomTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DecrementButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DefaultButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisclosedByRowAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisclosedRowsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisclosingAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisclosureLevelAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EditedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnabledAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExpandedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtrasMenuBarAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilenameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedUIElementAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedWindowAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForegroundColorTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrontmostAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FullScreenButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GrowAreaAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HandlesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeaderAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HelpAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HiddenAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HorizontalScrollBarAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HorizontalUnitDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HorizontalUnitsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IdentifierAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IncrementButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IndexAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InsertionPointLineNumberAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LabelUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LabelValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LanguageTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutPointForScreenPointParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutSizeForScreenSizeParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LineForIndexParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkedUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ListItemIndexTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ListItemLevelTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ListItemPrefixTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainWindowAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkedMisspelledTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkerGroupUIElementAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkerTypeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkerTypeDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkerUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MarkerValuesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MatteContentUIElementAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MatteHoleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MenuBarAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinimizeButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinimizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MisspelledTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModalAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NextContentsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NumberOfCharactersAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrderedByRowAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OverflowButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ParentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaceholderValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PositionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreviousContentsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProxyAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RTFForRangeParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RangeForIndexParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RangeForLineParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RangeForPositionParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequiredAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RoleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RoleDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCountAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowHeaderUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowIndexRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScreenPointForLayoutPointParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScreenSizeForLayoutSizeParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SearchButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SearchMenuAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedCellsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedColumnsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedRowsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextRangesAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServesAsTitleForUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadowTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharedCharacterRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharedFocusElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharedTextUIElementsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShownMenuAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SortDirectionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SplittersAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StrikethroughColorTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StrikethroughTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StringForRangeParameterizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StyleRangeForIndexParameterizedAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubroleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SuperscriptTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TabsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextAlignmentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleUIAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ToolbarButtonAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TopLevelUIElementAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ToplevelUIElementAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _URLAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnderlineColorTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnderlineTextAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnitDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnitsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VerticalScrollBarAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VerticalUnitDescriptionAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VerticalUnitsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleCellsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleCharacterRangeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleChildrenAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleColumnsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleRowsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WarningValueAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ZoomButtonAttribute;

	[Field("NSAccessibilityActivationPointAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ActivationPointAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ActivationPointAttribute == null)
			{
				_ActivationPointAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityActivationPointAttribute");
			}
			return _ActivationPointAttribute;
		}
	}

	[Field("NSAccessibilityAllowedValuesAttribute", "AppKit")]
	public static NSString AllowedValuesAttribute
	{
		get
		{
			if (_AllowedValuesAttribute == null)
			{
				_AllowedValuesAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAllowedValuesAttribute");
			}
			return _AllowedValuesAttribute;
		}
	}

	[Field("NSAccessibilityAlternateUIVisibleAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AlternateUIVisibleAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AlternateUIVisibleAttribute == null)
			{
				_AlternateUIVisibleAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAlternateUIVisibleAttribute");
			}
			return _AlternateUIVisibleAttribute;
		}
	}

	[Field("NSAccessibilityAnnotationTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString AnnotationTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_AnnotationTextAttribute == null)
			{
				_AnnotationTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnotationTextAttribute");
			}
			return _AnnotationTextAttribute;
		}
	}

	[Field("NSAccessibilityAttachmentTextAttribute", "AppKit")]
	public static NSString AttachmentTextAttribute
	{
		get
		{
			if (_AttachmentTextAttribute == null)
			{
				_AttachmentTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAttachmentTextAttribute");
			}
			return _AttachmentTextAttribute;
		}
	}

	[Field("NSAccessibilityAttributedStringForRangeParameterizedAttribute", "AppKit")]
	public static NSString AttributedStringForRangeParameterizedAttribute
	{
		get
		{
			if (_AttributedStringForRangeParameterizedAttribute == null)
			{
				_AttributedStringForRangeParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAttributedStringForRangeParameterizedAttribute");
			}
			return _AttributedStringForRangeParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityAutocorrectedTextAttribute", "AppKit")]
	public static NSString AutocorrectedAttribute
	{
		get
		{
			if (_AutocorrectedAttribute == null)
			{
				_AutocorrectedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAutocorrectedTextAttribute");
			}
			return _AutocorrectedAttribute;
		}
	}

	[Field("NSAccessibilityBackgroundColorTextAttribute", "AppKit")]
	public static NSString BackgroundColorTextAttribute
	{
		get
		{
			if (_BackgroundColorTextAttribute == null)
			{
				_BackgroundColorTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityBackgroundColorTextAttribute");
			}
			return _BackgroundColorTextAttribute;
		}
	}

	[Field("NSAccessibilityBoundsForRangeParameterizedAttribute", "AppKit")]
	public static NSString BoundsForRangeParameterizedAttribute
	{
		get
		{
			if (_BoundsForRangeParameterizedAttribute == null)
			{
				_BoundsForRangeParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityBoundsForRangeParameterizedAttribute");
			}
			return _BoundsForRangeParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityCancelButtonAttribute", "AppKit")]
	public static NSString CancelButtonAttribute
	{
		get
		{
			if (_CancelButtonAttribute == null)
			{
				_CancelButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCancelButtonAttribute");
			}
			return _CancelButtonAttribute;
		}
	}

	[Field("NSAccessibilityCellForColumnAndRowParameterizedAttribute", "AppKit")]
	public static NSString CellForColumnAndRowParameterizedAttribute
	{
		get
		{
			if (_CellForColumnAndRowParameterizedAttribute == null)
			{
				_CellForColumnAndRowParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCellForColumnAndRowParameterizedAttribute");
			}
			return _CellForColumnAndRowParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityChildrenAttribute", "AppKit")]
	public static NSString ChildrenAttribute
	{
		get
		{
			if (_ChildrenAttribute == null)
			{
				_ChildrenAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityChildrenAttribute");
			}
			return _ChildrenAttribute;
		}
	}

	[Field("NSAccessibilityClearButtonAttribute", "AppKit")]
	public static NSString ClearButtonAttribute
	{
		get
		{
			if (_ClearButtonAttribute == null)
			{
				_ClearButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityClearButtonAttribute");
			}
			return _ClearButtonAttribute;
		}
	}

	[Field("NSAccessibilityCloseButtonAttribute", "AppKit")]
	public static NSString CloseButtonAttribute
	{
		get
		{
			if (_CloseButtonAttribute == null)
			{
				_CloseButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCloseButtonAttribute");
			}
			return _CloseButtonAttribute;
		}
	}

	[Field("NSAccessibilityColumnCountAttribute", "AppKit")]
	public static NSString ColumnCountAttribute
	{
		get
		{
			if (_ColumnCountAttribute == null)
			{
				_ColumnCountAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityColumnCountAttribute");
			}
			return _ColumnCountAttribute;
		}
	}

	[Field("NSAccessibilityColumnHeaderUIElementsAttribute", "AppKit")]
	public static NSString ColumnHeaderUIElementsAttribute
	{
		get
		{
			if (_ColumnHeaderUIElementsAttribute == null)
			{
				_ColumnHeaderUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityColumnHeaderUIElementsAttribute");
			}
			return _ColumnHeaderUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityColumnIndexRangeAttribute", "AppKit")]
	public static NSString ColumnIndexRangeAttribute
	{
		get
		{
			if (_ColumnIndexRangeAttribute == null)
			{
				_ColumnIndexRangeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityColumnIndexRangeAttribute");
			}
			return _ColumnIndexRangeAttribute;
		}
	}

	[Field("NSAccessibilityColumnTitlesAttribute", "AppKit")]
	public static NSString ColumnTitlesAttribute
	{
		get
		{
			if (_ColumnTitlesAttribute == null)
			{
				_ColumnTitlesAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityColumnTitlesAttribute");
			}
			return _ColumnTitlesAttribute;
		}
	}

	[Field("NSAccessibilityColumnsAttribute", "AppKit")]
	public static NSString ColumnsAttribute
	{
		get
		{
			if (_ColumnsAttribute == null)
			{
				_ColumnsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityColumnsAttribute");
			}
			return _ColumnsAttribute;
		}
	}

	[Field("NSAccessibilityContainsProtectedContentAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ContainsProtectedContentAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ContainsProtectedContentAttribute == null)
			{
				_ContainsProtectedContentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityContainsProtectedContentAttribute");
			}
			return _ContainsProtectedContentAttribute;
		}
	}

	[Field("NSAccessibilityContentsAttribute", "AppKit")]
	public static NSString ContentsAttribute
	{
		get
		{
			if (_ContentsAttribute == null)
			{
				_ContentsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityContentsAttribute");
			}
			return _ContentsAttribute;
		}
	}

	[Field("NSAccessibilityCriticalValueAttribute", "AppKit")]
	public static NSString CriticalValueAttribute
	{
		get
		{
			if (_CriticalValueAttribute == null)
			{
				_CriticalValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCriticalValueAttribute");
			}
			return _CriticalValueAttribute;
		}
	}

	[Field("NSAccessibilityCustomTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString CustomTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_CustomTextAttribute == null)
			{
				_CustomTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCustomTextAttribute");
			}
			return _CustomTextAttribute;
		}
	}

	[Field("NSAccessibilityDecrementButtonAttribute", "AppKit")]
	public static NSString DecrementButtonAttribute
	{
		get
		{
			if (_DecrementButtonAttribute == null)
			{
				_DecrementButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDecrementButtonAttribute");
			}
			return _DecrementButtonAttribute;
		}
	}

	[Field("NSAccessibilityDefaultButtonAttribute", "AppKit")]
	public static NSString DefaultButtonAttribute
	{
		get
		{
			if (_DefaultButtonAttribute == null)
			{
				_DefaultButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDefaultButtonAttribute");
			}
			return _DefaultButtonAttribute;
		}
	}

	[Field("NSAccessibilityDescriptionAttribute", "AppKit")]
	public static NSString DescriptionAttribute
	{
		get
		{
			if (_DescriptionAttribute == null)
			{
				_DescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDescriptionAttribute");
			}
			return _DescriptionAttribute;
		}
	}

	[Field("NSAccessibilityDisclosedByRowAttribute", "AppKit")]
	public static NSString DisclosedByRowAttribute
	{
		get
		{
			if (_DisclosedByRowAttribute == null)
			{
				_DisclosedByRowAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDisclosedByRowAttribute");
			}
			return _DisclosedByRowAttribute;
		}
	}

	[Field("NSAccessibilityDisclosedRowsAttribute", "AppKit")]
	public static NSString DisclosedRowsAttribute
	{
		get
		{
			if (_DisclosedRowsAttribute == null)
			{
				_DisclosedRowsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDisclosedRowsAttribute");
			}
			return _DisclosedRowsAttribute;
		}
	}

	[Field("NSAccessibilityDisclosingAttribute", "AppKit")]
	public static NSString DisclosingAttribute
	{
		get
		{
			if (_DisclosingAttribute == null)
			{
				_DisclosingAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDisclosingAttribute");
			}
			return _DisclosingAttribute;
		}
	}

	[Field("NSAccessibilityDisclosureLevelAttribute", "AppKit")]
	public static NSString DisclosureLevelAttribute
	{
		get
		{
			if (_DisclosureLevelAttribute == null)
			{
				_DisclosureLevelAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDisclosureLevelAttribute");
			}
			return _DisclosureLevelAttribute;
		}
	}

	[Field("NSAccessibilityDocumentAttribute", "AppKit")]
	public static NSString DocumentAttribute
	{
		get
		{
			if (_DocumentAttribute == null)
			{
				_DocumentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDocumentAttribute");
			}
			return _DocumentAttribute;
		}
	}

	[Field("NSAccessibilityEditedAttribute", "AppKit")]
	public static NSString EditedAttribute
	{
		get
		{
			if (_EditedAttribute == null)
			{
				_EditedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityEditedAttribute");
			}
			return _EditedAttribute;
		}
	}

	[Field("NSAccessibilityEnabledAttribute", "AppKit")]
	public static NSString EnabledAttribute
	{
		get
		{
			if (_EnabledAttribute == null)
			{
				_EnabledAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityEnabledAttribute");
			}
			return _EnabledAttribute;
		}
	}

	[Field("NSAccessibilityExpandedAttribute", "AppKit")]
	public static NSString ExpandedAttribute
	{
		get
		{
			if (_ExpandedAttribute == null)
			{
				_ExpandedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityExpandedAttribute");
			}
			return _ExpandedAttribute;
		}
	}

	[Field("NSAccessibilityExtrasMenuBarAttribute", "AppKit")]
	public static NSString ExtrasMenuBarAttribute
	{
		get
		{
			if (_ExtrasMenuBarAttribute == null)
			{
				_ExtrasMenuBarAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityExtrasMenuBarAttribute");
			}
			return _ExtrasMenuBarAttribute;
		}
	}

	[Field("NSAccessibilityFilenameAttribute", "AppKit")]
	public static NSString FilenameAttribute
	{
		get
		{
			if (_FilenameAttribute == null)
			{
				_FilenameAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFilenameAttribute");
			}
			return _FilenameAttribute;
		}
	}

	[Field("NSAccessibilityFocusedAttribute", "AppKit")]
	public static NSString FocusedAttribute
	{
		get
		{
			if (_FocusedAttribute == null)
			{
				_FocusedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedAttribute");
			}
			return _FocusedAttribute;
		}
	}

	[Field("NSAccessibilityFocusedUIElementAttribute", "AppKit")]
	public static NSString FocusedUIElementAttribute
	{
		get
		{
			if (_FocusedUIElementAttribute == null)
			{
				_FocusedUIElementAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementAttribute");
			}
			return _FocusedUIElementAttribute;
		}
	}

	[Field("NSAccessibilityFocusedWindowAttribute", "AppKit")]
	public static NSString FocusedWindowAttribute
	{
		get
		{
			if (_FocusedWindowAttribute == null)
			{
				_FocusedWindowAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowAttribute");
			}
			return _FocusedWindowAttribute;
		}
	}

	[Field("NSAccessibilityFontTextAttribute", "AppKit")]
	public static NSString FontTextAttribute
	{
		get
		{
			if (_FontTextAttribute == null)
			{
				_FontTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFontTextAttribute");
			}
			return _FontTextAttribute;
		}
	}

	[Field("NSAccessibilityForegroundColorTextAttribute", "AppKit")]
	public static NSString ForegroundColorTextAttribute
	{
		get
		{
			if (_ForegroundColorTextAttribute == null)
			{
				_ForegroundColorTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityForegroundColorTextAttribute");
			}
			return _ForegroundColorTextAttribute;
		}
	}

	[Field("NSAccessibilityFrontmostAttribute", "AppKit")]
	public static NSString FrontmostAttribute
	{
		get
		{
			if (_FrontmostAttribute == null)
			{
				_FrontmostAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFrontmostAttribute");
			}
			return _FrontmostAttribute;
		}
	}

	[Field("NSAccessibilityFullScreenButtonAttribute", "AppKit")]
	public static NSString FullScreenButtonAttribute
	{
		get
		{
			if (_FullScreenButtonAttribute == null)
			{
				_FullScreenButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFullScreenButtonAttribute");
			}
			return _FullScreenButtonAttribute;
		}
	}

	[Field("NSAccessibilityGrowAreaAttribute", "AppKit")]
	public static NSString GrowAreaAttribute
	{
		get
		{
			if (_GrowAreaAttribute == null)
			{
				_GrowAreaAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityGrowAreaAttribute");
			}
			return _GrowAreaAttribute;
		}
	}

	[Field("NSAccessibilityHandlesAttribute", "AppKit")]
	public static NSString HandlesAttribute
	{
		get
		{
			if (_HandlesAttribute == null)
			{
				_HandlesAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHandlesAttribute");
			}
			return _HandlesAttribute;
		}
	}

	[Field("NSAccessibilityHeaderAttribute", "AppKit")]
	public static NSString HeaderAttribute
	{
		get
		{
			if (_HeaderAttribute == null)
			{
				_HeaderAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHeaderAttribute");
			}
			return _HeaderAttribute;
		}
	}

	[Field("NSAccessibilityHelpAttribute", "AppKit")]
	public static NSString HelpAttribute
	{
		get
		{
			if (_HelpAttribute == null)
			{
				_HelpAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHelpAttribute");
			}
			return _HelpAttribute;
		}
	}

	[Field("NSAccessibilityHiddenAttribute", "AppKit")]
	public static NSString HiddenAttribute
	{
		get
		{
			if (_HiddenAttribute == null)
			{
				_HiddenAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHiddenAttribute");
			}
			return _HiddenAttribute;
		}
	}

	[Field("NSAccessibilityHorizontalScrollBarAttribute", "AppKit")]
	public static NSString HorizontalScrollBarAttribute
	{
		get
		{
			if (_HorizontalScrollBarAttribute == null)
			{
				_HorizontalScrollBarAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHorizontalScrollBarAttribute");
			}
			return _HorizontalScrollBarAttribute;
		}
	}

	[Field("NSAccessibilityHorizontalUnitDescriptionAttribute", "AppKit")]
	public static NSString HorizontalUnitDescriptionAttribute
	{
		get
		{
			if (_HorizontalUnitDescriptionAttribute == null)
			{
				_HorizontalUnitDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHorizontalUnitDescriptionAttribute");
			}
			return _HorizontalUnitDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityHorizontalUnitsAttribute", "AppKit")]
	public static NSString HorizontalUnitsAttribute
	{
		get
		{
			if (_HorizontalUnitsAttribute == null)
			{
				_HorizontalUnitsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHorizontalUnitsAttribute");
			}
			return _HorizontalUnitsAttribute;
		}
	}

	[Field("NSAccessibilityIdentifierAttribute", "AppKit")]
	public static NSString IdentifierAttribute
	{
		get
		{
			if (_IdentifierAttribute == null)
			{
				_IdentifierAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIdentifierAttribute");
			}
			return _IdentifierAttribute;
		}
	}

	[Field("NSAccessibilityIncrementButtonAttribute", "AppKit")]
	public static NSString IncrementButtonAttribute
	{
		get
		{
			if (_IncrementButtonAttribute == null)
			{
				_IncrementButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIncrementButtonAttribute");
			}
			return _IncrementButtonAttribute;
		}
	}

	[Field("NSAccessibilityIndexAttribute", "AppKit")]
	public static NSString IndexAttribute
	{
		get
		{
			if (_IndexAttribute == null)
			{
				_IndexAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityIndexAttribute");
			}
			return _IndexAttribute;
		}
	}

	[Field("NSAccessibilityInsertionPointLineNumberAttribute", "AppKit")]
	public static NSString InsertionPointLineNumberAttribute
	{
		get
		{
			if (_InsertionPointLineNumberAttribute == null)
			{
				_InsertionPointLineNumberAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityInsertionPointLineNumberAttribute");
			}
			return _InsertionPointLineNumberAttribute;
		}
	}

	[Field("NSAccessibilityLabelUIElementsAttribute", "AppKit")]
	public static NSString LabelUIElementsAttribute
	{
		get
		{
			if (_LabelUIElementsAttribute == null)
			{
				_LabelUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLabelUIElementsAttribute");
			}
			return _LabelUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityLabelValueAttribute", "AppKit")]
	public static NSString LabelValueAttribute
	{
		get
		{
			if (_LabelValueAttribute == null)
			{
				_LabelValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLabelValueAttribute");
			}
			return _LabelValueAttribute;
		}
	}

	[Field("NSAccessibilityLanguageTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString LanguageTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_LanguageTextAttribute == null)
			{
				_LanguageTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLanguageTextAttribute");
			}
			return _LanguageTextAttribute;
		}
	}

	[Field("NSAccessibilityLayoutPointForScreenPointParameterizedAttribute", "AppKit")]
	public static NSString LayoutPointForScreenPointParameterizedAttribute
	{
		get
		{
			if (_LayoutPointForScreenPointParameterizedAttribute == null)
			{
				_LayoutPointForScreenPointParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLayoutPointForScreenPointParameterizedAttribute");
			}
			return _LayoutPointForScreenPointParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityLayoutSizeForScreenSizeParameterizedAttribute", "AppKit")]
	public static NSString LayoutSizeForScreenSizeParameterizedAttribute
	{
		get
		{
			if (_LayoutSizeForScreenSizeParameterizedAttribute == null)
			{
				_LayoutSizeForScreenSizeParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLayoutSizeForScreenSizeParameterizedAttribute");
			}
			return _LayoutSizeForScreenSizeParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityLineForIndexParameterizedAttribute", "AppKit")]
	public static NSString LineForIndexParameterizedAttribute
	{
		get
		{
			if (_LineForIndexParameterizedAttribute == null)
			{
				_LineForIndexParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLineForIndexParameterizedAttribute");
			}
			return _LineForIndexParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityLinkTextAttribute", "AppKit")]
	public static NSString LinkTextAttribute
	{
		get
		{
			if (_LinkTextAttribute == null)
			{
				_LinkTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLinkTextAttribute");
			}
			return _LinkTextAttribute;
		}
	}

	[Field("NSAccessibilityLinkedUIElementsAttribute", "AppKit")]
	public static NSString LinkedUIElementsAttribute
	{
		get
		{
			if (_LinkedUIElementsAttribute == null)
			{
				_LinkedUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLinkedUIElementsAttribute");
			}
			return _LinkedUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityListItemIndexTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ListItemIndexTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ListItemIndexTextAttribute == null)
			{
				_ListItemIndexTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityListItemIndexTextAttribute");
			}
			return _ListItemIndexTextAttribute;
		}
	}

	[Field("NSAccessibilityListItemLevelTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ListItemLevelTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ListItemLevelTextAttribute == null)
			{
				_ListItemLevelTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityListItemLevelTextAttribute");
			}
			return _ListItemLevelTextAttribute;
		}
	}

	[Field("NSAccessibilityListItemPrefixTextAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ListItemPrefixTextAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ListItemPrefixTextAttribute == null)
			{
				_ListItemPrefixTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityListItemPrefixTextAttribute");
			}
			return _ListItemPrefixTextAttribute;
		}
	}

	[Field("NSAccessibilityMainAttribute", "AppKit")]
	public static NSString MainAttribute
	{
		get
		{
			if (_MainAttribute == null)
			{
				_MainAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMainAttribute");
			}
			return _MainAttribute;
		}
	}

	[Field("NSAccessibilityMainWindowAttribute", "AppKit")]
	public static NSString MainWindowAttribute
	{
		get
		{
			if (_MainWindowAttribute == null)
			{
				_MainWindowAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMainWindowAttribute");
			}
			return _MainWindowAttribute;
		}
	}

	[Field("NSAccessibilityMarkedMisspelledTextAttribute", "AppKit")]
	public static NSString MarkedMisspelledTextAttribute
	{
		get
		{
			if (_MarkedMisspelledTextAttribute == null)
			{
				_MarkedMisspelledTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkedMisspelledTextAttribute");
			}
			return _MarkedMisspelledTextAttribute;
		}
	}

	[Field("NSAccessibilityMarkerGroupUIElementAttribute", "AppKit")]
	public static NSString MarkerGroupUIElementAttribute
	{
		get
		{
			if (_MarkerGroupUIElementAttribute == null)
			{
				_MarkerGroupUIElementAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkerGroupUIElementAttribute");
			}
			return _MarkerGroupUIElementAttribute;
		}
	}

	[Field("NSAccessibilityMarkerTypeAttribute", "AppKit")]
	public static NSString MarkerTypeAttribute
	{
		get
		{
			if (_MarkerTypeAttribute == null)
			{
				_MarkerTypeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkerTypeAttribute");
			}
			return _MarkerTypeAttribute;
		}
	}

	[Field("NSAccessibilityMarkerTypeDescriptionAttribute", "AppKit")]
	public static NSString MarkerTypeDescriptionAttribute
	{
		get
		{
			if (_MarkerTypeDescriptionAttribute == null)
			{
				_MarkerTypeDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkerTypeDescriptionAttribute");
			}
			return _MarkerTypeDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityMarkerUIElementsAttribute", "AppKit")]
	public static NSString MarkerUIElementsAttribute
	{
		get
		{
			if (_MarkerUIElementsAttribute == null)
			{
				_MarkerUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkerUIElementsAttribute");
			}
			return _MarkerUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityMarkerValuesAttribute", "AppKit")]
	public static NSString MarkerValuesAttribute
	{
		get
		{
			if (_MarkerValuesAttribute == null)
			{
				_MarkerValuesAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMarkerValuesAttribute");
			}
			return _MarkerValuesAttribute;
		}
	}

	[Field("NSAccessibilityMatteContentUIElementAttribute", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'NSAccessibility' methods instead.")]
	public static NSString MatteContentUIElementAttribute
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'NSAccessibility' methods instead.")]
		get
		{
			if (_MatteContentUIElementAttribute == null)
			{
				_MatteContentUIElementAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMatteContentUIElementAttribute");
			}
			return _MatteContentUIElementAttribute;
		}
	}

	[Field("NSAccessibilityMatteHoleAttribute", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'NSAccessibility' methods instead.")]
	public static NSString MatteHoleAttribute
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'NSAccessibility' methods instead.")]
		get
		{
			if (_MatteHoleAttribute == null)
			{
				_MatteHoleAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMatteHoleAttribute");
			}
			return _MatteHoleAttribute;
		}
	}

	[Field("NSAccessibilityMaxValueAttribute", "AppKit")]
	public static NSString MaxValueAttribute
	{
		get
		{
			if (_MaxValueAttribute == null)
			{
				_MaxValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMaxValueAttribute");
			}
			return _MaxValueAttribute;
		}
	}

	[Field("NSAccessibilityMenuBarAttribute", "AppKit")]
	public static NSString MenuBarAttribute
	{
		get
		{
			if (_MenuBarAttribute == null)
			{
				_MenuBarAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMenuBarAttribute");
			}
			return _MenuBarAttribute;
		}
	}

	[Field("NSAccessibilityMinValueAttribute", "AppKit")]
	public static NSString MinValueAttribute
	{
		get
		{
			if (_MinValueAttribute == null)
			{
				_MinValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMinValueAttribute");
			}
			return _MinValueAttribute;
		}
	}

	[Field("NSAccessibilityMinimizeButtonAttribute", "AppKit")]
	public static NSString MinimizeButtonAttribute
	{
		get
		{
			if (_MinimizeButtonAttribute == null)
			{
				_MinimizeButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMinimizeButtonAttribute");
			}
			return _MinimizeButtonAttribute;
		}
	}

	[Field("NSAccessibilityMinimizedAttribute", "AppKit")]
	public static NSString MinimizedAttribute
	{
		get
		{
			if (_MinimizedAttribute == null)
			{
				_MinimizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMinimizedAttribute");
			}
			return _MinimizedAttribute;
		}
	}

	[Field("NSAccessibilityMisspelledTextAttribute", "AppKit")]
	public static NSString MisspelledTextAttribute
	{
		get
		{
			if (_MisspelledTextAttribute == null)
			{
				_MisspelledTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMisspelledTextAttribute");
			}
			return _MisspelledTextAttribute;
		}
	}

	[Field("NSAccessibilityModalAttribute", "AppKit")]
	public static NSString ModalAttribute
	{
		get
		{
			if (_ModalAttribute == null)
			{
				_ModalAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityModalAttribute");
			}
			return _ModalAttribute;
		}
	}

	[Field("NSAccessibilityNextContentsAttribute", "AppKit")]
	public static NSString NextContentsAttribute
	{
		get
		{
			if (_NextContentsAttribute == null)
			{
				_NextContentsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityNextContentsAttribute");
			}
			return _NextContentsAttribute;
		}
	}

	[Field("NSAccessibilityNumberOfCharactersAttribute", "AppKit")]
	public static NSString NumberOfCharactersAttribute
	{
		get
		{
			if (_NumberOfCharactersAttribute == null)
			{
				_NumberOfCharactersAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityNumberOfCharactersAttribute");
			}
			return _NumberOfCharactersAttribute;
		}
	}

	[Field("NSAccessibilityOrderedByRowAttribute", "AppKit")]
	public static NSString OrderedByRowAttribute
	{
		get
		{
			if (_OrderedByRowAttribute == null)
			{
				_OrderedByRowAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityOrderedByRowAttribute");
			}
			return _OrderedByRowAttribute;
		}
	}

	[Field("NSAccessibilityOverflowButtonAttribute", "AppKit")]
	public static NSString OverflowButtonAttribute
	{
		get
		{
			if (_OverflowButtonAttribute == null)
			{
				_OverflowButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityOverflowButtonAttribute");
			}
			return _OverflowButtonAttribute;
		}
	}

	[Field("NSAccessibilityParentAttribute", "AppKit")]
	public static NSString ParentAttribute
	{
		get
		{
			if (_ParentAttribute == null)
			{
				_ParentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityParentAttribute");
			}
			return _ParentAttribute;
		}
	}

	[Field("NSAccessibilityPlaceholderValueAttribute", "AppKit")]
	public static NSString PlaceholderValueAttribute
	{
		get
		{
			if (_PlaceholderValueAttribute == null)
			{
				_PlaceholderValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPlaceholderValueAttribute");
			}
			return _PlaceholderValueAttribute;
		}
	}

	[Field("NSAccessibilityPositionAttribute", "AppKit")]
	public static NSString PositionAttribute
	{
		get
		{
			if (_PositionAttribute == null)
			{
				_PositionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPositionAttribute");
			}
			return _PositionAttribute;
		}
	}

	[Field("NSAccessibilityPreviousContentsAttribute", "AppKit")]
	public static NSString PreviousContentsAttribute
	{
		get
		{
			if (_PreviousContentsAttribute == null)
			{
				_PreviousContentsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityPreviousContentsAttribute");
			}
			return _PreviousContentsAttribute;
		}
	}

	[Field("NSAccessibilityProxyAttribute", "AppKit")]
	public static NSString ProxyAttribute
	{
		get
		{
			if (_ProxyAttribute == null)
			{
				_ProxyAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityProxyAttribute");
			}
			return _ProxyAttribute;
		}
	}

	[Field("NSAccessibilityRTFForRangeParameterizedAttribute", "AppKit")]
	public static NSString RTFForRangeParameterizedAttribute
	{
		get
		{
			if (_RTFForRangeParameterizedAttribute == null)
			{
				_RTFForRangeParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRTFForRangeParameterizedAttribute");
			}
			return _RTFForRangeParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityRangeForIndexParameterizedAttribute", "AppKit")]
	public static NSString RangeForIndexParameterizedAttribute
	{
		get
		{
			if (_RangeForIndexParameterizedAttribute == null)
			{
				_RangeForIndexParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRangeForIndexParameterizedAttribute");
			}
			return _RangeForIndexParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityRangeForLineParameterizedAttribute", "AppKit")]
	public static NSString RangeForLineParameterizedAttribute
	{
		get
		{
			if (_RangeForLineParameterizedAttribute == null)
			{
				_RangeForLineParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRangeForLineParameterizedAttribute");
			}
			return _RangeForLineParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityRangeForPositionParameterizedAttribute", "AppKit")]
	public static NSString RangeForPositionParameterizedAttribute
	{
		get
		{
			if (_RangeForPositionParameterizedAttribute == null)
			{
				_RangeForPositionParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRangeForPositionParameterizedAttribute");
			}
			return _RangeForPositionParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityRequiredAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString RequiredAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_RequiredAttribute == null)
			{
				_RequiredAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRequiredAttribute");
			}
			return _RequiredAttribute;
		}
	}

	[Field("NSAccessibilityRoleAttribute", "AppKit")]
	public static NSString RoleAttribute
	{
		get
		{
			if (_RoleAttribute == null)
			{
				_RoleAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRoleAttribute");
			}
			return _RoleAttribute;
		}
	}

	[Field("NSAccessibilityRoleDescriptionAttribute", "AppKit")]
	public static NSString RoleDescriptionAttribute
	{
		get
		{
			if (_RoleDescriptionAttribute == null)
			{
				_RoleDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRoleDescriptionAttribute");
			}
			return _RoleDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityRowCountAttribute", "AppKit")]
	public static NSString RowCountAttribute
	{
		get
		{
			if (_RowCountAttribute == null)
			{
				_RowCountAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCountAttribute");
			}
			return _RowCountAttribute;
		}
	}

	[Field("NSAccessibilityRowHeaderUIElementsAttribute", "AppKit")]
	public static NSString RowHeaderUIElementsAttribute
	{
		get
		{
			if (_RowHeaderUIElementsAttribute == null)
			{
				_RowHeaderUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowHeaderUIElementsAttribute");
			}
			return _RowHeaderUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityRowIndexRangeAttribute", "AppKit")]
	public static NSString RowIndexRangeAttribute
	{
		get
		{
			if (_RowIndexRangeAttribute == null)
			{
				_RowIndexRangeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowIndexRangeAttribute");
			}
			return _RowIndexRangeAttribute;
		}
	}

	[Field("NSAccessibilityRowsAttribute", "AppKit")]
	public static NSString RowsAttribute
	{
		get
		{
			if (_RowsAttribute == null)
			{
				_RowsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowsAttribute");
			}
			return _RowsAttribute;
		}
	}

	[Field("NSAccessibilityScreenPointForLayoutPointParameterizedAttribute", "AppKit")]
	public static NSString ScreenPointForLayoutPointParameterizedAttribute
	{
		get
		{
			if (_ScreenPointForLayoutPointParameterizedAttribute == null)
			{
				_ScreenPointForLayoutPointParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityScreenPointForLayoutPointParameterizedAttribute");
			}
			return _ScreenPointForLayoutPointParameterizedAttribute;
		}
	}

	[Field("NSAccessibilityScreenSizeForLayoutSizeParameterizedAttribute", "AppKit")]
	public static NSString ScreenSizeForLayoutSizeParameterizedAttribute
	{
		get
		{
			if (_ScreenSizeForLayoutSizeParameterizedAttribute == null)
			{
				_ScreenSizeForLayoutSizeParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityScreenSizeForLayoutSizeParameterizedAttribute");
			}
			return _ScreenSizeForLayoutSizeParameterizedAttribute;
		}
	}

	[Field("NSAccessibilitySearchButtonAttribute", "AppKit")]
	public static NSString SearchButtonAttribute
	{
		get
		{
			if (_SearchButtonAttribute == null)
			{
				_SearchButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySearchButtonAttribute");
			}
			return _SearchButtonAttribute;
		}
	}

	[Field("NSAccessibilitySearchMenuAttribute", "AppKit")]
	public static NSString SearchMenuAttribute
	{
		get
		{
			if (_SearchMenuAttribute == null)
			{
				_SearchMenuAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySearchMenuAttribute");
			}
			return _SearchMenuAttribute;
		}
	}

	[Field("NSAccessibilitySelectedAttribute", "AppKit")]
	public static NSString SelectedAttribute
	{
		get
		{
			if (_SelectedAttribute == null)
			{
				_SelectedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedAttribute");
			}
			return _SelectedAttribute;
		}
	}

	[Field("NSAccessibilitySelectedCellsAttribute", "AppKit")]
	public static NSString SelectedCellsAttribute
	{
		get
		{
			if (_SelectedCellsAttribute == null)
			{
				_SelectedCellsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsAttribute");
			}
			return _SelectedCellsAttribute;
		}
	}

	[Field("NSAccessibilitySelectedChildrenAttribute", "AppKit")]
	public static NSString SelectedChildrenAttribute
	{
		get
		{
			if (_SelectedChildrenAttribute == null)
			{
				_SelectedChildrenAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenAttribute");
			}
			return _SelectedChildrenAttribute;
		}
	}

	[Field("NSAccessibilitySelectedColumnsAttribute", "AppKit")]
	public static NSString SelectedColumnsAttribute
	{
		get
		{
			if (_SelectedColumnsAttribute == null)
			{
				_SelectedColumnsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsAttribute");
			}
			return _SelectedColumnsAttribute;
		}
	}

	[Field("NSAccessibilitySelectedRowsAttribute", "AppKit")]
	public static NSString SelectedRowsAttribute
	{
		get
		{
			if (_SelectedRowsAttribute == null)
			{
				_SelectedRowsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsAttribute");
			}
			return _SelectedRowsAttribute;
		}
	}

	[Field("NSAccessibilitySelectedTextAttribute", "AppKit")]
	public static NSString SelectedTextAttribute
	{
		get
		{
			if (_SelectedTextAttribute == null)
			{
				_SelectedTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextAttribute");
			}
			return _SelectedTextAttribute;
		}
	}

	[Field("NSAccessibilitySelectedTextRangeAttribute", "AppKit")]
	public static NSString SelectedTextRangeAttribute
	{
		get
		{
			if (_SelectedTextRangeAttribute == null)
			{
				_SelectedTextRangeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextRangeAttribute");
			}
			return _SelectedTextRangeAttribute;
		}
	}

	[Field("NSAccessibilitySelectedTextRangesAttribute", "AppKit")]
	public static NSString SelectedTextRangesAttribute
	{
		get
		{
			if (_SelectedTextRangesAttribute == null)
			{
				_SelectedTextRangesAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextRangesAttribute");
			}
			return _SelectedTextRangesAttribute;
		}
	}

	[Field("NSAccessibilityServesAsTitleForUIElementsAttribute", "AppKit")]
	public static NSString ServesAsTitleForUIElementsAttribute
	{
		get
		{
			if (_ServesAsTitleForUIElementsAttribute == null)
			{
				_ServesAsTitleForUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityServesAsTitleForUIElementsAttribute");
			}
			return _ServesAsTitleForUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityShadowTextAttribute", "AppKit")]
	public static NSString ShadowTextAttribute
	{
		get
		{
			if (_ShadowTextAttribute == null)
			{
				_ShadowTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityShadowTextAttribute");
			}
			return _ShadowTextAttribute;
		}
	}

	[Field("NSAccessibilitySharedCharacterRangeAttribute", "AppKit")]
	public static NSString SharedCharacterRangeAttribute
	{
		get
		{
			if (_SharedCharacterRangeAttribute == null)
			{
				_SharedCharacterRangeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySharedCharacterRangeAttribute");
			}
			return _SharedCharacterRangeAttribute;
		}
	}

	[Field("NSAccessibilitySharedFocusElementsAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString SharedFocusElementsAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_SharedFocusElementsAttribute == null)
			{
				_SharedFocusElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySharedFocusElementsAttribute");
			}
			return _SharedFocusElementsAttribute;
		}
	}

	[Field("NSAccessibilitySharedTextUIElementsAttribute", "AppKit")]
	public static NSString SharedTextUIElementsAttribute
	{
		get
		{
			if (_SharedTextUIElementsAttribute == null)
			{
				_SharedTextUIElementsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySharedTextUIElementsAttribute");
			}
			return _SharedTextUIElementsAttribute;
		}
	}

	[Field("NSAccessibilityShownMenuAttribute", "AppKit")]
	public static NSString ShownMenuAttribute
	{
		get
		{
			if (_ShownMenuAttribute == null)
			{
				_ShownMenuAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityShownMenuAttribute");
			}
			return _ShownMenuAttribute;
		}
	}

	[Field("NSAccessibilitySizeAttribute", "AppKit")]
	public static NSString SizeAttribute
	{
		get
		{
			if (_SizeAttribute == null)
			{
				_SizeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySizeAttribute");
			}
			return _SizeAttribute;
		}
	}

	[Field("NSAccessibilitySortDirectionAttribute", "AppKit")]
	public static NSString SortDirectionAttribute
	{
		get
		{
			if (_SortDirectionAttribute == null)
			{
				_SortDirectionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySortDirectionAttribute");
			}
			return _SortDirectionAttribute;
		}
	}

	[Field("NSAccessibilitySplittersAttribute", "AppKit")]
	public static NSString SplittersAttribute
	{
		get
		{
			if (_SplittersAttribute == null)
			{
				_SplittersAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySplittersAttribute");
			}
			return _SplittersAttribute;
		}
	}

	[Field("NSAccessibilityStrikethroughColorTextAttribute", "AppKit")]
	public static NSString StrikethroughColorTextAttribute
	{
		get
		{
			if (_StrikethroughColorTextAttribute == null)
			{
				_StrikethroughColorTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityStrikethroughColorTextAttribute");
			}
			return _StrikethroughColorTextAttribute;
		}
	}

	[Field("NSAccessibilityStrikethroughTextAttribute", "AppKit")]
	public static NSString StrikethroughTextAttribute
	{
		get
		{
			if (_StrikethroughTextAttribute == null)
			{
				_StrikethroughTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityStrikethroughTextAttribute");
			}
			return _StrikethroughTextAttribute;
		}
	}

	[Field("NSAccessibilityStringForRangeParameterizedAttribute", "AppKit")]
	public static NSString StringForRangeParameterizeAttribute
	{
		get
		{
			if (_StringForRangeParameterizeAttribute == null)
			{
				_StringForRangeParameterizeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityStringForRangeParameterizedAttribute");
			}
			return _StringForRangeParameterizeAttribute;
		}
	}

	[Field("NSAccessibilityStyleRangeForIndexParameterizedAttribute", "AppKit")]
	public static NSString StyleRangeForIndexParameterizedAttribute
	{
		get
		{
			if (_StyleRangeForIndexParameterizedAttribute == null)
			{
				_StyleRangeForIndexParameterizedAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityStyleRangeForIndexParameterizedAttribute");
			}
			return _StyleRangeForIndexParameterizedAttribute;
		}
	}

	[Field("NSAccessibilitySubroleAttribute", "AppKit")]
	public static NSString SubroleAttribute
	{
		get
		{
			if (_SubroleAttribute == null)
			{
				_SubroleAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySubroleAttribute");
			}
			return _SubroleAttribute;
		}
	}

	[Field("NSAccessibilitySuperscriptTextAttribute", "AppKit")]
	public static NSString SuperscriptTextAttribute
	{
		get
		{
			if (_SuperscriptTextAttribute == null)
			{
				_SuperscriptTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySuperscriptTextAttribute");
			}
			return _SuperscriptTextAttribute;
		}
	}

	[Field("NSAccessibilityTabsAttribute", "AppKit")]
	public static NSString TabsAttribute
	{
		get
		{
			if (_TabsAttribute == null)
			{
				_TabsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTabsAttribute");
			}
			return _TabsAttribute;
		}
	}

	[Field("NSAccessibilityTextAlignmentAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString TextAlignmentAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_TextAlignmentAttribute == null)
			{
				_TextAlignmentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTextAlignmentAttribute");
			}
			return _TextAlignmentAttribute;
		}
	}

	[Field("NSAccessibilityTitleAttribute", "AppKit")]
	public static NSString TitleAttribute
	{
		get
		{
			if (_TitleAttribute == null)
			{
				_TitleAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTitleAttribute");
			}
			return _TitleAttribute;
		}
	}

	[Field("NSAccessibilityTitleUIElementAttribute", "AppKit")]
	public static NSString TitleUIAttribute
	{
		get
		{
			if (_TitleUIAttribute == null)
			{
				_TitleUIAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTitleUIElementAttribute");
			}
			return _TitleUIAttribute;
		}
	}

	[Field("NSAccessibilityToolbarButtonAttribute", "AppKit")]
	public static NSString ToolbarButtonAttribute
	{
		get
		{
			if (_ToolbarButtonAttribute == null)
			{
				_ToolbarButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityToolbarButtonAttribute");
			}
			return _ToolbarButtonAttribute;
		}
	}

	[Field("NSAccessibilityTopLevelUIElementAttribute", "AppKit")]
	public static NSString TopLevelUIElementAttribute
	{
		get
		{
			if (_TopLevelUIElementAttribute == null)
			{
				_TopLevelUIElementAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTopLevelUIElementAttribute");
			}
			return _TopLevelUIElementAttribute;
		}
	}

	[Field("NSAccessibilityTopLevelUIElementAttribute", "AppKit")]
	public static NSString ToplevelUIElementAttribute
	{
		get
		{
			if (_ToplevelUIElementAttribute == null)
			{
				_ToplevelUIElementAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTopLevelUIElementAttribute");
			}
			return _ToplevelUIElementAttribute;
		}
	}

	[Field("NSAccessibilityURLAttribute", "AppKit")]
	public static NSString URLAttribute
	{
		get
		{
			if (_URLAttribute == null)
			{
				_URLAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityURLAttribute");
			}
			return _URLAttribute;
		}
	}

	[Field("NSAccessibilityUnderlineColorTextAttribute", "AppKit")]
	public static NSString UnderlineColorTextAttribute
	{
		get
		{
			if (_UnderlineColorTextAttribute == null)
			{
				_UnderlineColorTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnderlineColorTextAttribute");
			}
			return _UnderlineColorTextAttribute;
		}
	}

	[Field("NSAccessibilityUnderlineTextAttribute", "AppKit")]
	public static NSString UnderlineTextAttribute
	{
		get
		{
			if (_UnderlineTextAttribute == null)
			{
				_UnderlineTextAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnderlineTextAttribute");
			}
			return _UnderlineTextAttribute;
		}
	}

	[Field("NSAccessibilityUnitDescriptionAttribute", "AppKit")]
	public static NSString UnitDescriptionAttribute
	{
		get
		{
			if (_UnitDescriptionAttribute == null)
			{
				_UnitDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnitDescriptionAttribute");
			}
			return _UnitDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityUnitsAttribute", "AppKit")]
	public static NSString UnitsAttribute
	{
		get
		{
			if (_UnitsAttribute == null)
			{
				_UnitsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnitsAttribute");
			}
			return _UnitsAttribute;
		}
	}

	[Field("NSAccessibilityValueAttribute", "AppKit")]
	public static NSString ValueAttribute
	{
		get
		{
			if (_ValueAttribute == null)
			{
				_ValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityValueAttribute");
			}
			return _ValueAttribute;
		}
	}

	[Field("NSAccessibilityValueDescriptionAttribute", "AppKit")]
	public static NSString ValueDescriptionAttribute
	{
		get
		{
			if (_ValueDescriptionAttribute == null)
			{
				_ValueDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityValueDescriptionAttribute");
			}
			return _ValueDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityVerticalScrollBarAttribute", "AppKit")]
	public static NSString VerticalScrollBarAttribute
	{
		get
		{
			if (_VerticalScrollBarAttribute == null)
			{
				_VerticalScrollBarAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVerticalScrollBarAttribute");
			}
			return _VerticalScrollBarAttribute;
		}
	}

	[Field("NSAccessibilityVerticalUnitDescriptionAttribute", "AppKit")]
	public static NSString VerticalUnitDescriptionAttribute
	{
		get
		{
			if (_VerticalUnitDescriptionAttribute == null)
			{
				_VerticalUnitDescriptionAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVerticalUnitDescriptionAttribute");
			}
			return _VerticalUnitDescriptionAttribute;
		}
	}

	[Field("NSAccessibilityVerticalUnitsAttribute", "AppKit")]
	public static NSString VerticalUnitsAttribute
	{
		get
		{
			if (_VerticalUnitsAttribute == null)
			{
				_VerticalUnitsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVerticalUnitsAttribute");
			}
			return _VerticalUnitsAttribute;
		}
	}

	[Field("NSAccessibilityVisibleCellsAttribute", "AppKit")]
	public static NSString VisibleCellsAttribute
	{
		get
		{
			if (_VisibleCellsAttribute == null)
			{
				_VisibleCellsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleCellsAttribute");
			}
			return _VisibleCellsAttribute;
		}
	}

	[Field("NSAccessibilityVisibleCharacterRangeAttribute", "AppKit")]
	public static NSString VisibleCharacterRangeAttribute
	{
		get
		{
			if (_VisibleCharacterRangeAttribute == null)
			{
				_VisibleCharacterRangeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleCharacterRangeAttribute");
			}
			return _VisibleCharacterRangeAttribute;
		}
	}

	[Field("NSAccessibilityVisibleChildrenAttribute", "AppKit")]
	public static NSString VisibleChildrenAttribute
	{
		get
		{
			if (_VisibleChildrenAttribute == null)
			{
				_VisibleChildrenAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleChildrenAttribute");
			}
			return _VisibleChildrenAttribute;
		}
	}

	[Field("NSAccessibilityVisibleColumnsAttribute", "AppKit")]
	public static NSString VisibleColumnsAttribute
	{
		get
		{
			if (_VisibleColumnsAttribute == null)
			{
				_VisibleColumnsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleColumnsAttribute");
			}
			return _VisibleColumnsAttribute;
		}
	}

	[Field("NSAccessibilityVisibleRowsAttribute", "AppKit")]
	public static NSString VisibleRowsAttribute
	{
		get
		{
			if (_VisibleRowsAttribute == null)
			{
				_VisibleRowsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityVisibleRowsAttribute");
			}
			return _VisibleRowsAttribute;
		}
	}

	[Field("NSAccessibilityWarningValueAttribute", "AppKit")]
	public static NSString WarningValueAttribute
	{
		get
		{
			if (_WarningValueAttribute == null)
			{
				_WarningValueAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWarningValueAttribute");
			}
			return _WarningValueAttribute;
		}
	}

	[Field("NSAccessibilityWindowAttribute", "AppKit")]
	public static NSString WindowAttribute
	{
		get
		{
			if (_WindowAttribute == null)
			{
				_WindowAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowAttribute");
			}
			return _WindowAttribute;
		}
	}

	[Field("NSAccessibilityWindowsAttribute", "AppKit")]
	public static NSString WindowsAttribute
	{
		get
		{
			if (_WindowsAttribute == null)
			{
				_WindowsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowsAttribute");
			}
			return _WindowsAttribute;
		}
	}

	[Field("NSAccessibilityZoomButtonAttribute", "AppKit")]
	public static NSString ZoomButtonAttribute
	{
		get
		{
			if (_ZoomButtonAttribute == null)
			{
				_ZoomButtonAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityZoomButtonAttribute");
			}
			return _ZoomButtonAttribute;
		}
	}
}

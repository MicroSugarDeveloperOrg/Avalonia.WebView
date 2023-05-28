using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public enum PdfAnnotationKey
{
	AppearanceDictionary,
	AppearanceState,
	Border,
	Color,
	Contents,
	Flags,
	Date,
	Name,
	Page,
	Rect,
	Subtype,
	Action,
	AdditionalActions,
	BorderStyle,
	DefaultAppearance,
	Destination,
	HighlightingMode,
	Inklist,
	InteriorColor,
	LinePoints,
	LineEndingStyles,
	IconName,
	Open,
	Parent,
	Popup,
	Quadding,
	QuadPoints,
	TextLabel,
	WidgetDownCaption,
	WidgetBorderColor,
	WidgetBackgroundColor,
	WidgetCaption,
	WidgetDefaultValue,
	WidgetFieldFlags,
	WidgetFieldType,
	WidgetAppearanceDictionary,
	WidgetMaxLen,
	WidgetOptions,
	WidgetRotation,
	WidgetRolloverCaption,
	WidgetTextLabelUI,
	WidgetValue
}

using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationKeyExtensions
{
	private static IntPtr[] values = new IntPtr[42];

	[Field("PDFAnnotationKeyAppearanceDictionary", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyAppearanceDictionary
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyAppearanceDictionary", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyAppearanceState", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyAppearanceState
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyAppearanceState", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyBorder", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyBorder
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyBorder", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyColor", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyColor
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyColor", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyContents", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyContents
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyContents", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyFlags", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyFlags
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyFlags", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyDate", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyDate
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyDate", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyName", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyName
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyName", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyPage", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyPage
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyPage", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyRect", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyRect
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyRect", storage);
			}
		}
	}

	[Field("PDFAnnotationKeySubtype", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeySubtype
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeySubtype", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyAction", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyAction
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyAction", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyAdditionalActions", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyAdditionalActions
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyAdditionalActions", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyBorderStyle", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyBorderStyle
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyBorderStyle", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyDefaultAppearance", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyDefaultAppearance
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyDefaultAppearance", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyDestination", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyDestination
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyDestination", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyHighlightingMode", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyHighlightingMode
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyHighlightingMode", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyInklist", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyInklist
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyInklist", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyInteriorColor", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyInteriorColor
	{
		get
		{
			fixed (IntPtr* storage = &values[18])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyInteriorColor", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyLinePoints", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyLinePoints
	{
		get
		{
			fixed (IntPtr* storage = &values[19])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyLinePoints", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyLineEndingStyles", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyLineEndingStyles
	{
		get
		{
			fixed (IntPtr* storage = &values[20])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyLineEndingStyles", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyIconName", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyIconName
	{
		get
		{
			fixed (IntPtr* storage = &values[21])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyIconName", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyOpen", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyOpen
	{
		get
		{
			fixed (IntPtr* storage = &values[22])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyOpen", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyParent", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyParent
	{
		get
		{
			fixed (IntPtr* storage = &values[23])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyParent", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyPopup", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyPopup
	{
		get
		{
			fixed (IntPtr* storage = &values[24])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyPopup", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyQuadding", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyQuadding
	{
		get
		{
			fixed (IntPtr* storage = &values[25])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyQuadding", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyQuadPoints", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyQuadPoints
	{
		get
		{
			fixed (IntPtr* storage = &values[26])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyQuadPoints", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyTextLabel", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyTextLabel
	{
		get
		{
			fixed (IntPtr* storage = &values[27])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyTextLabel", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetDownCaption", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetDownCaption
	{
		get
		{
			fixed (IntPtr* storage = &values[28])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetDownCaption", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetBorderColor", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetBorderColor
	{
		get
		{
			fixed (IntPtr* storage = &values[29])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetBorderColor", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetBackgroundColor", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetBackgroundColor
	{
		get
		{
			fixed (IntPtr* storage = &values[30])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetBackgroundColor", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetCaption", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetCaption
	{
		get
		{
			fixed (IntPtr* storage = &values[31])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetCaption", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetDefaultValue", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetDefaultValue
	{
		get
		{
			fixed (IntPtr* storage = &values[32])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetDefaultValue", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetFieldFlags", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetFieldFlags
	{
		get
		{
			fixed (IntPtr* storage = &values[33])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetFieldFlags", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetFieldType", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetFieldType
	{
		get
		{
			fixed (IntPtr* storage = &values[34])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetFieldType", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetAppearanceDictionary", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetAppearanceDictionary
	{
		get
		{
			fixed (IntPtr* storage = &values[35])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetAppearanceDictionary", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetMaxLen", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetMaxLen
	{
		get
		{
			fixed (IntPtr* storage = &values[36])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetMaxLen", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetOptions", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetOptions
	{
		get
		{
			fixed (IntPtr* storage = &values[37])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetOptions", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetRotation", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetRotation
	{
		get
		{
			fixed (IntPtr* storage = &values[38])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetRotation", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetRolloverCaption", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetRolloverCaption
	{
		get
		{
			fixed (IntPtr* storage = &values[39])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetRolloverCaption", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetTextLabelUI", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetTextLabelUI
	{
		get
		{
			fixed (IntPtr* storage = &values[40])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetTextLabelUI", storage);
			}
		}
	}

	[Field("PDFAnnotationKeyWidgetValue", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationKeyWidgetValue
	{
		get
		{
			fixed (IntPtr* storage = &values[41])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationKeyWidgetValue", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationKey self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationKeyAppearanceDictionary;
			break;
		case 1:
			ptr = PDFAnnotationKeyAppearanceState;
			break;
		case 2:
			ptr = PDFAnnotationKeyBorder;
			break;
		case 3:
			ptr = PDFAnnotationKeyColor;
			break;
		case 4:
			ptr = PDFAnnotationKeyContents;
			break;
		case 5:
			ptr = PDFAnnotationKeyFlags;
			break;
		case 6:
			ptr = PDFAnnotationKeyDate;
			break;
		case 7:
			ptr = PDFAnnotationKeyName;
			break;
		case 8:
			ptr = PDFAnnotationKeyPage;
			break;
		case 9:
			ptr = PDFAnnotationKeyRect;
			break;
		case 10:
			ptr = PDFAnnotationKeySubtype;
			break;
		case 11:
			ptr = PDFAnnotationKeyAction;
			break;
		case 12:
			ptr = PDFAnnotationKeyAdditionalActions;
			break;
		case 13:
			ptr = PDFAnnotationKeyBorderStyle;
			break;
		case 14:
			ptr = PDFAnnotationKeyDefaultAppearance;
			break;
		case 15:
			ptr = PDFAnnotationKeyDestination;
			break;
		case 16:
			ptr = PDFAnnotationKeyHighlightingMode;
			break;
		case 17:
			ptr = PDFAnnotationKeyInklist;
			break;
		case 18:
			ptr = PDFAnnotationKeyInteriorColor;
			break;
		case 19:
			ptr = PDFAnnotationKeyLinePoints;
			break;
		case 20:
			ptr = PDFAnnotationKeyLineEndingStyles;
			break;
		case 21:
			ptr = PDFAnnotationKeyIconName;
			break;
		case 22:
			ptr = PDFAnnotationKeyOpen;
			break;
		case 23:
			ptr = PDFAnnotationKeyParent;
			break;
		case 24:
			ptr = PDFAnnotationKeyPopup;
			break;
		case 25:
			ptr = PDFAnnotationKeyQuadding;
			break;
		case 26:
			ptr = PDFAnnotationKeyQuadPoints;
			break;
		case 27:
			ptr = PDFAnnotationKeyTextLabel;
			break;
		case 28:
			ptr = PDFAnnotationKeyWidgetDownCaption;
			break;
		case 29:
			ptr = PDFAnnotationKeyWidgetBorderColor;
			break;
		case 30:
			ptr = PDFAnnotationKeyWidgetBackgroundColor;
			break;
		case 31:
			ptr = PDFAnnotationKeyWidgetCaption;
			break;
		case 32:
			ptr = PDFAnnotationKeyWidgetDefaultValue;
			break;
		case 33:
			ptr = PDFAnnotationKeyWidgetFieldFlags;
			break;
		case 34:
			ptr = PDFAnnotationKeyWidgetFieldType;
			break;
		case 35:
			ptr = PDFAnnotationKeyWidgetAppearanceDictionary;
			break;
		case 36:
			ptr = PDFAnnotationKeyWidgetMaxLen;
			break;
		case 37:
			ptr = PDFAnnotationKeyWidgetOptions;
			break;
		case 38:
			ptr = PDFAnnotationKeyWidgetRotation;
			break;
		case 39:
			ptr = PDFAnnotationKeyWidgetRolloverCaption;
			break;
		case 40:
			ptr = PDFAnnotationKeyWidgetTextLabelUI;
			break;
		case 41:
			ptr = PDFAnnotationKeyWidgetValue;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationKey GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationKeyAppearanceDictionary))
		{
			return PdfAnnotationKey.AppearanceDictionary;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyAppearanceState))
		{
			return PdfAnnotationKey.AppearanceState;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyBorder))
		{
			return PdfAnnotationKey.Border;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyColor))
		{
			return PdfAnnotationKey.Color;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyContents))
		{
			return PdfAnnotationKey.Contents;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyFlags))
		{
			return PdfAnnotationKey.Flags;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyDate))
		{
			return PdfAnnotationKey.Date;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyName))
		{
			return PdfAnnotationKey.Name;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyPage))
		{
			return PdfAnnotationKey.Page;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyRect))
		{
			return PdfAnnotationKey.Rect;
		}
		if (constant.IsEqualTo(PDFAnnotationKeySubtype))
		{
			return PdfAnnotationKey.Subtype;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyAction))
		{
			return PdfAnnotationKey.Action;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyAdditionalActions))
		{
			return PdfAnnotationKey.AdditionalActions;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyBorderStyle))
		{
			return PdfAnnotationKey.BorderStyle;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyDefaultAppearance))
		{
			return PdfAnnotationKey.DefaultAppearance;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyDestination))
		{
			return PdfAnnotationKey.Destination;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyHighlightingMode))
		{
			return PdfAnnotationKey.HighlightingMode;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyInklist))
		{
			return PdfAnnotationKey.Inklist;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyInteriorColor))
		{
			return PdfAnnotationKey.InteriorColor;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyLinePoints))
		{
			return PdfAnnotationKey.LinePoints;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyLineEndingStyles))
		{
			return PdfAnnotationKey.LineEndingStyles;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyIconName))
		{
			return PdfAnnotationKey.IconName;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyOpen))
		{
			return PdfAnnotationKey.Open;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyParent))
		{
			return PdfAnnotationKey.Parent;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyPopup))
		{
			return PdfAnnotationKey.Popup;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyQuadding))
		{
			return PdfAnnotationKey.Quadding;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyQuadPoints))
		{
			return PdfAnnotationKey.QuadPoints;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyTextLabel))
		{
			return PdfAnnotationKey.TextLabel;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetDownCaption))
		{
			return PdfAnnotationKey.WidgetDownCaption;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetBorderColor))
		{
			return PdfAnnotationKey.WidgetBorderColor;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetBackgroundColor))
		{
			return PdfAnnotationKey.WidgetBackgroundColor;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetCaption))
		{
			return PdfAnnotationKey.WidgetCaption;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetDefaultValue))
		{
			return PdfAnnotationKey.WidgetDefaultValue;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetFieldFlags))
		{
			return PdfAnnotationKey.WidgetFieldFlags;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetFieldType))
		{
			return PdfAnnotationKey.WidgetFieldType;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetAppearanceDictionary))
		{
			return PdfAnnotationKey.WidgetAppearanceDictionary;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetMaxLen))
		{
			return PdfAnnotationKey.WidgetMaxLen;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetOptions))
		{
			return PdfAnnotationKey.WidgetOptions;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetRotation))
		{
			return PdfAnnotationKey.WidgetRotation;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetRolloverCaption))
		{
			return PdfAnnotationKey.WidgetRolloverCaption;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetTextLabelUI))
		{
			return PdfAnnotationKey.WidgetTextLabelUI;
		}
		if (constant.IsEqualTo(PDFAnnotationKeyWidgetValue))
		{
			return PdfAnnotationKey.WidgetValue;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

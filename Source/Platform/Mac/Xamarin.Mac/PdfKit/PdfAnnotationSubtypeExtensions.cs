using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationSubtypeExtensions
{
	private static IntPtr[] values = new IntPtr[13];

	[Field("PDFAnnotationSubtypeText", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeText
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeText", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeLink", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeLink
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeLink", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeFreeText", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeFreeText
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeFreeText", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeLine", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeLine
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeLine", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeSquare", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeSquare
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeSquare", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeCircle", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeCircle
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeCircle", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeHighlight", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeHighlight
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeHighlight", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeUnderline", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeUnderline
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeUnderline", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeStrikeOut", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeStrikeOut
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeStrikeOut", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeInk", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeInk
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeInk", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeStamp", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeStamp
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeStamp", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypePopup", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypePopup
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypePopup", storage);
			}
		}
	}

	[Field("PDFAnnotationSubtypeWidget", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationSubtypeWidget
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationSubtypeWidget", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationSubtype self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationSubtypeText;
			break;
		case 1:
			ptr = PDFAnnotationSubtypeLink;
			break;
		case 2:
			ptr = PDFAnnotationSubtypeFreeText;
			break;
		case 3:
			ptr = PDFAnnotationSubtypeLine;
			break;
		case 4:
			ptr = PDFAnnotationSubtypeSquare;
			break;
		case 5:
			ptr = PDFAnnotationSubtypeCircle;
			break;
		case 6:
			ptr = PDFAnnotationSubtypeHighlight;
			break;
		case 7:
			ptr = PDFAnnotationSubtypeUnderline;
			break;
		case 8:
			ptr = PDFAnnotationSubtypeStrikeOut;
			break;
		case 9:
			ptr = PDFAnnotationSubtypeInk;
			break;
		case 10:
			ptr = PDFAnnotationSubtypeStamp;
			break;
		case 11:
			ptr = PDFAnnotationSubtypePopup;
			break;
		case 12:
			ptr = PDFAnnotationSubtypeWidget;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationSubtype GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeText))
		{
			return PdfAnnotationSubtype.Text;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeLink))
		{
			return PdfAnnotationSubtype.Link;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeFreeText))
		{
			return PdfAnnotationSubtype.FreeText;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeLine))
		{
			return PdfAnnotationSubtype.Line;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeSquare))
		{
			return PdfAnnotationSubtype.Square;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeCircle))
		{
			return PdfAnnotationSubtype.Circle;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeHighlight))
		{
			return PdfAnnotationSubtype.Highlight;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeUnderline))
		{
			return PdfAnnotationSubtype.Underline;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeStrikeOut))
		{
			return PdfAnnotationSubtype.StrikeOut;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeInk))
		{
			return PdfAnnotationSubtype.Ink;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeStamp))
		{
			return PdfAnnotationSubtype.Stamp;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypePopup))
		{
			return PdfAnnotationSubtype.Popup;
		}
		if (constant.IsEqualTo(PDFAnnotationSubtypeWidget))
		{
			return PdfAnnotationSubtype.Widget;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

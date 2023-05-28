using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationTextIconTypeExtensions
{
	private static IntPtr[] values = new IntPtr[7];

	[Field("PDFAnnotationTextIconTypeComment", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeComment
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeComment", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeKey", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeKey
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeKey", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeNote", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeNote
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeNote", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeHelp", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeHelp
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeHelp", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeNewParagraph", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeNewParagraph
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeNewParagraph", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeParagraph", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeParagraph
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeParagraph", storage);
			}
		}
	}

	[Field("PDFAnnotationTextIconTypeInsert", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationTextIconTypeInsert
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeInsert", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationTextIconType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationTextIconTypeComment;
			break;
		case 1:
			ptr = PDFAnnotationTextIconTypeKey;
			break;
		case 2:
			ptr = PDFAnnotationTextIconTypeNote;
			break;
		case 3:
			ptr = PDFAnnotationTextIconTypeHelp;
			break;
		case 4:
			ptr = PDFAnnotationTextIconTypeNewParagraph;
			break;
		case 5:
			ptr = PDFAnnotationTextIconTypeParagraph;
			break;
		case 6:
			ptr = PDFAnnotationTextIconTypeInsert;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationTextIconType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeComment))
		{
			return PdfAnnotationTextIconType.Comment;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeKey))
		{
			return PdfAnnotationTextIconType.Key;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeNote))
		{
			return PdfAnnotationTextIconType.Note;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeHelp))
		{
			return PdfAnnotationTextIconType.Help;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeNewParagraph))
		{
			return PdfAnnotationTextIconType.NewParagraph;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeParagraph))
		{
			return PdfAnnotationTextIconType.Paragraph;
		}
		if (constant.IsEqualTo(PDFAnnotationTextIconTypeInsert))
		{
			return PdfAnnotationTextIconType.Insert;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

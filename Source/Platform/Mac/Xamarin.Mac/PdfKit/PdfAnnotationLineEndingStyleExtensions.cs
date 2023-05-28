using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationLineEndingStyleExtensions
{
	private static IntPtr[] values = new IntPtr[6];

	[Field("PDFAnnotationLineEndingStyleNone", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleNone
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleNone", storage);
			}
		}
	}

	[Field("PDFAnnotationLineEndingStyleSquare", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleSquare
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleSquare", storage);
			}
		}
	}

	[Field("PDFAnnotationLineEndingStyleCircle", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleCircle
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleCircle", storage);
			}
		}
	}

	[Field("PDFAnnotationLineEndingStyleDiamond", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleDiamond
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleDiamond", storage);
			}
		}
	}

	[Field("PDFAnnotationLineEndingStyleOpenArrow", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleOpenArrow
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleOpenArrow", storage);
			}
		}
	}

	[Field("PDFAnnotationLineEndingStyleClosedArrow", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationLineEndingStyleClosedArrow
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleClosedArrow", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationLineEndingStyle self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationLineEndingStyleNone;
			break;
		case 1:
			ptr = PDFAnnotationLineEndingStyleSquare;
			break;
		case 2:
			ptr = PDFAnnotationLineEndingStyleCircle;
			break;
		case 3:
			ptr = PDFAnnotationLineEndingStyleDiamond;
			break;
		case 4:
			ptr = PDFAnnotationLineEndingStyleOpenArrow;
			break;
		case 5:
			ptr = PDFAnnotationLineEndingStyleClosedArrow;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationLineEndingStyle GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleNone))
		{
			return PdfAnnotationLineEndingStyle.None;
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleSquare))
		{
			return PdfAnnotationLineEndingStyle.Square;
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleCircle))
		{
			return PdfAnnotationLineEndingStyle.Circle;
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleDiamond))
		{
			return PdfAnnotationLineEndingStyle.Diamond;
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleOpenArrow))
		{
			return PdfAnnotationLineEndingStyle.OpenArrow;
		}
		if (constant.IsEqualTo(PDFAnnotationLineEndingStyleClosedArrow))
		{
			return PdfAnnotationLineEndingStyle.ClosedArrow;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationHighlightingModeExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("PDFAnnotationHighlightingModeNone", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationHighlightingModeNone
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationHighlightingModeNone", storage);
			}
		}
	}

	[Field("PDFAnnotationHighlightingModeInvert", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationHighlightingModeInvert
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationHighlightingModeInvert", storage);
			}
		}
	}

	[Field("PDFAnnotationHighlightingModeOutline", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationHighlightingModeOutline
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationHighlightingModeOutline", storage);
			}
		}
	}

	[Field("PDFAnnotationHighlightingModePush", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationHighlightingModePush
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationHighlightingModePush", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationHighlightingMode self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationHighlightingModeNone;
			break;
		case 1:
			ptr = PDFAnnotationHighlightingModeInvert;
			break;
		case 2:
			ptr = PDFAnnotationHighlightingModeOutline;
			break;
		case 3:
			ptr = PDFAnnotationHighlightingModePush;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationHighlightingMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationHighlightingModeNone))
		{
			return PdfAnnotationHighlightingMode.None;
		}
		if (constant.IsEqualTo(PDFAnnotationHighlightingModeInvert))
		{
			return PdfAnnotationHighlightingMode.Invert;
		}
		if (constant.IsEqualTo(PDFAnnotationHighlightingModeOutline))
		{
			return PdfAnnotationHighlightingMode.Outline;
		}
		if (constant.IsEqualTo(PDFAnnotationHighlightingModePush))
		{
			return PdfAnnotationHighlightingMode.Push;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

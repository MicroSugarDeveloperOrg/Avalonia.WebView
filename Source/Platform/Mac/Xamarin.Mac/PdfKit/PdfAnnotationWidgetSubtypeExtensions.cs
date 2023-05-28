using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PdfAnnotationWidgetSubtypeExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("PDFAnnotationWidgetSubtypeButton", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationWidgetSubtypeButton
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeButton", storage);
			}
		}
	}

	[Field("PDFAnnotationWidgetSubtypeChoice", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationWidgetSubtypeChoice
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeChoice", storage);
			}
		}
	}

	[Field("PDFAnnotationWidgetSubtypeSignature", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationWidgetSubtypeSignature
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeSignature", storage);
			}
		}
	}

	[Field("PDFAnnotationWidgetSubtypeText", "Quartz")]
	internal unsafe static IntPtr PDFAnnotationWidgetSubtypeText
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeText", storage);
			}
		}
	}

	public static NSString? GetConstant(this PdfAnnotationWidgetSubtype self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PDFAnnotationWidgetSubtypeButton;
			break;
		case 1:
			ptr = PDFAnnotationWidgetSubtypeChoice;
			break;
		case 2:
			ptr = PDFAnnotationWidgetSubtypeSignature;
			break;
		case 3:
			ptr = PDFAnnotationWidgetSubtypeText;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PdfAnnotationWidgetSubtype GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PDFAnnotationWidgetSubtypeButton))
		{
			return PdfAnnotationWidgetSubtype.Button;
		}
		if (constant.IsEqualTo(PDFAnnotationWidgetSubtypeChoice))
		{
			return PdfAnnotationWidgetSubtype.Choice;
		}
		if (constant.IsEqualTo(PDFAnnotationWidgetSubtypeSignature))
		{
			return PdfAnnotationWidgetSubtype.Signature;
		}
		if (constant.IsEqualTo(PDFAnnotationWidgetSubtypeText))
		{
			return PdfAnnotationWidgetSubtype.Text;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

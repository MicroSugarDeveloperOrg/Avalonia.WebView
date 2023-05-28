using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public static class PdfBorderKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DashPatternKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LineWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StyleKey;

	[Field("PDFBorderKeyDashPattern", "Quartz")]
	public static NSString DashPatternKey
	{
		get
		{
			if (_DashPatternKey == null)
			{
				_DashPatternKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFBorderKeyDashPattern");
			}
			return _DashPatternKey;
		}
	}

	[Field("PDFBorderKeyLineWidth", "Quartz")]
	public static NSString LineWidthKey
	{
		get
		{
			if (_LineWidthKey == null)
			{
				_LineWidthKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFBorderKeyLineWidth");
			}
			return _LineWidthKey;
		}
	}

	[Field("PDFBorderKeyStyle", "Quartz")]
	public static NSString StyleKey
	{
		get
		{
			if (_StyleKey == null)
			{
				_StyleKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFBorderKeyStyle");
			}
			return _StyleKey;
		}
	}
}

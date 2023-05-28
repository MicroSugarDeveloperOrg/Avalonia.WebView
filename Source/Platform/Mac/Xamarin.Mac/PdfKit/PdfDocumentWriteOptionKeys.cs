using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
internal static class PdfDocumentWriteOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OwnerPasswordKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserPasswordKey;

	[Field("PDFDocumentOwnerPasswordOption", "Quartz")]
	public static NSString OwnerPasswordKey
	{
		get
		{
			if (_OwnerPasswordKey == null)
			{
				_OwnerPasswordKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentOwnerPasswordOption");
			}
			return _OwnerPasswordKey;
		}
	}

	[Field("PDFDocumentUserPasswordOption", "Quartz")]
	public static NSString UserPasswordKey
	{
		get
		{
			if (_UserPasswordKey == null)
			{
				_UserPasswordKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentUserPasswordOption");
			}
			return _UserPasswordKey;
		}
	}
}

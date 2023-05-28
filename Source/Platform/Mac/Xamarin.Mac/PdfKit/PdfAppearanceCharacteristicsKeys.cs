using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public static class PdfAppearanceCharacteristicsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BorderColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CaptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownCaptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RolloverCaptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotationKey;

	[Field("PDFAppearanceCharacteristicsKeyBackgroundColor", "Quartz")]
	public static NSString BackgroundColorKey
	{
		get
		{
			if (_BackgroundColorKey == null)
			{
				_BackgroundColorKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyBackgroundColor");
			}
			return _BackgroundColorKey;
		}
	}

	[Field("PDFAppearanceCharacteristicsKeyBorderColor", "Quartz")]
	public static NSString BorderColorKey
	{
		get
		{
			if (_BorderColorKey == null)
			{
				_BorderColorKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyBorderColor");
			}
			return _BorderColorKey;
		}
	}

	[Field("PDFAppearanceCharacteristicsKeyCaption", "Quartz")]
	public static NSString CaptionKey
	{
		get
		{
			if (_CaptionKey == null)
			{
				_CaptionKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyCaption");
			}
			return _CaptionKey;
		}
	}

	[Field("PDFAppearanceCharacteristicsKeyDownCaption", "Quartz")]
	public static NSString DownCaptionKey
	{
		get
		{
			if (_DownCaptionKey == null)
			{
				_DownCaptionKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyDownCaption");
			}
			return _DownCaptionKey;
		}
	}

	[Field("PDFAppearanceCharacteristicsKeyRolloverCaption", "Quartz")]
	public static NSString RolloverCaptionKey
	{
		get
		{
			if (_RolloverCaptionKey == null)
			{
				_RolloverCaptionKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyRolloverCaption");
			}
			return _RolloverCaptionKey;
		}
	}

	[Field("PDFAppearanceCharacteristicsKeyRotation", "Quartz")]
	public static NSString RotationKey
	{
		get
		{
			if (_RotationKey == null)
			{
				_RotationKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFAppearanceCharacteristicsKeyRotation");
			}
			return _RotationKey;
		}
	}
}

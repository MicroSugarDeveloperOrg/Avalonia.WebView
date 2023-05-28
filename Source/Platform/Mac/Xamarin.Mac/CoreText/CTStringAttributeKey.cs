using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTStringAttributeKey
{
	public static readonly NSString Font;

	public static readonly NSString ForegroundColorFromContext;

	public static readonly NSString KerningAdjustment;

	public static readonly NSString LigatureFormation;

	public static readonly NSString ForegroundColor;

	public static readonly NSString BackgroundColor;

	public static readonly NSString ParagraphStyle;

	public static readonly NSString StrokeWidth;

	public static readonly NSString StrokeColor;

	public static readonly NSString UnderlineStyle;

	public static readonly NSString Superscript;

	public static readonly NSString UnderlineColor;

	public static readonly NSString VerticalForms;

	public static readonly NSString HorizontalInVerticalForms;

	public static readonly NSString GlyphInfo;

	public static readonly NSString CharacterShape;

	public static readonly NSString RunDelegate;

	internal static readonly NSString BaselineClass;

	internal static readonly NSString BaselineInfo;

	internal static readonly NSString BaselineReferenceInfo;

	internal static readonly NSString BaselineOffset;

	internal static readonly NSString WritingDirection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TrackingAttributeName;

	[Field("kCTTrackingAttributeName", "CoreText")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString TrackingAttributeName
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TrackingAttributeName == null)
			{
				_TrackingAttributeName = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTTrackingAttributeName");
			}
			return _TrackingAttributeName;
		}
	}

	static CTStringAttributeKey()
	{
		IntPtr handle = Libraries.CoreText.Handle;
		Font = Dlfcn.GetStringConstant(handle, "kCTFontAttributeName");
		ForegroundColorFromContext = Dlfcn.GetStringConstant(handle, "kCTForegroundColorFromContextAttributeName");
		KerningAdjustment = Dlfcn.GetStringConstant(handle, "kCTKernAttributeName");
		LigatureFormation = Dlfcn.GetStringConstant(handle, "kCTLigatureAttributeName");
		ForegroundColor = Dlfcn.GetStringConstant(handle, "kCTForegroundColorAttributeName");
		BackgroundColor = Dlfcn.GetStringConstant(handle, "kCTBackgroundColorAttributeName");
		ParagraphStyle = Dlfcn.GetStringConstant(handle, "kCTParagraphStyleAttributeName");
		StrokeWidth = Dlfcn.GetStringConstant(handle, "kCTStrokeWidthAttributeName");
		StrokeColor = Dlfcn.GetStringConstant(handle, "kCTStrokeColorAttributeName");
		UnderlineStyle = Dlfcn.GetStringConstant(handle, "kCTUnderlineStyleAttributeName");
		Superscript = Dlfcn.GetStringConstant(handle, "kCTSuperscriptAttributeName");
		UnderlineColor = Dlfcn.GetStringConstant(handle, "kCTUnderlineColorAttributeName");
		VerticalForms = Dlfcn.GetStringConstant(handle, "kCTVerticalFormsAttributeName");
		HorizontalInVerticalForms = Dlfcn.GetStringConstant(handle, "kCTHorizontalInVerticalFormsAttributeName");
		GlyphInfo = Dlfcn.GetStringConstant(handle, "kCTGlyphInfoAttributeName");
		CharacterShape = Dlfcn.GetStringConstant(handle, "kCTCharacterShapeAttributeName");
		RunDelegate = Dlfcn.GetStringConstant(handle, "kCTRunDelegateAttributeName");
		BaselineOffset = Dlfcn.GetStringConstant(handle, "kCTBaselineOffsetAttributeName");
	}
}

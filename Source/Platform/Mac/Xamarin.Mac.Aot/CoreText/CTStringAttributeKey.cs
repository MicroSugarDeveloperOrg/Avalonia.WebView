using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTStringAttributeKey
{
	public static readonly NSString Font;

	public static readonly NSString ForegroundColorFromContext;

	public static readonly NSString KerningAdjustment;

	public static readonly NSString LigatureFormation;

	public static readonly NSString ForegroundColor;

	public static readonly NSString ParagraphStyle;

	public static readonly NSString StrokeWidth;

	public static readonly NSString StrokeColor;

	public static readonly NSString UnderlineStyle;

	public static readonly NSString Superscript;

	public static readonly NSString UnderlineColor;

	public static readonly NSString VerticalForms;

	public static readonly NSString GlyphInfo;

	public static readonly NSString CharacterShape;

	public static readonly NSString RunDelegate;

	internal static readonly NSString BaselineClass;

	internal static readonly NSString BaselineInfo;

	internal static readonly NSString BaselineReferenceInfo;

	internal static readonly NSString WritingDirection;

	static CTStringAttributeKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Font = Dlfcn.GetStringConstant(intPtr, "kCTFontAttributeName");
			ForegroundColorFromContext = Dlfcn.GetStringConstant(intPtr, "kCTForegroundColorFromContextAttributeName");
			KerningAdjustment = Dlfcn.GetStringConstant(intPtr, "kCTKernAttributeName");
			LigatureFormation = Dlfcn.GetStringConstant(intPtr, "kCTLigatureAttributeName");
			ForegroundColor = Dlfcn.GetStringConstant(intPtr, "kCTForegroundColorAttributeName");
			ParagraphStyle = Dlfcn.GetStringConstant(intPtr, "kCTParagraphStyleAttributeName");
			StrokeWidth = Dlfcn.GetStringConstant(intPtr, "kCTStrokeWidthAttributeName");
			StrokeColor = Dlfcn.GetStringConstant(intPtr, "kCTStrokeColorAttributeName");
			UnderlineStyle = Dlfcn.GetStringConstant(intPtr, "kCTUnderlineStyleAttributeName");
			Superscript = Dlfcn.GetStringConstant(intPtr, "kCTSuperscriptAttributeName");
			UnderlineColor = Dlfcn.GetStringConstant(intPtr, "kCTUnderlineColorAttributeName");
			VerticalForms = Dlfcn.GetStringConstant(intPtr, "kCTVerticalFormsAttributeName");
			GlyphInfo = Dlfcn.GetStringConstant(intPtr, "kCTGlyphInfoAttributeName");
			CharacterShape = Dlfcn.GetStringConstant(intPtr, "kCTCharacterShapeAttributeName");
			RunDelegate = Dlfcn.GetStringConstant(intPtr, "kCTRunDelegateAttributeName");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

internal static class CTFontNameKeyId
{
	public static readonly NSString Copyright;

	public static readonly NSString Family;

	public static readonly NSString SubFamily;

	public static readonly NSString Style;

	public static readonly NSString Unique;

	public static readonly NSString Full;

	public static readonly NSString Version;

	public static readonly NSString PostScript;

	public static readonly NSString Trademark;

	public static readonly NSString Manufacturer;

	public static readonly NSString Designer;

	public static readonly NSString Description;

	public static readonly NSString VendorUrl;

	public static readonly NSString DesignerUrl;

	public static readonly NSString License;

	public static readonly NSString LicenseUrl;

	public static readonly NSString SampleText;

	public static readonly NSString PostscriptCid;

	static CTFontNameKeyId()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Copyright = Dlfcn.GetStringConstant(intPtr, "kCTFontCopyrightNameKey");
			Family = Dlfcn.GetStringConstant(intPtr, "kCTFontFamilyNameKey");
			SubFamily = Dlfcn.GetStringConstant(intPtr, "kCTFontSubFamilyNameKey");
			Style = Dlfcn.GetStringConstant(intPtr, "kCTFontStyleNameKey");
			Unique = Dlfcn.GetStringConstant(intPtr, "kCTFontUniqueNameKey");
			Full = Dlfcn.GetStringConstant(intPtr, "kCTFontFullNameKey");
			Version = Dlfcn.GetStringConstant(intPtr, "kCTFontVersionNameKey");
			PostScript = Dlfcn.GetStringConstant(intPtr, "kCTFontPostScriptNameKey");
			Trademark = Dlfcn.GetStringConstant(intPtr, "kCTFontTrademarkNameKey");
			Manufacturer = Dlfcn.GetStringConstant(intPtr, "kCTFontManufacturerNameKey");
			Designer = Dlfcn.GetStringConstant(intPtr, "kCTFontDesignerNameKey");
			Description = Dlfcn.GetStringConstant(intPtr, "kCTFontDescriptionNameKey");
			VendorUrl = Dlfcn.GetStringConstant(intPtr, "kCTFontVendorURLNameKey");
			DesignerUrl = Dlfcn.GetStringConstant(intPtr, "kCTFontDesignerURLNameKey");
			License = Dlfcn.GetStringConstant(intPtr, "kCTFontLicenseNameKey");
			LicenseUrl = Dlfcn.GetStringConstant(intPtr, "kCTFontLicenseURLNameKey");
			SampleText = Dlfcn.GetStringConstant(intPtr, "kCTFontSampleTextNameKey");
			PostscriptCid = Dlfcn.GetStringConstant(intPtr, "kCTFontPostScriptCIDNameKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	public static NSString ToId(CTFontNameKey key)
	{
		return key switch
		{
			CTFontNameKey.Copyright => Copyright, 
			CTFontNameKey.Family => Family, 
			CTFontNameKey.SubFamily => SubFamily, 
			CTFontNameKey.Style => Style, 
			CTFontNameKey.Unique => Unique, 
			CTFontNameKey.Full => Full, 
			CTFontNameKey.Version => Version, 
			CTFontNameKey.PostScript => PostScript, 
			CTFontNameKey.Trademark => Trademark, 
			CTFontNameKey.Manufacturer => Manufacturer, 
			CTFontNameKey.Designer => Designer, 
			CTFontNameKey.Description => Description, 
			CTFontNameKey.VendorUrl => VendorUrl, 
			CTFontNameKey.DesignerUrl => DesignerUrl, 
			CTFontNameKey.License => License, 
			CTFontNameKey.LicenseUrl => LicenseUrl, 
			CTFontNameKey.SampleText => SampleText, 
			CTFontNameKey.PostscriptCid => PostscriptCid, 
			_ => throw new NotSupportedException("Invalid CTFontNameKey value: " + key), 
		};
	}

	public static CTFontNameKey ToFontNameKey(NSString key)
	{
		if (key == Copyright)
		{
			return CTFontNameKey.Copyright;
		}
		if (key == Family)
		{
			return CTFontNameKey.Family;
		}
		if (key == SubFamily)
		{
			return CTFontNameKey.SubFamily;
		}
		if (key == Style)
		{
			return CTFontNameKey.Style;
		}
		if (key == Unique)
		{
			return CTFontNameKey.Unique;
		}
		if (key == Full)
		{
			return CTFontNameKey.Full;
		}
		if (key == Version)
		{
			return CTFontNameKey.Version;
		}
		if (key == PostScript)
		{
			return CTFontNameKey.PostScript;
		}
		if (key == Trademark)
		{
			return CTFontNameKey.Trademark;
		}
		if (key == Manufacturer)
		{
			return CTFontNameKey.Manufacturer;
		}
		if (key == Designer)
		{
			return CTFontNameKey.Designer;
		}
		if (key == Description)
		{
			return CTFontNameKey.Description;
		}
		if (key == VendorUrl)
		{
			return CTFontNameKey.VendorUrl;
		}
		if (key == DesignerUrl)
		{
			return CTFontNameKey.DesignerUrl;
		}
		if (key == License)
		{
			return CTFontNameKey.License;
		}
		if (key == LicenseUrl)
		{
			return CTFontNameKey.LicenseUrl;
		}
		if (key == SampleText)
		{
			return CTFontNameKey.SampleText;
		}
		if (key == PostscriptCid)
		{
			return CTFontNameKey.PostscriptCid;
		}
		throw new NotSupportedException("Invalid CTFontNameKeyId value: " + key);
	}
}

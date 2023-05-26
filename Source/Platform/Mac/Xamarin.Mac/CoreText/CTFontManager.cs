using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(4, 1)]
public class CTFontManager
{
	public static readonly NSString ErrorDomain;

	public static readonly NSString ErrorFontUrlsKey;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerIsSupportedFont(IntPtr url);

	public static bool IsFontSupported(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return CTFontManagerIsSupportedFont(url.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterFontsForURL(IntPtr fontUrl, CTFontManagerScope scope, IntPtr error);

	public static NSError RegisterFontsForUrl(NSUrl fontUrl, CTFontManagerScope scope)
	{
		if (fontUrl == null)
		{
			throw new ArgumentNullException("fontUrl");
		}
		NSError nSError = new NSError(ErrorDomain, 0);
		if (CTFontManagerRegisterFontsForURL(fontUrl.Handle, scope, nSError.Handle))
		{
			return null;
		}
		return nSError;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterFontsForURLs(IntPtr arrayRef, CTFontManagerScope scope, IntPtr error);

	public static NSError[] RegisterFontsForUrl(NSUrl[] fontUrls, CTFontManagerScope scope)
	{
		if (fontUrls == null)
		{
			throw new ArgumentNullException("fontUrls");
		}
		for (int i = 0; i < fontUrls.Length; i++)
		{
			if (fontUrls[i] == null)
			{
				throw new ArgumentException("contains a null entry", "fontUrls");
			}
		}
		NSArray nSArray = NSArray.FromNSObjects(fontUrls);
		NSError[] array = new NSError[fontUrls.Length];
		for (int j = 0; j < fontUrls.Length; j++)
		{
			array[j] = new NSError(ErrorDomain, 0);
		}
		NSArray nSArray2 = NSArray.FromNSObjects(array);
		if (CTFontManagerRegisterFontsForURLs(nSArray.Handle, scope, nSArray2.Handle))
		{
			return null;
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterFontsForURL(IntPtr fotUrl, CTFontManagerScope scope, IntPtr error);

	public static NSError UnregisterFontsForUrl(NSUrl fontUrl, CTFontManagerScope scope)
	{
		if (fontUrl == null)
		{
			throw new ArgumentNullException("fontUrl");
		}
		NSError nSError = new NSError(ErrorDomain, 0);
		if (CTFontManagerUnregisterFontsForURLs(fontUrl.Handle, scope, nSError.Handle))
		{
			return null;
		}
		return nSError;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterFontsForURLs(IntPtr arrayRef, CTFontManagerScope scope, IntPtr error);

	public static NSError[] UnregisterFontsForUrl(NSUrl[] fontUrls, CTFontManagerScope scope)
	{
		if (fontUrls == null)
		{
			throw new ArgumentNullException("fontUrls");
		}
		for (int i = 0; i < fontUrls.Length; i++)
		{
			if (fontUrls[i] == null)
			{
				throw new ArgumentException("contains a null entry", "fontUrls");
			}
		}
		NSArray nSArray = NSArray.FromNSObjects(fontUrls);
		NSError[] array = new NSError[fontUrls.Length];
		for (int j = 0; j < fontUrls.Length; j++)
		{
			array[j] = new NSError(ErrorDomain, 0);
		}
		NSArray nSArray2 = NSArray.FromNSObjects(array);
		if (CTFontManagerUnregisterFontsForURLs(nSArray.Handle, scope, nSArray2.Handle))
		{
			return null;
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterGraphicsFont(IntPtr cgfont, out IntPtr error);

	public static bool RegisterGraphicsFont(CGFont font, out NSError error)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		IntPtr error2;
		bool num = CTFontManagerRegisterGraphicsFont(font.Handle, out error2);
		if (num)
		{
			error = null;
			return num;
		}
		error = new NSError(error2);
		return num;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterGraphicsFont(IntPtr cgfont, out IntPtr error);

	public static bool UnregisterGraphicsFont(CGFont font, out NSError error)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		IntPtr error2;
		bool num = CTFontManagerUnregisterGraphicsFont(font.Handle, out error2);
		if (num)
		{
			error = null;
			return num;
		}
		error = new NSError(error2);
		return num;
	}

	static CTFontManager()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			ErrorDomain = Dlfcn.GetStringConstant(intPtr, "kCTFontManagerErrorDomain");
			ErrorFontUrlsKey = Dlfcn.GetStringConstant(intPtr, "kCTFontManagerErrorFontURLsKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}

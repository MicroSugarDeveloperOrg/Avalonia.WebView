using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGFont : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int NumberOfGlyphs => CGFontGetNumberOfGlyphs(handle);

	public int UnitsPerEm => CGFontGetUnitsPerEm(handle);

	public string PostScriptName
	{
		get
		{
			using CFString cFString = new CFString(CGFontCopyPostScriptName(handle), owns: true);
			return cFString;
		}
	}

	public string FullName
	{
		get
		{
			using CFString cFString = new CFString(CGFontCopyFullName(handle), owns: true);
			return cFString;
		}
	}

	public int Ascent => CGFontGetAscent(handle);

	public int Descent => CGFontGetDescent(handle);

	public int Leading => CGFontGetLeading(handle);

	public int CapHeight => CGFontGetCapHeight(handle);

	public int XHeight => CGFontGetXHeight(handle);

	public CGRect FontBBox => CGFontGetFontBBox(handle);

	public double ItalicAngle => CGFontGetItalicAngle(handle);

	public double StemV => CGFontGetStemV(handle);

	[Preserve(Conditional = true)]
	internal CGFont(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CGFontRetain(handle);
		}
	}

	~CGFont()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontRetain(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGFontRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGFontRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCreateWithDataProvider(IntPtr provider);

	public static CGFont CreateFromProvider(CGDataProvider provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		return new CGFont(CGFontCreateWithDataProvider(provider.Handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCreateWithFontName(IntPtr CFStringRef_name);

	public static CGFont CreateWithFontName(string name)
	{
		using CFString cFString = (CFString)name;
		return new CGFont(CGFontCreateWithFontName(cFString.handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetNumberOfGlyphs(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetUnitsPerEm(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCopyPostScriptName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCopyFullName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetAscent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetDescent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetLeading(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetCapHeight(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGFontGetXHeight(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGFontGetFontBBox(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGFontGetItalicAngle(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGFontGetStemV(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern ushort CGFontGetGlyphWithGlyphName(IntPtr font, IntPtr CFStringRef_name);

	public ushort GetGlyphWithGlyphName(string s)
	{
		using CFString cFString = new CFString(s);
		return CGFontGetGlyphWithGlyphName(handle, cFString.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCopyGlyphNameForGlyph(IntPtr font, ushort glyph);

	public string GlyphNameForGlyph(ushort glyph)
	{
		using CFString cFString = new CFString(CGFontCopyGlyphNameForGlyph(handle, glyph), owns: true);
		return cFString;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CGFontGetTypeID")]
	public static extern int GetTypeID();
}

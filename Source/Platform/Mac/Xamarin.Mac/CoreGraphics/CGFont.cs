using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreText;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGFont : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public nint NumberOfGlyphs => CGFontGetNumberOfGlyphs(handle);

	public int UnitsPerEm => CGFontGetUnitsPerEm(handle);

	public string PostScriptName => CFString.FetchString(CGFontCopyPostScriptName(handle), releaseHandle: true);

	public string FullName => CFString.FetchString(CGFontCopyFullName(handle), releaseHandle: true);

	public int Ascent => CGFontGetAscent(handle);

	public int Descent => CGFontGetDescent(handle);

	public int Leading => CGFontGetLeading(handle);

	public int CapHeight => CGFontGetCapHeight(handle);

	public int XHeight => CGFontGetXHeight(handle);

	public CGRect FontBBox => CGFontGetFontBBox(handle);

	public nfloat ItalicAngle => CGFontGetItalicAngle(handle);

	public nfloat StemV => CGFontGetStemV(handle);

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
	private static extern void CGFontRelease(IntPtr font);

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
			return null;
		}
		return new CGFont(CGFontCreateWithDataProvider(provider.Handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCreateWithFontName(IntPtr name);

	public static CGFont CreateWithFontName(string name)
	{
		if (name == null)
		{
			return null;
		}
		using CFString cFString = (CFString)name;
		return new CGFont(CGFontCreateWithFontName(cFString.Handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGFontGetNumberOfGlyphs(IntPtr font);

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
	private static extern nfloat CGFontGetItalicAngle(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGFontGetStemV(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern ushort CGFontGetGlyphWithGlyphName(IntPtr font, IntPtr name);

	public ushort GetGlyphWithGlyphName(string s)
	{
		using CFString cFString = new CFString(s);
		return CGFontGetGlyphWithGlyphName(handle, cFString.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFontCopyGlyphNameForGlyph(IntPtr font, ushort glyph);

	public string GlyphNameForGlyph(ushort glyph)
	{
		return CFString.FetchString(CGFontCopyGlyphNameForGlyph(handle, glyph), releaseHandle: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private unsafe static extern IntPtr CTFontCreateWithGraphicsFont(IntPtr graphicsFont, nfloat size, CGAffineTransform* matrix, IntPtr attributes);

	public unsafe CTFont ToCTFont(nfloat size)
	{
		return new CTFont(CTFontCreateWithGraphicsFont(handle, size, null, IntPtr.Zero), owns: true);
	}

	public unsafe CTFont ToCTFont(nfloat size, CGAffineTransform matrix)
	{
		return new CTFont(CTFontCreateWithGraphicsFont(handle, size, &matrix, IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CGFontGetTypeID")]
	public static extern nint GetTypeID();
}

using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFont : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public double Size => CTFontGetSize(handle);

	public CGAffineTransform Matrix => CTFontGetMatrix(handle);

	public CTFontSymbolicTraits SymbolicTraits => CTFontGetSymbolicTraits(handle);

	public string PostScriptName => GetStringAndRelease(CTFontCopyPostScriptName(handle));

	public string FamilyName => GetStringAndRelease(CTFontCopyFamilyName(handle));

	public string FullName => GetStringAndRelease(CTFontCopyFullName(handle));

	public string DisplayName => GetStringAndRelease(CTFontCopyDisplayName(handle));

	public NSCharacterSet CharacterSet
	{
		get
		{
			NSCharacterSet nSCharacterSet = (NSCharacterSet)Runtime.GetNSObject(CTFontCopyCharacterSet(handle));
			if (nSCharacterSet == null)
			{
				return null;
			}
			nSCharacterSet.Release();
			return nSCharacterSet;
		}
	}

	public uint StringEncoding => CTFontGetStringEncoding(handle);

	public double AscentMetric => CTFontGetAscent(handle);

	public double DescentMetric => CTFontGetDescent(handle);

	public double LeadingMetric => CTFontGetLeading(handle);

	public uint UnitsPerEmMetric => CTFontGetUnitsPerEm(handle);

	public int GlyphCount => CTFontGetGlyphCount(handle);

	public CGRect BoundingBox => CTFontGetBoundingBox(handle);

	public double UnderlinePosition => CTFontGetUnderlinePosition(handle);

	public double UnderlineThickness => CTFontGetUnderlineThickness(handle);

	public double SlantAngle => CTFontGetSlantAngle(handle);

	public double CapHeightMetric => CTFontGetCapHeight(handle);

	public double XHeightMetric => CTFontGetXHeight(handle);

	internal CTFont(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal CTFont(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			GC.SuppressFinalize(this);
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTFont()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithName(IntPtr name, double size, IntPtr matrix);

	public CTFont(string name, double size)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (NSString nSString = new NSString(name))
		{
			handle = CTFontCreateWithName(nSString.Handle, size, IntPtr.Zero);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithName(IntPtr name, double size, ref CGAffineTransform matrix);

	public CTFont(string name, double size, ref CGAffineTransform matrix)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontCreateWithName(cFString.Handle, size, ref matrix);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithFontDescriptor(IntPtr descriptor, double size, IntPtr matrix);

	public CTFont(CTFontDescriptor descriptor, double size)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptor(descriptor.Handle, size, IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithFontDescriptor(IntPtr descriptor, double size, ref CGAffineTransform matrix);

	public CTFont(CTFontDescriptor descriptor, double size, ref CGAffineTransform matrix)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptor(descriptor.Handle, size, ref matrix);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithNameAndOptions(IntPtr name, double size, IntPtr matrix, CTFontOptions options);

	public CTFont(string name, double size, CTFontOptions options)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontCreateWithNameAndOptions(cFString.Handle, size, IntPtr.Zero, options);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithNameAndOptions(IntPtr name, double size, ref CGAffineTransform matrix, CTFontOptions options);

	public CTFont(string name, double size, ref CGAffineTransform matrix, CTFontOptions options)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontCreateWithNameAndOptions(cFString.Handle, size, ref matrix, options);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithFontDescriptorAndOptions(IntPtr descriptor, double size, IntPtr matrix, CTFontOptions options);

	public CTFont(CTFontDescriptor descriptor, double size, CTFontOptions options)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptorAndOptions(descriptor.Handle, size, IntPtr.Zero, options);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithFontDescriptorAndOptions(IntPtr descriptor, double size, ref CGAffineTransform matrix, CTFontOptions options);

	public CTFont(CTFontDescriptor descriptor, double size, CTFontOptions options, ref CGAffineTransform matrix)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptorAndOptions(descriptor.Handle, size, ref matrix, options);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithGraphicsFont(IntPtr cgfontRef, double size, ref CGAffineTransform affine, IntPtr attrs);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CTFontCreateWithGraphicsFont")]
	private static extern IntPtr CTFontCreateWithGraphicsFont2(IntPtr cgfontRef, double size, IntPtr affine, IntPtr attrs);

	public CTFont(CGFont font, double size, CGAffineTransform transform, CTFontDescriptor descriptor)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		handle = CTFontCreateWithGraphicsFont(font.Handle, size, ref transform, descriptor?.Handle ?? IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	public CTFont(CGFont font, double size, CTFontDescriptor descriptor)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		handle = CTFontCreateWithGraphicsFont2(font.Handle, size, IntPtr.Zero, descriptor?.Handle ?? IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	public CTFont(CGFont font, double size, CGAffineTransform transform)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		handle = CTFontCreateWithGraphicsFont(font.Handle, size, ref transform, IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateUIFontForLanguage(CTFontUIFontType uiType, double size, IntPtr language);

	public CTFont(CTFontUIFontType uiType, double size, string language)
	{
		if (language == null)
		{
			throw ConstructorError.ArgumentNull(this, "language");
		}
		using (CFString cFString = (CFString)language)
		{
			handle = CTFontCreateUIFontForLanguage(uiType, size, cFString.Handle);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithAttributes(IntPtr font, double size, IntPtr matrix, IntPtr attributues);

	public CTFont WithAttributes(double size, CTFontDescriptor attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return CreateFont(CTFontCreateCopyWithAttributes(handle, size, IntPtr.Zero, attributes.Handle));
	}

	private static CTFont CreateFont(IntPtr h)
	{
		if (h == IntPtr.Zero)
		{
			return null;
		}
		return new CTFont(h, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithAttributes(IntPtr font, double size, ref CGAffineTransform matrix, IntPtr attributues);

	public CTFont WithAttributes(double size, CTFontDescriptor attributes, ref CGAffineTransform matrix)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return CreateFont(CTFontCreateCopyWithAttributes(handle, size, ref matrix, attributes.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithSymbolicTraits(IntPtr font, double size, IntPtr matrix, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask);

	public CTFont WithSymbolicTraits(double size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask)
	{
		return CreateFont(CTFontCreateCopyWithSymbolicTraits(handle, size, IntPtr.Zero, symTraitValue, symTraitMask));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithSymbolicTraits(IntPtr font, double size, ref CGAffineTransform matrix, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask);

	public CTFont WithSymbolicTraits(double size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask, ref CGAffineTransform matrix)
	{
		return CreateFont(CTFontCreateCopyWithSymbolicTraits(handle, size, ref matrix, symTraitValue, symTraitMask));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithFamily(IntPtr font, double size, IntPtr matrix, IntPtr family);

	public CTFont WithFamily(double size, string family)
	{
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		using CFString cFString = (CFString)family;
		return CreateFont(CTFontCreateCopyWithFamily(handle, size, IntPtr.Zero, cFString.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithFamily(IntPtr font, double size, ref CGAffineTransform matrix, IntPtr family);

	public CTFont WithFamily(double size, string family, ref CGAffineTransform matrix)
	{
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		using CFString cFString = (CFString)family;
		return CreateFont(CTFontCreateCopyWithFamily(handle, size, ref matrix, cFString.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateForString(IntPtr currentFont, IntPtr @string, NSRange range);

	public CTFont ForString(string value, NSRange range)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		using CFString cFString = (CFString)value;
		return CreateFont(CTFontCreateForString(handle, cFString.Handle, range));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFontDescriptor(IntPtr font);

	public CTFontDescriptor GetFontDescriptor()
	{
		IntPtr intPtr = CTFontCopyFontDescriptor(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTFontDescriptor(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyAttribute(IntPtr font, IntPtr attribute);

	public NSObject GetAttribute(NSString attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		return Runtime.GetNSObject(CTFontCopyAttribute(handle, attribute.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetSize(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGAffineTransform CTFontGetMatrix(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CTFontSymbolicTraits CTFontGetSymbolicTraits(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyTraits(IntPtr font);

	public CTFontTraits GetTraits()
	{
		NSDictionary nSDictionary = (NSDictionary)Runtime.GetNSObject(CTFontCopyTraits(handle));
		if (nSDictionary == null)
		{
			return null;
		}
		nSDictionary.Release();
		return new CTFontTraits(nSDictionary);
	}

	private static string GetStringAndRelease(IntPtr cfStringRef)
	{
		if (cfStringRef == IntPtr.Zero)
		{
			return null;
		}
		using CFString cFString = new CFString(cfStringRef, owns: true);
		return cFString;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyPostScriptName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFamilyName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFullName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyDisplayName(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyName(IntPtr font, IntPtr nameKey);

	public string GetName(CTFontNameKey nameKey)
	{
		return GetStringAndRelease(CTFontCopyName(handle, CTFontNameKeyId.ToId(nameKey).Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyLocalizedName(IntPtr font, IntPtr nameKey);

	public string GetLocalizedName(CTFontNameKey nameKey)
	{
		return GetStringAndRelease(CTFontCopyLocalizedName(handle, CTFontNameKeyId.ToId(nameKey).Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyCharacterSet(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern uint CTFontGetStringEncoding(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopySupportedLanguages(IntPtr font);

	public string[] GetSupportedLanguages()
	{
		IntPtr intPtr = CTFontCopySupportedLanguages(handle);
		if (intPtr == IntPtr.Zero)
		{
			return new string[0];
		}
		string[] result = NSArray.ArrayFromHandle(intPtr, CFString.FetchString);
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontGetGlyphsForCharacters(IntPtr font, [In] char[] characters, [Out] ushort[] glyphs, int count);

	public bool GetGlyphsForCharacters(char[] characters, ushort[] glyphs, int count)
	{
		AssertCount(count);
		AssertLength("characters", characters, count);
		AssertLength("glyphs", characters, count);
		return CTFontGetGlyphsForCharacters(handle, characters, glyphs, count);
	}

	public bool GetGlyphsForCharacters(char[] characters, ushort[] glyphs)
	{
		return GetGlyphsForCharacters(characters, glyphs, Math.Min(characters.Length, glyphs.Length));
	}

	private static void AssertCount(int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "cannot be negative");
		}
	}

	private static void AssertLength<T>(string name, T[] array, int count)
	{
		AssertLength(name, array, count, canBeNull: false);
	}

	private static void AssertLength<T>(string name, T[] array, int count, bool canBeNull)
	{
		if (!canBeNull || array != null)
		{
			if (array == null)
			{
				throw new ArgumentNullException(name);
			}
			if (array.Length < count)
			{
				throw new ArgumentException($"{name}.Length cannot be < count", name);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetAscent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetDescent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetLeading(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern uint CTFontGetUnitsPerEm(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTFontGetGlyphCount(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTFontGetBoundingBox(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetUnderlinePosition(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetUnderlineThickness(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetSlantAngle(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetCapHeight(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetXHeight(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern ushort CTFontGetGlyphWithName(IntPtr font, IntPtr glyphName);

	public ushort GetGlyphWithName(string glyphName)
	{
		if (glyphName == null)
		{
			throw new ArgumentNullException("glyphName");
		}
		using NSString nSString = new NSString(glyphName);
		return CTFontGetGlyphWithName(handle, nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTFontGetBoundingRectsForGlyphs(IntPtr font, CTFontOrientation orientation, [In] ushort[] glyphs, [Out] CGRect[] boundingRects, int count);

	public CGRect GetBoundingRects(CTFontOrientation orientation, ushort[] glyphs, CGRect[] boundingRects, int count)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("boundingRects", boundingRects, count, canBeNull: true);
		return CTFontGetBoundingRectsForGlyphs(handle, orientation, glyphs, boundingRects, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTFontGetOpticalBoundsForGlyphs(IntPtr font, [In] ushort[] glyphs, [Out] CGRect[] boundingRects, int count, CTFontOptions options);

	[Since(6, 0)]
	public CGRect GetOpticalBounds(ushort[] glyphs, CGRect[] boundingRects, int count, CTFontOptions options = CTFontOptions.Default)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("boundingRects", boundingRects, count, canBeNull: true);
		return CTFontGetOpticalBoundsForGlyphs(handle, glyphs, boundingRects, count, CTFontOptions.Default);
	}

	public CGRect GetBoundingRects(CTFontOrientation orientation, ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		return GetBoundingRects(orientation, glyphs, null, glyphs.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTFontGetAdvancesForGlyphs(IntPtr font, CTFontOrientation orientation, [In] ushort[] glyphs, [Out] CGSize[] advances, int count);

	public double GetAdvancesForGlyphs(CTFontOrientation orientation, ushort[] glyphs, CGSize[] advances, int count)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("advances", advances, count, canBeNull: true);
		return CTFontGetAdvancesForGlyphs(handle, orientation, glyphs, advances, count);
	}

	public double GetAdvancesForGlyphs(CTFontOrientation orientation, ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		return GetAdvancesForGlyphs(orientation, glyphs, null, glyphs.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTFontGetVerticalTranslationsForGlyphs(IntPtr font, [In] ushort[] glyphs, [Out] CGSize[] translations, int count);

	public void GetVerticalTranslationsForGlyphs(ushort[] glyphs, CGSize[] translations, int count)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("translations", translations, count);
		CTFontGetVerticalTranslationsForGlyphs(handle, glyphs, translations, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreatePathForGlyph(IntPtr font, ushort glyph, IntPtr transform);

	public CGPath GetPathForGlyph(ushort glyph)
	{
		IntPtr intPtr = CTFontCreatePathForGlyph(handle, glyph, IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGPath(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreatePathForGlyph(IntPtr font, ushort glyph, ref CGAffineTransform transform);

	public CGPath GetPathForGlyph(ushort glyph, ref CGAffineTransform transform)
	{
		IntPtr intPtr = CTFontCreatePathForGlyph(handle, glyph, ref transform);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGPath(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTFontDrawGlyphs(IntPtr font, [In] ushort[] glyphs, [In] CGPoint[] positions, int count, IntPtr context);

	[Since(4, 2)]
	public void DrawGlyphs(CGContext context, ushort[] glyphs, CGPoint[] positions)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (positions == null)
		{
			throw new ArgumentNullException("positions");
		}
		int num = glyphs.Length;
		if (num != positions.Length)
		{
			throw new ArgumentException("array sizes fo context and glyphs differ");
		}
		CTFontDrawGlyphs(handle, glyphs, positions, num, context.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTFontGetLigatureCaretPositions(IntPtr handle, ushort glyph, [Out] double[] positions, int max);

	[Since(4, 2)]
	public int GetLigatureCaretPositions(ushort glyph, double[] positions)
	{
		if (positions == null)
		{
			throw new ArgumentNullException("positions");
		}
		return CTFontGetLigatureCaretPositions(handle, glyph, positions, positions.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyVariationAxes(IntPtr font);

	public CTFontVariationAxes[] GetVariationAxes()
	{
		IntPtr intPtr = CTFontCopyVariationAxes(handle);
		if (intPtr == IntPtr.Zero)
		{
			return new CTFontVariationAxes[0];
		}
		CTFontVariationAxes[] result = NSArray.ArrayFromHandle(intPtr, (IntPtr d) => new CTFontVariationAxes((NSDictionary)Runtime.GetNSObject(d)));
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyVariation(IntPtr font);

	public CTFontVariation GetVariation()
	{
		IntPtr intPtr = CTFontCopyVariation(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTFontVariation((NSDictionary)Runtime.GetNSObject(intPtr));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFeatures(IntPtr font);

	public CTFontFeatures[] GetFeatures()
	{
		IntPtr intPtr = CTFontCopyFeatures(handle);
		if (intPtr == IntPtr.Zero)
		{
			return new CTFontFeatures[0];
		}
		CTFontFeatures[] result = NSArray.ArrayFromHandle(intPtr, (IntPtr d) => new CTFontFeatures((NSDictionary)Runtime.GetNSObject(d)));
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFeatureSettings(IntPtr font);

	public CTFontFeatureSettings[] GetFeatureSettings()
	{
		IntPtr intPtr = CTFontCopyFeatureSettings(handle);
		if (intPtr == IntPtr.Zero)
		{
			return new CTFontFeatureSettings[0];
		}
		CTFontFeatureSettings[] result = NSArray.ArrayFromHandle(intPtr, (IntPtr d) => new CTFontFeatureSettings((NSDictionary)Runtime.GetNSObject(d)));
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyGraphicsFont(IntPtr font, IntPtr attributes);

	public CGFont ToCGFont(CTFontDescriptor attributes)
	{
		IntPtr intPtr = CTFontCopyGraphicsFont(handle, attributes?.Handle ?? IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGFont(intPtr, owns: true);
	}

	public CGFont ToCGFont()
	{
		return ToCGFont(null);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyAvailableTables(IntPtr font, CTFontTableOptions options);

	public CTFontTable[] GetAvailableTables(CTFontTableOptions options)
	{
		IntPtr intPtr = CTFontCopyAvailableTables(handle, options);
		if (intPtr == IntPtr.Zero)
		{
			return new CTFontTable[0];
		}
		CTFontTable[] result = NSArray.ArrayFromHandle(intPtr, (IntPtr v) => (CTFontTable)(int)v);
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyTable(IntPtr font, CTFontTable table, CTFontTableOptions options);

	public NSData GetFontTableData(CTFontTable table, CTFontTableOptions options)
	{
		IntPtr intPtr = CTFontCopyTable(handle, table, options);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		NSData nSData = new NSData(intPtr);
		nSData.Release();
		return nSData;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CTFontGetTypeID")]
	private static extern IntPtr CTFontCopyDefaultCascadeListForLanguages(IntPtr font, IntPtr languagePrefList);

	[Since(6, 0)]
	public CTFontDescriptor[] GetDefaultCascadeList(string[] languages)
	{
		if (languages == null)
		{
			throw new ArgumentNullException("languages");
		}
		using NSArray nSArray = NSArray.FromStrings(languages);
		using CFArray cFArray = new CFArray(CTFontCopyDefaultCascadeListForLanguages(handle, nSArray.Handle), owns: true);
		int count = cFArray.Count;
		CTFontDescriptor[] array = new CTFontDescriptor[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = new CTFontDescriptor(cFArray.GetValue(i), owns: true);
		}
		return array;
	}

	public override string ToString()
	{
		return FullName;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CTFontGetTypeID")]
	public static extern int GetTypeID();
}

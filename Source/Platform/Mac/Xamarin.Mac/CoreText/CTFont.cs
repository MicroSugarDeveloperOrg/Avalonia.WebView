using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreText;

public class CTFont : INativeObject, IDisposable
{
	internal IntPtr handle;

	public nfloat Size => CTFontGetSize(handle);

	public CGAffineTransform Matrix => CTFontGetMatrix(handle);

	public CTFontSymbolicTraits SymbolicTraits => CTFontGetSymbolicTraits(handle);

	public string PostScriptName => CFString.FetchString(CTFontCopyPostScriptName(handle), releaseHandle: true);

	public string FamilyName => CFString.FetchString(CTFontCopyFamilyName(handle), releaseHandle: true);

	public string FullName => CFString.FetchString(CTFontCopyFullName(handle), releaseHandle: true);

	public string DisplayName => CFString.FetchString(CTFontCopyDisplayName(handle), releaseHandle: true);

	public NSCharacterSet CharacterSet
	{
		get
		{
			NSCharacterSet nSObject = Runtime.GetNSObject<NSCharacterSet>(CTFontCopyCharacterSet(handle));
			nSObject.DangerousRelease();
			return nSObject;
		}
	}

	public uint StringEncoding => CTFontGetStringEncoding(handle);

	public nfloat AscentMetric => CTFontGetAscent(handle);

	public nfloat DescentMetric => CTFontGetDescent(handle);

	public nfloat LeadingMetric => CTFontGetLeading(handle);

	public uint UnitsPerEmMetric => CTFontGetUnitsPerEm(handle);

	public nint GlyphCount => CTFontGetGlyphCount(handle);

	public CGRect BoundingBox => CTFontGetBoundingBox(handle);

	public nfloat UnderlinePosition => CTFontGetUnderlinePosition(handle);

	public nfloat UnderlineThickness => CTFontGetUnderlineThickness(handle);

	public nfloat SlantAngle => CTFontGetSlantAngle(handle);

	public nfloat CapHeightMetric => CTFontGetCapHeight(handle);

	public nfloat XHeightMetric => CTFontGetXHeight(handle);

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithName(IntPtr name, nfloat size, IntPtr matrix);

	public CTFont(string name, nfloat size)
	{
		using (NSString nSString = ((name == null) ? null : new NSString(name)))
		{
			handle = CTFontCreateWithName((nSString == null) ? IntPtr.Zero : nSString.Handle, size, IntPtr.Zero);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithName(IntPtr name, nfloat size, ref CGAffineTransform matrix);

	public CTFont(string name, nfloat size, ref CGAffineTransform matrix)
	{
		using (NSString nSString = ((name == null) ? null : new NSString(name)))
		{
			handle = CTFontCreateWithName((nSString == null) ? IntPtr.Zero : nSString.Handle, size, ref matrix);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithFontDescriptor(IntPtr descriptor, nfloat size, IntPtr matrix);

	public CTFont(CTFontDescriptor descriptor, nfloat size)
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
	private static extern IntPtr CTFontCreateWithFontDescriptor(IntPtr descriptor, nfloat size, ref CGAffineTransform matrix);

	public CTFont(CTFontDescriptor descriptor, nfloat size, ref CGAffineTransform matrix)
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
	[iOS(7, 0)]
	private static extern IntPtr CTFontCreateWithNameAndOptions(IntPtr name, nfloat size, IntPtr matrix, nuint options);

	[iOS(7, 0)]
	public CTFont(string name, nfloat size, CTFontOptions options)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontCreateWithNameAndOptions(cFString.Handle, size, IntPtr.Zero, (nuint)(ulong)options);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[iOS(7, 0)]
	private static extern IntPtr CTFontCreateWithNameAndOptions(IntPtr name, nfloat size, ref CGAffineTransform matrix, nuint options);

	[iOS(7, 0)]
	public CTFont(string name, nfloat size, ref CGAffineTransform matrix, CTFontOptions options)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontCreateWithNameAndOptions(cFString.Handle, size, ref matrix, (nuint)(ulong)options);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[iOS(7, 0)]
	private static extern IntPtr CTFontCreateWithFontDescriptorAndOptions(IntPtr descriptor, nfloat size, IntPtr matrix, nuint options);

	[iOS(7, 0)]
	public CTFont(CTFontDescriptor descriptor, nfloat size, CTFontOptions options)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptorAndOptions(descriptor.Handle, size, IntPtr.Zero, (nuint)(ulong)options);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[iOS(7, 0)]
	private static extern IntPtr CTFontCreateWithFontDescriptorAndOptions(IntPtr descriptor, nfloat size, ref CGAffineTransform matrix, nuint options);

	[iOS(7, 0)]
	public CTFont(CTFontDescriptor descriptor, nfloat size, CTFontOptions options, ref CGAffineTransform matrix)
	{
		if (descriptor == null)
		{
			throw ConstructorError.ArgumentNull(this, "descriptor");
		}
		handle = CTFontCreateWithFontDescriptorAndOptions(descriptor.Handle, size, ref matrix, (nuint)(ulong)options);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateWithGraphicsFont(IntPtr cgfontRef, nfloat size, ref CGAffineTransform affine, IntPtr attrs);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CTFontCreateWithGraphicsFont")]
	private static extern IntPtr CTFontCreateWithGraphicsFont2(IntPtr cgfontRef, nfloat size, IntPtr affine, IntPtr attrs);

	public CTFont(CGFont font, nfloat size, CGAffineTransform transform, CTFontDescriptor descriptor)
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

	public CTFont(CGFont font, nfloat size, CTFontDescriptor descriptor)
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

	public CTFont(CGFont font, nfloat size, CGAffineTransform transform)
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
	private static extern IntPtr CTFontCreateUIFontForLanguage(CTFontUIFontType uiType, nfloat size, IntPtr language);

	public CTFont(CTFontUIFontType uiType, nfloat size, string language)
	{
		CFString cFString = null;
		try
		{
			if (language != null)
			{
				cFString = language;
			}
			handle = CTFontCreateUIFontForLanguage(uiType, size, cFString?.Handle ?? IntPtr.Zero);
		}
		finally
		{
			cFString?.Dispose();
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithAttributes(IntPtr font, nfloat size, IntPtr matrix, IntPtr attributues);

	public CTFont WithAttributes(nfloat size, CTFontDescriptor attributes)
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
	private static extern IntPtr CTFontCreateCopyWithAttributes(IntPtr font, nfloat size, ref CGAffineTransform matrix, IntPtr attributes);

	public CTFont WithAttributes(nfloat size, CTFontDescriptor attributes, ref CGAffineTransform matrix)
	{
		return CreateFont(CTFontCreateCopyWithAttributes(handle, size, ref matrix, attributes?.Handle ?? IntPtr.Zero));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithSymbolicTraits(IntPtr font, nfloat size, IntPtr matrix, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask);

	public CTFont WithSymbolicTraits(nfloat size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask)
	{
		return CreateFont(CTFontCreateCopyWithSymbolicTraits(handle, size, IntPtr.Zero, symTraitValue, symTraitMask));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithSymbolicTraits(IntPtr font, nfloat size, ref CGAffineTransform matrix, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask);

	public CTFont WithSymbolicTraits(nfloat size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask, ref CGAffineTransform matrix)
	{
		return CreateFont(CTFontCreateCopyWithSymbolicTraits(handle, size, ref matrix, symTraitValue, symTraitMask));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithFamily(IntPtr font, nfloat size, IntPtr matrix, IntPtr family);

	public CTFont WithFamily(nfloat size, string family)
	{
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		using CFString cFString = (CFString)family;
		return CreateFont(CTFontCreateCopyWithFamily(handle, size, IntPtr.Zero, cFString.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCreateCopyWithFamily(IntPtr font, nfloat size, ref CGAffineTransform matrix, IntPtr family);

	public CTFont WithFamily(nfloat size, string family, ref CGAffineTransform matrix)
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
	[iOS(13, 0)]
	[Mac(10, 15)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr CTFontCreateForStringWithLanguage(IntPtr currentFont, IntPtr @string, NSRange range, IntPtr language);

	[iOS(13, 0)]
	[Mac(10, 15)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public CTFont ForString(string value, NSRange range, string language)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr @string = NSString.CreateNative(value);
		IntPtr language2 = NSString.CreateNative(language);
		try
		{
			return CreateFont(CTFontCreateForStringWithLanguage(handle, @string, range, language2));
		}
		finally
		{
			NSString.ReleaseNative(language2);
			NSString.ReleaseNative(@string);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyFontDescriptor(IntPtr font);

	public CTFontDescriptor GetFontDescriptor()
	{
		IntPtr intPtr = CTFontCopyFontDescriptor(handle);
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
	private static extern nfloat CTFontGetSize(IntPtr font);

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
		nSDictionary.DangerousRelease();
		return new CTFontTraits(nSDictionary);
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
		return CFString.FetchString(CTFontCopyName(handle, CTFontNameKeyId.ToId(nameKey).Handle), releaseHandle: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyLocalizedName(IntPtr font, IntPtr nameKey, out IntPtr actualLanguage);

	public string GetLocalizedName(CTFontNameKey nameKey)
	{
		string actualLanguage;
		return GetLocalizedName(nameKey, out actualLanguage);
	}

	public string GetLocalizedName(CTFontNameKey nameKey, out string actualLanguage)
	{
		IntPtr actualLanguage2;
		string result = CFString.FetchString(CTFontCopyLocalizedName(handle, CTFontNameKeyId.ToId(nameKey).Handle, out actualLanguage2), releaseHandle: true);
		actualLanguage = CFString.FetchString(actualLanguage2, releaseHandle: true);
		return result;
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
			return Array.Empty<string>();
		}
		string[] result = NSArray.ArrayFromHandle(intPtr, CFString.FetchString);
		CFObject.CFRelease(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", CharSet = CharSet.Unicode)]
	private static extern bool CTFontGetGlyphsForCharacters(IntPtr font, char[] characters, ushort[] glyphs, nint count);

	public bool GetGlyphsForCharacters(char[] characters, ushort[] glyphs, nint count)
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

	private static void AssertCount(nint count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "cannot be negative");
		}
	}

	private static void AssertLength<T>(string name, T[] array, nint count)
	{
		AssertLength(name, array, count, canBeNull: false);
	}

	private static void AssertLength<T>(string name, T[] array, nint count, bool canBeNull)
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
	private static extern nfloat CTFontGetAscent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetDescent(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetLeading(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern uint CTFontGetUnitsPerEm(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nint CTFontGetGlyphCount(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTFontGetBoundingBox(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetUnderlinePosition(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetUnderlineThickness(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetSlantAngle(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetCapHeight(IntPtr font);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTFontGetXHeight(IntPtr font);

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
	private static extern CGRect CTFontGetBoundingRectsForGlyphs(IntPtr font, CTFontOrientation orientation, [In] ushort[] glyphs, [Out] CGRect[] boundingRects, nint count);

	public CGRect GetBoundingRects(CTFontOrientation orientation, ushort[] glyphs, CGRect[] boundingRects, nint count)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("boundingRects", boundingRects, count, canBeNull: true);
		return CTFontGetBoundingRectsForGlyphs(handle, orientation, glyphs, boundingRects, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTFontGetOpticalBoundsForGlyphs(IntPtr font, [In] ushort[] glyphs, [Out] CGRect[] boundingRects, nint count, nuint options);

	public CGRect GetOpticalBounds(ushort[] glyphs, CGRect[] boundingRects, nint count, CTFontOptions options = CTFontOptions.Default)
	{
		AssertCount(count);
		AssertLength("glyphs", glyphs, count);
		AssertLength("boundingRects", boundingRects, count, canBeNull: true);
		return CTFontGetOpticalBoundsForGlyphs(handle, glyphs, boundingRects, count, (nuint)(ulong)options);
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
	private static extern double CTFontGetAdvancesForGlyphs(IntPtr font, CTFontOrientation orientation, [In] ushort[] glyphs, [Out] CGSize[] advances, nint count);

	public double GetAdvancesForGlyphs(CTFontOrientation orientation, ushort[] glyphs, CGSize[] advances, nint count)
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
	private static extern void CTFontGetVerticalTranslationsForGlyphs(IntPtr font, [In] ushort[] glyphs, [Out] CGSize[] translations, nint count);

	public void GetVerticalTranslationsForGlyphs(ushort[] glyphs, CGSize[] translations, nint count)
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
	private static extern void CTFontDrawGlyphs(IntPtr font, [In] ushort[] glyphs, [In] CGPoint[] positions, nint count, IntPtr context);

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
	private static extern nint CTFontGetLigatureCaretPositions(IntPtr handle, ushort glyph, [Out] nfloat[] positions, nint max);

	public nint GetLigatureCaretPositions(ushort glyph, nfloat[] positions)
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
		nSData.DangerousRelease();
		return nSData;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontCopyDefaultCascadeListForLanguages(IntPtr font, IntPtr languagePrefList);

	public CTFontDescriptor[] GetDefaultCascadeList(string[] languages)
	{
		using NSArray self = ((languages == null) ? null : NSArray.FromStrings(languages));
		IntPtr intPtr = CTFontCopyDefaultCascadeListForLanguages(handle, self.GetHandle());
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using CFArray cFArray = new CFArray(intPtr, owns: true);
		nint count = cFArray.Count;
		CTFontDescriptor[] array = new CTFontDescriptor[(long)count];
		for (nint nint = 0; nint < count; ++nint)
		{
			array[(long)nint] = new CTFontDescriptor(cFArray.GetValue(nint), owns: false);
		}
		return array;
	}

	public override string ToString()
	{
		return FullName;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", EntryPoint = "CTFontGetTypeID")]
	public static extern nint GetTypeID();

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
}

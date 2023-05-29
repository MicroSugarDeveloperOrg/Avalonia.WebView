using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTGlyphInfo : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public string GlyphName => CFString.FetchString(CTGlyphInfoGetGlyphName(handle));

	public ushort CharacterIdentifier => CTGlyphInfoGetCharacterIdentifier(handle);

	public CTCharacterCollection CharacterCollection => CTGlyphInfoGetCharacterCollection(handle);

	internal CTGlyphInfo(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.ArgumentNull(this, "handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTGlyphInfo()
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
	private static extern IntPtr CTGlyphInfoCreateWithGlyphName(IntPtr glyphName, IntPtr font, IntPtr baseString);

	public CTGlyphInfo(string glyphName, CTFont font, string baseString)
	{
		if (glyphName == null)
		{
			throw ConstructorError.ArgumentNull(this, "glyphName");
		}
		if (font == null)
		{
			throw ConstructorError.ArgumentNull(this, "font");
		}
		if (baseString == null)
		{
			throw ConstructorError.ArgumentNull(this, "baseString");
		}
		using (NSString nSString = new NSString(glyphName))
		{
			using NSString nSString2 = new NSString(baseString);
			handle = CTGlyphInfoCreateWithGlyphName(nSString.Handle, font.Handle, nSString2.Handle);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTGlyphInfoCreateWithGlyph(ushort glyph, IntPtr font, IntPtr baseString);

	public CTGlyphInfo(ushort glyph, CTFont font, string baseString)
	{
		if (font == null)
		{
			throw ConstructorError.ArgumentNull(this, "font");
		}
		if (baseString == null)
		{
			throw ConstructorError.ArgumentNull(this, "baseString");
		}
		using (NSString nSString = new NSString(baseString))
		{
			handle = CTGlyphInfoCreateWithGlyph(glyph, font.Handle, nSString.Handle);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTGlyphInfoCreateWithCharacterIdentifier(ushort cid, CTCharacterCollection collection, IntPtr baseString);

	public CTGlyphInfo(ushort cid, CTCharacterCollection collection, string baseString)
	{
		if (baseString == null)
		{
			throw ConstructorError.ArgumentNull(this, "baseString");
		}
		using (NSString nSString = new NSString(baseString))
		{
			handle = CTGlyphInfoCreateWithCharacterIdentifier(cid, collection, nSString.Handle);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTGlyphInfoGetGlyphName(IntPtr glyphInfo);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern ushort CTGlyphInfoGetCharacterIdentifier(IntPtr glyphInfo);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CTCharacterCollection CTGlyphInfoGetCharacterCollection(IntPtr glyphInfo);

	public override string ToString()
	{
		return GlyphName;
	}
}

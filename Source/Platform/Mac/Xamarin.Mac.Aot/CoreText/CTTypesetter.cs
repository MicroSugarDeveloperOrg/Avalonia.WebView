using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTTypesetter : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	internal CTTypesetter(IntPtr handle, bool owns)
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

	~CTTypesetter()
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
	private static extern IntPtr CTTypesetterCreateWithAttributedString(IntPtr @string);

	public CTTypesetter(NSAttributedString value)
	{
		if (value == null)
		{
			throw ConstructorError.ArgumentNull(this, "value");
		}
		handle = CTTypesetterCreateWithAttributedString(value.Handle);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTTypesetterCreateWithAttributedStringAndOptions(IntPtr @string, IntPtr options);

	public CTTypesetter(NSAttributedString value, CTTypesetterOptions options)
	{
		if (value == null)
		{
			throw ConstructorError.ArgumentNull(this, "value");
		}
		handle = CTTypesetterCreateWithAttributedStringAndOptions(value.Handle, options?.Dictionary.Handle ?? IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTTypesetterCreateLineWithOffset(IntPtr typesetter, NSRange stringRange, double offset);

	public CTLine GetLine(NSRange stringRange, double offset)
	{
		IntPtr intPtr = CTTypesetterCreateLineWithOffset(handle, stringRange, offset);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTLine(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTTypesetterCreateLine(IntPtr typesetter, NSRange stringRange);

	public CTLine GetLine(NSRange stringRange)
	{
		IntPtr intPtr = CTTypesetterCreateLine(handle, stringRange);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTLine(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTTypesetterSuggestLineBreakWithOffset(IntPtr typesetter, int startIndex, double width, double offset);

	public int SuggestLineBreak(int startIndex, double width, double offset)
	{
		return CTTypesetterSuggestLineBreakWithOffset(handle, startIndex, width, offset);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTTypesetterSuggestLineBreak(IntPtr typesetter, int startIndex, double width);

	public int SuggestLineBreak(int startIndex, double width)
	{
		return CTTypesetterSuggestLineBreak(handle, startIndex, width);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTTypesetterSuggestClusterBreakWithOffset(IntPtr typesetter, int startIndex, double width, double offset);

	public int SuggestClusterBreak(int startIndex, double width, double offset)
	{
		return CTTypesetterSuggestClusterBreakWithOffset(handle, startIndex, width, offset);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTTypesetterSuggestClusterBreak(IntPtr typesetter, int startIndex, double width);

	public int SuggestClusterBreak(int startIndex, double width)
	{
		return CTTypesetterSuggestClusterBreak(handle, startIndex, width);
	}
}

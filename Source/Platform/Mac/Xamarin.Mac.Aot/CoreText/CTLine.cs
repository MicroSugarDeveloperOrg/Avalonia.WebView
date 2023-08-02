using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTLine : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int GlyphCount => CTLineGetGlyphCount(handle);

	public NSRange StringRange => CTLineGetStringRange(handle);

	public double TrailingWhitespaceWidth => CTLineGetTrailingWhitespaceWidth(handle);

	internal CTLine(IntPtr handle, bool owns)
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

	~CTLine()
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
	private static extern IntPtr CTLineCreateWithAttributedString(IntPtr @string);

	public CTLine(NSAttributedString value)
	{
		if (value == null)
		{
			throw ConstructorError.ArgumentNull(this, "value");
		}
		handle = CTLineCreateWithAttributedString(value.Handle);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTLineCreateTruncatedLine(IntPtr line, double width, CTLineTruncation truncationType, IntPtr truncationToken);

	public CTLine GetTruncatedLine(double width, CTLineTruncation truncationType, CTLine truncationToken)
	{
		IntPtr intPtr = CTLineCreateTruncatedLine(handle, width, truncationType, truncationToken?.Handle ?? IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTLine(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTLineCreateJustifiedLine(IntPtr line, double justificationFactor, double justificationWidth);

	public CTLine GetJustifiedLine(double justificationFactor, double justificationWidth)
	{
		IntPtr intPtr = CTLineCreateJustifiedLine(handle, justificationFactor, justificationWidth);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTLine(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTLineGetGlyphCount(IntPtr line);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTLineGetGlyphRuns(IntPtr line);

	public CTRun[] GetGlyphRuns()
	{
		IntPtr intPtr = CTLineGetGlyphRuns(handle);
		if (intPtr == IntPtr.Zero)
		{
			return new CTRun[0];
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr v) => new CTRun(v, owns: false));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern NSRange CTLineGetStringRange(IntPtr line);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetPenOffsetForFlush(IntPtr line, double flushFactor, double flushWidth);

	public double GetPenOffsetForFlush(double flushFactor, double flushWidth)
	{
		return CTLineGetPenOffsetForFlush(handle, flushFactor, flushWidth);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTLineDraw(IntPtr line, IntPtr context);

	public void Draw(CGContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		CTLineDraw(handle, context.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTLineGetImageBounds(IntPtr line, IntPtr context);

	public CGRect GetImageBounds(CGContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return CTLineGetImageBounds(handle, context.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTLineGetBoundsWithOptions(IntPtr line, CTLineBoundsOptions options);

	[Since(6, 0)]
	public CGRect GetBounds(CTLineBoundsOptions options)
	{
		return CTLineGetBoundsWithOptions(handle, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetTypographicBounds(IntPtr line, out double ascent, out double descent, out double leading);

	public double GetTypographicBounds(out double ascent, out double descent, out double leading)
	{
		return CTLineGetTypographicBounds(handle, out ascent, out descent, out leading);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetTypographicBounds(IntPtr line, IntPtr ascent, IntPtr descent, IntPtr leading);

	public double GetTypographicBounds()
	{
		return CTLineGetTypographicBounds(handle, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetTrailingWhitespaceWidth(IntPtr line);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern int CTLineGetStringIndexForPosition(IntPtr line, CGPoint position);

	public int GetStringIndexForPosition(CGPoint position)
	{
		return CTLineGetStringIndexForPosition(handle, position);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetOffsetForStringIndex(IntPtr line, int charIndex, out double secondaryOffset);

	public double GetOffsetForStringIndex(int charIndex, out double secondaryOffset)
	{
		return CTLineGetOffsetForStringIndex(handle, charIndex, out secondaryOffset);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetOffsetForStringIndex(IntPtr line, int charIndex, IntPtr secondaryOffset);

	public double GetOffsetForStringIndex(int charIndex)
	{
		return CTLineGetOffsetForStringIndex(handle, charIndex, IntPtr.Zero);
	}
}

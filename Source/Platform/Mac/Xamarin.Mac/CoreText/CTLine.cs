using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreText;

public class CTLine : INativeObject, IDisposable
{
	public delegate void CaretEdgeEnumerator(double offset, nint charIndex, bool leadingEdge, ref bool stop);

	private delegate void CaretEdgeEnumeratorProxy(IntPtr block, double offset, nint charIndex, [MarshalAs(UnmanagedType.I1)] bool leadingEdge, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal IntPtr handle;

	private static readonly CaretEdgeEnumeratorProxy static_enumerate = TrampolineEnumerate;

	public IntPtr Handle => handle;

	public nint GlyphCount => CTLineGetGlyphCount(handle);

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
	private static extern IntPtr CTLineCreateJustifiedLine(IntPtr line, nfloat justificationFactor, double justificationWidth);

	public CTLine GetJustifiedLine(nfloat justificationFactor, double justificationWidth)
	{
		IntPtr intPtr = CTLineCreateJustifiedLine(handle, justificationFactor, justificationWidth);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTLine(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nint CTLineGetGlyphCount(IntPtr line);

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
	private static extern double CTLineGetPenOffsetForFlush(IntPtr line, nfloat flushFactor, double flushWidth);

	public double GetPenOffsetForFlush(nfloat flushFactor, double flushWidth)
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
		return CTLineGetImageBounds(handle, context.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTLineGetBoundsWithOptions(IntPtr line, nuint options);

	public CGRect GetBounds(CTLineBoundsOptions options)
	{
		return CTLineGetBoundsWithOptions(handle, (nuint)(ulong)options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTLineGetTypographicBounds(IntPtr line, out nfloat ascent, out nfloat descent, out nfloat leading);

	public double GetTypographicBounds(out nfloat ascent, out nfloat descent, out nfloat leading)
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
	private static extern nint CTLineGetStringIndexForPosition(IntPtr line, CGPoint position);

	public nint GetStringIndexForPosition(CGPoint position)
	{
		return CTLineGetStringIndexForPosition(handle, position);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTLineGetOffsetForStringIndex(IntPtr line, nint charIndex, out nfloat secondaryOffset);

	public nfloat GetOffsetForStringIndex(nint charIndex, out nfloat secondaryOffset)
	{
		return CTLineGetOffsetForStringIndex(handle, charIndex, out secondaryOffset);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nfloat CTLineGetOffsetForStringIndex(IntPtr line, nint charIndex, IntPtr secondaryOffset);

	public nfloat GetOffsetForStringIndex(nint charIndex)
	{
		return CTLineGetOffsetForStringIndex(handle, charIndex, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private unsafe static extern void CTLineEnumerateCaretOffsets(IntPtr line, BlockLiteral* blockEnumerator);

	[MonoPInvokeCallback(typeof(CaretEdgeEnumeratorProxy))]
	private unsafe static void TrampolineEnumerate(IntPtr blockPtr, double offset, nint charIndex, bool leadingEdge, ref bool stop)
	{
		BlockLiteral* ptr = (BlockLiteral*)(void*)blockPtr;
		((CaretEdgeEnumerator)ptr->Target)?.Invoke(offset, charIndex, leadingEdge, ref stop);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void EnumerateCaretOffsets(CaretEdgeEnumerator enumerator)
	{
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_enumerate, enumerator);
		CTLineEnumerateCaretOffsets(handle, ptr);
		ptr->CleanupBlock();
	}
}

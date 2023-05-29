using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFDocument : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int Pages => CGPDFDocumentGetNumberOfPages(handle);

	public bool IsEncrypted => CGPDFDocumentIsEncrypted(handle) != 0;

	public bool IsUnlocked => CGPDFDocumentIsUnlocked(handle) != 0;

	public bool AllowsPrinting => CGPDFDocumentAllowsPrinting(handle) != 0;

	public bool AllowsCopying => CGPDFDocumentAllowsCopying(handle) != 0;

	~CGPDFDocument()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDocumentRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDocumentRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGPDFDocumentRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public CGPDFDocument(IntPtr handle)
	{
		this.handle = handle;
		CGPDFDocumentRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CGPDFDocument(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGPDFDocumentRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentCreateWithProvider(IntPtr provider);

	public CGPDFDocument(CGDataProvider provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		handle = CGPDFDocumentCreateWithProvider(provider.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentCreateWithURL(IntPtr url);

	public static CGPDFDocument FromFile(string str)
	{
		using CFUrl cFUrl = CFUrl.FromFile(str);
		if (cFUrl == null)
		{
			return null;
		}
		IntPtr intPtr = CGPDFDocumentCreateWithURL(cFUrl.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGPDFDocument(intPtr, owns: true);
	}

	public static CGPDFDocument FromUrl(string str)
	{
		using CFUrl cFUrl = CFUrl.FromUrlString(str, null);
		if (cFUrl == null)
		{
			return null;
		}
		IntPtr intPtr = CGPDFDocumentCreateWithURL(cFUrl.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGPDFDocument(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentGetNumberOfPages(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetPage(IntPtr handle, int page);

	public CGPDFPage GetPage(int page)
	{
		return new CGPDFPage(this, CGPDFDocumentGetPage(handle, page));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDocumentGetVersion(IntPtr handle, out int major, out int minor);

	public void GetVersion(out int major, out int minor)
	{
		CGPDFDocumentGetVersion(handle, out major, out minor);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentIsEncrypted(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentUnlockWithPassword(IntPtr handle, string password);

	public bool UnlockWithPassword(string pass)
	{
		return CGPDFDocumentUnlockWithPassword(handle, pass) != 0;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentIsUnlocked(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentAllowsPrinting(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFDocumentAllowsCopying(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFDocumentGetMediaBox(IntPtr handle, int page);

	public CGRect GetMediaBox(int page)
	{
		return CGPDFDocumentGetMediaBox(handle, page);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFDocumentGetCropBox(IntPtr handle, int page);

	public CGRect GetCropBox(int page)
	{
		return CGPDFDocumentGetCropBox(handle, page);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFDocumentGetBleedBox(IntPtr handle, int page);

	public CGRect GetBleedBox(int page)
	{
		return CGPDFDocumentGetBleedBox(handle, page);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFDocumentGetTrimBox(IntPtr handle, int page);

	public CGRect GetTrimBox(int page)
	{
		return CGPDFDocumentGetTrimBox(handle, page);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPDFDocumentGetArtBox(IntPtr handle, int page);

	public CGRect GetArtBox(int page)
	{
		return CGPDFDocumentGetArtBox(handle, page);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetCatalog(IntPtr handle);

	public CGPDFDictionary GetCatalog()
	{
		return new CGPDFDictionary(CGPDFDocumentGetCatalog(handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetInfo(IntPtr handle);

	public CGPDFDictionary GetInfo()
	{
		return new CGPDFDictionary(CGPDFDocumentGetInfo(handle));
	}
}

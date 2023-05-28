using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGPDFDocument : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public nint Pages => CGPDFDocumentGetNumberOfPages(handle);

	public bool IsEncrypted => CGPDFDocumentIsEncrypted(handle);

	public bool IsUnlocked => CGPDFDocumentIsUnlocked(handle);

	public bool AllowsPrinting => CGPDFDocumentAllowsPrinting(handle);

	public bool AllowsCopying => CGPDFDocumentAllowsCopying(handle);

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
	private static extern void CGPDFDocumentRelease(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentRetain(IntPtr document);

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
	private static extern nint CGPDFDocumentGetNumberOfPages(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetPage(IntPtr document, nint page);

	public CGPDFPage GetPage(nint page)
	{
		IntPtr intPtr = CGPDFDocumentGetPage(handle, page);
		return (intPtr == IntPtr.Zero) ? null : new CGPDFPage(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDocumentGetVersion(IntPtr document, out int majorVersion, out int minorVersion);

	public void GetVersion(out int major, out int minor)
	{
		CGPDFDocumentGetVersion(handle, out major, out minor);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDocumentIsEncrypted(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDocumentUnlockWithPassword(IntPtr document, string password);

	public bool Unlock(string password)
	{
		return CGPDFDocumentUnlockWithPassword(handle, password);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDocumentIsUnlocked(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDocumentAllowsPrinting(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDocumentAllowsCopying(IntPtr document);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetCatalog(IntPtr document);

	public CGPDFDictionary GetCatalog()
	{
		return new CGPDFDictionary(CGPDFDocumentGetCatalog(handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDocumentGetInfo(IntPtr document);

	public CGPDFDictionary GetInfo()
	{
		return new CGPDFDictionary(CGPDFDocumentGetInfo(handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	private static extern void CGPDFContextSetOutline(IntPtr document, IntPtr outline);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	public void SetOutline(CGPDFOutlineOptions options)
	{
		CGPDFContextSetOutline(handle, options?.Dictionary.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	private static extern IntPtr CGPDFDocumentGetOutline(IntPtr document);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	public CGPDFOutlineOptions GetOutline()
	{
		IntPtr ptr = CGPDFDocumentGetOutline(handle);
		return new CGPDFOutlineOptions(Runtime.GetNSObject<NSDictionary>(ptr));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	private static extern CGPDFAccessPermissions CGPDFDocumentGetAccessPermissions(IntPtr document);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	public CGPDFAccessPermissions GetAccessPermissions()
	{
		return CGPDFDocumentGetAccessPermissions(handle);
	}
}

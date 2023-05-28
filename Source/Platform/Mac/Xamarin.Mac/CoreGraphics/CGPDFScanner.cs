using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGPDFScanner : INativeObject, IDisposable
{
	private object info;

	internal GCHandle gch;

	public object UserInfo => info;

	public IntPtr Handle { get; private set; }

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFScannerCreate(IntPtr cs, IntPtr table, IntPtr info);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFScannerRetain(IntPtr scanner);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFScannerRelease(IntPtr scanner);

	public CGPDFScanner(CGPDFContentStream cs, CGPDFOperatorTable table, object userInfo)
	{
		if (cs == null)
		{
			throw new ArgumentNullException("cs");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		info = userInfo;
		gch = GCHandle.Alloc(this);
		Handle = CGPDFScannerCreate(cs.Handle, table.Handle, GCHandle.ToIntPtr(gch));
	}

	public CGPDFScanner(IntPtr handle)
	{
		CGPDFScannerRetain(handle);
		Handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGPDFScanner(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGPDFScannerRetain(handle);
		}
		Handle = handle;
	}

	~CGPDFScanner()
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
		if (Handle != IntPtr.Zero)
		{
			CGPDFScannerRelease(Handle);
			Handle = IntPtr.Zero;
		}
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFScannerGetContentStream(IntPtr scanner);

	public CGPDFContentStream GetContentStream()
	{
		return new CGPDFContentStream(CGPDFScannerGetContentStream(Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerScan(IntPtr scanner);

	public bool Scan()
	{
		return CGPDFScannerScan(Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopObject(IntPtr scanner, out IntPtr value);

	public bool TryPop(out CGPDFObject value)
	{
		if (CGPDFScannerPopObject(Handle, out var value2))
		{
			value = new CGPDFObject(value2);
			return true;
		}
		value = null;
		return false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopBoolean(IntPtr scanner, out bool value);

	public bool TryPop(out bool value)
	{
		return CGPDFScannerPopBoolean(Handle, out value);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopInteger(IntPtr scanner, out nint value);

	public bool TryPop(out nint value)
	{
		return CGPDFScannerPopInteger(Handle, out value);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopNumber(IntPtr scanner, out nfloat value);

	public bool TryPop(out nfloat value)
	{
		return CGPDFScannerPopNumber(Handle, out value);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopName(IntPtr scanner, out IntPtr value);

	public bool TryPopName(out string name)
	{
		if (CGPDFScannerPopName(Handle, out var value))
		{
			name = Marshal.PtrToStringAnsi(value);
			return true;
		}
		name = null;
		return false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopString(IntPtr scanner, out IntPtr value);

	public bool TryPop(out string value)
	{
		if (CGPDFScannerPopString(Handle, out var value2))
		{
			value = CGPDFString.ToString(value2);
			return true;
		}
		value = null;
		return false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopArray(IntPtr scanner, out IntPtr value);

	public bool TryPop(out CGPDFArray value)
	{
		if (CGPDFScannerPopArray(Handle, out var value2))
		{
			value = new CGPDFArray(value2);
			return true;
		}
		value = null;
		return false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopDictionary(IntPtr scanner, out IntPtr value);

	public bool TryPop(out CGPDFDictionary value)
	{
		if (CGPDFScannerPopDictionary(Handle, out var value2))
		{
			value = new CGPDFDictionary(value2);
			return true;
		}
		value = null;
		return false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFScannerPopStream(IntPtr scanner, out IntPtr value);

	public bool TryPop(out CGPDFStream value)
	{
		if (CGPDFScannerPopStream(Handle, out var value2))
		{
			value = new CGPDFStream(value2);
			return true;
		}
		value = null;
		return false;
	}
}

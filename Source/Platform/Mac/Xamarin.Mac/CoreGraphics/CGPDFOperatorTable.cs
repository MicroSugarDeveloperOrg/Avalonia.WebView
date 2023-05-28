using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFOperatorTable : INativeObject, IDisposable
{
	private delegate void CGPDFOperatorCallback(IntPtr scanner, IntPtr info);

	public IntPtr Handle { get; private set; }

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFOperatorTableCreate();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFOperatorTableRetain(IntPtr table);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFOperatorTableRelease(IntPtr table);

	public CGPDFOperatorTable()
	{
		Handle = CGPDFOperatorTableCreate();
	}

	public CGPDFOperatorTable(IntPtr handle)
	{
		CGPDFOperatorTableRetain(handle);
		Handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGPDFOperatorTable(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGPDFOperatorTableRetain(handle);
		}
		Handle = handle;
	}

	~CGPDFOperatorTable()
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
			CGPDFOperatorTableRelease(Handle);
			Handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFOperatorTableSetCallback(IntPtr table, string name, Action<IntPtr, IntPtr> callback);

	public void SetCallback(string name, Action<CGPDFScanner, object> callback)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (callback == null)
		{
			CGPDFOperatorTableSetCallback(Handle, name, null);
			return;
		}
		CGPDFOperatorTableSetCallback(Handle, name, delegate(IntPtr reserved, IntPtr gchandle)
		{
			CGPDFScanner scannerFromInfo = GetScannerFromInfo(gchandle);
			callback(scannerFromInfo, scannerFromInfo?.UserInfo);
		});
	}

	[Advice("Use the nicer SetCallback(string,Action<CGPDFScanner,object>) API when possible.")]
	public void SetCallback(string name, Action<IntPtr, IntPtr> callback)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CGPDFOperatorTableSetCallback(Handle, name, callback);
	}

	public static CGPDFScanner GetScannerFromInfo(IntPtr gchandle)
	{
		return GCHandle.FromIntPtr(gchandle).Target as CGPDFScanner;
	}
}

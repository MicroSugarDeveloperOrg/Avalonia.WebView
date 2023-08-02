using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

public class CFUrl : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public string FileSystemPath => GetFileSystemPath(handle);

	~CFUrl()
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

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern IntPtr CFURLCreateWithFileSystemPath(IntPtr allocator, IntPtr cfstringref, CFUrlPathStyle pathstyle, bool isdir);

	internal CFUrl(IntPtr handle)
	{
		this.handle = handle;
	}

	public static CFUrl FromFile(string filename)
	{
		using CFString cFString = new CFString(filename);
		IntPtr intPtr = CFURLCreateWithFileSystemPath(IntPtr.Zero, cFString.Handle, CFUrlPathStyle.POSIX, isdir: false);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFUrl(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr stringref, IntPtr baseUrl);

	public static CFUrl FromUrlString(string url, CFUrl baseurl)
	{
		using CFString cFString = new CFString(url);
		return FromStringHandle(cFString.Handle, baseurl);
	}

	internal static CFUrl FromStringHandle(IntPtr cfstringHandle, CFUrl baseurl)
	{
		IntPtr intPtr = CFURLCreateWithString(IntPtr.Zero, cfstringHandle, baseurl?.Handle ?? IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFUrl(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFURLGetString(IntPtr anURL);

	public override string ToString()
	{
		using CFString cFString = new CFString(CFURLGetString(handle));
		return cFString.ToString();
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFURLCopyFileSystemPath(IntPtr cfUrl, int style);

	internal static string GetFileSystemPath(IntPtr hcfurl)
	{
		using CFString cFString = new CFString(CFURLCopyFileSystemPath(hcfurl, 0), owns: true);
		return cFString.ToString();
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFURLGetTypeID")]
	public static extern int GetTypeID();
}

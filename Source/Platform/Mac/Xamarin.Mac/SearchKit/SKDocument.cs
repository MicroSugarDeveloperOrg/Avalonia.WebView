using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace SearchKit;

public class SKDocument : IDisposable, INativeObject
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public NSUrl Url
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("disposed");
			}
			IntPtr intPtr = SKDocumentCopyURL(handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NSUrl(intPtr);
		}
	}

	public string Name
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("disposed");
			}
			IntPtr intPtr = SKDocumentGetName(handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	public string Scheme
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("disposed");
			}
			IntPtr intPtr = SKDocumentGetSchemeName(handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentCreate(IntPtr scheme, IntPtr docParent, IntPtr name);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentCreateWithURL(IntPtr url);

	public SKDocument(string name, SKDocument parent = null, string scheme = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		NSString nSString = ((scheme == null) ? null : new NSString(scheme));
		using (NSString nSString2 = new NSString(name))
		{
			handle = SKDocumentCreate((nSString == null) ? IntPtr.Zero : nSString.Handle, parent?.Handle ?? IntPtr.Zero, nSString2.Handle);
		}
		if (nSString != null)
		{
			nSString.Dispose();
		}
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("Failed to create the specified document");
		}
	}

	internal SKDocument(IntPtr h)
	{
		handle = h;
	}

	public SKDocument(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		handle = SKDocumentCreateWithURL(url.Handle);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("Failed to create the specified document");
		}
	}

	~SKDocument()
	{
		Dispose(disposing: false);
	}

	void IDisposable.Dispose()
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

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentCopyURL(IntPtr h);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentGetName(IntPtr h);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentGetParent(IntPtr h);

	public SKDocument GetParent()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("disposed");
		}
		IntPtr intPtr = SKDocumentGetParent(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKDocument(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKDocumentGetSchemeName(IntPtr h);
}

using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecIdentity : INativeObject, IDisposable
{
	internal IntPtr handle;

	public SecCertificate Certificate
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecIdentity");
			}
			SecIdentityCopyCertificate(handle, out var _);
			return new SecCertificate(handle, owns: true);
		}
	}

	public IntPtr Handle => handle;

	internal SecIdentity(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal SecIdentity(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecIdentityGetTypeID")]
	public static extern int GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecIdentityCopyCertificate(IntPtr handle, out IntPtr cert);

	~SecIdentity()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}

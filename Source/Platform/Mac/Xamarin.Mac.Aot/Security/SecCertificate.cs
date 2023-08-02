using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecCertificate : INativeObject, IDisposable
{
	internal IntPtr handle;

	public string SubjectSummary
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecCertificate");
			}
			IntPtr obj = SecCertificateCopySubjectSummary(handle);
			string result = CFString.FetchString(obj);
			CFObject.CFRelease(obj);
			return result;
		}
	}

	public NSData DerData
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecCertificate");
			}
			IntPtr intPtr = SecCertificateCopyData(handle);
			if (intPtr == IntPtr.Zero)
			{
				throw new ArgumentException("Not a valid certificate");
			}
			return new NSData(intPtr);
		}
	}

	public IntPtr Handle => handle;

	internal SecCertificate(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal SecCertificate(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecCertificateGetTypeID")]
	public static extern int GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecCertificateCreateWithData(IntPtr allocator, IntPtr cfData);

	public SecCertificate(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Initialize(data);
	}

	public SecCertificate(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using NSData data2 = NSData.FromArray(data);
		Initialize(data2);
	}

	public SecCertificate(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using NSData data = NSData.FromArray(certificate.Export(X509ContentType.Cert));
		Initialize(data);
	}

	public SecCertificate(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using NSData data = NSData.FromArray(certificate.RawData);
		Initialize(data);
	}

	private void Initialize(NSData data)
	{
		handle = SecCertificateCreateWithData(IntPtr.Zero, data.Handle);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("Not a valid DER-encoded X.509 certificate");
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecCertificateCopySubjectSummary(IntPtr cert);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecCertificateCopyData(IntPtr cert);

	~SecCertificate()
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

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecTrust : INativeObject, IDisposable
{
	private IntPtr handle;

	public int Count
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				return 0;
			}
			return (int)SecTrustGetCertificateCount(handle);
		}
	}

	public SecCertificate this[int index]
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecTrust");
			}
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return new SecCertificate(SecTrustGetCertificateAtIndex(handle, index));
		}
	}

	public IntPtr Handle => handle;

	internal SecTrust(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal SecTrust(IntPtr handle, bool owns)
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

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecTrustGetTypeID")]
	public static extern int GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustCreateWithCertificates(IntPtr certOrCertArray, IntPtr policies, out IntPtr sectrustref);

	public SecTrust(X509Certificate certificate, SecPolicy policy)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using SecCertificate secCertificate = new SecCertificate(certificate);
		Initialize(secCertificate.Handle, policy);
	}

	public SecTrust(X509Certificate2 certificate, SecPolicy policy)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using SecCertificate secCertificate = new SecCertificate(certificate);
		Initialize(secCertificate.Handle, policy);
	}

	public SecTrust(X509CertificateCollection certificates, SecPolicy policy)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		foreach (X509Certificate certificate in certificates)
		{
			array[num++] = new SecCertificate(certificate);
		}
		Initialize(array, policy);
	}

	public SecTrust(X509Certificate2Collection certificates, SecPolicy policy)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			array[num++] = new SecCertificate(current);
		}
		Initialize(array, policy);
	}

	private void Initialize(SecCertificate[] array, SecPolicy policy)
	{
		using CFArray cFArray = CFArray.FromNativeObjects(array);
		Initialize(cFArray.Handle, policy);
	}

	private void Initialize(IntPtr certHandle, SecPolicy policy)
	{
		if (policy == null)
		{
			throw new ArgumentNullException("policy");
		}
		SecStatusCode secStatusCode = SecTrustCreateWithCertificates(certHandle, policy.Handle, out handle);
		if (secStatusCode != 0)
		{
			throw new ArgumentException(secStatusCode.ToString());
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustEvaluate(IntPtr trust, out SecTrustResult result);

	public SecTrustResult Evaluate()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		SecTrustResult result;
		SecStatusCode secStatusCode = SecTrustEvaluate(handle, out result);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern long SecTrustGetCertificateCount(IntPtr trust);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecTrustGetCertificateAtIndex(IntPtr trust, long ix);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecTrustCopyPublicKey(IntPtr trust);

	public SecKey GetPublicKey()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return new SecKey(SecTrustCopyPublicKey(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecTrustCopyExceptions(IntPtr trust);

	public NSData GetExceptions()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return new NSData(SecTrustCopyExceptions(handle), owns: false);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern bool SecTrustSetExceptions(IntPtr trust, IntPtr exceptions);

	public bool SetExceptions(NSData data)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		IntPtr exceptions = data?.Handle ?? IntPtr.Zero;
		return SecTrustSetExceptions(handle, exceptions);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern double SecTrustGetVerifyTime(IntPtr trust);

	public double GetVerifyTime()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return SecTrustGetVerifyTime(handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetVerifyDate(IntPtr trust, IntPtr verifyDate);

	public SecStatusCode SetVerifyDate(DateTime date)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		using NSDate nSDate = (NSDate)date;
		return SecTrustSetVerifyDate(handle, nSDate.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetAnchorCertificates(IntPtr trust, IntPtr anchorCertificates);

	public SecStatusCode SetAnchorCertificates(X509CertificateCollection certificates)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		if (certificates == null)
		{
			return SecTrustSetAnchorCertificates(handle, IntPtr.Zero);
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		foreach (X509Certificate certificate in certificates)
		{
			array[num++] = new SecCertificate(certificate);
		}
		return SetAnchorCertificates(array);
	}

	public SecStatusCode SetAnchorCertificates(X509Certificate2Collection certificates)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		if (certificates == null)
		{
			return SecTrustSetAnchorCertificates(handle, IntPtr.Zero);
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			array[num++] = new SecCertificate(current);
		}
		return SetAnchorCertificates(array);
	}

	private SecStatusCode SetAnchorCertificates(SecCertificate[] array)
	{
		using CFArray cFArray = CFArray.FromNativeObjects(array);
		return SecTrustSetAnchorCertificates(handle, cFArray.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetAnchorCertificatesOnly(IntPtr trust, bool anchorCertificatesOnly);

	public SecStatusCode SetAnchorCertificatesOnly(bool anchorCertificatesOnly)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return SecTrustSetAnchorCertificatesOnly(handle, anchorCertificatesOnly);
	}

	~SecTrust()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}

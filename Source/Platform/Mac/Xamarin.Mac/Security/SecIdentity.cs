using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecIdentity : INativeObject, IDisposable
{
	internal IntPtr handle;

	public SecKey PrivateKey
	{
		get
		{
			IntPtr privatekey;
			SecStatusCode secStatusCode = SecIdentityCopyPrivateKey(handle, out privatekey);
			if (secStatusCode != 0)
			{
				throw new InvalidOperationException(secStatusCode.ToString());
			}
			return new SecKey(privatekey, owns: true);
		}
	}

	public SecCertificate Certificate
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecIdentity");
			}
			IntPtr certificateRef;
			SecStatusCode secStatusCode = SecIdentityCopyCertificate(handle, out certificateRef);
			if (secStatusCode != 0)
			{
				throw new InvalidOperationException(secStatusCode.ToString());
			}
			return new SecCertificate(certificateRef, owns: true);
		}
	}

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecIdentityCopyPrivateKey(IntPtr identity, out IntPtr privatekey);

	public SecIdentity(IntPtr handle)
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
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecIdentityCopyCertificate(IntPtr identityRef, out IntPtr certificateRef);

	public static SecIdentity Import(byte[] data, string password)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("password");
		}
		using NSString obj = new NSString(password);
		using NSDictionary options = NSDictionary.FromObjectAndKey(obj, SecImportExport.Passphrase);
		NSDictionary[] array;
		SecStatusCode secStatusCode = SecImportExport.ImportPkcs12(data, options, out array);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return new SecIdentity(array[0].LowlevelObjectForKey(SecImportExport.Identity.Handle));
	}

	public static SecIdentity Import(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!certificate.HasPrivateKey)
		{
			throw new InvalidOperationException("Need X509Certificate2 with a private key.");
		}
		string password = Guid.NewGuid().ToString();
		byte[] data = certificate.Export(X509ContentType.Pfx, password);
		return Import(data, password);
	}

	~SecIdentity()
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
}

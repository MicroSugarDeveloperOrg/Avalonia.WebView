using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

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
			return CFString.FetchString(SecCertificateCopySubjectSummary(handle), releaseHandle: true);
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
			return new NSData(intPtr, owns: true);
		}
	}

	public IntPtr Handle => handle;

	public SecCertificate(IntPtr handle)
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
	public static extern nint GetTypeID();

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
		using NSData data = NSData.FromArray(certificate.GetRawCertData());
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

	private byte[] GetRawData()
	{
		using NSData nSData = DerData;
		int num = (int)nSData.Length;
		byte[] array = new byte[num];
		Marshal.Copy(nSData.Bytes, array, 0, num);
		return array;
	}

	public X509Certificate ToX509Certificate()
	{
		return new X509Certificate(GetRawData());
	}

	public X509Certificate2 ToX509Certificate2()
	{
		return new X509Certificate2(GetRawData());
	}

	internal static bool Equals(SecCertificate first, SecCertificate second)
	{
		if (first == null)
		{
			throw new ArgumentNullException("first");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		if (first.Handle == second.Handle)
		{
			return true;
		}
		using NSData nSData = first.DerData;
		using NSData nSData2 = second.DerData;
		if (nSData.Handle == nSData2.Handle)
		{
			return true;
		}
		if (nSData.Length != nSData2.Length)
		{
			return false;
		}
		nint nint = (nint)nSData.Length;
		for (nint nint2 = 0; nint2 < nint; ++nint2)
		{
			if (nSData[nint2] != nSData2[nint2])
			{
				return false;
			}
		}
		return true;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecCertificateCopyValues(IntPtr certificate, IntPtr keys, IntPtr error);

	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetKey' instead.")]
	public NSData GetPublicKey()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecCertificate");
		}
		IntPtr intPtr;
		using (NSArray nSArray = NSArray.FromIntPtrs(new IntPtr[1] { SecCertificateOIDs.SubjectPublicKey }))
		{
			intPtr = SecCertificateCopyValues(handle, nSArray.Handle, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				throw new ArgumentException("Not a valid certificate");
			}
		}
		using NSDictionary nSDictionary = new NSDictionary(intPtr, alloced: true);
		IntPtr intPtr2 = nSDictionary.LowlevelObjectForKey(SecCertificateOIDs.SubjectPublicKey);
		if (intPtr2 == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSDictionary2 = new NSDictionary(intPtr2, alloced: false);
		IntPtr intPtr3 = nSDictionary2.LowlevelObjectForKey(SecPropertyKey.Value);
		if (intPtr3 == IntPtr.Zero)
		{
			return null;
		}
		return new NSData(intPtr3);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	[Watch(5, 0)]
	private static extern IntPtr SecCertificateCopyKey(IntPtr key);

	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	[Watch(5, 0)]
	public SecKey GetKey()
	{
		IntPtr intPtr = SecCertificateCopyKey(handle);
		return (intPtr == IntPtr.Zero) ? null : new SecKey(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 3)]
	[TV(10, 3)]
	[Watch(3, 3)]
	private static extern int SecCertificateCopyCommonName(IntPtr certificate, out IntPtr commonName);

	[iOS(10, 3)]
	[TV(10, 3)]
	[Watch(3, 3)]
	public string GetCommonName()
	{
		if (SecCertificateCopyCommonName(handle, out var commonName) == 0)
		{
			return CFString.FetchString(commonName, releaseHandle: true);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 3)]
	[TV(10, 3)]
	[Watch(3, 3)]
	private static extern int SecCertificateCopyEmailAddresses(IntPtr certificate, out IntPtr emailAddresses);

	[iOS(10, 3)]
	[TV(10, 3)]
	[Watch(3, 3)]
	public string[] GetEmailAddresses()
	{
		string[] result = null;
		if (SecCertificateCopyEmailAddresses(handle, out var emailAddresses) == 0)
		{
			result = NSArray.StringArrayFromHandle(emailAddresses);
			if (emailAddresses != IntPtr.Zero)
			{
				CFObject.CFRelease(emailAddresses);
			}
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 3)]
	[Mac(10, 12, 4)]
	[TV(10, 3)]
	[Watch(3, 3)]
	private static extern IntPtr SecCertificateCopyNormalizedIssuerSequence(IntPtr certificate);

	[iOS(10, 3)]
	[Mac(10, 12, 4)]
	[TV(10, 3)]
	[Watch(3, 3)]
	public NSData GetNormalizedIssuerSequence()
	{
		IntPtr intPtr = SecCertificateCopyNormalizedIssuerSequence(handle);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 3)]
	[Mac(10, 12, 4)]
	[TV(10, 3)]
	[Watch(3, 3)]
	private static extern IntPtr SecCertificateCopyNormalizedSubjectSequence(IntPtr certificate);

	[iOS(10, 3)]
	[Mac(10, 12, 4)]
	[TV(10, 3)]
	[Watch(3, 3)]
	public NSData GetNormalizedSubjectSequence()
	{
		IntPtr intPtr = SecCertificateCopyNormalizedSubjectSequence(handle);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecCertificateCopySerialNumber(IntPtr certificate, IntPtr error);

	[iOS(10, 3)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetSerialNumber(out NSError)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetSerialNumber(out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'GetSerialNumber(out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetSerialNumber(out NSError)' instead.")]
	public NSData GetSerialNumber()
	{
		IntPtr intPtr = SecCertificateCopySerialNumber(handle, IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	private static extern IntPtr SecCertificateCopySerialNumberData(IntPtr certificate, ref IntPtr error);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	public NSData GetSerialNumber(out NSError error)
	{
		IntPtr error2 = IntPtr.Zero;
		IntPtr intPtr = SecCertificateCopySerialNumberData(handle, ref error2);
		error = Runtime.GetNSObject<NSError>(error2);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	~SecCertificate()
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

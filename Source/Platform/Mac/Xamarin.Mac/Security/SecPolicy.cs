using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Security;

public class SecPolicy : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public SecPolicy(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal SecPolicy(IntPtr handle, bool owns)
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

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecPolicyCreateSSL(bool server, IntPtr hostname);

	public static SecPolicy CreateSslPolicy(bool server, string hostName)
	{
		NSString nSString = ((hostName == null) ? null : new NSString(hostName));
		IntPtr hostname = ((nSString == null) ? IntPtr.Zero : nSString.Handle);
		SecPolicy result = new SecPolicy(SecPolicyCreateSSL(server, hostname), owns: true);
		if (nSString != null)
		{
			nSString.Dispose();
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecPolicyCreateBasicX509();

	public static SecPolicy CreateBasicX509Policy()
	{
		return new SecPolicy(SecPolicyCreateBasicX509(), owns: true);
	}

	~SecPolicy()
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

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecPolicyGetTypeID")]
	public static extern nint GetTypeID();

	public static bool operator ==(SecPolicy a, SecPolicy b)
	{
		if ((object)a == null)
		{
			return (object)b == null;
		}
		if ((object)b == null)
		{
			return false;
		}
		return a.Handle == b.Handle;
	}

	public static bool operator !=(SecPolicy a, SecPolicy b)
	{
		if ((object)a == null)
		{
			return (object)b != null;
		}
		if ((object)b == null)
		{
			return true;
		}
		return a.Handle != b.Handle;
	}

	public override bool Equals(object other)
	{
		SecPolicy secPolicy = other as SecPolicy;
		return this == secPolicy;
	}

	public override int GetHashCode()
	{
		return (int)Handle;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	private static extern IntPtr SecPolicyCopyProperties(IntPtr policyRef);

	[iOS(7, 0)]
	public NSDictionary GetProperties()
	{
		IntPtr ptr = SecPolicyCopyProperties(Handle);
		return Runtime.GetNSObject<NSDictionary>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Mac(10, 9)]
	private static extern IntPtr SecPolicyCreateRevocation(nuint revocationFlags);

	[Mac(10, 9)]
	[iOS(7, 0)]
	public static SecPolicy CreateRevocationPolicy(SecRevocation revocationFlags)
	{
		IntPtr intPtr = SecPolicyCreateRevocation((nuint)(ulong)revocationFlags);
		return (intPtr == IntPtr.Zero) ? null : new SecPolicy(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Mac(10, 9)]
	[iOS(7, 0)]
	private static extern IntPtr SecPolicyCreateWithProperties(IntPtr policyIdentifier, IntPtr properties);

	[Mac(10, 9)]
	[iOS(7, 0)]
	public static SecPolicy CreatePolicy(NSString policyIdentifier, NSDictionary properties)
	{
		if (policyIdentifier == null)
		{
			throw new ArgumentNullException("policyIdentifier");
		}
		IntPtr properties2 = properties?.Handle ?? IntPtr.Zero;
		IntPtr intPtr = SecPolicyCreateWithProperties(policyIdentifier.Handle, properties2);
		if (intPtr == IntPtr.Zero)
		{
			throw new ArgumentException("Unknown policyIdentifier");
		}
		return new SecPolicy(intPtr, owns: true);
	}
}

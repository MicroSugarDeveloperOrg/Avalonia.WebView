using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecPolicy : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	internal SecPolicy(IntPtr handle)
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
		CFString cFString = ((hostName == null) ? null : new CFString(hostName));
		IntPtr hostname = cFString?.Handle ?? IntPtr.Zero;
		SecPolicy result = new SecPolicy(SecPolicyCreateSSL(server, hostname), owns: true);
		cFString?.Dispose();
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
	public static extern int GetTypeID();

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
}

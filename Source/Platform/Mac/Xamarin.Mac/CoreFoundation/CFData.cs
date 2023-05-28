using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFData : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public nint Length => CFDataGetLength(handle);

	public IntPtr Bytes => CFDataGetBytePtr(handle);

	public CFData(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	public CFData(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFData()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFDataGetTypeID")]
	public static extern nint GetTypeID();

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public static CFData FromDataNoCopy(IntPtr buffer, nint length)
	{
		return new CFData(CFDataCreateWithBytesNoCopy(IntPtr.Zero, buffer, length, CFAllocator.null_ptr), owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreateWithBytesNoCopy(IntPtr allocator, IntPtr bytes, nint length, IntPtr bytesDeallocator);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFDataGetLength(IntPtr theData);

	public byte[] GetBuffer()
	{
		byte[] array = new byte[(long)Length];
		IntPtr source = CFDataGetBytePtr(handle);
		Marshal.Copy(source, array, 0, array.Length);
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataGetBytePtr(IntPtr theData);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreate(IntPtr allocator, IntPtr bytes, nint length);

	public static CFData FromData(IntPtr buffer, nint length)
	{
		return new CFData(CFDataCreate(IntPtr.Zero, buffer, length), owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreateCopy(IntPtr allocator, IntPtr theData);

	public CFData Copy()
	{
		return new CFData(CFDataCreateCopy(IntPtr.Zero, Handle), owns: true);
	}
}

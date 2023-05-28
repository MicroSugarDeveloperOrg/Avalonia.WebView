using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Security;

[Mac(10, 10)]
[iOS(8, 0)]
public class SecAccessControl : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				handle = SecAccessControlCreateWithFlags(IntPtr.Zero, KeysAccessible.FromSecAccessible(Accessible), (int)Flags, out var _);
			}
			return handle;
		}
		internal set
		{
			handle = value;
		}
	}

	public SecAccessible Accessible { get; private set; }

	public SecAccessControlCreateFlags Flags { get; private set; }

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal SecAccessControl(IntPtr handle)
	{
		Handle = handle;
	}

	public SecAccessControl(SecAccessible accessible, SecAccessControlCreateFlags flags = SecAccessControlCreateFlags.UserPresence)
	{
		Accessible = accessible;
		Flags = flags;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	~SecAccessControl()
	{
		Dispose(disposing: false);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private static extern IntPtr SecAccessControlCreateWithFlags(IntPtr allocator, IntPtr protection, nint flags, out IntPtr error);
}

using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFBoolean : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public bool Value => CFBooleanGetValue(handle);

	[Field("kCFBooleanFalse", "CoreFoundation")]
	internal static IntPtr FalseHandle => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFBooleanFalse");

	[Field("kCFBooleanTrue", "CoreFoundation")]
	internal static IntPtr TrueHandle => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFBooleanTrue");

	[Preserve(Conditional = true)]
	internal CFBoolean(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CFBoolean()
	{
		Dispose(disposing: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFBooleanGetTypeID")]
	public static extern nint GetTypeID();

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

	public static implicit operator bool(CFBoolean value)
	{
		return value.Value;
	}

	public static explicit operator CFBoolean(bool value)
	{
		return FromBoolean(value);
	}

	internal static IntPtr ToHandle(bool value)
	{
		return value ? TrueHandle : FalseHandle;
	}

	public static CFBoolean FromBoolean(bool value)
	{
		return new CFBoolean(value ? TrueHandle : FalseHandle, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFBooleanGetValue(IntPtr boolean);

	public static bool GetValue(IntPtr boolean)
	{
		return CFBooleanGetValue(boolean);
	}
}

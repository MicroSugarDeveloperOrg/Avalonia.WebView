using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

[Mac(10, 12)]
[iOS(10, 0)]
[Watch(3, 0)]
[TV(10, 0)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public sealed class OSLog : NativeObject
{
	private static OSLog _default;

	public static OSLog Default
	{
		get
		{
			if (_default == null)
			{
				IntPtr intPtr = Dlfcn.dlsym(Libraries.System.Handle, "_os_log_default");
				if (intPtr == IntPtr.Zero)
				{
					throw new NotSupportedException("Feature not available on this OS version");
				}
				_default = new OSLog(intPtr, owns: false);
			}
			return _default;
		}
	}

	protected override void Retain()
	{
		if (base.Handle != IntPtr.Zero)
		{
			os_retain(base.Handle);
		}
	}

	protected override void Release()
	{
		if (base.Handle != IntPtr.Zero)
		{
			os_release(base.Handle);
		}
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr os_log_create(string subsystem, string category);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr os_retain(IntPtr handle);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern void os_release(IntPtr handle);

	[DllImport("__Internal")]
	private static extern void xamarin_os_log(IntPtr logHandle, OSLogLevel level, string message);

	private OSLog(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public OSLog(string subsystem, string category)
	{
		if (subsystem == null)
		{
			throw new ArgumentNullException("subsystem");
		}
		if (category == null)
		{
			throw new ArgumentNullException("category");
		}
		base.Handle = os_log_create(subsystem, category);
	}

	public void Log(string message)
	{
		Log(OSLogLevel.Default, message);
	}

	public void Log(OSLogLevel level, string message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		xamarin_os_log(base.Handle, level, message);
	}
}

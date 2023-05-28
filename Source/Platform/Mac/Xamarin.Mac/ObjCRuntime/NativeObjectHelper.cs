using System;

namespace ObjCRuntime;

internal static class NativeObjectHelper
{
	public static IntPtr GetHandle(this INativeObject self)
	{
		return self?.Handle ?? IntPtr.Zero;
	}
}

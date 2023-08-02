using System;

namespace CoreFoundation;

internal struct CFRunLoopSourceContext
{
	public CFIndex Version;

	public IntPtr Info;

	public IntPtr Retain;

	public IntPtr Release;

	public IntPtr CopyDescription;

	public IntPtr Equal;

	public IntPtr Hash;

	public IntPtr Schedule;

	public IntPtr Cancel;

	public IntPtr Perform;
}

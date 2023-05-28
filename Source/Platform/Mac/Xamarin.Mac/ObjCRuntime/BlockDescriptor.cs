using System;

namespace ObjCRuntime;

internal struct BlockDescriptor
{
	public IntPtr reserved;

	public IntPtr size;

	public IntPtr copy_helper;

	public IntPtr dispose;

	public IntPtr signature;
}

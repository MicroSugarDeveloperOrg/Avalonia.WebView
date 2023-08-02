using System;

namespace Darwin;

public struct KernelEvent
{
	public IntPtr Ident;

	public EventFilter Filter;

	public EventFlags Flags;

	public uint FilterFlags;

	public IntPtr Data;

	public IntPtr UserData;
}

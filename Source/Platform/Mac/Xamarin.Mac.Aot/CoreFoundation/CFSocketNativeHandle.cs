namespace CoreFoundation;

public struct CFSocketNativeHandle
{
	internal readonly int handle;

	internal CFSocketNativeHandle(int handle)
	{
		this.handle = handle;
	}

	public override string ToString()
	{
		return $"[CFSocketNativeHandle {handle}]";
	}
}

using System;

namespace Security;

internal struct AuthorizationItem
{
	public IntPtr name;

	public nint valueLen;

	public IntPtr value;

	public int flags;
}

using System;

namespace Security;

internal struct AuthorizationItem
{
	public IntPtr name;

	public IntPtr valueLen;

	public IntPtr value;

	public int flags;
}

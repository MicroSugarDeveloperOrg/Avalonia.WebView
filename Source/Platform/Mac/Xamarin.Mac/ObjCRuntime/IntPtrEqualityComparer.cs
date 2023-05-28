using System;
using System.Collections.Generic;

namespace ObjCRuntime;

internal class IntPtrEqualityComparer : IEqualityComparer<IntPtr>
{
	public bool Equals(IntPtr x, IntPtr y)
	{
		return x == y;
	}

	public int GetHashCode(IntPtr obj)
	{
		return obj.GetHashCode();
	}
}

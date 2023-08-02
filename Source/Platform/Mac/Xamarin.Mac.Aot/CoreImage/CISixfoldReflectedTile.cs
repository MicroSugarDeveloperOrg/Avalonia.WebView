using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISixfoldReflectedTile : CITileFilter
{
	public CISixfoldReflectedTile()
		: base("CISixfoldReflectedTile")
	{
	}

	public CISixfoldReflectedTile(IntPtr handle)
		: base(handle)
	{
	}
}

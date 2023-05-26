using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIEightfoldReflectedTile : CITileFilter
{
	public CIEightfoldReflectedTile()
		: base("CIEightfoldReflectedTile")
	{
	}

	public CIEightfoldReflectedTile(IntPtr handle)
		: base(handle)
	{
	}
}

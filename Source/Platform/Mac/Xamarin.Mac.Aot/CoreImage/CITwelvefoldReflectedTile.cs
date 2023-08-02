using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CITwelvefoldReflectedTile : CITileFilter
{
	public CITwelvefoldReflectedTile()
		: base("CITwelvefoldReflectedTile")
	{
	}

	public CITwelvefoldReflectedTile(IntPtr handle)
		: base(handle)
	{
	}
}

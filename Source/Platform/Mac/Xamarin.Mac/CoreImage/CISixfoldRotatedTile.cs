using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISixfoldRotatedTile : CITileFilter
{
	public CISixfoldRotatedTile()
		: base("CISixfoldRotatedTile")
	{
	}

	public CISixfoldRotatedTile(IntPtr handle)
		: base(handle)
	{
	}
}

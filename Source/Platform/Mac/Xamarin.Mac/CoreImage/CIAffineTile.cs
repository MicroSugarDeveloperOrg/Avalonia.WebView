using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIAffineTile : CIAffineFilter
{
	public CIAffineTile()
		: base("CIAffineTile")
	{
	}

	public CIAffineTile(IntPtr handle)
		: base(handle)
	{
	}
}

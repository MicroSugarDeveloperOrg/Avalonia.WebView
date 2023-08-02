using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIAffineClamp : CIAffineFilter
{
	public CIAffineClamp()
		: base("CIAffineClamp")
	{
	}

	public CIAffineClamp(IntPtr handle)
		: base(handle)
	{
	}
}

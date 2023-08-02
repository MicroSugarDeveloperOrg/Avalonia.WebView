using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISourceOverCompositing : CICompositingFilter
{
	public CISourceOverCompositing()
		: base("CISourceOverCompositing")
	{
	}

	public CISourceOverCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

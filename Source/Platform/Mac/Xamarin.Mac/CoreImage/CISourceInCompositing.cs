using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISourceInCompositing : CICompositingFilter
{
	public CISourceInCompositing()
		: base("CISourceInCompositing")
	{
	}

	public CISourceInCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISourceAtopCompositing : CICompositingFilter
{
	public CISourceAtopCompositing()
		: base("CISourceAtopCompositing")
	{
	}

	public CISourceAtopCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

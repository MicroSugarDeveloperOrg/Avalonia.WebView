using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIMinimumCompositing : CICompositingFilter
{
	public CIMinimumCompositing()
		: base("CIMinimumCompositing")
	{
	}

	public CIMinimumCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

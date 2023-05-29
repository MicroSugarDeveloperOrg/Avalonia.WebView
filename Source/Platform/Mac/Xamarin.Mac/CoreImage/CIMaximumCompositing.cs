using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIMaximumCompositing : CICompositingFilter
{
	public CIMaximumCompositing()
		: base("CIMaximumCompositing")
	{
	}

	public CIMaximumCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

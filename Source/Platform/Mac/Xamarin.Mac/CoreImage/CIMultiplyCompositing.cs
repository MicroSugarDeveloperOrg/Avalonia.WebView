using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIMultiplyCompositing : CICompositingFilter
{
	public CIMultiplyCompositing()
		: base("CIMultiplyCompositing")
	{
	}

	public CIMultiplyCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIAdditionCompositing : CICompositingFilter
{
	public CIAdditionCompositing()
		: base("CIAdditionCompositing")
	{
	}

	public CIAdditionCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

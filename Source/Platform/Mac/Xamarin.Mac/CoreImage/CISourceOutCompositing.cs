using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISourceOutCompositing : CICompositingFilter
{
	public CISourceOutCompositing()
		: base("CISourceOutCompositing")
	{
	}

	public CISourceOutCompositing(IntPtr handle)
		: base(handle)
	{
	}
}

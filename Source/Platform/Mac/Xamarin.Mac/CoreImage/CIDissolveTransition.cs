using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIDissolveTransition : CITransitionFilter
{
	public CIDissolveTransition()
		: base("CIDissolveTransition")
	{
	}

	public CIDissolveTransition(IntPtr handle)
		: base(handle)
	{
	}
}

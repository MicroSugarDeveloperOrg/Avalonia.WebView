using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIHoleDistortion : CIDistortionFilter
{
	public CIHoleDistortion()
		: base("CIHoleDistortion")
	{
	}

	public CIHoleDistortion(IntPtr handle)
		: base(handle)
	{
	}
}

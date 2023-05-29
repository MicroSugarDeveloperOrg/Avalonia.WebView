using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CICircleSplashDistortion : CIDistortionFilter
{
	public CICircleSplashDistortion()
		: base("CICircleSplashDistortion")
	{
	}

	public CICircleSplashDistortion(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIVortexDistortion : CIDistortionFilter
{
	public float Angle
	{
		get
		{
			return GetFloat("inputAngle");
		}
		set
		{
			SetFloat("inputAngle", value);
		}
	}

	public CIVortexDistortion()
		: base("CIVortexDistortion")
	{
	}

	public CIVortexDistortion(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIHatchedScreen : CIScreenFilter
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

	public CIHatchedScreen()
		: base("CIHatchedScreen")
	{
	}

	public CIHatchedScreen(IntPtr handle)
		: base(handle)
	{
	}
}

using System;

namespace CoreImage;

public class CIHueAdjust : CIFilter
{
	public CIImage Image
	{
		get
		{
			return GetInputImage();
		}
		set
		{
			SetInputImage(value);
		}
	}

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

	public CIHueAdjust()
		: base(CIFilter.CreateFilter("CIHueAdjust"))
	{
	}

	public CIHueAdjust(IntPtr handle)
		: base(handle)
	{
	}
}

using System;

namespace CoreImage;

public class CIStraightenFilter : CIFilter
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

	public CIStraightenFilter()
		: base(CIFilter.CreateFilter("CIStraightenFilter"))
	{
	}

	public CIStraightenFilter(IntPtr handle)
		: base(handle)
	{
	}
}

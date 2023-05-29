using System;

namespace CoreImage;

public class CIExposureAdjust : CIFilter
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

	public float EV
	{
		get
		{
			return GetFloat("inputEV");
		}
		set
		{
			SetFloat("inputEV", value);
		}
	}

	public CIExposureAdjust()
		: base(CIFilter.CreateFilter("CIExposureAdjust"))
	{
	}

	public CIExposureAdjust(IntPtr handle)
		: base(handle)
	{
	}
}

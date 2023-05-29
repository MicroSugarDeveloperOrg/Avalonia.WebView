using System;

namespace CoreImage;

public class CIGammaAdjust : CIFilter
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

	public float Power
	{
		get
		{
			return GetFloat("inputPower");
		}
		set
		{
			SetFloat("inputPower", value);
		}
	}

	public CIGammaAdjust()
		: base(CIFilter.CreateFilter("CIGammaAdjust"))
	{
	}

	public CIGammaAdjust(IntPtr handle)
		: base(handle)
	{
	}
}

using System;

namespace CoreImage;

public class CISepiaTone : CIFilter
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

	public float Intensity
	{
		get
		{
			return GetFloat("inputIntensity");
		}
		set
		{
			SetFloat("inputIntensity", value);
		}
	}

	public CISepiaTone()
		: base(CIFilter.CreateFilter("CISepiaTone"))
	{
	}

	public CISepiaTone(IntPtr handle)
		: base(handle)
	{
	}
}

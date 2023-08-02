using System;

namespace CoreImage;

public class CIColorMonochrome : CIFilter
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

	public CIColor Color
	{
		get
		{
			return GetColor("inputColor");
		}
		set
		{
			SetValue("inputColor", value);
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

	public CIColorMonochrome()
		: base(CIFilter.CreateFilter("CIColorMonochrome"))
	{
	}

	public CIColorMonochrome(IntPtr handle)
		: base(handle)
	{
	}
}

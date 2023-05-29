using System;

namespace CoreImage;

public class CIColorControls : CIFilter
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

	public float Saturation
	{
		get
		{
			return GetFloat("inputSaturation");
		}
		set
		{
			SetFloat("inputSaturation", value);
		}
	}

	public float Brightness
	{
		get
		{
			return GetFloat("inputBrightness");
		}
		set
		{
			SetFloat("inputBrightness", value);
		}
	}

	public float Contrast
	{
		get
		{
			return GetFloat("inputContrast");
		}
		set
		{
			SetFloat("inputContrast", value);
		}
	}

	public CIColorControls()
		: base(CIFilter.CreateFilter("CIColorControls"))
	{
	}

	public CIColorControls(IntPtr handle)
		: base(handle)
	{
	}
}

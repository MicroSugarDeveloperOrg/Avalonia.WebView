using System;

namespace CoreImage;

public class CIVibrance : CIFilter
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

	public float Amount
	{
		get
		{
			return GetFloat("inputAmount");
		}
		set
		{
			SetFloat("inputAmount", value);
		}
	}

	public CIVibrance()
		: base(CIFilter.CreateFilter("CIVibrance"))
	{
	}

	public CIVibrance(IntPtr handle)
		: base(handle)
	{
	}
}

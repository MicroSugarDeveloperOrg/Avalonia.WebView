using System;

namespace CoreImage;

public class CIColorInvert : CIFilter
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

	public CIColorInvert()
		: base(CIFilter.CreateFilter("CIColorInvert"))
	{
	}

	public CIColorInvert(IntPtr handle)
		: base(handle)
	{
	}
}

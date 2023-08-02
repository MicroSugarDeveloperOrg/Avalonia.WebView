using System;

namespace CoreImage;

public class CIWhitePointAdjust : CIFilter
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

	public CIWhitePointAdjust()
		: base(CIFilter.CreateFilter("CIWhitePointAdjust"))
	{
	}

	public CIWhitePointAdjust(IntPtr handle)
		: base(handle)
	{
	}
}

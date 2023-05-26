using System;

namespace CoreImage;

public class CIFalseColor : CIFilter
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

	public CIColor Color0
	{
		get
		{
			return GetColor("inputColor0");
		}
		set
		{
			SetValue("inputColor0", value);
		}
	}

	public CIColor Color1
	{
		get
		{
			return GetColor("inputColor1");
		}
		set
		{
			SetValue("inputColor1", value);
		}
	}

	public CIFalseColor()
		: base(CIFilter.CreateFilter("CIFalseColor"))
	{
	}

	public CIFalseColor(IntPtr handle)
		: base(handle)
	{
	}
}

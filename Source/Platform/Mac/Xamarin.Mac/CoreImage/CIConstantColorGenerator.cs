using System;

namespace CoreImage;

public class CIConstantColorGenerator : CIFilter
{
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

	public CIConstantColorGenerator()
		: base(CIFilter.CreateFilter("CIConstantColorGenerator"))
	{
	}

	public CIConstantColorGenerator(IntPtr handle)
		: base(handle)
	{
	}
}

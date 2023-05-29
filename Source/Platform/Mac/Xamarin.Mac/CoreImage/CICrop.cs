using System;

namespace CoreImage;

public class CICrop : CIFilter
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

	public CIVector Rectangle
	{
		get
		{
			return GetVector("inputRectangle");
		}
		set
		{
			SetValue("inputRectangle", value);
		}
	}

	public CICrop()
		: base(CIFilter.CreateFilter("CICrop"))
	{
	}

	public CICrop(IntPtr handle)
		: base(handle)
	{
	}
}

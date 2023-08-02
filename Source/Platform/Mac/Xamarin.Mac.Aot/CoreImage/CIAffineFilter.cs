using System;

namespace CoreImage;

public abstract class CIAffineFilter : CIFilter
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

	protected CIAffineFilter(string name)
		: base(CIFilter.CreateFilter(name))
	{
	}

	protected CIAffineFilter(IntPtr handle)
		: base(handle)
	{
	}
}

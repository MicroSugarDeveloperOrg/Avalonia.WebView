using System;

namespace CoreImage;

public abstract class CICompositingFilter : CIFilter
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

	public CIImage BackgroundImage
	{
		get
		{
			return GetBackgroundImage();
		}
		set
		{
			SetBackgroundImage(value);
		}
	}

	protected CICompositingFilter(string name)
		: base(name)
	{
	}

	protected CICompositingFilter(IntPtr handle)
		: base(handle)
	{
	}
}

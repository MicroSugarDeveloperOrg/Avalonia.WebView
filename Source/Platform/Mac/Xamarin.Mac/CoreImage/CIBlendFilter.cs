using System;

namespace CoreImage;

public abstract class CIBlendFilter : CIFilter
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

	protected CIBlendFilter(string name)
		: base(name)
	{
	}

	protected CIBlendFilter(IntPtr handle)
		: base(handle)
	{
	}
}

using System;

namespace CoreImage;

public abstract class CIDistortionFilter : CIFilter
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

	public CIVector Center
	{
		get
		{
			return GetVector("inputCenter");
		}
		set
		{
			SetValue("inputCenter", value);
		}
	}

	public float Radius
	{
		get
		{
			return GetFloat("inputRadius");
		}
		set
		{
			SetFloat("inputRadius", value);
		}
	}

	protected CIDistortionFilter(string name)
		: base(name)
	{
	}

	protected CIDistortionFilter(IntPtr handle)
		: base(handle)
	{
	}
}

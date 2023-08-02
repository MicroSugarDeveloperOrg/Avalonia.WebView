using System;

namespace CoreImage;

public class CIGaussianGradient : CIFilter
{
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

	public CIGaussianGradient()
		: base(CIFilter.CreateFilter("CIGaussianGradient"))
	{
	}

	public CIGaussianGradient(IntPtr handle)
		: base(handle)
	{
	}
}

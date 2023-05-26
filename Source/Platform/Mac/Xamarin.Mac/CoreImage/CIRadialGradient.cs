using System;

namespace CoreImage;

public class CIRadialGradient : CIFilter
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

	public float Radius0
	{
		get
		{
			return GetFloat("inputRadius0");
		}
		set
		{
			SetFloat("inputRadius0", value);
		}
	}

	public float Radius1
	{
		get
		{
			return GetFloat("inputRadius1");
		}
		set
		{
			SetFloat("inputRadius1", value);
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

	public CIRadialGradient()
		: base(CIFilter.CreateFilter("CIRadialGradient"))
	{
	}

	public CIRadialGradient(IntPtr handle)
		: base(handle)
	{
	}
}

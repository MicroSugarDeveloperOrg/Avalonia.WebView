using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIBloom : CIFilter
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

	public float Intensity
	{
		get
		{
			return GetFloat("inputIntensity");
		}
		set
		{
			SetFloat("inputIntensity", value);
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

	public CIBloom()
		: base("CIBloom")
	{
	}

	public CIBloom(IntPtr handle)
		: base(handle)
	{
	}
}

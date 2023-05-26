using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIGaussianBlur : CIFilter
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

	public CIGaussianBlur()
		: base("CIGaussianBlur")
	{
	}

	public CIGaussianBlur(IntPtr handle)
		: base(handle)
	{
	}
}

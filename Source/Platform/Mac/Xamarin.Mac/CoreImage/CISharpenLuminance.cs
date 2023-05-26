using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CISharpenLuminance : CIFilter
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

	public float Sharpness
	{
		get
		{
			return GetFloat("inputSharpness");
		}
		set
		{
			SetFloat("inputSharpness", value);
		}
	}

	public CISharpenLuminance()
		: base("CISharpenLuminance")
	{
	}

	public CISharpenLuminance(IntPtr handle)
		: base(handle)
	{
	}
}

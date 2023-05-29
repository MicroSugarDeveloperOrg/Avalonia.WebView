using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIDepthOfField : CIFilter
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

	public CIVector Point1
	{
		get
		{
			return GetVector("inputPoint1");
		}
		set
		{
			SetValue("inputPoint1", value);
		}
	}

	public CIVector Point2
	{
		get
		{
			return GetVector("inputPoint2");
		}
		set
		{
			SetValue("inputPoint2", value);
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

	public float Saturation
	{
		get
		{
			return GetFloat("inputSaturation");
		}
		set
		{
			SetFloat("inputSaturation", value);
		}
	}

	public float UnsharpMaskIntensity
	{
		get
		{
			return GetFloat("inputUnsharpMaskIntensity");
		}
		set
		{
			SetFloat("inputUnsharpMaskIntensity", value);
		}
	}

	public float UnsharpMaskRadius
	{
		get
		{
			return GetFloat("inputUnsharpMaskRadius");
		}
		set
		{
			SetFloat("inputUnsharpMaskRadius", value);
		}
	}

	public CIDepthOfField()
		: base("CIDepthOfField")
	{
	}

	public CIDepthOfField(IntPtr handle)
		: base(handle)
	{
	}
}

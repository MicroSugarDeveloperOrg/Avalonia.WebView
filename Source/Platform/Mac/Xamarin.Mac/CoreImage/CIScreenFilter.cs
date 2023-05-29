using System;

namespace CoreImage;

public class CIScreenFilter : CIFilter
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

	public float Width
	{
		get
		{
			return GetFloat("inputWidth");
		}
		set
		{
			SetFloat("inputWidth", value);
		}
	}

	protected CIScreenFilter(string name)
		: base(name)
	{
	}

	protected CIScreenFilter(IntPtr handle)
		: base(handle)
	{
	}
}

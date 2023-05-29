using System;

namespace CoreImage;

public class CITileFilter : CIFilter
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

	public float Angle
	{
		get
		{
			return GetFloat("inputAngle");
		}
		set
		{
			SetFloat("inputAngle", value);
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

	protected CITileFilter(string name)
		: base(name)
	{
	}

	protected CITileFilter(IntPtr handle)
		: base(handle)
	{
	}
}

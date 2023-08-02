using System;

namespace CoreImage;

public abstract class CITransitionFilter : CIFilter
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

	public CIImage TargetImage
	{
		get
		{
			return GetImage("inputTargetImage");
		}
		set
		{
			SetImage("inputTargetImage", value);
		}
	}

	public float Time
	{
		get
		{
			return GetFloat("inputTime");
		}
		set
		{
			SetFloat("inputTime", value);
		}
	}

	protected CITransitionFilter(string name)
		: base(CIFilter.CreateFilter(name))
	{
	}

	protected CITransitionFilter(IntPtr handle)
		: base(handle)
	{
	}
}

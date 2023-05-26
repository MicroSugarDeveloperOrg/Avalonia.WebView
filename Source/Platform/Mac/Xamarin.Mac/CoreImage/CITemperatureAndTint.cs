using System;

namespace CoreImage;

public class CITemperatureAndTint : CIFilter
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

	public CIVector Neutral
	{
		get
		{
			return GetVector("inputNeutral");
		}
		set
		{
			SetValue("inputNeutral", value);
		}
	}

	public CIVector TargetNeutral
	{
		get
		{
			return GetVector("inputTargetNeutral");
		}
		set
		{
			SetValue("inputTargetNeutral", value);
		}
	}

	public CITemperatureAndTint()
		: base(CIFilter.CreateFilter("CITemperatureAndTint"))
	{
	}

	public CITemperatureAndTint(IntPtr handle)
		: base(handle)
	{
	}
}

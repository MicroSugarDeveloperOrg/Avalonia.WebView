using System;

namespace CoreImage;

public class CIToneCurve : CIFilter
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

	public CIVector Point0
	{
		get
		{
			return GetVector("inputPoint0");
		}
		set
		{
			SetValue("inputPoint0", value);
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

	public CIVector Point3
	{
		get
		{
			return GetVector("inputPoint3");
		}
		set
		{
			SetValue("inputPoint3", value);
		}
	}

	public CIVector Point4
	{
		get
		{
			return GetVector("inputPoint4");
		}
		set
		{
			SetValue("inputPoint4", value);
		}
	}

	public CIToneCurve()
		: base(CIFilter.CreateFilter("CIToneCurve"))
	{
	}

	public CIToneCurve(IntPtr handle)
		: base(handle)
	{
	}
}

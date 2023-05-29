using System;

namespace CoreImage;

public class CILinearGradient : CIFilter
{
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

	public CILinearGradient()
		: base(CIFilter.CreateFilter("CILinearGradient"))
	{
	}

	public CILinearGradient(IntPtr handle)
		: base(handle)
	{
	}
}

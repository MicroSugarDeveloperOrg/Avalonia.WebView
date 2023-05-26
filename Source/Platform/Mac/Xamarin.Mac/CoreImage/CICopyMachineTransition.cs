using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CICopyMachineTransition : CITransitionFilter
{
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

	public CIColor Color
	{
		get
		{
			return GetColor("inputColor");
		}
		set
		{
			SetValue("inputColor", value);
		}
	}

	public CIVector Extent
	{
		get
		{
			return GetVector("inputExtent");
		}
		set
		{
			SetValue("inputExtent", value);
		}
	}

	public float Opacity
	{
		get
		{
			return GetFloat("inputOpacity");
		}
		set
		{
			SetFloat("inputOpacity", value);
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

	public CICopyMachineTransition()
		: base("CICopyMachineTransition")
	{
	}

	public CICopyMachineTransition(IntPtr handle)
		: base(handle)
	{
	}
}

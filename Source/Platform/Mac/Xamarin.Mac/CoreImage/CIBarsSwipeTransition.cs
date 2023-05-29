using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIBarsSwipeTransition : CITransitionFilter
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

	public float BarOffset
	{
		get
		{
			return GetFloat("inputBarOffset");
		}
		set
		{
			SetFloat("inputBarOffset", value);
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

	public CIBarsSwipeTransition()
		: base("CIBarsSwipeTransition")
	{
	}

	public CIBarsSwipeTransition(IntPtr handle)
		: base(handle)
	{
	}
}

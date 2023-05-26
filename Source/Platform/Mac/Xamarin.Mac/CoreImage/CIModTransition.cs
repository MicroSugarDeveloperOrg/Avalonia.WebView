using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIModTransition : CITransitionFilter
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

	public float Compression
	{
		get
		{
			return GetFloat("inputCompression");
		}
		set
		{
			SetFloat("inputCompression", value);
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

	public CIModTransition()
		: base("CIModTransition")
	{
	}

	public CIModTransition(IntPtr handle)
		: base(handle)
	{
	}
}

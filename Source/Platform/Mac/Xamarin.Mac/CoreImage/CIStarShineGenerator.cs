using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIStarShineGenerator : CIFilter
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

	public float CrossAngle
	{
		get
		{
			return GetFloat("inputCrossAngle");
		}
		set
		{
			SetFloat("inputCrossAngle", value);
		}
	}

	public float CrossOpacity
	{
		get
		{
			return GetFloat("inputCrossOpacity");
		}
		set
		{
			SetFloat("inputCrossOpacity", value);
		}
	}

	public float CrossScale
	{
		get
		{
			return GetFloat("inputCrossScale");
		}
		set
		{
			SetFloat("inputCrossScale", value);
		}
	}

	public float CrossWidth
	{
		get
		{
			return GetFloat("inputCrossWidth");
		}
		set
		{
			SetFloat("inputCrossWidth", value);
		}
	}

	public float Epsilon
	{
		get
		{
			return GetFloat("inputEpsilon");
		}
		set
		{
			SetFloat("inputEpsilon", value);
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

	public CIStarShineGenerator()
		: base("CIStarShineGenerator")
	{
	}

	public CIStarShineGenerator(IntPtr handle)
		: base(handle)
	{
	}
}

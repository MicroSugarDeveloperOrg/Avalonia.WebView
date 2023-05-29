using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIPerspectiveTile : CIFilter
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

	public CIVector BottomLeft
	{
		get
		{
			return GetVector("inputBottomLeft");
		}
		set
		{
			SetValue("inputBottomLeft", value);
		}
	}

	public CIVector BottomRight
	{
		get
		{
			return GetVector("inputBottomRight");
		}
		set
		{
			SetValue("inputBottomRight", value);
		}
	}

	public CIVector TopLeft
	{
		get
		{
			return GetVector("inputTopLeft");
		}
		set
		{
			SetValue("inputTopLeft", value);
		}
	}

	public CIVector TopRight
	{
		get
		{
			return GetVector("inputTopRight");
		}
		set
		{
			SetValue("inputTopRight", value);
		}
	}

	public CIPerspectiveTile()
		: base("CIPerspectiveTile")
	{
	}

	public CIPerspectiveTile(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIPerspectiveTransform : CIFilter
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

	public CIPerspectiveTransform()
		: base("CIPerspectiveTransform")
	{
	}

	public CIPerspectiveTransform(IntPtr handle)
		: base(handle)
	{
	}
}

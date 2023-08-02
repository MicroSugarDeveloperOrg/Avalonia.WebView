using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIFourfoldReflectedTile : CITileFilter
{
	public float AcuteAngle
	{
		get
		{
			return GetFloat("inputAcuteAngle");
		}
		set
		{
			SetFloat("inputAcuteAngle", value);
		}
	}

	public CIFourfoldReflectedTile()
		: base("CIFourfoldReflectedTile")
	{
	}

	public CIFourfoldReflectedTile(IntPtr handle)
		: base(handle)
	{
	}
}

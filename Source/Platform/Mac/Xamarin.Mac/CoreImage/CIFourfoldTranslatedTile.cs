using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIFourfoldTranslatedTile : CITileFilter
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

	public CIFourfoldTranslatedTile()
		: base("CIFourfoldTranslatedTile")
	{
	}

	public CIFourfoldTranslatedTile(IntPtr handle)
		: base(handle)
	{
	}
}

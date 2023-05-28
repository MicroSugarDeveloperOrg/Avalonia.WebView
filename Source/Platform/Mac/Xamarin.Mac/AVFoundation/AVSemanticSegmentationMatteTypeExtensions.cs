using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVSemanticSegmentationMatteTypeExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("AVSemanticSegmentationMatteTypeSkin", "AVFoundation")]
	internal unsafe static IntPtr AVSemanticSegmentationMatteTypeSkin
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeSkin", storage);
			}
		}
	}

	[Field("AVSemanticSegmentationMatteTypeHair", "AVFoundation")]
	internal unsafe static IntPtr AVSemanticSegmentationMatteTypeHair
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeHair", storage);
			}
		}
	}

	[Field("AVSemanticSegmentationMatteTypeTeeth", "AVFoundation")]
	internal unsafe static IntPtr AVSemanticSegmentationMatteTypeTeeth
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVSemanticSegmentationMatteTypeTeeth", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVSemanticSegmentationMatteType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 1:
			ptr = AVSemanticSegmentationMatteTypeSkin;
			break;
		case 2:
			ptr = AVSemanticSegmentationMatteTypeHair;
			break;
		case 3:
			ptr = AVSemanticSegmentationMatteTypeTeeth;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVSemanticSegmentationMatteType GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return AVSemanticSegmentationMatteType.None;
		}
		if (constant.IsEqualTo(AVSemanticSegmentationMatteTypeSkin))
		{
			return AVSemanticSegmentationMatteType.Skin;
		}
		if (constant.IsEqualTo(AVSemanticSegmentationMatteTypeHair))
		{
			return AVSemanticSegmentationMatteType.Hair;
		}
		if (constant.IsEqualTo(AVSemanticSegmentationMatteTypeTeeth))
		{
			return AVSemanticSegmentationMatteType.Teeth;
		}
		return AVSemanticSegmentationMatteType.None;
	}
}

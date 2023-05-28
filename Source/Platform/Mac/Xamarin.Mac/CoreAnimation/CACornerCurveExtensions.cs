using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CACornerCurveExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("kCACornerCurveCircular", "CoreAnimation")]
	internal unsafe static IntPtr kCACornerCurveCircular
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCACornerCurveCircular", storage);
			}
		}
	}

	[Field("kCACornerCurveContinuous", "CoreAnimation")]
	internal unsafe static IntPtr kCACornerCurveContinuous
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCACornerCurveContinuous", storage);
			}
		}
	}

	public static NSString? GetConstant(this CACornerCurve self)
	{
		IntPtr zero = IntPtr.Zero;
		zero = ((self != 0 && self == CACornerCurve.Continuous) ? kCACornerCurveContinuous : kCACornerCurveCircular);
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CACornerCurve GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCACornerCurveCircular))
		{
			return CACornerCurve.Circular;
		}
		if (constant.IsEqualTo(kCACornerCurveContinuous))
		{
			return CACornerCurve.Continuous;
		}
		return CACornerCurve.Circular;
	}
}

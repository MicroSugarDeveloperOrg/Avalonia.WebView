using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CATextLayerAlignmentModeExtensions
{
	private static IntPtr[] values = new IntPtr[5];

	[Field("kCAAlignmentLeft", "CoreAnimation")]
	internal unsafe static IntPtr kCAAlignmentLeft
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAAlignmentLeft", storage);
			}
		}
	}

	[Field("kCAAlignmentRight", "CoreAnimation")]
	internal unsafe static IntPtr kCAAlignmentRight
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAAlignmentRight", storage);
			}
		}
	}

	[Field("kCAAlignmentCenter", "CoreAnimation")]
	internal unsafe static IntPtr kCAAlignmentCenter
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAAlignmentCenter", storage);
			}
		}
	}

	[Field("kCAAlignmentJustified", "CoreAnimation")]
	internal unsafe static IntPtr kCAAlignmentJustified
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAAlignmentJustified", storage);
			}
		}
	}

	[Field("kCAAlignmentNatural", "CoreAnimation")]
	internal unsafe static IntPtr kCAAlignmentNatural
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAAlignmentNatural", storage);
			}
		}
	}

	public static NSString? GetConstant(this CATextLayerAlignmentMode self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCAAlignmentLeft;
			break;
		case 1:
			zero = kCAAlignmentRight;
			break;
		case 2:
			zero = kCAAlignmentCenter;
			break;
		case 3:
			zero = kCAAlignmentJustified;
			break;
		case 4:
			zero = kCAAlignmentNatural;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CATextLayerAlignmentMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCAAlignmentLeft))
		{
			return CATextLayerAlignmentMode.Left;
		}
		if (constant.IsEqualTo(kCAAlignmentRight))
		{
			return CATextLayerAlignmentMode.Right;
		}
		if (constant.IsEqualTo(kCAAlignmentCenter))
		{
			return CATextLayerAlignmentMode.Center;
		}
		if (constant.IsEqualTo(kCAAlignmentJustified))
		{
			return CATextLayerAlignmentMode.Justified;
		}
		if (constant.IsEqualTo(kCAAlignmentNatural))
		{
			return CATextLayerAlignmentMode.Natural;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

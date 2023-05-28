using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CATextLayerTruncationModeExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("kCATruncationNone", "CoreAnimation")]
	internal unsafe static IntPtr kCATruncationNone
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCATruncationNone", storage);
			}
		}
	}

	[Field("kCATruncationStart", "CoreAnimation")]
	internal unsafe static IntPtr kCATruncationStart
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCATruncationStart", storage);
			}
		}
	}

	[Field("kCATruncationMiddle", "CoreAnimation")]
	internal unsafe static IntPtr kCATruncationMiddle
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCATruncationMiddle", storage);
			}
		}
	}

	[Field("kCATruncationEnd", "CoreAnimation")]
	internal unsafe static IntPtr kCATruncationEnd
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCATruncationEnd", storage);
			}
		}
	}

	public static NSString? GetConstant(this CATextLayerTruncationMode self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCATruncationNone;
			break;
		case 1:
			zero = kCATruncationStart;
			break;
		case 2:
			zero = kCATruncationMiddle;
			break;
		case 3:
			zero = kCATruncationEnd;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CATextLayerTruncationMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCATruncationNone))
		{
			return CATextLayerTruncationMode.None;
		}
		if (constant.IsEqualTo(kCATruncationStart))
		{
			return CATextLayerTruncationMode.Start;
		}
		if (constant.IsEqualTo(kCATruncationMiddle))
		{
			return CATextLayerTruncationMode.Middle;
		}
		if (constant.IsEqualTo(kCATruncationEnd))
		{
			return CATextLayerTruncationMode.End;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

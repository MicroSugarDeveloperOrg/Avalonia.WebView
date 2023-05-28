using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CAScrollExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("kCAScrollNone", "CoreAnimation")]
	internal unsafe static IntPtr kCAScrollNone
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAScrollNone", storage);
			}
		}
	}

	[Field("kCAScrollVertically", "CoreAnimation")]
	internal unsafe static IntPtr kCAScrollVertically
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAScrollVertically", storage);
			}
		}
	}

	[Field("kCAScrollHorizontally", "CoreAnimation")]
	internal unsafe static IntPtr kCAScrollHorizontally
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAScrollHorizontally", storage);
			}
		}
	}

	[Field("kCAScrollBoth", "CoreAnimation")]
	internal unsafe static IntPtr kCAScrollBoth
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreAnimation.Handle, "kCAScrollBoth", storage);
			}
		}
	}

	public static NSString? GetConstant(this CAScroll self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCAScrollNone;
			break;
		case 1:
			zero = kCAScrollVertically;
			break;
		case 2:
			zero = kCAScrollHorizontally;
			break;
		case 3:
			zero = kCAScrollBoth;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CAScroll GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCAScrollNone))
		{
			return CAScroll.None;
		}
		if (constant.IsEqualTo(kCAScrollVertically))
		{
			return CAScroll.Vertically;
		}
		if (constant.IsEqualTo(kCAScrollHorizontally))
		{
			return CAScroll.Horizontally;
		}
		if (constant.IsEqualTo(kCAScrollBoth))
		{
			return CAScroll.Both;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class INPersonHandleLabelExtensions
{
	private static IntPtr[] values = new IntPtr[9];

	[Field("INPersonHandleLabelHome", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelHome
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelHome", storage);
			}
		}
	}

	[Field("INPersonHandleLabelWork", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelWork
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelWork", storage);
			}
		}
	}

	[Field("INPersonHandleLabeliPhone", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabeliPhone
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabeliPhone", storage);
			}
		}
	}

	[Field("INPersonHandleLabelMobile", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelMobile
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelMobile", storage);
			}
		}
	}

	[Field("INPersonHandleLabelMain", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelMain
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelMain", storage);
			}
		}
	}

	[Field("INPersonHandleLabelHomeFax", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelHomeFax
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelHomeFax", storage);
			}
		}
	}

	[Field("INPersonHandleLabelWorkFax", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelWorkFax
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelWorkFax", storage);
			}
		}
	}

	[Field("INPersonHandleLabelPager", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelPager
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelPager", storage);
			}
		}
	}

	[Field("INPersonHandleLabelOther", "Intents")]
	internal unsafe static IntPtr INPersonHandleLabelOther
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonHandleLabelOther", storage);
			}
		}
	}

	public static NSString? GetConstant(this INPersonHandleLabel self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 1:
			ptr = INPersonHandleLabelHome;
			break;
		case 2:
			ptr = INPersonHandleLabelWork;
			break;
		case 3:
			ptr = INPersonHandleLabeliPhone;
			break;
		case 4:
			ptr = INPersonHandleLabelMobile;
			break;
		case 5:
			ptr = INPersonHandleLabelMain;
			break;
		case 6:
			ptr = INPersonHandleLabelHomeFax;
			break;
		case 7:
			ptr = INPersonHandleLabelWorkFax;
			break;
		case 8:
			ptr = INPersonHandleLabelPager;
			break;
		case 9:
			ptr = INPersonHandleLabelOther;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static INPersonHandleLabel GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return INPersonHandleLabel.None;
		}
		if (constant.IsEqualTo(INPersonHandleLabelHome))
		{
			return INPersonHandleLabel.Home;
		}
		if (constant.IsEqualTo(INPersonHandleLabelWork))
		{
			return INPersonHandleLabel.Work;
		}
		if (constant.IsEqualTo(INPersonHandleLabeliPhone))
		{
			return INPersonHandleLabel.iPhone;
		}
		if (constant.IsEqualTo(INPersonHandleLabelMobile))
		{
			return INPersonHandleLabel.Mobile;
		}
		if (constant.IsEqualTo(INPersonHandleLabelMain))
		{
			return INPersonHandleLabel.Main;
		}
		if (constant.IsEqualTo(INPersonHandleLabelHomeFax))
		{
			return INPersonHandleLabel.HomeFax;
		}
		if (constant.IsEqualTo(INPersonHandleLabelWorkFax))
		{
			return INPersonHandleLabel.WorkFax;
		}
		if (constant.IsEqualTo(INPersonHandleLabelPager))
		{
			return INPersonHandleLabel.Pager;
		}
		if (constant.IsEqualTo(INPersonHandleLabelOther))
		{
			return INPersonHandleLabel.Other;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

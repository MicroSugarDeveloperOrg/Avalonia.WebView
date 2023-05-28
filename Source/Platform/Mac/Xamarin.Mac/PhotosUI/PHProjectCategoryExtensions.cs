using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PHProjectCategoryExtensions
{
	private static IntPtr[] values = new IntPtr[8];

	[Field("PHProjectCategoryBook", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryBook
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryBook", storage);
			}
		}
	}

	[Field("PHProjectCategoryCalendar", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryCalendar
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryCalendar", storage);
			}
		}
	}

	[Field("PHProjectCategoryCard", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryCard
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryCard", storage);
			}
		}
	}

	[Field("PHProjectCategoryPrints", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryPrints
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryPrints", storage);
			}
		}
	}

	[Field("PHProjectCategorySlideshow", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategorySlideshow
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategorySlideshow", storage);
			}
		}
	}

	[Field("PHProjectCategoryWallDecor", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryWallDecor
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryWallDecor", storage);
			}
		}
	}

	[Field("PHProjectCategoryOther", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryOther
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryOther", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, 2, PlatformArchitecture.All, null)]
	[Field("PHProjectCategoryUndefined", "PhotosUI")]
	internal unsafe static IntPtr PHProjectCategoryUndefined
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.PhotosUI.Handle, "PHProjectCategoryUndefined", storage);
			}
		}
	}

	public static NSString? GetConstant(this PHProjectCategory self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = PHProjectCategoryBook;
			break;
		case 1:
			ptr = PHProjectCategoryCalendar;
			break;
		case 2:
			ptr = PHProjectCategoryCard;
			break;
		case 3:
			ptr = PHProjectCategoryPrints;
			break;
		case 4:
			ptr = PHProjectCategorySlideshow;
			break;
		case 5:
			ptr = PHProjectCategoryWallDecor;
			break;
		case 6:
			ptr = PHProjectCategoryOther;
			break;
		case 7:
			ptr = PHProjectCategoryUndefined;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static PHProjectCategory GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(PHProjectCategoryBook))
		{
			return PHProjectCategory.Book;
		}
		if (constant.IsEqualTo(PHProjectCategoryCalendar))
		{
			return PHProjectCategory.Calendar;
		}
		if (constant.IsEqualTo(PHProjectCategoryCard))
		{
			return PHProjectCategory.Card;
		}
		if (constant.IsEqualTo(PHProjectCategoryPrints))
		{
			return PHProjectCategory.Prints;
		}
		if (constant.IsEqualTo(PHProjectCategorySlideshow))
		{
			return PHProjectCategory.Slideshow;
		}
		if (constant.IsEqualTo(PHProjectCategoryWallDecor))
		{
			return PHProjectCategory.WallDecor;
		}
		if (constant.IsEqualTo(PHProjectCategoryOther))
		{
			return PHProjectCategory.Other;
		}
		if (constant.IsEqualTo(PHProjectCategoryUndefined))
		{
			return PHProjectCategory.Undefined;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

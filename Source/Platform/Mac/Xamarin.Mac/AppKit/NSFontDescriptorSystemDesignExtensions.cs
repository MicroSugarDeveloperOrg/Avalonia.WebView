using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSFontDescriptorSystemDesignExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("NSFontDescriptorSystemDesignDefault", "AppKit")]
	internal unsafe static IntPtr NSFontDescriptorSystemDesignDefault
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignDefault", storage);
			}
		}
	}

	[Field("NSFontDescriptorSystemDesignSerif", "AppKit")]
	internal unsafe static IntPtr NSFontDescriptorSystemDesignSerif
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignSerif", storage);
			}
		}
	}

	[Field("NSFontDescriptorSystemDesignMonospaced", "AppKit")]
	internal unsafe static IntPtr NSFontDescriptorSystemDesignMonospaced
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignMonospaced", storage);
			}
		}
	}

	[Field("NSFontDescriptorSystemDesignRounded", "AppKit")]
	internal unsafe static IntPtr NSFontDescriptorSystemDesignRounded
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignRounded", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSFontDescriptorSystemDesign self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSFontDescriptorSystemDesignDefault;
			break;
		case 1:
			ptr = NSFontDescriptorSystemDesignSerif;
			break;
		case 2:
			ptr = NSFontDescriptorSystemDesignMonospaced;
			break;
		case 3:
			ptr = NSFontDescriptorSystemDesignRounded;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSFontDescriptorSystemDesign GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NSFontDescriptorSystemDesignDefault))
		{
			return NSFontDescriptorSystemDesign.Default;
		}
		if (constant.IsEqualTo(NSFontDescriptorSystemDesignSerif))
		{
			return NSFontDescriptorSystemDesign.Serif;
		}
		if (constant.IsEqualTo(NSFontDescriptorSystemDesignMonospaced))
		{
			return NSFontDescriptorSystemDesign.Monospaced;
		}
		if (constant.IsEqualTo(NSFontDescriptorSystemDesignRounded))
		{
			return NSFontDescriptorSystemDesign.Rounded;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

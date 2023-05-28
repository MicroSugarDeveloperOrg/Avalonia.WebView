using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSRulerViewUnitsExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("NSRulerViewUnitInches", "AppKit")]
	internal unsafe static IntPtr NSRulerViewUnitInches
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSRulerViewUnitInches", storage);
			}
		}
	}

	[Field("NSRulerViewUnitCentimeters", "AppKit")]
	internal unsafe static IntPtr NSRulerViewUnitCentimeters
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSRulerViewUnitCentimeters", storage);
			}
		}
	}

	[Field("NSRulerViewUnitPoints", "AppKit")]
	internal unsafe static IntPtr NSRulerViewUnitPoints
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSRulerViewUnitPoints", storage);
			}
		}
	}

	[Field("NSRulerViewUnitPicas", "AppKit")]
	internal unsafe static IntPtr NSRulerViewUnitPicas
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSRulerViewUnitPicas", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSRulerViewUnits self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSRulerViewUnitInches;
			break;
		case 1:
			ptr = NSRulerViewUnitCentimeters;
			break;
		case 2:
			ptr = NSRulerViewUnitPoints;
			break;
		case 3:
			ptr = NSRulerViewUnitPicas;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSRulerViewUnits GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NSRulerViewUnitInches))
		{
			return NSRulerViewUnits.Inches;
		}
		if (constant.IsEqualTo(NSRulerViewUnitCentimeters))
		{
			return NSRulerViewUnits.Centimeters;
		}
		if (constant.IsEqualTo(NSRulerViewUnitPoints))
		{
			return NSRulerViewUnits.Points;
		}
		if (constant.IsEqualTo(NSRulerViewUnitPicas))
		{
			return NSRulerViewUnits.Picas;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

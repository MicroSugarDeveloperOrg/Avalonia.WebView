using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VNAnimalIdentifierExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("VNAnimalIdentifierDog", "Vision")]
	internal unsafe static IntPtr VNAnimalIdentifierDog
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNAnimalIdentifierDog", storage);
			}
		}
	}

	[Field("VNAnimalIdentifierCat", "Vision")]
	internal unsafe static IntPtr VNAnimalIdentifierCat
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNAnimalIdentifierCat", storage);
			}
		}
	}

	public static NSString? GetConstant(this VNAnimalIdentifier self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = VNAnimalIdentifierDog;
			break;
		case 1:
			ptr = VNAnimalIdentifierCat;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static VNAnimalIdentifier GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return VNAnimalIdentifier.Unknown;
		}
		if (constant.IsEqualTo(VNAnimalIdentifierDog))
		{
			return VNAnimalIdentifier.Dog;
		}
		if (constant.IsEqualTo(VNAnimalIdentifierCat))
		{
			return VNAnimalIdentifier.Cat;
		}
		return VNAnimalIdentifier.Unknown;
	}
}

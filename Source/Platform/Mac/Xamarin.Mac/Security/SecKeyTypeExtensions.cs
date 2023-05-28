using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SecKeyTypeExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kSecAttrKeyTypeRSA", "Security")]
	internal unsafe static IntPtr kSecAttrKeyTypeRSA
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyTypeRSA", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Field("kSecAttrKeyTypeEC", "Security")]
	internal unsafe static IntPtr kSecAttrKeyTypeEC
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyTypeEC", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Field("kSecAttrKeyTypeECSECPrimeRandom", "Security")]
	internal unsafe static IntPtr kSecAttrKeyTypeECSECPrimeRandom
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyTypeECSECPrimeRandom", storage);
			}
		}
	}

	public static NSString? GetConstant(this SecKeyType self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kSecAttrKeyTypeRSA;
			break;
		case 1:
			zero = kSecAttrKeyTypeEC;
			break;
		case 2:
			zero = kSecAttrKeyTypeECSECPrimeRandom;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SecKeyType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSecAttrKeyTypeRSA))
		{
			return SecKeyType.RSA;
		}
		if (constant.IsEqualTo(kSecAttrKeyTypeEC))
		{
			return SecKeyType.EC;
		}
		if (constant.IsEqualTo(kSecAttrKeyTypeECSECPrimeRandom))
		{
			return SecKeyType.ECSecPrimeRandom;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

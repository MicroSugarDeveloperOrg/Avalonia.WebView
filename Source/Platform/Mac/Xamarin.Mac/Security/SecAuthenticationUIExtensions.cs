using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SecAuthenticationUIExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kSecUseAuthenticationUIAllow", "Security")]
	internal unsafe static IntPtr kSecUseAuthenticationUIAllow
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecUseAuthenticationUIAllow", storage);
			}
		}
	}

	[Field("kSecUseAuthenticationUIFail", "Security")]
	internal unsafe static IntPtr kSecUseAuthenticationUIFail
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecUseAuthenticationUIFail", storage);
			}
		}
	}

	[Field("kSecUseAuthenticationUISkip", "Security")]
	internal unsafe static IntPtr kSecUseAuthenticationUISkip
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecUseAuthenticationUISkip", storage);
			}
		}
	}

	public static NSString? GetConstant(this SecAuthenticationUI self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kSecUseAuthenticationUIAllow;
			break;
		case 1:
			zero = kSecUseAuthenticationUIFail;
			break;
		case 2:
			zero = kSecUseAuthenticationUISkip;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SecAuthenticationUI GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSecUseAuthenticationUIAllow))
		{
			return SecAuthenticationUI.Allow;
		}
		if (constant.IsEqualTo(kSecUseAuthenticationUIFail))
		{
			return SecAuthenticationUI.Fail;
		}
		if (constant.IsEqualTo(kSecUseAuthenticationUISkip))
		{
			return SecAuthenticationUI.Skip;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SecTokenIDExtensions
{
	private static IntPtr[] values = new IntPtr[1];

	[Field("kSecAttrTokenIDSecureEnclave", "Security")]
	internal unsafe static IntPtr kSecAttrTokenIDSecureEnclave
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrTokenIDSecureEnclave", storage);
			}
		}
	}

	public static NSString? GetConstant(this SecTokenID self)
	{
		IntPtr zero = IntPtr.Zero;
		if (self == SecTokenID.SecureEnclave)
		{
			zero = kSecAttrTokenIDSecureEnclave;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SecTokenID GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSecAttrTokenIDSecureEnclave))
		{
			return SecTokenID.SecureEnclave;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

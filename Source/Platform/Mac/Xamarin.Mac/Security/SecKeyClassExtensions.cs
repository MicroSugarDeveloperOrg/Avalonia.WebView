using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SecKeyClassExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kSecAttrKeyClassPublic", "Security")]
	internal unsafe static IntPtr kSecAttrKeyClassPublic
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyClassPublic", storage);
			}
		}
	}

	[Field("kSecAttrKeyClassPrivate", "Security")]
	internal unsafe static IntPtr kSecAttrKeyClassPrivate
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyClassPrivate", storage);
			}
		}
	}

	[Field("kSecAttrKeyClassSymmetric", "Security")]
	internal unsafe static IntPtr kSecAttrKeyClassSymmetric
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecAttrKeyClassSymmetric", storage);
			}
		}
	}

	public static NSString? GetConstant(this SecKeyClass self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kSecAttrKeyClassPublic;
			break;
		case 1:
			zero = kSecAttrKeyClassPrivate;
			break;
		case 2:
			zero = kSecAttrKeyClassSymmetric;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SecKeyClass GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSecAttrKeyClassPublic))
		{
			return SecKeyClass.Public;
		}
		if (constant.IsEqualTo(kSecAttrKeyClassPrivate))
		{
			return SecKeyClass.Private;
		}
		if (constant.IsEqualTo(kSecAttrKeyClassSymmetric))
		{
			return SecKeyClass.Symmetric;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

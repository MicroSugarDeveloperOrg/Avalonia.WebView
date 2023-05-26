using System;
using ObjCRuntime;

namespace Security;

internal static class KeyTypeKeys
{
	private static IntPtr _RSA;

	private static IntPtr _EC;

	public static IntPtr RSA
	{
		get
		{
			if (_RSA == IntPtr.Zero)
			{
				_RSA = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyTypeRSA");
			}
			return _RSA;
		}
	}

	public static IntPtr EC
	{
		get
		{
			if (_EC == IntPtr.Zero)
			{
				_EC = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyTypeEC");
			}
			return _EC;
		}
	}
}

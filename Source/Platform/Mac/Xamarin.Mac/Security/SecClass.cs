using System;
using ObjCRuntime;

namespace Security;

internal static class SecClass
{
	public static IntPtr SecClassKey;

	public static IntPtr GenericPassword;

	public static IntPtr InternetPassword;

	public static IntPtr Certificate;

	public static IntPtr Key;

	public static IntPtr Identity;

	static SecClass()
	{
		SecClassKey = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClass");
		GenericPassword = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClassGenericPassword");
		InternetPassword = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClassInternetPassword");
		Certificate = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClassCertificate");
		Key = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClassKey");
		Identity = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecClassIdentity");
	}

	public static IntPtr FromSecKind(SecKind secKind)
	{
		if (secKind == SecKind.InternetPassword)
		{
			return InternetPassword;
		}
		throw new ArgumentException("secKind");
	}
}

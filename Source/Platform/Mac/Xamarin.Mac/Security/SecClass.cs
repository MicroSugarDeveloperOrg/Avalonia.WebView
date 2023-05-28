using System;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class SecClass
{
	[Field("kSecClassCertificate", "Security")]
	public static IntPtr Certificate => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClassCertificate");

	[Field("kSecClassGenericPassword", "Security")]
	public static IntPtr GenericPassword => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClassGenericPassword");

	[Field("kSecClassIdentity", "Security")]
	public static IntPtr Identity => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClassIdentity");

	[Field("kSecClassInternetPassword", "Security")]
	public static IntPtr InternetPassword => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClassInternetPassword");

	[Field("kSecClassKey", "Security")]
	public static IntPtr Key => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClassKey");

	[Field("kSecClass", "Security")]
	public static IntPtr SecClassKey => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecClass");

	public static IntPtr FromSecKind(SecKind secKind)
	{
		return secKind switch
		{
			SecKind.InternetPassword => InternetPassword, 
			SecKind.GenericPassword => GenericPassword, 
			SecKind.Certificate => Certificate, 
			SecKind.Key => Key, 
			SecKind.Identity => Identity, 
			_ => throw new ArgumentException("secKind"), 
		};
	}
}

using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class KeysAuthenticationType
{
	[Field("kSecAttrAuthenticationTypeDPA", "Security")]
	public static IntPtr DPA => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeDPA");

	[Field("kSecAttrAuthenticationTypeDefault", "Security")]
	public static IntPtr Default => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeDefault");

	[Field("kSecAttrAuthenticationTypeHTMLForm", "Security")]
	public static IntPtr HTMLForm => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTMLForm");

	[Field("kSecAttrAuthenticationTypeHTTPBasic", "Security")]
	public static IntPtr HTTPBasic => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTTPBasic");

	[Field("kSecAttrAuthenticationTypeHTTPDigest", "Security")]
	public static IntPtr HTTPDigest => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeHTTPDigest");

	[Field("kSecAttrAuthenticationTypeMSN", "Security")]
	public static IntPtr MSN => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeMSN");

	[Field("kSecAttrAuthenticationTypeNTLM", "Security")]
	public static IntPtr NTLM => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeNTLM");

	[Field("kSecAttrAuthenticationTypeRPA", "Security")]
	public static IntPtr RPA => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationTypeRPA");

	public static SecAuthenticationType ToSecAuthenticationType(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return SecAuthenticationType.Invalid;
		}
		if (CFType.Equal(handle, NTLM))
		{
			return SecAuthenticationType.Ntlm;
		}
		if (CFType.Equal(handle, MSN))
		{
			return SecAuthenticationType.Msn;
		}
		if (CFType.Equal(handle, DPA))
		{
			return SecAuthenticationType.Dpa;
		}
		if (CFType.Equal(handle, RPA))
		{
			return SecAuthenticationType.Rpa;
		}
		if (CFType.Equal(handle, HTTPBasic))
		{
			return SecAuthenticationType.HttpBasic;
		}
		if (CFType.Equal(handle, HTTPDigest))
		{
			return SecAuthenticationType.HttpDigest;
		}
		if (CFType.Equal(handle, HTMLForm))
		{
			return SecAuthenticationType.HtmlForm;
		}
		if (CFType.Equal(handle, Default))
		{
			return SecAuthenticationType.Default;
		}
		return SecAuthenticationType.Invalid;
	}

	public static IntPtr FromSecAuthenticationType(SecAuthenticationType type)
	{
		return type switch
		{
			SecAuthenticationType.Ntlm => NTLM, 
			SecAuthenticationType.Msn => MSN, 
			SecAuthenticationType.Dpa => DPA, 
			SecAuthenticationType.Rpa => RPA, 
			SecAuthenticationType.HttpBasic => HTTPBasic, 
			SecAuthenticationType.HttpDigest => HTTPDigest, 
			SecAuthenticationType.HtmlForm => HTMLForm, 
			SecAuthenticationType.Default => Default, 
			_ => throw new ArgumentException("type"), 
		};
	}
}

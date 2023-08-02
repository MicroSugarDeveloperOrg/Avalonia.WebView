using System;
using ObjCRuntime;

namespace Security;

internal static class KeysAuthenticationType
{
	private static IntPtr _NTLM;

	private static IntPtr _MSN;

	private static IntPtr _DPA;

	private static IntPtr _RPA;

	private static IntPtr _HTTPBasic;

	private static IntPtr _HTTPDigest;

	private static IntPtr _HTMLForm;

	private static IntPtr _Default;

	public static IntPtr NTLM
	{
		get
		{
			if (_NTLM == IntPtr.Zero)
			{
				_NTLM = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeNTLM");
			}
			return _NTLM;
		}
	}

	public static IntPtr MSN
	{
		get
		{
			if (_MSN == IntPtr.Zero)
			{
				_MSN = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeMSN");
			}
			return _MSN;
		}
	}

	public static IntPtr DPA
	{
		get
		{
			if (_DPA == IntPtr.Zero)
			{
				_DPA = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeDPA");
			}
			return _DPA;
		}
	}

	public static IntPtr RPA
	{
		get
		{
			if (_RPA == IntPtr.Zero)
			{
				_RPA = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeRPA");
			}
			return _RPA;
		}
	}

	public static IntPtr HTTPBasic
	{
		get
		{
			if (_HTTPBasic == IntPtr.Zero)
			{
				_HTTPBasic = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeHTTPBasic");
			}
			return _HTTPBasic;
		}
	}

	public static IntPtr HTTPDigest
	{
		get
		{
			if (_HTTPDigest == IntPtr.Zero)
			{
				_HTTPDigest = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeHTTPDigest");
			}
			return _HTTPDigest;
		}
	}

	public static IntPtr HTMLForm
	{
		get
		{
			if (_HTMLForm == IntPtr.Zero)
			{
				_HTMLForm = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeHTMLForm");
			}
			return _HTMLForm;
		}
	}

	public static IntPtr Default
	{
		get
		{
			if (_Default == IntPtr.Zero)
			{
				_Default = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationTypeDefault");
			}
			return _Default;
		}
	}

	public static SecAuthenticationType ToSecAuthenticationType(IntPtr handle)
	{
		if (handle == NTLM)
		{
			return SecAuthenticationType.Ntlm;
		}
		if (handle == MSN)
		{
			return SecAuthenticationType.Msn;
		}
		if (handle == DPA)
		{
			return SecAuthenticationType.Dpa;
		}
		if (handle == RPA)
		{
			return SecAuthenticationType.Rpa;
		}
		if (handle == HTTPBasic)
		{
			return SecAuthenticationType.HttpBasic;
		}
		if (handle == HTTPDigest)
		{
			return SecAuthenticationType.HttpDigest;
		}
		if (handle == HTMLForm)
		{
			return SecAuthenticationType.HtmlForm;
		}
		if (handle == Default)
		{
			return SecAuthenticationType.Default;
		}
		throw new ArgumentException("handle");
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

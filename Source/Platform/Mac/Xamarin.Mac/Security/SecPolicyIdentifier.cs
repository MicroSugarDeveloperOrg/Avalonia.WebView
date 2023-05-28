using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public static class SecPolicyIdentifier
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleCodeSigning;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleEAP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleIDValidation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleIPsec;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplePKINITClient;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplePKINITServer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplePassbookSigning;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplePayIssuerEncryption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleRevocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleSMIME;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleSSL;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleTimeStamping;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleX509Basic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MacAppStoreReceipt;

	[Field("kSecPolicyAppleCodeSigning", "Security")]
	public static NSString AppleCodeSigning
	{
		get
		{
			if (_AppleCodeSigning == null)
			{
				_AppleCodeSigning = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleCodeSigning");
			}
			return _AppleCodeSigning;
		}
	}

	[Field("kSecPolicyAppleEAP", "Security")]
	public static NSString AppleEAP
	{
		get
		{
			if (_AppleEAP == null)
			{
				_AppleEAP = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleEAP");
			}
			return _AppleEAP;
		}
	}

	[Field("kSecPolicyAppleIDValidation", "Security")]
	public static NSString AppleIDValidation
	{
		get
		{
			if (_AppleIDValidation == null)
			{
				_AppleIDValidation = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleIDValidation");
			}
			return _AppleIDValidation;
		}
	}

	[Field("kSecPolicyAppleIPsec", "Security")]
	public static NSString AppleIPsec
	{
		get
		{
			if (_AppleIPsec == null)
			{
				_AppleIPsec = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleIPsec");
			}
			return _AppleIPsec;
		}
	}

	[Field("kSecPolicyApplePKINITClient", "Security")]
	public static NSString ApplePKINITClient
	{
		get
		{
			if (_ApplePKINITClient == null)
			{
				_ApplePKINITClient = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyApplePKINITClient");
			}
			return _ApplePKINITClient;
		}
	}

	[Field("kSecPolicyApplePKINITServer", "Security")]
	public static NSString ApplePKINITServer
	{
		get
		{
			if (_ApplePKINITServer == null)
			{
				_ApplePKINITServer = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyApplePKINITServer");
			}
			return _ApplePKINITServer;
		}
	}

	[Field("kSecPolicyApplePassbookSigning", "Security")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ApplePassbookSigning
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplePassbookSigning == null)
			{
				_ApplePassbookSigning = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyApplePassbookSigning");
			}
			return _ApplePassbookSigning;
		}
	}

	[Field("kSecPolicyApplePayIssuerEncryption", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString ApplePayIssuerEncryption
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplePayIssuerEncryption == null)
			{
				_ApplePayIssuerEncryption = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyApplePayIssuerEncryption");
			}
			return _ApplePayIssuerEncryption;
		}
	}

	[Field("kSecPolicyAppleRevocation", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AppleRevocation
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleRevocation == null)
			{
				_AppleRevocation = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleRevocation");
			}
			return _AppleRevocation;
		}
	}

	[Field("kSecPolicyAppleSMIME", "Security")]
	public static NSString AppleSMIME
	{
		get
		{
			if (_AppleSMIME == null)
			{
				_AppleSMIME = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleSMIME");
			}
			return _AppleSMIME;
		}
	}

	[Field("kSecPolicyAppleSSL", "Security")]
	public static NSString AppleSSL
	{
		get
		{
			if (_AppleSSL == null)
			{
				_AppleSSL = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleSSL");
			}
			return _AppleSSL;
		}
	}

	[Field("kSecPolicyAppleTimeStamping", "Security")]
	public static NSString AppleTimeStamping
	{
		get
		{
			if (_AppleTimeStamping == null)
			{
				_AppleTimeStamping = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleTimeStamping");
			}
			return _AppleTimeStamping;
		}
	}

	[Field("kSecPolicyAppleX509Basic", "Security")]
	public static NSString AppleX509Basic
	{
		get
		{
			if (_AppleX509Basic == null)
			{
				_AppleX509Basic = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyAppleX509Basic");
			}
			return _AppleX509Basic;
		}
	}

	[Field("kSecPolicyMacAppStoreReceipt", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString MacAppStoreReceipt
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MacAppStoreReceipt == null)
			{
				_MacAppStoreReceipt = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyMacAppStoreReceipt");
			}
			return _MacAppStoreReceipt;
		}
	}
}

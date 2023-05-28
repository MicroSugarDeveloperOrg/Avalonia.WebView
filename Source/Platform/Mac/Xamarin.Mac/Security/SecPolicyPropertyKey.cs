using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public static class SecPolicyPropertyKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Client;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Oid;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RevocationFlags;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TeamIdentifier;

	[Field("kSecPolicyClient", "Security")]
	public static NSString Client
	{
		get
		{
			if (_Client == null)
			{
				_Client = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyClient");
			}
			return _Client;
		}
	}

	[Field("kSecPolicyName", "Security")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyName");
			}
			return _Name;
		}
	}

	[Field("kSecPolicyOid", "Security")]
	public static NSString Oid
	{
		get
		{
			if (_Oid == null)
			{
				_Oid = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyOid");
			}
			return _Oid;
		}
	}

	[Field("kSecPolicyRevocationFlags", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RevocationFlags
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RevocationFlags == null)
			{
				_RevocationFlags = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyRevocationFlags");
			}
			return _RevocationFlags;
		}
	}

	[Field("kSecPolicyTeamIdentifier", "Security")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TeamIdentifier
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TeamIdentifier == null)
			{
				_TeamIdentifier = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecPolicyTeamIdentifier");
			}
			return _TeamIdentifier;
		}
	}
}

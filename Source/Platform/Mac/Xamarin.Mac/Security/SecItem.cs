using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class SecItem
{
	[Field("kSecMatchCaseInsensitive", "Security")]
	public static IntPtr MatchCaseInsensitive => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchCaseInsensitive");

	[Field("kSecMatchEmailAddressIfPresent", "Security")]
	public static IntPtr MatchEmailAddressIfPresent => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchEmailAddressIfPresent");

	[Field("kSecMatchIssuers", "Security")]
	public static IntPtr MatchIssuers => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchIssuers");

	[Field("kSecMatchItemList", "Security")]
	public static IntPtr MatchItemList => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchItemList");

	[Field("kSecMatchLimit", "Security")]
	public static IntPtr MatchLimit => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchLimit");

	[Field("kSecMatchPolicy", "Security")]
	public static IntPtr MatchPolicy => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchPolicy");

	[Field("kSecMatchSearchList", "Security")]
	public static IntPtr MatchSearchList => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchSearchList");

	[Field("kSecMatchSubjectContains", "Security")]
	public static IntPtr MatchSubjectContains => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchSubjectContains");

	[Field("kSecMatchTrustedOnly", "Security")]
	public static IntPtr MatchTrustedOnly => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchTrustedOnly");

	[Field("kSecMatchValidOnDate", "Security")]
	public static IntPtr MatchValidOnDate => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchValidOnDate");

	[Field("kSecReturnAttributes", "Security")]
	public static IntPtr ReturnAttributes => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecReturnAttributes");

	[Field("kSecReturnData", "Security")]
	public static IntPtr ReturnData => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecReturnData");

	[Field("kSecReturnPersistentRef", "Security")]
	public static IntPtr ReturnPersistentRef => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecReturnPersistentRef");

	[Field("kSecReturnRef", "Security")]
	public static IntPtr ReturnRef => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecReturnRef");

	[Field("kSecUseAuthenticationContext", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static IntPtr UseAuthenticationContext
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecUseAuthenticationContext");
		}
	}

	[Field("kSecUseAuthenticationUI", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static IntPtr UseAuthenticationUI
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecUseAuthenticationUI");
		}
	}

	[Field("kSecUseDataProtectionKeychain", "Security")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static IntPtr UseDataProtectionKeychain
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecUseDataProtectionKeychain");
		}
	}

	[Field("kSecUseItemList", "Security")]
	public static IntPtr UseItemList => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecUseItemList");

	[Field("kSecValueData", "Security")]
	public static IntPtr ValueData => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecValueData");

	[Field("kSecValuePersistentRef", "Security")]
	public static IntPtr ValuePersistentRef => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecValuePersistentRef");

	[Field("kSecValueRef", "Security")]
	public static IntPtr ValueRef => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecValueRef");

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemCopyMatching(IntPtr query, out IntPtr result);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemAdd(IntPtr attributes, IntPtr result);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemDelete(IntPtr query);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemUpdate(IntPtr query, IntPtr attributesToUpdate);
}

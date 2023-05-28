using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ASAuthorizationScopeExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("ASAuthorizationScopeFullName", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationScopeFullName
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationScopeFullName", storage);
			}
		}
	}

	[Field("ASAuthorizationScopeEmail", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationScopeEmail
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationScopeEmail", storage);
			}
		}
	}

	public static NSString? GetConstant(this ASAuthorizationScope self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = ASAuthorizationScopeFullName;
			break;
		case 1:
			ptr = ASAuthorizationScopeEmail;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static ASAuthorizationScope GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ASAuthorizationScopeFullName))
		{
			return ASAuthorizationScope.FullName;
		}
		if (constant.IsEqualTo(ASAuthorizationScopeEmail))
		{
			return ASAuthorizationScope.Email;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

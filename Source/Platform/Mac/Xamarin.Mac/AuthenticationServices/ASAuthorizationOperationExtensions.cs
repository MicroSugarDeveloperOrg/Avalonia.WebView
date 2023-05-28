using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ASAuthorizationOperationExtensions
{
	private static IntPtr[] values = new IntPtr[4];

	[Field("ASAuthorizationOperationImplicit", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationOperationImplicit
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationOperationImplicit", storage);
			}
		}
	}

	[Field("ASAuthorizationOperationLogin", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationOperationLogin
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationOperationLogin", storage);
			}
		}
	}

	[Field("ASAuthorizationOperationRefresh", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationOperationRefresh
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationOperationRefresh", storage);
			}
		}
	}

	[Field("ASAuthorizationOperationLogout", "AuthenticationServices")]
	internal unsafe static IntPtr ASAuthorizationOperationLogout
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AuthenticationServices.Handle, "ASAuthorizationOperationLogout", storage);
			}
		}
	}

	public static NSString? GetConstant(this ASAuthorizationOperation self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = ASAuthorizationOperationImplicit;
			break;
		case 1:
			ptr = ASAuthorizationOperationLogin;
			break;
		case 2:
			ptr = ASAuthorizationOperationRefresh;
			break;
		case 3:
			ptr = ASAuthorizationOperationLogout;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static ASAuthorizationOperation GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ASAuthorizationOperationImplicit))
		{
			return ASAuthorizationOperation.Implicit;
		}
		if (constant.IsEqualTo(ASAuthorizationOperationLogin))
		{
			return ASAuthorizationOperation.Login;
		}
		if (constant.IsEqualTo(ASAuthorizationOperationRefresh))
		{
			return ASAuthorizationOperation.Refresh;
		}
		if (constant.IsEqualTo(ASAuthorizationOperationLogout))
		{
			return ASAuthorizationOperation.Logout;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

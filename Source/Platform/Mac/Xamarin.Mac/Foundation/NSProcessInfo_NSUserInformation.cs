using System;
using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public static class NSProcessInfo_NSUserInformation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullUserName = "fullUserName";

	private static readonly IntPtr selFullUserNameHandle = Selector.GetHandle("fullUserName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserName = "userName";

	private static readonly IntPtr selUserNameHandle = Selector.GetHandle("userName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSProcessInfo");

	[Export("fullUserName")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetFullUserName(this NSProcessInfo This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, selFullUserNameHandle));
	}

	[Export("userName")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetUserName(this NSProcessInfo This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, selUserNameHandle));
	}
}

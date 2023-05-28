using System;
using Foundation;
using ObjCRuntime;

namespace Security;

public static class SecMatchLimit
{
	[Field("kSecMatchLimitAll", "Security")]
	public static IntPtr MatchLimitAll => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchLimitAll");

	[Field("kSecMatchLimitOne", "Security")]
	public static IntPtr MatchLimitOne => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecMatchLimitOne");
}

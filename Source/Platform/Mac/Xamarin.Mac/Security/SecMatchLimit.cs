using System;
using ObjCRuntime;

namespace Security;

public static class SecMatchLimit
{
	private static IntPtr _MatchLimitOne;

	private static IntPtr _MatchLimitAll;

	public static IntPtr MatchLimitOne
	{
		get
		{
			if (_MatchLimitOne == IntPtr.Zero)
			{
				_MatchLimitOne = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecMatchLimitOne");
			}
			return _MatchLimitOne;
		}
	}

	public static IntPtr MatchLimitAll
	{
		get
		{
			if (_MatchLimitAll == IntPtr.Zero)
			{
				_MatchLimitAll = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecMatchLimitAll");
			}
			return _MatchLimitAll;
		}
	}
}

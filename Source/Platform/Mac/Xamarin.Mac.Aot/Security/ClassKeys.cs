using System;
using ObjCRuntime;

namespace Security;

internal static class ClassKeys
{
	private static IntPtr _Public;

	private static IntPtr _Private;

	private static IntPtr _Symmetric;

	public static IntPtr Public
	{
		get
		{
			if (_Public == IntPtr.Zero)
			{
				_Public = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyClassPublic");
			}
			return _Public;
		}
	}

	public static IntPtr Private
	{
		get
		{
			if (_Private == IntPtr.Zero)
			{
				_Private = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyClassPrivate");
			}
			return _Private;
		}
	}

	public static IntPtr Symmetric
	{
		get
		{
			if (_Symmetric == IntPtr.Zero)
			{
				_Symmetric = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyClassSymmetric");
			}
			return _Symmetric;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Security;

internal class SecItem
{
	internal static IntPtr securityLibrary = Dlfcn.dlopen("/System/Library/Frameworks/Security.framework/Security", 0);

	private static IntPtr _MatchPolicy;

	private static IntPtr _MatchItemList;

	private static IntPtr _MatchSearchList;

	private static IntPtr _MatchIssuers;

	private static IntPtr _MatchEmailAddressIfPresent;

	private static IntPtr _MatchSubjectContains;

	private static IntPtr _MatchCaseInsensitive;

	private static IntPtr _MatchTrustedOnly;

	private static IntPtr _MatchValidOnDate;

	private static IntPtr _MatchLimit;

	private static IntPtr _ReturnData;

	private static IntPtr _ReturnAttributes;

	private static IntPtr _ReturnRef;

	private static IntPtr _ReturnPersistentRef;

	private static IntPtr _ValueData;

	private static IntPtr _ValueRef;

	private static IntPtr _ValuePersistentRef;

	private static IntPtr _UseItemList;

	public static IntPtr MatchPolicy
	{
		get
		{
			if (_MatchPolicy == IntPtr.Zero)
			{
				_MatchPolicy = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchPolicy");
			}
			return _MatchPolicy;
		}
	}

	public static IntPtr MatchItemList
	{
		get
		{
			if (_MatchItemList == IntPtr.Zero)
			{
				_MatchItemList = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchItemList");
			}
			return _MatchItemList;
		}
	}

	public static IntPtr MatchSearchList
	{
		get
		{
			if (_MatchSearchList == IntPtr.Zero)
			{
				_MatchSearchList = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchSearchList");
			}
			return _MatchSearchList;
		}
	}

	public static IntPtr MatchIssuers
	{
		get
		{
			if (_MatchIssuers == IntPtr.Zero)
			{
				_MatchIssuers = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchIssuers");
			}
			return _MatchIssuers;
		}
	}

	public static IntPtr MatchEmailAddressIfPresent
	{
		get
		{
			if (_MatchEmailAddressIfPresent == IntPtr.Zero)
			{
				_MatchEmailAddressIfPresent = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchEmailAddressIfPresent");
			}
			return _MatchEmailAddressIfPresent;
		}
	}

	public static IntPtr MatchSubjectContains
	{
		get
		{
			if (_MatchSubjectContains == IntPtr.Zero)
			{
				_MatchSubjectContains = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchSubjectContains");
			}
			return _MatchSubjectContains;
		}
	}

	public static IntPtr MatchCaseInsensitive
	{
		get
		{
			if (_MatchCaseInsensitive == IntPtr.Zero)
			{
				_MatchCaseInsensitive = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchCaseInsensitive");
			}
			return _MatchCaseInsensitive;
		}
	}

	public static IntPtr MatchTrustedOnly
	{
		get
		{
			if (_MatchTrustedOnly == IntPtr.Zero)
			{
				_MatchTrustedOnly = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchTrustedOnly");
			}
			return _MatchTrustedOnly;
		}
	}

	public static IntPtr MatchValidOnDate
	{
		get
		{
			if (_MatchValidOnDate == IntPtr.Zero)
			{
				_MatchValidOnDate = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchValidOnDate");
			}
			return _MatchValidOnDate;
		}
	}

	public static IntPtr MatchLimit
	{
		get
		{
			if (_MatchLimit == IntPtr.Zero)
			{
				_MatchLimit = Dlfcn.GetIntPtr(securityLibrary, "kSecMatchLimit");
			}
			return _MatchLimit;
		}
	}

	public static IntPtr ReturnData
	{
		get
		{
			if (_ReturnData == IntPtr.Zero)
			{
				_ReturnData = Dlfcn.GetIntPtr(securityLibrary, "kSecReturnData");
			}
			return _ReturnData;
		}
	}

	public static IntPtr ReturnAttributes
	{
		get
		{
			if (_ReturnAttributes == IntPtr.Zero)
			{
				_ReturnAttributes = Dlfcn.GetIntPtr(securityLibrary, "kSecReturnAttributes");
			}
			return _ReturnAttributes;
		}
	}

	public static IntPtr ReturnRef
	{
		get
		{
			if (_ReturnRef == IntPtr.Zero)
			{
				_ReturnRef = Dlfcn.GetIntPtr(securityLibrary, "kSecReturnRef");
			}
			return _ReturnRef;
		}
	}

	public static IntPtr ReturnPersistentRef
	{
		get
		{
			if (_ReturnPersistentRef == IntPtr.Zero)
			{
				_ReturnPersistentRef = Dlfcn.GetIntPtr(securityLibrary, "kSecReturnPersistentRef");
			}
			return _ReturnPersistentRef;
		}
	}

	public static IntPtr ValueData
	{
		get
		{
			if (_ValueData == IntPtr.Zero)
			{
				_ValueData = Dlfcn.GetIntPtr(securityLibrary, "kSecValueData");
			}
			return _ValueData;
		}
	}

	public static IntPtr ValueRef
	{
		get
		{
			if (_ValueRef == IntPtr.Zero)
			{
				_ValueRef = Dlfcn.GetIntPtr(securityLibrary, "kSecValueRef");
			}
			return _ValueRef;
		}
	}

	public static IntPtr ValuePersistentRef
	{
		get
		{
			if (_ValuePersistentRef == IntPtr.Zero)
			{
				_ValuePersistentRef = Dlfcn.GetIntPtr(securityLibrary, "kSecValuePersistentRef");
			}
			return _ValuePersistentRef;
		}
	}

	public static IntPtr UseItemList
	{
		get
		{
			if (_UseItemList == IntPtr.Zero)
			{
				_UseItemList = Dlfcn.GetIntPtr(securityLibrary, "kSecUseItemList");
			}
			return _UseItemList;
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemCopyMatching(IntPtr cfDictRef, out IntPtr result);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemAdd(IntPtr cfDictRef, IntPtr result);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemDelete(IntPtr cfDictRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	internal static extern SecStatusCode SecItemUpdate(IntPtr cfDictRef, IntPtr attrsToUpdate);
}

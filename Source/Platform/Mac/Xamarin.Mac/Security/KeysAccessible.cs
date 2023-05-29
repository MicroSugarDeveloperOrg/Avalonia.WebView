using System;
using ObjCRuntime;

namespace Security;

internal static class KeysAccessible
{
	private static IntPtr _WhenUnlocked;

	private static IntPtr _AfterFirstUnlock;

	private static IntPtr _Always;

	private static IntPtr _WhenUnlockedThisDeviceOnly;

	private static IntPtr _AfterFirstUnlockThisDeviceOnly;

	private static IntPtr _AlwaysThisDeviceOnly;

	public static IntPtr WhenUnlocked
	{
		get
		{
			if (_WhenUnlocked == IntPtr.Zero)
			{
				_WhenUnlocked = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleWhenUnlocked");
			}
			return _WhenUnlocked;
		}
	}

	public static IntPtr AfterFirstUnlock
	{
		get
		{
			if (_AfterFirstUnlock == IntPtr.Zero)
			{
				_AfterFirstUnlock = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleAfterFirstUnlock");
			}
			return _AfterFirstUnlock;
		}
	}

	public static IntPtr Always
	{
		get
		{
			if (_Always == IntPtr.Zero)
			{
				_Always = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleAlways");
			}
			return _Always;
		}
	}

	public static IntPtr WhenUnlockedThisDeviceOnly
	{
		get
		{
			if (_WhenUnlockedThisDeviceOnly == IntPtr.Zero)
			{
				_WhenUnlockedThisDeviceOnly = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleWhenUnlockedThisDeviceOnly");
			}
			return _WhenUnlockedThisDeviceOnly;
		}
	}

	public static IntPtr AfterFirstUnlockThisDeviceOnly
	{
		get
		{
			if (_AfterFirstUnlockThisDeviceOnly == IntPtr.Zero)
			{
				_AfterFirstUnlockThisDeviceOnly = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly");
			}
			return _AfterFirstUnlockThisDeviceOnly;
		}
	}

	public static IntPtr AlwaysThisDeviceOnly
	{
		get
		{
			if (_AlwaysThisDeviceOnly == IntPtr.Zero)
			{
				_AlwaysThisDeviceOnly = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessibleAlwaysThisDeviceOnly");
			}
			return _AlwaysThisDeviceOnly;
		}
	}

	public static IntPtr FromSecAccessible(SecAccessible accessible)
	{
		return accessible switch
		{
			SecAccessible.WhenUnlocked => WhenUnlocked, 
			SecAccessible.AfterFirstUnlock => AfterFirstUnlock, 
			SecAccessible.Always => Always, 
			SecAccessible.WhenUnlockedThisDeviceOnly => WhenUnlockedThisDeviceOnly, 
			SecAccessible.AfterFirstUnlockThisDeviceOnly => AfterFirstUnlockThisDeviceOnly, 
			SecAccessible.AlwaysThisDeviceOnly => AlwaysThisDeviceOnly, 
			_ => throw new ArgumentException("accessible"), 
		};
	}

	public static SecAccessible ToSecAccessible(IntPtr handle)
	{
		if (handle == WhenUnlocked)
		{
			return SecAccessible.WhenUnlocked;
		}
		if (handle == AfterFirstUnlock)
		{
			return SecAccessible.AfterFirstUnlock;
		}
		if (handle == Always)
		{
			return SecAccessible.Always;
		}
		if (handle == WhenUnlockedThisDeviceOnly)
		{
			return SecAccessible.WhenUnlockedThisDeviceOnly;
		}
		if (handle == AfterFirstUnlockThisDeviceOnly)
		{
			return SecAccessible.AfterFirstUnlockThisDeviceOnly;
		}
		if (handle == AlwaysThisDeviceOnly)
		{
			return SecAccessible.AlwaysThisDeviceOnly;
		}
		throw new ArgumentException("obj");
	}
}

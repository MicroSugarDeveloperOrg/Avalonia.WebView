using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class KeysAccessible
{
	[Field("kSecAttrAccessibleAfterFirstUnlock", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr AfterFirstUnlock
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleAfterFirstUnlock");
		}
	}

	[Field("kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr AfterFirstUnlockThisDeviceOnly
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly");
		}
	}

	[Field("kSecAttrAccessibleAlways", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr Always
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleAlways");
		}
	}

	[Field("kSecAttrAccessibleAlwaysThisDeviceOnly", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr AlwaysThisDeviceOnly
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleAlwaysThisDeviceOnly");
		}
	}

	[Field("kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly", "Security")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static IntPtr WhenPasscodeSetThisDeviceOnly
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly");
		}
	}

	[Field("kSecAttrAccessibleWhenUnlocked", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr WhenUnlocked
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleWhenUnlocked");
		}
	}

	[Field("kSecAttrAccessibleWhenUnlockedThisDeviceOnly", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr WhenUnlockedThisDeviceOnly
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessibleWhenUnlockedThisDeviceOnly");
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
			SecAccessible.WhenPasscodeSetThisDeviceOnly => WhenPasscodeSetThisDeviceOnly, 
			_ => throw new ArgumentException("accessible"), 
		};
	}

	public static SecAccessible ToSecAccessible(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return SecAccessible.Invalid;
		}
		if (CFType.Equal(handle, WhenUnlocked))
		{
			return SecAccessible.WhenUnlocked;
		}
		if (CFType.Equal(handle, AfterFirstUnlock))
		{
			return SecAccessible.AfterFirstUnlock;
		}
		if (CFType.Equal(handle, Always))
		{
			return SecAccessible.Always;
		}
		if (CFType.Equal(handle, WhenUnlockedThisDeviceOnly))
		{
			return SecAccessible.WhenUnlockedThisDeviceOnly;
		}
		if (CFType.Equal(handle, AfterFirstUnlockThisDeviceOnly))
		{
			return SecAccessible.AfterFirstUnlockThisDeviceOnly;
		}
		if (CFType.Equal(handle, AlwaysThisDeviceOnly))
		{
			return SecAccessible.AlwaysThisDeviceOnly;
		}
		if (CFType.Equal(handle, WhenUnlockedThisDeviceOnly))
		{
			return SecAccessible.WhenUnlockedThisDeviceOnly;
		}
		return SecAccessible.Invalid;
	}
}

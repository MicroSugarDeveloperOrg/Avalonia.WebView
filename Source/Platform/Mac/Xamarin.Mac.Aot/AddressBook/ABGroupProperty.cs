using System;
using ObjCRuntime;

namespace AddressBook;

internal static class ABGroupProperty
{
	public static int Name { get; private set; }

	static ABGroupProperty()
	{
		InitConstants.Init();
	}

	internal static void Init()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Name = Dlfcn.GetInt32(intPtr, "kABGroupNameProperty");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}

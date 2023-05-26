using System;
using ObjCRuntime;

namespace AddressBook;

internal static class ABSourcePropertyId
{
	public static int Name { get; private set; }

	public static int Type { get; private set; }

	static ABSourcePropertyId()
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
			Name = Dlfcn.GetInt32(intPtr, "kABSourceNameProperty");
			Type = Dlfcn.GetInt32(intPtr, "kABSourceTypeProperty");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	public static int ToId(ABSourceProperty property)
	{
		return property switch
		{
			ABSourceProperty.Name => Name, 
			ABSourceProperty.Type => Type, 
			_ => throw new NotSupportedException("Invalid ABSourceProperty value: " + property), 
		};
	}

	public static ABSourceProperty ToSourceProperty(int id)
	{
		if (id == Name)
		{
			return ABSourceProperty.Name;
		}
		if (id == Type)
		{
			return ABSourceProperty.Type;
		}
		throw new NotSupportedException("Invalid ABSourcePropertyId value: " + id);
	}
}

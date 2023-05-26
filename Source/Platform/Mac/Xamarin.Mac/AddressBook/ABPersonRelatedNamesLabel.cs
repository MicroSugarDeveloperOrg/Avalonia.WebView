using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public static class ABPersonRelatedNamesLabel
{
	public static NSString Assistant { get; private set; }

	public static NSString Brother { get; private set; }

	public static NSString Child { get; private set; }

	public static NSString Father { get; private set; }

	public static NSString Friend { get; private set; }

	public static NSString Manager { get; private set; }

	public static NSString Mother { get; private set; }

	public static NSString Parent { get; private set; }

	public static NSString Partner { get; private set; }

	public static NSString Sister { get; private set; }

	public static NSString Spouse { get; private set; }

	static ABPersonRelatedNamesLabel()
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
			Assistant = Dlfcn.GetStringConstant(intPtr, "kABPersonAssistantLabel");
			Brother = Dlfcn.GetStringConstant(intPtr, "kABPersonBrotherLabel");
			Child = Dlfcn.GetStringConstant(intPtr, "kABPersonChildLabel");
			Father = Dlfcn.GetStringConstant(intPtr, "kABPersonFatherLabel");
			Friend = Dlfcn.GetStringConstant(intPtr, "kABPersonFriendLabel");
			Manager = Dlfcn.GetStringConstant(intPtr, "kABPersonManagerLabel");
			Mother = Dlfcn.GetStringConstant(intPtr, "kABPersonMotherLabel");
			Parent = Dlfcn.GetStringConstant(intPtr, "kABPersonParentLabel");
			Partner = Dlfcn.GetStringConstant(intPtr, "kABPersonPartnerLabel");
			Sister = Dlfcn.GetStringConstant(intPtr, "kABPersonSisterLabel");
			Spouse = Dlfcn.GetStringConstant(intPtr, "kABPersonSpouseLabel");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class INPersonRelationshipExtensions
{
	private static IntPtr[] values = new IntPtr[13];

	[Field("INPersonRelationshipFather", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipFather
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipFather", storage);
			}
		}
	}

	[Field("INPersonRelationshipMother", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipMother
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipMother", storage);
			}
		}
	}

	[Field("INPersonRelationshipParent", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipParent
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipParent", storage);
			}
		}
	}

	[Field("INPersonRelationshipBrother", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipBrother
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipBrother", storage);
			}
		}
	}

	[Field("INPersonRelationshipSister", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipSister
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipSister", storage);
			}
		}
	}

	[Field("INPersonRelationshipChild", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipChild
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipChild", storage);
			}
		}
	}

	[Field("INPersonRelationshipFriend", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipFriend
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipFriend", storage);
			}
		}
	}

	[Field("INPersonRelationshipSpouse", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipSpouse
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipSpouse", storage);
			}
		}
	}

	[Field("INPersonRelationshipPartner", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipPartner
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipPartner", storage);
			}
		}
	}

	[Field("INPersonRelationshipAssistant", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipAssistant
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipAssistant", storage);
			}
		}
	}

	[Field("INPersonRelationshipManager", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipManager
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipManager", storage);
			}
		}
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("INPersonRelationshipSon", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipSon
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipSon", storage);
			}
		}
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("INPersonRelationshipDaughter", "Intents")]
	internal unsafe static IntPtr INPersonRelationshipDaughter
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.Intents.Handle, "INPersonRelationshipDaughter", storage);
			}
		}
	}

	public static NSString? GetConstant(this INPersonRelationship self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 1:
			ptr = INPersonRelationshipFather;
			break;
		case 2:
			ptr = INPersonRelationshipMother;
			break;
		case 3:
			ptr = INPersonRelationshipParent;
			break;
		case 4:
			ptr = INPersonRelationshipBrother;
			break;
		case 5:
			ptr = INPersonRelationshipSister;
			break;
		case 6:
			ptr = INPersonRelationshipChild;
			break;
		case 7:
			ptr = INPersonRelationshipFriend;
			break;
		case 8:
			ptr = INPersonRelationshipSpouse;
			break;
		case 9:
			ptr = INPersonRelationshipPartner;
			break;
		case 10:
			ptr = INPersonRelationshipAssistant;
			break;
		case 11:
			ptr = INPersonRelationshipManager;
			break;
		case 12:
			ptr = INPersonRelationshipSon;
			break;
		case 13:
			ptr = INPersonRelationshipDaughter;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static INPersonRelationship GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return INPersonRelationship.None;
		}
		if (constant.IsEqualTo(INPersonRelationshipFather))
		{
			return INPersonRelationship.Father;
		}
		if (constant.IsEqualTo(INPersonRelationshipMother))
		{
			return INPersonRelationship.Mother;
		}
		if (constant.IsEqualTo(INPersonRelationshipParent))
		{
			return INPersonRelationship.Parent;
		}
		if (constant.IsEqualTo(INPersonRelationshipBrother))
		{
			return INPersonRelationship.Brother;
		}
		if (constant.IsEqualTo(INPersonRelationshipSister))
		{
			return INPersonRelationship.Sister;
		}
		if (constant.IsEqualTo(INPersonRelationshipChild))
		{
			return INPersonRelationship.Child;
		}
		if (constant.IsEqualTo(INPersonRelationshipFriend))
		{
			return INPersonRelationship.Friend;
		}
		if (constant.IsEqualTo(INPersonRelationshipSpouse))
		{
			return INPersonRelationship.Spouse;
		}
		if (constant.IsEqualTo(INPersonRelationshipPartner))
		{
			return INPersonRelationship.Partner;
		}
		if (constant.IsEqualTo(INPersonRelationshipAssistant))
		{
			return INPersonRelationship.Assistant;
		}
		if (constant.IsEqualTo(INPersonRelationshipManager))
		{
			return INPersonRelationship.Manager;
		}
		if (constant.IsEqualTo(INPersonRelationshipSon))
		{
			return INPersonRelationship.Son;
		}
		if (constant.IsEqualTo(INPersonRelationshipDaughter))
		{
			return INPersonRelationship.Daughter;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

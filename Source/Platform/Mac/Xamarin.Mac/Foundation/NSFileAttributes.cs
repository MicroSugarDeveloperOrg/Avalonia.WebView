using Xamarin.Mac.System.Mac;

namespace Foundation;

public class NSFileAttributes
{
	public bool? AppendOnly { get; set; }

	public bool? Busy { get; set; }

	public bool? ExtensionHidden { get; set; }

	public NSDate CreationDate { get; set; }

	public string OwnerAccountName { get; set; }

	public string GroupOwnerAccountName { get; set; }

	public nint? SystemNumber { get; set; }

	public nuint? DeviceIdentifier { get; set; }

	public nuint? GroupOwnerAccountID { get; set; }

	public bool? Immutable { get; set; }

	public NSDate ModificationDate { get; set; }

	public nuint? OwnerAccountID { get; set; }

	public nuint? HfsCreatorCode { get; set; }

	public nuint? HfsTypeCode { get; set; }

	public short? PosixPermissions { get; set; }

	public nuint? ReferenceCount { get; set; }

	public nuint? SystemFileNumber { get; set; }

	public ulong? Size { get; set; }

	public NSFileType? Type { get; set; }

	internal NSDictionary ToDictionary()
	{
		NSString nSString = null;
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (AppendOnly.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromBoolean(AppendOnly.Value), NSFileManager.AppendOnly);
		}
		if (Busy.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromBoolean(Busy.Value), NSFileManager.Busy);
		}
		if (ExtensionHidden.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromBoolean(ExtensionHidden.Value), NSFileManager.ExtensionHidden);
		}
		if (CreationDate != null)
		{
			nSMutableDictionary.SetObject(CreationDate, NSFileManager.CreationDate);
		}
		if (OwnerAccountName != null)
		{
			nSMutableDictionary.SetObject(new NSString(OwnerAccountName), NSFileManager.OwnerAccountName);
		}
		if (GroupOwnerAccountName != null)
		{
			nSMutableDictionary.SetObject(new NSString(GroupOwnerAccountName), NSFileManager.GroupOwnerAccountName);
		}
		if (SystemNumber.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromLong(SystemNumber.Value), NSFileManager.SystemNumber);
		}
		if (DeviceIdentifier.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(DeviceIdentifier.Value), NSFileManager.DeviceIdentifier);
		}
		if (GroupOwnerAccountID.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(GroupOwnerAccountID.Value), NSFileManager.GroupOwnerAccountID);
		}
		if (Immutable.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromBoolean(Immutable.Value), NSFileManager.Immutable);
		}
		if (ModificationDate != null)
		{
			nSMutableDictionary.SetObject(ModificationDate, NSFileManager.ModificationDate);
		}
		if (OwnerAccountID.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(OwnerAccountID.Value), NSFileManager.OwnerAccountID);
		}
		if (HfsCreatorCode.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(HfsCreatorCode.Value), NSFileManager.HfsCreatorCode);
		}
		if (HfsTypeCode.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(HfsTypeCode.Value), NSFileManager.HfsTypeCode);
		}
		if (PosixPermissions.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt16(PosixPermissions.Value), NSFileManager.PosixPermissions);
		}
		if (ReferenceCount.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(ReferenceCount.Value), NSFileManager.ReferenceCount);
		}
		if (SystemFileNumber.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUnsignedLong(SystemFileNumber.Value), NSFileManager.SystemFileNumber);
		}
		if (Size.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromUInt64(Size.Value), NSFileManager.Size);
		}
		NSFileType? type = Type;
		if (type.HasValue)
		{
			nSString = null;
			nSMutableDictionary.SetObject(type.Value switch
			{
				NSFileType.Directory => NSFileManager.TypeDirectory, 
				NSFileType.Regular => NSFileManager.TypeRegular, 
				NSFileType.SymbolicLink => NSFileManager.TypeSymbolicLink, 
				NSFileType.Socket => NSFileManager.TypeSocket, 
				NSFileType.CharacterSpecial => NSFileManager.TypeCharacterSpecial, 
				NSFileType.BlockSpecial => NSFileManager.TypeBlockSpecial, 
				_ => NSFileManager.TypeUnknown, 
			}, NSFileManager.NSFileType);
		}
		return nSMutableDictionary;
	}

	internal static bool? fetch_bool(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.BoolValue;
	}

	internal static uint? fetch_uint(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.UInt32Value;
	}

	internal static nuint? fetch_nuint(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.UnsignedLongValue;
	}

	internal static nint? fetch_nint(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.LongValue;
	}

	internal static ulong? fetch_ulong(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.UInt64Value;
	}

	internal static long? fetch_long(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.Int64Value;
	}

	internal static short? fetch_short(NSDictionary dict, NSString key)
	{
		if (!(dict.ObjectForKey(key) is NSNumber nSNumber))
		{
			return null;
		}
		return nSNumber.Int16Value;
	}

	public static NSFileAttributes FromDictionary(NSDictionary dict)
	{
		if (dict == null)
		{
			return null;
		}
		NSFileAttributes nSFileAttributes = new NSFileAttributes();
		nSFileAttributes.AppendOnly = fetch_bool(dict, NSFileManager.AppendOnly);
		nSFileAttributes.Busy = fetch_bool(dict, NSFileManager.Busy);
		nSFileAttributes.ExtensionHidden = fetch_bool(dict, NSFileManager.ExtensionHidden);
		nSFileAttributes.CreationDate = dict.ObjectForKey(NSFileManager.CreationDate) as NSDate;
		nSFileAttributes.OwnerAccountName = dict.ObjectForKey(NSFileManager.OwnerAccountName) as NSString;
		nSFileAttributes.GroupOwnerAccountName = dict.ObjectForKey(NSFileManager.GroupOwnerAccountName) as NSString;
		nSFileAttributes.SystemNumber = fetch_nint(dict, NSFileManager.SystemNumber);
		nSFileAttributes.DeviceIdentifier = fetch_nuint(dict, NSFileManager.DeviceIdentifier);
		nSFileAttributes.GroupOwnerAccountID = fetch_nuint(dict, NSFileManager.GroupOwnerAccountID);
		nSFileAttributes.Immutable = fetch_bool(dict, NSFileManager.Immutable);
		nSFileAttributes.ModificationDate = dict.ObjectForKey(NSFileManager.ModificationDate) as NSDate;
		nSFileAttributes.OwnerAccountID = fetch_nuint(dict, NSFileManager.OwnerAccountID);
		nSFileAttributes.HfsCreatorCode = fetch_nuint(dict, NSFileManager.HfsCreatorCode);
		nSFileAttributes.HfsTypeCode = fetch_nuint(dict, NSFileManager.HfsTypeCode);
		nSFileAttributes.PosixPermissions = fetch_short(dict, NSFileManager.PosixPermissions);
		nSFileAttributes.ReferenceCount = fetch_nuint(dict, NSFileManager.ReferenceCount);
		nSFileAttributes.SystemFileNumber = fetch_nuint(dict, NSFileManager.SystemFileNumber);
		nSFileAttributes.Size = fetch_ulong(dict, NSFileManager.Size);
		NSString nSString = dict.ObjectForKey(NSFileManager.NSFileType) as NSString;
		if (nSString != null)
		{
			NSFileType? type = null;
			if (nSString == NSFileManager.TypeDirectory)
			{
				type = NSFileType.Directory;
			}
			else if (nSString == NSFileManager.TypeRegular)
			{
				type = NSFileType.Regular;
			}
			else if (nSString == NSFileManager.TypeSymbolicLink)
			{
				type = NSFileType.SymbolicLink;
			}
			else if (nSString == NSFileManager.TypeSocket)
			{
				type = NSFileType.Socket;
			}
			else if (nSString == NSFileManager.TypeCharacterSpecial)
			{
				type = NSFileType.CharacterSpecial;
			}
			else if (nSString == NSFileManager.TypeBlockSpecial)
			{
				type = NSFileType.BlockSpecial;
			}
			else if (nSString == NSFileManager.TypeUnknown)
			{
				type = NSFileType.Unknown;
			}
			nSFileAttributes.Type = type;
		}
		return nSFileAttributes;
	}
}

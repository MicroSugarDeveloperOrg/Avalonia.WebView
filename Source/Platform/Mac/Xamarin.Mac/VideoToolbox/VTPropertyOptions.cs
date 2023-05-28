using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTPropertyOptions : DictionaryContainer
{
	public VTPropertyType Type
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPropertyKeys.Type);
			if (nSStringValue == null)
			{
				return VTPropertyType.Unset;
			}
			if (nSStringValue == VTPropertyTypeKeys.Enumeration)
			{
				return VTPropertyType.Enumeration;
			}
			if (nSStringValue == VTPropertyTypeKeys.Boolean)
			{
				return VTPropertyType.Boolean;
			}
			if (nSStringValue == VTPropertyTypeKeys.Number)
			{
				return VTPropertyType.Number;
			}
			return VTPropertyType.Unset;
		}
		set
		{
			switch (value)
			{
			case VTPropertyType.Enumeration:
				SetStringValue(VTPropertyKeys.Type, VTPropertyTypeKeys.Enumeration);
				break;
			case VTPropertyType.Boolean:
				SetStringValue(VTPropertyKeys.Type, VTPropertyTypeKeys.Boolean);
				break;
			case VTPropertyType.Number:
				SetStringValue(VTPropertyKeys.Type, VTPropertyTypeKeys.Number);
				break;
			default:
				SetStringValue(VTPropertyKeys.Type, null);
				break;
			}
		}
	}

	public VTReadWriteStatus ReadWriteStatus
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPropertyKeys.ReadWriteStatus);
			if (nSStringValue == null)
			{
				return VTReadWriteStatus.Unset;
			}
			if (nSStringValue == VTPropertyReadWriteStatusKeys.ReadOnly)
			{
				return VTReadWriteStatus.ReadOnly;
			}
			if (nSStringValue == VTPropertyReadWriteStatusKeys.ReadWrite)
			{
				return VTReadWriteStatus.ReadWrite;
			}
			return VTReadWriteStatus.Unset;
		}
		set
		{
			switch (value)
			{
			case VTReadWriteStatus.ReadOnly:
				SetStringValue(VTPropertyKeys.ReadWriteStatus, VTPropertyReadWriteStatusKeys.ReadOnly);
				break;
			case VTReadWriteStatus.ReadWrite:
				SetStringValue(VTPropertyKeys.ReadWriteStatus, VTPropertyReadWriteStatusKeys.ReadWrite);
				break;
			default:
				SetStringValue(VTPropertyKeys.ReadWriteStatus, null);
				break;
			}
		}
	}

	public bool? ShouldBeSerialized
	{
		get
		{
			return GetBoolValue(VTPropertyKeys.ShouldBeSerialized);
		}
		set
		{
			SetBooleanValue(VTPropertyKeys.ShouldBeSerialized, value);
		}
	}

	public NSNumber? SupportedValueMinimum
	{
		get
		{
			return base.Dictionary[VTPropertyKeys.SupportedValueMinimumKey] as NSNumber;
		}
		set
		{
			SetNativeValue(VTPropertyKeys.SupportedValueMinimumKey, value);
		}
	}

	public NSNumber? SupportedValueMaximum
	{
		get
		{
			return base.Dictionary[VTPropertyKeys.SupportedValueMaximumKey] as NSNumber;
		}
		set
		{
			SetNativeValue(VTPropertyKeys.SupportedValueMaximumKey, value);
		}
	}

	public NSNumber[]? SupportedValueList
	{
		get
		{
			return GetArray<NSNumber>(VTPropertyKeys.SupportedValueListKey);
		}
		set
		{
			SetArrayValue(VTPropertyKeys.SupportedValueListKey, value);
		}
	}

	public NSString? Documentation
	{
		get
		{
			return GetNSStringValue(VTPropertyKeys.DocumentationKey);
		}
		set
		{
			SetStringValue(VTPropertyKeys.DocumentationKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTPropertyOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTPropertyOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

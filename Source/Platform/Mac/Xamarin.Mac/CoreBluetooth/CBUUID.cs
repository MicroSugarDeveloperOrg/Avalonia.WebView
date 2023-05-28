using System;
using System.ComponentModel;
using System.Text;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBUUID", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBUUID : NSObject, IEquatable<CBUUID>, INSCopying, INativeObject, IDisposable
{
	private const string format16bits = "{0:x2}{1:x2}";

	private const string format32bits = "{0:x2}{1:x2}{2:x2}{3:x2}";

	private const string format128bits = "{0:x2}{1:x2}{2:x2}{3:x2}-0000-1000-8000-00805f9b34fb";

	private const ulong highServiceBits = 18101263636780548224uL;

	private const ulong lowServiceMask = 4503599627370496uL;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDString = "UUIDString";

	private static readonly IntPtr selUUIDStringHandle = Selector.GetHandle("UUIDString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDWithCFUUID_ = "UUIDWithCFUUID:";

	private static readonly IntPtr selUUIDWithCFUUID_Handle = Selector.GetHandle("UUIDWithCFUUID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDWithData_ = "UUIDWithData:";

	private static readonly IntPtr selUUIDWithData_Handle = Selector.GetHandle("UUIDWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDWithNSUUID_ = "UUIDWithNSUUID:";

	private static readonly IntPtr selUUIDWithNSUUID_Handle = Selector.GetHandle("UUIDWithNSUUID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDWithString_ = "UUIDWithString:";

	private static readonly IntPtr selUUIDWithString_Handle = Selector.GetHandle("UUIDWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBUUID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppearanceString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CBUUIDCharacteristicValidRangeString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CBUUIDValidRangeString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicAggregateFormatString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicExtendedPropertiesString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicFormatString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacteristicUserDescriptionString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ClientCharacteristicConfigurationString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceNameString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericAccessProfileString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericAttributeProfileString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _L2CapPsmCharacteristicString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PeripheralPreferredConnectionParametersString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PeripheralPrivacyFlagString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReconnectionAddressString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServerCharacteristicConfigurationString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServiceChangedString;

	[Mac(10, 13)]
	public static NSString CharacteristicValidRangeString => CBUUIDCharacteristicValidRangeString ?? CBUUIDValidRangeString;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string Uuid
	{
		[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("UUIDString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUUIDStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUUIDStringHandle));
		}
	}

	[Field("CBUUIDAppearanceString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString AppearanceString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_AppearanceString == null)
			{
				_AppearanceString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDAppearanceString");
			}
			return _AppearanceString;
		}
	}

	[Field("CBUUIDCharacteristicValidRangeString", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	internal static NSString CBUUIDCharacteristicValidRangeString
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_CBUUIDCharacteristicValidRangeString == null)
			{
				_CBUUIDCharacteristicValidRangeString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDCharacteristicValidRangeString");
			}
			return _CBUUIDCharacteristicValidRangeString;
		}
	}

	[Field("CBUUIDValidRangeString", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	internal static NSString CBUUIDValidRangeString
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		get
		{
			if (_CBUUIDValidRangeString == null)
			{
				_CBUUIDValidRangeString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDValidRangeString");
			}
			return _CBUUIDValidRangeString;
		}
	}

	[Field("CBUUIDCharacteristicAggregateFormatString", "CoreBluetooth")]
	public static NSString CharacteristicAggregateFormatString
	{
		get
		{
			if (_CharacteristicAggregateFormatString == null)
			{
				_CharacteristicAggregateFormatString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDCharacteristicAggregateFormatString");
			}
			return _CharacteristicAggregateFormatString;
		}
	}

	[Field("CBUUIDCharacteristicExtendedPropertiesString", "CoreBluetooth")]
	public static NSString CharacteristicExtendedPropertiesString
	{
		get
		{
			if (_CharacteristicExtendedPropertiesString == null)
			{
				_CharacteristicExtendedPropertiesString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDCharacteristicExtendedPropertiesString");
			}
			return _CharacteristicExtendedPropertiesString;
		}
	}

	[Field("CBUUIDCharacteristicFormatString", "CoreBluetooth")]
	public static NSString CharacteristicFormatString
	{
		get
		{
			if (_CharacteristicFormatString == null)
			{
				_CharacteristicFormatString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDCharacteristicFormatString");
			}
			return _CharacteristicFormatString;
		}
	}

	[Field("CBUUIDCharacteristicUserDescriptionString", "CoreBluetooth")]
	public static NSString CharacteristicUserDescriptionString
	{
		get
		{
			if (_CharacteristicUserDescriptionString == null)
			{
				_CharacteristicUserDescriptionString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDCharacteristicUserDescriptionString");
			}
			return _CharacteristicUserDescriptionString;
		}
	}

	[Field("CBUUIDClientCharacteristicConfigurationString", "CoreBluetooth")]
	public static NSString ClientCharacteristicConfigurationString
	{
		get
		{
			if (_ClientCharacteristicConfigurationString == null)
			{
				_ClientCharacteristicConfigurationString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDClientCharacteristicConfigurationString");
			}
			return _ClientCharacteristicConfigurationString;
		}
	}

	[Field("CBUUIDDeviceNameString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString DeviceNameString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_DeviceNameString == null)
			{
				_DeviceNameString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDDeviceNameString");
			}
			return _DeviceNameString;
		}
	}

	[Field("CBUUIDGenericAccessProfileString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString GenericAccessProfileString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_GenericAccessProfileString == null)
			{
				_GenericAccessProfileString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDGenericAccessProfileString");
			}
			return _GenericAccessProfileString;
		}
	}

	[Field("CBUUIDGenericAttributeProfileString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString GenericAttributeProfileString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_GenericAttributeProfileString == null)
			{
				_GenericAttributeProfileString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDGenericAttributeProfileString");
			}
			return _GenericAttributeProfileString;
		}
	}

	[Field("CBUUIDL2CAPPSMCharacteristicString", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString L2CapPsmCharacteristicString
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_L2CapPsmCharacteristicString == null)
			{
				_L2CapPsmCharacteristicString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDL2CAPPSMCharacteristicString");
			}
			return _L2CapPsmCharacteristicString;
		}
	}

	[Field("CBUUIDPeripheralPreferredConnectionParametersString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString PeripheralPreferredConnectionParametersString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_PeripheralPreferredConnectionParametersString == null)
			{
				_PeripheralPreferredConnectionParametersString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDPeripheralPreferredConnectionParametersString");
			}
			return _PeripheralPreferredConnectionParametersString;
		}
	}

	[Field("CBUUIDPeripheralPrivacyFlagString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString PeripheralPrivacyFlagString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_PeripheralPrivacyFlagString == null)
			{
				_PeripheralPrivacyFlagString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDPeripheralPrivacyFlagString");
			}
			return _PeripheralPrivacyFlagString;
		}
	}

	[Field("CBUUIDReconnectionAddressString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString ReconnectionAddressString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_ReconnectionAddressString == null)
			{
				_ReconnectionAddressString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDReconnectionAddressString");
			}
			return _ReconnectionAddressString;
		}
	}

	[Field("CBUUIDServerCharacteristicConfigurationString", "CoreBluetooth")]
	public static NSString ServerCharacteristicConfigurationString
	{
		get
		{
			if (_ServerCharacteristicConfigurationString == null)
			{
				_ServerCharacteristicConfigurationString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDServerCharacteristicConfigurationString");
			}
			return _ServerCharacteristicConfigurationString;
		}
	}

	[Field("CBUUIDServiceChangedString", "CoreBluetooth")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	public static NSString ServiceChangedString
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_ServiceChangedString == null)
			{
				_ServiceChangedString = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBUUIDServiceChangedString");
			}
			return _ServiceChangedString;
		}
	}

	public static CBUUID FromBytes(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (bytes.Length != 2 && bytes.Length != 4 && bytes.Length != 16)
		{
			throw new ArgumentException("must either be 2, 4, or 16 bytes long", "bytes");
		}
		using NSData theData = NSData.FromArray(bytes);
		return FromData(theData);
	}

	public static CBUUID FromPartial(ushort servicePart)
	{
		return FromBytes(new byte[2]
		{
			(byte)(servicePart >> 8),
			(byte)servicePart
		});
	}

	public override string ToString()
	{
		return ToString(fullUuid: false);
	}

	public static bool operator ==(CBUUID a, CBUUID b)
	{
		return a?.Equals(b) ?? ((object)b == null);
	}

	public static bool operator !=(CBUUID a, CBUUID b)
	{
		return !(a == b);
	}

	public bool Equals(CBUUID obj)
	{
		return Equals((NSObject)obj);
	}

	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public unsafe string ToString(bool fullUuid)
	{
		NSData data = Data;
		if (data == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte* ptr = (byte*)(void*)data.Bytes;
		switch (data.Length)
		{
		case 2L:
			if (fullUuid)
			{
				stringBuilder.AppendFormat("{0:x2}{1:x2}{2:x2}{3:x2}-0000-1000-8000-00805f9b34fb", 0, 0, *(ptr++), *(ptr++));
			}
			else
			{
				stringBuilder.AppendFormat("{0:x2}{1:x2}", *(ptr++), *(ptr++));
			}
			break;
		case 4L:
			stringBuilder.AppendFormat(fullUuid ? "{0:x2}{1:x2}{2:x2}{3:x2}-0000-1000-8000-00805f9b34fb" : "{0:x2}{1:x2}{2:x2}{3:x2}", *(ptr++), *(ptr++), *(ptr++), *(ptr++));
			break;
		case 16L:
			stringBuilder.AppendFormat("{0:x2}{1:x2}{2:x2}{3:x2}-{4:x2}{5:x2}-{6:x2}{7:x2}-{8:x2}{9:x2}-{10:x2}{11:x2}{12:x2}{13:x2}{14:x2}{15:x2}", *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *(ptr++), *ptr);
			break;
		}
		return stringBuilder.ToString();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBUUID(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBUUID(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("UUIDWithCFUUID:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CBUUID FromCFUUID(IntPtr theUUID)
	{
		return Runtime.GetNSObject<CBUUID>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUUIDWithCFUUID_Handle, theUUID));
	}

	[Export("UUIDWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CBUUID FromData(NSData theData)
	{
		if (theData == null)
		{
			throw new ArgumentNullException("theData");
		}
		return Runtime.GetNSObject<CBUUID>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUUIDWithData_Handle, theData.Handle));
	}

	[Export("UUIDWithNSUUID:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CBUUID FromNSUuid(NSUuid theUUID)
	{
		if (theUUID == null)
		{
			throw new ArgumentNullException("theUUID");
		}
		return Runtime.GetNSObject<CBUUID>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUUIDWithNSUUID_Handle, theUUID.Handle));
	}

	[Export("UUIDWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CBUUID FromString(string theString)
	{
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		IntPtr arg = NSString.CreateNative(theString);
		CBUUID nSObject = Runtime.GetNSObject<CBUUID>(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(class_ptr, selUUIDWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

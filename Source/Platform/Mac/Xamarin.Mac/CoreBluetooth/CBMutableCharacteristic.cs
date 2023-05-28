using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBMutableCharacteristic", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CBMutableCharacteristic : CBCharacteristic
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptors = "descriptors";

	private static readonly IntPtr selDescriptorsHandle = Selector.GetHandle("descriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_Properties_Value_Permissions_ = "initWithType:properties:value:permissions:";

	private static readonly IntPtr selInitWithType_Properties_Value_Permissions_Handle = Selector.GetHandle("initWithType:properties:value:permissions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPermissions = "permissions";

	private static readonly IntPtr selPermissionsHandle = Selector.GetHandle("permissions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperties = "properties";

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDescriptors_ = "setDescriptors:";

	private static readonly IntPtr selSetDescriptors_Handle = Selector.GetHandle("setDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPermissions_ = "setPermissions:";

	private static readonly IntPtr selSetPermissions_Handle = Selector.GetHandle("setPermissions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperties_ = "setProperties:";

	private static readonly IntPtr selSetProperties_Handle = Selector.GetHandle("setProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscribedCentrals = "subscribedCentrals";

	private static readonly IntPtr selSubscribedCentralsHandle = Selector.GetHandle("subscribedCentrals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBMutableCharacteristic");

	[Obsolete("The setter is an empty stub (not mutable)")]
	public override CBUUID UUID
	{
		get
		{
			return base.UUID;
		}
		set
		{
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CBDescriptor[]? Descriptors
	{
		[Export("descriptors", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<CBDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptorsHandle));
		}
		[Export("setDescriptors:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBAttributePermissions Permissions
	{
		[Export("permissions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CBAttributePermissions)Messaging.UInt64_objc_msgSend(base.Handle, selPermissionsHandle);
			}
			return (CBAttributePermissions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPermissionsHandle);
		}
		[Export("setPermissions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPermissions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPermissions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CBCharacteristicProperties Properties
	{
		[Export("properties", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CBCharacteristicProperties)Messaging.UInt64_objc_msgSend(base.Handle, selPropertiesHandle);
			}
			return (CBCharacteristicProperties)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle);
		}
		[Export("setProperties:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetProperties_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetProperties_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CBCentral[] SubscribedCentrals
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("subscribedCentrals")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBCentral>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscribedCentralsHandle));
			}
			return NSArray.ArrayFromHandle<CBCentral>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscribedCentralsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSData? Value
	{
		[Export("value", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
		[Export("setValue:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBMutableCharacteristic(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBMutableCharacteristic(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:properties:value:permissions:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBMutableCharacteristic(CBUUID uuid, CBCharacteristicProperties properties, NSData? value, CBAttributePermissions permissions)
		: base(NSObjectFlag.Empty)
	{
		if (uuid == null)
		{
			throw new ArgumentNullException("uuid");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64(base.Handle, selInitWithType_Properties_Value_Permissions_Handle, uuid.Handle, (ulong)properties, value?.Handle ?? IntPtr.Zero, (ulong)permissions), "initWithType:properties:value:permissions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64(base.SuperHandle, selInitWithType_Properties_Value_Permissions_Handle, uuid.Handle, (ulong)properties, value?.Handle ?? IntPtr.Zero, (ulong)permissions), "initWithType:properties:value:permissions:");
		}
	}
}

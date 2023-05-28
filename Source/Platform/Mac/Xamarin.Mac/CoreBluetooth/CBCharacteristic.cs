using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBCharacteristic", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBCharacteristic : CBAttribute
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptors = "descriptors";

	private static readonly IntPtr selDescriptorsHandle = Selector.GetHandle("descriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBroadcasted = "isBroadcasted";

	private static readonly IntPtr selIsBroadcastedHandle = Selector.GetHandle("isBroadcasted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNotifying = "isNotifying";

	private static readonly IntPtr selIsNotifyingHandle = Selector.GetHandle("isNotifying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperties = "properties";

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selService = "service";

	private static readonly IntPtr selServiceHandle = Selector.GetHandle("service");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBCharacteristic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Service_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBDescriptor[]? Descriptors
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
		[NotImplemented("Not available on CBCharacteristic, only available on CBMutableCharacteristic")]
		set
		{
			throw new NotImplementedException("Not available on CBCharacteristic, only available on CBMutableCharacteristic");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual bool IsBroadcasted
	{
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("isBroadcasted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBroadcastedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBroadcastedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsNotifying
	{
		[Export("isNotifying")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsNotifyingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsNotifyingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBCharacteristicProperties Properties
	{
		[Export("properties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CBCharacteristicProperties)Messaging.UInt64_objc_msgSend(base.Handle, selPropertiesHandle);
			}
			return (CBCharacteristicProperties)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle);
		}
		[NotImplemented("Not available on CBCharacteristic, only available on CBMutableCharacteristic")]
		set
		{
			throw new NotImplementedException("Not available on CBCharacteristic, only available on CBMutableCharacteristic");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBService Service
	{
		[Export("service", ArgumentSemantic.Weak)]
		get
		{
			CBService cBService = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CBService>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServiceHandle)) : Runtime.GetNSObject<CBService>(Messaging.IntPtr_objc_msgSend(base.Handle, selServiceHandle)));
			MarkDirty();
			__mt_Service_var = cBService;
			return cBService;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Value
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
		[NotImplemented("Not available on CBCharacteristic, only available on CBMutableCharacteristic")]
		set
		{
			throw new NotImplementedException("Not available on CBCharacteristic, only available on CBMutableCharacteristic");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBCharacteristic(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBCharacteristic(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Service_var = null;
		}
	}
}

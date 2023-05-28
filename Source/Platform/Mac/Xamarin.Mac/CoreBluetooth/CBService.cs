using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBService", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBService : CBAttribute
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacteristics = "characteristics";

	private static readonly IntPtr selCharacteristicsHandle = Selector.GetHandle("characteristics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludedServices = "includedServices";

	private static readonly IntPtr selIncludedServicesHandle = Selector.GetHandle("includedServices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPrimary = "isPrimary";

	private static readonly IntPtr selIsPrimaryHandle = Selector.GetHandle("isPrimary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeripheral = "peripheral";

	private static readonly IntPtr selPeripheralHandle = Selector.GetHandle("peripheral");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Peripheral_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBCharacteristic[] Characteristics
	{
		[Export("characteristics", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBCharacteristic>(Messaging.IntPtr_objc_msgSend(base.Handle, selCharacteristicsHandle));
			}
			return NSArray.ArrayFromHandle<CBCharacteristic>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharacteristicsHandle));
		}
		[NotImplemented("Not available on 'CBService', only available on CBMutableService.")]
		set
		{
			throw new NotImplementedException("Not available on 'CBService', only available on CBMutableService.");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBService[] IncludedServices
	{
		[Export("includedServices", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSend(base.Handle, selIncludedServicesHandle));
			}
			return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIncludedServicesHandle));
		}
		[NotImplemented("Not available on 'CBService', only available on CBMutableService.")]
		set
		{
			throw new NotImplementedException("Not available on 'CBService', only available on CBMutableService.");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBPeripheral Peripheral
	{
		[Export("peripheral", ArgumentSemantic.Weak)]
		get
		{
			CBPeripheral cBPeripheral = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CBPeripheral>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPeripheralHandle)) : Runtime.GetNSObject<CBPeripheral>(Messaging.IntPtr_objc_msgSend(base.Handle, selPeripheralHandle)));
			MarkDirty();
			__mt_Peripheral_var = cBPeripheral;
			return cBPeripheral;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool Primary
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("isPrimary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPrimaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPrimaryHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[NotImplemented("Not available on 'CBService', only available on 'CBMutableService'.")]
		set
		{
			throw new NotImplementedException("Not available on 'CBService', only available on 'CBMutableService'.");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBService(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBService(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Peripheral_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBPeripheral", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBPeripheral : CBPeer, INSCopying, INativeObject, IDisposable
{
	[Register]
	internal class _CBPeripheralDelegate : NSObject, ICBPeripheralDelegate, INativeObject, IDisposable
	{
		internal EventHandler<CBPeripheralOpenL2CapChannelEventArgs>? didOpenL2CapChannel;

		internal EventHandler<CBServiceEventArgs>? discoveredCharacteristic;

		internal EventHandler<CBCharacteristicEventArgs>? discoveredDescriptor;

		internal EventHandler<CBServiceEventArgs>? discoveredIncludedService;

		internal EventHandler<NSErrorEventArgs>? discoveredService;

		internal EventHandler? invalidatedService;

		internal EventHandler? isReadyToSendWriteWithoutResponse;

		internal EventHandler<CBPeripheralServicesEventArgs>? modifiedServices;

		internal EventHandler<CBRssiEventArgs>? rssiRead;

		internal EventHandler<NSErrorEventArgs>? rssiUpdated;

		internal EventHandler<CBCharacteristicEventArgs>? updatedCharacterteristicValue;

		internal EventHandler? updatedName;

		internal EventHandler<CBCharacteristicEventArgs>? updatedNotificationState;

		internal EventHandler<CBDescriptorEventArgs>? updatedValue;

		internal EventHandler<CBCharacteristicEventArgs>? wroteCharacteristicValue;

		internal EventHandler<CBDescriptorEventArgs>? wroteDescriptorValue;

		public _CBPeripheralDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didOpenL2CAPChannel:error:")]
		public void DidOpenL2CapChannel(CBPeripheral peripheral, CBL2CapChannel? channel, NSError? error)
		{
			EventHandler<CBPeripheralOpenL2CapChannelEventArgs> eventHandler = didOpenL2CapChannel;
			if (eventHandler != null)
			{
				CBPeripheralOpenL2CapChannelEventArgs e = new CBPeripheralOpenL2CapChannelEventArgs(channel, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didDiscoverCharacteristicsForService:error:")]
		public void DiscoveredCharacteristic(CBPeripheral peripheral, CBService service, NSError error)
		{
			EventHandler<CBServiceEventArgs> eventHandler = discoveredCharacteristic;
			if (eventHandler != null)
			{
				CBServiceEventArgs e = new CBServiceEventArgs(service, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didDiscoverDescriptorsForCharacteristic:error:")]
		public void DiscoveredDescriptor(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
		{
			EventHandler<CBCharacteristicEventArgs> eventHandler = discoveredDescriptor;
			if (eventHandler != null)
			{
				CBCharacteristicEventArgs e = new CBCharacteristicEventArgs(characteristic, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didDiscoverIncludedServicesForService:error:")]
		public void DiscoveredIncludedService(CBPeripheral peripheral, CBService service, NSError error)
		{
			EventHandler<CBServiceEventArgs> eventHandler = discoveredIncludedService;
			if (eventHandler != null)
			{
				CBServiceEventArgs e = new CBServiceEventArgs(service, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didDiscoverServices:")]
		public void DiscoveredService(CBPeripheral peripheral, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = discoveredService;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralDidInvalidateServices:")]
		public void InvalidatedService(CBPeripheral peripheral)
		{
			invalidatedService?.Invoke(peripheral, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("peripheralIsReadyToSendWriteWithoutResponse:")]
		public void IsReadyToSendWriteWithoutResponse(CBPeripheral peripheral)
		{
			isReadyToSendWriteWithoutResponse?.Invoke(peripheral, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didModifyServices:")]
		public void ModifiedServices(CBPeripheral peripheral, CBService[] services)
		{
			EventHandler<CBPeripheralServicesEventArgs> eventHandler = modifiedServices;
			if (eventHandler != null)
			{
				CBPeripheralServicesEventArgs e = new CBPeripheralServicesEventArgs(services);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didReadRSSI:error:")]
		public void RssiRead(CBPeripheral peripheral, NSNumber rssi, NSError error)
		{
			EventHandler<CBRssiEventArgs> eventHandler = rssiRead;
			if (eventHandler != null)
			{
				CBRssiEventArgs e = new CBRssiEventArgs(rssi, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralDidUpdateRSSI:error:")]
		public void RssiUpdated(CBPeripheral peripheral, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = rssiUpdated;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didUpdateValueForCharacteristic:error:")]
		public void UpdatedCharacterteristicValue(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
		{
			EventHandler<CBCharacteristicEventArgs> eventHandler = updatedCharacterteristicValue;
			if (eventHandler != null)
			{
				CBCharacteristicEventArgs e = new CBCharacteristicEventArgs(characteristic, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralDidUpdateName:")]
		public void UpdatedName(CBPeripheral peripheral)
		{
			updatedName?.Invoke(peripheral, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didUpdateNotificationStateForCharacteristic:error:")]
		public void UpdatedNotificationState(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
		{
			EventHandler<CBCharacteristicEventArgs> eventHandler = updatedNotificationState;
			if (eventHandler != null)
			{
				CBCharacteristicEventArgs e = new CBCharacteristicEventArgs(characteristic, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didUpdateValueForDescriptor:error:")]
		public void UpdatedValue(CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
		{
			EventHandler<CBDescriptorEventArgs> eventHandler = updatedValue;
			if (eventHandler != null)
			{
				CBDescriptorEventArgs e = new CBDescriptorEventArgs(descriptor, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didWriteValueForCharacteristic:error:")]
		public void WroteCharacteristicValue(CBPeripheral peripheral, CBCharacteristic characteristic, NSError error)
		{
			EventHandler<CBCharacteristicEventArgs> eventHandler = wroteCharacteristicValue;
			if (eventHandler != null)
			{
				CBCharacteristicEventArgs e = new CBCharacteristicEventArgs(characteristic, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheral:didWriteValueForDescriptor:error:")]
		public void WroteDescriptorValue(CBPeripheral peripheral, CBDescriptor descriptor, NSError error)
		{
			EventHandler<CBDescriptorEventArgs> eventHandler = wroteDescriptorValue;
			if (eventHandler != null)
			{
				CBDescriptorEventArgs e = new CBDescriptorEventArgs(descriptor, error);
				eventHandler(peripheral, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRSSI = "RSSI";

	private static readonly IntPtr selRSSIHandle = Selector.GetHandle("RSSI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSendWriteWithoutResponse = "canSendWriteWithoutResponse";

	private static readonly IntPtr selCanSendWriteWithoutResponseHandle = Selector.GetHandle("canSendWriteWithoutResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverCharacteristics_ForService_ = "discoverCharacteristics:forService:";

	private static readonly IntPtr selDiscoverCharacteristics_ForService_Handle = Selector.GetHandle("discoverCharacteristics:forService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverDescriptorsForCharacteristic_ = "discoverDescriptorsForCharacteristic:";

	private static readonly IntPtr selDiscoverDescriptorsForCharacteristic_Handle = Selector.GetHandle("discoverDescriptorsForCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverIncludedServices_ForService_ = "discoverIncludedServices:forService:";

	private static readonly IntPtr selDiscoverIncludedServices_ForService_Handle = Selector.GetHandle("discoverIncludedServices:forService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverServices_ = "discoverServices:";

	private static readonly IntPtr selDiscoverServices_Handle = Selector.GetHandle("discoverServices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConnected = "isConnected";

	private static readonly IntPtr selIsConnectedHandle = Selector.GetHandle("isConnected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumWriteValueLengthForType_ = "maximumWriteValueLengthForType:";

	private static readonly IntPtr selMaximumWriteValueLengthForType_Handle = Selector.GetHandle("maximumWriteValueLengthForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenL2CAPChannel_ = "openL2CAPChannel:";

	private static readonly IntPtr selOpenL2CAPChannel_Handle = Selector.GetHandle("openL2CAPChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadRSSI = "readRSSI";

	private static readonly IntPtr selReadRSSIHandle = Selector.GetHandle("readRSSI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadValueForCharacteristic_ = "readValueForCharacteristic:";

	private static readonly IntPtr selReadValueForCharacteristic_Handle = Selector.GetHandle("readValueForCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadValueForDescriptor_ = "readValueForDescriptor:";

	private static readonly IntPtr selReadValueForDescriptor_Handle = Selector.GetHandle("readValueForDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServices = "services";

	private static readonly IntPtr selServicesHandle = Selector.GetHandle("services");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotifyValue_ForCharacteristic_ = "setNotifyValue:forCharacteristic:";

	private static readonly IntPtr selSetNotifyValue_ForCharacteristic_Handle = Selector.GetHandle("setNotifyValue:forCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteValue_ForCharacteristic_Type_ = "writeValue:forCharacteristic:type:";

	private static readonly IntPtr selWriteValue_ForCharacteristic_Type_Handle = Selector.GetHandle("writeValue:forCharacteristic:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteValue_ForDescriptor_ = "writeValue:forDescriptor:";

	private static readonly IntPtr selWriteValue_ForDescriptor_Handle = Selector.GetHandle("writeValue:forDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBPeripheral");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool CanSendWriteWithoutResponse
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("canSendWriteWithoutResponse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanSendWriteWithoutResponseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSendWriteWithoutResponseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ICBPeripheralDelegate Delegate
	{
		get
		{
			return WeakDelegate as ICBPeripheralDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool IsConnected
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("isConnected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConnectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConnectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual NSNumber RSSI
	{
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("RSSI", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selRSSIHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRSSIHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBService[] Services
	{
		[Export("services", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSend(base.Handle, selServicesHandle));
			}
			return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CBPeripheralState State
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CBPeripheralState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (CBPeripheralState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_CBPeripheralDelegate);

	public event EventHandler<CBPeripheralOpenL2CapChannelEventArgs> DidOpenL2CapChannel
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.didOpenL2CapChannel = (EventHandler<CBPeripheralOpenL2CapChannelEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.didOpenL2CapChannel, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.didOpenL2CapChannel = (EventHandler<CBPeripheralOpenL2CapChannelEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.didOpenL2CapChannel, value);
		}
	}

	public event EventHandler<CBServiceEventArgs> DiscoveredCharacteristic
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredCharacteristic = (EventHandler<CBServiceEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.discoveredCharacteristic, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredCharacteristic = (EventHandler<CBServiceEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.discoveredCharacteristic, value);
		}
	}

	public event EventHandler<CBCharacteristicEventArgs> DiscoveredDescriptor
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredDescriptor = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.discoveredDescriptor, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredDescriptor = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.discoveredDescriptor, value);
		}
	}

	public event EventHandler<CBServiceEventArgs> DiscoveredIncludedService
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredIncludedService = (EventHandler<CBServiceEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.discoveredIncludedService, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredIncludedService = (EventHandler<CBServiceEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.discoveredIncludedService, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> DiscoveredService
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredService = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.discoveredService, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.discoveredService = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.discoveredService, value);
		}
	}

	public event EventHandler InvalidatedService
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.invalidatedService = (EventHandler)System.Delegate.Combine(cBPeripheralDelegate.invalidatedService, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.invalidatedService = (EventHandler)System.Delegate.Remove(cBPeripheralDelegate.invalidatedService, value);
		}
	}

	public event EventHandler IsReadyToSendWriteWithoutResponse
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.isReadyToSendWriteWithoutResponse = (EventHandler)System.Delegate.Combine(cBPeripheralDelegate.isReadyToSendWriteWithoutResponse, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.isReadyToSendWriteWithoutResponse = (EventHandler)System.Delegate.Remove(cBPeripheralDelegate.isReadyToSendWriteWithoutResponse, value);
		}
	}

	public event EventHandler<CBPeripheralServicesEventArgs> ModifiedServices
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.modifiedServices = (EventHandler<CBPeripheralServicesEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.modifiedServices, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.modifiedServices = (EventHandler<CBPeripheralServicesEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.modifiedServices, value);
		}
	}

	public event EventHandler<CBRssiEventArgs> RssiRead
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.rssiRead = (EventHandler<CBRssiEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.rssiRead, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.rssiRead = (EventHandler<CBRssiEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.rssiRead, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> RssiUpdated
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.rssiUpdated = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.rssiUpdated, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.rssiUpdated = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.rssiUpdated, value);
		}
	}

	public event EventHandler<CBCharacteristicEventArgs> UpdatedCharacterteristicValue
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedCharacterteristicValue = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.updatedCharacterteristicValue, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedCharacterteristicValue = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.updatedCharacterteristicValue, value);
		}
	}

	public event EventHandler UpdatedName
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedName = (EventHandler)System.Delegate.Combine(cBPeripheralDelegate.updatedName, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedName = (EventHandler)System.Delegate.Remove(cBPeripheralDelegate.updatedName, value);
		}
	}

	public event EventHandler<CBCharacteristicEventArgs> UpdatedNotificationState
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedNotificationState = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.updatedNotificationState, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedNotificationState = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.updatedNotificationState, value);
		}
	}

	public event EventHandler<CBDescriptorEventArgs> UpdatedValue
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedValue = (EventHandler<CBDescriptorEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.updatedValue, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.updatedValue = (EventHandler<CBDescriptorEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.updatedValue, value);
		}
	}

	public event EventHandler<CBCharacteristicEventArgs> WroteCharacteristicValue
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.wroteCharacteristicValue = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.wroteCharacteristicValue, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.wroteCharacteristicValue = (EventHandler<CBCharacteristicEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.wroteCharacteristicValue, value);
		}
	}

	public event EventHandler<CBDescriptorEventArgs> WroteDescriptorValue
	{
		add
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.wroteDescriptorValue = (EventHandler<CBDescriptorEventArgs>)System.Delegate.Combine(cBPeripheralDelegate.wroteDescriptorValue, value);
		}
		remove
		{
			_CBPeripheralDelegate cBPeripheralDelegate = EnsureCBPeripheralDelegate();
			cBPeripheralDelegate.wroteDescriptorValue = (EventHandler<CBDescriptorEventArgs>)System.Delegate.Remove(cBPeripheralDelegate.wroteDescriptorValue, value);
		}
	}

	public void DiscoverServices()
	{
		DiscoverServices((NSArray?)null);
	}

	public void DiscoverServices(CBUUID[] services)
	{
		if (services == null)
		{
			DiscoverServices((NSArray?)null);
		}
		else
		{
			DiscoverServices(NSArray.FromObjects(services));
		}
	}

	public void DiscoverIncludedServices(CBUUID[] includedServiceUUIDs, CBService forService)
	{
		if (includedServiceUUIDs == null)
		{
			DiscoverIncludedServices((NSArray?)null, forService);
		}
		else
		{
			DiscoverIncludedServices(NSArray.FromObjects(includedServiceUUIDs), forService);
		}
	}

	public void DiscoverCharacteristics(CBService forService)
	{
		DiscoverCharacteristics((NSArray?)null, forService);
	}

	public void DiscoverCharacteristics(CBUUID[] charactersticUUIDs, CBService forService)
	{
		if (charactersticUUIDs == null)
		{
			DiscoverCharacteristics((NSArray?)null, forService);
		}
		else
		{
			DiscoverCharacteristics(NSArray.FromObjects(charactersticUUIDs), forService);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBPeripheral(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBPeripheral(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("discoverCharacteristics:forService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void DiscoverCharacteristics(NSArray? characteristicUUIDs, CBService forService)
	{
		if (forService == null)
		{
			throw new ArgumentNullException("forService");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverCharacteristics_ForService_Handle, characteristicUUIDs?.Handle ?? IntPtr.Zero, forService.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverCharacteristics_ForService_Handle, characteristicUUIDs?.Handle ?? IntPtr.Zero, forService.Handle);
		}
	}

	[Export("discoverDescriptorsForCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscoverDescriptors(CBCharacteristic characteristic)
	{
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDiscoverDescriptorsForCharacteristic_Handle, characteristic.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDiscoverDescriptorsForCharacteristic_Handle, characteristic.Handle);
		}
	}

	[Export("discoverIncludedServices:forService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void DiscoverIncludedServices(NSArray? includedServiceUUIDs, CBService forService)
	{
		if (forService == null)
		{
			throw new ArgumentNullException("forService");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDiscoverIncludedServices_ForService_Handle, includedServiceUUIDs?.Handle ?? IntPtr.Zero, forService.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDiscoverIncludedServices_ForService_Handle, includedServiceUUIDs?.Handle ?? IntPtr.Zero, forService.Handle);
		}
	}

	[Export("discoverServices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void DiscoverServices(NSArray? serviceUUIDs)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDiscoverServices_Handle, serviceUUIDs?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDiscoverServices_Handle, serviceUUIDs?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("maximumWriteValueLengthForType:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetMaximumWriteValueLength(CBCharacteristicWriteType type)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_Int64(base.Handle, selMaximumWriteValueLengthForType_Handle, (long)type);
		}
		return Messaging.nuint_objc_msgSendSuper_Int64(base.SuperHandle, selMaximumWriteValueLengthForType_Handle, (long)type);
	}

	[Export("openL2CAPChannel:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenL2CapChannel(ushort psm)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16(base.Handle, selOpenL2CAPChannel_Handle, psm);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16(base.SuperHandle, selOpenL2CAPChannel_Handle, psm);
		}
	}

	[Export("readRSSI")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadRSSI()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReadRSSIHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReadRSSIHandle);
		}
	}

	[Export("readValueForCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadValue(CBCharacteristic characteristic)
	{
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadValueForCharacteristic_Handle, characteristic.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadValueForCharacteristic_Handle, characteristic.Handle);
		}
	}

	[Export("readValueForDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadValue(CBDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadValueForDescriptor_Handle, descriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadValueForDescriptor_Handle, descriptor.Handle);
		}
	}

	[Export("setNotifyValue:forCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNotifyValue(bool enabled, CBCharacteristic characteristic)
	{
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selSetNotifyValue_ForCharacteristic_Handle, enabled, characteristic.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetNotifyValue_ForCharacteristic_Handle, enabled, characteristic.Handle);
		}
	}

	[Export("writeValue:forCharacteristic:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteValue(NSData data, CBCharacteristic characteristic, CBCharacteristicWriteType type)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selWriteValue_ForCharacteristic_Type_Handle, data.Handle, characteristic.Handle, (long)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selWriteValue_ForCharacteristic_Type_Handle, data.Handle, characteristic.Handle, (long)type);
		}
	}

	[Export("writeValue:forDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteValue(NSData data, CBDescriptor descriptor)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteValue_ForDescriptor_Handle, data.Handle, descriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteValue_ForDescriptor_Handle, data.Handle, descriptor.Handle);
		}
	}

	internal virtual _CBPeripheralDelegate CreateInternalEventDelegateType()
	{
		return new _CBPeripheralDelegate();
	}

	internal _CBPeripheralDelegate EnsureCBPeripheralDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_CBPeripheralDelegate cBPeripheralDelegate = Delegate as _CBPeripheralDelegate;
		if (cBPeripheralDelegate == null)
		{
			cBPeripheralDelegate = (_CBPeripheralDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return cBPeripheralDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using AppKit;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBCentralManager", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CBCentralManager : CBManager
{
	[Register]
	internal class _CBCentralManagerDelegate : NSObject, ICBCentralManagerDelegate, INativeObject, IDisposable
	{
		internal EventHandler<CBPeripheralEventArgs>? connectedPeripheral;

		internal EventHandler<CBPeripheralErrorEventArgs>? disconnectedPeripheral;

		internal EventHandler<CBDiscoveredPeripheralEventArgs>? discoveredPeripheral;

		internal EventHandler<CBPeripheralErrorEventArgs>? failedToConnectPeripheral;

		internal EventHandler<CBPeripheralsEventArgs>? retrievedConnectedPeripherals;

		internal EventHandler<CBPeripheralsEventArgs>? retrievedPeripherals;

		internal EventHandler? updatedState;

		internal EventHandler<CBWillRestoreEventArgs>? willRestoreState;

		public _CBCentralManagerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didConnectPeripheral:")]
		public void ConnectedPeripheral(CBCentralManager central, CBPeripheral peripheral)
		{
			EventHandler<CBPeripheralEventArgs> eventHandler = connectedPeripheral;
			if (eventHandler != null)
			{
				CBPeripheralEventArgs e = new CBPeripheralEventArgs(peripheral);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didDisconnectPeripheral:error:")]
		public void DisconnectedPeripheral(CBCentralManager central, CBPeripheral peripheral, NSError error)
		{
			EventHandler<CBPeripheralErrorEventArgs> eventHandler = disconnectedPeripheral;
			if (eventHandler != null)
			{
				CBPeripheralErrorEventArgs e = new CBPeripheralErrorEventArgs(peripheral, error);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didDiscoverPeripheral:advertisementData:RSSI:")]
		public void DiscoveredPeripheral(CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
		{
			EventHandler<CBDiscoveredPeripheralEventArgs> eventHandler = discoveredPeripheral;
			if (eventHandler != null)
			{
				CBDiscoveredPeripheralEventArgs e = new CBDiscoveredPeripheralEventArgs(peripheral, advertisementData, RSSI);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didFailToConnectPeripheral:error:")]
		public void FailedToConnectPeripheral(CBCentralManager central, CBPeripheral peripheral, NSError error)
		{
			EventHandler<CBPeripheralErrorEventArgs> eventHandler = failedToConnectPeripheral;
			if (eventHandler != null)
			{
				CBPeripheralErrorEventArgs e = new CBPeripheralErrorEventArgs(peripheral, error);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didRetrieveConnectedPeripherals:")]
		public void RetrievedConnectedPeripherals(CBCentralManager central, CBPeripheral[] peripherals)
		{
			EventHandler<CBPeripheralsEventArgs> eventHandler = retrievedConnectedPeripherals;
			if (eventHandler != null)
			{
				CBPeripheralsEventArgs e = new CBPeripheralsEventArgs(peripherals);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:didRetrievePeripherals:")]
		public void RetrievedPeripherals(CBCentralManager central, CBPeripheral[] peripherals)
		{
			EventHandler<CBPeripheralsEventArgs> eventHandler = retrievedPeripherals;
			if (eventHandler != null)
			{
				CBPeripheralsEventArgs e = new CBPeripheralsEventArgs(peripherals);
				eventHandler(central, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("centralManagerDidUpdateState:")]
		public void UpdatedState(CBCentralManager central)
		{
			updatedState?.Invoke(central, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("centralManager:willRestoreState:")]
		public void WillRestoreState(CBCentralManager central, NSDictionary dict)
		{
			EventHandler<CBWillRestoreEventArgs> eventHandler = willRestoreState;
			if (eventHandler != null)
			{
				CBWillRestoreEventArgs e = new CBWillRestoreEventArgs(dict);
				eventHandler(central, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPeripheralConnection_ = "cancelPeripheralConnection:";

	private static readonly IntPtr selCancelPeripheralConnection_Handle = Selector.GetHandle("cancelPeripheralConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectPeripheral_Options_ = "connectPeripheral:options:";

	private static readonly IntPtr selConnectPeripheral_Options_Handle = Selector.GetHandle("connectPeripheral:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDelegate_Queue_ = "initWithDelegate:queue:";

	private static readonly IntPtr selInitWithDelegate_Queue_Handle = Selector.GetHandle("initWithDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDelegate_Queue_Options_ = "initWithDelegate:queue:options:";

	private static readonly IntPtr selInitWithDelegate_Queue_Options_Handle = Selector.GetHandle("initWithDelegate:queue:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsScanning = "isScanning";

	private static readonly IntPtr selIsScanningHandle = Selector.GetHandle("isScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetrieveConnectedPeripherals = "retrieveConnectedPeripherals";

	private static readonly IntPtr selRetrieveConnectedPeripheralsHandle = Selector.GetHandle("retrieveConnectedPeripherals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetrieveConnectedPeripheralsWithServices_ = "retrieveConnectedPeripheralsWithServices:";

	private static readonly IntPtr selRetrieveConnectedPeripheralsWithServices_Handle = Selector.GetHandle("retrieveConnectedPeripheralsWithServices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetrievePeripherals_ = "retrievePeripherals:";

	private static readonly IntPtr selRetrievePeripherals_Handle = Selector.GetHandle("retrievePeripherals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetrievePeripheralsWithIdentifiers_ = "retrievePeripheralsWithIdentifiers:";

	private static readonly IntPtr selRetrievePeripheralsWithIdentifiers_Handle = Selector.GetHandle("retrievePeripheralsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForPeripheralsWithServices_Options_ = "scanForPeripheralsWithServices:options:";

	private static readonly IntPtr selScanForPeripheralsWithServices_Options_Handle = Selector.GetHandle("scanForPeripheralsWithServices:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopScan = "stopScan";

	private static readonly IntPtr selStopScanHandle = Selector.GetHandle("stopScan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBCentralManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionNotifyOnConnectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionNotifyOnDisconnectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionNotifyOnNotificationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionRestoreIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionShowPowerAlertKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionStartDelayKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RestoredStatePeripheralsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RestoredStateScanOptionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RestoredStateScanServicesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScanOptionAllowDuplicatesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScanOptionSolicitedServiceUUIDsKey;

	public new virtual CBCentralManagerState State => (CBCentralManagerState)base.State;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ICBCentralManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as ICBCentralManagerDelegate;
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
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool IsScanning
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("isScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsScanningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsScanningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
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

	[Field("CBConnectPeripheralOptionNotifyOnConnectionKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString OptionNotifyOnConnectionKey
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionNotifyOnConnectionKey == null)
			{
				_OptionNotifyOnConnectionKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnConnectionKey");
			}
			return _OptionNotifyOnConnectionKey;
		}
	}

	[Field("CBConnectPeripheralOptionNotifyOnDisconnectionKey", "CoreBluetooth")]
	public static NSString OptionNotifyOnDisconnectionKey
	{
		get
		{
			if (_OptionNotifyOnDisconnectionKey == null)
			{
				_OptionNotifyOnDisconnectionKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnDisconnectionKey");
			}
			return _OptionNotifyOnDisconnectionKey;
		}
	}

	[Field("CBConnectPeripheralOptionNotifyOnNotificationKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString OptionNotifyOnNotificationKey
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionNotifyOnNotificationKey == null)
			{
				_OptionNotifyOnNotificationKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnNotificationKey");
			}
			return _OptionNotifyOnNotificationKey;
		}
	}

	[Field("CBCentralManagerOptionRestoreIdentifierKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString OptionRestoreIdentifierKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionRestoreIdentifierKey == null)
			{
				_OptionRestoreIdentifierKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerOptionRestoreIdentifierKey");
			}
			return _OptionRestoreIdentifierKey;
		}
	}

	[Field("CBCentralManagerOptionShowPowerAlertKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OptionShowPowerAlertKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionShowPowerAlertKey == null)
			{
				_OptionShowPowerAlertKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerOptionShowPowerAlertKey");
			}
			return _OptionShowPowerAlertKey;
		}
	}

	[Field("CBConnectPeripheralOptionStartDelayKey", "CoreBluetooth")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 2, PlatformArchitecture.All, null)]
	public static NSString OptionStartDelayKey
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionStartDelayKey == null)
			{
				_OptionStartDelayKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionStartDelayKey");
			}
			return _OptionStartDelayKey;
		}
	}

	[Field("CBCentralManagerRestoredStatePeripheralsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString RestoredStatePeripheralsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_RestoredStatePeripheralsKey == null)
			{
				_RestoredStatePeripheralsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStatePeripheralsKey");
			}
			return _RestoredStatePeripheralsKey;
		}
	}

	[Field("CBCentralManagerRestoredStateScanOptionsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString RestoredStateScanOptionsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_RestoredStateScanOptionsKey == null)
			{
				_RestoredStateScanOptionsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanOptionsKey");
			}
			return _RestoredStateScanOptionsKey;
		}
	}

	[Field("CBCentralManagerRestoredStateScanServicesKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString RestoredStateScanServicesKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_RestoredStateScanServicesKey == null)
			{
				_RestoredStateScanServicesKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanServicesKey");
			}
			return _RestoredStateScanServicesKey;
		}
	}

	[Field("CBCentralManagerScanOptionAllowDuplicatesKey", "CoreBluetooth")]
	public static NSString ScanOptionAllowDuplicatesKey
	{
		get
		{
			if (_ScanOptionAllowDuplicatesKey == null)
			{
				_ScanOptionAllowDuplicatesKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerScanOptionAllowDuplicatesKey");
			}
			return _ScanOptionAllowDuplicatesKey;
		}
	}

	[Field("CBCentralManagerScanOptionSolicitedServiceUUIDsKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ScanOptionSolicitedServiceUUIDsKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ScanOptionSolicitedServiceUUIDsKey == null)
			{
				_ScanOptionSolicitedServiceUUIDsKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBCentralManagerScanOptionSolicitedServiceUUIDsKey");
			}
			return _ScanOptionSolicitedServiceUUIDsKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_CBCentralManagerDelegate);

	public event EventHandler<CBPeripheralEventArgs> ConnectedPeripheral
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.connectedPeripheral = (EventHandler<CBPeripheralEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.connectedPeripheral, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.connectedPeripheral = (EventHandler<CBPeripheralEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.connectedPeripheral, value);
		}
	}

	public event EventHandler<CBPeripheralErrorEventArgs> DisconnectedPeripheral
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.disconnectedPeripheral = (EventHandler<CBPeripheralErrorEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.disconnectedPeripheral, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.disconnectedPeripheral = (EventHandler<CBPeripheralErrorEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.disconnectedPeripheral, value);
		}
	}

	public event EventHandler<CBDiscoveredPeripheralEventArgs> DiscoveredPeripheral
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.discoveredPeripheral = (EventHandler<CBDiscoveredPeripheralEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.discoveredPeripheral, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.discoveredPeripheral = (EventHandler<CBDiscoveredPeripheralEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.discoveredPeripheral, value);
		}
	}

	public event EventHandler<CBPeripheralErrorEventArgs> FailedToConnectPeripheral
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.failedToConnectPeripheral = (EventHandler<CBPeripheralErrorEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.failedToConnectPeripheral, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.failedToConnectPeripheral = (EventHandler<CBPeripheralErrorEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.failedToConnectPeripheral, value);
		}
	}

	public event EventHandler<CBPeripheralsEventArgs> RetrievedConnectedPeripherals
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.retrievedConnectedPeripherals = (EventHandler<CBPeripheralsEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.retrievedConnectedPeripherals, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.retrievedConnectedPeripherals = (EventHandler<CBPeripheralsEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.retrievedConnectedPeripherals, value);
		}
	}

	public event EventHandler<CBPeripheralsEventArgs> RetrievedPeripherals
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.retrievedPeripherals = (EventHandler<CBPeripheralsEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.retrievedPeripherals, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.retrievedPeripherals = (EventHandler<CBPeripheralsEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.retrievedPeripherals, value);
		}
	}

	public event EventHandler UpdatedState
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.updatedState = (EventHandler)System.Delegate.Combine(cBCentralManagerDelegate.updatedState, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.updatedState = (EventHandler)System.Delegate.Remove(cBCentralManagerDelegate.updatedState, value);
		}
	}

	public event EventHandler<CBWillRestoreEventArgs> WillRestoreState
	{
		add
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.willRestoreState = (EventHandler<CBWillRestoreEventArgs>)System.Delegate.Combine(cBCentralManagerDelegate.willRestoreState, value);
		}
		remove
		{
			_CBCentralManagerDelegate cBCentralManagerDelegate = EnsureCBCentralManagerDelegate();
			cBCentralManagerDelegate.willRestoreState = (EventHandler<CBWillRestoreEventArgs>)System.Delegate.Remove(cBCentralManagerDelegate.willRestoreState, value);
		}
	}

	public CBCentralManager()
		: this(new _CBCentralManagerDelegate(), null)
	{
	}

	public CBCentralManager(DispatchQueue dispatchQueue)
		: this(new _CBCentralManagerDelegate(), dispatchQueue)
	{
	}

	public void ConnectPeripheral(CBPeripheral peripheral, PeripheralConnectionOptions options = null)
	{
		ConnectPeripheral(peripheral, options?.Dictionary);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'RetrievePeripheralsWithIdentifiers' instead.")]
	public void RetrievePeripherals(CBUUID[] peripheralUuids)
	{
		if (peripheralUuids == null)
		{
			throw new ArgumentNullException("peripheralUuids");
		}
		IntPtr[] array = new IntPtr[peripheralUuids.Length];
		for (int i = 0; i < peripheralUuids.Length; i++)
		{
			using NSString nSString = new NSString(peripheralUuids[i].ToString(fullUuid: true));
			array[i] = CFUUID.CFUUIDCreateFromString(IntPtr.Zero, nSString.Handle);
		}
		using (NSArray peripheralUUIDs = NSArray.FromIntPtrs(array))
		{
			RetrievePeripherals(peripheralUUIDs);
		}
		IntPtr[] array2 = array;
		foreach (IntPtr obj in array2)
		{
			CFObject.CFRelease(obj);
		}
	}

	public void RetrievePeripherals(CBUUID peripheralUuid)
	{
		RetrievePeripherals(new CBUUID[1] { peripheralUuid });
	}

	public void ScanForPeripherals(CBUUID[] peripheralUuids, NSDictionary options)
	{
		if (peripheralUuids == null)
		{
			ScanForPeripherals((NSArray?)null, options);
		}
		else
		{
			ScanForPeripherals(NSArray.FromObjects(peripheralUuids), options);
		}
	}

	public void ScanForPeripherals(CBUUID[] peripheralUuids, PeripheralScanningOptions options = null)
	{
		ScanForPeripherals(peripheralUuids, options?.Dictionary);
	}

	public void ScanForPeripherals(CBUUID[] peripheralUuids)
	{
		ScanForPeripherals(peripheralUuids, (NSDictionary)null);
	}

	public void ScanForPeripherals(CBUUID serviceUuid, NSDictionary options)
	{
		ScanForPeripherals(new CBUUID[1] { serviceUuid }, options);
	}

	public void ScanForPeripherals(CBUUID serviceUuid)
	{
		ScanForPeripherals(new CBUUID[1] { serviceUuid }, (NSDictionary)null);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBCentralManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBCentralManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBCentralManager(ICBCentralManagerDelegate? centralDelegate, DispatchQueue? queue)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDelegate_Queue_Handle, centralDelegate?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithDelegate:queue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDelegate_Queue_Handle, centralDelegate?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithDelegate:queue:");
		}
		NSObject weakDelegate = WeakDelegate;
	}

	[Export("initWithDelegate:queue:options:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBCentralManager(ICBCentralManagerDelegate? centralDelegate, DispatchQueue? queue, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDelegate_Queue_Options_Handle, centralDelegate?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, options?.Handle ?? IntPtr.Zero), "initWithDelegate:queue:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDelegate_Queue_Options_Handle, centralDelegate?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, options?.Handle ?? IntPtr.Zero), "initWithDelegate:queue:options:");
		}
		NSObject weakDelegate = WeakDelegate;
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBCentralManager(ICBCentralManagerDelegate? centralDelegate, DispatchQueue? queue, CBCentralInitOptions options)
		: this(centralDelegate, queue, options.GetDictionary())
	{
	}

	[Export("cancelPeripheralConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelPeripheralConnection(CBPeripheral peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelPeripheralConnection_Handle, peripheral.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelPeripheralConnection_Handle, peripheral.Handle);
		}
	}

	[Export("connectPeripheral:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectPeripheral(CBPeripheral peripheral, NSDictionary? options)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selConnectPeripheral_Options_Handle, peripheral.Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConnectPeripheral_Options_Handle, peripheral.Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ConnectPeripheral(CBPeripheral peripheral, CBConnectPeripheralOptions? options)
	{
		ConnectPeripheral(peripheral, options.GetDictionary());
	}

	[Export("retrieveConnectedPeripherals")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, "Use 'RetrievePeripheralsWithIdentifiers' instead.")]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.All, "Use 'RetrievePeripheralsWithIdentifiers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RetrieveConnectedPeripherals()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRetrieveConnectedPeripheralsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRetrieveConnectedPeripheralsHandle);
		}
	}

	[Export("retrieveConnectedPeripheralsWithServices:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBPeripheral[] RetrieveConnectedPeripherals(params CBUUID[] serviceUUIDs)
	{
		if (serviceUUIDs == null)
		{
			throw new ArgumentNullException("serviceUUIDs");
		}
		NSArray nSArray = NSArray.FromNSObjects(serviceUUIDs);
		CBPeripheral[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CBPeripheral>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRetrieveConnectedPeripheralsWithServices_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<CBPeripheral>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRetrieveConnectedPeripheralsWithServices_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("retrievePeripherals:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void RetrievePeripherals(NSArray peripheralUUIDs)
	{
		if (peripheralUUIDs == null)
		{
			throw new ArgumentNullException("peripheralUUIDs");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRetrievePeripherals_Handle, peripheralUUIDs.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRetrievePeripherals_Handle, peripheralUUIDs.Handle);
		}
	}

	[Export("retrievePeripheralsWithIdentifiers:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBPeripheral[] RetrievePeripheralsWithIdentifiers(params NSUuid[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		CBPeripheral[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CBPeripheral>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRetrievePeripheralsWithIdentifiers_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<CBPeripheral>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRetrievePeripheralsWithIdentifiers_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("scanForPeripheralsWithServices:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void ScanForPeripherals(NSArray? serviceUUIDs, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScanForPeripheralsWithServices_Options_Handle, serviceUUIDs?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScanForPeripheralsWithServices_Options_Handle, serviceUUIDs?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("stopScan")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopScan()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopScanHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopScanHandle);
		}
	}

	internal virtual _CBCentralManagerDelegate CreateInternalEventDelegateType()
	{
		return new _CBCentralManagerDelegate();
	}

	internal _CBCentralManagerDelegate EnsureCBCentralManagerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_CBCentralManagerDelegate cBCentralManagerDelegate = Delegate as _CBCentralManagerDelegate;
		if (cBCentralManagerDelegate == null)
		{
			cBCentralManagerDelegate = (_CBCentralManagerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return cBCentralManagerDelegate;
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

using System;
using System.ComponentModel;
using AppKit;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBPeripheralManager", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CBPeripheralManager : CBManager
{
	[Register]
	internal class _CBPeripheralManagerDelegate : NSObject, ICBPeripheralManagerDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSErrorEventArgs>? advertisingStarted;

		internal EventHandler<CBPeripheralManagerSubscriptionEventArgs>? characteristicSubscribed;

		internal EventHandler<CBPeripheralManagerSubscriptionEventArgs>? characteristicUnsubscribed;

		internal EventHandler<CBPeripheralManagerOpenL2CapChannelEventArgs>? didOpenL2CapChannel;

		internal EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>? didPublishL2CapChannel;

		internal EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>? didUnpublishL2CapChannel;

		internal EventHandler<CBATTRequestEventArgs>? readRequestReceived;

		internal EventHandler? readyToUpdateSubscribers;

		internal EventHandler<CBPeripheralManagerServiceEventArgs>? serviceAdded;

		internal EventHandler? stateUpdated;

		internal EventHandler<CBWillRestoreEventArgs>? willRestoreState;

		internal EventHandler<CBATTRequestsEventArgs>? writeRequestsReceived;

		public _CBPeripheralManagerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManagerDidStartAdvertising:error:")]
		public void AdvertisingStarted(CBPeripheralManager peripheral, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = advertisingStarted;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:central:didSubscribeToCharacteristic:")]
		public void CharacteristicSubscribed(CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			EventHandler<CBPeripheralManagerSubscriptionEventArgs> eventHandler = characteristicSubscribed;
			if (eventHandler != null)
			{
				CBPeripheralManagerSubscriptionEventArgs e = new CBPeripheralManagerSubscriptionEventArgs(central, characteristic);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:central:didUnsubscribeFromCharacteristic:")]
		public void CharacteristicUnsubscribed(CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic)
		{
			EventHandler<CBPeripheralManagerSubscriptionEventArgs> eventHandler = characteristicUnsubscribed;
			if (eventHandler != null)
			{
				CBPeripheralManagerSubscriptionEventArgs e = new CBPeripheralManagerSubscriptionEventArgs(central, characteristic);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didOpenL2CAPChannel:error:")]
		public void DidOpenL2CapChannel(CBPeripheralManager peripheral, CBL2CapChannel? channel, NSError? error)
		{
			EventHandler<CBPeripheralManagerOpenL2CapChannelEventArgs> eventHandler = didOpenL2CapChannel;
			if (eventHandler != null)
			{
				CBPeripheralManagerOpenL2CapChannelEventArgs e = new CBPeripheralManagerOpenL2CapChannelEventArgs(channel, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didPublishL2CAPChannel:error:")]
		public void DidPublishL2CapChannel(CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs> eventHandler = didPublishL2CapChannel;
			if (eventHandler != null)
			{
				CBPeripheralManagerL2CapChannelOperationEventArgs e = new CBPeripheralManagerL2CapChannelOperationEventArgs(psm, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didUnpublishL2CAPChannel:error:")]
		public void DidUnpublishL2CapChannel(CBPeripheralManager peripheral, ushort psm, NSError? error)
		{
			EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs> eventHandler = didUnpublishL2CapChannel;
			if (eventHandler != null)
			{
				CBPeripheralManagerL2CapChannelOperationEventArgs e = new CBPeripheralManagerL2CapChannelOperationEventArgs(psm, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didReceiveReadRequest:")]
		public void ReadRequestReceived(CBPeripheralManager peripheral, CBATTRequest request)
		{
			EventHandler<CBATTRequestEventArgs> eventHandler = readRequestReceived;
			if (eventHandler != null)
			{
				CBATTRequestEventArgs e = new CBATTRequestEventArgs(request);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManagerIsReadyToUpdateSubscribers:")]
		public void ReadyToUpdateSubscribers(CBPeripheralManager peripheral)
		{
			readyToUpdateSubscribers?.Invoke(peripheral, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didAddService:error:")]
		public void ServiceAdded(CBPeripheralManager peripheral, CBService service, NSError error)
		{
			EventHandler<CBPeripheralManagerServiceEventArgs> eventHandler = serviceAdded;
			if (eventHandler != null)
			{
				CBPeripheralManagerServiceEventArgs e = new CBPeripheralManagerServiceEventArgs(service, error);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManagerDidUpdateState:")]
		public void StateUpdated(CBPeripheralManager peripheral)
		{
			stateUpdated?.Invoke(peripheral, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:willRestoreState:")]
		public void WillRestoreState(CBPeripheralManager peripheral, NSDictionary dict)
		{
			EventHandler<CBWillRestoreEventArgs> eventHandler = willRestoreState;
			if (eventHandler != null)
			{
				CBWillRestoreEventArgs e = new CBWillRestoreEventArgs(dict);
				eventHandler(peripheral, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("peripheralManager:didReceiveWriteRequests:")]
		public void WriteRequestsReceived(CBPeripheralManager peripheral, CBATTRequest[] requests)
		{
			EventHandler<CBATTRequestsEventArgs> eventHandler = writeRequestsReceived;
			if (eventHandler != null)
			{
				CBATTRequestsEventArgs e = new CBATTRequestsEventArgs(requests);
				eventHandler(peripheral, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddService_ = "addService:";

	private static readonly IntPtr selAddService_Handle = Selector.GetHandle("addService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDelegate_Queue_ = "initWithDelegate:queue:";

	private static readonly IntPtr selInitWithDelegate_Queue_Handle = Selector.GetHandle("initWithDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDelegate_Queue_Options_ = "initWithDelegate:queue:options:";

	private static readonly IntPtr selInitWithDelegate_Queue_Options_Handle = Selector.GetHandle("initWithDelegate:queue:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdvertising = "isAdvertising";

	private static readonly IntPtr selIsAdvertisingHandle = Selector.GetHandle("isAdvertising");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublishL2CAPChannelWithEncryption_ = "publishL2CAPChannelWithEncryption:";

	private static readonly IntPtr selPublishL2CAPChannelWithEncryption_Handle = Selector.GetHandle("publishL2CAPChannelWithEncryption:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllServices = "removeAllServices";

	private static readonly IntPtr selRemoveAllServicesHandle = Selector.GetHandle("removeAllServices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveService_ = "removeService:";

	private static readonly IntPtr selRemoveService_Handle = Selector.GetHandle("removeService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRespondToRequest_WithResult_ = "respondToRequest:withResult:";

	private static readonly IntPtr selRespondToRequest_WithResult_Handle = Selector.GetHandle("respondToRequest:withResult:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesiredConnectionLatency_ForCentral_ = "setDesiredConnectionLatency:forCentral:";

	private static readonly IntPtr selSetDesiredConnectionLatency_ForCentral_Handle = Selector.GetHandle("setDesiredConnectionLatency:forCentral:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAdvertising_ = "startAdvertising:";

	private static readonly IntPtr selStartAdvertising_Handle = Selector.GetHandle("startAdvertising:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopAdvertising = "stopAdvertising";

	private static readonly IntPtr selStopAdvertisingHandle = Selector.GetHandle("stopAdvertising");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnpublishL2CAPChannel_ = "unpublishL2CAPChannel:";

	private static readonly IntPtr selUnpublishL2CAPChannel_Handle = Selector.GetHandle("unpublishL2CAPChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateValue_ForCharacteristic_OnSubscribedCentrals_ = "updateValue:forCharacteristic:onSubscribedCentrals:";

	private static readonly IntPtr selUpdateValue_ForCharacteristic_OnSubscribedCentrals_Handle = Selector.GetHandle("updateValue:forCharacteristic:onSubscribedCentrals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBPeripheralManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionRestoreIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionShowPowerAlertKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RestoredStateAdvertisementDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RestoredStateServicesKey;

	public new virtual CBPeripheralManagerState State => (CBPeripheralManagerState)base.State;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Advertising
	{
		[Export("isAdvertising")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdvertisingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdvertisingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static CBPeripheralManagerAuthorizationStatus AuthorizationStatus
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'CBManager.Authorization' instead.")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("authorizationStatus")]
		get
		{
			return (CBPeripheralManagerAuthorizationStatus)Messaging.Int64_objc_msgSend(class_ptr, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ICBPeripheralManagerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as ICBPeripheralManagerDelegate;
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

	[Field("CBPeripheralManagerOptionRestoreIdentifierKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString OptionRestoreIdentifierKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionRestoreIdentifierKey == null)
			{
				_OptionRestoreIdentifierKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBPeripheralManagerOptionRestoreIdentifierKey");
			}
			return _OptionRestoreIdentifierKey;
		}
	}

	[Field("CBPeripheralManagerOptionShowPowerAlertKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString OptionShowPowerAlertKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionShowPowerAlertKey == null)
			{
				_OptionShowPowerAlertKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBPeripheralManagerOptionShowPowerAlertKey");
			}
			return _OptionShowPowerAlertKey;
		}
	}

	[Field("CBPeripheralManagerRestoredStateAdvertisementDataKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString RestoredStateAdvertisementDataKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RestoredStateAdvertisementDataKey == null)
			{
				_RestoredStateAdvertisementDataKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBPeripheralManagerRestoredStateAdvertisementDataKey");
			}
			return _RestoredStateAdvertisementDataKey;
		}
	}

	[Field("CBPeripheralManagerRestoredStateServicesKey", "CoreBluetooth")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString RestoredStateServicesKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RestoredStateServicesKey == null)
			{
				_RestoredStateServicesKey = Dlfcn.GetStringConstant(Libraries.CoreBluetooth.Handle, "CBPeripheralManagerRestoredStateServicesKey");
			}
			return _RestoredStateServicesKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_CBPeripheralManagerDelegate);

	public event EventHandler<NSErrorEventArgs> AdvertisingStarted
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.advertisingStarted = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.advertisingStarted, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.advertisingStarted = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.advertisingStarted, value);
		}
	}

	public event EventHandler<CBPeripheralManagerSubscriptionEventArgs> CharacteristicSubscribed
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.characteristicSubscribed = (EventHandler<CBPeripheralManagerSubscriptionEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.characteristicSubscribed, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.characteristicSubscribed = (EventHandler<CBPeripheralManagerSubscriptionEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.characteristicSubscribed, value);
		}
	}

	public event EventHandler<CBPeripheralManagerSubscriptionEventArgs> CharacteristicUnsubscribed
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.characteristicUnsubscribed = (EventHandler<CBPeripheralManagerSubscriptionEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.characteristicUnsubscribed, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.characteristicUnsubscribed = (EventHandler<CBPeripheralManagerSubscriptionEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.characteristicUnsubscribed, value);
		}
	}

	public event EventHandler<CBPeripheralManagerOpenL2CapChannelEventArgs> DidOpenL2CapChannel
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didOpenL2CapChannel = (EventHandler<CBPeripheralManagerOpenL2CapChannelEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.didOpenL2CapChannel, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didOpenL2CapChannel = (EventHandler<CBPeripheralManagerOpenL2CapChannelEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.didOpenL2CapChannel, value);
		}
	}

	public event EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs> DidPublishL2CapChannel
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didPublishL2CapChannel = (EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.didPublishL2CapChannel, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didPublishL2CapChannel = (EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.didPublishL2CapChannel, value);
		}
	}

	public event EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs> DidUnpublishL2CapChannel
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didUnpublishL2CapChannel = (EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.didUnpublishL2CapChannel, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.didUnpublishL2CapChannel = (EventHandler<CBPeripheralManagerL2CapChannelOperationEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.didUnpublishL2CapChannel, value);
		}
	}

	public event EventHandler<CBATTRequestEventArgs> ReadRequestReceived
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.readRequestReceived = (EventHandler<CBATTRequestEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.readRequestReceived, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.readRequestReceived = (EventHandler<CBATTRequestEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.readRequestReceived, value);
		}
	}

	public event EventHandler ReadyToUpdateSubscribers
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.readyToUpdateSubscribers = (EventHandler)System.Delegate.Combine(cBPeripheralManagerDelegate.readyToUpdateSubscribers, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.readyToUpdateSubscribers = (EventHandler)System.Delegate.Remove(cBPeripheralManagerDelegate.readyToUpdateSubscribers, value);
		}
	}

	public event EventHandler<CBPeripheralManagerServiceEventArgs> ServiceAdded
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.serviceAdded = (EventHandler<CBPeripheralManagerServiceEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.serviceAdded, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.serviceAdded = (EventHandler<CBPeripheralManagerServiceEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.serviceAdded, value);
		}
	}

	public event EventHandler StateUpdated
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.stateUpdated = (EventHandler)System.Delegate.Combine(cBPeripheralManagerDelegate.stateUpdated, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.stateUpdated = (EventHandler)System.Delegate.Remove(cBPeripheralManagerDelegate.stateUpdated, value);
		}
	}

	public event EventHandler<CBWillRestoreEventArgs> WillRestoreState
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.willRestoreState = (EventHandler<CBWillRestoreEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.willRestoreState, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.willRestoreState = (EventHandler<CBWillRestoreEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.willRestoreState, value);
		}
	}

	public event EventHandler<CBATTRequestsEventArgs> WriteRequestsReceived
	{
		add
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.writeRequestsReceived = (EventHandler<CBATTRequestsEventArgs>)System.Delegate.Combine(cBPeripheralManagerDelegate.writeRequestsReceived, value);
		}
		remove
		{
			_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = EnsureCBPeripheralManagerDelegate();
			cBPeripheralManagerDelegate.writeRequestsReceived = (EventHandler<CBATTRequestsEventArgs>)System.Delegate.Remove(cBPeripheralManagerDelegate.writeRequestsReceived, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBPeripheralManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBPeripheralManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBPeripheralManager()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithDelegate:queue:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBPeripheralManager(ICBPeripheralManagerDelegate peripheralDelegate, DispatchQueue? queue)
		: base(NSObjectFlag.Empty)
	{
		if (peripheralDelegate != null)
		{
			if (!(peripheralDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + peripheralDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDelegate_Queue_Handle, peripheralDelegate.Handle, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithDelegate:queue:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDelegate_Queue_Handle, peripheralDelegate.Handle, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithDelegate:queue:");
			}
			NSObject weakDelegate = WeakDelegate;
			return;
		}
		throw new ArgumentNullException("peripheralDelegate");
	}

	[Export("initWithDelegate:queue:options:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBPeripheralManager(ICBPeripheralManagerDelegate peripheralDelegate, DispatchQueue? queue, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (peripheralDelegate != null)
		{
			if (!(peripheralDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + peripheralDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDelegate_Queue_Options_Handle, peripheralDelegate.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, options?.Handle ?? IntPtr.Zero), "initWithDelegate:queue:options:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDelegate_Queue_Options_Handle, peripheralDelegate.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, options?.Handle ?? IntPtr.Zero), "initWithDelegate:queue:options:");
			}
			NSObject weakDelegate = WeakDelegate;
			return;
		}
		throw new ArgumentNullException("peripheralDelegate");
	}

	[Export("addService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddService(CBMutableService service)
	{
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddService_Handle, service.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddService_Handle, service.Handle);
		}
	}

	[Export("publishL2CAPChannelWithEncryption:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PublishL2CapChannel(bool encryptionRequired)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selPublishL2CAPChannelWithEncryption_Handle, encryptionRequired);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selPublishL2CAPChannelWithEncryption_Handle, encryptionRequired);
		}
	}

	[Export("removeAllServices")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllServices()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllServicesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllServicesHandle);
		}
	}

	[Export("removeService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveService(CBMutableService service)
	{
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveService_Handle, service.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveService_Handle, service.Handle);
		}
	}

	[Export("respondToRequest:withResult:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RespondToRequest(CBATTRequest request, CBATTError result)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selRespondToRequest_WithResult_Handle, request.Handle, (long)result);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selRespondToRequest_WithResult_Handle, request.Handle, (long)result);
		}
	}

	[Export("setDesiredConnectionLatency:forCentral:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDesiredConnectionLatency(CBPeripheralManagerConnectionLatency latency, CBCentral connectedCentral)
	{
		if (connectedCentral == null)
		{
			throw new ArgumentNullException("connectedCentral");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selSetDesiredConnectionLatency_ForCentral_Handle, (long)latency, connectedCentral.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selSetDesiredConnectionLatency_ForCentral_Handle, (long)latency, connectedCentral.Handle);
		}
	}

	[Export("startAdvertising:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartAdvertising(NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartAdvertising_Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartAdvertising_Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StartAdvertising(StartAdvertisingOptions? options)
	{
		StartAdvertising(options.GetDictionary());
	}

	[Export("stopAdvertising")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopAdvertising()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAdvertisingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAdvertisingHandle);
		}
	}

	[Export("unpublishL2CAPChannel:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnpublishL2CapChannel(ushort psm)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16(base.Handle, selUnpublishL2CAPChannel_Handle, psm);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16(base.SuperHandle, selUnpublishL2CAPChannel_Handle, psm);
		}
	}

	[Export("updateValue:forCharacteristic:onSubscribedCentrals:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateValue(NSData value, CBMutableCharacteristic characteristic, CBCentral[]? subscribedCentrals)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (characteristic == null)
		{
			throw new ArgumentNullException("characteristic");
		}
		NSArray nSArray = ((subscribedCentrals == null) ? null : NSArray.FromNSObjects(subscribedCentrals));
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selUpdateValue_ForCharacteristic_OnSubscribedCentrals_Handle, value.Handle, characteristic.Handle, nSArray?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selUpdateValue_ForCharacteristic_OnSubscribedCentrals_Handle, value.Handle, characteristic.Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}

	internal virtual _CBPeripheralManagerDelegate CreateInternalEventDelegateType()
	{
		return new _CBPeripheralManagerDelegate();
	}

	internal _CBPeripheralManagerDelegate EnsureCBPeripheralManagerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_CBPeripheralManagerDelegate cBPeripheralManagerDelegate = Delegate as _CBPeripheralManagerDelegate;
		if (cBPeripheralManagerDelegate == null)
		{
			cBPeripheralManagerDelegate = (_CBPeripheralManagerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return cBPeripheralManagerDelegate;
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

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

[Register("EAAccessoryManager", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class EAAccessoryManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidConnect(EventHandler<EAAccessoryEventArgs> handler)
		{
			EventHandler<EAAccessoryEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidConnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new EAAccessoryEventArgs(notification));
			});
		}

		public static NSObject ObserveDidConnect(NSObject objectToObserve, EventHandler<EAAccessoryEventArgs> handler)
		{
			EventHandler<EAAccessoryEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidConnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new EAAccessoryEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidDisconnect(EventHandler<EAAccessoryEventArgs> handler)
		{
			EventHandler<EAAccessoryEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDisconnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new EAAccessoryEventArgs(notification));
			});
		}

		public static NSObject ObserveDidDisconnect(NSObject objectToObserve, EventHandler<EAAccessoryEventArgs> handler)
		{
			EventHandler<EAAccessoryEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDisconnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new EAAccessoryEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectedAccessories = "connectedAccessories";

	private static readonly IntPtr selConnectedAccessoriesHandle = Selector.GetHandle("connectedAccessories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterForLocalNotifications = "registerForLocalNotifications";

	private static readonly IntPtr selRegisterForLocalNotificationsHandle = Selector.GetHandle("registerForLocalNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedAccessoryManager = "sharedAccessoryManager";

	private static readonly IntPtr selSharedAccessoryManagerHandle = Selector.GetHandle("sharedAccessoryManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterForLocalNotifications = "unregisterForLocalNotifications";

	private static readonly IntPtr selUnregisterForLocalNotificationsHandle = Selector.GetHandle("unregisterForLocalNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EAAccessoryManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidConnectNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidDisconnectNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EAAccessory[] ConnectedAccessories
	{
		[Export("connectedAccessories")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<EAAccessory>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectedAccessoriesHandle));
			}
			return NSArray.ArrayFromHandle<EAAccessory>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectedAccessoriesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EAAccessoryManager SharedAccessoryManager
	{
		[Export("sharedAccessoryManager")]
		get
		{
			return Runtime.GetNSObject<EAAccessoryManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedAccessoryManagerHandle));
		}
	}

	[Field("EAAccessoryDidConnectNotification", "ExternalAccessory")]
	[Advice("Use EAAccessoryManager.Notifications.ObserveDidConnect helper method instead.")]
	public static NSString DidConnectNotification
	{
		get
		{
			if (_DidConnectNotification == null)
			{
				_DidConnectNotification = Dlfcn.GetStringConstant(Libraries.ExternalAccessory.Handle, "EAAccessoryDidConnectNotification");
			}
			return _DidConnectNotification;
		}
	}

	[Field("EAAccessoryDidDisconnectNotification", "ExternalAccessory")]
	[Advice("Use EAAccessoryManager.Notifications.ObserveDidDisconnect helper method instead.")]
	public static NSString DidDisconnectNotification
	{
		get
		{
			if (_DidDisconnectNotification == null)
			{
				_DidDisconnectNotification = Dlfcn.GetStringConstant(Libraries.ExternalAccessory.Handle, "EAAccessoryDidDisconnectNotification");
			}
			return _DidDisconnectNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EAAccessoryManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EAAccessoryManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("registerForLocalNotifications")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterForLocalNotifications()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRegisterForLocalNotificationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRegisterForLocalNotificationsHandle);
		}
	}

	[Export("unregisterForLocalNotifications")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterForLocalNotifications()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnregisterForLocalNotificationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnregisterForLocalNotificationsHandle);
		}
	}
}

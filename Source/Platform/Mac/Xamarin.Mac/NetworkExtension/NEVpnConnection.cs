using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEVPNConnection", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NEVpnConnection : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveStatusDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StatusDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveStatusDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(StatusDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectedDate = "connectedDate";

	private static readonly IntPtr selConnectedDateHandle = Selector.GetHandle("connectedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManager = "manager";

	private static readonly IntPtr selManagerHandle = Selector.GetHandle("manager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartVPNTunnelAndReturnError_ = "startVPNTunnelAndReturnError:";

	private static readonly IntPtr selStartVPNTunnelAndReturnError_Handle = Selector.GetHandle("startVPNTunnelAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartVPNTunnelWithOptions_AndReturnError_ = "startVPNTunnelWithOptions:andReturnError:";

	private static readonly IntPtr selStartVPNTunnelWithOptions_AndReturnError_Handle = Selector.GetHandle("startVPNTunnelWithOptions:andReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopVPNTunnel = "stopVPNTunnel";

	private static readonly IntPtr selStopVPNTunnelHandle = Selector.GetHandle("stopVPNTunnel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEVPNConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StatusDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDate? ConnectedDate
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("connectedDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectedDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NEVpnManager Manager
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("manager")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selManagerHandle));
			}
			return Runtime.GetNSObject<NEVpnManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (NEVpnStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[Field("NEVPNStatusDidChangeNotification", "NetworkExtension")]
	[Advice("Use NEVpnConnection.Notifications.ObserveStatusDidChange helper method instead.")]
	public static NSString StatusDidChangeNotification
	{
		get
		{
			if (_StatusDidChangeNotification == null)
			{
				_StatusDidChangeNotification = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNStatusDidChangeNotification");
			}
			return _StatusDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEVpnConnection()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEVpnConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEVpnConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startVPNTunnelAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartVpnTunnel(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selStartVPNTunnelAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selStartVPNTunnelAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("startVPNTunnelWithOptions:andReturnError:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool StartVpnTunnel(NSDictionary? options, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStartVPNTunnelWithOptions_AndReturnError_Handle, options?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStartVPNTunnelWithOptions_AndReturnError_Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool StartVpnTunnel(NEVpnConnectionStartOptions? options, out NSError error)
	{
		return StartVpnTunnel(options.GetDictionary(), out error);
	}

	[Export("stopVPNTunnel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopVpnTunnel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopVPNTunnelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopVPNTunnelHandle);
		}
	}
}

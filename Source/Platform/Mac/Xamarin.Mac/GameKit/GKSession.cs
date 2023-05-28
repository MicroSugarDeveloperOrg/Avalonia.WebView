using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKSession", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'MultipeerConnectivity.MCSession' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'MultipeerConnectivity.MCSession' instead.")]
public class GKSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptConnectionFromPeer_Error_ = "acceptConnectionFromPeer:error:";

	private static readonly IntPtr selAcceptConnectionFromPeer_Error_Handle = Selector.GetHandle("acceptConnectionFromPeer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelConnectToPeer_ = "cancelConnectToPeer:";

	private static readonly IntPtr selCancelConnectToPeer_Handle = Selector.GetHandle("cancelConnectToPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectToPeer_WithTimeout_ = "connectToPeer:withTimeout:";

	private static readonly IntPtr selConnectToPeer_WithTimeout_Handle = Selector.GetHandle("connectToPeer:withTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDenyConnectionFromPeer_ = "denyConnectionFromPeer:";

	private static readonly IntPtr selDenyConnectionFromPeer_Handle = Selector.GetHandle("denyConnectionFromPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectFromAllPeers = "disconnectFromAllPeers";

	private static readonly IntPtr selDisconnectFromAllPeersHandle = Selector.GetHandle("disconnectFromAllPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectPeerFromAllPeers_ = "disconnectPeerFromAllPeers:";

	private static readonly IntPtr selDisconnectPeerFromAllPeers_Handle = Selector.GetHandle("disconnectPeerFromAllPeers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectTimeout = "disconnectTimeout";

	private static readonly IntPtr selDisconnectTimeoutHandle = Selector.GetHandle("disconnectTimeout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameForPeer_ = "displayNameForPeer:";

	private static readonly IntPtr selDisplayNameForPeer_Handle = Selector.GetHandle("displayNameForPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSessionID_DisplayName_SessionMode_ = "initWithSessionID:displayName:sessionMode:";

	private static readonly IntPtr selInitWithSessionID_DisplayName_SessionMode_Handle = Selector.GetHandle("initWithSessionID:displayName:sessionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAvailable = "isAvailable";

	private static readonly IntPtr selIsAvailableHandle = Selector.GetHandle("isAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeerID = "peerID";

	private static readonly IntPtr selPeerIDHandle = Selector.GetHandle("peerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeersWithConnectionState_ = "peersWithConnectionState:";

	private static readonly IntPtr selPeersWithConnectionState_Handle = Selector.GetHandle("peersWithConnectionState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendData_ToPeers_WithDataMode_Error_ = "sendData:toPeers:withDataMode:error:";

	private static readonly IntPtr selSendData_ToPeers_WithDataMode_Error_Handle = Selector.GetHandle("sendData:toPeers:withDataMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendDataToAllPeers_WithDataMode_Error_ = "sendDataToAllPeers:withDataMode:error:";

	private static readonly IntPtr selSendDataToAllPeers_WithDataMode_Error_Handle = Selector.GetHandle("sendDataToAllPeers:withDataMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionID = "sessionID";

	private static readonly IntPtr selSessionIDHandle = Selector.GetHandle("sessionID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionMode = "sessionMode";

	private static readonly IntPtr selSessionModeHandle = Selector.GetHandle("sessionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAvailable_ = "setAvailable:";

	private static readonly IntPtr selSetAvailable_Handle = Selector.GetHandle("setAvailable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataReceiveHandler_WithContext_ = "setDataReceiveHandler:withContext:";

	private static readonly IntPtr selSetDataReceiveHandler_WithContext_Handle = Selector.GetHandle("setDataReceiveHandler:withContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisconnectTimeout_ = "setDisconnectTimeout:";

	private static readonly IntPtr selSetDisconnectTimeout_Handle = Selector.GetHandle("setDisconnectTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Available
	{
		[Export("isAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAvailableHandle);
		}
		[Export("setAvailable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAvailable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAvailable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKSessionDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKSessionDelegate;
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
	public virtual double DisconnectTimeout
	{
		[Export("disconnectTimeout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDisconnectTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDisconnectTimeoutHandle);
		}
		[Export("setDisconnectTimeout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDisconnectTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDisconnectTimeout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PeerID
	{
		[Export("peerID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPeerIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPeerIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SessionID
	{
		[Export("sessionID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public virtual GKSessionMode SessionMode
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("sessionMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKSessionMode)Messaging.int_objc_msgSend(base.Handle, selSessionModeHandle);
			}
			return (GKSessionMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSessionModeHandle);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKSession()
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
	protected GKSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSessionID:displayName:sessionMode:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKSession(string? sessionID, string? displayName, GKSessionMode mode)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(sessionID);
		IntPtr arg2 = NSString.CreateNative(displayName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int(base.Handle, selInitWithSessionID_DisplayName_SessionMode_Handle, arg, arg2, (int)mode), "initWithSessionID:displayName:sessionMode:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int(base.SuperHandle, selInitWithSessionID_DisplayName_SessionMode_Handle, arg, arg2, (int)mode), "initWithSessionID:displayName:sessionMode:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("acceptConnectionFromPeer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptConnection(string peerID, out NSError error)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(peerID);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selAcceptConnectionFromPeer_Error_Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selAcceptConnectionFromPeer_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("cancelConnectToPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelConnect(string peerID)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(peerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelConnectToPeer_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelConnectToPeer_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("connectToPeer:withTimeout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Connect(string peerID, double timeout)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(peerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selConnectToPeer_WithTimeout_Handle, arg, timeout);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selConnectToPeer_WithTimeout_Handle, arg, timeout);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("denyConnectionFromPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DenyConnection(string peerID)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(peerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDenyConnectionFromPeer_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDenyConnectionFromPeer_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("disconnectFromAllPeers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectFromAllPeers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisconnectFromAllPeersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisconnectFromAllPeersHandle);
		}
	}

	[Export("disconnectPeerFromAllPeers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectPeerFromAllPeers(string peerID)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(peerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisconnectPeerFromAllPeers_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisconnectPeerFromAllPeers_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("displayNameForPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayNameForPeer(string peerID)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(peerID);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameForPeer_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameForPeer_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("peersWithConnectionState:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PeersWithConnectionState(GKPeerConnectionState state)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selPeersWithConnectionState_Handle, (int)state));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selPeersWithConnectionState_Handle, (int)state));
	}

	[Export("sendData:toPeers:withDataMode:error:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendData(NSData data, string[] peers, GKSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (peers == null)
		{
			throw new ArgumentNullException("peers");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromStrings(peers);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr(base.SuperHandle, selSendData_ToPeers_WithDataMode_Error_Handle, data.Handle, nSArray.Handle, (int)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(base.Handle, selSendData_ToPeers_WithDataMode_Error_Handle, data.Handle, nSArray.Handle, (int)mode, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("sendDataToAllPeers:withDataMode:error:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendDataToAllPeers(NSData data, GKSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_int_ref_IntPtr(base.SuperHandle, selSendDataToAllPeers_WithDataMode_Error_Handle, data.Handle, (int)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_int_ref_IntPtr(base.Handle, selSendDataToAllPeers_WithDataMode_Error_Handle, data.Handle, (int)mode, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setDataReceiveHandler:withContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDataReceiveHandler(NSObject obj, IntPtr context)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataReceiveHandler_WithContext_Handle, obj.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataReceiveHandler_WithContext_Handle, obj.Handle, context);
		}
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

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Register("MCNearbyServiceBrowser", true)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class MCNearbyServiceBrowser : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPeer_ServiceType_ = "initWithPeer:serviceType:";

	private static readonly IntPtr selInitWithPeer_ServiceType_Handle = Selector.GetHandle("initWithPeer:serviceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvitePeer_ToSession_WithContext_Timeout_ = "invitePeer:toSession:withContext:timeout:";

	private static readonly IntPtr selInvitePeer_ToSession_WithContext_Timeout_Handle = Selector.GetHandle("invitePeer:toSession:withContext:timeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMyPeerID = "myPeerID";

	private static readonly IntPtr selMyPeerIDHandle = Selector.GetHandle("myPeerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceType = "serviceType";

	private static readonly IntPtr selServiceTypeHandle = Selector.GetHandle("serviceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartBrowsingForPeers = "startBrowsingForPeers";

	private static readonly IntPtr selStartBrowsingForPeersHandle = Selector.GetHandle("startBrowsingForPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopBrowsingForPeers = "stopBrowsingForPeers";

	private static readonly IntPtr selStopBrowsingForPeersHandle = Selector.GetHandle("stopBrowsingForPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MCNearbyServiceBrowser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMCNearbyServiceBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as IMCNearbyServiceBrowserDelegate;
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
	public virtual MCPeerID MyPeerID
	{
		[Export("myPeerID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MCPeerID>(Messaging.IntPtr_objc_msgSend(base.Handle, selMyPeerIDHandle));
			}
			return Runtime.GetNSObject<MCPeerID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMyPeerIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ServiceType
	{
		[Export("serviceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServiceTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServiceTypeHandle));
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
	protected MCNearbyServiceBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCNearbyServiceBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPeer:serviceType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCNearbyServiceBrowser(MCPeerID myPeerID, string serviceType)
		: base(NSObjectFlag.Empty)
	{
		if (myPeerID == null)
		{
			throw new ArgumentNullException("myPeerID");
		}
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		IntPtr arg = NSString.CreateNative(serviceType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithPeer_ServiceType_Handle, myPeerID.Handle, arg), "initWithPeer:serviceType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithPeer_ServiceType_Handle, myPeerID.Handle, arg), "initWithPeer:serviceType:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("invitePeer:toSession:withContext:timeout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvitePeer(MCPeerID peerID, MCSession session, NSData? context, double timeout)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_Double(base.Handle, selInvitePeer_ToSession_WithContext_Timeout_Handle, peerID.Handle, session.Handle, context?.Handle ?? IntPtr.Zero, timeout);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Double(base.SuperHandle, selInvitePeer_ToSession_WithContext_Timeout_Handle, peerID.Handle, session.Handle, context?.Handle ?? IntPtr.Zero, timeout);
		}
	}

	[Export("startBrowsingForPeers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartBrowsingForPeers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartBrowsingForPeersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartBrowsingForPeersHandle);
		}
	}

	[Export("stopBrowsingForPeers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopBrowsingForPeers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopBrowsingForPeersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopBrowsingForPeersHandle);
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

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Register("MCNearbyServiceAdvertiser", true)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class MCNearbyServiceAdvertiser : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoveryInfo = "discoveryInfo";

	private static readonly IntPtr selDiscoveryInfoHandle = Selector.GetHandle("discoveryInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPeer_DiscoveryInfo_ServiceType_ = "initWithPeer:discoveryInfo:serviceType:";

	private static readonly IntPtr selInitWithPeer_DiscoveryInfo_ServiceType_Handle = Selector.GetHandle("initWithPeer:discoveryInfo:serviceType:");

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
	private const string selStartAdvertisingPeer = "startAdvertisingPeer";

	private static readonly IntPtr selStartAdvertisingPeerHandle = Selector.GetHandle("startAdvertisingPeer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopAdvertisingPeer = "stopAdvertisingPeer";

	private static readonly IntPtr selStopAdvertisingPeerHandle = Selector.GetHandle("stopAdvertisingPeer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MCNearbyServiceAdvertiser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMCNearbyServiceAdvertiserDelegate Delegate
	{
		get
		{
			return WeakDelegate as IMCNearbyServiceAdvertiserDelegate;
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
	public virtual NSDictionary? DiscoveryInfo
	{
		[Export("discoveryInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDiscoveryInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiscoveryInfoHandle));
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
	protected MCNearbyServiceAdvertiser(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCNearbyServiceAdvertiser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPeer:discoveryInfo:serviceType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCNearbyServiceAdvertiser(MCPeerID myPeerID, NSDictionary? info, string serviceType)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPeer_DiscoveryInfo_ServiceType_Handle, myPeerID.Handle, info?.Handle ?? IntPtr.Zero, arg), "initWithPeer:discoveryInfo:serviceType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPeer_DiscoveryInfo_ServiceType_Handle, myPeerID.Handle, info?.Handle ?? IntPtr.Zero, arg), "initWithPeer:discoveryInfo:serviceType:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("startAdvertisingPeer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartAdvertisingPeer()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartAdvertisingPeerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartAdvertisingPeerHandle);
		}
	}

	[Export("stopAdvertisingPeer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopAdvertisingPeer()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAdvertisingPeerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAdvertisingPeerHandle);
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

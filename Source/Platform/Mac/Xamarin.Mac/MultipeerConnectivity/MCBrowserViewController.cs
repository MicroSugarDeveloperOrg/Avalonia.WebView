using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MultipeerConnectivity;

[Register("MCBrowserViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class MCBrowserViewController : NSViewController, IMCNearbyServiceBrowserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowser = "browser";

	private static readonly IntPtr selBrowserHandle = Selector.GetHandle("browser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowser_DidNotStartBrowsingForPeers_ = "browser:didNotStartBrowsingForPeers:";

	private static readonly IntPtr selBrowser_DidNotStartBrowsingForPeers_Handle = Selector.GetHandle("browser:didNotStartBrowsingForPeers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowser_FoundPeer_WithDiscoveryInfo_ = "browser:foundPeer:withDiscoveryInfo:";

	private static readonly IntPtr selBrowser_FoundPeer_WithDiscoveryInfo_Handle = Selector.GetHandle("browser:foundPeer:withDiscoveryInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowser_LostPeer_ = "browser:lostPeer:";

	private static readonly IntPtr selBrowser_LostPeer_Handle = Selector.GetHandle("browser:lostPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBrowser_Session_ = "initWithBrowser:session:";

	private static readonly IntPtr selInitWithBrowser_Session_Handle = Selector.GetHandle("initWithBrowser:session:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithServiceType_Session_ = "initWithServiceType:session:";

	private static readonly IntPtr selInitWithServiceType_Session_Handle = Selector.GetHandle("initWithServiceType:session:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumNumberOfPeers = "maximumNumberOfPeers";

	private static readonly IntPtr selMaximumNumberOfPeersHandle = Selector.GetHandle("maximumNumberOfPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumNumberOfPeers = "minimumNumberOfPeers";

	private static readonly IntPtr selMinimumNumberOfPeersHandle = Selector.GetHandle("minimumNumberOfPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSession = "session";

	private static readonly IntPtr selSessionHandle = Selector.GetHandle("session");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumNumberOfPeers_ = "setMaximumNumberOfPeers:";

	private static readonly IntPtr selSetMaximumNumberOfPeers_Handle = Selector.GetHandle("setMaximumNumberOfPeers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumNumberOfPeers_ = "setMinimumNumberOfPeers:";

	private static readonly IntPtr selSetMinimumNumberOfPeers_Handle = Selector.GetHandle("setMinimumNumberOfPeers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MCBrowserViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MCNearbyServiceBrowser Browser
	{
		[Export("browser")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MCNearbyServiceBrowser>(Messaging.IntPtr_objc_msgSend(base.Handle, selBrowserHandle));
			}
			return Runtime.GetNSObject<MCNearbyServiceBrowser>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBrowserHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMCBrowserViewControllerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IMCBrowserViewControllerDelegate;
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
	public virtual nuint MaximumNumberOfPeers
	{
		[Export("maximumNumberOfPeers", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumNumberOfPeersHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfPeersHandle);
		}
		[Export("setMaximumNumberOfPeers:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumNumberOfPeers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumNumberOfPeers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinimumNumberOfPeers
	{
		[Export("minimumNumberOfPeers", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinimumNumberOfPeersHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinimumNumberOfPeersHandle);
		}
		[Export("setMinimumNumberOfPeers:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinimumNumberOfPeers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinimumNumberOfPeers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MCSession Session
	{
		[Export("session")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MCSession>(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionHandle));
			}
			return Runtime.GetNSObject<MCSession>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionHandle));
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MCBrowserViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MCBrowserViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCBrowserViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCBrowserViewController(string? nibName, NSBundle? bundle)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithBrowser:session:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCBrowserViewController(MCNearbyServiceBrowser browser, MCSession session)
		: base(NSObjectFlag.Empty)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithBrowser_Session_Handle, browser.Handle, session.Handle), "initWithBrowser:session:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithBrowser_Session_Handle, browser.Handle, session.Handle), "initWithBrowser:session:");
		}
	}

	[Export("initWithServiceType:session:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCBrowserViewController(string serviceType, MCSession session)
		: base(NSObjectFlag.Empty)
	{
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		IntPtr arg = NSString.CreateNative(serviceType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithServiceType_Session_Handle, arg, session.Handle), "initWithServiceType:session:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithServiceType_Session_Handle, arg, session.Handle), "initWithServiceType:session:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("browser:didNotStartBrowsingForPeers:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidNotStartBrowsingForPeers(MCNearbyServiceBrowser browser, NSError error)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBrowser_DidNotStartBrowsingForPeers_Handle, browser.Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBrowser_DidNotStartBrowsingForPeers_Handle, browser.Handle, error.Handle);
		}
	}

	[Export("browser:foundPeer:withDiscoveryInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FoundPeer(MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBrowser_FoundPeer_WithDiscoveryInfo_Handle, browser.Handle, peerID.Handle, info?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBrowser_FoundPeer_WithDiscoveryInfo_Handle, browser.Handle, peerID.Handle, info?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("browser:lostPeer:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LostPeer(MCNearbyServiceBrowser browser, MCPeerID peerID)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBrowser_LostPeer_Handle, browser.Handle, peerID.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBrowser_LostPeer_Handle, browser.Handle, peerID.Handle);
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

using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Security;
using Xamarin.Mac.System.Mac;

namespace MultipeerConnectivity;

[Register("MCSession", true)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class MCSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelConnectPeer_ = "cancelConnectPeer:";

	private static readonly IntPtr selCancelConnectPeer_Handle = Selector.GetHandle("cancelConnectPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectPeer_WithNearbyConnectionData_ = "connectPeer:withNearbyConnectionData:";

	private static readonly IntPtr selConnectPeer_WithNearbyConnectionData_Handle = Selector.GetHandle("connectPeer:withNearbyConnectionData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectedPeers = "connectedPeers";

	private static readonly IntPtr selConnectedPeersHandle = Selector.GetHandle("connectedPeers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnect = "disconnect";

	private static readonly IntPtr selDisconnectHandle = Selector.GetHandle("disconnect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncryptionPreference = "encryptionPreference";

	private static readonly IntPtr selEncryptionPreferenceHandle = Selector.GetHandle("encryptionPreference");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPeer_ = "initWithPeer:";

	private static readonly IntPtr selInitWithPeer_Handle = Selector.GetHandle("initWithPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPeer_SecurityIdentity_EncryptionPreference_ = "initWithPeer:securityIdentity:encryptionPreference:";

	private static readonly IntPtr selInitWithPeer_SecurityIdentity_EncryptionPreference_Handle = Selector.GetHandle("initWithPeer:securityIdentity:encryptionPreference:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMyPeerID = "myPeerID";

	private static readonly IntPtr selMyPeerIDHandle = Selector.GetHandle("myPeerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNearbyConnectionDataForPeer_WithCompletionHandler_ = "nearbyConnectionDataForPeer:withCompletionHandler:";

	private static readonly IntPtr selNearbyConnectionDataForPeer_WithCompletionHandler_Handle = Selector.GetHandle("nearbyConnectionDataForPeer:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecurityIdentity = "securityIdentity";

	private static readonly IntPtr selSecurityIdentityHandle = Selector.GetHandle("securityIdentity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendData_ToPeers_WithMode_Error_ = "sendData:toPeers:withMode:error:";

	private static readonly IntPtr selSendData_ToPeers_WithMode_Error_Handle = Selector.GetHandle("sendData:toPeers:withMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_ = "sendResourceAtURL:withName:toPeer:withCompletionHandler:";

	private static readonly IntPtr selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_Handle = Selector.GetHandle("sendResourceAtURL:withName:toPeer:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartStreamWithName_ToPeer_Error_ = "startStreamWithName:toPeer:error:";

	private static readonly IntPtr selStartStreamWithName_ToPeer_Error_Handle = Selector.GetHandle("startStreamWithName:toPeer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MCSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MCPeerID[] ConnectedPeers
	{
		[Export("connectedPeers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MCPeerID>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectedPeersHandle));
			}
			return NSArray.ArrayFromHandle<MCPeerID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectedPeersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMCSessionDelegate Delegate
	{
		get
		{
			return WeakDelegate as IMCSessionDelegate;
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
	public virtual MCEncryptionPreference EncryptionPreference
	{
		[Export("encryptionPreference")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MCEncryptionPreference)Messaging.Int64_objc_msgSend(base.Handle, selEncryptionPreferenceHandle);
			}
			return (MCEncryptionPreference)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEncryptionPreferenceHandle);
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
	public virtual NSArray? SecurityIdentity
	{
		[Export("securityIdentity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selSecurityIdentityHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecurityIdentityHandle));
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

	[Field("kMCSessionMaximumNumberOfPeers", "MultipeerConnectivity")]
	public static nint MaximumNumberOfPeers => Dlfcn.GetNInt(Libraries.MultipeerConnectivity.Handle, "kMCSessionMaximumNumberOfPeers");

	[Field("kMCSessionMinimumNumberOfPeers", "MultipeerConnectivity")]
	public static nint MinimumNumberOfPeers => Dlfcn.GetNInt(Libraries.MultipeerConnectivity.Handle, "kMCSessionMinimumNumberOfPeers");

	public MCSession(MCPeerID myPeerID, SecIdentity identity, MCEncryptionPreference encryptionPreference)
		: base(NSObjectFlag.Empty)
	{
		if (identity == null)
		{
			base.Handle = Init(myPeerID, null, encryptionPreference);
			return;
		}
		using NSArray identity2 = NSArray.FromNSObjects<SecIdentity>(identity);
		base.Handle = Init(myPeerID, identity2, encryptionPreference);
	}

	public MCSession(MCPeerID myPeerID, SecIdentity identity, SecCertificate[] certificates, MCEncryptionPreference encryptionPreference)
		: base(NSObjectFlag.Empty)
	{
		if (identity == null)
		{
			if (certificates == null)
			{
				base.Handle = Init(myPeerID, null, encryptionPreference);
				return;
			}
			throw new ArgumentNullException("identity");
		}
		using NSArray identity2 = NSArray.FromNativeObjects(certificates);
		base.Handle = Init(myPeerID, identity2, encryptionPreference);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MCSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MCSession(MCPeerID myPeerID)
		: base(NSObjectFlag.Empty)
	{
		if (myPeerID == null)
		{
			throw new ArgumentNullException("myPeerID");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPeer_Handle, myPeerID.Handle), "initWithPeer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPeer_Handle, myPeerID.Handle), "initWithPeer:");
		}
	}

	[Export("cancelConnectPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelConnectPeer(MCPeerID peerID)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelConnectPeer_Handle, peerID.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelConnectPeer_Handle, peerID.Handle);
		}
	}

	[Export("connectPeer:withNearbyConnectionData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectPeer(MCPeerID peerID, NSData data)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selConnectPeer_WithNearbyConnectionData_Handle, peerID.Handle, data.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConnectPeer_WithNearbyConnectionData_Handle, peerID.Handle, data.Handle);
		}
	}

	[Export("disconnect")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Disconnect()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisconnectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisconnectHandle);
		}
	}

	[Export("initWithPeer:securityIdentity:encryptionPreference:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr Init(MCPeerID myPeerID, NSArray? identity, MCEncryptionPreference encryptionPreference)
	{
		if (myPeerID == null)
		{
			throw new ArgumentNullException("myPeerID");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selInitWithPeer_SecurityIdentity_EncryptionPreference_Handle, myPeerID.Handle, identity?.Handle ?? IntPtr.Zero, (long)encryptionPreference);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selInitWithPeer_SecurityIdentity_EncryptionPreference_Handle, myPeerID.Handle, identity?.Handle ?? IntPtr.Zero, (long)encryptionPreference);
	}

	[Export("nearbyConnectionDataForPeer:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void NearbyConnectionDataForPeer(MCPeerID peerID, [BlockProxy(typeof(Trampolines.NIDMCSessionNearbyConnectionDataForPeerCompletionHandler))] MCSessionNearbyConnectionDataForPeerCompletionHandler completionHandler)
	{
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMCSessionNearbyConnectionDataForPeerCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selNearbyConnectionDataForPeer_WithCompletionHandler_Handle, peerID.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selNearbyConnectionDataForPeer_WithCompletionHandler_Handle, peerID.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> NearbyConnectionDataForPeerAsync(MCPeerID peerID)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		NearbyConnectionDataForPeer(peerID, delegate(NSData connectionData_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(connectionData_);
			}
		});
		return tcs.Task;
	}

	[Export("sendData:toPeers:withMode:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendData(NSData data, MCPeerID[] peerIDs, MCSessionSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (peerIDs == null)
		{
			throw new ArgumentNullException("peerIDs");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(peerIDs);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selSendData_ToPeers_WithMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_Int64_ref_IntPtr(base.Handle, selSendData_ToPeers_WithMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("sendResourceAtURL:withName:toPeer:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress? SendResource(NSUrl resourceUrl, string resourceName, MCPeerID peerID, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (resourceUrl == null)
		{
			throw new ArgumentNullException("resourceUrl");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = NSString.CreateNative(resourceName);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_Handle, resourceUrl.Handle, arg, peerID.Handle, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selSendResourceAtURL_WithName_ToPeer_WithCompletionHandler_Handle, resourceUrl.Handle, arg, peerID.Handle, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendResourceAsync(NSUrl resourceUrl, string resourceName, MCPeerID peerID)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendResource(resourceUrl, resourceName, peerID, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendResourceAsync(NSUrl resourceUrl, string resourceName, MCPeerID peerID, out NSProgress result)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		result = SendResource(resourceUrl, resourceName, peerID, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("startStreamWithName:toPeer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOutputStream? StartStream(string streamName, MCPeerID peerID, out NSError error)
	{
		if (streamName == null)
		{
			throw new ArgumentNullException("streamName");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(streamName);
		NSOutputStream result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSOutputStream>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selStartStreamWithName_ToPeer_Error_Handle, arg2, peerID.Handle, ref arg)) : Runtime.GetNSObject<NSOutputStream>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selStartStreamWithName_ToPeer_Error_Handle, arg2, peerID.Handle, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
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

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSConnection", true)]
public class NSConnection : NSObject
{
	private static readonly IntPtr selRootObjectHandle = Selector.GetHandle("rootObject");

	private static readonly IntPtr selSetRootObject_Handle = Selector.GetHandle("setRootObject:");

	private static readonly IntPtr selRemoteObjectsHandle = Selector.GetHandle("remoteObjects");

	private static readonly IntPtr selLocalObjectsHandle = Selector.GetHandle("localObjects");

	private static readonly IntPtr selCurrentConversationHandle = Selector.GetHandle("currentConversation");

	private static readonly IntPtr selAllConnectionsHandle = Selector.GetHandle("allConnections");

	private static readonly IntPtr selRequestTimeoutHandle = Selector.GetHandle("requestTimeout");

	private static readonly IntPtr selSetRequestTimeout_Handle = Selector.GetHandle("setRequestTimeout:");

	private static readonly IntPtr selReplyTimeoutHandle = Selector.GetHandle("replyTimeout");

	private static readonly IntPtr selSetReplyTimeout_Handle = Selector.GetHandle("setReplyTimeout:");

	private static readonly IntPtr selIndependentConversationQueueingHandle = Selector.GetHandle("independentConversationQueueing");

	private static readonly IntPtr selSetIndependentConversationQueueing_Handle = Selector.GetHandle("setIndependentConversationQueueing:");

	private static readonly IntPtr selRequestModesHandle = Selector.GetHandle("requestModes");

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	private static readonly IntPtr selReceivePortHandle = Selector.GetHandle("receivePort");

	private static readonly IntPtr selSendPortHandle = Selector.GetHandle("sendPort");

	private static readonly IntPtr selStatisticsHandle = Selector.GetHandle("statistics");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selConnectionWithReceivePortSendPort_Handle = Selector.GetHandle("connectionWithReceivePort:sendPort:");

	private static readonly IntPtr selRunInNewThreadHandle = Selector.GetHandle("runInNewThread");

	private static readonly IntPtr selAddRunLoop_Handle = Selector.GetHandle("addRunLoop:");

	private static readonly IntPtr selRemoveRunLoop_Handle = Selector.GetHandle("removeRunLoop:");

	private static readonly IntPtr selServiceConnectionWithNameRootObjectUsingNameServer_Handle = Selector.GetHandle("serviceConnectionWithName:rootObject:usingNameServer:");

	private static readonly IntPtr selServiceConnectionWithNameRootObject_Handle = Selector.GetHandle("serviceConnectionWithName:rootObject:");

	private static readonly IntPtr selRegisterName_Handle = Selector.GetHandle("registerName:");

	private static readonly IntPtr selRegisterNameWithNameServer_Handle = Selector.GetHandle("registerName:withNameServer:");

	private static readonly IntPtr selConnectionWithRegisteredNameHost_Handle = Selector.GetHandle("connectionWithRegisteredName:host:");

	private static readonly IntPtr selConnectionWithRegisteredNameHostUsingNameServer_Handle = Selector.GetHandle("connectionWithRegisteredName:host:usingNameServer:");

	private static readonly IntPtr selRootProxyHandle = Selector.GetHandle("rootProxy");

	private static readonly IntPtr selRootProxyForConnectionWithRegisteredNameHost_Handle = Selector.GetHandle("rootProxyForConnectionWithRegisteredName:host:");

	private static readonly IntPtr selRootProxyForConnectionWithRegisteredNameHostUsingNameServer_Handle = Selector.GetHandle("rootProxyForConnectionWithRegisteredName:host:usingNameServer:");

	private static readonly IntPtr selAddRequestMode_Handle = Selector.GetHandle("addRequestMode:");

	private static readonly IntPtr selRemoveRequestMode_Handle = Selector.GetHandle("removeRequestMode:");

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	private static readonly IntPtr selDispatchWithComponents_Handle = Selector.GetHandle("dispatchWithComponents:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSConnection");

	private object __mt_RootObject_var;

	private object __mt_RemoteObjects_var;

	private object __mt_LocalObjects_var;

	private static object __mt_CurrentConversation_var_static;

	private static object __mt_AllConnections_var_static;

	private object __mt_RequestModes_var;

	private object __mt_ReceivePort_var;

	private object __mt_SendPort_var;

	private object __mt_Statistics_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject RootObject
	{
		[Export("rootObject")]
		get
		{
			return (NSObject)(__mt_RootObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRootObjectHandle))));
		}
		[Export("setRootObject:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRootObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRootObject_Handle, value.Handle);
			}
			__mt_RootObject_var = value;
		}
	}

	public virtual NSObject[] RemoteObjects
	{
		[Export("remoteObjects")]
		get
		{
			return (NSObject[])(__mt_RemoteObjects_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteObjectsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteObjectsHandle))));
		}
	}

	public virtual NSObject[] LocalObjects
	{
		[Export("localObjects")]
		get
		{
			return (NSObject[])(__mt_LocalObjects_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalObjectsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalObjectsHandle))));
		}
	}

	public static NSObject CurrentConversation
	{
		[Export("currentConversation")]
		get
		{
			return (NSObject)(__mt_CurrentConversation_var_static = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentConversationHandle)));
		}
	}

	public static NSConnection[] AllConnections
	{
		[Export("allConnections")]
		get
		{
			return (NSConnection[])(__mt_AllConnections_var_static = NSArray.ArrayFromHandle<NSConnection>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllConnectionsHandle)));
		}
	}

	public virtual double RequestTimeout
	{
		[Export("requestTimeout")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRequestTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRequestTimeoutHandle);
		}
		[Export("setRequestTimeout:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRequestTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRequestTimeout_Handle, value);
			}
		}
	}

	public virtual double ReplyTimeout
	{
		[Export("replyTimeout")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selReplyTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selReplyTimeoutHandle);
		}
		[Export("setReplyTimeout:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetReplyTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetReplyTimeout_Handle, value);
			}
		}
	}

	public virtual bool IndependentConversationQueueing
	{
		[Export("independentConversationQueueing")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIndependentConversationQueueingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIndependentConversationQueueingHandle);
		}
		[Export("setIndependentConversationQueueing:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndependentConversationQueueing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndependentConversationQueueing_Handle, value);
			}
		}
	}

	public virtual NSString[] RequestModes
	{
		[Export("requestModes")]
		get
		{
			return (NSString[])(__mt_RequestModes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestModesHandle)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestModesHandle))));
		}
	}

	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	public virtual NSPort ReceivePort
	{
		[Export("receivePort")]
		get
		{
			return (NSPort)(__mt_ReceivePort_var = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReceivePortHandle))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReceivePortHandle)))));
		}
	}

	public virtual NSPort SendPort
	{
		[Export("sendPort")]
		get
		{
			return (NSPort)(__mt_SendPort_var = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendPortHandle))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSendPortHandle)))));
		}
	}

	public virtual NSDictionary Statistics
	{
		[Export("statistics")]
		get
		{
			return (NSDictionary)(__mt_Statistics_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStatisticsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStatisticsHandle)))));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSConnectionDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSConnectionDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public TProxy GetRootProxy<TProxy>() where TProxy : NSObject
	{
		return GetRootProxy<TProxy>(_GetRootProxy());
	}

	public static TProxy GetRootProxy<TProxy>(string name, string hostName) where TProxy : NSObject
	{
		return GetRootProxy<TProxy>(_GetRootProxy(name, hostName));
	}

	public static TProxy GetRootProxy<TProxy>(string name, string hostName, NSPortNameServer server) where TProxy : NSObject
	{
		return GetRootProxy<TProxy>(_GetRootProxy(name, hostName, server));
	}

	private static TProxy GetRootProxy<TProxy>(IntPtr handle) where TProxy : NSObject
	{
		TProxy val = Runtime.TryGetNSObject(handle) as TProxy;
		if (val == null)
		{
			val = (TProxy)Activator.CreateInstance(typeof(TProxy), handle);
		}
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSConnection(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("connectionWithReceivePort:sendPort:")]
	public static NSConnection Create(NSPort receivePort, NSPort sendPort)
	{
		return (NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithReceivePortSendPort_Handle, receivePort?.Handle ?? IntPtr.Zero, sendPort?.Handle ?? IntPtr.Zero));
	}

	[Export("runInNewThread")]
	public virtual void RunInNewThread()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRunInNewThreadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRunInNewThreadHandle);
		}
	}

	[Export("addRunLoop:")]
	public virtual void AddRunLoop(NSRunLoop runLoop)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRunLoop_Handle, runLoop.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRunLoop_Handle, runLoop.Handle);
		}
	}

	[Export("removeRunLoop:")]
	public virtual void RemoveRunLoop(NSRunLoop runLoop)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRunLoop_Handle, runLoop.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRunLoop_Handle, runLoop.Handle);
		}
	}

	[Export("serviceConnectionWithName:rootObject:usingNameServer:")]
	public static NSConnection CreateService(string name, NSObject root, NSPortNameServer server)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSConnection result = (NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selServiceConnectionWithNameRootObjectUsingNameServer_Handle, arg, root.Handle, server.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("serviceConnectionWithName:rootObject:")]
	public static NSConnection CreateService(string name, NSObject root)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSConnection result = (NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selServiceConnectionWithNameRootObject_Handle, arg, root.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("registerName:")]
	public virtual bool RegisterName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRegisterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("registerName:withNameServer:")]
	public virtual bool RegisterName(string name, NSPortNameServer server)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterNameWithNameServer_Handle, arg, server.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterNameWithNameServer_Handle, arg, server.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("connectionWithRegisteredName:host:")]
	public static NSConnection LookupService(string name, string hostName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		NSConnection result = (NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithRegisteredNameHost_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("connectionWithRegisteredName:host:usingNameServer:")]
	public static NSConnection LookupService(string name, string hostName, NSPortNameServer server)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		NSConnection result = (NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selConnectionWithRegisteredNameHostUsingNameServer_Handle, arg, arg2, server.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("rootProxy")]
	internal virtual IntPtr _GetRootProxy()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selRootProxyHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootProxyHandle);
	}

	[Export("rootProxyForConnectionWithRegisteredName:host:")]
	internal static IntPtr _GetRootProxy(string name, string hostName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRootProxyForConnectionWithRegisteredNameHost_Handle, arg, arg2);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("rootProxyForConnectionWithRegisteredName:host:usingNameServer:")]
	internal static IntPtr _GetRootProxy(string name, string hostName, NSPortNameServer server)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRootProxyForConnectionWithRegisteredNameHostUsingNameServer_Handle, arg, arg2, server.Handle);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("addRequestMode:")]
	public virtual void AddRequestMode(NSString runLoopMode)
	{
		if (runLoopMode == null)
		{
			throw new ArgumentNullException("runLoopMode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRequestMode_Handle, runLoopMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRequestMode_Handle, runLoopMode.Handle);
		}
	}

	[Export("removeRequestMode:")]
	public virtual void RemoveRequestMode(NSString runLoopMode)
	{
		if (runLoopMode == null)
		{
			throw new ArgumentNullException("runLoopMode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRequestMode_Handle, runLoopMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRequestMode_Handle, runLoopMode.Handle);
		}
	}

	[Export("invalidate")]
	public virtual void Invalidate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("dispatchWithComponents:")]
	public virtual void Dispatch(NSArray components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDispatchWithComponents_Handle, components.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDispatchWithComponents_Handle, components.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RootObject_var = null;
			__mt_RemoteObjects_var = null;
			__mt_LocalObjects_var = null;
			__mt_RequestModes_var = null;
			__mt_ReceivePort_var = null;
			__mt_SendPort_var = null;
			__mt_Statistics_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

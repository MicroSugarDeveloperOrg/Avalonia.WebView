using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSConnection", true)]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
public class NSConnection : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRequestMode_ = "addRequestMode:";

	private static readonly IntPtr selAddRequestMode_Handle = Selector.GetHandle("addRequestMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRunLoop_ = "addRunLoop:";

	private static readonly IntPtr selAddRunLoop_Handle = Selector.GetHandle("addRunLoop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllConnections = "allConnections";

	private static readonly IntPtr selAllConnectionsHandle = Selector.GetHandle("allConnections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithReceivePort_SendPort_ = "connectionWithReceivePort:sendPort:";

	private static readonly IntPtr selConnectionWithReceivePort_SendPort_Handle = Selector.GetHandle("connectionWithReceivePort:sendPort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithRegisteredName_Host_ = "connectionWithRegisteredName:host:";

	private static readonly IntPtr selConnectionWithRegisteredName_Host_Handle = Selector.GetHandle("connectionWithRegisteredName:host:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithRegisteredName_Host_UsingNameServer_ = "connectionWithRegisteredName:host:usingNameServer:";

	private static readonly IntPtr selConnectionWithRegisteredName_Host_UsingNameServer_Handle = Selector.GetHandle("connectionWithRegisteredName:host:usingNameServer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentConversation = "currentConversation";

	private static readonly IntPtr selCurrentConversationHandle = Selector.GetHandle("currentConversation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDispatchWithComponents_ = "dispatchWithComponents:";

	private static readonly IntPtr selDispatchWithComponents_Handle = Selector.GetHandle("dispatchWithComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndependentConversationQueueing = "independentConversationQueueing";

	private static readonly IntPtr selIndependentConversationQueueingHandle = Selector.GetHandle("independentConversationQueueing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValid = "isValid";

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalObjects = "localObjects";

	private static readonly IntPtr selLocalObjectsHandle = Selector.GetHandle("localObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceivePort = "receivePort";

	private static readonly IntPtr selReceivePortHandle = Selector.GetHandle("receivePort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterName_ = "registerName:";

	private static readonly IntPtr selRegisterName_Handle = Selector.GetHandle("registerName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterName_WithNameServer_ = "registerName:withNameServer:";

	private static readonly IntPtr selRegisterName_WithNameServer_Handle = Selector.GetHandle("registerName:withNameServer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteObjects = "remoteObjects";

	private static readonly IntPtr selRemoteObjectsHandle = Selector.GetHandle("remoteObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRequestMode_ = "removeRequestMode:";

	private static readonly IntPtr selRemoveRequestMode_Handle = Selector.GetHandle("removeRequestMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRunLoop_ = "removeRunLoop:";

	private static readonly IntPtr selRemoveRunLoop_Handle = Selector.GetHandle("removeRunLoop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyTimeout = "replyTimeout";

	private static readonly IntPtr selReplyTimeoutHandle = Selector.GetHandle("replyTimeout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestModes = "requestModes";

	private static readonly IntPtr selRequestModesHandle = Selector.GetHandle("requestModes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestTimeout = "requestTimeout";

	private static readonly IntPtr selRequestTimeoutHandle = Selector.GetHandle("requestTimeout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootObject = "rootObject";

	private static readonly IntPtr selRootObjectHandle = Selector.GetHandle("rootObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootProxy = "rootProxy";

	private static readonly IntPtr selRootProxyHandle = Selector.GetHandle("rootProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootProxyForConnectionWithRegisteredName_Host_ = "rootProxyForConnectionWithRegisteredName:host:";

	private static readonly IntPtr selRootProxyForConnectionWithRegisteredName_Host_Handle = Selector.GetHandle("rootProxyForConnectionWithRegisteredName:host:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootProxyForConnectionWithRegisteredName_Host_UsingNameServer_ = "rootProxyForConnectionWithRegisteredName:host:usingNameServer:";

	private static readonly IntPtr selRootProxyForConnectionWithRegisteredName_Host_UsingNameServer_Handle = Selector.GetHandle("rootProxyForConnectionWithRegisteredName:host:usingNameServer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunInNewThread = "runInNewThread";

	private static readonly IntPtr selRunInNewThreadHandle = Selector.GetHandle("runInNewThread");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPort = "sendPort";

	private static readonly IntPtr selSendPortHandle = Selector.GetHandle("sendPort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceConnectionWithName_RootObject_ = "serviceConnectionWithName:rootObject:";

	private static readonly IntPtr selServiceConnectionWithName_RootObject_Handle = Selector.GetHandle("serviceConnectionWithName:rootObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceConnectionWithName_RootObject_UsingNameServer_ = "serviceConnectionWithName:rootObject:usingNameServer:";

	private static readonly IntPtr selServiceConnectionWithName_RootObject_UsingNameServer_Handle = Selector.GetHandle("serviceConnectionWithName:rootObject:usingNameServer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndependentConversationQueueing_ = "setIndependentConversationQueueing:";

	private static readonly IntPtr selSetIndependentConversationQueueing_Handle = Selector.GetHandle("setIndependentConversationQueueing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReplyTimeout_ = "setReplyTimeout:";

	private static readonly IntPtr selSetReplyTimeout_Handle = Selector.GetHandle("setReplyTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestTimeout_ = "setRequestTimeout:";

	private static readonly IntPtr selSetRequestTimeout_Handle = Selector.GetHandle("setRequestTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRootObject_ = "setRootObject:";

	private static readonly IntPtr selSetRootObject_Handle = Selector.GetHandle("setRootObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatistics = "statistics";

	private static readonly IntPtr selStatisticsHandle = Selector.GetHandle("statistics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSConnection[] AllConnections
	{
		[Export("allConnections")]
		get
		{
			return NSArray.ArrayFromHandle<NSConnection>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject CurrentConversation
	{
		[Export("currentConversation")]
		get
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentConversationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSConnectionDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSConnectionDelegate;
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
	public virtual bool IndependentConversationQueueing
	{
		[Export("independentConversationQueueing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIndependentConversationQueueingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIndependentConversationQueueingHandle);
		}
		[Export("setIndependentConversationQueueing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndependentConversationQueueing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndependentConversationQueueing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] LocalObjects
	{
		[Export("localObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalObjectsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort ReceivePort
	{
		[Export("receivePort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selReceivePortHandle));
			}
			return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReceivePortHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] RemoteObjects
	{
		[Export("remoteObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteObjectsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ReplyTimeout
	{
		[Export("replyTimeout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selReplyTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selReplyTimeoutHandle);
		}
		[Export("setReplyTimeout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetReplyTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetReplyTimeout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] RequestModes
	{
		[Export("requestModes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestModesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestModesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double RequestTimeout
	{
		[Export("requestTimeout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRequestTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRequestTimeoutHandle);
		}
		[Export("setRequestTimeout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRequestTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRequestTimeout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RootObject
	{
		[Export("rootObject", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRootObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootObjectHandle));
		}
		[Export("setRootObject:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRootObject_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRootObject_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort SendPort
	{
		[Export("sendPort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selSendPortHandle));
			}
			return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendPortHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Statistics
	{
		[Export("statistics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selStatisticsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStatisticsHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addRequestMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRequestMode(NSString runLoopMode)
	{
		if (runLoopMode == null)
		{
			throw new ArgumentNullException("runLoopMode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRequestMode_Handle, runLoopMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRequestMode_Handle, runLoopMode.Handle);
		}
	}

	[Export("addRunLoop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRunLoop(NSRunLoop runLoop)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRunLoop_Handle, runLoop.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRunLoop_Handle, runLoop.Handle);
		}
	}

	[Export("connectionWithReceivePort:sendPort:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSConnection Create(NSPort? receivePort, NSPort? sendPort)
	{
		return Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithReceivePort_SendPort_Handle, receivePort?.Handle ?? IntPtr.Zero, sendPort?.Handle ?? IntPtr.Zero));
	}

	[Export("serviceConnectionWithName:rootObject:usingNameServer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSConnection nSObject = Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selServiceConnectionWithName_RootObject_UsingNameServer_Handle, arg, root.Handle, server.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("serviceConnectionWithName:rootObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSConnection nSObject = Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selServiceConnectionWithName_RootObject_Handle, arg, root.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("dispatchWithComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Dispatch(NSArray components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDispatchWithComponents_Handle, components.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDispatchWithComponents_Handle, components.Handle);
		}
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("connectionWithRegisteredName:host:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSConnection LookupService(string name, string? hostName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		NSConnection nSObject = Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithRegisteredName_Host_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("connectionWithRegisteredName:host:usingNameServer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSConnection LookupService(string name, string? hostName, NSPortNameServer server)
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
		NSConnection nSObject = Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selConnectionWithRegisteredName_Host_UsingNameServer_Handle, arg, arg2, server.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("registerName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RegisterName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRegisterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("registerName:withNameServer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterName_WithNameServer_Handle, arg, server.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterName_WithNameServer_Handle, arg, server.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeRequestMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRequestMode(NSString runLoopMode)
	{
		if (runLoopMode == null)
		{
			throw new ArgumentNullException("runLoopMode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRequestMode_Handle, runLoopMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRequestMode_Handle, runLoopMode.Handle);
		}
	}

	[Export("removeRunLoop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRunLoop(NSRunLoop runLoop)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRunLoop_Handle, runLoop.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRunLoop_Handle, runLoop.Handle);
		}
	}

	[Export("runInNewThread")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunInNewThread()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRunInNewThreadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRunInNewThreadHandle);
		}
	}

	[Export("rootProxy")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetRootProxy()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selRootProxyHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootProxyHandle);
	}

	[Export("rootProxyForConnectionWithRegisteredName:host:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _GetRootProxy(string name, string? hostName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(hostName);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRootProxyForConnectionWithRegisteredName_Host_Handle, arg, arg2);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("rootProxyForConnectionWithRegisteredName:host:usingNameServer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _GetRootProxy(string name, string? hostName, NSPortNameServer server)
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
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRootProxyForConnectionWithRegisteredName_Host_UsingNameServer_Handle, arg, arg2, server.Handle);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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

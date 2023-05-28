using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSXPCConnection", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
public class NSXpcConnection : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuditSessionIdentifier = "auditSessionIdentifier";

	private static readonly IntPtr selAuditSessionIdentifierHandle = Selector.GetHandle("auditSessionIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentConnection = "currentConnection";

	private static readonly IntPtr selCurrentConnectionHandle = Selector.GetHandle("currentConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveGroupIdentifier = "effectiveGroupIdentifier";

	private static readonly IntPtr selEffectiveGroupIdentifierHandle = Selector.GetHandle("effectiveGroupIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveUserIdentifier = "effectiveUserIdentifier";

	private static readonly IntPtr selEffectiveUserIdentifierHandle = Selector.GetHandle("effectiveUserIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndpoint = "endpoint";

	private static readonly IntPtr selEndpointHandle = Selector.GetHandle("endpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportedInterface = "exportedInterface";

	private static readonly IntPtr selExportedInterfaceHandle = Selector.GetHandle("exportedInterface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportedObject = "exportedObject";

	private static readonly IntPtr selExportedObjectHandle = Selector.GetHandle("exportedObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithListenerEndpoint_ = "initWithListenerEndpoint:";

	private static readonly IntPtr selInitWithListenerEndpoint_Handle = Selector.GetHandle("initWithListenerEndpoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMachServiceName_Options_ = "initWithMachServiceName:options:";

	private static readonly IntPtr selInitWithMachServiceName_Options_Handle = Selector.GetHandle("initWithMachServiceName:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithServiceName_ = "initWithServiceName:";

	private static readonly IntPtr selInitWithServiceName_Handle = Selector.GetHandle("initWithServiceName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterruptionHandler = "interruptionHandler";

	private static readonly IntPtr selInterruptionHandlerHandle = Selector.GetHandle("interruptionHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidationHandler = "invalidationHandler";

	private static readonly IntPtr selInvalidationHandlerHandle = Selector.GetHandle("invalidationHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessIdentifier = "processIdentifier";

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteObjectInterface = "remoteObjectInterface";

	private static readonly IntPtr selRemoteObjectInterfaceHandle = Selector.GetHandle("remoteObjectInterface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteObjectProxy = "remoteObjectProxy";

	private static readonly IntPtr selRemoteObjectProxyHandle = Selector.GetHandle("remoteObjectProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteObjectProxyWithErrorHandler_ = "remoteObjectProxyWithErrorHandler:";

	private static readonly IntPtr selRemoteObjectProxyWithErrorHandler_Handle = Selector.GetHandle("remoteObjectProxyWithErrorHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleSendBarrierBlock_ = "scheduleSendBarrierBlock:";

	private static readonly IntPtr selScheduleSendBarrierBlock_Handle = Selector.GetHandle("scheduleSendBarrierBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceName = "serviceName";

	private static readonly IntPtr selServiceNameHandle = Selector.GetHandle("serviceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExportedInterface_ = "setExportedInterface:";

	private static readonly IntPtr selSetExportedInterface_Handle = Selector.GetHandle("setExportedInterface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExportedObject_ = "setExportedObject:";

	private static readonly IntPtr selSetExportedObject_Handle = Selector.GetHandle("setExportedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterruptionHandler_ = "setInterruptionHandler:";

	private static readonly IntPtr selSetInterruptionHandler_Handle = Selector.GetHandle("setInterruptionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInvalidationHandler_ = "setInvalidationHandler:";

	private static readonly IntPtr selSetInvalidationHandler_Handle = Selector.GetHandle("setInvalidationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemoteObjectInterface_ = "setRemoteObjectInterface:";

	private static readonly IntPtr selSetRemoteObjectInterface_Handle = Selector.GetHandle("setRemoteObjectInterface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuspend = "suspend";

	private static readonly IntPtr selSuspendHandle = Selector.GetHandle("suspend");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronousRemoteObjectProxyWithErrorHandler_ = "synchronousRemoteObjectProxyWithErrorHandler:";

	private static readonly IntPtr selSynchronousRemoteObjectProxyWithErrorHandler_Handle = Selector.GetHandle("synchronousRemoteObjectProxyWithErrorHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSXPCConnection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int AuditSessionIdentifier
	{
		[Export("auditSessionIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selAuditSessionIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selAuditSessionIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSXpcConnection CurrentConnection
	{
		[Export("currentConnection")]
		get
		{
			return Runtime.GetNSObject<NSXpcConnection>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentConnectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSXpcListenerEndpoint Endpoint
	{
		[Export("endpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSXpcListenerEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndpointHandle));
			}
			return Runtime.GetNSObject<NSXpcListenerEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSXpcInterface? ExportedInterface
	{
		[Export("exportedInterface", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSXpcInterface>(Messaging.IntPtr_objc_msgSend(base.Handle, selExportedInterfaceHandle));
			}
			return Runtime.GetNSObject<NSXpcInterface>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExportedInterfaceHandle));
		}
		[Export("setExportedInterface:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExportedInterface_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExportedInterface_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ExportedObject
	{
		[Export("exportedObject", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExportedObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExportedObjectHandle));
		}
		[Export("setExportedObject:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExportedObject_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExportedObject_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action InterruptionHandler
	{
		[Export("interruptionHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterruptionHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selInterruptionHandlerHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setInterruptionHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInterruptionHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInterruptionHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action InvalidationHandler
	{
		[Export("invalidationHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvalidationHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selInvalidationHandlerHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setInvalidationHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInvalidationHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInvalidationHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PeerEffectiveGroupId
	{
		[Export("effectiveGroupIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selEffectiveGroupIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selEffectiveGroupIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PeerEffectiveUserId
	{
		[Export("effectiveUserIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selEffectiveUserIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selEffectiveUserIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PeerProcessIdentifier
	{
		[Export("processIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selProcessIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selProcessIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSXpcInterface? RemoteInterface
	{
		[Export("remoteObjectInterface", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSXpcInterface>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteObjectInterfaceHandle));
			}
			return Runtime.GetNSObject<NSXpcInterface>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteObjectInterfaceHandle));
		}
		[Export("setRemoteObjectInterface:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRemoteObjectInterface_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRemoteObjectInterface_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ServiceName
	{
		[Export("serviceName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServiceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServiceNameHandle));
		}
	}

	public TProtocol CreateRemoteObjectProxy<TProtocol>() where TProtocol : class, INativeObject
	{
		IntPtr ptr = _CreateRemoteObjectProxy();
		return Runtime.GetINativeObject<TProtocol>(ptr, owns: true);
	}

	public TProtocol CreateRemoteObjectProxy<TProtocol>(Action<NSError> errorHandler) where TProtocol : class, INativeObject
	{
		IntPtr ptr = _CreateRemoteObjectProxy(errorHandler);
		return Runtime.GetINativeObject<TProtocol>(ptr, owns: true);
	}

	public TProtocol CreateSynchronousRemoteObjectProxy<TProtocol>(Action<NSError> errorHandler) where TProtocol : class, INativeObject
	{
		IntPtr ptr = _CreateSynchronousRemoteObjectProxy(errorHandler);
		return Runtime.GetINativeObject<TProtocol>(ptr, owns: true);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSXpcConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSXpcConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithServiceName:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSXpcConnection(string xpcServiceName)
		: base(NSObjectFlag.Empty)
	{
		if (xpcServiceName == null)
		{
			throw new ArgumentNullException("xpcServiceName");
		}
		IntPtr arg = NSString.CreateNative(xpcServiceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithServiceName_Handle, arg), "initWithServiceName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithServiceName_Handle, arg), "initWithServiceName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithMachServiceName:options:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSXpcConnection(string machServiceName, NSXpcConnectionOptions options)
		: base(NSObjectFlag.Empty)
	{
		if (machServiceName == null)
		{
			throw new ArgumentNullException("machServiceName");
		}
		IntPtr arg = NSString.CreateNative(machServiceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithMachServiceName_Options_Handle, arg, (ulong)options), "initWithMachServiceName:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithMachServiceName_Options_Handle, arg, (ulong)options), "initWithMachServiceName:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithListenerEndpoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSXpcConnection(NSXpcListenerEndpoint endpoint)
		: base(NSObjectFlag.Empty)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithListenerEndpoint_Handle, endpoint.Handle), "initWithListenerEndpoint:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithListenerEndpoint_Handle, endpoint.Handle), "initWithListenerEndpoint:");
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

	[Export("resume")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
		}
	}

	[Export("scheduleSendBarrierBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleSendBarrier([BlockProxy(typeof(Trampolines.NIDAction))] Action block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScheduleSendBarrierBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScheduleSendBarrierBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("suspend")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Suspend()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSuspendHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSuspendHandle);
		}
	}

	[Export("remoteObjectProxy")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _CreateRemoteObjectProxy()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteObjectProxyHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteObjectProxyHandle);
	}

	[Export("remoteObjectProxyWithErrorHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual IntPtr _CreateRemoteObjectProxy([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> errorHandler)
	{
		if (errorHandler == null)
		{
			throw new ArgumentNullException("errorHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, errorHandler);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoteObjectProxyWithErrorHandler_Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoteObjectProxyWithErrorHandler_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("synchronousRemoteObjectProxyWithErrorHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual IntPtr _CreateSynchronousRemoteObjectProxy([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> errorHandler)
	{
		if (errorHandler == null)
		{
			throw new ArgumentNullException("errorHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, errorHandler);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSynchronousRemoteObjectProxyWithErrorHandler_Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSynchronousRemoteObjectProxyWithErrorHandler_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}
}

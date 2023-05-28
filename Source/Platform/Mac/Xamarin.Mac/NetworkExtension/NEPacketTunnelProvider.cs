using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEPacketTunnelProvider", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEPacketTunnelProvider : NETunnelProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelTunnelWithError_ = "cancelTunnelWithError:";

	private static readonly IntPtr selCancelTunnelWithError_Handle = Selector.GetHandle("cancelTunnelWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTCPConnectionThroughTunnelToEndpoint_EnableTLS_TLSParameters_Delegate_ = "createTCPConnectionThroughTunnelToEndpoint:enableTLS:TLSParameters:delegate:";

	private static readonly IntPtr selCreateTCPConnectionThroughTunnelToEndpoint_EnableTLS_TLSParameters_Delegate_Handle = Selector.GetHandle("createTCPConnectionThroughTunnelToEndpoint:enableTLS:TLSParameters:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateUDPSessionThroughTunnelToEndpoint_FromEndpoint_ = "createUDPSessionThroughTunnelToEndpoint:fromEndpoint:";

	private static readonly IntPtr selCreateUDPSessionThroughTunnelToEndpoint_FromEndpoint_Handle = Selector.GetHandle("createUDPSessionThroughTunnelToEndpoint:fromEndpoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPacketFlow = "packetFlow";

	private static readonly IntPtr selPacketFlowHandle = Selector.GetHandle("packetFlow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTunnelWithOptions_CompletionHandler_ = "startTunnelWithOptions:completionHandler:";

	private static readonly IntPtr selStartTunnelWithOptions_CompletionHandler_Handle = Selector.GetHandle("startTunnelWithOptions:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopTunnelWithReason_CompletionHandler_ = "stopTunnelWithReason:completionHandler:";

	private static readonly IntPtr selStopTunnelWithReason_CompletionHandler_Handle = Selector.GetHandle("stopTunnelWithReason:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEPacketTunnelProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEPacketTunnelFlow PacketFlow
	{
		[Export("packetFlow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEPacketTunnelFlow>(Messaging.IntPtr_objc_msgSend(base.Handle, selPacketFlowHandle));
			}
			return Runtime.GetNSObject<NEPacketTunnelFlow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPacketFlowHandle));
		}
	}

	[Obsolete("Use the overload accepting a 'INWTcpConnectionAuthenticationDelegate' argument.")]
	public virtual NWTcpConnection CreateTcpConnection(NWEndpoint remoteEndpoint, bool enableTls, NWTlsParameters tlsParameters, NWTcpConnectionAuthenticationDelegate @delegate)
	{
		return CreateTcpConnection(remoteEndpoint, enableTls, tlsParameters, (INWTcpConnectionAuthenticationDelegate?)@delegate);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEPacketTunnelProvider()
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
	protected NEPacketTunnelProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEPacketTunnelProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelTunnelWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelTunnel(NSError? error)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelTunnelWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelTunnelWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("createTCPConnectionThroughTunnelToEndpoint:enableTLS:TLSParameters:delegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWTcpConnection CreateTcpConnection(NWEndpoint remoteEndpoint, bool enableTls, NWTlsParameters? tlsParameters, INWTcpConnectionAuthenticationDelegate? @delegate)
	{
		if (remoteEndpoint == null)
		{
			throw new ArgumentNullException("remoteEndpoint");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NWTcpConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr_IntPtr(base.Handle, selCreateTCPConnectionThroughTunnelToEndpoint_EnableTLS_TLSParameters_Delegate_Handle, remoteEndpoint.Handle, enableTls, tlsParameters?.Handle ?? IntPtr.Zero, @delegate?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NWTcpConnection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr(base.SuperHandle, selCreateTCPConnectionThroughTunnelToEndpoint_EnableTLS_TLSParameters_Delegate_Handle, remoteEndpoint.Handle, enableTls, tlsParameters?.Handle ?? IntPtr.Zero, @delegate?.Handle ?? IntPtr.Zero));
	}

	[Export("createUDPSessionThroughTunnelToEndpoint:fromEndpoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWUdpSession CreateUdpSession(NWEndpoint remoteEndpoint, NWHostEndpoint? localEndpoint)
	{
		if (remoteEndpoint == null)
		{
			throw new ArgumentNullException("remoteEndpoint");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NWUdpSession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateUDPSessionThroughTunnelToEndpoint_FromEndpoint_Handle, remoteEndpoint.Handle, localEndpoint?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NWUdpSession>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateUDPSessionThroughTunnelToEndpoint_FromEndpoint_Handle, remoteEndpoint.Handle, localEndpoint?.Handle ?? IntPtr.Zero));
	}

	[Export("startTunnelWithOptions:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartTunnel(NSDictionary<NSString, NSObject>? options, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartTunnelWithOptions_CompletionHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartTunnelWithOptions_CompletionHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StartTunnelAsync(NSDictionary<NSString, NSObject>? options)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StartTunnel(options, delegate(NSError obj_)
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

	[Export("stopTunnelWithReason:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StopTunnel(NEProviderStopReason reason, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selStopTunnelWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selStopTunnelWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StopTunnelAsync(NEProviderStopReason reason)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StopTunnel(reason, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}

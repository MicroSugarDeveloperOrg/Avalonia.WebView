using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEDNSProxyProvider", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEDnsProxyProvider : NEProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelProxyWithError_ = "cancelProxyWithError:";

	private static readonly IntPtr selCancelProxyWithError_Handle = Selector.GetHandle("cancelProxyWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleNewFlow_ = "handleNewFlow:";

	private static readonly IntPtr selHandleNewFlow_Handle = Selector.GetHandle("handleNewFlow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleNewUDPFlow_InitialRemoteEndpoint_ = "handleNewUDPFlow:initialRemoteEndpoint:";

	private static readonly IntPtr selHandleNewUDPFlow_InitialRemoteEndpoint_Handle = Selector.GetHandle("handleNewUDPFlow:initialRemoteEndpoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartProxyWithOptions_CompletionHandler_ = "startProxyWithOptions:completionHandler:";

	private static readonly IntPtr selStartProxyWithOptions_CompletionHandler_Handle = Selector.GetHandle("startProxyWithOptions:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopProxyWithReason_CompletionHandler_ = "stopProxyWithReason:completionHandler:";

	private static readonly IntPtr selStopProxyWithReason_CompletionHandler_Handle = Selector.GetHandle("stopProxyWithReason:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemDNSSettings = "systemDNSSettings";

	private static readonly IntPtr selSystemDNSSettingsHandle = Selector.GetHandle("systemDNSSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEDNSProxyProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEDnsSettings[]? SystemDnsSettings
	{
		[Export("systemDNSSettings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEDnsSettings>(Messaging.IntPtr_objc_msgSend(base.Handle, selSystemDNSSettingsHandle));
			}
			return NSArray.ArrayFromHandle<NEDnsSettings>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSystemDNSSettingsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEDnsProxyProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEDnsProxyProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelProxyWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelProxy(NSError? error)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelProxyWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelProxyWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("handleNewFlow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandleNewFlow(NEAppProxyFlow flow)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHandleNewFlow_Handle, flow.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleNewFlow_Handle, flow.Handle);
	}

	[Export("handleNewUDPFlow:initialRemoteEndpoint:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandleNewUdpFlow(NEAppProxyUdpFlow flow, NWEndpoint remoteEndpoint)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (remoteEndpoint == null)
		{
			throw new ArgumentNullException("remoteEndpoint");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selHandleNewUDPFlow_InitialRemoteEndpoint_Handle, flow.Handle, remoteEndpoint.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHandleNewUDPFlow_InitialRemoteEndpoint_Handle, flow.Handle, remoteEndpoint.Handle);
	}

	[Export("startProxyWithOptions:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartProxy(NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartProxyWithOptions_CompletionHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartProxyWithOptions_CompletionHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StartProxyAsync(NSDictionary? options)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StartProxy(options, delegate(NSError obj_)
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

	[Export("stopProxyWithReason:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StopProxy(NEProviderStopReason reason, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
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
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selStopProxyWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selStopProxyWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StopProxyAsync(NEProviderStopReason reason)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StopProxy(reason, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}

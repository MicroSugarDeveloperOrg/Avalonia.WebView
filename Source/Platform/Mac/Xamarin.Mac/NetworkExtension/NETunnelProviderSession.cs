using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NETunnelProviderSession", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NETunnelProviderSession : NEVpnConnection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendProviderMessage_ReturnError_ResponseHandler_ = "sendProviderMessage:returnError:responseHandler:";

	private static readonly IntPtr selSendProviderMessage_ReturnError_ResponseHandler_Handle = Selector.GetHandle("sendProviderMessage:returnError:responseHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTunnelWithOptions_AndReturnError_ = "startTunnelWithOptions:andReturnError:";

	private static readonly IntPtr selStartTunnelWithOptions_AndReturnError_Handle = Selector.GetHandle("startTunnelWithOptions:andReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopTunnel = "stopTunnel";

	private static readonly IntPtr selStopTunnelHandle = Selector.GetHandle("stopTunnel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NETunnelProviderSession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NETunnelProviderSession()
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
	protected NETunnelProviderSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NETunnelProviderSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sendProviderMessage:returnError:responseHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool SendProviderMessage(NSData messageData, out NSError? error, [BlockProxy(typeof(Trampolines.NIDActionArity1V28))] Action<NSData>? responseHandler)
	{
		if (messageData == null)
		{
			throw new ArgumentNullException("messageData");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral* ptr;
		if (responseHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V28.Handler, responseHandler);
		}
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr(base.SuperHandle, selSendProviderMessage_ReturnError_ResponseHandler_Handle, messageData.Handle, ref arg, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr(base.Handle, selSendProviderMessage_ReturnError_ResponseHandler_Handle, messageData.Handle, ref arg, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("startTunnelWithOptions:andReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartTunnel(NSDictionary<NSString, NSObject>? options, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStartTunnelWithOptions_AndReturnError_Handle, options?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStartTunnelWithOptions_AndReturnError_Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("stopTunnel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopTunnel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopTunnelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopTunnelHandle);
		}
	}
}

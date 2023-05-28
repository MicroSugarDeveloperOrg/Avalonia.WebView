using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEProvider", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEProvider : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTCPConnectionToEndpoint_EnableTLS_TLSParameters_Delegate_ = "createTCPConnectionToEndpoint:enableTLS:TLSParameters:delegate:";

	private static readonly IntPtr selCreateTCPConnectionToEndpoint_EnableTLS_TLSParameters_Delegate_Handle = Selector.GetHandle("createTCPConnectionToEndpoint:enableTLS:TLSParameters:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateUDPSessionToEndpoint_FromEndpoint_ = "createUDPSessionToEndpoint:fromEndpoint:";

	private static readonly IntPtr selCreateUDPSessionToEndpoint_FromEndpoint_Handle = Selector.GetHandle("createUDPSessionToEndpoint:fromEndpoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultPath = "defaultPath";

	private static readonly IntPtr selDefaultPathHandle = Selector.GetHandle("defaultPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayMessage_CompletionHandler_ = "displayMessage:completionHandler:";

	private static readonly IntPtr selDisplayMessage_CompletionHandler_Handle = Selector.GetHandle("displayMessage:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSleepWithCompletionHandler_ = "sleepWithCompletionHandler:";

	private static readonly IntPtr selSleepWithCompletionHandler_Handle = Selector.GetHandle("sleepWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSystemExtensionMode = "startSystemExtensionMode";

	private static readonly IntPtr selStartSystemExtensionModeHandle = Selector.GetHandle("startSystemExtensionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWake = "wake";

	private static readonly IntPtr selWakeHandle = Selector.GetHandle("wake");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWPath? DefaultPath
	{
		[Export("defaultPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultPathHandle));
			}
			return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createTCPConnectionToEndpoint:enableTLS:TLSParameters:delegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWTcpConnection CreateTcpConnectionToEndpoint(NWEndpoint remoteEndpoint, bool enableTLS, NWTlsParameters? TLSParameters, NSObject? connectionDelegate)
	{
		if (remoteEndpoint == null)
		{
			throw new ArgumentNullException("remoteEndpoint");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NWTcpConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr_IntPtr(base.Handle, selCreateTCPConnectionToEndpoint_EnableTLS_TLSParameters_Delegate_Handle, remoteEndpoint.Handle, enableTLS, TLSParameters?.Handle ?? IntPtr.Zero, connectionDelegate?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NWTcpConnection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr(base.SuperHandle, selCreateTCPConnectionToEndpoint_EnableTLS_TLSParameters_Delegate_Handle, remoteEndpoint.Handle, enableTLS, TLSParameters?.Handle ?? IntPtr.Zero, connectionDelegate?.Handle ?? IntPtr.Zero));
	}

	[Export("createUDPSessionToEndpoint:fromEndpoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWUdpSession CreateUdpSessionToEndpoint(NWEndpoint remoteEndpoint, NWHostEndpoint? localEndpoint)
	{
		if (remoteEndpoint == null)
		{
			throw new ArgumentNullException("remoteEndpoint");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NWUdpSession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateUDPSessionToEndpoint_FromEndpoint_Handle, remoteEndpoint.Handle, localEndpoint?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NWUdpSession>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateUDPSessionToEndpoint_FromEndpoint_Handle, remoteEndpoint.Handle, localEndpoint?.Handle ?? IntPtr.Zero));
	}

	[Export("displayMessage:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DisplayMessage(string message, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(message);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDisplayMessage_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDisplayMessage_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> DisplayMessageAsync(string message)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DisplayMessage(message, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("sleepWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Sleep([BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
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
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSleepWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSleepWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SleepAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Sleep(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("startSystemExtensionMode")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StartSystemExtensionMode()
	{
		Messaging.void_objc_msgSend(class_ptr, selStartSystemExtensionModeHandle);
	}

	[Export("wake")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Wake()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWakeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWakeHandle);
		}
	}
}

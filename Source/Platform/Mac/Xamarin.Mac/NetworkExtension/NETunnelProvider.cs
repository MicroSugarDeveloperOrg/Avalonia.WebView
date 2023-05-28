using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NETunnelProvider", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NETunnelProvider : NEProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppRules = "appRules";

	private static readonly IntPtr selAppRulesHandle = Selector.GetHandle("appRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleAppMessage_CompletionHandler_ = "handleAppMessage:completionHandler:";

	private static readonly IntPtr selHandleAppMessage_CompletionHandler_Handle = Selector.GetHandle("handleAppMessage:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocolConfiguration = "protocolConfiguration";

	private static readonly IntPtr selProtocolConfigurationHandle = Selector.GetHandle("protocolConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReasserting = "reasserting";

	private static readonly IntPtr selReassertingHandle = Selector.GetHandle("reasserting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoutingMethod = "routingMethod";

	private static readonly IntPtr selRoutingMethodHandle = Selector.GetHandle("routingMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReasserting_ = "setReasserting:";

	private static readonly IntPtr selSetReasserting_Handle = Selector.GetHandle("setReasserting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTunnelNetworkSettings_CompletionHandler_ = "setTunnelNetworkSettings:completionHandler:";

	private static readonly IntPtr selSetTunnelNetworkSettings_CompletionHandler_Handle = Selector.GetHandle("setTunnelNetworkSettings:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NETunnelProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEAppRule[]? AppRules
	{
		[Export("appRules")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppRulesHandle));
			}
			return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppRulesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnProtocol ProtocolConfiguration
	{
		[Export("protocolConfiguration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolConfigurationHandle));
			}
			return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Reasserting
	{
		[Export("reasserting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReassertingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReassertingHandle);
		}
		[Export("setReasserting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReasserting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReasserting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NETunnelProviderRoutingMethod RoutingMethod
	{
		[Export("routingMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NETunnelProviderRoutingMethod)Messaging.Int64_objc_msgSend(base.Handle, selRoutingMethodHandle);
			}
			return (NETunnelProviderRoutingMethod)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRoutingMethodHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NETunnelProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NETunnelProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("handleAppMessage:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HandleAppMessage(NSData messageData, [BlockProxy(typeof(Trampolines.NIDActionArity1V28))] Action<NSData>? completionHandler)
	{
		if (messageData == null)
		{
			throw new ArgumentNullException("messageData");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V28.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selHandleAppMessage_CompletionHandler_Handle, messageData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHandleAppMessage_CompletionHandler_Handle, messageData.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> HandleAppMessageAsync(NSData messageData)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		HandleAppMessage(messageData, delegate(NSData obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("setTunnelNetworkSettings:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetTunnelNetworkSettings(NETunnelNetworkSettings? tunnelNetworkSettings, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetTunnelNetworkSettings_CompletionHandler_Handle, tunnelNetworkSettings?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetTunnelNetworkSettings_CompletionHandler_Handle, tunnelNetworkSettings?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetTunnelNetworkSettingsAsync(NETunnelNetworkSettings? tunnelNetworkSettings)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetTunnelNetworkSettings(tunnelNetworkSettings, delegate(NSError obj_)
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
}

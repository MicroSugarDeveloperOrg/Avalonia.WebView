using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

[Register("NENetworkRule", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NENetworkRule : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDestinationHost_Protocol_ = "initWithDestinationHost:protocol:";

	private static readonly IntPtr selInitWithDestinationHost_Protocol_Handle = Selector.GetHandle("initWithDestinationHost:protocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDestinationNetwork_Prefix_Protocol_ = "initWithDestinationNetwork:prefix:protocol:";

	private static readonly IntPtr selInitWithDestinationNetwork_Prefix_Protocol_Handle = Selector.GetHandle("initWithDestinationNetwork:prefix:protocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_ = "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:";

	private static readonly IntPtr selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_Handle = Selector.GetHandle("initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchDirection = "matchDirection";

	private static readonly IntPtr selMatchDirectionHandle = Selector.GetHandle("matchDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchLocalNetwork = "matchLocalNetwork";

	private static readonly IntPtr selMatchLocalNetworkHandle = Selector.GetHandle("matchLocalNetwork");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchLocalPrefix = "matchLocalPrefix";

	private static readonly IntPtr selMatchLocalPrefixHandle = Selector.GetHandle("matchLocalPrefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchProtocol = "matchProtocol";

	private static readonly IntPtr selMatchProtocolHandle = Selector.GetHandle("matchProtocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchRemoteEndpoint = "matchRemoteEndpoint";

	private static readonly IntPtr selMatchRemoteEndpointHandle = Selector.GetHandle("matchRemoteEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchRemotePrefix = "matchRemotePrefix";

	private static readonly IntPtr selMatchRemotePrefixHandle = Selector.GetHandle("matchRemotePrefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NENetworkRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NETrafficDirection MatchDirection
	{
		[Export("matchDirection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NETrafficDirection)Messaging.Int64_objc_msgSend(base.Handle, selMatchDirectionHandle);
			}
			return (NETrafficDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMatchDirectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWHostEndpoint? MatchLocalNetwork
	{
		[Export("matchLocalNetwork")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWHostEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchLocalNetworkHandle));
			}
			return Runtime.GetNSObject<NWHostEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchLocalNetworkHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MatchLocalPrefix
	{
		[Export("matchLocalPrefix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMatchLocalPrefixHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMatchLocalPrefixHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NENetworkRuleProtocol MatchProtocol
	{
		[Export("matchProtocol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NENetworkRuleProtocol)Messaging.Int64_objc_msgSend(base.Handle, selMatchProtocolHandle);
			}
			return (NENetworkRuleProtocol)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMatchProtocolHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWHostEndpoint? MatchRemoteEndpoint
	{
		[Export("matchRemoteEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWHostEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchRemoteEndpointHandle));
			}
			return Runtime.GetNSObject<NWHostEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchRemoteEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MatchRemotePrefix
	{
		[Export("matchRemotePrefix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMatchRemotePrefixHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMatchRemotePrefixHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NENetworkRule(NSCoder coder)
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
	protected NENetworkRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NENetworkRule(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDestinationNetwork:prefix:protocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NENetworkRule(NWHostEndpoint networkEndpoint, nuint destinationPrefix, NENetworkRuleProtocol protocol)
		: base(NSObjectFlag.Empty)
	{
		if (networkEndpoint == null)
		{
			throw new ArgumentNullException("networkEndpoint");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Int64(base.Handle, selInitWithDestinationNetwork_Prefix_Protocol_Handle, networkEndpoint.Handle, destinationPrefix, (long)protocol), "initWithDestinationNetwork:prefix:protocol:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_Int64(base.SuperHandle, selInitWithDestinationNetwork_Prefix_Protocol_Handle, networkEndpoint.Handle, destinationPrefix, (long)protocol), "initWithDestinationNetwork:prefix:protocol:");
		}
	}

	[Export("initWithDestinationHost:protocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NENetworkRule(NWHostEndpoint hostEndpoint, NENetworkRuleProtocol protocol)
		: base(NSObjectFlag.Empty)
	{
		if (hostEndpoint == null)
		{
			throw new ArgumentNullException("hostEndpoint");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selInitWithDestinationHost_Protocol_Handle, hostEndpoint.Handle, (long)protocol), "initWithDestinationHost:protocol:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInitWithDestinationHost_Protocol_Handle, hostEndpoint.Handle, (long)protocol), "initWithDestinationHost:protocol:");
		}
	}

	[Export("initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NENetworkRule(NWHostEndpoint? remoteNetwork, nuint remotePrefix, NWHostEndpoint? localNetwork, nuint localPrefix, NENetworkRuleProtocol protocol, NETrafficDirection direction)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_nuint_Int64_Int64(base.Handle, selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_Handle, remoteNetwork?.Handle ?? IntPtr.Zero, remotePrefix, localNetwork?.Handle ?? IntPtr.Zero, localPrefix, (long)protocol, (long)direction), "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint_Int64_Int64(base.SuperHandle, selInitWithRemoteNetwork_RemotePrefix_LocalNetwork_LocalPrefix_Protocol_Direction_Handle, remoteNetwork?.Handle ?? IntPtr.Zero, remotePrefix, localNetwork?.Handle ?? IntPtr.Zero, localPrefix, (long)protocol, (long)direction), "initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}

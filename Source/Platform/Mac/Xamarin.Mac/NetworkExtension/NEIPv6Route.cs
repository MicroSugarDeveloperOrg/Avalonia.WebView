using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEIPv6Route", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEIPv6Route : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultRoute = "defaultRoute";

	private static readonly IntPtr selDefaultRouteHandle = Selector.GetHandle("defaultRoute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationAddress = "destinationAddress";

	private static readonly IntPtr selDestinationAddressHandle = Selector.GetHandle("destinationAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationNetworkPrefixLength = "destinationNetworkPrefixLength";

	private static readonly IntPtr selDestinationNetworkPrefixLengthHandle = Selector.GetHandle("destinationNetworkPrefixLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGatewayAddress = "gatewayAddress";

	private static readonly IntPtr selGatewayAddressHandle = Selector.GetHandle("gatewayAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDestinationAddress_NetworkPrefixLength_ = "initWithDestinationAddress:networkPrefixLength:";

	private static readonly IntPtr selInitWithDestinationAddress_NetworkPrefixLength_Handle = Selector.GetHandle("initWithDestinationAddress:networkPrefixLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGatewayAddress_ = "setGatewayAddress:";

	private static readonly IntPtr selSetGatewayAddress_Handle = Selector.GetHandle("setGatewayAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEIPv6Route");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEIPv6Route DefaultRoute
	{
		[Export("defaultRoute")]
		get
		{
			return Runtime.GetNSObject<NEIPv6Route>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultRouteHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DestinationAddress
	{
		[Export("destinationAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber DestinationNetworkPrefixLength
	{
		[Export("destinationNetworkPrefixLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationNetworkPrefixLengthHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationNetworkPrefixLengthHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GatewayAddress
	{
		[Export("gatewayAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGatewayAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGatewayAddressHandle));
		}
		[Export("setGatewayAddress:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGatewayAddress_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGatewayAddress_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NEIPv6Route(NSCoder coder)
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
	protected NEIPv6Route(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEIPv6Route(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDestinationAddress:networkPrefixLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NEIPv6Route(string address, NSNumber networkPrefixLength)
		: base(NSObjectFlag.Empty)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (networkPrefixLength == null)
		{
			throw new ArgumentNullException("networkPrefixLength");
		}
		IntPtr arg = NSString.CreateNative(address);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDestinationAddress_NetworkPrefixLength_Handle, arg, networkPrefixLength.Handle), "initWithDestinationAddress:networkPrefixLength:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDestinationAddress_NetworkPrefixLength_Handle, arg, networkPrefixLength.Handle), "initWithDestinationAddress:networkPrefixLength:");
		}
		NSString.ReleaseNative(arg);
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

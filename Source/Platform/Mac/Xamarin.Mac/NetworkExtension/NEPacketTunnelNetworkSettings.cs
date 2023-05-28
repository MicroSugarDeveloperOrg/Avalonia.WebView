using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEPacketTunnelNetworkSettings", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEPacketTunnelNetworkSettings : NETunnelNetworkSettings
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIPv4Settings = "IPv4Settings";

	private static readonly IntPtr selIPv4SettingsHandle = Selector.GetHandle("IPv4Settings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIPv6Settings = "IPv6Settings";

	private static readonly IntPtr selIPv6SettingsHandle = Selector.GetHandle("IPv6Settings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMTU = "MTU";

	private static readonly IntPtr selMTUHandle = Selector.GetHandle("MTU");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTunnelRemoteAddress_ = "initWithTunnelRemoteAddress:";

	private static readonly IntPtr selInitWithTunnelRemoteAddress_Handle = Selector.GetHandle("initWithTunnelRemoteAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIPv4Settings_ = "setIPv4Settings:";

	private static readonly IntPtr selSetIPv4Settings_Handle = Selector.GetHandle("setIPv4Settings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIPv6Settings_ = "setIPv6Settings:";

	private static readonly IntPtr selSetIPv6Settings_Handle = Selector.GetHandle("setIPv6Settings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMTU_ = "setMTU:";

	private static readonly IntPtr selSetMTU_Handle = Selector.GetHandle("setMTU:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTunnelOverheadBytes_ = "setTunnelOverheadBytes:";

	private static readonly IntPtr selSetTunnelOverheadBytes_Handle = Selector.GetHandle("setTunnelOverheadBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTunnelOverheadBytes = "tunnelOverheadBytes";

	private static readonly IntPtr selTunnelOverheadBytesHandle = Selector.GetHandle("tunnelOverheadBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEPacketTunnelNetworkSettings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEIPv4Settings? IPv4Settings
	{
		[Export("IPv4Settings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEIPv4Settings>(Messaging.IntPtr_objc_msgSend(base.Handle, selIPv4SettingsHandle));
			}
			return Runtime.GetNSObject<NEIPv4Settings>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIPv4SettingsHandle));
		}
		[Export("setIPv4Settings:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIPv4Settings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIPv4Settings_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEIPv6Settings? IPv6Settings
	{
		[Export("IPv6Settings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEIPv6Settings>(Messaging.IntPtr_objc_msgSend(base.Handle, selIPv6SettingsHandle));
			}
			return Runtime.GetNSObject<NEIPv6Settings>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIPv6SettingsHandle));
		}
		[Export("setIPv6Settings:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIPv6Settings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIPv6Settings_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? Mtu
	{
		[Export("MTU", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMTUHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMTUHandle));
		}
		[Export("setMTU:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMTU_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMTU_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? TunnelOverheadBytes
	{
		[Export("tunnelOverheadBytes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selTunnelOverheadBytesHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTunnelOverheadBytesHandle));
		}
		[Export("setTunnelOverheadBytes:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTunnelOverheadBytes_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTunnelOverheadBytes_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Obsolete("This constructor does not create a valid instance of the type.")]
	public NEPacketTunnelNetworkSettings()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NEPacketTunnelNetworkSettings(NSCoder coder)
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
	protected NEPacketTunnelNetworkSettings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEPacketTunnelNetworkSettings(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTunnelRemoteAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NEPacketTunnelNetworkSettings(string address)
		: base(NSObjectFlag.Empty)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		IntPtr arg = NSString.CreateNative(address);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTunnelRemoteAddress_Handle, arg), "initWithTunnelRemoteAddress:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTunnelRemoteAddress_Handle, arg), "initWithTunnelRemoteAddress:");
		}
		NSString.ReleaseNative(arg);
	}
}

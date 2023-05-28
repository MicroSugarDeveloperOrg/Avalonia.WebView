using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NETransparentProxyNetworkSettings", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NETransparentProxyNetworkSettings : NETunnelNetworkSettings
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExcludedNetworkRules = "excludedNetworkRules";

	private static readonly IntPtr selExcludedNetworkRulesHandle = Selector.GetHandle("excludedNetworkRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludedNetworkRules = "includedNetworkRules";

	private static readonly IntPtr selIncludedNetworkRulesHandle = Selector.GetHandle("includedNetworkRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExcludedNetworkRules_ = "setExcludedNetworkRules:";

	private static readonly IntPtr selSetExcludedNetworkRules_Handle = Selector.GetHandle("setExcludedNetworkRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludedNetworkRules_ = "setIncludedNetworkRules:";

	private static readonly IntPtr selSetIncludedNetworkRules_Handle = Selector.GetHandle("setIncludedNetworkRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NETransparentProxyNetworkSettings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NENetworkRule[]? ExcludedNetworkRules
	{
		[Export("excludedNetworkRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NENetworkRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selExcludedNetworkRulesHandle));
			}
			return NSArray.ArrayFromHandle<NENetworkRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExcludedNetworkRulesHandle));
		}
		[Export("setExcludedNetworkRules:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExcludedNetworkRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExcludedNetworkRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NENetworkRule[]? IncludedNetworkRules
	{
		[Export("includedNetworkRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NENetworkRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selIncludedNetworkRulesHandle));
			}
			return NSArray.ArrayFromHandle<NENetworkRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIncludedNetworkRulesHandle));
		}
		[Export("setIncludedNetworkRules:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIncludedNetworkRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIncludedNetworkRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NETransparentProxyNetworkSettings()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NETransparentProxyNetworkSettings(NSCoder coder)
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
	protected NETransparentProxyNetworkSettings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NETransparentProxyNetworkSettings(IntPtr handle)
		: base(handle)
	{
	}
}

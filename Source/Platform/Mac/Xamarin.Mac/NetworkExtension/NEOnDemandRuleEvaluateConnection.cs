using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEOnDemandRuleEvaluateConnection", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NEOnDemandRuleEvaluateConnection : NEOnDemandRule
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionRules = "connectionRules";

	private static readonly IntPtr selConnectionRulesHandle = Selector.GetHandle("connectionRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConnectionRules_ = "setConnectionRules:";

	private static readonly IntPtr selSetConnectionRules_Handle = Selector.GetHandle("setConnectionRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEOnDemandRuleEvaluateConnection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEEvaluateConnectionRule[]? ConnectionRules
	{
		[Export("connectionRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEEvaluateConnectionRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionRulesHandle));
			}
			return NSArray.ArrayFromHandle<NEEvaluateConnectionRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionRulesHandle));
		}
		[Export("setConnectionRules:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConnectionRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConnectionRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEOnDemandRuleEvaluateConnection()
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
	public NEOnDemandRuleEvaluateConnection(NSCoder coder)
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
	protected NEOnDemandRuleEvaluateConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEOnDemandRuleEvaluateConnection(IntPtr handle)
		: base(handle)
	{
	}
}

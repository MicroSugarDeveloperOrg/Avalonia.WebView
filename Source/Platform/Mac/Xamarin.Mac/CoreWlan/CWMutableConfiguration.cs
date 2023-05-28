using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWMutableConfiguration", true)]
public class CWMutableConfiguration : CWConfiguration
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRememberJoinedNetworks = "rememberJoinedNetworks";

	private static readonly IntPtr selRememberJoinedNetworksHandle = Selector.GetHandle("rememberJoinedNetworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdministratorForIBSSMode = "requireAdministratorForIBSSMode";

	private static readonly IntPtr selRequireAdministratorForIBSSModeHandle = Selector.GetHandle("requireAdministratorForIBSSMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdministratorForPower = "requireAdministratorForPower";

	private static readonly IntPtr selRequireAdministratorForPowerHandle = Selector.GetHandle("requireAdministratorForPower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRememberJoinedNetworks_ = "setRememberJoinedNetworks:";

	private static readonly IntPtr selSetRememberJoinedNetworks_Handle = Selector.GetHandle("setRememberJoinedNetworks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequireAdministratorForIBSSMode_ = "setRequireAdministratorForIBSSMode:";

	private static readonly IntPtr selSetRequireAdministratorForIBSSMode_Handle = Selector.GetHandle("setRequireAdministratorForIBSSMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequireAdministratorForPower_ = "setRequireAdministratorForPower:";

	private static readonly IntPtr selSetRequireAdministratorForPower_Handle = Selector.GetHandle("setRequireAdministratorForPower:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CWMutableConfiguration");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool RememberJoinedNetworks
	{
		[Export("rememberJoinedNetworks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRememberJoinedNetworksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRememberJoinedNetworksHandle);
		}
		[Export("setRememberJoinedNetworks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRememberJoinedNetworks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRememberJoinedNetworks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool RequireAdministratorForIbssMode
	{
		[Export("requireAdministratorForIBSSMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdministratorForIBSSModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdministratorForIBSSModeHandle);
		}
		[Export("setRequireAdministratorForIBSSMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdministratorForIBSSMode_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdministratorForIBSSMode_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool RequireAdministratorForPower
	{
		[Export("requireAdministratorForPower")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdministratorForPowerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdministratorForPowerHandle);
		}
		[Export("setRequireAdministratorForPower:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdministratorForPower_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdministratorForPower_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWMutableConfiguration()
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
	public CWMutableConfiguration(NSCoder coder)
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
	protected CWMutableConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWMutableConfiguration(IntPtr handle)
		: base(handle)
	{
	}
}

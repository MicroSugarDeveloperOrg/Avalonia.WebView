using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWConfiguration", true)]
public class CWConfiguration : NSObject
{
	private static readonly IntPtr selRememberedNetworksHandle = Selector.GetHandle("rememberedNetworks");

	private static readonly IntPtr selSetRememberedNetworks_Handle = Selector.GetHandle("setRememberedNetworks:");

	private static readonly IntPtr selPreferredNetworksHandle = Selector.GetHandle("preferredNetworks");

	private static readonly IntPtr selSetPreferredNetworks_Handle = Selector.GetHandle("setPreferredNetworks:");

	private static readonly IntPtr selAlwaysRememberNetworksHandle = Selector.GetHandle("alwaysRememberNetworks");

	private static readonly IntPtr selSetAlwaysRememberNetworks_Handle = Selector.GetHandle("setAlwaysRememberNetworks:");

	private static readonly IntPtr selDisconnectOnLogoutHandle = Selector.GetHandle("disconnectOnLogout");

	private static readonly IntPtr selSetDisconnectOnLogout_Handle = Selector.GetHandle("setDisconnectOnLogout:");

	private static readonly IntPtr selRequireAdminForNetworkChangeHandle = Selector.GetHandle("requireAdminForNetworkChange");

	private static readonly IntPtr selSetRequireAdminForNetworkChange_Handle = Selector.GetHandle("setRequireAdminForNetworkChange:");

	private static readonly IntPtr selRequireAdminForPowerChangeHandle = Selector.GetHandle("requireAdminForPowerChange");

	private static readonly IntPtr selSetRequireAdminForPowerChange_Handle = Selector.GetHandle("setRequireAdminForPowerChange:");

	private static readonly IntPtr selRequireAdminForIBSSCreationHandle = Selector.GetHandle("requireAdminForIBSSCreation");

	private static readonly IntPtr selSetRequireAdminForIBSSCreation_Handle = Selector.GetHandle("setRequireAdminForIBSSCreation:");

	private static readonly IntPtr selIsEqualToConfiguration_Handle = Selector.GetHandle("isEqualToConfiguration:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CWConfiguration");

	private object __mt_RememberedNetworks_var;

	private object __mt_PreferredNetworks_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSSet RememberedNetworks
	{
		[Export("rememberedNetworks")]
		get
		{
			return (NSSet)(__mt_RememberedNetworks_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRememberedNetworksHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRememberedNetworksHandle)))));
		}
		[Export("setRememberedNetworks:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRememberedNetworks_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRememberedNetworks_Handle, value.Handle);
			}
			__mt_RememberedNetworks_var = value;
		}
	}

	public virtual CWWirelessProfile[] PreferredNetworks
	{
		[Export("preferredNetworks")]
		get
		{
			return (CWWirelessProfile[])(__mt_PreferredNetworks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CWWirelessProfile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredNetworksHandle)) : NSArray.ArrayFromHandle<CWWirelessProfile>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredNetworksHandle))));
		}
		[Export("setPreferredNetworks:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferredNetworks_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferredNetworks_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_PreferredNetworks_var = value;
		}
	}

	public virtual bool AlwaysRememberNetworks
	{
		[Export("alwaysRememberNetworks")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysRememberNetworksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysRememberNetworksHandle);
		}
		[Export("setAlwaysRememberNetworks:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysRememberNetworks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysRememberNetworks_Handle, value);
			}
		}
	}

	public virtual bool DisconnectOnLogout
	{
		[Export("disconnectOnLogout")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisconnectOnLogoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisconnectOnLogoutHandle);
		}
		[Export("setDisconnectOnLogout:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisconnectOnLogout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisconnectOnLogout_Handle, value);
			}
		}
	}

	public virtual bool RequireAdminForNetworkChange
	{
		[Export("requireAdminForNetworkChange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForNetworkChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForNetworkChangeHandle);
		}
		[Export("setRequireAdminForNetworkChange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForNetworkChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForNetworkChange_Handle, value);
			}
		}
	}

	public virtual bool RequireAdminForPowerChange
	{
		[Export("requireAdminForPowerChange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForPowerChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForPowerChangeHandle);
		}
		[Export("setRequireAdminForPowerChange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForPowerChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForPowerChange_Handle, value);
			}
		}
	}

	public virtual bool RequireAdminForIBSSCreation
	{
		[Export("requireAdminForIBSSCreation")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForIBSSCreationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForIBSSCreationHandle);
		}
		[Export("setRequireAdminForIBSSCreation:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForIBSSCreation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForIBSSCreation_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWConfiguration()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CWConfiguration(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CWConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CWConfiguration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isEqualToConfiguration:")]
	public virtual bool IsEqualToConfiguration(CWConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToConfiguration_Handle, configuration.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToConfiguration_Handle, configuration.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RememberedNetworks_var = null;
			__mt_PreferredNetworks_var = null;
		}
	}
}

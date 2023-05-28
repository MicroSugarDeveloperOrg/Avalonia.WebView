using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWConfiguration", true)]
public class CWConfiguration : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysRememberNetworks = "alwaysRememberNetworks";

	private static readonly IntPtr selAlwaysRememberNetworksHandle = Selector.GetHandle("alwaysRememberNetworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectOnLogout = "disconnectOnLogout";

	private static readonly IntPtr selDisconnectOnLogoutHandle = Selector.GetHandle("disconnectOnLogout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithConfiguration_ = "initWithConfiguration:";

	private static readonly IntPtr selInitWithConfiguration_Handle = Selector.GetHandle("initWithConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToConfiguration_ = "isEqualToConfiguration:";

	private static readonly IntPtr selIsEqualToConfiguration_Handle = Selector.GetHandle("isEqualToConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNetworkProfiles = "networkProfiles";

	private static readonly IntPtr selNetworkProfilesHandle = Selector.GetHandle("networkProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredNetworks = "preferredNetworks";

	private static readonly IntPtr selPreferredNetworksHandle = Selector.GetHandle("preferredNetworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRememberJoinedNetworks = "rememberJoinedNetworks";

	private static readonly IntPtr selRememberJoinedNetworksHandle = Selector.GetHandle("rememberJoinedNetworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRememberedNetworks = "rememberedNetworks";

	private static readonly IntPtr selRememberedNetworksHandle = Selector.GetHandle("rememberedNetworks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdminForIBSSCreation = "requireAdminForIBSSCreation";

	private static readonly IntPtr selRequireAdminForIBSSCreationHandle = Selector.GetHandle("requireAdminForIBSSCreation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdminForNetworkChange = "requireAdminForNetworkChange";

	private static readonly IntPtr selRequireAdminForNetworkChangeHandle = Selector.GetHandle("requireAdminForNetworkChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdminForPowerChange = "requireAdminForPowerChange";

	private static readonly IntPtr selRequireAdminForPowerChangeHandle = Selector.GetHandle("requireAdminForPowerChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdministratorForAssociation = "requireAdministratorForAssociation";

	private static readonly IntPtr selRequireAdministratorForAssociationHandle = Selector.GetHandle("requireAdministratorForAssociation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdministratorForIBSSMode = "requireAdministratorForIBSSMode";

	private static readonly IntPtr selRequireAdministratorForIBSSModeHandle = Selector.GetHandle("requireAdministratorForIBSSMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequireAdministratorForPower = "requireAdministratorForPower";

	private static readonly IntPtr selRequireAdministratorForPowerHandle = Selector.GetHandle("requireAdministratorForPower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysRememberNetworks_ = "setAlwaysRememberNetworks:";

	private static readonly IntPtr selSetAlwaysRememberNetworks_Handle = Selector.GetHandle("setAlwaysRememberNetworks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisconnectOnLogout_ = "setDisconnectOnLogout:";

	private static readonly IntPtr selSetDisconnectOnLogout_Handle = Selector.GetHandle("setDisconnectOnLogout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredNetworks_ = "setPreferredNetworks:";

	private static readonly IntPtr selSetPreferredNetworks_Handle = Selector.GetHandle("setPreferredNetworks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRememberedNetworks_ = "setRememberedNetworks:";

	private static readonly IntPtr selSetRememberedNetworks_Handle = Selector.GetHandle("setRememberedNetworks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequireAdminForIBSSCreation_ = "setRequireAdminForIBSSCreation:";

	private static readonly IntPtr selSetRequireAdminForIBSSCreation_Handle = Selector.GetHandle("setRequireAdminForIBSSCreation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequireAdminForNetworkChange_ = "setRequireAdminForNetworkChange:";

	private static readonly IntPtr selSetRequireAdminForNetworkChange_Handle = Selector.GetHandle("setRequireAdminForNetworkChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequireAdminForPowerChange_ = "setRequireAdminForPowerChange:";

	private static readonly IntPtr selSetRequireAdminForPowerChange_Handle = Selector.GetHandle("setRequireAdminForPowerChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CWConfiguration");

	public CWNetworkProfile[] NetworkProfiles
	{
		get
		{
			NSOrderedSet networkProfiles = _NetworkProfiles;
			if (networkProfiles != null)
			{
				return networkProfiles.ToArray<CWNetworkProfile>();
			}
			return null;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool AlwaysRememberNetworks
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("alwaysRememberNetworks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysRememberNetworksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysRememberNetworksHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAlwaysRememberNetworks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysRememberNetworks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysRememberNetworks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool DisconnectOnLogout
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("disconnectOnLogout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisconnectOnLogoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisconnectOnLogoutHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setDisconnectOnLogout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisconnectOnLogout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisconnectOnLogout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CWWirelessProfile[] PreferredNetworks
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("preferredNetworks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CWWirelessProfile>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredNetworksHandle));
			}
			return NSArray.ArrayFromHandle<CWWirelessProfile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredNetworksHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setPreferredNetworks:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferredNetworks_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferredNetworks_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RememberJoinedNetworks
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSSet RememberedNetworks
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("rememberedNetworks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selRememberedNetworksHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRememberedNetworksHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRememberedNetworks:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRememberedNetworks_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRememberedNetworks_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool RequireAdminForIBSSCreation
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("requireAdminForIBSSCreation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForIBSSCreationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForIBSSCreationHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRequireAdminForIBSSCreation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForIBSSCreation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForIBSSCreation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool RequireAdminForNetworkChange
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("requireAdminForNetworkChange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForNetworkChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForNetworkChangeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRequireAdminForNetworkChange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForNetworkChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForNetworkChange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool RequireAdminForPowerChange
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("requireAdminForPowerChange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdminForPowerChangeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdminForPowerChangeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRequireAdminForPowerChange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequireAdminForPowerChange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequireAdminForPowerChange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RequireAdministratorForAssociation
	{
		[Export("requireAdministratorForAssociation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequireAdministratorForAssociationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequireAdministratorForAssociationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RequireAdministratorForIbssMode
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RequireAdministratorForPower
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSOrderedSet _NetworkProfiles
	{
		[Export("networkProfiles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOrderedSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selNetworkProfilesHandle));
			}
			return Runtime.GetNSObject<NSOrderedSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNetworkProfilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWConfiguration()
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
	public CWConfiguration(NSCoder coder)
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
	protected CWConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWConfiguration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CWConfiguration(CWConfiguration configuration)
		: base(NSObjectFlag.Empty)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithConfiguration_Handle, configuration.Handle), "initWithConfiguration:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithConfiguration_Handle, configuration.Handle), "initWithConfiguration:");
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

	[Export("configuration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CWConfiguration Create()
	{
		return Runtime.GetNSObject<CWConfiguration>(Messaging.IntPtr_objc_msgSend(class_ptr, selConfigurationHandle));
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

	[Export("isEqualToConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToConfiguration(CWConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToConfiguration_Handle, configuration.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToConfiguration_Handle, configuration.Handle);
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEVPNProtocolIKEv2", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NEVpnProtocolIke2 : NEVpnProtocolIpSec
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIKESecurityAssociationParameters = "IKESecurityAssociationParameters";

	private static readonly IntPtr selIKESecurityAssociationParametersHandle = Selector.GetHandle("IKESecurityAssociationParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCertificateType = "certificateType";

	private static readonly IntPtr selCertificateTypeHandle = Selector.GetHandle("certificateType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildSecurityAssociationParameters = "childSecurityAssociationParameters";

	private static readonly IntPtr selChildSecurityAssociationParametersHandle = Selector.GetHandle("childSecurityAssociationParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeadPeerDetectionRate = "deadPeerDetectionRate";

	private static readonly IntPtr selDeadPeerDetectionRateHandle = Selector.GetHandle("deadPeerDetectionRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableMOBIKE = "disableMOBIKE";

	private static readonly IntPtr selDisableMOBIKEHandle = Selector.GetHandle("disableMOBIKE");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableRedirect = "disableRedirect";

	private static readonly IntPtr selDisableRedirectHandle = Selector.GetHandle("disableRedirect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnablePFS = "enablePFS";

	private static readonly IntPtr selEnablePFSHandle = Selector.GetHandle("enablePFS");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableRevocationCheck = "enableRevocationCheck";

	private static readonly IntPtr selEnableRevocationCheckHandle = Selector.GetHandle("enableRevocationCheck");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumTLSVersion = "maximumTLSVersion";

	private static readonly IntPtr selMaximumTLSVersionHandle = Selector.GetHandle("maximumTLSVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumTLSVersion = "minimumTLSVersion";

	private static readonly IntPtr selMinimumTLSVersionHandle = Selector.GetHandle("minimumTLSVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServerCertificateCommonName = "serverCertificateCommonName";

	private static readonly IntPtr selServerCertificateCommonNameHandle = Selector.GetHandle("serverCertificateCommonName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServerCertificateIssuerCommonName = "serverCertificateIssuerCommonName";

	private static readonly IntPtr selServerCertificateIssuerCommonNameHandle = Selector.GetHandle("serverCertificateIssuerCommonName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCertificateType_ = "setCertificateType:";

	private static readonly IntPtr selSetCertificateType_Handle = Selector.GetHandle("setCertificateType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeadPeerDetectionRate_ = "setDeadPeerDetectionRate:";

	private static readonly IntPtr selSetDeadPeerDetectionRate_Handle = Selector.GetHandle("setDeadPeerDetectionRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisableMOBIKE_ = "setDisableMOBIKE:";

	private static readonly IntPtr selSetDisableMOBIKE_Handle = Selector.GetHandle("setDisableMOBIKE:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisableRedirect_ = "setDisableRedirect:";

	private static readonly IntPtr selSetDisableRedirect_Handle = Selector.GetHandle("setDisableRedirect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnablePFS_ = "setEnablePFS:";

	private static readonly IntPtr selSetEnablePFS_Handle = Selector.GetHandle("setEnablePFS:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnableRevocationCheck_ = "setEnableRevocationCheck:";

	private static readonly IntPtr selSetEnableRevocationCheck_Handle = Selector.GetHandle("setEnableRevocationCheck:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumTLSVersion_ = "setMaximumTLSVersion:";

	private static readonly IntPtr selSetMaximumTLSVersion_Handle = Selector.GetHandle("setMaximumTLSVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumTLSVersion_ = "setMinimumTLSVersion:";

	private static readonly IntPtr selSetMinimumTLSVersion_Handle = Selector.GetHandle("setMinimumTLSVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetServerCertificateCommonName_ = "setServerCertificateCommonName:";

	private static readonly IntPtr selSetServerCertificateCommonName_Handle = Selector.GetHandle("setServerCertificateCommonName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetServerCertificateIssuerCommonName_ = "setServerCertificateIssuerCommonName:";

	private static readonly IntPtr selSetServerCertificateIssuerCommonName_Handle = Selector.GetHandle("setServerCertificateIssuerCommonName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrictRevocationCheck_ = "setStrictRevocationCheck:";

	private static readonly IntPtr selSetStrictRevocationCheck_Handle = Selector.GetHandle("setStrictRevocationCheck:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUseConfigurationAttributeInternalIPSubnet_ = "setUseConfigurationAttributeInternalIPSubnet:";

	private static readonly IntPtr selSetUseConfigurationAttributeInternalIPSubnet_Handle = Selector.GetHandle("setUseConfigurationAttributeInternalIPSubnet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrictRevocationCheck = "strictRevocationCheck";

	private static readonly IntPtr selStrictRevocationCheckHandle = Selector.GetHandle("strictRevocationCheck");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseConfigurationAttributeInternalIPSubnet = "useConfigurationAttributeInternalIPSubnet";

	private static readonly IntPtr selUseConfigurationAttributeInternalIPSubnetHandle = Selector.GetHandle("useConfigurationAttributeInternalIPSubnet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEVPNProtocolIKEv2");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NEVpnIke2CertificateType CertificateType
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("certificateType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIke2CertificateType)Messaging.Int64_objc_msgSend(base.Handle, selCertificateTypeHandle);
			}
			return (NEVpnIke2CertificateType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCertificateTypeHandle);
		}
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCertificateType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCertificateType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCertificateType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2SecurityAssociationParameters ChildSecurityAssociationParameters
	{
		[Export("childSecurityAssociationParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildSecurityAssociationParametersHandle));
			}
			return Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildSecurityAssociationParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2DeadPeerDetectionRate DeadPeerDetectionRate
	{
		[Export("deadPeerDetectionRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIke2DeadPeerDetectionRate)Messaging.Int64_objc_msgSend(base.Handle, selDeadPeerDetectionRateHandle);
			}
			return (NEVpnIke2DeadPeerDetectionRate)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDeadPeerDetectionRateHandle);
		}
		[Export("setDeadPeerDetectionRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDeadPeerDetectionRate_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDeadPeerDetectionRate_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool DisableMobike
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("disableMOBIKE")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisableMOBIKEHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisableMOBIKEHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDisableMOBIKE:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisableMOBIKE_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisableMOBIKE_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool DisableRedirect
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("disableRedirect")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisableRedirectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisableRedirectHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDisableRedirect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisableRedirect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisableRedirect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool EnablePfs
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("enablePFS")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnablePFSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnablePFSHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setEnablePFS:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnablePFS_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnablePFS_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool EnableRevocationCheck
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("enableRevocationCheck")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableRevocationCheckHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableRevocationCheckHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setEnableRevocationCheck:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableRevocationCheck_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableRevocationCheck_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2SecurityAssociationParameters IKESecurityAssociationParameters
	{
		[Export("IKESecurityAssociationParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selIKESecurityAssociationParametersHandle));
			}
			return Runtime.GetNSObject<NEVpnIke2SecurityAssociationParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIKESecurityAssociationParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NEVpnIkev2TlsVersion MaximumTlsVersion
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("maximumTLSVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIkev2TlsVersion)Messaging.Int64_objc_msgSend(base.Handle, selMaximumTLSVersionHandle);
			}
			return (NEVpnIkev2TlsVersion)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaximumTLSVersionHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setMaximumTLSVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaximumTLSVersion_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaximumTLSVersion_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NEVpnIkev2TlsVersion MinimumTlsVersion
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("minimumTLSVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIkev2TlsVersion)Messaging.Int64_objc_msgSend(base.Handle, selMinimumTLSVersionHandle);
			}
			return (NEVpnIkev2TlsVersion)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMinimumTLSVersionHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setMinimumTLSVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMinimumTLSVersion_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMinimumTLSVersion_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ServerCertificateCommonName
	{
		[Export("serverCertificateCommonName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServerCertificateCommonNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerCertificateCommonNameHandle));
		}
		[Export("setServerCertificateCommonName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetServerCertificateCommonName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetServerCertificateCommonName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ServerCertificateIssuerCommonName
	{
		[Export("serverCertificateIssuerCommonName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServerCertificateIssuerCommonNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerCertificateIssuerCommonNameHandle));
		}
		[Export("setServerCertificateIssuerCommonName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetServerCertificateIssuerCommonName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetServerCertificateIssuerCommonName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool StrictRevocationCheck
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("strictRevocationCheck")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selStrictRevocationCheckHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStrictRevocationCheckHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setStrictRevocationCheck:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStrictRevocationCheck_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStrictRevocationCheck_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool UseConfigurationAttributeInternalIPSubnet
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("useConfigurationAttributeInternalIPSubnet")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUseConfigurationAttributeInternalIPSubnetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUseConfigurationAttributeInternalIPSubnetHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setUseConfigurationAttributeInternalIPSubnet:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUseConfigurationAttributeInternalIPSubnet_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUseConfigurationAttributeInternalIPSubnet_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEVpnProtocolIke2()
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
	public NEVpnProtocolIke2(NSCoder coder)
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
	protected NEVpnProtocolIke2(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEVpnProtocolIke2(IntPtr handle)
		: base(handle)
	{
	}
}

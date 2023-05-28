using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Security;
using Xamarin.Mac.System.Mac;

namespace CoreWlan;

[Register("CWInterface", true)]
public class CWInterface : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivePHYMode = "activePHYMode";

	private static readonly IntPtr selActivePHYModeHandle = Selector.GetHandle("activePHYMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociateToEnterpriseNetwork_Identity_Username_Password_Error_ = "associateToEnterpriseNetwork:identity:username:password:error:";

	private static readonly IntPtr selAssociateToEnterpriseNetwork_Identity_Username_Password_Error_Handle = Selector.GetHandle("associateToEnterpriseNetwork:identity:username:password:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociateToNetwork_Parameters_Error_ = "associateToNetwork:parameters:error:";

	private static readonly IntPtr selAssociateToNetwork_Parameters_Error_Handle = Selector.GetHandle("associateToNetwork:parameters:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociateToNetwork_Password_Error_ = "associateToNetwork:password:error:";

	private static readonly IntPtr selAssociateToNetwork_Password_Error_Handle = Selector.GetHandle("associateToNetwork:password:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBssid = "bssid";

	private static readonly IntPtr selBssidHandle = Selector.GetHandle("bssid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBssidData = "bssidData";

	private static readonly IntPtr selBssidDataHandle = Selector.GetHandle("bssidData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCachedScanResults = "cachedScanResults";

	private static readonly IntPtr selCachedScanResultsHandle = Selector.GetHandle("cachedScanResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannel = "channel";

	private static readonly IntPtr selChannelHandle = Selector.GetHandle("channel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitConfiguration_Authorization_Error_ = "commitConfiguration:authorization:error:";

	private static readonly IntPtr selCommitConfiguration_Authorization_Error_Handle = Selector.GetHandle("commitConfiguration:authorization:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitConfiguration_Error_ = "commitConfiguration:error:";

	private static readonly IntPtr selCommitConfiguration_Error_Handle = Selector.GetHandle("commitConfiguration:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountryCode = "countryCode";

	private static readonly IntPtr selCountryCodeHandle = Selector.GetHandle("countryCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceAttached = "deviceAttached";

	private static readonly IntPtr selDeviceAttachedHandle = Selector.GetHandle("deviceAttached");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisassociate = "disassociate";

	private static readonly IntPtr selDisassociateHandle = Selector.GetHandle("disassociate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableIBSSWithParameters_Error_ = "enableIBSSWithParameters:error:";

	private static readonly IntPtr selEnableIBSSWithParameters_Error_Handle = Selector.GetHandle("enableIBSSWithParameters:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHardwareAddress = "hardwareAddress";

	private static readonly IntPtr selHardwareAddressHandle = Selector.GetHandle("hardwareAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInterfaceName_ = "initWithInterfaceName:";

	private static readonly IntPtr selInitWithInterfaceName_Handle = Selector.GetHandle("initWithInterfaceName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterface = "interface";

	private static readonly IntPtr selInterfaceHandle = Selector.GetHandle("interface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceMode = "interfaceMode";

	private static readonly IntPtr selInterfaceModeHandle = Selector.GetHandle("interfaceMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceName = "interfaceName";

	private static readonly IntPtr selInterfaceNameHandle = Selector.GetHandle("interfaceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceNames = "interfaceNames";

	private static readonly IntPtr selInterfaceNamesHandle = Selector.GetHandle("interfaceNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceState = "interfaceState";

	private static readonly IntPtr selInterfaceStateHandle = Selector.GetHandle("interfaceState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceWithName_ = "interfaceWithName:";

	private static readonly IntPtr selInterfaceWithName_Handle = Selector.GetHandle("interfaceWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToInterface_ = "isEqualToInterface:";

	private static readonly IntPtr selIsEqualToInterface_Handle = Selector.GetHandle("isEqualToInterface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoise = "noise";

	private static readonly IntPtr selNoiseHandle = Selector.GetHandle("noise");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseMeasurement = "noiseMeasurement";

	private static readonly IntPtr selNoiseMeasurementHandle = Selector.GetHandle("noiseMeasurement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpMode = "opMode";

	private static readonly IntPtr selOpModeHandle = Selector.GetHandle("opMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhyMode = "phyMode";

	private static readonly IntPtr selPhyModeHandle = Selector.GetHandle("phyMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPower = "power";

	private static readonly IntPtr selPowerHandle = Selector.GetHandle("power");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPowerOn = "powerOn";

	private static readonly IntPtr selPowerOnHandle = Selector.GetHandle("powerOn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPowerSave = "powerSave";

	private static readonly IntPtr selPowerSaveHandle = Selector.GetHandle("powerSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRssi = "rssi";

	private static readonly IntPtr selRssiHandle = Selector.GetHandle("rssi");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRssiValue = "rssiValue";

	private static readonly IntPtr selRssiValueHandle = Selector.GetHandle("rssiValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForNetworksWithName_Error_ = "scanForNetworksWithName:error:";

	private static readonly IntPtr selScanForNetworksWithName_Error_Handle = Selector.GetHandle("scanForNetworksWithName:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForNetworksWithName_IncludeHidden_Error_ = "scanForNetworksWithName:includeHidden:error:";

	private static readonly IntPtr selScanForNetworksWithName_IncludeHidden_Error_Handle = Selector.GetHandle("scanForNetworksWithName:includeHidden:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForNetworksWithParameters_Error_ = "scanForNetworksWithParameters:error:";

	private static readonly IntPtr selScanForNetworksWithParameters_Error_Handle = Selector.GetHandle("scanForNetworksWithParameters:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForNetworksWithSSID_Error_ = "scanForNetworksWithSSID:error:";

	private static readonly IntPtr selScanForNetworksWithSSID_Error_Handle = Selector.GetHandle("scanForNetworksWithSSID:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanForNetworksWithSSID_IncludeHidden_Error_ = "scanForNetworksWithSSID:includeHidden:error:";

	private static readonly IntPtr selScanForNetworksWithSSID_IncludeHidden_Error_Handle = Selector.GetHandle("scanForNetworksWithSSID:includeHidden:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecurity = "security";

	private static readonly IntPtr selSecurityHandle = Selector.GetHandle("security");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecurityMode = "securityMode";

	private static readonly IntPtr selSecurityModeHandle = Selector.GetHandle("securityMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceActive = "serviceActive";

	private static readonly IntPtr selServiceActiveHandle = Selector.GetHandle("serviceActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannel_Error_ = "setChannel:error:";

	private static readonly IntPtr selSetChannel_Error_Handle = Selector.GetHandle("setChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPairwiseMasterKey_Error_ = "setPairwiseMasterKey:error:";

	private static readonly IntPtr selSetPairwiseMasterKey_Error_Handle = Selector.GetHandle("setPairwiseMasterKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPower_Error_ = "setPower:error:";

	private static readonly IntPtr selSetPower_Error_Handle = Selector.GetHandle("setPower:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWEPKey_Flags_Index_Error_ = "setWEPKey:flags:index:error:";

	private static readonly IntPtr selSetWEPKey_Flags_Index_Error_Handle = Selector.GetHandle("setWEPKey:flags:index:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWLANChannel_Error_ = "setWLANChannel:error:";

	private static readonly IntPtr selSetWLANChannel_Error_Handle = Selector.GetHandle("setWLANChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSsid = "ssid";

	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSsidData = "ssidData";

	private static readonly IntPtr selSsidDataHandle = Selector.GetHandle("ssidData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartIBSSModeWithSSID_Security_Channel_Password_Error_ = "startIBSSModeWithSSID:security:channel:password:error:";

	private static readonly IntPtr selStartIBSSModeWithSSID_Security_Channel_Password_Error_Handle = Selector.GetHandle("startIBSSModeWithSSID:security:channel:password:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedChannels = "supportedChannels";

	private static readonly IntPtr selSupportedChannelsHandle = Selector.GetHandle("supportedChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedInterfaces = "supportedInterfaces";

	private static readonly IntPtr selSupportedInterfacesHandle = Selector.GetHandle("supportedInterfaces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedPHYModes = "supportedPHYModes";

	private static readonly IntPtr selSupportedPHYModesHandle = Selector.GetHandle("supportedPHYModes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedWLANChannels = "supportedWLANChannels";

	private static readonly IntPtr selSupportedWLANChannelsHandle = Selector.GetHandle("supportedWLANChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsAES_CCM = "supportsAES_CCM";

	private static readonly IntPtr selSupportsAES_CCMHandle = Selector.GetHandle("supportsAES_CCM");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsHostAP = "supportsHostAP";

	private static readonly IntPtr selSupportsHostAPHandle = Selector.GetHandle("supportsHostAP");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsIBSS = "supportsIBSS";

	private static readonly IntPtr selSupportsIBSSHandle = Selector.GetHandle("supportsIBSS");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsMonitorMode = "supportsMonitorMode";

	private static readonly IntPtr selSupportsMonitorModeHandle = Selector.GetHandle("supportsMonitorMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsPMGT = "supportsPMGT";

	private static readonly IntPtr selSupportsPMGTHandle = Selector.GetHandle("supportsPMGT");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsShortGI20MHz = "supportsShortGI20MHz";

	private static readonly IntPtr selSupportsShortGI20MHzHandle = Selector.GetHandle("supportsShortGI20MHz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsShortGI40MHz = "supportsShortGI40MHz";

	private static readonly IntPtr selSupportsShortGI40MHzHandle = Selector.GetHandle("supportsShortGI40MHz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsTKIP = "supportsTKIP";

	private static readonly IntPtr selSupportsTKIPHandle = Selector.GetHandle("supportsTKIP");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsTSN = "supportsTSN";

	private static readonly IntPtr selSupportsTSNHandle = Selector.GetHandle("supportsTSN");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsWEP = "supportsWEP";

	private static readonly IntPtr selSupportsWEPHandle = Selector.GetHandle("supportsWEP");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsWME = "supportsWME";

	private static readonly IntPtr selSupportsWMEHandle = Selector.GetHandle("supportsWME");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsWPA = "supportsWPA";

	private static readonly IntPtr selSupportsWPAHandle = Selector.GetHandle("supportsWPA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsWPA2 = "supportsWPA2";

	private static readonly IntPtr selSupportsWPA2Handle = Selector.GetHandle("supportsWPA2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsWoW = "supportsWoW";

	private static readonly IntPtr selSupportsWoWHandle = Selector.GetHandle("supportsWoW");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransmitPower = "transmitPower";

	private static readonly IntPtr selTransmitPowerHandle = Selector.GetHandle("transmitPower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransmitRate = "transmitRate";

	private static readonly IntPtr selTransmitRateHandle = Selector.GetHandle("transmitRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTxPower = "txPower";

	private static readonly IntPtr selTxPowerHandle = Selector.GetHandle("txPower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTxRate = "txRate";

	private static readonly IntPtr selTxRateHandle = Selector.GetHandle("txRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWlanChannel = "wlanChannel";

	private static readonly IntPtr selWlanChannelHandle = Selector.GetHandle("wlanChannel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CWInterface");

	public CWChannel[] SupportedWlanChannels => _SupportedWlanChannels?.ToArray<CWChannel>();

	public CWNetwork[] CachedScanResults => _CachedScanResults?.ToArray<CWNetwork>();

	public static string[] InterfaceNames
	{
		get
		{
			NSSet interfaceNames = _InterfaceNames;
			if (interfaceNames != null)
			{
				return Array.ConvertAll(interfaceNames.ToArray<NSString>(), (Converter<NSString, string>)((NSString item) => item));
			}
			return null;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWPhyMode ActivePHYMode
	{
		[Export("activePHYMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CWPhyMode)Messaging.UInt64_objc_msgSend(base.Handle, selActivePHYModeHandle);
			}
			return (CWPhyMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selActivePHYModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Bssid
	{
		[Export("bssid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBssidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBssidHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSData BssidData
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("bssidData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selBssidDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBssidDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber Channel
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("channel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWConfiguration Configuration
	{
		[Export("configuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CWConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<CWConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CountryCode
	{
		[Export("countryCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCountryCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCountryCodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeviceAttached
	{
		[Export("deviceAttached")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDeviceAttachedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeviceAttachedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string HardwareAddress
	{
		[Export("hardwareAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHardwareAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHardwareAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWInterfaceMode InterfaceMode
	{
		[Export("interfaceMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CWInterfaceMode)Messaging.UInt64_objc_msgSend(base.Handle, selInterfaceModeHandle);
			}
			return (CWInterfaceMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selInterfaceModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string InterfaceName
	{
		[Export("interfaceName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfaceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfaceNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber InterfaceState
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("interfaceState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfaceStateHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfaceStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static CWInterface MainInterface
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("interface")]
		get
		{
			return Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSend(class_ptr, selInterfaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber Noise
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("noise")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selNoiseHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNoiseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NoiseMeasurement
	{
		[Export("noiseMeasurement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNoiseMeasurementHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNoiseMeasurementHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber OpMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("opMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selOpModeHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpModeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber PhyMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("phyMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhyModeHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhyModeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool Power
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("power")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPowerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPowerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PowerOn
	{
		[Export("powerOn")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPowerOnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPowerOnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool PowerSave
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("powerSave")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPowerSaveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPowerSaveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber Rssi
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("rssi")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selRssiHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRssiHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RssiValue
	{
		[Export("rssiValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRssiValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRssiValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWSecurity Security
	{
		[Export("security")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CWSecurity)Messaging.UInt64_objc_msgSend(base.Handle, selSecurityHandle);
			}
			return (CWSecurity)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSecurityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber SecurityMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("securityMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSecurityModeHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecurityModeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ServiceActive
	{
		[Export("serviceActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selServiceActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selServiceActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Ssid
	{
		[Export("ssid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSsidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSsidHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData SsidData
	{
		[Export("ssidData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSsidDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSsidDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber[] SupportedChannels
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportedChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedChannelsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedChannelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static string[] SupportedInterfaces
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportedInterfaces")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedInterfacesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber[] SupportedPhyModes
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportedPHYModes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedPHYModesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedPHYModesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsAesCcm
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsAES_CCM")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsAES_CCMHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsAES_CCMHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsHostAP
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsHostAP")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsHostAPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsHostAPHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsIbss
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsIBSS")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsIBSSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsIBSSHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsMonitorMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsMonitorMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsMonitorModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsMonitorModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsPmgt
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsPMGT")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsPMGTHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsPMGTHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsShortGI20MHz
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsShortGI20MHz")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsShortGI20MHzHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsShortGI20MHzHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsShortGI40MHz
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsShortGI40MHz")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsShortGI40MHzHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsShortGI40MHzHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsTkip
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsTKIP")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTKIPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTKIPHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsTsn
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsTSN")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTSNHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTSNHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsWep
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsWEP")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWEPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWEPHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsWme
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsWME")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWMEHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWMEHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsWow
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsWoW")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWoWHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWoWHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsWpa
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsWPA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWPAHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWPAHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SupportsWpa2
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("supportsWPA2")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWPA2Handle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWPA2Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint TransmitPower
	{
		[Export("transmitPower")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selTransmitPowerHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTransmitPowerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TransmitRate
	{
		[Export("transmitRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTransmitRateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTransmitRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber TxPower
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("txPower")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selTxPowerHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTxPowerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSNumber TxRate
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("txRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selTxRateHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTxRateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWChannel WlanChannel
	{
		[Export("wlanChannel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CWChannel>(Messaging.IntPtr_objc_msgSend(base.Handle, selWlanChannelHandle));
			}
			return Runtime.GetNSObject<CWChannel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWlanChannelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet _CachedScanResults
	{
		[Export("cachedScanResults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selCachedScanResultsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCachedScanResultsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSSet _InterfaceNames
	{
		[Export("interfaceNames")]
		get
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selInterfaceNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet _SupportedWlanChannels
	{
		[Export("supportedWLANChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedWLANChannelsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedWLANChannelsHandle));
		}
	}

	public CWNetwork[] ScanForNetworksWithSsid(NSData ssid, out NSError error)
	{
		return _ScanForNetworksWithSsid(ssid, out error)?.ToArray<CWNetwork>();
	}

	public CWNetwork[] ScanForNetworksWithName(string networkName, out NSError error)
	{
		return _ScanForNetworksWithName(networkName, out error)?.ToArray<CWNetwork>();
	}

	[Mac(10, 13)]
	public CWNetwork[] ScanForNetworksWithSsid(NSData ssid, bool includeHidden, out NSError error)
	{
		return _ScanForNetworksWithSsid(ssid, includeHidden, out error)?.ToArray<CWNetwork>();
	}

	[Mac(10, 13)]
	public CWNetwork[] ScanForNetworksWithName(string networkName, bool includeHidden, out NSError error)
	{
		return _ScanForNetworksWithName(networkName, includeHidden, out error)?.ToArray<CWNetwork>();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWInterface()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CWInterface(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWInterface(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInterfaceName:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'CWWiFiClient.FromName' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CWInterface(string? name)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithInterfaceName_Handle, arg), "initWithInterfaceName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithInterfaceName_Handle, arg), "initWithInterfaceName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("associateToEnterpriseNetwork:identity:username:password:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AssociateToEnterpriseNetwork(CWNetwork network, SecIdentity identity, string username, string password, out NSError error)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(username);
		IntPtr arg3 = NSString.CreateNative(password);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selAssociateToEnterpriseNetwork_Identity_Username_Password_Error_Handle, network.Handle, identity.Handle, arg2, arg3, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selAssociateToEnterpriseNetwork_Identity_Username_Password_Error_Handle, network.Handle, identity.Handle, arg2, arg3, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("associateToNetwork:parameters:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AssociateToNetwork(CWNetwork network, NSDictionary? parameters, out NSError error)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selAssociateToNetwork_Parameters_Error_Handle, network.Handle, parameters?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selAssociateToNetwork_Parameters_Error_Handle, network.Handle, parameters?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("associateToNetwork:password:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AssociateToNetwork(CWNetwork network, string password, out NSError error)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(password);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selAssociateToNetwork_Password_Error_Handle, network.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selAssociateToNetwork_Password_Error_Handle, network.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("commitConfiguration:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CommitConfiguration(CWConfiguration config, out NSError error)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selCommitConfiguration_Error_Handle, config.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selCommitConfiguration_Error_Handle, config.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("commitConfiguration:authorization:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CommitConfiguration(CWConfiguration configuration, NSObject authorization, out NSError error)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (authorization == null)
		{
			throw new ArgumentNullException("authorization");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCommitConfiguration_Authorization_Error_Handle, configuration.Handle, authorization.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCommitConfiguration_Authorization_Error_Handle, configuration.Handle, authorization.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("disassociate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Disassociate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisassociateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisassociateHandle);
		}
	}

	[Export("enableIBSSWithParameters:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableIBSSWithParameters(NSDictionary? parameters, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selEnableIBSSWithParameters_Error_Handle, parameters?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selEnableIBSSWithParameters_Error_Handle, parameters?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("interfaceWithName:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CWInterface FromName(string? name)
	{
		IntPtr arg = NSString.CreateNative(name);
		CWInterface nSObject = Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInterfaceWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("isEqualToInterface:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToInterface(CWInterface intface)
	{
		if (intface == null)
		{
			throw new ArgumentNullException("intface");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToInterface_Handle, intface.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToInterface_Handle, intface.Handle);
	}

	[Export("scanForNetworksWithParameters:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWNetwork[] ScanForNetworksWithParameters(NSDictionary? parameters, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		CWNetwork[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<CWNetwork>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selScanForNetworksWithParameters_Error_Handle, parameters?.Handle ?? IntPtr.Zero, ref arg)) : NSArray.ArrayFromHandle<CWNetwork>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selScanForNetworksWithParameters_Error_Handle, parameters?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setChannel:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetChannel(nuint channel, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_nuint_ref_IntPtr(base.SuperHandle, selSetChannel_Error_Handle, channel, ref arg) : Messaging.bool_objc_msgSend_nuint_ref_IntPtr(base.Handle, selSetChannel_Error_Handle, channel, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setPairwiseMasterKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetPairwiseMasterKey(NSData key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSetPairwiseMasterKey_Error_Handle, key.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSetPairwiseMasterKey_Error_Handle, key.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setPower:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetPower(bool power, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_bool_ref_IntPtr(base.SuperHandle, selSetPower_Error_Handle, power, ref arg) : Messaging.bool_objc_msgSend_bool_ref_IntPtr(base.Handle, selSetPower_Error_Handle, power, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setWEPKey:flags:index:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetWEPKey(NSData key, CWCipherKeyFlags flags, nint index, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_nint_ref_IntPtr(base.SuperHandle, selSetWEPKey_Flags_Index_Error_Handle, key.Handle, (ulong)flags, index, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_nint_ref_IntPtr(base.Handle, selSetWEPKey_Flags_Index_Error_Handle, key.Handle, (ulong)flags, index, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setWLANChannel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetWlanChannel(CWChannel channel, out NSError error)
	{
		if (channel == null)
		{
			throw new ArgumentNullException("channel");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSetWLANChannel_Error_Handle, channel.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSetWLANChannel_Error_Handle, channel.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("startIBSSModeWithSSID:security:channel:password:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartIbssModeWithSsid(NSData ssidData, CWIbssModeSecurity security, nuint channel, string password, out NSError error)
	{
		if (ssidData == null)
		{
			throw new ArgumentNullException("ssidData");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(password);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_nuint_IntPtr_ref_IntPtr(base.SuperHandle, selStartIBSSModeWithSSID_Security_Channel_Password_Error_Handle, ssidData.Handle, (ulong)security, channel, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_nuint_IntPtr_ref_IntPtr(base.Handle, selStartIBSSModeWithSSID_Security_Channel_Password_Error_Handle, ssidData.Handle, (ulong)security, channel, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scanForNetworksWithName:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet _ScanForNetworksWithName(string? networkName, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(networkName);
		NSSet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selScanForNetworksWithName_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selScanForNetworksWithName_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scanForNetworksWithName:includeHidden:error:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet? _ScanForNetworksWithName(string? networkName, bool includeHidden, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(networkName);
		NSSet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selScanForNetworksWithName_IncludeHidden_Error_Handle, arg2, includeHidden, ref arg)) : Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selScanForNetworksWithName_IncludeHidden_Error_Handle, arg2, includeHidden, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scanForNetworksWithSSID:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet _ScanForNetworksWithSsid(NSData? ssid, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSSet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selScanForNetworksWithSSID_Error_Handle, ssid?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selScanForNetworksWithSSID_Error_Handle, ssid?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scanForNetworksWithSSID:includeHidden:error:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSSet? _ScanForNetworksWithSsid(NSData? ssid, bool includeHidden, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSSet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selScanForNetworksWithSSID_IncludeHidden_Error_Handle, ssid?.Handle ?? IntPtr.Zero, includeHidden, ref arg)) : Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selScanForNetworksWithSSID_IncludeHidden_Error_Handle, ssid?.Handle ?? IntPtr.Zero, includeHidden, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

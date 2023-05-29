using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWInterface", true)]
public class CWInterface : NSObject
{
	private static readonly IntPtr selSupportsWoWHandle = Selector.GetHandle("supportsWoW");

	private static readonly IntPtr selSupportsWEPHandle = Selector.GetHandle("supportsWEP");

	private static readonly IntPtr selSupportsAES_CCMHandle = Selector.GetHandle("supportsAES_CCM");

	private static readonly IntPtr selSupportsIBSSHandle = Selector.GetHandle("supportsIBSS");

	private static readonly IntPtr selSupportsTKIPHandle = Selector.GetHandle("supportsTKIP");

	private static readonly IntPtr selSupportsPMGTHandle = Selector.GetHandle("supportsPMGT");

	private static readonly IntPtr selSupportsHostAPHandle = Selector.GetHandle("supportsHostAP");

	private static readonly IntPtr selSupportsMonitorModeHandle = Selector.GetHandle("supportsMonitorMode");

	private static readonly IntPtr selSupportsWPAHandle = Selector.GetHandle("supportsWPA");

	private static readonly IntPtr selSupportsWPA2Handle = Selector.GetHandle("supportsWPA2");

	private static readonly IntPtr selSupportsWMEHandle = Selector.GetHandle("supportsWME");

	private static readonly IntPtr selSupportsShortGI40MHzHandle = Selector.GetHandle("supportsShortGI40MHz");

	private static readonly IntPtr selSupportsShortGI20MHzHandle = Selector.GetHandle("supportsShortGI20MHz");

	private static readonly IntPtr selSupportsTSNHandle = Selector.GetHandle("supportsTSN");

	private static readonly IntPtr selPowerHandle = Selector.GetHandle("power");

	private static readonly IntPtr selPowerSaveHandle = Selector.GetHandle("powerSave");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSupportedChannelsHandle = Selector.GetHandle("supportedChannels");

	private static readonly IntPtr selSupportedPHYModesHandle = Selector.GetHandle("supportedPHYModes");

	private static readonly IntPtr selChannelHandle = Selector.GetHandle("channel");

	private static readonly IntPtr selPhyModeHandle = Selector.GetHandle("phyMode");

	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	private static readonly IntPtr selBssidHandle = Selector.GetHandle("bssid");

	private static readonly IntPtr selBssidDataHandle = Selector.GetHandle("bssidData");

	private static readonly IntPtr selRssiHandle = Selector.GetHandle("rssi");

	private static readonly IntPtr selNoiseHandle = Selector.GetHandle("noise");

	private static readonly IntPtr selTxRateHandle = Selector.GetHandle("txRate");

	private static readonly IntPtr selSecurityModeHandle = Selector.GetHandle("securityMode");

	private static readonly IntPtr selInterfaceStateHandle = Selector.GetHandle("interfaceState");

	private static readonly IntPtr selCountryCodeHandle = Selector.GetHandle("countryCode");

	private static readonly IntPtr selOpModeHandle = Selector.GetHandle("opMode");

	private static readonly IntPtr selTxPowerHandle = Selector.GetHandle("txPower");

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	private static readonly IntPtr selSupportedInterfacesHandle = Selector.GetHandle("supportedInterfaces");

	private static readonly IntPtr selInterfaceHandle = Selector.GetHandle("interface");

	private static readonly IntPtr selInterfaceWithName_Handle = Selector.GetHandle("interfaceWithName:");

	private static readonly IntPtr selInitWithInterfaceName_Handle = Selector.GetHandle("initWithInterfaceName:");

	private static readonly IntPtr selIsEqualToInterface_Handle = Selector.GetHandle("isEqualToInterface:");

	private static readonly IntPtr selSetPowerError_Handle = Selector.GetHandle("setPower:error:");

	private static readonly IntPtr selSetChannelError_Handle = Selector.GetHandle("setChannel:error:");

	private static readonly IntPtr selScanForNetworksWithParametersError_Handle = Selector.GetHandle("scanForNetworksWithParameters:error:");

	private static readonly IntPtr selAssociateToNetworkParametersError_Handle = Selector.GetHandle("associateToNetwork:parameters:error:");

	private static readonly IntPtr selDisassociateHandle = Selector.GetHandle("disassociate");

	private static readonly IntPtr selEnableIBSSWithParametersError_Handle = Selector.GetHandle("enableIBSSWithParameters:error:");

	private static readonly IntPtr selCommitConfigurationError_Handle = Selector.GetHandle("commitConfiguration:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CWInterface");

	private object __mt_SupportedChannels_var;

	private object __mt_SupportedPhyModes_var;

	private object __mt_Channel_var;

	private object __mt_PhyMode_var;

	private object __mt_BssidData_var;

	private object __mt_Rssi_var;

	private object __mt_Noise_var;

	private object __mt_TxRate_var;

	private object __mt_SecurityMode_var;

	private object __mt_InterfaceState_var;

	private object __mt_OpMode_var;

	private object __mt_TxPower_var;

	private object __mt_Configuration_var;

	private static object __mt_MainInterface_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool SupportsWow
	{
		[Export("supportsWoW")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWoWHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWoWHandle);
		}
	}

	public virtual bool SupportsWep
	{
		[Export("supportsWEP")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWEPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWEPHandle);
		}
	}

	public virtual bool SupportsAesCcm
	{
		[Export("supportsAES_CCM")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsAES_CCMHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsAES_CCMHandle);
		}
	}

	public virtual bool SupportsIbss
	{
		[Export("supportsIBSS")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsIBSSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsIBSSHandle);
		}
	}

	public virtual bool SupportsTkip
	{
		[Export("supportsTKIP")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTKIPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTKIPHandle);
		}
	}

	public virtual bool SupportsPmgt
	{
		[Export("supportsPMGT")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsPMGTHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsPMGTHandle);
		}
	}

	public virtual bool SupportsHostAP
	{
		[Export("supportsHostAP")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsHostAPHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsHostAPHandle);
		}
	}

	public virtual bool SupportsMonitorMode
	{
		[Export("supportsMonitorMode")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsMonitorModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsMonitorModeHandle);
		}
	}

	public virtual bool SupportsWpa
	{
		[Export("supportsWPA")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWPAHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWPAHandle);
		}
	}

	public virtual bool SupportsWpa2
	{
		[Export("supportsWPA2")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWPA2Handle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWPA2Handle);
		}
	}

	public virtual bool SupportsWme
	{
		[Export("supportsWME")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsWMEHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsWMEHandle);
		}
	}

	public virtual bool SupportsShortGI40MHz
	{
		[Export("supportsShortGI40MHz")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsShortGI40MHzHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsShortGI40MHzHandle);
		}
	}

	public virtual bool SupportsShortGI20MHz
	{
		[Export("supportsShortGI20MHz")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsShortGI20MHzHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsShortGI20MHzHandle);
		}
	}

	public virtual bool SupportsTsn
	{
		[Export("supportsTSN")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsTSNHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsTSNHandle);
		}
	}

	public virtual bool Power
	{
		[Export("power")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPowerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPowerHandle);
		}
	}

	public virtual bool PowerSave
	{
		[Export("powerSave")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPowerSaveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPowerSaveHandle);
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual NSNumber[] SupportedChannels
	{
		[Export("supportedChannels")]
		get
		{
			return (NSNumber[])(__mt_SupportedChannels_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedChannelsHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedChannelsHandle))));
		}
	}

	public virtual NSNumber[] SupportedPhyModes
	{
		[Export("supportedPHYModes")]
		get
		{
			return (NSNumber[])(__mt_SupportedPhyModes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedPHYModesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedPHYModesHandle))));
		}
	}

	public virtual NSNumber Channel
	{
		[Export("channel")]
		get
		{
			return (NSNumber)(__mt_Channel_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelHandle)))));
		}
	}

	public virtual NSNumber PhyMode
	{
		[Export("phyMode")]
		get
		{
			return (NSNumber)(__mt_PhyMode_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhyModeHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPhyModeHandle)))));
		}
	}

	public virtual string Ssid
	{
		[Export("ssid")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSsidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSsidHandle));
		}
	}

	public virtual string Bssid
	{
		[Export("bssid")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBssidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBssidHandle));
		}
	}

	public virtual NSData BssidData
	{
		[Export("bssidData")]
		get
		{
			return (NSData)(__mt_BssidData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBssidDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBssidDataHandle)))));
		}
	}

	public virtual NSNumber Rssi
	{
		[Export("rssi")]
		get
		{
			return (NSNumber)(__mt_Rssi_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRssiHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRssiHandle)))));
		}
	}

	public virtual NSNumber Noise
	{
		[Export("noise")]
		get
		{
			return (NSNumber)(__mt_Noise_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNoiseHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNoiseHandle)))));
		}
	}

	public virtual NSNumber TxRate
	{
		[Export("txRate")]
		get
		{
			return (NSNumber)(__mt_TxRate_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTxRateHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTxRateHandle)))));
		}
	}

	public virtual NSNumber SecurityMode
	{
		[Export("securityMode")]
		get
		{
			return (NSNumber)(__mt_SecurityMode_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecurityModeHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSecurityModeHandle)))));
		}
	}

	public virtual NSNumber InterfaceState
	{
		[Export("interfaceState")]
		get
		{
			return (NSNumber)(__mt_InterfaceState_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfaceStateHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfaceStateHandle)))));
		}
	}

	public virtual string CountryCode
	{
		[Export("countryCode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCountryCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCountryCodeHandle));
		}
	}

	public virtual NSNumber OpMode
	{
		[Export("opMode")]
		get
		{
			return (NSNumber)(__mt_OpMode_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpModeHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOpModeHandle)))));
		}
	}

	public virtual NSNumber TxPower
	{
		[Export("txPower")]
		get
		{
			return (NSNumber)(__mt_TxPower_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTxPowerHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTxPowerHandle)))));
		}
	}

	public virtual CWConfiguration Configuration
	{
		[Export("configuration")]
		get
		{
			return (CWConfiguration)(__mt_Configuration_var = ((!IsDirectBinding) ? ((CWConfiguration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle))) : ((CWConfiguration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle)))));
		}
	}

	public static string[] SupportedInterfaces
	{
		[Export("supportedInterfaces")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedInterfacesHandle));
		}
	}

	public static CWInterface MainInterface
	{
		[Export("interface")]
		get
		{
			return (CWInterface)(__mt_MainInterface_var_static = (CWInterface)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selInterfaceHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWInterface()
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
	public CWInterface(NSCoder coder)
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
	public CWInterface(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CWInterface(IntPtr handle)
		: base(handle)
	{
	}

	[Export("interfaceWithName:")]
	public static CWInterface FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CWInterface result = (CWInterface)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInterfaceWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithInterfaceName:")]
	public CWInterface(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithInterfaceName_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithInterfaceName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("isEqualToInterface:")]
	public virtual bool IsEqualToInterface(CWInterface intface)
	{
		if (intface == null)
		{
			throw new ArgumentNullException("intface");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToInterface_Handle, intface.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToInterface_Handle, intface.Handle);
	}

	[Export("setPower:error:")]
	public virtual bool SetPower(bool power, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetPowerError_Handle, power, intPtr) : Messaging.bool_objc_msgSend_bool_IntPtr(base.Handle, selSetPowerError_Handle, power, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setChannel:error:")]
	public virtual bool SetChannel(uint channel, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selSetChannelError_Handle, channel, intPtr) : Messaging.bool_objc_msgSend_UInt32_IntPtr(base.Handle, selSetChannelError_Handle, channel, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("scanForNetworksWithParameters:error:")]
	public virtual CWNetwork[] ScanForNetworksWithParameters(NSDictionary parameters, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		CWNetwork[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CWNetwork>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScanForNetworksWithParametersError_Handle, parameters?.Handle ?? IntPtr.Zero, intPtr)) : NSArray.ArrayFromHandle<CWNetwork>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selScanForNetworksWithParametersError_Handle, parameters?.Handle ?? IntPtr.Zero, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("associateToNetwork:parameters:error:")]
	public virtual bool AssociateToNetwork(CWNetwork network, NSDictionary parameters, out NSError error)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAssociateToNetworkParametersError_Handle, network.Handle, parameters?.Handle ?? IntPtr.Zero, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAssociateToNetworkParametersError_Handle, network.Handle, parameters?.Handle ?? IntPtr.Zero, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("disassociate")]
	public virtual void Disassociate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisassociateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisassociateHandle);
		}
	}

	[Export("enableIBSSWithParameters:error:")]
	public virtual bool EnableIBSSWithParameters(NSDictionary parameters, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnableIBSSWithParametersError_Handle, parameters?.Handle ?? IntPtr.Zero, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnableIBSSWithParametersError_Handle, parameters?.Handle ?? IntPtr.Zero, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("commitConfiguration:error:")]
	public virtual bool CommitConfiguration(CWConfiguration config, out NSError error)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCommitConfigurationError_Handle, config.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCommitConfigurationError_Handle, config.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SupportedChannels_var = null;
			__mt_SupportedPhyModes_var = null;
			__mt_Channel_var = null;
			__mt_PhyMode_var = null;
			__mt_BssidData_var = null;
			__mt_Rssi_var = null;
			__mt_Noise_var = null;
			__mt_TxRate_var = null;
			__mt_SecurityMode_var = null;
			__mt_InterfaceState_var = null;
			__mt_OpMode_var = null;
			__mt_TxPower_var = null;
			__mt_Configuration_var = null;
		}
	}
}

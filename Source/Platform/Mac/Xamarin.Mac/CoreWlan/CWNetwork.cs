using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWNetwork", true)]
public class CWNetwork : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeaconInterval = "beaconInterval";

	private static readonly IntPtr selBeaconIntervalHandle = Selector.GetHandle("beaconInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBssid = "bssid";

	private static readonly IntPtr selBssidHandle = Selector.GetHandle("bssid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBssidData = "bssidData";

	private static readonly IntPtr selBssidDataHandle = Selector.GetHandle("bssidData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannel = "channel";

	private static readonly IntPtr selChannelHandle = Selector.GetHandle("channel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountryCode = "countryCode";

	private static readonly IntPtr selCountryCodeHandle = Selector.GetHandle("countryCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIbss = "ibss";

	private static readonly IntPtr selIbssHandle = Selector.GetHandle("ibss");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIeData = "ieData";

	private static readonly IntPtr selIeDataHandle = Selector.GetHandle("ieData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInformationElementData = "informationElementData";

	private static readonly IntPtr selInformationElementDataHandle = Selector.GetHandle("informationElementData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToNetwork_ = "isEqualToNetwork:";

	private static readonly IntPtr selIsEqualToNetwork_Handle = Selector.GetHandle("isEqualToNetwork:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIBSS = "isIBSS";

	private static readonly IntPtr selIsIBSSHandle = Selector.GetHandle("isIBSS");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoise = "noise";

	private static readonly IntPtr selNoiseHandle = Selector.GetHandle("noise");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseMeasurement = "noiseMeasurement";

	private static readonly IntPtr selNoiseMeasurementHandle = Selector.GetHandle("noiseMeasurement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhyMode = "phyMode";

	private static readonly IntPtr selPhyModeHandle = Selector.GetHandle("phyMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRssi = "rssi";

	private static readonly IntPtr selRssiHandle = Selector.GetHandle("rssi");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRssiValue = "rssiValue";

	private static readonly IntPtr selRssiValueHandle = Selector.GetHandle("rssiValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecurityMode = "securityMode";

	private static readonly IntPtr selSecurityModeHandle = Selector.GetHandle("securityMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSsid = "ssid";

	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSsidData = "ssidData";

	private static readonly IntPtr selSsidDataHandle = Selector.GetHandle("ssidData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsPHYMode_ = "supportsPHYMode:";

	private static readonly IntPtr selSupportsPHYMode_Handle = Selector.GetHandle("supportsPHYMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsSecurity_ = "supportsSecurity:";

	private static readonly IntPtr selSupportsSecurity_Handle = Selector.GetHandle("supportsSecurity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWirelessProfile = "wirelessProfile";

	private static readonly IntPtr selWirelessProfileHandle = Selector.GetHandle("wirelessProfile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWlanChannel = "wlanChannel";

	private static readonly IntPtr selWlanChannelHandle = Selector.GetHandle("wlanChannel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CWNetwork");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BeaconInterval
	{
		[Export("beaconInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBeaconIntervalHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBeaconIntervalHandle);
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
	public virtual bool Ibss
	{
		[Export("ibss")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIbssHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIbssHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSData IeData
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("ieData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selIeDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIeDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData InformationElementData
	{
		[Export("informationElementData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selInformationElementDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInformationElementDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool IsIBSS
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("isIBSS")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIBSSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIBSSHandle);
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
	public virtual CWWirelessProfile WirelessProfile
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("wirelessProfile")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CWWirelessProfile>(Messaging.IntPtr_objc_msgSend(base.Handle, selWirelessProfileHandle));
			}
			return Runtime.GetNSObject<CWWirelessProfile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWirelessProfileHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWChannel? WlanChannel
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWNetwork()
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
	public CWNetwork(NSCoder coder)
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
	protected CWNetwork(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWNetwork(IntPtr handle)
		: base(handle)
	{
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

	[Export("isEqualToNetwork:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToNetwork(CWNetwork network)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToNetwork_Handle, network.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToNetwork_Handle, network.Handle);
	}

	[Export("supportsPHYMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsPhyMode(CWPhyMode phyMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selSupportsPHYMode_Handle, (ulong)phyMode);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selSupportsPHYMode_Handle, (ulong)phyMode);
	}

	[Export("supportsSecurity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsSecurity(CWSecurity security)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selSupportsSecurity_Handle, (ulong)security);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selSupportsSecurity_Handle, (ulong)security);
	}
}

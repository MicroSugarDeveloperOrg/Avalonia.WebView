using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWNetwork", true)]
public class CWNetwork : NSObject
{
	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	private static readonly IntPtr selBssidHandle = Selector.GetHandle("bssid");

	private static readonly IntPtr selBssidDataHandle = Selector.GetHandle("bssidData");

	private static readonly IntPtr selSecurityModeHandle = Selector.GetHandle("securityMode");

	private static readonly IntPtr selPhyModeHandle = Selector.GetHandle("phyMode");

	private static readonly IntPtr selChannelHandle = Selector.GetHandle("channel");

	private static readonly IntPtr selRssiHandle = Selector.GetHandle("rssi");

	private static readonly IntPtr selNoiseHandle = Selector.GetHandle("noise");

	private static readonly IntPtr selIeDataHandle = Selector.GetHandle("ieData");

	private static readonly IntPtr selIsIBSSHandle = Selector.GetHandle("isIBSS");

	private static readonly IntPtr selWirelessProfileHandle = Selector.GetHandle("wirelessProfile");

	private static readonly IntPtr selIsEqualToNetwork_Handle = Selector.GetHandle("isEqualToNetwork:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CWNetwork");

	private object __mt_BssidData_var;

	private object __mt_SecurityMode_var;

	private object __mt_PhyMode_var;

	private object __mt_Channel_var;

	private object __mt_Rssi_var;

	private object __mt_Noise_var;

	private object __mt_IeData_var;

	private object __mt_WirelessProfile_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual NSNumber SecurityMode
	{
		[Export("securityMode")]
		get
		{
			return (NSNumber)(__mt_SecurityMode_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecurityModeHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSecurityModeHandle)))));
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

	public virtual NSNumber Channel
	{
		[Export("channel")]
		get
		{
			return (NSNumber)(__mt_Channel_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelHandle)))));
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

	public virtual NSData IeData
	{
		[Export("ieData")]
		get
		{
			return (NSData)(__mt_IeData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIeDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIeDataHandle)))));
		}
	}

	public virtual bool IsIBSS
	{
		[Export("isIBSS")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIBSSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIBSSHandle);
		}
	}

	public virtual CWWirelessProfile WirelessProfile
	{
		[Export("wirelessProfile")]
		get
		{
			return (CWWirelessProfile)(__mt_WirelessProfile_var = ((!IsDirectBinding) ? ((CWWirelessProfile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWirelessProfileHandle))) : ((CWWirelessProfile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWirelessProfileHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWNetwork()
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
	public CWNetwork(NSCoder coder)
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
	public CWNetwork(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CWNetwork(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isEqualToNetwork:")]
	public virtual bool IsEqualToNetwork(CWNetwork network)
	{
		if (network == null)
		{
			throw new ArgumentNullException("network");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToNetwork_Handle, network.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToNetwork_Handle, network.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BssidData_var = null;
			__mt_SecurityMode_var = null;
			__mt_PhyMode_var = null;
			__mt_Channel_var = null;
			__mt_Rssi_var = null;
			__mt_Noise_var = null;
			__mt_IeData_var = null;
			__mt_WirelessProfile_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEFilterDataVerdict", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEFilterDataVerdict : NEFilterVerdict, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowVerdict = "allowVerdict";

	private static readonly IntPtr selAllowVerdictHandle = Selector.GetHandle("allowVerdict");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataVerdictWithPassBytes_PeekBytes_ = "dataVerdictWithPassBytes:peekBytes:";

	private static readonly IntPtr selDataVerdictWithPassBytes_PeekBytes_Handle = Selector.GetHandle("dataVerdictWithPassBytes:peekBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDropVerdict = "dropVerdict";

	private static readonly IntPtr selDropVerdictHandle = Selector.GetHandle("dropVerdict");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedRulesVerdict = "needRulesVerdict";

	private static readonly IntPtr selNeedRulesVerdictHandle = Selector.GetHandle("needRulesVerdict");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseVerdict = "pauseVerdict";

	private static readonly IntPtr selPauseVerdictHandle = Selector.GetHandle("pauseVerdict");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemediateVerdictWithRemediationURLMapKey_RemediationButtonTextMapKey_ = "remediateVerdictWithRemediationURLMapKey:remediationButtonTextMapKey:";

	private static readonly IntPtr selRemediateVerdictWithRemediationURLMapKey_RemediationButtonTextMapKey_Handle = Selector.GetHandle("remediateVerdictWithRemediationURLMapKey:remediationButtonTextMapKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStatisticsReportFrequency_ = "setStatisticsReportFrequency:";

	private static readonly IntPtr selSetStatisticsReportFrequency_Handle = Selector.GetHandle("setStatisticsReportFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatisticsReportFrequency = "statisticsReportFrequency";

	private static readonly IntPtr selStatisticsReportFrequencyHandle = Selector.GetHandle("statisticsReportFrequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEFilterDataVerdict");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual NEFilterReportFrequency StatisticsReportFrequency
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("statisticsReportFrequency", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEFilterReportFrequency)Messaging.Int64_objc_msgSend(base.Handle, selStatisticsReportFrequencyHandle);
			}
			return (NEFilterReportFrequency)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatisticsReportFrequencyHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setStatisticsReportFrequency:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetStatisticsReportFrequency_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetStatisticsReportFrequency_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEFilterDataVerdict()
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
	public NEFilterDataVerdict(NSCoder coder)
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
	protected NEFilterDataVerdict(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEFilterDataVerdict(IntPtr handle)
		: base(handle)
	{
	}

	[Export("allowVerdict")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict AllowVerdict()
	{
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllowVerdictHandle));
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("dataVerdictWithPassBytes:peekBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict DataVerdict(nuint passBytes, nuint peekBytes)
	{
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_nuint_nuint(class_ptr, selDataVerdictWithPassBytes_PeekBytes_Handle, passBytes, peekBytes));
	}

	[Export("dropVerdict")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict DropVerdict()
	{
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend(class_ptr, selDropVerdictHandle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("needRulesVerdict")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict NeedRulesVerdict()
	{
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedRulesVerdictHandle));
	}

	[Export("pauseVerdict")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict PauseVerdict()
	{
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend(class_ptr, selPauseVerdictHandle));
	}

	[Export("remediateVerdictWithRemediationURLMapKey:remediationButtonTextMapKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEFilterDataVerdict RemediateVerdict(string? remediationUrlMapKey, string? remediationButtonTextMapKey)
	{
		IntPtr arg = NSString.CreateNative(remediationUrlMapKey);
		IntPtr arg2 = NSString.CreateNative(remediationButtonTextMapKey);
		NEFilterDataVerdict nSObject = Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRemediateVerdictWithRemediationURLMapKey_RemediationButtonTextMapKey_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSProcessInfo", true)]
public class NSProcessInfo : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveThermalStateDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ThermalStateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveThermalStateDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ThermalStateDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveProcessorCount = "activeProcessorCount";

	private static readonly IntPtr selActiveProcessorCountHandle = Selector.GetHandle("activeProcessorCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArguments = "arguments";

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticTerminationSupportEnabled = "automaticTerminationSupportEnabled";

	private static readonly IntPtr selAutomaticTerminationSupportEnabledHandle = Selector.GetHandle("automaticTerminationSupportEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginActivityWithOptions_Reason_ = "beginActivityWithOptions:reason:";

	private static readonly IntPtr selBeginActivityWithOptions_Reason_Handle = Selector.GetHandle("beginActivityWithOptions:reason:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableAutomaticTermination_ = "disableAutomaticTermination:";

	private static readonly IntPtr selDisableAutomaticTermination_Handle = Selector.GetHandle("disableAutomaticTermination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableSuddenTermination = "disableSuddenTermination";

	private static readonly IntPtr selDisableSuddenTerminationHandle = Selector.GetHandle("disableSuddenTermination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableAutomaticTermination_ = "enableAutomaticTermination:";

	private static readonly IntPtr selEnableAutomaticTermination_Handle = Selector.GetHandle("enableAutomaticTermination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableSuddenTermination = "enableSuddenTermination";

	private static readonly IntPtr selEnableSuddenTerminationHandle = Selector.GetHandle("enableSuddenTermination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndActivity_ = "endActivity:";

	private static readonly IntPtr selEndActivity_Handle = Selector.GetHandle("endActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnvironment = "environment";

	private static readonly IntPtr selEnvironmentHandle = Selector.GetHandle("environment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGloballyUniqueString = "globallyUniqueString";

	private static readonly IntPtr selGloballyUniqueStringHandle = Selector.GetHandle("globallyUniqueString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostName = "hostName";

	private static readonly IntPtr selHostNameHandle = Selector.GetHandle("hostName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMacCatalystApp = "isMacCatalystApp";

	private static readonly IntPtr selIsMacCatalystAppHandle = Selector.GetHandle("isMacCatalystApp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOperatingSystemAtLeastVersion_ = "isOperatingSystemAtLeastVersion:";

	private static readonly IntPtr selIsOperatingSystemAtLeastVersion_Handle = Selector.GetHandle("isOperatingSystemAtLeastVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperatingSystem = "operatingSystem";

	private static readonly IntPtr selOperatingSystemHandle = Selector.GetHandle("operatingSystem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperatingSystemName = "operatingSystemName";

	private static readonly IntPtr selOperatingSystemNameHandle = Selector.GetHandle("operatingSystemName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperatingSystemVersion = "operatingSystemVersion";

	private static readonly IntPtr selOperatingSystemVersionHandle = Selector.GetHandle("operatingSystemVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperatingSystemVersionString = "operatingSystemVersionString";

	private static readonly IntPtr selOperatingSystemVersionStringHandle = Selector.GetHandle("operatingSystemVersionString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformActivityWithOptions_Reason_UsingBlock_ = "performActivityWithOptions:reason:usingBlock:";

	private static readonly IntPtr selPerformActivityWithOptions_Reason_UsingBlock_Handle = Selector.GetHandle("performActivityWithOptions:reason:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicalMemory = "physicalMemory";

	private static readonly IntPtr selPhysicalMemoryHandle = Selector.GetHandle("physicalMemory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessIdentifier = "processIdentifier";

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessInfo = "processInfo";

	private static readonly IntPtr selProcessInfoHandle = Selector.GetHandle("processInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessName = "processName";

	private static readonly IntPtr selProcessNameHandle = Selector.GetHandle("processName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessorCount = "processorCount";

	private static readonly IntPtr selProcessorCountHandle = Selector.GetHandle("processorCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticTerminationSupportEnabled_ = "setAutomaticTerminationSupportEnabled:";

	private static readonly IntPtr selSetAutomaticTerminationSupportEnabled_Handle = Selector.GetHandle("setAutomaticTerminationSupportEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProcessName_ = "setProcessName:";

	private static readonly IntPtr selSetProcessName_Handle = Selector.GetHandle("setProcessName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemUptime = "systemUptime";

	private static readonly IntPtr selSystemUptimeHandle = Selector.GetHandle("systemUptime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThermalState = "thermalState";

	private static readonly IntPtr selThermalStateHandle = Selector.GetHandle("thermalState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSProcessInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThermalStateDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ActiveProcessorCount
	{
		[Export("activeProcessorCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selActiveProcessorCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selActiveProcessorCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Arguments
	{
		[Export("arguments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticTerminationSupportEnabled
	{
		[Export("automaticTerminationSupportEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticTerminationSupportEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticTerminationSupportEnabledHandle);
		}
		[Export("setAutomaticTerminationSupportEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTerminationSupportEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTerminationSupportEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Environment
	{
		[Export("environment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnvironmentHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnvironmentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GloballyUniqueString
	{
		[Export("globallyUniqueString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGloballyUniqueStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGloballyUniqueStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string HostName
	{
		[Export("hostName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool IsMacCatalystApplication
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isMacCatalystApp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMacCatalystAppHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMacCatalystAppHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'OperatingSystemVersion' or 'IsOperatingSystemAtLeastVersion' instead.")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'OperatingSystemVersion' or 'IsOperatingSystemAtLeastVersion' instead.")]
	public virtual nint OperatingSystem
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'OperatingSystemVersion' or 'IsOperatingSystemAtLeastVersion' instead.")]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'OperatingSystemVersion' or 'IsOperatingSystemAtLeastVersion' instead.")]
		[Export("operatingSystem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selOperatingSystemHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selOperatingSystemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'OperatingSystemVersionString' instead.")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'OperatingSystemVersionString' instead.")]
	public virtual string OperatingSystemName
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'OperatingSystemVersionString' instead.")]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'OperatingSystemVersionString' instead.")]
		[Export("operatingSystemName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatingSystemNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatingSystemNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual NSOperatingSystemVersion OperatingSystemVersion
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("operatingSystemVersion")]
		get
		{
			NSOperatingSystemVersion retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSOperatingSystemVersion_objc_msgSend_stret(out retval, base.Handle, selOperatingSystemVersionHandle);
			}
			else
			{
				Messaging.NSOperatingSystemVersion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOperatingSystemVersionHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OperatingSystemVersionString
	{
		[Export("operatingSystemVersionString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatingSystemVersionStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatingSystemVersionStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong PhysicalMemory
	{
		[Export("physicalMemory")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selPhysicalMemoryHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPhysicalMemoryHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ProcessIdentifier
	{
		[Export("processIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selProcessIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selProcessIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProcessInfo ProcessInfo
	{
		[Export("processInfo", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSProcessInfo>(Messaging.IntPtr_objc_msgSend(class_ptr, selProcessInfoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ProcessName
	{
		[Export("processName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProcessNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProcessNameHandle));
		}
		[Export("setProcessName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProcessName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProcessName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ProcessorCount
	{
		[Export("processorCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selProcessorCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selProcessorCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double SystemUptime
	{
		[Export("systemUptime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSystemUptimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSystemUptimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSProcessInfoThermalState ThermalState
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("thermalState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSProcessInfoThermalState)Messaging.Int64_objc_msgSend(base.Handle, selThermalStateHandle);
			}
			return (NSProcessInfoThermalState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selThermalStateHandle);
		}
	}

	[Field("NSProcessInfoThermalStateDidChangeNotification", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Advice("Use NSProcessInfo.Notifications.ObserveThermalStateDidChange helper method instead.")]
	public static NSString ThermalStateDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ThermalStateDidChangeNotification == null)
			{
				_ThermalStateDidChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProcessInfoThermalStateDidChangeNotification");
			}
			return _ThermalStateDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSProcessInfo()
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
	protected NSProcessInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSProcessInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginActivityWithOptions:reason:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject BeginActivity(NSActivityOptions options, string reason)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(reason);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selBeginActivityWithOptions_Reason_Handle, (ulong)options, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selBeginActivityWithOptions_Reason_Handle, (ulong)options, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("disableAutomaticTermination:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableAutomaticTermination(string reason)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(reason);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisableAutomaticTermination_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisableAutomaticTermination_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("disableSuddenTermination")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableSuddenTermination()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableSuddenTerminationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableSuddenTerminationHandle);
		}
	}

	[Export("enableAutomaticTermination:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableAutomaticTermination(string reason)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(reason);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnableAutomaticTermination_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnableAutomaticTermination_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("enableSuddenTermination")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableSuddenTermination()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableSuddenTerminationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableSuddenTerminationHandle);
		}
	}

	[Export("endActivity:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndActivity(NSObject activity)
	{
		if (activity == null)
		{
			throw new ArgumentNullException("activity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndActivity_Handle, activity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndActivity_Handle, activity.Handle);
		}
	}

	[Export("isOperatingSystemAtLeastVersion:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOperatingSystemAtLeastVersion(NSOperatingSystemVersion version)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_NSOperatingSystemVersion(base.Handle, selIsOperatingSystemAtLeastVersion_Handle, version);
		}
		return Messaging.bool_objc_msgSendSuper_NSOperatingSystemVersion(base.SuperHandle, selIsOperatingSystemAtLeastVersion_Handle, version);
	}

	[Export("performActivityWithOptions:reason:usingBlock:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformActivity(NSActivityOptions options, string reason, [BlockProxy(typeof(Trampolines.NIDAction))] Action runCode)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		if (runCode == null)
		{
			throw new ArgumentNullException("runCode");
		}
		IntPtr arg = NSString.CreateNative(reason);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, runCode);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr(base.Handle, selPerformActivityWithOptions_Reason_UsingBlock_Handle, (ulong)options, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(base.SuperHandle, selPerformActivityWithOptions_Reason_UsingBlock_Handle, (ulong)options, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}
}

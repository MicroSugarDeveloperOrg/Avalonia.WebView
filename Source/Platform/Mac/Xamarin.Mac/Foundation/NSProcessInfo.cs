using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSProcessInfo", true)]
public class NSProcessInfo : NSObject
{
	private static readonly IntPtr selProcessInfoHandle = Selector.GetHandle("processInfo");

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	private static readonly IntPtr selEnvironmentHandle = Selector.GetHandle("environment");

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	private static readonly IntPtr selGloballyUniqueStringHandle = Selector.GetHandle("globallyUniqueString");

	private static readonly IntPtr selProcessNameHandle = Selector.GetHandle("processName");

	private static readonly IntPtr selSetProcessName_Handle = Selector.GetHandle("setProcessName:");

	private static readonly IntPtr selHostNameHandle = Selector.GetHandle("hostName");

	private static readonly IntPtr selOperatingSystemHandle = Selector.GetHandle("operatingSystem");

	private static readonly IntPtr selOperatingSystemNameHandle = Selector.GetHandle("operatingSystemName");

	private static readonly IntPtr selOperatingSystemVersionStringHandle = Selector.GetHandle("operatingSystemVersionString");

	private static readonly IntPtr selPhysicalMemoryHandle = Selector.GetHandle("physicalMemory");

	private static readonly IntPtr selProcessorCountHandle = Selector.GetHandle("processorCount");

	private static readonly IntPtr selActiveProcessorCountHandle = Selector.GetHandle("activeProcessorCount");

	private static readonly IntPtr selSystemUptimeHandle = Selector.GetHandle("systemUptime");

	private static readonly IntPtr selAutomaticTerminationSupportEnabledHandle = Selector.GetHandle("automaticTerminationSupportEnabled");

	private static readonly IntPtr selSetAutomaticTerminationSupportEnabled_Handle = Selector.GetHandle("setAutomaticTerminationSupportEnabled:");

	private static readonly IntPtr selEnableSuddenTerminationHandle = Selector.GetHandle("enableSuddenTermination");

	private static readonly IntPtr selDisableSuddenTerminationHandle = Selector.GetHandle("disableSuddenTermination");

	private static readonly IntPtr selEnableAutomaticTermination_Handle = Selector.GetHandle("enableAutomaticTermination:");

	private static readonly IntPtr selDisableAutomaticTermination_Handle = Selector.GetHandle("disableAutomaticTermination:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSProcessInfo");

	private static object __mt_ProcessInfo_var_static;

	private object __mt_Environment_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSProcessInfo ProcessInfo
	{
		[Export("processInfo")]
		get
		{
			return (NSProcessInfo)(__mt_ProcessInfo_var_static = (NSProcessInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selProcessInfoHandle)));
		}
	}

	public virtual string[] Arguments
	{
		[Export("arguments")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentsHandle));
		}
	}

	public virtual NSDictionary Environment
	{
		[Export("environment")]
		get
		{
			return (NSDictionary)(__mt_Environment_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnvironmentHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEnvironmentHandle)))));
		}
	}

	public virtual int ProcessIdentifier
	{
		[Export("processIdentifier")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selProcessIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selProcessIdentifierHandle);
		}
	}

	public virtual string GloballyUniqueString
	{
		[Export("globallyUniqueString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGloballyUniqueStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGloballyUniqueStringHandle));
		}
	}

	public virtual string ProcessName
	{
		[Export("processName")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string HostName
	{
		[Export("hostName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostNameHandle));
		}
	}

	public virtual ulong OperatingSystem
	{
		[Export("operatingSystem")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selOperatingSystemHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOperatingSystemHandle);
		}
	}

	public virtual string OperatingSystemName
	{
		[Export("operatingSystemName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatingSystemNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatingSystemNameHandle));
		}
	}

	public virtual string OperatingSystemVersionString
	{
		[Export("operatingSystemVersionString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOperatingSystemVersionStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperatingSystemVersionStringHandle));
		}
	}

	public virtual ulong PhysicalMemory
	{
		[Export("physicalMemory")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selPhysicalMemoryHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPhysicalMemoryHandle);
		}
	}

	public virtual ulong ProcessorCount
	{
		[Export("processorCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selProcessorCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selProcessorCountHandle);
		}
	}

	public virtual ulong ActiveProcessorCount
	{
		[Export("activeProcessorCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selActiveProcessorCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selActiveProcessorCountHandle);
		}
	}

	public virtual double SystemUptime
	{
		[Export("systemUptime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSystemUptimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSystemUptimeHandle);
		}
	}

	public virtual bool AutomaticTerminationSupportEnabled
	{
		[Export("automaticTerminationSupportEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticTerminationSupportEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticTerminationSupportEnabledHandle);
		}
		[Export("setAutomaticTerminationSupportEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTerminationSupportEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTerminationSupportEnabled_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSProcessInfo()
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
	public NSProcessInfo(NSCoder coder)
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
	public NSProcessInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSProcessInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enableSuddenTermination")]
	public virtual void EnableSuddenTermination()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableSuddenTerminationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableSuddenTerminationHandle);
		}
	}

	[Export("disableSuddenTermination")]
	public virtual void DisableSuddenTermination()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableSuddenTerminationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableSuddenTerminationHandle);
		}
	}

	[Export("enableAutomaticTermination:")]
	public virtual void EnableAutomaticTermination(string reason)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(reason);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnableAutomaticTermination_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnableAutomaticTermination_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("disableAutomaticTermination:")]
	public virtual void DisableAutomaticTermination(string reason)
	{
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(reason);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisableAutomaticTermination_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisableAutomaticTermination_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Environment_var = null;
		}
	}
}

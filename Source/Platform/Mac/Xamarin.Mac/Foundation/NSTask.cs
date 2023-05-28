using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTask", true)]
public class NSTask : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidTerminate(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidTerminateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidTerminate(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidTerminateNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArguments = "arguments";

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDirectoryPath = "currentDirectoryPath";

	private static readonly IntPtr selCurrentDirectoryPathHandle = Selector.GetHandle("currentDirectoryPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnvironment = "environment";

	private static readonly IntPtr selEnvironmentHandle = Selector.GetHandle("environment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterrupt = "interrupt";

	private static readonly IntPtr selInterruptHandle = Selector.GetHandle("interrupt");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRunning = "isRunning";

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunch = "launch";

	private static readonly IntPtr selLaunchHandle = Selector.GetHandle("launch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchPath = "launchPath";

	private static readonly IntPtr selLaunchPathHandle = Selector.GetHandle("launchPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchedTaskWithLaunchPath_Arguments_ = "launchedTaskWithLaunchPath:arguments:";

	private static readonly IntPtr selLaunchedTaskWithLaunchPath_Arguments_Handle = Selector.GetHandle("launchedTaskWithLaunchPath:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessIdentifier = "processIdentifier";

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArguments_ = "setArguments:";

	private static readonly IntPtr selSetArguments_Handle = Selector.GetHandle("setArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentDirectoryPath_ = "setCurrentDirectoryPath:";

	private static readonly IntPtr selSetCurrentDirectoryPath_Handle = Selector.GetHandle("setCurrentDirectoryPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnvironment_ = "setEnvironment:";

	private static readonly IntPtr selSetEnvironment_Handle = Selector.GetHandle("setEnvironment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLaunchPath_ = "setLaunchPath:";

	private static readonly IntPtr selSetLaunchPath_Handle = Selector.GetHandle("setLaunchPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandardError_ = "setStandardError:";

	private static readonly IntPtr selSetStandardError_Handle = Selector.GetHandle("setStandardError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandardInput_ = "setStandardInput:";

	private static readonly IntPtr selSetStandardInput_Handle = Selector.GetHandle("setStandardInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandardOutput_ = "setStandardOutput:";

	private static readonly IntPtr selSetStandardOutput_Handle = Selector.GetHandle("setStandardOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardError = "standardError";

	private static readonly IntPtr selStandardErrorHandle = Selector.GetHandle("standardError");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardInput = "standardInput";

	private static readonly IntPtr selStandardInputHandle = Selector.GetHandle("standardInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardOutput = "standardOutput";

	private static readonly IntPtr selStandardOutputHandle = Selector.GetHandle("standardOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuspend = "suspend";

	private static readonly IntPtr selSuspendHandle = Selector.GetHandle("suspend");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerminate = "terminate";

	private static readonly IntPtr selTerminateHandle = Selector.GetHandle("terminate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerminationReason = "terminationReason";

	private static readonly IntPtr selTerminationReasonHandle = Selector.GetHandle("terminationReason");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerminationStatus = "terminationStatus";

	private static readonly IntPtr selTerminationStatusHandle = Selector.GetHandle("terminationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilExit = "waitUntilExit";

	private static readonly IntPtr selWaitUntilExitHandle = Selector.GetHandle("waitUntilExit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidTerminateNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSTaskDidTerminateNotification;

	public override IntPtr ClassHandle => class_ptr;

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
		[Export("setArguments:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetArguments_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetArguments_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	public virtual string CurrentDirectoryPath
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
		[Export("currentDirectoryPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryPathHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
		[Export("setCurrentDirectoryPath:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentDirectoryPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentDirectoryPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Environment
	{
		[Export("environment", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnvironmentHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnvironmentHandle));
		}
		[Export("setEnvironment:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEnvironment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEnvironment_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRunning
	{
		[Export("isRunning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRunningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	public virtual string LaunchPath
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
		[Export("launchPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchPathHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
		[Export("setLaunchPath:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLaunchPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLaunchPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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
	public virtual NSObject StandardError
	{
		[Export("standardError", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardErrorHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardErrorHandle));
		}
		[Export("setStandardError:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardError_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardError_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject StandardInput
	{
		[Export("standardInput", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardInputHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardInputHandle));
		}
		[Export("setStandardInput:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardInput_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardInput_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject StandardOutput
	{
		[Export("standardOutput", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardOutputHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardOutputHandle));
		}
		[Export("setStandardOutput:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardOutput_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardOutput_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTaskTerminationReason TerminationReason
	{
		[Export("terminationReason")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSTaskTerminationReason)Messaging.Int64_objc_msgSend(base.Handle, selTerminationReasonHandle);
			}
			return (NSTaskTerminationReason)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTerminationReasonHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TerminationStatus
	{
		[Export("terminationStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTerminationStatusHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTerminationStatusHandle);
		}
	}

	[Field("NSTaskDidTerminateNotification", "Foundation")]
	[Advice("Use NSTask.Notifications.ObserveDidTerminate helper method instead.")]
	public static NSString DidTerminateNotification
	{
		get
		{
			if (_DidTerminateNotification == null)
			{
				_DidTerminateNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTaskDidTerminateNotification");
			}
			return _DidTerminateNotification;
		}
	}

	[Field("NSTaskDidTerminateNotification", "Foundation")]
	public static NSString NSTaskDidTerminateNotification
	{
		get
		{
			if (_NSTaskDidTerminateNotification == null)
			{
				_NSTaskDidTerminateNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSTaskDidTerminateNotification");
			}
			return _NSTaskDidTerminateNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTask()
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
	protected NSTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("interrupt")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Interrupt()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInterruptHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInterruptHandle);
		}
	}

	[Export("launch")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Launch()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLaunchHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLaunchHandle);
		}
	}

	[Export("launchedTaskWithLaunchPath:arguments:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTask LaunchFromPath(string path, string[] arguments)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSArray nSArray = NSArray.FromStrings(arguments);
		NSTask nSObject = Runtime.GetNSObject<NSTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLaunchedTaskWithLaunchPath_Arguments_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("resume")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Resume()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResumeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
	}

	[Export("suspend")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Suspend()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSuspendHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuspendHandle);
	}

	[Export("terminate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Terminate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTerminateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTerminateHandle);
		}
	}

	[Export("waitUntilExit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitUntilExit()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilExitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilExitHandle);
		}
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTask", true)]
public class NSTask : NSObject
{
	private static readonly IntPtr selLaunchPathHandle = Selector.GetHandle("launchPath");

	private static readonly IntPtr selSetLaunchPath_Handle = Selector.GetHandle("setLaunchPath:");

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	private static readonly IntPtr selSetArguments_Handle = Selector.GetHandle("setArguments:");

	private static readonly IntPtr selEnvironmentHandle = Selector.GetHandle("environment");

	private static readonly IntPtr selSetEnvironment_Handle = Selector.GetHandle("setEnvironment:");

	private static readonly IntPtr selCurrentDirectoryPathHandle = Selector.GetHandle("currentDirectoryPath");

	private static readonly IntPtr selSetCurrentDirectoryPath_Handle = Selector.GetHandle("setCurrentDirectoryPath:");

	private static readonly IntPtr selStandardInputHandle = Selector.GetHandle("standardInput");

	private static readonly IntPtr selSetStandardInput_Handle = Selector.GetHandle("setStandardInput:");

	private static readonly IntPtr selStandardOutputHandle = Selector.GetHandle("standardOutput");

	private static readonly IntPtr selSetStandardOutput_Handle = Selector.GetHandle("setStandardOutput:");

	private static readonly IntPtr selStandardErrorHandle = Selector.GetHandle("standardError");

	private static readonly IntPtr selSetStandardError_Handle = Selector.GetHandle("setStandardError:");

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	private static readonly IntPtr selTerminationStatusHandle = Selector.GetHandle("terminationStatus");

	private static readonly IntPtr selTerminationReasonHandle = Selector.GetHandle("terminationReason");

	private static readonly IntPtr selLaunchHandle = Selector.GetHandle("launch");

	private static readonly IntPtr selInterruptHandle = Selector.GetHandle("interrupt");

	private static readonly IntPtr selTerminateHandle = Selector.GetHandle("terminate");

	private static readonly IntPtr selSuspendHandle = Selector.GetHandle("suspend");

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	private static readonly IntPtr selWaitUntilExitHandle = Selector.GetHandle("waitUntilExit");

	private static readonly IntPtr selLaunchedTaskWithLaunchPathArguments_Handle = Selector.GetHandle("launchedTaskWithLaunchPath:arguments:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTask");

	private object __mt_Environment_var;

	private object __mt_StandardInput_var;

	private object __mt_StandardOutput_var;

	private object __mt_StandardError_var;

	private static NSString _NSTaskDidTerminateNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string LaunchPath
	{
		[Export("launchPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchPathHandle));
		}
		[Export("setLaunchPath:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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
		[Export("setArguments:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (IsDirectBinding)
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

	public virtual NSDictionary Environment
	{
		[Export("environment")]
		get
		{
			return (NSDictionary)(__mt_Environment_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnvironmentHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEnvironmentHandle)))));
		}
		[Export("setEnvironment:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEnvironment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEnvironment_Handle, value.Handle);
			}
			__mt_Environment_var = value;
		}
	}

	public virtual string CurrentDirectoryPath
	{
		[Export("currentDirectoryPath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryPathHandle));
		}
		[Export("setCurrentDirectoryPath:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual NSObject StandardInput
	{
		[Export("standardInput")]
		get
		{
			return (NSObject)(__mt_StandardInput_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardInputHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardInputHandle))));
		}
		[Export("setStandardInput:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardInput_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardInput_Handle, value.Handle);
			}
			__mt_StandardInput_var = value;
		}
	}

	public virtual NSObject StandardOutput
	{
		[Export("standardOutput")]
		get
		{
			return (NSObject)(__mt_StandardOutput_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardOutputHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardOutputHandle))));
		}
		[Export("setStandardOutput:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardOutput_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardOutput_Handle, value.Handle);
			}
			__mt_StandardOutput_var = value;
		}
	}

	public virtual NSObject StandardError
	{
		[Export("standardError")]
		get
		{
			return (NSObject)(__mt_StandardError_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardErrorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardErrorHandle))));
		}
		[Export("setStandardError:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandardError_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandardError_Handle, value.Handle);
			}
			__mt_StandardError_var = value;
		}
	}

	public virtual bool IsRunning
	{
		[Export("isRunning")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRunningHandle);
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

	public virtual int TerminationStatus
	{
		[Export("terminationStatus")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTerminationStatusHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTerminationStatusHandle);
		}
	}

	public virtual NSTaskTerminationReason TerminationReason
	{
		[Export("terminationReason")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSTaskTerminationReason)Messaging.int_objc_msgSend(base.Handle, selTerminationReasonHandle);
			}
			return (NSTaskTerminationReason)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTerminationReasonHandle);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTask()
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
	public NSTask(NSCoder coder)
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
	public NSTask(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("launch")]
	public virtual void Launch()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLaunchHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLaunchHandle);
		}
	}

	[Export("interrupt")]
	public virtual void Interrupt()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInterruptHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInterruptHandle);
		}
	}

	[Export("terminate")]
	public virtual void Terminate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTerminateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTerminateHandle);
		}
	}

	[Export("suspend")]
	public virtual bool Suspend()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selSuspendHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuspendHandle);
	}

	[Export("resume")]
	public virtual bool Resume()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResumeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
	}

	[Export("waitUntilExit")]
	public virtual void WaitUntilExit()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitUntilExitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitUntilExitHandle);
		}
	}

	[Export("launchedTaskWithLaunchPath:arguments:")]
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
		NSTask result = (NSTask)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLaunchedTaskWithLaunchPathArguments_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Environment_var = null;
			__mt_StandardInput_var = null;
			__mt_StandardOutput_var = null;
			__mt_StandardError_var = null;
		}
	}
}

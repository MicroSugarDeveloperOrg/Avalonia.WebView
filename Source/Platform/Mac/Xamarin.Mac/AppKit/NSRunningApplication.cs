using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSRunningApplication", true)]
public class NSRunningApplication : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivateWithOptions_ = "activateWithOptions:";

	private static readonly IntPtr selActivateWithOptions_Handle = Selector.GetHandle("activateWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivationPolicy = "activationPolicy";

	private static readonly IntPtr selActivationPolicyHandle = Selector.GetHandle("activationPolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleIdentifier = "bundleIdentifier";

	private static readonly IntPtr selBundleIdentifierHandle = Selector.GetHandle("bundleIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBundleURL = "bundleURL";

	private static readonly IntPtr selBundleURLHandle = Selector.GetHandle("bundleURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentApplication = "currentApplication";

	private static readonly IntPtr selCurrentApplicationHandle = Selector.GetHandle("currentApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecutableArchitecture = "executableArchitecture";

	private static readonly IntPtr selExecutableArchitectureHandle = Selector.GetHandle("executableArchitecture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecutableURL = "executableURL";

	private static readonly IntPtr selExecutableURLHandle = Selector.GetHandle("executableURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForceTerminate = "forceTerminate";

	private static readonly IntPtr selForceTerminateHandle = Selector.GetHandle("forceTerminate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHide = "hide";

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIcon = "icon";

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinishedLaunching = "isFinishedLaunching";

	private static readonly IntPtr selIsFinishedLaunchingHandle = Selector.GetHandle("isFinishedLaunching");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTerminated = "isTerminated";

	private static readonly IntPtr selIsTerminatedHandle = Selector.GetHandle("isTerminated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchDate = "launchDate";

	private static readonly IntPtr selLaunchDateHandle = Selector.GetHandle("launchDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwnsMenuBar = "ownsMenuBar";

	private static readonly IntPtr selOwnsMenuBarHandle = Selector.GetHandle("ownsMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessIdentifier = "processIdentifier";

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunningApplicationWithProcessIdentifier_ = "runningApplicationWithProcessIdentifier:";

	private static readonly IntPtr selRunningApplicationWithProcessIdentifier_Handle = Selector.GetHandle("runningApplicationWithProcessIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunningApplicationsWithBundleIdentifier_ = "runningApplicationsWithBundleIdentifier:";

	private static readonly IntPtr selRunningApplicationsWithBundleIdentifier_Handle = Selector.GetHandle("runningApplicationsWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerminate = "terminate";

	private static readonly IntPtr selTerminateHandle = Selector.GetHandle("terminate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerminateAutomaticallyTerminableApplications = "terminateAutomaticallyTerminableApplications";

	private static readonly IntPtr selTerminateAutomaticallyTerminableApplicationsHandle = Selector.GetHandle("terminateAutomaticallyTerminableApplications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnhide = "unhide";

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRunningApplication");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSApplicationActivationPolicy ActivationPolicy
	{
		[Export("activationPolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSend(base.Handle, selActivationPolicyHandle);
			}
			return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selActivationPolicyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string BundleIdentifier
	{
		[Export("bundleIdentifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl BundleUrl
	{
		[Export("bundleURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public static NSRunningApplication CurrentApplication
	{
		[Export("currentApplication")]
		get
		{
			return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentApplicationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ExecutableArchitecture
	{
		[Export("executableArchitecture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selExecutableArchitectureHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selExecutableArchitectureHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl ExecutableUrl
	{
		[Export("executableURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutableURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutableURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FinishedLaunching
	{
		[Export("isFinishedLaunching")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedLaunchingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedLaunchingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Icon
	{
		[Export("icon", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LaunchDate
	{
		[Export("launchDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedName
	{
		[Export("localizedName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OwnsMenuBar
	{
		[Export("ownsMenuBar")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selOwnsMenuBarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selOwnsMenuBarHandle);
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
	public virtual bool Terminated
	{
		[Export("isTerminated")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTerminatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTerminatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRunningApplication()
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
	protected NSRunningApplication(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRunningApplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("activateWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Activate(NSApplicationActivationOptions options)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selActivateWithOptions_Handle, (ulong)options);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selActivateWithOptions_Handle, (ulong)options);
	}

	[Export("forceTerminate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ForceTerminate()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selForceTerminateHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selForceTerminateHandle);
	}

	[Export("runningApplicationWithProcessIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRunningApplication GetRunningApplication(int pid)
	{
		return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selRunningApplicationWithProcessIdentifier_Handle, pid));
	}

	[Export("runningApplicationsWithBundleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRunningApplication[] GetRunningApplications(string bundleIdentifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSRunningApplication[] result = NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRunningApplicationsWithBundleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hide()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHideHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHideHandle);
	}

	[Export("terminate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Terminate()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selTerminateHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTerminateHandle);
	}

	[Export("terminateAutomaticallyTerminableApplications")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TerminateAutomaticallyTerminableApplications()
	{
		Messaging.void_objc_msgSend(class_ptr, selTerminateAutomaticallyTerminableApplicationsHandle);
	}

	[Export("unhide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Unhide()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUnhideHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnhideHandle);
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRunningApplication", true)]
public class NSRunningApplication : NSObject
{
	private static readonly IntPtr selIsTerminatedHandle = Selector.GetHandle("isTerminated");

	private static readonly IntPtr selIsFinishedLaunchingHandle = Selector.GetHandle("isFinishedLaunching");

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	private static readonly IntPtr selActivationPolicyHandle = Selector.GetHandle("activationPolicy");

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	private static readonly IntPtr selBundleIdentifierHandle = Selector.GetHandle("bundleIdentifier");

	private static readonly IntPtr selBundleURLHandle = Selector.GetHandle("bundleURL");

	private static readonly IntPtr selExecutableURLHandle = Selector.GetHandle("executableURL");

	private static readonly IntPtr selProcessIdentifierHandle = Selector.GetHandle("processIdentifier");

	private static readonly IntPtr selLaunchDateHandle = Selector.GetHandle("launchDate");

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	private static readonly IntPtr selExecutableArchitectureHandle = Selector.GetHandle("executableArchitecture");

	private static readonly IntPtr selCurrentApplicationHandle = Selector.GetHandle("currentApplication");

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	private static readonly IntPtr selActivateWithOptions_Handle = Selector.GetHandle("activateWithOptions:");

	private static readonly IntPtr selTerminateHandle = Selector.GetHandle("terminate");

	private static readonly IntPtr selForceTerminateHandle = Selector.GetHandle("forceTerminate");

	private static readonly IntPtr selRunningApplicationsWithBundleIdentifier_Handle = Selector.GetHandle("runningApplicationsWithBundleIdentifier:");

	private static readonly IntPtr selRunningApplicationWithProcessIdentifier_Handle = Selector.GetHandle("runningApplicationWithProcessIdentifier:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRunningApplication");

	private object __mt_BundleUrl_var;

	private object __mt_ExecutableUrl_var;

	private object __mt_LaunchDate_var;

	private object __mt_Icon_var;

	private static object __mt_CurrentApplication_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool Terminated
	{
		[Export("isTerminated")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTerminatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTerminatedHandle);
		}
	}

	public virtual bool FinishedLaunching
	{
		[Export("isFinishedLaunching")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedLaunchingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedLaunchingHandle);
		}
	}

	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
	}

	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	public virtual NSApplicationActivationPolicy ActivationPolicy
	{
		[Export("activationPolicy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSend(base.Handle, selActivationPolicyHandle);
			}
			return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selActivationPolicyHandle);
		}
	}

	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	public virtual string BundleIdentifier
	{
		[Export("bundleIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleIdentifierHandle));
		}
	}

	public virtual NSUrl BundleUrl
	{
		[Export("bundleURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_BundleUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBundleURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBundleURLHandle)))));
		}
	}

	public virtual NSUrl ExecutableUrl
	{
		[Export("executableURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_ExecutableUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutableURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutableURLHandle)))));
		}
	}

	public virtual int ProcessIdentifier
	{
		[Export("processIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selProcessIdentifierHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selProcessIdentifierHandle);
		}
	}

	public virtual NSDate LaunchDate
	{
		[Export("launchDate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDate)(__mt_LaunchDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchDateHandle)))));
		}
	}

	public virtual NSImage Icon
	{
		[Export("icon")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Icon_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle)))));
		}
	}

	public virtual int ExecutableArchitecture
	{
		[Export("executableArchitecture")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selExecutableArchitectureHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selExecutableArchitectureHandle);
		}
	}

	[ThreadSafe]
	public static NSRunningApplication CurrentApplication
	{
		[Export("currentApplication")]
		get
		{
			return (NSRunningApplication)(__mt_CurrentApplication_var_static = (NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentApplicationHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRunningApplication()
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
	public NSRunningApplication(NSCoder coder)
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
	public NSRunningApplication(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRunningApplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("hide")]
	public virtual bool Hide()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHideHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHideHandle);
	}

	[Export("unhide")]
	public virtual bool Unhide()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selUnhideHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnhideHandle);
	}

	[Export("activateWithOptions:")]
	public virtual bool Activate(NSApplicationActivationOptions options)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selActivateWithOptions_Handle, (ulong)options);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selActivateWithOptions_Handle, (ulong)options);
	}

	[Export("terminate")]
	public virtual bool Terminate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selTerminateHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTerminateHandle);
	}

	[Export("forceTerminate")]
	public virtual bool ForceTerminate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selForceTerminateHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selForceTerminateHandle);
	}

	[Export("runningApplicationsWithBundleIdentifier:")]
	public static NSRunningApplication[] GetRunningApplications(string bundleIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSRunningApplication[] result = NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRunningApplicationsWithBundleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("runningApplicationWithProcessIdentifier:")]
	public static NSRunningApplication GetRunningApplication(int pid)
	{
		NSApplication.EnsureUIThread();
		return (NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(class_ptr, selRunningApplicationWithProcessIdentifier_Handle, pid));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BundleUrl_var = null;
			__mt_ExecutableUrl_var = null;
			__mt_LaunchDate_var = null;
			__mt_Icon_var = null;
		}
	}
}

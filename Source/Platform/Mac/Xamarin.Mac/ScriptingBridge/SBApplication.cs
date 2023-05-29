using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

[Register("SBApplication", true)]
public class SBApplication : SBObject
{
	[Register]
	private sealed class _SBApplicationDelegate : SBApplicationDelegate
	{
		internal SBApplicationError eventDidFailwithError;

		[Preserve(Conditional = true)]
		public override NSObject EventDidFailwithError(IntPtr appleEvent, NSError error)
		{
			return eventDidFailwithError?.Invoke(appleEvent, error);
		}
	}

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selLaunchFlagsHandle = Selector.GetHandle("launchFlags");

	private static readonly IntPtr selSetLaunchFlags_Handle = Selector.GetHandle("setLaunchFlags:");

	private static readonly IntPtr selSendModeHandle = Selector.GetHandle("sendMode");

	private static readonly IntPtr selSetSendMode_Handle = Selector.GetHandle("setSendMode:");

	private static readonly IntPtr selTimeoutHandle = Selector.GetHandle("timeout");

	private static readonly IntPtr selSetTimeout_Handle = Selector.GetHandle("setTimeout:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithProcessIdentifier_Handle = Selector.GetHandle("initWithProcessIdentifier:");

	private static readonly IntPtr selInitWithBundleIdentifier_Handle = Selector.GetHandle("initWithBundleIdentifier:");

	private static readonly IntPtr selApplicationWithBundleIdentifier_Handle = Selector.GetHandle("applicationWithBundleIdentifier:");

	private static readonly IntPtr selApplicationWithURL_Handle = Selector.GetHandle("applicationWithURL:");

	private static readonly IntPtr selApplicationWithProcessIdentifier_Handle = Selector.GetHandle("applicationWithProcessIdentifier:");

	private static readonly IntPtr selClassForScriptingClass_Handle = Selector.GetHandle("classForScriptingClass:");

	private static readonly IntPtr selActivateHandle = Selector.GetHandle("activate");

	private static readonly IntPtr class_ptr = Class.GetHandle("SBApplication");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public SBApplicationDelegate Delegate
	{
		get
		{
			return WeakDelegate as SBApplicationDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual LSLaunchFlags LaunchFlags
	{
		[Export("launchFlags")]
		get
		{
			if (IsDirectBinding)
			{
				return (LSLaunchFlags)Messaging.UInt32_objc_msgSend(base.Handle, selLaunchFlagsHandle);
			}
			return (LSLaunchFlags)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLaunchFlagsHandle);
		}
		[Export("setLaunchFlags:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetLaunchFlags_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetLaunchFlags_Handle, (uint)value);
			}
		}
	}

	public virtual AESendMode SendMode
	{
		[Export("sendMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (AESendMode)Messaging.int_objc_msgSend(base.Handle, selSendModeHandle);
			}
			return (AESendMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSendModeHandle);
		}
		[Export("setSendMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSendMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSendMode_Handle, (int)value);
			}
		}
	}

	public virtual int Timeout
	{
		[Export("timeout")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTimeoutHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTimeoutHandle);
		}
		[Export("setTimeout:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTimeout_Handle, value);
			}
		}
	}

	public SBApplicationError EventDidFailwithError
	{
		get
		{
			return EnsureSBApplicationDelegate().eventDidFailwithError;
		}
		set
		{
			EnsureSBApplicationDelegate().eventDidFailwithError = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SBApplication(NSCoder coder)
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
	public SBApplication(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public SBApplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	public SBApplication(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
		}
	}

	[Export("initWithProcessIdentifier:")]
	public SBApplication(int pid)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithProcessIdentifier_Handle, pid);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithProcessIdentifier_Handle, pid);
		}
	}

	[Export("initWithBundleIdentifier:")]
	public SBApplication(string ident)
		: base(NSObjectFlag.Empty)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		IntPtr arg = NSString.CreateNative(ident);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithBundleIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithBundleIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("applicationWithBundleIdentifier:")]
	public static SBApplication FromBundleIdentifier(string ident)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		IntPtr arg = NSString.CreateNative(ident);
		SBApplication result = (SBApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selApplicationWithBundleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("applicationWithURL:")]
	public static SBApplication FromURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (SBApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selApplicationWithURL_Handle, url.Handle));
	}

	[Export("applicationWithProcessIdentifier:")]
	public static SBApplication FromProcessIdentifier(int pid)
	{
		return (SBApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(class_ptr, selApplicationWithProcessIdentifier_Handle, pid));
	}

	[Export("classForScriptingClass:")]
	public virtual Class ClassForScripting(string className)
	{
		if (className == null)
		{
			throw new ArgumentNullException("className");
		}
		IntPtr arg = NSString.CreateNative(className);
		Class result = ((!IsDirectBinding) ? new Class(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassForScriptingClass_Handle, arg)) : new Class(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassForScriptingClass_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("activate")]
	public virtual void Activate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selActivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selActivateHandle);
		}
	}

	private _SBApplicationDelegate EnsureSBApplicationDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _SBApplicationDelegate))
		{
			nSObject = (WeakDelegate = new _SBApplicationDelegate());
		}
		return (_SBApplicationDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

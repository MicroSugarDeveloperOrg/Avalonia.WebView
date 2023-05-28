using System;
using System.ComponentModel;
using System.Reflection;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

[Register("SBApplication", true)]
public class SBApplication : SBObject, INSCoding, INativeObject, IDisposable
{
	[Register]
	internal class _SBApplicationDelegate : NSObject, ISBApplicationDelegate, INativeObject, IDisposable
	{
		internal SBApplicationError? eventDidFailwithError;

		public _SBApplicationDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("eventDidFail:withError:")]
		public NSObject EventDidFailwithError(IntPtr appleEvent, NSError error)
		{
			return eventDidFailwithError?.Invoke(appleEvent, error);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivate = "activate";

	private static readonly IntPtr selActivateHandle = Selector.GetHandle("activate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationWithBundleIdentifier_ = "applicationWithBundleIdentifier:";

	private static readonly IntPtr selApplicationWithBundleIdentifier_Handle = Selector.GetHandle("applicationWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationWithProcessIdentifier_ = "applicationWithProcessIdentifier:";

	private static readonly IntPtr selApplicationWithProcessIdentifier_Handle = Selector.GetHandle("applicationWithProcessIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationWithURL_ = "applicationWithURL:";

	private static readonly IntPtr selApplicationWithURL_Handle = Selector.GetHandle("applicationWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForScriptingClass_ = "classForScriptingClass:";

	private static readonly IntPtr selClassForScriptingClass_Handle = Selector.GetHandle("classForScriptingClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBundleIdentifier_ = "initWithBundleIdentifier:";

	private static readonly IntPtr selInitWithBundleIdentifier_Handle = Selector.GetHandle("initWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProcessIdentifier_ = "initWithProcessIdentifier:";

	private static readonly IntPtr selInitWithProcessIdentifier_Handle = Selector.GetHandle("initWithProcessIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRunning = "isRunning";

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchFlags = "launchFlags";

	private static readonly IntPtr selLaunchFlagsHandle = Selector.GetHandle("launchFlags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMode = "sendMode";

	private static readonly IntPtr selSendModeHandle = Selector.GetHandle("sendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLaunchFlags_ = "setLaunchFlags:";

	private static readonly IntPtr selSetLaunchFlags_Handle = Selector.GetHandle("setLaunchFlags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSendMode_ = "setSendMode:";

	private static readonly IntPtr selSetSendMode_Handle = Selector.GetHandle("setSendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeout_ = "setTimeout:";

	private static readonly IntPtr selSetTimeout_Handle = Selector.GetHandle("setTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeout = "timeout";

	private static readonly IntPtr selTimeoutHandle = Selector.GetHandle("timeout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SBApplication");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISBApplicationDelegate Delegate
	{
		get
		{
			return WeakDelegate as ISBApplicationDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
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
	public virtual LSLaunchFlags LaunchFlags
	{
		[Export("launchFlags")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (LSLaunchFlags)Messaging.UInt32_objc_msgSend(base.Handle, selLaunchFlagsHandle);
			}
			return (LSLaunchFlags)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLaunchFlagsHandle);
		}
		[Export("setLaunchFlags:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetLaunchFlags_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetLaunchFlags_Handle, (uint)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AESendMode SendMode
	{
		[Export("sendMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AESendMode)Messaging.int_objc_msgSend(base.Handle, selSendModeHandle);
			}
			return (AESendMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSendModeHandle);
		}
		[Export("setSendMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSendMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSendMode_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Timeout
	{
		[Export("timeout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selTimeoutHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTimeoutHandle);
		}
		[Export("setTimeout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetTimeout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle));
		}
		[Export("setDelegate:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(null, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_SBApplicationDelegate);

	public SBApplicationError? EventDidFailwithError
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

	public static T FromBundleIdentifier<T>(string ident) where T : SBApplication, new()
	{
		using SBApplication sBApplication = FromBundleIdentifier(ident);
		return (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { sBApplication.Handle }, null);
	}

	public static T FromURL<T>(NSUrl url) where T : SBApplication
	{
		using SBApplication sBApplication = FromURL(url);
		return (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { sBApplication.Handle }, null);
	}

	public static T FromProcessIdentifier<T>(int pid) where T : SBApplication
	{
		using SBApplication sBApplication = FromProcessIdentifier(pid);
		return (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { sBApplication.Handle }, null);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SBApplication(NSCoder coder)
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
	protected SBApplication(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SBApplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SBApplication(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("initWithProcessIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SBApplication(int pid)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithProcessIdentifier_Handle, pid), "initWithProcessIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithProcessIdentifier_Handle, pid), "initWithProcessIdentifier:");
		}
	}

	[Export("initWithBundleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SBApplication(string ident)
		: base(NSObjectFlag.Empty)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		IntPtr arg = NSString.CreateNative(ident);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithBundleIdentifier_Handle, arg), "initWithBundleIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithBundleIdentifier_Handle, arg), "initWithBundleIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("activate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Activate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selActivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selActivateHandle);
		}
	}

	[Export("classForScriptingClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class ClassForScripting(string className)
	{
		if (className == null)
		{
			throw new ArgumentNullException("className");
		}
		IntPtr arg = NSString.CreateNative(className);
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassForScriptingClass_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassForScriptingClass_Handle, arg));
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
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

	[Export("applicationWithBundleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SBApplication FromBundleIdentifier(string ident)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		IntPtr arg = NSString.CreateNative(ident);
		SBApplication nSObject = Runtime.GetNSObject<SBApplication>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selApplicationWithBundleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("applicationWithProcessIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SBApplication FromProcessIdentifier(int pid)
	{
		return Runtime.GetNSObject<SBApplication>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selApplicationWithProcessIdentifier_Handle, pid));
	}

	[Export("applicationWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SBApplication FromURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<SBApplication>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selApplicationWithURL_Handle, url.Handle));
	}

	internal virtual _SBApplicationDelegate CreateInternalEventDelegateType()
	{
		return new _SBApplicationDelegate();
	}

	internal _SBApplicationDelegate EnsureSBApplicationDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_SBApplicationDelegate sBApplicationDelegate = Delegate as _SBApplicationDelegate;
		if (sBApplicationDelegate == null)
		{
			sBApplicationDelegate = (_SBApplicationDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return sBApplicationDelegate;
	}
}

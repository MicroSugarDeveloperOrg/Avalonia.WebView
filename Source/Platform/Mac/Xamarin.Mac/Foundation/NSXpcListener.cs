using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSXPCListener", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
public class NSXpcListener : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnonymousListener = "anonymousListener";

	private static readonly IntPtr selAnonymousListenerHandle = Selector.GetHandle("anonymousListener");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndpoint = "endpoint";

	private static readonly IntPtr selEndpointHandle = Selector.GetHandle("endpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMachServiceName_ = "initWithMachServiceName:";

	private static readonly IntPtr selInitWithMachServiceName_Handle = Selector.GetHandle("initWithMachServiceName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceListener = "serviceListener";

	private static readonly IntPtr selServiceListenerHandle = Selector.GetHandle("serviceListener");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuspend = "suspend";

	private static readonly IntPtr selSuspendHandle = Selector.GetHandle("suspend");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSXPCListener");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSXpcListener AnonymousListener
	{
		[Export("anonymousListener")]
		get
		{
			return Runtime.GetNSObject<NSXpcListener>(Messaging.IntPtr_objc_msgSend(class_ptr, selAnonymousListenerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSXpcListenerDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSXpcListenerDelegate;
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
	public virtual NSXpcListenerEndpoint Endpoint
	{
		[Export("endpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSXpcListenerEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndpointHandle));
			}
			return Runtime.GetNSObject<NSXpcListenerEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSXpcListener ServiceListener
	{
		[Export("serviceListener")]
		get
		{
			return Runtime.GetNSObject<NSXpcListener>(Messaging.IntPtr_objc_msgSend(class_ptr, selServiceListenerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSXpcListener(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSXpcListener(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMachServiceName:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSXpcListener(string machServiceName)
		: base(NSObjectFlag.Empty)
	{
		if (machServiceName == null)
		{
			throw new ArgumentNullException("machServiceName");
		}
		IntPtr arg = NSString.CreateNative(machServiceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMachServiceName_Handle, arg), "initWithMachServiceName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMachServiceName_Handle, arg), "initWithMachServiceName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("resume")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
		}
	}

	[Export("suspend")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Suspend()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSuspendHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSuspendHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMachPort", true)]
public class NSMachPort : NSPort
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMachPort_ = "initWithMachPort:";

	private static readonly IntPtr selInitWithMachPort_Handle = Selector.GetHandle("initWithMachPort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMachPort_Options_ = "initWithMachPort:options:";

	private static readonly IntPtr selInitWithMachPort_Options_Handle = Selector.GetHandle("initWithMachPort:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMachPort = "machPort";

	private static readonly IntPtr selMachPortHandle = Selector.GetHandle("machPort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortWithMachPort_ = "portWithMachPort:";

	private static readonly IntPtr selPortWithMachPort_Handle = Selector.GetHandle("portWithMachPort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortWithMachPort_Options_ = "portWithMachPort:options:";

	private static readonly IntPtr selPortWithMachPort_Options_Handle = Selector.GetHandle("portWithMachPort:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromRunLoop_ForMode_ = "removeFromRunLoop:forMode:";

	private static readonly IntPtr selRemoveFromRunLoop_ForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleInRunLoop_ForMode_ = "scheduleInRunLoop:forMode:";

	private static readonly IntPtr selScheduleInRunLoop_ForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMachPort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSMachPortDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSMachPortDelegate;
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
	public virtual uint MachPort
	{
		[Export("machPort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMachPortHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMachPortHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSObject? WeakDelegate
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
	[Export("init")]
	public NSMachPort()
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
	public NSMachPort(NSCoder coder)
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
	protected NSMachPort(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMachPort(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMachPort:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMachPort(uint machPort)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selInitWithMachPort_Handle, machPort), "initWithMachPort:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selInitWithMachPort_Handle, machPort), "initWithMachPort:");
		}
	}

	[Export("initWithMachPort:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMachPort(uint machPort, NSMachPortRights options)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32_UInt64(base.Handle, selInitWithMachPort_Options_Handle, machPort, (ulong)options), "initWithMachPort:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt64(base.SuperHandle, selInitWithMachPort_Options_Handle, machPort, (ulong)options), "initWithMachPort:options:");
		}
	}

	[Export("portWithMachPort:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPort FromMachPort(uint port)
	{
		return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selPortWithMachPort_Handle, port));
	}

	[Export("portWithMachPort:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPort FromMachPort(uint port, NSMachPortRights options)
	{
		return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend_UInt32_UInt64(class_ptr, selPortWithMachPort_Options_Handle, port, (ulong)options));
	}

	[Export("removeFromRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override void RemoveFromRunLoop(NSRunLoop runLoop, NSString mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFromRunLoop_ForMode_Handle, runLoop.Handle, mode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFromRunLoop_ForMode_Handle, runLoop.Handle, mode.Handle);
		}
	}

	[Export("scheduleInRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override void ScheduleInRunLoop(NSRunLoop runLoop, NSString mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoop_ForMode_Handle, runLoop.Handle, mode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoop_ForMode_Handle, runLoop.Handle, mode.Handle);
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

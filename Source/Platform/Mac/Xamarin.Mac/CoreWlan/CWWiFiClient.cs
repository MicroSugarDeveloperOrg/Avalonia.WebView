using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWWiFiClient", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CWWiFiClient : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterface = "interface";

	private static readonly IntPtr selInterfaceHandle = Selector.GetHandle("interface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceNames = "interfaceNames";

	private static readonly IntPtr selInterfaceNamesHandle = Selector.GetHandle("interfaceNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceWithName_ = "interfaceWithName:";

	private static readonly IntPtr selInterfaceWithName_Handle = Selector.GetHandle("interfaceWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaces = "interfaces";

	private static readonly IntPtr selInterfacesHandle = Selector.GetHandle("interfaces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedWiFiClient = "sharedWiFiClient";

	private static readonly IntPtr selSharedWiFiClientHandle = Selector.GetHandle("sharedWiFiClient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartMonitoringEventWithType_Error_ = "startMonitoringEventWithType:error:";

	private static readonly IntPtr selStartMonitoringEventWithType_Error_Handle = Selector.GetHandle("startMonitoringEventWithType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopMonitoringAllEventsAndReturnError_ = "stopMonitoringAllEventsAndReturnError:";

	private static readonly IntPtr selStopMonitoringAllEventsAndReturnError_Handle = Selector.GetHandle("stopMonitoringAllEventsAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopMonitoringEventWithType_Error_ = "stopMonitoringEventWithType:error:";

	private static readonly IntPtr selStopMonitoringEventWithType_Error_Handle = Selector.GetHandle("stopMonitoringEventWithType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CWWiFiClient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICWEventDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			ICWEventDelegate iCWEventDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ICWEventDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<ICWEventDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iCWEventDelegate;
			return iCWEventDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
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
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] InterfaceNames
	{
		[Export("interfaceNames")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selInterfaceNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWInterface[] Interfaces
	{
		[Export("interfaces")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CWInterface>(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfacesHandle));
			}
			return NSArray.ArrayFromHandle<CWInterface>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfacesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWInterface MainInterface
	{
		[Export("interface")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfaceHandle));
			}
			return Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CWWiFiClient SharedWiFiClient
	{
		[Export("sharedWiFiClient")]
		get
		{
			return Runtime.GetNSObject<CWWiFiClient>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedWiFiClientHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWWiFiClient()
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
	protected CWWiFiClient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWWiFiClient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("interfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CWInterface FromName(string? name)
	{
		IntPtr arg = NSString.CreateNative(name);
		CWInterface result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInterfaceWithName_Handle, arg)) : Runtime.GetNSObject<CWInterface>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInterfaceWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("startMonitoringEventWithType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartMonitoringEvent(CWEventType type, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selStartMonitoringEventWithType_Error_Handle, (long)type, ref arg) : Messaging.bool_objc_msgSend_Int64_ref_IntPtr(base.Handle, selStartMonitoringEventWithType_Error_Handle, (long)type, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("stopMonitoringAllEventsAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StopMonitoringAllEvents(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selStopMonitoringAllEventsAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selStopMonitoringAllEventsAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("stopMonitoringEventWithType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StopMonitoringEvent(CWEventType type, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selStopMonitoringEventWithType_Error_Handle, (long)type, ref arg) : Messaging.bool_objc_msgSend_Int64_ref_IntPtr(base.Handle, selStopMonitoringEventWithType_Error_Handle, (long)type, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPortNameServer", true)]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
public class NSPortNameServer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortForName_ = "portForName:";

	private static readonly IntPtr selPortForName_Handle = Selector.GetHandle("portForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortForName_Host_ = "portForName:host:";

	private static readonly IntPtr selPortForName_Host_Handle = Selector.GetHandle("portForName:host:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterPort_Name_ = "registerPort:name:";

	private static readonly IntPtr selRegisterPort_Name_Handle = Selector.GetHandle("registerPort:name:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePortForName_ = "removePortForName:";

	private static readonly IntPtr selRemovePortForName_Handle = Selector.GetHandle("removePortForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemDefaultPortNameServer = "systemDefaultPortNameServer";

	private static readonly IntPtr selSystemDefaultPortNameServerHandle = Selector.GetHandle("systemDefaultPortNameServer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPortNameServer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPortNameServer SystemDefault
	{
		[Export("systemDefaultPortNameServer")]
		get
		{
			return Runtime.GetNSObject<NSPortNameServer>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemDefaultPortNameServerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPortNameServer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPortNameServer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("portForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort GetPort(string portName)
	{
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		NSPort result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPortForName_Handle, arg)) : Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPortForName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("portForName:host:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort GetPort(string portName, string hostName)
	{
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		if (hostName == null)
		{
			throw new ArgumentNullException("hostName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		IntPtr arg2 = NSString.CreateNative(hostName);
		NSPort result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPortForName_Host_Handle, arg, arg2)) : Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPortForName_Host_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("registerPort:name:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RegisterPort(NSPort port, string portName)
	{
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterPort_Name_Handle, port.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterPort_Name_Handle, port.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removePortForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemovePort(string portName)
	{
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemovePortForName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemovePortForName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}

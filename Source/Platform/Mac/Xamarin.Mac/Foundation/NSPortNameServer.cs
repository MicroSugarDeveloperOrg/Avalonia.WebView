using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPortNameServer", true)]
public class NSPortNameServer : NSObject
{
	private static readonly IntPtr selSystemDefaultPortNameServerHandle = Selector.GetHandle("systemDefaultPortNameServer");

	private static readonly IntPtr selPortForName_Handle = Selector.GetHandle("portForName:");

	private static readonly IntPtr selPortForNameHost_Handle = Selector.GetHandle("portForName:host:");

	private static readonly IntPtr selRegisterPortName_Handle = Selector.GetHandle("registerPort:name:");

	private static readonly IntPtr selRemovePortForName_Handle = Selector.GetHandle("removePortForName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPortNameServer");

	private static object __mt_SystemDefault_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSPortNameServer SystemDefault
	{
		[Export("systemDefaultPortNameServer")]
		get
		{
			return (NSPortNameServer)(__mt_SystemDefault_var_static = (NSPortNameServer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemDefaultPortNameServerHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPortNameServer(NSCoder coder)
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
	public NSPortNameServer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPortNameServer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("portForName:")]
	public virtual NSPort GetPort(string portName)
	{
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		NSPort result = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPortForName_Handle, arg))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPortForName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("portForName:host:")]
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
		NSPort result = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPortForNameHost_Handle, arg, arg2))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPortForNameHost_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("registerPort:name:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterPortName_Handle, port.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterPortName_Handle, port.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removePortForName:")]
	public virtual bool RemovePort(string portName)
	{
		if (portName == null)
		{
			throw new ArgumentNullException("portName");
		}
		IntPtr arg = NSString.CreateNative(portName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemovePortForName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemovePortForName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}

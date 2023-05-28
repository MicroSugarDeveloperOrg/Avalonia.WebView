using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NWHostEndpoint", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NWHostEndpoint : NWEndpoint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndpointWithHostname_Port_ = "endpointWithHostname:port:";

	private static readonly IntPtr selEndpointWithHostname_Port_Handle = Selector.GetHandle("endpointWithHostname:port:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostname = "hostname";

	private static readonly IntPtr selHostnameHandle = Selector.GetHandle("hostname");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPort = "port";

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NWHostEndpoint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Hostname
	{
		[Export("hostname")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostnameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostnameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Port
	{
		[Export("port")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPortHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortHandle));
		}
	}

	[Obsolete("Use the 'Create' method instead.")]
	public NWHostEndpoint()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NWHostEndpoint(NSCoder coder)
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
	protected NWHostEndpoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NWHostEndpoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("endpointWithHostname:port:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NWHostEndpoint Create(string hostname, string port)
	{
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		IntPtr arg = NSString.CreateNative(hostname);
		IntPtr arg2 = NSString.CreateNative(port);
		NWHostEndpoint nSObject = Runtime.GetNSObject<NWHostEndpoint>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selEndpointWithHostname_Port_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}
}

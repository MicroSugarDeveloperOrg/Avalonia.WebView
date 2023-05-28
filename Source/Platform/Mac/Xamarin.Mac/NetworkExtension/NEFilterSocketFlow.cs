using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEFilterSocketFlow", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEFilterSocketFlow : NEFilterFlow
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalEndpoint = "localEndpoint";

	private static readonly IntPtr selLocalEndpointHandle = Selector.GetHandle("localEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteEndpoint = "remoteEndpoint";

	private static readonly IntPtr selRemoteEndpointHandle = Selector.GetHandle("remoteEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSocketFamily_ = "setSocketFamily:";

	private static readonly IntPtr selSetSocketFamily_Handle = Selector.GetHandle("setSocketFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSocketFamily = "socketFamily";

	private static readonly IntPtr selSocketFamilyHandle = Selector.GetHandle("socketFamily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSocketProtocol = "socketProtocol";

	private static readonly IntPtr selSocketProtocolHandle = Selector.GetHandle("socketProtocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSocketType = "socketType";

	private static readonly IntPtr selSocketTypeHandle = Selector.GetHandle("socketType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEFilterSocketFlow");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint? LocalEndpoint
	{
		[Export("localEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint? RemoteEndpoint
	{
		[Export("remoteEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int SocketFamily
	{
		[Export("socketFamily")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSocketFamilyHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSocketFamilyHandle);
		}
		[Export("setSocketFamily:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSocketFamily_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSocketFamily_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int SocketProtocol
	{
		[Export("socketProtocol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSocketProtocolHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSocketProtocolHandle);
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int SocketType
	{
		[Export("socketType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSocketTypeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSocketTypeHandle);
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEFilterSocketFlow()
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
	public NEFilterSocketFlow(NSCoder coder)
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
	protected NEFilterSocketFlow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEFilterSocketFlow(IntPtr handle)
		: base(handle)
	{
	}
}

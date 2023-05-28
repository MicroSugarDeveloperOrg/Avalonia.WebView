using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBL2CAPChannel", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CBL2CapChannel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPSM = "PSM";

	private static readonly IntPtr selPSMHandle = Selector.GetHandle("PSM");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputStream = "inputStream";

	private static readonly IntPtr selInputStreamHandle = Selector.GetHandle("inputStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputStream = "outputStream";

	private static readonly IntPtr selOutputStreamHandle = Selector.GetHandle("outputStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPeer = "peer";

	private static readonly IntPtr selPeerHandle = Selector.GetHandle("peer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBL2CAPChannel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSInputStream InputStream
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("inputStream")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputStreamHandle));
			}
			return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputStreamHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSOutputStream OutputStream
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("outputStream")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOutputStream>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputStreamHandle));
			}
			return Runtime.GetNSObject<NSOutputStream>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputStreamHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual CBPeer Peer
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("peer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CBPeer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPeerHandle));
			}
			return Runtime.GetNSObject<CBPeer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPeerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual ushort Psm
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("PSM")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selPSMHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selPSMHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CBL2CapChannel()
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
	protected CBL2CapChannel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBL2CapChannel(IntPtr handle)
		: base(handle)
	{
	}
}

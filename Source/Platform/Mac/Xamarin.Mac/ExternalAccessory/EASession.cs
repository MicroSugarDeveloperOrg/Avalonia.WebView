using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

[Register("EASession", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class EASession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessory = "accessory";

	private static readonly IntPtr selAccessoryHandle = Selector.GetHandle("accessory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAccessory_ForProtocol_ = "initWithAccessory:forProtocol:";

	private static readonly IntPtr selInitWithAccessory_ForProtocol_Handle = Selector.GetHandle("initWithAccessory:forProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputStream = "inputStream";

	private static readonly IntPtr selInputStreamHandle = Selector.GetHandle("inputStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputStream = "outputStream";

	private static readonly IntPtr selOutputStreamHandle = Selector.GetHandle("outputStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocolString = "protocolString";

	private static readonly IntPtr selProtocolStringHandle = Selector.GetHandle("protocolString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EASession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EAAccessory? Accessory
	{
		[Export("accessory")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EAAccessory>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryHandle));
			}
			return Runtime.GetNSObject<EAAccessory>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSInputStream? InputStream
	{
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
	public virtual NSOutputStream? OutputStream
	{
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
	public virtual string? ProtocolString
	{
		[Export("protocolString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EASession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EASession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAccessory:forProtocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EASession(EAAccessory accessory, string protocol)
		: base(NSObjectFlag.Empty)
	{
		if (accessory == null)
		{
			throw new ArgumentNullException("accessory");
		}
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		IntPtr arg = NSString.CreateNative(protocol);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAccessory_ForProtocol_Handle, accessory.Handle, arg), "initWithAccessory:forProtocol:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAccessory_ForProtocol_Handle, accessory.Handle, arg), "initWithAccessory:forProtocol:");
		}
		NSString.ReleaseNative(arg);
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPortMessage", true)]
public class NSPortMessage : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSendPort_ReceivePort_Components_ = "initWithSendPort:receivePort:components:";

	private static readonly IntPtr selInitWithSendPort_ReceivePort_Components_Handle = Selector.GetHandle("initWithSendPort:receivePort:components:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMsgid = "msgid";

	private static readonly IntPtr selMsgidHandle = Selector.GetHandle("msgid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceivePort = "receivePort";

	private static readonly IntPtr selReceivePortHandle = Selector.GetHandle("receivePort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendBeforeDate_ = "sendBeforeDate:";

	private static readonly IntPtr selSendBeforeDate_Handle = Selector.GetHandle("sendBeforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPort = "sendPort";

	private static readonly IntPtr selSendPortHandle = Selector.GetHandle("sendPort");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMsgid_ = "setMsgid:";

	private static readonly IntPtr selSetMsgid_Handle = Selector.GetHandle("setMsgid:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPortMessage");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray Components
	{
		[Export("components")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint MsgId
	{
		[Export("msgid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMsgidHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMsgidHandle);
		}
		[Export("setMsgid:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMsgid_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMsgid_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort ReceivePort
	{
		[Export("receivePort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selReceivePortHandle));
			}
			return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReceivePortHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPort SendPort
	{
		[Export("sendPort")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selSendPortHandle));
			}
			return Runtime.GetNSObject<NSPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendPortHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPortMessage()
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
	protected NSPortMessage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPortMessage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSendPort:receivePort:components:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPortMessage(NSPort sendPort, NSPort recvPort, NSArray components)
		: base(NSObjectFlag.Empty)
	{
		if (sendPort == null)
		{
			throw new ArgumentNullException("sendPort");
		}
		if (recvPort == null)
		{
			throw new ArgumentNullException("recvPort");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSendPort_ReceivePort_Components_Handle, sendPort.Handle, recvPort.Handle, components.Handle), "initWithSendPort:receivePort:components:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSendPort_ReceivePort_Components_Handle, sendPort.Handle, recvPort.Handle, components.Handle), "initWithSendPort:receivePort:components:");
		}
	}

	[Export("sendBeforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendBefore(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSendBeforeDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendBeforeDate_Handle, date.Handle);
	}
}

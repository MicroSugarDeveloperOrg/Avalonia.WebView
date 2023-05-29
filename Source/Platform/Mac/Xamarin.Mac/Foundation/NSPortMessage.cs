using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPortMessage", true)]
public class NSPortMessage : NSObject
{
	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	private static readonly IntPtr selReceivePortHandle = Selector.GetHandle("receivePort");

	private static readonly IntPtr selSendPortHandle = Selector.GetHandle("sendPort");

	private static readonly IntPtr selMsgidHandle = Selector.GetHandle("msgid");

	private static readonly IntPtr selSetMsgid_Handle = Selector.GetHandle("setMsgid:");

	private static readonly IntPtr selInitWithSendPortReceivePortComponents_Handle = Selector.GetHandle("initWithSendPort:receivePort:components:");

	private static readonly IntPtr selSendBeforeDate_Handle = Selector.GetHandle("sendBeforeDate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPortMessage");

	private object __mt_Components_var;

	private object __mt_ReceivePort_var;

	private object __mt_SendPort_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSArray Components
	{
		[Export("components")]
		get
		{
			return (NSArray)(__mt_Components_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle)))));
		}
	}

	public virtual NSPort ReceivePort
	{
		[Export("receivePort")]
		get
		{
			return (NSPort)(__mt_ReceivePort_var = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReceivePortHandle))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReceivePortHandle)))));
		}
	}

	public virtual NSPort SendPort
	{
		[Export("sendPort")]
		get
		{
			return (NSPort)(__mt_SendPort_var = ((!IsDirectBinding) ? ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendPortHandle))) : ((NSPort)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSendPortHandle)))));
		}
	}

	public virtual uint MsgId
	{
		[Export("msgid")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMsgidHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMsgidHandle);
		}
		[Export("setMsgid:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMsgid_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMsgid_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPortMessage()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPortMessage(NSCoder coder)
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
	public NSPortMessage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPortMessage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSendPort:receivePort:components:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSendPortReceivePortComponents_Handle, sendPort.Handle, recvPort.Handle, components.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSendPortReceivePortComponents_Handle, sendPort.Handle, recvPort.Handle, components.Handle);
		}
	}

	[Export("sendBeforeDate:")]
	public virtual bool SendBefore(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSendBeforeDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendBeforeDate_Handle, date.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Components_var = null;
			__mt_ReceivePort_var = null;
			__mt_SendPort_var = null;
		}
	}
}

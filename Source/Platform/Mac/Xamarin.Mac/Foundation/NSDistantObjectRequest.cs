using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDistantObjectRequest", true)]
public class NSDistantObjectRequest : NSObject
{
	private static readonly IntPtr selConnectionHandle = Selector.GetHandle("connection");

	private static readonly IntPtr selConversationHandle = Selector.GetHandle("conversation");

	private static readonly IntPtr selInvocationHandle = Selector.GetHandle("invocation");

	private static readonly IntPtr selReplyWithException_Handle = Selector.GetHandle("replyWithException:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDistantObjectRequest");

	private object __mt_Connection_var;

	private object __mt_Conversation_var;

	private object __mt_Invocation_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSConnection Connection
	{
		[Export("connection")]
		get
		{
			return (NSConnection)(__mt_Connection_var = ((!IsDirectBinding) ? ((NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionHandle))) : ((NSConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionHandle)))));
		}
	}

	public virtual NSObject Conversation
	{
		[Export("conversation")]
		get
		{
			return (NSObject)(__mt_Conversation_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConversationHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConversationHandle))));
		}
	}

	public virtual NSInvocation Invocation
	{
		[Export("invocation")]
		get
		{
			return (NSInvocation)(__mt_Invocation_var = ((!IsDirectBinding) ? ((NSInvocation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvocationHandle))) : ((NSInvocation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInvocationHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSDistantObjectRequest(NSCoder coder)
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
	public NSDistantObjectRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDistantObjectRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replyWithException:")]
	public virtual void Reply(NSException exception)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplyWithException_Handle, exception?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplyWithException_Handle, exception?.Handle ?? IntPtr.Zero);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Connection_var = null;
			__mt_Conversation_var = null;
			__mt_Invocation_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDistantObjectRequest", true)]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
public class NSDistantObjectRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnection = "connection";

	private static readonly IntPtr selConnectionHandle = Selector.GetHandle("connection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversation = "conversation";

	private static readonly IntPtr selConversationHandle = Selector.GetHandle("conversation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvocation = "invocation";

	private static readonly IntPtr selInvocationHandle = Selector.GetHandle("invocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyWithException_ = "replyWithException:";

	private static readonly IntPtr selReplyWithException_Handle = Selector.GetHandle("replyWithException:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDistantObjectRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSConnection Connection
	{
		[Export("connection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionHandle));
			}
			return Runtime.GetNSObject<NSConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Conversation
	{
		[Export("conversation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConversationHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConversationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSInvocation Invocation
	{
		[Export("invocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSInvocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selInvocationHandle));
			}
			return Runtime.GetNSObject<NSInvocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDistantObjectRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDistantObjectRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replyWithException:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reply(NSException? exception)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplyWithException_Handle, exception?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplyWithException_Handle, exception?.Handle ?? IntPtr.Zero);
		}
	}
}

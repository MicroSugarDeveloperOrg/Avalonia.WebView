using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSConnectionDelegate", true)]
[Model]
public class NSConnectionDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSConnectionDelegate()
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
	public NSConnectionDelegate(NSCoder coder)
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
	public NSConnectionDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSConnectionDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("authenticateComponents:withData:")]
	public virtual bool AuthenticateComponents(NSArray components, NSData authenticationData)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("authenticationDataForComponents:")]
	public virtual NSData GetAuthenticationData(NSArray components)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:shouldMakeNewConnection:")]
	public virtual bool ShouldMakeNewConnection(NSConnection parentConnection, NSConnection newConnection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:handleRequest:")]
	public virtual bool HandleRequest(NSConnection connection, NSDistantObjectRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("createConversationForConnection:")]
	public virtual NSObject CreateConversation(NSConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("makeNewConnection:sender:")]
	public virtual bool AllowNewConnection(NSConnection newConnection, NSConnection parentConnection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

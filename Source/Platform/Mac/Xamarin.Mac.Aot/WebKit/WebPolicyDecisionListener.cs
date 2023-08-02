using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebPolicyDecisionListener", true)]
[Model]
public class WebPolicyDecisionListener : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebPolicyDecisionListener()
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
	public WebPolicyDecisionListener(NSCoder coder)
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
	public WebPolicyDecisionListener(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebPolicyDecisionListener(IntPtr handle)
		: base(handle)
	{
	}

	[Export("use")]
	public virtual void Use()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download")]
	public virtual void Download()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("ignore")]
	public virtual void Ignore()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

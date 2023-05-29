using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSNetServiceDelegate", true)]
[Model]
public class NSNetServiceDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceDelegate()
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
	public NSNetServiceDelegate(NSCoder coder)
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
	public NSNetServiceDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNetServiceDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("netServiceWillPublish:")]
	public virtual void WillPublish(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceDidPublish:")]
	public virtual void Published(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didNotPublish:")]
	public virtual void PublishFailure(NSNetService sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceWillResolve:")]
	public virtual void WillResolve(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceDidResolveAddress:")]
	public virtual void AddressResolved(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didNotResolve:")]
	public virtual void ResolveFailure(NSNetService sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceDidStop:")]
	public virtual void Stopped(NSNetService sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netService:didUpdateTXTRecordData:")]
	public virtual void UpdatedTxtRecordData(NSNetService sender, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

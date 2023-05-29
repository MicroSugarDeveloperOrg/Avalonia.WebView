using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMachPortDelegate", true)]
[Model]
public class NSMachPortDelegate : NSPortDelegate
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMachPortDelegate()
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
	public NSMachPortDelegate(NSCoder coder)
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
	public NSMachPortDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMachPortDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("handleMachMessage:")]
	public virtual void MachMessageReceived(IntPtr msgHeader)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

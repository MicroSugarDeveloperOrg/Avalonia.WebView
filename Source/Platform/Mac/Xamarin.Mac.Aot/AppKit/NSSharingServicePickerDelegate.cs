using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingServicePickerDelegate", true)]
[Model]
[MountainLion]
public class NSSharingServicePickerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServicePickerDelegate()
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
	public NSSharingServicePickerDelegate(NSCoder coder)
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
	public NSSharingServicePickerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSharingServicePickerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
	public virtual NSSharingService[] SharingServicesForItems(NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingServicePicker:delegateForSharingService:")]
	public virtual NSSharingServiceDelegate DelegateForSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingServicePicker:didChooseSharingService:")]
	public virtual void DidChooseSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService service)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

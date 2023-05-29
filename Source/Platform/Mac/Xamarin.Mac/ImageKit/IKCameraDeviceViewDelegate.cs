using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKCameraDeviceViewDelegate", true)]
[Model]
public class IKCameraDeviceViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKCameraDeviceViewDelegate()
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
	public IKCameraDeviceViewDelegate(NSCoder coder)
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
	public IKCameraDeviceViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKCameraDeviceViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cameraDeviceViewSelectionDidChange:")]
	public virtual void SelectionDidChange(IKCameraDeviceView cameraDeviceView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDeviceView:didEncounterError:")]
	public virtual void DidEncounterError(IKCameraDeviceView cameraDeviceView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

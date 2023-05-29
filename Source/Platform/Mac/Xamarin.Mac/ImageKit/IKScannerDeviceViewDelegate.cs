using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKScannerDeviceViewDelegate", true)]
[Model]
public class IKScannerDeviceViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKScannerDeviceViewDelegate()
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
	public IKScannerDeviceViewDelegate(NSCoder coder)
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
	public IKScannerDeviceViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKScannerDeviceViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scannerDeviceView:didScanToURL:fileData:error:")]
	public virtual void DidScan(IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDeviceView:didEncounterError:")]
	public virtual void DidEncounterError(IKScannerDeviceView scannerDeviceView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

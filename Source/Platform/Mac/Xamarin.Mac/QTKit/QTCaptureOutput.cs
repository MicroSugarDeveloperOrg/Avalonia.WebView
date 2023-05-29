using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureOutput", true)]
public class QTCaptureOutput : NSObject
{
	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureOutput");

	private object __mt_Connections_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTCaptureConnection[] Connections
	{
		[Export("connections")]
		get
		{
			return (QTCaptureConnection[])(__mt_Connections_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle)) : NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureOutput(NSCoder coder)
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
	public QTCaptureOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureOutput(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Connections_var = null;
		}
	}
}

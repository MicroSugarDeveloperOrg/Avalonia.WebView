using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureOutput", true)]
public class AVCaptureOutput : NSObject
{
	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	private static readonly IntPtr selConnectionWithMediaType_Handle = Selector.GetHandle("connectionWithMediaType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureOutput");

	private object __mt_Connections_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureConnection[] Connections
	{
		[Export("connections")]
		get
		{
			return (AVCaptureConnection[])(__mt_Connections_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle)) : NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureOutput(NSCoder coder)
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
	public AVCaptureOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("connectionWithMediaType:")]
	public virtual AVCaptureConnection ConnectionFromMediaType(NSString avMediaType)
	{
		if (avMediaType == null)
		{
			throw new ArgumentNullException("avMediaType");
		}
		if (IsDirectBinding)
		{
			return (AVCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConnectionWithMediaType_Handle, avMediaType.Handle));
		}
		return (AVCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConnectionWithMediaType_Handle, avMediaType.Handle));
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

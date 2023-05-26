using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureInput", true)]
public class AVCaptureInput : NSObject
{
	public static class Notifications
	{
		public static NSObject ObservePortFormatDescriptionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(PortFormatDescriptionDidChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selPortsHandle = Selector.GetHandle("ports");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureInput");

	private object __mt_Ports_var;

	private static NSString _PortFormatDescriptionDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureInputPort[] Ports
	{
		[Export("ports")]
		get
		{
			return (AVCaptureInputPort[])(__mt_Ports_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortsHandle)) : NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortsHandle))));
		}
	}

	[Field("AVCaptureInputPortFormatDescriptionDidChangeNotification", "AVFoundation")]
	public static NSString PortFormatDescriptionDidChangeNotification
	{
		get
		{
			if (_PortFormatDescriptionDidChangeNotification == null)
			{
				_PortFormatDescriptionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureInputPortFormatDescriptionDidChangeNotification");
			}
			return _PortFormatDescriptionDidChangeNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureInput(NSCoder coder)
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
	public AVCaptureInput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureInput(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Ports_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureVideoPreviewLayer", true)]
public class AVCaptureVideoPreviewLayer : CALayer
{
	private static readonly IntPtr selSessionHandle = Selector.GetHandle("session");

	private static readonly IntPtr selSetSession_Handle = Selector.GetHandle("setSession:");

	private static readonly IntPtr selConnectionHandle = Selector.GetHandle("connection");

	private static readonly IntPtr selSetSessionWithNoConnection_Handle = Selector.GetHandle("setSessionWithNoConnection:");

	private static readonly IntPtr selLayerWithSession_Handle = Selector.GetHandle("layerWithSession:");

	private static readonly IntPtr selInitWithSession_Handle = Selector.GetHandle("initWithSession:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureVideoPreviewLayer");

	private object __mt_Session_var;

	private object __mt_Connection_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureSession Session
	{
		[Export("session")]
		get
		{
			return (AVCaptureSession)(__mt_Session_var = ((!IsDirectBinding) ? ((AVCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionHandle))) : ((AVCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionHandle)))));
		}
		[Export("setSession:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSession_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSession_Handle, value.Handle);
			}
			__mt_Session_var = value;
		}
	}

	[Since(6, 0)]
	public virtual AVCaptureConnection Connection
	{
		[Export("connection")]
		get
		{
			return (AVCaptureConnection)(__mt_Connection_var = ((!IsDirectBinding) ? ((AVCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionHandle))) : ((AVCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureVideoPreviewLayer()
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
	public AVCaptureVideoPreviewLayer(NSCoder coder)
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
	public AVCaptureVideoPreviewLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureVideoPreviewLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setSessionWithNoConnection:")]
	public virtual void SetSessionWithNoConnection(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionWithNoConnection_Handle, session.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionWithNoConnection_Handle, session.Handle);
		}
	}

	[Export("layerWithSession:")]
	public static AVCaptureVideoPreviewLayer FromSession(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		return (AVCaptureVideoPreviewLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithSession_Handle, session.Handle));
	}

	[Export("initWithSession:")]
	public AVCaptureVideoPreviewLayer(AVCaptureSession session)
		: base(NSObjectFlag.Empty)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSession_Handle, session.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSession_Handle, session.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Session_var = null;
			__mt_Connection_var = null;
		}
	}
}

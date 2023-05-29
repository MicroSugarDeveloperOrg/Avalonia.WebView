using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureLayer", true)]
public class QTCaptureLayer : CALayer
{
	private static readonly IntPtr selSessionHandle = Selector.GetHandle("session");

	private static readonly IntPtr selSetSession_Handle = Selector.GetHandle("setSession:");

	private static readonly IntPtr selLayerWithSession_Handle = Selector.GetHandle("layerWithSession:");

	private static readonly IntPtr selInitWithSession_Handle = Selector.GetHandle("initWithSession:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureLayer");

	private object __mt_Session_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTCaptureSession Session
	{
		[Export("session")]
		get
		{
			return (QTCaptureSession)(__mt_Session_var = ((!IsDirectBinding) ? ((QTCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionHandle))) : ((QTCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionHandle)))));
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureLayer()
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
	public QTCaptureLayer(NSCoder coder)
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
	public QTCaptureLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layerWithSession:")]
	public static NSObject FromSession(QTCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithSession_Handle, session.Handle));
	}

	[Export("initWithSession:")]
	public QTCaptureLayer(QTCaptureSession session)
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
		}
	}
}

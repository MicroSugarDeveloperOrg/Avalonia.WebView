using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureView", true)]
public class QTCaptureView : NSView
{
	[Register]
	private sealed class _QTCaptureViewDelegate : QTCaptureViewDelegate
	{
		internal QTCaptureImageEvent willDisplayImage;

		[Preserve(Conditional = true)]
		public override CIImage WillDisplayImage(QTCaptureView view, CIImage image)
		{
			QTCaptureImageEvent qTCaptureImageEvent = willDisplayImage;
			if (qTCaptureImageEvent != null)
			{
				return qTCaptureImageEvent(view, image);
			}
			return image;
		}
	}

	private static readonly IntPtr selAvailableVideoPreviewConnectionsHandle = Selector.GetHandle("availableVideoPreviewConnections");

	private static readonly IntPtr selPreviewBoundsHandle = Selector.GetHandle("previewBounds");

	private static readonly IntPtr selCaptureSessionHandle = Selector.GetHandle("captureSession");

	private static readonly IntPtr selSetCaptureSession_Handle = Selector.GetHandle("setCaptureSession:");

	private static readonly IntPtr selVideoPreviewConnectionHandle = Selector.GetHandle("videoPreviewConnection");

	private static readonly IntPtr selSetVideoPreviewConnection_Handle = Selector.GetHandle("setVideoPreviewConnection:");

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	private static readonly IntPtr selPreservesAspectRatioHandle = Selector.GetHandle("preservesAspectRatio");

	private static readonly IntPtr selSetPreservesAspectRatio_Handle = Selector.GetHandle("setPreservesAspectRatio:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCaptureView");

	private object __mt_AvailableVideoPreviewConnections_var;

	private object __mt_CaptureSession_var;

	private object __mt_VideoPreviewConnection_var;

	private object __mt_FillColor_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTCaptureConnection[] AvailableVideoPreviewConnections
	{
		[Export("availableVideoPreviewConnections")]
		get
		{
			return (QTCaptureConnection[])(__mt_AvailableVideoPreviewConnections_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoPreviewConnectionsHandle)) : NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoPreviewConnectionsHandle))));
		}
	}

	public virtual CGRect PreviewBounds
	{
		[Export("previewBounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selPreviewBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreviewBoundsHandle);
			}
			return retval;
		}
	}

	public virtual QTCaptureSession CaptureSession
	{
		[Export("captureSession")]
		get
		{
			return (QTCaptureSession)(__mt_CaptureSession_var = ((!IsDirectBinding) ? ((QTCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCaptureSessionHandle))) : ((QTCaptureSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCaptureSessionHandle)))));
		}
		[Export("setCaptureSession:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCaptureSession_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCaptureSession_Handle, value.Handle);
			}
			__mt_CaptureSession_var = value;
		}
	}

	public virtual QTCaptureConnection VideoPreviewConnection
	{
		[Export("videoPreviewConnection")]
		get
		{
			return (QTCaptureConnection)(__mt_VideoPreviewConnection_var = ((!IsDirectBinding) ? ((QTCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoPreviewConnectionHandle))) : ((QTCaptureConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoPreviewConnectionHandle)))));
		}
		[Export("setVideoPreviewConnection:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoPreviewConnection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoPreviewConnection_Handle, value.Handle);
			}
			__mt_VideoPreviewConnection_var = value;
		}
	}

	public virtual NSColor FillColor
	{
		[Export("fillColor")]
		get
		{
			return (NSColor)(__mt_FillColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle)))));
		}
		[Export("setFillColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
			__mt_FillColor_var = value;
		}
	}

	public virtual bool PreservesAspectRatio
	{
		[Export("preservesAspectRatio")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesAspectRatioHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesAspectRatioHandle);
		}
		[Export("setPreservesAspectRatio:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesAspectRatio_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public QTCaptureViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as QTCaptureViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public QTCaptureImageEvent WillDisplayImage
	{
		get
		{
			return EnsureQTCaptureViewDelegate().willDisplayImage;
		}
		set
		{
			EnsureQTCaptureViewDelegate().willDisplayImage = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureView()
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
	public QTCaptureView(NSCoder coder)
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
	public QTCaptureView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureView(IntPtr handle)
		: base(handle)
	{
	}

	private _QTCaptureViewDelegate EnsureQTCaptureViewDelegate()
	{
		QTCaptureViewDelegate qTCaptureViewDelegate = Delegate;
		if (qTCaptureViewDelegate == null || !(qTCaptureViewDelegate is _QTCaptureViewDelegate))
		{
			qTCaptureViewDelegate = (Delegate = new _QTCaptureViewDelegate());
		}
		return (_QTCaptureViewDelegate)qTCaptureViewDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AvailableVideoPreviewConnections_var = null;
			__mt_CaptureSession_var = null;
			__mt_VideoPreviewConnection_var = null;
			__mt_FillColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

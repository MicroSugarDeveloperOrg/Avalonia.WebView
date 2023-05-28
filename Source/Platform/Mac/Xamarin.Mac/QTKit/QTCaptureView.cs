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
	internal class _QTCaptureViewDelegate : NSObject, IQTCaptureViewDelegate, INativeObject, IDisposable
	{
		internal QTCaptureImageEvent? willDisplayImage;

		public _QTCaptureViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("view:willDisplayImage:")]
		public CIImage WillDisplayImage(QTCaptureView view, CIImage image)
		{
			QTCaptureImageEvent qTCaptureImageEvent = willDisplayImage;
			if (qTCaptureImageEvent != null)
			{
				return qTCaptureImageEvent(view, image);
			}
			return image;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableVideoPreviewConnections = "availableVideoPreviewConnections";

	private static readonly IntPtr selAvailableVideoPreviewConnectionsHandle = Selector.GetHandle("availableVideoPreviewConnections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCaptureSession = "captureSession";

	private static readonly IntPtr selCaptureSessionHandle = Selector.GetHandle("captureSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillColor = "fillColor";

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesAspectRatio = "preservesAspectRatio";

	private static readonly IntPtr selPreservesAspectRatioHandle = Selector.GetHandle("preservesAspectRatio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewBounds = "previewBounds";

	private static readonly IntPtr selPreviewBoundsHandle = Selector.GetHandle("previewBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCaptureSession_ = "setCaptureSession:";

	private static readonly IntPtr selSetCaptureSession_Handle = Selector.GetHandle("setCaptureSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillColor_ = "setFillColor:";

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesAspectRatio_ = "setPreservesAspectRatio:";

	private static readonly IntPtr selSetPreservesAspectRatio_Handle = Selector.GetHandle("setPreservesAspectRatio:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoPreviewConnection_ = "setVideoPreviewConnection:";

	private static readonly IntPtr selSetVideoPreviewConnection_Handle = Selector.GetHandle("setVideoPreviewConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoPreviewConnection = "videoPreviewConnection";

	private static readonly IntPtr selVideoPreviewConnectionHandle = Selector.GetHandle("videoPreviewConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureConnection[] AvailableVideoPreviewConnections
	{
		[Export("availableVideoPreviewConnections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoPreviewConnectionsHandle));
			}
			return NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoPreviewConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureSession CaptureSession
	{
		[Export("captureSession")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTCaptureSession>(Messaging.IntPtr_objc_msgSend(base.Handle, selCaptureSessionHandle));
			}
			return Runtime.GetNSObject<QTCaptureSession>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCaptureSessionHandle));
		}
		[Export("setCaptureSession:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCaptureSession_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCaptureSession_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQTCaptureViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IQTCaptureViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor FillColor
	{
		[Export("fillColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle));
		}
		[Export("setFillColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesAspectRatio
	{
		[Export("preservesAspectRatio")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesAspectRatioHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesAspectRatioHandle);
		}
		[Export("setPreservesAspectRatio:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesAspectRatio_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesAspectRatio_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect PreviewBounds
	{
		[Export("previewBounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureConnection VideoPreviewConnection
	{
		[Export("videoPreviewConnection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoPreviewConnectionHandle));
			}
			return Runtime.GetNSObject<QTCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoPreviewConnectionHandle));
		}
		[Export("setVideoPreviewConnection:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoPreviewConnection_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoPreviewConnection_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_QTCaptureViewDelegate);

	public QTCaptureImageEvent? WillDisplayImage
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureView()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTCaptureView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	internal virtual _QTCaptureViewDelegate CreateInternalEventDelegateType()
	{
		return new _QTCaptureViewDelegate();
	}

	internal _QTCaptureViewDelegate EnsureQTCaptureViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_QTCaptureViewDelegate qTCaptureViewDelegate = Delegate as _QTCaptureViewDelegate;
		if (qTCaptureViewDelegate == null)
		{
			qTCaptureViewDelegate = (_QTCaptureViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return qTCaptureViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

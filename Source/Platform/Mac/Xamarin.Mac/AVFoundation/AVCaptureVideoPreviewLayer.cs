using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureVideoPreviewLayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureVideoPreviewLayer : CALayer
{
	public enum InitMode
	{
		WithConnection,
		[iOS(8, 0)]
		WithNoConnection
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCaptureDevicePointOfInterestForPoint_ = "captureDevicePointOfInterestForPoint:";

	private static readonly IntPtr selCaptureDevicePointOfInterestForPoint_Handle = Selector.GetHandle("captureDevicePointOfInterestForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnection = "connection";

	private static readonly IntPtr selConnectionHandle = Selector.GetHandle("connection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSession_ = "initWithSession:";

	private static readonly IntPtr selInitWithSession_Handle = Selector.GetHandle("initWithSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSessionWithNoConnection_ = "initWithSessionWithNoConnection:";

	private static readonly IntPtr selInitWithSessionWithNoConnection_Handle = Selector.GetHandle("initWithSessionWithNoConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerWithSession_ = "layerWithSession:";

	private static readonly IntPtr selLayerWithSession_Handle = Selector.GetHandle("layerWithSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerWithSessionWithNoConnection_ = "layerWithSessionWithNoConnection:";

	private static readonly IntPtr selLayerWithSessionWithNoConnection_Handle = Selector.GetHandle("layerWithSessionWithNoConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataOutputRectOfInterestForRect_ = "metadataOutputRectOfInterestForRect:";

	private static readonly IntPtr selMetadataOutputRectOfInterestForRect_Handle = Selector.GetHandle("metadataOutputRectOfInterestForRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointForCaptureDevicePointOfInterest_ = "pointForCaptureDevicePointOfInterest:";

	private static readonly IntPtr selPointForCaptureDevicePointOfInterest_Handle = Selector.GetHandle("pointForCaptureDevicePointOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForMetadataOutputRectOfInterest_ = "rectForMetadataOutputRectOfInterest:";

	private static readonly IntPtr selRectForMetadataOutputRectOfInterest_Handle = Selector.GetHandle("rectForMetadataOutputRectOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSession = "session";

	private static readonly IntPtr selSessionHandle = Selector.GetHandle("session");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSession_ = "setSession:";

	private static readonly IntPtr selSetSession_Handle = Selector.GetHandle("setSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSessionWithNoConnection_ = "setSessionWithNoConnection:";

	private static readonly IntPtr selSetSessionWithNoConnection_Handle = Selector.GetHandle("setSessionWithNoConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoGravity_ = "setVideoGravity:";

	private static readonly IntPtr selSetVideoGravity_Handle = Selector.GetHandle("setVideoGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformedMetadataObjectForMetadataObject_ = "transformedMetadataObjectForMetadataObject:";

	private static readonly IntPtr selTransformedMetadataObjectForMetadataObject_Handle = Selector.GetHandle("transformedMetadataObjectForMetadataObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoGravity = "videoGravity";

	private static readonly IntPtr selVideoGravityHandle = Selector.GetHandle("videoGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureVideoPreviewLayer");

	public AVLayerVideoGravity VideoGravity
	{
		get
		{
			return AVPlayerLayer.KeyToEnum(WeakVideoGravity);
		}
		set
		{
			WeakVideoGravity = AVPlayerLayer.EnumToKey(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureConnection? Connection
	{
		[Export("connection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionHandle));
			}
			return Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureSession? Session
	{
		[Export("session", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVCaptureSession>(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionHandle));
			}
			return Runtime.GetNSObject<AVCaptureSession>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionHandle));
		}
		[Export("setSession:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSession_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSession_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString WeakVideoGravity
	{
		[Export("videoGravity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoGravityHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoGravityHandle));
		}
		[Export("setVideoGravity:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoGravity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoGravity_Handle, value.Handle);
			}
		}
	}

	public AVCaptureVideoPreviewLayer(AVCaptureSession session, InitMode mode)
		: base(NSObjectFlag.Empty)
	{
		switch (mode)
		{
		case InitMode.WithConnection:
			InitializeHandle(InitWithConnection(session));
			break;
		case InitMode.WithNoConnection:
			InitializeHandle(InitWithNoConnection(session));
			break;
		default:
			throw new ArgumentException("mode");
		}
	}

	public AVCaptureVideoPreviewLayer(AVCaptureSession session)
		: this(session, InitMode.WithConnection)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureVideoPreviewLayer()
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
	public AVCaptureVideoPreviewLayer(NSCoder coder)
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
	protected AVCaptureVideoPreviewLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureVideoPreviewLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureDevicePointOfInterestForPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CaptureDevicePointOfInterestForPoint(CGPoint pointInLayer)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selCaptureDevicePointOfInterestForPoint_Handle, pointInLayer);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCaptureDevicePointOfInterestForPoint_Handle, pointInLayer);
	}

	[Export("layerWithSessionWithNoConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureVideoPreviewLayer CreateWithNoConnection(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		return Runtime.GetNSObject<AVCaptureVideoPreviewLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithSessionWithNoConnection_Handle, session.Handle));
	}

	[Export("layerWithSession:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVCaptureVideoPreviewLayer FromSession(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		return Runtime.GetNSObject<AVCaptureVideoPreviewLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithSession_Handle, session.Handle));
	}

	[Export("transformedMetadataObjectForMetadataObject:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataObject? GetTransformedMetadataObject(AVMetadataObject metadataObject)
	{
		if (metadataObject == null)
		{
			throw new ArgumentNullException("metadataObject");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMetadataObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTransformedMetadataObjectForMetadataObject_Handle, metadataObject.Handle));
		}
		return Runtime.GetNSObject<AVMetadataObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformedMetadataObjectForMetadataObject_Handle, metadataObject.Handle));
	}

	[Export("initWithSession:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithConnection(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSession_Handle, session.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSession_Handle, session.Handle);
	}

	[Export("initWithSessionWithNoConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNoConnection(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSessionWithNoConnection_Handle, session.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSessionWithNoConnection_Handle, session.Handle);
	}

	[Export("rectForMetadataOutputRectOfInterest:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect MapToLayerCoordinates(CGRect rectInMetadataOutputCoordinates)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selRectForMetadataOutputRectOfInterest_Handle, rectInMetadataOutputCoordinates);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selRectForMetadataOutputRectOfInterest_Handle, rectInMetadataOutputCoordinates);
		}
		return retval;
	}

	[Export("metadataOutputRectOfInterestForRect:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect MapToMetadataOutputCoordinates(CGRect rectInLayerCoordinates)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selMetadataOutputRectOfInterestForRect_Handle, rectInLayerCoordinates);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selMetadataOutputRectOfInterestForRect_Handle, rectInLayerCoordinates);
		}
		return retval;
	}

	[Export("pointForCaptureDevicePointOfInterest:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint PointForCaptureDevicePointOfInterest(CGPoint captureDevicePointOfInterest)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selPointForCaptureDevicePointOfInterest_Handle, captureDevicePointOfInterest);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selPointForCaptureDevicePointOfInterest_Handle, captureDevicePointOfInterest);
	}

	[Export("setSessionWithNoConnection:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSessionWithNoConnection(AVCaptureSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionWithNoConnection_Handle, session.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionWithNoConnection_Handle, session.Handle);
		}
	}
}

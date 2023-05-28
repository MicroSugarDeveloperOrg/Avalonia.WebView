using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureOutput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithMediaType_ = "connectionWithMediaType:";

	private static readonly IntPtr selConnectionWithMediaType_Handle = Selector.GetHandle("connectionWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnections = "connections";

	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataOutputRectOfInterestForRect_ = "metadataOutputRectOfInterestForRect:";

	private static readonly IntPtr selMetadataOutputRectOfInterestForRect_Handle = Selector.GetHandle("metadataOutputRectOfInterestForRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForMetadataOutputRectOfInterest_ = "rectForMetadataOutputRectOfInterest:";

	private static readonly IntPtr selRectForMetadataOutputRectOfInterest_Handle = Selector.GetHandle("rectForMetadataOutputRectOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformedMetadataObjectForMetadataObject_Connection_ = "transformedMetadataObjectForMetadataObject:connection:";

	private static readonly IntPtr selTransformedMetadataObjectForMetadataObject_Connection_Handle = Selector.GetHandle("transformedMetadataObjectForMetadataObject:connection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureConnection[] Connections
	{
		[Export("connections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("connectionWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureConnection? ConnectionFromMediaType(NSString avMediaType)
	{
		if (avMediaType == null)
		{
			throw new ArgumentNullException("avMediaType");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConnectionWithMediaType_Handle, avMediaType.Handle));
		}
		return Runtime.GetNSObject<AVCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConnectionWithMediaType_Handle, avMediaType.Handle));
	}

	[Export("metadataOutputRectOfInterestForRect:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetMetadataOutputRectOfInterestForRect(CGRect rectInOutputCoordinates)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selMetadataOutputRectOfInterestForRect_Handle, rectInOutputCoordinates);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selMetadataOutputRectOfInterestForRect_Handle, rectInOutputCoordinates);
		}
		return retval;
	}

	[Export("rectForMetadataOutputRectOfInterest:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectForMetadataOutputRectOfInterest(CGRect rectInMetadataOutputCoordinates)
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

	[Export("transformedMetadataObjectForMetadataObject:connection:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataObject? GetTransformedMetadataObject(AVMetadataObject metadataObject, AVCaptureConnection connection)
	{
		if (metadataObject == null)
		{
			throw new ArgumentNullException("metadataObject");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMetadataObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTransformedMetadataObjectForMetadataObject_Connection_Handle, metadataObject.Handle, connection.Handle));
		}
		return Runtime.GetNSObject<AVMetadataObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTransformedMetadataObjectForMetadataObject_Connection_Handle, metadataObject.Handle, connection.Handle));
	}
}

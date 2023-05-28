using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureScreenInput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureScreenInput : AVCaptureInput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapturesCursor = "capturesCursor";

	private static readonly IntPtr selCapturesCursorHandle = Selector.GetHandle("capturesCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapturesMouseClicks = "capturesMouseClicks";

	private static readonly IntPtr selCapturesMouseClicksHandle = Selector.GetHandle("capturesMouseClicks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCropRect = "cropRect";

	private static readonly IntPtr selCropRectHandle = Selector.GetHandle("cropRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDisplayID_ = "initWithDisplayID:";

	private static readonly IntPtr selInitWithDisplayID_Handle = Selector.GetHandle("initWithDisplayID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFrameDuration = "minFrameDuration";

	private static readonly IntPtr selMinFrameDurationHandle = Selector.GetHandle("minFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovesDuplicateFrames = "removesDuplicateFrames";

	private static readonly IntPtr selRemovesDuplicateFramesHandle = Selector.GetHandle("removesDuplicateFrames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactor = "scaleFactor";

	private static readonly IntPtr selScaleFactorHandle = Selector.GetHandle("scaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCapturesCursor_ = "setCapturesCursor:";

	private static readonly IntPtr selSetCapturesCursor_Handle = Selector.GetHandle("setCapturesCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCapturesMouseClicks_ = "setCapturesMouseClicks:";

	private static readonly IntPtr selSetCapturesMouseClicks_Handle = Selector.GetHandle("setCapturesMouseClicks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCropRect_ = "setCropRect:";

	private static readonly IntPtr selSetCropRect_Handle = Selector.GetHandle("setCropRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFrameDuration_ = "setMinFrameDuration:";

	private static readonly IntPtr selSetMinFrameDuration_Handle = Selector.GetHandle("setMinFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemovesDuplicateFrames_ = "setRemovesDuplicateFrames:";

	private static readonly IntPtr selSetRemovesDuplicateFrames_Handle = Selector.GetHandle("setRemovesDuplicateFrames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleFactor_ = "setScaleFactor:";

	private static readonly IntPtr selSetScaleFactor_Handle = Selector.GetHandle("setScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureScreenInput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CapturesCursor
	{
		[Export("capturesCursor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCapturesCursorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCapturesCursorHandle);
		}
		[Export("setCapturesCursor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCapturesCursor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCapturesCursor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CapturesMouseClicks
	{
		[Export("capturesMouseClicks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCapturesMouseClicksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCapturesMouseClicksHandle);
		}
		[Export("setCapturesMouseClicks:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCapturesMouseClicks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCapturesMouseClicks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CropRect
	{
		[Export("cropRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selCropRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCropRectHandle);
			}
			return retval;
		}
		[Export("setCropRect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetCropRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetCropRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime MinFrameDuration
	{
		[Export("minFrameDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMinFrameDurationHandle);
			}
			return retval;
		}
		[Export("setMinFrameDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMinFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Ignored since 10.10, if you want to get this behavior, use AVCaptureVideoDataOutput and compare the frame contents on your own code.")]
	public virtual bool RemovesDuplicateFrames
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Ignored since 10.10, if you want to get this behavior, use AVCaptureVideoDataOutput and compare the frame contents on your own code.")]
		[Export("removesDuplicateFrames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRemovesDuplicateFramesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRemovesDuplicateFramesHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Ignored since 10.10, if you want to get this behavior, use AVCaptureVideoDataOutput and compare the frame contents on your own code.")]
		[Export("setRemovesDuplicateFrames:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRemovesDuplicateFrames_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRemovesDuplicateFrames_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ScaleFactor
	{
		[Export("scaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScaleFactorHandle);
		}
		[Export("setScaleFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureScreenInput()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureScreenInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureScreenInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDisplayID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCaptureScreenInput(uint displayID)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selInitWithDisplayID_Handle, displayID), "initWithDisplayID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selInitWithDisplayID_Handle, displayID), "initWithDisplayID:");
		}
	}
}

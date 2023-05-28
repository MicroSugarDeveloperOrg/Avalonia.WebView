using System;
using System.ComponentModel;
using AppKit;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Register("AVPictureInPictureController", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class AVPictureInPictureController : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlayerLayer_ = "initWithPlayerLayer:";

	private static readonly IntPtr selInitWithPlayerLayer_Handle = Selector.GetHandle("initWithPlayerLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPictureInPictureActive = "isPictureInPictureActive";

	private static readonly IntPtr selIsPictureInPictureActiveHandle = Selector.GetHandle("isPictureInPictureActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPictureInPicturePossible = "isPictureInPicturePossible";

	private static readonly IntPtr selIsPictureInPicturePossibleHandle = Selector.GetHandle("isPictureInPicturePossible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPictureInPictureSupported = "isPictureInPictureSupported";

	private static readonly IntPtr selIsPictureInPictureSupportedHandle = Selector.GetHandle("isPictureInPictureSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPictureInPictureSuspended = "isPictureInPictureSuspended";

	private static readonly IntPtr selIsPictureInPictureSuspendedHandle = Selector.GetHandle("isPictureInPictureSuspended");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPictureInPictureButtonStartImage = "pictureInPictureButtonStartImage";

	private static readonly IntPtr selPictureInPictureButtonStartImageHandle = Selector.GetHandle("pictureInPictureButtonStartImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPictureInPictureButtonStopImage = "pictureInPictureButtonStopImage";

	private static readonly IntPtr selPictureInPictureButtonStopImageHandle = Selector.GetHandle("pictureInPictureButtonStopImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerLayer = "playerLayer";

	private static readonly IntPtr selPlayerLayerHandle = Selector.GetHandle("playerLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartPictureInPicture = "startPictureInPicture";

	private static readonly IntPtr selStartPictureInPictureHandle = Selector.GetHandle("startPictureInPicture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopPictureInPicture = "stopPictureInPicture";

	private static readonly IntPtr selStopPictureInPictureHandle = Selector.GetHandle("stopPictureInPicture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPictureInPictureController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVPictureInPictureControllerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IAVPictureInPictureControllerDelegate;
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
	public static bool IsPictureInPictureSupported
	{
		[Export("isPictureInPictureSupported")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsPictureInPictureSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PictureInPictureActive
	{
		[Export("isPictureInPictureActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPictureInPictureActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPictureInPictureActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSImage PictureInPictureButtonStartImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pictureInPictureButtonStartImage")]
		get
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPictureInPictureButtonStartImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSImage PictureInPictureButtonStopImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pictureInPictureButtonStopImage")]
		get
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPictureInPictureButtonStopImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PictureInPicturePossible
	{
		[Export("isPictureInPicturePossible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPictureInPicturePossibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPictureInPicturePossibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PictureInPictureSuspended
	{
		[Export("isPictureInPictureSuspended")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPictureInPictureSuspendedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPictureInPictureSuspendedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerLayer PlayerLayer
	{
		[Export("playerLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayerLayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerLayerHandle));
			}
			return Runtime.GetNSObject<AVPlayerLayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerLayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPictureInPictureController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPictureInPictureController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPlayerLayer:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPictureInPictureController(AVPlayerLayer playerLayer)
		: base(NSObjectFlag.Empty)
	{
		if (playerLayer == null)
		{
			throw new ArgumentNullException("playerLayer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlayerLayer_Handle, playerLayer.Handle), "initWithPlayerLayer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlayerLayer_Handle, playerLayer.Handle), "initWithPlayerLayer:");
		}
	}

	[Export("startPictureInPicture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartPictureInPicture()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartPictureInPictureHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartPictureInPictureHandle);
		}
	}

	[Export("stopPictureInPicture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopPictureInPicture()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopPictureInPictureHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopPictureInPictureHandle);
		}
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

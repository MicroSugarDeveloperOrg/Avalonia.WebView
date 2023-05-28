using System;
using System.ComponentModel;
using AppKit;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKTransition", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKTransition : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCrossFadeWithDuration_ = "crossFadeWithDuration:";

	private static readonly IntPtr selCrossFadeWithDuration_Handle = Selector.GetHandle("crossFadeWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoorsCloseHorizontalWithDuration_ = "doorsCloseHorizontalWithDuration:";

	private static readonly IntPtr selDoorsCloseHorizontalWithDuration_Handle = Selector.GetHandle("doorsCloseHorizontalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoorsCloseVerticalWithDuration_ = "doorsCloseVerticalWithDuration:";

	private static readonly IntPtr selDoorsCloseVerticalWithDuration_Handle = Selector.GetHandle("doorsCloseVerticalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoorsOpenHorizontalWithDuration_ = "doorsOpenHorizontalWithDuration:";

	private static readonly IntPtr selDoorsOpenHorizontalWithDuration_Handle = Selector.GetHandle("doorsOpenHorizontalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoorsOpenVerticalWithDuration_ = "doorsOpenVerticalWithDuration:";

	private static readonly IntPtr selDoorsOpenVerticalWithDuration_Handle = Selector.GetHandle("doorsOpenVerticalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoorwayWithDuration_ = "doorwayWithDuration:";

	private static readonly IntPtr selDoorwayWithDuration_Handle = Selector.GetHandle("doorwayWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeWithColor_Duration_ = "fadeWithColor:duration:";

	private static readonly IntPtr selFadeWithColor_Duration_Handle = Selector.GetHandle("fadeWithColor:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeWithDuration_ = "fadeWithDuration:";

	private static readonly IntPtr selFadeWithDuration_Handle = Selector.GetHandle("fadeWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipHorizontalWithDuration_ = "flipHorizontalWithDuration:";

	private static readonly IntPtr selFlipHorizontalWithDuration_Handle = Selector.GetHandle("flipHorizontalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipVerticalWithDuration_ = "flipVerticalWithDuration:";

	private static readonly IntPtr selFlipVerticalWithDuration_Handle = Selector.GetHandle("flipVerticalWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveInWithDirection_Duration_ = "moveInWithDirection:duration:";

	private static readonly IntPtr selMoveInWithDirection_Duration_Handle = Selector.GetHandle("moveInWithDirection:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPausesIncomingScene = "pausesIncomingScene";

	private static readonly IntPtr selPausesIncomingSceneHandle = Selector.GetHandle("pausesIncomingScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPausesOutgoingScene = "pausesOutgoingScene";

	private static readonly IntPtr selPausesOutgoingSceneHandle = Selector.GetHandle("pausesOutgoingScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPushWithDirection_Duration_ = "pushWithDirection:duration:";

	private static readonly IntPtr selPushWithDirection_Duration_Handle = Selector.GetHandle("pushWithDirection:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevealWithDirection_Duration_ = "revealWithDirection:duration:";

	private static readonly IntPtr selRevealWithDirection_Duration_Handle = Selector.GetHandle("revealWithDirection:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPausesIncomingScene_ = "setPausesIncomingScene:";

	private static readonly IntPtr selSetPausesIncomingScene_Handle = Selector.GetHandle("setPausesIncomingScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPausesOutgoingScene_ = "setPausesOutgoingScene:";

	private static readonly IntPtr selSetPausesOutgoingScene_Handle = Selector.GetHandle("setPausesOutgoingScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitionWithCIFilter_Duration_ = "transitionWithCIFilter:duration:";

	private static readonly IntPtr selTransitionWithCIFilter_Duration_Handle = Selector.GetHandle("transitionWithCIFilter:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTransition");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PausesIncomingScene
	{
		[Export("pausesIncomingScene")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPausesIncomingSceneHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPausesIncomingSceneHandle);
		}
		[Export("setPausesIncomingScene:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPausesIncomingScene_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPausesIncomingScene_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PausesOutgoingScene
	{
		[Export("pausesOutgoingScene")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPausesOutgoingSceneHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPausesOutgoingSceneHandle);
		}
		[Export("setPausesOutgoingScene:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPausesOutgoingScene_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPausesOutgoingScene_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKTransition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTransition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("crossFadeWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition CrossFadeWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selCrossFadeWithDuration_Handle, sec));
	}

	[Export("doorsCloseHorizontalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition DoorsCloseHorizontalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDoorsCloseHorizontalWithDuration_Handle, sec));
	}

	[Export("doorsCloseVerticalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition DoorsCloseVerticalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDoorsCloseVerticalWithDuration_Handle, sec));
	}

	[Export("doorsOpenHorizontalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition DoorsOpenHorizontalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDoorsOpenHorizontalWithDuration_Handle, sec));
	}

	[Export("doorsOpenVerticalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition DoorsOpenVerticalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDoorsOpenVerticalWithDuration_Handle, sec));
	}

	[Export("doorwayWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition DoorwayWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDoorwayWithDuration_Handle, sec));
	}

	[Export("fadeWithColor:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition FadeWithColor(NSColor color, double sec)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFadeWithColor_Duration_Handle, color.Handle, sec));
	}

	[Export("fadeWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition FadeWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFadeWithDuration_Handle, sec));
	}

	[Export("flipHorizontalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition FlipHorizontalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFlipHorizontalWithDuration_Handle, sec));
	}

	[Export("flipVerticalWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition FlipVerticalWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFlipVerticalWithDuration_Handle, sec));
	}

	[Export("moveInWithDirection:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition MoveInWithDirection(SKTransitionDirection direction, double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Int64_Double(class_ptr, selMoveInWithDirection_Duration_Handle, (long)direction, sec));
	}

	[Export("pushWithDirection:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition PushWithDirection(SKTransitionDirection direction, double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Int64_Double(class_ptr, selPushWithDirection_Duration_Handle, (long)direction, sec));
	}

	[Export("revealWithDirection:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition RevealWithDirection(SKTransitionDirection direction, double sec)
	{
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_Int64_Double(class_ptr, selRevealWithDirection_Duration_Handle, (long)direction, sec));
	}

	[Export("transitionWithCIFilter:duration:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTransition TransitionWithCIFilter(CIFilter filter, double sec)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		return Runtime.GetNSObject<SKTransition>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selTransitionWithCIFilter_Duration_Handle, filter.Handle, sec));
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVRouteDetector", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class AVRouteDetector : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveMultipleRoutesDetectedDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MultipleRoutesDetectedDidChange, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMultipleRoutesDetectedDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MultipleRoutesDetectedDidChange, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRouteDetectionEnabled = "isRouteDetectionEnabled";

	private static readonly IntPtr selIsRouteDetectionEnabledHandle = Selector.GetHandle("isRouteDetectionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultipleRoutesDetected = "multipleRoutesDetected";

	private static readonly IntPtr selMultipleRoutesDetectedHandle = Selector.GetHandle("multipleRoutesDetected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRouteDetectionEnabled_ = "setRouteDetectionEnabled:";

	private static readonly IntPtr selSetRouteDetectionEnabled_Handle = Selector.GetHandle("setRouteDetectionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVRouteDetector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MultipleRoutesDetectedDidChange;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MultipleRoutesDetected
	{
		[Export("multipleRoutesDetected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMultipleRoutesDetectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMultipleRoutesDetectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RouteDetectionEnabled
	{
		[Export("isRouteDetectionEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRouteDetectionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRouteDetectionEnabledHandle);
		}
		[Export("setRouteDetectionEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRouteDetectionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRouteDetectionEnabled_Handle, value);
			}
		}
	}

	[Field("AVRouteDetectorMultipleRoutesDetectedDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVRouteDetector.Notifications.ObserveMultipleRoutesDetectedDidChange helper method instead.")]
	public static NSString MultipleRoutesDetectedDidChange
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MultipleRoutesDetectedDidChange == null)
			{
				_MultipleRoutesDetectedDidChange = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVRouteDetectorMultipleRoutesDetectedDidChangeNotification");
			}
			return _MultipleRoutesDetectedDidChange;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVRouteDetector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVRouteDetector(IntPtr handle)
		: base(handle)
	{
	}
}

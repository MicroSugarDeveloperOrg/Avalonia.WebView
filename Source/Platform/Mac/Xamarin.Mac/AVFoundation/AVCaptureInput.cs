using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureInput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureInput : NSObject
{
	public static class Notifications
	{
		public static NSObject ObservePortFormatDescriptionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PortFormatDescriptionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePortFormatDescriptionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PortFormatDescriptionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPorts = "ports";

	private static readonly IntPtr selPortsHandle = Selector.GetHandle("ports");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PortFormatDescriptionDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureInputPort[] Ports
	{
		[Export("ports")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortsHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureInputPort>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortsHandle));
		}
	}

	[Field("AVCaptureInputPortFormatDescriptionDidChangeNotification", "AVFoundation")]
	[Advice("Use AVCaptureInput.Notifications.ObservePortFormatDescriptionDidChange helper method instead.")]
	public static NSString PortFormatDescriptionDidChangeNotification
	{
		get
		{
			if (_PortFormatDescriptionDidChangeNotification == null)
			{
				_PortFormatDescriptionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVCaptureInputPortFormatDescriptionDidChangeNotification");
			}
			return _PortFormatDescriptionDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureInput(IntPtr handle)
		: base(handle)
	{
	}
}

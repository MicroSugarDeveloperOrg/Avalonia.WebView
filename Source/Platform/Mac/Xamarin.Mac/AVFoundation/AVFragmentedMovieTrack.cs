using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVFragmentedMovieTrack", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class AVFragmentedMovieTrack : AVMovieTrack
{
	public new static class Notifications
	{
		public static NSObject ObserveSegmentsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SegmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSegmentsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SegmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTimeRangeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeRangeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTimeRangeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeRangeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVFragmentedMovieTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ATimeRangeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SegmentsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeRangeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TotalSampleDataLengthDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[Field("AVFragmentedMovieTrackTimeRangeDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static NSString ATimeRangeDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_ATimeRangeDidChangeNotification == null)
			{
				_ATimeRangeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieTrackTimeRangeDidChangeNotification");
			}
			return _ATimeRangeDidChangeNotification;
		}
	}

	[Field("AVFragmentedMovieTrackSegmentsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("Use AVFragmentedMovieTrack.Notifications.ObserveSegmentsDidChange helper method instead.")]
	public new static NSString SegmentsDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_SegmentsDidChangeNotification == null)
			{
				_SegmentsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieTrackSegmentsDidChangeNotification");
			}
			return _SegmentsDidChangeNotification;
		}
	}

	[Field("AVFragmentedMovieTrackTimeRangeDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("Use AVFragmentedMovieTrack.Notifications.ObserveTimeRangeDidChange helper method instead.")]
	public new static NSString TimeRangeDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_TimeRangeDidChangeNotification == null)
			{
				_TimeRangeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieTrackTimeRangeDidChangeNotification");
			}
			return _TimeRangeDidChangeNotification;
		}
	}

	[Field("AVFragmentedMovieTrackTotalSampleDataLengthDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use either 'AVFragmentedMovieTrackTimeRangeDidChangeNotification' or 'AVFragmentedMovieTrackSegmentsDidChangeNotification' instead. In either case, you can assume that the sender's 'TotalSampleDataLength' has changed.")]
	public static NSString TotalSampleDataLengthDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use either 'AVFragmentedMovieTrackTimeRangeDidChangeNotification' or 'AVFragmentedMovieTrackSegmentsDidChangeNotification' instead. In either case, you can assume that the sender's 'TotalSampleDataLength' has changed.")]
		get
		{
			if (_TotalSampleDataLengthDidChangeNotification == null)
			{
				_TotalSampleDataLengthDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieTrackTotalSampleDataLengthDidChangeNotification");
			}
			return _TotalSampleDataLengthDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVFragmentedMovieTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVFragmentedMovieTrack(IntPtr handle)
		: base(handle)
	{
	}
}
